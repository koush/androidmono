namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.spec.EncodedKeySpec_))]
	public abstract partial class EncodedKeySpec : java.lang.Object, KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EncodedKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded24020;
		public virtual byte[] getEncoded()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.EncodedKeySpec._getEncoded24020.native == global::System.IntPtr.Zero)
				global::java.security.spec.EncodedKeySpec._getEncoded24020 = @__env.GetMethodIDNoThrow(global::java.security.spec.EncodedKeySpec.staticClass, "getEncoded", "()[B");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.spec.EncodedKeySpec.staticClass, global::java.security.spec.EncodedKeySpec._getEncoded24020) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getFormat24021;
		public abstract global::java.lang.String getFormat();
		internal static global::MonoJavaBridge.MethodId _EncodedKeySpec24022;
		public EncodedKeySpec(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.EncodedKeySpec._EncodedKeySpec24022.native == global::System.IntPtr.Zero)
				global::java.security.spec.EncodedKeySpec._EncodedKeySpec24022 = @__env.GetMethodIDNoThrow(global::java.security.spec.EncodedKeySpec.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.EncodedKeySpec.staticClass, global::java.security.spec.EncodedKeySpec._EncodedKeySpec24022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EncodedKeySpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.EncodedKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/EncodedKeySpec"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.spec.EncodedKeySpec))]
	internal sealed partial class EncodedKeySpec_ : java.security.spec.EncodedKeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EncodedKeySpec_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getFormat24023;
		public override global::java.lang.String getFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.EncodedKeySpec_._getFormat24023.native == global::System.IntPtr.Zero)
				global::java.security.spec.EncodedKeySpec_._getFormat24023 = @__env.GetMethodIDNoThrow(global::java.security.spec.EncodedKeySpec_.staticClass, "getFormat", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.EncodedKeySpec_._getFormat24023)) as java.lang.String;
		}
		static EncodedKeySpec_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.EncodedKeySpec_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/EncodedKeySpec"));
		}
		internal static void InitJNI()
		{
		}
	}
}
