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
		internal static global::MonoJavaBridge.MethodId _toString27096;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch._toString27096)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._toString27096)) as java.lang.String;
		}
		public new long Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount27097;
		public virtual long getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch._getCount27097);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._getCount27097);
		}
		internal static global::MonoJavaBridge.MethodId _await27098;
		public virtual void await() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch._await27098);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._await27098);
		}
		internal static global::MonoJavaBridge.MethodId _await27099;
		public virtual bool await(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch._await27099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._await27099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _countDown27100;
		public virtual void countDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch._countDown27100);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._countDown27100);
		}
		internal static global::MonoJavaBridge.MethodId _CountDownLatch27101;
		public CountDownLatch(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._CountDownLatch27101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CountDownLatch.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CountDownLatch"));
			global::java.util.concurrent.CountDownLatch._toString27096 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.CountDownLatch._getCount27097 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "getCount", "()J");
			global::java.util.concurrent.CountDownLatch._await27098 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "await", "()V");
			global::java.util.concurrent.CountDownLatch._await27099 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "await", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.CountDownLatch._countDown27100 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "countDown", "()V");
			global::java.util.concurrent.CountDownLatch._CountDownLatch27101 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "<init>", "(I)V");
		}
	}
}
