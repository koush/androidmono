namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class URLEncoder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URLEncoder()
		{
			InitJNI();
		}
		protected URLEncoder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _encode21973;
		public static global::java.lang.String encode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.net.URLEncoder.staticClass, global::java.net.URLEncoder._encode21973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _encode21974;
		public static global::java.lang.String encode(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.net.URLEncoder.staticClass, global::java.net.URLEncoder._encode21974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLEncoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLEncoder"));
			global::java.net.URLEncoder._encode21973 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLEncoder.staticClass, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLEncoder._encode21974 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLEncoder.staticClass, "encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
		}
	}
}
