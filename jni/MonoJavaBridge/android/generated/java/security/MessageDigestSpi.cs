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
		internal static global::MonoJavaBridge.MethodId _clone17465;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigestSpi._clone17465)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._clone17465)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate17466;
		protected abstract void engineUpdate(byte arg0);
		internal static global::MonoJavaBridge.MethodId _engineUpdate17467;
		protected abstract void engineUpdate(byte[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _engineUpdate17468;
		protected virtual void engineUpdate(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi._engineUpdate17468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._engineUpdate17468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineDigest17469;
		protected abstract byte[] engineDigest();
		internal static global::MonoJavaBridge.MethodId _engineDigest17470;
		protected virtual int engineDigest(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.MessageDigestSpi._engineDigest17470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._engineDigest17470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineReset17471;
		protected abstract void engineReset();
		internal static global::MonoJavaBridge.MethodId _engineGetDigestLength17472;
		protected virtual int engineGetDigestLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.MessageDigestSpi._engineGetDigestLength17472);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._engineGetDigestLength17472);
		}
		internal static global::MonoJavaBridge.MethodId _MessageDigestSpi17473;
		public MessageDigestSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.MessageDigestSpi.staticClass, global::java.security.MessageDigestSpi._MessageDigestSpi17473);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigestSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigestSpi"));
			global::java.security.MessageDigestSpi._clone17465 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.MessageDigestSpi._engineUpdate17466 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineUpdate", "(B)V");
			global::java.security.MessageDigestSpi._engineUpdate17467 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineUpdate", "([BII)V");
			global::java.security.MessageDigestSpi._engineUpdate17468 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;)V");
			global::java.security.MessageDigestSpi._engineDigest17469 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineDigest", "()[B");
			global::java.security.MessageDigestSpi._engineDigest17470 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineDigest", "([BII)I");
			global::java.security.MessageDigestSpi._engineReset17471 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineReset", "()V");
			global::java.security.MessageDigestSpi._engineGetDigestLength17472 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "engineGetDigestLength", "()I");
			global::java.security.MessageDigestSpi._MessageDigestSpi17473 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.MessageDigestSpi))]
	public sealed partial class MessageDigestSpi_ : java.security.MessageDigestSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MessageDigestSpi_()
		{
			InitJNI();
		}
		internal MessageDigestSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate17474;
		protected override void engineUpdate(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi_._engineUpdate17474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi_.staticClass, global::java.security.MessageDigestSpi_._engineUpdate17474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate17475;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi_._engineUpdate17475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi_.staticClass, global::java.security.MessageDigestSpi_._engineUpdate17475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineDigest17476;
		protected override byte[] engineDigest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigestSpi_._engineDigest17476)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigestSpi_.staticClass, global::java.security.MessageDigestSpi_._engineDigest17476)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineReset17477;
		protected override void engineReset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi_._engineReset17477);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigestSpi_.staticClass, global::java.security.MessageDigestSpi_._engineReset17477);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigestSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigestSpi"));
			global::java.security.MessageDigestSpi_._engineUpdate17474 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi_.staticClass, "engineUpdate", "(B)V");
			global::java.security.MessageDigestSpi_._engineUpdate17475 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi_.staticClass, "engineUpdate", "([BII)V");
			global::java.security.MessageDigestSpi_._engineDigest17476 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi_.staticClass, "engineDigest", "()[B");
			global::java.security.MessageDigestSpi_._engineReset17477 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigestSpi_.staticClass, "engineReset", "()V");
		}
	}
}
