namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Timer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Timer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _cancel26862;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._cancel26862.native == global::System.IntPtr.Zero)
				global::java.util.Timer._cancel26862 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "cancel", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Timer.staticClass, global::java.util.Timer._cancel26862);
		}
		internal static global::MonoJavaBridge.MethodId _schedule26863;
		public virtual void schedule(java.util.TimerTask arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._schedule26863.native == global::System.IntPtr.Zero)
				global::java.util.Timer._schedule26863 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;J)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Timer.staticClass, global::java.util.Timer._schedule26863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _schedule26864;
		public virtual void schedule(java.util.TimerTask arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._schedule26864.native == global::System.IntPtr.Zero)
				global::java.util.Timer._schedule26864 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;JJ)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Timer.staticClass, global::java.util.Timer._schedule26864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _schedule26865;
		public virtual void schedule(java.util.TimerTask arg0, java.util.Date arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._schedule26865.native == global::System.IntPtr.Zero)
				global::java.util.Timer._schedule26865 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;Ljava/util/Date;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Timer.staticClass, global::java.util.Timer._schedule26865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _schedule26866;
		public virtual void schedule(java.util.TimerTask arg0, java.util.Date arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._schedule26866.native == global::System.IntPtr.Zero)
				global::java.util.Timer._schedule26866 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;Ljava/util/Date;J)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Timer.staticClass, global::java.util.Timer._schedule26866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleAtFixedRate26867;
		public virtual void scheduleAtFixedRate(java.util.TimerTask arg0, java.util.Date arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._scheduleAtFixedRate26867.native == global::System.IntPtr.Zero)
				global::java.util.Timer._scheduleAtFixedRate26867 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "scheduleAtFixedRate", "(Ljava/util/TimerTask;Ljava/util/Date;J)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Timer.staticClass, global::java.util.Timer._scheduleAtFixedRate26867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleAtFixedRate26868;
		public virtual void scheduleAtFixedRate(java.util.TimerTask arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._scheduleAtFixedRate26868.native == global::System.IntPtr.Zero)
				global::java.util.Timer._scheduleAtFixedRate26868 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "scheduleAtFixedRate", "(Ljava/util/TimerTask;JJ)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Timer.staticClass, global::java.util.Timer._scheduleAtFixedRate26868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _purge26869;
		public virtual int purge()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._purge26869.native == global::System.IntPtr.Zero)
				global::java.util.Timer._purge26869 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "purge", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Timer.staticClass, global::java.util.Timer._purge26869);
		}
		internal static global::MonoJavaBridge.MethodId _Timer26870;
		public Timer(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._Timer26870.native == global::System.IntPtr.Zero)
				global::java.util.Timer._Timer26870 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._Timer26870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Timer26871;
		public Timer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._Timer26871.native == global::System.IntPtr.Zero)
				global::java.util.Timer._Timer26871 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._Timer26871);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Timer26872;
		public Timer(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._Timer26872.native == global::System.IntPtr.Zero)
				global::java.util.Timer._Timer26872 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._Timer26872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Timer26873;
		public Timer(java.lang.String arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Timer._Timer26873.native == global::System.IntPtr.Zero)
				global::java.util.Timer._Timer26873 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._Timer26873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Timer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Timer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Timer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
