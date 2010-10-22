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
		internal static global::MonoJavaBridge.MethodId _charset22628;
		public virtual global::java.nio.charset.Charset charset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._charset22628)) as java.nio.charset.Charset;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._charset22628)) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _decode22629;
		public virtual global::java.nio.charset.CoderResult decode(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._decode22629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._decode22629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _decode22630;
		public virtual global::java.nio.CharBuffer decode(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._decode22630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._decode22630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _flush22631;
		public virtual global::java.nio.charset.CoderResult flush(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._flush22631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._flush22631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _reset22632;
		public virtual global::java.nio.charset.CharsetDecoder reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._reset22632)) as java.nio.charset.CharsetDecoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._reset22632)) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _onMalformedInput22633;
		public virtual global::java.nio.charset.CharsetDecoder onMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._onMalformedInput22633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._onMalformedInput22633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _onUnmappableCharacter22634;
		public virtual global::java.nio.charset.CharsetDecoder onUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._onUnmappableCharacter22634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._onUnmappableCharacter22634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _replacement22635;
		public virtual global::java.lang.String replacement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._replacement22635)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._replacement22635)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _malformedInputAction22636;
		public virtual global::java.nio.charset.CodingErrorAction malformedInputAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._malformedInputAction22636)) as java.nio.charset.CodingErrorAction;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._malformedInputAction22636)) as java.nio.charset.CodingErrorAction;
		}
		internal static global::MonoJavaBridge.MethodId _unmappableCharacterAction22637;
		public virtual global::java.nio.charset.CodingErrorAction unmappableCharacterAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._unmappableCharacterAction22637)) as java.nio.charset.CodingErrorAction;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._unmappableCharacterAction22637)) as java.nio.charset.CodingErrorAction;
		}
		internal static global::MonoJavaBridge.MethodId _replaceWith22638;
		public virtual global::java.nio.charset.CharsetDecoder replaceWith(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._replaceWith22638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._replaceWith22638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _implReplaceWith22639;
		protected virtual void implReplaceWith(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._implReplaceWith22639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implReplaceWith22639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implOnMalformedInput22640;
		protected virtual void implOnMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._implOnMalformedInput22640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implOnMalformedInput22640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implOnUnmappableCharacter22641;
		protected virtual void implOnUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._implOnUnmappableCharacter22641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implOnUnmappableCharacter22641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implFlush22642;
		protected virtual global::java.nio.charset.CoderResult implFlush(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._implFlush22642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implFlush22642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _implReset22643;
		protected virtual void implReset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._implReset22643);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implReset22643);
		}
		internal static global::MonoJavaBridge.MethodId _maxCharsPerByte22644;
		public virtual float maxCharsPerByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._maxCharsPerByte22644);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._maxCharsPerByte22644);
		}
		internal static global::MonoJavaBridge.MethodId _decodeLoop22645;
		protected abstract global::java.nio.charset.CoderResult decodeLoop(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1);
		internal static global::MonoJavaBridge.MethodId _averageCharsPerByte22646;
		public virtual float averageCharsPerByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._averageCharsPerByte22646);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._averageCharsPerByte22646);
		}
		internal static global::MonoJavaBridge.MethodId _isAutoDetecting22647;
		public virtual bool isAutoDetecting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._isAutoDetecting22647);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._isAutoDetecting22647);
		}
		internal static global::MonoJavaBridge.MethodId _isCharsetDetected22648;
		public virtual bool isCharsetDetected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._isCharsetDetected22648);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._isCharsetDetected22648);
		}
		internal static global::MonoJavaBridge.MethodId _detectedCharset22649;
		public virtual global::java.nio.charset.Charset detectedCharset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._detectedCharset22649)) as java.nio.charset.Charset;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._detectedCharset22649)) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _CharsetDecoder22650;
		protected CharsetDecoder(java.nio.charset.Charset arg0, float arg1, float arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._CharsetDecoder22650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetDecoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetDecoder"));
			global::java.nio.charset.CharsetDecoder._charset22628 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "charset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.CharsetDecoder._decode22629 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "decode", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;Z)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._decode22630 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;");
			global::java.nio.charset.CharsetDecoder._flush22631 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "flush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._reset22632 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "reset", "()Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._onMalformedInput22633 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._onUnmappableCharacter22634 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._replacement22635 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "replacement", "()Ljava/lang/String;");
			global::java.nio.charset.CharsetDecoder._malformedInputAction22636 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetDecoder._unmappableCharacterAction22637 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetDecoder._replaceWith22638 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "replaceWith", "(Ljava/lang/String;)Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._implReplaceWith22639 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "implReplaceWith", "(Ljava/lang/String;)V");
			global::java.nio.charset.CharsetDecoder._implOnMalformedInput22640 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetDecoder._implOnUnmappableCharacter22641 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetDecoder._implFlush22642 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "implFlush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._implReset22643 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "implReset", "()V");
			global::java.nio.charset.CharsetDecoder._maxCharsPerByte22644 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "maxCharsPerByte", "()F");
			global::java.nio.charset.CharsetDecoder._decodeLoop22645 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "decodeLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._averageCharsPerByte22646 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "averageCharsPerByte", "()F");
			global::java.nio.charset.CharsetDecoder._isAutoDetecting22647 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "isAutoDetecting", "()Z");
			global::java.nio.charset.CharsetDecoder._isCharsetDetected22648 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "isCharsetDetected", "()Z");
			global::java.nio.charset.CharsetDecoder._detectedCharset22649 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "detectedCharset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.CharsetDecoder._CharsetDecoder22650 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF)V");
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
		internal static global::MonoJavaBridge.MethodId _decodeLoop22651;
		protected override global::java.nio.charset.CoderResult decodeLoop(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder_._decodeLoop22651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder_.staticClass, global::java.nio.charset.CharsetDecoder_._decodeLoop22651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.charset.CoderResult;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetDecoder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetDecoder"));
			global::java.nio.charset.CharsetDecoder_._decodeLoop22651 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder_.staticClass, "decodeLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;");
		}
	}
}
