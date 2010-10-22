namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DhcpInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DhcpInfo()
		{
			InitJNI();
		}
		protected DhcpInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString7609;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.DhcpInfo._toString7609)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.DhcpInfo.staticClass, global::android.net.DhcpInfo._toString7609)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7610;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.DhcpInfo._writeToParcel7610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.DhcpInfo.staticClass, global::android.net.DhcpInfo._writeToParcel7610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents7611;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.DhcpInfo._describeContents7611);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.DhcpInfo.staticClass, global::android.net.DhcpInfo._describeContents7611);
		}
		internal static global::MonoJavaBridge.MethodId _DhcpInfo7612;
		public DhcpInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.DhcpInfo.staticClass, global::android.net.DhcpInfo._DhcpInfo7612);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ipAddress7613;
		public int ipAddress
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _ipAddress7613);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _gateway7614;
		public int gateway
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _gateway7614);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _netmask7615;
		public int netmask
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _netmask7615);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dns17616;
		public int dns1
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _dns17616);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dns27617;
		public int dns2
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _dns27617);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _serverAddress7618;
		public int serverAddress
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _serverAddress7618);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _leaseDuration7619;
		public int leaseDuration
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _leaseDuration7619);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.DhcpInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/DhcpInfo"));
			global::android.net.DhcpInfo._toString7609 = @__env.GetMethodIDNoThrow(global::android.net.DhcpInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.DhcpInfo._writeToParcel7610 = @__env.GetMethodIDNoThrow(global::android.net.DhcpInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.DhcpInfo._describeContents7611 = @__env.GetMethodIDNoThrow(global::android.net.DhcpInfo.staticClass, "describeContents", "()I");
			global::android.net.DhcpInfo._DhcpInfo7612 = @__env.GetMethodIDNoThrow(global::android.net.DhcpInfo.staticClass, "<init>", "()V");
			global::android.net.DhcpInfo._ipAddress7613 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "ipAddress", "I");
			global::android.net.DhcpInfo._gateway7614 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "gateway", "I");
			global::android.net.DhcpInfo._netmask7615 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "netmask", "I");
			global::android.net.DhcpInfo._dns17616 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "dns1", "I");
			global::android.net.DhcpInfo._dns27617 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "dns2", "I");
			global::android.net.DhcpInfo._serverAddress7618 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "serverAddress", "I");
			global::android.net.DhcpInfo._leaseDuration7619 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "leaseDuration", "I");
		}
	}
}
