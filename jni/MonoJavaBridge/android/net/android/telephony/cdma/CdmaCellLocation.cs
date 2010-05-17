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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode6322; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return @__env.CallIntMethod(this, _hashCode6322); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _hashCode6322); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals6323; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return @__env.CallBooleanMethod(this, _equals6323, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _equals6323, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString6324; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString6324)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.cdma.CdmaCellLocation.staticClass, _toString6324)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSystemId6325; 
		public virtual int getSystemId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return @__env.CallIntMethod(this, _getSystemId6325); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _getSystemId6325); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkId6326; 
		public virtual int getNetworkId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return @__env.CallIntMethod(this, _getNetworkId6326); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _getNetworkId6326); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseStationId6327; 
		public virtual int getBaseStationId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return @__env.CallIntMethod(this, _getBaseStationId6327); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _getBaseStationId6327); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseStationLatitude6328; 
		public virtual int getBaseStationLatitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return @__env.CallIntMethod(this, _getBaseStationLatitude6328); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _getBaseStationLatitude6328); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseStationLongitude6329; 
		public virtual int getBaseStationLongitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				return @__env.CallIntMethod(this, _getBaseStationLongitude6329); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _getBaseStationLongitude6329); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStateInvalid6330; 
		public virtual void setStateInvalid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				@__env.CallVoidMethod(this, _setStateInvalid6330); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _setStateInvalid6330); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCellLocationData6331; 
		public virtual void setCellLocationData(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				@__env.CallVoidMethod(this, _setCellLocationData6331, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _setCellLocationData6331, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCellLocationData6332; 
		public virtual void setCellLocationData(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				@__env.CallVoidMethod(this, _setCellLocationData6332, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _setCellLocationData6332, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fillInNotifierBundle6333; 
		public virtual void fillInNotifierBundle(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.cdma.CdmaCellLocation)) 
				@__env.CallVoidMethod(this, _fillInNotifierBundle6333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.cdma.CdmaCellLocation.staticClass, _fillInNotifierBundle6333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CdmaCellLocation6334; 
		public CdmaCellLocation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.cdma.CdmaCellLocation.staticClass, _CdmaCellLocation6334, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CdmaCellLocation6335; 
		public CdmaCellLocation(android.os.Bundle arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.cdma.CdmaCellLocation.staticClass, _CdmaCellLocation6335, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.telephony.cdma.CdmaCellLocation.staticClass = @__class; 
			global::android.telephony.cdma.CdmaCellLocation._hashCode6322 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "hashCode", "()I"); 
			global::android.telephony.cdma.CdmaCellLocation._equals6323 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.telephony.cdma.CdmaCellLocation._toString6324 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.telephony.cdma.CdmaCellLocation._getSystemId6325 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getSystemId", "()I"); 
			global::android.telephony.cdma.CdmaCellLocation._getNetworkId6326 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getNetworkId", "()I"); 
			global::android.telephony.cdma.CdmaCellLocation._getBaseStationId6327 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationId", "()I"); 
			global::android.telephony.cdma.CdmaCellLocation._getBaseStationLatitude6328 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationLatitude", "()I"); 
			global::android.telephony.cdma.CdmaCellLocation._getBaseStationLongitude6329 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "getBaseStationLongitude", "()I"); 
			global::android.telephony.cdma.CdmaCellLocation._setStateInvalid6330 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setStateInvalid", "()V"); 
			global::android.telephony.cdma.CdmaCellLocation._setCellLocationData6331 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setCellLocationData", "(IIIII)V"); 
			global::android.telephony.cdma.CdmaCellLocation._setCellLocationData6332 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "setCellLocationData", "(III)V"); 
			global::android.telephony.cdma.CdmaCellLocation._fillInNotifierBundle6333 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "fillInNotifierBundle", "(Landroid/os/Bundle;)V"); 
			global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation6334 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "<init>", "()V"); 
			global::android.telephony.cdma.CdmaCellLocation._CdmaCellLocation6335 = @__env.GetMethodID(global::android.telephony.cdma.CdmaCellLocation.staticClass, "<init>", "(Landroid/os/Bundle;)V"); 
		} 
	} 
} 
