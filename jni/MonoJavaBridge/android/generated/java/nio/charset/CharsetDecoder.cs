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
		internal static global::MonoJavaBridge.MethodId _charset22746;
		public virtual global::java.nio.charset.Charset charset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._charset22746)) as java.nio.charset.Charset;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._charset22746)) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _decode22747;
		public virtual global::java.nio.charset.CoderResult decode(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._decode22747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._decode22747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _decode22748;
		public virtual global::java.nio.CharBuffer decode(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._decode22748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._decode22748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _flush22749;
		public virtual global::java.nio.charset.CoderResult flush(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._flush22749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._flush22749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _reset22750;
		public virtual global::java.nio.charset.CharsetDecoder reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._reset22750)) as java.nio.charset.CharsetDecoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._reset22750)) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _onMalformedInput22751;
		public virtual global::java.nio.charset.CharsetDecoder onMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._onMalformedInput22751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._onMalformedInput22751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _onUnmappableCharacter22752;
		public virtual global::java.nio.charset.CharsetDecoder onUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._onUnmappableCharacter22752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._onUnmappableCharacter22752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _replacement22753;
		public virtual global::java.lang.String replacement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._replacement22753)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._replacement22753)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _malformedInputAction22754;
		public virtual global::java.nio.charset.CodingErrorAction malformedInputAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._malformedInputAction22754)) as java.nio.charset.CodingErrorAction;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._malformedInputAction22754)) as java.nio.charset.CodingErrorAction;
		}
		internal static global::MonoJavaBridge.MethodId _unmappableCharacterAction22755;
		public virtual global::java.nio.charset.CodingErrorAction unmappableCharacterAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._unmappableCharacterAction22755)) as java.nio.charset.CodingErrorAction;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._unmappableCharacterAction22755)) as java.nio.charset.CodingErrorAction;
		}
		internal static global::MonoJavaBridge.MethodId _replaceWith22756;
		public virtual global::java.nio.charset.CharsetDecoder replaceWith(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._replaceWith22756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._replaceWith22756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _implReplaceWith22757;
		protected virtual void implReplaceWith(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._implReplaceWith22757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implReplaceWith22757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implOnMalformedInput22758;
		protected virtual void implOnMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._implOnMalformedInput22758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implOnMalformedInput22758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implOnUnmappableCharacter22759;
		protected virtual void implOnUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._implOnUnmappableCharacter22759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implOnUnmappableCharacter22759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implFlush22760;
		protected virtual global::java.nio.charset.CoderResult implFlush(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._implFlush22760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implFlush22760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _implReset22761;
		protected virtual void implReset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._implReset22761);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implReset22761);
		}
		internal static global::MonoJavaBridge.MethodId _maxCharsPerByte22762;
		public virtual float maxCharsPerByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._maxCharsPerByte22762);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._maxCharsPerByte22762);
		}
		internal static global::MonoJavaBridge.MethodId _decodeLoop22763;
		protected abstract global::java.nio.charset.CoderResult decodeLoop(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1);
		internal static global::MonoJavaBridge.MethodId _averageCharsPerByte22764;
		public virtual float averageCharsPerByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._averageCharsPerByte22764);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._averageCharsPerByte22764);
		}
		internal static global::MonoJavaBridge.MethodId _isAutoDetecting22765;
		public virtual bool isAutoDetecting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._isAutoDetecting22765);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._isAutoDetecting22765);
		}
		internal static global::MonoJavaBridge.MethodId _isCharsetDetected22766;
		public virtual bool isCharsetDetected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._isCharsetDetected22766);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._isCharsetDetected22766);
		}
		internal static global::MonoJavaBridge.MethodId _detectedCharset22767;
		public virtual global::java.nio.charset.Charset detectedCharset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder._detectedCharset22767)) as java.nio.charset.Charset;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._detectedCharset22767)) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _CharsetDecoder22768;
		protected CharsetDecoder(java.nio.charset.Charset arg0, float arg1, float arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._CharsetDecoder22768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetDecoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetDecoder"));
			global::java.nio.charset.CharsetDecoder._charset22746 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "charset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.CharsetDecoder._decode22747 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "decode", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;Z)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._decode22748 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;");
			global::java.nio.charset.CharsetDecoder._flush22749 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "flush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._reset22750 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "reset", "()Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._onMalformedInput22751 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._onUnmappableCharacter22752 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._replacement22753 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "replacement", "()Ljava/lang/String;");
			global::java.nio.charset.CharsetDecoder._malformedInputAction22754 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetDecoder._unmappableCharacterAction22755 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetDecoder._replaceWith22756 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "replaceWith", "(Ljava/lang/String;)Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._implReplaceWith22757 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "implReplaceWith", "(Ljava/lang/String;)V");
			global::java.nio.charset.CharsetDecoder._implOnMalformedInput22758 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetDecoder._implOnUnmappableCharacter22759 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetDecoder._implFlush22760 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "implFlush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._implReset22761 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "implReset", "()V");
			global::java.nio.charset.CharsetDecoder._maxCharsPerByte22762 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "maxCharsPerByte", "()F");
			global::java.nio.charset.CharsetDecoder._decodeLoop22763 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "decodeLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._averageCharsPerByte22764 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "averageCharsPerByte", "()F");
			global::java.nio.charset.CharsetDecoder._isAutoDetecting22765 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "isAutoDetecting", "()Z");
			global::java.nio.charset.CharsetDecoder._isCharsetDetected22766 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "isCharsetDetected", "()Z");
			global::java.nio.charset.CharsetDecoder._detectedCharset22767 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "detectedCharset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.CharsetDecoder._CharsetDecoder22768 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.charset.CharsetDecoder))]
	internal sealed partial class CharsetDecoder_ : java.nio.charset.CharsetDecoder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharsetDecoder_()
		{
			InitJNI();
		}
		internal CharsetDecoder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _decodeLoop22769;
		protected override global::java.nio.charset.CoderResult decodeLoop(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder_._decodeLoop22769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetDecoder_.staticClass, global::java.nio.charset.CharsetDecoder_._decodeLoop22769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.charset.CoderResult;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetDecoder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetDecoder"));
			global::java.nio.charset.CharsetDecoder_._decodeLoop22769 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetDecoder_.staticClass, "decodeLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;");
		}
	}
}
