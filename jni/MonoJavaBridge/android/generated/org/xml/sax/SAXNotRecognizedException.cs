namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SAXNotRecognizedException : org.xml.sax.SAXException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SAXNotRecognizedException()
		{
			InitJNI();
		}
		protected SAXNotRecognizedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SAXNotRecognizedException28165;
		public SAXNotRecognizedException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXNotRecognizedException.staticClass, global::org.xml.sax.SAXNotRecognizedException._SAXNotRecognizedException28165);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXNotRecognizedException28166;
		public SAXNotRecognizedException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXNotRecognizedException.staticClass, global::org.xml.sax.SAXNotRecognizedException._SAXNotRecognizedException28166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.SAXNotRecognizedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/SAXNotRecognizedException"));
			global::org.xml.sax.SAXNotRecognizedException._SAXNotRecognizedException28165 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXNotRecognizedException.staticClass, "<init>", "()V");
			global::org.xml.sax.SAXNotRecognizedException._SAXNotRecognizedException28166 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXNotRecognizedException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
