namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CountDownLatch : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CountDownLatch(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString27215;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CountDownLatch._toString27215.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CountDownLatch._toString27215 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._toString27215) as java.lang.String;
		}
		public new long Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount27216;
		public virtual long getCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CountDownLatch._getCount27216.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CountDownLatch._getCount27216 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "getCount", "()J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._getCount27216);
		}
		internal static global::MonoJavaBridge.MethodId _await27217;
		public virtual void await()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CountDownLatch._await27217.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CountDownLatch._await27217 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "await", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._await27217);
		}
		internal static global::MonoJavaBridge.MethodId _await27218;
		public virtual bool await(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CountDownLatch._await27218.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CountDownLatch._await27218 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "await", "(JLjava/util/concurrent/TimeUnit;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._await27218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _countDown27219;
		public virtual void countDown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CountDownLatch._countDown27219.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CountDownLatch._countDown27219 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "countDown", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._countDown27219);
		}
		internal static global::MonoJavaBridge.MethodId _CountDownLatch27220;
		public CountDownLatch(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.CountDownLatch._CountDownLatch27220.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.CountDownLatch._CountDownLatch27220 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._CountDownLatch27220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CountDownLatch()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CountDownLatch.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CountDownLatch"));
		}
		internal static void InitJNI()
		{
		}
	}
}
