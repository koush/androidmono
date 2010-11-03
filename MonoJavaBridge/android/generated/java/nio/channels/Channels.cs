namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Channels : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Channels(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.io.InputStream newInputStream(java.nio.channels.ReadableByteChannel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Channels._m0.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Channels._m0 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newInputStream", "(Ljava/nio/channels/ReadableByteChannel;)Ljava/io/InputStream;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.io.OutputStream newOutputStream(java.nio.channels.WritableByteChannel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Channels._m1.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Channels._m1 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newOutputStream", "(Ljava/nio/channels/WritableByteChannel;)Ljava/io/OutputStream;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.nio.channels.ReadableByteChannel newChannel(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Channels._m2.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Channels._m2 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newChannel", "(Ljava/io/InputStream;)Ljava/nio/channels/ReadableByteChannel;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.nio.channels.ReadableByteChannel>(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.ReadableByteChannel;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.nio.channels.WritableByteChannel newChannel(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Channels._m3.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Channels._m3 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newChannel", "(Ljava/io/OutputStream;)Ljava/nio/channels/WritableByteChannel;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.nio.channels.WritableByteChannel>(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.WritableByteChannel;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.io.Reader newReader(java.nio.channels.ReadableByteChannel arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Channels._m4.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Channels._m4 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newReader", "(Ljava/nio/channels/ReadableByteChannel;Ljava/lang/String;)Ljava/io/Reader;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.io.Reader newReader(java.nio.channels.ReadableByteChannel arg0, java.nio.charset.CharsetDecoder arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Channels._m5.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Channels._m5 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newReader", "(Ljava/nio/channels/ReadableByteChannel;Ljava/nio/charset/CharsetDecoder;I)Ljava/io/Reader;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.io.Writer newWriter(java.nio.channels.WritableByteChannel arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Channels._m6.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Channels._m6 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newWriter", "(Ljava/nio/channels/WritableByteChannel;Ljava/lang/String;)Ljava/io/Writer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.Writer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.io.Writer newWriter(java.nio.channels.WritableByteChannel arg0, java.nio.charset.CharsetEncoder arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Channels._m7.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Channels._m7 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newWriter", "(Ljava/nio/channels/WritableByteChannel;Ljava/nio/charset/CharsetEncoder;I)Ljava/io/Writer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.Writer;
		}
		static Channels()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Channels.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Channels"));
		}
	}
}
