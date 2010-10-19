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
		internal static global::MonoJavaBridge.MethodId _write13739;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter._write13739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._write13739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write13740;
		public override void write(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter._write13740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._write13740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write13741;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter._write13741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._write13741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush13742;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter._flush13742);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._flush13742);
		}
		internal static global::MonoJavaBridge.MethodId _close13743;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter._close13743);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._close13743);
		}
		public new global::java.lang.String Encoding
		{
			get
			{
				return getEncoding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEncoding13744;
		public virtual global::java.lang.String getEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.OutputStreamWriter._getEncoding13744)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._getEncoding13744)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _OutputStreamWriter13745;
		public OutputStreamWriter(java.io.OutputStream arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._OutputStreamWriter13745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OutputStreamWriter13746;
		public OutputStreamWriter(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._OutputStreamWriter13746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OutputStreamWriter13747;
		public OutputStreamWriter(java.io.OutputStream arg0, java.nio.charset.Charset arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._OutputStreamWriter13747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OutputStreamWriter13748;
		public OutputStreamWriter(java.io.OutputStream arg0, java.nio.charset.CharsetEncoder arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.OutputStreamWriter.staticClass, global::java.io.OutputStreamWriter._OutputStreamWriter13748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.OutputStreamWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/OutputStreamWriter"));
			global::java.io.OutputStreamWriter._write13739 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "write", "([CII)V");
			global::java.io.OutputStreamWriter._write13740 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.OutputStreamWriter._write13741 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "write", "(I)V");
			global::java.io.OutputStreamWriter._flush13742 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "flush", "()V");
			global::java.io.OutputStreamWriter._close13743 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "close", "()V");
			global::java.io.OutputStreamWriter._getEncoding13744 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "getEncoding", "()Ljava/lang/String;");
			global::java.io.OutputStreamWriter._OutputStreamWriter13745 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::java.io.OutputStreamWriter._OutputStreamWriter13746 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::java.io.OutputStreamWriter._OutputStreamWriter13747 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/nio/charset/Charset;)V");
			global::java.io.OutputStreamWriter._OutputStreamWriter13748 = @__env.GetMethodIDNoThrow(global::java.io.OutputStreamWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/nio/charset/CharsetEncoder;)V");
		}
	}
}
