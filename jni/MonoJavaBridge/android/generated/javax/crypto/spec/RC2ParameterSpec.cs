namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RC2ParameterSpec : java.lang.Object, java.security.spec.AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RC2ParameterSpec()
		{
			InitJNI();
		}
		protected RC2ParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals28807;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.crypto.spec.RC2ParameterSpec._equals28807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.crypto.spec.RC2ParameterSpec.staticClass, global::javax.crypto.spec.RC2ParameterSpec._equals28807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode28808;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.spec.RC2ParameterSpec._hashCode28808);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.spec.RC2ParameterSpec.staticClass, global::javax.crypto.spec.RC2ParameterSpec._hashCode28808);
		}
		public new byte[] IV
		{
			get
			{
				return getIV();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIV28809;
		public virtual byte[] getIV() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.RC2ParameterSpec._getIV28809)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.RC2ParameterSpec.staticClass, global::javax.crypto.spec.RC2ParameterSpec._getIV28809)) as byte[];
		}
		public new int EffectiveKeyBits
		{
			get
			{
				return getEffectiveKeyBits();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEffectiveKeyBits28810;
		public virtual int getEffectiveKeyBits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.spec.RC2ParameterSpec._getEffectiveKeyBits28810);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.spec.RC2ParameterSpec.staticClass, global::javax.crypto.spec.RC2ParameterSpec._getEffectiveKeyBits28810);
		}
		internal static global::MonoJavaBridge.MethodId _RC2ParameterSpec28811;
		public RC2ParameterSpec(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.RC2ParameterSpec.staticClass, global::javax.crypto.spec.RC2ParameterSpec._RC2ParameterSpec28811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RC2ParameterSpec28812;
		public RC2ParameterSpec(int arg0, byte[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.RC2ParameterSpec.staticClass, global::javax.crypto.spec.RC2ParameterSpec._RC2ParameterSpec28812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RC2ParameterSpec28813;
		public RC2ParameterSpec(int arg0, byte[] arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.RC2ParameterSpec.staticClass, global::javax.crypto.spec.RC2ParameterSpec._RC2ParameterSpec28813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.RC2ParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/RC2ParameterSpec"));
			global::javax.crypto.spec.RC2ParameterSpec._equals28807 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC2ParameterSpec.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.crypto.spec.RC2ParameterSpec._hashCode28808 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC2ParameterSpec.staticClass, "hashCode", "()I");
			global::javax.crypto.spec.RC2ParameterSpec._getIV28809 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC2ParameterSpec.staticClass, "getIV", "()[B");
			global::javax.crypto.spec.RC2ParameterSpec._getEffectiveKeyBits28810 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC2ParameterSpec.staticClass, "getEffectiveKeyBits", "()I");
			global::javax.crypto.spec.RC2ParameterSpec._RC2ParameterSpec28811 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC2ParameterSpec.staticClass, "<init>", "(I)V");
			global::javax.crypto.spec.RC2ParameterSpec._RC2ParameterSpec28812 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC2ParameterSpec.staticClass, "<init>", "(I[B)V");
			global::javax.crypto.spec.RC2ParameterSpec._RC2ParameterSpec28813 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC2ParameterSpec.staticClass, "<init>", "(I[BI)V");
		}
	}
}
