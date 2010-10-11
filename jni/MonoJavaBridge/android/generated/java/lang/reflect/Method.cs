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
		internal static global::MonoJavaBridge.MethodId _invoke13490;
		public global::java.lang.Object invoke(java.lang.Object arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._invoke13490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._invoke13490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals13491;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method._equals13491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._equals13491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString13492;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._toString13492)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._toString13492)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13493;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Method._hashCode13493);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._hashCode13493);
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers13494;
		public int getModifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Method._getModifiers13494);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getModifiers13494);
		}
		internal static global::MonoJavaBridge.MethodId _getName13495;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getName13495)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getName13495)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic13496;
		public bool isSynthetic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method._isSynthetic13496);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._isSynthetic13496);
		}
		internal static global::MonoJavaBridge.MethodId _getTypeParameters13497;
		public global::java.lang.reflect.TypeVariable[] getTypeParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getTypeParameters13497)) as java.lang.reflect.TypeVariable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.TypeVariable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getTypeParameters13497)) as java.lang.reflect.TypeVariable[];
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass13498;
		public global::java.lang.Class getDeclaringClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getDeclaringClass13498)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getDeclaringClass13498)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation13499;
		public sealed override global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getAnnotation13499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getAnnotation13499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations13500;
		public sealed override global::java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getDeclaredAnnotations13500)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getDeclaredAnnotations13500)) as java.lang.annotation.Annotation[];
		}
		internal static global::MonoJavaBridge.MethodId _getReturnType13501;
		public global::java.lang.Class getReturnType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getReturnType13501)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getReturnType13501)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getParameterTypes13502;
		public global::java.lang.Class[] getParameterTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getParameterTypes13502)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getParameterTypes13502)) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _toGenericString13503;
		public global::java.lang.String toGenericString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._toGenericString13503)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._toGenericString13503)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getGenericReturnType13504;
		public global::java.lang.reflect.Type getGenericReturnType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getGenericReturnType13504)) as java.lang.reflect.Type;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getGenericReturnType13504)) as java.lang.reflect.Type;
		}
		internal static global::MonoJavaBridge.MethodId _getGenericParameterTypes13505;
		public global::java.lang.reflect.Type[] getGenericParameterTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getGenericParameterTypes13505)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getGenericParameterTypes13505)) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _getExceptionTypes13506;
		public global::java.lang.Class[] getExceptionTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getExceptionTypes13506)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getExceptionTypes13506)) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _getGenericExceptionTypes13507;
		public global::java.lang.reflect.Type[] getGenericExceptionTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getGenericExceptionTypes13507)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getGenericExceptionTypes13507)) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _isBridge13508;
		public bool isBridge() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method._isBridge13508);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._isBridge13508);
		}
		internal static global::MonoJavaBridge.MethodId _isVarArgs13509;
		public bool isVarArgs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method._isVarArgs13509);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._isVarArgs13509);
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultValue13510;
		public global::java.lang.Object getDefaultValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getDefaultValue13510)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getDefaultValue13510)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getParameterAnnotations13511;
		public global::java.lang.annotation.Annotation[][] getParameterAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation[]>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Method._getParameterAnnotations13511)) as java.lang.annotation.Annotation[][];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation[]>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._getParameterAnnotations13511)) as java.lang.annotation.Annotation[][];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Method.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Method"));
			global::java.lang.reflect.Method._invoke13490 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "invoke", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.lang.reflect.Method._equals13491 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.reflect.Method._toString13492 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.reflect.Method._hashCode13493 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "hashCode", "()I");
			global::java.lang.reflect.Method._getModifiers13494 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getModifiers", "()I");
			global::java.lang.reflect.Method._getName13495 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.reflect.Method._isSynthetic13496 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "isSynthetic", "()Z");
			global::java.lang.reflect.Method._getTypeParameters13497 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
			global::java.lang.reflect.Method._getDeclaringClass13498 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			global::java.lang.reflect.Method._getAnnotation13499 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Method._getDeclaredAnnotations13500 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Method._getReturnType13501 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getReturnType", "()Ljava/lang/Class;");
			global::java.lang.reflect.Method._getParameterTypes13502 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getParameterTypes", "()[Ljava/lang/Class;");
			global::java.lang.reflect.Method._toGenericString13503 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "toGenericString", "()Ljava/lang/String;");
			global::java.lang.reflect.Method._getGenericReturnType13504 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getGenericReturnType", "()Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Method._getGenericParameterTypes13505 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Method._getExceptionTypes13506 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getExceptionTypes", "()[Ljava/lang/Class;");
			global::java.lang.reflect.Method._getGenericExceptionTypes13507 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Method._isBridge13508 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "isBridge", "()Z");
			global::java.lang.reflect.Method._isVarArgs13509 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "isVarArgs", "()Z");
			global::java.lang.reflect.Method._getDefaultValue13510 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getDefaultValue", "()Ljava/lang/Object;");
			global::java.lang.reflect.Method._getParameterAnnotations13511 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Method.staticClass, "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;");
		}
	}
}
