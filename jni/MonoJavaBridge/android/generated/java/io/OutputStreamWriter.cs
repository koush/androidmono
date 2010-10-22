namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OutputStreamWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OutputStreamWriter()
		{
			InitJNI();
		}
		protected OutputStreamWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write19241;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter._write19241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._write19241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write19242;
		public override void write(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter._write19242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._write19242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write19243;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter._write19243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._write19243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush19244;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter._flush19244);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._flush19244);
		}
		internal static global::MonoJavaBridge.MethodId _close19245;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter._close19245);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._close19245);
		}
		public new global::java.lang.String Encoding
		{
			get
			{
				return getEncoding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEncoding19246;
		public virtual global::java.lang.String getEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.OutputStreamWriter._getEncoding19246)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._getEncoding19246)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _OutputStreamWriter19247;
		public OutputStreamWriter(java.io.OutputStream arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._OutputStreamWriter19247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OutputStreamWriter19248;
		public OutputStreamWriter(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._OutputStreamWriter19248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OutputStreamWriter19249;
		public OutputStreamWriter(java.io.OutputStream arg0, java.nio.charset.Charset arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._OutputStreamWriter19249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OutputStreamWriter19250;
		public OutputStreamWriter(java.io.OutputStream arg0, java.nio.charset.CharsetEncoder arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._OutputStreamWriter19250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.OutputStreamWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/OutputStreamWriter"));
			global::java.io.OutputStreamWriter._write19241 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "write", "([CII)V");
			global::java.io.OutputStreamWriter._write19242 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.OutputStreamWriter._write19243 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "write", "(I)V");
			global::java.io.OutputStreamWriter._flush19244 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "flush", "()V");
			global::java.io.OutputStreamWriter._close19245 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "close", "()V");
			global::java.io.OutputStreamWriter._getEncoding19246 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "getEncoding", "()Ljava/lang/String;");
			global::java.io.OutputStreamWriter._OutputStreamWriter19247 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::java.io.OutputStreamWriter._OutputStreamWriter19248 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::java.io.OutputStreamWriter._OutputStreamWriter19249 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/nio/charset/Charset;)V");
			global::java.io.OutputStreamWriter._OutputStreamWriter19250 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/nio/charset/CharsetEncoder;)V");
		}
	}
}
