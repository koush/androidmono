namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.MessageDigest_))]
	public abstract partial class MessageDigest : java.security.MessageDigestSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MessageDigest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.MessageDigest.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.MessageDigest._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.MessageDigest.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.security.MessageDigest._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.security.MessageDigest getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.MessageDigest._m2.native == global::System.IntPtr.Zero)
				global::java.security.MessageDigest._m2 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/MessageDigest;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.MessageDigest;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.security.MessageDigest getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.MessageDigest._m3.native == global::System.IntPtr.Zero)
				global::java.security.MessageDigest._m3 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/MessageDigest;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.MessageDigest;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.security.MessageDigest getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.MessageDigest._m4.native == global::System.IntPtr.Zero)
				global::java.security.MessageDigest._m4 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/MessageDigest;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.MessageDigest;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.MessageDigest.staticClass, "reset", "()V", ref global::java.security.MessageDigest._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int digest(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.MessageDigest.staticClass, "digest", "([BII)I", ref global::java.security.MessageDigest._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual byte[] digest(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.MessageDigest.staticClass, "digest", "([B)[B", ref global::java.security.MessageDigest._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual byte[] digest()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.MessageDigest.staticClass, "digest", "()[B", ref global::java.security.MessageDigest._m8) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void update(byte arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.MessageDigest.staticClass, "update", "(B)V", ref global::java.security.MessageDigest._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void update(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.MessageDigest.staticClass, "update", "([B)V", ref global::java.security.MessageDigest._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void update(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.MessageDigest.staticClass, "update", "([BII)V", ref global::java.security.MessageDigest._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void update(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.MessageDigest.staticClass, "update", "(Ljava/nio/ByteBuffer;)V", ref global::java.security.MessageDigest._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.MessageDigest.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.MessageDigest._m13) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static bool isEqual(byte[] arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.MessageDigest._m14.native == global::System.IntPtr.Zero)
				global::java.security.MessageDigest._m14 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "isEqual", "([B[B)Z");
			return @__env.CallStaticBooleanMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.MessageDigest.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::java.security.MessageDigest._m15) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int getDigestLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.MessageDigest.staticClass, "getDigestLength", "()I", ref global::java.security.MessageDigest._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected MessageDigest(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.MessageDigest._m17.native == global::System.IntPtr.Zero)
				global::java.security.MessageDigest._m17 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MessageDigest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigest.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigest"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.MessageDigest))]
	internal sealed partial class MessageDigest_ : java.security.MessageDigest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MessageDigest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void engineUpdate(byte arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.MessageDigest_.staticClass, "engineUpdate", "(B)V", ref global::java.security.MessageDigest_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.MessageDigest_.staticClass, "engineUpdate", "([BII)V", ref global::java.security.MessageDigest_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override byte[] engineDigest()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.MessageDigest_.staticClass, "engineDigest", "()[B", ref global::java.security.MessageDigest_._m2) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void engineReset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.MessageDigest_.staticClass, "engineReset", "()V", ref global::java.security.MessageDigest_._m3);
		}
		static MessageDigest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigest"));
		}
	}
}
