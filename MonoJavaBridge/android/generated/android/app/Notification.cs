namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Notification : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Notification(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.Notification.staticClass, "toString", "()Ljava/lang/String;", ref global::android.app.Notification._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Notification.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.app.Notification._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Notification.staticClass, "describeContents", "()I", ref global::android.app.Notification._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setLatestEventInfo(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, android.app.PendingIntent arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Notification.staticClass, "setLatestEventInfo", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/app/PendingIntent;)V", ref global::android.app.Notification._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void setLatestEventInfo(android.content.Context arg0, string arg1, string arg2, android.app.PendingIntent arg3)
		{
			setLatestEventInfo(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public Notification() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Notification._m4.native == global::System.IntPtr.Zero)
				global::android.app.Notification._m4 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Notification.staticClass, global::android.app.Notification._m4);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public Notification(int arg0, java.lang.CharSequence arg1, long arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Notification._m5.native == global::System.IntPtr.Zero)
				global::android.app.Notification._m5 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "<init>", "(ILjava/lang/CharSequence;J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Notification.staticClass, global::android.app.Notification._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public Notification(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Notification._m6.native == global::System.IntPtr.Zero)
				global::android.app.Notification._m6 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Notification.staticClass, global::android.app.Notification._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _when1364;
		public long when
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _when1364);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _icon1365;
		public int icon
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _icon1365);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _number1366;
		public int number
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _number1366);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _contentIntent1367;
		public global::android.app.PendingIntent contentIntent
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.GetObjectField(this.JvmHandle, _contentIntent1367)) as android.app.PendingIntent;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _deleteIntent1368;
		public global::android.app.PendingIntent deleteIntent
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.GetObjectField(this.JvmHandle, _deleteIntent1368)) as android.app.PendingIntent;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _tickerText1369;
		public global::java.lang.CharSequence tickerText
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _tickerText1369)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _contentView1370;
		public global::android.widget.RemoteViews contentView
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _contentView1370)) as android.widget.RemoteViews;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _iconLevel1371;
		public int iconLevel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _iconLevel1371);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sound1372;
		public global::android.net.Uri sound
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _sound1372)) as android.net.Uri;
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
		internal static global::MonoJavaBridge.FieldId _audioStreamType1374;
		public int audioStreamType
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _audioStreamType1374);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _vibrate1375;
		public long[] vibrate
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.GetObjectField(this.JvmHandle, _vibrate1375)) as long[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ledARGB1376;
		public int ledARGB
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _ledARGB1376);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ledOnMS1377;
		public int ledOnMS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _ledOnMS1377);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ledOffMS1378;
		public int ledOffMS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _ledOffMS1378);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _defaults1379;
		public int defaults
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _defaults1379);
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
		internal static global::MonoJavaBridge.FieldId _flags1387;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags1387);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1388;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.Notification.staticClass, _CREATOR1388)) as android.os.Parcelable_Creator;
			}
		}
		static Notification()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Notification.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Notification"));
			global::android.app.Notification._when1364 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "when", "J");
			global::android.app.Notification._icon1365 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "icon", "I");
			global::android.app.Notification._number1366 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "number", "I");
			global::android.app.Notification._contentIntent1367 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "contentIntent", "Landroid/app/PendingIntent;");
			global::android.app.Notification._deleteIntent1368 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "deleteIntent", "Landroid/app/PendingIntent;");
			global::android.app.Notification._tickerText1369 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "tickerText", "Ljava/lang/CharSequence;");
			global::android.app.Notification._contentView1370 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "contentView", "Landroid/widget/RemoteViews;");
			global::android.app.Notification._iconLevel1371 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "iconLevel", "I");
			global::android.app.Notification._sound1372 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "sound", "Landroid/net/Uri;");
			global::android.app.Notification._audioStreamType1374 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "audioStreamType", "I");
			global::android.app.Notification._vibrate1375 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "vibrate", "[J");
			global::android.app.Notification._ledARGB1376 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "ledARGB", "I");
			global::android.app.Notification._ledOnMS1377 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "ledOnMS", "I");
			global::android.app.Notification._ledOffMS1378 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "ledOffMS", "I");
			global::android.app.Notification._defaults1379 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "defaults", "I");
			global::android.app.Notification._flags1387 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "flags", "I");
			global::android.app.Notification._CREATOR1388 = @__env.GetStaticFieldIDNoThrow(global::android.app.Notification.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
