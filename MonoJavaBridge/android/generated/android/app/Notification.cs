namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Notification : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Notification(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString1968;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Notification.staticClass, global::android.app.Notification._toString1968)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1969;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Notification.staticClass, global::android.app.Notification._writeToParcel1969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1970;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Notification.staticClass, global::android.app.Notification._describeContents1970);
		}
		internal static global::MonoJavaBridge.MethodId _setLatestEventInfo1971;
		public virtual void setLatestEventInfo(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, android.app.PendingIntent arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Notification.staticClass, global::android.app.Notification._setLatestEventInfo1971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void setLatestEventInfo(android.content.Context arg0, string arg1, string arg2, android.app.PendingIntent arg3)
		{
			setLatestEventInfo(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _Notification1972;
		public Notification() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Notification.staticClass, global::android.app.Notification._Notification1972);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Notification1973;
		public Notification(int arg0, java.lang.CharSequence arg1, long arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Notification.staticClass, global::android.app.Notification._Notification1973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Notification1974;
		public Notification(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Notification.staticClass, global::android.app.Notification._Notification1974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _when1979;
		public long when
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _when1979);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _icon1980;
		public int icon
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _icon1980);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _number1981;
		public int number
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _number1981);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _contentIntent1982;
		public global::android.app.PendingIntent contentIntent
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.GetObjectField(this.JvmHandle, _contentIntent1982)) as android.app.PendingIntent;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _deleteIntent1983;
		public global::android.app.PendingIntent deleteIntent
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.GetObjectField(this.JvmHandle, _deleteIntent1983)) as android.app.PendingIntent;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _tickerText1984;
		public global::java.lang.CharSequence tickerText
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _tickerText1984)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _contentView1985;
		public global::android.widget.RemoteViews contentView
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _contentView1985)) as android.widget.RemoteViews;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _iconLevel1986;
		public int iconLevel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _iconLevel1986);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sound1987;
		public global::android.net.Uri sound
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _sound1987)) as android.net.Uri;
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
		internal static global::MonoJavaBridge.FieldId _audioStreamType1989;
		public int audioStreamType
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _audioStreamType1989);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _vibrate1990;
		public long[] vibrate
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.GetObjectField(this.JvmHandle, _vibrate1990)) as long[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ledARGB1991;
		public int ledARGB
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _ledARGB1991);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ledOnMS1992;
		public int ledOnMS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _ledOnMS1992);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ledOffMS1993;
		public int ledOffMS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _ledOffMS1993);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _defaults1994;
		public int defaults
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _defaults1994);
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
		internal static global::MonoJavaBridge.FieldId _flags2002;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags2002);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2003;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.Notification.staticClass, _CREATOR2003)) as android.os.Parcelable_Creator;
			}
		}
		static Notification()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Notification.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Notification"));
			global::android.app.Notification._toString1968 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "toString", "()Ljava/lang/String;");
			global::android.app.Notification._writeToParcel1969 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.app.Notification._describeContents1970 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "describeContents", "()I");
			global::android.app.Notification._setLatestEventInfo1971 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "setLatestEventInfo", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/app/PendingIntent;)V");
			global::android.app.Notification._Notification1972 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "<init>", "()V");
			global::android.app.Notification._Notification1973 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "<init>", "(ILjava/lang/CharSequence;J)V");
			global::android.app.Notification._Notification1974 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.app.Notification._when1979 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "when", "J");
			global::android.app.Notification._icon1980 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "icon", "I");
			global::android.app.Notification._number1981 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "number", "I");
			global::android.app.Notification._contentIntent1982 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "contentIntent", "Landroid/app/PendingIntent;");
			global::android.app.Notification._deleteIntent1983 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "deleteIntent", "Landroid/app/PendingIntent;");
			global::android.app.Notification._tickerText1984 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "tickerText", "Ljava/lang/CharSequence;");
			global::android.app.Notification._contentView1985 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "contentView", "Landroid/widget/RemoteViews;");
			global::android.app.Notification._iconLevel1986 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "iconLevel", "I");
			global::android.app.Notification._sound1987 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "sound", "Landroid/net/Uri;");
			global::android.app.Notification._audioStreamType1989 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "audioStreamType", "I");
			global::android.app.Notification._vibrate1990 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "vibrate", "[J");
			global::android.app.Notification._ledARGB1991 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "ledARGB", "I");
			global::android.app.Notification._ledOnMS1992 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "ledOnMS", "I");
			global::android.app.Notification._ledOffMS1993 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "ledOffMS", "I");
			global::android.app.Notification._defaults1994 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "defaults", "I");
			global::android.app.Notification._flags2002 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "flags", "I");
			global::android.app.Notification._CREATOR2003 = @__env.GetStaticFieldIDNoThrow(global::android.app.Notification.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
