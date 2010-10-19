namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DigestInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DigestInputStream()
		{
			InitJNI();
		}
		protected DigestInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString17221;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.DigestInputStream._toString17221)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.DigestInputStream.staticClass, global::java.security.DigestInputStream._toString17221)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _read17222;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.DigestInputStream._read17222);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.DigestInputStream.staticClass, global::java.security.DigestInputStream._read17222);
		}
		internal static global::MonoJavaBridge.MethodId _read17223;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.DigestInputStream._read17223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.DigestInputStream.staticClass, global::java.security.DigestInputStream._read17223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _on17224;
		public virtual void on(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.DigestInputStream._on17224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.DigestInputStream.staticClass, global::java.security.DigestInputStream._on17224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.security.MessageDigest MessageDigest
		{
			get
			{
				return getMessageDigest();
			}
			set
			{
				setMessageDigest(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessageDigest17225;
		public virtual global::java.security.MessageDigest getMessageDigest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.DigestInputStream._getMessageDigest17225)) as java.security.MessageDigest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.DigestInputStream.staticClass, global::java.security.DigestInputStream._getMessageDigest17225)) as java.security.MessageDigest;
		}
		internal static global::MonoJavaBridge.MethodId _setMessageDigest17226;
		public virtual void setMessageDigest(java.security.MessageDigest arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.DigestInputStream._setMessageDigest17226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.DigestInputStream.staticClass, global::java.security.DigestInputStream._setMessageDigest17226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DigestInputStream17227;
		public DigestInputStream(java.io.InputStream arg0, java.security.MessageDigest arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.DigestInputStream.staticClass, global::java.security.DigestInputStream._DigestInputStream17227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.DigestInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/DigestInputStream"));
			global::java.security.DigestInputStream._toString17221 = @__env.GetMethodIDNoThrow(global::java.security.DigestInputStream.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.DigestInputStream._read17222 = @__env.GetMethodIDNoThrow(global::java.security.DigestInputStream.staticClass, "read", "()I");
			global::java.security.DigestInputStream._read17223 = @__env.GetMethodIDNoThrow(global::java.security.DigestInputStream.staticClass, "read", "([BII)I");
			global::java.security.DigestInputStream._on17224 = @__env.GetMethodIDNoThrow(global::java.security.DigestInputStream.staticClass, "on", "(Z)V");
			global::java.security.DigestInputStream._getMessageDigest17225 = @__env.GetMethodIDNoThrow(global::java.security.DigestInputStream.staticClass, "getMessageDigest", "()Ljava/security/MessageDigest;");
			global::java.security.DigestInputStream._setMessageDigest17226 = @__env.GetMethodIDNoThrow(global::java.security.DigestInputStream.staticClass, "setMessageDigest", "(Ljava/security/MessageDigest;)V");
			global::java.security.DigestInputStream._DigestInputStream17227 = @__env.GetMethodIDNoThrow(global::java.security.DigestInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/security/MessageDigest;)V");
		}
	}
}
