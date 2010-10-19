namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EllipticCurve : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EllipticCurve()
		{
			InitJNI();
		}
		protected EllipticCurve(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals18284;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.spec.EllipticCurve._equals18284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._equals18284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode18285;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.EllipticCurve._hashCode18285);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._hashCode18285);
		}
		public new global::java.security.spec.ECField Field
		{
			get
			{
				return getField();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getField18286;
		public virtual global::java.security.spec.ECField getField() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.ECField>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve._getField18286)) as java.security.spec.ECField;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.ECField>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._getField18286)) as java.security.spec.ECField;
		}
		public new byte[] Seed
		{
			get
			{
				return getSeed();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSeed18287;
		public virtual byte[] getSeed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve._getSeed18287)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._getSeed18287)) as byte[];
		}
		public new global::java.math.BigInteger A
		{
			get
			{
				return getA();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getA18288;
		public virtual global::java.math.BigInteger getA() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve._getA18288)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._getA18288)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger B
		{
			get
			{
				return getB();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getB18289;
		public virtual global::java.math.BigInteger getB() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve._getB18289)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._getB18289)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _EllipticCurve18290;
		public EllipticCurve(java.security.spec.ECField arg0, java.math.BigInteger arg1, java.math.BigInteger arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._EllipticCurve18290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EllipticCurve18291;
		public EllipticCurve(java.security.spec.ECField arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, byte[] arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._EllipticCurve18291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.EllipticCurve.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/EllipticCurve"));
			global::java.security.spec.EllipticCurve._equals18284 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.spec.EllipticCurve._hashCode18285 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "hashCode", "()I");
			global::java.security.spec.EllipticCurve._getField18286 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "getField", "()Ljava/security/spec/ECField;");
			global::java.security.spec.EllipticCurve._getSeed18287 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "getSeed", "()[B");
			global::java.security.spec.EllipticCurve._getA18288 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "getA", "()Ljava/math/BigInteger;");
			global::java.security.spec.EllipticCurve._getB18289 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "getB", "()Ljava/math/BigInteger;");
			global::java.security.spec.EllipticCurve._EllipticCurve18290 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "<init>", "(Ljava/security/spec/ECField;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
			global::java.security.spec.EllipticCurve._EllipticCurve18291 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "<init>", "(Ljava/security/spec/ECField;Ljava/math/BigInteger;Ljava/math/BigInteger;[B)V");
		}
	}
}
