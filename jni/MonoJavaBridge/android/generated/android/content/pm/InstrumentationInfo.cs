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
		internal static global::MonoJavaBridge.MethodId _toString1915;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.InstrumentationInfo._toString1915)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._toString1915)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1916;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.InstrumentationInfo._writeToParcel1916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._writeToParcel1916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1917;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.InstrumentationInfo._describeContents1917);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._describeContents1917);
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationInfo1918;
		public InstrumentationInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._InstrumentationInfo1918);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationInfo1919;
		public InstrumentationInfo(android.content.pm.InstrumentationInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._InstrumentationInfo1919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _targetPackage1920;
		public global::java.lang.String targetPackage
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _sourceDir1921;
		public global::java.lang.String sourceDir
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _publicSourceDir1922;
		public global::java.lang.String publicSourceDir
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dataDir1923;
		public global::java.lang.String dataDir
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _handleProfiling1924;
		public bool handleProfiling
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _functionalTest1925;
		public bool functionalTest
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1926;
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
			global::android.content.pm.InstrumentationInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/InstrumentationInfo"));
			global::android.content.pm.InstrumentationInfo._toString1915 = @__env.GetMethodIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.InstrumentationInfo._writeToParcel1916 = @__env.GetMethodIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.InstrumentationInfo._describeContents1917 = @__env.GetMethodIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.InstrumentationInfo._InstrumentationInfo1918 = @__env.GetMethodIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "<init>", "()V");
			global::android.content.pm.InstrumentationInfo._InstrumentationInfo1919 = @__env.GetMethodIDNoThrow(global::android.content.pm.InstrumentationInfo.staticClass, "<init>", "(Landroid/content/pm/InstrumentationInfo;)V");
		}
	}
}
