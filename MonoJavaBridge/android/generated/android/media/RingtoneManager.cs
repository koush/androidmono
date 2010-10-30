namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RingtoneManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RingtoneManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static bool isDefault(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._m0.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._m0 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "isDefault", "(Landroid/net/Uri;)Z");
			return @__env.CallStaticBooleanMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Type
		{
			set
			{
				setType(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.RingtoneManager.staticClass, "setType", "(I)V", ref global::android.media.RingtoneManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int inferStreamType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.RingtoneManager.staticClass, "inferStreamType", "()I", ref global::android.media.RingtoneManager._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setStopPreviousRingtone(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.RingtoneManager.staticClass, "setStopPreviousRingtone", "(Z)V", ref global::android.media.RingtoneManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void stopPreviousRingtone()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.RingtoneManager.staticClass, "stopPreviousRingtone", "()V", ref global::android.media.RingtoneManager._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool getStopPreviousRingtone()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.RingtoneManager.staticClass, "getStopPreviousRingtone", "()Z", ref global::android.media.RingtoneManager._m5);
		}
		public new bool IncludeDrm
		{
			get
			{
				return getIncludeDrm();
			}
			set
			{
				setIncludeDrm(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool getIncludeDrm()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.RingtoneManager.staticClass, "getIncludeDrm", "()Z", ref global::android.media.RingtoneManager._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setIncludeDrm(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.RingtoneManager.staticClass, "setIncludeDrm", "(Z)V", ref global::android.media.RingtoneManager._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.database.Cursor Cursor
		{
			get
			{
				return getCursor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.database.Cursor getCursor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.media.RingtoneManager.staticClass, "getCursor", "()Landroid/database/Cursor;", ref global::android.media.RingtoneManager._m8) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.media.Ringtone getRingtone(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.media.RingtoneManager.staticClass, "getRingtone", "(I)Landroid/media/Ringtone;", ref global::android.media.RingtoneManager._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.media.Ringtone;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::android.media.Ringtone getRingtone(android.content.Context arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._m10.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._m10 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getRingtone", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/media/Ringtone;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.media.Ringtone;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::android.net.Uri getRingtoneUri(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.media.RingtoneManager.staticClass, "getRingtoneUri", "(I)Landroid/net/Uri;", ref global::android.media.RingtoneManager._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int getRingtonePosition(android.net.Uri arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.RingtoneManager.staticClass, "getRingtonePosition", "(Landroid/net/Uri;)I", ref global::android.media.RingtoneManager._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::android.net.Uri getValidRingtoneUri(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._m13.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._m13 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getValidRingtoneUri", "(Landroid/content/Context;)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::android.net.Uri getActualDefaultRingtoneUri(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._m14.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._m14 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getActualDefaultRingtoneUri", "(Landroid/content/Context;I)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static void setActualDefaultRingtoneUri(android.content.Context arg0, int arg1, android.net.Uri arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._m15.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._m15 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "setActualDefaultRingtoneUri", "(Landroid/content/Context;ILandroid/net/Uri;)V");
			@__env.CallStaticVoidMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static int getDefaultType(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._m16.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._m16 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getDefaultType", "(Landroid/net/Uri;)I");
			return @__env.CallStaticIntMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static global::android.net.Uri getDefaultUri(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._m17.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._m17 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getDefaultUri", "(I)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public RingtoneManager(android.app.Activity arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._m18.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._m18 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "<init>", "(Landroid/app/Activity;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public RingtoneManager(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._m19.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._m19 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int TYPE_RINGTONE
		{
			get
			{
				return 1;
			}
		}
		public static int TYPE_NOTIFICATION
		{
			get
			{
				return 2;
			}
		}
		public static int TYPE_ALARM
		{
			get
			{
				return 4;
			}
		}
		public static int TYPE_ALL
		{
			get
			{
				return 7;
			}
		}
		public static global::java.lang.String ACTION_RINGTONE_PICKER
		{
			get
			{
				return "android.intent.action.RINGTONE_PICKER";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_SHOW_DEFAULT
		{
			get
			{
				return "android.intent.extra.ringtone.SHOW_DEFAULT";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_SHOW_SILENT
		{
			get
			{
				return "android.intent.extra.ringtone.SHOW_SILENT";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_INCLUDE_DRM
		{
			get
			{
				return "android.intent.extra.ringtone.INCLUDE_DRM";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_EXISTING_URI
		{
			get
			{
				return "android.intent.extra.ringtone.EXISTING_URI";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_DEFAULT_URI
		{
			get
			{
				return "android.intent.extra.ringtone.DEFAULT_URI";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_TYPE
		{
			get
			{
				return "android.intent.extra.ringtone.TYPE";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_TITLE
		{
			get
			{
				return "android.intent.extra.ringtone.TITLE";
			}
		}
		public static global::java.lang.String EXTRA_RINGTONE_PICKED_URI
		{
			get
			{
				return "android.intent.extra.ringtone.PICKED_URI";
			}
		}
		public static int ID_COLUMN_INDEX
		{
			get
			{
				return 0;
			}
		}
		public static int TITLE_COLUMN_INDEX
		{
			get
			{
				return 1;
			}
		}
		public static int URI_COLUMN_INDEX
		{
			get
			{
				return 2;
			}
		}
		static RingtoneManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.RingtoneManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/RingtoneManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
