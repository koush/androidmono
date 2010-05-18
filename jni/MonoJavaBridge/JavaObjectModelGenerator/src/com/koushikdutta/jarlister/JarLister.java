package com.koushikdutta.jarlister;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.lang.reflect.Constructor;
import java.lang.reflect.Field;
import java.lang.reflect.Member;
import java.lang.reflect.Method;
import java.lang.reflect.Modifier;
import java.net.URL;
import java.net.URLClassLoader;
import java.util.ArrayList;
import java.util.jar.JarEntry;
import java.util.jar.JarInputStream;

import org.xml.sax.SAXException;

import com.sun.org.apache.xml.internal.serialize.OutputFormat;
import com.sun.org.apache.xml.internal.serialize.XMLSerializer;

public class JarLister {
	
	static void dataElement(XMLSerializer ser, String name, Object o) throws SAXException
	{
		if (o == null)
			return;
		ser.startElement(name, null);
		String value = o.toString();
		ser.characters(value.toCharArray(), 0, value.length());
		ser.endElement(name);
	}
	
	static boolean isValidType(Class type, ArrayList<String> classes)
	{
		Class baseComp = getBaseComponentType(type);
		if (baseComp.isPrimitive())
			return true;
		return classes.contains(baseComp.getName());
	}
	
	static Class getBaseComponentType(Class clazz)
	{
		while (clazz.getComponentType() != null)
			clazz = clazz.getComponentType();
		return clazz;
	}
	
	static boolean hasValidTypes(Class returnType, Class[] parameterTypes, ArrayList<String> classes)
	{
		if (returnType != null && !isValidType(returnType, classes))
			return false;
		for (Class arg: parameterTypes)
		{
			if (!isValidType(arg, classes))
				return false;
		}
		return true;
	}
	
	static void outputMember(XMLSerializer wr, Member member, Class[] parameterTypes) throws SAXException
	{
		wr.startElement("Parameters", null);
		for (Class arg: parameterTypes)
		{
			dataElement(wr, "Parameter", cleanClassName(arg));
		}
		wr.endElement("Parameters");
	}
	
	static String cleanClassName(Class clazz)
	{
		if (clazz.isArray())
			return cleanClassName(clazz.getComponentType()) + "[]";
		String className = clazz.getName();
		if (className.equals("boolean"))
			return "bool";
		if (clazz.isMemberClass() && clazz.getEnclosingClass().isInterface())
			return className.replace('$', '_');
		return className.replace('$', '.');
	}
	
	static boolean parametersMatch(Class[] p1, Class[] p2)
	{
		if (p1.length != p2.length)
			return false;
		for (int i = 0; i < p1.length; i++)
		{
			if (!p1[i].equals(p2[i]))
				return false;
		}
		return true;
	}

	static boolean methodMatch(Method method, Method other)
	{
		if (!method.getName().equals(other.getName()))
			return false;
		return parametersMatch(method.getParameterTypes(), other.getParameterTypes());
	}
	
	static void collectMissingInterfaceMethods(ArrayList<Method> methods, Class clazz, Class iface) 
	{
		for (Method method: iface.getMethods())
		{
			try
			{
				clazz.getDeclaredMethod(method.getName(), method.getParameterTypes());
				continue;
			}
			catch (Exception e)
			{
			}
			try 
			{
				clazz.getSuperclass().getMethod(method.getName(), method.getParameterTypes());
				continue;
			}
			catch (Exception e) 
			{
			}
			boolean exists = false;
			for (Method other: methods)
			{
				if (exists = methodMatch(method, other))
					break;
			}
			if (!exists)
				methods.add(method);
		}
		//for (Class child: iface.getInterfaces())
		//	collectMissingInterfaceMethods(methods, clazz, child);
	}
	
