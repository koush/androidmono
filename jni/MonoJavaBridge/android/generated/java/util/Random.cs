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
		internal static global::MonoJavaBridge.MethodId _next26489;
		protected virtual int next(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Random._next26489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._next26489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextDouble26490;
		public virtual double nextDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.Random._nextDouble26490);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextDouble26490);
		}
		internal static global::MonoJavaBridge.MethodId _nextInt26491;
		public virtual int nextInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Random._nextInt26491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextInt26491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextInt26492;
		public virtual int nextInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Random._nextInt26492);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextInt26492);
		}
		internal static global::MonoJavaBridge.MethodId _nextLong26493;
		public virtual long nextLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.Random._nextLong26493);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextLong26493);
		}
		internal static global::MonoJavaBridge.MethodId _nextBytes26494;
		public virtual void nextBytes(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Random._nextBytes26494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextBytes26494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSeed26495;
		public virtual void setSeed(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Random._setSeed26495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._setSeed26495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextBoolean26496;
		public virtual bool nextBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Random._nextBoolean26496);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextBoolean26496);
		}
		internal static global::MonoJavaBridge.MethodId _nextFloat26497;
		public virtual float nextFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.Random._nextFloat26497);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextFloat26497);
		}
		internal static global::MonoJavaBridge.MethodId _nextGaussian26498;
		public virtual double nextGaussian() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.Random._nextGaussian26498);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextGaussian26498);
		}
		internal static global::MonoJavaBridge.MethodId _Random26499;
		public Random()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Random.staticClass, global::java.util.Random._Random26499);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Random26500;
		public Random(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Random.staticClass, global::java.util.Random._Random26500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Random.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Random"));
			global::java.util.Random._next26489 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "next", "(I)I");
			global::java.util.Random._nextDouble26490 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextDouble", "()D");
			global::java.util.Random._nextInt26491 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextInt", "(I)I");
			global::java.util.Random._nextInt26492 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextInt", "()I");
			global::java.util.Random._nextLong26493 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextLong", "()J");
			global::java.util.Random._nextBytes26494 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextBytes", "([B)V");
			global::java.util.Random._setSeed26495 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "setSeed", "(J)V");
			global::java.util.Random._nextBoolean26496 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextBoolean", "()Z");
			global::java.util.Random._nextFloat26497 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextFloat", "()F");
			global::java.util.Random._nextGaussian26498 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextGaussian", "()D");
			global::java.util.Random._Random26499 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "<init>", "()V");
			global::java.util.Random._Random26500 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "<init>", "(J)V");
		}
	}
}
