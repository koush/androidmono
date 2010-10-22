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
		internal static global::MonoJavaBridge.MethodId _toString23042;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._toString23042)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._toString23042)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23043;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._clone23043)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._clone23043)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23044;
		public static global::java.security.MessageDigest getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getInstance23044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.MessageDigest;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23045;
		public static global::java.security.MessageDigest getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getInstance23045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.MessageDigest;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23046;
		public static global::java.security.MessageDigest getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getInstance23046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.MessageDigest;
		}
		internal static global::MonoJavaBridge.MethodId _reset23047;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest._reset23047);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._reset23047);
		}
		internal static global::MonoJavaBridge.MethodId _digest23048;
		public virtual int digest(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.MessageDigest._digest23048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._digest23048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _digest23049;
		public virtual byte[] digest(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._digest23049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._digest23049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _digest23050;
		public virtual byte[] digest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._digest23050)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._digest23050)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _update23051;
		public virtual void update(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest._update23051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._update23051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update23052;
		public virtual void update(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest._update23052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._update23052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update23053;
		public virtual void update(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest._update23053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._update23053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update23054;
		public virtual void update(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest._update23054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._update23054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23055;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._getAlgorithm23055)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getAlgorithm23055)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqual23056;
		public static bool isEqual(byte[] arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._isEqual23056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23057;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._getProvider23057)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getProvider23057)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getDigestLength23058;
		public virtual int getDigestLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.MessageDigest._getDigestLength23058);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getDigestLength23058);
		}
		internal static global::MonoJavaBridge.MethodId _MessageDigest23059;
		protected MessageDigest(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._MessageDigest23059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigest.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigest"));
			global::java.security.MessageDigest._toString23042 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.MessageDigest._clone23043 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.MessageDigest._getInstance23044 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/MessageDigest;");
			global::java.security.MessageDigest._getInstance23045 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/MessageDigest;");
			global::java.security.MessageDigest._getInstance23046 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/MessageDigest;");
			global::java.security.MessageDigest._reset23047 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "reset", "()V");
			global::java.security.MessageDigest._digest23048 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "digest", "([BII)I");
			global::java.security.MessageDigest._digest23049 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "digest", "([B)[B");
			global::java.security.MessageDigest._digest23050 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "digest", "()[B");
			global::java.security.MessageDigest._update23051 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "update", "(B)V");
			global::java.security.MessageDigest._update23052 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "update", "([B)V");
			global::java.security.MessageDigest._update23053 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "update", "([BII)V");
			global::java.security.MessageDigest._update23054 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "update", "(Ljava/nio/ByteBuffer;)V");
			global::java.security.MessageDigest._getAlgorithm23055 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.MessageDigest._isEqual23056 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "isEqual", "([B[B)Z");
			global::java.security.MessageDigest._getProvider23057 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.MessageDigest._getDigestLength23058 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getDigestLength", "()I");
			global::java.security.MessageDigest._MessageDigest23059 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "<init>", "(Ljava/lang/String;)V");
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
		internal static global::MonoJavaBridge.MethodId _engineUpdate23060;
		protected override void engineUpdate(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest_._engineUpdate23060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest_.staticClass, global::java.security.MessageDigest_._engineUpdate23060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23061;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest_._engineUpdate23061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest_.staticClass, global::java.security.MessageDigest_._engineUpdate23061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineDigest23062;
		protected override byte[] engineDigest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest_._engineDigest23062)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest_.staticClass, global::java.security.MessageDigest_._engineDigest23062)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineReset23063;
		protected override void engineReset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest_._engineReset23063);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest_.staticClass, global::java.security.MessageDigest_._engineReset23063);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigest"));
			global::java.security.MessageDigest_._engineUpdate23060 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest_.staticClass, "engineUpdate", "(B)V");
			global::java.security.MessageDigest_._engineUpdate23061 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest_.staticClass, "engineUpdate", "([BII)V");
			global::java.security.MessageDigest_._engineDigest23062 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest_.staticClass, "engineDigest", "()[B");
			global::java.security.MessageDigest_._engineReset23063 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest_.staticClass, "engineReset", "()V");
		}
	}
}
