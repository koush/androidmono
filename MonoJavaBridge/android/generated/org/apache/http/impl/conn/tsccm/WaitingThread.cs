namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WaitingThread : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WaitingThread(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _interrupt33185;
		public virtual void interrupt()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, "interrupt", "()V", ref global::org.apache.http.impl.conn.tsccm.WaitingThread._interrupt33185);
		}
		public new global::org.apache.http.impl.conn.tsccm.RouteSpecificPool Pool
		{
			get
			{
				return getPool();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPool33186;
		public virtual global::org.apache.http.impl.conn.tsccm.RouteSpecificPool getPool()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, "getPool", "()Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;", ref global::org.apache.http.impl.conn.tsccm.WaitingThread._getPool33186) as org.apache.http.impl.conn.tsccm.RouteSpecificPool;
		}
		public new global::java.lang.Thread Thread
		{
			get
			{
				return getThread();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThread33187;
		public virtual global::java.lang.Thread getThread()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, "getThread", "()Ljava/lang/Thread;", ref global::org.apache.http.impl.conn.tsccm.WaitingThread._getThread33187) as java.lang.Thread;
		}
		internal static global::MonoJavaBridge.MethodId _wakeup33188;
		public virtual void wakeup()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, "wakeup", "()V", ref global::org.apache.http.impl.conn.tsccm.WaitingThread._wakeup33188);
		}
		internal static global::MonoJavaBridge.MethodId _await33189;
		public virtual bool await(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, "await", "(Ljava/util/Date;)Z", ref global::org.apache.http.impl.conn.tsccm.WaitingThread._await33189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.concurrent.locks.Condition Condition
		{
			get
			{
				return getCondition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCondition33190;
		public virtual global::java.util.concurrent.locks.Condition getCondition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.locks.Condition>(this, global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, "getCondition", "()Ljava/util/concurrent/locks/Condition;", ref global::org.apache.http.impl.conn.tsccm.WaitingThread._getCondition33190) as java.util.concurrent.locks.Condition;
		}
		internal static global::MonoJavaBridge.MethodId _WaitingThread33191;
		public WaitingThread(java.util.concurrent.locks.Condition arg0, org.apache.http.impl.conn.tsccm.RouteSpecificPool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.WaitingThread._WaitingThread33191.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.WaitingThread._WaitingThread33191 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, "<init>", "(Ljava/util/concurrent/locks/Condition;Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, global::org.apache.http.impl.conn.tsccm.WaitingThread._WaitingThread33191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static WaitingThread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/WaitingThread"));
		}
		internal static void InitJNI()
		{
		}
	}
}
