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
		internal static global::MonoJavaBridge.MethodId _toString13277;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter._toString13277)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._toString13277)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append13278;
		public virtual global::java.io.CharArrayWriter append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter._append13278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.CharArrayWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._append13278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.CharArrayWriter;
		}
		public java.io.CharArrayWriter append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append13279;
		public virtual global::java.io.CharArrayWriter append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter._append13279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.CharArrayWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._append13279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.CharArrayWriter;
		}
		public java.io.CharArrayWriter append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append13280;
		public virtual global::java.io.CharArrayWriter append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter._append13280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.CharArrayWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._append13280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.CharArrayWriter;
		}
		internal static global::MonoJavaBridge.MethodId _toCharArray13281;
		public virtual char[] toCharArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter._toCharArray13281)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._toCharArray13281)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _size13282;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.CharArrayWriter._size13282);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._size13282);
		}
		internal static global::MonoJavaBridge.MethodId _write13283;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter._write13283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._write13283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write13284;
		public override void write(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter._write13284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._write13284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write13285;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter._write13285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._write13285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush13286;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter._flush13286);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._flush13286);
		}
		internal static global::MonoJavaBridge.MethodId _close13287;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter._close13287);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._close13287);
		}
		internal static global::MonoJavaBridge.MethodId _reset13288;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter._reset13288);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._reset13288);
		}
		internal static global::MonoJavaBridge.MethodId _writeTo13289;
		public virtual void writeTo(java.io.Writer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter._writeTo13289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._writeTo13289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayWriter13290;
		public CharArrayWriter(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._CharArrayWriter13290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CharArrayWriter13291;
		public CharArrayWriter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharArrayWriter.staticClass, global::java.io.CharArrayWriter._CharArrayWriter13291);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.CharArrayWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/CharArrayWriter"));
			global::java.io.CharArrayWriter._toString13277 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "toString", "()Ljava/lang/String;");
			global::java.io.CharArrayWriter._append13278 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/io/CharArrayWriter;");
			global::java.io.CharArrayWriter._append13279 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/io/CharArrayWriter;");
			global::java.io.CharArrayWriter._append13280 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "append", "(C)Ljava/io/CharArrayWriter;");
			global::java.io.CharArrayWriter._toCharArray13281 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "toCharArray", "()[C");
			global::java.io.CharArrayWriter._size13282 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "size", "()I");
			global::java.io.CharArrayWriter._write13283 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "write", "([CII)V");
			global::java.io.CharArrayWriter._write13284 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.CharArrayWriter._write13285 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "write", "(I)V");
			global::java.io.CharArrayWriter._flush13286 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "flush", "()V");
			global::java.io.CharArrayWriter._close13287 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "close", "()V");
			global::java.io.CharArrayWriter._reset13288 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "reset", "()V");
			global::java.io.CharArrayWriter._writeTo13289 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "writeTo", "(Ljava/io/Writer;)V");
			global::java.io.CharArrayWriter._CharArrayWriter13290 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "<init>", "(I)V");
			global::java.io.CharArrayWriter._CharArrayWriter13291 = @__env.GetMethodIDNoThrow(global::java.io.CharArrayWriter.staticClass, "<init>", "()V");
		}
	}
}
