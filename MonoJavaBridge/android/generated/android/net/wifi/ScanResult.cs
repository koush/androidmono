namespace android.net.wifi
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScanResult : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ScanResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.wifi.ScanResult.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.wifi.ScanResult._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.wifi.ScanResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.net.wifi.ScanResult._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.wifi.ScanResult.staticClass, "describeContents", "()I", ref global::android.net.wifi.ScanResult._m2);
		}
		internal static global::MonoJavaBridge.FieldId _SSID3025;
		public global::java.lang.String SSID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _SSID3025)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _BSSID3026;
		public global::java.lang.String BSSID
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _BSSID3026)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _capabilities3027;
		public global::java.lang.String capabilities
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _capabilities3027)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _level3028;
		public int level
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _level3028);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _frequency3029;
		public int frequency
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _frequency3029);
			}
			set
			{
			}
		}
		static ScanResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.wifi.ScanResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/wifi/ScanResult"));
			global::android.net.wifi.ScanResult._SSID3025 = @__env.GetFieldIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "SSID", "Ljava/lang/String;");
			global::android.net.wifi.ScanResult._BSSID3026 = @__env.GetFieldIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "BSSID", "Ljava/lang/String;");
			global::android.net.wifi.ScanResult._capabilities3027 = @__env.GetFieldIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "capabilities", "Ljava/lang/String;");
			global::android.net.wifi.ScanResult._level3028 = @__env.GetFieldIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "level", "I");
			global::android.net.wifi.ScanResult._frequency3029 = @__env.GetFieldIDNoThrow(global::android.net.wifi.ScanResult.staticClass, "frequency", "I");
		}
		internal static void InitJNI()
		{
		}
	}
}
