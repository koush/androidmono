namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SignalStrength : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SignalStrength(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.SignalStrength.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.telephony.SignalStrength._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.SignalStrength.staticClass, "toString", "()Ljava/lang/String;", ref global::android.telephony.SignalStrength._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, "hashCode", "()I", ref global::android.telephony.SignalStrength._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.SignalStrength.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.telephony.SignalStrength._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, "describeContents", "()I", ref global::android.telephony.SignalStrength._m4);
		}
		public new int GsmSignalStrength
		{
			get
			{
				return getGsmSignalStrength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getGsmSignalStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, "getGsmSignalStrength", "()I", ref global::android.telephony.SignalStrength._m5);
		}
		public new int GsmBitErrorRate
		{
			get
			{
				return getGsmBitErrorRate();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getGsmBitErrorRate()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, "getGsmBitErrorRate", "()I", ref global::android.telephony.SignalStrength._m6);
		}
		public new int CdmaDbm
		{
			get
			{
				return getCdmaDbm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getCdmaDbm()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, "getCdmaDbm", "()I", ref global::android.telephony.SignalStrength._m7);
		}
		public new int CdmaEcio
		{
			get
			{
				return getCdmaEcio();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getCdmaEcio()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, "getCdmaEcio", "()I", ref global::android.telephony.SignalStrength._m8);
		}
		public new int EvdoDbm
		{
			get
			{
				return getEvdoDbm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getEvdoDbm()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, "getEvdoDbm", "()I", ref global::android.telephony.SignalStrength._m9);
		}
		public new int EvdoEcio
		{
			get
			{
				return getEvdoEcio();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getEvdoEcio()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, "getEvdoEcio", "()I", ref global::android.telephony.SignalStrength._m10);
		}
		public new int EvdoSnr
		{
			get
			{
				return getEvdoSnr();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getEvdoSnr()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.SignalStrength.staticClass, "getEvdoSnr", "()I", ref global::android.telephony.SignalStrength._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool isGsm()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.SignalStrength.staticClass, "isGsm", "()Z", ref global::android.telephony.SignalStrength._m12);
		}
		static SignalStrength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.SignalStrength.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/SignalStrength"));
		}
	}
}
