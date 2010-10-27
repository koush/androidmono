namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpServerConnection_))]
	public partial interface HttpServerConnection : HttpConnection
	{
		void flush();
		global::org.apache.http.HttpRequest receiveRequestHeader();
		void receiveRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0);
		void sendResponseHeader(org.apache.http.HttpResponse arg0);
		void sendResponseEntity(org.apache.http.HttpResponse arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpServerConnection))]
	internal sealed partial class HttpServerConnection_ : java.lang.Object, HttpServerConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpServerConnection_()
		{
			InitJNI();
		}
		internal HttpServerConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _flush31667;
		void org.apache.http.HttpServerConnection.flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._flush31667);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._flush31667);
		}
		internal static global::MonoJavaBridge.MethodId _receiveRequestHeader31668;
		global::org.apache.http.HttpRequest org.apache.http.HttpServerConnection.receiveRequestHeader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._receiveRequestHeader31668)) as org.apache.http.HttpRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._receiveRequestHeader31668)) as org.apache.http.HttpRequest;
		}
		internal static global::MonoJavaBridge.MethodId _receiveRequestEntity31669;
		void org.apache.http.HttpServerConnection.receiveRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._receiveRequestEntity31669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._receiveRequestEntity31669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendResponseHeader31670;
		void org.apache.http.HttpServerConnection.sendResponseHeader(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._sendResponseHeader31670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._sendResponseHeader31670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendResponseEntity31671;
		void org.apache.http.HttpServerConnection.sendResponseEntity(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._sendResponseEntity31671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._sendResponseEntity31671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown31672;
		void org.apache.http.HttpConnection.shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._shutdown31672);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._shutdown31672);
		}
		internal static global::MonoJavaBridge.MethodId _close31673;
		void org.apache.http.HttpConnection.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._close31673);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._close31673);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen31674;
		bool org.apache.http.HttpConnection.isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._isOpen31674);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._isOpen31674);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics31675;
		global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._getMetrics31675)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._getMetrics31675)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale31676;
		bool org.apache.http.HttpConnection.isStale()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._isStale31676);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._isStale31676);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout31677;
		void org.apache.http.HttpConnection.setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._setSocketTimeout31677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._setSocketTimeout31677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout31678;
		int org.apache.http.HttpConnection.getSocketTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._getSocketTimeout31678);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._getSocketTimeout31678);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpServerConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpServerConnection"));
			global::org.apache.http.HttpServerConnection_._flush31667 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "flush", "()V");
			global::org.apache.http.HttpServerConnection_._receiveRequestHeader31668 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "receiveRequestHeader", "()Lorg/apache/http/HttpRequest;");
			global::org.apache.http.HttpServerConnection_._receiveRequestEntity31669 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "receiveRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.HttpServerConnection_._sendResponseHeader31670 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "sendResponseHeader", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.HttpServerConnection_._sendResponseEntity31671 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "sendResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.HttpServerConnection_._shutdown31672 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.HttpServerConnection_._close31673 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "close", "()V");
			global::org.apache.http.HttpServerConnection_._isOpen31674 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.HttpServerConnection_._getMetrics31675 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.HttpServerConnection_._isStale31676 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "isStale", "()Z");
			global::org.apache.http.HttpServerConnection_._setSocketTimeout31677 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.HttpServerConnection_._getSocketTimeout31678 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "getSocketTimeout", "()I");
		}
	}
}
