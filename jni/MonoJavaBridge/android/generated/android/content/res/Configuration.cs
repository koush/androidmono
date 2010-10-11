namespace android.content.res
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Configuration : java.lang.Object, android.os.Parcelable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Configuration()
		{
			InitJNI();
		}
		internal Configuration(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals2256;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.Configuration._equals2256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._equals2256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals2257;
		public bool equals(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.Configuration._equals2257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._equals2257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString2258;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.Configuration._toString2258)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._toString2258)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode2259;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._hashCode2259);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._hashCode2259);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo2260;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._compareTo2260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._compareTo2260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo2261;
		public int compareTo(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._compareTo2261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._compareTo2261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2262;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.Configuration._writeToParcel2262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._writeToParcel2262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2263;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._describeContents2263);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._describeContents2263);
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel2264;
		public void readFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.Configuration._readFromParcel2264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._readFromParcel2264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTo2265;
		public void setTo(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.Configuration._setTo2265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._setTo2265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setToDefaults2266;
		public void setToDefaults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.Configuration._setToDefaults2266);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._setToDefaults2266);
		}
		internal static global::MonoJavaBridge.MethodId _updateFrom2267;
		public int updateFrom(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._updateFrom2267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._updateFrom2267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _diff2268;
		public int diff(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._diff2268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._diff2268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _needNewResources2269;
		public static bool needNewResources(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._needNewResources2269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Configuration2270;
		public Configuration()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._Configuration2270);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Configuration2271;
		public Configuration(android.content.res.Configuration arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._Configuration2271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _fontScale2272;
		public float fontScale
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _mcc2273;
		public int mcc
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _mnc2274;
		public int mnc
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _locale2275;
		public global::java.util.Locale locale
		{
			get
			{
				return default(global::java.util.Locale);
			}
			set
			{
			}
		}
		public static int SCREENLAYOUT_SIZE_MASK
		{
			get
			{
				return 15;
			}
		}
		public static int SCREENLAYOUT_SIZE_UNDEFINED
		{
			get
			{
				return 0;
			}
		}
		public static int SCREENLAYOUT_SIZE_SMALL
		{
			get
			{
				return 1;
			}
		}
		public static int SCREENLAYOUT_SIZE_NORMAL
		{
			get
			{
				return 2;
			}
		}
		public static int SCREENLAYOUT_SIZE_LARGE
		{
			get
			{
				return 3;
			}
		}
		public static int SCREENLAYOUT_LONG_MASK
		{
			get
			{
				return 48;
			}
		}
		public static int SCREENLAYOUT_LONG_UNDEFINED
		{
			get
			{
				return 0;
			}
		}
		public static int SCREENLAYOUT_LONG_NO
		{
			get
			{
				return 16;
			}
		}
		public static int SCREENLAYOUT_LONG_YES
		{
			get
			{
				return 32;
			}
		}
		internal static global::MonoJavaBridge.FieldId _screenLayout2276;
		public int screenLayout
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int TOUCHSCREEN_UNDEFINED
		{
			get
			{
				return 0;
			}
		}
		public static int TOUCHSCREEN_NOTOUCH
		{
			get
			{
				return 1;
			}
		}
		public static int TOUCHSCREEN_STYLUS
		{
			get
			{
				return 2;
			}
		}
		public static int TOUCHSCREEN_FINGER
		{
			get
			{
				return 3;
			}
		}
		internal static global::MonoJavaBridge.FieldId _touchscreen2277;
		public int touchscreen
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int KEYBOARD_UNDEFINED
		{
			get
			{
				return 0;
			}
		}
		public static int KEYBOARD_NOKEYS
		{
			get
			{
				return 1;
			}
		}
		public static int KEYBOARD_QWERTY
		{
			get
			{
				return 2;
			}
		}
		public static int KEYBOARD_12KEY
		{
			get
			{
				return 3;
			}
		}
		internal static global::MonoJavaBridge.FieldId _keyboard2278;
		public int keyboard
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int KEYBOARDHIDDEN_UNDEFINED
		{
			get
			{
				return 0;
			}
		}
		public static int KEYBOARDHIDDEN_NO
		{
			get
			{
				return 1;
			}
		}
		public static int KEYBOARDHIDDEN_YES
		{
			get
			{
				return 2;
			}
		}
		internal static global::MonoJavaBridge.FieldId _keyboardHidden2279;
		public int keyboardHidden
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int HARDKEYBOARDHIDDEN_UNDEFINED
		{
			get
			{
				return 0;
			}
		}
		public static int HARDKEYBOARDHIDDEN_NO
		{
			get
			{
				return 1;
			}
		}
		public static int HARDKEYBOARDHIDDEN_YES
		{
			get
			{
				return 2;
			}
		}
		internal static global::MonoJavaBridge.FieldId _hardKeyboardHidden2280;
		public int hardKeyboardHidden
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int NAVIGATION_UNDEFINED
		{
			get
			{
				return 0;
			}
		}
		public static int NAVIGATION_NONAV
		{
			get
			{
				return 1;
			}
		}
		public static int NAVIGATION_DPAD
		{
			get
			{
				return 2;
			}
		}
		public static int NAVIGATION_TRACKBALL
		{
			get
			{
				return 3;
			}
		}
		public static int NAVIGATION_WHEEL
		{
			get
			{
				return 4;
			}
		}
		internal static global::MonoJavaBridge.FieldId _navigation2281;
		public int navigation
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int NAVIGATIONHIDDEN_UNDEFINED
		{
			get
			{
				return 0;
			}
		}
		public static int NAVIGATIONHIDDEN_NO
		{
			get
			{
				return 1;
			}
		}
		public static int NAVIGATIONHIDDEN_YES
		{
			get
			{
				return 2;
			}
		}
		internal static global::MonoJavaBridge.FieldId _navigationHidden2282;
		public int navigationHidden
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int ORIENTATION_UNDEFINED
		{
			get
			{
				return 0;
			}
		}
		public static int ORIENTATION_PORTRAIT
		{
			get
			{
				return 1;
			}
		}
		public static int ORIENTATION_LANDSCAPE
		{
			get
			{
				return 2;
			}
		}
		public static int ORIENTATION_SQUARE
		{
			get
			{
				return 3;
			}
		}
		internal static global::MonoJavaBridge.FieldId _orientation2283;
		public int orientation
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int UI_MODE_TYPE_MASK
		{
			get
			{
				return 15;
			}
		}
		public static int UI_MODE_TYPE_UNDEFINED
		{
			get
			{
				return 0;
			}
		}
		public static int UI_MODE_TYPE_NORMAL
		{
			get
			{
				return 1;
			}
		}
		public static int UI_MODE_TYPE_DESK
		{
			get
			{
				return 2;
			}
		}
		public static int UI_MODE_TYPE_CAR
		{
			get
			{
				return 3;
			}
		}
		public static int UI_MODE_NIGHT_MASK
		{
			get
			{
				return 48;
			}
		}
		public static int UI_MODE_NIGHT_UNDEFINED
		{
			get
			{
				return 0;
			}
		}
		public static int UI_MODE_NIGHT_NO
		{
			get
			{
				return 16;
			}
		}
		public static int UI_MODE_NIGHT_YES
		{
			get
			{
				return 32;
			}
		}
		internal static global::MonoJavaBridge.FieldId _uiMode2284;
		public int uiMode
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2285;
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
			global::android.content.res.Configuration.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/Configuration"));
			global::android.content.res.Configuration._equals2256 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.res.Configuration._equals2257 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "equals", "(Landroid/content/res/Configuration;)Z");
			global::android.content.res.Configuration._toString2258 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.Configuration._hashCode2259 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "hashCode", "()I");
			global::android.content.res.Configuration._compareTo2260 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::android.content.res.Configuration._compareTo2261 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "compareTo", "(Landroid/content/res/Configuration;)I");
			global::android.content.res.Configuration._writeToParcel2262 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.res.Configuration._describeContents2263 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "describeContents", "()I");
			global::android.content.res.Configuration._readFromParcel2264 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.content.res.Configuration._setTo2265 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "setTo", "(Landroid/content/res/Configuration;)V");
			global::android.content.res.Configuration._setToDefaults2266 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "setToDefaults", "()V");
			global::android.content.res.Configuration._updateFrom2267 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "updateFrom", "(Landroid/content/res/Configuration;)I");
			global::android.content.res.Configuration._diff2268 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "diff", "(Landroid/content/res/Configuration;)I");
			global::android.content.res.Configuration._needNewResources2269 = @__env.GetStaticMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "needNewResources", "(II)Z");
			global::android.content.res.Configuration._Configuration2270 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "<init>", "()V");
			global::android.content.res.Configuration._Configuration2271 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "<init>", "(Landroid/content/res/Configuration;)V");
		}
	}
}
