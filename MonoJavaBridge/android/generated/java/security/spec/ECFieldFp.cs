namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ECFieldFp : java.lang.Object, ECField
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ECFieldFp(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.spec.ECFieldFp.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.spec.ECFieldFp._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.ECFieldFp.staticClass, "hashCode", "()I", ref global::java.security.spec.ECFieldFp._m1);
		}
		public new global::java.math.BigInteger P
		{
			get
			{
				return getP();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.math.BigInteger getP()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.ECFieldFp.staticClass, "getP", "()Ljava/math/BigInteger;", ref global::java.security.spec.ECFieldFp._m2) as java.math.BigInteger;
		}
		public new int FieldSize
		{
			get
			{
				return getFieldSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getFieldSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.ECFieldFp.staticClass, "getFieldSize", "()I", ref global::java.security.spec.ECFieldFp._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ECFieldFp(java.math.BigInteger arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECFieldFp._m4.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECFieldFp._m4 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldFp.staticClass, "<init>", "(Ljava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECFieldFp.staticClass, global::java.security.spec.ECFieldFp._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ECFieldFp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECFieldFp.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECFieldFp"));
		}
	}
}
