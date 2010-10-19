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
		internal static global::MonoJavaBridge.MethodId _resolve25349;
		public static global::java.net.URI resolve(java.net.URI arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URIUtils.staticClass, global::org.apache.http.client.utils.URIUtils._resolve25349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _resolve25350;
		public static global::java.net.URI resolve(java.net.URI arg0, java.net.URI arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URIUtils.staticClass, global::org.apache.http.client.utils.URIUtils._resolve25350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _createURI25351;
		public static global::java.net.URI createURI(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URIUtils.staticClass, global::org.apache.http.client.utils.URIUtils._createURI25351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _rewriteURI25352;
		public static global::java.net.URI rewriteURI(java.net.URI arg0, org.apache.http.HttpHost arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URIUtils.staticClass, global::org.apache.http.client.utils.URIUtils._rewriteURI25352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _rewriteURI25353;
		public static global::java.net.URI rewriteURI(java.net.URI arg0, org.apache.http.HttpHost arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URIUtils.staticClass, global::org.apache.http.client.utils.URIUtils._rewriteURI25353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.URI;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.utils.URIUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/utils/URIUtils"));
			global::org.apache.http.client.utils.URIUtils._resolve25349 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URIUtils.staticClass, "resolve", "(Ljava/net/URI;Ljava/lang/String;)Ljava/net/URI;");
			global::org.apache.http.client.utils.URIUtils._resolve25350 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URIUtils.staticClass, "resolve", "(Ljava/net/URI;Ljava/net/URI;)Ljava/net/URI;");
			global::org.apache.http.client.utils.URIUtils._createURI25351 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URIUtils.staticClass, "createURI", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/net/URI;");
			global::org.apache.http.client.utils.URIUtils._rewriteURI25352 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URIUtils.staticClass, "rewriteURI", "(Ljava/net/URI;Lorg/apache/http/HttpHost;Z)Ljava/net/URI;");
			global::org.apache.http.client.utils.URIUtils._rewriteURI25353 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URIUtils.staticClass, "rewriteURI", "(Ljava/net/URI;Lorg/apache/http/HttpHost;)Ljava/net/URI;");
		}
	}
}
