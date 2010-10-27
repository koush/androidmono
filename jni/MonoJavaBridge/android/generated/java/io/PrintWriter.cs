namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PrintWriter : java.io.Writer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PrintWriter()
		{
			InitJNI();
		}
		protected PrintWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _println19442;
		public virtual void println(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println19442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println19442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19443;
		public virtual void println()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println19443);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println19443);
		}
		internal static global::MonoJavaBridge.MethodId _println19444;
		public virtual void println(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println19444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println19444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19445;
		public virtual void println(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println19445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println19445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19446;
		public virtual void println(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println19446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println19446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19447;
		public virtual void println(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println19447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println19447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19448;
		public virtual void println(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println19448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println19448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19449;
		public virtual void println(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println19449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println19449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19450;
		public virtual void println(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println19450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println19450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19451;
		public virtual void println(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println19451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println19451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append19452;
		public virtual global::java.io.PrintWriter append(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._append19452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._append19452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.PrintWriter;
		}
		public java.io.PrintWriter append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append19453;
		public virtual global::java.io.PrintWriter append(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._append19453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._append19453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
		}
		public java.io.PrintWriter append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append19454;
		public virtual global::java.io.PrintWriter append(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._append19454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._append19454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _format19455;
		public virtual global::java.io.PrintWriter format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._format19455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._format19455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _format19456;
		public virtual global::java.io.PrintWriter format(java.lang.String arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._format19456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._format19456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _write19457;
		public override void write(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._write19457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write19457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19458;
		public override void write(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._write19458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write19458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write19459;
		public override void write(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._write19459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write19459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write19460;
		public override void write(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._write19460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write19460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write19461;
		public override void write(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._write19461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write19461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19462;
		public virtual void print(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print19462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print19462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19463;
		public virtual void print(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print19463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print19463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19464;
		public virtual void print(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print19464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print19464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19465;
		public virtual void print(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print19465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print19465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19466;
		public virtual void print(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print19466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print19466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19467;
		public virtual void print(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print19467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print19467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19468;
		public virtual void print(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print19468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print19468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19469;
		public virtual void print(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print19469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print19469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19470;
		public virtual void print(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print19470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print19470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush19471;
		public override void flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._flush19471);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._flush19471);
		}
		internal static global::MonoJavaBridge.MethodId _close19472;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._close19472);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._close19472);
		}
		internal static global::MonoJavaBridge.MethodId _checkError19473;
		public virtual bool checkError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PrintWriter._checkError19473);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._checkError19473);
		}
		internal static global::MonoJavaBridge.MethodId _setError19474;
		protected virtual void setError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._setError19474);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._setError19474);
		}
		internal static global::MonoJavaBridge.MethodId _clearError19475;
		protected virtual void clearError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._clearError19475);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._clearError19475);
		}
		internal static global::MonoJavaBridge.MethodId _printf19476;
		public virtual global::java.io.PrintWriter printf(java.lang.String arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._printf19476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._printf19476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _printf19477;
		public virtual global::java.io.PrintWriter printf(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._printf19477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._printf19477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter19478;
		public PrintWriter(java.io.Writer arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter19478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter19479;
		public PrintWriter(java.io.OutputStream arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter19479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter19480;
		public PrintWriter(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter19480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter19481;
		public PrintWriter(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter19481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter19482;
		public PrintWriter(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter19482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter19483;
		public PrintWriter(java.io.File arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter19483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter19484;
		public PrintWriter(java.io.Writer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter19484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter19485;
		public PrintWriter(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter19485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PrintWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PrintWriter"));
			global::java.io.PrintWriter._println19442 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(C)V");
			global::java.io.PrintWriter._println19443 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "()V");
			global::java.io.PrintWriter._println19444 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(Z)V");
			global::java.io.PrintWriter._println19445 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(Ljava/lang/Object;)V");
			global::java.io.PrintWriter._println19446 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._println19447 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "([C)V");
			global::java.io.PrintWriter._println19448 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(D)V");
			global::java.io.PrintWriter._println19449 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(F)V");
			global::java.io.PrintWriter._println19450 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(J)V");
			global::java.io.PrintWriter._println19451 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(I)V");
			global::java.io.PrintWriter._append19452 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._append19453 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._append19454 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "append", "(C)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._format19455 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._format19456 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._write19457 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "write", "([C)V");
			global::java.io.PrintWriter._write19458 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "write", "([CII)V");
			global::java.io.PrintWriter._write19459 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "write", "(I)V");
			global::java.io.PrintWriter._write19460 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.PrintWriter._write19461 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "write", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._print19462 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._print19463 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(Ljava/lang/Object;)V");
			global::java.io.PrintWriter._print19464 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(Z)V");
			global::java.io.PrintWriter._print19465 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(C)V");
			global::java.io.PrintWriter._print19466 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(I)V");
			global::java.io.PrintWriter._print19467 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(J)V");
			global::java.io.PrintWriter._print19468 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(F)V");
			global::java.io.PrintWriter._print19469 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(D)V");
			global::java.io.PrintWriter._print19470 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "([C)V");
			global::java.io.PrintWriter._flush19471 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "flush", "()V");
			global::java.io.PrintWriter._close19472 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "close", "()V");
			global::java.io.PrintWriter._checkError19473 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "checkError", "()Z");
			global::java.io.PrintWriter._setError19474 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "setError", "()V");
			global::java.io.PrintWriter._clearError19475 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "clearError", "()V");
			global::java.io.PrintWriter._printf19476 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._printf19477 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._PrintWriter19478 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/Writer;Z)V");
			global::java.io.PrintWriter._PrintWriter19479 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Z)V");
			global::java.io.PrintWriter._PrintWriter19480 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._PrintWriter19481 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.PrintWriter._PrintWriter19482 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.PrintWriter._PrintWriter19483 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.io.PrintWriter._PrintWriter19484 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/Writer;)V");
			global::java.io.PrintWriter._PrintWriter19485 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
