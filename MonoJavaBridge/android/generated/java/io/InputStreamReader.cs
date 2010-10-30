namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InputStreamReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InputStreamReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19105;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._close19105);
		}
		internal static global::MonoJavaBridge.MethodId _read19106;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._read19106);
		}
		internal static global::MonoJavaBridge.MethodId _read19107;
		public override int read(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._read19107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.String Encoding
		{
			get
			{
				return getEncoding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEncoding19108;
		public virtual global::java.lang.String getEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._getEncoding19108)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ready19109;
		public override bool ready()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._ready19109);
		}
		internal static global::MonoJavaBridge.MethodId _InputStreamReader19110;
		public InputStreamReader(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._InputStreamReader19110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputStreamReader19111;
		public InputStreamReader(java.io.InputStream arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._InputStreamReader19111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputStreamReader19112;
		public InputStreamReader(java.io.InputStream arg0, java.nio.charset.Charset arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._InputStreamReader19112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputStreamReader19113;
		public InputStreamReader(java.io.InputStream arg0, java.nio.charset.CharsetDecoder arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._InputStreamReader19113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static InputStreamReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InputStreamReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InputStreamReader"));
			global::java.io.InputStreamReader._close19105 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "close", "()V");
			global::java.io.InputStreamReader._read19106 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "read", "()I");
			global::java.io.InputStreamReader._read19107 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "read", "([CII)I");
			global::java.io.InputStreamReader._getEncoding19108 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "getEncoding", "()Ljava/lang/String;");
			global::java.io.InputStreamReader._ready19109 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "ready", "()Z");
			global::java.io.InputStreamReader._InputStreamReader19110 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::java.io.InputStreamReader._InputStreamReader19111 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::java.io.InputStreamReader._InputStreamReader19112 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V");
			global::java.io.InputStreamReader._InputStreamReader19113 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/nio/charset/CharsetDecoder;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
