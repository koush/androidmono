namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class X509EncodedKeySpec : java.security.spec.EncodedKeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected X509EncodedKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new byte[] Encoded
		{
			get
			{
				return getEncoded();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded24077;
		public override byte[] getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.X509EncodedKeySpec._getEncoded24077.native == global::System.IntPtr.Zero)
				global::java.security.spec.X509EncodedKeySpec._getEncoded24077 = @__env.GetMethodIDNoThrow(global::java.security.spec.X509EncodedKeySpec.staticClass, "getEncoded", "()[B");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.spec.X509EncodedKeySpec.staticClass, global::java.security.spec.X509EncodedKeySpec._getEncoded24077) as byte[];
		}
		public new global::java.lang.String Format
		{
			get
			{
				return getFormat();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFormat24078;
		public sealed override global::java.lang.String getFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.X509EncodedKeySpec._getFormat24078.native == global::System.IntPtr.Zero)
				global::java.security.spec.X509EncodedKeySpec._getFormat24078 = @__env.GetMethodIDNoThrow(global::java.security.spec.X509EncodedKeySpec.staticClass, "getFormat", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.spec.X509EncodedKeySpec.staticClass, global::java.security.spec.X509EncodedKeySpec._getFormat24078) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _X509EncodedKeySpec24079;
		public X509EncodedKeySpec(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.X509EncodedKeySpec._X509EncodedKeySpec24079.native == global::System.IntPtr.Zero)
				global::java.security.spec.X509EncodedKeySpec._X509EncodedKeySpec24079 = @__env.GetMethodIDNoThrow(global::java.security.spec.X509EncodedKeySpec.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.X509EncodedKeySpec.staticClass, global::java.security.spec.X509EncodedKeySpec._X509EncodedKeySpec24079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static X509EncodedKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.X509EncodedKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/X509EncodedKeySpec"));
		}
		internal static void InitJNI()
		{
		}
	}
}
