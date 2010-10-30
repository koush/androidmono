namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TransformerFactoryConfigurationError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TransformerFactoryConfigurationError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage31033;
		public override global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "getMessage", "()Ljava/lang/String;", ref global::javax.xml.transform.TransformerFactoryConfigurationError._getMessage31033) as java.lang.String;
		}
		public new global::java.lang.Exception Exception
		{
			get
			{
				return getException();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getException31034;
		public virtual global::java.lang.Exception getException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "getException", "()Ljava/lang/Exception;", ref global::javax.xml.transform.TransformerFactoryConfigurationError._getException31034) as java.lang.Exception;
		}
		internal static global::MonoJavaBridge.MethodId _TransformerFactoryConfigurationError31035;
		public TransformerFactoryConfigurationError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31035.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31035 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31035);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerFactoryConfigurationError31036;
		public TransformerFactoryConfigurationError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31036.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31036 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerFactoryConfigurationError31037;
		public TransformerFactoryConfigurationError(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31037.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31037 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerFactoryConfigurationError31038;
		public TransformerFactoryConfigurationError(java.lang.Exception arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31038.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31038 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "<init>", "(Ljava/lang/Exception;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TransformerFactoryConfigurationError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/TransformerFactoryConfigurationError"));
		}
		internal static void InitJNI()
		{
		}
	}
}
