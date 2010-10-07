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
		internal static global::net.sf.jni4net.jni.MethodId _equals7248;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.gsm.GsmCellLocation._equals7248, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._equals7248, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString7249;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.gsm.GsmCellLocation._toString7249));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._toString7249));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode7250;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.gsm.GsmCellLocation._hashCode7250);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._hashCode7250);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLac7251;
		public virtual int getLac() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.gsm.GsmCellLocation._getLac7251);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._getLac7251);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCid7252;
		public virtual int getCid() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.gsm.GsmCellLocation._getCid7252);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._getCid7252);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStateInvalid7253;
		public virtual void setStateInvalid() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.gsm.GsmCellLocation._setStateInvalid7253);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._setStateInvalid7253);
		}
		internal static global::net.sf.jni4net.jni.MethodId _fillInNotifierBundle7254;
		public virtual void fillInNotifierBundle(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.gsm.GsmCellLocation._fillInNotifierBundle7254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._fillInNotifierBundle7254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLacAndCid7255;
		public virtual void setLacAndCid(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.gsm.GsmCellLocation._setLacAndCid7255, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._setLacAndCid7255, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GsmCellLocation7256;
		public GsmCellLocation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._GsmCellLocation7256, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _GsmCellLocation7257;
		public GsmCellLocation(android.os.Bundle arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._GsmCellLocation7257, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.telephony.gsm.GsmCellLocation.staticClass = @__class;
			global::android.telephony.gsm.GsmCellLocation._equals7248 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.telephony.gsm.GsmCellLocation._toString7249 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.gsm.GsmCellLocation._hashCode7250 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "hashCode", "()I");
			global::android.telephony.gsm.GsmCellLocation._getLac7251 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "getLac", "()I");
			global::android.telephony.gsm.GsmCellLocation._getCid7252 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "getCid", "()I");
			global::android.telephony.gsm.GsmCellLocation._setStateInvalid7253 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "setStateInvalid", "()V");
			global::android.telephony.gsm.GsmCellLocation._fillInNotifierBundle7254 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "fillInNotifierBundle", "(Landroid/os/Bundle;)V");
			global::android.telephony.gsm.GsmCellLocation._setLacAndCid7255 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "setLacAndCid", "(II)V");
			global::android.telephony.gsm.GsmCellLocation._GsmCellLocation7256 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "<init>", "()V");
			global::android.telephony.gsm.GsmCellLocation._GsmCellLocation7257 = @__env.GetMethodID(global::android.telephony.gsm.GsmCellLocation.staticClass, "<init>", "(Landroid/os/Bundle;)V");
		}
	}
}
