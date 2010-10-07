namespace android.telephony.cdma
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class CdmaCellLocation : android.telephony.CellLocation
	{
		internal new static global::java.lang.Class staticClass;
		static CdmaCellLocation()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.cdma.CdmaCellLocation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.telephony.cdma.CdmaCellLocation(@__env);
			}
		}
		protected CdmaCellLocation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals7234;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.cdma.CdmaCellLocation._equals7234, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._equals7234, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString7235;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.cdma.CdmaCellLocation._toString7235));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._toString7235));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode7236;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation._hashCode7236);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._hashCode7236);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSystemId7237;
		public virtual int getSystemId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation._getSystemId7237);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getSystemId7237);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkId7238;
		public virtual int getNetworkId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation._getNetworkId7238);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getNetworkId7238);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBaseStationId7239;
		public virtual int getBaseStationId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation._getBaseStationId7239);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getBaseStationId7239);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBaseStationLatitude7240;
		public virtual int getBaseStationLatitude() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation._getBaseStationLatitude7240);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getBaseStationLatitude7240);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBaseStationLongitude7241;
		public virtual int getBaseStationLongitude() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.cdma.CdmaCellLocation._getBaseStationLongitude7241);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._getBaseStationLongitude7241);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStateInvalid7242;
		public virtual void setStateInvalid() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation._setStateInvalid7242);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._setStateInvalid7242);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCellLocationData7243;
		public virtual void setCellLocationData(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation._setCellLocationData7243, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._setCellLocationData7243, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCellLocationData7244;
		public virtual void setCellLocationData(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation._setCellLocationData7244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._setCellLocationData7244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fillInNotifierBundle7245;
		public virtual void fillInNotifierBundle(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation._fillInNotifierBundle7245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._fillInNotifierBundle7245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CdmaCellLocation7246;
		public CdmaCellLocation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation7246, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _CdmaCellLocation7247;
		public CdmaCellLocation(android.os.Bundle arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.cdma.CdmaCellLocation.staticClass, global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation7247, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.telephony.cdma.CdmaCellLocation.staticClass = @__class;
			global::android.telephony.cdma.CdmaCellLocation._equals7234 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.telephony.cdma.CdmaCellLocation._toString7235 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.cdma.CdmaCellLocation._hashCode7236 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "hashCode", "()I");
			global::android.telephony.cdma.CdmaCellLocation._getSystemId7237 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getSystemId", "()I");
			global::android.telephony.cdma.CdmaCellLocation._getNetworkId7238 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getNetworkId", "()I");
			global::android.telephony.cdma.CdmaCellLocation._getBaseStationId7239 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationId", "()I");
			global::android.telephony.cdma.CdmaCellLocation._getBaseStationLatitude7240 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationLatitude", "()I");
			global::android.telephony.cdma.CdmaCellLocation._getBaseStationLongitude7241 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationLongitude", "()I");
			global::android.telephony.cdma.CdmaCellLocation._setStateInvalid7242 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setStateInvalid", "()V");
			global::android.telephony.cdma.CdmaCellLocation._setCellLocationData7243 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setCellLocationData", "(IIIII)V");
			global::android.telephony.cdma.CdmaCellLocation._setCellLocationData7244 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setCellLocationData", "(III)V");
			global::android.telephony.cdma.CdmaCellLocation._fillInNotifierBundle7245 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "fillInNotifierBundle", "(Landroid/os/Bundle;)V");
			global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation7246 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "<init>", "()V");
			global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation7247 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "<init>", "(Landroid/os/Bundle;)V");
		}
	}
}
