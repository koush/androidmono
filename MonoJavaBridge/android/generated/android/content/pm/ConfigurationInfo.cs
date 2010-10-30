namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConfigurationInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConfigurationInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString3701;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._toString3701)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3702;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._writeToParcel3702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3703;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._describeContents3703);
		}
		public new global::java.lang.String GlEsVersion
		{
			get
			{
				return getGlEsVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlEsVersion3704;
		public virtual global::java.lang.String getGlEsVersion()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._getGlEsVersion3704)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ConfigurationInfo3705;
		public ConfigurationInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._ConfigurationInfo3705);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConfigurationInfo3706;
		public ConfigurationInfo(android.content.pm.ConfigurationInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._ConfigurationInfo3706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _reqTouchScreen3707;
		public int reqTouchScreen
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqTouchScreen3707);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _reqKeyboardType3708;
		public int reqKeyboardType
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqKeyboardType3708);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _reqNavigation3709;
		public int reqNavigation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqNavigation3709);
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
		internal static global::MonoJavaBridge.FieldId _reqInputFeatures3712;
		public int reqInputFeatures
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqInputFeatures3712);
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
		internal static global::MonoJavaBridge.FieldId _reqGlEsVersion3714;
		public int reqGlEsVersion
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqGlEsVersion3714);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3715;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ConfigurationInfo.staticClass, _CREATOR3715)) as android.os.Parcelable_Creator;
			}
		}
		static ConfigurationInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ConfigurationInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ConfigurationInfo"));
			global::android.content.pm.ConfigurationInfo._toString3701 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ConfigurationInfo._writeToParcel3702 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ConfigurationInfo._describeContents3703 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ConfigurationInfo._getGlEsVersion3704 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "getGlEsVersion", "()Ljava/lang/String;");
			global::android.content.pm.ConfigurationInfo._ConfigurationInfo3705 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ConfigurationInfo._ConfigurationInfo3706 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "<init>", "(Landroid/content/pm/ConfigurationInfo;)V");
			global::android.content.pm.ConfigurationInfo._reqTouchScreen3707 = @__env.GetFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "reqTouchScreen", "I");
			global::android.content.pm.ConfigurationInfo._reqKeyboardType3708 = @__env.GetFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "reqKeyboardType", "I");
			global::android.content.pm.ConfigurationInfo._reqNavigation3709 = @__env.GetFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "reqNavigation", "I");
			global::android.content.pm.ConfigurationInfo._reqInputFeatures3712 = @__env.GetFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "reqInputFeatures", "I");
			global::android.content.pm.ConfigurationInfo._reqGlEsVersion3714 = @__env.GetFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "reqGlEsVersion", "I");
			global::android.content.pm.ConfigurationInfo._CREATOR3715 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
