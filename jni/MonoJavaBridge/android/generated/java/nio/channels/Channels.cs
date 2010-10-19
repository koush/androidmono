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
		internal static global::MonoJavaBridge.MethodId _newInputStream16696;
		public static global::java.io.InputStream newInputStream(java.nio.channels.ReadableByteChannel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newInputStream16696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _newOutputStream16697;
		public static global::java.io.OutputStream newOutputStream(java.nio.channels.WritableByteChannel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newOutputStream16697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _newChannel16698;
		public static global::java.nio.channels.ReadableByteChannel newChannel(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.nio.channels.ReadableByteChannel>(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newChannel16698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.ReadableByteChannel;
		}
		internal static global::MonoJavaBridge.MethodId _newChannel16699;
		public static global::java.nio.channels.WritableByteChannel newChannel(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.nio.channels.WritableByteChannel>(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newChannel16699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.WritableByteChannel;
		}
		internal static global::MonoJavaBridge.MethodId _newReader16700;
		public static global::java.io.Reader newReader(java.nio.channels.ReadableByteChannel arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newReader16700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _newReader16701;
		public static global::java.io.Reader newReader(java.nio.channels.ReadableByteChannel arg0, java.nio.charset.CharsetDecoder arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newReader16701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _newWriter16702;
		public static global::java.io.Writer newWriter(java.nio.channels.WritableByteChannel arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newWriter16702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.Writer;
		}
		internal static global::MonoJavaBridge.MethodId _newWriter16703;
		public static global::java.io.Writer newWriter(java.nio.channels.WritableByteChannel arg0, java.nio.charset.CharsetEncoder arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Channels.staticClass, global::java.nio.channels.Channels._newWriter16703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.Writer;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Channels.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Channels"));
			global::java.nio.channels.Channels._newInputStream16696 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newInputStream", "(Ljava/nio/channels/ReadableByteChannel;)Ljava/io/InputStream;");
			global::java.nio.channels.Channels._newOutputStream16697 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newOutputStream", "(Ljava/nio/channels/WritableByteChannel;)Ljava/io/OutputStream;");
			global::java.nio.channels.Channels._newChannel16698 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newChannel", "(Ljava/io/InputStream;)Ljava/nio/channels/ReadableByteChannel;");
			global::java.nio.channels.Channels._newChannel16699 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newChannel", "(Ljava/io/OutputStream;)Ljava/nio/channels/WritableByteChannel;");
			global::java.nio.channels.Channels._newReader16700 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newReader", "(Ljava/nio/channels/ReadableByteChannel;Ljava/lang/String;)Ljava/io/Reader;");
			global::java.nio.channels.Channels._newReader16701 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newReader", "(Ljava/nio/channels/ReadableByteChannel;Ljava/nio/charset/CharsetDecoder;I)Ljava/io/Reader;");
			global::java.nio.channels.Channels._newWriter16702 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newWriter", "(Ljava/nio/channels/WritableByteChannel;Ljava/lang/String;)Ljava/io/Writer;");
			global::java.nio.channels.Channels._newWriter16703 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Channels.staticClass, "newWriter", "(Ljava/nio/channels/WritableByteChannel;Ljava/nio/charset/CharsetEncoder;I)Ljava/io/Writer;");
		}
	}
}
