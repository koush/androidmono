namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ServiceState : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ServiceState()
		{
			InitJNI();
		}
		protected ServiceState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals11800;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.ServiceState._equals11800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._equals11800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString11801;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.ServiceState._toString11801)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._toString11801)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode11802;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.ServiceState._hashCode11802);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._hashCode11802);
		}
		public new int State
		{
			get
			{
				return getState();
			}
			set
			{
				setState(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getState11803;
		public virtual int getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.ServiceState._getState11803);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getState11803);
		}
		internal static global::MonoJavaBridge.MethodId _setState11804;
		public virtual void setState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._setState11804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setState11804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel11805;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._writeToParcel11805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._writeToParcel11805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents11806;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.ServiceState._describeContents11806);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._describeContents11806);
		}
		internal static global::MonoJavaBridge.MethodId _copyFrom11807;
		protected virtual void copyFrom(android.telephony.ServiceState arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._copyFrom11807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._copyFrom11807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Roaming
		{
			get
			{
				return getRoaming();
			}
			set
			{
				setRoaming(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRoaming11808;
		public virtual bool getRoaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.ServiceState._getRoaming11808);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getRoaming11808);
		}
		public new global::java.lang.String OperatorAlphaLong
		{
			get
			{
				return getOperatorAlphaLong();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOperatorAlphaLong11809;
		public virtual global::java.lang.String getOperatorAlphaLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.ServiceState._getOperatorAlphaLong11809)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getOperatorAlphaLong11809)) as java.lang.String;
		}
		public new global::java.lang.String OperatorAlphaShort
		{
			get
			{
				return getOperatorAlphaShort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOperatorAlphaShort11810;
		public virtual global::java.lang.String getOperatorAlphaShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.ServiceState._getOperatorAlphaShort11810)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getOperatorAlphaShort11810)) as java.lang.String;
		}
		public new global::java.lang.String OperatorNumeric
		{
			get
			{
				return getOperatorNumeric();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOperatorNumeric11811;
		public virtual global::java.lang.String getOperatorNumeric() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.ServiceState._getOperatorNumeric11811)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getOperatorNumeric11811)) as java.lang.String;
		}
		public new bool IsManualSelection
		{
			get
			{
				return getIsManualSelection();
			}
			set
			{
				setIsManualSelection(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIsManualSelection11812;
		public virtual bool getIsManualSelection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.ServiceState._getIsManualSelection11812);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getIsManualSelection11812);
		}
		internal static global::MonoJavaBridge.MethodId _setStateOutOfService11813;
		public virtual void setStateOutOfService() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._setStateOutOfService11813);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setStateOutOfService11813);
		}
		internal static global::MonoJavaBridge.MethodId _setStateOff11814;
		public virtual void setStateOff() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._setStateOff11814);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setStateOff11814);
		}
		internal static global::MonoJavaBridge.MethodId _setRoaming11815;
		public virtual void setRoaming(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._setRoaming11815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setRoaming11815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOperatorName11816;
		public virtual void setOperatorName(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._setOperatorName11816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setOperatorName11816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setIsManualSelection11817;
		public virtual void setIsManualSelection(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._setIsManualSelection11817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setIsManualSelection11817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ServiceState11818;
		public ServiceState()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._ServiceState11818);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServiceState11819;
		public ServiceState(android.telephony.ServiceState arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._ServiceState11819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServiceState11820;
		public ServiceState(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._ServiceState11820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
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
		internal static global::MonoJavaBridge.FieldId _CREATOR11825;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.telephony.ServiceState.staticClass, _CREATOR11825)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.ServiceState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/ServiceState"));
			global::android.telephony.ServiceState._equals11800 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.telephony.ServiceState._toString11801 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._hashCode11802 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "hashCode", "()I");
			global::android.telephony.ServiceState._getState11803 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getState", "()I");
			global::android.telephony.ServiceState._setState11804 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setState", "(I)V");
			global::android.telephony.ServiceState._writeToParcel11805 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.telephony.ServiceState._describeContents11806 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "describeContents", "()I");
			global::android.telephony.ServiceState._copyFrom11807 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "copyFrom", "(Landroid/telephony/ServiceState;)V");
			global::android.telephony.ServiceState._getRoaming11808 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getRoaming", "()Z");
			global::android.telephony.ServiceState._getOperatorAlphaLong11809 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getOperatorAlphaLong", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._getOperatorAlphaShort11810 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getOperatorAlphaShort", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._getOperatorNumeric11811 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getOperatorNumeric", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._getIsManualSelection11812 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getIsManualSelection", "()Z");
			global::android.telephony.ServiceState._setStateOutOfService11813 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setStateOutOfService", "()V");
			global::android.telephony.ServiceState._setStateOff11814 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setStateOff", "()V");
			global::android.telephony.ServiceState._setRoaming11815 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setRoaming", "(Z)V");
			global::android.telephony.ServiceState._setOperatorName11816 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setOperatorName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.telephony.ServiceState._setIsManualSelection11817 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setIsManualSelection", "(Z)V");
			global::android.telephony.ServiceState._ServiceState11818 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "<init>", "()V");
			global::android.telephony.ServiceState._ServiceState11819 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "<init>", "(Landroid/telephony/ServiceState;)V");
			global::android.telephony.ServiceState._ServiceState11820 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.telephony.ServiceState._CREATOR11825 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.ServiceState.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
