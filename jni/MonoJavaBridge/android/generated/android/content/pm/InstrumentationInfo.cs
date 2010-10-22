namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InstrumentationInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InstrumentationInfo()
		{
			InitJNI();
		}
		protected InstrumentationInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString3711;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.InstrumentationInfo._toString3711)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._toString3711)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3712;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.InstrumentationInfo._writeToParcel3712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._writeToParcel3712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3713;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.InstrumentationInfo._describeContents3713);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._describeContents3713);
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationInfo3714;
		public InstrumentationInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._InstrumentationInfo3714);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationInfo3715;
		public InstrumentationInfo(android.content.pm.InstrumentationInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._InstrumentationInfo3715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _targetPackage3716;
		public global::java.lang.String targetPackage
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _targetPackage3716)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sourceDir3717;
		public global::java.lang.String sourceDir
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _sourceDir3717)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _publicSourceDir3718;
		public global::java.lang.String publicSourceDir
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _publicSourceDir3718)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dataDir3719;
		public global::java.lang.String dataDir
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _dataDir3719)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _handleProfiling3720;
		public bool handleProfiling
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _handleProfiling3720);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _functionalTest3721;
		public bool functionalTest
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _functionalTest3721);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3722;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.InstrumentationInfo.staticClass, _CREATOR3722)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.InstrumentationInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/InstrumentationInfo"));
			global::android.content.pm.InstrumentationInfo._toString3711 = @__env.GetMethodIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.InstrumentationInfo._writeToParcel3712 = @__env.GetMethodIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.InstrumentationInfo._describeContents3713 = @__env.GetMethodIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.InstrumentationInfo._InstrumentationInfo3714 = @__env.GetMethodIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "<init>", "()V");
			global::android.content.pm.InstrumentationInfo._InstrumentationInfo3715 = @__env.GetMethodIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "<init>", "(Landroid/content/pm/InstrumentationInfo;)V");
			global::android.content.pm.InstrumentationInfo._targetPackage3716 = @__env.GetFieldIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "targetPackage", "Ljava/lang/String;");
			global::android.content.pm.InstrumentationInfo._sourceDir3717 = @__env.GetFieldIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "sourceDir", "Ljava/lang/String;");
			global::android.content.pm.InstrumentationInfo._publicSourceDir3718 = @__env.GetFieldIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "publicSourceDir", "Ljava/lang/String;");
			global::android.content.pm.InstrumentationInfo._dataDir3719 = @__env.GetFieldIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "dataDir", "Ljava/lang/String;");
			global::android.content.pm.InstrumentationInfo._handleProfiling3720 = @__env.GetFieldIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "handleProfiling", "Z");
			global::android.content.pm.InstrumentationInfo._functionalTest3721 = @__env.GetFieldIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "functionalTest", "Z");
			global::android.content.pm.InstrumentationInfo._CREATOR3722 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
