namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParserConfigurationException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ParserConfigurationException()
		{
			InitJNI();
		}
		protected ParserConfigurationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ParserConfigurationException30888;
		public ParserConfigurationException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.ParserConfigurationException.staticClass, global::javax.xml.parsers.ParserConfigurationException._ParserConfigurationException30888);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ParserConfigurationException30889;
		public ParserConfigurationException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.ParserConfigurationException.staticClass, global::javax.xml.parsers.ParserConfigurationException._ParserConfigurationException30889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.ParserConfigurationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/ParserConfigurationException"));
			global::javax.xml.parsers.ParserConfigurationException._ParserConfigurationException30888 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.ParserConfigurationException.staticClass, "<init>", "()V");
			global::javax.xml.parsers.ParserConfigurationException._ParserConfigurationException30889 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.ParserConfigurationException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
