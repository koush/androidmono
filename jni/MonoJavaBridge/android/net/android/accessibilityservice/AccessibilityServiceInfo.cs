namespace android.accessibilityservice 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AccessibilityServiceInfo : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static AccessibilityServiceInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.accessibilityservice.AccessibilityServiceInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.accessibilityservice.AccessibilityServiceInfo(@__env); 
			} 
		} 
		protected AccessibilityServiceInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel25; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accessibilityservice.AccessibilityServiceInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel25, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.accessibilityservice.AccessibilityServiceInfo.staticClass, _writeToParcel25, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents26; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.accessibilityservice.AccessibilityServiceInfo)) 
				return @__env.CallIntMethod(this, _describeContents26); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.accessibilityservice.AccessibilityServiceInfo.staticClass, _describeContents26); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AccessibilityServiceInfo27; 
		public AccessibilityServiceInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accessibilityservice.AccessibilityServiceInfo.staticClass, _AccessibilityServiceInfo27, this); 
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
		internal static global::net.sf.jni4net.jni.FieldId _eventTypes28; 
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
		internal static global::net.sf.jni4net.jni.FieldId _packageNames29; 
		public java.lang.String[] packageNames
		{ 
			get 
			{ 
				return default(java.lang.String[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _feedbackType30; 
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
		internal static global::net.sf.jni4net.jni.FieldId _notificationTimeout31; 
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
		internal static global::net.sf.jni4net.jni.FieldId _flags32; 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR33; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.accessibilityservice.AccessibilityServiceInfo.staticClass = @__class; 
			global::android.accessibilityservice.AccessibilityServiceInfo._writeToParcel25 = @__env.GetMethodID(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.accessibilityservice.AccessibilityServiceInfo._describeContents26 = @__env.GetMethodID(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "describeContents", "()I"); 
			global::android.accessibilityservice.AccessibilityServiceInfo._AccessibilityServiceInfo27 = @__env.GetMethodID(global::android.accessibilityservice.AccessibilityServiceInfo.staticClass, "<init>", "()V"); 
		} 
	} 
} 
