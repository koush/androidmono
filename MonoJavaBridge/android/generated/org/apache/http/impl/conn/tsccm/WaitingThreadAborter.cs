namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WaitingThreadAborter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WaitingThreadAborter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _abort33192;
		public virtual void abort()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass, "abort", "()V", ref global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._abort33192);
		}
		public new global::org.apache.http.impl.conn.tsccm.WaitingThread WaitingThread
		{
			set
			{
				setWaitingThread(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setWaitingThread33193;
		public virtual void setWaitingThread(org.apache.http.impl.conn.tsccm.WaitingThread arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass, "setWaitingThread", "(Lorg/apache/http/impl/conn/tsccm/WaitingThread;)V", ref global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._setWaitingThread33193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _WaitingThreadAborter33194;
		public WaitingThreadAborter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._WaitingThreadAborter33194.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._WaitingThreadAborter33194 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass, global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._WaitingThreadAborter33194);
			Init(@__env, handle);
		}
		static WaitingThreadAborter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/WaitingThreadAborter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
