namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EntityEnclosingRequestWrapper : org.apache.http.impl.client.RequestWrapper, HttpEntityEnclosingRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EntityEnclosingRequestWrapper()
		{
			InitJNI();
		}
		protected EntityEnclosingRequestWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32929;
		public override bool isRepeatable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._isRepeatable32929);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._isRepeatable32929);
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
		internal static global::MonoJavaBridge.MethodId _getEntity32930;
		public virtual global::org.apache.http.HttpEntity getEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpEntity>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._getEntity32930)) as org.apache.http.HttpEntity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpEntity>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._getEntity32930)) as org.apache.http.HttpEntity;
		}
		internal static global::MonoJavaBridge.MethodId _setEntity32931;
		public virtual void setEntity(org.apache.http.HttpEntity arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._setEntity32931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._setEntity32931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _expectContinue32932;
		public virtual bool expectContinue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._expectContinue32932);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._expectContinue32932);
		}
		internal static global::MonoJavaBridge.MethodId _EntityEnclosingRequestWrapper32933;
		public EntityEnclosingRequestWrapper(org.apache.http.HttpEntityEnclosingRequest arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._EntityEnclosingRequestWrapper32933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/EntityEnclosingRequestWrapper"));
			global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._isRepeatable32929 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._getEntity32930 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, "getEntity", "()Lorg/apache/http/HttpEntity;");
			global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._setEntity32931 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, "setEntity", "(Lorg/apache/http/HttpEntity;)V");
			global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._expectContinue32932 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, "expectContinue", "()Z");
			global::org.apache.http.impl.client.EntityEnclosingRequestWrapper._EntityEnclosingRequestWrapper32933 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.EntityEnclosingRequestWrapper.staticClass, "<init>", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
		}
	}
}
