namespace android.content.res
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class Configuration : java.lang.Object, android.os.Parcelable, java.lang.Comparable
	{
		internal static global::java.lang.Class staticClass;
		static Configuration()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.res.Configuration), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.res.Configuration(@__env);
			}
		}
		internal Configuration(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals2102;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.Configuration._equals2102, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._equals2102, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals2103;
		public bool equals(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.Configuration._equals2103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._equals2103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString2104;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Configuration._toString2104));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._toString2104));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode2105;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Configuration._hashCode2105);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._hashCode2105);
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo2106;
		public int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Configuration._compareTo2106, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._compareTo2106, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo2107;
		public int compareTo(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Configuration._compareTo2107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._compareTo2107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel2108;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Configuration._writeToParcel2108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._writeToParcel2108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents2109;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Configuration._describeContents2109);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._describeContents2109);
		}
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel2110;
		public void readFromParcel(android.os.Parcel arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Configuration._readFromParcel2110, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._readFromParcel2110, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTo2111;
		public void setTo(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Configuration._setTo2111, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._setTo2111, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setToDefaults2112;
		public void setToDefaults() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Configuration._setToDefaults2112);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._setToDefaults2112);
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateFrom2113;
		public int updateFrom(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Configuration._updateFrom2113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._updateFrom2113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _diff2114;
		public int diff(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Configuration._diff2114, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._diff2114, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _needNewResources2115;
		public static bool needNewResources(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._needNewResources2115, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Configuration2116;
		public Configuration()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._Configuration2116, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Configuration2117;
		public Configuration(android.content.res.Configuration arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._Configuration2117, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _fontScale2118;
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
		internal static global::net.sf.jni4net.jni.FieldId _mcc2119;
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
		internal static global::net.sf.jni4net.jni.FieldId _mnc2120;
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
		internal static global::net.sf.jni4net.jni.FieldId _locale2121;
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
		internal static global::net.sf.jni4net.jni.FieldId _screenLayout2122;
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
		internal static global::net.sf.jni4net.jni.FieldId _touchscreen2123;
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
		internal static global::net.sf.jni4net.jni.FieldId _keyboard2124;
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
		internal static global::net.sf.jni4net.jni.FieldId _keyboardHidden2125;
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
		internal static global::net.sf.jni4net.jni.FieldId _hardKeyboardHidden2126;
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
		internal static global::net.sf.jni4net.jni.FieldId _navigation2127;
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
		internal static global::net.sf.jni4net.jni.FieldId _navigationHidden2128;
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
		internal static global::net.sf.jni4net.jni.FieldId _orientation2129;
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
		internal static global::net.sf.jni4net.jni.FieldId _uiMode2130;
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR2131;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.res.Configuration.staticClass = @__class;
			global::android.content.res.Configuration._equals2102 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.res.Configuration._equals2103 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "equals", "(Landroid/content/res/Configuration;)Z");
			global::android.content.res.Configuration._toString2104 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.Configuration._hashCode2105 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "hashCode", "()I");
			global::android.content.res.Configuration._compareTo2106 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::android.content.res.Configuration._compareTo2107 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "compareTo", "(Landroid/content/res/Configuration;)I");
			global::android.content.res.Configuration._writeToParcel2108 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.res.Configuration._describeContents2109 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "describeContents", "()I");
			global::android.content.res.Configuration._readFromParcel2110 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.content.res.Configuration._setTo2111 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "setTo", "(Landroid/content/res/Configuration;)V");
			global::android.content.res.Configuration._setToDefaults2112 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "setToDefaults", "()V");
			global::android.content.res.Configuration._updateFrom2113 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "updateFrom", "(Landroid/content/res/Configuration;)I");
			global::android.content.res.Configuration._diff2114 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "diff", "(Landroid/content/res/Configuration;)I");
			global::android.content.res.Configuration._needNewResources2115 = @__env.GetStaticMethodID(global::android.content.res.Configuration.staticClass, "needNewResources", "(II)Z");
			global::android.content.res.Configuration._Configuration2116 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "<init>", "()V");
			global::android.content.res.Configuration._Configuration2117 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "<init>", "(Landroid/content/res/Configuration;)V");
		}
	}
}
