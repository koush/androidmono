namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicCredentialsProvider : java.lang.Object, org.apache.http.client.CredentialsProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicCredentialsProvider()
		{
			InitJNI();
		}
		protected BasicCredentialsProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString32862;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCredentialsProvider._toString32862)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, global::org.apache.http.impl.client.BasicCredentialsProvider._toString32862)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear32863;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCredentialsProvider._clear32863);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, global::org.apache.http.impl.client.BasicCredentialsProvider._clear32863);
		}
		internal static global::MonoJavaBridge.MethodId _getCredentials32864;
		public virtual global::org.apache.http.auth.Credentials getCredentials(org.apache.http.auth.AuthScope arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.Credentials>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCredentialsProvider._getCredentials32864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.auth.Credentials;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.Credentials>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, global::org.apache.http.impl.client.BasicCredentialsProvider._getCredentials32864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.auth.Credentials;
		}
		internal static global::MonoJavaBridge.MethodId _setCredentials32865;
		public virtual void setCredentials(org.apache.http.auth.AuthScope arg0, org.apache.http.auth.Credentials arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCredentialsProvider._setCredentials32865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, global::org.apache.http.impl.client.BasicCredentialsProvider._setCredentials32865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicCredentialsProvider32866;
		public BasicCredentialsProvider() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.BasicCredentialsProvider.staticClass, global::org.apache.http.impl.client.BasicCredentialsProvider._BasicCredentialsProvider32866);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/BasicCredentialsProvider"));
			global::org.apache.http.impl.client.BasicCredentialsProvider._toString32862 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.impl.client.BasicCredentialsProvider._clear32863 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, "clear", "()V");
			global::org.apache.http.impl.client.BasicCredentialsProvider._getCredentials32864 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, "getCredentials", "(Lorg/apache/http/auth/AuthScope;)Lorg/apache/http/auth/Credentials;");
			global::org.apache.http.impl.client.BasicCredentialsProvider._setCredentials32865 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, "setCredentials", "(Lorg/apache/http/auth/AuthScope;Lorg/apache/http/auth/Credentials;)V");
			global::org.apache.http.impl.client.BasicCredentialsProvider._BasicCredentialsProvider32866 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.BasicCredentialsProvider.staticClass, "<init>", "()V");
		}
	}
}
