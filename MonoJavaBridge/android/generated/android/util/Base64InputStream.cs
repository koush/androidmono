namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Base64InputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Base64InputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close13713;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.Base64InputStream.staticClass, "close", "()V", ref global::android.util.Base64InputStream._close13713);
		}
		internal static global::MonoJavaBridge.MethodId _mark13714;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.Base64InputStream.staticClass, "mark", "(I)V", ref global::android.util.Base64InputStream._mark13714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset13715;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.Base64InputStream.staticClass, "reset", "()V", ref global::android.util.Base64InputStream._reset13715);
		}
		internal static global::MonoJavaBridge.MethodId _read13716;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.Base64InputStream.staticClass, "read", "()I", ref global::android.util.Base64InputStream._read13716);
		}
		internal static global::MonoJavaBridge.MethodId _read13717;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.Base64InputStream.staticClass, "read", "([BII)I", ref global::android.util.Base64InputStream._read13717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip13718;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.util.Base64InputStream.staticClass, "skip", "(J)J", ref global::android.util.Base64InputStream._skip13718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available13719;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.Base64InputStream.staticClass, "available", "()I", ref global::android.util.Base64InputStream._available13719);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported13720;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.util.Base64InputStream.staticClass, "markSupported", "()Z", ref global::android.util.Base64InputStream._markSupported13720);
		}
		internal static global::MonoJavaBridge.MethodId _Base64InputStream13721;
		public Base64InputStream(java.io.InputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64InputStream._Base64InputStream13721.native == global::System.IntPtr.Zero)
				global::android.util.Base64InputStream._Base64InputStream13721 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._Base64InputStream13721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Base64InputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Base64InputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Base64InputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
