namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.spec.EncodedKeySpec_))]
	public abstract partial class EncodedKeySpec : java.lang.Object, KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EncodedKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.spec.EncodedKeySpec.staticClass, "getEncoded", "()[B", ref global::java.security.spec.EncodedKeySpec._m0) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.lang.String getFormat();
		private static global::MonoJavaBridge.MethodId _m2;
		public EncodedKeySpec(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.EncodedKeySpec._m2.native == global::System.IntPtr.Zero)
				global::java.security.spec.EncodedKeySpec._m2 = @__env.GetMethodIDNoThrow(global::java.security.spec.EncodedKeySpec.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.EncodedKeySpec.staticClass, global::java.security.spec.EncodedKeySpec._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EncodedKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.EncodedKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/EncodedKeySpec"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.spec.EncodedKeySpec))]
	internal sealed partial class EncodedKeySpec_ : java.security.spec.EncodedKeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EncodedKeySpec_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.spec.EncodedKeySpec_.staticClass, "getFormat", "()Ljava/lang/String;", ref global::java.security.spec.EncodedKeySpec_._m0) as java.lang.String;
		}
		static EncodedKeySpec_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.EncodedKeySpec_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/EncodedKeySpec"));
		}
	}
}
