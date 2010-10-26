namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TransformerFactoryConfigurationError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TransformerFactoryConfigurationError()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getMessage31032;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactoryConfigurationError._getMessage31032)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._getMessage31032)) as java.lang.String;
		}
		public new global::java.lang.Exception Exception
		{
			get
			{
				return getException();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getException31033;
		public virtual global::java.lang.Exception getException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactoryConfigurationError._getException31033)) as java.lang.Exception;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._getException31033)) as java.lang.Exception;
		}
		internal static global::MonoJavaBridge.MethodId _TransformerFactoryConfigurationError31034;
		public TransformerFactoryConfigurationError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31034);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerFactoryConfigurationError31035;
		public TransformerFactoryConfigurationError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerFactoryConfigurationError31036;
		public TransformerFactoryConfigurationError(java.lang.Exception arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerFactoryConfigurationError31037;
		public TransformerFactoryConfigurationError(java.lang.Exception arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/TransformerFactoryConfigurationError"));
			global::javax.xml.transform.TransformerFactoryConfigurationError._getMessage31032 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "getMessage", "()Ljava/lang/String;");
			global::javax.xml.transform.TransformerFactoryConfigurationError._getException31033 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "getException", "()Ljava/lang/Exception;");
			global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31034 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "<init>", "()V");
			global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31035 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31036 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError31037 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "<init>", "(Ljava/lang/Exception;Ljava/lang/String;)V");
		}
	}
}
