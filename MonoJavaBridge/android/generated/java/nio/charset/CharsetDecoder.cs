namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.charset.CharsetDecoder_))]
	public abstract partial class CharsetDecoder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CharsetDecoder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _charset22747;
		public virtual global::java.nio.charset.Charset charset()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "charset", "()Ljava/nio/charset/Charset;", ref global::java.nio.charset.CharsetDecoder._charset22747) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _decode22748;
		public virtual global::java.nio.charset.CoderResult decode(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "decode", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;Z)Ljava/nio/charset/CoderResult;", ref global::java.nio.charset.CharsetDecoder._decode22748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _decode22749;
		public virtual global::java.nio.CharBuffer decode(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;", ref global::java.nio.charset.CharsetDecoder._decode22749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _flush22750;
		public virtual global::java.nio.charset.CoderResult flush(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "flush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", ref global::java.nio.charset.CharsetDecoder._flush22750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _reset22751;
		public virtual global::java.nio.charset.CharsetDecoder reset()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "reset", "()Ljava/nio/charset/CharsetDecoder;", ref global::java.nio.charset.CharsetDecoder._reset22751) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _onMalformedInput22752;
		public virtual global::java.nio.charset.CharsetDecoder onMalformedInput(java.nio.charset.CodingErrorAction arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;", ref global::java.nio.charset.CharsetDecoder._onMalformedInput22752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _onUnmappableCharacter22753;
		public virtual global::java.nio.charset.CharsetDecoder onUnmappableCharacter(java.nio.charset.CodingErrorAction arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;", ref global::java.nio.charset.CharsetDecoder._onUnmappableCharacter22753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _replacement22754;
		public virtual global::java.lang.String replacement()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.CharsetDecoder.staticClass, "replacement", "()Ljava/lang/String;", ref global::java.nio.charset.CharsetDecoder._replacement22754) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _malformedInputAction22755;
		public virtual global::java.nio.charset.CodingErrorAction malformedInputAction()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;", ref global::java.nio.charset.CharsetDecoder._malformedInputAction22755) as java.nio.charset.CodingErrorAction;
		}
		internal static global::MonoJavaBridge.MethodId _unmappableCharacterAction22756;
		public virtual global::java.nio.charset.CodingErrorAction unmappableCharacterAction()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;", ref global::java.nio.charset.CharsetDecoder._unmappableCharacterAction22756) as java.nio.charset.CodingErrorAction;
		}
		internal static global::MonoJavaBridge.MethodId _replaceWith22757;
		public virtual global::java.nio.charset.CharsetDecoder replaceWith(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "replaceWith", "(Ljava/lang/String;)Ljava/nio/charset/CharsetDecoder;", ref global::java.nio.charset.CharsetDecoder._replaceWith22757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _implReplaceWith22758;
		protected virtual void implReplaceWith(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "implReplaceWith", "(Ljava/lang/String;)V", ref global::java.nio.charset.CharsetDecoder._implReplaceWith22758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implOnMalformedInput22759;
		protected virtual void implOnMalformedInput(java.nio.charset.CodingErrorAction arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V", ref global::java.nio.charset.CharsetDecoder._implOnMalformedInput22759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implOnUnmappableCharacter22760;
		protected virtual void implOnUnmappableCharacter(java.nio.charset.CodingErrorAction arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V", ref global::java.nio.charset.CharsetDecoder._implOnUnmappableCharacter22760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implFlush22761;
		protected virtual global::java.nio.charset.CoderResult implFlush(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "implFlush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", ref global::java.nio.charset.CharsetDecoder._implFlush22761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _implReset22762;
		protected virtual void implReset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "implReset", "()V", ref global::java.nio.charset.CharsetDecoder._implReset22762);
		}
		internal static global::MonoJavaBridge.MethodId _maxCharsPerByte22763;
		public virtual float maxCharsPerByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "maxCharsPerByte", "()F", ref global::java.nio.charset.CharsetDecoder._maxCharsPerByte22763);
		}
		internal static global::MonoJavaBridge.MethodId _decodeLoop22764;
		protected abstract global::java.nio.charset.CoderResult decodeLoop(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1);
		internal static global::MonoJavaBridge.MethodId _averageCharsPerByte22765;
		public virtual float averageCharsPerByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "averageCharsPerByte", "()F", ref global::java.nio.charset.CharsetDecoder._averageCharsPerByte22765);
		}
		internal static global::MonoJavaBridge.MethodId _isAutoDetecting22766;
		public virtual bool isAutoDetecting()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "isAutoDetecting", "()Z", ref global::java.nio.charset.CharsetDecoder._isAutoDetecting22766);
		}
		internal static global::MonoJavaBridge.MethodId _isCharsetDetected22767;
		public virtual bool isCharsetDetected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "isCharsetDetected", "()Z", ref global::java.nio.charset.CharsetDecoder._isCharsetDetected22767);
		}
		internal static global::MonoJavaBridge.MethodId _detectedCharset22768;
		public virtual global::java.nio.charset.Charset detectedCharset()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, "detectedCharset", "()Ljava/nio/charset/Charset;", ref global::java.nio.charset.CharsetDecoder._detectedCharset22768) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _CharsetDecoder22769;
		protected CharsetDecoder(java.nio.charset.Charset arg0, float arg1, float arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CharsetDecoder._CharsetDecoder22769.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CharsetDecoder._CharsetDecoder22769 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._CharsetDecoder22769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static CharsetDecoder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetDecoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetDecoder"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.charset.CharsetDecoder))]
	internal sealed partial class CharsetDecoder_ : java.nio.charset.CharsetDecoder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CharsetDecoder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _decodeLoop22770;
		protected override global::java.nio.charset.CoderResult decodeLoop(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.CharsetDecoder_.staticClass, "decodeLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;", ref global::java.nio.charset.CharsetDecoder_._decodeLoop22770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.nio.charset.CoderResult;
		}
		static CharsetDecoder_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetDecoder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetDecoder"));
		}
		internal static void InitJNI()
		{
		}
	}
}
