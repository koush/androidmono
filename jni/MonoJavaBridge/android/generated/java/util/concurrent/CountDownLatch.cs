namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CountDownLatch : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CountDownLatch()
		{
			InitJNI();
		}
		protected CountDownLatch(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString21266;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch._toString21266)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._toString21266)) as java.lang.String;
		}
		public new long Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount21267;
		public virtual long getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch._getCount21267);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._getCount21267);
		}
		internal static global::MonoJavaBridge.MethodId _await21268;
		public virtual void await() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch._await21268);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._await21268);
		}
		internal static global::MonoJavaBridge.MethodId _await21269;
		public virtual bool await(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch._await21269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._await21269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _countDown21270;
		public virtual void countDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch._countDown21270);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._countDown21270);
		}
		internal static global::MonoJavaBridge.MethodId _CountDownLatch21271;
		public CountDownLatch(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._CountDownLatch21271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CountDownLatch.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CountDownLatch"));
			global::java.util.concurrent.CountDownLatch._toString21266 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.CountDownLatch._getCount21267 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "getCount", "()J");
			global::java.util.concurrent.CountDownLatch._await21268 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "await", "()V");
			global::java.util.concurrent.CountDownLatch._await21269 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "await", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.CountDownLatch._countDown21270 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "countDown", "()V");
			global::java.util.concurrent.CountDownLatch._CountDownLatch21271 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "<init>", "(I)V");
		}
	}
}
