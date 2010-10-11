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
		internal static global::MonoJavaBridge.MethodId _toString2180;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.ServiceInfo._toString2180)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._toString2180)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump2181;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ServiceInfo._dump2181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._dump2181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2182;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.ServiceInfo._writeToParcel2182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._writeToParcel2182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2183;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.ServiceInfo._describeContents2183);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._describeContents2183);
		}
		internal static global::MonoJavaBridge.MethodId _ServiceInfo2184;
		public ServiceInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._ServiceInfo2184);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServiceInfo2185;
		public ServiceInfo(android.content.pm.ServiceInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.ServiceInfo.staticClass, global::android.content.pm.ServiceInfo._ServiceInfo2185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _permission2186;
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
		internal static global::MonoJavaBridge.FieldId _CREATOR2187;
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
			global::android.content.pm.ServiceInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/ServiceInfo"));
			global::android.content.pm.ServiceInfo._toString2180 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.ServiceInfo._dump2181 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.content.pm.ServiceInfo._writeToParcel2182 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.ServiceInfo._describeContents2183 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.ServiceInfo._ServiceInfo2184 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "<init>", "()V");
			global::android.content.pm.ServiceInfo._ServiceInfo2185 = @__env.GetMethodIDNoThrow(global::android.content.pm.ServiceInfo.staticClass, "<init>", "(Landroid/content/pm/ServiceInfo;)V");
		}
	}
}
