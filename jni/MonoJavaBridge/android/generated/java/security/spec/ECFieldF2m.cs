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
		internal static global::MonoJavaBridge.MethodId _equals18251;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m._equals18251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._equals18251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode18252;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m._hashCode18252);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._hashCode18252);
		}
		public new int FieldSize
		{
			get
			{
				return getFieldSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFieldSize18253;
		public virtual int getFieldSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m._getFieldSize18253);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._getFieldSize18253);
		}
		public new int M
		{
			get
			{
				return getM();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getM18254;
		public virtual int getM() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m._getM18254);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._getM18254);
		}
		public new global::java.math.BigInteger ReductionPolynomial
		{
			get
			{
				return getReductionPolynomial();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReductionPolynomial18255;
		public virtual global::java.math.BigInteger getReductionPolynomial() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m._getReductionPolynomial18255)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._getReductionPolynomial18255)) as java.math.BigInteger;
		}
		public new int[] MidTermsOfReductionPolynomial
		{
			get
			{
				return getMidTermsOfReductionPolynomial();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMidTermsOfReductionPolynomial18256;
		public virtual int[] getMidTermsOfReductionPolynomial() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m._getMidTermsOfReductionPolynomial18256)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._getMidTermsOfReductionPolynomial18256)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _ECFieldF2m18257;
		public ECFieldF2m(int arg0, java.math.BigInteger arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._ECFieldF2m18257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ECFieldF2m18258;
		public ECFieldF2m(int arg0, int[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._ECFieldF2m18258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ECFieldF2m18259;
		public ECFieldF2m(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._ECFieldF2m18259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECFieldF2m.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECFieldF2m"));
			global::java.security.spec.ECFieldF2m._equals18251 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.spec.ECFieldF2m._hashCode18252 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "hashCode", "()I");
			global::java.security.spec.ECFieldF2m._getFieldSize18253 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "getFieldSize", "()I");
			global::java.security.spec.ECFieldF2m._getM18254 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "getM", "()I");
			global::java.security.spec.ECFieldF2m._getReductionPolynomial18255 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "getReductionPolynomial", "()Ljava/math/BigInteger;");
			global::java.security.spec.ECFieldF2m._getMidTermsOfReductionPolynomial18256 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "getMidTermsOfReductionPolynomial", "()[I");
			global::java.security.spec.ECFieldF2m._ECFieldF2m18257 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "<init>", "(ILjava/math/BigInteger;)V");
			global::java.security.spec.ECFieldF2m._ECFieldF2m18258 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "<init>", "(I[I)V");
			global::java.security.spec.ECFieldF2m._ECFieldF2m18259 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "<init>", "(I)V");
		}
	}
}
