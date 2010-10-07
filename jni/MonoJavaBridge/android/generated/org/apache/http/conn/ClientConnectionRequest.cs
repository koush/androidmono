namespace org.apache.http.conn
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface ClientConnectionRequest 
	{
		global::org.apache.http.conn.ManagedClientConnection getConnection(long arg0, java.util.concurrent.TimeUnit arg1);
		void abortRequest();
	}

	public partial class ClientConnectionRequest_
	{
		public static global::java.lang.Class _class
		{
			get { return __ClientConnectionRequest.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __ClientConnectionRequest : java.lang.Object, ClientConnectionRequest
	{
		internal static global::java.lang.Class staticClass;
		static __ClientConnectionRequest()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.conn.__ClientConnectionRequest), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.conn.__ClientConnectionRequest(@__env);
			}
		}
		internal __ClientConnectionRequest(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConnection14407;
		 global::org.apache.http.conn.ManagedClientConnection org.apache.http.conn.ClientConnectionRequest.getConnection(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.conn.ManagedClientConnection>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.conn.__ClientConnectionRequest._getConnection14407, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.conn.ManagedClientConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.conn.__ClientConnectionRequest.staticClass, global::org.apache.http.conn.__ClientConnectionRequest._getConnection14407, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _abortRequest14408;
		 void org.apache.http.conn.ClientConnectionRequest.abortRequest() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ClientConnectionRequest._abortRequest14408);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ClientConnectionRequest.staticClass, global::org.apache.http.conn.__ClientConnectionRequest._abortRequest14408);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.conn.__ClientConnectionRequest.staticClass = @__class;
			global::org.apache.http.conn.__ClientConnectionRequest._getConnection14407 = @__env.GetMethodID(global::org.apache.http.conn.__ClientConnectionRequest.staticClass, "org.apache.http.conn.ClientConnectionRequest.getConnection", "(JLjava/util/concurrent/TimeUnit;)Lorg/apache/http/conn/ManagedClientConnection;");
			global::org.apache.http.conn.__ClientConnectionRequest._abortRequest14408 = @__env.GetMethodID(global::org.apache.http.conn.__ClientConnectionRequest.staticClass, "org.apache.http.conn.ClientConnectionRequest.abortRequest", "()V");
		}
	}
}
