namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.MessageDigestSpi_))]
	public abstract partial class MessageDigestSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MessageDigestSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone23183;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.MessageDigestSpi._clone23183.native == global::System.IntPtr.Zero)
				global::java.security.MessageDigestSpi._clone23183 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._clone23183) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23184;
		protected abstract void engineUpdate(byte arg0);
		internal static global::MonoJavaBridge.MethodId _engineUpdate23185;
		protected abstract void engineUpdate(byte[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _engineUpdate23186;
		protected virtual void engineUpdate(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.MessageDigestSpi._engineUpdate23186.native == global::System.IntPtr.Zero)
				global::java.security.MessageDigestSpi._engineUpdate23186 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._engineUpdate23186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineDigest23187;
		protected abstract byte[] engineDigest();
		internal static global::MonoJavaBridge.MethodId _engineDigest23188;
		protected virtual int engineDigest(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.MessageDigestSpi._engineDigest23188.native == global::System.IntPtr.Zero)
				global::java.security.MessageDigestSpi._engineDigest23188 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineDigest", "([BII)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._engineDigest23188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineReset23189;
		protected abstract void engineReset();
		internal static global::MonoJavaBridge.MethodId _engineGetDigestLength23190;
		protected virtual int engineGetDigestLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.MessageDigestSpi._engineGetDigestLength23190.native == global::System.IntPtr.Zero)
				global::java.security.MessageDigestSpi._engineGetDigestLength23190 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineGetDigestLength", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._engineGetDigestLength23190);
		}
		internal static global::MonoJavaBridge.MethodId _MessageDigestSpi23191;
		public MessageDigestSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.MessageDigestSpi._MessageDigestSpi23191.native == global::System.IntPtr.Zero)
				global::java.security.MessageDigestSpi._MessageDigestSpi23191 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._MessageDigestSpi23191);
			Init(@__env, handle);
		}
		static MessageDigestSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigestSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigestSpi"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.MessageDigestSpi))]
	internal sealed partial class MessageDigestSpi_ : java.security.MessageDigestSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MessageDigestSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23192;
		protected override void engineUpdate(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.MessageDigestSpi_._engineUpdate23192.native == global::System.IntPtr.Zero)
				global::java.security.MessageDigestSpi_._engineUpdate23192 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi_.staticClass, "engineUpdate", "(B)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi_._engineUpdate23192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23193;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.MessageDigestSpi_._engineUpdate23193.native == global::System.IntPtr.Zero)
				global::java.security.MessageDigestSpi_._engineUpdate23193 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi_.staticClass, "engineUpdate", "([BII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi_._engineUpdate23193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineDigest23194;
		protected override byte[] engineDigest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.MessageDigestSpi_._engineDigest23194.native == global::System.IntPtr.Zero)
				global::java.security.MessageDigestSpi_._engineDigest23194 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi_.staticClass, "engineDigest", "()[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigestSpi_._engineDigest23194)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineReset23195;
		protected override void engineReset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.MessageDigestSpi_._engineReset23195.native == global::System.IntPtr.Zero)
				global::java.security.MessageDigestSpi_._engineReset23195 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi_.staticClass, "engineReset", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi_._engineReset23195);
		}
		static MessageDigestSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigestSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigestSpi"));
		}
		internal static void InitJNI()
		{
		}
	}
}
