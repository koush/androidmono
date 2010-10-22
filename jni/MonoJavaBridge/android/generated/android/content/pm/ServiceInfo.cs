namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ServiceInfo : android.content.pm.ComponentInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ServiceInfo()
		{
			InitJNI();
		}
		protected ServiceInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString4029;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ServiceInfo._toString4029)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._toString4029)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump4030;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ServiceInfo._dump4030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._dump4030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4031;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ServiceInfo._writeToParcel4031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._writeToParcel4031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4032;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ServiceInfo._describeContents4032);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._describeContents4032);
		}
		internal static global::MonoJavaBridge.MethodId _ServiceInfo4033;
		public ServiceInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._ServiceInfo4033);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServiceInfo4034;
		public ServiceInfo(android.content.pm.ServiceInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._ServiceInfo4034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _permission4035;
		public global::java.lang.String permission
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _permission4035)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4036;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.ServiceInfo.staticClass, _CREATOR4036)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.ServiceInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ServiceInfo"));
			global::android.content.pm.ServiceInfo._toString4029 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ServiceInfo._dump4030 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ServiceInfo._writeToParcel4031 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ServiceInfo._describeContents4032 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ServiceInfo._ServiceInfo4033 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ServiceInfo._ServiceInfo4034 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "<init>", "(Landroid/content/pm/ServiceInfo;)V");
			global::android.content.pm.ServiceInfo._permission4035 = @__env.GetFieldIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "permission", "Ljava/lang/String;");
			global::android.content.pm.ServiceInfo._CREATOR4036 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
