namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Random : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Random() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.Random), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _next12961; 
		protected virtual int next(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallIntMethod(this, _next12961, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Random.staticClass, _next12961, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextInt12962; 
		public virtual int nextInt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallIntMethod(this, _nextInt12962); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Random.staticClass, _nextInt12962); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextInt12963; 
		public virtual int nextInt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallIntMethod(this, _nextInt12963, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Random.staticClass, _nextInt12963, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextLong12964; 
		public virtual long nextLong() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallLongMethod(this, _nextLong12964); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.Random.staticClass, _nextLong12964); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextDouble12965; 
		public virtual double nextDouble() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallDoubleMethod(this, _nextDouble12965); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, java.util.Random.staticClass, _nextDouble12965); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextBytes12966; 
		public virtual void nextBytes(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				@__env.CallVoidMethod(this, _nextBytes12966, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Random.staticClass, _nextBytes12966, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSeed12967; 
		public virtual void setSeed(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				@__env.CallVoidMethod(this, _setSeed12967, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Random.staticClass, _setSeed12967, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextBoolean12968; 
		public virtual bool nextBoolean() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallBooleanMethod(this, _nextBoolean12968); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Random.staticClass, _nextBoolean12968); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextFloat12969; 
		public virtual float nextFloat() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallFloatMethod(this, _nextFloat12969); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, java.util.Random.staticClass, _nextFloat12969); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextGaussian12970; 
		public virtual double nextGaussian() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallDoubleMethod(this, _nextGaussian12970); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, java.util.Random.staticClass, _nextGaussian12970); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Random12971; 
		public Random()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Random.staticClass, _Random12971, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Random12972; 
		public Random(long arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Random.staticClass, _Random12972, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.Random.staticClass = @__class; 
			global::java.util.Random._next12961 = @__env.GetMethodID(global::java.util.Random.staticClass, "next", "(I)I"); 
			global::java.util.Random._nextInt12962 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextInt", "()I"); 
			global::java.util.Random._nextInt12963 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextInt", "(I)I"); 
			global::java.util.Random._nextLong12964 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextLong", "()J"); 
			global::java.util.Random._nextDouble12965 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextDouble", "()D"); 
			global::java.util.Random._nextBytes12966 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextBytes", "([B)V"); 
			global::java.util.Random._setSeed12967 = @__env.GetMethodID(global::java.util.Random.staticClass, "setSeed", "(J)V"); 
			global::java.util.Random._nextBoolean12968 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextBoolean", "()Z"); 
			global::java.util.Random._nextFloat12969 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextFloat", "()F"); 
			global::java.util.Random._nextGaussian12970 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextGaussian", "()D"); 
			global::java.util.Random._Random12971 = @__env.GetMethodID(global::java.util.Random.staticClass, "<init>", "()V"); 
			global::java.util.Random._Random12972 = @__env.GetMethodID(global::java.util.Random.staticClass, "<init>", "(J)V"); 
		} 
	} 
} 
