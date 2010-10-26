namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FactoryConfigurationError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FactoryConfigurationError()
		{
			InitJNI();
		}
		protected FactoryConfigurationError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage30882;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.FactoryConfigurationError._getMessage30882)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.FactoryConfigurationError.staticClass, global::javax.xml.parsers.FactoryConfigurationError._getMessage30882)) as java.lang.String;
		}
		public new global::java.lang.Exception Exception
		{
			get
			{
				return getException();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getException30883;
		public virtual global::java.lang.Exception getException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.FactoryConfigurationError._getException30883)) as java.lang.Exception;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.FactoryConfigurationError.staticClass, global::javax.xml.parsers.FactoryConfigurationError._getException30883)) as java.lang.Exception;
		}
		internal static global::MonoJavaBridge.MethodId _FactoryConfigurationError30884;
		public FactoryConfigurationError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.FactoryConfigurationError.staticClass, global::javax.xml.parsers.FactoryConfigurationError._FactoryConfigurationError30884);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FactoryConfigurationError30885;
		public FactoryConfigurationError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.FactoryConfigurationError.staticClass, global::javax.xml.parsers.FactoryConfigurationError._FactoryConfigurationError30885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FactoryConfigurationError30886;
		public FactoryConfigurationError(java.lang.Exception arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.FactoryConfigurationError.staticClass, global::javax.xml.parsers.FactoryConfigurationError._FactoryConfigurationError30886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FactoryConfigurationError30887;
		public FactoryConfigurationError(java.lang.Exception arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.FactoryConfigurationError.staticClass, global::javax.xml.parsers.FactoryConfigurationError._FactoryConfigurationError30887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.FactoryConfigurationError.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/FactoryConfigurationError"));
			global::javax.xml.parsers.FactoryConfigurationError._getMessage30882 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.FactoryConfigurationError.staticClass, "getMessage", "()Ljava/lang/String;");
			global::javax.xml.parsers.FactoryConfigurationError._getException30883 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.FactoryConfigurationError.staticClass, "getException", "()Ljava/lang/Exception;");
			global::javax.xml.parsers.FactoryConfigurationError._FactoryConfigurationError30884 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.FactoryConfigurationError.staticClass, "<init>", "()V");
			global::javax.xml.parsers.FactoryConfigurationError._FactoryConfigurationError30885 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.FactoryConfigurationError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.parsers.FactoryConfigurationError._FactoryConfigurationError30886 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.FactoryConfigurationError.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			global::javax.xml.parsers.FactoryConfigurationError._FactoryConfigurationError30887 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.FactoryConfigurationError.staticClass, "<init>", "(Ljava/lang/Exception;Ljava/lang/String;)V");
		}
	}
}
