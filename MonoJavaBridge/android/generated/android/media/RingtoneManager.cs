namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RingtoneManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RingtoneManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isDefault7449;
		public static bool isDefault(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._isDefault7449.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._isDefault7449 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "isDefault", "(Landroid/net/Uri;)Z");
			return @__env.CallStaticBooleanMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._isDefault7449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Type
		{
			set
			{
				setType(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setType7450;
		public virtual void setType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._setType7450.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._setType7450 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "setType", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._setType7450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inferStreamType7451;
		public virtual int inferStreamType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._inferStreamType7451.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._inferStreamType7451 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "inferStreamType", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._inferStreamType7451);
		}
		internal static global::MonoJavaBridge.MethodId _setStopPreviousRingtone7452;
		public virtual void setStopPreviousRingtone(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._setStopPreviousRingtone7452.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._setStopPreviousRingtone7452 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "setStopPreviousRingtone", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._setStopPreviousRingtone7452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopPreviousRingtone7453;
		public virtual void stopPreviousRingtone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._stopPreviousRingtone7453.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._stopPreviousRingtone7453 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "stopPreviousRingtone", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._stopPreviousRingtone7453);
		}
		internal static global::MonoJavaBridge.MethodId _getStopPreviousRingtone7454;
		public virtual bool getStopPreviousRingtone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._getStopPreviousRingtone7454.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._getStopPreviousRingtone7454 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getStopPreviousRingtone", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getStopPreviousRingtone7454);
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
		internal static global::MonoJavaBridge.MethodId _getIncludeDrm7455;
		public virtual bool getIncludeDrm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._getIncludeDrm7455.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._getIncludeDrm7455 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getIncludeDrm", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getIncludeDrm7455);
		}
		internal static global::MonoJavaBridge.MethodId _setIncludeDrm7456;
		public virtual void setIncludeDrm(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._setIncludeDrm7456.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._setIncludeDrm7456 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "setIncludeDrm", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._setIncludeDrm7456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.database.Cursor Cursor
		{
			get
			{
				return getCursor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCursor7457;
		public virtual global::android.database.Cursor getCursor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._getCursor7457.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._getCursor7457 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getCursor", "()Landroid/database/Cursor;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getCursor7457) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _getRingtone7458;
		public virtual global::android.media.Ringtone getRingtone(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._getRingtone7458.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._getRingtone7458 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getRingtone", "(I)Landroid/media/Ringtone;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getRingtone7458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.media.Ringtone;
		}
		internal static global::MonoJavaBridge.MethodId _getRingtone7459;
		public static global::android.media.Ringtone getRingtone(android.content.Context arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._getRingtone7459.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._getRingtone7459 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getRingtone", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/media/Ringtone;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getRingtone7459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.media.Ringtone;
		}
		internal static global::MonoJavaBridge.MethodId _getRingtoneUri7460;
		public virtual global::android.net.Uri getRingtoneUri(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._getRingtoneUri7460.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._getRingtoneUri7460 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getRingtoneUri", "(I)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getRingtoneUri7460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _getRingtonePosition7461;
		public virtual int getRingtonePosition(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._getRingtonePosition7461.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._getRingtonePosition7461 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getRingtonePosition", "(Landroid/net/Uri;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getRingtonePosition7461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getValidRingtoneUri7462;
		public static global::android.net.Uri getValidRingtoneUri(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._getValidRingtoneUri7462.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._getValidRingtoneUri7462 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getValidRingtoneUri", "(Landroid/content/Context;)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getValidRingtoneUri7462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _getActualDefaultRingtoneUri7463;
		public static global::android.net.Uri getActualDefaultRingtoneUri(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._getActualDefaultRingtoneUri7463.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._getActualDefaultRingtoneUri7463 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getActualDefaultRingtoneUri", "(Landroid/content/Context;I)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getActualDefaultRingtoneUri7463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _setActualDefaultRingtoneUri7464;
		public static void setActualDefaultRingtoneUri(android.content.Context arg0, int arg1, android.net.Uri arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._setActualDefaultRingtoneUri7464.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._setActualDefaultRingtoneUri7464 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "setActualDefaultRingtoneUri", "(Landroid/content/Context;ILandroid/net/Uri;)V");
			@__env.CallStaticVoidMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._setActualDefaultRingtoneUri7464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultType7465;
		public static int getDefaultType(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._getDefaultType7465.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._getDefaultType7465 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getDefaultType", "(Landroid/net/Uri;)I");
			return @__env.CallStaticIntMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getDefaultType7465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultUri7466;
		public static global::android.net.Uri getDefaultUri(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._getDefaultUri7466.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._getDefaultUri7466 = @__env.GetStaticMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "getDefaultUri", "(I)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._getDefaultUri7466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _RingtoneManager7467;
		public RingtoneManager(android.app.Activity arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._RingtoneManager7467.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._RingtoneManager7467 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "<init>", "(Landroid/app/Activity;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._RingtoneManager7467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RingtoneManager7468;
		public RingtoneManager(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.RingtoneManager._RingtoneManager7468.native == global::System.IntPtr.Zero)
				global::android.media.RingtoneManager._RingtoneManager7468 = @__env.GetMethodIDNoThrow(global::android.media.RingtoneManager.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.RingtoneManager.staticClass, global::android.media.RingtoneManager._RingtoneManager7468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
