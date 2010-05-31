namespace android.telephony.gsm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GsmCellLocation : android.telephony.CellLocation
	{ 
		internal new static global::java.lang.Class staticClass; 
		static GsmCellLocation() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.gsm.GsmCellLocation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.telephony.gsm.GsmCellLocation(@__env); 
			} 
		} 
		protected GsmCellLocation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode6624; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.telephony.gsm.GsmCellLocation._hashCode6624); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._hashCode6624); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals6625; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.GsmCellLocation._equals6625, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._equals6625, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString6626; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.GsmCellLocation._toString6626)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._toString6626)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLac6627; 
		public virtual int getLac() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.telephony.gsm.GsmCellLocation._getLac6627); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._getLac6627); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCid6628; 
		public virtual int getCid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.telephony.gsm.GsmCellLocation._getCid6628); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._getCid6628); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStateInvalid6629; 
		public virtual void setStateInvalid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.telephony.gsm.GsmCellLocation._setStateInvalid6629); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._setStateInvalid6629); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fillInNotifierBundle6630; 
		public virtual void fillInNotifierBundle(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.telephony.gsm.GsmCellLocation._fillInNotifierBundle6630, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._fillInNotifierBundle6630, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLacAndCid6631; 
		public virtual void setLacAndCid(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.telephony.gsm.GsmCellLocation._setLacAndCid6631, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._setLacAndCid6631, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GsmCellLocation6632; 
		public GsmCellLocation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._GsmCellLocation6632, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GsmCellLocation6633; 
		public GsmCellLocation(android.os.Bundle arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._GsmCellLocation6633, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.telephony.gsm.GsmCellLocation.staticClass = @__class; 
			global::android.telephony.gsm.GsmCellLocation._hashCode6624 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "hashCode", "()I"); 
			global::android.telephony.gsm.GsmCellLocation._equals6625 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.telephony.gsm.GsmCellLocation._toString6626 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.telephony.gsm.GsmCellLocation._getLac6627 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "getLac", "()I"); 
			global::android.telephony.gsm.GsmCellLocation._getCid6628 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "getCid", "()I"); 
			global::android.telephony.gsm.GsmCellLocation._setStateInvalid6629 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "setStateInvalid", "()V"); 
			global::android.telephony.gsm.GsmCellLocation._fillInNotifierBundle6630 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "fillInNotifierBundle", "(Landroid/os/Bundle;)V"); 
			global::android.telephony.gsm.GsmCellLocation._setLacAndCid6631 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "setLacAndCid", "(II)V"); 
			global::android.telephony.gsm.GsmCellLocation._GsmCellLocation6632 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "<init>", "()V"); 
			global::android.telephony.gsm.GsmCellLocation._GsmCellLocation6633 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "<init>", "(Landroid/os/Bundle;)V"); 
		} 
	} 
} 
