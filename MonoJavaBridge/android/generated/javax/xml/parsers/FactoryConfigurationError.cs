namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FactoryConfigurationError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.parsers.FactoryConfigurationError.staticClass, "getMessage", "()Ljava/lang/String;", ref global::javax.xml.parsers.FactoryConfigurationError._m0) as java.lang.String;
		}
		public new global::java.lang.Exception Exception
		{
			get
			{
				return getException();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Exception getException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.parsers.FactoryConfigurationError.staticClass, "getException", "()Ljava/lang/Exception;", ref global::javax.xml.parsers.FactoryConfigurationError._m1) as java.lang.Exception;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public FactoryConfigurationError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.FactoryConfigurationError._m2.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.FactoryConfigurationError._m2 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.FactoryConfigurationError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.FactoryConfigurationError.staticClass, global::javax.xml.parsers.FactoryConfigurationError._m2);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public FactoryConfigurationError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.FactoryConfigurationError._m3.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.FactoryConfigurationError._m3 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.FactoryConfigurationError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.FactoryConfigurationError.staticClass, global::javax.xml.parsers.FactoryConfigurationError._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public FactoryConfigurationError(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.FactoryConfigurationError._m4.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.FactoryConfigurationError._m4 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.FactoryConfigurationError.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.FactoryConfigurationError.staticClass, global::javax.xml.parsers.FactoryConfigurationError._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public FactoryConfigurationError(java.lang.Exception arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.parsers.FactoryConfigurationError._m5.native == global::System.IntPtr.Zero)
				global::javax.xml.parsers.FactoryConfigurationError._m5 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.FactoryConfigurationError.staticClass, "<init>", "(Ljava/lang/Exception;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.FactoryConfigurationError.staticClass, global::javax.xml.parsers.FactoryConfigurationError._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static FactoryConfigurationError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.FactoryConfigurationError.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/FactoryConfigurationError"));
		}
		internal static void InitJNI()
		{
		}
	}
}
