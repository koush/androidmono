namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.charset.CharsetEncoder_))]
	public abstract partial class CharsetEncoder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharsetEncoder()
		{
			InitJNI();
		}
		protected CharsetEncoder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _charset17054;
		public virtual global::java.nio.charset.Charset charset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._charset17054)) as java.nio.charset.Charset;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._charset17054)) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _encode17055;
		public virtual global::java.nio.charset.CoderResult encode(java.nio.CharBuffer arg0, java.nio.ByteBuffer arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._encode17055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._encode17055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _encode17056;
		public virtual global::java.nio.ByteBuffer encode(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._encode17056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._encode17056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _flush17057;
		public virtual global::java.nio.charset.CoderResult flush(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._flush17057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._flush17057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _reset17058;
		public virtual global::java.nio.charset.CharsetEncoder reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._reset17058)) as java.nio.charset.CharsetEncoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._reset17058)) as java.nio.charset.CharsetEncoder;
		}
		internal static global::MonoJavaBridge.MethodId _canEncode17059;
		public virtual bool canEncode(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._canEncode17059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._canEncode17059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _canEncode17060;
		public virtual bool canEncode(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._canEncode17060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._canEncode17060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool canEncode(string arg0)
		{
			return canEncode((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _onMalformedInput17061;
		public virtual global::java.nio.charset.CharsetEncoder onMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._onMalformedInput17061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetEncoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._onMalformedInput17061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetEncoder;
		}
		internal static global::MonoJavaBridge.MethodId _onUnmappableCharacter17062;
		public virtual global::java.nio.charset.CharsetEncoder onUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._onUnmappableCharacter17062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetEncoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._onUnmappableCharacter17062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetEncoder;
		}
		internal static global::MonoJavaBridge.MethodId _maxBytesPerChar17063;
		public virtual float maxBytesPerChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._maxBytesPerChar17063);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._maxBytesPerChar17063);
		}
		internal static global::MonoJavaBridge.MethodId _isLegalReplacement17064;
		public virtual bool isLegalReplacement(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._isLegalReplacement17064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._isLegalReplacement17064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _encodeLoop17065;
		protected abstract global::java.nio.charset.CoderResult encodeLoop(java.nio.CharBuffer arg0, java.nio.ByteBuffer arg1);
		internal static global::MonoJavaBridge.MethodId _averageBytesPerChar17066;
		public virtual float averageBytesPerChar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._averageBytesPerChar17066);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._averageBytesPerChar17066);
		}
		internal static global::MonoJavaBridge.MethodId _replacement17067;
		public virtual byte[] replacement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._replacement17067)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._replacement17067)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _malformedInputAction17068;
		public virtual global::java.nio.charset.CodingErrorAction malformedInputAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._malformedInputAction17068)) as java.nio.charset.CodingErrorAction;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._malformedInputAction17068)) as java.nio.charset.CodingErrorAction;
		}
		internal static global::MonoJavaBridge.MethodId _unmappableCharacterAction17069;
		public virtual global::java.nio.charset.CodingErrorAction unmappableCharacterAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._unmappableCharacterAction17069)) as java.nio.charset.CodingErrorAction;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._unmappableCharacterAction17069)) as java.nio.charset.CodingErrorAction;
		}
		internal static global::MonoJavaBridge.MethodId _replaceWith17070;
		public virtual global::java.nio.charset.CharsetEncoder replaceWith(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._replaceWith17070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetEncoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._replaceWith17070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetEncoder;
		}
		internal static global::MonoJavaBridge.MethodId _implReplaceWith17071;
		protected virtual void implReplaceWith(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._implReplaceWith17071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implReplaceWith17071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implOnMalformedInput17072;
		protected virtual void implOnMalformedInput(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._implOnMalformedInput17072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implOnMalformedInput17072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implOnUnmappableCharacter17073;
		protected virtual void implOnUnmappableCharacter(java.nio.charset.CodingErrorAction arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._implOnUnmappableCharacter17073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implOnUnmappableCharacter17073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implFlush17074;
		protected virtual global::java.nio.charset.CoderResult implFlush(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._implFlush17074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implFlush17074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _implReset17075;
		protected virtual void implReset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._implReset17075);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implReset17075);
		}
		internal static global::MonoJavaBridge.MethodId _CharsetEncoder17076;
		protected CharsetEncoder(java.nio.charset.Charset arg0, float arg1, float arg2, byte[] arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._CharsetEncoder17076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CharsetEncoder17077;
		protected CharsetEncoder(java.nio.charset.Charset arg0, float arg1, float arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._CharsetEncoder17077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetEncoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetEncoder"));
			global::java.nio.charset.CharsetEncoder._charset17054 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "charset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.CharsetEncoder._encode17055 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "encode", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;Z)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._encode17056 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;");
			global::java.nio.charset.CharsetEncoder._flush17057 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "flush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._reset17058 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "reset", "()Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._canEncode17059 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "canEncode", "(C)Z");
			global::java.nio.charset.CharsetEncoder._canEncode17060 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "canEncode", "(Ljava/lang/CharSequence;)Z");
			global::java.nio.charset.CharsetEncoder._onMalformedInput17061 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._onUnmappableCharacter17062 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._maxBytesPerChar17063 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "maxBytesPerChar", "()F");
			global::java.nio.charset.CharsetEncoder._isLegalReplacement17064 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "isLegalReplacement", "([B)Z");
			global::java.nio.charset.CharsetEncoder._encodeLoop17065 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "encodeLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._averageBytesPerChar17066 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "averageBytesPerChar", "()F");
			global::java.nio.charset.CharsetEncoder._replacement17067 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "replacement", "()[B");
			global::java.nio.charset.CharsetEncoder._malformedInputAction17068 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetEncoder._unmappableCharacterAction17069 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetEncoder._replaceWith17070 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "replaceWith", "([B)Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._implReplaceWith17071 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "implReplaceWith", "([B)V");
			global::java.nio.charset.CharsetEncoder._implOnMalformedInput17072 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetEncoder._implOnUnmappableCharacter17073 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetEncoder._implFlush17074 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "implFlush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._implReset17075 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "implReset", "()V");
			global::java.nio.charset.CharsetEncoder._CharsetEncoder17076 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF[B)V");
			global::java.nio.charset.CharsetEncoder._CharsetEncoder17077 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.charset.CharsetEncoder))]
	public sealed partial class CharsetEncoder_ : java.nio.charset.CharsetEncoder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharsetEncoder_()
		{
			InitJNI();
		}
		internal CharsetEncoder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _encodeLoop17078;
		protected override global::java.nio.charset.CoderResult encodeLoop(java.nio.CharBuffer arg0, java.nio.ByteBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder_._encodeLoop17078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder_.staticClass, global::java.nio.charset.CharsetEncoder_._encodeLoop17078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.charset.CoderResult;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetEncoder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetEncoder"));
			global::java.nio.charset.CharsetEncoder_._encodeLoop17078 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder_.staticClass, "encodeLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;");
		}
	}
}
