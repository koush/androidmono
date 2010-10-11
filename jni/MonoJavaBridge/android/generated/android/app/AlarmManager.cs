namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlarmManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AlarmManager()
		{
			InitJNI();
		}
		protected AlarmManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _set381;
		public virtual void set(int arg0, long arg1, android.app.PendingIntent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlarmManager._set381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._set381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTime382;
		public virtual void setTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlarmManager._setTime382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._setTime382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTimeZone383;
		public virtual void setTimeZone(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlarmManager._setTimeZone383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._setTimeZone383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cancel384;
		public virtual void cancel(android.app.PendingIntent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlarmManager._cancel384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._cancel384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRepeating385;
		public virtual void setRepeating(int arg0, long arg1, long arg2, android.app.PendingIntent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlarmManager._setRepeating385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._setRepeating385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setInexactRepeating386;
		public virtual void setInexactRepeating(int arg0, long arg1, long arg2, android.app.PendingIntent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlarmManager._setInexactRepeating386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._setInexactRepeating386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public static int RTC_WAKEUP
		{
			get
			{
				return 0;
			}
		}
		public static int RTC
		{
			get
			{
				return 1;
			}
		}
		public static int ELAPSED_REALTIME_WAKEUP
		{
			get
			{
				return 2;
			}
		}
		public static int ELAPSED_REALTIME
		{
			get
			{
				return 3;
			}
		}
		public static long INTERVAL_FIFTEEN_MINUTES
		{
			get
			{
				return 900000L;
			}
		}
		public static long INTERVAL_HALF_HOUR
		{
			get
			{
				return 1800000L;
			}
		}
		public static long INTERVAL_HOUR
		{
			get
			{
				return 3600000L;
			}
		}
		public static long INTERVAL_HALF_DAY
		{
			get
			{
				return 43200000L;
			}
		}
		public static long INTERVAL_DAY
		{
			get
			{
				return 86400000L;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.AlarmManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/AlarmManager"));
			global::android.app.AlarmManager._set381 = @__env.GetMethodIDNoThrow(global::android.app.AlarmManager.staticClass, "set", "(IJLandroid/app/PendingIntent;)V");
			global::android.app.AlarmManager._setTime382 = @__env.GetMethodIDNoThrow(global::android.app.AlarmManager.staticClass, "setTime", "(J)V");
			global::android.app.AlarmManager._setTimeZone383 = @__env.GetMethodIDNoThrow(global::android.app.AlarmManager.staticClass, "setTimeZone", "(Ljava/lang/String;)V");
			global::android.app.AlarmManager._cancel384 = @__env.GetMethodIDNoThrow(global::android.app.AlarmManager.staticClass, "cancel", "(Landroid/app/PendingIntent;)V");
			global::android.app.AlarmManager._setRepeating385 = @__env.GetMethodIDNoThrow(global::android.app.AlarmManager.staticClass, "setRepeating", "(IJJLandroid/app/PendingIntent;)V");
			global::android.app.AlarmManager._setInexactRepeating386 = @__env.GetMethodIDNoThrow(global::android.app.AlarmManager.staticClass, "setInexactRepeating", "(IJJLandroid/app/PendingIntent;)V");
		}
	}
}
