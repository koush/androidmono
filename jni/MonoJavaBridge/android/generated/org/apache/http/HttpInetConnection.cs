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
		internal static global::MonoJavaBridge.MethodId _getLocalAddress16189;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getLocalAddress16189)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getLocalAddress16189)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort16190;
		 int org.apache.http.HttpInetConnection.getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getLocalPort16190);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getLocalPort16190);
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteAddress16191;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getRemoteAddress16191)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getRemoteAddress16191)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _getRemotePort16192;
		 int org.apache.http.HttpInetConnection.getRemotePort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getRemotePort16192);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getRemotePort16192);
		}
		internal static global::MonoJavaBridge.MethodId _shutdown16193;
		 void org.apache.http.HttpConnection.shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._shutdown16193);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._shutdown16193);
		}
		internal static global::MonoJavaBridge.MethodId _close16194;
		 void org.apache.http.HttpConnection.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._close16194);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._close16194);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen16195;
		 bool org.apache.http.HttpConnection.isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._isOpen16195);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._isOpen16195);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics16196;
		 global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getMetrics16196)) as org.apache.http.HttpConnectionMetrics;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpConnectionMetrics>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getMetrics16196)) as org.apache.http.HttpConnectionMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _isStale16197;
		 bool org.apache.http.HttpConnection.isStale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._isStale16197);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._isStale16197);
		}
		internal static global::MonoJavaBridge.MethodId _setSocketTimeout16198;
		 void org.apache.http.HttpConnection.setSocketTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._setSocketTimeout16198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._setSocketTimeout16198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSocketTimeout16199;
		 int org.apache.http.HttpConnection.getSocketTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_._getSocketTimeout16199);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.HttpInetConnection_.staticClass, global::org.apache.http.HttpInetConnection_._getSocketTimeout16199);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpInetConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpInetConnection"));
			global::org.apache.http.HttpInetConnection_._getLocalAddress16189 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.HttpInetConnection_._getLocalPort16190 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getLocalPort", "()I");
			global::org.apache.http.HttpInetConnection_._getRemoteAddress16191 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.HttpInetConnection_._getRemotePort16192 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getRemotePort", "()I");
			global::org.apache.http.HttpInetConnection_._shutdown16193 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "shutdown", "()V");
			global::org.apache.http.HttpInetConnection_._close16194 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "close", "()V");
			global::org.apache.http.HttpInetConnection_._isOpen16195 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "isOpen", "()Z");
			global::org.apache.http.HttpInetConnection_._getMetrics16196 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.HttpInetConnection_._isStale16197 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "isStale", "()Z");
			global::org.apache.http.HttpInetConnection_._setSocketTimeout16198 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "setSocketTimeout", "(I)V");
			global::org.apache.http.HttpInetConnection_._getSocketTimeout16199 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpInetConnection_.staticClass, "getSocketTimeout", "()I");
		}
	}
}
