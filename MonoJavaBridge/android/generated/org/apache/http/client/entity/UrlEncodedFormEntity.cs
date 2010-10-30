namespace org.apache.http.client.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UrlEncodedFormEntity : org.apache.http.entity.StringEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UrlEncodedFormEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public UrlEncodedFormEntity(java.util.List arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.entity.UrlEncodedFormEntity._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.entity.UrlEncodedFormEntity._m0 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.entity.UrlEncodedFormEntity.staticClass, "<init>", "(Ljava/util/List;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.entity.UrlEncodedFormEntity.staticClass, global::org.apache.http.client.entity.UrlEncodedFormEntity._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public UrlEncodedFormEntity(java.util.List arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.entity.UrlEncodedFormEntity._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.entity.UrlEncodedFormEntity._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.entity.UrlEncodedFormEntity.staticClass, "<init>", "(Ljava/util/List;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.entity.UrlEncodedFormEntity.staticClass, global::org.apache.http.client.entity.UrlEncodedFormEntity._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UrlEncodedFormEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.entity.UrlEncodedFormEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/entity/UrlEncodedFormEntity"));
		}
		internal static void InitJNI()
		{
		}
	}
}
