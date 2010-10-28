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
		internal static global::MonoJavaBridge.MethodId _toString27215;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch._toString27215)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._toString27215)) as java.lang.String;
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
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch._getCount27216);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._getCount27216);
		}
		internal static global::MonoJavaBridge.MethodId _await27217;
		public virtual void await()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch._await27217);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._await27217);
		}
		internal static global::MonoJavaBridge.MethodId _await27218;
		public virtual bool await(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch._await27218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._await27218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _countDown27219;
		public virtual void countDown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch._countDown27219);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._countDown27219);
		}
		internal static global::MonoJavaBridge.MethodId _CountDownLatch27220;
		public CountDownLatch(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CountDownLatch.staticClass, global::java.util.concurrent.CountDownLatch._CountDownLatch27220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CountDownLatch.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CountDownLatch"));
			global::java.util.concurrent.CountDownLatch._toString27215 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.CountDownLatch._getCount27216 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "getCount", "()J");
			global::java.util.concurrent.CountDownLatch._await27217 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "await", "()V");
			global::java.util.concurrent.CountDownLatch._await27218 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "await", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.CountDownLatch._countDown27219 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "countDown", "()V");
			global::java.util.concurrent.CountDownLatch._CountDownLatch27220 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CountDownLatch.staticClass, "<init>", "(I)V");
		}
	}
}
