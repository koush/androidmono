namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RedirectLocations : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RedirectLocations(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void add(java.net.URI arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.RedirectLocations.staticClass, "add", "(Ljava/net/URI;)V", ref global::org.apache.http.impl.client.RedirectLocations._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool contains(java.net.URI arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.RedirectLocations.staticClass, "contains", "(Ljava/net/URI;)Z", ref global::org.apache.http.impl.client.RedirectLocations._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool remove(java.net.URI arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.RedirectLocations.staticClass, "remove", "(Ljava/net/URI;)Z", ref global::org.apache.http.impl.client.RedirectLocations._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public RedirectLocations() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.RedirectLocations._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.RedirectLocations._m3 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RedirectLocations.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.RedirectLocations.staticClass, global::org.apache.http.impl.client.RedirectLocations._m3);
			Init(@__env, handle);
		}
		static RedirectLocations()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.RedirectLocations.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/RedirectLocations"));
		}
	}
}
