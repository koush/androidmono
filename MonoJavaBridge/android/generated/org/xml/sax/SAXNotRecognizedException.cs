namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SAXNotRecognizedException : org.xml.sax.SAXException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SAXNotRecognizedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public SAXNotRecognizedException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXNotRecognizedException._m0.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXNotRecognizedException._m0 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXNotRecognizedException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXNotRecognizedException.staticClass, global::org.xml.sax.SAXNotRecognizedException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public SAXNotRecognizedException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXNotRecognizedException._m1.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXNotRecognizedException._m1 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXNotRecognizedException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXNotRecognizedException.staticClass, global::org.xml.sax.SAXNotRecognizedException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SAXNotRecognizedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.SAXNotRecognizedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/SAXNotRecognizedException"));
		}
	}
}
