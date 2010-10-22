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
		internal static global::MonoJavaBridge.MethodId _forName19859;
		public static global::java.lang.Class forName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallStaticObjectMethod(java.lang.Class.staticClass, global::java.lang.Class._forName19859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _forName19860;
		public static global::java.lang.Class forName(java.lang.String arg0, bool arg1, java.lang.ClassLoader arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallStaticObjectMethod(java.lang.Class.staticClass, global::java.lang.Class._forName19860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _toString19861;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._toString19861)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._toString19861)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAssignableFrom19862;
		public bool isAssignableFrom(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isAssignableFrom19862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isAssignableFrom19862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInstance19863;
		public bool isInstance(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isInstance19863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isInstance19863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Modifiers
		{
			get
			{
				return getModifiers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers19864;
		public int getModifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Class._getModifiers19864);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getModifiers19864);
		}
		internal static global::MonoJavaBridge.MethodId _isInterface19865;
		public bool isInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isInterface19865);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isInterface19865);
		}
		internal static global::MonoJavaBridge.MethodId _isArray19866;
		public bool isArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isArray19866);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isArray19866);
		}
		internal static global::MonoJavaBridge.MethodId _isPrimitive19867;
		public bool isPrimitive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isPrimitive19867);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isPrimitive19867);
		}
		public new global::java.lang.Class Superclass
		{
			get
			{
				return getSuperclass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuperclass19868;
		public global::java.lang.Class getSuperclass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getSuperclass19868)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getSuperclass19868)) as java.lang.Class;
		}
		public new global::java.lang.Class ComponentType
		{
			get
			{
				return getComponentType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComponentType19869;
		public global::java.lang.Class getComponentType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getComponentType19869)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getComponentType19869)) as java.lang.Class;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName19870;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getName19870)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getName19870)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance19871;
		public global::java.lang.Object newInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._newInstance19871)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._newInstance19871)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isAnnotation19872;
		public bool isAnnotation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isAnnotation19872);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isAnnotation19872);
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic19873;
		public bool isSynthetic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isSynthetic19873);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isSynthetic19873);
		}
		public new global::java.lang.ClassLoader ClassLoader
		{
			get
			{
				return getClassLoader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassLoader19874;
		public global::java.lang.ClassLoader getClassLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getClassLoader19874)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getClassLoader19874)) as java.lang.ClassLoader;
		}
		public new global::java.lang.reflect.TypeVariable[] TypeParameters
		{
			get
			{
				return getTypeParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeParameters19875;
		public global::java.lang.reflect.TypeVariable[] getTypeParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getTypeParameters19875)) as java.lang.reflect.TypeVariable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getTypeParameters19875)) as java.lang.reflect.TypeVariable[];
		}
		public new global::java.lang.reflect.Type GenericSuperclass
		{
			get
			{
				return getGenericSuperclass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericSuperclass19876;
		public global::java.lang.reflect.Type getGenericSuperclass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getGenericSuperclass19876)) as java.lang.reflect.Type;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getGenericSuperclass19876)) as java.lang.reflect.Type;
		}
		public new global::java.lang.Package Package
		{
			get
			{
				return getPackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackage19877;
		public global::java.lang.Package getPackage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getPackage19877)) as java.lang.Package;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getPackage19877)) as java.lang.Package;
		}
		public new global::java.lang.Class[] Interfaces
		{
			get
			{
				return getInterfaces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInterfaces19878;
		public global::java.lang.Class[] getInterfaces() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getInterfaces19878)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getInterfaces19878)) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Type[] GenericInterfaces
		{
			get
			{
				return getGenericInterfaces();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericInterfaces19879;
		public global::java.lang.reflect.Type[] getGenericInterfaces() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getGenericInterfaces19879)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getGenericInterfaces19879)) as java.lang.reflect.Type[];
		}
		public new global::java.lang.Object[] Signers
		{
			get
			{
				return getSigners();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSigners19880;
		public global::java.lang.Object[] getSigners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getSigners19880)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getSigners19880)) as java.lang.Object[];
		}
		public new global::java.lang.reflect.Method EnclosingMethod
		{
			get
			{
				return getEnclosingMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingMethod19881;
		public global::java.lang.reflect.Method getEnclosingMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Method>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getEnclosingMethod19881)) as java.lang.reflect.Method;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Method>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getEnclosingMethod19881)) as java.lang.reflect.Method;
		}
		public new global::java.lang.reflect.Constructor EnclosingConstructor
		{
			get
			{
				return getEnclosingConstructor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingConstructor19882;
		public global::java.lang.reflect.Constructor getEnclosingConstructor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Constructor>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getEnclosingConstructor19882)) as java.lang.reflect.Constructor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Constructor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getEnclosingConstructor19882)) as java.lang.reflect.Constructor;
		}
		public new global::java.lang.Class DeclaringClass
		{
			get
			{
				return getDeclaringClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass19883;
		public global::java.lang.Class getDeclaringClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaringClass19883)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaringClass19883)) as java.lang.Class;
		}
		public new global::java.lang.Class EnclosingClass
		{
			get
			{
				return getEnclosingClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnclosingClass19884;
		public global::java.lang.Class getEnclosingClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getEnclosingClass19884)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getEnclosingClass19884)) as java.lang.Class;
		}
		public new global::java.lang.String SimpleName
		{
			get
			{
				return getSimpleName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSimpleName19885;
		public global::java.lang.String getSimpleName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getSimpleName19885)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getSimpleName19885)) as java.lang.String;
		}
		public new global::java.lang.String CanonicalName
		{
			get
			{
				return getCanonicalName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCanonicalName19886;
		public global::java.lang.String getCanonicalName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getCanonicalName19886)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getCanonicalName19886)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAnonymousClass19887;
		public bool isAnonymousClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isAnonymousClass19887);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isAnonymousClass19887);
		}
		internal static global::MonoJavaBridge.MethodId _isLocalClass19888;
		public bool isLocalClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isLocalClass19888);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isLocalClass19888);
		}
		internal static global::MonoJavaBridge.MethodId _isMemberClass19889;
		public bool isMemberClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isMemberClass19889);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isMemberClass19889);
		}
		public new global::java.lang.Class[] Classes
		{
			get
			{
				return getClasses();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClasses19890;
		public global::java.lang.Class[] getClasses() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getClasses19890)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getClasses19890)) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Field[] Fields
		{
			get
			{
				return getFields();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFields19891;
		public global::java.lang.reflect.Field[] getFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Field>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getFields19891)) as java.lang.reflect.Field[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Field>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getFields19891)) as java.lang.reflect.Field[];
		}
		public new global::java.lang.reflect.Method[] Methods
		{
			get
			{
				return getMethods();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethods19892;
		public global::java.lang.reflect.Method[] getMethods() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Method>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getMethods19892)) as java.lang.reflect.Method[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Method>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getMethods19892)) as java.lang.reflect.Method[];
		}
		public new global::java.lang.reflect.Constructor[] Constructors
		{
			get
			{
				return getConstructors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstructors19893;
		public global::java.lang.reflect.Constructor[] getConstructors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Constructor>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getConstructors19893)) as java.lang.reflect.Constructor[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Constructor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getConstructors19893)) as java.lang.reflect.Constructor[];
		}
		internal static global::MonoJavaBridge.MethodId _getField19894;
		public global::java.lang.reflect.Field getField(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Field>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getField19894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Field;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Field>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getField19894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Field;
		}
		internal static global::MonoJavaBridge.MethodId _getMethod19895;
		public global::java.lang.reflect.Method getMethod(java.lang.String arg0, java.lang.Class[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Method>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getMethod19895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.reflect.Method;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Method>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getMethod19895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.reflect.Method;
		}
		internal static global::MonoJavaBridge.MethodId _getConstructor19896;
		public global::java.lang.reflect.Constructor getConstructor(java.lang.Class[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Constructor>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getConstructor19896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Constructor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getConstructor19896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
		}
		public new global::java.lang.Class[] DeclaredClasses
		{
			get
			{
				return getDeclaredClasses();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredClasses19897;
		public global::java.lang.Class[] getDeclaredClasses() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredClasses19897)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredClasses19897)) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Field[] DeclaredFields
		{
			get
			{
				return getDeclaredFields();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredFields19898;
		public global::java.lang.reflect.Field[] getDeclaredFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Field>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredFields19898)) as java.lang.reflect.Field[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Field>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredFields19898)) as java.lang.reflect.Field[];
		}
		public new global::java.lang.reflect.Method[] DeclaredMethods
		{
			get
			{
				return getDeclaredMethods();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredMethods19899;
		public global::java.lang.reflect.Method[] getDeclaredMethods() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Method>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredMethods19899)) as java.lang.reflect.Method[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Method>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredMethods19899)) as java.lang.reflect.Method[];
		}
		public new global::java.lang.reflect.Constructor[] DeclaredConstructors
		{
			get
			{
				return getDeclaredConstructors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredConstructors19900;
		public global::java.lang.reflect.Constructor[] getDeclaredConstructors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Constructor>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredConstructors19900)) as java.lang.reflect.Constructor[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Constructor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredConstructors19900)) as java.lang.reflect.Constructor[];
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredField19901;
		public global::java.lang.reflect.Field getDeclaredField(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Field>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredField19901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Field;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Field>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredField19901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Field;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredMethod19902;
		public global::java.lang.reflect.Method getDeclaredMethod(java.lang.String arg0, java.lang.Class[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Method>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredMethod19902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.reflect.Method;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Method>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredMethod19902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.reflect.Method;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredConstructor19903;
		public global::java.lang.reflect.Constructor getDeclaredConstructor(java.lang.Class[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Constructor>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredConstructor19903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Constructor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredConstructor19903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
		}
		internal static global::MonoJavaBridge.MethodId _getResourceAsStream19904;
		public global::java.io.InputStream getResourceAsStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getResourceAsStream19904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getResourceAsStream19904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getResource19905;
		public global::java.net.URL getResource(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getResource19905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getResource19905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		public new global::java.security.ProtectionDomain ProtectionDomain
		{
			get
			{
				return getProtectionDomain();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtectionDomain19906;
		public global::java.security.ProtectionDomain getProtectionDomain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getProtectionDomain19906)) as java.security.ProtectionDomain;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getProtectionDomain19906)) as java.security.ProtectionDomain;
		}
		internal static global::MonoJavaBridge.MethodId _desiredAssertionStatus19907;
		public bool desiredAssertionStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._desiredAssertionStatus19907);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._desiredAssertionStatus19907);
		}
		internal static global::MonoJavaBridge.MethodId _isEnum19908;
		public bool isEnum() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isEnum19908);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isEnum19908);
		}
		public new global::java.lang.Object[] EnumConstants
		{
			get
			{
				return getEnumConstants();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEnumConstants19909;
		public global::java.lang.Object[] getEnumConstants() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getEnumConstants19909)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getEnumConstants19909)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _cast19910;
		public global::java.lang.Object cast(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._cast19910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._cast19910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _asSubclass19911;
		public global::java.lang.Class asSubclass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._asSubclass19911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._asSubclass19911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation19912;
		public global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getAnnotation19912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getAnnotation19912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		internal static global::MonoJavaBridge.MethodId _isAnnotationPresent19913;
		public bool isAnnotationPresent(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Class._isAnnotationPresent19913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._isAnnotationPresent19913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.annotation.Annotation[] Annotations
		{
			get
			{
				return getAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotations19914;
		public global::java.lang.annotation.Annotation[] getAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getAnnotations19914)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getAnnotations19914)) as java.lang.annotation.Annotation[];
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations19915;
		public global::java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Class._getDeclaredAnnotations19915)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Class.staticClass, global::java.lang.Class._getDeclaredAnnotations19915)) as java.lang.annotation.Annotation[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Class.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Class"));
			global::java.lang.Class._forName19859 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Class.staticClass, "forName", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::java.lang.Class._forName19860 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Class.staticClass, "forName", "(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;");
			global::java.lang.Class._toString19861 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Class._isAssignableFrom19862 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isAssignableFrom", "(Ljava/lang/Class;)Z");
			global::java.lang.Class._isInstance19863 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isInstance", "(Ljava/lang/Object;)Z");
			global::java.lang.Class._getModifiers19864 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getModifiers", "()I");
			global::java.lang.Class._isInterface19865 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isInterface", "()Z");
			global::java.lang.Class._isArray19866 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isArray", "()Z");
			global::java.lang.Class._isPrimitive19867 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isPrimitive", "()Z");
			global::java.lang.Class._getSuperclass19868 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getSuperclass", "()Ljava/lang/Class;");
			global::java.lang.Class._getComponentType19869 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getComponentType", "()Ljava/lang/Class;");
			global::java.lang.Class._getName19870 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.Class._newInstance19871 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "newInstance", "()Ljava/lang/Object;");
			global::java.lang.Class._isAnnotation19872 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isAnnotation", "()Z");
			global::java.lang.Class._isSynthetic19873 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isSynthetic", "()Z");
			global::java.lang.Class._getClassLoader19874 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getClassLoader", "()Ljava/lang/ClassLoader;");
			global::java.lang.Class._getTypeParameters19875 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
			global::java.lang.Class._getGenericSuperclass19876 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getGenericSuperclass", "()Ljava/lang/reflect/Type;");
			global::java.lang.Class._getPackage19877 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getPackage", "()Ljava/lang/Package;");
			global::java.lang.Class._getInterfaces19878 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getInterfaces", "()[Ljava/lang/Class;");
			global::java.lang.Class._getGenericInterfaces19879 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getGenericInterfaces", "()[Ljava/lang/reflect/Type;");
			global::java.lang.Class._getSigners19880 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getSigners", "()[Ljava/lang/Object;");
			global::java.lang.Class._getEnclosingMethod19881 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getEnclosingMethod", "()Ljava/lang/reflect/Method;");
			global::java.lang.Class._getEnclosingConstructor19882 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getEnclosingConstructor", "()Ljava/lang/reflect/Constructor;");
			global::java.lang.Class._getDeclaringClass19883 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			global::java.lang.Class._getEnclosingClass19884 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getEnclosingClass", "()Ljava/lang/Class;");
			global::java.lang.Class._getSimpleName19885 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getSimpleName", "()Ljava/lang/String;");
			global::java.lang.Class._getCanonicalName19886 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getCanonicalName", "()Ljava/lang/String;");
			global::java.lang.Class._isAnonymousClass19887 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isAnonymousClass", "()Z");
			global::java.lang.Class._isLocalClass19888 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isLocalClass", "()Z");
			global::java.lang.Class._isMemberClass19889 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isMemberClass", "()Z");
			global::java.lang.Class._getClasses19890 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getClasses", "()[Ljava/lang/Class;");
			global::java.lang.Class._getFields19891 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getFields", "()[Ljava/lang/reflect/Field;");
			global::java.lang.Class._getMethods19892 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getMethods", "()[Ljava/lang/reflect/Method;");
			global::java.lang.Class._getConstructors19893 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getConstructors", "()[Ljava/lang/reflect/Constructor;");
			global::java.lang.Class._getField19894 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;");
			global::java.lang.Class._getMethod19895 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;");
			global::java.lang.Class._getConstructor19896 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;");
			global::java.lang.Class._getDeclaredClasses19897 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredClasses", "()[Ljava/lang/Class;");
			global::java.lang.Class._getDeclaredFields19898 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredFields", "()[Ljava/lang/reflect/Field;");
			global::java.lang.Class._getDeclaredMethods19899 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredMethods", "()[Ljava/lang/reflect/Method;");
			global::java.lang.Class._getDeclaredConstructors19900 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredConstructors", "()[Ljava/lang/reflect/Constructor;");
			global::java.lang.Class._getDeclaredField19901 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;");
			global::java.lang.Class._getDeclaredMethod19902 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;");
			global::java.lang.Class._getDeclaredConstructor19903 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;");
			global::java.lang.Class._getResourceAsStream19904 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::java.lang.Class._getResource19905 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getResource", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.lang.Class._getProtectionDomain19906 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getProtectionDomain", "()Ljava/security/ProtectionDomain;");
			global::java.lang.Class._desiredAssertionStatus19907 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "desiredAssertionStatus", "()Z");
			global::java.lang.Class._isEnum19908 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isEnum", "()Z");
			global::java.lang.Class._getEnumConstants19909 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getEnumConstants", "()[Ljava/lang/Object;");
			global::java.lang.Class._cast19910 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "cast", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.lang.Class._asSubclass19911 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "asSubclass", "(Ljava/lang/Class;)Ljava/lang/Class;");
			global::java.lang.Class._getAnnotation19912 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.Class._isAnnotationPresent19913 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "isAnnotationPresent", "(Ljava/lang/Class;)Z");
			global::java.lang.Class._getAnnotations19914 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.Class._getDeclaredAnnotations19915 = @__env.GetMethodIDNoThrow(global::java.lang.Class.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
		}
	}
}
