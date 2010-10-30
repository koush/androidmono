namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlarmManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlarmManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void set(int arg0, long arg1, android.app.PendingIntent arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlarmManager.staticClass, "set", "(IJLandroid/app/PendingIntent;)V", ref global::android.app.AlarmManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new long Time
		{
			set
			{
				setTime(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setTime(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlarmManager.staticClass, "setTime", "(J)V", ref global::android.app.AlarmManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String TimeZone
		{
			set
			{
				setTimeZone(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setTimeZone(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlarmManager.staticClass, "setTimeZone", "(Ljava/lang/String;)V", ref global::android.app.AlarmManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void cancel(android.app.PendingIntent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlarmManager.staticClass, "cancel", "(Landroid/app/PendingIntent;)V", ref global::android.app.AlarmManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setRepeating(int arg0, long arg1, long arg2, android.app.PendingIntent arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlarmManager.staticClass, "setRepeating", "(IJJLandroid/app/PendingIntent;)V", ref global::android.app.AlarmManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setInexactRepeating(int arg0, long arg1, long arg2, android.app.PendingIntent arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlarmManager.staticClass, "setInexactRepeating", "(IJJLandroid/app/PendingIntent;)V", ref global::android.app.AlarmManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
		static AlarmManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.AlarmManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/AlarmManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
