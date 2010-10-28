namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.MessageDigestSpi_))]
	public abstract partial class MessageDigestSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MessageDigestSpi()
		{
			InitJNI();
		}
		protected MessageDigestSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone23183;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigestSpi._clone23183)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._clone23183)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23184;
		protected abstract void engineUpdate(byte arg0);
		internal static global::MonoJavaBridge.MethodId _engineUpdate23185;
		protected abstract void engineUpdate(byte[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _engineUpdate23186;
		protected virtual void engineUpdate(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi._engineUpdate23186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._engineUpdate23186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineDigest23187;
		protected abstract byte[] engineDigest();
		internal static global::MonoJavaBridge.MethodId _engineDigest23188;
		protected virtual int engineDigest(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.MessageDigestSpi._engineDigest23188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._engineDigest23188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineReset23189;
		protected abstract void engineReset();
		internal static global::MonoJavaBridge.MethodId _engineGetDigestLength23190;
		protected virtual int engineGetDigestLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.MessageDigestSpi._engineGetDigestLength23190);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._engineGetDigestLength23190);
		}
		internal static global::MonoJavaBridge.MethodId _MessageDigestSpi23191;
		public MessageDigestSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._MessageDigestSpi23191);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigestSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigestSpi"));
			global::java.security.MessageDigestSpi._clone23183 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.MessageDigestSpi._engineUpdate23184 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineUpdate", "(B)V");
			global::java.security.MessageDigestSpi._engineUpdate23185 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineUpdate", "([BII)V");
			global::java.security.MessageDigestSpi._engineUpdate23186 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;)V");
			global::java.security.MessageDigestSpi._engineDigest23187 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineDigest", "()[B");
			global::java.security.MessageDigestSpi._engineDigest23188 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineDigest", "([BII)I");
			global::java.security.MessageDigestSpi._engineReset23189 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineReset", "()V");
			global::java.security.MessageDigestSpi._engineGetDigestLength23190 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineGetDigestLength", "()I");
			global::java.security.MessageDigestSpi._MessageDigestSpi23191 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.MessageDigestSpi))]
	internal sealed partial class MessageDigestSpi_ : java.security.MessageDigestSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MessageDigestSpi_()
		{
			InitJNI();
		}
		internal MessageDigestSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23192;
		protected override void engineUpdate(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi_._engineUpdate23192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi_.staticClass, global::java.security.MessageDigestSpi_._engineUpdate23192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23193;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi_._engineUpdate23193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi_.staticClass, global::java.security.MessageDigestSpi_._engineUpdate23193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineDigest23194;
		protected override byte[] engineDigest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigestSpi_._engineDigest23194)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigestSpi_.staticClass, global::java.security.MessageDigestSpi_._engineDigest23194)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineReset23195;
		protected override void engineReset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi_._engineReset23195);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi_.staticClass, global::java.security.MessageDigestSpi_._engineReset23195);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigestSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigestSpi"));
			global::java.security.MessageDigestSpi_._engineUpdate23192 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi_.staticClass, "engineUpdate", "(B)V");
			global::java.security.MessageDigestSpi_._engineUpdate23193 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi_.staticClass, "engineUpdate", "([BII)V");
			global::java.security.MessageDigestSpi_._engineDigest23194 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi_.staticClass, "engineDigest", "()[B");
			global::java.security.MessageDigestSpi_._engineReset23195 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi_.staticClass, "engineReset", "()V");
		}
	}
}
