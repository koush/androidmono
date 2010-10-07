namespace android.telephony
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ServiceState : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static ServiceState()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.ServiceState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _equals7125;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.ServiceState._equals7125, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._equals7125, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString7126;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.ServiceState._toString7126));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._toString7126));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode7127;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.ServiceState._hashCode7127);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._hashCode7127);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getState7128;
		public virtual int getState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.ServiceState._getState7128);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getState7128);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setState7129;
		public virtual void setState(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.ServiceState._setState7129, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setState7129, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7130;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.ServiceState._writeToParcel7130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._writeToParcel7130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7131;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.ServiceState._describeContents7131);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._describeContents7131);
		}
		internal static global::net.sf.jni4net.jni.MethodId _copyFrom7132;
		protected virtual void copyFrom(android.telephony.ServiceState arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.ServiceState._copyFrom7132, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._copyFrom7132, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRoaming7133;
		public virtual bool getRoaming() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.ServiceState._getRoaming7133);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getRoaming7133);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOperatorAlphaLong7134;
		public virtual global::java.lang.String getOperatorAlphaLong() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.ServiceState._getOperatorAlphaLong7134));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getOperatorAlphaLong7134));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOperatorAlphaShort7135;
		public virtual global::java.lang.String getOperatorAlphaShort() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.ServiceState._getOperatorAlphaShort7135));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getOperatorAlphaShort7135));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOperatorNumeric7136;
		public virtual global::java.lang.String getOperatorNumeric() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.ServiceState._getOperatorNumeric7136));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getOperatorNumeric7136));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIsManualSelection7137;
		public virtual bool getIsManualSelection() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.ServiceState._getIsManualSelection7137);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getIsManualSelection7137);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStateOutOfService7138;
		public virtual void setStateOutOfService() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.ServiceState._setStateOutOfService7138);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setStateOutOfService7138);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStateOff7139;
		public virtual void setStateOff() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.ServiceState._setStateOff7139);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setStateOff7139);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRoaming7140;
		public virtual void setRoaming(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.ServiceState._setRoaming7140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setRoaming7140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOperatorName7141;
		public virtual void setOperatorName(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.ServiceState._setOperatorName7141, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setOperatorName7141, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIsManualSelection7142;
		public virtual void setIsManualSelection(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.ServiceState._setIsManualSelection7142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setIsManualSelection7142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ServiceState7143;
		public ServiceState()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._ServiceState7143, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ServiceState7144;
		public ServiceState(android.telephony.ServiceState arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._ServiceState7144, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ServiceState7145;
		public ServiceState(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._ServiceState7145, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR7146;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.telephony.ServiceState.staticClass = @__class;
			global::android.telephony.ServiceState._equals7125 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.telephony.ServiceState._toString7126 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._hashCode7127 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "hashCode", "()I");
			global::android.telephony.ServiceState._getState7128 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getState", "()I");
			global::android.telephony.ServiceState._setState7129 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setState", "(I)V");
			global::android.telephony.ServiceState._writeToParcel7130 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.telephony.ServiceState._describeContents7131 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "describeContents", "()I");
			global::android.telephony.ServiceState._copyFrom7132 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "copyFrom", "(Landroid/telephony/ServiceState;)V");
			global::android.telephony.ServiceState._getRoaming7133 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getRoaming", "()Z");
			global::android.telephony.ServiceState._getOperatorAlphaLong7134 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getOperatorAlphaLong", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._getOperatorAlphaShort7135 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getOperatorAlphaShort", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._getOperatorNumeric7136 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getOperatorNumeric", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._getIsManualSelection7137 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "getIsManualSelection", "()Z");
			global::android.telephony.ServiceState._setStateOutOfService7138 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setStateOutOfService", "()V");
			global::android.telephony.ServiceState._setStateOff7139 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setStateOff", "()V");
			global::android.telephony.ServiceState._setRoaming7140 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setRoaming", "(Z)V");
			global::android.telephony.ServiceState._setOperatorName7141 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setOperatorName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.telephony.ServiceState._setIsManualSelection7142 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "setIsManualSelection", "(Z)V");
			global::android.telephony.ServiceState._ServiceState7143 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "<init>", "()V");
			global::android.telephony.ServiceState._ServiceState7144 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "<init>", "(Landroid/telephony/ServiceState;)V");
			global::android.telephony.ServiceState._ServiceState7145 = @__env.GetMethodID(global::android.telephony.ServiceState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
