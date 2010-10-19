namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.MessageDigest_))]
	public abstract partial class MessageDigest : java.security.MessageDigestSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MessageDigest()
		{
			InitJNI();
		}
		protected MessageDigest(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString17443;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._toString17443)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._toString17443)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone17444;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._clone17444)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._clone17444)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17445;
		public static global::java.security.MessageDigest getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getInstance17445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.MessageDigest;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17446;
		public static global::java.security.MessageDigest getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getInstance17446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.MessageDigest;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance17447;
		public static global::java.security.MessageDigest getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getInstance17447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.MessageDigest;
		}
		internal static global::MonoJavaBridge.MethodId _reset17448;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest._reset17448);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._reset17448);
		}
		internal static global::MonoJavaBridge.MethodId _digest17449;
		public virtual int digest(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.MessageDigest._digest17449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._digest17449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _digest17450;
		public virtual byte[] digest(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._digest17450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._digest17450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _digest17451;
		public virtual byte[] digest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._digest17451)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._digest17451)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _update17452;
		public virtual void update(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest._update17452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._update17452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update17453;
		public virtual void update(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest._update17453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._update17453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update17454;
		public virtual void update(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest._update17454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._update17454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update17455;
		public virtual void update(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest._update17455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._update17455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm17456;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._getAlgorithm17456)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getAlgorithm17456)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqual17457;
		public static bool isEqual(byte[] arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._isEqual17457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProvider17458;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._getProvider17458)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getProvider17458)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getDigestLength17459;
		public virtual int getDigestLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.MessageDigest._getDigestLength17459);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getDigestLength17459);
		}
		internal static global::MonoJavaBridge.MethodId _MessageDigest17460;
		protected MessageDigest(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._MessageDigest17460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigest.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigest"));
			global::java.security.MessageDigest._toString17443 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.MessageDigest._clone17444 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.MessageDigest._getInstance17445 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/MessageDigest;");
			global::java.security.MessageDigest._getInstance17446 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/MessageDigest;");
			global::java.security.MessageDigest._getInstance17447 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/MessageDigest;");
			global::java.security.MessageDigest._reset17448 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "reset", "()V");
			global::java.security.MessageDigest._digest17449 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "digest", "([BII)I");
			global::java.security.MessageDigest._digest17450 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "digest", "([B)[B");
			global::java.security.MessageDigest._digest17451 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "digest", "()[B");
			global::java.security.MessageDigest._update17452 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "update", "(B)V");
			global::java.security.MessageDigest._update17453 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "update", "([B)V");
			global::java.security.MessageDigest._update17454 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "update", "([BII)V");
			global::java.security.MessageDigest._update17455 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "update", "(Ljava/nio/ByteBuffer;)V");
			global::java.security.MessageDigest._getAlgorithm17456 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.MessageDigest._isEqual17457 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "isEqual", "([B[B)Z");
			global::java.security.MessageDigest._getProvider17458 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.MessageDigest._getDigestLength17459 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getDigestLength", "()I");
			global::java.security.MessageDigest._MessageDigest17460 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.MessageDigest))]
	public sealed partial class MessageDigest_ : java.security.MessageDigest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MessageDigest_()
		{
			InitJNI();
		}
		internal MessageDigest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate17461;
		protected override void engineUpdate(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest_._engineUpdate17461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest_.staticClass, global::java.security.MessageDigest_._engineUpdate17461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate17462;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest_._engineUpdate17462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest_.staticClass, global::java.security.MessageDigest_._engineUpdate17462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineDigest17463;
		protected override byte[] engineDigest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest_._engineDigest17463)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest_.staticClass, global::java.security.MessageDigest_._engineDigest17463)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineReset17464;
		protected override void engineReset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest_._engineReset17464);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest_.staticClass, global::java.security.MessageDigest_._engineReset17464);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigest"));
			global::java.security.MessageDigest_._engineUpdate17461 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest_.staticClass, "engineUpdate", "(B)V");
			global::java.security.MessageDigest_._engineUpdate17462 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest_.staticClass, "engineUpdate", "([BII)V");
			global::java.security.MessageDigest_._engineDigest17463 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest_.staticClass, "engineDigest", "()[B");
			global::java.security.MessageDigest_._engineReset17464 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest_.staticClass, "engineReset", "()V");
		}
	}
}
