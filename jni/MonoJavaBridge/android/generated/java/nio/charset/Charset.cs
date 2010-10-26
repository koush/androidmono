namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.charset.Charset_))]
	public abstract partial class Charset : java.lang.Object, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Charset()
		{
			InitJNI();
		}
		protected Charset(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _name22721;
		public virtual global::java.lang.String name() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._name22721)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._name22721)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _forName22722;
		public static global::java.nio.charset.Charset forName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._forName22722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _equals22723;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset._equals22723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._equals22723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22724;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._toString22724)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._toString22724)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22725;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.charset.Charset._hashCode22725);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._hashCode22725);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22726;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.charset.Charset._compareTo22726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._compareTo22726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22727;
		public virtual int compareTo(java.nio.charset.Charset arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.charset.Charset._compareTo22727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._compareTo22727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains22728;
		public abstract bool contains(java.nio.charset.Charset arg0);
		internal static global::MonoJavaBridge.MethodId _decode22729;
		public virtual global::java.nio.CharBuffer decode(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._decode22729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._decode22729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _encode22730;
		public virtual global::java.nio.ByteBuffer encode(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._encode22730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._encode22730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _encode22731;
		public virtual global::java.nio.ByteBuffer encode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._encode22731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._encode22731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isSupported22732;
		public static bool isSupported(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._isSupported22732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _defaultCharset22733;
		public static global::java.nio.charset.Charset defaultCharset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._defaultCharset22733)) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _aliases22734;
		public virtual global::java.util.Set aliases() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._aliases22734)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._aliases22734)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _availableCharsets22735;
		public static global::java.util.SortedMap availableCharsets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._availableCharsets22735)) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _displayName22736;
		public virtual global::java.lang.String displayName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._displayName22736)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._displayName22736)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _displayName22737;
		public virtual global::java.lang.String displayName(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._displayName22737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._displayName22737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isRegistered22738;
		public virtual bool isRegistered() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset._isRegistered22738);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._isRegistered22738);
		}
		internal static global::MonoJavaBridge.MethodId _newDecoder22739;
		public abstract global::java.nio.charset.CharsetDecoder newDecoder();
		internal static global::MonoJavaBridge.MethodId _newEncoder22740;
		public abstract global::java.nio.charset.CharsetEncoder newEncoder();
		internal static global::MonoJavaBridge.MethodId _canEncode22741;
		public virtual bool canEncode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset._canEncode22741);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._canEncode22741);
		}
		internal static global::MonoJavaBridge.MethodId _Charset22742;
		protected Charset(java.lang.String arg0, java.lang.String[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._Charset22742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.Charset.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/Charset"));
			global::java.nio.charset.Charset._name22721 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "name", "()Ljava/lang/String;");
			global::java.nio.charset.Charset._forName22722 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "forName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;");
			global::java.nio.charset.Charset._equals22723 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.charset.Charset._toString22724 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.charset.Charset._hashCode22725 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "hashCode", "()I");
			global::java.nio.charset.Charset._compareTo22726 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.charset.Charset._compareTo22727 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/nio/charset/Charset;)I");
			global::java.nio.charset.Charset._contains22728 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "contains", "(Ljava/nio/charset/Charset;)Z");
			global::java.nio.charset.Charset._decode22729 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;");
			global::java.nio.charset.Charset._encode22730 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;");
			global::java.nio.charset.Charset._encode22731 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/lang/String;)Ljava/nio/ByteBuffer;");
			global::java.nio.charset.Charset._isSupported22732 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "isSupported", "(Ljava/lang/String;)Z");
			global::java.nio.charset.Charset._defaultCharset22733 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "defaultCharset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.Charset._aliases22734 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "aliases", "()Ljava/util/Set;");
			global::java.nio.charset.Charset._availableCharsets22735 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "availableCharsets", "()Ljava/util/SortedMap;");
			global::java.nio.charset.Charset._displayName22736 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "displayName", "()Ljava/lang/String;");
			global::java.nio.charset.Charset._displayName22737 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "displayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.nio.charset.Charset._isRegistered22738 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "isRegistered", "()Z");
			global::java.nio.charset.Charset._newDecoder22739 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "newDecoder", "()Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.Charset._newEncoder22740 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "newEncoder", "()Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.Charset._canEncode22741 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "canEncode", "()Z");
			global::java.nio.charset.Charset._Charset22742 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "<init>", "(Ljava/lang/String;[Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.charset.Charset))]
	internal sealed partial class Charset_ : java.nio.charset.Charset
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Charset_()
		{
			InitJNI();
		}
		internal Charset_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _contains22743;
		public override bool contains(java.nio.charset.Charset arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset_._contains22743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset_.staticClass, global::java.nio.charset.Charset_._contains22743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newDecoder22744;
		public override global::java.nio.charset.CharsetDecoder newDecoder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset_._newDecoder22744)) as java.nio.charset.CharsetDecoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset_.staticClass, global::java.nio.charset.Charset_._newDecoder22744)) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _newEncoder22745;
		public override global::java.nio.charset.CharsetEncoder newEncoder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset_._newEncoder22745)) as java.nio.charset.CharsetEncoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset_.staticClass, global::java.nio.charset.Charset_._newEncoder22745)) as java.nio.charset.CharsetEncoder;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.Charset_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/Charset"));
			global::java.nio.charset.Charset_._contains22743 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset_.staticClass, "contains", "(Ljava/nio/charset/Charset;)Z");
			global::java.nio.charset.Charset_._newDecoder22744 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset_.staticClass, "newDecoder", "()Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.Charset_._newEncoder22745 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset_.staticClass, "newEncoder", "()Ljava/nio/charset/CharsetEncoder;");
		}
	}
}
