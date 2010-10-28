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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThread._interrupt33185);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, global::org.apache.http.impl.conn.tsccm.WaitingThread._interrupt33185);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThread._getPool33186)) as org.apache.http.impl.conn.tsccm.RouteSpecificPool;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, global::org.apache.http.impl.conn.tsccm.WaitingThread._getPool33186)) as org.apache.http.impl.conn.tsccm.RouteSpecificPool;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThread._getThread33187)) as java.lang.Thread;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, global::org.apache.http.impl.conn.tsccm.WaitingThread._getThread33187)) as java.lang.Thread;
		}
		internal static global::MonoJavaBridge.MethodId _wakeup33188;
		public virtual void wakeup()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThread._wakeup33188);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, global::org.apache.http.impl.conn.tsccm.WaitingThread._wakeup33188);
		}
		internal static global::MonoJavaBridge.MethodId _await33189;
		public virtual bool await(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThread._await33189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, global::org.apache.http.impl.conn.tsccm.WaitingThread._await33189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThread._getCondition33190)) as java.util.concurrent.locks.Condition;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.locks.Condition>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, global::org.apache.http.impl.conn.tsccm.WaitingThread._getCondition33190)) as java.util.concurrent.locks.Condition;
		}
		internal static global::MonoJavaBridge.MethodId _WaitingThread33191;
		public WaitingThread(java.util.concurrent.locks.Condition arg0, org.apache.http.impl.conn.tsccm.RouteSpecificPool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, global::org.apache.http.impl.conn.tsccm.WaitingThread._WaitingThread33191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static WaitingThread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/WaitingThread"));
			global::org.apache.http.impl.conn.tsccm.WaitingThread._interrupt33185 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, "interrupt", "()V");
			global::org.apache.http.impl.conn.tsccm.WaitingThread._getPool33186 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, "getPool", "()Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;");
			global::org.apache.http.impl.conn.tsccm.WaitingThread._getThread33187 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, "getThread", "()Ljava/lang/Thread;");
			global::org.apache.http.impl.conn.tsccm.WaitingThread._wakeup33188 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, "wakeup", "()V");
			global::org.apache.http.impl.conn.tsccm.WaitingThread._await33189 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, "await", "(Ljava/util/Date;)Z");
			global::org.apache.http.impl.conn.tsccm.WaitingThread._getCondition33190 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, "getCondition", "()Ljava/util/concurrent/locks/Condition;");
			global::org.apache.http.impl.conn.tsccm.WaitingThread._WaitingThread33191 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.WaitingThread.staticClass, "<init>", "(Ljava/util/concurrent/locks/Condition;Lorg/apache/http/impl/conn/tsccm/RouteSpecificPool;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
