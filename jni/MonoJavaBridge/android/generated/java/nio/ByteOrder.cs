namespace java.nio
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ByteOrder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ByteOrder()
		{
			InitJNI();
		}
		internal ByteOrder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString14098;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteOrder._toString14098)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteOrder.staticClass, global::java.nio.ByteOrder._toString14098)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nativeOrder14099;
		public static global::java.nio.ByteOrder nativeOrder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.ByteOrder.staticClass, global::java.nio.ByteOrder._nativeOrder14099)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.FieldId _BIG_ENDIAN14100;
		public static global::java.nio.ByteOrder BIG_ENDIAN
		{
			get
			{
				return default(global::java.nio.ByteOrder);
			}
		}
		internal static global::MonoJavaBridge.FieldId _LITTLE_ENDIAN14101;
		public static global::java.nio.ByteOrder LITTLE_ENDIAN
		{
			get
			{
				return default(global::java.nio.ByteOrder);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteOrder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteOrder"));
			global::java.nio.ByteOrder._toString14098 = @__env.GetMethodIDNoThrow(global::java.nio.ByteOrder.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.ByteOrder._nativeOrder14099 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteOrder.staticClass, "nativeOrder", "()Ljava/nio/ByteOrder;");
		}
	}
}
