namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConfigurationInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConfigurationInfo()
		{
			InitJNI();
		}
		protected ConfigurationInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString1893;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo._toString1893)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._toString1893)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1894;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo._writeToParcel1894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._writeToParcel1894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1895;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo._describeContents1895);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._describeContents1895);
		}
		public new global::java.lang.String GlEsVersion
		{
			get
			{
				return getGlEsVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlEsVersion1896;
		public virtual global::java.lang.String getGlEsVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo._getGlEsVersion1896)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._getGlEsVersion1896)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ConfigurationInfo1897;
		public ConfigurationInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._ConfigurationInfo1897);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConfigurationInfo1898;
		public ConfigurationInfo(android.content.pm.ConfigurationInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._ConfigurationInfo1898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _reqTouchScreen1899;
		public int reqTouchScreen
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _reqKeyboardType1900;
		public int reqKeyboardType
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _reqNavigation1901;
		public int reqNavigation
		{
			get
			{
				return default(int);
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
		internal static global::MonoJavaBridge.FieldId _reqInputFeatures1902;
		public int reqInputFeatures
		{
			get
			{
				return default(int);
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
		internal static global::MonoJavaBridge.FieldId _reqGlEsVersion1903;
		public int reqGlEsVersion
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1904;
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
			global::android.content.pm.ConfigurationInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ConfigurationInfo"));
			global::android.content.pm.ConfigurationInfo._toString1893 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ConfigurationInfo._writeToParcel1894 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ConfigurationInfo._describeContents1895 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ConfigurationInfo._getGlEsVersion1896 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "getGlEsVersion", "()Ljava/lang/String;");
			global::android.content.pm.ConfigurationInfo._ConfigurationInfo1897 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ConfigurationInfo._ConfigurationInfo1898 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "<init>", "(Landroid/content/pm/ConfigurationInfo;)V");
		}
	}
}
