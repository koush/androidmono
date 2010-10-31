namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RC5ParameterSpec : java.lang.Object, java.security.spec.AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RC5ParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.crypto.spec.RC5ParameterSpec.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::javax.crypto.spec.RC5ParameterSpec._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.RC5ParameterSpec.staticClass, "hashCode", "()I", ref global::javax.crypto.spec.RC5ParameterSpec._m1);
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.RC5ParameterSpec.staticClass, "getVersion", "()I", ref global::javax.crypto.spec.RC5ParameterSpec._m2);
		}
		public new byte[] IV
		{
			get
			{
				return getIV();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual byte[] getIV()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.spec.RC5ParameterSpec.staticClass, "getIV", "()[B", ref global::javax.crypto.spec.RC5ParameterSpec._m3) as byte[];
		}
		public new int Rounds
		{
			get
			{
				return getRounds();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getRounds()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.RC5ParameterSpec.staticClass, "getRounds", "()I", ref global::javax.crypto.spec.RC5ParameterSpec._m4);
		}
		public new int WordSize
		{
			get
			{
				return getWordSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getWordSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.RC5ParameterSpec.staticClass, "getWordSize", "()I", ref global::javax.crypto.spec.RC5ParameterSpec._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public RC5ParameterSpec(int arg0, int arg1, int arg2, byte[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.RC5ParameterSpec._m6.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.RC5ParameterSpec._m6 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC5ParameterSpec.staticClass, "<init>", "(III[B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.RC5ParameterSpec.staticClass, global::javax.crypto.spec.RC5ParameterSpec._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public RC5ParameterSpec(int arg0, int arg1, int arg2, byte[] arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.RC5ParameterSpec._m7.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.RC5ParameterSpec._m7 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC5ParameterSpec.staticClass, "<init>", "(III[BI)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.RC5ParameterSpec.staticClass, global::javax.crypto.spec.RC5ParameterSpec._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public RC5ParameterSpec(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.RC5ParameterSpec._m8.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.RC5ParameterSpec._m8 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC5ParameterSpec.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.RC5ParameterSpec.staticClass, global::javax.crypto.spec.RC5ParameterSpec._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static RC5ParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.RC5ParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/RC5ParameterSpec"));
		}
	}
}
