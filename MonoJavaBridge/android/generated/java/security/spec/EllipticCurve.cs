namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EllipticCurve : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EllipticCurve(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals24012;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.EllipticCurve._equals24012.native == global::System.IntPtr.Zero)
				global::java.security.spec.EllipticCurve._equals24012 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._equals24012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode24013;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.EllipticCurve._hashCode24013.native == global::System.IntPtr.Zero)
				global::java.security.spec.EllipticCurve._hashCode24013 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._hashCode24013);
		}
		public new global::java.security.spec.ECField Field
		{
			get
			{
				return getField();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getField24014;
		public virtual global::java.security.spec.ECField getField()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.EllipticCurve._getField24014.native == global::System.IntPtr.Zero)
				global::java.security.spec.EllipticCurve._getField24014 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "getField", "()Ljava/security/spec/ECField;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.spec.ECField>(this, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._getField24014) as java.security.spec.ECField;
		}
		public new byte[] Seed
		{
			get
			{
				return getSeed();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSeed24015;
		public virtual byte[] getSeed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.EllipticCurve._getSeed24015.native == global::System.IntPtr.Zero)
				global::java.security.spec.EllipticCurve._getSeed24015 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "getSeed", "()[B");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._getSeed24015) as byte[];
		}
		public new global::java.math.BigInteger A
		{
			get
			{
				return getA();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getA24016;
		public virtual global::java.math.BigInteger getA()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.EllipticCurve._getA24016.native == global::System.IntPtr.Zero)
				global::java.security.spec.EllipticCurve._getA24016 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "getA", "()Ljava/math/BigInteger;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._getA24016) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger B
		{
			get
			{
				return getB();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getB24017;
		public virtual global::java.math.BigInteger getB()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.EllipticCurve._getB24017.native == global::System.IntPtr.Zero)
				global::java.security.spec.EllipticCurve._getB24017 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "getB", "()Ljava/math/BigInteger;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._getB24017) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _EllipticCurve24018;
		public EllipticCurve(java.security.spec.ECField arg0, java.math.BigInteger arg1, java.math.BigInteger arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.EllipticCurve._EllipticCurve24018.native == global::System.IntPtr.Zero)
				global::java.security.spec.EllipticCurve._EllipticCurve24018 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "<init>", "(Ljava/security/spec/ECField;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._EllipticCurve24018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EllipticCurve24019;
		public EllipticCurve(java.security.spec.ECField arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, byte[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.EllipticCurve._EllipticCurve24019.native == global::System.IntPtr.Zero)
				global::java.security.spec.EllipticCurve._EllipticCurve24019 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "<init>", "(Ljava/security/spec/ECField;Ljava/math/BigInteger;Ljava/math/BigInteger;[B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._EllipticCurve24019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static EllipticCurve()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.EllipticCurve.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/EllipticCurve"));
		}
		internal static void InitJNI()
		{
		}
	}
}
