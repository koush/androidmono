namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WaitingThreadAborter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WaitingThreadAborter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void abort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass, "abort", "()V", ref global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._m0);
		}
		public new global::org.apache.http.impl.conn.tsccm.WaitingThread WaitingThread
		{
			set
			{
				setWaitingThread(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setWaitingThread(org.apache.http.impl.conn.tsccm.WaitingThread arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass, "setWaitingThread", "(Lorg/apache/http/impl/conn/tsccm/WaitingThread;)V", ref global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public WaitingThreadAborter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._m2 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass, global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._m2);
			Init(@__env, handle);
		}
		static WaitingThreadAborter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/WaitingThreadAborter"));
		}
	}
}
