namespace javax.xml.datatype
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DatatypeConfigurationException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DatatypeConfigurationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public DatatypeConfigurationException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.DatatypeConfigurationException._m0.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.DatatypeConfigurationException._m0 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public DatatypeConfigurationException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.DatatypeConfigurationException._m1.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.DatatypeConfigurationException._m1 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public DatatypeConfigurationException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.DatatypeConfigurationException._m2.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.DatatypeConfigurationException._m2 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public DatatypeConfigurationException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.DatatypeConfigurationException._m3.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.DatatypeConfigurationException._m3 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DatatypeConfigurationException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.DatatypeConfigurationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeConfigurationException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
