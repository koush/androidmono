namespace android.content.pm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class InstrumentationInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{
		internal new static global::java.lang.Class staticClass;
		static InstrumentationInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.InstrumentationInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.pm.InstrumentationInfo(@__env);
			}
		}
		protected InstrumentationInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1821;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.InstrumentationInfo._toString1821));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._toString1821));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1822;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.InstrumentationInfo._writeToParcel1822, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._writeToParcel1822, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1823;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.InstrumentationInfo._describeContents1823);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._describeContents1823);
		}
		internal static global::net.sf.jni4net.jni.MethodId _InstrumentationInfo1824;
		public InstrumentationInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._InstrumentationInfo1824, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _InstrumentationInfo1825;
		public InstrumentationInfo(android.content.pm.InstrumentationInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.InstrumentationInfo.staticClass, global::android.content.pm.InstrumentationInfo._InstrumentationInfo1825, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _targetPackage1826;
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
		internal static global::net.sf.jni4net.jni.FieldId _sourceDir1827;
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
		internal static global::net.sf.jni4net.jni.FieldId _publicSourceDir1828;
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
		internal static global::net.sf.jni4net.jni.FieldId _dataDir1829;
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
		internal static global::net.sf.jni4net.jni.FieldId _handleProfiling1830;
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
		internal static global::net.sf.jni4net.jni.FieldId _functionalTest1831;
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1832;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.pm.InstrumentationInfo.staticClass = @__class;
			global::android.content.pm.InstrumentationInfo._toString1821 = @__env.GetMethodID(global::android.content.pm.InstrumentationInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.InstrumentationInfo._writeToParcel1822 = @__env.GetMethodID(global::android.content.pm.InstrumentationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.InstrumentationInfo._describeContents1823 = @__env.GetMethodID(global::android.content.pm.InstrumentationInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.InstrumentationInfo._InstrumentationInfo1824 = @__env.GetMethodID(global::android.content.pm.InstrumentationInfo.staticClass, "<init>", "()V");
			global::android.content.pm.InstrumentationInfo._InstrumentationInfo1825 = @__env.GetMethodID(global::android.content.pm.InstrumentationInfo.staticClass, "<init>", "(Landroid/content/pm/InstrumentationInfo;)V");
		}
	}
}
