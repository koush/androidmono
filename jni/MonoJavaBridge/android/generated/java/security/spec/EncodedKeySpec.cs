namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.spec.EncodedKeySpec_))]
	public abstract partial class EncodedKeySpec : java.lang.Object, KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EncodedKeySpec()
		{
			InitJNI();
		}
		protected EncodedKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded24019;
		public virtual byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.EncodedKeySpec._getEncoded24019)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.EncodedKeySpec.staticClass, global::java.security.spec.EncodedKeySpec._getEncoded24019)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getFormat24020;
		public abstract global::java.lang.String getFormat();
		internal static global::MonoJavaBridge.MethodId _EncodedKeySpec24021;
		public EncodedKeySpec(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.EncodedKeySpec.staticClass, global::java.security.spec.EncodedKeySpec._EncodedKeySpec24021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.EncodedKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/EncodedKeySpec"));
			global::java.security.spec.EncodedKeySpec._getEncoded24019 = @__env.GetMethodIDNoThrow(global::java.security.spec.EncodedKeySpec.staticClass, "getEncoded", "()[B");
			global::java.security.spec.EncodedKeySpec._getFormat24020 = @__env.GetMethodIDNoThrow(global::java.security.spec.EncodedKeySpec.staticClass, "getFormat", "()Ljava/lang/String;");
			global::java.security.spec.EncodedKeySpec._EncodedKeySpec24021 = @__env.GetMethodIDNoThrow(global::java.security.spec.EncodedKeySpec.staticClass, "<init>", "([B)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.spec.EncodedKeySpec))]
	internal sealed partial class EncodedKeySpec_ : java.security.spec.EncodedKeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EncodedKeySpec_()
		{
			InitJNI();
		}
		internal EncodedKeySpec_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getFormat24022;
		public override global::java.lang.String getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.EncodedKeySpec_._getFormat24022)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.EncodedKeySpec_.staticClass, global::java.security.spec.EncodedKeySpec_._getFormat24022)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.EncodedKeySpec_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/EncodedKeySpec"));
			global::java.security.spec.EncodedKeySpec_._getFormat24022 = @__env.GetMethodIDNoThrow(global::java.security.spec.EncodedKeySpec_.staticClass, "getFormat", "()Ljava/lang/String;");
		}
	}
}
