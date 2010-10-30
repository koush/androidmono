namespace android.net.wifi
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScanResult : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ScanResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString7973;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.ScanResult._toString7973.native == global::System.IntPtr.Zero)
				global::android.net.wifi.ScanResult._toString7973 = @__env.GetMethodIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.ScanResult.staticClass, global::android.net.wifi.ScanResult._toString7973) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7974;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.ScanResult._writeToParcel7974.native == global::System.IntPtr.Zero)
				global::android.net.wifi.ScanResult._writeToParcel7974 = @__env.GetMethodIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.ScanResult.staticClass, global::android.net.wifi.ScanResult._writeToParcel7974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents7975;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.wifi.ScanResult._describeContents7975.native == global::System.IntPtr.Zero)
				global::android.net.wifi.ScanResult._describeContents7975 = @__env.GetMethodIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.ScanResult.staticClass, global::android.net.wifi.ScanResult._describeContents7975);
		}
		internal static global::MonoJavaBridge.FieldId _SSID7976;
		public global::java.lang.String SSID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _SSID7976)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _BSSID7977;
		public global::java.lang.String BSSID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _BSSID7977)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _capabilities7978;
		public global::java.lang.String capabilities
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _capabilities7978)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _level7979;
		public int level
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _level7979);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _frequency7980;
		public int frequency
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _frequency7980);
			}
			set
			{
			}
		}
		static ScanResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.wifi.ScanResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/ScanResult"));
			global::android.net.wifi.ScanResult._SSID7976 = @__env.GetFieldIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "SSID", "Ljava/lang/String;");
			global::android.net.wifi.ScanResult._BSSID7977 = @__env.GetFieldIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "BSSID", "Ljava/lang/String;");
			global::android.net.wifi.ScanResult._capabilities7978 = @__env.GetFieldIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "capabilities", "Ljava/lang/String;");
			global::android.net.wifi.ScanResult._level7979 = @__env.GetFieldIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "level", "I");
			global::android.net.wifi.ScanResult._frequency7980 = @__env.GetFieldIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "frequency", "I");
		}
		internal static void InitJNI()
		{
		}
	}
}
