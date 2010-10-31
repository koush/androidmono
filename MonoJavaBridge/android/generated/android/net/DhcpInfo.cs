namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DhcpInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DhcpInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.DhcpInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.DhcpInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.DhcpInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.net.DhcpInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.DhcpInfo.staticClass, "describeContents", "()I", ref global::android.net.DhcpInfo._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public DhcpInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.DhcpInfo._m3.native == global::System.IntPtr.Zero)
				global::android.net.DhcpInfo._m3 = @__env.GetMethodIDNoThrow(global::android.net.DhcpInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.DhcpInfo.staticClass, global::android.net.DhcpInfo._m3);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ipAddress2963;
		public int ipAddress
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _ipAddress2963);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _gateway2964;
		public int gateway
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _gateway2964);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _netmask2965;
		public int netmask
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _netmask2965);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dns12966;
		public int dns1
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _dns12966);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dns22967;
		public int dns2
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _dns22967);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _serverAddress2968;
		public int serverAddress
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _serverAddress2968);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _leaseDuration2969;
		public int leaseDuration
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _leaseDuration2969);
			}
			set
			{
			}
		}
		static DhcpInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.DhcpInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/DhcpInfo"));
			global::android.net.DhcpInfo._ipAddress2963 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "ipAddress", "I");
			global::android.net.DhcpInfo._gateway2964 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "gateway", "I");
			global::android.net.DhcpInfo._netmask2965 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "netmask", "I");
			global::android.net.DhcpInfo._dns12966 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "dns1", "I");
			global::android.net.DhcpInfo._dns22967 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "dns2", "I");
			global::android.net.DhcpInfo._serverAddress2968 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "serverAddress", "I");
			global::android.net.DhcpInfo._leaseDuration2969 = @__env.GetFieldIDNoThrow(global::android.net.DhcpInfo.staticClass, "leaseDuration", "I");
		}
	}
}
