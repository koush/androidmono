namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Class : java.lang.Object, java.io.Serializable, java.lang.reflect.GenericDeclaration, java.lang.reflect.Type, java.lang.reflect.AnnotatedElement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Class(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _forName19977;
		public static global::java.lang.Class forName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Class._forName19977.native == global::System.IntPtr.Zero)
				global::java.lang.Class._forName19977 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Class.staticClass, "forName", "(Ljava/lang/String;)Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallStaticObjectMethod(java.lang.Class.staticClass, global::java.lang.Class._forName19977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _forName19978;
		public static global::java.lang.Class forName(java.lang.String arg0, bool arg1, java.lang.ClassLoader arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Class._forName19978.native == global::System.IntPtr.Zero)
				global::java.lang.Class._forName19978 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Class.staticClass, "forName", "(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallStaticObjectMethod(java.lang.Class.staticClass, global::java.lang.Class._forName19978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _toString19979;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Class.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Class._toString19979) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAssignableFrom19980;
		public bool isAssignableFrom(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isAssignableFrom", "(Ljava/lang/Class;)Z", ref global::java.lang.Class._isAssignableFrom19980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInstance19981;
		public bool isInstance(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isInstance", "(Ljava/lang/Object;)Z", ref global::java.lang.Class._isInstance19981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Modifiers
		{
			get
			{
				return getModifiers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers19982;
		public int getModifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Class.staticClass, "getModifiers", "()I", ref global::java.lang.Class._getModifiers19982);
		}
		internal static global::MonoJavaBridge.MethodId _isInterface19983;
		public bool isInterface()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isInterface", "()Z", ref global::java.lang.Class._isInterface19983);
		}
		internal static global::MonoJavaBridge.MethodId _isArray19984;
		public bool isArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isArray", "()Z", ref global::java.lang.Class._isArray19984);
		}
		internal static global::MonoJavaBridge.MethodId _isPrimitive19985;
		public bool isPrimitive()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isPrimitive", "()Z", ref global::java.lang.Class._isPrimitive19985);
		}
		public new global::java.lang.Class Superclass
		{
			get
			{
				return getSuperclass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuperclass19986;
		public global::java.lang.Class getSuperclass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "getSuperclass", "()Ljava/lang/Class;", ref global::java.lang.Class._getSuperclass19986) as java.lang.Class;
		}
		public new global::java.lang.Class ComponentType
		{
			get
			{
				return getComponentType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComponentType19987;
		public global::java.lang.Class getComponentType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "getComponentType", "()Ljava/lang/Class;", ref global::java.lang.Class._getComponentType19987) as java.lang.Class;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName19988;
		public global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Class.staticClass, "getName", "()Ljava/lang/String;", ref global::java.lang.Class._getName19988) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance19989;
		public global::java.lang.Object newInstance()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Class.staticClass, "newInstance", "()Ljava/lang/Object;", ref global::java.lang.Class._newInstance19989) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isAnnotation19990;
		public bool isAnnotation()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isAnnotation", "()Z", ref global::java.lang.Class._isAnnotation19990);
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic19991;
		public bool isSynthetic()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isSynthetic", "()Z", ref global::java.lang.Class._isSynthetic19991);
		}
		public new global::java.lang.ClassLoader ClassLoader
		{
			get
			{
				return getClassLoader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassLoader19992;
		public global::java.lang.ClassLoader getClassLoader()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Class.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;", ref global::java.lang.Class._getClassLoader19992) as java.lang.ClassLoader;
		}
		public new global::java.lang.reflect.TypeVariable[] TypeParameters
		{
			get
			{
				return getTypeParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeParameters19993;
		public global::java.lang.reflect.TypeVariable[] getTypeParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.TypeVariable>(this, global::java.lang.Class.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", ref global::java.lang.Class._getTypeParameters19993) as java.lang.reflect.TypeVariable[];
		}
		public new global::java.lang.reflect.Type GenericSuperclass
		{
			get
			{
				return getGenericSuperclass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericSuperclass19994;
		public global::java.lang.reflect.Type getGenericSuperclass()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.reflect.Type>(this, global::java.lang.Class.staticClass, "getGenericSuperclass", "()Ljava/lang/reflect/Type;", ref global::java.lang.Class._getGenericSuperclass19994) as java.lang.reflect.Type;
		}
		public new global::java.lang.Package Package
		{
			get
			{
				return getPackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackage19995;
		public global::java.lang.Package getPackage()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Class.staticClass, "getPackage", "()Ljava/lang/Package;", ref global::java.lang.Class._getPackage19995) as java.lang.Package;
		}
		public new global::java.lang.Class[] Interfaces
		{
			get
			{
				return getInterfaces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInterfaces19996;
		public global::java.lang.Class[] getInterfaces()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "getInterfaces", "()[Ljava/lang/Class;", ref global::java.lang.Class._getInterfaces19996) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Type[] GenericInterfaces
		{
			get
			{
				return getGenericInterfaces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericInterfaces19997;
		public global::java.lang.reflect.Type[] getGenericInterfaces()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Type>(this, global::java.lang.Class.staticClass, "getGenericInterfaces", "()[Ljava/lang/reflect/Type;", ref global::java.lang.Class._getGenericInterfaces19997) as java.lang.reflect.Type[];
		}
		public new global::java.lang.Object[] Signers
		{
			get
			{
				return getSigners();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSigners19998;
		public global::java.lang.Object[] getSigners()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.lang.Class.staticClass, "getSigners", "()[Ljava/lang/Object;", ref global::java.lang.Class._getSigners19998) as java.lang.Object[];
		}
		public new global::java.lang.reflect.Method EnclosingMethod
		{
			get
			{
				return getEnclosingMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingMethod19999;
		public global::java.lang.reflect.Method getEnclosingMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Method>(this, global::java.lang.Class.staticClass, "getEnclosingMethod", "()Ljava/lang/reflect/Method;", ref global::java.lang.Class._getEnclosingMethod19999) as java.lang.reflect.Method;
		}
		public new global::java.lang.reflect.Constructor EnclosingConstructor
		{
			get
			{
				return getEnclosingConstructor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingConstructor20000;
		public global::java.lang.reflect.Constructor getEnclosingConstructor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Constructor>(this, global::java.lang.Class.staticClass, "getEnclosingConstructor", "()Ljava/lang/reflect/Constructor;", ref global::java.lang.Class._getEnclosingConstructor20000) as java.lang.reflect.Constructor;
		}
		public new global::java.lang.Class DeclaringClass
		{
			get
			{
				return getDeclaringClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass20001;
		public global::java.lang.Class getDeclaringClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "getDeclaringClass", "()Ljava/lang/Class;", ref global::java.lang.Class._getDeclaringClass20001) as java.lang.Class;
		}
		public new global::java.lang.Class EnclosingClass
		{
			get
			{
				return getEnclosingClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingClass20002;
		public global::java.lang.Class getEnclosingClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "getEnclosingClass", "()Ljava/lang/Class;", ref global::java.lang.Class._getEnclosingClass20002) as java.lang.Class;
		}
		public new global::java.lang.String SimpleName
		{
			get
			{
				return getSimpleName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSimpleName20003;
		public global::java.lang.String getSimpleName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Class.staticClass, "getSimpleName", "()Ljava/lang/String;", ref global::java.lang.Class._getSimpleName20003) as java.lang.String;
		}
		public new global::java.lang.String CanonicalName
		{
			get
			{
				return getCanonicalName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalName20004;
		public global::java.lang.String getCanonicalName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Class.staticClass, "getCanonicalName", "()Ljava/lang/String;", ref global::java.lang.Class._getCanonicalName20004) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAnonymousClass20005;
		public bool isAnonymousClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isAnonymousClass", "()Z", ref global::java.lang.Class._isAnonymousClass20005);
		}
		internal static global::MonoJavaBridge.MethodId _isLocalClass20006;
		public bool isLocalClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isLocalClass", "()Z", ref global::java.lang.Class._isLocalClass20006);
		}
		internal static global::MonoJavaBridge.MethodId _isMemberClass20007;
		public bool isMemberClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isMemberClass", "()Z", ref global::java.lang.Class._isMemberClass20007);
		}
		public new global::java.lang.Class[] Classes
		{
			get
			{
				return getClasses();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClasses20008;
		public global::java.lang.Class[] getClasses()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "getClasses", "()[Ljava/lang/Class;", ref global::java.lang.Class._getClasses20008) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Field[] Fields
		{
			get
			{
				return getFields();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFields20009;
		public global::java.lang.reflect.Field[] getFields()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Field>(this, global::java.lang.Class.staticClass, "getFields", "()[Ljava/lang/reflect/Field;", ref global::java.lang.Class._getFields20009) as java.lang.reflect.Field[];
		}
		public new global::java.lang.reflect.Method[] Methods
		{
			get
			{
				return getMethods();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethods20010;
		public global::java.lang.reflect.Method[] getMethods()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Method>(this, global::java.lang.Class.staticClass, "getMethods", "()[Ljava/lang/reflect/Method;", ref global::java.lang.Class._getMethods20010) as java.lang.reflect.Method[];
		}
		public new global::java.lang.reflect.Constructor[] Constructors
		{
			get
			{
				return getConstructors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstructors20011;
		public global::java.lang.reflect.Constructor[] getConstructors()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Constructor>(this, global::java.lang.Class.staticClass, "getConstructors", "()[Ljava/lang/reflect/Constructor;", ref global::java.lang.Class._getConstructors20011) as java.lang.reflect.Constructor[];
		}
		internal static global::MonoJavaBridge.MethodId _getField20012;
		public global::java.lang.reflect.Field getField(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Field>(this, global::java.lang.Class.staticClass, "getField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", ref global::java.lang.Class._getField20012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.reflect.Field;
		}
		internal static global::MonoJavaBridge.MethodId _getMethod20013;
		public global::java.lang.reflect.Method getMethod(java.lang.String arg0, java.lang.Class[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Method>(this, global::java.lang.Class.staticClass, "getMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", ref global::java.lang.Class._getMethod20013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.reflect.Method;
		}
		internal static global::MonoJavaBridge.MethodId _getConstructor20014;
		public global::java.lang.reflect.Constructor getConstructor(java.lang.Class[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Constructor>(this, global::java.lang.Class.staticClass, "getConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", ref global::java.lang.Class._getConstructor20014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.reflect.Constructor;
		}
		public new global::java.lang.Class[] DeclaredClasses
		{
			get
			{
				return getDeclaredClasses();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredClasses20015;
		public global::java.lang.Class[] getDeclaredClasses()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "getDeclaredClasses", "()[Ljava/lang/Class;", ref global::java.lang.Class._getDeclaredClasses20015) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Field[] DeclaredFields
		{
			get
			{
				return getDeclaredFields();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredFields20016;
		public global::java.lang.reflect.Field[] getDeclaredFields()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Field>(this, global::java.lang.Class.staticClass, "getDeclaredFields", "()[Ljava/lang/reflect/Field;", ref global::java.lang.Class._getDeclaredFields20016) as java.lang.reflect.Field[];
		}
		public new global::java.lang.reflect.Method[] DeclaredMethods
		{
			get
			{
				return getDeclaredMethods();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredMethods20017;
		public global::java.lang.reflect.Method[] getDeclaredMethods()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Method>(this, global::java.lang.Class.staticClass, "getDeclaredMethods", "()[Ljava/lang/reflect/Method;", ref global::java.lang.Class._getDeclaredMethods20017) as java.lang.reflect.Method[];
		}
		public new global::java.lang.reflect.Constructor[] DeclaredConstructors
		{
			get
			{
				return getDeclaredConstructors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredConstructors20018;
		public global::java.lang.reflect.Constructor[] getDeclaredConstructors()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Constructor>(this, global::java.lang.Class.staticClass, "getDeclaredConstructors", "()[Ljava/lang/reflect/Constructor;", ref global::java.lang.Class._getDeclaredConstructors20018) as java.lang.reflect.Constructor[];
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredField20019;
		public global::java.lang.reflect.Field getDeclaredField(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Field>(this, global::java.lang.Class.staticClass, "getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", ref global::java.lang.Class._getDeclaredField20019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.reflect.Field;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredMethod20020;
		public global::java.lang.reflect.Method getDeclaredMethod(java.lang.String arg0, java.lang.Class[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Method>(this, global::java.lang.Class.staticClass, "getDeclaredMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", ref global::java.lang.Class._getDeclaredMethod20020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.reflect.Method;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredConstructor20021;
		public global::java.lang.reflect.Constructor getDeclaredConstructor(java.lang.Class[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.reflect.Constructor>(this, global::java.lang.Class.staticClass, "getDeclaredConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", ref global::java.lang.Class._getDeclaredConstructor20021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.reflect.Constructor;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceAsStream20022;
		public global::java.io.InputStream getResourceAsStream(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Class.staticClass, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", ref global::java.lang.Class._getResourceAsStream20022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getResource20023;
		public global::java.net.URL getResource(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.lang.Class.staticClass, "getResource", "(Ljava/lang/String;)Ljava/net/URL;", ref global::java.lang.Class._getResource20023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URL;
		}
		public new global::java.security.ProtectionDomain ProtectionDomain
		{
			get
			{
				return getProtectionDomain();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtectionDomain20024;
		public global::java.security.ProtectionDomain getProtectionDomain()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Class.staticClass, "getProtectionDomain", "()Ljava/security/ProtectionDomain;", ref global::java.lang.Class._getProtectionDomain20024) as java.security.ProtectionDomain;
		}
		internal static global::MonoJavaBridge.MethodId _desiredAssertionStatus20025;
		public bool desiredAssertionStatus()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "desiredAssertionStatus", "()Z", ref global::java.lang.Class._desiredAssertionStatus20025);
		}
		internal static global::MonoJavaBridge.MethodId _isEnum20026;
		public bool isEnum()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isEnum", "()Z", ref global::java.lang.Class._isEnum20026);
		}
		public new global::java.lang.Object[] EnumConstants
		{
			get
			{
				return getEnumConstants();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnumConstants20027;
		public global::java.lang.Object[] getEnumConstants()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.lang.Class.staticClass, "getEnumConstants", "()[Ljava/lang/Object;", ref global::java.lang.Class._getEnumConstants20027) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _cast20028;
		public global::java.lang.Object cast(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.Class.staticClass, "cast", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.lang.Class._cast20028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _asSubclass20029;
		public global::java.lang.Class asSubclass(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.Class.staticClass, "asSubclass", "(Ljava/lang/Class;)Ljava/lang/Class;", ref global::java.lang.Class._asSubclass20029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation20030;
		public global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.Class.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", ref global::java.lang.Class._getAnnotation20030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.annotation.Annotation;
		}
		internal static global::MonoJavaBridge.MethodId _isAnnotationPresent20031;
		public bool isAnnotationPresent(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Class.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z", ref global::java.lang.Class._isAnnotationPresent20031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.annotation.Annotation[] Annotations
		{
			get
			{
				return getAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotations20032;
		public global::java.lang.annotation.Annotation[] getAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.Class.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;", ref global::java.lang.Class._getAnnotations20032) as java.lang.annotation.Annotation[];
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations20033;
		public global::java.lang.annotation.Annotation[] getDeclaredAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.Class.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", ref global::java.lang.Class._getDeclaredAnnotations20033) as java.lang.annotation.Annotation[];
		}
		static Class()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Class.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Class"));
		}
		internal static void InitJNI()
		{
		}
	}
}
