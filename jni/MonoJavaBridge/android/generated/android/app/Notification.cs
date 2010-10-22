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
		internal static global::MonoJavaBridge.MethodId _toString1964;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Notification._toString1964)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Notification.staticClass, global::android.app.Notification._toString1964)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1965;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Notification._writeToParcel1965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Notification.staticClass, global::android.app.Notification._writeToParcel1965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1966;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Notification._describeContents1966);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Notification.staticClass, global::android.app.Notification._describeContents1966);
		}
		internal static global::MonoJavaBridge.MethodId _setLatestEventInfo1967;
		public virtual void setLatestEventInfo(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, android.app.PendingIntent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Notification._setLatestEventInfo1967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Notification.staticClass, global::android.app.Notification._setLatestEventInfo1967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void setLatestEventInfo(android.content.Context arg0, string arg1, string arg2, android.app.PendingIntent arg3)
		{
			setLatestEventInfo(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3);
		}
		internal static global::MonoJavaBridge.MethodId _Notification1968;
		public Notification()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Notification.staticClass, global::android.app.Notification._Notification1968);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Notification1969;
		public Notification(int arg0, java.lang.CharSequence arg1, long arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Notification.staticClass, global::android.app.Notification._Notification1969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Notification1970;
		public Notification(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Notification.staticClass, global::android.app.Notification._Notification1970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _when1975;
		public long when
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _when1975);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _icon1976;
		public int icon
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _icon1976);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _number1977;
		public int number
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _number1977);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _contentIntent1978;
		public global::android.app.PendingIntent contentIntent
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.GetObjectField(this.JvmHandle, _contentIntent1978)) as android.app.PendingIntent;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _deleteIntent1979;
		public global::android.app.PendingIntent deleteIntent
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.PendingIntent>(@__env.GetObjectField(this.JvmHandle, _deleteIntent1979)) as android.app.PendingIntent;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _tickerText1980;
		public global::java.lang.CharSequence tickerText
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _tickerText1980)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _contentView1981;
		public global::android.widget.RemoteViews contentView
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _contentView1981)) as android.widget.RemoteViews;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _iconLevel1982;
		public int iconLevel
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _iconLevel1982);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sound1983;
		public global::android.net.Uri sound
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _sound1983)) as android.net.Uri;
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
		internal static global::MonoJavaBridge.FieldId _audioStreamType1985;
		public int audioStreamType
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _audioStreamType1985);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _vibrate1986;
		public long[] vibrate
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.GetObjectField(this.JvmHandle, _vibrate1986)) as long[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ledARGB1987;
		public int ledARGB
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _ledARGB1987);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ledOnMS1988;
		public int ledOnMS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _ledOnMS1988);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ledOffMS1989;
		public int ledOffMS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _ledOffMS1989);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _defaults1990;
		public int defaults
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _defaults1990);
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
		internal static global::MonoJavaBridge.FieldId _flags1998;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags1998);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1999;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.Notification.staticClass, _CREATOR1999)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Notification.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Notification"));
			global::android.app.Notification._toString1964 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "toString", "()Ljava/lang/String;");
			global::android.app.Notification._writeToParcel1965 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.app.Notification._describeContents1966 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "describeContents", "()I");
			global::android.app.Notification._setLatestEventInfo1967 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "setLatestEventInfo", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/app/PendingIntent;)V");
			global::android.app.Notification._Notification1968 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "<init>", "()V");
			global::android.app.Notification._Notification1969 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "<init>", "(ILjava/lang/CharSequence;J)V");
			global::android.app.Notification._Notification1970 = @__env.GetMethodIDNoThrow(global::android.app.Notification.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.app.Notification._when1975 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "when", "J");
			global::android.app.Notification._icon1976 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "icon", "I");
			global::android.app.Notification._number1977 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "number", "I");
			global::android.app.Notification._contentIntent1978 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "contentIntent", "Landroid/app/PendingIntent;");
			global::android.app.Notification._deleteIntent1979 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "deleteIntent", "Landroid/app/PendingIntent;");
			global::android.app.Notification._tickerText1980 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "tickerText", "Ljava/lang/CharSequence;");
			global::android.app.Notification._contentView1981 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "contentView", "Landroid/widget/RemoteViews;");
			global::android.app.Notification._iconLevel1982 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "iconLevel", "I");
			global::android.app.Notification._sound1983 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "sound", "Landroid/net/Uri;");
			global::android.app.Notification._audioStreamType1985 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "audioStreamType", "I");
			global::android.app.Notification._vibrate1986 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "vibrate", "[J");
			global::android.app.Notification._ledARGB1987 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "ledARGB", "I");
			global::android.app.Notification._ledOnMS1988 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "ledOnMS", "I");
			global::android.app.Notification._ledOffMS1989 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "ledOffMS", "I");
			global::android.app.Notification._defaults1990 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "defaults", "I");
			global::android.app.Notification._flags1998 = @__env.GetFieldIDNoThrow(global::android.app.Notification.staticClass, "flags", "I");
			global::android.app.Notification._CREATOR1999 = @__env.GetStaticFieldIDNoThrow(global::android.app.Notification.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
