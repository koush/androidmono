namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DESedeKeySpec : java.lang.Object, java.security.spec.KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DESedeKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new byte[] Key
		{
			get
			{
				return getKey();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKey28762;
		public virtual byte[] getKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.DESedeKeySpec._getKey28762)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.DESedeKeySpec.staticClass, global::javax.crypto.spec.DESedeKeySpec._getKey28762)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _isParityAdjusted28763;
		public static bool isParityAdjusted(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(javax.crypto.spec.DESedeKeySpec.staticClass, global::javax.crypto.spec.DESedeKeySpec._isParityAdjusted28763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DESedeKeySpec28764;
		public DESedeKeySpec(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DESedeKeySpec.staticClass, global::javax.crypto.spec.DESedeKeySpec._DESedeKeySpec28764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DESedeKeySpec28765;
		public DESedeKeySpec(byte[] arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DESedeKeySpec.staticClass, global::javax.crypto.spec.DESedeKeySpec._DESedeKeySpec28765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int DES_EDE_KEY_LEN
		{
			get
			{
				return 24;
			}
		}
		static DESedeKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.DESedeKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/DESedeKeySpec"));
			global::javax.crypto.spec.DESedeKeySpec._getKey28762 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DESedeKeySpec.staticClass, "getKey", "()[B");
			global::javax.crypto.spec.DESedeKeySpec._isParityAdjusted28763 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.spec.DESedeKeySpec.staticClass, "isParityAdjusted", "([BI)Z");
			global::javax.crypto.spec.DESedeKeySpec._DESedeKeySpec28764 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DESedeKeySpec.staticClass, "<init>", "([B)V");
			global::javax.crypto.spec.DESedeKeySpec._DESedeKeySpec28765 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DESedeKeySpec.staticClass, "<init>", "([BI)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
