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
		internal static global::MonoJavaBridge.MethodId _set1656;
		public virtual void set(int arg0, long arg1, android.app.PendingIntent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlarmManager._set1656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._set1656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTime1657;
		public virtual void setTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlarmManager._setTime1657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._setTime1657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTimeZone1658;
		public virtual void setTimeZone(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlarmManager._setTimeZone1658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._setTimeZone1658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cancel1659;
		public virtual void cancel(android.app.PendingIntent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlarmManager._cancel1659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._cancel1659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRepeating1660;
		public virtual void setRepeating(int arg0, long arg1, long arg2, android.app.PendingIntent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlarmManager._setRepeating1660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._setRepeating1660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setInexactRepeating1661;
		public virtual void setInexactRepeating(int arg0, long arg1, long arg2, android.app.PendingIntent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlarmManager._setInexactRepeating1661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._setInexactRepeating1661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
			global::android.app.AlarmManager._set1656 = @__env.GetMethodIDNoThrow(global::android.app.AlarmManager.staticClass, "set", "(IJLandroid/app/PendingIntent;)V");
			global::android.app.AlarmManager._setTime1657 = @__env.GetMethodIDNoThrow(global::android.app.AlarmManager.staticClass, "setTime", "(J)V");
			global::android.app.AlarmManager._setTimeZone1658 = @__env.GetMethodIDNoThrow(global::android.app.AlarmManager.staticClass, "setTimeZone", "(Ljava/lang/String;)V");
			global::android.app.AlarmManager._cancel1659 = @__env.GetMethodIDNoThrow(global::android.app.AlarmManager.staticClass, "cancel", "(Landroid/app/PendingIntent;)V");
			global::android.app.AlarmManager._setRepeating1660 = @__env.GetMethodIDNoThrow(global::android.app.AlarmManager.staticClass, "setRepeating", "(IJJLandroid/app/PendingIntent;)V");
			global::android.app.AlarmManager._setInexactRepeating1661 = @__env.GetMethodIDNoThrow(global::android.app.AlarmManager.staticClass, "setInexactRepeating", "(IJJLandroid/app/PendingIntent;)V");
		}
	}
}
