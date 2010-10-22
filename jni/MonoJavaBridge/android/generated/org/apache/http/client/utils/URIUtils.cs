namespace org.apache.http.client.utils
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class URIUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URIUtils()
		{
			InitJNI();
		}
		protected URIUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _resolve31930;
		public static global::java.net.URI resolve(java.net.URI arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URIUtils.staticClass, global::org.apache.http.client.utils.URIUtils._resolve31930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _resolve31931;
		public static global::java.net.URI resolve(java.net.URI arg0, java.net.URI arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URIUtils.staticClass, global::org.apache.http.client.utils.URIUtils._resolve31931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _createURI31932;
		public static global::java.net.URI createURI(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URIUtils.staticClass, global::org.apache.http.client.utils.URIUtils._createURI31932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _rewriteURI31933;
		public static global::java.net.URI rewriteURI(java.net.URI arg0, org.apache.http.HttpHost arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URIUtils.staticClass, global::org.apache.http.client.utils.URIUtils._rewriteURI31933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _rewriteURI31934;
		public static global::java.net.URI rewriteURI(java.net.URI arg0, org.apache.http.HttpHost arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URIUtils.staticClass, global::org.apache.http.client.utils.URIUtils._rewriteURI31934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.URI;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.utils.URIUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/utils/URIUtils"));
			global::org.apache.http.client.utils.URIUtils._resolve31930 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URIUtils.staticClass, "resolve", "(Ljava/net/URI;Ljava/lang/String;)Ljava/net/URI;");
			global::org.apache.http.client.utils.URIUtils._resolve31931 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URIUtils.staticClass, "resolve", "(Ljava/net/URI;Ljava/net/URI;)Ljava/net/URI;");
			global::org.apache.http.client.utils.URIUtils._createURI31932 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URIUtils.staticClass, "createURI", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/net/URI;");
			global::org.apache.http.client.utils.URIUtils._rewriteURI31933 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URIUtils.staticClass, "rewriteURI", "(Ljava/net/URI;Lorg/apache/http/HttpHost;Z)Ljava/net/URI;");
			global::org.apache.http.client.utils.URIUtils._rewriteURI31934 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URIUtils.staticClass, "rewriteURI", "(Ljava/net/URI;Lorg/apache/http/HttpHost;)Ljava/net/URI;");
		}
	}
}
