namespace java.nio.charset
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class CharsetEncoder : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static CharsetEncoder()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.charset.CharsetEncoder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected CharsetEncoder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _charset12381;
		public virtual global::java.nio.charset.Charset charset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._charset12381));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._charset12381));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encode12382;
		public virtual global::java.nio.charset.CoderResult encode(java.nio.CharBuffer arg0, java.nio.ByteBuffer arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._encode12382, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._encode12382, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encode12383;
		public virtual global::java.nio.ByteBuffer encode(java.nio.CharBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._encode12383, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._encode12383, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flush12384;
		public virtual global::java.nio.charset.CoderResult flush(java.nio.ByteBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._flush12384, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._flush12384, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset12385;
		public virtual global::java.nio.charset.CharsetEncoder reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._reset12385));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._reset12385));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implFlush12386;
		protected virtual global::java.nio.charset.CoderResult implFlush(java.nio.ByteBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._implFlush12386, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implFlush12386, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMalformedInput12387;
		public virtual global::java.nio.charset.CharsetEncoder onMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._onMalformedInput12387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._onMalformedInput12387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUnmappableCharacter12388;
		public virtual global::java.nio.charset.CharsetEncoder onUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._onUnmappableCharacter12388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._onUnmappableCharacter12388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _canEncode12389;
		public virtual bool canEncode(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.CharsetEncoder._canEncode12389, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._canEncode12389, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _canEncode12390;
		public virtual bool canEncode(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.CharsetEncoder._canEncode12390, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._canEncode12390, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encodeLoop12391;
		protected abstract global::java.nio.charset.CoderResult encodeLoop(java.nio.CharBuffer arg0, java.nio.ByteBuffer arg1);
		internal static global::net.sf.jni4net.jni.MethodId _averageBytesPerChar12392;
		public virtual float averageBytesPerChar() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::java.nio.charset.CharsetEncoder._averageBytesPerChar12392);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._averageBytesPerChar12392);
		}
		internal static global::net.sf.jni4net.jni.MethodId _maxBytesPerChar12393;
		public virtual float maxBytesPerChar() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::java.nio.charset.CharsetEncoder._maxBytesPerChar12393);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._maxBytesPerChar12393);
		}
		internal static global::net.sf.jni4net.jni.MethodId _replacement12394;
		public virtual byte[] replacement() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._replacement12394));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._replacement12394));
		}
		internal static global::net.sf.jni4net.jni.MethodId _malformedInputAction12395;
		public virtual global::java.nio.charset.CodingErrorAction malformedInputAction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._malformedInputAction12395));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._malformedInputAction12395));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unmappableCharacterAction12396;
		public virtual global::java.nio.charset.CodingErrorAction unmappableCharacterAction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._unmappableCharacterAction12396));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._unmappableCharacterAction12396));
		}
		internal static global::net.sf.jni4net.jni.MethodId _replaceWith12397;
		public virtual global::java.nio.charset.CharsetEncoder replaceWith(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._replaceWith12397, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._replaceWith12397, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implReplaceWith12398;
		protected virtual void implReplaceWith(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.charset.CharsetEncoder._implReplaceWith12398, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implReplaceWith12398, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLegalReplacement12399;
		public virtual bool isLegalReplacement(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.CharsetEncoder._isLegalReplacement12399, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._isLegalReplacement12399, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implOnMalformedInput12400;
		protected virtual void implOnMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.charset.CharsetEncoder._implOnMalformedInput12400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implOnMalformedInput12400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implOnUnmappableCharacter12401;
		protected virtual void implOnUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.charset.CharsetEncoder._implOnUnmappableCharacter12401, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implOnUnmappableCharacter12401, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implReset12402;
		protected virtual void implReset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.charset.CharsetEncoder._implReset12402);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implReset12402);
		}
		internal static global::net.sf.jni4net.jni.MethodId _CharsetEncoder12403;
		protected CharsetEncoder(java.nio.charset.Charset arg0, float arg1, float arg2, byte[] arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._CharsetEncoder12403, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CharsetEncoder12404;
		protected CharsetEncoder(java.nio.charset.Charset arg0, float arg1, float arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._CharsetEncoder12404, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.charset.CharsetEncoder.staticClass = @__class;
			global::java.nio.charset.CharsetEncoder._charset12381 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "charset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.CharsetEncoder._encode12382 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "encode", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;Z)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._encode12383 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;");
			global::java.nio.charset.CharsetEncoder._flush12384 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "flush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._reset12385 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "reset", "()Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._implFlush12386 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "implFlush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._onMalformedInput12387 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._onUnmappableCharacter12388 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._canEncode12389 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "canEncode", "(Ljava/lang/CharSequence;)Z");
			global::java.nio.charset.CharsetEncoder._canEncode12390 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "canEncode", "(C)Z");
			global::java.nio.charset.CharsetEncoder._encodeLoop12391 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "encodeLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._averageBytesPerChar12392 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "averageBytesPerChar", "()F");
			global::java.nio.charset.CharsetEncoder._maxBytesPerChar12393 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "maxBytesPerChar", "()F");
			global::java.nio.charset.CharsetEncoder._replacement12394 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "replacement", "()[B");
			global::java.nio.charset.CharsetEncoder._malformedInputAction12395 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetEncoder._unmappableCharacterAction12396 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetEncoder._replaceWith12397 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "replaceWith", "([B)Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._implReplaceWith12398 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "implReplaceWith", "([B)V");
			global::java.nio.charset.CharsetEncoder._isLegalReplacement12399 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "isLegalReplacement", "([B)Z");
			global::java.nio.charset.CharsetEncoder._implOnMalformedInput12400 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetEncoder._implOnUnmappableCharacter12401 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetEncoder._implReset12402 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "implReset", "()V");
			global::java.nio.charset.CharsetEncoder._CharsetEncoder12403 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF[B)V");
			global::java.nio.charset.CharsetEncoder._CharsetEncoder12404 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF)V");
		}
	}
	public static class CharsetEncoderExtensionMethods
	{
		public static bool canEncode(this global::java.nio.charset.CharsetEncoder __this, string arg0)
		{
			return __this.canEncode((global::java.lang.String)arg0);
		}
	}
}
