namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class URLDecoder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected URLDecoder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.String decode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLDecoder._m0.native == global::System.IntPtr.Zero)
				global::java.net.URLDecoder._m0 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLDecoder.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.net.URLDecoder.staticClass, global::java.net.URLDecoder._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.String decode(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLDecoder._m1.native == global::System.IntPtr.Zero)
				global::java.net.URLDecoder._m1 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLDecoder.staticClass, "decode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.net.URLDecoder.staticClass, global::java.net.URLDecoder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public URLDecoder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLDecoder._m2.native == global::System.IntPtr.Zero)
				global::java.net.URLDecoder._m2 = @__env.GetMethodIDNoThrow(global::java.net.URLDecoder.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLDecoder.staticClass, global::java.net.URLDecoder._m2);
			Init(@__env, handle);
		}
		static URLDecoder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLDecoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLDecoder"));
		}
	}
}
