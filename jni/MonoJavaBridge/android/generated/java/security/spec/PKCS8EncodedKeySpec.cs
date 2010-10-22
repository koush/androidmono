namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PKCS8EncodedKeySpec : java.security.spec.EncodedKeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PKCS8EncodedKeySpec()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getEncoded23917;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.PKCS8EncodedKeySpec._getEncoded23917)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.PKCS8EncodedKeySpec.staticClass, global::java.security.spec.PKCS8EncodedKeySpec._getEncoded23917)) as byte[];
		}
		public new global::java.lang.String Format
		{
			get
			{
				return getFormat();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFormat23918;
		public sealed override global::java.lang.String getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.PKCS8EncodedKeySpec._getFormat23918)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.PKCS8EncodedKeySpec.staticClass, global::java.security.spec.PKCS8EncodedKeySpec._getFormat23918)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _PKCS8EncodedKeySpec23919;
		public PKCS8EncodedKeySpec(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.PKCS8EncodedKeySpec.staticClass, global::java.security.spec.PKCS8EncodedKeySpec._PKCS8EncodedKeySpec23919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.PKCS8EncodedKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/PKCS8EncodedKeySpec"));
			global::java.security.spec.PKCS8EncodedKeySpec._getEncoded23917 = @__env.GetMethodIDNoThrow(global::java.security.spec.PKCS8EncodedKeySpec.staticClass, "getEncoded", "()[B");
			global::java.security.spec.PKCS8EncodedKeySpec._getFormat23918 = @__env.GetMethodIDNoThrow(global::java.security.spec.PKCS8EncodedKeySpec.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.spec.PKCS8EncodedKeySpec._PKCS8EncodedKeySpec23919 = @__env.GetMethodIDNoThrow(global::java.security.spec.PKCS8EncodedKeySpec.staticClass, "<init>", "([B)V");
		}
	}
}
