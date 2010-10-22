namespace java.math
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BigDecimal : java.lang.Number, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BigDecimal()
		{
			InitJNI();
		}
		protected BigDecimal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add21045;
		public virtual global::java.math.BigDecimal add(java.math.BigDecimal arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._add21045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._add21045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _add21046;
		public virtual global::java.math.BigDecimal add(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._add21046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._add21046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _equals21047;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.math.BigDecimal._equals21047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._equals21047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21048;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._toString21048)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toString21048)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21049;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._hashCode21049);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._hashCode21049);
		}
		internal static global::MonoJavaBridge.MethodId _abs21050;
		public virtual global::java.math.BigDecimal abs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._abs21050)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._abs21050)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _abs21051;
		public virtual global::java.math.BigDecimal abs(java.math.MathContext arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._abs21051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._abs21051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _pow21052;
		public virtual global::java.math.BigDecimal pow(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._pow21052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._pow21052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _pow21053;
		public virtual global::java.math.BigDecimal pow(int arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._pow21053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._pow21053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _min21054;
		public virtual global::java.math.BigDecimal min(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._min21054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._min21054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _max21055;
		public virtual global::java.math.BigDecimal max(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._max21055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._max21055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21056;
		public virtual int compareTo(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._compareTo21056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._compareTo21056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21057;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._compareTo21057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._compareTo21057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf21058;
		public static global::java.math.BigDecimal valueOf(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._valueOf21058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf21059;
		public static global::java.math.BigDecimal valueOf(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._valueOf21059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf21060;
		public static global::java.math.BigDecimal valueOf(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._valueOf21060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _intValue21061;
		public override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._intValue21061);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._intValue21061);
		}
		internal static global::MonoJavaBridge.MethodId _longValue21062;
		public override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.math.BigDecimal._longValue21062);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._longValue21062);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue21063;
		public override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.math.BigDecimal._floatValue21063);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._floatValue21063);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue21064;
		public override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.math.BigDecimal._doubleValue21064);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._doubleValue21064);
		}
		internal static global::MonoJavaBridge.MethodId _signum21065;
		public virtual int signum() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._signum21065);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._signum21065);
		}
		internal static global::MonoJavaBridge.MethodId _round21066;
		public virtual global::java.math.BigDecimal round(java.math.MathContext arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._round21066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._round21066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _ulp21067;
		public virtual global::java.math.BigDecimal ulp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._ulp21067)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._ulp21067)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _scale21068;
		public virtual int scale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._scale21068);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._scale21068);
		}
		internal static global::MonoJavaBridge.MethodId _subtract21069;
		public virtual global::java.math.BigDecimal subtract(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._subtract21069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._subtract21069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _subtract21070;
		public virtual global::java.math.BigDecimal subtract(java.math.BigDecimal arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._subtract21070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._subtract21070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _multiply21071;
		public virtual global::java.math.BigDecimal multiply(java.math.BigDecimal arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._multiply21071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._multiply21071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _multiply21072;
		public virtual global::java.math.BigDecimal multiply(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._multiply21072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._multiply21072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21073;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide21073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21074;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, int arg1, java.math.RoundingMode arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide21074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21075;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide21075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21076;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, java.math.RoundingMode arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide21076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21077;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide21077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide21078;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide21078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide21078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divideAndRemainder21079;
		public virtual global::java.math.BigDecimal[] divideAndRemainder(java.math.BigDecimal arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigDecimal>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divideAndRemainder21079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigDecimal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideAndRemainder21079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal[];
		}
		internal static global::MonoJavaBridge.MethodId _divideAndRemainder21080;
		public virtual global::java.math.BigDecimal[] divideAndRemainder(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigDecimal>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divideAndRemainder21080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigDecimal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideAndRemainder21080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal[];
		}
		internal static global::MonoJavaBridge.MethodId _remainder21081;
		public virtual global::java.math.BigDecimal remainder(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._remainder21081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._remainder21081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _remainder21082;
		public virtual global::java.math.BigDecimal remainder(java.math.BigDecimal arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._remainder21082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._remainder21082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _negate21083;
		public virtual global::java.math.BigDecimal negate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._negate21083)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._negate21083)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _negate21084;
		public virtual global::java.math.BigDecimal negate(java.math.MathContext arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._negate21084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._negate21084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _toBigInteger21085;
		public virtual global::java.math.BigInteger toBigInteger() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._toBigInteger21085)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toBigInteger21085)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _setScale21086;
		public virtual global::java.math.BigDecimal setScale(int arg0, java.math.RoundingMode arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._setScale21086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._setScale21086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _setScale21087;
		public virtual global::java.math.BigDecimal setScale(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._setScale21087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._setScale21087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _setScale21088;
		public virtual global::java.math.BigDecimal setScale(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._setScale21088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._setScale21088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _precision21089;
		public virtual int precision() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._precision21089);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._precision21089);
		}
		internal static global::MonoJavaBridge.MethodId _divideToIntegralValue21090;
		public virtual global::java.math.BigDecimal divideToIntegralValue(java.math.BigDecimal arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divideToIntegralValue21090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideToIntegralValue21090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divideToIntegralValue21091;
		public virtual global::java.math.BigDecimal divideToIntegralValue(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divideToIntegralValue21091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideToIntegralValue21091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _plus21092;
		public virtual global::java.math.BigDecimal plus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._plus21092)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._plus21092)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _plus21093;
		public virtual global::java.math.BigDecimal plus(java.math.MathContext arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._plus21093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._plus21093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _unscaledValue21094;
		public virtual global::java.math.BigInteger unscaledValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._unscaledValue21094)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._unscaledValue21094)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _movePointLeft21095;
		public virtual global::java.math.BigDecimal movePointLeft(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._movePointLeft21095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._movePointLeft21095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _movePointRight21096;
		public virtual global::java.math.BigDecimal movePointRight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._movePointRight21096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._movePointRight21096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _scaleByPowerOfTen21097;
		public virtual global::java.math.BigDecimal scaleByPowerOfTen(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._scaleByPowerOfTen21097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._scaleByPowerOfTen21097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _stripTrailingZeros21098;
		public virtual global::java.math.BigDecimal stripTrailingZeros() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._stripTrailingZeros21098)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._stripTrailingZeros21098)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _toEngineeringString21099;
		public virtual global::java.lang.String toEngineeringString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._toEngineeringString21099)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toEngineeringString21099)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toPlainString21100;
		public virtual global::java.lang.String toPlainString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._toPlainString21100)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toPlainString21100)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toBigIntegerExact21101;
		public virtual global::java.math.BigInteger toBigIntegerExact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._toBigIntegerExact21101)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toBigIntegerExact21101)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _longValueExact21102;
		public virtual long longValueExact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.math.BigDecimal._longValueExact21102);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._longValueExact21102);
		}
		internal static global::MonoJavaBridge.MethodId _intValueExact21103;
		public virtual int intValueExact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._intValueExact21103);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._intValueExact21103);
		}
		internal static global::MonoJavaBridge.MethodId _shortValueExact21104;
		public virtual short shortValueExact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.math.BigDecimal._shortValueExact21104);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._shortValueExact21104);
		}
		internal static global::MonoJavaBridge.MethodId _byteValueExact21105;
		public virtual byte byteValueExact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.math.BigDecimal._byteValueExact21105);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._byteValueExact21105);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21106;
		public BigDecimal(char[] arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21107;
		public BigDecimal(char[] arg0, int arg1, int arg2, java.math.MathContext arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21108;
		public BigDecimal(char[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21109;
		public BigDecimal(char[] arg0, java.math.MathContext arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21110;
		public BigDecimal(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21111;
		public BigDecimal(java.lang.String arg0, java.math.MathContext arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21112;
		public BigDecimal(double arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21113;
		public BigDecimal(double arg0, java.math.MathContext arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21114;
		public BigDecimal(java.math.BigInteger arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21115;
		public BigDecimal(java.math.BigInteger arg0, java.math.MathContext arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21116;
		public BigDecimal(java.math.BigInteger arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21117;
		public BigDecimal(java.math.BigInteger arg0, int arg1, java.math.MathContext arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21118;
		public BigDecimal(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21119;
		public BigDecimal(int arg0, java.math.MathContext arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21120;
		public BigDecimal(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal21121;
		public BigDecimal(long arg0, java.math.MathContext arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal21121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ZERO21122;
		public static global::java.math.BigDecimal ZERO
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigDecimal.staticClass, _ZERO21122)) as java.math.BigDecimal;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ONE21123;
		public static global::java.math.BigDecimal ONE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigDecimal.staticClass, _ONE21123)) as java.math.BigDecimal;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TEN21124;
		public static global::java.math.BigDecimal TEN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigDecimal.staticClass, _TEN21124)) as java.math.BigDecimal;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.math.BigDecimal.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/math/BigDecimal"));
			global::java.math.BigDecimal._add21045 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "add", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._add21046 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "add", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._equals21047 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.math.BigDecimal._toString21048 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toString", "()Ljava/lang/String;");
			global::java.math.BigDecimal._hashCode21049 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "hashCode", "()I");
			global::java.math.BigDecimal._abs21050 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "abs", "()Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._abs21051 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "abs", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._pow21052 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "pow", "(I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._pow21053 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "pow", "(ILjava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._min21054 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "min", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._max21055 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "max", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._compareTo21056 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "compareTo", "(Ljava/math/BigDecimal;)I");
			global::java.math.BigDecimal._compareTo21057 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.math.BigDecimal._valueOf21058 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "valueOf", "(JI)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._valueOf21059 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "valueOf", "(D)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._valueOf21060 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "valueOf", "(J)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._intValue21061 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "intValue", "()I");
			global::java.math.BigDecimal._longValue21062 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "longValue", "()J");
			global::java.math.BigDecimal._floatValue21063 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "floatValue", "()F");
			global::java.math.BigDecimal._doubleValue21064 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "doubleValue", "()D");
			global::java.math.BigDecimal._signum21065 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "signum", "()I");
			global::java.math.BigDecimal._round21066 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "round", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._ulp21067 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "ulp", "()Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._scale21068 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "scale", "()I");
			global::java.math.BigDecimal._subtract21069 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "subtract", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._subtract21070 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "subtract", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._multiply21071 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "multiply", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._multiply21072 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "multiply", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide21073 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide21074 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide21075 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide21076 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;Ljava/math/RoundingMode;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide21077 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide21078 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;II)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divideAndRemainder21079 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideAndRemainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)[Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divideAndRemainder21080 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideAndRemainder", "(Ljava/math/BigDecimal;)[Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._remainder21081 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "remainder", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._remainder21082 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "remainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._negate21083 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "negate", "()Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._negate21084 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "negate", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._toBigInteger21085 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toBigInteger", "()Ljava/math/BigInteger;");
			global::java.math.BigDecimal._setScale21086 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "setScale", "(ILjava/math/RoundingMode;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._setScale21087 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "setScale", "(II)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._setScale21088 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "setScale", "(I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._precision21089 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "precision", "()I");
			global::java.math.BigDecimal._divideToIntegralValue21090 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideToIntegralValue", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divideToIntegralValue21091 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideToIntegralValue", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._plus21092 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "plus", "()Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._plus21093 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "plus", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._unscaledValue21094 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "unscaledValue", "()Ljava/math/BigInteger;");
			global::java.math.BigDecimal._movePointLeft21095 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "movePointLeft", "(I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._movePointRight21096 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "movePointRight", "(I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._scaleByPowerOfTen21097 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "scaleByPowerOfTen", "(I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._stripTrailingZeros21098 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "stripTrailingZeros", "()Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._toEngineeringString21099 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toEngineeringString", "()Ljava/lang/String;");
			global::java.math.BigDecimal._toPlainString21100 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toPlainString", "()Ljava/lang/String;");
			global::java.math.BigDecimal._toBigIntegerExact21101 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toBigIntegerExact", "()Ljava/math/BigInteger;");
			global::java.math.BigDecimal._longValueExact21102 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "longValueExact", "()J");
			global::java.math.BigDecimal._intValueExact21103 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "intValueExact", "()I");
			global::java.math.BigDecimal._shortValueExact21104 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "shortValueExact", "()S");
			global::java.math.BigDecimal._byteValueExact21105 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "byteValueExact", "()B");
			global::java.math.BigDecimal._BigDecimal21106 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([CII)V");
			global::java.math.BigDecimal._BigDecimal21107 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([CIILjava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal21108 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([C)V");
			global::java.math.BigDecimal._BigDecimal21109 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([CLjava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal21110 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.math.BigDecimal._BigDecimal21111 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/lang/String;Ljava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal21112 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(D)V");
			global::java.math.BigDecimal._BigDecimal21113 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(DLjava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal21114 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;)V");
			global::java.math.BigDecimal._BigDecimal21115 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal21116 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;I)V");
			global::java.math.BigDecimal._BigDecimal21117 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;ILjava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal21118 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(I)V");
			global::java.math.BigDecimal._BigDecimal21119 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(ILjava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal21120 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(J)V");
			global::java.math.BigDecimal._BigDecimal21121 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(JLjava/math/MathContext;)V");
			global::java.math.BigDecimal._ZERO21122 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigDecimal.staticClass, "ZERO", "Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._ONE21123 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigDecimal.staticClass, "ONE", "Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._TEN21124 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigDecimal.staticClass, "TEN", "Ljava/math/BigDecimal;");
		}
	}
}
