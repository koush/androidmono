namespace android.telephony.gsm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GsmCellLocation : android.telephony.CellLocation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GsmCellLocation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.telephony.gsm.GsmCellLocation._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.gsm.GsmCellLocation.staticClass, "toString", "()Ljava/lang/String;", ref global::android.telephony.gsm.GsmCellLocation._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, "hashCode", "()I", ref global::android.telephony.gsm.GsmCellLocation._m2);
		}
		public new int Lac
		{
			get
			{
				return getLac();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getLac()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, "getLac", "()I", ref global::android.telephony.gsm.GsmCellLocation._m3);
		}
		public new int Cid
		{
			get
			{
				return getCid();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getCid()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, "getCid", "()I", ref global::android.telephony.gsm.GsmCellLocation._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setStateInvalid()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, "setStateInvalid", "()V", ref global::android.telephony.gsm.GsmCellLocation._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void fillInNotifierBundle(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, "fillInNotifierBundle", "(Landroid/os/Bundle;)V", ref global::android.telephony.gsm.GsmCellLocation._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setLacAndCid(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.gsm.GsmCellLocation.staticClass, "setLacAndCid", "(II)V", ref global::android.telephony.gsm.GsmCellLocation._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public GsmCellLocation() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.gsm.GsmCellLocation._m8.native == global::System.IntPtr.Zero)
				global::android.telephony.gsm.GsmCellLocation._m8 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._m8);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public GsmCellLocation(android.os.Bundle arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.gsm.GsmCellLocation._m9.native == global::System.IntPtr.Zero)
				global::android.telephony.gsm.GsmCellLocation._m9 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "<init>", "(Landroid/os/Bundle;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static GsmCellLocation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.gsm.GsmCellLocation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/gsm/GsmCellLocation"));
		}
	}
}
