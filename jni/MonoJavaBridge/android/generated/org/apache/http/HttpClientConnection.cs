namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HttpClientConnection : HttpConnection
	{
		void flush();
		bool isResponseAvailable(int arg0);
		void sendRequestHeader(org.apache.http.HttpRequest arg0);
		void sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0);
		global::org.apache.http.HttpResponse receiveResponseHeader();
		void receiveResponseEntity(org.apache.http.HttpResponse arg0);
	}

	public partial class HttpClientConnection_
	{
		public static global::java.lang.Class _class
		{
			get { return __HttpClientConnection.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HttpClientConnection : java.lang.Object, HttpClientConnection
	{
		internal static global::java.lang.Class staticClass;
		static __HttpClientConnection()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.__HttpClientConnection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.__HttpClientConnection(@__env);
			}
		}
		internal __HttpClientConnection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _flush14205;
		 void org.apache.http.HttpClientConnection.flush() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpClientConnection._flush14205);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpClientConnection.staticClass, global::org.apache.http.__HttpClientConnection._flush14205);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isResponseAvailable14206;
		 bool org.apache.http.HttpClientConnection.isResponseAvailable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HttpClientConnection._isResponseAvailable14206, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HttpClientConnection.staticClass, global::org.apache.http.__HttpClientConnection._isResponseAvailable14206, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendRequestHeader14207;
		 void org.apache.http.HttpClientConnection.sendRequestHeader(org.apache.http.HttpRequest arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpClientConnection._sendRequestHeader14207, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpClientConnection.staticClass, global::org.apache.http.__HttpClientConnection._sendRequestHeader14207, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendRequestEntity14208;
		 void org.apache.http.HttpClientConnection.sendRequestEntity(org.apache.http.HttpEntityEnclosingRequest arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpClientConnection._sendRequestEntity14208, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpClientConnection.staticClass, global::org.apache.http.__HttpClientConnection._sendRequestEntity14208, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _receiveResponseHeader14209;
		 global::org.apache.http.HttpResponse org.apache.http.HttpClientConnection.receiveResponseHeader() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpResponse>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpClientConnection._receiveResponseHeader14209));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpResponse>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpClientConnection.staticClass, global::org.apache.http.__HttpClientConnection._receiveResponseHeader14209));
		}
		internal static global::net.sf.jni4net.jni.MethodId _receiveResponseEntity14210;
		 void org.apache.http.HttpClientConnection.receiveResponseEntity(org.apache.http.HttpResponse arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpClientConnection._receiveResponseEntity14210, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpClientConnection.staticClass, global::org.apache.http.__HttpClientConnection._receiveResponseEntity14210, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _shutdown14211;
		 void org.apache.http.HttpConnection.shutdown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpClientConnection._shutdown14211);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpClientConnection.staticClass, global::org.apache.http.__HttpClientConnection._shutdown14211);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close14212;
		 void org.apache.http.HttpConnection.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpClientConnection._close14212);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpClientConnection.staticClass, global::org.apache.http.__HttpClientConnection._close14212);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOpen14213;
		 bool org.apache.http.HttpConnection.isOpen() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HttpClientConnection._isOpen14213);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HttpClientConnection.staticClass, global::org.apache.http.__HttpClientConnection._isOpen14213);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMetrics14214;
		 global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpConnectionMetrics>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpClientConnection._getMetrics14214));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpConnectionMetrics>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpClientConnection.staticClass, global::org.apache.http.__HttpClientConnection._getMetrics14214));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStale14215;
		 bool org.apache.http.HttpConnection.isStale() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HttpClientConnection._isStale14215);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HttpClientConnection.staticClass, global::org.apache.http.__HttpClientConnection._isStale14215);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSocketTimeout14216;
		 void org.apache.http.HttpConnection.setSocketTimeout(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpClientConnection._setSocketTimeout14216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpClientConnection.staticClass, global::org.apache.http.__HttpClientConnection._setSocketTimeout14216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSocketTimeout14217;
		 int org.apache.http.HttpConnection.getSocketTimeout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.__HttpClientConnection._getSocketTimeout14217);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.__HttpClientConnection.staticClass, global::org.apache.http.__HttpClientConnection._getSocketTimeout14217);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.__HttpClientConnection.staticClass = @__class;
			global::org.apache.http.__HttpClientConnection._flush14205 = @__env.GetMethodID(global::org.apache.http.__HttpClientConnection.staticClass, "org.apache.http.HttpClientConnection.flush", "()V");
			global::org.apache.http.__HttpClientConnection._isResponseAvailable14206 = @__env.GetMethodID(global::org.apache.http.__HttpClientConnection.staticClass, "org.apache.http.HttpClientConnection.isResponseAvailable", "(I)Z");
			global::org.apache.http.__HttpClientConnection._sendRequestHeader14207 = @__env.GetMethodID(global::org.apache.http.__HttpClientConnection.staticClass, "org.apache.http.HttpClientConnection.sendRequestHeader", "(Lorg/apache/http/HttpRequest;)V");
			global::org.apache.http.__HttpClientConnection._sendRequestEntity14208 = @__env.GetMethodID(global::org.apache.http.__HttpClientConnection.staticClass, "org.apache.http.HttpClientConnection.sendRequestEntity", "(Lorg/apache/http/HttpEntityEnclosingRequest;)V");
			global::org.apache.http.__HttpClientConnection._receiveResponseHeader14209 = @__env.GetMethodID(global::org.apache.http.__HttpClientConnection.staticClass, "org.apache.http.HttpClientConnection.receiveResponseHeader", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.__HttpClientConnection._receiveResponseEntity14210 = @__env.GetMethodID(global::org.apache.http.__HttpClientConnection.staticClass, "org.apache.http.HttpClientConnection.receiveResponseEntity", "(Lorg/apache/http/HttpResponse;)V");
			global::org.apache.http.__HttpClientConnection._shutdown14211 = @__env.GetMethodID(global::org.apache.http.__HttpClientConnection.staticClass, "org.apache.http.HttpConnection.shutdown", "()V");
			global::org.apache.http.__HttpClientConnection._close14212 = @__env.GetMethodID(global::org.apache.http.__HttpClientConnection.staticClass, "org.apache.http.HttpConnection.close", "()V");
			global::org.apache.http.__HttpClientConnection._isOpen14213 = @__env.GetMethodID(global::org.apache.http.__HttpClientConnection.staticClass, "org.apache.http.HttpConnection.isOpen", "()Z");
			global::org.apache.http.__HttpClientConnection._getMetrics14214 = @__env.GetMethodID(global::org.apache.http.__HttpClientConnection.staticClass, "org.apache.http.HttpConnection.getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.__HttpClientConnection._isStale14215 = @__env.GetMethodID(global::org.apache.http.__HttpClientConnection.staticClass, "org.apache.http.HttpConnection.isStale", "()Z");
			global::org.apache.http.__HttpClientConnection._setSocketTimeout14216 = @__env.GetMethodID(global::org.apache.http.__HttpClientConnection.staticClass, "org.apache.http.HttpConnection.setSocketTimeout", "(I)V");
			global::org.apache.http.__HttpClientConnection._getSocketTimeout14217 = @__env.GetMethodID(global::org.apache.http.__HttpClientConnection.staticClass, "org.apache.http.HttpConnection.getSocketTimeout", "()I");
		}
	}
}
