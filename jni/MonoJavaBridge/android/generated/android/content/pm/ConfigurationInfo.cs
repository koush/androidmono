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
		internal static global::MonoJavaBridge.MethodId _toString3684;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo._toString3684)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._toString3684)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3685;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo._writeToParcel3685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._writeToParcel3685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3686;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo._describeContents3686);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._describeContents3686);
		}
		public new global::java.lang.String GlEsVersion
		{
			get
			{
				return getGlEsVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlEsVersion3687;
		public virtual global::java.lang.String getGlEsVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo._getGlEsVersion3687)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._getGlEsVersion3687)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ConfigurationInfo3688;
		public ConfigurationInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._ConfigurationInfo3688);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConfigurationInfo3689;
		public ConfigurationInfo(android.content.pm.ConfigurationInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._ConfigurationInfo3689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _reqTouchScreen3690;
		public int reqTouchScreen
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqTouchScreen3690);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _reqKeyboardType3691;
		public int reqKeyboardType
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqKeyboardType3691);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _reqNavigation3692;
		public int reqNavigation
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqNavigation3692);
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
		internal static global::MonoJavaBridge.FieldId _reqInputFeatures3695;
		public int reqInputFeatures
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqInputFeatures3695);
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
		internal static global::MonoJavaBridge.FieldId _reqGlEsVersion3697;
		public int reqGlEsVersion
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqGlEsVersion3697);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3698;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ConfigurationInfo.staticClass, _CREATOR3698)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ConfigurationInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ConfigurationInfo"));
			global::android.content.pm.ConfigurationInfo._toString3684 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ConfigurationInfo._writeToParcel3685 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ConfigurationInfo._describeContents3686 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ConfigurationInfo._getGlEsVersion3687 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "getGlEsVersion", "()Ljava/lang/String;");
			global::android.content.pm.ConfigurationInfo._ConfigurationInfo3688 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ConfigurationInfo._ConfigurationInfo3689 = @__env.GetMethodIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "<init>", "(Landroid/content/pm/ConfigurationInfo;)V");
			global::android.content.pm.ConfigurationInfo._reqTouchScreen3690 = @__env.GetFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "reqTouchScreen", "I");
			global::android.content.pm.ConfigurationInfo._reqKeyboardType3691 = @__env.GetFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "reqKeyboardType", "I");
			global::android.content.pm.ConfigurationInfo._reqNavigation3692 = @__env.GetFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "reqNavigation", "I");
			global::android.content.pm.ConfigurationInfo._reqInputFeatures3695 = @__env.GetFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "reqInputFeatures", "I");
			global::android.content.pm.ConfigurationInfo._reqGlEsVersion3697 = @__env.GetFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "reqGlEsVersion", "I");
			global::android.content.pm.ConfigurationInfo._CREATOR3698 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ConfigurationInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
