namespace android.telephony.cdma
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CdmaCellLocation : android.telephony.CellLocation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CdmaCellLocation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.telephony.cdma.CdmaCellLocation._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, "toString", "()Ljava/lang/String;", ref global::android.telephony.cdma.CdmaCellLocation._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, "hashCode", "()I", ref global::android.telephony.cdma.CdmaCellLocation._m2);
		}
		public new int SystemId
		{
			get
			{
				return getSystemId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, "getSystemId", "()I", ref global::android.telephony.cdma.CdmaCellLocation._m3);
		}
		public new int NetworkId
		{
			get
			{
				return getNetworkId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getNetworkId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, "getNetworkId", "()I", ref global::android.telephony.cdma.CdmaCellLocation._m4);
		}
		public new int BaseStationId
		{
			get
			{
				return getBaseStationId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getBaseStationId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationId", "()I", ref global::android.telephony.cdma.CdmaCellLocation._m5);
		}
		public new int BaseStationLatitude
		{
			get
			{
				return getBaseStationLatitude();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getBaseStationLatitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationLatitude", "()I", ref global::android.telephony.cdma.CdmaCellLocation._m6);
		}
		public new int BaseStationLongitude
		{
			get
			{
				return getBaseStationLongitude();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getBaseStationLongitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationLongitude", "()I", ref global::android.telephony.cdma.CdmaCellLocation._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setStateInvalid()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, "setStateInvalid", "()V", ref global::android.telephony.cdma.CdmaCellLocation._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setCellLocationData(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, "setCellLocationData", "(IIIII)V", ref global::android.telephony.cdma.CdmaCellLocation._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setCellLocationData(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, "setCellLocationData", "(III)V", ref global::android.telephony.cdma.CdmaCellLocation._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void fillInNotifierBundle(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, "fillInNotifierBundle", "(Landroid/os/Bundle;)V", ref global::android.telephony.cdma.CdmaCellLocation._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public CdmaCellLocation() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._m12.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._m12 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._m12);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public CdmaCellLocation(android.os.Bundle arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.cdma.CdmaCellLocation._m13.native == global::System.IntPtr.Zero)
				global::android.telephony.cdma.CdmaCellLocation._m13 = @__env.GetMethodIDNoThrow(global::android.telephony.cdma.CdmaCellLocation.staticClass, "<init>", "(Landroid/os/Bundle;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CdmaCellLocation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.cdma.CdmaCellLocation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/cdma/CdmaCellLocation"));
		}
	}
}
