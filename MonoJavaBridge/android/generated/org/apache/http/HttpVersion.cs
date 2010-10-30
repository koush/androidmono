namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class HttpVersion : org.apache.http.ProtocolVersion, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpVersion(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::org.apache.http.ProtocolVersion forVersion(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.HttpVersion.staticClass, "forVersion", "(II)Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.HttpVersion._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.ProtocolVersion;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public HttpVersion(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpVersion._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpVersion._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpVersion.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpVersion.staticClass, global::org.apache.http.HttpVersion._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static global::java.lang.String HTTP
		{
			get
			{
				return "HTTP";
			}
		}
		internal static global::MonoJavaBridge.FieldId _HTTP_0_97402;
		public static global::org.apache.http.HttpVersion HTTP_0_9
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpVersion>(@__env.GetStaticObjectField(global::org.apache.http.HttpVersion.staticClass, _HTTP_0_97402)) as org.apache.http.HttpVersion;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HTTP_1_07403;
		public static global::org.apache.http.HttpVersion HTTP_1_0
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpVersion>(@__env.GetStaticObjectField(global::org.apache.http.HttpVersion.staticClass, _HTTP_1_07403)) as org.apache.http.HttpVersion;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HTTP_1_17404;
		public static global::org.apache.http.HttpVersion HTTP_1_1
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpVersion>(@__env.GetStaticObjectField(global::org.apache.http.HttpVersion.staticClass, _HTTP_1_17404)) as org.apache.http.HttpVersion;
			}
		}
		static HttpVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpVersion.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpVersion"));
			global::org.apache.http.HttpVersion._HTTP_0_97402 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.HttpVersion.staticClass, "HTTP_0_9", "Lorg/apache/http/HttpVersion;");
			global::org.apache.http.HttpVersion._HTTP_1_07403 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.HttpVersion.staticClass, "HTTP_1_0", "Lorg/apache/http/HttpVersion;");
			global::org.apache.http.HttpVersion._HTTP_1_17404 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.HttpVersion.staticClass, "HTTP_1_1", "Lorg/apache/http/HttpVersion;");
		}
		internal static void InitJNI()
		{
		}
	}
}
