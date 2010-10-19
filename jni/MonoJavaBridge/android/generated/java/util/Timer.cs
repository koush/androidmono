namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Timer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Timer()
		{
			InitJNI();
		}
		protected Timer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _cancel20913;
		public virtual void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Timer._cancel20913);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._cancel20913);
		}
		internal static global::MonoJavaBridge.MethodId _schedule20914;
		public virtual void schedule(java.util.TimerTask arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Timer._schedule20914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._schedule20914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _schedule20915;
		public virtual void schedule(java.util.TimerTask arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Timer._schedule20915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._schedule20915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _schedule20916;
		public virtual void schedule(java.util.TimerTask arg0, java.util.Date arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Timer._schedule20916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._schedule20916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _schedule20917;
		public virtual void schedule(java.util.TimerTask arg0, java.util.Date arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Timer._schedule20917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._schedule20917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleAtFixedRate20918;
		public virtual void scheduleAtFixedRate(java.util.TimerTask arg0, java.util.Date arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Timer._scheduleAtFixedRate20918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._scheduleAtFixedRate20918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleAtFixedRate20919;
		public virtual void scheduleAtFixedRate(java.util.TimerTask arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Timer._scheduleAtFixedRate20919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._scheduleAtFixedRate20919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _purge20920;
		public virtual int purge() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Timer._purge20920);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._purge20920);
		}
		internal static global::MonoJavaBridge.MethodId _Timer20921;
		public Timer(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._Timer20921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Timer20922;
		public Timer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._Timer20922);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Timer20923;
		public Timer(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._Timer20923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Timer20924;
		public Timer(java.lang.String arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._Timer20924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Timer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Timer"));
			global::java.util.Timer._cancel20913 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "cancel", "()V");
			global::java.util.Timer._schedule20914 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;J)V");
			global::java.util.Timer._schedule20915 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;JJ)V");
			global::java.util.Timer._schedule20916 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;Ljava/util/Date;)V");
			global::java.util.Timer._schedule20917 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;Ljava/util/Date;J)V");
			global::java.util.Timer._scheduleAtFixedRate20918 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "scheduleAtFixedRate", "(Ljava/util/TimerTask;Ljava/util/Date;J)V");
			global::java.util.Timer._scheduleAtFixedRate20919 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "scheduleAtFixedRate", "(Ljava/util/TimerTask;JJ)V");
			global::java.util.Timer._purge20920 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "purge", "()I");
			global::java.util.Timer._Timer20921 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.Timer._Timer20922 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "()V");
			global::java.util.Timer._Timer20923 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "(Z)V");
			global::java.util.Timer._Timer20924 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "(Ljava/lang/String;Z)V");
		}
	}
}
