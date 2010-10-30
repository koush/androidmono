namespace android.telephony.cdma
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CdmaCellLocation : android.telephony.CellLocation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CdmaCellLocation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12023;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._equals12023.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._equals12023 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._equals12023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12024;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._toString12024.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._toString12024 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._toString12024) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12025;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._hashCode12025.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._hashCode12025 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._hashCode12025);
		}
		public new int SystemId
		{
			get
			{
				return getSystemId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId12026;
		public virtual int getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._getSystemId12026.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._getSystemId12026 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getSystemId", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getSystemId12026);
		}
		public new int NetworkId
		{
			get
			{
				return getNetworkId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkId12027;
		public virtual int getNetworkId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._getNetworkId12027.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._getNetworkId12027 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getNetworkId", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getNetworkId12027);
		}
		public new int BaseStationId
		{
			get
			{
				return getBaseStationId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseStationId12028;
		public virtual int getBaseStationId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._getBaseStationId12028.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._getBaseStationId12028 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationId", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getBaseStationId12028);
		}
		public new int BaseStationLatitude
		{
			get
			{
				return getBaseStationLatitude();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseStationLatitude12029;
		public virtual int getBaseStationLatitude()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._getBaseStationLatitude12029.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._getBaseStationLatitude12029 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationLatitude", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getBaseStationLatitude12029);
		}
		public new int BaseStationLongitude
		{
			get
			{
				return getBaseStationLongitude();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseStationLongitude12030;
		public virtual int getBaseStationLongitude()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._getBaseStationLongitude12030.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._getBaseStationLongitude12030 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationLongitude", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getBaseStationLongitude12030);
		}
		internal static global::MonoJavaBridge.MethodId _setStateInvalid12031;
		public virtual void setStateInvalid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._setStateInvalid12031.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._setStateInvalid12031 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setStateInvalid", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._setStateInvalid12031);
		}
		internal static global::MonoJavaBridge.MethodId _setCellLocationData12032;
		public virtual void setCellLocationData(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._setCellLocationData12032.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._setCellLocationData12032 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setCellLocationData", "(IIIII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._setCellLocationData12032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _setCellLocationData12033;
		public virtual void setCellLocationData(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._setCellLocationData12033.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._setCellLocationData12033 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setCellLocationData", "(III)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._setCellLocationData12033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _fillInNotifierBundle12034;
		public virtual void fillInNotifierBundle(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._fillInNotifierBundle12034.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._fillInNotifierBundle12034 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "fillInNotifierBundle", "(Landroid/os/Bundle;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._fillInNotifierBundle12034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CdmaCellLocation12035;
		public CdmaCellLocation() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation12035.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation12035 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation12035);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CdmaCellLocation12036;
		public CdmaCellLocation(android.os.Bundle arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation12036.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation12036 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "<init>", "(Landroid/os/Bundle;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation12036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CdmaCellLocation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.cdma.CdmaCellLocation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/cdma/CdmaCellLocation"));
		}
		internal static void InitJNI()
		{
		}
	}
}
