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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode6213; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return @__env.CallIntMethod(this, _hashCode6213); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.ServiceState.staticClass, _hashCode6213); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals6214; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return @__env.CallBooleanMethod(this, _equals6214, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.ServiceState.staticClass, _equals6214, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString6215; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString6215)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.ServiceState.staticClass, _toString6215)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getState6216; 
		public virtual int getState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return @__env.CallIntMethod(this, _getState6216); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.ServiceState.staticClass, _getState6216); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setState6217; 
		public virtual void setState(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _setState6217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _setState6217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6218; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _writeToParcel6218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _writeToParcel6218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents6219; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return @__env.CallIntMethod(this, _describeContents6219); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.ServiceState.staticClass, _describeContents6219); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyFrom6220; 
		protected virtual void copyFrom(android.telephony.ServiceState arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _copyFrom6220, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _copyFrom6220, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRoaming6221; 
		public virtual bool getRoaming() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return @__env.CallBooleanMethod(this, _getRoaming6221); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.ServiceState.staticClass, _getRoaming6221); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOperatorAlphaLong6222; 
		public virtual java.lang.String getOperatorAlphaLong() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getOperatorAlphaLong6222)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.ServiceState.staticClass, _getOperatorAlphaLong6222)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOperatorAlphaShort6223; 
		public virtual java.lang.String getOperatorAlphaShort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getOperatorAlphaShort6223)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.ServiceState.staticClass, _getOperatorAlphaShort6223)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOperatorNumeric6224; 
		public virtual java.lang.String getOperatorNumeric() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getOperatorNumeric6224)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.ServiceState.staticClass, _getOperatorNumeric6224)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIsManualSelection6225; 
		public virtual bool getIsManualSelection() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				return @__env.CallBooleanMethod(this, _getIsManualSelection6225); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.ServiceState.staticClass, _getIsManualSelection6225); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStateOutOfService6226; 
		public virtual void setStateOutOfService() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _setStateOutOfService6226); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _setStateOutOfService6226); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStateOff6227; 
		public virtual void setStateOff() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _setStateOff6227); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _setStateOff6227); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRoaming6228; 
		public virtual void setRoaming(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _setRoaming6228, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _setRoaming6228, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOperatorName6229; 
		public virtual void setOperatorName(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _setOperatorName6229, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _setOperatorName6229, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIsManualSelection6230; 
		public virtual void setIsManualSelection(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.ServiceState)) 
				@__env.CallVoidMethod(this, _setIsManualSelection6230, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.ServiceState.staticClass, _setIsManualSelection6230, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServiceState6231; 
		public ServiceState()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.ServiceState.staticClass, _ServiceState6231, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServiceState6232; 
		public ServiceState(android.telephony.ServiceState arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.ServiceState.staticClass, _ServiceState6232, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServiceState6233; 
		public ServiceState(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.ServiceState.staticClass, _ServiceState6233, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR6234; 
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
			global::android.telephony.ServiceState._hashCode6213 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "hashCode", "()I"); 
			global::android.telephony.ServiceState._equals6214 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.telephony.ServiceState._toString6215 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.telephony.ServiceState._getState6216 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getState", "()I"); 
			global::android.telephony.ServiceState._setState6217 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setState", "(I)V"); 
			global::android.telephony.ServiceState._writeToParcel6218 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.telephony.ServiceState._describeContents6219 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "describeContents", "()I"); 
			global::android.telephony.ServiceState._copyFrom6220 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "copyFrom", "(Landroid/telephony/ServiceState;)V"); 
			global::android.telephony.ServiceState._getRoaming6221 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getRoaming", "()Z"); 
			global::android.telephony.ServiceState._getOperatorAlphaLong6222 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getOperatorAlphaLong", "()Ljava/lang/String;"); 
			global::android.telephony.ServiceState._getOperatorAlphaShort6223 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getOperatorAlphaShort", "()Ljava/lang/String;"); 
			global::android.telephony.ServiceState._getOperatorNumeric6224 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getOperatorNumeric", "()Ljava/lang/String;"); 
			global::android.telephony.ServiceState._getIsManualSelection6225 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getIsManualSelection", "()Z"); 
			global::android.telephony.ServiceState._setStateOutOfService6226 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setStateOutOfService", "()V"); 
			global::android.telephony.ServiceState._setStateOff6227 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setStateOff", "()V"); 
			global::android.telephony.ServiceState._setRoaming6228 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setRoaming", "(Z)V"); 
			global::android.telephony.ServiceState._setOperatorName6229 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setOperatorName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.telephony.ServiceState._setIsManualSelection6230 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setIsManualSelection", "(Z)V"); 
			global::android.telephony.ServiceState._ServiceState6231 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "<init>", "()V"); 
			global::android.telephony.ServiceState._ServiceState6232 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "<init>", "(Landroid/telephony/ServiceState;)V"); 
			global::android.telephony.ServiceState._ServiceState6233 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
