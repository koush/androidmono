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
		internal static global::MonoJavaBridge.MethodId _equals13436;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Constructor._equals13436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._equals13436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString13437;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._toString13437)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._toString13437)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13438;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Constructor._hashCode13438);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._hashCode13438);
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers13439;
		public int getModifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getModifiers13439);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getModifiers13439);
		}
		internal static global::MonoJavaBridge.MethodId _getName13440;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getName13440)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getName13440)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance13441;
		public global::java.lang.Object newInstance(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._newInstance13441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._newInstance13441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic13442;
		public bool isSynthetic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Constructor._isSynthetic13442);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._isSynthetic13442);
		}
		internal static global::MonoJavaBridge.MethodId _getTypeParameters13443;
		public global::java.lang.reflect.TypeVariable[] getTypeParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getTypeParameters13443)) as java.lang.reflect.TypeVariable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getTypeParameters13443)) as java.lang.reflect.TypeVariable[];
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass13444;
		public global::java.lang.Class getDeclaringClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getDeclaringClass13444)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getDeclaringClass13444)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation13445;
		public sealed override global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getAnnotation13445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getAnnotation13445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations13446;
		public sealed override global::java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getDeclaredAnnotations13446)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getDeclaredAnnotations13446)) as java.lang.annotation.Annotation[];
		}
		internal static global::MonoJavaBridge.MethodId _getParameterTypes13447;
		public global::java.lang.Class[] getParameterTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getParameterTypes13447)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getParameterTypes13447)) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _toGenericString13448;
		public global::java.lang.String toGenericString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._toGenericString13448)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._toGenericString13448)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getGenericParameterTypes13449;
		public global::java.lang.reflect.Type[] getGenericParameterTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getGenericParameterTypes13449)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getGenericParameterTypes13449)) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _getExceptionTypes13450;
		public global::java.lang.Class[] getExceptionTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getExceptionTypes13450)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getExceptionTypes13450)) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _getGenericExceptionTypes13451;
		public global::java.lang.reflect.Type[] getGenericExceptionTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getGenericExceptionTypes13451)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getGenericExceptionTypes13451)) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _isVarArgs13452;
		public bool isVarArgs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Constructor._isVarArgs13452);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._isVarArgs13452);
		}
		internal static global::MonoJavaBridge.MethodId _getParameterAnnotations13453;
		public global::java.lang.annotation.Annotation[][] getParameterAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation[]>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor._getParameterAnnotations13453)) as java.lang.annotation.Annotation[][];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation[]>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Constructor.staticClass, global::java.lang.reflect.Constructor._getParameterAnnotations13453)) as java.lang.annotation.Annotation[][];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Constructor.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Constructor"));
			global::java.lang.reflect.Constructor._equals13436 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.reflect.Constructor._toString13437 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.reflect.Constructor._hashCode13438 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "hashCode", "()I");
			global::java.lang.reflect.Constructor._getModifiers13439 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getModifiers", "()I");
			global::java.lang.reflect.Constructor._getName13440 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.reflect.Constructor._newInstance13441 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "newInstance", "([Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.lang.reflect.Constructor._isSynthetic13442 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "isSynthetic", "()Z");
			global::java.lang.reflect.Constructor._getTypeParameters13443 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
			global::java.lang.reflect.Constructor._getDeclaringClass13444 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			global::java.lang.reflect.Constructor._getAnnotation13445 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Constructor._getDeclaredAnnotations13446 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Constructor._getParameterTypes13447 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getParameterTypes", "()[Ljava/lang/Class;");
			global::java.lang.reflect.Constructor._toGenericString13448 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "toGenericString", "()Ljava/lang/String;");
			global::java.lang.reflect.Constructor._getGenericParameterTypes13449 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Constructor._getExceptionTypes13450 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getExceptionTypes", "()[Ljava/lang/Class;");
			global::java.lang.reflect.Constructor._getGenericExceptionTypes13451 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Constructor._isVarArgs13452 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "isVarArgs", "()Z");
			global::java.lang.reflect.Constructor._getParameterAnnotations13453 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Constructor.staticClass, "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;");
		}
	}
}
