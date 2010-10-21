namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.methods.AbortableHttpRequest_))]
	public interface AbortableHttpRequest  : global::MonoJavaBridge.IJavaObject 
	{
		void abort();
		void setConnectionRequest(org.apache.http.conn.ClientConnectionRequest arg0);
		void setReleaseTrigger(org.apache.http.conn.ConnectionReleaseTrigger arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.methods.AbortableHttpRequest))]
	public sealed partial class AbortableHttpRequest_ : java.lang.Object, AbortableHttpRequest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbortableHttpRequest_()
		{
			InitJNI();
		}
		internal AbortableHttpRequest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _abort31787;
		 void org.apache.http.client.methods.AbortableHttpRequest.abort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.AbortableHttpRequest_._abort31787);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.AbortableHttpRequest_.staticClass, global::org.apache.http.client.methods.AbortableHttpRequest_._abort31787);
		}
		internal static global::MonoJavaBridge.MethodId _setConnectionRequest31788;
		 void org.apache.http.client.methods.AbortableHttpRequest.setConnectionRequest(org.apache.http.conn.ClientConnectionRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.AbortableHttpRequest_._setConnectionRequest31788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.AbortableHttpRequest_.staticClass, global::org.apache.http.client.methods.AbortableHttpRequest_._setConnectionRequest31788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setReleaseTrigger31789;
		 void org.apache.http.client.methods.AbortableHttpRequest.setReleaseTrigger(org.apache.http.conn.ConnectionReleaseTrigger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.AbortableHttpRequest_._setReleaseTrigger31789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.methods.AbortableHttpRequest_.staticClass, global::org.apache.http.client.methods.AbortableHttpRequest_._setReleaseTrigger31789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.AbortableHttpRequest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/AbortableHttpRequest"));
			global::org.apache.http.client.methods.AbortableHttpRequest_._abort31787 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.AbortableHttpRequest_.staticClass, "abort", "()V");
			global::org.apache.http.client.methods.AbortableHttpRequest_._setConnectionRequest31788 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.AbortableHttpRequest_.staticClass, "setConnectionRequest", "(Lorg/apache/http/conn/ClientConnectionRequest;)V");
			global::org.apache.http.client.methods.AbortableHttpRequest_._setReleaseTrigger31789 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.AbortableHttpRequest_.staticClass, "setReleaseTrigger", "(Lorg/apache/http/conn/ConnectionReleaseTrigger;)V");
		}
	}
}
