namespace android.telephony 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SignalStrength : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static SignalStrength() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.telephony.SignalStrength), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode6235; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SignalStrength)) 
				return @__env.CallIntMethod(this, _hashCode6235); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.SignalStrength.staticClass, _hashCode6235); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals6236; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SignalStrength)) 
				return @__env.CallBooleanMethod(this, _equals6236, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.SignalStrength.staticClass, _equals6236, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString6237; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SignalStrength)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString6237)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.SignalStrength.staticClass, _toString6237)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6238; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SignalStrength)) 
				@__env.CallVoidMethod(this, _writeToParcel6238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.SignalStrength.staticClass, _writeToParcel6238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents6239; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SignalStrength)) 
				return @__env.CallIntMethod(this, _describeContents6239); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.SignalStrength.staticClass, _describeContents6239); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGsmSignalStrength6240; 
		public virtual int getGsmSignalStrength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SignalStrength)) 
				return @__env.CallIntMethod(this, _getGsmSignalStrength6240); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.SignalStrength.staticClass, _getGsmSignalStrength6240); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGsmBitErrorRate6241; 
		public virtual int getGsmBitErrorRate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SignalStrength)) 
				return @__env.CallIntMethod(this, _getGsmBitErrorRate6241); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.SignalStrength.staticClass, _getGsmBitErrorRate6241); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCdmaDbm6242; 
		public virtual int getCdmaDbm() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SignalStrength)) 
				return @__env.CallIntMethod(this, _getCdmaDbm6242); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.SignalStrength.staticClass, _getCdmaDbm6242); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCdmaEcio6243; 
		public virtual int getCdmaEcio() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SignalStrength)) 
				return @__env.CallIntMethod(this, _getCdmaEcio6243); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.SignalStrength.staticClass, _getCdmaEcio6243); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEvdoDbm6244; 
		public virtual int getEvdoDbm() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SignalStrength)) 
				return @__env.CallIntMethod(this, _getEvdoDbm6244); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.SignalStrength.staticClass, _getEvdoDbm6244); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEvdoEcio6245; 
		public virtual int getEvdoEcio() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SignalStrength)) 
				return @__env.CallIntMethod(this, _getEvdoEcio6245); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.SignalStrength.staticClass, _getEvdoEcio6245); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEvdoSnr6246; 
		public virtual int getEvdoSnr() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SignalStrength)) 
				return @__env.CallIntMethod(this, _getEvdoSnr6246); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.SignalStrength.staticClass, _getEvdoSnr6246); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isGsm6247; 
		public virtual bool isGsm() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SignalStrength)) 
				return @__env.CallBooleanMethod(this, _isGsm6247); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.SignalStrength.staticClass, _isGsm6247); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.telephony.SignalStrength.staticClass = @__class; 
			global::android.telephony.SignalStrength._hashCode6235 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "hashCode", "()I"); 
			global::android.telephony.SignalStrength._equals6236 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.telephony.SignalStrength._toString6237 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.telephony.SignalStrength._writeToParcel6238 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.telephony.SignalStrength._describeContents6239 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "describeContents", "()I"); 
			global::android.telephony.SignalStrength._getGsmSignalStrength6240 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getGsmSignalStrength", "()I"); 
			global::android.telephony.SignalStrength._getGsmBitErrorRate6241 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getGsmBitErrorRate", "()I"); 
			global::android.telephony.SignalStrength._getCdmaDbm6242 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getCdmaDbm", "()I"); 
			global::android.telephony.SignalStrength._getCdmaEcio6243 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getCdmaEcio", "()I"); 
			global::android.telephony.SignalStrength._getEvdoDbm6244 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getEvdoDbm", "()I"); 
			global::android.telephony.SignalStrength._getEvdoEcio6245 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getEvdoEcio", "()I"); 
			global::android.telephony.SignalStrength._getEvdoSnr6246 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "getEvdoSnr", "()I"); 
			global::android.telephony.SignalStrength._isGsm6247 = @__env.GetMethodID(global::android.telephony.SignalStrength.staticClass, "isGsm", "()Z"); 
		} 
	} 
} 
