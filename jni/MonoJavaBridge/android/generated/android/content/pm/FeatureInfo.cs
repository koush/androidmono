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
		internal static global::MonoJavaBridge.MethodId _toString3699;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.FeatureInfo._toString3699)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._toString3699)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3700;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.FeatureInfo._writeToParcel3700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._writeToParcel3700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3701;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.FeatureInfo._describeContents3701);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._describeContents3701);
		}
		public new global::java.lang.String GlEsVersion
		{
			get
			{
				return getGlEsVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlEsVersion3702;
		public virtual global::java.lang.String getGlEsVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.FeatureInfo._getGlEsVersion3702)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._getGlEsVersion3702)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _FeatureInfo3703;
		public FeatureInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._FeatureInfo3703);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FeatureInfo3704;
		public FeatureInfo(android.content.pm.FeatureInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._FeatureInfo3704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _name3705;
		public global::java.lang.String name
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _name3705)) as java.lang.String;
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
		internal static global::MonoJavaBridge.FieldId _reqGlEsVersion3707;
		public int reqGlEsVersion
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqGlEsVersion3707);
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
		internal static global::MonoJavaBridge.FieldId _flags3709;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags3709);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3710;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.FeatureInfo.staticClass, _CREATOR3710)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.FeatureInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/FeatureInfo"));
			global::android.content.pm.FeatureInfo._toString3699 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.FeatureInfo._writeToParcel3700 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.FeatureInfo._describeContents3701 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.FeatureInfo._getGlEsVersion3702 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "getGlEsVersion", "()Ljava/lang/String;");
			global::android.content.pm.FeatureInfo._FeatureInfo3703 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "<init>", "()V");
			global::android.content.pm.FeatureInfo._FeatureInfo3704 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "<init>", "(Landroid/content/pm/FeatureInfo;)V");
			global::android.content.pm.FeatureInfo._name3705 = @__env.GetFieldIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "name", "Ljava/lang/String;");
			global::android.content.pm.FeatureInfo._reqGlEsVersion3707 = @__env.GetFieldIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "reqGlEsVersion", "I");
			global::android.content.pm.FeatureInfo._flags3709 = @__env.GetFieldIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "flags", "I");
			global::android.content.pm.FeatureInfo._CREATOR3710 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
