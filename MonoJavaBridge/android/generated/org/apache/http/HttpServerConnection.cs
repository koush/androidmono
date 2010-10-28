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
		internal HttpServerConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _flush31668;
		void org.apache.http.HttpServerConnection.flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._flush31668);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._flush31668);
		}
		internal static global::MonoJavaBridge.MethodId _receiveRequestHeader31669;
		global::org.apache.http.HttpRequest org.apache.http.HttpServerConnection.receiveRequestHeader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._receiveRequestHeader31669)) as org.apache.http.HttpRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._receiveRequestHeader31669)) as org.apache.http.HttpRequest;
		}
		internal static global::MonoJavaBridge.MethodId _receiveRequestEntity31670;
		void org.apache.http.HttpServerConnection.receiveRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._receiveRequestEntity31670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._receiveRequestEntity31670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendResponseHeader31671;
		void org.apache.http.HttpServerConnection.sendResponseHeader(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._sendResponseHeader31671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._sendResponseHeader31671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendResponseEntity31672;
		void org.apache.http.HttpServerConnection.sendResponseEntity(org.apache.http.HttpResponse arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._sendResponseEntity31672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._sendResponseEntity31672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _shutdown31673;
		void org.apache.http.HttpConnection.shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._shutdown31673);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._shutdown31673);
		}
		internal static global::MonoJavaBridge.MethodId _close31674;
		void org.apache.http.HttpConnection.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._close31674);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._close31674);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen31675;
		bool org.apache.http.HttpConnection.isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._isOpen31675);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._isOpen31675);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics31676;
		global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._getMetrics31676)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._getMetrics31676)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale31677;
		bool org.apache.http.HttpConnection.isStale()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._isStale31677);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._isStale31677);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout31678;
		void org.apache.http.HttpConnection.setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._setSocketTimeout31678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._setSocketTimeout31678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout31679;
		int org.apache.http.HttpConnection.getSocketTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_._getSocketTimeout31679);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpServerConnection_.staticClass, global::org.apache.http.HttpServerConnection_._getSocketTimeout31679);
		}
		static HttpServerConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpServerConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpServerConnection"));
			global::org.apache.http.HttpServerConnection_._flush31668 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "flush", "()V");
			global::org.apache.http.HttpServerConnection_._receiveRequestHeader31669 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "receiveRequestHeader", "()Lorg/apache/http/HttpRequest;");
			global::org.apache.http.HttpServerConnection_._receiveRequestEntity31670 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "receiveRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.HttpServerConnection_._sendResponseHeader31671 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "sendResponseHeader", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.HttpServerConnection_._sendResponseEntity31672 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "sendResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.HttpServerConnection_._shutdown31673 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.HttpServerConnection_._close31674 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "close", "()V");
			global::org.apache.http.HttpServerConnection_._isOpen31675 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.HttpServerConnection_._getMetrics31676 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.HttpServerConnection_._isStale31677 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "isStale", "()Z");
			global::org.apache.http.HttpServerConnection_._setSocketTimeout31678 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.HttpServerConnection_._getSocketTimeout31679 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpServerConnection_.staticClass, "getSocketTimeout", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}
