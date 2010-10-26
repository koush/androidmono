namespace org.apache.http.client.utils
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class URLEncodedUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URLEncodedUtils()
		{
			InitJNI();
		}
		protected URLEncodedUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _format32053;
		public static global::java.lang.String format(java.util.List arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URLEncodedUtils.staticClass, global::org.apache.http.client.utils.URLEncodedUtils._format32053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parse32054;
		public static global::java.util.List parse(java.net.URI arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URLEncodedUtils.staticClass, global::org.apache.http.client.utils.URLEncodedUtils._parse32054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _parse32055;
		public static global::java.util.List parse(org.apache.http.HttpEntity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URLEncodedUtils.staticClass, global::org.apache.http.client.utils.URLEncodedUtils._parse32055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _parse32056;
		public static void parse(java.util.List arg0, java.util.Scanner arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(org.apache.http.client.utils.URLEncodedUtils.staticClass, global::org.apache.http.client.utils.URLEncodedUtils._parse32056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isEncoded32057;
		public static bool isEncoded(org.apache.http.HttpEntity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.client.utils.URLEncodedUtils.staticClass, global::org.apache.http.client.utils.URLEncodedUtils._isEncoded32057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _URLEncodedUtils32058;
		public URLEncodedUtils()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.utils.URLEncodedUtils.staticClass, global::org.apache.http.client.utils.URLEncodedUtils._URLEncodedUtils32058);
			Init(@__env, handle);
		}
		public static global::java.lang.String CONTENT_TYPE
		{
			get
			{
				return "application/x-www-form-urlencoded";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.utils.URLEncodedUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/utils/URLEncodedUtils"));
			global::org.apache.http.client.utils.URLEncodedUtils._format32053 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URLEncodedUtils.staticClass, "format", "(Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.client.utils.URLEncodedUtils._parse32054 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URLEncodedUtils.staticClass, "parse", "(Ljava/net/URI;Ljava/lang/String;)Ljava/util/List;");
			global::org.apache.http.client.utils.URLEncodedUtils._parse32055 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URLEncodedUtils.staticClass, "parse", "(Lorg/apache/http/HttpEntity;)Ljava/util/List;");
			global::org.apache.http.client.utils.URLEncodedUtils._parse32056 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URLEncodedUtils.staticClass, "parse", "(Ljava/util/List;Ljava/util/Scanner;Ljava/lang/String;)V");
			global::org.apache.http.client.utils.URLEncodedUtils._isEncoded32057 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URLEncodedUtils.staticClass, "isEncoded", "(Lorg/apache/http/HttpEntity;)Z");
			global::org.apache.http.client.utils.URLEncodedUtils._URLEncodedUtils32058 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.utils.URLEncodedUtils.staticClass, "<init>", "()V");
		}
	}
}
