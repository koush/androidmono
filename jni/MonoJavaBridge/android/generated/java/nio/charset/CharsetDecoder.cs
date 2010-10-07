namespace java.nio.charset
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class CharsetDecoder : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static CharsetDecoder()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.charset.CharsetDecoder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected CharsetDecoder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _charset13087;
		public virtual global::java.nio.charset.Charset charset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder._charset13087));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._charset13087));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decode13088;
		public virtual global::java.nio.charset.CoderResult decode(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder._decode13088, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._decode13088, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decode13089;
		public virtual global::java.nio.CharBuffer decode(java.nio.ByteBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder._decode13089, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._decode13089, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flush13090;
		public virtual global::java.nio.charset.CoderResult flush(java.nio.CharBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder._flush13090, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._flush13090, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset13091;
		public virtual global::java.nio.charset.CharsetDecoder reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder._reset13091));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._reset13091));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMalformedInput13092;
		public virtual global::java.nio.charset.CharsetDecoder onMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder._onMalformedInput13092, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._onMalformedInput13092, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUnmappableCharacter13093;
		public virtual global::java.nio.charset.CharsetDecoder onUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder._onUnmappableCharacter13093, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._onUnmappableCharacter13093, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _replacement13094;
		public virtual global::java.lang.String replacement() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder._replacement13094));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._replacement13094));
		}
		internal static global::net.sf.jni4net.jni.MethodId _malformedInputAction13095;
		public virtual global::java.nio.charset.CodingErrorAction malformedInputAction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder._malformedInputAction13095));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._malformedInputAction13095));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unmappableCharacterAction13096;
		public virtual global::java.nio.charset.CodingErrorAction unmappableCharacterAction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder._unmappableCharacterAction13096));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._unmappableCharacterAction13096));
		}
		internal static global::net.sf.jni4net.jni.MethodId _replaceWith13097;
		public virtual global::java.nio.charset.CharsetDecoder replaceWith(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder._replaceWith13097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._replaceWith13097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implReplaceWith13098;
		protected virtual void implReplaceWith(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.charset.CharsetDecoder._implReplaceWith13098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implReplaceWith13098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implOnMalformedInput13099;
		protected virtual void implOnMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.charset.CharsetDecoder._implOnMalformedInput13099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implOnMalformedInput13099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implOnUnmappableCharacter13100;
		protected virtual void implOnUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.charset.CharsetDecoder._implOnUnmappableCharacter13100, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implOnUnmappableCharacter13100, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implFlush13101;
		protected virtual global::java.nio.charset.CoderResult implFlush(java.nio.CharBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder._implFlush13101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implFlush13101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implReset13102;
		protected virtual void implReset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.charset.CharsetDecoder._implReset13102);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._implReset13102);
		}
		internal static global::net.sf.jni4net.jni.MethodId _maxCharsPerByte13103;
		public virtual float maxCharsPerByte() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::java.nio.charset.CharsetDecoder._maxCharsPerByte13103);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._maxCharsPerByte13103);
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeLoop13104;
		protected abstract global::java.nio.charset.CoderResult decodeLoop(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1);
		internal static global::net.sf.jni4net.jni.MethodId _averageCharsPerByte13105;
		public virtual float averageCharsPerByte() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::java.nio.charset.CharsetDecoder._averageCharsPerByte13105);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._averageCharsPerByte13105);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAutoDetecting13106;
		public virtual bool isAutoDetecting() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.CharsetDecoder._isAutoDetecting13106);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._isAutoDetecting13106);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isCharsetDetected13107;
		public virtual bool isCharsetDetected() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.CharsetDecoder._isCharsetDetected13107);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._isCharsetDetected13107);
		}
		internal static global::net.sf.jni4net.jni.MethodId _detectedCharset13108;
		public virtual global::java.nio.charset.Charset detectedCharset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder._detectedCharset13108));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._detectedCharset13108));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CharsetDecoder13109;
		protected CharsetDecoder(java.nio.charset.Charset arg0, float arg1, float arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.charset.CharsetDecoder.staticClass, global::java.nio.charset.CharsetDecoder._CharsetDecoder13109, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.charset.CharsetDecoder.staticClass = @__class;
			global::java.nio.charset.CharsetDecoder._charset13087 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "charset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.CharsetDecoder._decode13088 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "decode", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;Z)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._decode13089 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;");
			global::java.nio.charset.CharsetDecoder._flush13090 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "flush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._reset13091 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "reset", "()Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._onMalformedInput13092 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._onUnmappableCharacter13093 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._replacement13094 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "replacement", "()Ljava/lang/String;");
			global::java.nio.charset.CharsetDecoder._malformedInputAction13095 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetDecoder._unmappableCharacterAction13096 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetDecoder._replaceWith13097 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "replaceWith", "(Ljava/lang/String;)Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.CharsetDecoder._implReplaceWith13098 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "implReplaceWith", "(Ljava/lang/String;)V");
			global::java.nio.charset.CharsetDecoder._implOnMalformedInput13099 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetDecoder._implOnUnmappableCharacter13100 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetDecoder._implFlush13101 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "implFlush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._implReset13102 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "implReset", "()V");
			global::java.nio.charset.CharsetDecoder._maxCharsPerByte13103 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "maxCharsPerByte", "()F");
			global::java.nio.charset.CharsetDecoder._decodeLoop13104 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "decodeLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetDecoder._averageCharsPerByte13105 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "averageCharsPerByte", "()F");
			global::java.nio.charset.CharsetDecoder._isAutoDetecting13106 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "isAutoDetecting", "()Z");
			global::java.nio.charset.CharsetDecoder._isCharsetDetected13107 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "isCharsetDetected", "()Z");
			global::java.nio.charset.CharsetDecoder._detectedCharset13108 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "detectedCharset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.CharsetDecoder._CharsetDecoder13109 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF)V");
		}
	}
}
