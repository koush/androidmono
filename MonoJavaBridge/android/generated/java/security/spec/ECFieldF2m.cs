namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ECFieldF2m : java.lang.Object, ECField
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ECFieldF2m(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.spec.ECFieldF2m.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.spec.ECFieldF2m._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.ECFieldF2m.staticClass, "hashCode", "()I", ref global::java.security.spec.ECFieldF2m._m1);
		}
		public new int FieldSize
		{
			get
			{
				return getFieldSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getFieldSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.ECFieldF2m.staticClass, "getFieldSize", "()I", ref global::java.security.spec.ECFieldF2m._m2);
		}
		public new int M
		{
			get
			{
				return getM();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getM()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.ECFieldF2m.staticClass, "getM", "()I", ref global::java.security.spec.ECFieldF2m._m3);
		}
		public new global::java.math.BigInteger ReductionPolynomial
		{
			get
			{
				return getReductionPolynomial();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.math.BigInteger getReductionPolynomial()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.ECFieldF2m.staticClass, "getReductionPolynomial", "()Ljava/math/BigInteger;", ref global::java.security.spec.ECFieldF2m._m4) as java.math.BigInteger;
		}
		public new int[] MidTermsOfReductionPolynomial
		{
			get
			{
				return getMidTermsOfReductionPolynomial();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int[] getMidTermsOfReductionPolynomial()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::java.security.spec.ECFieldF2m.staticClass, "getMidTermsOfReductionPolynomial", "()[I", ref global::java.security.spec.ECFieldF2m._m5) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ECFieldF2m(int arg0, java.math.BigInteger arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECFieldF2m._m6.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECFieldF2m._m6 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "<init>", "(ILjava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public ECFieldF2m(int arg0, int[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECFieldF2m._m7.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECFieldF2m._m7 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "<init>", "(I[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public ECFieldF2m(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECFieldF2m._m8.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECFieldF2m._m8 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ECFieldF2m()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECFieldF2m.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECFieldF2m"));
		}
	}
}
