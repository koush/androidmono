namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EntityEnclosingRequestWrapper : org.apache.http.impl.client.RequestWrapper, HttpEntityEnclosingRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EntityEnclosingRequestWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._m0);
		}
		public new global::org.apache.http.HttpEntity Entity
		{
			get
			{
				return getEntity();
			}
			set
			{
				setEntity(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.apache.http.HttpEntity getEntity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpEntity>(this, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, "getEntity", "()Lorg/apache/http/HttpEntity;", ref global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._m1) as org.apache.http.HttpEntity;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setEntity(org.apache.http.HttpEntity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, "setEntity", "(Lorg/apache/http/HttpEntity;)V", ref global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool expectContinue()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, "expectContinue", "()Z", ref global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public EntityEnclosingRequestWrapper(org.apache.http.HttpEntityEnclosingRequest arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._m4 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, "<init>", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EntityEnclosingRequestWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/EntityEnclosingRequestWrapper"));
		}
	}
}
