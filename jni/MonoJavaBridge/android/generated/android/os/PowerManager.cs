namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PowerManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PowerManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class WakeLock : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected WakeLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _finalize10129;
			protected override void finalize()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.os.PowerManager.WakeLock._finalize10129);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.PowerManager.WakeLock.staticClass, global::android.os.PowerManager.WakeLock._finalize10129);
			}
			internal static global::MonoJavaBridge.MethodId _toString10130;
			public override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.PowerManager.WakeLock._toString10130)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.PowerManager.WakeLock.staticClass, global::android.os.PowerManager.WakeLock._toString10130)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _acquire10131;
			public virtual void acquire()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.os.PowerManager.WakeLock._acquire10131);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.PowerManager.WakeLock.staticClass, global::android.os.PowerManager.WakeLock._acquire10131);
			}
			internal static global::MonoJavaBridge.MethodId _acquire10132;
			public virtual void acquire(long arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.os.PowerManager.WakeLock._acquire10132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.PowerManager.WakeLock.staticClass, global::android.os.PowerManager.WakeLock._acquire10132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _release10133;
			public virtual void release()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.os.PowerManager.WakeLock._release10133);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.PowerManager.WakeLock.staticClass, global::android.os.PowerManager.WakeLock._release10133);
			}
			public new bool ReferenceCounted
			{
				set
				{
					setReferenceCounted(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setReferenceCounted10134;
			public virtual void setReferenceCounted(bool arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.os.PowerManager.WakeLock._setReferenceCounted10134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.PowerManager.WakeLock.staticClass, global::android.os.PowerManager.WakeLock._setReferenceCounted10134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isHeld10135;
			public virtual bool isHeld()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.PowerManager.WakeLock._isHeld10135);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.PowerManager.WakeLock.staticClass, global::android.os.PowerManager.WakeLock._isHeld10135);
			}
			static WakeLock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.PowerManager.WakeLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/PowerManager$WakeLock"));
				global::android.os.PowerManager.WakeLock._finalize10129 = @__env.GetMethodIDNoThrow(global::android.os.PowerManager.WakeLock.staticClass, "finalize", "()V");
				global::android.os.PowerManager.WakeLock._toString10130 = @__env.GetMethodIDNoThrow(global::android.os.PowerManager.WakeLock.staticClass, "toString", "()Ljava/lang/String;");
				global::android.os.PowerManager.WakeLock._acquire10131 = @__env.GetMethodIDNoThrow(global::android.os.PowerManager.WakeLock.staticClass, "acquire", "()V");
				global::android.os.PowerManager.WakeLock._acquire10132 = @__env.GetMethodIDNoThrow(global::android.os.PowerManager.WakeLock.staticClass, "acquire", "(J)V");
				global::android.os.PowerManager.WakeLock._release10133 = @__env.GetMethodIDNoThrow(global::android.os.PowerManager.WakeLock.staticClass, "release", "()V");
				global::android.os.PowerManager.WakeLock._setReferenceCounted10134 = @__env.GetMethodIDNoThrow(global::android.os.PowerManager.WakeLock.staticClass, "setReferenceCounted", "(Z)V");
				global::android.os.PowerManager.WakeLock._isHeld10135 = @__env.GetMethodIDNoThrow(global::android.os.PowerManager.WakeLock.staticClass, "isHeld", "()Z");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _newWakeLock10136;
		public virtual global::android.os.PowerManager.WakeLock newWakeLock(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.PowerManager._newWakeLock10136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.PowerManager.WakeLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.PowerManager.staticClass, global::android.os.PowerManager._newWakeLock10136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.PowerManager.WakeLock;
		}
		internal static global::MonoJavaBridge.MethodId _userActivity10137;
		public virtual void userActivity(long arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.PowerManager._userActivity10137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.PowerManager.staticClass, global::android.os.PowerManager._userActivity10137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _goToSleep10138;
		public virtual void goToSleep(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.PowerManager._goToSleep10138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.PowerManager.staticClass, global::android.os.PowerManager._goToSleep10138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isScreenOn10139;
		public virtual bool isScreenOn()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.PowerManager._isScreenOn10139);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.PowerManager.staticClass, global::android.os.PowerManager._isScreenOn10139);
		}
		internal static global::MonoJavaBridge.MethodId _reboot10140;
		public virtual void reboot(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.PowerManager._reboot10140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.PowerManager.staticClass, global::android.os.PowerManager._reboot10140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int PARTIAL_WAKE_LOCK
		{
			get
			{
				return 1;
			}
		}
		public static int FULL_WAKE_LOCK
		{
			get
			{
				return 26;
			}
		}
		public static int SCREEN_BRIGHT_WAKE_LOCK
		{
			get
			{
				return 10;
			}
		}
		public static int SCREEN_DIM_WAKE_LOCK
		{
			get
			{
				return 6;
			}
		}
		public static int ACQUIRE_CAUSES_WAKEUP
		{
			get
			{
				return 268435456;
			}
		}
		public static int ON_AFTER_RELEASE
		{
			get
			{
				return 536870912;
			}
		}
		static PowerManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.PowerManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/PowerManager"));
			global::android.os.PowerManager._newWakeLock10136 = @__env.GetMethodIDNoThrow(global::android.os.PowerManager.staticClass, "newWakeLock", "(ILjava/lang/String;)Landroid/os/PowerManager$WakeLock;");
			global::android.os.PowerManager._userActivity10137 = @__env.GetMethodIDNoThrow(global::android.os.PowerManager.staticClass, "userActivity", "(JZ)V");
			global::android.os.PowerManager._goToSleep10138 = @__env.GetMethodIDNoThrow(global::android.os.PowerManager.staticClass, "goToSleep", "(J)V");
			global::android.os.PowerManager._isScreenOn10139 = @__env.GetMethodIDNoThrow(global::android.os.PowerManager.staticClass, "isScreenOn", "()Z");
			global::android.os.PowerManager._reboot10140 = @__env.GetMethodIDNoThrow(global::android.os.PowerManager.staticClass, "reboot", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
