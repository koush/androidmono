namespace org.apache.http.client
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HttpClient 
	{
		global::org.apache.http.@params.HttpParams getParams();
		global::org.apache.http.HttpResponse execute(org.apache.http.client.methods.HttpUriRequest arg0);
		global::org.apache.http.HttpResponse execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.protocol.HttpContext arg1);
		global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1);
		global::org.apache.http.HttpResponse execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2);
		global::java.lang.Object execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1);
		global::java.lang.Object execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1, org.apache.http.protocol.HttpContext arg2);
		global::java.lang.Object execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2);
		global::java.lang.Object execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2, org.apache.http.protocol.HttpContext arg3);
		global::org.apache.http.conn.ClientConnectionManager getConnectionManager();
	}

	public partial class HttpClient_
	{
		public static global::java.lang.Class _class
		{
			get { return __HttpClient.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HttpClient : java.lang.Object, HttpClient
	{
		internal static global::java.lang.Class staticClass;
		static __HttpClient()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.client.__HttpClient), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.client.__HttpClient(@__env);
			}
		}
		internal __HttpClient(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParams14368;
		 global::org.apache.http.@params.HttpParams org.apache.http.client.HttpClient.getParams() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.__HttpClient._getParams14368));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.__HttpClient.staticClass, global::org.apache.http.client.__HttpClient._getParams14368));
		}
		internal static global::net.sf.jni4net.jni.MethodId _execute14369;
		 global::org.apache.http.HttpResponse org.apache.http.client.HttpClient.execute(org.apache.http.client.methods.HttpUriRequest arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpResponse>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.__HttpClient._execute14369, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpResponse>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.__HttpClient.staticClass, global::org.apache.http.client.__HttpClient._execute14369, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _execute14370;
		 global::org.apache.http.HttpResponse org.apache.http.client.HttpClient.execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpResponse>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.__HttpClient._execute14370, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpResponse>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.__HttpClient.staticClass, global::org.apache.http.client.__HttpClient._execute14370, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _execute14371;
		 global::org.apache.http.HttpResponse org.apache.http.client.HttpClient.execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpResponse>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.__HttpClient._execute14371, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpResponse>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.__HttpClient.staticClass, global::org.apache.http.client.__HttpClient._execute14371, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _execute14372;
		 global::org.apache.http.HttpResponse org.apache.http.client.HttpClient.execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpResponse>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.__HttpClient._execute14372, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.HttpResponse>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.__HttpClient.staticClass, global::org.apache.http.client.__HttpClient._execute14372, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _execute14373;
		 global::java.lang.Object org.apache.http.client.HttpClient.execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.__HttpClient._execute14373, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.__HttpClient.staticClass, global::org.apache.http.client.__HttpClient._execute14373, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _execute14374;
		 global::java.lang.Object org.apache.http.client.HttpClient.execute(org.apache.http.client.methods.HttpUriRequest arg0, org.apache.http.client.ResponseHandler arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.__HttpClient._execute14374, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.__HttpClient.staticClass, global::org.apache.http.client.__HttpClient._execute14374, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _execute14375;
		 global::java.lang.Object org.apache.http.client.HttpClient.execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.__HttpClient._execute14375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.__HttpClient.staticClass, global::org.apache.http.client.__HttpClient._execute14375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _execute14376;
		 global::java.lang.Object org.apache.http.client.HttpClient.execute(org.apache.http.HttpHost arg0, org.apache.http.HttpRequest arg1, org.apache.http.client.ResponseHandler arg2, org.apache.http.protocol.HttpContext arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.__HttpClient._execute14376, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.__HttpClient.staticClass, global::org.apache.http.client.__HttpClient._execute14376, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConnectionManager14377;
		 global::org.apache.http.conn.ClientConnectionManager org.apache.http.client.HttpClient.getConnectionManager() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.conn.ClientConnectionManager>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.client.__HttpClient._getConnectionManager14377));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.conn.ClientConnectionManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.client.__HttpClient.staticClass, global::org.apache.http.client.__HttpClient._getConnectionManager14377));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.client.__HttpClient.staticClass = @__class;
			global::org.apache.http.client.__HttpClient._getParams14368 = @__env.GetMethodID(global::org.apache.http.client.__HttpClient.staticClass, "org.apache.http.client.HttpClient.getParams", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.client.__HttpClient._execute14369 = @__env.GetMethodID(global::org.apache.http.client.__HttpClient.staticClass, "org.apache.http.client.HttpClient.execute", "(Lorg/apache/http/client/methods/HttpUriRequest;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.client.__HttpClient._execute14370 = @__env.GetMethodID(global::org.apache.http.client.__HttpClient.staticClass, "org.apache.http.client.HttpClient.execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.client.__HttpClient._execute14371 = @__env.GetMethodID(global::org.apache.http.client.__HttpClient.staticClass, "org.apache.http.client.HttpClient.execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.client.__HttpClient._execute14372 = @__env.GetMethodID(global::org.apache.http.client.__HttpClient.staticClass, "org.apache.http.client.HttpClient.execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;");
			global::org.apache.http.client.__HttpClient._execute14373 = @__env.GetMethodID(global::org.apache.http.client.__HttpClient.staticClass, "org.apache.http.client.HttpClient.execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseHandler;)Ljava/lang/Object;");
			global::org.apache.http.client.__HttpClient._execute14374 = @__env.GetMethodID(global::org.apache.http.client.__HttpClient.staticClass, "org.apache.http.client.HttpClient.execute", "(Lorg/apache/http/client/methods/HttpUriRequest;Lorg/apache/http/client/ResponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;");
			global::org.apache.http.client.__HttpClient._execute14375 = @__env.GetMethodID(global::org.apache.http.client.__HttpClient.staticClass, "org.apache.http.client.HttpClient.execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/ResponseHandler;)Ljava/lang/Object;");
			global::org.apache.http.client.__HttpClient._execute14376 = @__env.GetMethodID(global::org.apache.http.client.__HttpClient.staticClass, "org.apache.http.client.HttpClient.execute", "(Lorg/apache/http/HttpHost;Lorg/apache/http/HttpRequest;Lorg/apache/http/client/ResponseHandler;Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;");
			global::org.apache.http.client.__HttpClient._getConnectionManager14377 = @__env.GetMethodID(global::org.apache.http.client.__HttpClient.staticClass, "org.apache.http.client.HttpClient.getConnectionManager", "()Lorg/apache/http/conn/ClientConnectionManager;");
		}
	}
}
