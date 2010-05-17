namespace android.net.wifi 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ScanResult : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static ScanResult() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.wifi.ScanResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.wifi.ScanResult(@__env); 
			} 
		} 
		protected ScanResult(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString4600; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.ScanResult)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString4600)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.wifi.ScanResult.staticClass, _toString4600)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4601; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.ScanResult)) 
				@__env.CallVoidMethod(this, _writeToParcel4601, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.wifi.ScanResult.staticClass, _writeToParcel4601, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4602; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.wifi.ScanResult)) 
				return @__env.CallIntMethod(this, _describeContents4602); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.wifi.ScanResult.staticClass, _describeContents4602); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _SSID4603; 
		public java.lang.String SSID
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _BSSID4604; 
		public java.lang.String BSSID
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _capabilities4605; 
		public java.lang.String capabilities
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _level4606; 
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
		internal static global::net.sf.jni4net.jni.FieldId _frequency4607; 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.wifi.ScanResult.staticClass = @__class; 
			global::android.net.wifi.ScanResult._toString4600 = @__env.GetMethodID(global::android.net.wifi.ScanResult.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.wifi.ScanResult._writeToParcel4601 = @__env.GetMethodID(global::android.net.wifi.ScanResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.net.wifi.ScanResult._describeContents4602 = @__env.GetMethodID(global::android.net.wifi.ScanResult.staticClass, "describeContents", "()I"); 
		} 
	} 
} 
