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
		internal static global::MonoJavaBridge.MethodId _cancel26861;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Timer._cancel26861);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._cancel26861);
		}
		internal static global::MonoJavaBridge.MethodId _schedule26862;
		public virtual void schedule(java.util.TimerTask arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Timer._schedule26862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._schedule26862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _schedule26863;
		public virtual void schedule(java.util.TimerTask arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Timer._schedule26863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._schedule26863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _schedule26864;
		public virtual void schedule(java.util.TimerTask arg0, java.util.Date arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Timer._schedule26864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._schedule26864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _schedule26865;
		public virtual void schedule(java.util.TimerTask arg0, java.util.Date arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Timer._schedule26865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._schedule26865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleAtFixedRate26866;
		public virtual void scheduleAtFixedRate(java.util.TimerTask arg0, java.util.Date arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Timer._scheduleAtFixedRate26866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._scheduleAtFixedRate26866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleAtFixedRate26867;
		public virtual void scheduleAtFixedRate(java.util.TimerTask arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Timer._scheduleAtFixedRate26867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._scheduleAtFixedRate26867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _purge26868;
		public virtual int purge()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Timer._purge26868);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Timer.staticClass, global::java.util.Timer._purge26868);
		}
		internal static global::MonoJavaBridge.MethodId _Timer26869;
		public Timer(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._Timer26869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Timer26870;
		public Timer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._Timer26870);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Timer26871;
		public Timer(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._Timer26871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Timer26872;
		public Timer(java.lang.String arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Timer.staticClass, global::java.util.Timer._Timer26872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Timer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Timer"));
			global::java.util.Timer._cancel26861 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "cancel", "()V");
			global::java.util.Timer._schedule26862 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;J)V");
			global::java.util.Timer._schedule26863 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;JJ)V");
			global::java.util.Timer._schedule26864 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;Ljava/util/Date;)V");
			global::java.util.Timer._schedule26865 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "schedule", "(Ljava/util/TimerTask;Ljava/util/Date;J)V");
			global::java.util.Timer._scheduleAtFixedRate26866 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "scheduleAtFixedRate", "(Ljava/util/TimerTask;Ljava/util/Date;J)V");
			global::java.util.Timer._scheduleAtFixedRate26867 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "scheduleAtFixedRate", "(Ljava/util/TimerTask;JJ)V");
			global::java.util.Timer._purge26868 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "purge", "()I");
			global::java.util.Timer._Timer26869 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.Timer._Timer26870 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "()V");
			global::java.util.Timer._Timer26871 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "(Z)V");
			global::java.util.Timer._Timer26872 = @__env.GetMethodIDNoThrow(global::java.util.Timer.staticClass, "<init>", "(Ljava/lang/String;Z)V");
		}
	}
}
