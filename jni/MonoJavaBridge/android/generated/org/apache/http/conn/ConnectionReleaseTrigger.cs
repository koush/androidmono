namespace org.apache.http.conn
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface ConnectionReleaseTrigger 
	{
		void releaseConnection();
		void abortConnection();
	}

	public partial class ConnectionReleaseTrigger_
	{
		public static global::java.lang.Class _class
		{
			get { return __ConnectionReleaseTrigger.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __ConnectionReleaseTrigger : java.lang.Object, ConnectionReleaseTrigger
	{
		internal static global::java.lang.Class staticClass;
		static __ConnectionReleaseTrigger()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.conn.__ConnectionReleaseTrigger), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.conn.__ConnectionReleaseTrigger(@__env);
			}
		}
		internal __ConnectionReleaseTrigger(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _releaseConnection14409;
		 void org.apache.http.conn.ConnectionReleaseTrigger.releaseConnection() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ConnectionReleaseTrigger._releaseConnection14409);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ConnectionReleaseTrigger.staticClass, global::org.apache.http.conn.__ConnectionReleaseTrigger._releaseConnection14409);
		}
		internal static global::net.sf.jni4net.jni.MethodId _abortConnection14410;
		 void org.apache.http.conn.ConnectionReleaseTrigger.abortConnection() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::org.apache.http.conn.__ConnectionReleaseTrigger._abortConnection14410);
			else
				@__env.CallNonVirtualVoidMethod(this, global::org.apache.http.conn.__ConnectionReleaseTrigger.staticClass, global::org.apache.http.conn.__ConnectionReleaseTrigger._abortConnection14410);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.conn.__ConnectionReleaseTrigger.staticClass = @__class;
			global::org.apache.http.conn.__ConnectionReleaseTrigger._releaseConnection14409 = @__env.GetMethodID(global::org.apache.http.conn.__ConnectionReleaseTrigger.staticClass, "org.apache.http.conn.ConnectionReleaseTrigger.releaseConnection", "()V");
			global::org.apache.http.conn.__ConnectionReleaseTrigger._abortConnection14410 = @__env.GetMethodID(global::org.apache.http.conn.__ConnectionReleaseTrigger.staticClass, "org.apache.http.conn.ConnectionReleaseTrigger.abortConnection", "()V");
		}
	}
}
