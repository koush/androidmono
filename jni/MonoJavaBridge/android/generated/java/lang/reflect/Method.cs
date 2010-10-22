namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Method : java.lang.reflect.AccessibleObject, GenericDeclaration, Member
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Method()
		{
			InitJNI();
		}
		internal Method(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _invoke20978;
		public global::java.lang.Object invoke(java.lang.Object arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._invoke20978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._invoke20978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals20979;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method._equals20979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._equals20979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20980;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._toString20980)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._toString20980)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20981;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Method._hashCode20981);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._hashCode20981);
		}
		public new int Modifiers
		{
			get
			{
				return getModifiers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers20982;
		public int getModifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Method._getModifiers20982);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getModifiers20982);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName20983;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getName20983)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getName20983)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic20984;
		public bool isSynthetic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method._isSynthetic20984);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._isSynthetic20984);
		}
		public new global::java.lang.reflect.TypeVariable[] TypeParameters
		{
			get
			{
				return getTypeParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeParameters20985;
		public global::java.lang.reflect.TypeVariable[] getTypeParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getTypeParameters20985)) as java.lang.reflect.TypeVariable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getTypeParameters20985)) as java.lang.reflect.TypeVariable[];
		}
		public new global::java.lang.Class DeclaringClass
		{
			get
			{
				return getDeclaringClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass20986;
		public global::java.lang.Class getDeclaringClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getDeclaringClass20986)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getDeclaringClass20986)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation20987;
		public sealed override global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getAnnotation20987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getAnnotation20987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations20988;
		public sealed override global::java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getDeclaredAnnotations20988)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getDeclaredAnnotations20988)) as java.lang.annotation.Annotation[];
		}
		public new global::java.lang.Class ReturnType
		{
			get
			{
				return getReturnType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReturnType20989;
		public global::java.lang.Class getReturnType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getReturnType20989)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getReturnType20989)) as java.lang.Class;
		}
		public new global::java.lang.Class[] ParameterTypes
		{
			get
			{
				return getParameterTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterTypes20990;
		public global::java.lang.Class[] getParameterTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getParameterTypes20990)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getParameterTypes20990)) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _toGenericString20991;
		public global::java.lang.String toGenericString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._toGenericString20991)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._toGenericString20991)) as java.lang.String;
		}
		public new global::java.lang.reflect.Type GenericReturnType
		{
			get
			{
				return getGenericReturnType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericReturnType20992;
		public global::java.lang.reflect.Type getGenericReturnType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getGenericReturnType20992)) as java.lang.reflect.Type;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getGenericReturnType20992)) as java.lang.reflect.Type;
		}
		public new global::java.lang.reflect.Type[] GenericParameterTypes
		{
			get
			{
				return getGenericParameterTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericParameterTypes20993;
		public global::java.lang.reflect.Type[] getGenericParameterTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getGenericParameterTypes20993)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getGenericParameterTypes20993)) as java.lang.reflect.Type[];
		}
		public new global::java.lang.Class[] ExceptionTypes
		{
			get
			{
				return getExceptionTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExceptionTypes20994;
		public global::java.lang.Class[] getExceptionTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getExceptionTypes20994)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getExceptionTypes20994)) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Type[] GenericExceptionTypes
		{
			get
			{
				return getGenericExceptionTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericExceptionTypes20995;
		public global::java.lang.reflect.Type[] getGenericExceptionTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getGenericExceptionTypes20995)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getGenericExceptionTypes20995)) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _isBridge20996;
		public bool isBridge() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method._isBridge20996);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._isBridge20996);
		}
		internal static global::MonoJavaBridge.MethodId _isVarArgs20997;
		public bool isVarArgs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method._isVarArgs20997);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._isVarArgs20997);
		}
		public new global::java.lang.Object DefaultValue
		{
			get
			{
				return getDefaultValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultValue20998;
		public global::java.lang.Object getDefaultValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getDefaultValue20998)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getDefaultValue20998)) as java.lang.Object;
		}
		public new global::java.lang.annotation.Annotation[][] ParameterAnnotations
		{
			get
			{
				return getParameterAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterAnnotations20999;
		public global::java.lang.annotation.Annotation[][] getParameterAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation[]>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getParameterAnnotations20999)) as java.lang.annotation.Annotation[][];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation[]>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getParameterAnnotations20999)) as java.lang.annotation.Annotation[][];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Method.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Method"));
			global::java.lang.reflect.Method._invoke20978 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "invoke", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.lang.reflect.Method._equals20979 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.reflect.Method._toString20980 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.reflect.Method._hashCode20981 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "hashCode", "()I");
			global::java.lang.reflect.Method._getModifiers20982 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getModifiers", "()I");
			global::java.lang.reflect.Method._getName20983 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.reflect.Method._isSynthetic20984 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "isSynthetic", "()Z");
			global::java.lang.reflect.Method._getTypeParameters20985 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
			global::java.lang.reflect.Method._getDeclaringClass20986 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			global::java.lang.reflect.Method._getAnnotation20987 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Method._getDeclaredAnnotations20988 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Method._getReturnType20989 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getReturnType", "()Ljava/lang/Class;");
			global::java.lang.reflect.Method._getParameterTypes20990 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getParameterTypes", "()[Ljava/lang/Class;");
			global::java.lang.reflect.Method._toGenericString20991 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "toGenericString", "()Ljava/lang/String;");
			global::java.lang.reflect.Method._getGenericReturnType20992 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getGenericReturnType", "()Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Method._getGenericParameterTypes20993 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Method._getExceptionTypes20994 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getExceptionTypes", "()[Ljava/lang/Class;");
			global::java.lang.reflect.Method._getGenericExceptionTypes20995 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Method._isBridge20996 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "isBridge", "()Z");
			global::java.lang.reflect.Method._isVarArgs20997 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "isVarArgs", "()Z");
			global::java.lang.reflect.Method._getDefaultValue20998 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getDefaultValue", "()Ljava/lang/Object;");
			global::java.lang.reflect.Method._getParameterAnnotations20999 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;");
		}
	}
}
