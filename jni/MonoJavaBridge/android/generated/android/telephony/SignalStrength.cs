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
		internal static global::net.sf.jni4net.jni.MethodId _equals7147;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.SignalStrength._equals7147, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._equals7147, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString7148;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.SignalStrength._toString7148));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._toString7148));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode7149;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._hashCode7149);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._hashCode7149);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7150;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.SignalStrength._writeToParcel7150, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._writeToParcel7150, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7151;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._describeContents7151);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._describeContents7151);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGsmSignalStrength7152;
		public virtual int getGsmSignalStrength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._getGsmSignalStrength7152);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getGsmSignalStrength7152);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGsmBitErrorRate7153;
		public virtual int getGsmBitErrorRate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._getGsmBitErrorRate7153);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getGsmBitErrorRate7153);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCdmaDbm7154;
		public virtual int getCdmaDbm() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._getCdmaDbm7154);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getCdmaDbm7154);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCdmaEcio7155;
		public virtual int getCdmaEcio() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._getCdmaEcio7155);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getCdmaEcio7155);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEvdoDbm7156;
		public virtual int getEvdoDbm() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._getEvdoDbm7156);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getEvdoDbm7156);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEvdoEcio7157;
		public virtual int getEvdoEcio() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._getEvdoEcio7157);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getEvdoEcio7157);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEvdoSnr7158;
		public virtual int getEvdoSnr() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.SignalStrength._getEvdoSnr7158);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._getEvdoSnr7158);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isGsm7159;
		public virtual bool isGsm() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.SignalStrength._isGsm7159);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.SignalStrength.staticClass, global::android.telephony.SignalStrength._isGsm7159);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.telephony.SignalStrength.staticClass = @__class;
			global::android.telephony.SignalStrength._equals7147 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.telephony.SignalStrength._toString7148 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.SignalStrength._hashCode7149 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "hashCode", "()I");
			global::android.telephony.SignalStrength._writeToParcel7150 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.telephony.SignalStrength._describeContents7151 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "describeContents", "()I");
			global::android.telephony.SignalStrength._getGsmSignalStrength7152 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getGsmSignalStrength", "()I");
			global::android.telephony.SignalStrength._getGsmBitErrorRate7153 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getGsmBitErrorRate", "()I");
			global::android.telephony.SignalStrength._getCdmaDbm7154 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getCdmaDbm", "()I");
			global::android.telephony.SignalStrength._getCdmaEcio7155 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getCdmaEcio", "()I");
			global::android.telephony.SignalStrength._getEvdoDbm7156 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getEvdoDbm", "()I");
			global::android.telephony.SignalStrength._getEvdoEcio7157 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getEvdoEcio", "()I");
			global::android.telephony.SignalStrength._getEvdoSnr7158 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getEvdoSnr", "()I");
			global::android.telephony.SignalStrength._isGsm7159 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "isGsm", "()Z");
		}
	}
}
