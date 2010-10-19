namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpServerConnection_))]
	public interface HttpServerConnection : HttpConnection
	{
		void flush();
		global::org.apache.http.HttpRequest receiveRequestHeader();
		void receiveRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0);
		void sendResponseHeader(org.apache.http.HttpResponse arg0);
		void sendResponseEntity(org.apache.http.HttpResponse arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpServerConnection))]
	public sealed partial class HttpServerConnection_ : java.lang.Object, HttpServerConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpServerConnection_()
		{
			InitJNI();
		}
		internal HttpServerConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _flush25059;
		 void org.apache.http.HttpServerConnection.flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._flush25059);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._flush25059);
		}
		internal static global::MonoJavaBridge.MethodId _receiveRequestHeader25060;
		 global::org.apache.http.HttpRequest org.apache.http.HttpServerConnection.receiveRequestHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._receiveRequestHeader25060)) as org.apache.http.HttpRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._receiveRequestHeader25060)) as org.apache.http.HttpRequest;
		}
		internal static global::MonoJavaBridge.MethodId _receiveRequestEntity25061;
		 void org.apache.http.HttpServerConnection.receiveRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._receiveRequestEntity25061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._receiveRequestEntity25061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendResponseHeader25062;
		 void org.apache.http.HttpServerConnection.sendResponseHeader(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._sendResponseHeader25062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._sendResponseHeader25062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendResponseEntity25063;
		 void org.apache.http.HttpServerConnection.sendResponseEntity(org.apache.http.HttpResponse arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._sendResponseEntity25063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._sendResponseEntity25063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown25064;
		 void org.apache.http.HttpConnection.shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._shutdown25064);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._shutdown25064);
		}
		internal static global::MonoJavaBridge.MethodId _close25065;
		 void org.apache.http.HttpConnection.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._close25065);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._close25065);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen25066;
		 bool org.apache.http.HttpConnection.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._isOpen25066);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._isOpen25066);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics25067;
		 global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._getMetrics25067)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._getMetrics25067)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale25068;
		 bool org.apache.http.HttpConnection.isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._isStale25068);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._isStale25068);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout25069;
		 void org.apache.http.HttpConnection.setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._setSocketTimeout25069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._setSocketTimeout25069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout25070;
		 int org.apache.http.HttpConnection.getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._getSocketTimeout25070);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._getSocketTimeout25070);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpServerConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpServerConnection"));
			global::org.apache.http.HttpServerConnection_._flush25059 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "flush", "()V");
			global::org.apache.http.HttpServerConnection_._receiveRequestHeader25060 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "receiveRequestHeader", "()Lorg/apache/http/HttpRequest;");
			global::org.apache.http.HttpServerConnection_._receiveRequestEntity25061 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "receiveRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.HttpServerConnection_._sendResponseHeader25062 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "sendResponseHeader", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.HttpServerConnection_._sendResponseEntity25063 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "sendResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.HttpServerConnection_._shutdown25064 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.HttpServerConnection_._close25065 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "close", "()V");
			global::org.apache.http.HttpServerConnection_._isOpen25066 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.HttpServerConnection_._getMetrics25067 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.HttpServerConnection_._isStale25068 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "isStale", "()Z");
			global::org.apache.http.HttpServerConnection_._setSocketTimeout25069 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.HttpServerConnection_._getSocketTimeout25070 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "getSocketTimeout", "()I");
		}
	}
}
