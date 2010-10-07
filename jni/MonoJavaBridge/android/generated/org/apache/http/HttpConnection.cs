namespace org.apache.http
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HttpConnection 
	{
		void shutdown();
		void close();
		bool isOpen();
		global::org.apache.http.HttpConnectionMetrics getMetrics();
		bool isStale();
		void setSocketTimeout(int arg0);
		int getSocketTimeout();
	}

	public partial class HttpConnection_
	{
		public static global::java.lang.Class _class
		{
			get { return __HttpConnection.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HttpConnection : java.lang.Object, HttpConnection
	{
		internal static global::java.lang.Class staticClass;
		static __HttpConnection()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.__HttpConnection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.__HttpConnection(@__env);
			}
		}
		internal __HttpConnection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _shutdown14218;
		 void org.apache.http.HttpConnection.shutdown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpConnection._shutdown14218);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpConnection.staticClass, global::org.apache.http.__HttpConnection._shutdown14218);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close14219;
		 void org.apache.http.HttpConnection.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpConnection._close14219);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpConnection.staticClass, global::org.apache.http.__HttpConnection._close14219);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOpen14220;
		 bool org.apache.http.HttpConnection.isOpen() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HttpConnection._isOpen14220);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HttpConnection.staticClass, global::org.apache.http.__HttpConnection._isOpen14220);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMetrics14221;
		 global::org.apache.http.HttpConnectionMetrics org.apache.http.HttpConnection.getMetrics() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpConnectionMetrics>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.__HttpConnection._getMetrics14221));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpConnectionMetrics>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.__HttpConnection.staticClass, global::org.apache.http.__HttpConnection._getMetrics14221));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStale14222;
		 bool org.apache.http.HttpConnection.isStale() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.__HttpConnection._isStale14222);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.__HttpConnection.staticClass, global::org.apache.http.__HttpConnection._isStale14222);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSocketTimeout14223;
		 void org.apache.http.HttpConnection.setSocketTimeout(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.__HttpConnection._setSocketTimeout14223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.__HttpConnection.staticClass, global::org.apache.http.__HttpConnection._setSocketTimeout14223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSocketTimeout14224;
		 int org.apache.http.HttpConnection.getSocketTimeout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.__HttpConnection._getSocketTimeout14224);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.__HttpConnection.staticClass, global::org.apache.http.__HttpConnection._getSocketTimeout14224);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.__HttpConnection.staticClass = @__class;
			global::org.apache.http.__HttpConnection._shutdown14218 = @__env.GetMethodID(global::org.apache.http.__HttpConnection.staticClass, "org.apache.http.HttpConnection.shutdown", "()V");
			global::org.apache.http.__HttpConnection._close14219 = @__env.GetMethodID(global::org.apache.http.__HttpConnection.staticClass, "org.apache.http.HttpConnection.close", "()V");
			global::org.apache.http.__HttpConnection._isOpen14220 = @__env.GetMethodID(global::org.apache.http.__HttpConnection.staticClass, "org.apache.http.HttpConnection.isOpen", "()Z");
			global::org.apache.http.__HttpConnection._getMetrics14221 = @__env.GetMethodID(global::org.apache.http.__HttpConnection.staticClass, "org.apache.http.HttpConnection.getMetrics", "()Lorg/apache/http/HttpConnectionMetrics;");
			global::org.apache.http.__HttpConnection._isStale14222 = @__env.GetMethodID(global::org.apache.http.__HttpConnection.staticClass, "org.apache.http.HttpConnection.isStale", "()Z");
			global::org.apache.http.__HttpConnection._setSocketTimeout14223 = @__env.GetMethodID(global::org.apache.http.__HttpConnection.staticClass, "org.apache.http.HttpConnection.setSocketTimeout", "(I)V");
			global::org.apache.http.__HttpConnection._getSocketTimeout14224 = @__env.GetMethodID(global::org.apache.http.__HttpConnection.staticClass, "org.apache.http.HttpConnection.getSocketTimeout", "()I");
		}
	}
}
