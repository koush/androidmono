namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SignalStrength : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SignalStrength()
		{
			InitJNI();
		}
		protected SignalStrength(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals11826;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SignalStrength._equals11826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._equals11826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString11827;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SignalStrength._toString11827)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._toString11827)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode11828;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._hashCode11828);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._hashCode11828);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel11829;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.SignalStrength._writeToParcel11829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._writeToParcel11829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents11830;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._describeContents11830);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._describeContents11830);
		}
		public new int GsmSignalStrength
		{
			get
			{
				return getGsmSignalStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGsmSignalStrength11831;
		public virtual int getGsmSignalStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._getGsmSignalStrength11831);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getGsmSignalStrength11831);
		}
		public new int GsmBitErrorRate
		{
			get
			{
				return getGsmBitErrorRate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGsmBitErrorRate11832;
		public virtual int getGsmBitErrorRate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._getGsmBitErrorRate11832);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getGsmBitErrorRate11832);
		}
		public new int CdmaDbm
		{
			get
			{
				return getCdmaDbm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCdmaDbm11833;
		public virtual int getCdmaDbm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._getCdmaDbm11833);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getCdmaDbm11833);
		}
		public new int CdmaEcio
		{
			get
			{
				return getCdmaEcio();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCdmaEcio11834;
		public virtual int getCdmaEcio() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._getCdmaEcio11834);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getCdmaEcio11834);
		}
		public new int EvdoDbm
		{
			get
			{
				return getEvdoDbm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEvdoDbm11835;
		public virtual int getEvdoDbm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._getEvdoDbm11835);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getEvdoDbm11835);
		}
		public new int EvdoEcio
		{
			get
			{
				return getEvdoEcio();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEvdoEcio11836;
		public virtual int getEvdoEcio() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._getEvdoEcio11836);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getEvdoEcio11836);
		}
		public new int EvdoSnr
		{
			get
			{
				return getEvdoSnr();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEvdoSnr11837;
		public virtual int getEvdoSnr() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._getEvdoSnr11837);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getEvdoSnr11837);
		}
		internal static global::MonoJavaBridge.MethodId _isGsm11838;
		public virtual bool isGsm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SignalStrength._isGsm11838);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._isGsm11838);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.SignalStrength.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/SignalStrength"));
			global::android.telephony.SignalStrength._equals11826 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.telephony.SignalStrength._toString11827 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.SignalStrength._hashCode11828 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "hashCode", "()I");
			global::android.telephony.SignalStrength._writeToParcel11829 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.telephony.SignalStrength._describeContents11830 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "describeContents", "()I");
			global::android.telephony.SignalStrength._getGsmSignalStrength11831 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getGsmSignalStrength", "()I");
			global::android.telephony.SignalStrength._getGsmBitErrorRate11832 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getGsmBitErrorRate", "()I");
			global::android.telephony.SignalStrength._getCdmaDbm11833 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getCdmaDbm", "()I");
			global::android.telephony.SignalStrength._getCdmaEcio11834 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getCdmaEcio", "()I");
			global::android.telephony.SignalStrength._getEvdoDbm11835 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getEvdoDbm", "()I");
			global::android.telephony.SignalStrength._getEvdoEcio11836 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getEvdoEcio", "()I");
			global::android.telephony.SignalStrength._getEvdoSnr11837 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getEvdoSnr", "()I");
			global::android.telephony.SignalStrength._isGsm11838 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "isGsm", "()Z");
		}
	}
}
