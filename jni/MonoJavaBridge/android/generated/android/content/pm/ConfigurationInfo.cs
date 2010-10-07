namespace android.content.pm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ConfigurationInfo : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static ConfigurationInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.ConfigurationInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.pm.ConfigurationInfo(@__env);
			}
		}
		protected ConfigurationInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1799;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.ConfigurationInfo._toString1799));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._toString1799));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1800;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.ConfigurationInfo._writeToParcel1800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._writeToParcel1800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1801;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.ConfigurationInfo._describeContents1801);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._describeContents1801);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlEsVersion1802;
		public virtual global::java.lang.String getGlEsVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.ConfigurationInfo._getGlEsVersion1802));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._getGlEsVersion1802));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ConfigurationInfo1803;
		public ConfigurationInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._ConfigurationInfo1803, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ConfigurationInfo1804;
		public ConfigurationInfo(android.content.pm.ConfigurationInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.ConfigurationInfo.staticClass, global::android.content.pm.ConfigurationInfo._ConfigurationInfo1804, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _reqTouchScreen1805;
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
		internal static global::net.sf.jni4net.jni.FieldId _reqKeyboardType1806;
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
		internal static global::net.sf.jni4net.jni.FieldId _reqNavigation1807;
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
		internal static global::net.sf.jni4net.jni.FieldId _reqInputFeatures1808;
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
		internal static global::net.sf.jni4net.jni.FieldId _reqGlEsVersion1809;
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1810;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.pm.ConfigurationInfo.staticClass = @__class;
			global::android.content.pm.ConfigurationInfo._toString1799 = @__env.GetMethodID(global::android.content.pm.ConfigurationInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ConfigurationInfo._writeToParcel1800 = @__env.GetMethodID(global::android.content.pm.ConfigurationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ConfigurationInfo._describeContents1801 = @__env.GetMethodID(global::android.content.pm.ConfigurationInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ConfigurationInfo._getGlEsVersion1802 = @__env.GetMethodID(global::android.content.pm.ConfigurationInfo.staticClass, "getGlEsVersion", "()Ljava/lang/String;");
			global::android.content.pm.ConfigurationInfo._ConfigurationInfo1803 = @__env.GetMethodID(global::android.content.pm.ConfigurationInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ConfigurationInfo._ConfigurationInfo1804 = @__env.GetMethodID(global::android.content.pm.ConfigurationInfo.staticClass, "<init>", "(Landroid/content/pm/ConfigurationInfo;)V");
		}
	}
}
