namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHttpEntityEnclosingRequest : org.apache.http.message.BasicHttpRequest, HttpEntityEnclosingRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicHttpEntityEnclosingRequest()
		{
			InitJNI();
		}
		protected BasicHttpEntityEnclosingRequest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
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
		internal static global::MonoJavaBridge.MethodId _getEntity26820;
		public virtual global::org.apache.http.HttpEntity getEntity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpEntity>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpEntityEnclosingRequest._getEntity26820)) as org.apache.http.HttpEntity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpEntity>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, global::org.apache.http.message.BasicHttpEntityEnclosingRequest._getEntity26820)) as org.apache.http.HttpEntity;
		}
		internal static global::MonoJavaBridge.MethodId _setEntity26821;
		public virtual void setEntity(org.apache.http.HttpEntity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpEntityEnclosingRequest._setEntity26821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, global::org.apache.http.message.BasicHttpEntityEnclosingRequest._setEntity26821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _expectContinue26822;
		public virtual bool expectContinue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpEntityEnclosingRequest._expectContinue26822);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, global::org.apache.http.message.BasicHttpEntityEnclosingRequest._expectContinue26822);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpEntityEnclosingRequest26823;
		public BasicHttpEntityEnclosingRequest(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, global::org.apache.http.message.BasicHttpEntityEnclosingRequest._BasicHttpEntityEnclosingRequest26823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpEntityEnclosingRequest26824;
		public BasicHttpEntityEnclosingRequest(java.lang.String arg0, java.lang.String arg1, org.apache.http.ProtocolVersion arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, global::org.apache.http.message.BasicHttpEntityEnclosingRequest._BasicHttpEntityEnclosingRequest26824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpEntityEnclosingRequest26825;
		public BasicHttpEntityEnclosingRequest(org.apache.http.RequestLine arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, global::org.apache.http.message.BasicHttpEntityEnclosingRequest._BasicHttpEntityEnclosingRequest26825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHttpEntityEnclosingRequest"));
			global::org.apache.http.message.BasicHttpEntityEnclosingRequest._getEntity26820 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, "getEntity", "()Lorg/apache/http/HttpEntity;");
			global::org.apache.http.message.BasicHttpEntityEnclosingRequest._setEntity26821 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, "setEntity", "(Lorg/apache/http/HttpEntity;)V");
			global::org.apache.http.message.BasicHttpEntityEnclosingRequest._expectContinue26822 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, "expectContinue", "()Z");
			global::org.apache.http.message.BasicHttpEntityEnclosingRequest._BasicHttpEntityEnclosingRequest26823 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.message.BasicHttpEntityEnclosingRequest._BasicHttpEntityEnclosingRequest26824 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)V");
			global::org.apache.http.message.BasicHttpEntityEnclosingRequest._BasicHttpEntityEnclosingRequest26825 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHttpEntityEnclosingRequest.staticClass, "<init>", "(Lorg/apache/http/RequestLine;)V");
		}
	}
}
