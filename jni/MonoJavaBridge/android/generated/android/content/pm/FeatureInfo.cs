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
		internal static global::MonoJavaBridge.MethodId _toString3716;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.FeatureInfo._toString3716)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._toString3716)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3717;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.FeatureInfo._writeToParcel3717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._writeToParcel3717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3718;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.FeatureInfo._describeContents3718);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._describeContents3718);
		}
		public new global::java.lang.String GlEsVersion
		{
			get
			{
				return getGlEsVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlEsVersion3719;
		public virtual global::java.lang.String getGlEsVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.FeatureInfo._getGlEsVersion3719)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._getGlEsVersion3719)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _FeatureInfo3720;
		public FeatureInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._FeatureInfo3720);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FeatureInfo3721;
		public FeatureInfo(android.content.pm.FeatureInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._FeatureInfo3721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _name3722;
		public global::java.lang.String name
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _name3722)) as java.lang.String;
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
		internal static global::MonoJavaBridge.FieldId _reqGlEsVersion3724;
		public int reqGlEsVersion
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqGlEsVersion3724);
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
		internal static global::MonoJavaBridge.FieldId _flags3726;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags3726);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3727;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.FeatureInfo.staticClass, _CREATOR3727)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.FeatureInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/FeatureInfo"));
			global::android.content.pm.FeatureInfo._toString3716 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.FeatureInfo._writeToParcel3717 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.FeatureInfo._describeContents3718 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.FeatureInfo._getGlEsVersion3719 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "getGlEsVersion", "()Ljava/lang/String;");
			global::android.content.pm.FeatureInfo._FeatureInfo3720 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "<init>", "()V");
			global::android.content.pm.FeatureInfo._FeatureInfo3721 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "<init>", "(Landroid/content/pm/FeatureInfo;)V");
			global::android.content.pm.FeatureInfo._name3722 = @__env.GetFieldIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "name", "Ljava/lang/String;");
			global::android.content.pm.FeatureInfo._reqGlEsVersion3724 = @__env.GetFieldIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "reqGlEsVersion", "I");
			global::android.content.pm.FeatureInfo._flags3726 = @__env.GetFieldIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "flags", "I");
			global::android.content.pm.FeatureInfo._CREATOR3727 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
