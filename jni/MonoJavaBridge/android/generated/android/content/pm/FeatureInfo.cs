namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FeatureInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FeatureInfo()
		{
			InitJNI();
		}
		protected FeatureInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString1905;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.FeatureInfo._toString1905)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._toString1905)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1906;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.FeatureInfo._writeToParcel1906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._writeToParcel1906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1907;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.FeatureInfo._describeContents1907);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._describeContents1907);
		}
		internal static global::MonoJavaBridge.MethodId _getGlEsVersion1908;
		public virtual global::java.lang.String getGlEsVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.FeatureInfo._getGlEsVersion1908)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._getGlEsVersion1908)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _FeatureInfo1909;
		public FeatureInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._FeatureInfo1909);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FeatureInfo1910;
		public FeatureInfo(android.content.pm.FeatureInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._FeatureInfo1910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _name1911;
		public global::java.lang.String name
		{
			get
			{
				return default(global::java.lang.String);
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
		internal static global::MonoJavaBridge.FieldId _reqGlEsVersion1912;
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
		public static int FLAG_REQUIRED
		{
			get
			{
				return 1;
			}
		}
		internal static global::MonoJavaBridge.FieldId _flags1913;
		public int flags
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1914;
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
			global::android.content.pm.FeatureInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/FeatureInfo"));
			global::android.content.pm.FeatureInfo._toString1905 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.FeatureInfo._writeToParcel1906 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.FeatureInfo._describeContents1907 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.FeatureInfo._getGlEsVersion1908 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "getGlEsVersion", "()Ljava/lang/String;");
			global::android.content.pm.FeatureInfo._FeatureInfo1909 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "<init>", "()V");
			global::android.content.pm.FeatureInfo._FeatureInfo1910 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "<init>", "(Landroid/content/pm/FeatureInfo;)V");
		}
	}
}
