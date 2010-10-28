namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SAXNotSupportedException : org.xml.sax.SAXException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SAXNotSupportedException()
		{
			InitJNI();
		}
		protected SAXNotSupportedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SAXNotSupportedException35037;
		public SAXNotSupportedException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXNotSupportedException.staticClass, global::org.xml.sax.SAXNotSupportedException._SAXNotSupportedException35037);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXNotSupportedException35038;
		public SAXNotSupportedException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXNotSupportedException.staticClass, global::org.xml.sax.SAXNotSupportedException._SAXNotSupportedException35038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.SAXNotSupportedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/SAXNotSupportedException"));
			global::org.xml.sax.SAXNotSupportedException._SAXNotSupportedException35037 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXNotSupportedException.staticClass, "<init>", "()V");
			global::org.xml.sax.SAXNotSupportedException._SAXNotSupportedException35038 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXNotSupportedException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
