namespace android.content.pm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ServiceInfo : android.content.pm.ComponentInfo, android.os.Parcelable
	{
		internal new static global::java.lang.Class staticClass;
		static ServiceInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.ServiceInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.pm.ServiceInfo(@__env);
			}
		}
		protected ServiceInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1848;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.ServiceInfo._toString1848));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._toString1848));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump1849;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.ServiceInfo._dump1849, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._dump1849, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1850;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.ServiceInfo._writeToParcel1850, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._writeToParcel1850, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1851;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.ServiceInfo._describeContents1851);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._describeContents1851);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ServiceInfo1852;
		public ServiceInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._ServiceInfo1852, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ServiceInfo1853;
		public ServiceInfo(android.content.pm.ServiceInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._ServiceInfo1853, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _permission1854;
		public global::java.lang.String permission
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1855;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.pm.ServiceInfo.staticClass = @__class;
			global::android.content.pm.ServiceInfo._toString1848 = @__env.GetMethodID(global::android.content.pm.ServiceInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ServiceInfo._dump1849 = @__env.GetMethodID(global::android.content.pm.ServiceInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ServiceInfo._writeToParcel1850 = @__env.GetMethodID(global::android.content.pm.ServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ServiceInfo._describeContents1851 = @__env.GetMethodID(global::android.content.pm.ServiceInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ServiceInfo._ServiceInfo1852 = @__env.GetMethodID(global::android.content.pm.ServiceInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ServiceInfo._ServiceInfo1853 = @__env.GetMethodID(global::android.content.pm.ServiceInfo.staticClass, "<init>", "(Landroid/content/pm/ServiceInfo;)V");
		}
	}
}
