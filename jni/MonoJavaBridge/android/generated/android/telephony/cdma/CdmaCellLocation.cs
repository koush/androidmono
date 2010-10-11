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
		internal static global::MonoJavaBridge.MethodId _equals7514;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._equals7514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._equals7514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString7515;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._toString7515)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._toString7515)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode7516;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._hashCode7516);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._hashCode7516);
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId7517;
		public virtual int getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._getSystemId7517);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getSystemId7517);
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkId7518;
		public virtual int getNetworkId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._getNetworkId7518);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getNetworkId7518);
		}
		internal static global::MonoJavaBridge.MethodId _getBaseStationId7519;
		public virtual int getBaseStationId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._getBaseStationId7519);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getBaseStationId7519);
		}
		internal static global::MonoJavaBridge.MethodId _getBaseStationLatitude7520;
		public virtual int getBaseStationLatitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._getBaseStationLatitude7520);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getBaseStationLatitude7520);
		}
		internal static global::MonoJavaBridge.MethodId _getBaseStationLongitude7521;
		public virtual int getBaseStationLongitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._getBaseStationLongitude7521);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getBaseStationLongitude7521);
		}
		internal static global::MonoJavaBridge.MethodId _setStateInvalid7522;
		public virtual void setStateInvalid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._setStateInvalid7522);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._setStateInvalid7522);
		}
		internal static global::MonoJavaBridge.MethodId _setCellLocationData7523;
		public virtual void setCellLocationData(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._setCellLocationData7523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._setCellLocationData7523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _setCellLocationData7524;
		public virtual void setCellLocationData(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._setCellLocationData7524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._setCellLocationData7524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _fillInNotifierBundle7525;
		public virtual void fillInNotifierBundle(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation._fillInNotifierBundle7525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._fillInNotifierBundle7525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CdmaCellLocation7526;
		public CdmaCellLocation()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation7526);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CdmaCellLocation7527;
		public CdmaCellLocation(android.os.Bundle arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation7527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.cdma.CdmaCellLocation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/cdma/CdmaCellLocation"));
			global::android.telephony.cdma.CdmaCellLocation._equals7514 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.telephony.cdma.CdmaCellLocation._toString7515 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.cdma.CdmaCellLocation._hashCode7516 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "hashCode", "()I");
			global::android.telephony.cdma.CdmaCellLocation._getSystemId7517 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getSystemId", "()I");
			global::android.telephony.cdma.CdmaCellLocation._getNetworkId7518 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getNetworkId", "()I");
			global::android.telephony.cdma.CdmaCellLocation._getBaseStationId7519 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationId", "()I");
			global::android.telephony.cdma.CdmaCellLocation._getBaseStationLatitude7520 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationLatitude", "()I");
			global::android.telephony.cdma.CdmaCellLocation._getBaseStationLongitude7521 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationLongitude", "()I");
			global::android.telephony.cdma.CdmaCellLocation._setStateInvalid7522 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setStateInvalid", "()V");
			global::android.telephony.cdma.CdmaCellLocation._setCellLocationData7523 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setCellLocationData", "(IIIII)V");
			global::android.telephony.cdma.CdmaCellLocation._setCellLocationData7524 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setCellLocationData", "(III)V");
			global::android.telephony.cdma.CdmaCellLocation._fillInNotifierBundle7525 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "fillInNotifierBundle", "(Landroid/os/Bundle;)V");
			global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation7526 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "<init>", "()V");
			global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation7527 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "<init>", "(Landroid/os/Bundle;)V");
		}
	}
}
