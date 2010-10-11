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
		internal static global::MonoJavaBridge.MethodId _equals7405;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.ServiceState._equals7405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._equals7405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString7406;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.ServiceState._toString7406)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._toString7406)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode7407;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.ServiceState._hashCode7407);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._hashCode7407);
		}
		internal static global::MonoJavaBridge.MethodId _getState7408;
		public virtual int getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.ServiceState._getState7408);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getState7408);
		}
		internal static global::MonoJavaBridge.MethodId _setState7409;
		public virtual void setState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._setState7409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setState7409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7410;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._writeToParcel7410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._writeToParcel7410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents7411;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.ServiceState._describeContents7411);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._describeContents7411);
		}
		internal static global::MonoJavaBridge.MethodId _copyFrom7412;
		protected virtual void copyFrom(android.telephony.ServiceState arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._copyFrom7412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._copyFrom7412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRoaming7413;
		public virtual bool getRoaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.ServiceState._getRoaming7413);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getRoaming7413);
		}
		internal static global::MonoJavaBridge.MethodId _getOperatorAlphaLong7414;
		public virtual global::java.lang.String getOperatorAlphaLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.ServiceState._getOperatorAlphaLong7414)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getOperatorAlphaLong7414)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getOperatorAlphaShort7415;
		public virtual global::java.lang.String getOperatorAlphaShort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.ServiceState._getOperatorAlphaShort7415)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getOperatorAlphaShort7415)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getOperatorNumeric7416;
		public virtual global::java.lang.String getOperatorNumeric() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.ServiceState._getOperatorNumeric7416)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getOperatorNumeric7416)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIsManualSelection7417;
		public virtual bool getIsManualSelection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.ServiceState._getIsManualSelection7417);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._getIsManualSelection7417);
		}
		internal static global::MonoJavaBridge.MethodId _setStateOutOfService7418;
		public virtual void setStateOutOfService() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._setStateOutOfService7418);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setStateOutOfService7418);
		}
		internal static global::MonoJavaBridge.MethodId _setStateOff7419;
		public virtual void setStateOff() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._setStateOff7419);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setStateOff7419);
		}
		internal static global::MonoJavaBridge.MethodId _setRoaming7420;
		public virtual void setRoaming(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._setRoaming7420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setRoaming7420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOperatorName7421;
		public virtual void setOperatorName(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._setOperatorName7421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setOperatorName7421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setIsManualSelection7422;
		public virtual void setIsManualSelection(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.ServiceState._setIsManualSelection7422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._setIsManualSelection7422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ServiceState7423;
		public ServiceState()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._ServiceState7423);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServiceState7424;
		public ServiceState(android.telephony.ServiceState arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._ServiceState7424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ServiceState7425;
		public ServiceState(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._ServiceState7425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR7426;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.ServiceState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/ServiceState"));
			global::android.telephony.ServiceState._equals7405 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.telephony.ServiceState._toString7406 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._hashCode7407 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "hashCode", "()I");
			global::android.telephony.ServiceState._getState7408 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getState", "()I");
			global::android.telephony.ServiceState._setState7409 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setState", "(I)V");
			global::android.telephony.ServiceState._writeToParcel7410 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.telephony.ServiceState._describeContents7411 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "describeContents", "()I");
			global::android.telephony.ServiceState._copyFrom7412 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "copyFrom", "(Landroid/telephony/ServiceState;)V");
			global::android.telephony.ServiceState._getRoaming7413 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getRoaming", "()Z");
			global::android.telephony.ServiceState._getOperatorAlphaLong7414 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getOperatorAlphaLong", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._getOperatorAlphaShort7415 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getOperatorAlphaShort", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._getOperatorNumeric7416 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getOperatorNumeric", "()Ljava/lang/String;");
			global::android.telephony.ServiceState._getIsManualSelection7417 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "getIsManualSelection", "()Z");
			global::android.telephony.ServiceState._setStateOutOfService7418 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setStateOutOfService", "()V");
			global::android.telephony.ServiceState._setStateOff7419 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setStateOff", "()V");
			global::android.telephony.ServiceState._setRoaming7420 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setRoaming", "(Z)V");
			global::android.telephony.ServiceState._setOperatorName7421 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setOperatorName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.telephony.ServiceState._setIsManualSelection7422 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "setIsManualSelection", "(Z)V");
			global::android.telephony.ServiceState._ServiceState7423 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "<init>", "()V");
			global::android.telephony.ServiceState._ServiceState7424 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "<init>", "(Landroid/telephony/ServiceState;)V");
			global::android.telephony.ServiceState._ServiceState7425 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
