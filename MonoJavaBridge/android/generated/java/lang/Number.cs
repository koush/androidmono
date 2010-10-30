namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.Number_))]
	public abstract partial class Number : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Number(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _byteValue20354;
		public virtual byte byteValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Number._byteValue20354.native == global::System.IntPtr.Zero)
				global::java.lang.Number._byteValue20354 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "byteValue", "()B");
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.lang.Number.staticClass, global::java.lang.Number._byteValue20354);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue20355;
		public virtual short shortValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Number._shortValue20355.native == global::System.IntPtr.Zero)
				global::java.lang.Number._shortValue20355 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "shortValue", "()S");
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.lang.Number.staticClass, global::java.lang.Number._shortValue20355);
		}
		internal static global::MonoJavaBridge.MethodId _intValue20356;
		public abstract int intValue();
		internal static global::MonoJavaBridge.MethodId _longValue20357;
		public abstract long longValue();
		internal static global::MonoJavaBridge.MethodId _floatValue20358;
		public abstract float floatValue();
		internal static global::MonoJavaBridge.MethodId _doubleValue20359;
		public abstract double doubleValue();
		internal static global::MonoJavaBridge.MethodId _Number20360;
		public Number() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Number._Number20360.native == global::System.IntPtr.Zero)
				global::java.lang.Number._Number20360 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Number.staticClass, global::java.lang.Number._Number20360);
			Init(@__env, handle);
		}
		static Number()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Number.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Number"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Number))]
	internal sealed partial class Number_ : java.lang.Number
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Number_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _intValue20361;
		public override int intValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Number_._intValue20361.native == global::System.IntPtr.Zero)
				global::java.lang.Number_._intValue20361 = @__env.GetMethodIDNoThrow(global::java.lang.Number_.staticClass, "intValue", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Number_._intValue20361);
		}
		internal static global::MonoJavaBridge.MethodId _longValue20362;
		public override long longValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Number_._longValue20362.native == global::System.IntPtr.Zero)
				global::java.lang.Number_._longValue20362 = @__env.GetMethodIDNoThrow(global::java.lang.Number_.staticClass, "longValue", "()J");
			return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Number_._longValue20362);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue20363;
		public override float floatValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Number_._floatValue20363.native == global::System.IntPtr.Zero)
				global::java.lang.Number_._floatValue20363 = @__env.GetMethodIDNoThrow(global::java.lang.Number_.staticClass, "floatValue", "()F");
			return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Number_._floatValue20363);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue20364;
		public override double doubleValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Number_._doubleValue20364.native == global::System.IntPtr.Zero)
				global::java.lang.Number_._doubleValue20364 = @__env.GetMethodIDNoThrow(global::java.lang.Number_.staticClass, "doubleValue", "()D");
			return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Number_._doubleValue20364);
		}
		static Number_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Number_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Number"));
		}
		internal static void InitJNI()
		{
		}
	}
}
