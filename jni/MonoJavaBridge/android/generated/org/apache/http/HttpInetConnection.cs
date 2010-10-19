namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpInetConnection_))]
	public interface HttpInetConnection : HttpConnection
	{
		global::java.net.InetAddress getLocalAddress();
		int getLocalPort();
		global::java.net.InetAddress getRemoteAddress();
		int getRemotePort();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpInetConnection))]
	public sealed partial class HttpInetConnection_ : java.lang.Object, HttpInetConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpInetConnection_()
		{
			InitJNI();
		}
		internal HttpInetConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress24980;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getLocalAddress24980)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getLocalAddress24980)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort24981;
		 int org.apache.http.HttpInetConnection.getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getLocalPort24981);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getLocalPort24981);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress24982;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getRemoteAddress24982)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getRemoteAddress24982)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort24983;
		 int org.apache.http.HttpInetConnection.getRemotePort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getRemotePort24983);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getRemotePort24983);
		}
		internal static global::MonoJavaBridge.MethodId _shutdown24984;
		 void org.apache.http.HttpConnection.shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._shutdown24984);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._shutdown24984);
		}
		internal static global::MonoJavaBridge.MethodId _close24985;
		 void org.apache.http.HttpConnection.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._close24985);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._close24985);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen24986;
		 bool org.apache.http.HttpConnection.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._isOpen24986);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._isOpen24986);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics24987;
		 global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getMetrics24987)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getMetrics24987)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale24988;
		 bool org.apache.http.HttpConnection.isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._isStale24988);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._isStale24988);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout24989;
		 void org.apache.http.HttpConnection.setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._setSocketTimeout24989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._setSocketTimeout24989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout24990;
		 int org.apache.http.HttpConnection.getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getSocketTimeout24990);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getSocketTimeout24990);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpInetConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpInetConnection"));
			global::org.apache.http.HttpInetConnection_._getLocalAddress24980 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.HttpInetConnection_._getLocalPort24981 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getLocalPort", "()I");
			global::org.apache.http.HttpInetConnection_._getRemoteAddress24982 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.HttpInetConnection_._getRemotePort24983 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getRemotePort", "()I");
			global::org.apache.http.HttpInetConnection_._shutdown24984 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.HttpInetConnection_._close24985 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "close", "()V");
			global::org.apache.http.HttpInetConnection_._isOpen24986 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.HttpInetConnection_._getMetrics24987 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.HttpInetConnection_._isStale24988 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "isStale", "()Z");
			global::org.apache.http.HttpInetConnection_._setSocketTimeout24989 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.HttpInetConnection_._getSocketTimeout24990 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getSocketTimeout", "()I");
		}
	}
}
