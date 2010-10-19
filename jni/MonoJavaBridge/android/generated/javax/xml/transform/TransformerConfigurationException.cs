namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TransformerConfigurationException : javax.xml.transform.TransformerException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TransformerConfigurationException()
		{
			InitJNI();
		}
		protected TransformerConfigurationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException24389;
		public TransformerConfigurationException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException24389);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException24390;
		public TransformerConfigurationException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException24390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException24391;
		public TransformerConfigurationException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException24391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException24392;
		public TransformerConfigurationException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException24392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException24393;
		public TransformerConfigurationException(java.lang.String arg0, javax.xml.transform.SourceLocator arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException24393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerConfigurationException24394;
		public TransformerConfigurationException(java.lang.String arg0, javax.xml.transform.SourceLocator arg1, java.lang.Throwable arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerConfigurationException.staticClass, global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException24394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.TransformerConfigurationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/TransformerConfigurationException"));
			global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException24389 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "()V");
			global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException24390 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException24391 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException24392 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException24393 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;)V");
			global::javax.xml.transform.TransformerConfigurationException._TransformerConfigurationException24394 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;Ljava/lang/Throwable;)V");
		}
	}
}
