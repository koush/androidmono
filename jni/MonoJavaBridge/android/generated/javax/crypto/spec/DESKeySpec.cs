namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DESKeySpec : java.lang.Object, java.security.spec.KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DESKeySpec()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getKey28637;
		public virtual byte[] getKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.DESKeySpec._getKey28637)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.DESKeySpec.staticClass, global::javax.crypto.spec.DESKeySpec._getKey28637)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _isParityAdjusted28638;
		public static bool isParityAdjusted(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(javax.crypto.spec.DESKeySpec.staticClass, global::javax.crypto.spec.DESKeySpec._isParityAdjusted28638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isWeak28639;
		public static bool isWeak(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(javax.crypto.spec.DESKeySpec.staticClass, global::javax.crypto.spec.DESKeySpec._isWeak28639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DESKeySpec28640;
		public DESKeySpec(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DESKeySpec.staticClass, global::javax.crypto.spec.DESKeySpec._DESKeySpec28640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DESKeySpec28641;
		public DESKeySpec(byte[] arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DESKeySpec.staticClass, global::javax.crypto.spec.DESKeySpec._DESKeySpec28641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int DES_KEY_LEN
		{
			get
			{
				return 8;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.DESKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/DESKeySpec"));
			global::javax.crypto.spec.DESKeySpec._getKey28637 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DESKeySpec.staticClass, "getKey", "()[B");
			global::javax.crypto.spec.DESKeySpec._isParityAdjusted28638 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.spec.DESKeySpec.staticClass, "isParityAdjusted", "([BI)Z");
			global::javax.crypto.spec.DESKeySpec._isWeak28639 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.spec.DESKeySpec.staticClass, "isWeak", "([BI)Z");
			global::javax.crypto.spec.DESKeySpec._DESKeySpec28640 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DESKeySpec.staticClass, "<init>", "([B)V");
			global::javax.crypto.spec.DESKeySpec._DESKeySpec28641 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DESKeySpec.staticClass, "<init>", "([BI)V");
		}
	}
}
