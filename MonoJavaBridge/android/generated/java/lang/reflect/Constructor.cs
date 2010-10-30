namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Constructor : java.lang.reflect.AccessibleObject, GenericDeclaration, Member
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Constructor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21032;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Constructor.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.reflect.Constructor._equals21032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21033;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.reflect.Constructor.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.reflect.Constructor._toString21033) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21034;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.reflect.Constructor.staticClass, "hashCode", "()I", ref global::java.lang.reflect.Constructor._hashCode21034);
		}
		public new int Modifiers
		{
			get
			{
				return getModifiers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers21035;
		public int getModifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.reflect.Constructor.staticClass, "getModifiers", "()I", ref global::java.lang.reflect.Constructor._getModifiers21035);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName21036;
		public global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.reflect.Constructor.staticClass, "getName", "()Ljava/lang/String;", ref global::java.lang.reflect.Constructor._getName21036) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance21037;
		public global::java.lang.Object newInstance(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.reflect.Constructor.staticClass, "newInstance", "([Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.lang.reflect.Constructor._newInstance21037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic21038;
		public bool isSynthetic()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Constructor.staticClass, "isSynthetic", "()Z", ref global::java.lang.reflect.Constructor._isSynthetic21038);
		}
		public new global::java.lang.reflect.TypeVariable[] TypeParameters
		{
			get
			{
				return getTypeParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeParameters21039;
		public global::java.lang.reflect.TypeVariable[] getTypeParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.TypeVariable>(this, global::java.lang.reflect.Constructor.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", ref global::java.lang.reflect.Constructor._getTypeParameters21039) as java.lang.reflect.TypeVariable[];
		}
		public new global::java.lang.Class DeclaringClass
		{
			get
			{
				return getDeclaringClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass21040;
		public global::java.lang.Class getDeclaringClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.reflect.Constructor.staticClass, "getDeclaringClass", "()Ljava/lang/Class;", ref global::java.lang.reflect.Constructor._getDeclaringClass21040) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation21041;
		public sealed override global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.reflect.Constructor.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.Constructor._getAnnotation21041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.annotation.Annotation;
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations21042;
		public sealed override global::java.lang.annotation.Annotation[] getDeclaredAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.reflect.Constructor.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.Constructor._getDeclaredAnnotations21042) as java.lang.annotation.Annotation[];
		}
		public new global::java.lang.Class[] ParameterTypes
		{
			get
			{
				return getParameterTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterTypes21043;
		public global::java.lang.Class[] getParameterTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::java.lang.reflect.Constructor.staticClass, "getParameterTypes", "()[Ljava/lang/Class;", ref global::java.lang.reflect.Constructor._getParameterTypes21043) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _toGenericString21044;
		public global::java.lang.String toGenericString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.reflect.Constructor.staticClass, "toGenericString", "()Ljava/lang/String;", ref global::java.lang.reflect.Constructor._toGenericString21044) as java.lang.String;
		}
		public new global::java.lang.reflect.Type[] GenericParameterTypes
		{
			get
			{
				return getGenericParameterTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericParameterTypes21045;
		public global::java.lang.reflect.Type[] getGenericParameterTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Type>(this, global::java.lang.reflect.Constructor.staticClass, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", ref global::java.lang.reflect.Constructor._getGenericParameterTypes21045) as java.lang.reflect.Type[];
		}
		public new global::java.lang.Class[] ExceptionTypes
		{
			get
			{
				return getExceptionTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExceptionTypes21046;
		public global::java.lang.Class[] getExceptionTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::java.lang.reflect.Constructor.staticClass, "getExceptionTypes", "()[Ljava/lang/Class;", ref global::java.lang.reflect.Constructor._getExceptionTypes21046) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Type[] GenericExceptionTypes
		{
			get
			{
				return getGenericExceptionTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericExceptionTypes21047;
		public global::java.lang.reflect.Type[] getGenericExceptionTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Type>(this, global::java.lang.reflect.Constructor.staticClass, "getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", ref global::java.lang.reflect.Constructor._getGenericExceptionTypes21047) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _isVarArgs21048;
		public bool isVarArgs()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Constructor.staticClass, "isVarArgs", "()Z", ref global::java.lang.reflect.Constructor._isVarArgs21048);
		}
		public new global::java.lang.annotation.Annotation[][] ParameterAnnotations
		{
			get
			{
				return getParameterAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterAnnotations21049;
		public global::java.lang.annotation.Annotation[][] getParameterAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation[]>(this, global::java.lang.reflect.Constructor.staticClass, "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.Constructor._getParameterAnnotations21049) as java.lang.annotation.Annotation[][];
		}
		static Constructor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Constructor.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Constructor"));
		}
		internal static void InitJNI()
		{
		}
	}
}
