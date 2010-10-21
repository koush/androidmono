namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class URLDecoder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URLDecoder()
		{
			InitJNI();
		}
		protected URLDecoder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _decode21852;
		public static global::java.lang.String decode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLDecoder.staticClass, global::java.net.URLDecoder._decode21852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _decode21853;
		public static global::java.lang.String decode(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLDecoder.staticClass, global::java.net.URLDecoder._decode21853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _URLDecoder21854;
		public URLDecoder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLDecoder.staticClass, global::java.net.URLDecoder._URLDecoder21854);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLDecoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLDecoder"));
			global::java.net.URLDecoder._decode21852 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLDecoder.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLDecoder._decode21853 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLDecoder.staticClass, "decode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLDecoder._URLDecoder21854 = @__env.GetMethodIDNoThrow(global::java.net.URLDecoder.staticClass, "<init>", "()V");
		}
	}
}
