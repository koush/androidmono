namespace android.accessibilityservice
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccessibilityServiceInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccessibilityServiceInfo()
		{
			InitJNI();
		}
		protected AccessibilityServiceInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1246;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityServiceInfo._writeToParcel1246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, global::android.accessibilityservice.AccessibilityServiceInfo._writeToParcel1246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1247;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityServiceInfo._describeContents1247);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, global::android.accessibilityservice.AccessibilityServiceInfo._describeContents1247);
		}
		internal static global::MonoJavaBridge.MethodId _AccessibilityServiceInfo1248;
		public AccessibilityServiceInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accessibilityservice.AccessibilityServiceInfo.staticClass, global::android.accessibilityservice.AccessibilityServiceInfo._AccessibilityServiceInfo1248);
			Init(@__env, handle);
		}
		public static int FEEDBACK_SPOKEN
		{
			get
			{
				return 1;
			}
		}
		public static int FEEDBACK_HAPTIC
		{
			get
			{
				return 2;
			}
		}
		public static int FEEDBACK_AUDIBLE
		{
			get
			{
				return 4;
			}
		}
		public static int FEEDBACK_VISUAL
		{
			get
			{
				return 8;
			}
		}
		public static int FEEDBACK_GENERIC
		{
			get
			{
				return 16;
			}
		}
		public static int DEFAULT
		{
			get
			{
				return 1;
			}
		}
		internal static global::MonoJavaBridge.FieldId _eventTypes1255;
		public int eventTypes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _eventTypes1255);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageNames1256;
		public global::java.lang.String[] packageNames
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageNames1256)) as java.lang.String[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _feedbackType1257;
		public int feedbackType
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _feedbackType1257);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _notificationTimeout1258;
		public long notificationTimeout
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _notificationTimeout1258);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _flags1259;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags1259);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1260;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, _CREATOR1260)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accessibilityservice.AccessibilityServiceInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accessibilityservice/AccessibilityServiceInfo"));
			global::android.accessibilityservice.AccessibilityServiceInfo._writeToParcel1246 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.accessibilityservice.AccessibilityServiceInfo._describeContents1247 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "describeContents", "()I");
			global::android.accessibilityservice.AccessibilityServiceInfo._AccessibilityServiceInfo1248 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "<init>", "()V");
			global::android.accessibilityservice.AccessibilityServiceInfo._eventTypes1255 = @__env.GetFieldIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "eventTypes", "I");
			global::android.accessibilityservice.AccessibilityServiceInfo._packageNames1256 = @__env.GetFieldIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "packageNames", "[Ljava/lang/String;");
			global::android.accessibilityservice.AccessibilityServiceInfo._feedbackType1257 = @__env.GetFieldIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "feedbackType", "I");
			global::android.accessibilityservice.AccessibilityServiceInfo._notificationTimeout1258 = @__env.GetFieldIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "notificationTimeout", "J");
			global::android.accessibilityservice.AccessibilityServiceInfo._flags1259 = @__env.GetFieldIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "flags", "I");
			global::android.accessibilityservice.AccessibilityServiceInfo._CREATOR1260 = @__env.GetStaticFieldIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
