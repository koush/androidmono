namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PBEParameterSpec : java.lang.Object, java.security.spec.AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PBEParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int IterationCount
		{
			get
			{
				return getIterationCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIterationCount28800;
		public virtual int getIterationCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.PBEParameterSpec._getIterationCount28800.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.PBEParameterSpec._getIterationCount28800 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEParameterSpec.staticClass, "getIterationCount", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.PBEParameterSpec.staticClass, global::javax.crypto.spec.PBEParameterSpec._getIterationCount28800);
		}
		public new byte[] Salt
		{
			get
			{
				return getSalt();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSalt28801;
		public virtual byte[] getSalt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.PBEParameterSpec._getSalt28801.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.PBEParameterSpec._getSalt28801 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEParameterSpec.staticClass, "getSalt", "()[B");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.spec.PBEParameterSpec.staticClass, global::javax.crypto.spec.PBEParameterSpec._getSalt28801) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _PBEParameterSpec28802;
		public PBEParameterSpec(byte[] arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.PBEParameterSpec._PBEParameterSpec28802.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.PBEParameterSpec._PBEParameterSpec28802 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEParameterSpec.staticClass, "<init>", "([BI)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PBEParameterSpec.staticClass, global::javax.crypto.spec.PBEParameterSpec._PBEParameterSpec28802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static PBEParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.PBEParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/PBEParameterSpec"));
		}
		internal static void InitJNI()
		{
		}
	}
}
