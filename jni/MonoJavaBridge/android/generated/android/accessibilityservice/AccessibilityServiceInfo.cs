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
		internal static global::MonoJavaBridge.MethodId _writeToParcel27;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityServiceInfo._writeToParcel27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, global::android.accessibilityservice.AccessibilityServiceInfo._writeToParcel27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents28;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityServiceInfo._describeContents28);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, global::android.accessibilityservice.AccessibilityServiceInfo._describeContents28);
		}
		internal static global::MonoJavaBridge.MethodId _AccessibilityServiceInfo29;
		public AccessibilityServiceInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accessibilityservice.AccessibilityServiceInfo.staticClass, global::android.accessibilityservice.AccessibilityServiceInfo._AccessibilityServiceInfo29);
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
		internal static global::MonoJavaBridge.FieldId _eventTypes30;
		public int eventTypes
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageNames31;
		public global::java.lang.String[] packageNames
		{
			get
			{
				return default(global::java.lang.String[]);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _feedbackType32;
		public int feedbackType
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _notificationTimeout33;
		public long notificationTimeout
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _flags34;
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
		internal static global::MonoJavaBridge.FieldId _CREATOR35;
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
			global::android.accessibilityservice.AccessibilityServiceInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accessibilityservice/AccessibilityServiceInfo"));
			global::android.accessibilityservice.AccessibilityServiceInfo._writeToParcel27 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.accessibilityservice.AccessibilityServiceInfo._describeContents28 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "describeContents", "()I");
			global::android.accessibilityservice.AccessibilityServiceInfo._AccessibilityServiceInfo29 = @__env.GetMethodIDNoThrow(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "<init>", "()V");
		}
	}
}
