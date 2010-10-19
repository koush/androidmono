namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Class : java.lang.Object, java.io.Serializable, java.lang.reflect.GenericDeclaration, java.lang.reflect.Type, java.lang.reflect.AnnotatedElement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Class()
		{
			InitJNI();
		}
		internal Class(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _forName14353;
		public static global::java.lang.Class forName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Class.staticClass, global::java.lang.Class._forName14353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _forName14354;
		public static global::java.lang.Class forName(java.lang.String arg0, bool arg1, java.lang.ClassLoader arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Class.staticClass, global::java.lang.Class._forName14354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _toString14355;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._toString14355)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._toString14355)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAssignableFrom14356;
		public bool isAssignableFrom(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isAssignableFrom14356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isAssignableFrom14356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInstance14357;
		public bool isInstance(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isInstance14357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isInstance14357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Modifiers
		{
			get
			{
				return getModifiers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers14358;
		public int getModifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Class._getModifiers14358);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getModifiers14358);
		}
		internal static global::MonoJavaBridge.MethodId _isInterface14359;
		public bool isInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isInterface14359);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isInterface14359);
		}
		internal static global::MonoJavaBridge.MethodId _isArray14360;
		public bool isArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isArray14360);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isArray14360);
		}
		internal static global::MonoJavaBridge.MethodId _isPrimitive14361;
		public bool isPrimitive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isPrimitive14361);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isPrimitive14361);
		}
		public new global::java.lang.Class Superclass
		{
			get
			{
				return getSuperclass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuperclass14362;
		public global::java.lang.Class getSuperclass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getSuperclass14362)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getSuperclass14362)) as java.lang.Class;
		}
		public new global::java.lang.Class ComponentType
		{
			get
			{
				return getComponentType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComponentType14363;
		public global::java.lang.Class getComponentType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getComponentType14363)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getComponentType14363)) as java.lang.Class;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName14364;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getName14364)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getName14364)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance14365;
		public global::java.lang.Object newInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._newInstance14365)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._newInstance14365)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isAnnotation14366;
		public bool isAnnotation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isAnnotation14366);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isAnnotation14366);
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic14367;
		public bool isSynthetic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isSynthetic14367);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isSynthetic14367);
		}
		public new global::java.lang.ClassLoader ClassLoader
		{
			get
			{
				return getClassLoader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassLoader14368;
		public global::java.lang.ClassLoader getClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getClassLoader14368)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getClassLoader14368)) as java.lang.ClassLoader;
		}
		public new global::java.lang.reflect.TypeVariable[] TypeParameters
		{
			get
			{
				return getTypeParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeParameters14369;
		public global::java.lang.reflect.TypeVariable[] getTypeParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getTypeParameters14369)) as java.lang.reflect.TypeVariable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getTypeParameters14369)) as java.lang.reflect.TypeVariable[];
		}
		public new global::java.lang.reflect.Type GenericSuperclass
		{
			get
			{
				return getGenericSuperclass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericSuperclass14370;
		public global::java.lang.reflect.Type getGenericSuperclass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getGenericSuperclass14370)) as java.lang.reflect.Type;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getGenericSuperclass14370)) as java.lang.reflect.Type;
		}
		public new global::java.lang.Package Package
		{
			get
			{
				return getPackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackage14371;
		public global::java.lang.Package getPackage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getPackage14371)) as java.lang.Package;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getPackage14371)) as java.lang.Package;
		}
		public new global::java.lang.Class[] Interfaces
		{
			get
			{
				return getInterfaces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInterfaces14372;
		public global::java.lang.Class[] getInterfaces() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getInterfaces14372)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getInterfaces14372)) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Type[] GenericInterfaces
		{
			get
			{
				return getGenericInterfaces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericInterfaces14373;
		public global::java.lang.reflect.Type[] getGenericInterfaces() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getGenericInterfaces14373)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getGenericInterfaces14373)) as java.lang.reflect.Type[];
		}
		public new global::java.lang.Object[] Signers
		{
			get
			{
				return getSigners();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSigners14374;
		public global::java.lang.Object[] getSigners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getSigners14374)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getSigners14374)) as java.lang.Object[];
		}
		public new global::java.lang.reflect.Method EnclosingMethod
		{
			get
			{
				return getEnclosingMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingMethod14375;
		public global::java.lang.reflect.Method getEnclosingMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getEnclosingMethod14375)) as java.lang.reflect.Method;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getEnclosingMethod14375)) as java.lang.reflect.Method;
		}
		public new global::java.lang.reflect.Constructor EnclosingConstructor
		{
			get
			{
				return getEnclosingConstructor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingConstructor14376;
		public global::java.lang.reflect.Constructor getEnclosingConstructor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getEnclosingConstructor14376)) as java.lang.reflect.Constructor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getEnclosingConstructor14376)) as java.lang.reflect.Constructor;
		}
		public new global::java.lang.Class DeclaringClass
		{
			get
			{
				return getDeclaringClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass14377;
		public global::java.lang.Class getDeclaringClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaringClass14377)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaringClass14377)) as java.lang.Class;
		}
		public new global::java.lang.Class EnclosingClass
		{
			get
			{
				return getEnclosingClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingClass14378;
		public global::java.lang.Class getEnclosingClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getEnclosingClass14378)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getEnclosingClass14378)) as java.lang.Class;
		}
		public new global::java.lang.String SimpleName
		{
			get
			{
				return getSimpleName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSimpleName14379;
		public global::java.lang.String getSimpleName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getSimpleName14379)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getSimpleName14379)) as java.lang.String;
		}
		public new global::java.lang.String CanonicalName
		{
			get
			{
				return getCanonicalName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalName14380;
		public global::java.lang.String getCanonicalName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getCanonicalName14380)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getCanonicalName14380)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAnonymousClass14381;
		public bool isAnonymousClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isAnonymousClass14381);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isAnonymousClass14381);
		}
		internal static global::MonoJavaBridge.MethodId _isLocalClass14382;
		public bool isLocalClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isLocalClass14382);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isLocalClass14382);
		}
		internal static global::MonoJavaBridge.MethodId _isMemberClass14383;
		public bool isMemberClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isMemberClass14383);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isMemberClass14383);
		}
		public new global::java.lang.Class[] Classes
		{
			get
			{
				return getClasses();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClasses14384;
		public global::java.lang.Class[] getClasses() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getClasses14384)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getClasses14384)) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Field[] Fields
		{
			get
			{
				return getFields();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFields14385;
		public global::java.lang.reflect.Field[] getFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Field>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getFields14385)) as java.lang.reflect.Field[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Field>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getFields14385)) as java.lang.reflect.Field[];
		}
		public new global::java.lang.reflect.Method[] Methods
		{
			get
			{
				return getMethods();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethods14386;
		public global::java.lang.reflect.Method[] getMethods() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Method>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getMethods14386)) as java.lang.reflect.Method[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Method>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getMethods14386)) as java.lang.reflect.Method[];
		}
		public new global::java.lang.reflect.Constructor[] Constructors
		{
			get
			{
				return getConstructors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstructors14387;
		public global::java.lang.reflect.Constructor[] getConstructors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Constructor>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getConstructors14387)) as java.lang.reflect.Constructor[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Constructor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getConstructors14387)) as java.lang.reflect.Constructor[];
		}
		internal static global::MonoJavaBridge.MethodId _getField14388;
		public global::java.lang.reflect.Field getField(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getField14388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Field;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getField14388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Field;
		}
		internal static global::MonoJavaBridge.MethodId _getMethod14389;
		public global::java.lang.reflect.Method getMethod(java.lang.String arg0, java.lang.Class[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getMethod14389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.reflect.Method;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getMethod14389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.reflect.Method;
		}
		internal static global::MonoJavaBridge.MethodId _getConstructor14390;
		public global::java.lang.reflect.Constructor getConstructor(java.lang.Class[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getConstructor14390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getConstructor14390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
		}
		public new global::java.lang.Class[] DeclaredClasses
		{
			get
			{
				return getDeclaredClasses();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredClasses14391;
		public global::java.lang.Class[] getDeclaredClasses() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredClasses14391)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredClasses14391)) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Field[] DeclaredFields
		{
			get
			{
				return getDeclaredFields();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredFields14392;
		public global::java.lang.reflect.Field[] getDeclaredFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Field>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredFields14392)) as java.lang.reflect.Field[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Field>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredFields14392)) as java.lang.reflect.Field[];
		}
		public new global::java.lang.reflect.Method[] DeclaredMethods
		{
			get
			{
				return getDeclaredMethods();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredMethods14393;
		public global::java.lang.reflect.Method[] getDeclaredMethods() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Method>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredMethods14393)) as java.lang.reflect.Method[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Method>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredMethods14393)) as java.lang.reflect.Method[];
		}
		public new global::java.lang.reflect.Constructor[] DeclaredConstructors
		{
			get
			{
				return getDeclaredConstructors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredConstructors14394;
		public global::java.lang.reflect.Constructor[] getDeclaredConstructors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Constructor>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredConstructors14394)) as java.lang.reflect.Constructor[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Constructor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredConstructors14394)) as java.lang.reflect.Constructor[];
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredField14395;
		public global::java.lang.reflect.Field getDeclaredField(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredField14395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Field;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredField14395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Field;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredMethod14396;
		public global::java.lang.reflect.Method getDeclaredMethod(java.lang.String arg0, java.lang.Class[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredMethod14396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.reflect.Method;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredMethod14396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.reflect.Method;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredConstructor14397;
		public global::java.lang.reflect.Constructor getDeclaredConstructor(java.lang.Class[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredConstructor14397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredConstructor14397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceAsStream14398;
		public global::java.io.InputStream getResourceAsStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getResourceAsStream14398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getResourceAsStream14398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getResource14399;
		public global::java.net.URL getResource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getResource14399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getResource14399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		public new global::java.security.ProtectionDomain ProtectionDomain
		{
			get
			{
				return getProtectionDomain();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtectionDomain14400;
		public global::java.security.ProtectionDomain getProtectionDomain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getProtectionDomain14400)) as java.security.ProtectionDomain;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getProtectionDomain14400)) as java.security.ProtectionDomain;
		}
		internal static global::MonoJavaBridge.MethodId _desiredAssertionStatus14401;
		public bool desiredAssertionStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._desiredAssertionStatus14401);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._desiredAssertionStatus14401);
		}
		internal static global::MonoJavaBridge.MethodId _isEnum14402;
		public bool isEnum() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isEnum14402);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isEnum14402);
		}
		public new global::java.lang.Object[] EnumConstants
		{
			get
			{
				return getEnumConstants();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnumConstants14403;
		public global::java.lang.Object[] getEnumConstants() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getEnumConstants14403)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getEnumConstants14403)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _cast14404;
		public global::java.lang.Object cast(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._cast14404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._cast14404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _asSubclass14405;
		public global::java.lang.Class asSubclass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._asSubclass14405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._asSubclass14405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation14406;
		public global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getAnnotation14406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getAnnotation14406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		internal static global::MonoJavaBridge.MethodId _isAnnotationPresent14407;
		public bool isAnnotationPresent(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isAnnotationPresent14407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isAnnotationPresent14407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.annotation.Annotation[] Annotations
		{
			get
			{
				return getAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotations14408;
		public global::java.lang.annotation.Annotation[] getAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getAnnotations14408)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getAnnotations14408)) as java.lang.annotation.Annotation[];
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations14409;
		public global::java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredAnnotations14409)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredAnnotations14409)) as java.lang.annotation.Annotation[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Class.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Class"));
			global::java.lang.Class._forName14353 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Class.staticClass, "forName", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.Class._forName14354 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Class.staticClass, "forName", "(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;");
			global::java.lang.Class._toString14355 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Class._isAssignableFrom14356 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isAssignableFrom", "(Ljava/lang/Class;)Z");
			global::java.lang.Class._isInstance14357 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isInstance", "(Ljava/lang/Object;)Z");
			global::java.lang.Class._getModifiers14358 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getModifiers", "()I");
			global::java.lang.Class._isInterface14359 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isInterface", "()Z");
			global::java.lang.Class._isArray14360 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isArray", "()Z");
			global::java.lang.Class._isPrimitive14361 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isPrimitive", "()Z");
			global::java.lang.Class._getSuperclass14362 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getSuperclass", "()Ljava/lang/Class;");
			global::java.lang.Class._getComponentType14363 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getComponentType", "()Ljava/lang/Class;");
			global::java.lang.Class._getName14364 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.Class._newInstance14365 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "newInstance", "()Ljava/lang/Object;");
			global::java.lang.Class._isAnnotation14366 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isAnnotation", "()Z");
			global::java.lang.Class._isSynthetic14367 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isSynthetic", "()Z");
			global::java.lang.Class._getClassLoader14368 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.Class._getTypeParameters14369 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
			global::java.lang.Class._getGenericSuperclass14370 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getGenericSuperclass", "()Ljava/lang/reflect/Type;");
			global::java.lang.Class._getPackage14371 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getPackage", "()Ljava/lang/Package;");
			global::java.lang.Class._getInterfaces14372 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getInterfaces", "()[Ljava/lang/Class;");
			global::java.lang.Class._getGenericInterfaces14373 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getGenericInterfaces", "()[Ljava/lang/reflect/Type;");
			global::java.lang.Class._getSigners14374 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getSigners", "()[Ljava/lang/Object;");
			global::java.lang.Class._getEnclosingMethod14375 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getEnclosingMethod", "()Ljava/lang/reflect/Method;");
			global::java.lang.Class._getEnclosingConstructor14376 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getEnclosingConstructor", "()Ljava/lang/reflect/Constructor;");
			global::java.lang.Class._getDeclaringClass14377 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			global::java.lang.Class._getEnclosingClass14378 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getEnclosingClass", "()Ljava/lang/Class;");
			global::java.lang.Class._getSimpleName14379 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getSimpleName", "()Ljava/lang/String;");
			global::java.lang.Class._getCanonicalName14380 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getCanonicalName", "()Ljava/lang/String;");
			global::java.lang.Class._isAnonymousClass14381 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isAnonymousClass", "()Z");
			global::java.lang.Class._isLocalClass14382 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isLocalClass", "()Z");
			global::java.lang.Class._isMemberClass14383 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isMemberClass", "()Z");
			global::java.lang.Class._getClasses14384 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getClasses", "()[Ljava/lang/Class;");
			global::java.lang.Class._getFields14385 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getFields", "()[Ljava/lang/reflect/Field;");
			global::java.lang.Class._getMethods14386 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getMethods", "()[Ljava/lang/reflect/Method;");
			global::java.lang.Class._getConstructors14387 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getConstructors", "()[Ljava/lang/reflect/Constructor;");
			global::java.lang.Class._getField14388 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;");
			global::java.lang.Class._getMethod14389 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;");
			global::java.lang.Class._getConstructor14390 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;");
			global::java.lang.Class._getDeclaredClasses14391 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredClasses", "()[Ljava/lang/Class;");
			global::java.lang.Class._getDeclaredFields14392 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredFields", "()[Ljava/lang/reflect/Field;");
			global::java.lang.Class._getDeclaredMethods14393 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredMethods", "()[Ljava/lang/reflect/Method;");
			global::java.lang.Class._getDeclaredConstructors14394 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredConstructors", "()[Ljava/lang/reflect/Constructor;");
			global::java.lang.Class._getDeclaredField14395 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;");
			global::java.lang.Class._getDeclaredMethod14396 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;");
			global::java.lang.Class._getDeclaredConstructor14397 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;");
			global::java.lang.Class._getResourceAsStream14398 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.lang.Class._getResource14399 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.lang.Class._getProtectionDomain14400 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getProtectionDomain", "()Ljava/security/ProtectionDomain;");
			global::java.lang.Class._desiredAssertionStatus14401 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "desiredAssertionStatus", "()Z");
			global::java.lang.Class._isEnum14402 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isEnum", "()Z");
			global::java.lang.Class._getEnumConstants14403 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getEnumConstants", "()[Ljava/lang/Object;");
			global::java.lang.Class._cast14404 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "cast", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.lang.Class._asSubclass14405 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "asSubclass", "(Ljava/lang/Class;)Ljava/lang/Class;");
			global::java.lang.Class._getAnnotation14406 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.Class._isAnnotationPresent14407 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z");
			global::java.lang.Class._getAnnotations14408 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.Class._getDeclaredAnnotations14409 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
		}
	}
}
