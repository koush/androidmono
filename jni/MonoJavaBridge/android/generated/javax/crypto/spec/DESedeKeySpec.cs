namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DESedeKeySpec : java.lang.Object, java.security.spec.KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DESedeKeySpec()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getKey28643;
		public virtual byte[] getKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.DESedeKeySpec._getKey28643)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.DESedeKeySpec.staticClass, global::javax.crypto.spec.DESedeKeySpec._getKey28643)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _isParityAdjusted28644;
		public static bool isParityAdjusted(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(javax.crypto.spec.DESedeKeySpec.staticClass, global::javax.crypto.spec.DESedeKeySpec._isParityAdjusted28644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DESedeKeySpec28645;
		public DESedeKeySpec(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DESedeKeySpec.staticClass, global::javax.crypto.spec.DESedeKeySpec._DESedeKeySpec28645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DESedeKeySpec28646;
		public DESedeKeySpec(byte[] arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.DESedeKeySpec.staticClass, global::javax.crypto.spec.DESedeKeySpec._DESedeKeySpec28646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int DES_EDE_KEY_LEN
		{
			get
			{
				return 24;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.DESedeKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/DESedeKeySpec"));
			global::javax.crypto.spec.DESedeKeySpec._getKey28643 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DESedeKeySpec.staticClass, "getKey", "()[B");
			global::javax.crypto.spec.DESedeKeySpec._isParityAdjusted28644 = @__env.GetStaticMethodIDNoThrow(global::javax.crypto.spec.DESedeKeySpec.staticClass, "isParityAdjusted", "([BI)Z");
			global::javax.crypto.spec.DESedeKeySpec._DESedeKeySpec28645 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DESedeKeySpec.staticClass, "<init>", "([B)V");
			global::javax.crypto.spec.DESedeKeySpec._DESedeKeySpec28646 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.DESedeKeySpec.staticClass, "<init>", "([BI)V");
		}
	}
}
