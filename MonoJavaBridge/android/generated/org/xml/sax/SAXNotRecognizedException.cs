namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SAXNotRecognizedException : org.xml.sax.SAXException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SAXNotRecognizedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SAXNotRecognizedException35035;
		public SAXNotRecognizedException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXNotRecognizedException._SAXNotRecognizedException35035.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXNotRecognizedException._SAXNotRecognizedException35035 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXNotRecognizedException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXNotRecognizedException.staticClass, global::org.xml.sax.SAXNotRecognizedException._SAXNotRecognizedException35035);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXNotRecognizedException35036;
		public SAXNotRecognizedException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXNotRecognizedException._SAXNotRecognizedException35036.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXNotRecognizedException._SAXNotRecognizedException35036 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXNotRecognizedException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXNotRecognizedException.staticClass, global::org.xml.sax.SAXNotRecognizedException._SAXNotRecognizedException35036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SAXNotRecognizedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.SAXNotRecognizedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/SAXNotRecognizedException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
