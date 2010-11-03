namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CharArrayWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CharArrayWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.CharArrayWriter.staticClass, "toString", "()Ljava/lang/String;", ref global::java.io.CharArrayWriter._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.io.CharArrayWriter append(java.lang.CharSequence arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.CharArrayWriter.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/io/CharArrayWriter;", ref global::java.io.CharArrayWriter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.CharArrayWriter;
		}
		public java.io.CharArrayWriter append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.io.CharArrayWriter append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.CharArrayWriter.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/io/CharArrayWriter;", ref global::java.io.CharArrayWriter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.io.CharArrayWriter;
		}
		public java.io.CharArrayWriter append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.io.CharArrayWriter append(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.CharArrayWriter.staticClass, "append", "(C)Ljava/io/CharArrayWriter;", ref global::java.io.CharArrayWriter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.CharArrayWriter;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual char[] toCharArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::java.io.CharArrayWriter.staticClass, "toCharArray", "()[C", ref global::java.io.CharArrayWriter._m4) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.io.CharArrayWriter.staticClass, "size", "()I", ref global::java.io.CharArrayWriter._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void write(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayWriter.staticClass, "write", "([CII)V", ref global::java.io.CharArrayWriter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void write(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayWriter.staticClass, "write", "(Ljava/lang/String;II)V", ref global::java.io.CharArrayWriter._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayWriter.staticClass, "write", "(I)V", ref global::java.io.CharArrayWriter._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayWriter.staticClass, "flush", "()V", ref global::java.io.CharArrayWriter._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayWriter.staticClass, "close", "()V", ref global::java.io.CharArrayWriter._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayWriter.staticClass, "reset", "()V", ref global::java.io.CharArrayWriter._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void writeTo(java.io.Writer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.io.CharArrayWriter.staticClass, "writeTo", "(Ljava/io/Writer;)V", ref global::java.io.CharArrayWriter._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public CharArrayWriter(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.CharArrayWriter._m13.native == global::System.IntPtr.Zero)
				global::java.io.CharArrayWriter._m13 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public CharArrayWriter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.CharArrayWriter._m14.native == global::System.IntPtr.Zero)
				global::java.io.CharArrayWriter._m14 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._m14);
			Init(@__env, handle);
		}
		static CharArrayWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.CharArrayWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/CharArrayWriter"));
		}
	}
}
