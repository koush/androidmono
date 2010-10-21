namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CharArrayWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharArrayWriter()
		{
			InitJNI();
		}
		protected CharArrayWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString18748;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter._toString18748)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._toString18748)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append18749;
		public virtual global::java.io.CharArrayWriter append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter._append18749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.CharArrayWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._append18749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.CharArrayWriter;
		}
		public java.io.CharArrayWriter append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append18750;
		public virtual global::java.io.CharArrayWriter append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter._append18750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.CharArrayWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._append18750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.CharArrayWriter;
		}
		public java.io.CharArrayWriter append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append18751;
		public virtual global::java.io.CharArrayWriter append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter._append18751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.CharArrayWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._append18751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.CharArrayWriter;
		}
		internal static global::MonoJavaBridge.MethodId _toCharArray18752;
		public virtual char[] toCharArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter._toCharArray18752)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._toCharArray18752)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _size18753;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.CharArrayWriter._size18753);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._size18753);
		}
		internal static global::MonoJavaBridge.MethodId _write18754;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter._write18754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._write18754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write18755;
		public override void write(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter._write18755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._write18755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write18756;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter._write18756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._write18756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush18757;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter._flush18757);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._flush18757);
		}
		internal static global::MonoJavaBridge.MethodId _close18758;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter._close18758);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._close18758);
		}
		internal static global::MonoJavaBridge.MethodId _reset18759;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter._reset18759);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._reset18759);
		}
		internal static global::MonoJavaBridge.MethodId _writeTo18760;
		public virtual void writeTo(java.io.Writer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter._writeTo18760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._writeTo18760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayWriter18761;
		public CharArrayWriter(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._CharArrayWriter18761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayWriter18762;
		public CharArrayWriter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._CharArrayWriter18762);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.CharArrayWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/CharArrayWriter"));
			global::java.io.CharArrayWriter._toString18748 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "toString", "()Ljava/lang/String;");
			global::java.io.CharArrayWriter._append18749 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/io/CharArrayWriter;");
			global::java.io.CharArrayWriter._append18750 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/io/CharArrayWriter;");
			global::java.io.CharArrayWriter._append18751 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "append", "(C)Ljava/io/CharArrayWriter;");
			global::java.io.CharArrayWriter._toCharArray18752 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "toCharArray", "()[C");
			global::java.io.CharArrayWriter._size18753 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "size", "()I");
			global::java.io.CharArrayWriter._write18754 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "write", "([CII)V");
			global::java.io.CharArrayWriter._write18755 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.CharArrayWriter._write18756 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "write", "(I)V");
			global::java.io.CharArrayWriter._flush18757 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "flush", "()V");
			global::java.io.CharArrayWriter._close18758 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "close", "()V");
			global::java.io.CharArrayWriter._reset18759 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "reset", "()V");
			global::java.io.CharArrayWriter._writeTo18760 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "writeTo", "(Ljava/io/Writer;)V");
			global::java.io.CharArrayWriter._CharArrayWriter18761 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "<init>", "(I)V");
			global::java.io.CharArrayWriter._CharArrayWriter18762 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "<init>", "()V");
		}
	}
}
