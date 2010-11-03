namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Timer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Timer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Timer.staticClass, "cancel", "()V", ref global::java.util.Timer._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void schedule(java.util.TimerTask arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;J)V", ref global::java.util.Timer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void schedule(java.util.TimerTask arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;JJ)V", ref global::java.util.Timer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void schedule(java.util.TimerTask arg0, java.util.Date arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;Ljava/util/Date;)V", ref global::java.util.Timer._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void schedule(java.util.TimerTask arg0, java.util.Date arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;Ljava/util/Date;J)V", ref global::java.util.Timer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void scheduleAtFixedRate(java.util.TimerTask arg0, java.util.Date arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Timer.staticClass, "scheduleAtFixedRate", "(Ljava/util/TimerTask;Ljava/util/Date;J)V", ref global::java.util.Timer._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void scheduleAtFixedRate(java.util.TimerTask arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Timer.staticClass, "scheduleAtFixedRate", "(Ljava/util/TimerTask;JJ)V", ref global::java.util.Timer._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int purge()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Timer.staticClass, "purge", "()I", ref global::java.util.Timer._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public Timer(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._m8.native == global::System.IntPtr.Zero)
				global::java.util.Timer._m8 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public Timer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._m9.native == global::System.IntPtr.Zero)
				global::java.util.Timer._m9 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._m9);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public Timer(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._m10.native == global::System.IntPtr.Zero)
				global::java.util.Timer._m10 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public Timer(java.lang.String arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._m11.native == global::System.IntPtr.Zero)
				global::java.util.Timer._m11 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Timer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Timer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Timer"));
		}
	}
}
