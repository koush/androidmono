namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HttpInetConnection : HttpConnection
	{
		global::java.net.InetAddress getLocalAddress();
		int getLocalPort();
		global::java.net.InetAddress getRemoteAddress();
		int getRemotePort();
	}

	public partial class HttpInetConnection_
	{
		public static global::java.lang.Class _class
		{
			get { return __HttpInetConnection.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HttpInetConnection : java.lang.Object, HttpInetConnection
	{
		internal static global::java.lang.Class staticClass;
		static __HttpInetConnection()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.__HttpInetConnection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.__HttpInetConnection(@__env);
			}
		}
		internal __HttpInetConnection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocalAddress14274;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getLocalAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpInetConnection._getLocalAddress14274));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpInetConnection.staticClass, global::org.apache.http.__HttpInetConnection._getLocalAddress14274));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocalPort14275;
		 int org.apache.http.HttpInetConnection.getLocalPort() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.__HttpInetConnection._getLocalPort14275);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.__HttpInetConnection.staticClass, global::org.apache.http.__HttpInetConnection._getLocalPort14275);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRemoteAddress14276;
		 global::java.net.InetAddress org.apache.http.HttpInetConnection.getRemoteAddress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpInetConnection._getRemoteAddress14276));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpInetConnection.staticClass, global::org.apache.http.__HttpInetConnection._getRemoteAddress14276));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRemotePort14277;
		 int org.apache.http.HttpInetConnection.getRemotePort() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.__HttpInetConnection._getRemotePort14277);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.__HttpInetConnection.staticClass, global::org.apache.http.__HttpInetConnection._getRemotePort14277);
		}
		internal static global::net.sf.jni4net.jni.MethodId _shutdown14278;
		 void org.apache.http.HttpConnection.shutdown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpInetConnection._shutdown14278);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpInetConnection.staticClass, global::org.apache.http.__HttpInetConnection._shutdown14278);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close14279;
		 void org.apache.http.HttpConnection.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpInetConnection._close14279);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpInetConnection.staticClass, global::org.apache.http.__HttpInetConnection._close14279);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOpen14280;
		 bool org.apache.http.HttpConnection.isOpen() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HttpInetConnection._isOpen14280);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HttpInetConnection.staticClass, global::org.apache.http.__HttpInetConnection._isOpen14280);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMetrics14281;
		 global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpConnectionMetrics>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpInetConnection._getMetrics14281));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpConnectionMetrics>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpInetConnection.staticClass, global::org.apache.http.__HttpInetConnection._getMetrics14281));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStale14282;
		 bool org.apache.http.HttpConnection.isStale() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HttpInetConnection._isStale14282);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HttpInetConnection.staticClass, global::org.apache.http.__HttpInetConnection._isStale14282);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSocketTimeout14283;
		 void org.apache.http.HttpConnection.setSocketTimeout(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpInetConnection._setSocketTimeout14283, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpInetConnection.staticClass, global::org.apache.http.__HttpInetConnection._setSocketTimeout14283, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSocketTimeout14284;
		 int org.apache.http.HttpConnection.getSocketTimeout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.__HttpInetConnection._getSocketTimeout14284);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.__HttpInetConnection.staticClass, global::org.apache.http.__HttpInetConnection._getSocketTimeout14284);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.__HttpInetConnection.staticClass = @__class;
			global::org.apache.http.__HttpInetConnection._getLocalAddress14274 = @__env.GetMethodID(global::org.apache.http.__HttpInetConnection.staticClass, "org.apache.http.HttpInetConnection.getLocalAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.__HttpInetConnection._getLocalPort14275 = @__env.GetMethodID(global::org.apache.http.__HttpInetConnection.staticClass, "org.apache.http.HttpInetConnection.getLocalPort", "()I");
			global::org.apache.http.__HttpInetConnection._getRemoteAddress14276 = @__env.GetMethodID(global::org.apache.http.__HttpInetConnection.staticClass, "org.apache.http.HttpInetConnection.getRemoteAddress", "()Ljava/net/InetAddress;");
			global::org.apache.http.__HttpInetConnection._getRemotePort14277 = @__env.GetMethodID(global::org.apache.http.__HttpInetConnection.staticClass, "org.apache.http.HttpInetConnection.getRemotePort", "()I");
			global::org.apache.http.__HttpInetConnection._shutdown14278 = @__env.GetMethodID(global::org.apache.http.__HttpInetConnection.staticClass, "org.apache.http.HttpConnection.shutdown", "()V");
			global::org.apache.http.__HttpInetConnection._close14279 = @__env.GetMethodID(global::org.apache.http.__HttpInetConnection.staticClass, "org.apache.http.HttpConnection.close", "()V");
			global::org.apache.http.__HttpInetConnection._isOpen14280 = @__env.GetMethodID(global::org.apache.http.__HttpInetConnection.staticClass, "org.apache.http.HttpConnection.isOpen", "()Z");
			global::org.apache.http.__HttpInetConnection._getMetrics14281 = @__env.GetMethodID(global::org.apache.http.__HttpInetConnection.staticClass, "org.apache.http.HttpConnection.getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.__HttpInetConnection._isStale14282 = @__env.GetMethodID(global::org.apache.http.__HttpInetConnection.staticClass, "org.apache.http.HttpConnection.isStale", "()Z");
			global::org.apache.http.__HttpInetConnection._setSocketTimeout14283 = @__env.GetMethodID(global::org.apache.http.__HttpInetConnection.staticClass, "org.apache.http.HttpConnection.setSocketTimeout", "(I)V");
			global::org.apache.http.__HttpInetConnection._getSocketTimeout14284 = @__env.GetMethodID(global::org.apache.http.__HttpInetConnection.staticClass, "org.apache.http.HttpConnection.getSocketTimeout", "()I");
		}
	}
}
