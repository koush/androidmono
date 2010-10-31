namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ServiceState : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ServiceState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.ServiceState.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.telephony.ServiceState._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.ServiceState.staticClass, "toString", "()Ljava/lang/String;", ref global::android.telephony.ServiceState._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.ServiceState.staticClass, "hashCode", "()I", ref global::android.telephony.ServiceState._m2);
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
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.ServiceState.staticClass, "getState", "()I", ref global::android.telephony.ServiceState._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setState(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, "setState", "(I)V", ref global::android.telephony.ServiceState._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.telephony.ServiceState._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.ServiceState.staticClass, "describeContents", "()I", ref global::android.telephony.ServiceState._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual void copyFrom(android.telephony.ServiceState arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, "copyFrom", "(Landroid/telephony/ServiceState;)V", ref global::android.telephony.ServiceState._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool getRoaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.ServiceState.staticClass, "getRoaming", "()Z", ref global::android.telephony.ServiceState._m8);
		}
		public new global::java.lang.String OperatorAlphaLong
		{
			get
			{
				return getOperatorAlphaLong();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.String getOperatorAlphaLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.ServiceState.staticClass, "getOperatorAlphaLong", "()Ljava/lang/String;", ref global::android.telephony.ServiceState._m9) as java.lang.String;
		}
		public new global::java.lang.String OperatorAlphaShort
		{
			get
			{
				return getOperatorAlphaShort();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.String getOperatorAlphaShort()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.ServiceState.staticClass, "getOperatorAlphaShort", "()Ljava/lang/String;", ref global::android.telephony.ServiceState._m10) as java.lang.String;
		}
		public new global::java.lang.String OperatorNumeric
		{
			get
			{
				return getOperatorNumeric();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.String getOperatorNumeric()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.ServiceState.staticClass, "getOperatorNumeric", "()Ljava/lang/String;", ref global::android.telephony.ServiceState._m11) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool getIsManualSelection()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.ServiceState.staticClass, "getIsManualSelection", "()Z", ref global::android.telephony.ServiceState._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setStateOutOfService()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, "setStateOutOfService", "()V", ref global::android.telephony.ServiceState._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setStateOff()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, "setStateOff", "()V", ref global::android.telephony.ServiceState._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setRoaming(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, "setRoaming", "(Z)V", ref global::android.telephony.ServiceState._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setOperatorName(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, "setOperatorName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::android.telephony.ServiceState._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setIsManualSelection(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.ServiceState.staticClass, "setIsManualSelection", "(Z)V", ref global::android.telephony.ServiceState._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public ServiceState() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.ServiceState._m18.native == global::System.IntPtr.Zero)
				global::android.telephony.ServiceState._m18 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._m18);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public ServiceState(android.telephony.ServiceState arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.ServiceState._m19.native == global::System.IntPtr.Zero)
				global::android.telephony.ServiceState._m19 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "<init>", "(Landroid/telephony/ServiceState;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public ServiceState(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.ServiceState._m20.native == global::System.IntPtr.Zero)
				global::android.telephony.ServiceState._m20 = @__env.GetMethodIDNoThrow(global::android.telephony.ServiceState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.ServiceState.staticClass, global::android.telephony.ServiceState._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR5095;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.telephony.ServiceState.staticClass, _CREATOR5095)) as android.os.Parcelable_Creator;
			}
		}
		static ServiceState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.ServiceState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/ServiceState"));
			global::android.telephony.ServiceState._CREATOR5095 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.ServiceState.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
