namespace android.telephony.cdma
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CdmaCellLocation : android.telephony.CellLocation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CdmaCellLocation()
		{
			InitJNI();
		}
		protected CdmaCellLocation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals11966;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._equals11966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._equals11966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString11967;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._toString11967)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._toString11967)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode11968;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._hashCode11968);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._hashCode11968);
		}
		public new int SystemId
		{
			get
			{
				return getSystemId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId11969;
		public virtual int getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._getSystemId11969);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getSystemId11969);
		}
		public new int NetworkId
		{
			get
			{
				return getNetworkId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkId11970;
		public virtual int getNetworkId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._getNetworkId11970);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getNetworkId11970);
		}
		public new int BaseStationId
		{
			get
			{
				return getBaseStationId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseStationId11971;
		public virtual int getBaseStationId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._getBaseStationId11971);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getBaseStationId11971);
		}
		public new int BaseStationLatitude
		{
			get
			{
				return getBaseStationLatitude();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseStationLatitude11972;
		public virtual int getBaseStationLatitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._getBaseStationLatitude11972);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getBaseStationLatitude11972);
		}
		public new int BaseStationLongitude
		{
			get
			{
				return getBaseStationLongitude();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseStationLongitude11973;
		public virtual int getBaseStationLongitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._getBaseStationLongitude11973);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getBaseStationLongitude11973);
		}
		internal static global::MonoJavaBridge.MethodId _setStateInvalid11974;
		public virtual void setStateInvalid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._setStateInvalid11974);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._setStateInvalid11974);
		}
		internal static global::MonoJavaBridge.MethodId _setCellLocationData11975;
		public virtual void setCellLocationData(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._setCellLocationData11975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._setCellLocationData11975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _setCellLocationData11976;
		public virtual void setCellLocationData(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._setCellLocationData11976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._setCellLocationData11976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _fillInNotifierBundle11977;
		public virtual void fillInNotifierBundle(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._fillInNotifierBundle11977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._fillInNotifierBundle11977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CdmaCellLocation11978;
		public CdmaCellLocation()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation11978);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CdmaCellLocation11979;
		public CdmaCellLocation(android.os.Bundle arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation11979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.cdma.CdmaCellLocation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/cdma/CdmaCellLocation"));
			global::android.telephony.cdma.CdmaCellLocation._equals11966 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.telephony.cdma.CdmaCellLocation._toString11967 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.cdma.CdmaCellLocation._hashCode11968 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "hashCode", "()I");
			global::android.telephony.cdma.CdmaCellLocation._getSystemId11969 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getSystemId", "()I");
			global::android.telephony.cdma.CdmaCellLocation._getNetworkId11970 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getNetworkId", "()I");
			global::android.telephony.cdma.CdmaCellLocation._getBaseStationId11971 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationId", "()I");
			global::android.telephony.cdma.CdmaCellLocation._getBaseStationLatitude11972 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationLatitude", "()I");
			global::android.telephony.cdma.CdmaCellLocation._getBaseStationLongitude11973 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationLongitude", "()I");
			global::android.telephony.cdma.CdmaCellLocation._setStateInvalid11974 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setStateInvalid", "()V");
			global::android.telephony.cdma.CdmaCellLocation._setCellLocationData11975 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setCellLocationData", "(IIIII)V");
			global::android.telephony.cdma.CdmaCellLocation._setCellLocationData11976 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setCellLocationData", "(III)V");
			global::android.telephony.cdma.CdmaCellLocation._fillInNotifierBundle11977 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "fillInNotifierBundle", "(Landroid/os/Bundle;)V");
			global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation11978 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "<init>", "()V");
			global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation11979 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "<init>", "(Landroid/os/Bundle;)V");
		}
	}
}
