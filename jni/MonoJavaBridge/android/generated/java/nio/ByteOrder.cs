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
		internal static global::MonoJavaBridge.MethodId _toString22114;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.ByteOrder._toString22114)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.ByteOrder.staticClass, global::java.nio.ByteOrder._toString22114)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nativeOrder22115;
		public static global::java.nio.ByteOrder nativeOrder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.CallStaticObjectMethod(java.nio.ByteOrder.staticClass, global::java.nio.ByteOrder._nativeOrder22115)) as java.nio.ByteOrder;
		}
		internal static global::MonoJavaBridge.FieldId _BIG_ENDIAN22116;
		public static global::java.nio.ByteOrder BIG_ENDIAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.GetStaticObjectField(global::java.nio.ByteOrder.staticClass, _BIG_ENDIAN22116)) as java.nio.ByteOrder;
			}
		}
		internal static global::MonoJavaBridge.FieldId _LITTLE_ENDIAN22117;
		public static global::java.nio.ByteOrder LITTLE_ENDIAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.nio.ByteOrder>(@__env.GetStaticObjectField(global::java.nio.ByteOrder.staticClass, _LITTLE_ENDIAN22117)) as java.nio.ByteOrder;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ByteOrder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ByteOrder"));
			global::java.nio.ByteOrder._toString22114 = @__env.GetMethodIDNoThrow(global::java.nio.ByteOrder.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.ByteOrder._nativeOrder22115 = @__env.GetStaticMethodIDNoThrow(global::java.nio.ByteOrder.staticClass, "nativeOrder", "()Ljava/nio/ByteOrder;");
			global::java.nio.ByteOrder._BIG_ENDIAN22116 = @__env.GetStaticFieldIDNoThrow(global::java.nio.ByteOrder.staticClass, "BIG_ENDIAN", "Ljava/nio/ByteOrder;");
			global::java.nio.ByteOrder._LITTLE_ENDIAN22117 = @__env.GetStaticFieldIDNoThrow(global::java.nio.ByteOrder.staticClass, "LITTLE_ENDIAN", "Ljava/nio/ByteOrder;");
		}
	}
}
