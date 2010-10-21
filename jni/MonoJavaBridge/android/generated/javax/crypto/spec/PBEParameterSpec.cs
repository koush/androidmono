namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PBEParameterSpec : java.lang.Object, java.security.spec.AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PBEParameterSpec()
		{
			InitJNI();
		}
		protected PBEParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int IterationCount
		{
			get
			{
				return getIterationCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIterationCount28681;
		public virtual int getIterationCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.spec.PBEParameterSpec._getIterationCount28681);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.spec.PBEParameterSpec.staticClass, global::javax.crypto.spec.PBEParameterSpec._getIterationCount28681);
		}
		public new byte[] Salt
		{
			get
			{
				return getSalt();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSalt28682;
		public virtual byte[] getSalt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.PBEParameterSpec._getSalt28682)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.PBEParameterSpec.staticClass, global::javax.crypto.spec.PBEParameterSpec._getSalt28682)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _PBEParameterSpec28683;
		public PBEParameterSpec(byte[] arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.PBEParameterSpec.staticClass, global::javax.crypto.spec.PBEParameterSpec._PBEParameterSpec28683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.PBEParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/PBEParameterSpec"));
			global::javax.crypto.spec.PBEParameterSpec._getIterationCount28681 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEParameterSpec.staticClass, "getIterationCount", "()I");
			global::javax.crypto.spec.PBEParameterSpec._getSalt28682 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEParameterSpec.staticClass, "getSalt", "()[B");
			global::javax.crypto.spec.PBEParameterSpec._PBEParameterSpec28683 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.PBEParameterSpec.staticClass, "<init>", "([BI)V");
		}
	}
}
