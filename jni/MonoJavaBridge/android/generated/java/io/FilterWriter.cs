namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.FilterWriter_))]
	public abstract partial class FilterWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FilterWriter()
		{
			InitJNI();
		}
		protected FilterWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write18965;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterWriter._write18965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterWriter.staticClass, global::java.io.FilterWriter._write18965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write18966;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterWriter._write18966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterWriter.staticClass, global::java.io.FilterWriter._write18966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write18967;
		public override void write(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterWriter._write18967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterWriter.staticClass, global::java.io.FilterWriter._write18967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush18968;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterWriter._flush18968);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterWriter.staticClass, global::java.io.FilterWriter._flush18968);
		}
		internal static global::MonoJavaBridge.MethodId _close18969;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.FilterWriter._close18969);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.FilterWriter.staticClass, global::java.io.FilterWriter._close18969);
		}
		internal static global::MonoJavaBridge.MethodId _FilterWriter18970;
		protected FilterWriter(java.io.Writer arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.FilterWriter.staticClass, global::java.io.FilterWriter._FilterWriter18970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterWriter"));
			global::java.io.FilterWriter._write18965 = @__env.GetMethodIDNoThrow(global::java.io.FilterWriter.staticClass, "write", "(I)V");
			global::java.io.FilterWriter._write18966 = @__env.GetMethodIDNoThrow(global::java.io.FilterWriter.staticClass, "write", "([CII)V");
			global::java.io.FilterWriter._write18967 = @__env.GetMethodIDNoThrow(global::java.io.FilterWriter.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.FilterWriter._flush18968 = @__env.GetMethodIDNoThrow(global::java.io.FilterWriter.staticClass, "flush", "()V");
			global::java.io.FilterWriter._close18969 = @__env.GetMethodIDNoThrow(global::java.io.FilterWriter.staticClass, "close", "()V");
			global::java.io.FilterWriter._FilterWriter18970 = @__env.GetMethodIDNoThrow(global::java.io.FilterWriter.staticClass, "<init>", "(Ljava/io/Writer;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.FilterWriter))]
	public sealed partial class FilterWriter_ : java.io.FilterWriter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FilterWriter_()
		{
			InitJNI();
		}
		internal FilterWriter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.FilterWriter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/FilterWriter"));
		}
	}
}
