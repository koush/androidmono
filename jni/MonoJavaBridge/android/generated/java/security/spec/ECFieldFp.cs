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
		internal static global::MonoJavaBridge.MethodId _equals18260;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.spec.ECFieldFp._equals18260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.spec.ECFieldFp.staticClass, global::java.security.spec.ECFieldFp._equals18260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode18261;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.ECFieldFp._hashCode18261);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.ECFieldFp.staticClass, global::java.security.spec.ECFieldFp._hashCode18261);
		}
		public new global::java.math.BigInteger P
		{
			get
			{
				return getP();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getP18262;
		public virtual global::java.math.BigInteger getP() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECFieldFp._getP18262)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECFieldFp.staticClass, global::java.security.spec.ECFieldFp._getP18262)) as java.math.BigInteger;
		}
		public new int FieldSize
		{
			get
			{
				return getFieldSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFieldSize18263;
		public virtual int getFieldSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.ECFieldFp._getFieldSize18263);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.ECFieldFp.staticClass, global::java.security.spec.ECFieldFp._getFieldSize18263);
		}
		internal static global::MonoJavaBridge.MethodId _ECFieldFp18264;
		public ECFieldFp(java.math.BigInteger arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECFieldFp.staticClass, global::java.security.spec.ECFieldFp._ECFieldFp18264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECFieldFp.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECFieldFp"));
			global::java.security.spec.ECFieldFp._equals18260 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldFp.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.spec.ECFieldFp._hashCode18261 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldFp.staticClass, "hashCode", "()I");
			global::java.security.spec.ECFieldFp._getP18262 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldFp.staticClass, "getP", "()Ljava/math/BigInteger;");
			global::java.security.spec.ECFieldFp._getFieldSize18263 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldFp.staticClass, "getFieldSize", "()I");
			global::java.security.spec.ECFieldFp._ECFieldFp18264 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldFp.staticClass, "<init>", "(Ljava/math/BigInteger;)V");
		}
	}
}
