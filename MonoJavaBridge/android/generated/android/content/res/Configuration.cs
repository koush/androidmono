namespace android.content.res
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Configuration : java.lang.Object, android.os.Parcelable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Configuration(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.Configuration.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.content.res.Configuration._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public bool equals(android.content.res.Configuration arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.Configuration.staticClass, "equals", "(Landroid/content/res/Configuration;)Z", ref global::android.content.res.Configuration._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Configuration.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.res.Configuration._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Configuration.staticClass, "hashCode", "()I", ref global::android.content.res.Configuration._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Configuration.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::android.content.res.Configuration._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public int compareTo(android.content.res.Configuration arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Configuration.staticClass, "compareTo", "(Landroid/content/res/Configuration;)I", ref global::android.content.res.Configuration._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Configuration.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.res.Configuration._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Configuration.staticClass, "describeContents", "()I", ref global::android.content.res.Configuration._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public void readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Configuration.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.content.res.Configuration._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.Configuration To
		{
			set
			{
				setTo(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public void setTo(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Configuration.staticClass, "setTo", "(Landroid/content/res/Configuration;)V", ref global::android.content.res.Configuration._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public void setToDefaults()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Configuration.staticClass, "setToDefaults", "()V", ref global::android.content.res.Configuration._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public int updateFrom(android.content.res.Configuration arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Configuration.staticClass, "updateFrom", "(Landroid/content/res/Configuration;)I", ref global::android.content.res.Configuration._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public int diff(android.content.res.Configuration arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Configuration.staticClass, "diff", "(Landroid/content/res/Configuration;)I", ref global::android.content.res.Configuration._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static bool needNewResources(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Configuration._m13.native == global::System.IntPtr.Zero)
				global::android.content.res.Configuration._m13 = @__env.GetStaticMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "needNewResources", "(II)Z");
			return @__env.CallStaticBooleanMethod(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public Configuration() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Configuration._m14.native == global::System.IntPtr.Zero)
				global::android.content.res.Configuration._m14 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._m14);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public Configuration(android.content.res.Configuration arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Configuration._m15.native == global::System.IntPtr.Zero)
				global::android.content.res.Configuration._m15 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "<init>", "(Landroid/content/res/Configuration;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _fontScale2136;
		public float fontScale
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _fontScale2136);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _mcc2137;
		public int mcc
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _mcc2137);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _mnc2138;
		public int mnc
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _mnc2138);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _locale2139;
		public global::java.util.Locale locale
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetObjectField(this.JvmHandle, _locale2139)) as java.util.Locale;
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
		internal static global::MonoJavaBridge.FieldId _screenLayout2149;
		public int screenLayout
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _screenLayout2149);
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
		internal static global::MonoJavaBridge.FieldId _touchscreen2154;
		public int touchscreen
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _touchscreen2154);
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
		internal static global::MonoJavaBridge.FieldId _keyboard2159;
		public int keyboard
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _keyboard2159);
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
		internal static global::MonoJavaBridge.FieldId _keyboardHidden2163;
		public int keyboardHidden
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _keyboardHidden2163);
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
		internal static global::MonoJavaBridge.FieldId _hardKeyboardHidden2167;
		public int hardKeyboardHidden
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _hardKeyboardHidden2167);
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
		internal static global::MonoJavaBridge.FieldId _navigation2173;
		public int navigation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _navigation2173);
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
		internal static global::MonoJavaBridge.FieldId _navigationHidden2177;
		public int navigationHidden
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _navigationHidden2177);
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
		internal static global::MonoJavaBridge.FieldId _orientation2182;
		public int orientation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _orientation2182);
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
		internal static global::MonoJavaBridge.FieldId _uiMode2192;
		public int uiMode
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _uiMode2192);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2193;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.res.Configuration.staticClass, _CREATOR2193)) as android.os.Parcelable_Creator;
			}
		}
		static Configuration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.Configuration.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/Configuration"));
			global::android.content.res.Configuration._fontScale2136 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "fontScale", "F");
			global::android.content.res.Configuration._mcc2137 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "mcc", "I");
			global::android.content.res.Configuration._mnc2138 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "mnc", "I");
			global::android.content.res.Configuration._locale2139 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "locale", "Ljava/util/Locale;");
			global::android.content.res.Configuration._screenLayout2149 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "screenLayout", "I");
			global::android.content.res.Configuration._touchscreen2154 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "touchscreen", "I");
			global::android.content.res.Configuration._keyboard2159 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "keyboard", "I");
			global::android.content.res.Configuration._keyboardHidden2163 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "keyboardHidden", "I");
			global::android.content.res.Configuration._hardKeyboardHidden2167 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "hardKeyboardHidden", "I");
			global::android.content.res.Configuration._navigation2173 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "navigation", "I");
			global::android.content.res.Configuration._navigationHidden2177 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "navigationHidden", "I");
			global::android.content.res.Configuration._orientation2182 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "orientation", "I");
			global::android.content.res.Configuration._uiMode2192 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "uiMode", "I");
			global::android.content.res.Configuration._CREATOR2193 = @__env.GetStaticFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
