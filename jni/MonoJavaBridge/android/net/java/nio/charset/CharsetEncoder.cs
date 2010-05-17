namespace java.nio.charset 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class CharsetEncoder : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static CharsetEncoder() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.charset.CharsetEncoder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected CharsetEncoder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _charset11517; 
		public virtual java.nio.charset.Charset charset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallObjectMethodPtr(this, _charset11517)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetEncoder.staticClass, _charset11517)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _encode11518; 
		public virtual java.nio.charset.CoderResult encode(java.nio.CharBuffer arg0, java.nio.ByteBuffer arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallObjectMethodPtr(this, _encode11518, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetEncoder.staticClass, _encode11518, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _encode11519; 
		public virtual java.nio.ByteBuffer encode(java.nio.CharBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, _encode11519, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetEncoder.staticClass, _encode11519, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flush11520; 
		public virtual java.nio.charset.CoderResult flush(java.nio.ByteBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallObjectMethodPtr(this, _flush11520, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetEncoder.staticClass, _flush11520, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset11521; 
		public virtual java.nio.charset.CharsetEncoder reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallObjectMethodPtr(this, _reset11521)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetEncoder.staticClass, _reset11521)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implFlush11522; 
		protected virtual java.nio.charset.CoderResult implFlush(java.nio.ByteBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallObjectMethodPtr(this, _implFlush11522, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetEncoder.staticClass, _implFlush11522, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMalformedInput11523; 
		public virtual java.nio.charset.CharsetEncoder onMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallObjectMethodPtr(this, _onMalformedInput11523, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetEncoder.staticClass, _onMalformedInput11523, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUnmappableCharacter11524; 
		public virtual java.nio.charset.CharsetEncoder onUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallObjectMethodPtr(this, _onUnmappableCharacter11524, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetEncoder.staticClass, _onUnmappableCharacter11524, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canEncode11525; 
		public virtual bool canEncode(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return @__env.CallBooleanMethod(this, _canEncode11525, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.CharsetEncoder.staticClass, _canEncode11525, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canEncode11526; 
		public virtual bool canEncode(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return @__env.CallBooleanMethod(this, _canEncode11526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.CharsetEncoder.staticClass, _canEncode11526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _encodeLoop11527; 
		protected abstract java.nio.charset.CoderResult encodeLoop(java.nio.CharBuffer arg0, java.nio.ByteBuffer arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _averageBytesPerChar11528; 
		public virtual float averageBytesPerChar() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return @__env.CallFloatMethod(this, _averageBytesPerChar11528); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, java.nio.charset.CharsetEncoder.staticClass, _averageBytesPerChar11528); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _maxBytesPerChar11529; 
		public virtual float maxBytesPerChar() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return @__env.CallFloatMethod(this, _maxBytesPerChar11529); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, java.nio.charset.CharsetEncoder.staticClass, _maxBytesPerChar11529); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replacement11530; 
		public virtual byte[] replacement() 
		{ 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _replacement11530)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetEncoder.staticClass, _replacement11530)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _malformedInputAction11531; 
		public virtual java.nio.charset.CodingErrorAction malformedInputAction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallObjectMethodPtr(this, _malformedInputAction11531)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetEncoder.staticClass, _malformedInputAction11531)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unmappableCharacterAction11532; 
		public virtual java.nio.charset.CodingErrorAction unmappableCharacterAction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallObjectMethodPtr(this, _unmappableCharacterAction11532)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetEncoder.staticClass, _unmappableCharacterAction11532)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replaceWith11533; 
		public virtual java.nio.charset.CharsetEncoder replaceWith(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallObjectMethodPtr(this, _replaceWith11533, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CharsetEncoder.staticClass, _replaceWith11533, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implReplaceWith11534; 
		protected virtual void implReplaceWith(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				@__env.CallVoidMethod(this, _implReplaceWith11534, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.charset.CharsetEncoder.staticClass, _implReplaceWith11534, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLegalReplacement11535; 
		public virtual bool isLegalReplacement(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				return @__env.CallBooleanMethod(this, _isLegalReplacement11535, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.CharsetEncoder.staticClass, _isLegalReplacement11535, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implOnMalformedInput11536; 
		protected virtual void implOnMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				@__env.CallVoidMethod(this, _implOnMalformedInput11536, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.charset.CharsetEncoder.staticClass, _implOnMalformedInput11536, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implOnUnmappableCharacter11537; 
		protected virtual void implOnUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				@__env.CallVoidMethod(this, _implOnUnmappableCharacter11537, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.charset.CharsetEncoder.staticClass, _implOnUnmappableCharacter11537, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implReset11538; 
		protected virtual void implReset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CharsetEncoder)) 
				@__env.CallVoidMethod(this, _implReset11538); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.charset.CharsetEncoder.staticClass, _implReset11538); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CharsetEncoder11539; 
		protected CharsetEncoder(java.nio.charset.Charset arg0, float arg1, float arg2, byte[] arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.charset.CharsetEncoder.staticClass, _CharsetEncoder11539, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CharsetEncoder11540; 
		protected CharsetEncoder(java.nio.charset.Charset arg0, float arg1, float arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.charset.CharsetEncoder.staticClass, _CharsetEncoder11540, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.charset.CharsetEncoder.staticClass = @__class; 
			global::java.nio.charset.CharsetEncoder._charset11517 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "charset", "()Ljava/nio/charset/Charset;"); 
			global::java.nio.charset.CharsetEncoder._encode11518 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "encode", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;Z)Ljava/nio/charset/CoderResult;"); 
			global::java.nio.charset.CharsetEncoder._encode11519 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;"); 
			global::java.nio.charset.CharsetEncoder._flush11520 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "flush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;"); 
			global::java.nio.charset.CharsetEncoder._reset11521 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "reset", "()Ljava/nio/charset/CharsetEncoder;"); 
			global::java.nio.charset.CharsetEncoder._implFlush11522 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "implFlush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;"); 
			global::java.nio.charset.CharsetEncoder._onMalformedInput11523 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;"); 
			global::java.nio.charset.CharsetEncoder._onUnmappableCharacter11524 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;"); 
			global::java.nio.charset.CharsetEncoder._canEncode11525 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "canEncode", "(Ljava/lang/CharSequence;)Z"); 
			global::java.nio.charset.CharsetEncoder._canEncode11526 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "canEncode", "(C)Z"); 
			global::java.nio.charset.CharsetEncoder._encodeLoop11527 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "encodeLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;"); 
			global::java.nio.charset.CharsetEncoder._averageBytesPerChar11528 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "averageBytesPerChar", "()F"); 
			global::java.nio.charset.CharsetEncoder._maxBytesPerChar11529 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "maxBytesPerChar", "()F"); 
			global::java.nio.charset.CharsetEncoder._replacement11530 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "replacement", "()[B"); 
			global::java.nio.charset.CharsetEncoder._malformedInputAction11531 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;"); 
			global::java.nio.charset.CharsetEncoder._unmappableCharacterAction11532 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;"); 
			global::java.nio.charset.CharsetEncoder._replaceWith11533 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "replaceWith", "([B)Ljava/nio/charset/CharsetEncoder;"); 
			global::java.nio.charset.CharsetEncoder._implReplaceWith11534 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "implReplaceWith", "([B)V"); 
			global::java.nio.charset.CharsetEncoder._isLegalReplacement11535 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "isLegalReplacement", "([B)Z"); 
			global::java.nio.charset.CharsetEncoder._implOnMalformedInput11536 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V"); 
			global::java.nio.charset.CharsetEncoder._implOnUnmappableCharacter11537 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V"); 
			global::java.nio.charset.CharsetEncoder._implReset11538 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "implReset", "()V"); 
			global::java.nio.charset.CharsetEncoder._CharsetEncoder11539 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF[B)V"); 
			global::java.nio.charset.CharsetEncoder._CharsetEncoder11540 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF)V"); 
		} 
	} 
} 
