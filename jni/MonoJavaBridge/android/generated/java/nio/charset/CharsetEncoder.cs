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
		internal static global::MonoJavaBridge.MethodId _charset22771;
		public virtual global::java.nio.charset.Charset charset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._charset22771)) as java.nio.charset.Charset;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._charset22771)) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _encode22772;
		public virtual global::java.nio.charset.CoderResult encode(java.nio.CharBuffer arg0, java.nio.ByteBuffer arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._encode22772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._encode22772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _encode22773;
		public virtual global::java.nio.ByteBuffer encode(java.nio.CharBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._encode22773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._encode22773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _flush22774;
		public virtual global::java.nio.charset.CoderResult flush(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._flush22774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._flush22774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _reset22775;
		public virtual global::java.nio.charset.CharsetEncoder reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._reset22775)) as java.nio.charset.CharsetEncoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._reset22775)) as java.nio.charset.CharsetEncoder;
		}
		internal static global::MonoJavaBridge.MethodId _canEncode22776;
		public virtual bool canEncode(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._canEncode22776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._canEncode22776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _canEncode22777;
		public virtual bool canEncode(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._canEncode22777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._canEncode22777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool canEncode(string arg0)
		{
			return canEncode((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _onMalformedInput22778;
		public virtual global::java.nio.charset.CharsetEncoder onMalformedInput(java.nio.charset.CodingErrorAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._onMalformedInput22778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetEncoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._onMalformedInput22778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetEncoder;
		}
		internal static global::MonoJavaBridge.MethodId _onUnmappableCharacter22779;
		public virtual global::java.nio.charset.CharsetEncoder onUnmappableCharacter(java.nio.charset.CodingErrorAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._onUnmappableCharacter22779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetEncoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._onUnmappableCharacter22779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetEncoder;
		}
		internal static global::MonoJavaBridge.MethodId _maxBytesPerChar22780;
		public virtual float maxBytesPerChar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._maxBytesPerChar22780);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._maxBytesPerChar22780);
		}
		internal static global::MonoJavaBridge.MethodId _isLegalReplacement22781;
		public virtual bool isLegalReplacement(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._isLegalReplacement22781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._isLegalReplacement22781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _encodeLoop22782;
		protected abstract global::java.nio.charset.CoderResult encodeLoop(java.nio.CharBuffer arg0, java.nio.ByteBuffer arg1);
		internal static global::MonoJavaBridge.MethodId _averageBytesPerChar22783;
		public virtual float averageBytesPerChar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._averageBytesPerChar22783);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._averageBytesPerChar22783);
		}
		internal static global::MonoJavaBridge.MethodId _replacement22784;
		public virtual byte[] replacement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._replacement22784)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._replacement22784)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _malformedInputAction22785;
		public virtual global::java.nio.charset.CodingErrorAction malformedInputAction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._malformedInputAction22785)) as java.nio.charset.CodingErrorAction;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._malformedInputAction22785)) as java.nio.charset.CodingErrorAction;
		}
		internal static global::MonoJavaBridge.MethodId _unmappableCharacterAction22786;
		public virtual global::java.nio.charset.CodingErrorAction unmappableCharacterAction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._unmappableCharacterAction22786)) as java.nio.charset.CodingErrorAction;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._unmappableCharacterAction22786)) as java.nio.charset.CodingErrorAction;
		}
		internal static global::MonoJavaBridge.MethodId _replaceWith22787;
		public virtual global::java.nio.charset.CharsetEncoder replaceWith(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._replaceWith22787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetEncoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._replaceWith22787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CharsetEncoder;
		}
		internal static global::MonoJavaBridge.MethodId _implReplaceWith22788;
		protected virtual void implReplaceWith(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._implReplaceWith22788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implReplaceWith22788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implOnMalformedInput22789;
		protected virtual void implOnMalformedInput(java.nio.charset.CodingErrorAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._implOnMalformedInput22789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implOnMalformedInput22789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implOnUnmappableCharacter22790;
		protected virtual void implOnUnmappableCharacter(java.nio.charset.CodingErrorAction arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._implOnUnmappableCharacter22790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implOnUnmappableCharacter22790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _implFlush22791;
		protected virtual global::java.nio.charset.CoderResult implFlush(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._implFlush22791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implFlush22791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _implReset22792;
		protected virtual void implReset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder._implReset22792);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._implReset22792);
		}
		internal static global::MonoJavaBridge.MethodId _CharsetEncoder22793;
		protected CharsetEncoder(java.nio.charset.Charset arg0, float arg1, float arg2, byte[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._CharsetEncoder22793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CharsetEncoder22794;
		protected CharsetEncoder(java.nio.charset.Charset arg0, float arg1, float arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.CharsetEncoder.staticClass, global::java.nio.charset.CharsetEncoder._CharsetEncoder22794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetEncoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetEncoder"));
			global::java.nio.charset.CharsetEncoder._charset22771 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "charset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.CharsetEncoder._encode22772 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "encode", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;Z)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._encode22773 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;");
			global::java.nio.charset.CharsetEncoder._flush22774 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "flush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._reset22775 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "reset", "()Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._canEncode22776 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "canEncode", "(C)Z");
			global::java.nio.charset.CharsetEncoder._canEncode22777 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "canEncode", "(Ljava/lang/CharSequence;)Z");
			global::java.nio.charset.CharsetEncoder._onMalformedInput22778 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "onMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._onUnmappableCharacter22779 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "onUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._maxBytesPerChar22780 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "maxBytesPerChar", "()F");
			global::java.nio.charset.CharsetEncoder._isLegalReplacement22781 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "isLegalReplacement", "([B)Z");
			global::java.nio.charset.CharsetEncoder._encodeLoop22782 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "encodeLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._averageBytesPerChar22783 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "averageBytesPerChar", "()F");
			global::java.nio.charset.CharsetEncoder._replacement22784 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "replacement", "()[B");
			global::java.nio.charset.CharsetEncoder._malformedInputAction22785 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "malformedInputAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetEncoder._unmappableCharacterAction22786 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "unmappableCharacterAction", "()Ljava/nio/charset/CodingErrorAction;");
			global::java.nio.charset.CharsetEncoder._replaceWith22787 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "replaceWith", "([B)Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.CharsetEncoder._implReplaceWith22788 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "implReplaceWith", "([B)V");
			global::java.nio.charset.CharsetEncoder._implOnMalformedInput22789 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "implOnMalformedInput", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetEncoder._implOnUnmappableCharacter22790 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "implOnUnmappableCharacter", "(Ljava/nio/charset/CodingErrorAction;)V");
			global::java.nio.charset.CharsetEncoder._implFlush22791 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "implFlush", "(Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CharsetEncoder._implReset22792 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "implReset", "()V");
			global::java.nio.charset.CharsetEncoder._CharsetEncoder22793 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF[B)V");
			global::java.nio.charset.CharsetEncoder._CharsetEncoder22794 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder.staticClass, "<init>", "(Ljava/nio/charset/Charset;FF)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.charset.CharsetEncoder))]
	internal sealed partial class CharsetEncoder_ : java.nio.charset.CharsetEncoder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharsetEncoder_()
		{
			InitJNI();
		}
		internal CharsetEncoder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _encodeLoop22795;
		protected override global::java.nio.charset.CoderResult encodeLoop(java.nio.CharBuffer arg0, java.nio.ByteBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder_._encodeLoop22795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.charset.CoderResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CharsetEncoder_.staticClass, global::java.nio.charset.CharsetEncoder_._encodeLoop22795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.nio.charset.CoderResult;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CharsetEncoder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CharsetEncoder"));
			global::java.nio.charset.CharsetEncoder_._encodeLoop22795 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CharsetEncoder_.staticClass, "encodeLoop", "(Ljava/nio/CharBuffer;Ljava/nio/ByteBuffer;)Ljava/nio/charset/CoderResult;");
		}
	}
}