	/**
	 * @param args
	 */
	public static void main(String[] args) {
		String androidSdk = "/Users/koush/src/android-sdk/platforms/android-7/android.jar";
		//String androidSdk = "/Users/koush/eclair/out/target/common/obj/JAVA_LIBRARIES/core_intermediates/classes.jar";
		try {
			JarInputStream input = new JarInputStream(new FileInputStream(androidSdk));
			
			JarEntry entry = input.getNextJarEntry();
			ArrayList<String> classes = new ArrayList<String>();
			while (entry != null)
			{
				try
				{
					String name = entry.getName();
					if (!name.endsWith(".class"))
						continue;
					name = name.substring(0, name.length() - 6).replace('/', '.');
					//System.out.println(name);
					classes.add(name);
				}
				finally
				{
					entry = input.getNextJarEntry();
				}
			}
			ClassLoader loader = URLClassLoader.newInstance(
				    new URL[] { new URL("file://" + androidSdk) },
				    ClassLoader.getSystemClassLoader()
				);
			FileOutputStream fos = new FileOutputStream("../androidsdk.xml");
			OutputFormat of = new OutputFormat();
			of.setIndenting(true);
			XMLSerializer wr = new XMLSerializer(fos, of);
			wr.startDocument();
			wr.startElement("ObjectModel", null);
			
			int count = 0;
			for (String className: classes)
			{
				//if (className.startsWith("SQLite"))
				//	continue;
				Class clazz = Class.forName(className, false, loader);
				Class superclass = clazz.getSuperclass();
				if (superclass != null && !classes.contains(superclass.getName()))
					continue;
				String neutralClassName = cleanClassName(clazz);
				
				if (Modifier.isPrivate(clazz.getModifiers()))
					continue;
				
				count++;
				wr.startElement("Type", null);
				dataElement(wr, "Abstract", Modifier.isAbstract(clazz.getModifiers()));
				dataElement(wr, "IsInnerClass", !Modifier.isStatic(clazz.getModifiers()) && clazz.getEnclosingClass() != null);
				dataElement(wr, "IsSealed", Modifier.isFinal(clazz.getModifiers()));
				dataElement(wr, "Scope", Modifier.isProtected(clazz.getModifiers()) ? "protected" : "public");
				dataElement(wr, "IsInterface", clazz.isInterface());
				dataElement(wr, "IsEnum", clazz.isEnum());
				dataElement(wr, "Name", neutralClassName);
				dataElement(wr, "NativeName", clazz.getName());
				
				Class enclosingClass = clazz.getEnclosingClass();
				if (enclosingClass != null)
				{
					Class root = enclosingClass.getSuperclass();
					Class found = null;
					while (root != null)
					{
						Class[] nestedClasses = root.getClasses();
						for (Class nestedClass: nestedClasses)
						{
							if (nestedClass.getSimpleName().equals(clazz.getSimpleName()))
							{
								found = nestedClass;
								break;
							}
						}
						if (found != null)
							break;
						root = root.getEnclosingClass();
					}
					if (found != null)
						dataElement(wr, "IsNew", true);
				}
				
				wr.startElement("Interfaces", null);
				for (Class iface: clazz.getInterfaces())
				{
					if (!classes.contains(iface.getName()))
						continue;
					dataElement(wr, "Interface", cleanClassName(iface));
				}
				wr.endElement("Interfaces");
				wr.startElement("Methods", null);
				
				if  (!clazz.isInterface())
				{
					ArrayList<Method> missingMethods = new ArrayList<Method>();
					for (Class iface: clazz.getInterfaces())
					{
						collectMissingInterfaceMethods(missingMethods, clazz, iface);
					}
					if (Modifier.isAbstract(clazz.getModifiers()))
					{
						for (Method method: missingMethods)
						{
							wr.startElement("Method", null);
							dataElement(wr, "Scope", "public");
							dataElement(wr, "Abstract", true);
							dataElement(wr, "Return", cleanClassName(method.getReturnType()));
							dataElement(wr, "Name", method.getName());
							outputMember(wr, method, method.getParameterTypes());
							wr.endElement("Method");						
						}
					}
					else
					{
						
					}
				}
				
				ArrayList<ArrayList<Method>> methodGroups = new ArrayList<ArrayList<Method>>();
				for (Method method: clazz.getDeclaredMethods())
				{
					if (Modifier.isPrivate(method.getModifiers()))
						continue;
					if (!Modifier.isPublic(method.getModifiers()) && !Modifier.isProtected(method.getModifiers()))
						continue;
					if (!hasValidTypes(method.getReturnType(), method.getParameterTypes(), classes))
						continue;
					if (Modifier.isFinal(clazz.getModifiers()) && Modifier.isProtected(method.getModifiers()))
						continue;
					
					// seriously bizarre. Buffer has a public abstract method isDirect which isn't supposed to be there.
					// All the child classes have this method too, also defined as abstract. causes issues.
					if (clazz.getCanonicalName().equals("java.nio.Buffer") && method.getName().equals("isDirect"))
						continue;
					
					ArrayList<Method> foundGroup = null;
					for (ArrayList<Method> group: methodGroups)
					{
						if (methodMatch(group.get(0), method))
						{
							foundGroup = group;
							break;
						}
					}
					if (foundGroup == null)
					{
						foundGroup = new ArrayList<Method>();
						methodGroups.add(foundGroup);
					}
					foundGroup.add(method);
				}
			
				ArrayList<Method> abstractScopeChanged = new ArrayList<Method>();
				for (ArrayList<Method> group: methodGroups)
				{
					Class[] parameterTypes = group.get(0).getParameterTypes();
					String methodName = group.get(0).getName();
					
					Method amethod = null;
					Method imethod = null;
					// hideoverrideimplement is the method on a parent class or interface that has the same parameters and name
					Method hideoverrideimplement = null;
					// check superclass for abstract methods that need to be implemented.
					{
						Class root = superclass;
						while (root != null)
						{
							try
							{
								Method possible = null;
								try
								{
									possible = root.getDeclaredMethod(methodName, parameterTypes);
								}
								catch (Exception ex)
								{
								}
								
								if (root.getSuperclass() == null && possible == null)
								{
									possible = superclass.getMethod(methodName, parameterTypes);
								}
								if (possible == null)
								{
									throw new NoSuchMethodException();
								}
								
								if (Modifier.isPublic(possible.getModifiers()) || Modifier.isProtected(possible.getModifiers()) || Modifier.isPrivate(possible.getModifiers()))
								{
									hideoverrideimplement = possible;
									if (Modifier.isStatic(possible.getModifiers()))
										break;
									if (Modifier.isAbstract(possible.getModifiers()))
									{
										amethod = possible;
										break;
									}
									// ok, we found a matching method sig. But let's verify that this match
									// isn't actually a method that implements an abstract method via 
									// a bridge method. (my brain hurts)
									root = root.getSuperclass();
									Method grandParentMethod = null;
									while (root != null)
									{
										try
										{
											grandParentMethod = root.getDeclaredMethod(methodName, parameterTypes);
											break;
										}
										catch (NoSuchMethodException ex)
										{
										}
										root = root.getSuperclass();
									}
									// if the grandparent class method is abstract and isn't an EXACT match, that means that a bridge/synthetic
									// method was used to implement it via the possible method.
									if (grandParentMethod == null || !Modifier.isAbstract(grandParentMethod.getModifiers()) || grandParentMethod.getReturnType().equals(possible.getReturnType()))
										break;
									
									// exact abstract match was found. now find which synthetic method implemented this up the superclass
									// chain.
									Method[] allMethods = possible.getDeclaringClass().getDeclaredMethods();
									for(Method m: allMethods)
									{
										if (methodMatch(m, grandParentMethod) && m.getReturnType().equals(grandParentMethod.getReturnType()))
										{
											hideoverrideimplement = m;
											break;
										}
									}
									if (hideoverrideimplement == null)
										throw new Exception("bad state");
									break;
								}
							}
							catch (NoSuchMethodException ex)
							{
							}
							root = root.getSuperclass();
						}
					}
					// check interfaces on this class that need to be implemented.
					for(Class root: clazz.getInterfaces())
					{
						try
						{
							Method method = root.getMethod(methodName, parameterTypes);
							// if this class is an interface, then one interface method is hiding another.
							// otherwise, it is a method that needs to be implemented.
							if (clazz.isInterface())
								hideoverrideimplement = method;
							else
								imethod = method;
							break;
						}
						catch (NoSuchMethodException ex)
						{
						}
					}
					// I'm 99% sure this scenario is impossible in Java... interface and abstract method implementation requirement
					// that has different return types. Though .NET does support it via explicit interface implementations.
					// Not worrying about implementing it right now.
					if (amethod != null && imethod != null && !amethod.getReturnType().equals(imethod.getReturnType()))
						throw new Exception("Found abstract method and interface method that both need to be implemented and have differing return types!");
					
					// now that we know the contractual requirements of this method group, let's output the data!
					for (Method method: group)
					{
						// if it's a synthetic method, see if we really even need to emit it.
						// we only really need to emit it if it fulfills a contractual requirement.
						if (method.isSynthetic())
						{
							boolean required = false;
							if (amethod != null && method.getReturnType().equals(amethod.getReturnType()))
								required = true;
							else if (imethod != null && method.getReturnType().equals(imethod.getReturnType()))
								required = true;
							
							// search for explicit method implementation
							if (!required)
							{
								Method found = null;
								for (Class iface: clazz.getInterfaces())
								{
									try
									{
										Method poss; 
										if ((poss = iface.getMethod(methodName, parameterTypes)).getReturnType().equals(method.getReturnType()))
										{
											found = poss;
											break;
										}
									}
									catch (Exception ex)
									{
									}
								}
								if (found != null)
								{
									String name = cleanClassName(found.getDeclaringClass()) + "." + methodName;
									//System.out.println(name);
									wr.startElement("Method", null);
									dataElement(wr, "Scope", "");
									dataElement(wr, "Return", cleanClassName(method.getReturnType()));
									dataElement(wr, "Name", name);
									outputMember(wr, method, method.getParameterTypes());
									wr.endElement("Method");		
									continue;
								}
							}
							
							if (!required)
								continue;
							//System.out.println("Required synthetic method: " + method);
						}
						
						// Ok, now let's do this!
						// First off, if this method has an abstract requirement, we must expose only that one.
						// Unless of course there is an interface which we must implement (explicitly)
						boolean implementsInterface = imethod != null && method.getReturnType().equals(imethod.getReturnType());
						boolean implementsAbstract = amethod != null && method.getReturnType().equals(amethod.getReturnType());
						// note that you can't override an interface
						boolean overrides = hideoverrideimplement != null && method.getReturnType().equals(hideoverrideimplement.getReturnType()) && !hideoverrideimplement.getDeclaringClass().isInterface();
						//overrides |= implementsAbstract;
						
						// but you CAN override an interface if it the method is implicitly abstract in a superclass
						if (!overrides && hideoverrideimplement != null && superclass != null && hideoverrideimplement.getDeclaringClass().isInterface())
						{
							try
							{
								overrides = superclass.getMethod(methodName, parameterTypes).equals(hideoverrideimplement);
							}
							catch (NoSuchMethodException ex)
							{
							}
						}
						
						String scope = Modifier.isPublic(method.getModifiers()) ? "public" : "protected";
						boolean scopeChange = overrides && Modifier.isPublic(method.getModifiers()) != Modifier.isPublic(hideoverrideimplement.getModifiers());

						// note if the implementation of an abstract method changes the scope of the method.
						// the only way to fix this is by using a proxy class to shim it.
						// ie, A.Foo is abstract protected.
						// B.Foo is public virtual
						// fix is: B inherits from BShim, which has a protected virtual BShim.Foo.
						// B then has a public new B.Foo.
						if (scopeChange && implementsAbstract)
						{
							//System.out.println("Scope change on abstract method implementation " + method);
							abstractScopeChanged.add(method);
						}

						if ((amethod != null && !implementsAbstract) || (imethod != null && !implementsInterface))
							continue;
						
						wr.startElement("Method", null);
						dataElement(wr, "Scope", scope);
						dataElement(wr, "Abstract", Modifier.isAbstract(method.getModifiers()));
						dataElement(wr, "Static", Modifier.isStatic(method.getModifiers()));

						if (hideoverrideimplement != null)
						{
							// note the weird edge case where a method can be made "new" by
							// declaring it abstract when there already is a superclass implementation. 
							if (!scopeChange && overrides && !Modifier.isAbstract(method.getModifiers()) && !Modifier.isStatic(method.getModifiers()))
							{
								dataElement(wr, "IsOverride", true);
								dataElement(wr, "Override", cleanClassName(hideoverrideimplement.getDeclaringClass()));
							}
							else// if (clazz.isInterface() || !hideoverrideimplement.getDeclaringClass().isInterface())
							{
								// read above for information regarding the isDirect hack...
								if (!Modifier.isAbstract(method.getModifiers()) || !method.getName().equals("isDirect"))
									dataElement(wr, "IsNew", true);
							}
							//else
							{
								// this is an explicit interface implementation, do nothing.
								//System.out.println(method);
							}
						}
						
						dataElement(wr, "IsSealed", Modifier.isFinal(method.getModifiers()) || Modifier.isFinal(clazz.getModifiers()));
						outputMember(wr, method, method.getParameterTypes());
						dataElement(wr, "Return", cleanClassName(method.getReturnType()));
						dataElement(wr, "Name", method.getName());
						wr.endElement("Method");
					}
				}

				boolean hasEmptyConstructor = false;
				for (Constructor constructor: clazz.getDeclaredConstructors())
				{
					if (!hasValidTypes(null, constructor.getParameterTypes(), classes))
						continue;
					if (Modifier.isPrivate(constructor.getModifiers()))
						continue;
					if (!Modifier.isPublic(constructor.getModifiers()) && !Modifier.isProtected(constructor.getModifiers()))
						continue;
					if (Modifier.isProtected(constructor.getModifiers()) && Modifier.isFinal(clazz.getModifiers()))
							continue;
					wr.startElement("Method", null);
					hasEmptyConstructor |= constructor.getParameterTypes().length == 0; 
					outputMember(wr, constructor, constructor.getParameterTypes());
					dataElement(wr, "IsConstructor", true);
					dataElement(wr, "Scope", Modifier.isPublic(constructor.getModifiers()) ? "public" : "protected");
					String cname = cleanClassName(clazz);
					cname = cname.substring(cname.lastIndexOf('.') + 1);
					dataElement(wr, "Name", cname);
					wr.endElement("Method");
				}
				
				// add empty internal constructors for everything.
				// this fixes problems with classes not calling the base class constructors with 
				// arguments when there are no empty constructor versions.
				/*
				 *
				// This is not needed anymore because I am using jni4net env constructor:
				// className(net.sf.jni4net.jni.JNIEnv env)
				if (!hasEmptyConstructor && !clazz.isInterface())
				{
					wr.startElement("Method", null);
					dataElement(wr, "IsConstructor", true);
					dataElement(wr, "Scope", "internal");
					String cname = cleanClassName(clazz);
					cname = cname.substring(cname.lastIndexOf('.') + 1);
					dataElement(wr, "Name", cname);
					wr.endElement("Method");
				}
				*/
				
				wr.endElement("Methods");
				
				if (clazz.getDeclaredFields().length > 0 && !clazz.isPrimitive() && !clazz.isInterface() && !clazz.getName().equals("java.lang.Character") && !clazz.getName().equals("java.text.CharacterIterator") && !clazz.getName().equals("java.lang.Float") && !clazz.getName().equals("java.lang.Byte") && !clazz.getName().equals("java.lang.Double"))
				{
					wr.startElement("Fields", null);
					for (Field field: clazz.getDeclaredFields())
					{
						if (Modifier.isPrivate(field.getModifiers()))
							continue;
						if (!Modifier.isPublic(field.getModifiers()) && !Modifier.isProtected(field.getModifiers()))
							continue;
						wr.startElement("Field", null);
						dataElement(wr, "Name", field.getName());
						dataElement(wr, "Type", cleanClassName(field.getType()));
						dataElement(wr, "Static", Modifier.isStatic(field.getModifiers()));
						dataElement(wr, "IsReadOnly", Modifier.isFinal(field.getModifiers()));
						dataElement(wr, "Scope", Modifier.isPublic(field.getModifiers()) ? "public" : "protected");
						if (Modifier.isStatic(field.getModifiers()) && Modifier.isFinal(field.getModifiers()) && (field.getType().isPrimitive() || field.getType().getName().equals("java.lang.String")))
						{
							field.setAccessible(true);
							dataElement(wr, "Value", field.get(null));
						}
						wr.endElement("Field");
					}
					wr.endElement("Fields");
				}
				
				if (superclass != null)
				{
					String superclassName = cleanClassName(superclass);
					if (abstractScopeChanged.size() > 0)
					{
						superclassName = cleanClassName(clazz) + "ScopeChangeShim";
					}
					dataElement(wr, "Parent", superclassName);
				}
				wr.endElement("Type");
				
				// In Java, interfaces can have readonly/static fields. However, .NET doesn't support this.
				// Fix this, by creating a <Interface>Constants class.
				if (clazz.isInterface() && clazz.getDeclaredFields().length > 0)
				{
					wr.startElement("Type", null);
					dataElement(wr, "Static", true);
					dataElement(wr, "Scope", "public");
					dataElement(wr, "Name", cleanClassName(clazz) + "Constants");
					wr.startElement("Fields", null);
					for (Field field: clazz.getDeclaredFields())
					{
						if (Modifier.isPrivate(field.getModifiers()))
							continue;
						if (!Modifier.isPublic(field.getModifiers()) && !Modifier.isProtected(field.getModifiers()))
							continue;
						if (clazz.getName().equals("java.lang.Character") || clazz.getName().equals("java.text.CharacterIterator"))
							continue;
						wr.startElement("Field", null);
						dataElement(wr, "Name", field.getName());
						dataElement(wr, "Type", cleanClassName(field.getType()));
						dataElement(wr, "Static", Modifier.isStatic(field.getModifiers()));
						dataElement(wr, "IsReadOnly", Modifier.isFinal(field.getModifiers()));
						dataElement(wr, "Scope", Modifier.isPublic(field.getModifiers()) ? "public" : "protected");
						if (Modifier.isStatic(field.getModifiers()) && Modifier.isFinal(field.getModifiers()) && (field.getType().isPrimitive() || field.getType().getName().equals("java.lang.String")))
						{
							field.setAccessible(true);
							dataElement(wr, "Value", field.get(null));
						}
						wr.endElement("Field");
					}
					wr.endElement("Fields");
					wr.endElement("Type");
				}
				
				// see comments above regarding abstract class scope change shim
				if (abstractScopeChanged.size() > 0)
				{
					wr.startElement("Type", null);
					dataElement(wr, "Abstract", Modifier.isAbstract(superclass.getModifiers()));
					dataElement(wr, "Scope", Modifier.isProtected(clazz.getModifiers()) ? "protected" : "public");
					dataElement(wr, "IsEnum", clazz.isEnum());
					dataElement(wr, "Name", cleanClassName(clazz) + "ScopeChangeShim");
					dataElement(wr, "Parent", cleanClassName(superclass));
					wr.startElement("Methods", null);
					for (Method method: abstractScopeChanged)
					{
						wr.startElement("Method", null);
						dataElement(wr, "Scope", "protected");
						dataElement(wr, "IsOverride", true);
						dataElement(wr, "Abstract", false);
						dataElement(wr, "Return", cleanClassName(method.getReturnType()));
						dataElement(wr, "Name", method.getName());
						outputMember(wr, method, method.getParameterTypes());
						wr.endElement("Method");
					}
					wr.endElement("Method");
					wr.endElement("Type");
				}
			}
			wr.endElement("ObjectModel");
			wr.endDocument();
			System.out.println("Classes: " + count);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

}
