namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.MessageDigestSpi_))]
	public abstract partial class MessageDigestSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MessageDigestSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.MessageDigestSpi.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.MessageDigestSpi._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected abstract void engineUpdate(byte arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		protected abstract void engineUpdate(byte[] arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual void engineUpdate(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.MessageDigestSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;)V", ref global::java.security.MessageDigestSpi._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected abstract byte[] engineDigest();
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual int engineDigest(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.MessageDigestSpi.staticClass, "engineDigest", "([BII)I", ref global::java.security.MessageDigestSpi._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected abstract void engineReset();
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual int engineGetDigestLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.MessageDigestSpi.staticClass, "engineGetDigestLength", "()I", ref global::java.security.MessageDigestSpi._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public MessageDigestSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.MessageDigestSpi._m8.native == global::System.IntPtr.Zero)
				global::java.security.MessageDigestSpi._m8 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._m8);
			Init(@__env, handle);
		}
		static MessageDigestSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigestSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigestSpi"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.MessageDigestSpi))]
	internal sealed partial class MessageDigestSpi_ : java.security.MessageDigestSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MessageDigestSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void engineUpdate(byte arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.MessageDigestSpi_.staticClass, "engineUpdate", "(B)V", ref global::java.security.MessageDigestSpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.MessageDigestSpi_.staticClass, "engineUpdate", "([BII)V", ref global::java.security.MessageDigestSpi_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override byte[] engineDigest()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.MessageDigestSpi_.staticClass, "engineDigest", "()[B", ref global::java.security.MessageDigestSpi_._m2) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void engineReset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.MessageDigestSpi_.staticClass, "engineReset", "()V", ref global::java.security.MessageDigestSpi_._m3);
		}
		static MessageDigestSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigestSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigestSpi"));
		}
	}
}
