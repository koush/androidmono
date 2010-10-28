namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RC5ParameterSpec : java.lang.Object, java.security.spec.AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RC5ParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals28815;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.crypto.spec.RC5ParameterSpec._equals28815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.crypto.spec.RC5ParameterSpec.staticClass, global::javax.crypto.spec.RC5ParameterSpec._equals28815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode28816;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.spec.RC5ParameterSpec._hashCode28816);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.spec.RC5ParameterSpec.staticClass, global::javax.crypto.spec.RC5ParameterSpec._hashCode28816);
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersion28817;
		public virtual int getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.spec.RC5ParameterSpec._getVersion28817);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.spec.RC5ParameterSpec.staticClass, global::javax.crypto.spec.RC5ParameterSpec._getVersion28817);
		}
		public new byte[] IV
		{
			get
			{
				return getIV();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIV28818;
		public virtual byte[] getIV()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.RC5ParameterSpec._getIV28818)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.RC5ParameterSpec.staticClass, global::javax.crypto.spec.RC5ParameterSpec._getIV28818)) as byte[];
		}
		public new int Rounds
		{
			get
			{
				return getRounds();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRounds28819;
		public virtual int getRounds()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.spec.RC5ParameterSpec._getRounds28819);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.spec.RC5ParameterSpec.staticClass, global::javax.crypto.spec.RC5ParameterSpec._getRounds28819);
		}
		public new int WordSize
		{
			get
			{
				return getWordSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWordSize28820;
		public virtual int getWordSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.spec.RC5ParameterSpec._getWordSize28820);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.spec.RC5ParameterSpec.staticClass, global::javax.crypto.spec.RC5ParameterSpec._getWordSize28820);
		}
		internal static global::MonoJavaBridge.MethodId _RC5ParameterSpec28821;
		public RC5ParameterSpec(int arg0, int arg1, int arg2, byte[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.RC5ParameterSpec.staticClass, global::javax.crypto.spec.RC5ParameterSpec._RC5ParameterSpec28821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RC5ParameterSpec28822;
		public RC5ParameterSpec(int arg0, int arg1, int arg2, byte[] arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.RC5ParameterSpec.staticClass, global::javax.crypto.spec.RC5ParameterSpec._RC5ParameterSpec28822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RC5ParameterSpec28823;
		public RC5ParameterSpec(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.RC5ParameterSpec.staticClass, global::javax.crypto.spec.RC5ParameterSpec._RC5ParameterSpec28823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static RC5ParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.RC5ParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/RC5ParameterSpec"));
			global::javax.crypto.spec.RC5ParameterSpec._equals28815 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC5ParameterSpec.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.crypto.spec.RC5ParameterSpec._hashCode28816 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC5ParameterSpec.staticClass, "hashCode", "()I");
			global::javax.crypto.spec.RC5ParameterSpec._getVersion28817 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC5ParameterSpec.staticClass, "getVersion", "()I");
			global::javax.crypto.spec.RC5ParameterSpec._getIV28818 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC5ParameterSpec.staticClass, "getIV", "()[B");
			global::javax.crypto.spec.RC5ParameterSpec._getRounds28819 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC5ParameterSpec.staticClass, "getRounds", "()I");
			global::javax.crypto.spec.RC5ParameterSpec._getWordSize28820 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC5ParameterSpec.staticClass, "getWordSize", "()I");
			global::javax.crypto.spec.RC5ParameterSpec._RC5ParameterSpec28821 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC5ParameterSpec.staticClass, "<init>", "(III[B)V");
			global::javax.crypto.spec.RC5ParameterSpec._RC5ParameterSpec28822 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC5ParameterSpec.staticClass, "<init>", "(III[BI)V");
			global::javax.crypto.spec.RC5ParameterSpec._RC5ParameterSpec28823 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.RC5ParameterSpec.staticClass, "<init>", "(III)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
