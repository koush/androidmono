namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ServiceInfo : android.content.pm.ComponentInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ServiceInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString4046;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ServiceInfo._toString4046)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._toString4046)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump4047;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ServiceInfo._dump4047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._dump4047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4048;
		public override void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ServiceInfo._writeToParcel4048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._writeToParcel4048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4049;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ServiceInfo._describeContents4049);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._describeContents4049);
		}
		internal static global::MonoJavaBridge.MethodId _ServiceInfo4050;
		public ServiceInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._ServiceInfo4050);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServiceInfo4051;
		public ServiceInfo(android.content.pm.ServiceInfo arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._ServiceInfo4051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _permission4052;
		public global::java.lang.String permission
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _permission4052)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4053;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ServiceInfo.staticClass, _CREATOR4053)) as android.os.Parcelable_Creator;
			}
		}
		static ServiceInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ServiceInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ServiceInfo"));
			global::android.content.pm.ServiceInfo._toString4046 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ServiceInfo._dump4047 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ServiceInfo._writeToParcel4048 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ServiceInfo._describeContents4049 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ServiceInfo._ServiceInfo4050 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ServiceInfo._ServiceInfo4051 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "<init>", "(Landroid/content/pm/ServiceInfo;)V");
			global::android.content.pm.ServiceInfo._permission4052 = @__env.GetFieldIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "permission", "Ljava/lang/String;");
			global::android.content.pm.ServiceInfo._CREATOR4053 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
