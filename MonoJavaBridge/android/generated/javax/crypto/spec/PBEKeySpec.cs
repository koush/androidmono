namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PBEKeySpec : java.lang.Object, java.security.spec.KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PBEKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new char[] Password
		{
			get
			{
				return getPassword();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual char[] getPassword()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::javax.crypto.spec.PBEKeySpec.staticClass, "getPassword", "()[C", ref global::javax.crypto.spec.PBEKeySpec._m0) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void clearPassword()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.spec.PBEKeySpec.staticClass, "clearPassword", "()V", ref global::javax.crypto.spec.PBEKeySpec._m1);
		}
		public new int IterationCount
		{
			get
			{
				return getIterationCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getIterationCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.PBEKeySpec.staticClass, "getIterationCount", "()I", ref global::javax.crypto.spec.PBEKeySpec._m2);
		}
		public new byte[] Salt
		{
			get
			{
				return getSalt();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual byte[] getSalt()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.spec.PBEKeySpec.staticClass, "getSalt", "()[B", ref global::javax.crypto.spec.PBEKeySpec._m3) as byte[];
		}
		public new int KeyLength
		{
			get
			{
				return getKeyLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getKeyLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.spec.PBEKeySpec.staticClass, "getKeyLength", "()I", ref global::javax.crypto.spec.PBEKeySpec._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public PBEKeySpec(char[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.PBEKeySpec._m5.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.PBEKeySpec._m5 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "<init>", "([C)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public PBEKeySpec(char[] arg0, byte[] arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.PBEKeySpec._m6.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.PBEKeySpec._m6 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "<init>", "([C[BII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public PBEKeySpec(char[] arg0, byte[] arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.spec.PBEKeySpec._m7.native == global::System.IntPtr.Zero)
				global::javax.crypto.spec.PBEKeySpec._m7 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEKeySpec.staticClass, "<init>", "([C[BI)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PBEKeySpec.staticClass, global::javax.crypto.spec.PBEKeySpec._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static PBEKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.PBEKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/PBEKeySpec"));
		}
	}
}
