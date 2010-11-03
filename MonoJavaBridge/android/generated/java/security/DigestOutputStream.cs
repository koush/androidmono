namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DigestOutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DigestOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.DigestOutputStream.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.DigestOutputStream._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.DigestOutputStream.staticClass, "write", "(I)V", ref global::java.security.DigestOutputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.DigestOutputStream.staticClass, "write", "([BII)V", ref global::java.security.DigestOutputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void on(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.DigestOutputStream.staticClass, "on", "(Z)V", ref global::java.security.DigestOutputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.MessageDigest MessageDigest
		{
			get
			{
				return getMessageDigest();
			}
			set
			{
				setMessageDigest(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.security.MessageDigest getMessageDigest()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.DigestOutputStream.staticClass, "getMessageDigest", "()Ljava/security/MessageDigest;", ref global::java.security.DigestOutputStream._m4) as java.security.MessageDigest;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setMessageDigest(java.security.MessageDigest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.DigestOutputStream.staticClass, "setMessageDigest", "(Ljava/security/MessageDigest;)V", ref global::java.security.DigestOutputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public DigestOutputStream(java.io.OutputStream arg0, java.security.MessageDigest arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.DigestOutputStream._m6.native == global::System.IntPtr.Zero)
				global::java.security.DigestOutputStream._m6 = @__env.GetMethodIDNoThrow(global::java.security.DigestOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/security/MessageDigest;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.DigestOutputStream.staticClass, global::java.security.DigestOutputStream._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DigestOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.DigestOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/DigestOutputStream"));
		}
	}
}
