namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DESKeySpec : java.lang.Object, java.security.spec.KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DESKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new byte[] Key
		{
			get
			{
				return getKey();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual byte[] getKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.spec.DESKeySpec.staticClass, "getKey", "()[B", ref global::javax.crypto.spec.DESKeySpec._m0) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static bool isParityAdjusted(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DESKeySpec._m1.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DESKeySpec._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.spec.DESKeySpec.staticClass, "isParityAdjusted", "([BI)Z");
			return @__env.CallStaticBooleanMethod(javax.crypto.spec.DESKeySpec.staticClass, global::javax.crypto.spec.DESKeySpec._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static bool isWeak(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DESKeySpec._m2.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DESKeySpec._m2 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.spec.DESKeySpec.staticClass, "isWeak", "([BI)Z");
			return @__env.CallStaticBooleanMethod(javax.crypto.spec.DESKeySpec.staticClass, global::javax.crypto.spec.DESKeySpec._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public DESKeySpec(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DESKeySpec._m3.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DESKeySpec._m3 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DESKeySpec.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DESKeySpec.staticClass, global::javax.crypto.spec.DESKeySpec._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public DESKeySpec(byte[] arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DESKeySpec._m4.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DESKeySpec._m4 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DESKeySpec.staticClass, "<init>", "([BI)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DESKeySpec.staticClass, global::javax.crypto.spec.DESKeySpec._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int DES_KEY_LEN
		{
			get
			{
				return 8;
			}
		}
		static DESKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.DESKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/DESKeySpec"));
		}
	}
}
