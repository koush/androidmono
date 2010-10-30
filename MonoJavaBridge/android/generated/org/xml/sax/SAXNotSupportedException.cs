namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SAXNotSupportedException : org.xml.sax.SAXException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SAXNotSupportedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public SAXNotSupportedException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXNotSupportedException._m0.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXNotSupportedException._m0 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXNotSupportedException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXNotSupportedException.staticClass, global::org.xml.sax.SAXNotSupportedException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public SAXNotSupportedException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXNotSupportedException._m1.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXNotSupportedException._m1 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXNotSupportedException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXNotSupportedException.staticClass, global::org.xml.sax.SAXNotSupportedException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SAXNotSupportedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.SAXNotSupportedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/SAXNotSupportedException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
