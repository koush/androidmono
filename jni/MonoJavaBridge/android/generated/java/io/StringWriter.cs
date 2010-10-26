namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StringWriter()
		{
			InitJNI();
		}
		protected StringWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString19617;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.StringWriter._toString19617)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.StringWriter.staticClass, global::java.io.StringWriter._toString19617)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _append19618;
		public virtual global::java.io.StringWriter append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.StringWriter._append19618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.StringWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.StringWriter.staticClass, global::java.io.StringWriter._append19618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.StringWriter;
		}
		public java.io.StringWriter append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append19619;
		public virtual global::java.io.StringWriter append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.StringWriter._append19619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.StringWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.StringWriter.staticClass, global::java.io.StringWriter._append19619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.StringWriter;
		}
		internal static global::MonoJavaBridge.MethodId _append19620;
		public virtual global::java.io.StringWriter append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.StringWriter._append19620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.StringWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.StringWriter.staticClass, global::java.io.StringWriter._append19620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.StringWriter;
		}
		public java.io.StringWriter append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _write19621;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringWriter._write19621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringWriter.staticClass, global::java.io.StringWriter._write19621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write19622;
		public override void write(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringWriter._write19622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringWriter.staticClass, global::java.io.StringWriter._write19622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19623;
		public override void write(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringWriter._write19623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringWriter.staticClass, global::java.io.StringWriter._write19623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write19624;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringWriter._write19624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringWriter.staticClass, global::java.io.StringWriter._write19624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush19625;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringWriter._flush19625);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringWriter.staticClass, global::java.io.StringWriter._flush19625);
		}
		internal static global::MonoJavaBridge.MethodId _close19626;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.StringWriter._close19626);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.StringWriter.staticClass, global::java.io.StringWriter._close19626);
		}
		public new global::java.lang.StringBuffer Buffer
		{
			get
			{
				return getBuffer();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBuffer19627;
		public virtual global::java.lang.StringBuffer getBuffer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.StringWriter._getBuffer19627)) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.StringWriter.staticClass, global::java.io.StringWriter._getBuffer19627)) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _StringWriter19628;
		public StringWriter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StringWriter.staticClass, global::java.io.StringWriter._StringWriter19628);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringWriter19629;
		public StringWriter(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StringWriter.staticClass, global::java.io.StringWriter._StringWriter19629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StringWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StringWriter"));
			global::java.io.StringWriter._toString19617 = @__env.GetMethodIDNoThrow(global::java.io.StringWriter.staticClass, "toString", "()Ljava/lang/String;");
			global::java.io.StringWriter._append19618 = @__env.GetMethodIDNoThrow(global::java.io.StringWriter.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/io/StringWriter;");
			global::java.io.StringWriter._append19619 = @__env.GetMethodIDNoThrow(global::java.io.StringWriter.staticClass, "append", "(C)Ljava/io/StringWriter;");
			global::java.io.StringWriter._append19620 = @__env.GetMethodIDNoThrow(global::java.io.StringWriter.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/io/StringWriter;");
			global::java.io.StringWriter._write19621 = @__env.GetMethodIDNoThrow(global::java.io.StringWriter.staticClass, "write", "([CII)V");
			global::java.io.StringWriter._write19622 = @__env.GetMethodIDNoThrow(global::java.io.StringWriter.staticClass, "write", "(Ljava/lang/String;)V");
			global::java.io.StringWriter._write19623 = @__env.GetMethodIDNoThrow(global::java.io.StringWriter.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.StringWriter._write19624 = @__env.GetMethodIDNoThrow(global::java.io.StringWriter.staticClass, "write", "(I)V");
			global::java.io.StringWriter._flush19625 = @__env.GetMethodIDNoThrow(global::java.io.StringWriter.staticClass, "flush", "()V");
			global::java.io.StringWriter._close19626 = @__env.GetMethodIDNoThrow(global::java.io.StringWriter.staticClass, "close", "()V");
			global::java.io.StringWriter._getBuffer19627 = @__env.GetMethodIDNoThrow(global::java.io.StringWriter.staticClass, "getBuffer", "()Ljava/lang/StringBuffer;");
			global::java.io.StringWriter._StringWriter19628 = @__env.GetMethodIDNoThrow(global::java.io.StringWriter.staticClass, "<init>", "()V");
			global::java.io.StringWriter._StringWriter19629 = @__env.GetMethodIDNoThrow(global::java.io.StringWriter.staticClass, "<init>", "(I)V");
		}
	}
}
