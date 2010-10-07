namespace org.apache.http.conn
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface ClientConnectionManager 
	{
		void shutdown();
		global::org.apache.http.conn.scheme.SchemeRegistry getSchemeRegistry();
		global::org.apache.http.conn.ClientConnectionRequest requestConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1);
		void releaseConnection(org.apache.http.conn.ManagedClientConnection arg0, long arg1, java.util.concurrent.TimeUnit arg2);
		void closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1);
		void closeExpiredConnections();
	}

	public partial class ClientConnectionManager_
	{
		public static global::java.lang.Class _class
		{
			get { return __ClientConnectionManager.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __ClientConnectionManager : java.lang.Object, ClientConnectionManager
	{
		internal static global::java.lang.Class staticClass;
		static __ClientConnectionManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.conn.__ClientConnectionManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.conn.__ClientConnectionManager(@__env);
			}
		}
		internal __ClientConnectionManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _shutdown14401;
		 void org.apache.http.conn.ClientConnectionManager.shutdown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ClientConnectionManager._shutdown14401);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ClientConnectionManager.staticClass, global::org.apache.http.conn.__ClientConnectionManager._shutdown14401);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSchemeRegistry14402;
		 global::org.apache.http.conn.scheme.SchemeRegistry org.apache.http.conn.ClientConnectionManager.getSchemeRegistry() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.scheme.SchemeRegistry>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.__ClientConnectionManager._getSchemeRegistry14402));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<org.apache.http.conn.scheme.SchemeRegistry>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.__ClientConnectionManager.staticClass, global::org.apache.http.conn.__ClientConnectionManager._getSchemeRegistry14402));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestConnection14403;
		 global::org.apache.http.conn.ClientConnectionRequest org.apache.http.conn.ClientConnectionManager.requestConnection(org.apache.http.conn.routing.HttpRoute arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.conn.ClientConnectionRequest>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.__ClientConnectionManager._requestConnection14403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.conn.ClientConnectionRequest>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.__ClientConnectionManager.staticClass, global::org.apache.http.conn.__ClientConnectionManager._requestConnection14403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _releaseConnection14404;
		 void org.apache.http.conn.ClientConnectionManager.releaseConnection(org.apache.http.conn.ManagedClientConnection arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ClientConnectionManager._releaseConnection14404, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ClientConnectionManager.staticClass, global::org.apache.http.conn.__ClientConnectionManager._releaseConnection14404, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _closeIdleConnections14405;
		 void org.apache.http.conn.ClientConnectionManager.closeIdleConnections(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ClientConnectionManager._closeIdleConnections14405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ClientConnectionManager.staticClass, global::org.apache.http.conn.__ClientConnectionManager._closeIdleConnections14405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _closeExpiredConnections14406;
		 void org.apache.http.conn.ClientConnectionManager.closeExpiredConnections() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ClientConnectionManager._closeExpiredConnections14406);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ClientConnectionManager.staticClass, global::org.apache.http.conn.__ClientConnectionManager._closeExpiredConnections14406);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.conn.__ClientConnectionManager.staticClass = @__class;
			global::org.apache.http.conn.__ClientConnectionManager._shutdown14401 = @__env.GetMethodID(global::org.apache.http.conn.__ClientConnectionManager.staticClass, "org.apache.http.conn.ClientConnectionManager.shutdown", "()V");
			global::org.apache.http.conn.__ClientConnectionManager._getSchemeRegistry14402 = @__env.GetMethodID(global::org.apache.http.conn.__ClientConnectionManager.staticClass, "org.apache.http.conn.ClientConnectionManager.getSchemeRegistry", "()Lorg/apache/http/conn/scheme/SchemeRegistry;");
			global::org.apache.http.conn.__ClientConnectionManager._requestConnection14403 = @__env.GetMethodID(global::org.apache.http.conn.__ClientConnectionManager.staticClass, "org.apache.http.conn.ClientConnectionManager.requestConnection", "(Lorg/apache/http/conn/routing/HttpRoute;Ljava/lang/Object;)Lorg/apache/http/conn/ClientConnectionRequest;");
			global::org.apache.http.conn.__ClientConnectionManager._releaseConnection14404 = @__env.GetMethodID(global::org.apache.http.conn.__ClientConnectionManager.staticClass, "org.apache.http.conn.ClientConnectionManager.releaseConnection", "(Lorg/apache/http/conn/ManagedClientConnection;JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.conn.__ClientConnectionManager._closeIdleConnections14405 = @__env.GetMethodID(global::org.apache.http.conn.__ClientConnectionManager.staticClass, "org.apache.http.conn.ClientConnectionManager.closeIdleConnections", "(JLjava/util/concurrent/TimeUnit;)V");
			global::org.apache.http.conn.__ClientConnectionManager._closeExpiredConnections14406 = @__env.GetMethodID(global::org.apache.http.conn.__ClientConnectionManager.staticClass, "org.apache.http.conn.ClientConnectionManager.closeExpiredConnections", "()V");
		}
	}
}
