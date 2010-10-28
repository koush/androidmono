namespace android.content.res
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Configuration : java.lang.Object, android.os.Parcelable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Configuration(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals4127;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.Configuration._equals4127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._equals4127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals4128;
		public bool equals(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.Configuration._equals4128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._equals4128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString4129;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.Configuration._toString4129)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._toString4129)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode4130;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._hashCode4130);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._hashCode4130);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo4131;
		public int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._compareTo4131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._compareTo4131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo4132;
		public int compareTo(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._compareTo4132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._compareTo4132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4133;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.Configuration._writeToParcel4133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._writeToParcel4133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4134;
		public int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._describeContents4134);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._describeContents4134);
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel4135;
		public void readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.Configuration._readFromParcel4135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._readFromParcel4135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.Configuration To
		{
			set
			{
				setTo(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setTo4136;
		public void setTo(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.Configuration._setTo4136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._setTo4136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setToDefaults4137;
		public void setToDefaults()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.Configuration._setToDefaults4137);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._setToDefaults4137);
		}
		internal static global::MonoJavaBridge.MethodId _updateFrom4138;
		public int updateFrom(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._updateFrom4138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._updateFrom4138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _diff4139;
		public int diff(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.Configuration._diff4139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._diff4139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _needNewResources4140;
		public static bool needNewResources(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._needNewResources4140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Configuration4141;
		public Configuration() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._Configuration4141);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Configuration4142;
		public Configuration(android.content.res.Configuration arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._Configuration4142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _fontScale4143;
		public float fontScale
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _fontScale4143);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _mcc4144;
		public int mcc
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _mcc4144);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _mnc4145;
		public int mnc
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _mnc4145);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _locale4146;
		public global::java.util.Locale locale
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetObjectField(this.JvmHandle, _locale4146)) as java.util.Locale;
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
		internal static global::MonoJavaBridge.FieldId _screenLayout4156;
		public int screenLayout
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _screenLayout4156);
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
		internal static global::MonoJavaBridge.FieldId _touchscreen4161;
		public int touchscreen
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _touchscreen4161);
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
		internal static global::MonoJavaBridge.FieldId _keyboard4166;
		public int keyboard
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _keyboard4166);
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
		internal static global::MonoJavaBridge.FieldId _keyboardHidden4170;
		public int keyboardHidden
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _keyboardHidden4170);
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
		internal static global::MonoJavaBridge.FieldId _hardKeyboardHidden4174;
		public int hardKeyboardHidden
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _hardKeyboardHidden4174);
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
		internal static global::MonoJavaBridge.FieldId _navigation4180;
		public int navigation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _navigation4180);
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
		internal static global::MonoJavaBridge.FieldId _navigationHidden4184;
		public int navigationHidden
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _navigationHidden4184);
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
		internal static global::MonoJavaBridge.FieldId _orientation4189;
		public int orientation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _orientation4189);
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
		internal static global::MonoJavaBridge.FieldId _uiMode4199;
		public int uiMode
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _uiMode4199);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4200;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.res.Configuration.staticClass, _CREATOR4200)) as android.os.Parcelable_Creator;
			}
		}
		static Configuration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.Configuration.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/Configuration"));
			global::android.content.res.Configuration._equals4127 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.res.Configuration._equals4128 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "equals", "(Landroid/content/res/Configuration;)Z");
			global::android.content.res.Configuration._toString4129 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.Configuration._hashCode4130 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "hashCode", "()I");
			global::android.content.res.Configuration._compareTo4131 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::android.content.res.Configuration._compareTo4132 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "compareTo", "(Landroid/content/res/Configuration;)I");
			global::android.content.res.Configuration._writeToParcel4133 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.res.Configuration._describeContents4134 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "describeContents", "()I");
			global::android.content.res.Configuration._readFromParcel4135 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.content.res.Configuration._setTo4136 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "setTo", "(Landroid/content/res/Configuration;)V");
			global::android.content.res.Configuration._setToDefaults4137 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "setToDefaults", "()V");
			global::android.content.res.Configuration._updateFrom4138 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "updateFrom", "(Landroid/content/res/Configuration;)I");
			global::android.content.res.Configuration._diff4139 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "diff", "(Landroid/content/res/Configuration;)I");
			global::android.content.res.Configuration._needNewResources4140 = @__env.GetStaticMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "needNewResources", "(II)Z");
			global::android.content.res.Configuration._Configuration4141 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "<init>", "()V");
			global::android.content.res.Configuration._Configuration4142 = @__env.GetMethodIDNoThrow(global::android.content.res.Configuration.staticClass, "<init>", "(Landroid/content/res/Configuration;)V");
			global::android.content.res.Configuration._fontScale4143 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "fontScale", "F");
			global::android.content.res.Configuration._mcc4144 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "mcc", "I");
			global::android.content.res.Configuration._mnc4145 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "mnc", "I");
			global::android.content.res.Configuration._locale4146 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "locale", "Ljava/util/Locale;");
			global::android.content.res.Configuration._screenLayout4156 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "screenLayout", "I");
			global::android.content.res.Configuration._touchscreen4161 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "touchscreen", "I");
			global::android.content.res.Configuration._keyboard4166 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "keyboard", "I");
			global::android.content.res.Configuration._keyboardHidden4170 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "keyboardHidden", "I");
			global::android.content.res.Configuration._hardKeyboardHidden4174 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "hardKeyboardHidden", "I");
			global::android.content.res.Configuration._navigation4180 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "navigation", "I");
			global::android.content.res.Configuration._navigationHidden4184 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "navigationHidden", "I");
			global::android.content.res.Configuration._orientation4189 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "orientation", "I");
			global::android.content.res.Configuration._uiMode4199 = @__env.GetFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "uiMode", "I");
			global::android.content.res.Configuration._CREATOR4200 = @__env.GetStaticFieldIDNoThrow(global::android.content.res.Configuration.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
