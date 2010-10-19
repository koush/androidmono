namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IvParameterSpec : java.lang.Object, java.security.spec.AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IvParameterSpec()
		{
			InitJNI();
		}
		protected IvParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new byte[] IV
		{
			get
			{
				return getIV();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIV22762;
		public virtual byte[] getIV() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.IvParameterSpec._getIV22762)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.IvParameterSpec.staticClass, global::javax.crypto.spec.IvParameterSpec._getIV22762)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _IvParameterSpec22763;
		public IvParameterSpec(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.IvParameterSpec.staticClass, global::javax.crypto.spec.IvParameterSpec._IvParameterSpec22763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IvParameterSpec22764;
		public IvParameterSpec(byte[] arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.IvParameterSpec.staticClass, global::javax.crypto.spec.IvParameterSpec._IvParameterSpec22764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.IvParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/IvParameterSpec"));
			global::javax.crypto.spec.IvParameterSpec._getIV22762 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.IvParameterSpec.staticClass, "getIV", "()[B");
			global::javax.crypto.spec.IvParameterSpec._IvParameterSpec22763 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.IvParameterSpec.staticClass, "<init>", "([B)V");
			global::javax.crypto.spec.IvParameterSpec._IvParameterSpec22764 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.IvParameterSpec.staticClass, "<init>", "([BII)V");
		}
	}
}
