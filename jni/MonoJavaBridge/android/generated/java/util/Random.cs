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
		internal static global::MonoJavaBridge.MethodId _next20664;
		protected virtual int next(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Random._next20664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._next20664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextDouble20665;
		public virtual double nextDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.Random._nextDouble20665);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextDouble20665);
		}
		internal static global::MonoJavaBridge.MethodId _nextInt20666;
		public virtual int nextInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Random._nextInt20666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextInt20666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextInt20667;
		public virtual int nextInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Random._nextInt20667);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextInt20667);
		}
		internal static global::MonoJavaBridge.MethodId _nextLong20668;
		public virtual long nextLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.Random._nextLong20668);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextLong20668);
		}
		internal static global::MonoJavaBridge.MethodId _nextBytes20669;
		public virtual void nextBytes(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Random._nextBytes20669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextBytes20669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSeed20670;
		public virtual void setSeed(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Random._setSeed20670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._setSeed20670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextBoolean20671;
		public virtual bool nextBoolean() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Random._nextBoolean20671);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextBoolean20671);
		}
		internal static global::MonoJavaBridge.MethodId _nextFloat20672;
		public virtual float nextFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.util.Random._nextFloat20672);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextFloat20672);
		}
		internal static global::MonoJavaBridge.MethodId _nextGaussian20673;
		public virtual double nextGaussian() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.util.Random._nextGaussian20673);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.util.Random.staticClass, global::java.util.Random._nextGaussian20673);
		}
		internal static global::MonoJavaBridge.MethodId _Random20674;
		public Random()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Random.staticClass, global::java.util.Random._Random20674);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Random20675;
		public Random(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Random.staticClass, global::java.util.Random._Random20675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Random.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Random"));
			global::java.util.Random._next20664 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "next", "(I)I");
			global::java.util.Random._nextDouble20665 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextDouble", "()D");
			global::java.util.Random._nextInt20666 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextInt", "(I)I");
			global::java.util.Random._nextInt20667 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextInt", "()I");
			global::java.util.Random._nextLong20668 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextLong", "()J");
			global::java.util.Random._nextBytes20669 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextBytes", "([B)V");
			global::java.util.Random._setSeed20670 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "setSeed", "(J)V");
			global::java.util.Random._nextBoolean20671 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextBoolean", "()Z");
			global::java.util.Random._nextFloat20672 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextFloat", "()F");
			global::java.util.Random._nextGaussian20673 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "nextGaussian", "()D");
			global::java.util.Random._Random20674 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "<init>", "()V");
			global::java.util.Random._Random20675 = @__env.GetMethodIDNoThrow(global::java.util.Random.staticClass, "<init>", "(J)V");
		}
	}
}
