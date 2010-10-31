namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.charset.CharsetDecoder_))]
	public abstract partial class CharsetDecoder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CharsetDecoder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.nio.charset.Charset charset()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "charset", "()Ljava/nio/charset/Charset;", ref global::java.nio.charset.CharsetDecoder._m0) as java.nio.charset.Charset;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.nio.charset.CoderResult decode(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "decode", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;Z)Ljava/nio/charset/CoderResult;", ref global::java.nio.charset.CharsetDecoder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.charset.CoderResult;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.nio.CharBuffer decode(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;", ref global::java.nio.charset.CharsetDecoder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.nio.charset.CoderResult flush(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "flush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", ref global::java.nio.charset.CharsetDecoder._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.CoderResult;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.nio.charset.CharsetDecoder reset()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "reset", "()Ljava/nio/charset/CharsetDecoder;", ref global::java.nio.charset.CharsetDecoder._m4) as java.nio.charset.CharsetDecoder;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.nio.charset.CharsetDecoder onMalformedInput(java.nio.charset.CodingErrorAction arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;", ref global::java.nio.charset.CharsetDecoder._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.CharsetDecoder;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.nio.charset.CharsetDecoder onUnmappableCharacter(java.nio.charset.CodingErrorAction arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;", ref global::java.nio.charset.CharsetDecoder._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.CharsetDecoder;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String replacement()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.CharsetDecoder.staticClass, "replacement", "()Ljava/lang/String;", ref global::java.nio.charset.CharsetDecoder._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.nio.charset.CodingErrorAction malformedInputAction()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;", ref global::java.nio.charset.CharsetDecoder._m8) as java.nio.charset.CodingErrorAction;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.nio.charset.CodingErrorAction unmappableCharacterAction()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;", ref global::java.nio.charset.CharsetDecoder._m9) as java.nio.charset.CodingErrorAction;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.nio.charset.CharsetDecoder replaceWith(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "replaceWith", "(Ljava/lang/String;)Ljava/nio/charset/CharsetDecoder;", ref global::java.nio.charset.CharsetDecoder._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.CharsetDecoder;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected virtual void implReplaceWith(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "implReplaceWith", "(Ljava/lang/String;)V", ref global::java.nio.charset.CharsetDecoder._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected virtual void implOnMalformedInput(java.nio.charset.CodingErrorAction arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V", ref global::java.nio.charset.CharsetDecoder._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected virtual void implOnUnmappableCharacter(java.nio.charset.CodingErrorAction arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V", ref global::java.nio.charset.CharsetDecoder._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected virtual global::java.nio.charset.CoderResult implFlush(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "implFlush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", ref global::java.nio.charset.CharsetDecoder._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.CoderResult;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected virtual void implReset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "implReset", "()V", ref global::java.nio.charset.CharsetDecoder._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual float maxCharsPerByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "maxCharsPerByte", "()F", ref global::java.nio.charset.CharsetDecoder._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected abstract global::java.nio.charset.CoderResult decodeLoop(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1);
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual float averageCharsPerByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "averageCharsPerByte", "()F", ref global::java.nio.charset.CharsetDecoder._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool isAutoDetecting()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "isAutoDetecting", "()Z", ref global::java.nio.charset.CharsetDecoder._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool isCharsetDetected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "isCharsetDetected", "()Z", ref global::java.nio.charset.CharsetDecoder._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::java.nio.charset.Charset detectedCharset()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "detectedCharset", "()Ljava/nio/charset/Charset;", ref global::java.nio.charset.CharsetDecoder._m21) as java.nio.charset.Charset;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		protected CharsetDecoder(java.nio.charset.Charset arg0, float arg1, float arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CharsetDecoder._m22.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CharsetDecoder._m22 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static CharsetDecoder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetDecoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetDecoder"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.charset.CharsetDecoder))]
	internal sealed partial class CharsetDecoder_ : java.nio.charset.CharsetDecoder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CharsetDecoder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::java.nio.charset.CoderResult decodeLoop(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder_.staticClass, "decodeLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", ref global::java.nio.charset.CharsetDecoder_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.charset.CoderResult;
		}
		static CharsetDecoder_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetDecoder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetDecoder"));
		}
	}
}
