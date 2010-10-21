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
		internal static global::MonoJavaBridge.MethodId _byteValue20236;
		public virtual byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Number._byteValue20236);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Number.staticClass, global::java.lang.Number._byteValue20236);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue20237;
		public virtual short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Number._shortValue20237);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Number.staticClass, global::java.lang.Number._shortValue20237);
		}
		internal static global::MonoJavaBridge.MethodId _intValue20238;
		public abstract int intValue();
		internal static global::MonoJavaBridge.MethodId _longValue20239;
		public abstract long longValue();
		internal static global::MonoJavaBridge.MethodId _floatValue20240;
		public abstract float floatValue();
		internal static global::MonoJavaBridge.MethodId _doubleValue20241;
		public abstract double doubleValue();
		internal static global::MonoJavaBridge.MethodId _Number20242;
		public Number()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Number.staticClass, global::java.lang.Number._Number20242);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Number.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Number"));
			global::java.lang.Number._byteValue20236 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "byteValue", "()B");
			global::java.lang.Number._shortValue20237 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "shortValue", "()S");
			global::java.lang.Number._intValue20238 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "intValue", "()I");
			global::java.lang.Number._longValue20239 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "longValue", "()J");
			global::java.lang.Number._floatValue20240 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "floatValue", "()F");
			global::java.lang.Number._doubleValue20241 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "doubleValue", "()D");
			global::java.lang.Number._Number20242 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _intValue20243;
		public override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Number_._intValue20243);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Number_.staticClass, global::java.lang.Number_._intValue20243);
		}
		internal static global::MonoJavaBridge.MethodId _longValue20244;
		public override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Number_._longValue20244);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Number_.staticClass, global::java.lang.Number_._longValue20244);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue20245;
		public override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Number_._floatValue20245);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Number_.staticClass, global::java.lang.Number_._floatValue20245);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue20246;
		public override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Number_._doubleValue20246);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Number_.staticClass, global::java.lang.Number_._doubleValue20246);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Number_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Number"));
			global::java.lang.Number_._intValue20243 = @__env.GetMethodIDNoThrow(global::java.lang.Number_.staticClass, "intValue", "()I");
			global::java.lang.Number_._longValue20244 = @__env.GetMethodIDNoThrow(global::java.lang.Number_.staticClass, "longValue", "()J");
			global::java.lang.Number_._floatValue20245 = @__env.GetMethodIDNoThrow(global::java.lang.Number_.staticClass, "floatValue", "()F");
			global::java.lang.Number_._doubleValue20246 = @__env.GetMethodIDNoThrow(global::java.lang.Number_.staticClass, "doubleValue", "()D");
		}
	}
}
