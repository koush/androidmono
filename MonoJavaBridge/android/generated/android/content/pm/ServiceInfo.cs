namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ServiceInfo : android.content.pm.ComponentInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ServiceInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.ServiceInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.pm.ServiceInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ServiceInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.content.pm.ServiceInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.ServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.ServiceInfo._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.ServiceInfo.staticClass, "describeContents", "()I", ref global::android.content.pm.ServiceInfo._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ServiceInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ServiceInfo._m4.native == global::System.IntPtr.Zero)
				global::android.content.pm.ServiceInfo._m4 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._m4);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ServiceInfo(android.content.pm.ServiceInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.ServiceInfo._m5.native == global::System.IntPtr.Zero)
				global::android.content.pm.ServiceInfo._m5 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "<init>", "(Landroid/content/pm/ServiceInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _permission2126;
		public global::java.lang.String permission
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _permission2126)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2127;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ServiceInfo.staticClass, _CREATOR2127)) as android.os.Parcelable_Creator;
			}
		}
		static ServiceInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ServiceInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ServiceInfo"));
			global::android.content.pm.ServiceInfo._permission2126 = @__env.GetFieldIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "permission", "Ljava/lang/String;");
			global::android.content.pm.ServiceInfo._CREATOR2127 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
