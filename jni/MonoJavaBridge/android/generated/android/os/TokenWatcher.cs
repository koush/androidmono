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
		internal static global::MonoJavaBridge.MethodId _cleanup10214;
		public virtual void cleanup(android.os.IBinder arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.TokenWatcher._cleanup10214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._cleanup10214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _acquire10215;
		public virtual void acquire(android.os.IBinder arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.TokenWatcher._acquire10215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._acquire10215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _release10216;
		public virtual void release(android.os.IBinder arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.TokenWatcher._release10216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._release10216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dump10217;
		public virtual void dump()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.TokenWatcher._dump10217);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._dump10217);
		}
		internal static global::MonoJavaBridge.MethodId _acquired10218;
		public abstract void acquired();
		internal static global::MonoJavaBridge.MethodId _released10219;
		public abstract void released();
		internal static global::MonoJavaBridge.MethodId _isAcquired10220;
		public virtual bool isAcquired()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.TokenWatcher._isAcquired10220);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._isAcquired10220);
		}
		internal static global::MonoJavaBridge.MethodId _TokenWatcher10221;
		public TokenWatcher(android.os.Handler arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._TokenWatcher10221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.TokenWatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/TokenWatcher"));
			global::android.os.TokenWatcher._cleanup10214 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "cleanup", "(Landroid/os/IBinder;Z)V");
			global::android.os.TokenWatcher._acquire10215 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "acquire", "(Landroid/os/IBinder;Ljava/lang/String;)V");
			global::android.os.TokenWatcher._release10216 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "release", "(Landroid/os/IBinder;)V");
			global::android.os.TokenWatcher._dump10217 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "dump", "()V");
			global::android.os.TokenWatcher._acquired10218 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "acquired", "()V");
			global::android.os.TokenWatcher._released10219 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "released", "()V");
			global::android.os.TokenWatcher._isAcquired10220 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "isAcquired", "()Z");
			global::android.os.TokenWatcher._TokenWatcher10221 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "<init>", "(Landroid/os/Handler;Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.TokenWatcher))]
	internal sealed partial class TokenWatcher_ : android.os.TokenWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TokenWatcher_()
		{
			InitJNI();
		}
		internal TokenWatcher_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _acquired10222;
		public override void acquired()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.TokenWatcher_._acquired10222);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.TokenWatcher_.staticClass, global::android.os.TokenWatcher_._acquired10222);
		}
		internal static global::MonoJavaBridge.MethodId _released10223;
		public override void released()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.TokenWatcher_._released10223);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.TokenWatcher_.staticClass, global::android.os.TokenWatcher_._released10223);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.TokenWatcher_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/TokenWatcher"));
			global::android.os.TokenWatcher_._acquired10222 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher_.staticClass, "acquired", "()V");
			global::android.os.TokenWatcher_._released10223 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher_.staticClass, "released", "()V");
		}
	}
}
