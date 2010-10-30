namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class HttpVersion : org.apache.http.ProtocolVersion, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpVersion(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _forVersion31728;
		public sealed override global::org.apache.http.ProtocolVersion forVersion(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.HttpVersion.staticClass, "forVersion", "(II)Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.HttpVersion._forVersion31728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _HttpVersion31729;
		public HttpVersion(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpVersion._HttpVersion31729.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpVersion._HttpVersion31729 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpVersion.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpVersion.staticClass, global::org.apache.http.HttpVersion._HttpVersion31729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static global::java.lang.String HTTP
		{
			get
			{
				return "HTTP";
			}
		}
		internal static global::MonoJavaBridge.FieldId _HTTP_0_931731;
		public static global::org.apache.http.HttpVersion HTTP_0_9
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpVersion>(@__env.GetStaticObjectField(global::org.apache.http.HttpVersion.staticClass, _HTTP_0_931731)) as org.apache.http.HttpVersion;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HTTP_1_031732;
		public static global::org.apache.http.HttpVersion HTTP_1_0
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpVersion>(@__env.GetStaticObjectField(global::org.apache.http.HttpVersion.staticClass, _HTTP_1_031732)) as org.apache.http.HttpVersion;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HTTP_1_131733;
		public static global::org.apache.http.HttpVersion HTTP_1_1
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.HttpVersion>(@__env.GetStaticObjectField(global::org.apache.http.HttpVersion.staticClass, _HTTP_1_131733)) as org.apache.http.HttpVersion;
			}
		}
		static HttpVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpVersion.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpVersion"));
			global::org.apache.http.HttpVersion._HTTP_0_931731 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.HttpVersion.staticClass, "HTTP_0_9", "Lorg/apache/http/HttpVersion;");
			global::org.apache.http.HttpVersion._HTTP_1_031732 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.HttpVersion.staticClass, "HTTP_1_0", "Lorg/apache/http/HttpVersion;");
			global::org.apache.http.HttpVersion._HTTP_1_131733 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.HttpVersion.staticClass, "HTTP_1_1", "Lorg/apache/http/HttpVersion;");
		}
		internal static void InitJNI()
		{
		}
	}
}
