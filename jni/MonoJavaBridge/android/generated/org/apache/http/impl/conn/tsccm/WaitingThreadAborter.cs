namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WaitingThreadAborter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WaitingThreadAborter()
		{
			InitJNI();
		}
		protected WaitingThreadAborter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _abort26449;
		public virtual void abort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._abort26449);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass, global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._abort26449);
		}
		internal static global::MonoJavaBridge.MethodId _setWaitingThread26450;
		public virtual void setWaitingThread(org.apache.http.impl.conn.tsccm.WaitingThread arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._setWaitingThread26450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass, global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._setWaitingThread26450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _WaitingThreadAborter26451;
		public WaitingThreadAborter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass, global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._WaitingThreadAborter26451);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/WaitingThreadAborter"));
			global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._abort26449 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass, "abort", "()V");
			global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._setWaitingThread26450 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass, "setWaitingThread", "(Lorg/apache/http/impl/conn/tsccm/WaitingThread;)V");
			global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter._WaitingThreadAborter26451 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.WaitingThreadAborter.staticClass, "<init>", "()V");
		}
	}
}
