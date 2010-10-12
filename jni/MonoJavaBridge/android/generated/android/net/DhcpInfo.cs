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
		internal static global::MonoJavaBridge.MethodId _toString5137;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.DhcpInfo._toString5137)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.DhcpInfo.staticClass, global::android.net.DhcpInfo._toString5137)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5138;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.DhcpInfo._writeToParcel5138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.DhcpInfo.staticClass, global::android.net.DhcpInfo._writeToParcel5138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents5139;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.DhcpInfo._describeContents5139);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.DhcpInfo.staticClass, global::android.net.DhcpInfo._describeContents5139);
		}
		internal static global::MonoJavaBridge.MethodId _DhcpInfo5140;
		public DhcpInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.DhcpInfo.staticClass, global::android.net.DhcpInfo._DhcpInfo5140);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ipAddress5141;
		public int ipAddress
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _gateway5142;
		public int gateway
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _netmask5143;
		public int netmask
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dns15144;
		public int dns1
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dns25145;
		public int dns2
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _serverAddress5146;
		public int serverAddress
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _leaseDuration5147;
		public int leaseDuration
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.DhcpInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/DhcpInfo"));
			global::android.net.DhcpInfo._toString5137 = @__env.GetMethodIDNoThrow(global::android.net.DhcpInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.DhcpInfo._writeToParcel5138 = @__env.GetMethodIDNoThrow(global::android.net.DhcpInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.DhcpInfo._describeContents5139 = @__env.GetMethodIDNoThrow(global::android.net.DhcpInfo.staticClass, "describeContents", "()I");
			global::android.net.DhcpInfo._DhcpInfo5140 = @__env.GetMethodIDNoThrow(global::android.net.DhcpInfo.staticClass, "<init>", "()V");
		}
	}
}
