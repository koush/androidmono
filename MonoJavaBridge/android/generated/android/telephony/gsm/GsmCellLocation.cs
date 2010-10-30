namespace android.telephony.gsm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GsmCellLocation : android.telephony.CellLocation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GsmCellLocation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12037;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._equals12037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12038;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._toString12038)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12039;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._hashCode12039);
		}
		public new int Lac
		{
			get
			{
				return getLac();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLac12040;
		public virtual int getLac()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._getLac12040);
		}
		public new int Cid
		{
			get
			{
				return getCid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCid12041;
		public virtual int getCid()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._getCid12041);
		}
		internal static global::MonoJavaBridge.MethodId _setStateInvalid12042;
		public virtual void setStateInvalid()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._setStateInvalid12042);
		}
		internal static global::MonoJavaBridge.MethodId _fillInNotifierBundle12043;
		public virtual void fillInNotifierBundle(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._fillInNotifierBundle12043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLacAndCid12044;
		public virtual void setLacAndCid(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._setLacAndCid12044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _GsmCellLocation12045;
		public GsmCellLocation() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._GsmCellLocation12045);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GsmCellLocation12046;
		public GsmCellLocation(android.os.Bundle arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._GsmCellLocation12046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static GsmCellLocation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.gsm.GsmCellLocation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/gsm/GsmCellLocation"));
			global::android.telephony.gsm.GsmCellLocation._equals12037 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.telephony.gsm.GsmCellLocation._toString12038 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.gsm.GsmCellLocation._hashCode12039 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "hashCode", "()I");
			global::android.telephony.gsm.GsmCellLocation._getLac12040 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "getLac", "()I");
			global::android.telephony.gsm.GsmCellLocation._getCid12041 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "getCid", "()I");
			global::android.telephony.gsm.GsmCellLocation._setStateInvalid12042 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "setStateInvalid", "()V");
			global::android.telephony.gsm.GsmCellLocation._fillInNotifierBundle12043 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "fillInNotifierBundle", "(Landroid/os/Bundle;)V");
			global::android.telephony.gsm.GsmCellLocation._setLacAndCid12044 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "setLacAndCid", "(II)V");
			global::android.telephony.gsm.GsmCellLocation._GsmCellLocation12045 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "<init>", "()V");
			global::android.telephony.gsm.GsmCellLocation._GsmCellLocation12046 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "<init>", "(Landroid/os/Bundle;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
