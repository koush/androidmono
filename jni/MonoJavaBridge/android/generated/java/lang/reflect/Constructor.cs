namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Constructor : java.lang.reflect.AccessibleObject, GenericDeclaration, Member
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Constructor()
		{
			InitJNI();
		}
		internal Constructor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20913;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Constructor._equals20913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._equals20913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20914;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._toString20914)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._toString20914)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20915;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Constructor._hashCode20915);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._hashCode20915);
		}
		public new int Modifiers
		{
			get
			{
				return getModifiers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers20916;
		public int getModifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getModifiers20916);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getModifiers20916);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName20917;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getName20917)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getName20917)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance20918;
		public global::java.lang.Object newInstance(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._newInstance20918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._newInstance20918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic20919;
		public bool isSynthetic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Constructor._isSynthetic20919);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._isSynthetic20919);
		}
		public new global::java.lang.reflect.TypeVariable[] TypeParameters
		{
			get
			{
				return getTypeParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeParameters20920;
		public global::java.lang.reflect.TypeVariable[] getTypeParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getTypeParameters20920)) as java.lang.reflect.TypeVariable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getTypeParameters20920)) as java.lang.reflect.TypeVariable[];
		}
		public new global::java.lang.Class DeclaringClass
		{
			get
			{
				return getDeclaringClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass20921;
		public global::java.lang.Class getDeclaringClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getDeclaringClass20921)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getDeclaringClass20921)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation20922;
		public sealed override global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getAnnotation20922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getAnnotation20922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations20923;
		public sealed override global::java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getDeclaredAnnotations20923)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getDeclaredAnnotations20923)) as java.lang.annotation.Annotation[];
		}
		public new global::java.lang.Class[] ParameterTypes
		{
			get
			{
				return getParameterTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterTypes20924;
		public global::java.lang.Class[] getParameterTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getParameterTypes20924)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getParameterTypes20924)) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _toGenericString20925;
		public global::java.lang.String toGenericString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._toGenericString20925)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._toGenericString20925)) as java.lang.String;
		}
		public new global::java.lang.reflect.Type[] GenericParameterTypes
		{
			get
			{
				return getGenericParameterTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericParameterTypes20926;
		public global::java.lang.reflect.Type[] getGenericParameterTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getGenericParameterTypes20926)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getGenericParameterTypes20926)) as java.lang.reflect.Type[];
		}
		public new global::java.lang.Class[] ExceptionTypes
		{
			get
			{
				return getExceptionTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExceptionTypes20927;
		public global::java.lang.Class[] getExceptionTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getExceptionTypes20927)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getExceptionTypes20927)) as java.lang.Class[];
		}
		public new global::java.lang.reflect.Type[] GenericExceptionTypes
		{
			get
			{
				return getGenericExceptionTypes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericExceptionTypes20928;
		public global::java.lang.reflect.Type[] getGenericExceptionTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getGenericExceptionTypes20928)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getGenericExceptionTypes20928)) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _isVarArgs20929;
		public bool isVarArgs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Constructor._isVarArgs20929);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._isVarArgs20929);
		}
		public new global::java.lang.annotation.Annotation[][] ParameterAnnotations
		{
			get
			{
				return getParameterAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameterAnnotations20930;
		public global::java.lang.annotation.Annotation[][] getParameterAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation[]>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getParameterAnnotations20930)) as java.lang.annotation.Annotation[][];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation[]>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getParameterAnnotations20930)) as java.lang.annotation.Annotation[][];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Constructor.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Constructor"));
			global::java.lang.reflect.Constructor._equals20913 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.reflect.Constructor._toString20914 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.reflect.Constructor._hashCode20915 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "hashCode", "()I");
			global::java.lang.reflect.Constructor._getModifiers20916 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getModifiers", "()I");
			global::java.lang.reflect.Constructor._getName20917 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.reflect.Constructor._newInstance20918 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "newInstance", "([Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.lang.reflect.Constructor._isSynthetic20919 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "isSynthetic", "()Z");
			global::java.lang.reflect.Constructor._getTypeParameters20920 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
			global::java.lang.reflect.Constructor._getDeclaringClass20921 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			global::java.lang.reflect.Constructor._getAnnotation20922 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Constructor._getDeclaredAnnotations20923 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Constructor._getParameterTypes20924 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getParameterTypes", "()[Ljava/lang/Class;");
			global::java.lang.reflect.Constructor._toGenericString20925 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "toGenericString", "()Ljava/lang/String;");
			global::java.lang.reflect.Constructor._getGenericParameterTypes20926 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Constructor._getExceptionTypes20927 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getExceptionTypes", "()[Ljava/lang/Class;");
			global::java.lang.reflect.Constructor._getGenericExceptionTypes20928 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Constructor._isVarArgs20929 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "isVarArgs", "()Z");
			global::java.lang.reflect.Constructor._getParameterAnnotations20930 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;");
		}
	}
}
