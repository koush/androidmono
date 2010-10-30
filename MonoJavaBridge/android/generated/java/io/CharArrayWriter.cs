namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CharArrayWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CharArrayWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString18866;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._toString18866)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append18867;
		public virtual global::java.io.CharArrayWriter append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._append18867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.CharArrayWriter;
		}
		public java.io.CharArrayWriter append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append18868;
		public virtual global::java.io.CharArrayWriter append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._append18868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.CharArrayWriter;
		}
		public java.io.CharArrayWriter append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append18869;
		public virtual global::java.io.CharArrayWriter append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._append18869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.CharArrayWriter;
		}
		internal static global::MonoJavaBridge.MethodId _toCharArray18870;
		public virtual char[] toCharArray()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._toCharArray18870)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _size18871;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._size18871);
		}
		internal static global::MonoJavaBridge.MethodId _write18872;
		public override void write(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._write18872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write18873;
		public override void write(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._write18873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write18874;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._write18874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush18875;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._flush18875);
		}
		internal static global::MonoJavaBridge.MethodId _close18876;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._close18876);
		}
		internal static global::MonoJavaBridge.MethodId _reset18877;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._reset18877);
		}
		internal static global::MonoJavaBridge.MethodId _writeTo18878;
		public virtual void writeTo(java.io.Writer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._writeTo18878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayWriter18879;
		public CharArrayWriter(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._CharArrayWriter18879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayWriter18880;
		public CharArrayWriter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._CharArrayWriter18880);
			Init(@__env, handle);
		}
		static CharArrayWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.CharArrayWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/CharArrayWriter"));
			global::java.io.CharArrayWriter._toString18866 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "toString", "()Ljava/lang/String;");
			global::java.io.CharArrayWriter._append18867 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/io/CharArrayWriter;");
			global::java.io.CharArrayWriter._append18868 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/io/CharArrayWriter;");
			global::java.io.CharArrayWriter._append18869 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "append", "(C)Ljava/io/CharArrayWriter;");
			global::java.io.CharArrayWriter._toCharArray18870 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "toCharArray", "()[C");
			global::java.io.CharArrayWriter._size18871 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "size", "()I");
			global::java.io.CharArrayWriter._write18872 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "write", "([CII)V");
			global::java.io.CharArrayWriter._write18873 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.CharArrayWriter._write18874 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "write", "(I)V");
			global::java.io.CharArrayWriter._flush18875 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "flush", "()V");
			global::java.io.CharArrayWriter._close18876 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "close", "()V");
			global::java.io.CharArrayWriter._reset18877 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "reset", "()V");
			global::java.io.CharArrayWriter._writeTo18878 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "writeTo", "(Ljava/io/Writer;)V");
			global::java.io.CharArrayWriter._CharArrayWriter18879 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "<init>", "(I)V");
			global::java.io.CharArrayWriter._CharArrayWriter18880 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
