namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.charset.CharsetDecoder_))]
	public abstract partial class CharsetDecoder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharsetDecoder()
		{
			InitJNI();
		}
		protected CharsetDecoder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _charset17030;
		public virtual global::java.nio.charset.Charset charset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._charset17030)) as java.nio.charset.Charset;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._charset17030)) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _decode17031;
		public virtual global::java.nio.charset.CoderResult decode(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._decode17031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._decode17031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _decode17032;
		public virtual global::java.nio.CharBuffer decode(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._decode17032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._decode17032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _flush17033;
		public virtual global::java.nio.charset.CoderResult flush(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._flush17033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._flush17033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _reset17034;
		public virtual global::java.nio.charset.CharsetDecoder reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._reset17034)) as java.nio.charset.CharsetDecoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._reset17034)) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _onMalformedInput17035;
		public virtual global::java.nio.charset.CharsetDecoder onMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._onMalformedInput17035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._onMalformedInput17035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _onUnmappableCharacter17036;
		public virtual global::java.nio.charset.CharsetDecoder onUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._onUnmappableCharacter17036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._onUnmappableCharacter17036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _replacement17037;
		public virtual global::java.lang.String replacement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._replacement17037)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._replacement17037)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _malformedInputAction17038;
		public virtual global::java.nio.charset.CodingErrorAction malformedInputAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._malformedInputAction17038)) as java.nio.charset.CodingErrorAction;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._malformedInputAction17038)) as java.nio.charset.CodingErrorAction;
		}
		internal static global::MonoJavaBridge.MethodId _unmappableCharacterAction17039;
		public virtual global::java.nio.charset.CodingErrorAction unmappableCharacterAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._unmappableCharacterAction17039)) as java.nio.charset.CodingErrorAction;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._unmappableCharacterAction17039)) as java.nio.charset.CodingErrorAction;
		}
		internal static global::MonoJavaBridge.MethodId _replaceWith17040;
		public virtual global::java.nio.charset.CharsetDecoder replaceWith(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._replaceWith17040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._replaceWith17040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _implReplaceWith17041;
		protected virtual void implReplaceWith(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._implReplaceWith17041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implReplaceWith17041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implOnMalformedInput17042;
		protected virtual void implOnMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._implOnMalformedInput17042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implOnMalformedInput17042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implOnUnmappableCharacter17043;
		protected virtual void implOnUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._implOnUnmappableCharacter17043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implOnUnmappableCharacter17043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implFlush17044;
		protected virtual global::java.nio.charset.CoderResult implFlush(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._implFlush17044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implFlush17044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _implReset17045;
		protected virtual void implReset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._implReset17045);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implReset17045);
		}
		internal static global::MonoJavaBridge.MethodId _maxCharsPerByte17046;
		public virtual float maxCharsPerByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._maxCharsPerByte17046);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._maxCharsPerByte17046);
		}
		internal static global::MonoJavaBridge.MethodId _decodeLoop17047;
		protected abstract global::java.nio.charset.CoderResult decodeLoop(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1);
		internal static global::MonoJavaBridge.MethodId _averageCharsPerByte17048;
		public virtual float averageCharsPerByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._averageCharsPerByte17048);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._averageCharsPerByte17048);
		}
		internal static global::MonoJavaBridge.MethodId _isAutoDetecting17049;
		public virtual bool isAutoDetecting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._isAutoDetecting17049);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._isAutoDetecting17049);
		}
		internal static global::MonoJavaBridge.MethodId _isCharsetDetected17050;
		public virtual bool isCharsetDetected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._isCharsetDetected17050);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._isCharsetDetected17050);
		}
		internal static global::MonoJavaBridge.MethodId _detectedCharset17051;
		public virtual global::java.nio.charset.Charset detectedCharset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._detectedCharset17051)) as java.nio.charset.Charset;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._detectedCharset17051)) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _CharsetDecoder17052;
		protected CharsetDecoder(java.nio.charset.Charset arg0, float arg1, float arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._CharsetDecoder17052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetDecoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetDecoder"));
			global::java.nio.charset.CharsetDecoder._charset17030 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "charset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.CharsetDecoder._decode17031 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "decode", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;Z)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._decode17032 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;");
			global::java.nio.charset.CharsetDecoder._flush17033 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "flush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._reset17034 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "reset", "()Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._onMalformedInput17035 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._onUnmappableCharacter17036 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._replacement17037 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "replacement", "()Ljava/lang/String;");
			global::java.nio.charset.CharsetDecoder._malformedInputAction17038 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetDecoder._unmappableCharacterAction17039 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetDecoder._replaceWith17040 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "replaceWith", "(Ljava/lang/String;)Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._implReplaceWith17041 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "implReplaceWith", "(Ljava/lang/String;)V");
			global::java.nio.charset.CharsetDecoder._implOnMalformedInput17042 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetDecoder._implOnUnmappableCharacter17043 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetDecoder._implFlush17044 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "implFlush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._implReset17045 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "implReset", "()V");
			global::java.nio.charset.CharsetDecoder._maxCharsPerByte17046 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "maxCharsPerByte", "()F");
			global::java.nio.charset.CharsetDecoder._decodeLoop17047 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "decodeLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._averageCharsPerByte17048 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "averageCharsPerByte", "()F");
			global::java.nio.charset.CharsetDecoder._isAutoDetecting17049 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "isAutoDetecting", "()Z");
			global::java.nio.charset.CharsetDecoder._isCharsetDetected17050 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "isCharsetDetected", "()Z");
			global::java.nio.charset.CharsetDecoder._detectedCharset17051 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "detectedCharset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.CharsetDecoder._CharsetDecoder17052 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.charset.CharsetDecoder))]
	public sealed partial class CharsetDecoder_ : java.nio.charset.CharsetDecoder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharsetDecoder_()
		{
			InitJNI();
		}
		internal CharsetDecoder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _decodeLoop17053;
		protected override global::java.nio.charset.CoderResult decodeLoop(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder_._decodeLoop17053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder_.staticClass, global::java.nio.charset.CharsetDecoder_._decodeLoop17053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.charset.CoderResult;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetDecoder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetDecoder"));
			global::java.nio.charset.CharsetDecoder_._decodeLoop17053 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder_.staticClass, "decodeLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;");
		}
	}
}
