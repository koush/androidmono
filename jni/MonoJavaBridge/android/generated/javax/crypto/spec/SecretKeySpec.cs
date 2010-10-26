namespace javax.crypto.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SecretKeySpec : java.lang.Object, java.security.spec.KeySpec, SecretKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SecretKeySpec()
		{
			InitJNI();
		}
		protected SecretKeySpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals28823;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.crypto.spec.SecretKeySpec._equals28823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.crypto.spec.SecretKeySpec.staticClass, global::javax.crypto.spec.SecretKeySpec._equals28823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode28824;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.spec.SecretKeySpec._hashCode28824);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.spec.SecretKeySpec.staticClass, global::javax.crypto.spec.SecretKeySpec._hashCode28824);
		}
		public new byte[] Encoded
		{
			get
			{
				return getEncoded();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEncoded28825;
		public virtual byte[] getEncoded() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.SecretKeySpec._getEncoded28825)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.SecretKeySpec.staticClass, global::javax.crypto.spec.SecretKeySpec._getEncoded28825)) as byte[];
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28826;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.SecretKeySpec._getAlgorithm28826)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.SecretKeySpec.staticClass, global::javax.crypto.spec.SecretKeySpec._getAlgorithm28826)) as java.lang.String;
		}
		public new global::java.lang.String Format
		{
			get
			{
				return getFormat();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFormat28827;
		public virtual global::java.lang.String getFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.spec.SecretKeySpec._getFormat28827)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.spec.SecretKeySpec.staticClass, global::javax.crypto.spec.SecretKeySpec._getFormat28827)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _SecretKeySpec28828;
		public SecretKeySpec(byte[] arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.SecretKeySpec.staticClass, global::javax.crypto.spec.SecretKeySpec._SecretKeySpec28828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SecretKeySpec28829;
		public SecretKeySpec(byte[] arg0, int arg1, int arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.spec.SecretKeySpec.staticClass, global::javax.crypto.spec.SecretKeySpec._SecretKeySpec28829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.spec.SecretKeySpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/spec/SecretKeySpec"));
			global::javax.crypto.spec.SecretKeySpec._equals28823 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.SecretKeySpec.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.crypto.spec.SecretKeySpec._hashCode28824 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.SecretKeySpec.staticClass, "hashCode", "()I");
			global::javax.crypto.spec.SecretKeySpec._getEncoded28825 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.SecretKeySpec.staticClass, "getEncoded", "()[B");
			global::javax.crypto.spec.SecretKeySpec._getAlgorithm28826 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.SecretKeySpec.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.spec.SecretKeySpec._getFormat28827 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.SecretKeySpec.staticClass, "getFormat", "()Ljava/lang/String;");
			global::javax.crypto.spec.SecretKeySpec._SecretKeySpec28828 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.SecretKeySpec.staticClass, "<init>", "([BLjava/lang/String;)V");
			global::javax.crypto.spec.SecretKeySpec._SecretKeySpec28829 = @__env.GetMethodIDNoThrow(global::javax.crypto.spec.SecretKeySpec.staticClass, "<init>", "([BIILjava/lang/String;)V");
		}
	}
}
