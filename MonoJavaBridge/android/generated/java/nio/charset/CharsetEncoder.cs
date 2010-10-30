namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.charset.CharsetEncoder_))]
	public abstract partial class CharsetEncoder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CharsetEncoder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.nio.charset.Charset charset()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "charset", "()Ljava/nio/charset/Charset;", ref global::java.nio.charset.CharsetEncoder._m0) as java.nio.charset.Charset;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.nio.charset.CoderResult encode(java.nio.CharBuffer arg0, java.nio.ByteBuffer arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "encode", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;Z)Ljava/nio/charset/CoderResult;", ref global::java.nio.charset.CharsetEncoder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.charset.CoderResult;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.nio.ByteBuffer encode(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;", ref global::java.nio.charset.CharsetEncoder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.nio.charset.CoderResult flush(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "flush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", ref global::java.nio.charset.CharsetEncoder._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.CoderResult;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.nio.charset.CharsetEncoder reset()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "reset", "()Ljava/nio/charset/CharsetEncoder;", ref global::java.nio.charset.CharsetEncoder._m4) as java.nio.charset.CharsetEncoder;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool canEncode(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "canEncode", "(C)Z", ref global::java.nio.charset.CharsetEncoder._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool canEncode(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "canEncode", "(Ljava/lang/CharSequence;)Z", ref global::java.nio.charset.CharsetEncoder._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool canEncode(string arg0)
		{
			return canEncode((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.nio.charset.CharsetEncoder onMalformedInput(java.nio.charset.CodingErrorAction arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;", ref global::java.nio.charset.CharsetEncoder._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.CharsetEncoder;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.nio.charset.CharsetEncoder onUnmappableCharacter(java.nio.charset.CodingErrorAction arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;", ref global::java.nio.charset.CharsetEncoder._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.CharsetEncoder;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual float maxBytesPerChar()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "maxBytesPerChar", "()F", ref global::java.nio.charset.CharsetEncoder._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isLegalReplacement(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "isLegalReplacement", "([B)Z", ref global::java.nio.charset.CharsetEncoder._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected abstract global::java.nio.charset.CoderResult encodeLoop(java.nio.CharBuffer arg0, java.nio.ByteBuffer arg1);
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual float averageBytesPerChar()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "averageBytesPerChar", "()F", ref global::java.nio.charset.CharsetEncoder._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual byte[] replacement()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.nio.charset.CharsetEncoder.staticClass, "replacement", "()[B", ref global::java.nio.charset.CharsetEncoder._m13) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.nio.charset.CodingErrorAction malformedInputAction()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;", ref global::java.nio.charset.CharsetEncoder._m14) as java.nio.charset.CodingErrorAction;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.nio.charset.CodingErrorAction unmappableCharacterAction()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;", ref global::java.nio.charset.CharsetEncoder._m15) as java.nio.charset.CodingErrorAction;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.nio.charset.CharsetEncoder replaceWith(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "replaceWith", "([B)Ljava/nio/charset/CharsetEncoder;", ref global::java.nio.charset.CharsetEncoder._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.CharsetEncoder;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected virtual void implReplaceWith(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "implReplaceWith", "([B)V", ref global::java.nio.charset.CharsetEncoder._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		protected virtual void implOnMalformedInput(java.nio.charset.CodingErrorAction arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V", ref global::java.nio.charset.CharsetEncoder._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected virtual void implOnUnmappableCharacter(java.nio.charset.CodingErrorAction arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V", ref global::java.nio.charset.CharsetEncoder._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		protected virtual global::java.nio.charset.CoderResult implFlush(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "implFlush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", ref global::java.nio.charset.CharsetEncoder._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.CoderResult;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		protected virtual void implReset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, "implReset", "()V", ref global::java.nio.charset.CharsetEncoder._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		protected CharsetEncoder(java.nio.charset.Charset arg0, float arg1, float arg2, byte[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CharsetEncoder._m22.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CharsetEncoder._m22 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF[B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		protected CharsetEncoder(java.nio.charset.Charset arg0, float arg1, float arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CharsetEncoder._m23.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CharsetEncoder._m23 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static CharsetEncoder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetEncoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetEncoder"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.charset.CharsetEncoder))]
	internal sealed partial class CharsetEncoder_ : java.nio.charset.CharsetEncoder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CharsetEncoder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::java.nio.charset.CoderResult encodeLoop(java.nio.CharBuffer arg0, java.nio.ByteBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetEncoder_.staticClass, "encodeLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;", ref global::java.nio.charset.CharsetEncoder_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.charset.CoderResult;
		}
		static CharsetEncoder_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetEncoder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetEncoder"));
		}
		internal static void InitJNI()
		{
		}
	}
}
