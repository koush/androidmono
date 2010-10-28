namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ECFieldFp : java.lang.Object, ECField
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ECFieldFp()
		{
			InitJNI();
		}
		protected ECFieldFp(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals23988;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.spec.ECFieldFp._equals23988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.spec.ECFieldFp.staticClass, global::java.security.spec.ECFieldFp._equals23988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23989;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.ECFieldFp._hashCode23989);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.ECFieldFp.staticClass, global::java.security.spec.ECFieldFp._hashCode23989);
		}
		public new global::java.math.BigInteger P
		{
			get
			{
				return getP();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getP23990;
		public virtual global::java.math.BigInteger getP()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECFieldFp._getP23990)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECFieldFp.staticClass, global::java.security.spec.ECFieldFp._getP23990)) as java.math.BigInteger;
		}
		public new int FieldSize
		{
			get
			{
				return getFieldSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFieldSize23991;
		public virtual int getFieldSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.ECFieldFp._getFieldSize23991);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.ECFieldFp.staticClass, global::java.security.spec.ECFieldFp._getFieldSize23991);
		}
		internal static global::MonoJavaBridge.MethodId _ECFieldFp23992;
		public ECFieldFp(java.math.BigInteger arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECFieldFp.staticClass, global::java.security.spec.ECFieldFp._ECFieldFp23992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECFieldFp.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECFieldFp"));
			global::java.security.spec.ECFieldFp._equals23988 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldFp.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.spec.ECFieldFp._hashCode23989 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldFp.staticClass, "hashCode", "()I");
			global::java.security.spec.ECFieldFp._getP23990 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldFp.staticClass, "getP", "()Ljava/math/BigInteger;");
			global::java.security.spec.ECFieldFp._getFieldSize23991 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldFp.staticClass, "getFieldSize", "()I");
			global::java.security.spec.ECFieldFp._ECFieldFp23992 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldFp.staticClass, "<init>", "(Ljava/math/BigInteger;)V");
		}
	}
}
