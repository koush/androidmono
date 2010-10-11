namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Notification : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Notification()
		{
			InitJNI();
		}
		protected Notification(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString678;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Notification._toString678)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Notification.staticClass, global::android.app.Notification._toString678)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel679;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Notification._writeToParcel679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Notification.staticClass, global::android.app.Notification._writeToParcel679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents680;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Notification._describeContents680);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Notification.staticClass, global::android.app.Notification._describeContents680);
		}
		internal static global::MonoJavaBridge.MethodId _setLatestEventInfo681;
		public virtual void setLatestEventInfo(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, android.app.PendingIntent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Notification._setLatestEventInfo681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Notification.staticClass, global::android.app.Notification._setLatestEventInfo681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void setLatestEventInfo(android.content.Context arg0, string arg1, string arg2, android.app.PendingIntent arg3)
		{
			setLatestEventInfo(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _Notification682;
		public Notification()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Notification.staticClass, global::android.app.Notification._Notification682);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Notification683;
		public Notification(int arg0, java.lang.CharSequence arg1, long arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Notification.staticClass, global::android.app.Notification._Notification683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Notification684;
		public Notification(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Notification.staticClass, global::android.app.Notification._Notification684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int DEFAULT_ALL
		{
			get
			{
				return -1;
			}
		}
		public static int DEFAULT_SOUND
		{
			get
			{
				return 1;
			}
		}
		public static int DEFAULT_VIBRATE
		{
			get
			{
				return 2;
			}
		}
		public static int DEFAULT_LIGHTS
		{
			get
			{
				return 4;
			}
		}
		internal static global::MonoJavaBridge.FieldId _when685;
		public long when
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _icon686;
		public int icon
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _number687;
		public int number
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _contentIntent688;
		public global::android.app.PendingIntent contentIntent
		{
			get
			{
				return default(global::android.app.PendingIntent);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _deleteIntent689;
		public global::android.app.PendingIntent deleteIntent
		{
			get
			{
				return default(global::android.app.PendingIntent);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _tickerText690;
		public global::java.lang.CharSequence tickerText
		{
			get
			{
				return default(global::java.lang.CharSequence);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _contentView691;
		public global::android.widget.RemoteViews contentView
		{
			get
			{
				return default(global::android.widget.RemoteViews);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _iconLevel692;
		public int iconLevel
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sound693;
		public global::android.net.Uri sound
		{
			get
			{
				return default(global::android.net.Uri);
			}
			set
			{
			}
		}
		public static int STREAM_DEFAULT
		{
			get
			{
				return -1;
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioStreamType694;
		public int audioStreamType
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _vibrate695;
		public long[] vibrate
		{
			get
			{
				return default(long[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ledARGB696;
		public int ledARGB
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ledOnMS697;
		public int ledOnMS
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ledOffMS698;
		public int ledOffMS
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _defaults699;
		public int defaults
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int FLAG_SHOW_LIGHTS
		{
			get
			{
				return 1;
			}
		}
		public static int FLAG_ONGOING_EVENT
		{
			get
			{
				return 2;
			}
		}
		public static int FLAG_INSISTENT
		{
			get
			{
				return 4;
			}
		}
		public static int FLAG_ONLY_ALERT_ONCE
		{
			get
			{
				return 8;
			}
		}
		public static int FLAG_AUTO_CANCEL
		{
			get
			{
				return 16;
			}
		}
		public static int FLAG_NO_CLEAR
		{
			get
			{
				return 32;
			}
		}
		public static int FLAG_FOREGROUND_SERVICE
		{
			get
			{
				return 64;
			}
		}
		internal static global::MonoJavaBridge.FieldId _flags700;
		public int flags
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR701;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Notification.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Notification"));
			global::android.app.Notification._toString678 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "toString", "()Ljava/lang/String;");
			global::android.app.Notification._writeToParcel679 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.app.Notification._describeContents680 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "describeContents", "()I");
			global::android.app.Notification._setLatestEventInfo681 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "setLatestEventInfo", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/app/PendingIntent;)V");
			global::android.app.Notification._Notification682 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "<init>", "()V");
			global::android.app.Notification._Notification683 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "<init>", "(ILjava/lang/CharSequence;J)V");
			global::android.app.Notification._Notification684 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
