namespace java.lang
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.lang.Number_))]
	public abstract partial class Number : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Number(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual byte byteValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.lang.Number.staticClass, "byteValue", "()B", ref global::java.lang.Number._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual short shortValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.lang.Number.staticClass, "shortValue", "()S", ref global::java.lang.Number._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract int intValue();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract long longValue();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract float floatValue();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract double doubleValue();
		private static global::MonoJavaBridge.MethodId _m6;
		public Number() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Number._m6.native == global::System.IntPtr.Zero)
				global::java.lang.Number._m6 = @__env.GetMethodIDNoThrow(global::java.lang.Number.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Number.staticClass, global::java.lang.Number._m6);
			Init(@__env, handle);
		}
		static Number()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Number.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Number"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Number))]
	internal sealed partial class Number_ : java.lang.Number
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Number_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Number_.staticClass, "intValue", "()I", ref global::java.lang.Number_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Number_.staticClass, "longValue", "()J", ref global::java.lang.Number_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.lang.Number_.staticClass, "floatValue", "()F", ref global::java.lang.Number_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.lang.Number_.staticClass, "doubleValue", "()D", ref global::java.lang.Number_._m3);
		}
		static Number_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Number_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Number"));
		}
	}
}
