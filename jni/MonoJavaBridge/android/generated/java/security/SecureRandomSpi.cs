namespace java.security
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class SecureRandomSpi : java.lang.Object, java.io.Serializable
	{
		internal static global::java.lang.Class staticClass;
		static SecureRandomSpi()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.SecureRandomSpi), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected SecureRandomSpi(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _engineSetSeed13295;
		protected abstract void engineSetSeed(byte[] arg0);
		internal static global::net.sf.jni4net.jni.MethodId _engineNextBytes13296;
		protected abstract void engineNextBytes(byte[] arg0);
		internal static global::net.sf.jni4net.jni.MethodId _engineGenerateSeed13297;
		protected abstract byte[] engineGenerateSeed(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _SecureRandomSpi13298;
		public SecureRandomSpi()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.SecureRandomSpi.staticClass, global::java.security.SecureRandomSpi._SecureRandomSpi13298, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.SecureRandomSpi.staticClass = @__class;
			global::java.security.SecureRandomSpi._engineSetSeed13295 = @__env.GetMethodID(global::java.security.SecureRandomSpi.staticClass, "engineSetSeed", "([B)V");
			global::java.security.SecureRandomSpi._engineNextBytes13296 = @__env.GetMethodID(global::java.security.SecureRandomSpi.staticClass, "engineNextBytes", "([B)V");
			global::java.security.SecureRandomSpi._engineGenerateSeed13297 = @__env.GetMethodID(global::java.security.SecureRandomSpi.staticClass, "engineGenerateSeed", "(I)[B");
			global::java.security.SecureRandomSpi._SecureRandomSpi13298 = @__env.GetMethodID(global::java.security.SecureRandomSpi.staticClass, "<init>", "()V");
		}
	}
}
