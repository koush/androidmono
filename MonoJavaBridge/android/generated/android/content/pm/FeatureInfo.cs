namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FeatureInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FeatureInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.FeatureInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.pm.FeatureInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.FeatureInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.FeatureInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.FeatureInfo.staticClass, "describeContents", "()I", ref global::android.content.pm.FeatureInfo._m2);
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.FeatureInfo.staticClass, "getGlEsVersion", "()Ljava/lang/String;", ref global::android.content.pm.FeatureInfo._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public FeatureInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.FeatureInfo._m4.native == global::System.IntPtr.Zero)
				global::android.content.pm.FeatureInfo._m4 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._m4);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public FeatureInfo(android.content.pm.FeatureInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.FeatureInfo._m5.native == global::System.IntPtr.Zero)
				global::android.content.pm.FeatureInfo._m5 = @__env.GetMethodIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "<init>", "(Landroid/content/pm/FeatureInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.FeatureInfo.staticClass, global::android.content.pm.FeatureInfo._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _name1998;
		public global::java.lang.String name
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _name1998)) as java.lang.String;
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
		internal static global::MonoJavaBridge.FieldId _reqGlEsVersion2000;
		public int reqGlEsVersion
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _reqGlEsVersion2000);
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
		internal static global::MonoJavaBridge.FieldId _flags2002;
		public int flags
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _flags2002);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2003;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.FeatureInfo.staticClass, _CREATOR2003)) as android.os.Parcelable_Creator;
			}
		}
		static FeatureInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.FeatureInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/FeatureInfo"));
			global::android.content.pm.FeatureInfo._name1998 = @__env.GetFieldIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "name", "Ljava/lang/String;");
			global::android.content.pm.FeatureInfo._reqGlEsVersion2000 = @__env.GetFieldIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "reqGlEsVersion", "I");
			global::android.content.pm.FeatureInfo._flags2002 = @__env.GetFieldIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "flags", "I");
			global::android.content.pm.FeatureInfo._CREATOR2003 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.FeatureInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
