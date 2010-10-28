namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Method : java.lang.reflect.AccessibleObject, GenericDeclaration, Member
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Method(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _invoke21097;
		public global::java.lang.Object invoke(java.lang.Object arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._invoke21097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._invoke21097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals21098;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method._equals21098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._equals21098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21099;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._toString21099)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._toString21099)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21100;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Method._hashCode21100);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._hashCode21100);
		}
		public new int Modifiers
		{
			get
			{
				return getModifiers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers21101;
		public int getModifiers()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Method._getModifiers21101);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getModifiers21101);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName21102;
		public global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getName21102)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getName21102)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic21103;
		public bool isSynthetic()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method._isSynthetic21103);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._isSynthetic21103);
		}
		public new global::java.lang.reflect.TypeVariable[] TypeParameters
		{
			get
			{
				return getTypeParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeParameters21104;
		public global::java.lang.reflect.TypeVariable[] getTypeParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getTypeParameters21104)) as java.lang.reflect.TypeVariable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getTypeParameters21104)) as java.lang.reflect.TypeVariable[];
		}
		public new global::java.lang.Class DeclaringClass
		{
			get
			{
				return getDeclaringClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass21105;
		public global::java.lang.Class getDeclaringClass()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getDeclaringClass21105)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getDeclaringClass21105)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation21106;
		public sealed override global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getAnnotation21106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getAnnotation21106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations21107;
		public sealed override global::java.lang.annotation.Annotation[] getDeclaredAnnotations()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getDeclaredAnnotations21107)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getDeclaredAnnotations21107)) as java.lang.annotation.Annotation[];
		}
		public new global::java.lang.Class ReturnType
		{
			get
			{
				return getReturnType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReturnType21108;
		public global::java.lang.Class getReturnType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getReturnType21108)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getReturnType21108)) as java.lang.Class;
		}
		public new global::java.lang.Class[] ParameterTypes
		{
			get
			{
				return getParameterTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterTypes21109;
		public global::java.lang.Class[] getParameterTypes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getParameterTypes21109)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getParameterTypes21109)) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _toGenericString21110;
		public global::java.lang.String toGenericString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._toGenericString21110)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._toGenericString21110)) as java.lang.String;
		}
		public new global::java.lang.reflect.Type GenericReturnType
		{
			get
			{
				return getGenericReturnType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericReturnType21111;
		public global::java.lang.reflect.Type getGenericReturnType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getGenericReturnType21111)) as java.lang.reflect.Type;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getGenericReturnType21111)) as java.lang.reflect.Type;
		}
		public new global::java.lang.reflect.Type[] GenericParameterTypes
		{
			get
			{
				return getGenericParameterTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericParameterTypes21112;
		public global::java.lang.reflect.Type[] getGenericParameterTypes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getGenericParameterTypes21112)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getGenericParameterTypes21112)) as java.lang.reflect.Type[];
		}
		public new global::java.lang.Class[] ExceptionTypes
		{
			get
			{
				return getExceptionTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExceptionTypes21113;
		public global::java.lang.Class[] getExceptionTypes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getExceptionTypes21113)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getExceptionTypes21113)) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Type[] GenericExceptionTypes
		{
			get
			{
				return getGenericExceptionTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericExceptionTypes21114;
		public global::java.lang.reflect.Type[] getGenericExceptionTypes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getGenericExceptionTypes21114)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getGenericExceptionTypes21114)) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _isBridge21115;
		public bool isBridge()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method._isBridge21115);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._isBridge21115);
		}
		internal static global::MonoJavaBridge.MethodId _isVarArgs21116;
		public bool isVarArgs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method._isVarArgs21116);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._isVarArgs21116);
		}
		public new global::java.lang.Object DefaultValue
		{
			get
			{
				return getDefaultValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultValue21117;
		public global::java.lang.Object getDefaultValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getDefaultValue21117)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getDefaultValue21117)) as java.lang.Object;
		}
		public new global::java.lang.annotation.Annotation[][] ParameterAnnotations
		{
			get
			{
				return getParameterAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterAnnotations21118;
		public global::java.lang.annotation.Annotation[][] getParameterAnnotations()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation[]>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getParameterAnnotations21118)) as java.lang.annotation.Annotation[][];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation[]>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getParameterAnnotations21118)) as java.lang.annotation.Annotation[][];
		}
		static Method()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Method.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Method"));
			global::java.lang.reflect.Method._invoke21097 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "invoke", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.lang.reflect.Method._equals21098 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.reflect.Method._toString21099 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.reflect.Method._hashCode21100 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "hashCode", "()I");
			global::java.lang.reflect.Method._getModifiers21101 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getModifiers", "()I");
			global::java.lang.reflect.Method._getName21102 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.reflect.Method._isSynthetic21103 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "isSynthetic", "()Z");
			global::java.lang.reflect.Method._getTypeParameters21104 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
			global::java.lang.reflect.Method._getDeclaringClass21105 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			global::java.lang.reflect.Method._getAnnotation21106 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Method._getDeclaredAnnotations21107 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Method._getReturnType21108 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getReturnType", "()Ljava/lang/Class;");
			global::java.lang.reflect.Method._getParameterTypes21109 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getParameterTypes", "()[Ljava/lang/Class;");
			global::java.lang.reflect.Method._toGenericString21110 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "toGenericString", "()Ljava/lang/String;");
			global::java.lang.reflect.Method._getGenericReturnType21111 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getGenericReturnType", "()Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Method._getGenericParameterTypes21112 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Method._getExceptionTypes21113 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getExceptionTypes", "()[Ljava/lang/Class;");
			global::java.lang.reflect.Method._getGenericExceptionTypes21114 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Method._isBridge21115 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "isBridge", "()Z");
			global::java.lang.reflect.Method._isVarArgs21116 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "isVarArgs", "()Z");
			global::java.lang.reflect.Method._getDefaultValue21117 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getDefaultValue", "()Ljava/lang/Object;");
			global::java.lang.reflect.Method._getParameterAnnotations21118 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;");
		}
		internal static void InitJNI()
		{
		}
	}
}
