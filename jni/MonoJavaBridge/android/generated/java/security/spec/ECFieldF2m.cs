namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ECFieldF2m : java.lang.Object, ECField
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ECFieldF2m()
		{
			InitJNI();
		}
		protected ECFieldF2m(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals23978;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m._equals23978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._equals23978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23979;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m._hashCode23979);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._hashCode23979);
		}
		public new int FieldSize
		{
			get
			{
				return getFieldSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFieldSize23980;
		public virtual int getFieldSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m._getFieldSize23980);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._getFieldSize23980);
		}
		public new int M
		{
			get
			{
				return getM();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getM23981;
		public virtual int getM() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m._getM23981);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._getM23981);
		}
		public new global::java.math.BigInteger ReductionPolynomial
		{
			get
			{
				return getReductionPolynomial();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReductionPolynomial23982;
		public virtual global::java.math.BigInteger getReductionPolynomial() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m._getReductionPolynomial23982)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._getReductionPolynomial23982)) as java.math.BigInteger;
		}
		public new int[] MidTermsOfReductionPolynomial
		{
			get
			{
				return getMidTermsOfReductionPolynomial();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMidTermsOfReductionPolynomial23983;
		public virtual int[] getMidTermsOfReductionPolynomial() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m._getMidTermsOfReductionPolynomial23983)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._getMidTermsOfReductionPolynomial23983)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _ECFieldF2m23984;
		public ECFieldF2m(int arg0, java.math.BigInteger arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._ECFieldF2m23984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ECFieldF2m23985;
		public ECFieldF2m(int arg0, int[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._ECFieldF2m23985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ECFieldF2m23986;
		public ECFieldF2m(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._ECFieldF2m23986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECFieldF2m.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECFieldF2m"));
			global::java.security.spec.ECFieldF2m._equals23978 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.spec.ECFieldF2m._hashCode23979 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "hashCode", "()I");
			global::java.security.spec.ECFieldF2m._getFieldSize23980 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "getFieldSize", "()I");
			global::java.security.spec.ECFieldF2m._getM23981 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "getM", "()I");
			global::java.security.spec.ECFieldF2m._getReductionPolynomial23982 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "getReductionPolynomial", "()Ljava/math/BigInteger;");
			global::java.security.spec.ECFieldF2m._getMidTermsOfReductionPolynomial23983 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "getMidTermsOfReductionPolynomial", "()[I");
			global::java.security.spec.ECFieldF2m._ECFieldF2m23984 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "<init>", "(ILjava/math/BigInteger;)V");
			global::java.security.spec.ECFieldF2m._ECFieldF2m23985 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "<init>", "(I[I)V");
			global::java.security.spec.ECFieldF2m._ECFieldF2m23986 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "<init>", "(I)V");
		}
	}
}
