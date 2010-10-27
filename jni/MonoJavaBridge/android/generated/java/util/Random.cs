namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Random : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Random()
		{
			InitJNI();
		}
		protected Random(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _next26607;
		protected virtual int next(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Random._next26607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._next26607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextDouble26608;
		public virtual double nextDouble()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.Random._nextDouble26608);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextDouble26608);
		}
		internal static global::MonoJavaBridge.MethodId _nextInt26609;
		public virtual int nextInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Random._nextInt26609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextInt26609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextInt26610;
		public virtual int nextInt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Random._nextInt26610);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextInt26610);
		}
		internal static global::MonoJavaBridge.MethodId _nextLong26611;
		public virtual long nextLong()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.Random._nextLong26611);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextLong26611);
		}
		internal static global::MonoJavaBridge.MethodId _nextBytes26612;
		public virtual void nextBytes(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Random._nextBytes26612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextBytes26612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long Seed
		{
			set
			{
				setSeed(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSeed26613;
		public virtual void setSeed(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Random._setSeed26613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._setSeed26613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextBoolean26614;
		public virtual bool nextBoolean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Random._nextBoolean26614);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextBoolean26614);
		}
		internal static global::MonoJavaBridge.MethodId _nextFloat26615;
		public virtual float nextFloat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.Random._nextFloat26615);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextFloat26615);
		}
		internal static global::MonoJavaBridge.MethodId _nextGaussian26616;
		public virtual double nextGaussian()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.Random._nextGaussian26616);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextGaussian26616);
		}
		internal static global::MonoJavaBridge.MethodId _Random26617;
		public Random() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Random.staticClass, global::java.util.Random._Random26617);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Random26618;
		public Random(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Random.staticClass, global::java.util.Random._Random26618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Random.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Random"));
			global::java.util.Random._next26607 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "next", "(I)I");
			global::java.util.Random._nextDouble26608 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextDouble", "()D");
			global::java.util.Random._nextInt26609 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextInt", "(I)I");
			global::java.util.Random._nextInt26610 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextInt", "()I");
			global::java.util.Random._nextLong26611 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextLong", "()J");
			global::java.util.Random._nextBytes26612 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextBytes", "([B)V");
			global::java.util.Random._setSeed26613 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "setSeed", "(J)V");
			global::java.util.Random._nextBoolean26614 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextBoolean", "()Z");
			global::java.util.Random._nextFloat26615 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextFloat", "()F");
			global::java.util.Random._nextGaussian26616 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextGaussian", "()D");
			global::java.util.Random._Random26617 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "<init>", "()V");
			global::java.util.Random._Random26618 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "<init>", "(J)V");
		}
	}
}
