namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Method : java.lang.reflect.AccessibleObject, GenericDeclaration, Member
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Method(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::java.lang.Object invoke(java.lang.Object arg0, java.lang.Object[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.reflect.Method.staticClass, "invoke", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.lang.reflect.Method._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Method.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.reflect.Method._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.reflect.Method.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.reflect.Method._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.reflect.Method.staticClass, "hashCode", "()I", ref global::java.lang.reflect.Method._m3);
		}
		public new int Modifiers
		{
			get
			{
				return getModifiers();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public int getModifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.reflect.Method.staticClass, "getModifiers", "()I", ref global::java.lang.reflect.Method._m4);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.reflect.Method.staticClass, "getName", "()Ljava/lang/String;", ref global::java.lang.reflect.Method._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public bool isSynthetic()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Method.staticClass, "isSynthetic", "()Z", ref global::java.lang.reflect.Method._m6);
		}
		public new global::java.lang.reflect.TypeVariable[] TypeParameters
		{
			get
			{
				return getTypeParameters();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::java.lang.reflect.TypeVariable[] getTypeParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.TypeVariable>(this, global::java.lang.reflect.Method.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", ref global::java.lang.reflect.Method._m7) as java.lang.reflect.TypeVariable[];
		}
		public new global::java.lang.Class DeclaringClass
		{
			get
			{
				return getDeclaringClass();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::java.lang.Class getDeclaringClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.reflect.Method.staticClass, "getDeclaringClass", "()Ljava/lang/Class;", ref global::java.lang.reflect.Method._m8) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public sealed override global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.reflect.Method.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.Method._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.annotation.Annotation;
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public sealed override global::java.lang.annotation.Annotation[] getDeclaredAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.reflect.Method.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.Method._m10) as java.lang.annotation.Annotation[];
		}
		public new global::java.lang.Class ReturnType
		{
			get
			{
				return getReturnType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public global::java.lang.Class getReturnType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.reflect.Method.staticClass, "getReturnType", "()Ljava/lang/Class;", ref global::java.lang.reflect.Method._m11) as java.lang.Class;
		}
		public new global::java.lang.Class[] ParameterTypes
		{
			get
			{
				return getParameterTypes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public global::java.lang.Class[] getParameterTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::java.lang.reflect.Method.staticClass, "getParameterTypes", "()[Ljava/lang/Class;", ref global::java.lang.reflect.Method._m12) as java.lang.Class[];
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::java.lang.String toGenericString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.reflect.Method.staticClass, "toGenericString", "()Ljava/lang/String;", ref global::java.lang.reflect.Method._m13) as java.lang.String;
		}
		public new global::java.lang.reflect.Type GenericReturnType
		{
			get
			{
				return getGenericReturnType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public global::java.lang.reflect.Type getGenericReturnType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.reflect.Type>(this, global::java.lang.reflect.Method.staticClass, "getGenericReturnType", "()Ljava/lang/reflect/Type;", ref global::java.lang.reflect.Method._m14) as java.lang.reflect.Type;
		}
		public new global::java.lang.reflect.Type[] GenericParameterTypes
		{
			get
			{
				return getGenericParameterTypes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public global::java.lang.reflect.Type[] getGenericParameterTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Type>(this, global::java.lang.reflect.Method.staticClass, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", ref global::java.lang.reflect.Method._m15) as java.lang.reflect.Type[];
		}
		public new global::java.lang.Class[] ExceptionTypes
		{
			get
			{
				return getExceptionTypes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public global::java.lang.Class[] getExceptionTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::java.lang.reflect.Method.staticClass, "getExceptionTypes", "()[Ljava/lang/Class;", ref global::java.lang.reflect.Method._m16) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Type[] GenericExceptionTypes
		{
			get
			{
				return getGenericExceptionTypes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public global::java.lang.reflect.Type[] getGenericExceptionTypes()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.reflect.Type>(this, global::java.lang.reflect.Method.staticClass, "getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", ref global::java.lang.reflect.Method._m17) as java.lang.reflect.Type[];
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public bool isBridge()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Method.staticClass, "isBridge", "()Z", ref global::java.lang.reflect.Method._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public bool isVarArgs()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Method.staticClass, "isVarArgs", "()Z", ref global::java.lang.reflect.Method._m19);
		}
		public new global::java.lang.Object DefaultValue
		{
			get
			{
				return getDefaultValue();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public global::java.lang.Object getDefaultValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.reflect.Method.staticClass, "getDefaultValue", "()Ljava/lang/Object;", ref global::java.lang.reflect.Method._m20) as java.lang.Object;
		}
		public new global::java.lang.annotation.Annotation[][] ParameterAnnotations
		{
			get
			{
				return getParameterAnnotations();
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public global::java.lang.annotation.Annotation[][] getParameterAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation[]>(this, global::java.lang.reflect.Method.staticClass, "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.Method._m21) as java.lang.annotation.Annotation[][];
		}
		static Method()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Method.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Method"));
		}
	}
}
