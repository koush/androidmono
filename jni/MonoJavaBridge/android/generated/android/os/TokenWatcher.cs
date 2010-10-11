namespace android.os
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.os.TokenWatcher_))]
	public abstract partial class TokenWatcher : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TokenWatcher()
		{
			InitJNI();
		}
		protected TokenWatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _cleanup6733;
		public virtual void cleanup(android.os.IBinder arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.TokenWatcher._cleanup6733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._cleanup6733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _acquire6734;
		public virtual void acquire(android.os.IBinder arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.TokenWatcher._acquire6734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._acquire6734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _release6735;
		public virtual void release(android.os.IBinder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.TokenWatcher._release6735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._release6735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dump6736;
		public virtual void dump() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.TokenWatcher._dump6736);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._dump6736);
		}
		internal static global::MonoJavaBridge.MethodId _acquired6737;
		public abstract void acquired();
		internal static global::MonoJavaBridge.MethodId _released6738;
		public abstract void released();
		internal static global::MonoJavaBridge.MethodId _isAcquired6739;
		public virtual bool isAcquired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.TokenWatcher._isAcquired6739);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._isAcquired6739);
		}
		internal static global::MonoJavaBridge.MethodId _TokenWatcher6740;
		public TokenWatcher(android.os.Handler arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._TokenWatcher6740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.TokenWatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/TokenWatcher"));
			global::android.os.TokenWatcher._cleanup6733 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "cleanup", "(Landroid/os/IBinder;Z)V");
			global::android.os.TokenWatcher._acquire6734 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "acquire", "(Landroid/os/IBinder;Ljava/lang/String;)V");
			global::android.os.TokenWatcher._release6735 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "release", "(Landroid/os/IBinder;)V");
			global::android.os.TokenWatcher._dump6736 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "dump", "()V");
			global::android.os.TokenWatcher._acquired6737 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "acquired", "()V");
			global::android.os.TokenWatcher._released6738 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "released", "()V");
			global::android.os.TokenWatcher._isAcquired6739 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "isAcquired", "()Z");
			global::android.os.TokenWatcher._TokenWatcher6740 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "<init>", "(Landroid/os/Handler;Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.TokenWatcher))]
	public sealed partial class TokenWatcher_ : android.os.TokenWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TokenWatcher_()
		{
			InitJNI();
		}
		internal TokenWatcher_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _acquired6741;
		public override void acquired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.TokenWatcher_._acquired6741);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.TokenWatcher_.staticClass, global::android.os.TokenWatcher_._acquired6741);
		}
		internal static global::MonoJavaBridge.MethodId _released6742;
		public override void released() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.TokenWatcher_._released6742);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.TokenWatcher_.staticClass, global::android.os.TokenWatcher_._released6742);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.TokenWatcher_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/TokenWatcher"));
			global::android.os.TokenWatcher_._acquired6741 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher_.staticClass, "acquired", "()V");
			global::android.os.TokenWatcher_._released6742 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher_.staticClass, "released", "()V");
		}
	}
}
