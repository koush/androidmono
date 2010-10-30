namespace java.nio.charset.spi
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.charset.spi.CharsetProvider_))]
	public abstract partial class CharsetProvider : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CharsetProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _charsetForName22823;
		public abstract global::java.nio.charset.Charset charsetForName(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _charsets22824;
		public abstract global::java.util.Iterator charsets();
		internal static global::MonoJavaBridge.MethodId _CharsetProvider22825;
		protected CharsetProvider() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.spi.CharsetProvider._CharsetProvider22825.native == global::System.IntPtr.Zero)
				global::java.nio.charset.spi.CharsetProvider._CharsetProvider22825 = @__env.GetMethodIDNoThrow(global::java.nio.charset.spi.CharsetProvider.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.spi.CharsetProvider.staticClass, global::java.nio.charset.spi.CharsetProvider._CharsetProvider22825);
			Init(@__env, handle);
		}
		static CharsetProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.spi.CharsetProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/spi/CharsetProvider"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.charset.spi.CharsetProvider))]
	internal sealed partial class CharsetProvider_ : java.nio.charset.spi.CharsetProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CharsetProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _charsetForName22826;
		public override global::java.nio.charset.Charset charsetForName(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.charset.spi.CharsetProvider_.staticClass, "charsetForName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;", ref global::java.nio.charset.spi.CharsetProvider_._charsetForName22826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _charsets22827;
		public override global::java.util.Iterator charsets()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.nio.charset.spi.CharsetProvider_.staticClass, "charsets", "()Ljava/util/Iterator;", ref global::java.nio.charset.spi.CharsetProvider_._charsets22827) as java.util.Iterator;
		}
		static CharsetProvider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.spi.CharsetProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/spi/CharsetProvider"));
		}
		internal static void InitJNI()
		{
		}
	}
}
