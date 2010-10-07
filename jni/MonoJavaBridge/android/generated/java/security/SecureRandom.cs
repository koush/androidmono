namespace java.security
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SecureRandom : java.util.Random
	{
		internal new static global::java.lang.Class staticClass;
		static SecureRandom()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.SecureRandom), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.security.SecureRandom(@__env);
			}
		}
		protected SecureRandom(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _next13281;
		protected sealed override int next(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.security.SecureRandom._next13281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.security.SecureRandom.staticClass, global::java.security.SecureRandom._next13281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance13282;
		public static global::java.security.SecureRandom getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.SecureRandom>(@__env, @__env.CallStaticObjectMethodPtr(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._getInstance13282, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance13283;
		public static global::java.security.SecureRandom getInstance(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.SecureRandom>(@__env, @__env.CallStaticObjectMethodPtr(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._getInstance13283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance13284;
		public static global::java.security.SecureRandom getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.SecureRandom>(@__env, @__env.CallStaticObjectMethodPtr(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._getInstance13284, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAlgorithm13285;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.SecureRandom._getAlgorithm13285));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.SecureRandom.staticClass, global::java.security.SecureRandom._getAlgorithm13285));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProvider13286;
		public virtual global::java.security.Provider getProvider() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Provider>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.SecureRandom._getProvider13286));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Provider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.SecureRandom.staticClass, global::java.security.SecureRandom._getProvider13286));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextBytes13287;
		public override void nextBytes(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.SecureRandom._nextBytes13287, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.SecureRandom.staticClass, global::java.security.SecureRandom._nextBytes13287, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSeed13288;
		public override void setSeed(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.SecureRandom._setSeed13288, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.SecureRandom.staticClass, global::java.security.SecureRandom._setSeed13288, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSeed13289;
		public virtual void setSeed(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.SecureRandom._setSeed13289, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.SecureRandom.staticClass, global::java.security.SecureRandom._setSeed13289, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSeed13290;
		public static byte[] getSeed(int arg0) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._getSeed13290, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateSeed13291;
		public virtual byte[] generateSeed(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.security.SecureRandom._generateSeed13291, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.SecureRandom.staticClass, global::java.security.SecureRandom._generateSeed13291, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SecureRandom13292;
		public SecureRandom(byte[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._SecureRandom13292, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SecureRandom13293;
		public SecureRandom()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._SecureRandom13293, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SecureRandom13294;
		protected SecureRandom(java.security.SecureRandomSpi arg0, java.security.Provider arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.SecureRandom.staticClass, global::java.security.SecureRandom._SecureRandom13294, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.SecureRandom.staticClass = @__class;
			global::java.security.SecureRandom._next13281 = @__env.GetMethodID(global::java.security.SecureRandom.staticClass, "next", "(I)I");
			global::java.security.SecureRandom._getInstance13282 = @__env.GetStaticMethodID(global::java.security.SecureRandom.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/SecureRandom;");
			global::java.security.SecureRandom._getInstance13283 = @__env.GetStaticMethodID(global::java.security.SecureRandom.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/SecureRandom;");
			global::java.security.SecureRandom._getInstance13284 = @__env.GetStaticMethodID(global::java.security.SecureRandom.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/SecureRandom;");
			global::java.security.SecureRandom._getAlgorithm13285 = @__env.GetMethodID(global::java.security.SecureRandom.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.SecureRandom._getProvider13286 = @__env.GetMethodID(global::java.security.SecureRandom.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.SecureRandom._nextBytes13287 = @__env.GetMethodID(global::java.security.SecureRandom.staticClass, "nextBytes", "([B)V");
			global::java.security.SecureRandom._setSeed13288 = @__env.GetMethodID(global::java.security.SecureRandom.staticClass, "setSeed", "(J)V");
			global::java.security.SecureRandom._setSeed13289 = @__env.GetMethodID(global::java.security.SecureRandom.staticClass, "setSeed", "([B)V");
			global::java.security.SecureRandom._getSeed13290 = @__env.GetStaticMethodID(global::java.security.SecureRandom.staticClass, "getSeed", "(I)[B");
			global::java.security.SecureRandom._generateSeed13291 = @__env.GetMethodID(global::java.security.SecureRandom.staticClass, "generateSeed", "(I)[B");
			global::java.security.SecureRandom._SecureRandom13292 = @__env.GetMethodID(global::java.security.SecureRandom.staticClass, "<init>", "([B)V");
			global::java.security.SecureRandom._SecureRandom13293 = @__env.GetMethodID(global::java.security.SecureRandom.staticClass, "<init>", "()V");
			global::java.security.SecureRandom._SecureRandom13294 = @__env.GetMethodID(global::java.security.SecureRandom.staticClass, "<init>", "(Ljava/security/SecureRandomSpi;Ljava/security/Provider;)V");
		}
	}
}
