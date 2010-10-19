namespace android.telephony.gsm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GsmCellLocation : android.telephony.CellLocation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GsmCellLocation()
		{
			InitJNI();
		}
		protected GsmCellLocation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals7528;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._equals7528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._equals7528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString7529;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._toString7529)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._toString7529)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode7530;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._hashCode7530);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._hashCode7530);
		}
		public new int Lac
		{
			get
			{
				return getLac();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLac7531;
		public virtual int getLac() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._getLac7531);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._getLac7531);
		}
		public new int Cid
		{
			get
			{
				return getCid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCid7532;
		public virtual int getCid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._getCid7532);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._getCid7532);
		}
		internal static global::MonoJavaBridge.MethodId _setStateInvalid7533;
		public virtual void setStateInvalid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._setStateInvalid7533);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._setStateInvalid7533);
		}
		internal static global::MonoJavaBridge.MethodId _fillInNotifierBundle7534;
		public virtual void fillInNotifierBundle(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._fillInNotifierBundle7534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._fillInNotifierBundle7534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLacAndCid7535;
		public virtual void setLacAndCid(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._setLacAndCid7535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._setLacAndCid7535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _GsmCellLocation7536;
		public GsmCellLocation()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._GsmCellLocation7536);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GsmCellLocation7537;
		public GsmCellLocation(android.os.Bundle arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._GsmCellLocation7537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.gsm.GsmCellLocation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/gsm/GsmCellLocation"));
			global::android.telephony.gsm.GsmCellLocation._equals7528 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.telephony.gsm.GsmCellLocation._toString7529 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.gsm.GsmCellLocation._hashCode7530 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "hashCode", "()I");
			global::android.telephony.gsm.GsmCellLocation._getLac7531 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "getLac", "()I");
			global::android.telephony.gsm.GsmCellLocation._getCid7532 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "getCid", "()I");
			global::android.telephony.gsm.GsmCellLocation._setStateInvalid7533 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "setStateInvalid", "()V");
			global::android.telephony.gsm.GsmCellLocation._fillInNotifierBundle7534 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "fillInNotifierBundle", "(Landroid/os/Bundle;)V");
			global::android.telephony.gsm.GsmCellLocation._setLacAndCid7535 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "setLacAndCid", "(II)V");
			global::android.telephony.gsm.GsmCellLocation._GsmCellLocation7536 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "<init>", "()V");
			global::android.telephony.gsm.GsmCellLocation._GsmCellLocation7537 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "<init>", "(Landroid/os/Bundle;)V");
		}
	}
}
