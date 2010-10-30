namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConfigurationInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConfigurationInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.ConfigurationInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.pm.ConfigurationInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ConfigurationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.ConfigurationInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ConfigurationInfo.staticClass, "describeContents", "()I", ref global::android.content.pm.ConfigurationInfo._m2);
		}
		public new global::java.lang.String GlEsVersion
		{
			get
			{
				return getGlEsVersion();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getGlEsVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.ConfigurationInfo.staticClass, "getGlEsVersion", "()Ljava/lang/String;", ref global::android.content.pm.ConfigurationInfo._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ConfigurationInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ConfigurationInfo._m4.native == global::System.IntPtr.Zero)
				global::android.content.pm.ConfigurationInfo._m4 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._m4);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ConfigurationInfo(android.content.pm.ConfigurationInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ConfigurationInfo._m5.native == global::System.IntPtr.Zero)
				global::android.content.pm.ConfigurationInfo._m5 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "<init>", "(Landroid/content/pm/ConfigurationInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _reqTouchScreen1989;
		public int reqTouchScreen
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqTouchScreen1989);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _reqKeyboardType1990;
		public int reqKeyboardType
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqKeyboardType1990);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _reqNavigation1991;
		public int reqNavigation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqNavigation1991);
			}
			set
			{
			}
		}
		public static int INPUT_FEATURE_HARD_KEYBOARD
		{
			get
			{
				return 1;
			}
		}
		public static int INPUT_FEATURE_FIVE_WAY_NAV
		{
			get
			{
				return 2;
			}
		}
		internal static global::MonoJavaBridge.FieldId _reqInputFeatures1994;
		public int reqInputFeatures
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqInputFeatures1994);
			}
			set
			{
			}
		}
		public static int GL_ES_VERSION_UNDEFINED
		{
			get
			{
				return 0;
			}
		}
		internal static global::MonoJavaBridge.FieldId _reqGlEsVersion1996;
		public int reqGlEsVersion
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqGlEsVersion1996);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1997;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ConfigurationInfo.staticClass, _CREATOR1997)) as android.os.Parcelable_Creator;
			}
		}
		static ConfigurationInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ConfigurationInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ConfigurationInfo"));
			global::android.content.pm.ConfigurationInfo._reqTouchScreen1989 = @__env.GetFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "reqTouchScreen", "I");
			global::android.content.pm.ConfigurationInfo._reqKeyboardType1990 = @__env.GetFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "reqKeyboardType", "I");
			global::android.content.pm.ConfigurationInfo._reqNavigation1991 = @__env.GetFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "reqNavigation", "I");
			global::android.content.pm.ConfigurationInfo._reqInputFeatures1994 = @__env.GetFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "reqInputFeatures", "I");
			global::android.content.pm.ConfigurationInfo._reqGlEsVersion1996 = @__env.GetFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "reqGlEsVersion", "I");
			global::android.content.pm.ConfigurationInfo._CREATOR1997 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
