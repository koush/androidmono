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
		internal static global::MonoJavaBridge.MethodId _getKey28756;
		public virtual byte[] getKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.spec.DESKeySpec.staticClass, "getKey", "()[B", ref global::javax.crypto.spec.DESKeySpec._getKey28756) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _isParityAdjusted28757;
		public static bool isParityAdjusted(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DESKeySpec._isParityAdjusted28757.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DESKeySpec._isParityAdjusted28757 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.spec.DESKeySpec.staticClass, "isParityAdjusted", "([BI)Z");
			return @__env.CallStaticBooleanMethod(javax.crypto.spec.DESKeySpec.staticClass, global::javax.crypto.spec.DESKeySpec._isParityAdjusted28757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isWeak28758;
		public static bool isWeak(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DESKeySpec._isWeak28758.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DESKeySpec._isWeak28758 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.spec.DESKeySpec.staticClass, "isWeak", "([BI)Z");
			return @__env.CallStaticBooleanMethod(javax.crypto.spec.DESKeySpec.staticClass, global::javax.crypto.spec.DESKeySpec._isWeak28758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DESKeySpec28759;
		public DESKeySpec(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DESKeySpec._DESKeySpec28759.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DESKeySpec._DESKeySpec28759 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DESKeySpec.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DESKeySpec.staticClass, global::javax.crypto.spec.DESKeySpec._DESKeySpec28759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DESKeySpec28760;
		public DESKeySpec(byte[] arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.DESKeySpec._DESKeySpec28760.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.DESKeySpec._DESKeySpec28760 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DESKeySpec.staticClass, "<init>", "([BI)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DESKeySpec.staticClass, global::javax.crypto.spec.DESKeySpec._DESKeySpec28760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static void InitJNI()
		{
		}
	}
}
