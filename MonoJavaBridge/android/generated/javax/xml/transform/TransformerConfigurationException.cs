namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TransformerConfigurationException : javax.xml.transform.TransformerException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TransformerConfigurationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException30985;
		public TransformerConfigurationException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30985.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30985 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30985);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException30986;
		public TransformerConfigurationException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30986.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30986 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException30987;
		public TransformerConfigurationException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30987.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30987 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException30988;
		public TransformerConfigurationException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30988.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30988 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException30989;
		public TransformerConfigurationException(java.lang.String arg0, javax.xml.transform.SourceLocator arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30989.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30989 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException30990;
		public TransformerConfigurationException(java.lang.String arg0, javax.xml.transform.SourceLocator arg1, java.lang.Throwable arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30990.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30990 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException30990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static TransformerConfigurationException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.TransformerConfigurationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/TransformerConfigurationException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
