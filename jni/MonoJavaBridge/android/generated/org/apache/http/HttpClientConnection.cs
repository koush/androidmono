namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpClientConnection_))]
	public interface HttpClientConnection : HttpConnection
	{
		void flush();
		bool isResponseAvailable(int arg0);
		void sendRequestHeader(org.apache.http.HttpRequest arg0);
		void sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0);
		global::org.apache.http.HttpResponse receiveResponseHeader();
		void receiveResponseEntity(org.apache.http.HttpResponse arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpClientConnection))]
	public sealed partial class HttpClientConnection_ : java.lang.Object, HttpClientConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpClientConnection_()
		{
			InitJNI();
		}
		internal HttpClientConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _flush24908;
		 void org.apache.http.HttpClientConnection.flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_._flush24908);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_.staticClass, global::org.apache.http.HttpClientConnection_._flush24908);
		}
		internal static global::MonoJavaBridge.MethodId _isResponseAvailable24909;
		 bool org.apache.http.HttpClientConnection.isResponseAvailable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_._isResponseAvailable24909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_.staticClass, global::org.apache.http.HttpClientConnection_._isResponseAvailable24909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestHeader24910;
		 void org.apache.http.HttpClientConnection.sendRequestHeader(org.apache.http.HttpRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_._sendRequestHeader24910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_.staticClass, global::org.apache.http.HttpClientConnection_._sendRequestHeader24910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendRequestEntity24911;
		 void org.apache.http.HttpClientConnection.sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_._sendRequestEntity24911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_.staticClass, global::org.apache.http.HttpClientConnection_._sendRequestEntity24911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseHeader24912;
		 global::org.apache.http.HttpResponse org.apache.http.HttpClientConnection.receiveResponseHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_._receiveResponseHeader24912)) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_.staticClass, global::org.apache.http.HttpClientConnection_._receiveResponseHeader24912)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _receiveResponseEntity24913;
		 void org.apache.http.HttpClientConnection.receiveResponseEntity(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_._receiveResponseEntity24913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_.staticClass, global::org.apache.http.HttpClientConnection_._receiveResponseEntity24913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown24914;
		 void org.apache.http.HttpConnection.shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_._shutdown24914);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_.staticClass, global::org.apache.http.HttpClientConnection_._shutdown24914);
		}
		internal static global::MonoJavaBridge.MethodId _close24915;
		 void org.apache.http.HttpConnection.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_._close24915);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_.staticClass, global::org.apache.http.HttpClientConnection_._close24915);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen24916;
		 bool org.apache.http.HttpConnection.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_._isOpen24916);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_.staticClass, global::org.apache.http.HttpClientConnection_._isOpen24916);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics24917;
		 global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_._getMetrics24917)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_.staticClass, global::org.apache.http.HttpClientConnection_._getMetrics24917)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale24918;
		 bool org.apache.http.HttpConnection.isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_._isStale24918);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_.staticClass, global::org.apache.http.HttpClientConnection_._isStale24918);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout24919;
		 void org.apache.http.HttpConnection.setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_._setSocketTimeout24919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_.staticClass, global::org.apache.http.HttpClientConnection_._setSocketTimeout24919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout24920;
		 int org.apache.http.HttpConnection.getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_._getSocketTimeout24920);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpClientConnection_.staticClass, global::org.apache.http.HttpClientConnection_._getSocketTimeout24920);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpClientConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpClientConnection"));
			global::org.apache.http.HttpClientConnection_._flush24908 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpClientConnection_.staticClass, "flush", "()V");
			global::org.apache.http.HttpClientConnection_._isResponseAvailable24909 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpClientConnection_.staticClass, "isResponseAvailable", "(I)Z");
			global::org.apache.http.HttpClientConnection_._sendRequestHeader24910 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpClientConnection_.staticClass, "sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.HttpClientConnection_._sendRequestEntity24911 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpClientConnection_.staticClass, "sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.HttpClientConnection_._receiveResponseHeader24912 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpClientConnection_.staticClass, "receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.HttpClientConnection_._receiveResponseEntity24913 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpClientConnection_.staticClass, "receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.HttpClientConnection_._shutdown24914 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpClientConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.HttpClientConnection_._close24915 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpClientConnection_.staticClass, "close", "()V");
			global::org.apache.http.HttpClientConnection_._isOpen24916 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpClientConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.HttpClientConnection_._getMetrics24917 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpClientConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.HttpClientConnection_._isStale24918 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpClientConnection_.staticClass, "isStale", "()Z");
			global::org.apache.http.HttpClientConnection_._setSocketTimeout24919 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpClientConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.HttpClientConnection_._getSocketTimeout24920 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpClientConnection_.staticClass, "getSocketTimeout", "()I");
		}
	}
}
