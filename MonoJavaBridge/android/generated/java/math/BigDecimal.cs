namespace java.math
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BigDecimal : java.lang.Number, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BigDecimal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add21164;
		public virtual global::java.math.BigDecimal add(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._add21164.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._add21164 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "add", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._add21164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _add21165;
		public virtual global::java.math.BigDecimal add(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._add21165.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._add21165 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "add", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._add21165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _equals21166;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._equals21166.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._equals21166 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._equals21166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21167;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._toString21167.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._toString21167 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toString21167) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21168;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._hashCode21168.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._hashCode21168 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._hashCode21168);
		}
		internal static global::MonoJavaBridge.MethodId _abs21169;
		public virtual global::java.math.BigDecimal abs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._abs21169.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._abs21169 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "abs", "()Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._abs21169) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _abs21170;
		public virtual global::java.math.BigDecimal abs(java.math.MathContext arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._abs21170.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._abs21170 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "abs", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._abs21170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _pow21171;
		public virtual global::java.math.BigDecimal pow(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._pow21171.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._pow21171 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "pow", "(I)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._pow21171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _pow21172;
		public virtual global::java.math.BigDecimal pow(int arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._pow21172.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._pow21172 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "pow", "(ILjava/math/MathContext;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._pow21172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _min21173;
		public virtual global::java.math.BigDecimal min(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._min21173.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._min21173 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "min", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._min21173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _max21174;
		public virtual global::java.math.BigDecimal max(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._max21174.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._max21174 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "max", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._max21174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21175;
		public virtual int compareTo(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._compareTo21175.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._compareTo21175 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "compareTo", "(Ljava/math/BigDecimal;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._compareTo21175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21176;
		public virtual int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._compareTo21176.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._compareTo21176 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._compareTo21176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf21177;
		public static global::java.math.BigDecimal valueOf(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._valueOf21177.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._valueOf21177 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "valueOf", "(JI)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._valueOf21177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf21178;
		public static global::java.math.BigDecimal valueOf(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._valueOf21178.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._valueOf21178 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "valueOf", "(D)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._valueOf21178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf21179;
		public static global::java.math.BigDecimal valueOf(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._valueOf21179.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._valueOf21179 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "valueOf", "(J)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._valueOf21179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _intValue21180;
		public override int intValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._intValue21180.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._intValue21180 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "intValue", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._intValue21180);
		}
		internal static global::MonoJavaBridge.MethodId _longValue21181;
		public override long longValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._longValue21181.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._longValue21181 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "longValue", "()J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._longValue21181);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue21182;
		public override float floatValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._floatValue21182.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._floatValue21182 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "floatValue", "()F");
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._floatValue21182);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue21183;
		public override double doubleValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._doubleValue21183.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._doubleValue21183 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "doubleValue", "()D");
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._doubleValue21183);
		}
		internal static global::MonoJavaBridge.MethodId _signum21184;
		public virtual int signum()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._signum21184.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._signum21184 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "signum", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._signum21184);
		}
		internal static global::MonoJavaBridge.MethodId _round21185;
		public virtual global::java.math.BigDecimal round(java.math.MathContext arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._round21185.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._round21185 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "round", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._round21185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _ulp21186;
		public virtual global::java.math.BigDecimal ulp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._ulp21186.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._ulp21186 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "ulp", "()Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._ulp21186) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _scale21187;
		public virtual int scale()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._scale21187.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._scale21187 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "scale", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._scale21187);
		}
		internal static global::MonoJavaBridge.MethodId _subtract21188;
		public virtual global::java.math.BigDecimal subtract(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._subtract21188.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._subtract21188 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "subtract", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._subtract21188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _subtract21189;
		public virtual global::java.math.BigDecimal subtract(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._subtract21189.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._subtract21189 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "subtract", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._subtract21189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _multiply21190;
		public virtual global::java.math.BigDecimal multiply(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._multiply21190.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._multiply21190 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "multiply", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._multiply21190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _multiply21191;
		public virtual global::java.math.BigDecimal multiply(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._multiply21191.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._multiply21191 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "multiply", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._multiply21191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21192;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._divide21192.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._divide21192 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21193;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, int arg1, java.math.RoundingMode arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._divide21193.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._divide21193 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21194;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._divide21194.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._divide21194 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;I)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21195;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, java.math.RoundingMode arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._divide21195.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._divide21195 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;Ljava/math/RoundingMode;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21196;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._divide21196.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._divide21196 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21197;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._divide21197.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._divide21197 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;II)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divideAndRemainder21198;
		public virtual global::java.math.BigDecimal[] divideAndRemainder(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._divideAndRemainder21198.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._divideAndRemainder21198 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideAndRemainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)[Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.math.BigDecimal>(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideAndRemainder21198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal[];
		}
		internal static global::MonoJavaBridge.MethodId _divideAndRemainder21199;
		public virtual global::java.math.BigDecimal[] divideAndRemainder(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._divideAndRemainder21199.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._divideAndRemainder21199 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideAndRemainder", "(Ljava/math/BigDecimal;)[Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.math.BigDecimal>(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideAndRemainder21199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal[];
		}
		internal static global::MonoJavaBridge.MethodId _remainder21200;
		public virtual global::java.math.BigDecimal remainder(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._remainder21200.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._remainder21200 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "remainder", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._remainder21200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _remainder21201;
		public virtual global::java.math.BigDecimal remainder(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._remainder21201.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._remainder21201 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "remainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._remainder21201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _negate21202;
		public virtual global::java.math.BigDecimal negate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._negate21202.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._negate21202 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "negate", "()Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._negate21202) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _negate21203;
		public virtual global::java.math.BigDecimal negate(java.math.MathContext arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._negate21203.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._negate21203 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "negate", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._negate21203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _toBigInteger21204;
		public virtual global::java.math.BigInteger toBigInteger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._toBigInteger21204.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._toBigInteger21204 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toBigInteger", "()Ljava/math/BigInteger;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toBigInteger21204) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _setScale21205;
		public virtual global::java.math.BigDecimal setScale(int arg0, java.math.RoundingMode arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._setScale21205.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._setScale21205 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "setScale", "(ILjava/math/RoundingMode;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._setScale21205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _setScale21206;
		public virtual global::java.math.BigDecimal setScale(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._setScale21206.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._setScale21206 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "setScale", "(II)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._setScale21206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _setScale21207;
		public virtual global::java.math.BigDecimal setScale(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._setScale21207.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._setScale21207 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "setScale", "(I)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._setScale21207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _precision21208;
		public virtual int precision()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._precision21208.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._precision21208 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "precision", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._precision21208);
		}
		internal static global::MonoJavaBridge.MethodId _divideToIntegralValue21209;
		public virtual global::java.math.BigDecimal divideToIntegralValue(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._divideToIntegralValue21209.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._divideToIntegralValue21209 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideToIntegralValue", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideToIntegralValue21209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divideToIntegralValue21210;
		public virtual global::java.math.BigDecimal divideToIntegralValue(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._divideToIntegralValue21210.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._divideToIntegralValue21210 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideToIntegralValue", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideToIntegralValue21210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _plus21211;
		public virtual global::java.math.BigDecimal plus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._plus21211.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._plus21211 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "plus", "()Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._plus21211) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _plus21212;
		public virtual global::java.math.BigDecimal plus(java.math.MathContext arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._plus21212.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._plus21212 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "plus", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._plus21212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _unscaledValue21213;
		public virtual global::java.math.BigInteger unscaledValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._unscaledValue21213.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._unscaledValue21213 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "unscaledValue", "()Ljava/math/BigInteger;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._unscaledValue21213) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _movePointLeft21214;
		public virtual global::java.math.BigDecimal movePointLeft(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._movePointLeft21214.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._movePointLeft21214 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "movePointLeft", "(I)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._movePointLeft21214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _movePointRight21215;
		public virtual global::java.math.BigDecimal movePointRight(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._movePointRight21215.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._movePointRight21215 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "movePointRight", "(I)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._movePointRight21215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _scaleByPowerOfTen21216;
		public virtual global::java.math.BigDecimal scaleByPowerOfTen(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._scaleByPowerOfTen21216.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._scaleByPowerOfTen21216 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "scaleByPowerOfTen", "(I)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._scaleByPowerOfTen21216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _stripTrailingZeros21217;
		public virtual global::java.math.BigDecimal stripTrailingZeros()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._stripTrailingZeros21217.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._stripTrailingZeros21217 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "stripTrailingZeros", "()Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._stripTrailingZeros21217) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _toEngineeringString21218;
		public virtual global::java.lang.String toEngineeringString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._toEngineeringString21218.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._toEngineeringString21218 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toEngineeringString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toEngineeringString21218) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toPlainString21219;
		public virtual global::java.lang.String toPlainString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._toPlainString21219.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._toPlainString21219 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toPlainString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toPlainString21219) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toBigIntegerExact21220;
		public virtual global::java.math.BigInteger toBigIntegerExact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._toBigIntegerExact21220.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._toBigIntegerExact21220 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toBigIntegerExact", "()Ljava/math/BigInteger;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toBigIntegerExact21220) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _longValueExact21221;
		public virtual long longValueExact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._longValueExact21221.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._longValueExact21221 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "longValueExact", "()J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._longValueExact21221);
		}
		internal static global::MonoJavaBridge.MethodId _intValueExact21222;
		public virtual int intValueExact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._intValueExact21222.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._intValueExact21222 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "intValueExact", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._intValueExact21222);
		}
		internal static global::MonoJavaBridge.MethodId _shortValueExact21223;
		public virtual short shortValueExact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._shortValueExact21223.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._shortValueExact21223 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "shortValueExact", "()S");
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._shortValueExact21223);
		}
		internal static global::MonoJavaBridge.MethodId _byteValueExact21224;
		public virtual byte byteValueExact()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._byteValueExact21224.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._byteValueExact21224 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "byteValueExact", "()B");
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._byteValueExact21224);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21225;
		public BigDecimal(char[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21225.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21225 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([CII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21226;
		public BigDecimal(char[] arg0, int arg1, int arg2, java.math.MathContext arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21226.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21226 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([CIILjava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21227;
		public BigDecimal(char[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21227.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21227 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([C)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21228;
		public BigDecimal(char[] arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21228.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21228 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([CLjava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21229;
		public BigDecimal(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21229.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21229 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21230;
		public BigDecimal(java.lang.String arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21230.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21230 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/lang/String;Ljava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21231;
		public BigDecimal(double arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21231.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21231 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(D)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21232;
		public BigDecimal(double arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21232.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21232 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(DLjava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21233;
		public BigDecimal(java.math.BigInteger arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21233.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21233 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21234;
		public BigDecimal(java.math.BigInteger arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21234.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21234 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21235;
		public BigDecimal(java.math.BigInteger arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21235.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21235 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21236;
		public BigDecimal(java.math.BigInteger arg0, int arg1, java.math.MathContext arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21236.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21236 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;ILjava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21237;
		public BigDecimal(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21237.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21237 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21238;
		public BigDecimal(int arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21238.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21238 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(ILjava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21239;
		public BigDecimal(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21239.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21239 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21240;
		public BigDecimal(long arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._BigDecimal21240.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._BigDecimal21240 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(JLjava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ZERO21241;
		public static global::java.math.BigDecimal ZERO
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigDecimal.staticClass, _ZERO21241)) as java.math.BigDecimal;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ONE21242;
		public static global::java.math.BigDecimal ONE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigDecimal.staticClass, _ONE21242)) as java.math.BigDecimal;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TEN21243;
		public static global::java.math.BigDecimal TEN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigDecimal.staticClass, _TEN21243)) as java.math.BigDecimal;
			}
		}
		public static int ROUND_UP
		{
			get
			{
				return 0;
			}
		}
		public static int ROUND_DOWN
		{
			get
			{
				return 1;
			}
		}
		public static int ROUND_CEILING
		{
			get
			{
				return 2;
			}
		}
		public static int ROUND_FLOOR
		{
			get
			{
				return 3;
			}
		}
		public static int ROUND_HALF_UP
		{
			get
			{
				return 4;
			}
		}
		public static int ROUND_HALF_DOWN
		{
			get
			{
				return 5;
			}
		}
		public static int ROUND_HALF_EVEN
		{
			get
			{
				return 6;
			}
		}
		public static int ROUND_UNNECESSARY
		{
			get
			{
				return 7;
			}
		}
		static BigDecimal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.math.BigDecimal.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/math/BigDecimal"));
			global::java.math.BigDecimal._ZERO21241 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigDecimal.staticClass, "ZERO", "Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._ONE21242 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigDecimal.staticClass, "ONE", "Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._TEN21243 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigDecimal.staticClass, "TEN", "Ljava/math/BigDecimal;");
		}
		internal static void InitJNI()
		{
		}
	}
}
