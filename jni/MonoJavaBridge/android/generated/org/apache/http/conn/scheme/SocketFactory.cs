namespace org.apache.http.conn.scheme
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface SocketFactory 
	{
		global::java.net.Socket createSocket();
		global::java.net.Socket connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5);
		bool isSecure(java.net.Socket arg0);
	}

	public partial class SocketFactory_
	{
		public static global::java.lang.Class _class
		{
			get { return __SocketFactory.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __SocketFactory : java.lang.Object, SocketFactory
	{
		internal static global::java.lang.Class staticClass;
		static __SocketFactory()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.conn.scheme.__SocketFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.conn.scheme.__SocketFactory(@__env);
			}
		}
		internal __SocketFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _createSocket14502;
		 global::java.net.Socket org.apache.http.conn.scheme.SocketFactory.createSocket() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.scheme.__SocketFactory._createSocket14502));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.scheme.__SocketFactory.staticClass, global::org.apache.http.conn.scheme.__SocketFactory._createSocket14502));
		}
		internal static global::net.sf.jni4net.jni.MethodId _connectSocket14503;
		 global::java.net.Socket org.apache.http.conn.scheme.SocketFactory.connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.scheme.__SocketFactory._connectSocket14503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.scheme.__SocketFactory.staticClass, global::org.apache.http.conn.scheme.__SocketFactory._connectSocket14503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSecure14504;
		 bool org.apache.http.conn.scheme.SocketFactory.isSecure(java.net.Socket arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.scheme.__SocketFactory._isSecure14504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.scheme.__SocketFactory.staticClass, global::org.apache.http.conn.scheme.__SocketFactory._isSecure14504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.conn.scheme.__SocketFactory.staticClass = @__class;
			global::org.apache.http.conn.scheme.__SocketFactory._createSocket14502 = @__env.GetMethodID(global::org.apache.http.conn.scheme.__SocketFactory.staticClass, "org.apache.http.conn.scheme.SocketFactory.createSocket", "()Ljava/net/Socket;");
			global::org.apache.http.conn.scheme.__SocketFactory._connectSocket14503 = @__env.GetMethodID(global::org.apache.http.conn.scheme.__SocketFactory.staticClass, "org.apache.http.conn.scheme.SocketFactory.connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/@params/HttpParams;)Ljava/net/Socket;");
			global::org.apache.http.conn.scheme.__SocketFactory._isSecure14504 = @__env.GetMethodID(global::org.apache.http.conn.scheme.__SocketFactory.staticClass, "org.apache.http.conn.scheme.SocketFactory.isSecure", "(Ljava/net/Socket;)Z");
		}
	}
}
