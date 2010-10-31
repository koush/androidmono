namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InstrumentationInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InstrumentationInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.InstrumentationInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.pm.InstrumentationInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.InstrumentationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.InstrumentationInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.InstrumentationInfo.staticClass, "describeContents", "()I", ref global::android.content.pm.InstrumentationInfo._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public InstrumentationInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.InstrumentationInfo._m3.native == global::System.IntPtr.Zero)
				global::android.content.pm.InstrumentationInfo._m3 = @__env.GetMethodIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._m3);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public InstrumentationInfo(android.content.pm.InstrumentationInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.InstrumentationInfo._m4.native == global::System.IntPtr.Zero)
				global::android.content.pm.InstrumentationInfo._m4 = @__env.GetMethodIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "<init>", "(Landroid/content/pm/InstrumentationInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _targetPackage2004;
		public global::java.lang.String targetPackage
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _targetPackage2004)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sourceDir2005;
		public global::java.lang.String sourceDir
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _sourceDir2005)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _publicSourceDir2006;
		public global::java.lang.String publicSourceDir
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _publicSourceDir2006)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dataDir2007;
		public global::java.lang.String dataDir
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _dataDir2007)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _handleProfiling2008;
		public bool handleProfiling
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _handleProfiling2008);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _functionalTest2009;
		public bool functionalTest
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _functionalTest2009);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2010;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.InstrumentationInfo.staticClass, _CREATOR2010)) as android.os.Parcelable_Creator;
			}
		}
		static InstrumentationInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.InstrumentationInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/InstrumentationInfo"));
			global::android.content.pm.InstrumentationInfo._targetPackage2004 = @__env.GetFieldIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "targetPackage", "Ljava/lang/String;");
			global::android.content.pm.InstrumentationInfo._sourceDir2005 = @__env.GetFieldIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "sourceDir", "Ljava/lang/String;");
			global::android.content.pm.InstrumentationInfo._publicSourceDir2006 = @__env.GetFieldIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "publicSourceDir", "Ljava/lang/String;");
			global::android.content.pm.InstrumentationInfo._dataDir2007 = @__env.GetFieldIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "dataDir", "Ljava/lang/String;");
			global::android.content.pm.InstrumentationInfo._handleProfiling2008 = @__env.GetFieldIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "handleProfiling", "Z");
			global::android.content.pm.InstrumentationInfo._functionalTest2009 = @__env.GetFieldIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "functionalTest", "Z");
			global::android.content.pm.InstrumentationInfo._CREATOR2010 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
