namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ServiceState : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ServiceState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals11857;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._equals11857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString11858;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._toString11858)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode11859;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._hashCode11859);
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
		internal static global::MonoJavaBridge.MethodId _getState11860;
		public virtual int getState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getState11860);
		}
		internal static global::MonoJavaBridge.MethodId _setState11861;
		public virtual void setState(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setState11861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel11862;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._writeToParcel11862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents11863;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._describeContents11863);
		}
		internal static global::MonoJavaBridge.MethodId _copyFrom11864;
		protected virtual void copyFrom(android.telephony.ServiceState arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._copyFrom11864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getRoaming11865;
		public virtual bool getRoaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getRoaming11865);
		}
		public new global::java.lang.String OperatorAlphaLong
		{
			get
			{
				return getOperatorAlphaLong();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOperatorAlphaLong11866;
		public virtual global::java.lang.String getOperatorAlphaLong()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getOperatorAlphaLong11866)) as java.lang.String;
		}
		public new global::java.lang.String OperatorAlphaShort
		{
			get
			{
				return getOperatorAlphaShort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOperatorAlphaShort11867;
		public virtual global::java.lang.String getOperatorAlphaShort()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getOperatorAlphaShort11867)) as java.lang.String;
		}
		public new global::java.lang.String OperatorNumeric
		{
			get
			{
				return getOperatorNumeric();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOperatorNumeric11868;
		public virtual global::java.lang.String getOperatorNumeric()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getOperatorNumeric11868)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getIsManualSelection11869;
		public virtual bool getIsManualSelection()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getIsManualSelection11869);
		}
		internal static global::MonoJavaBridge.MethodId _setStateOutOfService11870;
		public virtual void setStateOutOfService()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setStateOutOfService11870);
		}
		internal static global::MonoJavaBridge.MethodId _setStateOff11871;
		public virtual void setStateOff()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setStateOff11871);
		}
		internal static global::MonoJavaBridge.MethodId _setRoaming11872;
		public virtual void setRoaming(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setRoaming11872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOperatorName11873;
		public virtual void setOperatorName(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setOperatorName11873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setIsManualSelection11874;
		public virtual void setIsManualSelection(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setIsManualSelection11874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ServiceState11875;
		public ServiceState() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._ServiceState11875);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServiceState11876;
		public ServiceState(android.telephony.ServiceState arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._ServiceState11876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServiceState11877;
		public ServiceState(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._ServiceState11877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR11882;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.telephony.ServiceState.staticClass, _CREATOR11882)) as android.os.Parcelable_Creator;
			}
		}
		static ServiceState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.ServiceState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/ServiceState"));
			global::android.telephony.ServiceState._equals11857 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.telephony.ServiceState._toString11858 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._hashCode11859 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "hashCode", "()I");
			global::android.telephony.ServiceState._getState11860 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getState", "()I");
			global::android.telephony.ServiceState._setState11861 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setState", "(I)V");
			global::android.telephony.ServiceState._writeToParcel11862 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.telephony.ServiceState._describeContents11863 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "describeContents", "()I");
			global::android.telephony.ServiceState._copyFrom11864 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "copyFrom", "(Landroid/telephony/ServiceState;)V");
			global::android.telephony.ServiceState._getRoaming11865 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getRoaming", "()Z");
			global::android.telephony.ServiceState._getOperatorAlphaLong11866 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getOperatorAlphaLong", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._getOperatorAlphaShort11867 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getOperatorAlphaShort", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._getOperatorNumeric11868 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getOperatorNumeric", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._getIsManualSelection11869 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getIsManualSelection", "()Z");
			global::android.telephony.ServiceState._setStateOutOfService11870 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setStateOutOfService", "()V");
			global::android.telephony.ServiceState._setStateOff11871 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setStateOff", "()V");
			global::android.telephony.ServiceState._setRoaming11872 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setRoaming", "(Z)V");
			global::android.telephony.ServiceState._setOperatorName11873 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setOperatorName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.telephony.ServiceState._setIsManualSelection11874 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setIsManualSelection", "(Z)V");
			global::android.telephony.ServiceState._ServiceState11875 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "<init>", "()V");
			global::android.telephony.ServiceState._ServiceState11876 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "<init>", "(Landroid/telephony/ServiceState;)V");
			global::android.telephony.ServiceState._ServiceState11877 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.telephony.ServiceState._CREATOR11882 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.ServiceState.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
