namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpConnection_))]
	public partial interface HttpConnection  : global::MonoJavaBridge.IJavaObject 
	{
		void shutdown();
		void close();
		bool isOpen();
		global::org.apache.http.HttpConnectionMetrics getMetrics();
		bool isStale();
		void setSocketTimeout(int arg0);
		int getSocketTimeout();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpConnection))]
	public sealed partial class HttpConnection_ : java.lang.Object, HttpConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpConnection_()
		{
			InitJNI();
		}
		internal HttpConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown31410;
		 void org.apache.http.HttpConnection.shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnection_._shutdown31410);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnection_.staticClass, global::org.apache.http.HttpConnection_._shutdown31410);
		}
		internal static global::MonoJavaBridge.MethodId _close31411;
		 void org.apache.http.HttpConnection.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnection_._close31411);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnection_.staticClass, global::org.apache.http.HttpConnection_._close31411);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen31412;
		 bool org.apache.http.HttpConnection.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpConnection_._isOpen31412);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpConnection_.staticClass, global::org.apache.http.HttpConnection_._isOpen31412);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics31413;
		 global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpConnection_._getMetrics31413)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpConnection_.staticClass, global::org.apache.http.HttpConnection_._getMetrics31413)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale31414;
		 bool org.apache.http.HttpConnection.isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpConnection_._isStale31414);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpConnection_.staticClass, global::org.apache.http.HttpConnection_._isStale31414);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout31415;
		 void org.apache.http.HttpConnection.setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnection_._setSocketTimeout31415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpConnection_.staticClass, global::org.apache.http.HttpConnection_._setSocketTimeout31415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout31416;
		 int org.apache.http.HttpConnection.getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpConnection_._getSocketTimeout31416);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpConnection_.staticClass, global::org.apache.http.HttpConnection_._getSocketTimeout31416);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpConnection"));
			global::org.apache.http.HttpConnection_._shutdown31410 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.HttpConnection_._close31411 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnection_.staticClass, "close", "()V");
			global::org.apache.http.HttpConnection_._isOpen31412 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.HttpConnection_._getMetrics31413 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.HttpConnection_._isStale31414 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnection_.staticClass, "isStale", "()Z");
			global::org.apache.http.HttpConnection_._setSocketTimeout31415 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.HttpConnection_._getSocketTimeout31416 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpConnection_.staticClass, "getSocketTimeout", "()I");
		}
	}
}
