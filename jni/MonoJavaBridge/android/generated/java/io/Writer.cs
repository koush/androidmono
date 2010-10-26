namespace java.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.io.Writer_))]
	public abstract partial class Writer : java.lang.Object, java.lang.Appendable, Closeable, Flushable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Writer()
		{
			InitJNI();
		}
		protected Writer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _append19639;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.Writer._append19639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._append19639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append19640;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.Writer._append19640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._append19640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append19641;
		public virtual global::java.lang.Appendable append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.Writer._append19641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._append19641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _write19642;
		public abstract void write(char[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _write19643;
		public virtual void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer._write19643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._write19643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19644;
		public virtual void write(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer._write19644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._write19644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19645;
		public virtual void write(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer._write19645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._write19645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19646;
		public virtual void write(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer._write19646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._write19646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush19647;
		public abstract void flush();
		internal static global::MonoJavaBridge.MethodId _close19648;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _Writer19649;
		protected Writer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Writer.staticClass, global::java.io.Writer._Writer19649);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Writer19650;
		protected Writer(java.lang.Object arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Writer.staticClass, global::java.io.Writer._Writer19650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Writer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Writer"));
			global::java.io.Writer._append19639 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.io.Writer._append19640 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.io.Writer._append19641 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::java.io.Writer._write19642 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "write", "([CII)V");
			global::java.io.Writer._write19643 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "write", "(I)V");
			global::java.io.Writer._write19644 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "write", "([C)V");
			global::java.io.Writer._write19645 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "write", "(Ljava/lang/String;)V");
			global::java.io.Writer._write19646 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.Writer._flush19647 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "flush", "()V");
			global::java.io.Writer._close19648 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "close", "()V");
			global::java.io.Writer._Writer19649 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "<init>", "()V");
			global::java.io.Writer._Writer19650 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "<init>", "(Ljava/lang/Object;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.Writer))]
	internal sealed partial class Writer_ : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Writer_()
		{
			InitJNI();
		}
		internal Writer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write19651;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer_._write19651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer_.staticClass, global::java.io.Writer_._write19651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush19652;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer_._flush19652);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer_.staticClass, global::java.io.Writer_._flush19652);
		}
		internal static global::MonoJavaBridge.MethodId _close19653;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer_._close19653);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer_.staticClass, global::java.io.Writer_._close19653);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Writer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Writer"));
			global::java.io.Writer_._write19651 = @__env.GetMethodIDNoThrow(global::java.io.Writer_.staticClass, "write", "([CII)V");
			global::java.io.Writer_._flush19652 = @__env.GetMethodIDNoThrow(global::java.io.Writer_.staticClass, "flush", "()V");
			global::java.io.Writer_._close19653 = @__env.GetMethodIDNoThrow(global::java.io.Writer_.staticClass, "close", "()V");
		}
	}
}
