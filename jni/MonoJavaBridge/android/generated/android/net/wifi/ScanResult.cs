namespace android.net.wifi
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScanResult : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ScanResult()
		{
			InitJNI();
		}
		protected ScanResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString5431;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.ScanResult._toString5431)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.ScanResult.staticClass, global::android.net.wifi.ScanResult._toString5431)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5432;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.ScanResult._writeToParcel5432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.ScanResult.staticClass, global::android.net.wifi.ScanResult._writeToParcel5432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents5433;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.ScanResult._describeContents5433);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.ScanResult.staticClass, global::android.net.wifi.ScanResult._describeContents5433);
		}
		internal static global::MonoJavaBridge.FieldId _SSID5434;
		public global::java.lang.String SSID
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _BSSID5435;
		public global::java.lang.String BSSID
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _capabilities5436;
		public global::java.lang.String capabilities
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _level5437;
		public int level
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _frequency5438;
		public int frequency
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
			global::android.net.wifi.ScanResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/ScanResult"));
			global::android.net.wifi.ScanResult._toString5431 = @__env.GetMethodIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.wifi.ScanResult._writeToParcel5432 = @__env.GetMethodIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.wifi.ScanResult._describeContents5433 = @__env.GetMethodIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "describeContents", "()I");
		}
	}
}
