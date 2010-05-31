namespace android.telephony
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SignalStrength : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static SignalStrength()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.SignalStrength), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.telephony.SignalStrength(@__env);
			}
		}
		protected SignalStrength(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode6523;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._hashCode6523);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._hashCode6523);
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals6524;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.SignalStrength._equals6524, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._equals6524, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString6525;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SignalStrength._toString6525));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._toString6525));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6526;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.SignalStrength._writeToParcel6526, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._writeToParcel6526, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents6527;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._describeContents6527);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._describeContents6527);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGsmSignalStrength6528;
		public virtual int getGsmSignalStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._getGsmSignalStrength6528);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getGsmSignalStrength6528);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGsmBitErrorRate6529;
		public virtual int getGsmBitErrorRate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._getGsmBitErrorRate6529);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getGsmBitErrorRate6529);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCdmaDbm6530;
		public virtual int getCdmaDbm() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._getCdmaDbm6530);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getCdmaDbm6530);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCdmaEcio6531;
		public virtual int getCdmaEcio() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._getCdmaEcio6531);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getCdmaEcio6531);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEvdoDbm6532;
		public virtual int getEvdoDbm() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._getEvdoDbm6532);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getEvdoDbm6532);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEvdoEcio6533;
		public virtual int getEvdoEcio() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._getEvdoEcio6533);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getEvdoEcio6533);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEvdoSnr6534;
		public virtual int getEvdoSnr() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._getEvdoSnr6534);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getEvdoSnr6534);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isGsm6535;
		public virtual bool isGsm() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.SignalStrength._isGsm6535);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._isGsm6535);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.telephony.SignalStrength.staticClass = @__class;
			global::android.telephony.SignalStrength._hashCode6523 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "hashCode", "()I");
			global::android.telephony.SignalStrength._equals6524 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.telephony.SignalStrength._toString6525 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.SignalStrength._writeToParcel6526 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.telephony.SignalStrength._describeContents6527 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "describeContents", "()I");
			global::android.telephony.SignalStrength._getGsmSignalStrength6528 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getGsmSignalStrength", "()I");
			global::android.telephony.SignalStrength._getGsmBitErrorRate6529 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getGsmBitErrorRate", "()I");
			global::android.telephony.SignalStrength._getCdmaDbm6530 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getCdmaDbm", "()I");
			global::android.telephony.SignalStrength._getCdmaEcio6531 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getCdmaEcio", "()I");
			global::android.telephony.SignalStrength._getEvdoDbm6532 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getEvdoDbm", "()I");
			global::android.telephony.SignalStrength._getEvdoEcio6533 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getEvdoEcio", "()I");
			global::android.telephony.SignalStrength._getEvdoSnr6534 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getEvdoSnr", "()I");
			global::android.telephony.SignalStrength._isGsm6535 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "isGsm", "()Z");
		}
	}
}
