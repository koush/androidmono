namespace android.telephony 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ServiceState : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static ServiceState() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.telephony.ServiceState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.telephony.ServiceState(@__env); 
			} 
		} 
		protected ServiceState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode6501; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return @__env.CallIntMethod(this, _hashCode6501); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.ServiceState.staticClass, _hashCode6501); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals6502; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return @__env.CallBooleanMethod(this, _equals6502, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.ServiceState.staticClass, _equals6502, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString6503; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString6503)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.ServiceState.staticClass, _toString6503)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getState6504; 
		public virtual int getState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return @__env.CallIntMethod(this, _getState6504); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.ServiceState.staticClass, _getState6504); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setState6505; 
		public virtual void setState(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _setState6505, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _setState6505, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6506; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _writeToParcel6506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _writeToParcel6506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents6507; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return @__env.CallIntMethod(this, _describeContents6507); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.ServiceState.staticClass, _describeContents6507); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyFrom6508; 
		protected virtual void copyFrom(android.telephony.ServiceState arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _copyFrom6508, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _copyFrom6508, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRoaming6509; 
		public virtual bool getRoaming() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return @__env.CallBooleanMethod(this, _getRoaming6509); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.ServiceState.staticClass, _getRoaming6509); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOperatorAlphaLong6510; 
		public virtual java.lang.String getOperatorAlphaLong() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getOperatorAlphaLong6510)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.ServiceState.staticClass, _getOperatorAlphaLong6510)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOperatorAlphaShort6511; 
		public virtual java.lang.String getOperatorAlphaShort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getOperatorAlphaShort6511)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.ServiceState.staticClass, _getOperatorAlphaShort6511)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOperatorNumeric6512; 
		public virtual java.lang.String getOperatorNumeric() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getOperatorNumeric6512)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.ServiceState.staticClass, _getOperatorNumeric6512)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIsManualSelection6513; 
		public virtual bool getIsManualSelection() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return @__env.CallBooleanMethod(this, _getIsManualSelection6513); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.ServiceState.staticClass, _getIsManualSelection6513); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStateOutOfService6514; 
		public virtual void setStateOutOfService() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _setStateOutOfService6514); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _setStateOutOfService6514); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStateOff6515; 
		public virtual void setStateOff() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _setStateOff6515); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _setStateOff6515); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRoaming6516; 
		public virtual void setRoaming(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _setRoaming6516, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _setRoaming6516, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOperatorName6517; 
		public virtual void setOperatorName(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _setOperatorName6517, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _setOperatorName6517, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIsManualSelection6518; 
		public virtual void setIsManualSelection(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _setIsManualSelection6518, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _setIsManualSelection6518, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServiceState6519; 
		public ServiceState()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.ServiceState.staticClass, _ServiceState6519, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServiceState6520; 
		public ServiceState(android.telephony.ServiceState arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.ServiceState.staticClass, _ServiceState6520, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServiceState6521; 
		public ServiceState(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.ServiceState.staticClass, _ServiceState6521, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int STATE_IN_SERVICE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int STATE_OUT_OF_SERVICE
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int STATE_EMERGENCY_ONLY
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int STATE_POWER_OFF
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR6522; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.telephony.ServiceState.staticClass = @__class; 
			global::android.telephony.ServiceState._hashCode6501 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "hashCode", "()I"); 
			global::android.telephony.ServiceState._equals6502 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.telephony.ServiceState._toString6503 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.telephony.ServiceState._getState6504 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getState", "()I"); 
			global::android.telephony.ServiceState._setState6505 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setState", "(I)V"); 
			global::android.telephony.ServiceState._writeToParcel6506 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.telephony.ServiceState._describeContents6507 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "describeContents", "()I"); 
			global::android.telephony.ServiceState._copyFrom6508 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "copyFrom", "(Landroid/telephony/ServiceState;)V"); 
			global::android.telephony.ServiceState._getRoaming6509 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getRoaming", "()Z"); 
			global::android.telephony.ServiceState._getOperatorAlphaLong6510 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getOperatorAlphaLong", "()Ljava/lang/String;"); 
			global::android.telephony.ServiceState._getOperatorAlphaShort6511 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getOperatorAlphaShort", "()Ljava/lang/String;"); 
			global::android.telephony.ServiceState._getOperatorNumeric6512 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getOperatorNumeric", "()Ljava/lang/String;"); 
			global::android.telephony.ServiceState._getIsManualSelection6513 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getIsManualSelection", "()Z"); 
			global::android.telephony.ServiceState._setStateOutOfService6514 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setStateOutOfService", "()V"); 
			global::android.telephony.ServiceState._setStateOff6515 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setStateOff", "()V"); 
			global::android.telephony.ServiceState._setRoaming6516 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setRoaming", "(Z)V"); 
			global::android.telephony.ServiceState._setOperatorName6517 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setOperatorName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.telephony.ServiceState._setIsManualSelection6518 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setIsManualSelection", "(Z)V"); 
			global::android.telephony.ServiceState._ServiceState6519 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "<init>", "()V"); 
			global::android.telephony.ServiceState._ServiceState6520 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "<init>", "(Landroid/telephony/ServiceState;)V"); 
			global::android.telephony.ServiceState._ServiceState6521 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
