namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SignalStrength : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SignalStrength(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals11883;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.SignalStrength._equals11883.native == global::System.IntPtr.Zero)
				global::android.telephony.SignalStrength._equals11883 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._equals11883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString11884;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.SignalStrength._toString11884.native == global::System.IntPtr.Zero)
				global::android.telephony.SignalStrength._toString11884 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._toString11884) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode11885;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.SignalStrength._hashCode11885.native == global::System.IntPtr.Zero)
				global::android.telephony.SignalStrength._hashCode11885 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._hashCode11885);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel11886;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.SignalStrength._writeToParcel11886.native == global::System.IntPtr.Zero)
				global::android.telephony.SignalStrength._writeToParcel11886 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._writeToParcel11886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents11887;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.SignalStrength._describeContents11887.native == global::System.IntPtr.Zero)
				global::android.telephony.SignalStrength._describeContents11887 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._describeContents11887);
		}
		public new int GsmSignalStrength
		{
			get
			{
				return getGsmSignalStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGsmSignalStrength11888;
		public virtual int getGsmSignalStrength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.SignalStrength._getGsmSignalStrength11888.native == global::System.IntPtr.Zero)
				global::android.telephony.SignalStrength._getGsmSignalStrength11888 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getGsmSignalStrength", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getGsmSignalStrength11888);
		}
		public new int GsmBitErrorRate
		{
			get
			{
				return getGsmBitErrorRate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGsmBitErrorRate11889;
		public virtual int getGsmBitErrorRate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.SignalStrength._getGsmBitErrorRate11889.native == global::System.IntPtr.Zero)
				global::android.telephony.SignalStrength._getGsmBitErrorRate11889 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getGsmBitErrorRate", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getGsmBitErrorRate11889);
		}
		public new int CdmaDbm
		{
			get
			{
				return getCdmaDbm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCdmaDbm11890;
		public virtual int getCdmaDbm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.SignalStrength._getCdmaDbm11890.native == global::System.IntPtr.Zero)
				global::android.telephony.SignalStrength._getCdmaDbm11890 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getCdmaDbm", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getCdmaDbm11890);
		}
		public new int CdmaEcio
		{
			get
			{
				return getCdmaEcio();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCdmaEcio11891;
		public virtual int getCdmaEcio()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.SignalStrength._getCdmaEcio11891.native == global::System.IntPtr.Zero)
				global::android.telephony.SignalStrength._getCdmaEcio11891 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getCdmaEcio", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getCdmaEcio11891);
		}
		public new int EvdoDbm
		{
			get
			{
				return getEvdoDbm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEvdoDbm11892;
		public virtual int getEvdoDbm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.SignalStrength._getEvdoDbm11892.native == global::System.IntPtr.Zero)
				global::android.telephony.SignalStrength._getEvdoDbm11892 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getEvdoDbm", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getEvdoDbm11892);
		}
		public new int EvdoEcio
		{
			get
			{
				return getEvdoEcio();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEvdoEcio11893;
		public virtual int getEvdoEcio()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.SignalStrength._getEvdoEcio11893.native == global::System.IntPtr.Zero)
				global::android.telephony.SignalStrength._getEvdoEcio11893 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getEvdoEcio", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getEvdoEcio11893);
		}
		public new int EvdoSnr
		{
			get
			{
				return getEvdoSnr();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEvdoSnr11894;
		public virtual int getEvdoSnr()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.SignalStrength._getEvdoSnr11894.native == global::System.IntPtr.Zero)
				global::android.telephony.SignalStrength._getEvdoSnr11894 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getEvdoSnr", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getEvdoSnr11894);
		}
		internal static global::MonoJavaBridge.MethodId _isGsm11895;
		public virtual bool isGsm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.SignalStrength._isGsm11895.native == global::System.IntPtr.Zero)
				global::android.telephony.SignalStrength._isGsm11895 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "isGsm", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._isGsm11895);
		}
		static SignalStrength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.SignalStrength.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/SignalStrength"));
		}
		internal static void InitJNI()
		{
		}
	}
}
