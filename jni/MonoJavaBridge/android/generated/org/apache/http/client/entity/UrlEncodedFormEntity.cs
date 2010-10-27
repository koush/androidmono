namespace org.apache.http.client.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UrlEncodedFormEntity : org.apache.http.entity.StringEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UrlEncodedFormEntity()
		{
			InitJNI();
		}
		protected UrlEncodedFormEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UrlEncodedFormEntity31903;
		public UrlEncodedFormEntity(java.util.List arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.entity.UrlEncodedFormEntity.staticClass, global::org.apache.http.client.entity.UrlEncodedFormEntity._UrlEncodedFormEntity31903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UrlEncodedFormEntity31904;
		public UrlEncodedFormEntity(java.util.List arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.entity.UrlEncodedFormEntity.staticClass, global::org.apache.http.client.entity.UrlEncodedFormEntity._UrlEncodedFormEntity31904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.entity.UrlEncodedFormEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/entity/UrlEncodedFormEntity"));
			global::org.apache.http.client.entity.UrlEncodedFormEntity._UrlEncodedFormEntity31903 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.entity.UrlEncodedFormEntity.staticClass, "<init>", "(Ljava/util/List;Ljava/lang/String;)V");
			global::org.apache.http.client.entity.UrlEncodedFormEntity._UrlEncodedFormEntity31904 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.entity.UrlEncodedFormEntity.staticClass, "<init>", "(Ljava/util/List;)V");
		}
	}
}
