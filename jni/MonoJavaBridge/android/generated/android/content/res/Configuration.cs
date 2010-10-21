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
		internal static global::MonoJavaBridge.MethodId _equals4110;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.Configuration._equals4110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._equals4110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals4111;
		public bool equals(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.Configuration._equals4111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._equals4111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString4112;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.Configuration._toString4112)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._toString4112)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode4113;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._hashCode4113);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._hashCode4113);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo4114;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._compareTo4114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._compareTo4114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo4115;
		public int compareTo(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._compareTo4115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._compareTo4115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4116;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.Configuration._writeToParcel4116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._writeToParcel4116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4117;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._describeContents4117);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._describeContents4117);
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel4118;
		public void readFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.Configuration._readFromParcel4118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._readFromParcel4118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTo4119;
		public void setTo(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.Configuration._setTo4119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._setTo4119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setToDefaults4120;
		public void setToDefaults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.Configuration._setToDefaults4120);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._setToDefaults4120);
		}
		internal static global::MonoJavaBridge.MethodId _updateFrom4121;
		public int updateFrom(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._updateFrom4121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._updateFrom4121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _diff4122;
		public int diff(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._diff4122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._diff4122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _needNewResources4123;
		public static bool needNewResources(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._needNewResources4123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Configuration4124;
		public Configuration()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._Configuration4124);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Configuration4125;
		public Configuration(android.content.res.Configuration arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._Configuration4125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _fontScale4126;
		public float fontScale
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _fontScale4126);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _mcc4127;
		public int mcc
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _mcc4127);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _mnc4128;
		public int mnc
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _mnc4128);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _locale4129;
		public global::java.util.Locale locale
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _locale4129)) as java.util.Locale;
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
		internal static global::MonoJavaBridge.FieldId _screenLayout4139;
		public int screenLayout
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _screenLayout4139);
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
		internal static global::MonoJavaBridge.FieldId _touchscreen4144;
		public int touchscreen
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _touchscreen4144);
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
		internal static global::MonoJavaBridge.FieldId _keyboard4149;
		public int keyboard
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _keyboard4149);
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
		internal static global::MonoJavaBridge.FieldId _keyboardHidden4153;
		public int keyboardHidden
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _keyboardHidden4153);
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
		internal static global::MonoJavaBridge.FieldId _hardKeyboardHidden4157;
		public int hardKeyboardHidden
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _hardKeyboardHidden4157);
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
		internal static global::MonoJavaBridge.FieldId _navigation4163;
		public int navigation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _navigation4163);
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
		internal static global::MonoJavaBridge.FieldId _navigationHidden4167;
		public int navigationHidden
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _navigationHidden4167);
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
		internal static global::MonoJavaBridge.FieldId _orientation4172;
		public int orientation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _orientation4172);
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
		internal static global::MonoJavaBridge.FieldId _uiMode4182;
		public int uiMode
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _uiMode4182);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4183;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.res.Configuration.staticClass, _CREATOR4183)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.Configuration.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/Configuration"));
			global::android.content.res.Configuration._equals4110 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.res.Configuration._equals4111 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "equals", "(Landroid/content/res/Configuration;)Z");
			global::android.content.res.Configuration._toString4112 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.Configuration._hashCode4113 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "hashCode", "()I");
			global::android.content.res.Configuration._compareTo4114 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::android.content.res.Configuration._compareTo4115 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "compareTo", "(Landroid/content/res/Configuration;)I");
			global::android.content.res.Configuration._writeToParcel4116 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.res.Configuration._describeContents4117 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "describeContents", "()I");
			global::android.content.res.Configuration._readFromParcel4118 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.content.res.Configuration._setTo4119 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "setTo", "(Landroid/content/res/Configuration;)V");
			global::android.content.res.Configuration._setToDefaults4120 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "setToDefaults", "()V");
			global::android.content.res.Configuration._updateFrom4121 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "updateFrom", "(Landroid/content/res/Configuration;)I");
			global::android.content.res.Configuration._diff4122 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "diff", "(Landroid/content/res/Configuration;)I");
			global::android.content.res.Configuration._needNewResources4123 = @__env.GetStaticMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "needNewResources", "(II)Z");
			global::android.content.res.Configuration._Configuration4124 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "<init>", "()V");
			global::android.content.res.Configuration._Configuration4125 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "<init>", "(Landroid/content/res/Configuration;)V");
			global::android.content.res.Configuration._fontScale4126 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "fontScale", "F");
			global::android.content.res.Configuration._mcc4127 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "mcc", "I");
			global::android.content.res.Configuration._mnc4128 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "mnc", "I");
			global::android.content.res.Configuration._locale4129 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "locale", "Ljava/util/Locale;");
			global::android.content.res.Configuration._screenLayout4139 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "screenLayout", "I");
			global::android.content.res.Configuration._touchscreen4144 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "touchscreen", "I");
			global::android.content.res.Configuration._keyboard4149 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "keyboard", "I");
			global::android.content.res.Configuration._keyboardHidden4153 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "keyboardHidden", "I");
			global::android.content.res.Configuration._hardKeyboardHidden4157 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "hardKeyboardHidden", "I");
			global::android.content.res.Configuration._navigation4163 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "navigation", "I");
			global::android.content.res.Configuration._navigationHidden4167 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "navigationHidden", "I");
			global::android.content.res.Configuration._orientation4172 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "orientation", "I");
			global::android.content.res.Configuration._uiMode4182 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "uiMode", "I");
			global::android.content.res.Configuration._CREATOR4183 = @__env.GetStaticFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
