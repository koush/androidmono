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
		internal static global::MonoJavaBridge.MethodId _toString7933;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.wifi.ScanResult._toString7933)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.wifi.ScanResult.staticClass, global::android.net.wifi.ScanResult._toString7933)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7934;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.wifi.ScanResult._writeToParcel7934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.wifi.ScanResult.staticClass, global::android.net.wifi.ScanResult._writeToParcel7934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents7935;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.wifi.ScanResult._describeContents7935);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.wifi.ScanResult.staticClass, global::android.net.wifi.ScanResult._describeContents7935);
		}
		internal static global::MonoJavaBridge.FieldId _SSID7936;
		public global::java.lang.String SSID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _SSID7936)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _BSSID7937;
		public global::java.lang.String BSSID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _BSSID7937)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _capabilities7938;
		public global::java.lang.String capabilities
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _capabilities7938)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _level7939;
		public int level
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _level7939);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _frequency7940;
		public int frequency
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _frequency7940);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.wifi.ScanResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/ScanResult"));
			global::android.net.wifi.ScanResult._toString7933 = @__env.GetMethodIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.wifi.ScanResult._writeToParcel7934 = @__env.GetMethodIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.wifi.ScanResult._describeContents7935 = @__env.GetMethodIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "describeContents", "()I");
			global::android.net.wifi.ScanResult._SSID7936 = @__env.GetFieldIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "SSID", "Ljava/lang/String;");
			global::android.net.wifi.ScanResult._BSSID7937 = @__env.GetFieldIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "BSSID", "Ljava/lang/String;");
			global::android.net.wifi.ScanResult._capabilities7938 = @__env.GetFieldIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "capabilities", "Ljava/lang/String;");
			global::android.net.wifi.ScanResult._level7939 = @__env.GetFieldIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "level", "I");
			global::android.net.wifi.ScanResult._frequency7940 = @__env.GetFieldIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "frequency", "I");
		}
	}
}
