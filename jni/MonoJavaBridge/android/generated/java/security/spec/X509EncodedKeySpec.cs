namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class X509EncodedKeySpec : java.security.spec.EncodedKeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509EncodedKeySpec()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getEncoded18349;
		public override byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.X509EncodedKeySpec._getEncoded18349)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.X509EncodedKeySpec.staticClass, global::java.security.spec.X509EncodedKeySpec._getEncoded18349)) as byte[];
		}
		public new global::java.lang.String Format
		{
			get
			{
				return getFormat();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFormat18350;
		public sealed override global::java.lang.String getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.X509EncodedKeySpec._getFormat18350)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.X509EncodedKeySpec.staticClass, global::java.security.spec.X509EncodedKeySpec._getFormat18350)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _X509EncodedKeySpec18351;
		public X509EncodedKeySpec(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.X509EncodedKeySpec.staticClass, global::java.security.spec.X509EncodedKeySpec._X509EncodedKeySpec18351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.X509EncodedKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/X509EncodedKeySpec"));
			global::java.security.spec.X509EncodedKeySpec._getEncoded18349 = @__env.GetMethodIDNoThrow(global::java.security.spec.X509EncodedKeySpec.staticClass, "getEncoded", "()[B");
			global::java.security.spec.X509EncodedKeySpec._getFormat18350 = @__env.GetMethodIDNoThrow(global::java.security.spec.X509EncodedKeySpec.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.spec.X509EncodedKeySpec._X509EncodedKeySpec18351 = @__env.GetMethodIDNoThrow(global::java.security.spec.X509EncodedKeySpec.staticClass, "<init>", "([B)V");
		}
	}
}
