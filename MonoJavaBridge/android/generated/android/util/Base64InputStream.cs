namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Base64InputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Base64InputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.Base64InputStream.staticClass, "close", "()V", ref global::android.util.Base64InputStream._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void mark(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.Base64InputStream.staticClass, "mark", "(I)V", ref global::android.util.Base64InputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.Base64InputStream.staticClass, "reset", "()V", ref global::android.util.Base64InputStream._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.Base64InputStream.staticClass, "read", "()I", ref global::android.util.Base64InputStream._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.Base64InputStream.staticClass, "read", "([BII)I", ref global::android.util.Base64InputStream._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override long skip(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.util.Base64InputStream.staticClass, "skip", "(J)J", ref global::android.util.Base64InputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int available()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.Base64InputStream.staticClass, "available", "()I", ref global::android.util.Base64InputStream._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool markSupported()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.util.Base64InputStream.staticClass, "markSupported", "()Z", ref global::android.util.Base64InputStream._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public Base64InputStream(java.io.InputStream arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Base64InputStream._m8.native == global::System.IntPtr.Zero)
				global::android.util.Base64InputStream._m8 = @__env.GetMethodIDNoThrow(global::android.util.Base64InputStream.staticClass, "<init>", "(Ljava/io/InputStream;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Base64InputStream.staticClass, global::android.util.Base64InputStream._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
