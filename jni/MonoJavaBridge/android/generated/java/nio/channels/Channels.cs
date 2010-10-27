namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Channels : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Channels()
		{
			InitJNI();
		}
		internal Channels(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInputStream22408;
		public static global::java.io.InputStream newInputStream(java.nio.channels.ReadableByteChannel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newInputStream22408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _newOutputStream22409;
		public static global::java.io.OutputStream newOutputStream(java.nio.channels.WritableByteChannel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newOutputStream22409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _newChannel22410;
		public static global::java.nio.channels.ReadableByteChannel newChannel(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.nio.channels.ReadableByteChannel>(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newChannel22410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.ReadableByteChannel;
		}
		internal static global::MonoJavaBridge.MethodId _newChannel22411;
		public static global::java.nio.channels.WritableByteChannel newChannel(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.nio.channels.WritableByteChannel>(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newChannel22411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.WritableByteChannel;
		}
		internal static global::MonoJavaBridge.MethodId _newReader22412;
		public static global::java.io.Reader newReader(java.nio.channels.ReadableByteChannel arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newReader22412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _newReader22413;
		public static global::java.io.Reader newReader(java.nio.channels.ReadableByteChannel arg0, java.nio.charset.CharsetDecoder arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newReader22413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _newWriter22414;
		public static global::java.io.Writer newWriter(java.nio.channels.WritableByteChannel arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newWriter22414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.Writer;
		}
		internal static global::MonoJavaBridge.MethodId _newWriter22415;
		public static global::java.io.Writer newWriter(java.nio.channels.WritableByteChannel arg0, java.nio.charset.CharsetEncoder arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newWriter22415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.Writer;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Channels.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Channels"));
			global::java.nio.channels.Channels._newInputStream22408 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newInputStream", "(Ljava/nio/channels/ReadableByteChannel;)Ljava/io/InputStream;");
			global::java.nio.channels.Channels._newOutputStream22409 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newOutputStream", "(Ljava/nio/channels/WritableByteChannel;)Ljava/io/OutputStream;");
			global::java.nio.channels.Channels._newChannel22410 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newChannel", "(Ljava/io/InputStream;)Ljava/nio/channels/ReadableByteChannel;");
			global::java.nio.channels.Channels._newChannel22411 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newChannel", "(Ljava/io/OutputStream;)Ljava/nio/channels/WritableByteChannel;");
			global::java.nio.channels.Channels._newReader22412 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newReader", "(Ljava/nio/channels/ReadableByteChannel;Ljava/lang/String;)Ljava/io/Reader;");
			global::java.nio.channels.Channels._newReader22413 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newReader", "(Ljava/nio/channels/ReadableByteChannel;Ljava/nio/charset/CharsetDecoder;I)Ljava/io/Reader;");
			global::java.nio.channels.Channels._newWriter22414 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newWriter", "(Ljava/nio/channels/WritableByteChannel;Ljava/lang/String;)Ljava/io/Writer;");
			global::java.nio.channels.Channels._newWriter22415 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newWriter", "(Ljava/nio/channels/WritableByteChannel;Ljava/nio/charset/CharsetEncoder;I)Ljava/io/Writer;");
		}
	}
}
