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
		internal static global::MonoJavaBridge.MethodId _append12718;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.Writer._append12718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._append12718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append12719;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.Writer._append12719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._append12719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append12720;
		public virtual global::java.lang.Appendable append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.Writer._append12720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._append12720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _write12721;
		public abstract void write(char[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _write12722;
		public virtual void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer._write12722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._write12722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write12723;
		public virtual void write(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer._write12723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._write12723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write12724;
		public virtual void write(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer._write12724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._write12724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write12725;
		public virtual void write(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer._write12725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._write12725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush12726;
		public abstract void flush();
		internal static global::MonoJavaBridge.MethodId _close12727;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _Writer12728;
		protected Writer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Writer.staticClass, global::java.io.Writer._Writer12728);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Writer12729;
		protected Writer(java.lang.Object arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Writer.staticClass, global::java.io.Writer._Writer12729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Writer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Writer"));
			global::java.io.Writer._append12718 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.io.Writer._append12719 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.io.Writer._append12720 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::java.io.Writer._write12721 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "write", "([CII)V");
			global::java.io.Writer._write12722 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "write", "(I)V");
			global::java.io.Writer._write12723 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "write", "([C)V");
			global::java.io.Writer._write12724 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "write", "(Ljava/lang/String;)V");
			global::java.io.Writer._write12725 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.Writer._flush12726 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "flush", "()V");
			global::java.io.Writer._close12727 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "close", "()V");
			global::java.io.Writer._Writer12728 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "<init>", "()V");
			global::java.io.Writer._Writer12729 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "<init>", "(Ljava/lang/Object;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.Writer))]
	public sealed partial class Writer_ : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Writer_()
		{
			InitJNI();
		}
		internal Writer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write12730;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer_._write12730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer_.staticClass, global::java.io.Writer_._write12730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush12731;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer_._flush12731);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer_.staticClass, global::java.io.Writer_._flush12731);
		}
		internal static global::MonoJavaBridge.MethodId _close12732;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer_._close12732);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer_.staticClass, global::java.io.Writer_._close12732);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Writer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Writer"));
			global::java.io.Writer_._write12730 = @__env.GetMethodIDNoThrow(global::java.io.Writer_.staticClass, "write", "([CII)V");
			global::java.io.Writer_._flush12731 = @__env.GetMethodIDNoThrow(global::java.io.Writer_.staticClass, "flush", "()V");
			global::java.io.Writer_._close12732 = @__env.GetMethodIDNoThrow(global::java.io.Writer_.staticClass, "close", "()V");
		}
	}
}
