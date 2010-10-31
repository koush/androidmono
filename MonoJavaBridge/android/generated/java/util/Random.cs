namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Random : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Random(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual int next(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Random.staticClass, "next", "(I)I", ref global::java.util.Random._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual double nextDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.util.Random.staticClass, "nextDouble", "()D", ref global::java.util.Random._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int nextInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Random.staticClass, "nextInt", "(I)I", ref global::java.util.Random._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int nextInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Random.staticClass, "nextInt", "()I", ref global::java.util.Random._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual long nextLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.Random.staticClass, "nextLong", "()J", ref global::java.util.Random._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void nextBytes(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Random.staticClass, "nextBytes", "([B)V", ref global::java.util.Random._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long Seed
		{
			set
			{
				setSeed(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setSeed(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Random.staticClass, "setSeed", "(J)V", ref global::java.util.Random._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool nextBoolean()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Random.staticClass, "nextBoolean", "()Z", ref global::java.util.Random._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual float nextFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.util.Random.staticClass, "nextFloat", "()F", ref global::java.util.Random._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual double nextGaussian()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.util.Random.staticClass, "nextGaussian", "()D", ref global::java.util.Random._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public Random() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Random._m10.native == global::System.IntPtr.Zero)
				global::java.util.Random._m10 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Random.staticClass, global::java.util.Random._m10);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public Random(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Random._m11.native == global::System.IntPtr.Zero)
				global::java.util.Random._m11 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "<init>", "(J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Random.staticClass, global::java.util.Random._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Random()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Random.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Random"));
		}
	}
}
