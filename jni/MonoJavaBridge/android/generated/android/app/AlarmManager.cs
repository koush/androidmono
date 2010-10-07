namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AlarmManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static AlarmManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.AlarmManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.AlarmManager(@__env);
			}
		}
		protected AlarmManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _set372;
		public virtual void set(int arg0, long arg1, android.app.PendingIntent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlarmManager._set372, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._set372, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTime373;
		public virtual void setTime(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlarmManager._setTime373, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._setTime373, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTimeZone374;
		public virtual void setTimeZone(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlarmManager._setTimeZone374, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._setTimeZone374, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancel375;
		public virtual void cancel(android.app.PendingIntent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlarmManager._cancel375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._cancel375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRepeating376;
		public virtual void setRepeating(int arg0, long arg1, long arg2, android.app.PendingIntent arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlarmManager._setRepeating376, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._setRepeating376, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInexactRepeating377;
		public virtual void setInexactRepeating(int arg0, long arg1, long arg2, android.app.PendingIntent arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlarmManager._setInexactRepeating377, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlarmManager.staticClass, global::android.app.AlarmManager._setInexactRepeating377, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.AlarmManager.staticClass = @__class;
			global::android.app.AlarmManager._set372 = @__env.GetMethodID(global::android.app.AlarmManager.staticClass, "set", "(IJLandroid/app/PendingIntent;)V");
			global::android.app.AlarmManager._setTime373 = @__env.GetMethodID(global::android.app.AlarmManager.staticClass, "setTime", "(J)V");
			global::android.app.AlarmManager._setTimeZone374 = @__env.GetMethodID(global::android.app.AlarmManager.staticClass, "setTimeZone", "(Ljava/lang/String;)V");
			global::android.app.AlarmManager._cancel375 = @__env.GetMethodID(global::android.app.AlarmManager.staticClass, "cancel", "(Landroid/app/PendingIntent;)V");
			global::android.app.AlarmManager._setRepeating376 = @__env.GetMethodID(global::android.app.AlarmManager.staticClass, "setRepeating", "(IJJLandroid/app/PendingIntent;)V");
			global::android.app.AlarmManager._setInexactRepeating377 = @__env.GetMethodID(global::android.app.AlarmManager.staticClass, "setInexactRepeating", "(IJJLandroid/app/PendingIntent;)V");
		}
	}
}
