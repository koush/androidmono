namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.charset.Charset_))]
	public abstract partial class Charset : java.lang.Object, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Charset(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String name()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.Charset.staticClass, "name", "()Ljava/lang/String;", ref global::java.nio.charset.Charset._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.nio.charset.Charset forName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._m1.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._m1 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "forName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.Charset;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.Charset.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.nio.charset.Charset._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.Charset.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.charset.Charset._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.charset.Charset.staticClass, "hashCode", "()I", ref global::java.nio.charset.Charset._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.nio.charset.Charset._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int compareTo(java.nio.charset.Charset arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.charset.Charset.staticClass, "compareTo", "(Ljava/nio/charset/Charset;)I", ref global::java.nio.charset.Charset._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract bool contains(java.nio.charset.Charset arg0);
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.nio.CharBuffer decode(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.Charset.staticClass, "decode", "(Ljava/nio/ByteBuffer;)Ljava/nio/CharBuffer;", ref global::java.nio.charset.Charset._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.CharBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.nio.ByteBuffer encode(java.nio.CharBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/nio/CharBuffer;)Ljava/nio/ByteBuffer;", ref global::java.nio.charset.Charset._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.nio.ByteBuffer encode(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.Charset.staticClass, "encode", "(Ljava/lang/String;)Ljava/nio/ByteBuffer;", ref global::java.nio.charset.Charset._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.ByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static bool isSupported(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._m11.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._m11 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "isSupported", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::java.nio.charset.Charset defaultCharset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._m12.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._m12 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "defaultCharset", "()Ljava/nio/charset/Charset;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._m12)) as java.nio.charset.Charset;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.util.Set aliases()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.nio.charset.Charset.staticClass, "aliases", "()Ljava/util/Set;", ref global::java.nio.charset.Charset._m13) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::java.util.SortedMap availableCharsets()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._m14.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._m14 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "availableCharsets", "()Ljava/util/SortedMap;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._m14)) as java.util.SortedMap;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.lang.String displayName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.Charset.staticClass, "displayName", "()Ljava/lang/String;", ref global::java.nio.charset.Charset._m15) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.lang.String displayName(java.util.Locale arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.Charset.staticClass, "displayName", "(Ljava/util/Locale;)Ljava/lang/String;", ref global::java.nio.charset.Charset._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool isRegistered()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.Charset.staticClass, "isRegistered", "()Z", ref global::java.nio.charset.Charset._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract global::java.nio.charset.CharsetDecoder newDecoder();
		private static global::MonoJavaBridge.MethodId _m19;
		public abstract global::java.nio.charset.CharsetEncoder newEncoder();
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool canEncode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.Charset.staticClass, "canEncode", "()Z", ref global::java.nio.charset.Charset._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		protected Charset(java.lang.String arg0, java.lang.String[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.Charset._m21.native == global::System.IntPtr.Zero)
				global::java.nio.charset.Charset._m21 = @__env.GetMethodIDNoThrow(global::java.nio.charset.Charset.staticClass, "<init>", "(Ljava/lang/String;[Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.Charset.staticClass, global::java.nio.charset.Charset._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Charset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.Charset.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/Charset"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.charset.Charset))]
	internal sealed partial class Charset_ : java.nio.charset.Charset
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Charset_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool contains(java.nio.charset.Charset arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.Charset_.staticClass, "contains", "(Ljava/nio/charset/Charset;)Z", ref global::java.nio.charset.Charset_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.nio.charset.CharsetDecoder newDecoder()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.Charset_.staticClass, "newDecoder", "()Ljava/nio/charset/CharsetDecoder;", ref global::java.nio.charset.Charset_._m1) as java.nio.charset.CharsetDecoder;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.nio.charset.CharsetEncoder newEncoder()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.Charset_.staticClass, "newEncoder", "()Ljava/nio/charset/CharsetEncoder;", ref global::java.nio.charset.Charset_._m2) as java.nio.charset.CharsetEncoder;
		}
		static Charset_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.Charset_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/Charset"));
		}
	}
}
