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
		internal static global::MonoJavaBridge.MethodId _add15509;
		public virtual global::java.math.BigDecimal add(java.math.BigDecimal arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._add15509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._add15509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _add15510;
		public virtual global::java.math.BigDecimal add(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._add15510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._add15510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _equals15511;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.math.BigDecimal._equals15511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._equals15511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15512;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._toString15512)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toString15512)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15513;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._hashCode15513);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._hashCode15513);
		}
		internal static global::MonoJavaBridge.MethodId _abs15514;
		public virtual global::java.math.BigDecimal abs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._abs15514)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._abs15514)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _abs15515;
		public virtual global::java.math.BigDecimal abs(java.math.MathContext arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._abs15515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._abs15515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _pow15516;
		public virtual global::java.math.BigDecimal pow(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._pow15516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._pow15516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _pow15517;
		public virtual global::java.math.BigDecimal pow(int arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._pow15517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._pow15517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _min15518;
		public virtual global::java.math.BigDecimal min(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._min15518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._min15518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _max15519;
		public virtual global::java.math.BigDecimal max(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._max15519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._max15519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo15520;
		public virtual int compareTo(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._compareTo15520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._compareTo15520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo15521;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._compareTo15521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._compareTo15521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15522;
		public static global::java.math.BigDecimal valueOf(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._valueOf15522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15523;
		public static global::java.math.BigDecimal valueOf(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._valueOf15523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15524;
		public static global::java.math.BigDecimal valueOf(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._valueOf15524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _intValue15525;
		public override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._intValue15525);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._intValue15525);
		}
		internal static global::MonoJavaBridge.MethodId _longValue15526;
		public override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.math.BigDecimal._longValue15526);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._longValue15526);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue15527;
		public override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.math.BigDecimal._floatValue15527);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._floatValue15527);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue15528;
		public override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.math.BigDecimal._doubleValue15528);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._doubleValue15528);
		}
		internal static global::MonoJavaBridge.MethodId _signum15529;
		public virtual int signum() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._signum15529);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._signum15529);
		}
		internal static global::MonoJavaBridge.MethodId _round15530;
		public virtual global::java.math.BigDecimal round(java.math.MathContext arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._round15530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._round15530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _ulp15531;
		public virtual global::java.math.BigDecimal ulp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._ulp15531)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._ulp15531)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _scale15532;
		public virtual int scale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._scale15532);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._scale15532);
		}
		internal static global::MonoJavaBridge.MethodId _subtract15533;
		public virtual global::java.math.BigDecimal subtract(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._subtract15533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._subtract15533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _subtract15534;
		public virtual global::java.math.BigDecimal subtract(java.math.BigDecimal arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._subtract15534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._subtract15534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _multiply15535;
		public virtual global::java.math.BigDecimal multiply(java.math.BigDecimal arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._multiply15535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._multiply15535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _multiply15536;
		public virtual global::java.math.BigDecimal multiply(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._multiply15536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._multiply15536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide15537;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide15537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide15537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide15538;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, int arg1, java.math.RoundingMode arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide15538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide15538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide15539;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide15539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide15539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide15540;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, java.math.RoundingMode arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide15540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide15540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide15541;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide15541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide15541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divide15542;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divide15542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divide15542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divideAndRemainder15543;
		public virtual global::java.math.BigDecimal[] divideAndRemainder(java.math.BigDecimal arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigDecimal>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divideAndRemainder15543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigDecimal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideAndRemainder15543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal[];
		}
		internal static global::MonoJavaBridge.MethodId _divideAndRemainder15544;
		public virtual global::java.math.BigDecimal[] divideAndRemainder(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigDecimal>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divideAndRemainder15544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigDecimal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideAndRemainder15544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal[];
		}
		internal static global::MonoJavaBridge.MethodId _remainder15545;
		public virtual global::java.math.BigDecimal remainder(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._remainder15545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._remainder15545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _remainder15546;
		public virtual global::java.math.BigDecimal remainder(java.math.BigDecimal arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._remainder15546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._remainder15546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _negate15547;
		public virtual global::java.math.BigDecimal negate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._negate15547)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._negate15547)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _negate15548;
		public virtual global::java.math.BigDecimal negate(java.math.MathContext arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._negate15548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._negate15548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _toBigInteger15549;
		public virtual global::java.math.BigInteger toBigInteger() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._toBigInteger15549)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toBigInteger15549)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _setScale15550;
		public virtual global::java.math.BigDecimal setScale(int arg0, java.math.RoundingMode arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._setScale15550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._setScale15550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _setScale15551;
		public virtual global::java.math.BigDecimal setScale(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._setScale15551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._setScale15551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _setScale15552;
		public virtual global::java.math.BigDecimal setScale(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._setScale15552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._setScale15552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _precision15553;
		public virtual int precision() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._precision15553);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._precision15553);
		}
		internal static global::MonoJavaBridge.MethodId _divideToIntegralValue15554;
		public virtual global::java.math.BigDecimal divideToIntegralValue(java.math.BigDecimal arg0, java.math.MathContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divideToIntegralValue15554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideToIntegralValue15554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _divideToIntegralValue15555;
		public virtual global::java.math.BigDecimal divideToIntegralValue(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._divideToIntegralValue15555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._divideToIntegralValue15555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _plus15556;
		public virtual global::java.math.BigDecimal plus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._plus15556)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._plus15556)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _plus15557;
		public virtual global::java.math.BigDecimal plus(java.math.MathContext arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._plus15557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._plus15557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _unscaledValue15558;
		public virtual global::java.math.BigInteger unscaledValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._unscaledValue15558)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._unscaledValue15558)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _movePointLeft15559;
		public virtual global::java.math.BigDecimal movePointLeft(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._movePointLeft15559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._movePointLeft15559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _movePointRight15560;
		public virtual global::java.math.BigDecimal movePointRight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._movePointRight15560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._movePointRight15560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _scaleByPowerOfTen15561;
		public virtual global::java.math.BigDecimal scaleByPowerOfTen(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._scaleByPowerOfTen15561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._scaleByPowerOfTen15561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _stripTrailingZeros15562;
		public virtual global::java.math.BigDecimal stripTrailingZeros() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._stripTrailingZeros15562)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._stripTrailingZeros15562)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _toEngineeringString15563;
		public virtual global::java.lang.String toEngineeringString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._toEngineeringString15563)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toEngineeringString15563)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toPlainString15564;
		public virtual global::java.lang.String toPlainString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._toPlainString15564)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toPlainString15564)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toBigIntegerExact15565;
		public virtual global::java.math.BigInteger toBigIntegerExact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigDecimal._toBigIntegerExact15565)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._toBigIntegerExact15565)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _longValueExact15566;
		public virtual long longValueExact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.math.BigDecimal._longValueExact15566);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._longValueExact15566);
		}
		internal static global::MonoJavaBridge.MethodId _intValueExact15567;
		public virtual int intValueExact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigDecimal._intValueExact15567);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._intValueExact15567);
		}
		internal static global::MonoJavaBridge.MethodId _shortValueExact15568;
		public virtual short shortValueExact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.math.BigDecimal._shortValueExact15568);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._shortValueExact15568);
		}
		internal static global::MonoJavaBridge.MethodId _byteValueExact15569;
		public virtual byte byteValueExact() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.math.BigDecimal._byteValueExact15569);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.math.BigDecimal.staticClass, global::java.math.BigDecimal._byteValueExact15569);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15570;
		public BigDecimal(char[] arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15571;
		public BigDecimal(char[] arg0, int arg1, int arg2, java.math.MathContext arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15572;
		public BigDecimal(char[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15573;
		public BigDecimal(char[] arg0, java.math.MathContext arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15574;
		public BigDecimal(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15575;
		public BigDecimal(java.lang.String arg0, java.math.MathContext arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15576;
		public BigDecimal(double arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15577;
		public BigDecimal(double arg0, java.math.MathContext arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15578;
		public BigDecimal(java.math.BigInteger arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15579;
		public BigDecimal(java.math.BigInteger arg0, java.math.MathContext arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15580;
		public BigDecimal(java.math.BigInteger arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15581;
		public BigDecimal(java.math.BigInteger arg0, int arg1, java.math.MathContext arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15582;
		public BigDecimal(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15583;
		public BigDecimal(int arg0, java.math.MathContext arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15584;
		public BigDecimal(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigDecimal15585;
		public BigDecimal(long arg0, java.math.MathContext arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._BigDecimal15585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ZERO15586;
		public static global::java.math.BigDecimal ZERO
		{
			get
			{
				return default(global::java.math.BigDecimal);
			}
		}
		internal static global::MonoJavaBridge.FieldId _ONE15587;
		public static global::java.math.BigDecimal ONE
		{
			get
			{
				return default(global::java.math.BigDecimal);
			}
		}
		internal static global::MonoJavaBridge.FieldId _TEN15588;
		public static global::java.math.BigDecimal TEN
		{
			get
			{
				return default(global::java.math.BigDecimal);
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
			global::java.math.BigDecimal._add15509 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "add", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._add15510 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "add", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._equals15511 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.math.BigDecimal._toString15512 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toString", "()Ljava/lang/String;");
			global::java.math.BigDecimal._hashCode15513 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "hashCode", "()I");
			global::java.math.BigDecimal._abs15514 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "abs", "()Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._abs15515 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "abs", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._pow15516 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "pow", "(I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._pow15517 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "pow", "(ILjava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._min15518 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "min", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._max15519 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "max", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._compareTo15520 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "compareTo", "(Ljava/math/BigDecimal;)I");
			global::java.math.BigDecimal._compareTo15521 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.math.BigDecimal._valueOf15522 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "valueOf", "(JI)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._valueOf15523 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "valueOf", "(D)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._valueOf15524 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "valueOf", "(J)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._intValue15525 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "intValue", "()I");
			global::java.math.BigDecimal._longValue15526 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "longValue", "()J");
			global::java.math.BigDecimal._floatValue15527 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "floatValue", "()F");
			global::java.math.BigDecimal._doubleValue15528 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "doubleValue", "()D");
			global::java.math.BigDecimal._signum15529 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "signum", "()I");
			global::java.math.BigDecimal._round15530 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "round", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._ulp15531 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "ulp", "()Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._scale15532 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "scale", "()I");
			global::java.math.BigDecimal._subtract15533 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "subtract", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._subtract15534 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "subtract", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._multiply15535 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "multiply", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._multiply15536 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "multiply", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide15537 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide15538 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide15539 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide15540 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;Ljava/math/RoundingMode;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide15541 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divide15542 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;II)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divideAndRemainder15543 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideAndRemainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)[Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divideAndRemainder15544 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideAndRemainder", "(Ljava/math/BigDecimal;)[Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._remainder15545 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "remainder", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._remainder15546 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "remainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._negate15547 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "negate", "()Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._negate15548 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "negate", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._toBigInteger15549 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toBigInteger", "()Ljava/math/BigInteger;");
			global::java.math.BigDecimal._setScale15550 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "setScale", "(ILjava/math/RoundingMode;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._setScale15551 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "setScale", "(II)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._setScale15552 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "setScale", "(I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._precision15553 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "precision", "()I");
			global::java.math.BigDecimal._divideToIntegralValue15554 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideToIntegralValue", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._divideToIntegralValue15555 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "divideToIntegralValue", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._plus15556 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "plus", "()Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._plus15557 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "plus", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._unscaledValue15558 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "unscaledValue", "()Ljava/math/BigInteger;");
			global::java.math.BigDecimal._movePointLeft15559 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "movePointLeft", "(I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._movePointRight15560 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "movePointRight", "(I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._scaleByPowerOfTen15561 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "scaleByPowerOfTen", "(I)Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._stripTrailingZeros15562 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "stripTrailingZeros", "()Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._toEngineeringString15563 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toEngineeringString", "()Ljava/lang/String;");
			global::java.math.BigDecimal._toPlainString15564 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toPlainString", "()Ljava/lang/String;");
			global::java.math.BigDecimal._toBigIntegerExact15565 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "toBigIntegerExact", "()Ljava/math/BigInteger;");
			global::java.math.BigDecimal._longValueExact15566 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "longValueExact", "()J");
			global::java.math.BigDecimal._intValueExact15567 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "intValueExact", "()I");
			global::java.math.BigDecimal._shortValueExact15568 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "shortValueExact", "()S");
			global::java.math.BigDecimal._byteValueExact15569 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "byteValueExact", "()B");
			global::java.math.BigDecimal._BigDecimal15570 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([CII)V");
			global::java.math.BigDecimal._BigDecimal15571 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([CIILjava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal15572 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([C)V");
			global::java.math.BigDecimal._BigDecimal15573 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([CLjava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal15574 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.math.BigDecimal._BigDecimal15575 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/lang/String;Ljava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal15576 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(D)V");
			global::java.math.BigDecimal._BigDecimal15577 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(DLjava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal15578 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;)V");
			global::java.math.BigDecimal._BigDecimal15579 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal15580 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;I)V");
			global::java.math.BigDecimal._BigDecimal15581 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;ILjava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal15582 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(I)V");
			global::java.math.BigDecimal._BigDecimal15583 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(ILjava/math/MathContext;)V");
			global::java.math.BigDecimal._BigDecimal15584 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(J)V");
			global::java.math.BigDecimal._BigDecimal15585 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(JLjava/math/MathContext;)V");
		}
	}
}
