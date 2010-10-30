namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DhcpInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DhcpInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString7648;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.DhcpInfo._toString7648.native == global::System.IntPtr.Zero)
				global::android.net.DhcpInfo._toString7648 = @__env.GetMethodIDNoThrow(global::android.net.DhcpInfo.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.DhcpInfo.staticClass, global::android.net.DhcpInfo._toString7648) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7649;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.DhcpInfo._writeToParcel7649.native == global::System.IntPtr.Zero)
				global::android.net.DhcpInfo._writeToParcel7649 = @__env.GetMethodIDNoThrow(global::android.net.DhcpInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.DhcpInfo.staticClass, global::android.net.DhcpInfo._writeToParcel7649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents7650;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.DhcpInfo._describeContents7650.native == global::System.IntPtr.Zero)
				global::android.net.DhcpInfo._describeContents7650 = @__env.GetMethodIDNoThrow(global::android.net.DhcpInfo.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.DhcpInfo.staticClass, global::android.net.DhcpInfo._describeContents7650);
		}
		internal static global::MonoJavaBridge.MethodId _DhcpInfo7651;
		public DhcpInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.DhcpInfo._DhcpInfo7651.native == global::System.IntPtr.Zero)
				global::android.net.DhcpInfo._DhcpInfo7651 = @__env.GetMethodIDNoThrow(global::android.net.DhcpInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.DhcpInfo.staticClass, global::android.net.DhcpInfo._DhcpInfo7651);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ipAddress7652;
		public int ipAddress
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _ipAddress7652);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _gateway7653;
		public int gateway
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _gateway7653);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _netmask7654;
		public int netmask
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _netmask7654);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dns17655;
		public int dns1
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _dns17655);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dns27656;
		public int dns2
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _dns27656);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _serverAddress7657;
		public int serverAddress
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _serverAddress7657);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _leaseDuration7658;
		public int leaseDuration
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _leaseDuration7658);
			}
			set
			{
			}
		}
		static DhcpInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.DhcpInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/DhcpInfo"));
			global::android.net.DhcpInfo._ipAddress7652 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "ipAddress", "I");
			global::android.net.DhcpInfo._gateway7653 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "gateway", "I");
			global::android.net.DhcpInfo._netmask7654 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "netmask", "I");
			global::android.net.DhcpInfo._dns17655 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "dns1", "I");
			global::android.net.DhcpInfo._dns27656 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "dns2", "I");
			global::android.net.DhcpInfo._serverAddress7657 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "serverAddress", "I");
			global::android.net.DhcpInfo._leaseDuration7658 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "leaseDuration", "I");
		}
		internal static void InitJNI()
		{
		}
	}
}
