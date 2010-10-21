namespace javax.xml.datatype
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DatatypeConfigurationException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatatypeConfigurationException()
		{
			InitJNI();
		}
		protected DatatypeConfigurationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DatatypeConfigurationException30516;
		public DatatypeConfigurationException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30516);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatatypeConfigurationException30517;
		public DatatypeConfigurationException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatatypeConfigurationException30518;
		public DatatypeConfigurationException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatatypeConfigurationException30519;
		public DatatypeConfigurationException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.DatatypeConfigurationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeConfigurationException"));
			global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30516 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "()V");
			global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30517 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30518 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30519 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
