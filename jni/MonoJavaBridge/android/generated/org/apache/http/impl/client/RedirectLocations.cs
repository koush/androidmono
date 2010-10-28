namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RedirectLocations : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RedirectLocations()
		{
			InitJNI();
		}
		protected RedirectLocations(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add32934;
		public virtual void add(java.net.URI arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RedirectLocations._add32934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.RedirectLocations.staticClass, global::org.apache.http.impl.client.RedirectLocations._add32934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains32935;
		public virtual bool contains(java.net.URI arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.RedirectLocations._contains32935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.RedirectLocations.staticClass, global::org.apache.http.impl.client.RedirectLocations._contains32935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove32936;
		public virtual bool remove(java.net.URI arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.RedirectLocations._remove32936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.RedirectLocations.staticClass, global::org.apache.http.impl.client.RedirectLocations._remove32936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RedirectLocations32937;
		public RedirectLocations() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.RedirectLocations.staticClass, global::org.apache.http.impl.client.RedirectLocations._RedirectLocations32937);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.RedirectLocations.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/RedirectLocations"));
			global::org.apache.http.impl.client.RedirectLocations._add32934 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RedirectLocations.staticClass, "add", "(Ljava/net/URI;)V");
			global::org.apache.http.impl.client.RedirectLocations._contains32935 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RedirectLocations.staticClass, "contains", "(Ljava/net/URI;)Z");
			global::org.apache.http.impl.client.RedirectLocations._remove32936 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RedirectLocations.staticClass, "remove", "(Ljava/net/URI;)Z");
			global::org.apache.http.impl.client.RedirectLocations._RedirectLocations32937 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.RedirectLocations.staticClass, "<init>", "()V");
		}
	}
}
