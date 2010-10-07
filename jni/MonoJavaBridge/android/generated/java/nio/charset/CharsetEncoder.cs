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
		internal static global::net.sf.jni4net.jni.MethodId _charset13110;
		public virtual global::java.nio.charset.Charset charset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._charset13110));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.Charset>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._charset13110));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encode13111;
		public virtual global::java.nio.charset.CoderResult encode(java.nio.CharBuffer arg0, java.nio.ByteBuffer arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._encode13111, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._encode13111, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encode13112;
		public virtual global::java.nio.ByteBuffer encode(java.nio.CharBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._encode13112, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ByteBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._encode13112, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flush13113;
		public virtual global::java.nio.charset.CoderResult flush(java.nio.ByteBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._flush13113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._flush13113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset13114;
		public virtual global::java.nio.charset.CharsetEncoder reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._reset13114));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._reset13114));
		}
		internal static global::net.sf.jni4net.jni.MethodId _canEncode13115;
		public virtual bool canEncode(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.CharsetEncoder._canEncode13115, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._canEncode13115, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _canEncode13116;
		public virtual bool canEncode(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.CharsetEncoder._canEncode13116, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._canEncode13116, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public bool canEncode(string arg0)
		{
			return canEncode((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMalformedInput13117;
		public virtual global::java.nio.charset.CharsetEncoder onMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._onMalformedInput13117, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._onMalformedInput13117, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUnmappableCharacter13118;
		public virtual global::java.nio.charset.CharsetEncoder onUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._onUnmappableCharacter13118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._onUnmappableCharacter13118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _maxBytesPerChar13119;
		public virtual float maxBytesPerChar() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::java.nio.charset.CharsetEncoder._maxBytesPerChar13119);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._maxBytesPerChar13119);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLegalReplacement13120;
		public virtual bool isLegalReplacement(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.CharsetEncoder._isLegalReplacement13120, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._isLegalReplacement13120, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _encodeLoop13121;
		protected abstract global::java.nio.charset.CoderResult encodeLoop(java.nio.CharBuffer arg0, java.nio.ByteBuffer arg1);
		internal static global::net.sf.jni4net.jni.MethodId _averageBytesPerChar13122;
		public virtual float averageBytesPerChar() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::java.nio.charset.CharsetEncoder._averageBytesPerChar13122);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._averageBytesPerChar13122);
		}
		internal static global::net.sf.jni4net.jni.MethodId _replacement13123;
		public virtual byte[] replacement() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._replacement13123));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._replacement13123));
		}
		internal static global::net.sf.jni4net.jni.MethodId _malformedInputAction13124;
		public virtual global::java.nio.charset.CodingErrorAction malformedInputAction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._malformedInputAction13124));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._malformedInputAction13124));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unmappableCharacterAction13125;
		public virtual global::java.nio.charset.CodingErrorAction unmappableCharacterAction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._unmappableCharacterAction13125));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CodingErrorAction>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._unmappableCharacterAction13125));
		}
		internal static global::net.sf.jni4net.jni.MethodId _replaceWith13126;
		public virtual global::java.nio.charset.CharsetEncoder replaceWith(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._replaceWith13126, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CharsetEncoder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._replaceWith13126, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implReplaceWith13127;
		protected virtual void implReplaceWith(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.charset.CharsetEncoder._implReplaceWith13127, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implReplaceWith13127, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implOnMalformedInput13128;
		protected virtual void implOnMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.charset.CharsetEncoder._implOnMalformedInput13128, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implOnMalformedInput13128, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implOnUnmappableCharacter13129;
		protected virtual void implOnUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.charset.CharsetEncoder._implOnUnmappableCharacter13129, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implOnUnmappableCharacter13129, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implFlush13130;
		protected virtual global::java.nio.charset.CoderResult implFlush(java.nio.ByteBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder._implFlush13130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implFlush13130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implReset13131;
		protected virtual void implReset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.charset.CharsetEncoder._implReset13131);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implReset13131);
		}
		internal static global::net.sf.jni4net.jni.MethodId _CharsetEncoder13132;
		protected CharsetEncoder(java.nio.charset.Charset arg0, float arg1, float arg2, byte[] arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._CharsetEncoder13132, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CharsetEncoder13133;
		protected CharsetEncoder(java.nio.charset.Charset arg0, float arg1, float arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._CharsetEncoder13133, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.charset.CharsetEncoder.staticClass = @__class;
			global::java.nio.charset.CharsetEncoder._charset13110 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "charset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.CharsetEncoder._encode13111 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "encode", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;Z)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._encode13112 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;");
			global::java.nio.charset.CharsetEncoder._flush13113 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "flush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._reset13114 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "reset", "()Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._canEncode13115 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "canEncode", "(C)Z");
			global::java.nio.charset.CharsetEncoder._canEncode13116 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "canEncode", "(Ljava/lang/CharSequence;)Z");
			global::java.nio.charset.CharsetEncoder._onMalformedInput13117 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._onUnmappableCharacter13118 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._maxBytesPerChar13119 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "maxBytesPerChar", "()F");
			global::java.nio.charset.CharsetEncoder._isLegalReplacement13120 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "isLegalReplacement", "([B)Z");
			global::java.nio.charset.CharsetEncoder._encodeLoop13121 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "encodeLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._averageBytesPerChar13122 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "averageBytesPerChar", "()F");
			global::java.nio.charset.CharsetEncoder._replacement13123 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "replacement", "()[B");
			global::java.nio.charset.CharsetEncoder._malformedInputAction13124 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetEncoder._unmappableCharacterAction13125 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetEncoder._replaceWith13126 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "replaceWith", "([B)Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._implReplaceWith13127 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "implReplaceWith", "([B)V");
			global::java.nio.charset.CharsetEncoder._implOnMalformedInput13128 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetEncoder._implOnUnmappableCharacter13129 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetEncoder._implFlush13130 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "implFlush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._implReset13131 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "implReset", "()V");
			global::java.nio.charset.CharsetEncoder._CharsetEncoder13132 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF[B)V");
			global::java.nio.charset.CharsetEncoder._CharsetEncoder13133 = @__env.GetMethodID(global::java.nio.charset.CharsetEncoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF)V");
		}
	}
}
