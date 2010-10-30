namespace android.accessibilityservice
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccessibilityServiceInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AccessibilityServiceInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.accessibilityservice.AccessibilityServiceInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "describeContents", "()I", ref global::android.accessibilityservice.AccessibilityServiceInfo._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public AccessibilityServiceInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accessibilityservice.AccessibilityServiceInfo._m2.native == global::System.IntPtr.Zero)
				global::android.accessibilityservice.AccessibilityServiceInfo._m2 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accessibilityservice.AccessibilityServiceInfo.staticClass, global::android.accessibilityservice.AccessibilityServiceInfo._m2);
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
		internal static global::MonoJavaBridge.FieldId _eventTypes1225;
		public int eventTypes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _eventTypes1225);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageNames1226;
		public global::java.lang.String[] packageNames
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageNames1226)) as java.lang.String[];
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _feedbackType1227;
		public int feedbackType
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _feedbackType1227);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _notificationTimeout1228;
		public long notificationTimeout
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _notificationTimeout1228);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _flags1229;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags1229);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1230;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, _CREATOR1230)) as android.os.Parcelable_Creator;
			}
		}
		static AccessibilityServiceInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accessibilityservice.AccessibilityServiceInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accessibilityservice/AccessibilityServiceInfo"));
			global::android.accessibilityservice.AccessibilityServiceInfo._eventTypes1225 = @__env.GetFieldIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "eventTypes", "I");
			global::android.accessibilityservice.AccessibilityServiceInfo._packageNames1226 = @__env.GetFieldIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "packageNames", "[Ljava/lang/String;");
			global::android.accessibilityservice.AccessibilityServiceInfo._feedbackType1227 = @__env.GetFieldIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "feedbackType", "I");
			global::android.accessibilityservice.AccessibilityServiceInfo._notificationTimeout1228 = @__env.GetFieldIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "notificationTimeout", "J");
			global::android.accessibilityservice.AccessibilityServiceInfo._flags1229 = @__env.GetFieldIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "flags", "I");
			global::android.accessibilityservice.AccessibilityServiceInfo._CREATOR1230 = @__env.GetStaticFieldIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
