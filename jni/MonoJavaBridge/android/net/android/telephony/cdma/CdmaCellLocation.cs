namespace android.telephony.cdma 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class CdmaCellLocation : android.telephony.CellLocation
	{ 
		internal new static global::java.lang.Class staticClass; 
		static CdmaCellLocation() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.telephony.cdma.CdmaCellLocation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode6610; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return @__env.CallIntMethod(this, _hashCode6610); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _hashCode6610); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals6611; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return @__env.CallBooleanMethod(this, _equals6611, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _equals6611, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString6612; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString6612)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.cdma.CdmaCellLocation.staticClass, _toString6612)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSystemId6613; 
		public virtual int getSystemId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return @__env.CallIntMethod(this, _getSystemId6613); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _getSystemId6613); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkId6614; 
		public virtual int getNetworkId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return @__env.CallIntMethod(this, _getNetworkId6614); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _getNetworkId6614); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseStationId6615; 
		public virtual int getBaseStationId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return @__env.CallIntMethod(this, _getBaseStationId6615); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _getBaseStationId6615); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseStationLatitude6616; 
		public virtual int getBaseStationLatitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return @__env.CallIntMethod(this, _getBaseStationLatitude6616); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _getBaseStationLatitude6616); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseStationLongitude6617; 
		public virtual int getBaseStationLongitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return @__env.CallIntMethod(this, _getBaseStationLongitude6617); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _getBaseStationLongitude6617); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStateInvalid6618; 
		public virtual void setStateInvalid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				@__env.CallVoidMethod(this, _setStateInvalid6618); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _setStateInvalid6618); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCellLocationData6619; 
		public virtual void setCellLocationData(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				@__env.CallVoidMethod(this, _setCellLocationData6619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _setCellLocationData6619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCellLocationData6620; 
		public virtual void setCellLocationData(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				@__env.CallVoidMethod(this, _setCellLocationData6620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _setCellLocationData6620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fillInNotifierBundle6621; 
		public virtual void fillInNotifierBundle(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				@__env.CallVoidMethod(this, _fillInNotifierBundle6621, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _fillInNotifierBundle6621, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CdmaCellLocation6622; 
		public CdmaCellLocation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.cdma.CdmaCellLocation.staticClass, _CdmaCellLocation6622, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CdmaCellLocation6623; 
		public CdmaCellLocation(android.os.Bundle arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.cdma.CdmaCellLocation.staticClass, _CdmaCellLocation6623, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.telephony.cdma.CdmaCellLocation.staticClass = @__class; 
			global::android.telephony.cdma.CdmaCellLocation._hashCode6610 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "hashCode", "()I"); 
			global::android.telephony.cdma.CdmaCellLocation._equals6611 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.telephony.cdma.CdmaCellLocation._toString6612 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.telephony.cdma.CdmaCellLocation._getSystemId6613 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getSystemId", "()I"); 
			global::android.telephony.cdma.CdmaCellLocation._getNetworkId6614 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getNetworkId", "()I"); 
			global::android.telephony.cdma.CdmaCellLocation._getBaseStationId6615 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationId", "()I"); 
			global::android.telephony.cdma.CdmaCellLocation._getBaseStationLatitude6616 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationLatitude", "()I"); 
			global::android.telephony.cdma.CdmaCellLocation._getBaseStationLongitude6617 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationLongitude", "()I"); 
			global::android.telephony.cdma.CdmaCellLocation._setStateInvalid6618 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setStateInvalid", "()V"); 
			global::android.telephony.cdma.CdmaCellLocation._setCellLocationData6619 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setCellLocationData", "(IIIII)V"); 
			global::android.telephony.cdma.CdmaCellLocation._setCellLocationData6620 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setCellLocationData", "(III)V"); 
			global::android.telephony.cdma.CdmaCellLocation._fillInNotifierBundle6621 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "fillInNotifierBundle", "(Landroid/os/Bundle;)V"); 
			global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation6622 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "<init>", "()V"); 
			global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation6623 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "<init>", "(Landroid/os/Bundle;)V"); 
		} 
	} 
} 
