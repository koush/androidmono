namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.charset.Charset_))]
	public abstract partial class Charset : java.lang.Object, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Charset(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _name22722;
		public virtual global::java.lang.String name()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.Charset.staticClass, "name", "()Ljava/lang/String;", ref global::java.nio.charset.Charset._name22722) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _forName22723;
		public static global::java.nio.charset.Charset forName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._forName22723.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._forName22723 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "forName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._forName22723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _equals22724;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.Charset.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.nio.charset.Charset._equals22724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22725;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.Charset.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.charset.Charset._toString22725) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22726;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.charset.Charset.staticClass, "hashCode", "()I", ref global::java.nio.charset.Charset._hashCode22726);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22727;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.nio.charset.Charset._compareTo22727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22728;
		public virtual int compareTo(java.nio.charset.Charset arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/nio/charset/Charset;)I", ref global::java.nio.charset.Charset._compareTo22728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains22729;
		public abstract bool contains(java.nio.charset.Charset arg0);
		internal static global::MonoJavaBridge.MethodId _decode22730;
		public virtual global::java.nio.CharBuffer decode(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.Charset.staticClass, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;", ref global::java.nio.charset.Charset._decode22730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _encode22731;
		public virtual global::java.nio.ByteBuffer encode(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;", ref global::java.nio.charset.Charset._encode22731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _encode22732;
		public virtual global::java.nio.ByteBuffer encode(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/lang/String;)Ljava/nio/ByteBuffer;", ref global::java.nio.charset.Charset._encode22732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _isSupported22733;
		public static bool isSupported(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._isSupported22733.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._isSupported22733 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "isSupported", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._isSupported22733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _defaultCharset22734;
		public static global::java.nio.charset.Charset defaultCharset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._defaultCharset22734.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._defaultCharset22734 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "defaultCharset", "()Ljava/nio/charset/Charset;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._defaultCharset22734)) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _aliases22735;
		public virtual global::java.util.Set aliases()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.nio.charset.Charset.staticClass, "aliases", "()Ljava/util/Set;", ref global::java.nio.charset.Charset._aliases22735) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _availableCharsets22736;
		public static global::java.util.SortedMap availableCharsets()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._availableCharsets22736.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._availableCharsets22736 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "availableCharsets", "()Ljava/util/SortedMap;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._availableCharsets22736)) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _displayName22737;
		public virtual global::java.lang.String displayName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.Charset.staticClass, "displayName", "()Ljava/lang/String;", ref global::java.nio.charset.Charset._displayName22737) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _displayName22738;
		public virtual global::java.lang.String displayName(java.util.Locale arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.Charset.staticClass, "displayName", "(Ljava/util/Locale;)Ljava/lang/String;", ref global::java.nio.charset.Charset._displayName22738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isRegistered22739;
		public virtual bool isRegistered()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.Charset.staticClass, "isRegistered", "()Z", ref global::java.nio.charset.Charset._isRegistered22739);
		}
		internal static global::MonoJavaBridge.MethodId _newDecoder22740;
		public abstract global::java.nio.charset.CharsetDecoder newDecoder();
		internal static global::MonoJavaBridge.MethodId _newEncoder22741;
		public abstract global::java.nio.charset.CharsetEncoder newEncoder();
		internal static global::MonoJavaBridge.MethodId _canEncode22742;
		public virtual bool canEncode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.Charset.staticClass, "canEncode", "()Z", ref global::java.nio.charset.Charset._canEncode22742);
		}
		internal static global::MonoJavaBridge.MethodId _Charset22743;
		protected Charset(java.lang.String arg0, java.lang.String[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._Charset22743.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._Charset22743 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "<init>", "(Ljava/lang/String;[Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._Charset22743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Charset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.Charset.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/Charset"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.charset.Charset))]
	internal sealed partial class Charset_ : java.nio.charset.Charset
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Charset_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _contains22744;
		public override bool contains(java.nio.charset.Charset arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.Charset_.staticClass, "contains", "(Ljava/nio/charset/Charset;)Z", ref global::java.nio.charset.Charset_._contains22744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newDecoder22745;
		public override global::java.nio.charset.CharsetDecoder newDecoder()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.Charset_.staticClass, "newDecoder", "()Ljava/nio/charset/CharsetDecoder;", ref global::java.nio.charset.Charset_._newDecoder22745) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _newEncoder22746;
		public override global::java.nio.charset.CharsetEncoder newEncoder()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.Charset_.staticClass, "newEncoder", "()Ljava/nio/charset/CharsetEncoder;", ref global::java.nio.charset.Charset_._newEncoder22746) as java.nio.charset.CharsetEncoder;
		}
		static Charset_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.Charset_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/Charset"));
		}
		internal static void InitJNI()
		{
		}
	}
}
