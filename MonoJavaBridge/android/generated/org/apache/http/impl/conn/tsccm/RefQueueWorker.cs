namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RefQueueWorker : java.lang.Object, java.lang.Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RefQueueWorker(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run33154;
		public virtual void run()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.RefQueueWorker.staticClass, "run", "()V", ref global::org.apache.http.impl.conn.tsccm.RefQueueWorker._run33154);
		}
		internal static global::MonoJavaBridge.MethodId _shutdown33155;
		public virtual void shutdown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.conn.tsccm.RefQueueWorker.staticClass, "shutdown", "()V", ref global::org.apache.http.impl.conn.tsccm.RefQueueWorker._shutdown33155);
		}
		internal static global::MonoJavaBridge.MethodId _toString33156;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.conn.tsccm.RefQueueWorker.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.impl.conn.tsccm.RefQueueWorker._toString33156) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _RefQueueWorker33157;
		public RefQueueWorker(java.lang.@ref.ReferenceQueue arg0, org.apache.http.impl.conn.tsccm.RefQueueHandler arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.conn.tsccm.RefQueueWorker._RefQueueWorker33157.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.conn.tsccm.RefQueueWorker._RefQueueWorker33157 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RefQueueWorker.staticClass, "<init>", "(Ljava/lang/ref/ReferenceQueue;Lorg/apache/http/impl/conn/tsccm/RefQueueHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.RefQueueWorker.staticClass, global::org.apache.http.impl.conn.tsccm.RefQueueWorker._RefQueueWorker33157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static RefQueueWorker()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.RefQueueWorker.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/RefQueueWorker"));
		}
		internal static void InitJNI()
		{
		}
	}
}
