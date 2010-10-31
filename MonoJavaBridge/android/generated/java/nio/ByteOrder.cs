namespace java.nio
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ByteOrder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ByteOrder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.ByteOrder.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.ByteOrder._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.nio.ByteOrder nativeOrder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.ByteOrder._m1.native == global::System.IntPtr.Zero)
				global::java.nio.ByteOrder._m1 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteOrder.staticClass, "nativeOrder", "()Ljava/nio/ByteOrder;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallStaticObjectMethod(java.nio.ByteOrder.staticClass, global::java.nio.ByteOrder._m1)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.FieldId _BIG_ENDIAN6490;
		public static global::java.nio.ByteOrder BIG_ENDIAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.GetStaticObjectField(global::java.nio.ByteOrder.staticClass, _BIG_ENDIAN6490)) as java.nio.ByteOrder;
			}
		}
		internal static global::MonoJavaBridge.FieldId _LITTLE_ENDIAN6491;
		public static global::java.nio.ByteOrder LITTLE_ENDIAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.GetStaticObjectField(global::java.nio.ByteOrder.staticClass, _LITTLE_ENDIAN6491)) as java.nio.ByteOrder;
			}
		}
		static ByteOrder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteOrder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteOrder"));
			global::java.nio.ByteOrder._BIG_ENDIAN6490 = @__env.GetStaticFieldIDNoThrow(global::java.nio.ByteOrder.staticClass, "BIG_ENDIAN", "Ljava/nio/ByteOrder;");
			global::java.nio.ByteOrder._LITTLE_ENDIAN6491 = @__env.GetStaticFieldIDNoThrow(global::java.nio.ByteOrder.staticClass, "LITTLE_ENDIAN", "Ljava/nio/ByteOrder;");
		}
	}
}
