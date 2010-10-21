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
		internal static global::MonoJavaBridge.MethodId _getMessage30914;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactoryConfigurationError._getMessage30914)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._getMessage30914)) as java.lang.String;
		}
		public new global::java.lang.Exception Exception
		{
			get
			{
				return getException();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getException30915;
		public virtual global::java.lang.Exception getException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactoryConfigurationError._getException30915)) as java.lang.Exception;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._getException30915)) as java.lang.Exception;
		}
		internal static global::MonoJavaBridge.MethodId _TransformerFactoryConfigurationError30916;
		public TransformerFactoryConfigurationError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError30916);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerFactoryConfigurationError30917;
		public TransformerFactoryConfigurationError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError30917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerFactoryConfigurationError30918;
		public TransformerFactoryConfigurationError(java.lang.Exception arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError30918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerFactoryConfigurationError30919;
		public TransformerFactoryConfigurationError(java.lang.Exception arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerFactoryConfigurationError.staticClass, global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError30919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/TransformerFactoryConfigurationError"));
			global::javax.xml.transform.TransformerFactoryConfigurationError._getMessage30914 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "getMessage", "()Ljava/lang/String;");
			global::javax.xml.transform.TransformerFactoryConfigurationError._getException30915 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "getException", "()Ljava/lang/Exception;");
			global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError30916 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "<init>", "()V");
			global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError30917 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError30918 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			global::javax.xml.transform.TransformerFactoryConfigurationError._TransformerFactoryConfigurationError30919 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerFactoryConfigurationError.staticClass, "<init>", "(Ljava/lang/Exception;Ljava/lang/String;)V");
		}
	}
}
