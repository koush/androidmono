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
		internal static global::net.sf.jni4net.jni.MethodId _next12038; 
		protected virtual int next(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallIntMethod(this, _next12038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Random.staticClass, _next12038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextInt12039; 
		public virtual int nextInt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallIntMethod(this, _nextInt12039); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Random.staticClass, _nextInt12039); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextInt12040; 
		public virtual int nextInt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallIntMethod(this, _nextInt12040, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Random.staticClass, _nextInt12040, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextLong12041; 
		public virtual long nextLong() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallLongMethod(this, _nextLong12041); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.Random.staticClass, _nextLong12041); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextDouble12042; 
		public virtual double nextDouble() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallDoubleMethod(this, _nextDouble12042); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, java.util.Random.staticClass, _nextDouble12042); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextBytes12043; 
		public virtual void nextBytes(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				@__env.CallVoidMethod(this, _nextBytes12043, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Random.staticClass, _nextBytes12043, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSeed12044; 
		public virtual void setSeed(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				@__env.CallVoidMethod(this, _setSeed12044, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Random.staticClass, _setSeed12044, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextBoolean12045; 
		public virtual bool nextBoolean() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallBooleanMethod(this, _nextBoolean12045); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Random.staticClass, _nextBoolean12045); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextFloat12046; 
		public virtual float nextFloat() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallFloatMethod(this, _nextFloat12046); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, java.util.Random.staticClass, _nextFloat12046); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextGaussian12047; 
		public virtual double nextGaussian() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Random)) 
				return @__env.CallDoubleMethod(this, _nextGaussian12047); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, java.util.Random.staticClass, _nextGaussian12047); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Random12048; 
		public Random()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Random.staticClass, _Random12048, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Random12049; 
		public Random(long arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Random.staticClass, _Random12049, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.Random.staticClass = @__class; 
			global::java.util.Random._next12038 = @__env.GetMethodID(global::java.util.Random.staticClass, "next", "(I)I"); 
			global::java.util.Random._nextInt12039 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextInt", "()I"); 
			global::java.util.Random._nextInt12040 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextInt", "(I)I"); 
			global::java.util.Random._nextLong12041 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextLong", "()J"); 
			global::java.util.Random._nextDouble12042 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextDouble", "()D"); 
			global::java.util.Random._nextBytes12043 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextBytes", "([B)V"); 
			global::java.util.Random._setSeed12044 = @__env.GetMethodID(global::java.util.Random.staticClass, "setSeed", "(J)V"); 
			global::java.util.Random._nextBoolean12045 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextBoolean", "()Z"); 
			global::java.util.Random._nextFloat12046 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextFloat", "()F"); 
			global::java.util.Random._nextGaussian12047 = @__env.GetMethodID(global::java.util.Random.staticClass, "nextGaussian", "()D"); 
			global::java.util.Random._Random12048 = @__env.GetMethodID(global::java.util.Random.staticClass, "<init>", "()V"); 
			global::java.util.Random._Random12049 = @__env.GetMethodID(global::java.util.Random.staticClass, "<init>", "(J)V"); 
		} 
	} 
} 
