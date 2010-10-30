namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DigestOutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DigestOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString22945;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.DigestOutputStream.staticClass, global::java.security.DigestOutputStream._toString22945)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _write22946;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.DigestOutputStream.staticClass, global::java.security.DigestOutputStream._write22946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22947;
		public override void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.DigestOutputStream.staticClass, global::java.security.DigestOutputStream._write22947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _on22948;
		public virtual void on(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.DigestOutputStream.staticClass, global::java.security.DigestOutputStream._on22948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMessageDigest22949;
		public virtual global::java.security.MessageDigest getMessageDigest()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.DigestOutputStream.staticClass, global::java.security.DigestOutputStream._getMessageDigest22949)) as java.security.MessageDigest;
		}
		internal static global::MonoJavaBridge.MethodId _setMessageDigest22950;
		public virtual void setMessageDigest(java.security.MessageDigest arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.DigestOutputStream.staticClass, global::java.security.DigestOutputStream._setMessageDigest22950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DigestOutputStream22951;
		public DigestOutputStream(java.io.OutputStream arg0, java.security.MessageDigest arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.DigestOutputStream.staticClass, global::java.security.DigestOutputStream._DigestOutputStream22951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DigestOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.DigestOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/DigestOutputStream"));
			global::java.security.DigestOutputStream._toString22945 = @__env.GetMethodIDNoThrow(global::java.security.DigestOutputStream.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.DigestOutputStream._write22946 = @__env.GetMethodIDNoThrow(global::java.security.DigestOutputStream.staticClass, "write", "(I)V");
			global::java.security.DigestOutputStream._write22947 = @__env.GetMethodIDNoThrow(global::java.security.DigestOutputStream.staticClass, "write", "([BII)V");
			global::java.security.DigestOutputStream._on22948 = @__env.GetMethodIDNoThrow(global::java.security.DigestOutputStream.staticClass, "on", "(Z)V");
			global::java.security.DigestOutputStream._getMessageDigest22949 = @__env.GetMethodIDNoThrow(global::java.security.DigestOutputStream.staticClass, "getMessageDigest", "()Ljava/security/MessageDigest;");
			global::java.security.DigestOutputStream._setMessageDigest22950 = @__env.GetMethodIDNoThrow(global::java.security.DigestOutputStream.staticClass, "setMessageDigest", "(Ljava/security/MessageDigest;)V");
			global::java.security.DigestOutputStream._DigestOutputStream22951 = @__env.GetMethodIDNoThrow(global::java.security.DigestOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/security/MessageDigest;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
