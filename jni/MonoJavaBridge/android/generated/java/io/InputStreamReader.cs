namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InputStreamReader : java.io.Reader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputStreamReader()
		{
			InitJNI();
		}
		protected InputStreamReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close13512;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.InputStreamReader._close13512);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._close13512);
		}
		internal static global::MonoJavaBridge.MethodId _read13513;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.InputStreamReader._read13513);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._read13513);
		}
		internal static global::MonoJavaBridge.MethodId _read13514;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.InputStreamReader._read13514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._read13514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.String Encoding
		{
			get
			{
				return getEncoding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEncoding13515;
		public virtual global::java.lang.String getEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.InputStreamReader._getEncoding13515)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._getEncoding13515)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ready13516;
		public override bool ready() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.InputStreamReader._ready13516);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._ready13516);
		}
		internal static global::MonoJavaBridge.MethodId _InputStreamReader13517;
		public InputStreamReader(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._InputStreamReader13517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputStreamReader13518;
		public InputStreamReader(java.io.InputStream arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._InputStreamReader13518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputStreamReader13519;
		public InputStreamReader(java.io.InputStream arg0, java.nio.charset.Charset arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._InputStreamReader13519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputStreamReader13520;
		public InputStreamReader(java.io.InputStream arg0, java.nio.charset.CharsetDecoder arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InputStreamReader.staticClass, global::java.io.InputStreamReader._InputStreamReader13520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InputStreamReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InputStreamReader"));
			global::java.io.InputStreamReader._close13512 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "close", "()V");
			global::java.io.InputStreamReader._read13513 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "read", "()I");
			global::java.io.InputStreamReader._read13514 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "read", "([CII)I");
			global::java.io.InputStreamReader._getEncoding13515 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "getEncoding", "()Ljava/lang/String;");
			global::java.io.InputStreamReader._ready13516 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "ready", "()Z");
			global::java.io.InputStreamReader._InputStreamReader13517 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::java.io.InputStreamReader._InputStreamReader13518 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::java.io.InputStreamReader._InputStreamReader13519 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/nio/charset/Charset;)V");
			global::java.io.InputStreamReader._InputStreamReader13520 = @__env.GetMethodIDNoThrow(global::java.io.InputStreamReader.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/nio/charset/CharsetDecoder;)V");
		}
	}
}
