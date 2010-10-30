namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PKCS8EncodedKeySpec : java.security.spec.EncodedKeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PKCS8EncodedKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new byte[] Encoded
		{
			get
			{
				return getEncoded();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded24036;
		public override byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.spec.PKCS8EncodedKeySpec.staticClass, "getEncoded", "()[B", ref global::java.security.spec.PKCS8EncodedKeySpec._getEncoded24036) as byte[];
		}
		public new global::java.lang.String Format
		{
			get
			{
				return getFormat();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFormat24037;
		public sealed override global::java.lang.String getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.spec.PKCS8EncodedKeySpec.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.spec.PKCS8EncodedKeySpec._getFormat24037) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _PKCS8EncodedKeySpec24038;
		public PKCS8EncodedKeySpec(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.PKCS8EncodedKeySpec._PKCS8EncodedKeySpec24038.native == global::System.IntPtr.Zero)
				global::java.security.spec.PKCS8EncodedKeySpec._PKCS8EncodedKeySpec24038 = @__env.GetMethodIDNoThrow(global::java.security.spec.PKCS8EncodedKeySpec.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.PKCS8EncodedKeySpec.staticClass, global::java.security.spec.PKCS8EncodedKeySpec._PKCS8EncodedKeySpec24038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PKCS8EncodedKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.PKCS8EncodedKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/PKCS8EncodedKeySpec"));
		}
		internal static void InitJNI()
		{
		}
	}
}
