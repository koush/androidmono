namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpInetConnection_))]
	public partial interface HttpInetConnection : HttpConnection
	{
		global::java.net.InetAddress getLocalAddress();
		int getLocalPort();
		global::java.net.InetAddress getRemoteAddress();
		int getRemotePort();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpInetConnection))]
	internal sealed partial class HttpInetConnection_ : java.lang.Object, HttpInetConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpInetConnection_()
		{
			InitJNI();
		}
		internal HttpInetConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress31588;
		global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getLocalAddress31588)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getLocalAddress31588)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort31589;
		int org.apache.http.HttpInetConnection.getLocalPort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getLocalPort31589);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getLocalPort31589);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress31590;
		global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getRemoteAddress31590)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getRemoteAddress31590)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort31591;
		int org.apache.http.HttpInetConnection.getRemotePort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getRemotePort31591);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getRemotePort31591);
		}
		internal static global::MonoJavaBridge.MethodId _shutdown31592;
		void org.apache.http.HttpConnection.shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._shutdown31592);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._shutdown31592);
		}
		internal static global::MonoJavaBridge.MethodId _close31593;
		void org.apache.http.HttpConnection.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._close31593);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._close31593);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen31594;
		bool org.apache.http.HttpConnection.isOpen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._isOpen31594);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._isOpen31594);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics31595;
		global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getMetrics31595)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getMetrics31595)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale31596;
		bool org.apache.http.HttpConnection.isStale()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._isStale31596);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._isStale31596);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout31597;
		void org.apache.http.HttpConnection.setSocketTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._setSocketTimeout31597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._setSocketTimeout31597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout31598;
		int org.apache.http.HttpConnection.getSocketTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getSocketTimeout31598);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getSocketTimeout31598);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpInetConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpInetConnection"));
			global::org.apache.http.HttpInetConnection_._getLocalAddress31588 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.HttpInetConnection_._getLocalPort31589 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getLocalPort", "()I");
			global::org.apache.http.HttpInetConnection_._getRemoteAddress31590 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.HttpInetConnection_._getRemotePort31591 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getRemotePort", "()I");
			global::org.apache.http.HttpInetConnection_._shutdown31592 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.HttpInetConnection_._close31593 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "close", "()V");
			global::org.apache.http.HttpInetConnection_._isOpen31594 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.HttpInetConnection_._getMetrics31595 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.HttpInetConnection_._isStale31596 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "isStale", "()Z");
			global::org.apache.http.HttpInetConnection_._setSocketTimeout31597 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.HttpInetConnection_._getSocketTimeout31598 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getSocketTimeout", "()I");
		}
	}
}
