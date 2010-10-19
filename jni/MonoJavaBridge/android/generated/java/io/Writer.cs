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
		internal static global::MonoJavaBridge.MethodId _append14015;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.Writer._append14015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._append14015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append14016;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.Writer._append14016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._append14016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append14017;
		public virtual global::java.lang.Appendable append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.Writer._append14017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._append14017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _write14018;
		public abstract void write(char[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _write14019;
		public virtual void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer._write14019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._write14019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write14020;
		public virtual void write(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer._write14020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._write14020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write14021;
		public virtual void write(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer._write14021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._write14021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write14022;
		public virtual void write(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer._write14022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer.staticClass, global::java.io.Writer._write14022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush14023;
		public abstract void flush();
		internal static global::MonoJavaBridge.MethodId _close14024;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _Writer14025;
		protected Writer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Writer.staticClass, global::java.io.Writer._Writer14025);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Writer14026;
		protected Writer(java.lang.Object arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.Writer.staticClass, global::java.io.Writer._Writer14026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Writer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Writer"));
			global::java.io.Writer._append14015 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.io.Writer._append14016 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.io.Writer._append14017 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::java.io.Writer._write14018 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "write", "([CII)V");
			global::java.io.Writer._write14019 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "write", "(I)V");
			global::java.io.Writer._write14020 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "write", "([C)V");
			global::java.io.Writer._write14021 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "write", "(Ljava/lang/String;)V");
			global::java.io.Writer._write14022 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.Writer._flush14023 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "flush", "()V");
			global::java.io.Writer._close14024 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "close", "()V");
			global::java.io.Writer._Writer14025 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "<init>", "()V");
			global::java.io.Writer._Writer14026 = @__env.GetMethodIDNoThrow(global::java.io.Writer.staticClass, "<init>", "(Ljava/lang/Object;)V");
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
		internal static global::MonoJavaBridge.MethodId _write14027;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer_._write14027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer_.staticClass, global::java.io.Writer_._write14027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush14028;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer_._flush14028);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer_.staticClass, global::java.io.Writer_._flush14028);
		}
		internal static global::MonoJavaBridge.MethodId _close14029;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.Writer_._close14029);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.Writer_.staticClass, global::java.io.Writer_._close14029);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Writer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Writer"));
			global::java.io.Writer_._write14027 = @__env.GetMethodIDNoThrow(global::java.io.Writer_.staticClass, "write", "([CII)V");
			global::java.io.Writer_._flush14028 = @__env.GetMethodIDNoThrow(global::java.io.Writer_.staticClass, "flush", "()V");
			global::java.io.Writer_._close14029 = @__env.GetMethodIDNoThrow(global::java.io.Writer_.staticClass, "close", "()V");
		}
	}
}
