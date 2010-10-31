namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Class : java.lang.Object, java.io.Serializable, java.lang.reflect.GenericDeclaration, java.lang.reflect.Type, java.lang.reflect.AnnotatedElement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Class(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.Class forName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Class._m0.native == global::System.IntPtr.Zero)
				global::java.lang.Class._m0 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Class.staticClass, "forName", "(Ljava/lang/String;)Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallStaticObjectMethod(java.lang.Class.staticClass, global::java.lang.Class._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.Class forName(java.lang.String arg0, bool arg1, java.lang.ClassLoader arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Class._m1.native == global::System.IntPtr.Zero)
				global::java.lang.Class._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Class.staticClass, "forName", "(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallStaticObjectMethod(java.lang.Class.staticClass, global::java.lang.Class._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Class.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Class._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public bool isAssignableFrom(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isAssignableFrom", "(Ljava/lang/Class;)Z", ref global::java.lang.Class._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public bool isInstance(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isInstance", "(Ljava/lang/Object;)Z", ref global::java.lang.Class._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Modifiers
		{
			get
			{
				return getModifiers();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public int getModifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Class.staticClass, "getModifiers", "()I", ref global::java.lang.Class._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public bool isInterface()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isInterface", "()Z", ref global::java.lang.Class._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public bool isArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isArray", "()Z", ref global::java.lang.Class._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public bool isPrimitive()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isPrimitive", "()Z", ref global::java.lang.Class._m8);
		}
		public new global::java.lang.Class Superclass
		{
			get
			{
				return getSuperclass();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public global::java.lang.Class getSuperclass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "getSuperclass", "()Ljava/lang/Class;", ref global::java.lang.Class._m9) as java.lang.Class;
		}
		public new global::java.lang.Class ComponentType
		{
			get
			{
				return getComponentType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public global::java.lang.Class getComponentType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "getComponentType", "()Ljava/lang/Class;", ref global::java.lang.Class._m10) as java.lang.Class;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Class.staticClass, "getName", "()Ljava/lang/String;", ref global::java.lang.Class._m11) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public global::java.lang.Object newInstance()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Class.staticClass, "newInstance", "()Ljava/lang/Object;", ref global::java.lang.Class._m12) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public bool isAnnotation()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isAnnotation", "()Z", ref global::java.lang.Class._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public bool isSynthetic()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isSynthetic", "()Z", ref global::java.lang.Class._m14);
		}
		public new global::java.lang.ClassLoader ClassLoader
		{
			get
			{
				return getClassLoader();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public global::java.lang.ClassLoader getClassLoader()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Class.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;", ref global::java.lang.Class._m15) as java.lang.ClassLoader;
		}
		public new global::java.lang.reflect.TypeVariable[] TypeParameters
		{
			get
			{
				return getTypeParameters();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public global::java.lang.reflect.TypeVariable[] getTypeParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.TypeVariable>(this, global::java.lang.Class.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", ref global::java.lang.Class._m16) as java.lang.reflect.TypeVariable[];
		}
		public new global::java.lang.reflect.Type GenericSuperclass
		{
			get
			{
				return getGenericSuperclass();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public global::java.lang.reflect.Type getGenericSuperclass()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.reflect.Type>(this, global::java.lang.Class.staticClass, "getGenericSuperclass", "()Ljava/lang/reflect/Type;", ref global::java.lang.Class._m17) as java.lang.reflect.Type;
		}
		public new global::java.lang.Package Package
		{
			get
			{
				return getPackage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public global::java.lang.Package getPackage()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Class.staticClass, "getPackage", "()Ljava/lang/Package;", ref global::java.lang.Class._m18) as java.lang.Package;
		}
		public new global::java.lang.Class[] Interfaces
		{
			get
			{
				return getInterfaces();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public global::java.lang.Class[] getInterfaces()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "getInterfaces", "()[Ljava/lang/Class;", ref global::java.lang.Class._m19) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Type[] GenericInterfaces
		{
			get
			{
				return getGenericInterfaces();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public global::java.lang.reflect.Type[] getGenericInterfaces()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Type>(this, global::java.lang.Class.staticClass, "getGenericInterfaces", "()[Ljava/lang/reflect/Type;", ref global::java.lang.Class._m20) as java.lang.reflect.Type[];
		}
		public new global::java.lang.Object[] Signers
		{
			get
			{
				return getSigners();
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public global::java.lang.Object[] getSigners()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.lang.Class.staticClass, "getSigners", "()[Ljava/lang/Object;", ref global::java.lang.Class._m21) as java.lang.Object[];
		}
		public new global::java.lang.reflect.Method EnclosingMethod
		{
			get
			{
				return getEnclosingMethod();
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public global::java.lang.reflect.Method getEnclosingMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Method>(this, global::java.lang.Class.staticClass, "getEnclosingMethod", "()Ljava/lang/reflect/Method;", ref global::java.lang.Class._m22) as java.lang.reflect.Method;
		}
		public new global::java.lang.reflect.Constructor EnclosingConstructor
		{
			get
			{
				return getEnclosingConstructor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public global::java.lang.reflect.Constructor getEnclosingConstructor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Constructor>(this, global::java.lang.Class.staticClass, "getEnclosingConstructor", "()Ljava/lang/reflect/Constructor;", ref global::java.lang.Class._m23) as java.lang.reflect.Constructor;
		}
		public new global::java.lang.Class DeclaringClass
		{
			get
			{
				return getDeclaringClass();
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public global::java.lang.Class getDeclaringClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "getDeclaringClass", "()Ljava/lang/Class;", ref global::java.lang.Class._m24) as java.lang.Class;
		}
		public new global::java.lang.Class EnclosingClass
		{
			get
			{
				return getEnclosingClass();
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public global::java.lang.Class getEnclosingClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "getEnclosingClass", "()Ljava/lang/Class;", ref global::java.lang.Class._m25) as java.lang.Class;
		}
		public new global::java.lang.String SimpleName
		{
			get
			{
				return getSimpleName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public global::java.lang.String getSimpleName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Class.staticClass, "getSimpleName", "()Ljava/lang/String;", ref global::java.lang.Class._m26) as java.lang.String;
		}
		public new global::java.lang.String CanonicalName
		{
			get
			{
				return getCanonicalName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public global::java.lang.String getCanonicalName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Class.staticClass, "getCanonicalName", "()Ljava/lang/String;", ref global::java.lang.Class._m27) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public bool isAnonymousClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isAnonymousClass", "()Z", ref global::java.lang.Class._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public bool isLocalClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isLocalClass", "()Z", ref global::java.lang.Class._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public bool isMemberClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isMemberClass", "()Z", ref global::java.lang.Class._m30);
		}
		public new global::java.lang.Class[] Classes
		{
			get
			{
				return getClasses();
			}
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public global::java.lang.Class[] getClasses()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "getClasses", "()[Ljava/lang/Class;", ref global::java.lang.Class._m31) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Field[] Fields
		{
			get
			{
				return getFields();
			}
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public global::java.lang.reflect.Field[] getFields()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Field>(this, global::java.lang.Class.staticClass, "getFields", "()[Ljava/lang/reflect/Field;", ref global::java.lang.Class._m32) as java.lang.reflect.Field[];
		}
		public new global::java.lang.reflect.Method[] Methods
		{
			get
			{
				return getMethods();
			}
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public global::java.lang.reflect.Method[] getMethods()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Method>(this, global::java.lang.Class.staticClass, "getMethods", "()[Ljava/lang/reflect/Method;", ref global::java.lang.Class._m33) as java.lang.reflect.Method[];
		}
		public new global::java.lang.reflect.Constructor[] Constructors
		{
			get
			{
				return getConstructors();
			}
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public global::java.lang.reflect.Constructor[] getConstructors()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Constructor>(this, global::java.lang.Class.staticClass, "getConstructors", "()[Ljava/lang/reflect/Constructor;", ref global::java.lang.Class._m34) as java.lang.reflect.Constructor[];
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public global::java.lang.reflect.Field getField(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Field>(this, global::java.lang.Class.staticClass, "getField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", ref global::java.lang.Class._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.reflect.Field;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public global::java.lang.reflect.Method getMethod(java.lang.String arg0, java.lang.Class[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Method>(this, global::java.lang.Class.staticClass, "getMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", ref global::java.lang.Class._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.reflect.Method;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public global::java.lang.reflect.Constructor getConstructor(java.lang.Class[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Constructor>(this, global::java.lang.Class.staticClass, "getConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", ref global::java.lang.Class._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.reflect.Constructor;
		}
		public new global::java.lang.Class[] DeclaredClasses
		{
			get
			{
				return getDeclaredClasses();
			}
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public global::java.lang.Class[] getDeclaredClasses()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "getDeclaredClasses", "()[Ljava/lang/Class;", ref global::java.lang.Class._m38) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Field[] DeclaredFields
		{
			get
			{
				return getDeclaredFields();
			}
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public global::java.lang.reflect.Field[] getDeclaredFields()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Field>(this, global::java.lang.Class.staticClass, "getDeclaredFields", "()[Ljava/lang/reflect/Field;", ref global::java.lang.Class._m39) as java.lang.reflect.Field[];
		}
		public new global::java.lang.reflect.Method[] DeclaredMethods
		{
			get
			{
				return getDeclaredMethods();
			}
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public global::java.lang.reflect.Method[] getDeclaredMethods()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Method>(this, global::java.lang.Class.staticClass, "getDeclaredMethods", "()[Ljava/lang/reflect/Method;", ref global::java.lang.Class._m40) as java.lang.reflect.Method[];
		}
		public new global::java.lang.reflect.Constructor[] DeclaredConstructors
		{
			get
			{
				return getDeclaredConstructors();
			}
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public global::java.lang.reflect.Constructor[] getDeclaredConstructors()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Constructor>(this, global::java.lang.Class.staticClass, "getDeclaredConstructors", "()[Ljava/lang/reflect/Constructor;", ref global::java.lang.Class._m41) as java.lang.reflect.Constructor[];
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public global::java.lang.reflect.Field getDeclaredField(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Field>(this, global::java.lang.Class.staticClass, "getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", ref global::java.lang.Class._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.reflect.Field;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public global::java.lang.reflect.Method getDeclaredMethod(java.lang.String arg0, java.lang.Class[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Method>(this, global::java.lang.Class.staticClass, "getDeclaredMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", ref global::java.lang.Class._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.reflect.Method;
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public global::java.lang.reflect.Constructor getDeclaredConstructor(java.lang.Class[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Constructor>(this, global::java.lang.Class.staticClass, "getDeclaredConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", ref global::java.lang.Class._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.reflect.Constructor;
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public global::java.io.InputStream getResourceAsStream(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Class.staticClass, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", ref global::java.lang.Class._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public global::java.net.URL getResource(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.lang.Class.staticClass, "getResource", "(Ljava/lang/String;)Ljava/net/URL;", ref global::java.lang.Class._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URL;
		}
		public new global::java.security.ProtectionDomain ProtectionDomain
		{
			get
			{
				return getProtectionDomain();
			}
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public global::java.security.ProtectionDomain getProtectionDomain()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Class.staticClass, "getProtectionDomain", "()Ljava/security/ProtectionDomain;", ref global::java.lang.Class._m47) as java.security.ProtectionDomain;
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public bool desiredAssertionStatus()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "desiredAssertionStatus", "()Z", ref global::java.lang.Class._m48);
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public bool isEnum()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isEnum", "()Z", ref global::java.lang.Class._m49);
		}
		public new global::java.lang.Object[] EnumConstants
		{
			get
			{
				return getEnumConstants();
			}
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public global::java.lang.Object[] getEnumConstants()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.lang.Class.staticClass, "getEnumConstants", "()[Ljava/lang/Object;", ref global::java.lang.Class._m50) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public global::java.lang.Object cast(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Class.staticClass, "cast", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.lang.Class._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public global::java.lang.Class asSubclass(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "asSubclass", "(Ljava/lang/Class;)Ljava/lang/Class;", ref global::java.lang.Class._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.Class.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", ref global::java.lang.Class._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.annotation.Annotation;
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public bool isAnnotationPresent(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z", ref global::java.lang.Class._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.annotation.Annotation[] Annotations
		{
			get
			{
				return getAnnotations();
			}
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public global::java.lang.annotation.Annotation[] getAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.Class.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;", ref global::java.lang.Class._m55) as java.lang.annotation.Annotation[];
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public global::java.lang.annotation.Annotation[] getDeclaredAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.Class.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", ref global::java.lang.Class._m56) as java.lang.annotation.Annotation[];
		}
		static Class()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Class.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Class"));
		}
	}
}
