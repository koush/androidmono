namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParserConfigurationException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ParserConfigurationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ParserConfigurationException30889;
		public ParserConfigurationException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.ParserConfigurationException._ParserConfigurationException30889.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.ParserConfigurationException._ParserConfigurationException30889 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.ParserConfigurationException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.ParserConfigurationException.staticClass, global::javax.xml.parsers.ParserConfigurationException._ParserConfigurationException30889);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ParserConfigurationException30890;
		public ParserConfigurationException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.ParserConfigurationException._ParserConfigurationException30890.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.ParserConfigurationException._ParserConfigurationException30890 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.ParserConfigurationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.ParserConfigurationException.staticClass, global::javax.xml.parsers.ParserConfigurationException._ParserConfigurationException30890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ParserConfigurationException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.ParserConfigurationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/ParserConfigurationException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
