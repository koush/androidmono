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
		internal static global::MonoJavaBridge.MethodId _equals7427;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SignalStrength._equals7427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._equals7427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString7428;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.SignalStrength._toString7428)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._toString7428)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode7429;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._hashCode7429);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._hashCode7429);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7430;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.SignalStrength._writeToParcel7430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._writeToParcel7430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents7431;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._describeContents7431);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._describeContents7431);
		}
		public new int GsmSignalStrength
		{
			get
			{
				return getGsmSignalStrength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGsmSignalStrength7432;
		public virtual int getGsmSignalStrength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._getGsmSignalStrength7432);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getGsmSignalStrength7432);
		}
		public new int GsmBitErrorRate
		{
			get
			{
				return getGsmBitErrorRate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGsmBitErrorRate7433;
		public virtual int getGsmBitErrorRate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._getGsmBitErrorRate7433);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getGsmBitErrorRate7433);
		}
		public new int CdmaDbm
		{
			get
			{
				return getCdmaDbm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCdmaDbm7434;
		public virtual int getCdmaDbm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._getCdmaDbm7434);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getCdmaDbm7434);
		}
		public new int CdmaEcio
		{
			get
			{
				return getCdmaEcio();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCdmaEcio7435;
		public virtual int getCdmaEcio() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._getCdmaEcio7435);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getCdmaEcio7435);
		}
		public new int EvdoDbm
		{
			get
			{
				return getEvdoDbm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEvdoDbm7436;
		public virtual int getEvdoDbm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._getEvdoDbm7436);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getEvdoDbm7436);
		}
		public new int EvdoEcio
		{
			get
			{
				return getEvdoEcio();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEvdoEcio7437;
		public virtual int getEvdoEcio() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._getEvdoEcio7437);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getEvdoEcio7437);
		}
		public new int EvdoSnr
		{
			get
			{
				return getEvdoSnr();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEvdoSnr7438;
		public virtual int getEvdoSnr() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.SignalStrength._getEvdoSnr7438);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getEvdoSnr7438);
		}
		internal static global::MonoJavaBridge.MethodId _isGsm7439;
		public virtual bool isGsm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.SignalStrength._isGsm7439);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._isGsm7439);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.SignalStrength.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/SignalStrength"));
			global::android.telephony.SignalStrength._equals7427 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.telephony.SignalStrength._toString7428 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.SignalStrength._hashCode7429 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "hashCode", "()I");
			global::android.telephony.SignalStrength._writeToParcel7430 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.telephony.SignalStrength._describeContents7431 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "describeContents", "()I");
			global::android.telephony.SignalStrength._getGsmSignalStrength7432 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getGsmSignalStrength", "()I");
			global::android.telephony.SignalStrength._getGsmBitErrorRate7433 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getGsmBitErrorRate", "()I");
			global::android.telephony.SignalStrength._getCdmaDbm7434 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getCdmaDbm", "()I");
			global::android.telephony.SignalStrength._getCdmaEcio7435 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getCdmaEcio", "()I");
			global::android.telephony.SignalStrength._getEvdoDbm7436 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getEvdoDbm", "()I");
			global::android.telephony.SignalStrength._getEvdoEcio7437 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getEvdoEcio", "()I");
			global::android.telephony.SignalStrength._getEvdoSnr7438 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "getEvdoSnr", "()I");
			global::android.telephony.SignalStrength._isGsm7439 = @__env.GetMethodIDNoThrow(global::android.telephony.SignalStrength.staticClass, "isGsm", "()Z");
		}
	}
}
