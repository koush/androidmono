namespace org.apache.http.client.utils
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class URLEncodedUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected URLEncodedUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.String format(java.util.List arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.utils.URLEncodedUtils._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.utils.URLEncodedUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URLEncodedUtils.staticClass, "format", "(Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URLEncodedUtils.staticClass, global::org.apache.http.client.utils.URLEncodedUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.util.List parse(java.net.URI arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.utils.URLEncodedUtils._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.utils.URLEncodedUtils._m1 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URLEncodedUtils.staticClass, "parse", "(Ljava/net/URI;Ljava/lang/String;)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URLEncodedUtils.staticClass, global::org.apache.http.client.utils.URLEncodedUtils._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.util.List parse(org.apache.http.HttpEntity arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.utils.URLEncodedUtils._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.utils.URLEncodedUtils._m2 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URLEncodedUtils.staticClass, "parse", "(Lorg/apache/http/HttpEntity;)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(org.apache.http.client.utils.URLEncodedUtils.staticClass, global::org.apache.http.client.utils.URLEncodedUtils._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void parse(java.util.List arg0, java.util.Scanner arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.utils.URLEncodedUtils._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.utils.URLEncodedUtils._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URLEncodedUtils.staticClass, "parse", "(Ljava/util/List;Ljava/util/Scanner;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(org.apache.http.client.utils.URLEncodedUtils.staticClass, global::org.apache.http.client.utils.URLEncodedUtils._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static bool isEncoded(org.apache.http.HttpEntity arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.utils.URLEncodedUtils._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.utils.URLEncodedUtils._m4 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.URLEncodedUtils.staticClass, "isEncoded", "(Lorg/apache/http/HttpEntity;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.client.utils.URLEncodedUtils.staticClass, global::org.apache.http.client.utils.URLEncodedUtils._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public URLEncodedUtils() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.utils.URLEncodedUtils._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.utils.URLEncodedUtils._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.utils.URLEncodedUtils.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.utils.URLEncodedUtils.staticClass, global::org.apache.http.client.utils.URLEncodedUtils._m5);
			Init(@__env, handle);
		}
		public static global::java.lang.String CONTENT_TYPE
		{
			get
			{
				return "application/x-www-form-urlencoded";
			}
		}
		static URLEncodedUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.utils.URLEncodedUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/utils/URLEncodedUtils"));
		}
		internal static void InitJNI()
		{
		}
	}
}
