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
		internal static global::MonoJavaBridge.MethodId _equals11980;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._equals11980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._equals11980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString11981;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._toString11981)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._toString11981)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode11982;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._hashCode11982);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._hashCode11982);
		}
		public new int Lac
		{
			get
			{
				return getLac();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLac11983;
		public virtual int getLac() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._getLac11983);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._getLac11983);
		}
		public new int Cid
		{
			get
			{
				return getCid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCid11984;
		public virtual int getCid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._getCid11984);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._getCid11984);
		}
		internal static global::MonoJavaBridge.MethodId _setStateInvalid11985;
		public virtual void setStateInvalid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._setStateInvalid11985);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._setStateInvalid11985);
		}
		internal static global::MonoJavaBridge.MethodId _fillInNotifierBundle11986;
		public virtual void fillInNotifierBundle(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._fillInNotifierBundle11986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._fillInNotifierBundle11986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLacAndCid11987;
		public virtual void setLacAndCid(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation._setLacAndCid11987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._setLacAndCid11987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _GsmCellLocation11988;
		public GsmCellLocation()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._GsmCellLocation11988);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GsmCellLocation11989;
		public GsmCellLocation(android.os.Bundle arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.gsm.GsmCellLocation.staticClass, global::android.telephony.gsm.GsmCellLocation._GsmCellLocation11989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.gsm.GsmCellLocation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/gsm/GsmCellLocation"));
			global::android.telephony.gsm.GsmCellLocation._equals11980 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.telephony.gsm.GsmCellLocation._toString11981 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.gsm.GsmCellLocation._hashCode11982 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "hashCode", "()I");
			global::android.telephony.gsm.GsmCellLocation._getLac11983 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "getLac", "()I");
			global::android.telephony.gsm.GsmCellLocation._getCid11984 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "getCid", "()I");
			global::android.telephony.gsm.GsmCellLocation._setStateInvalid11985 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "setStateInvalid", "()V");
			global::android.telephony.gsm.GsmCellLocation._fillInNotifierBundle11986 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "fillInNotifierBundle", "(Landroid/os/Bundle;)V");
			global::android.telephony.gsm.GsmCellLocation._setLacAndCid11987 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "setLacAndCid", "(II)V");
			global::android.telephony.gsm.GsmCellLocation._GsmCellLocation11988 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "<init>", "()V");
			global::android.telephony.gsm.GsmCellLocation._GsmCellLocation11989 = @__env.GetMethodIDNoThrow(global::android.telephony.gsm.GsmCellLocation.staticClass, "<init>", "(Landroid/os/Bundle;)V");
		}
	}
}
