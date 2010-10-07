namespace org.apache.http.conn.scheme
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface LayeredSocketFactory : SocketFactory
	{
		global::java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3);
	}

	public partial class LayeredSocketFactory_
	{
		public static global::java.lang.Class _class
		{
			get { return __LayeredSocketFactory.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __LayeredSocketFactory : java.lang.Object, LayeredSocketFactory
	{
		internal static global::java.lang.Class staticClass;
		static __LayeredSocketFactory()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.conn.scheme.__LayeredSocketFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.conn.scheme.__LayeredSocketFactory(@__env);
			}
		}
		internal __LayeredSocketFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _createSocket14481;
		 global::java.net.Socket org.apache.http.conn.scheme.LayeredSocketFactory.createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.scheme.__LayeredSocketFactory._createSocket14481, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.scheme.__LayeredSocketFactory.staticClass, global::org.apache.http.conn.scheme.__LayeredSocketFactory._createSocket14481, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createSocket14482;
		 global::java.net.Socket org.apache.http.conn.scheme.SocketFactory.createSocket() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.scheme.__LayeredSocketFactory._createSocket14482));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.scheme.__LayeredSocketFactory.staticClass, global::org.apache.http.conn.scheme.__LayeredSocketFactory._createSocket14482));
		}
		internal static global::net.sf.jni4net.jni.MethodId _connectSocket14483;
		 global::java.net.Socket org.apache.http.conn.scheme.SocketFactory.connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.scheme.__LayeredSocketFactory._connectSocket14483, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.scheme.__LayeredSocketFactory.staticClass, global::org.apache.http.conn.scheme.__LayeredSocketFactory._connectSocket14483, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSecure14484;
		 bool org.apache.http.conn.scheme.SocketFactory.isSecure(java.net.Socket arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.conn.scheme.__LayeredSocketFactory._isSecure14484, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.conn.scheme.__LayeredSocketFactory.staticClass, global::org.apache.http.conn.scheme.__LayeredSocketFactory._isSecure14484, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.conn.scheme.__LayeredSocketFactory.staticClass = @__class;
			global::org.apache.http.conn.scheme.__LayeredSocketFactory._createSocket14481 = @__env.GetMethodID(global::org.apache.http.conn.scheme.__LayeredSocketFactory.staticClass, "org.apache.http.conn.scheme.LayeredSocketFactory.createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;");
			global::org.apache.http.conn.scheme.__LayeredSocketFactory._createSocket14482 = @__env.GetMethodID(global::org.apache.http.conn.scheme.__LayeredSocketFactory.staticClass, "org.apache.http.conn.scheme.SocketFactory.createSocket", "()Ljava/net/Socket;");
			global::org.apache.http.conn.scheme.__LayeredSocketFactory._connectSocket14483 = @__env.GetMethodID(global::org.apache.http.conn.scheme.__LayeredSocketFactory.staticClass, "org.apache.http.conn.scheme.SocketFactory.connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/@params/HttpParams;)Ljava/net/Socket;");
			global::org.apache.http.conn.scheme.__LayeredSocketFactory._isSecure14484 = @__env.GetMethodID(global::org.apache.http.conn.scheme.__LayeredSocketFactory.staticClass, "org.apache.http.conn.scheme.SocketFactory.isSecure", "(Ljava/net/Socket;)Z");
		}
	}
}
