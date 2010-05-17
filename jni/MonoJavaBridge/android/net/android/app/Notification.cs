namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Notification : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Notification() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.Notification), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.Notification(@__env); 
			} 
		} 
		protected Notification(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString649; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Notification)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString649)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Notification.staticClass, _toString649)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel650; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Notification)) 
				@__env.CallVoidMethod(this, _writeToParcel650, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Notification.staticClass, _writeToParcel650, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents651; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Notification)) 
				return @__env.CallIntMethod(this, _describeContents651); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.Notification.staticClass, _describeContents651); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLatestEventInfo652; 
		public virtual void setLatestEventInfo(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, android.app.PendingIntent arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Notification)) 
				@__env.CallVoidMethod(this, _setLatestEventInfo652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Notification.staticClass, _setLatestEventInfo652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Notification653; 
		public Notification()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Notification.staticClass, _Notification653, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Notification654; 
		public Notification(int arg0, java.lang.CharSequence arg1, long arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Notification.staticClass, _Notification654, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Notification655; 
		public Notification(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Notification.staticClass, _Notification655, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
		internal static global::net.sf.jni4net.jni.FieldId _when656; 
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
		internal static global::net.sf.jni4net.jni.FieldId _icon657; 
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
		internal static global::net.sf.jni4net.jni.FieldId _number658; 
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
		internal static global::net.sf.jni4net.jni.FieldId _contentIntent659; 
		public android.app.PendingIntent contentIntent
		{ 
			get 
			{ 
				return default(android.app.PendingIntent); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _deleteIntent660; 
		public android.app.PendingIntent deleteIntent
		{ 
			get 
			{ 
				return default(android.app.PendingIntent); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _tickerText661; 
		public java.lang.CharSequence tickerText
		{ 
			get 
			{ 
				return default(java.lang.CharSequence); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _contentView662; 
		public android.widget.RemoteViews contentView
		{ 
			get 
			{ 
				return default(android.widget.RemoteViews); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _iconLevel663; 
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
		internal static global::net.sf.jni4net.jni.FieldId _sound664; 
		public android.net.Uri sound
		{ 
			get 
			{ 
				return default(android.net.Uri); 
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
		internal static global::net.sf.jni4net.jni.FieldId _audioStreamType665; 
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
		internal static global::net.sf.jni4net.jni.FieldId _vibrate666; 
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
		internal static global::net.sf.jni4net.jni.FieldId _ledARGB667; 
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
		internal static global::net.sf.jni4net.jni.FieldId _ledOnMS668; 
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
		internal static global::net.sf.jni4net.jni.FieldId _ledOffMS669; 
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
		internal static global::net.sf.jni4net.jni.FieldId _defaults670; 
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
		internal static global::net.sf.jni4net.jni.FieldId _flags671; 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR672; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.Notification.staticClass = @__class; 
			global::android.app.Notification._toString649 = @__env.GetMethodID(global::android.app.Notification.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.app.Notification._writeToParcel650 = @__env.GetMethodID(global::android.app.Notification.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.app.Notification._describeContents651 = @__env.GetMethodID(global::android.app.Notification.staticClass, "describeContents", "()I"); 
			global::android.app.Notification._setLatestEventInfo652 = @__env.GetMethodID(global::android.app.Notification.staticClass, "setLatestEventInfo", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/app/PendingIntent;)V"); 
			global::android.app.Notification._Notification653 = @__env.GetMethodID(global::android.app.Notification.staticClass, "<init>", "()V"); 
			global::android.app.Notification._Notification654 = @__env.GetMethodID(global::android.app.Notification.staticClass, "<init>", "(ILjava/lang/CharSequence;J)V"); 
			global::android.app.Notification._Notification655 = @__env.GetMethodID(global::android.app.Notification.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
