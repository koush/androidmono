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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._name22722.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._name22722 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "name", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._name22722) as java.lang.String;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._equals22724.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._equals22724 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._equals22724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString22725;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._toString22725.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._toString22725 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._toString22725) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22726;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._hashCode22726.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._hashCode22726 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._hashCode22726);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22727;
		public virtual int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._compareTo22727.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._compareTo22727 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._compareTo22727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo22728;
		public virtual int compareTo(java.nio.charset.Charset arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._compareTo22728.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._compareTo22728 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/nio/charset/Charset;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._compareTo22728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _contains22729;
		public abstract bool contains(java.nio.charset.Charset arg0);
		internal static global::MonoJavaBridge.MethodId _decode22730;
		public virtual global::java.nio.CharBuffer decode(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._decode22730.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._decode22730 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._decode22730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.CharBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _encode22731;
		public virtual global::java.nio.ByteBuffer encode(java.nio.CharBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._encode22731.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._encode22731 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._encode22731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _encode22732;
		public virtual global::java.nio.ByteBuffer encode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._encode22732.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._encode22732 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/lang/String;)Ljava/nio/ByteBuffer;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._encode22732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._aliases22735.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._aliases22735 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "aliases", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._aliases22735) as java.util.Set;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._displayName22737.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._displayName22737 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "displayName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._displayName22737) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _displayName22738;
		public virtual global::java.lang.String displayName(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._displayName22738.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._displayName22738 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "displayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._displayName22738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isRegistered22739;
		public virtual bool isRegistered()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._isRegistered22739.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._isRegistered22739 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "isRegistered", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._isRegistered22739);
		}
		internal static global::MonoJavaBridge.MethodId _newDecoder22740;
		public abstract global::java.nio.charset.CharsetDecoder newDecoder();
		internal static global::MonoJavaBridge.MethodId _newEncoder22741;
		public abstract global::java.nio.charset.CharsetEncoder newEncoder();
		internal static global::MonoJavaBridge.MethodId _canEncode22742;
		public virtual bool canEncode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._canEncode22742.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._canEncode22742 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "canEncode", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._canEncode22742);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset_._contains22744.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset_._contains22744 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset_.staticClass, "contains", "(Ljava/nio/charset/Charset;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.Charset_._contains22744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newDecoder22745;
		public override global::java.nio.charset.CharsetDecoder newDecoder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset_._newDecoder22745.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset_._newDecoder22745 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset_.staticClass, "newDecoder", "()Ljava/nio/charset/CharsetDecoder;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset_._newDecoder22745)) as java.nio.charset.CharsetDecoder;
		}
		internal static global::MonoJavaBridge.MethodId _newEncoder22746;
		public override global::java.nio.charset.CharsetEncoder newEncoder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset_._newEncoder22746.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset_._newEncoder22746 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset_.staticClass, "newEncoder", "()Ljava/nio/charset/CharsetEncoder;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.Charset_._newEncoder22746)) as java.nio.charset.CharsetEncoder;
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
