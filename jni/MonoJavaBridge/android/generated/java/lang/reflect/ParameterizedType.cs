namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.reflect.ParameterizedType_))]
	public interface ParameterizedType : Type
	{
		global::java.lang.reflect.Type[] getActualTypeArguments();
		global::java.lang.reflect.Type getRawType();
		global::java.lang.reflect.Type getOwnerType();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.reflect.ParameterizedType))]
	public sealed partial class ParameterizedType_ : java.lang.Object, ParameterizedType
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ParameterizedType_()
		{
			InitJNI();
		}
		internal ParameterizedType_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getActualTypeArguments21026;
		 global::java.lang.reflect.Type[] java.lang.reflect.ParameterizedType.getActualTypeArguments() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.ParameterizedType_._getActualTypeArguments21026)) as java.lang.reflect.Type[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.ParameterizedType_.staticClass, global::java.lang.reflect.ParameterizedType_._getActualTypeArguments21026)) as java.lang.reflect.Type[];
		}
		internal static global::MonoJavaBridge.MethodId _getRawType21027;
		 global::java.lang.reflect.Type java.lang.reflect.ParameterizedType.getRawType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.ParameterizedType_._getRawType21027)) as java.lang.reflect.Type;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.ParameterizedType_.staticClass, global::java.lang.reflect.ParameterizedType_._getRawType21027)) as java.lang.reflect.Type;
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerType21028;
		 global::java.lang.reflect.Type java.lang.reflect.ParameterizedType.getOwnerType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.ParameterizedType_._getOwnerType21028)) as java.lang.reflect.Type;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.ParameterizedType_.staticClass, global::java.lang.reflect.ParameterizedType_._getOwnerType21028)) as java.lang.reflect.Type;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.ParameterizedType_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/ParameterizedType"));
			global::java.lang.reflect.ParameterizedType_._getActualTypeArguments21026 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.ParameterizedType_.staticClass, "getActualTypeArguments", "()[Ljava/lang/reflect/Type;");
			global::java.lang.reflect.ParameterizedType_._getRawType21027 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.ParameterizedType_.staticClass, "getRawType", "()Ljava/lang/reflect/Type;");
			global::java.lang.reflect.ParameterizedType_._getOwnerType21028 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.ParameterizedType_.staticClass, "getOwnerType", "()Ljava/lang/reflect/Type;");
		}
	}
}
