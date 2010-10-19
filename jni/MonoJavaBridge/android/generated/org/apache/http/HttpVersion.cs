namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class HttpVersion : org.apache.http.ProtocolVersion, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpVersion()
		{
			InitJNI();
		}
		internal HttpVersion(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _forVersion25071;
		public sealed override global::org.apache.http.ProtocolVersion forVersion(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpVersion._forVersion25071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpVersion.staticClass, global::org.apache.http.HttpVersion._forVersion25071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _HttpVersion25072;
		public HttpVersion(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpVersion.staticClass, global::org.apache.http.HttpVersion._HttpVersion25072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static global::java.lang.String HTTP
		{
			get
			{
				return "HTTP";
			}
		}
		internal static global::MonoJavaBridge.FieldId _HTTP_0_925073;
		public static global::org.apache.http.HttpVersion HTTP_0_9
		{
			get
			{
				return default(global::org.apache.http.HttpVersion);
			}
		}
		internal static global::MonoJavaBridge.FieldId _HTTP_1_025074;
		public static global::org.apache.http.HttpVersion HTTP_1_0
		{
			get
			{
				return default(global::org.apache.http.HttpVersion);
			}
		}
		internal static global::MonoJavaBridge.FieldId _HTTP_1_125075;
		public static global::org.apache.http.HttpVersion HTTP_1_1
		{
			get
			{
				return default(global::org.apache.http.HttpVersion);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpVersion.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpVersion"));
			global::org.apache.http.HttpVersion._forVersion25071 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpVersion.staticClass, "forVersion", "(II)Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.HttpVersion._HttpVersion25072 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpVersion.staticClass, "<init>", "(II)V");
		}
	}
}
