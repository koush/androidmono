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
		internal static global::MonoJavaBridge.MethodId _DatatypeConfigurationException24072;
		public DatatypeConfigurationException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException24072);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatatypeConfigurationException24073;
		public DatatypeConfigurationException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException24073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatatypeConfigurationException24074;
		public DatatypeConfigurationException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException24074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatatypeConfigurationException24075;
		public DatatypeConfigurationException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException24075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.DatatypeConfigurationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeConfigurationException"));
			global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException24072 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "()V");
			global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException24073 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException24074 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException24075 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
