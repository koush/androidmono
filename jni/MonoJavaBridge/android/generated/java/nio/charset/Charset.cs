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
		internal static global::MonoJavaBridge.MethodId _name17005;
		public virtual global::java.lang.String name() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._name17005)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._name17005)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _forName17006;
		public static global::java.nio.charset.Charset forName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._forName17006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _equals17007;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset._equals17007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._equals17007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString17008;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._toString17008)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._toString17008)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode17009;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.charset.Charset._hashCode17009);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._hashCode17009);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo17010;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.charset.Charset._compareTo17010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._compareTo17010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo17011;
		public virtual int compareTo(java.nio.charset.Charset arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.charset.Charset._compareTo17011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._compareTo17011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains17012;
		public abstract bool contains(java.nio.charset.Charset arg0);
		internal static global::MonoJavaBridge.MethodId _decode17013;
		public virtual global::java.nio.CharBuffer decode(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._decode17013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._decode17013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _encode17014;
		public virtual global::java.nio.ByteBuffer encode(java.nio.CharBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._encode17014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._encode17014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _encode17015;
		public virtual global::java.nio.ByteBuffer encode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._encode17015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._encode17015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isSupported17016;
		public static bool isSupported(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._isSupported17016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _defaultCharset17017;
		public static global::java.nio.charset.Charset defaultCharset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._defaultCharset17017)) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _aliases17018;
		public virtual global::java.util.Set aliases() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._aliases17018)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._aliases17018)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _availableCharsets17019;
		public static global::java.util.SortedMap availableCharsets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._availableCharsets17019)) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _displayName17020;
		public virtual global::java.lang.String displayName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._displayName17020)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._displayName17020)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _displayName17021;
		public virtual global::java.lang.String displayName(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset._displayName17021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._displayName17021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isRegistered17022;
		public virtual bool isRegistered() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset._isRegistered17022);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._isRegistered17022);
		}
		internal static global::MonoJavaBridge.MethodId _newDecoder17023;
		public abstract global::java.nio.charset.CharsetDecoder newDecoder();
		internal static global::MonoJavaBridge.MethodId _newEncoder17024;
		public abstract global::java.nio.charset.CharsetEncoder newEncoder();
		internal static global::MonoJavaBridge.MethodId _canEncode17025;
		public virtual bool canEncode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset._canEncode17025);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._canEncode17025);
		}
		internal static global::MonoJavaBridge.MethodId _Charset17026;
		protected Charset(java.lang.String arg0, java.lang.String[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._Charset17026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.Charset.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/Charset"));
			global::java.nio.charset.Charset._name17005 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "name", "()Ljava/lang/String;");
			global::java.nio.charset.Charset._forName17006 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "forName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;");
			global::java.nio.charset.Charset._equals17007 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.nio.charset.Charset._toString17008 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.charset.Charset._hashCode17009 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "hashCode", "()I");
			global::java.nio.charset.Charset._compareTo17010 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.nio.charset.Charset._compareTo17011 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/nio/charset/Charset;)I");
			global::java.nio.charset.Charset._contains17012 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "contains", "(Ljava/nio/charset/Charset;)Z");
			global::java.nio.charset.Charset._decode17013 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;");
			global::java.nio.charset.Charset._encode17014 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;");
			global::java.nio.charset.Charset._encode17015 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/lang/String;)Ljava/nio/ByteBuffer;");
			global::java.nio.charset.Charset._isSupported17016 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "isSupported", "(Ljava/lang/String;)Z");
			global::java.nio.charset.Charset._defaultCharset17017 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "defaultCharset", "()Ljava/nio/charset/Charset;");
			global::java.nio.charset.Charset._aliases17018 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "aliases", "()Ljava/util/Set;");
			global::java.nio.charset.Charset._availableCharsets17019 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "availableCharsets", "()Ljava/util/SortedMap;");
			global::java.nio.charset.Charset._displayName17020 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "displayName", "()Ljava/lang/String;");
			global::java.nio.charset.Charset._displayName17021 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "displayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.nio.charset.Charset._isRegistered17022 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "isRegistered", "()Z");
			global::java.nio.charset.Charset._newDecoder17023 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "newDecoder", "()Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.Charset._newEncoder17024 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "newEncoder", "()Ljava/nio/charset/CharsetEncoder;");
			global::java.nio.charset.Charset._canEncode17025 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "canEncode", "()Z");
			global::java.nio.charset.Charset._Charset17026 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "<init>", "(Ljava/lang/String;[Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.charset.Charset))]
	public sealed partial class Charset_ : java.nio.charset.Charset
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Charset_()
		{
			InitJNI();
		}
		internal Charset_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _contains17027;
		public override bool contains(java.nio.charset.Charset arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset_._contains17027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset_.staticClass, global::java.nio.charset.Charset_._contains17027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newDecoder17028;
		public override global::java.nio.charset.CharsetDecoder newDecoder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset_._newDecoder17028)) as java.nio.charset.CharsetDecoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset_.staticClass, global::java.nio.charset.Charset_._newDecoder17028)) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _newEncoder17029;
		public override global::java.nio.charset.CharsetEncoder newEncoder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset_._newEncoder17029)) as java.nio.charset.CharsetEncoder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.Charset_.staticClass, global::java.nio.charset.Charset_._newEncoder17029)) as java.nio.charset.CharsetEncoder;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.Charset_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/Charset"));
			global::java.nio.charset.Charset_._contains17027 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset_.staticClass, "contains", "(Ljava/nio/charset/Charset;)Z");
			global::java.nio.charset.Charset_._newDecoder17028 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset_.staticClass, "newDecoder", "()Ljava/nio/charset/CharsetDecoder;");
			global::java.nio.charset.Charset_._newEncoder17029 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset_.staticClass, "newEncoder", "()Ljava/nio/charset/CharsetEncoder;");
		}
	}
}
