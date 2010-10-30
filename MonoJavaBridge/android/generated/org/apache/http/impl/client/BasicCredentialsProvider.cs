namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicCredentialsProvider : java.lang.Object, org.apache.http.client.CredentialsProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicCredentialsProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.impl.client.BasicCredentialsProvider._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, "clear", "()V", ref global::org.apache.http.impl.client.BasicCredentialsProvider._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.apache.http.auth.Credentials getCredentials(org.apache.http.auth.AuthScope arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.auth.Credentials>(this, global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, "getCredentials", "(Lorg/apache/http/auth/AuthScope;)Lorg/apache/http/auth/Credentials;", ref global::org.apache.http.impl.client.BasicCredentialsProvider._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.auth.Credentials;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setCredentials(org.apache.http.auth.AuthScope arg0, org.apache.http.auth.Credentials arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, "setCredentials", "(Lorg/apache/http/auth/AuthScope;Lorg/apache/http/auth/Credentials;)V", ref global::org.apache.http.impl.client.BasicCredentialsProvider._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public BasicCredentialsProvider() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.BasicCredentialsProvider._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.BasicCredentialsProvider._m4 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.BasicCredentialsProvider.staticClass, global::org.apache.http.impl.client.BasicCredentialsProvider._m4);
			Init(@__env, handle);
		}
		static BasicCredentialsProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/BasicCredentialsProvider"));
		}
		internal static void InitJNI()
		{
		}
	}
}
