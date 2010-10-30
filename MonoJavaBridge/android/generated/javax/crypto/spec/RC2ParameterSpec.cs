namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RC2ParameterSpec : java.lang.Object, java.security.spec.AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RC2ParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.crypto.spec.RC2ParameterSpec.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::javax.crypto.spec.RC2ParameterSpec._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.RC2ParameterSpec.staticClass, "hashCode", "()I", ref global::javax.crypto.spec.RC2ParameterSpec._m1);
		}
		public new byte[] IV
		{
			get
			{
				return getIV();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual byte[] getIV()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.spec.RC2ParameterSpec.staticClass, "getIV", "()[B", ref global::javax.crypto.spec.RC2ParameterSpec._m2) as byte[];
		}
		public new int EffectiveKeyBits
		{
			get
			{
				return getEffectiveKeyBits();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getEffectiveKeyBits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.RC2ParameterSpec.staticClass, "getEffectiveKeyBits", "()I", ref global::javax.crypto.spec.RC2ParameterSpec._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public RC2ParameterSpec(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.RC2ParameterSpec._m4.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.RC2ParameterSpec._m4 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC2ParameterSpec.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.RC2ParameterSpec.staticClass, global::javax.crypto.spec.RC2ParameterSpec._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public RC2ParameterSpec(int arg0, byte[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.RC2ParameterSpec._m5.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.RC2ParameterSpec._m5 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC2ParameterSpec.staticClass, "<init>", "(I[B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.RC2ParameterSpec.staticClass, global::javax.crypto.spec.RC2ParameterSpec._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public RC2ParameterSpec(int arg0, byte[] arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.RC2ParameterSpec._m6.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.RC2ParameterSpec._m6 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC2ParameterSpec.staticClass, "<init>", "(I[BI)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.RC2ParameterSpec.staticClass, global::javax.crypto.spec.RC2ParameterSpec._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static RC2ParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.RC2ParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/RC2ParameterSpec"));
		}
		internal static void InitJNI()
		{
		}
	}
}
