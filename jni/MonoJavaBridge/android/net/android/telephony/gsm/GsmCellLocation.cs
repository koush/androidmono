namespace android.telephony.gsm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GsmCellLocation : android.telephony.CellLocation
	{ 
		internal new static global::java.lang.Class staticClass; 
		static GsmCellLocation() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.telephony.gsm.GsmCellLocation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode6336; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.GsmCellLocation)) 
				return @__env.CallIntMethod(this, _hashCode6336); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.gsm.GsmCellLocation.staticClass, _hashCode6336); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals6337; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.GsmCellLocation)) 
				return @__env.CallBooleanMethod(this, _equals6337, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.gsm.GsmCellLocation.staticClass, _equals6337, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString6338; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.GsmCellLocation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString6338)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.gsm.GsmCellLocation.staticClass, _toString6338)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLac6339; 
		public virtual int getLac() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.GsmCellLocation)) 
				return @__env.CallIntMethod(this, _getLac6339); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.gsm.GsmCellLocation.staticClass, _getLac6339); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCid6340; 
		public virtual int getCid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.GsmCellLocation)) 
				return @__env.CallIntMethod(this, _getCid6340); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.gsm.GsmCellLocation.staticClass, _getCid6340); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStateInvalid6341; 
		public virtual void setStateInvalid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.GsmCellLocation)) 
				@__env.CallVoidMethod(this, _setStateInvalid6341); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.gsm.GsmCellLocation.staticClass, _setStateInvalid6341); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fillInNotifierBundle6342; 
		public virtual void fillInNotifierBundle(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.GsmCellLocation)) 
				@__env.CallVoidMethod(this, _fillInNotifierBundle6342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.gsm.GsmCellLocation.staticClass, _fillInNotifierBundle6342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLacAndCid6343; 
		public virtual void setLacAndCid(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.gsm.GsmCellLocation)) 
				@__env.CallVoidMethod(this, _setLacAndCid6343, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.gsm.GsmCellLocation.staticClass, _setLacAndCid6343, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GsmCellLocation6344; 
		public GsmCellLocation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.gsm.GsmCellLocation.staticClass, _GsmCellLocation6344, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GsmCellLocation6345; 
		public GsmCellLocation(android.os.Bundle arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.gsm.GsmCellLocation.staticClass, _GsmCellLocation6345, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.telephony.gsm.GsmCellLocation.staticClass = @__class; 
			global::android.telephony.gsm.GsmCellLocation._hashCode6336 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "hashCode", "()I"); 
			global::android.telephony.gsm.GsmCellLocation._equals6337 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.telephony.gsm.GsmCellLocation._toString6338 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.telephony.gsm.GsmCellLocation._getLac6339 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "getLac", "()I"); 
			global::android.telephony.gsm.GsmCellLocation._getCid6340 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "getCid", "()I"); 
			global::android.telephony.gsm.GsmCellLocation._setStateInvalid6341 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "setStateInvalid", "()V"); 
			global::android.telephony.gsm.GsmCellLocation._fillInNotifierBundle6342 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "fillInNotifierBundle", "(Landroid/os/Bundle;)V"); 
			global::android.telephony.gsm.GsmCellLocation._setLacAndCid6343 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "setLacAndCid", "(II)V"); 
			global::android.telephony.gsm.GsmCellLocation._GsmCellLocation6344 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "<init>", "()V"); 
			global::android.telephony.gsm.GsmCellLocation._GsmCellLocation6345 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "<init>", "(Landroid/os/Bundle;)V"); 
		} 
	} 
} 
