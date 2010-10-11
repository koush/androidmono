namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.Number_))]
	public abstract partial class Number : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Number()
		{
			InitJNI();
		}
		protected Number(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _byteValue13064;
		public virtual byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Number._byteValue13064);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Number.staticClass, global::java.lang.Number._byteValue13064);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue13065;
		public virtual short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Number._shortValue13065);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Number.staticClass, global::java.lang.Number._shortValue13065);
		}
		internal static global::MonoJavaBridge.MethodId _intValue13066;
		public abstract int intValue();
		internal static global::MonoJavaBridge.MethodId _longValue13067;
		public abstract long longValue();
		internal static global::MonoJavaBridge.MethodId _floatValue13068;
		public abstract float floatValue();
		internal static global::MonoJavaBridge.MethodId _doubleValue13069;
		public abstract double doubleValue();
		internal static global::MonoJavaBridge.MethodId _Number13070;
		public Number()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Number.staticClass, global::java.lang.Number._Number13070);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Number.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Number"));
			global::java.lang.Number._byteValue13064 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "byteValue", "()B");
			global::java.lang.Number._shortValue13065 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "shortValue", "()S");
			global::java.lang.Number._intValue13066 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "intValue", "()I");
			global::java.lang.Number._longValue13067 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "longValue", "()J");
			global::java.lang.Number._floatValue13068 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "floatValue", "()F");
			global::java.lang.Number._doubleValue13069 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "doubleValue", "()D");
			global::java.lang.Number._Number13070 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Number))]
	public sealed partial class Number_ : java.lang.Number
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Number_()
		{
			InitJNI();
		}
		internal Number_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _intValue13071;
		public override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Number_._intValue13071);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Number_.staticClass, global::java.lang.Number_._intValue13071);
		}
		internal static global::MonoJavaBridge.MethodId _longValue13072;
		public override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Number_._longValue13072);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Number_.staticClass, global::java.lang.Number_._longValue13072);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue13073;
		public override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Number_._floatValue13073);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Number_.staticClass, global::java.lang.Number_._floatValue13073);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue13074;
		public override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Number_._doubleValue13074);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Number_.staticClass, global::java.lang.Number_._doubleValue13074);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Number_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Number"));
			global::java.lang.Number_._intValue13071 = @__env.GetMethodIDNoThrow(global::java.lang.Number_.staticClass, "intValue", "()I");
			global::java.lang.Number_._longValue13072 = @__env.GetMethodIDNoThrow(global::java.lang.Number_.staticClass, "longValue", "()J");
			global::java.lang.Number_._floatValue13073 = @__env.GetMethodIDNoThrow(global::java.lang.Number_.staticClass, "floatValue", "()F");
			global::java.lang.Number_._doubleValue13074 = @__env.GetMethodIDNoThrow(global::java.lang.Number_.staticClass, "doubleValue", "()D");
		}
	}
}
