namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SealedObject : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SealedObject()
		{
			InitJNI();
		}
		protected SealedObject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getObject28589;
		public virtual global::java.lang.Object getObject(javax.crypto.Cipher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SealedObject._getObject28589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SealedObject.staticClass, global::javax.crypto.SealedObject._getObject28589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject28590;
		public virtual global::java.lang.Object getObject(java.security.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SealedObject._getObject28590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SealedObject.staticClass, global::javax.crypto.SealedObject._getObject28590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject28591;
		public virtual global::java.lang.Object getObject(java.security.Key arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SealedObject._getObject28591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SealedObject.staticClass, global::javax.crypto.SealedObject._getObject28591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm28592;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SealedObject._getAlgorithm28592)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SealedObject.staticClass, global::javax.crypto.SealedObject._getAlgorithm28592)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _SealedObject28593;
		public SealedObject(java.io.Serializable arg0, javax.crypto.Cipher arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.SealedObject.staticClass, global::javax.crypto.SealedObject._SealedObject28593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SealedObject28594;
		protected SealedObject(javax.crypto.SealedObject arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.SealedObject.staticClass, global::javax.crypto.SealedObject._SealedObject28594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.SealedObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/SealedObject"));
			global::javax.crypto.SealedObject._getObject28589 = @__env.GetMethodIDNoThrow(global::javax.crypto.SealedObject.staticClass, "getObject", "(Ljavax/crypto/Cipher;)Ljava/lang/Object;");
			global::javax.crypto.SealedObject._getObject28590 = @__env.GetMethodIDNoThrow(global::javax.crypto.SealedObject.staticClass, "getObject", "(Ljava/security/Key;)Ljava/lang/Object;");
			global::javax.crypto.SealedObject._getObject28591 = @__env.GetMethodIDNoThrow(global::javax.crypto.SealedObject.staticClass, "getObject", "(Ljava/security/Key;Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.crypto.SealedObject._getAlgorithm28592 = @__env.GetMethodIDNoThrow(global::javax.crypto.SealedObject.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::javax.crypto.SealedObject._SealedObject28593 = @__env.GetMethodIDNoThrow(global::javax.crypto.SealedObject.staticClass, "<init>", "(Ljava/io/Serializable;Ljavax/crypto/Cipher;)V");
			global::javax.crypto.SealedObject._SealedObject28594 = @__env.GetMethodIDNoThrow(global::javax.crypto.SealedObject.staticClass, "<init>", "(Ljavax/crypto/SealedObject;)V");
		}
	}
}
