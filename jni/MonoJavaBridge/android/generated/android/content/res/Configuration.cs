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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode1924;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Configuration._hashCode1924);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._hashCode1924);
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals1925;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.Configuration._equals1925, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._equals1925, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals1926;
		public bool equals(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.res.Configuration._equals1926, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._equals1926, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo1927;
		public int compareTo(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Configuration._compareTo1927, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._compareTo1927, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo1928;
		public int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Configuration._compareTo1928, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._compareTo1928, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1929;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.Configuration._toString1929));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._toString1929));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1930;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Configuration._writeToParcel1930, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._writeToParcel1930, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1931;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Configuration._describeContents1931);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._describeContents1931);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setToDefaults1932;
		public void setToDefaults() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.Configuration._setToDefaults1932);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._setToDefaults1932);
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateFrom1933;
		public int updateFrom(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Configuration._updateFrom1933, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._updateFrom1933, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _diff1934;
		public int diff(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.Configuration._diff1934, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.Configuration.staticClass, global::android.content.res.Configuration._diff1934, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _needNewResources1935;
		public static bool needNewResources(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._needNewResources1935, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Configuration1936;
		public Configuration()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._Configuration1936, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Configuration1937;
		public Configuration(android.content.res.Configuration arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.res.Configuration.staticClass, global::android.content.res.Configuration._Configuration1937, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _fontScale1938;
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
		internal static global::net.sf.jni4net.jni.FieldId _mcc1939;
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
		internal static global::net.sf.jni4net.jni.FieldId _mnc1940;
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
		internal static global::net.sf.jni4net.jni.FieldId _locale1941;
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
		internal static global::net.sf.jni4net.jni.FieldId _screenLayout1942;
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
		internal static global::net.sf.jni4net.jni.FieldId _touchscreen1943;
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
		internal static global::net.sf.jni4net.jni.FieldId _keyboard1944;
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
		internal static global::net.sf.jni4net.jni.FieldId _keyboardHidden1945;
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
		internal static global::net.sf.jni4net.jni.FieldId _hardKeyboardHidden1946;
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
		internal static global::net.sf.jni4net.jni.FieldId _navigation1947;
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
		internal static global::net.sf.jni4net.jni.FieldId _navigationHidden1948;
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
		internal static global::net.sf.jni4net.jni.FieldId _orientation1949;
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1950;
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
			global::android.content.res.Configuration._hashCode1924 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "hashCode", "()I");
			global::android.content.res.Configuration._equals1925 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.res.Configuration._equals1926 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "equals", "(Landroid/content/res/Configuration;)Z");
			global::android.content.res.Configuration._compareTo1927 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "compareTo", "(Landroid/content/res/Configuration;)I");
			global::android.content.res.Configuration._compareTo1928 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::android.content.res.Configuration._toString1929 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.Configuration._writeToParcel1930 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.res.Configuration._describeContents1931 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "describeContents", "()I");
			global::android.content.res.Configuration._setToDefaults1932 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "setToDefaults", "()V");
			global::android.content.res.Configuration._updateFrom1933 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "updateFrom", "(Landroid/content/res/Configuration;)I");
			global::android.content.res.Configuration._diff1934 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "diff", "(Landroid/content/res/Configuration;)I");
			global::android.content.res.Configuration._needNewResources1935 = @__env.GetStaticMethodID(global::android.content.res.Configuration.staticClass, "needNewResources", "(II)Z");
			global::android.content.res.Configuration._Configuration1936 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "<init>", "()V");
			global::android.content.res.Configuration._Configuration1937 = @__env.GetMethodID(global::android.content.res.Configuration.staticClass, "<init>", "(Landroid/content/res/Configuration;)V");
		}
	}
}
