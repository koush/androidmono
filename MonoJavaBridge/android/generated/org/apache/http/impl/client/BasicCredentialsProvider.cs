namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicCredentialsProvider : java.lang.Object, org.apache.http.client.CredentialsProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicCredentialsProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString32863;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.BasicCredentialsProvider._toString32863.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.BasicCredentialsProvider._toString32863 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, global::org.apache.http.impl.client.BasicCredentialsProvider._toString32863) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear32864;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.BasicCredentialsProvider._clear32864.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.BasicCredentialsProvider._clear32864 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, "clear", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, global::org.apache.http.impl.client.BasicCredentialsProvider._clear32864);
		}
		internal static global::MonoJavaBridge.MethodId _getCredentials32865;
		public virtual global::org.apache.http.auth.Credentials getCredentials(org.apache.http.auth.AuthScope arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.BasicCredentialsProvider._getCredentials32865.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.BasicCredentialsProvider._getCredentials32865 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, "getCredentials", "(Lorg/apache/http/auth/AuthScope;)Lorg/apache/http/auth/Credentials;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.auth.Credentials>(this, global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, global::org.apache.http.impl.client.BasicCredentialsProvider._getCredentials32865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.auth.Credentials;
		}
		internal static global::MonoJavaBridge.MethodId _setCredentials32866;
		public virtual void setCredentials(org.apache.http.auth.AuthScope arg0, org.apache.http.auth.Credentials arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.BasicCredentialsProvider._setCredentials32866.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.BasicCredentialsProvider._setCredentials32866 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, "setCredentials", "(Lorg/apache/http/auth/AuthScope;Lorg/apache/http/auth/Credentials;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, global::org.apache.http.impl.client.BasicCredentialsProvider._setCredentials32866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicCredentialsProvider32867;
		public BasicCredentialsProvider() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.BasicCredentialsProvider._BasicCredentialsProvider32867.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.BasicCredentialsProvider._BasicCredentialsProvider32867 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.BasicCredentialsProvider.staticClass, global::org.apache.http.impl.client.BasicCredentialsProvider._BasicCredentialsProvider32867);
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
