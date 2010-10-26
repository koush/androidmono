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
		internal static global::MonoJavaBridge.MethodId _toString23160;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._toString23160)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._toString23160)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone23161;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._clone23161)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._clone23161)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23162;
		public static global::java.security.MessageDigest getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getInstance23162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.MessageDigest;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23163;
		public static global::java.security.MessageDigest getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getInstance23163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.MessageDigest;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23164;
		public static global::java.security.MessageDigest getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getInstance23164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.MessageDigest;
		}
		internal static global::MonoJavaBridge.MethodId _reset23165;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest._reset23165);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._reset23165);
		}
		internal static global::MonoJavaBridge.MethodId _digest23166;
		public virtual int digest(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.MessageDigest._digest23166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._digest23166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _digest23167;
		public virtual byte[] digest(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._digest23167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._digest23167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _digest23168;
		public virtual byte[] digest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._digest23168)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._digest23168)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _update23169;
		public virtual void update(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest._update23169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._update23169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update23170;
		public virtual void update(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest._update23170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._update23170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update23171;
		public virtual void update(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest._update23171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._update23171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update23172;
		public virtual void update(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest._update23172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._update23172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23173;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._getAlgorithm23173)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getAlgorithm23173)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEqual23174;
		public static bool isEqual(byte[] arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._isEqual23174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23175;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest._getProvider23175)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getProvider23175)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _getDigestLength23176;
		public virtual int getDigestLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.MessageDigest._getDigestLength23176);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.MessageDigest.staticClass, global::java.security.MessageDigest._getDigestLength23176);
		}
		internal static global::MonoJavaBridge.MethodId _MessageDigest23177;
		protected MessageDigest(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.MessageDigest.staticClass, global::java.security.MessageDigest._MessageDigest23177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigest.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigest"));
			global::java.security.MessageDigest._toString23160 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.MessageDigest._clone23161 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.MessageDigest._getInstance23162 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/MessageDigest;");
			global::java.security.MessageDigest._getInstance23163 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/MessageDigest;");
			global::java.security.MessageDigest._getInstance23164 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/MessageDigest;");
			global::java.security.MessageDigest._reset23165 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "reset", "()V");
			global::java.security.MessageDigest._digest23166 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "digest", "([BII)I");
			global::java.security.MessageDigest._digest23167 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "digest", "([B)[B");
			global::java.security.MessageDigest._digest23168 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "digest", "()[B");
			global::java.security.MessageDigest._update23169 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "update", "(B)V");
			global::java.security.MessageDigest._update23170 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "update", "([B)V");
			global::java.security.MessageDigest._update23171 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "update", "([BII)V");
			global::java.security.MessageDigest._update23172 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "update", "(Ljava/nio/ByteBuffer;)V");
			global::java.security.MessageDigest._getAlgorithm23173 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.MessageDigest._isEqual23174 = @__env.GetStaticMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "isEqual", "([B[B)Z");
			global::java.security.MessageDigest._getProvider23175 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.MessageDigest._getDigestLength23176 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "getDigestLength", "()I");
			global::java.security.MessageDigest._MessageDigest23177 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.MessageDigest))]
	internal sealed partial class MessageDigest_ : java.security.MessageDigest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MessageDigest_()
		{
			InitJNI();
		}
		internal MessageDigest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23178;
		protected override void engineUpdate(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest_._engineUpdate23178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest_.staticClass, global::java.security.MessageDigest_._engineUpdate23178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23179;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest_._engineUpdate23179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest_.staticClass, global::java.security.MessageDigest_._engineUpdate23179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineDigest23180;
		protected override byte[] engineDigest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.MessageDigest_._engineDigest23180)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.MessageDigest_.staticClass, global::java.security.MessageDigest_._engineDigest23180)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineReset23181;
		protected override void engineReset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.MessageDigest_._engineReset23181);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.MessageDigest_.staticClass, global::java.security.MessageDigest_._engineReset23181);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.MessageDigest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/MessageDigest"));
			global::java.security.MessageDigest_._engineUpdate23178 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest_.staticClass, "engineUpdate", "(B)V");
			global::java.security.MessageDigest_._engineUpdate23179 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest_.staticClass, "engineUpdate", "([BII)V");
			global::java.security.MessageDigest_._engineDigest23180 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest_.staticClass, "engineDigest", "()[B");
			global::java.security.MessageDigest_._engineReset23181 = @__env.GetMethodIDNoThrow(global::java.security.MessageDigest_.staticClass, "engineReset", "()V");
		}
	}
}
