namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PrintStream : java.io.FilterOutputStream, java.lang.Appendable, Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PrintStream()
		{
			InitJNI();
		}
		protected PrintStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _println19402;
		public virtual void println(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19403;
		public virtual void println() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19403);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19403);
		}
		internal static global::MonoJavaBridge.MethodId _println19404;
		public virtual void println(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19405;
		public virtual void println(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19406;
		public virtual void println(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19407;
		public virtual void println(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19408;
		public virtual void println(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19409;
		public virtual void println(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19410;
		public virtual void println(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19411;
		public virtual void println(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append19412;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._append19412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._append19412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append19413;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._append19413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._append19413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append19414;
		public virtual global::java.lang.Appendable append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._append19414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._append19414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _format19415;
		public virtual global::java.io.PrintStream format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._format19415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._format19415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintStream;
		}
		internal static global::MonoJavaBridge.MethodId _format19416;
		public virtual global::java.io.PrintStream format(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._format19416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._format19416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintStream;
		}
		internal static global::MonoJavaBridge.MethodId _write19417;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._write19417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._write19417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write19418;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._write19418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._write19418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19419;
		public virtual void print(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19420;
		public virtual void print(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19421;
		public virtual void print(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19422;
		public virtual void print(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19423;
		public virtual void print(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19424;
		public virtual void print(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19425;
		public virtual void print(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19426;
		public virtual void print(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19427;
		public virtual void print(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush19428;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._flush19428);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._flush19428);
		}
		internal static global::MonoJavaBridge.MethodId _close19429;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._close19429);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._close19429);
		}
		internal static global::MonoJavaBridge.MethodId _checkError19430;
		public virtual bool checkError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PrintStream._checkError19430);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._checkError19430);
		}
		internal static global::MonoJavaBridge.MethodId _setError19431;
		protected virtual void setError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._setError19431);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._setError19431);
		}
		internal static global::MonoJavaBridge.MethodId _clearError19432;
		protected virtual void clearError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._clearError19432);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._clearError19432);
		}
		internal static global::MonoJavaBridge.MethodId _printf19433;
		public virtual global::java.io.PrintStream printf(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._printf19433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._printf19433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintStream;
		}
		internal static global::MonoJavaBridge.MethodId _printf19434;
		public virtual global::java.io.PrintStream printf(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._printf19434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._printf19434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintStream;
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream19435;
		public PrintStream(java.io.OutputStream arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream19435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream19436;
		public PrintStream(java.io.OutputStream arg0, bool arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream19436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream19437;
		public PrintStream(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream19437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream19438;
		public PrintStream(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream19438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream19439;
		public PrintStream(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream19439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream19440;
		public PrintStream(java.io.File arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream19440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream19441;
		public PrintStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream19441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PrintStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PrintStream"));
			global::java.io.PrintStream._println19402 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(C)V");
			global::java.io.PrintStream._println19403 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "()V");
			global::java.io.PrintStream._println19404 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(Z)V");
			global::java.io.PrintStream._println19405 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(Ljava/lang/Object;)V");
			global::java.io.PrintStream._println19406 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(Ljava/lang/String;)V");
			global::java.io.PrintStream._println19407 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "([C)V");
			global::java.io.PrintStream._println19408 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(D)V");
			global::java.io.PrintStream._println19409 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(F)V");
			global::java.io.PrintStream._println19410 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(J)V");
			global::java.io.PrintStream._println19411 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(I)V");
			global::java.io.PrintStream._append19412 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.io.PrintStream._append19413 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.io.PrintStream._append19414 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::java.io.PrintStream._format19415 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
			global::java.io.PrintStream._format19416 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
			global::java.io.PrintStream._write19417 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "write", "([BII)V");
			global::java.io.PrintStream._write19418 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "write", "(I)V");
			global::java.io.PrintStream._print19419 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(F)V");
			global::java.io.PrintStream._print19420 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(D)V");
			global::java.io.PrintStream._print19421 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "([C)V");
			global::java.io.PrintStream._print19422 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(Ljava/lang/String;)V");
			global::java.io.PrintStream._print19423 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(Ljava/lang/Object;)V");
			global::java.io.PrintStream._print19424 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(Z)V");
			global::java.io.PrintStream._print19425 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(C)V");
			global::java.io.PrintStream._print19426 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(I)V");
			global::java.io.PrintStream._print19427 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(J)V");
			global::java.io.PrintStream._flush19428 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "flush", "()V");
			global::java.io.PrintStream._close19429 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "close", "()V");
			global::java.io.PrintStream._checkError19430 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "checkError", "()Z");
			global::java.io.PrintStream._setError19431 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "setError", "()V");
			global::java.io.PrintStream._clearError19432 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "clearError", "()V");
			global::java.io.PrintStream._printf19433 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
			global::java.io.PrintStream._printf19434 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
			global::java.io.PrintStream._PrintStream19435 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/OutputStream;Z)V");
			global::java.io.PrintStream._PrintStream19436 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/OutputStream;ZLjava/lang/String;)V");
			global::java.io.PrintStream._PrintStream19437 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.PrintStream._PrintStream19438 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.PrintStream._PrintStream19439 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.PrintStream._PrintStream19440 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.io.PrintStream._PrintStream19441 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
