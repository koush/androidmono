namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InputStreamReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InputStreamReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.InputStreamReader.staticClass, "close", "()V", ref global::java.io.InputStreamReader._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.InputStreamReader.staticClass, "read", "()I", ref global::java.io.InputStreamReader._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.InputStreamReader.staticClass, "read", "([CII)I", ref global::java.io.InputStreamReader._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.String Encoding
		{
			get
			{
				return getEncoding();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.InputStreamReader.staticClass, "getEncoding", "()Ljava/lang/String;", ref global::java.io.InputStreamReader._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool ready()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.InputStreamReader.staticClass, "ready", "()Z", ref global::java.io.InputStreamReader._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public InputStreamReader(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InputStreamReader._m5.native == global::System.IntPtr.Zero)
				global::java.io.InputStreamReader._m5 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public InputStreamReader(java.io.InputStream arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InputStreamReader._m6.native == global::System.IntPtr.Zero)
				global::java.io.InputStreamReader._m6 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public InputStreamReader(java.io.InputStream arg0, java.nio.charset.Charset arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InputStreamReader._m7.native == global::System.IntPtr.Zero)
				global::java.io.InputStreamReader._m7 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public InputStreamReader(java.io.InputStream arg0, java.nio.charset.CharsetDecoder arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InputStreamReader._m8.native == global::System.IntPtr.Zero)
				global::java.io.InputStreamReader._m8 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/nio/charset/CharsetDecoder;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static InputStreamReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InputStreamReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InputStreamReader"));
		}
	}
}
