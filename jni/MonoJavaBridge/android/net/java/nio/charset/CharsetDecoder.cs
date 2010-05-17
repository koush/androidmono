namespace java.nio.charset 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class CharsetDecoder : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static CharsetDecoder() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.charset.CharsetDecoder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected CharsetDecoder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _charset11494; 
		public virtual java.nio.charset.Charset charset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallObjectMethodPtr(this, _charset11494)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetDecoder.staticClass, _charset11494)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decode11495; 
		public virtual java.nio.charset.CoderResult decode(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallObjectMethodPtr(this, _decode11495, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetDecoder.staticClass, _decode11495, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decode11496; 
		public virtual java.nio.CharBuffer decode(java.nio.ByteBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallObjectMethodPtr(this, _decode11496, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.CharBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetDecoder.staticClass, _decode11496, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flush11497; 
		public virtual java.nio.charset.CoderResult flush(java.nio.CharBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallObjectMethodPtr(this, _flush11497, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetDecoder.staticClass, _flush11497, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset11498; 
		public virtual java.nio.charset.CharsetDecoder reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallObjectMethodPtr(this, _reset11498)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetDecoder.staticClass, _reset11498)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implFlush11499; 
		protected virtual java.nio.charset.CoderResult implFlush(java.nio.CharBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallObjectMethodPtr(this, _implFlush11499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetDecoder.staticClass, _implFlush11499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMalformedInput11500; 
		public virtual java.nio.charset.CharsetDecoder onMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallObjectMethodPtr(this, _onMalformedInput11500, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetDecoder.staticClass, _onMalformedInput11500, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUnmappableCharacter11501; 
		public virtual java.nio.charset.CharsetDecoder onUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallObjectMethodPtr(this, _onUnmappableCharacter11501, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetDecoder.staticClass, _onUnmappableCharacter11501, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replacement11502; 
		public virtual java.lang.String replacement() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _replacement11502)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetDecoder.staticClass, _replacement11502)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _malformedInputAction11503; 
		public virtual java.nio.charset.CodingErrorAction malformedInputAction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallObjectMethodPtr(this, _malformedInputAction11503)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetDecoder.staticClass, _malformedInputAction11503)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unmappableCharacterAction11504; 
		public virtual java.nio.charset.CodingErrorAction unmappableCharacterAction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallObjectMethodPtr(this, _unmappableCharacterAction11504)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetDecoder.staticClass, _unmappableCharacterAction11504)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replaceWith11505; 
		public virtual java.nio.charset.CharsetDecoder replaceWith(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallObjectMethodPtr(this, _replaceWith11505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetDecoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetDecoder.staticClass, _replaceWith11505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implReplaceWith11506; 
		protected virtual void implReplaceWith(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				@__env.CallVoidMethod(this, _implReplaceWith11506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.charset.CharsetDecoder.staticClass, _implReplaceWith11506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implOnMalformedInput11507; 
		protected virtual void implOnMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				@__env.CallVoidMethod(this, _implOnMalformedInput11507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.charset.CharsetDecoder.staticClass, _implOnMalformedInput11507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implOnUnmappableCharacter11508; 
		protected virtual void implOnUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				@__env.CallVoidMethod(this, _implOnUnmappableCharacter11508, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.charset.CharsetDecoder.staticClass, _implOnUnmappableCharacter11508, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implReset11509; 
		protected virtual void implReset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				@__env.CallVoidMethod(this, _implReset11509); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.charset.CharsetDecoder.staticClass, _implReset11509); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _maxCharsPerByte11510; 
		public virtual float maxCharsPerByte() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return @__env.CallFloatMethod(this, _maxCharsPerByte11510); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, java.nio.charset.CharsetDecoder.staticClass, _maxCharsPerByte11510); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeLoop11511; 
		protected abstract java.nio.charset.CoderResult decodeLoop(java.nio.ByteBuffer arg0, java.nio.CharBuffer arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _averageCharsPerByte11512; 
		public virtual float averageCharsPerByte() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return @__env.CallFloatMethod(this, _averageCharsPerByte11512); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, java.nio.charset.CharsetDecoder.staticClass, _averageCharsPerByte11512); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAutoDetecting11513; 
		public virtual bool isAutoDetecting() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return @__env.CallBooleanMethod(this, _isAutoDetecting11513); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.CharsetDecoder.staticClass, _isAutoDetecting11513); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isCharsetDetected11514; 
		public virtual bool isCharsetDetected() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return @__env.CallBooleanMethod(this, _isCharsetDetected11514); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.CharsetDecoder.staticClass, _isCharsetDetected11514); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _detectedCharset11515; 
		public virtual java.nio.charset.Charset detectedCharset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetDecoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallObjectMethodPtr(this, _detectedCharset11515)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetDecoder.staticClass, _detectedCharset11515)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CharsetDecoder11516; 
		protected CharsetDecoder(java.nio.charset.Charset arg0, float arg1, float arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.charset.CharsetDecoder.staticClass, _CharsetDecoder11516, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.charset.CharsetDecoder.staticClass = @__class; 
			global::java.nio.charset.CharsetDecoder._charset11494 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "charset", "()Ljava/nio/charset/Charset;"); 
			global::java.nio.charset.CharsetDecoder._decode11495 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "decode", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;Z)Ljava/nio/charset/CoderResult;"); 
			global::java.nio.charset.CharsetDecoder._decode11496 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;"); 
			global::java.nio.charset.CharsetDecoder._flush11497 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "flush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;"); 
			global::java.nio.charset.CharsetDecoder._reset11498 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "reset", "()Ljava/nio/charset/CharsetDecoder;"); 
			global::java.nio.charset.CharsetDecoder._implFlush11499 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "implFlush", "(Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;"); 
			global::java.nio.charset.CharsetDecoder._onMalformedInput11500 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;"); 
			global::java.nio.charset.CharsetDecoder._onUnmappableCharacter11501 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetDecoder;"); 
			global::java.nio.charset.CharsetDecoder._replacement11502 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "replacement", "()Ljava/lang/String;"); 
			global::java.nio.charset.CharsetDecoder._malformedInputAction11503 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;"); 
			global::java.nio.charset.CharsetDecoder._unmappableCharacterAction11504 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;"); 
			global::java.nio.charset.CharsetDecoder._replaceWith11505 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "replaceWith", "(Ljava/lang/String;)Ljava/nio/charset/CharsetDecoder;"); 
			global::java.nio.charset.CharsetDecoder._implReplaceWith11506 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "implReplaceWith", "(Ljava/lang/String;)V"); 
			global::java.nio.charset.CharsetDecoder._implOnMalformedInput11507 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V"); 
			global::java.nio.charset.CharsetDecoder._implOnUnmappableCharacter11508 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V"); 
			global::java.nio.charset.CharsetDecoder._implReset11509 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "implReset", "()V"); 
			global::java.nio.charset.CharsetDecoder._maxCharsPerByte11510 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "maxCharsPerByte", "()F"); 
			global::java.nio.charset.CharsetDecoder._decodeLoop11511 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "decodeLoop", "(Ljava/nio/ByteBuffer;Ljava/nio/CharBuffer;)Ljava/nio/charset/CoderResult;"); 
			global::java.nio.charset.CharsetDecoder._averageCharsPerByte11512 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "averageCharsPerByte", "()F"); 
			global::java.nio.charset.CharsetDecoder._isAutoDetecting11513 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "isAutoDetecting", "()Z"); 
			global::java.nio.charset.CharsetDecoder._isCharsetDetected11514 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "isCharsetDetected", "()Z"); 
			global::java.nio.charset.CharsetDecoder._detectedCharset11515 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "detectedCharset", "()Ljava/nio/charset/Charset;"); 
			global::java.nio.charset.CharsetDecoder._CharsetDecoder11516 = @__env.GetMethodID(global::java.nio.charset.CharsetDecoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF)V"); 
		} 
	} 
} 
