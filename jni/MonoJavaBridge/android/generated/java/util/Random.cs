namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Random : java.lang.Object, java.io.Serializable
	{
		internal static global::java.lang.Class staticClass;
		static Random()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.Random), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.util.Random(@__env);
			}
		}
		protected Random(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _next13792;
		protected virtual int next(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Random._next13792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Random.staticClass, global::java.util.Random._next13792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextDouble13793;
		public virtual double nextDouble() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::java.util.Random._nextDouble13793);
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::java.util.Random.staticClass, global::java.util.Random._nextDouble13793);
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextInt13794;
		public virtual int nextInt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Random._nextInt13794, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Random.staticClass, global::java.util.Random._nextInt13794, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextInt13795;
		public virtual int nextInt() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Random._nextInt13795);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Random.staticClass, global::java.util.Random._nextInt13795);
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextLong13796;
		public virtual long nextLong() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.util.Random._nextLong13796);
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.util.Random.staticClass, global::java.util.Random._nextLong13796);
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextBytes13797;
		public virtual void nextBytes(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Random._nextBytes13797, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Random.staticClass, global::java.util.Random._nextBytes13797, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSeed13798;
		public virtual void setSeed(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Random._setSeed13798, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Random.staticClass, global::java.util.Random._setSeed13798, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextBoolean13799;
		public virtual bool nextBoolean() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.Random._nextBoolean13799);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.Random.staticClass, global::java.util.Random._nextBoolean13799);
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextFloat13800;
		public virtual float nextFloat() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::java.util.Random._nextFloat13800);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::java.util.Random.staticClass, global::java.util.Random._nextFloat13800);
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextGaussian13801;
		public virtual double nextGaussian() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::java.util.Random._nextGaussian13801);
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::java.util.Random.staticClass, global::java.util.Random._nextGaussian13801);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Random13802;
		public Random()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Random.staticClass, global::java.util.Random._Random13802, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Random13803;
		public Random(long arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Random.staticClass, global::java.util.Random._Random13803, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.Random.staticClass = @__class;
			global::java.util.Random._next13792 = @__env.GetMethodID(global::java.util.Random.staticClass, "next", "(I)I");
			global::java.util.Random._nextDouble13793 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextDouble", "()D");
			global::java.util.Random._nextInt13794 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextInt", "(I)I");
			global::java.util.Random._nextInt13795 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextInt", "()I");
			global::java.util.Random._nextLong13796 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextLong", "()J");
			global::java.util.Random._nextBytes13797 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextBytes", "([B)V");
			global::java.util.Random._setSeed13798 = @__env.GetMethodID(global::java.util.Random.staticClass, "setSeed", "(J)V");
			global::java.util.Random._nextBoolean13799 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextBoolean", "()Z");
			global::java.util.Random._nextFloat13800 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextFloat", "()F");
			global::java.util.Random._nextGaussian13801 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextGaussian", "()D");
			global::java.util.Random._Random13802 = @__env.GetMethodID(global::java.util.Random.staticClass, "<init>", "()V");
			global::java.util.Random._Random13803 = @__env.GetMethodID(global::java.util.Random.staticClass, "<init>", "(J)V");
		}
	}
}
