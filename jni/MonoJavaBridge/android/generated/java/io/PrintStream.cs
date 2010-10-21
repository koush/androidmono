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
		internal static global::MonoJavaBridge.MethodId _println19284;
		public virtual void println(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19285;
		public virtual void println() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19285);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19285);
		}
		internal static global::MonoJavaBridge.MethodId _println19286;
		public virtual void println(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19287;
		public virtual void println(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19288;
		public virtual void println(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19289;
		public virtual void println(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19290;
		public virtual void println(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19291;
		public virtual void println(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19292;
		public virtual void println(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println19293;
		public virtual void println(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println19293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println19293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append19294;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._append19294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._append19294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append19295;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._append19295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._append19295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append19296;
		public virtual global::java.lang.Appendable append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._append19296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._append19296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _format19297;
		public virtual global::java.io.PrintStream format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._format19297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._format19297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintStream;
		}
		internal static global::MonoJavaBridge.MethodId _format19298;
		public virtual global::java.io.PrintStream format(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._format19298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._format19298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintStream;
		}
		internal static global::MonoJavaBridge.MethodId _write19299;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._write19299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._write19299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write19300;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._write19300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._write19300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19301;
		public virtual void print(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19302;
		public virtual void print(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19303;
		public virtual void print(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19304;
		public virtual void print(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19305;
		public virtual void print(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19306;
		public virtual void print(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19307;
		public virtual void print(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19308;
		public virtual void print(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print19309;
		public virtual void print(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print19309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print19309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush19310;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._flush19310);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._flush19310);
		}
		internal static global::MonoJavaBridge.MethodId _close19311;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._close19311);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._close19311);
		}
		internal static global::MonoJavaBridge.MethodId _checkError19312;
		public virtual bool checkError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PrintStream._checkError19312);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._checkError19312);
		}
		internal static global::MonoJavaBridge.MethodId _setError19313;
		protected virtual void setError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._setError19313);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._setError19313);
		}
		internal static global::MonoJavaBridge.MethodId _clearError19314;
		protected virtual void clearError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._clearError19314);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._clearError19314);
		}
		internal static global::MonoJavaBridge.MethodId _printf19315;
		public virtual global::java.io.PrintStream printf(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._printf19315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._printf19315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintStream;
		}
		internal static global::MonoJavaBridge.MethodId _printf19316;
		public virtual global::java.io.PrintStream printf(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._printf19316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._printf19316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintStream;
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream19317;
		public PrintStream(java.io.OutputStream arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream19317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream19318;
		public PrintStream(java.io.OutputStream arg0, bool arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream19318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream19319;
		public PrintStream(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream19319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream19320;
		public PrintStream(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream19320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream19321;
		public PrintStream(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream19321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream19322;
		public PrintStream(java.io.File arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream19322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream19323;
		public PrintStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream19323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PrintStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PrintStream"));
			global::java.io.PrintStream._println19284 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(C)V");
			global::java.io.PrintStream._println19285 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "()V");
			global::java.io.PrintStream._println19286 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(Z)V");
			global::java.io.PrintStream._println19287 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(Ljava/lang/Object;)V");
			global::java.io.PrintStream._println19288 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(Ljava/lang/String;)V");
			global::java.io.PrintStream._println19289 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "([C)V");
			global::java.io.PrintStream._println19290 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(D)V");
			global::java.io.PrintStream._println19291 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(F)V");
			global::java.io.PrintStream._println19292 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(J)V");
			global::java.io.PrintStream._println19293 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(I)V");
			global::java.io.PrintStream._append19294 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.io.PrintStream._append19295 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.io.PrintStream._append19296 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::java.io.PrintStream._format19297 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
			global::java.io.PrintStream._format19298 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
			global::java.io.PrintStream._write19299 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "write", "([BII)V");
			global::java.io.PrintStream._write19300 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "write", "(I)V");
			global::java.io.PrintStream._print19301 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(F)V");
			global::java.io.PrintStream._print19302 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(D)V");
			global::java.io.PrintStream._print19303 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "([C)V");
			global::java.io.PrintStream._print19304 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(Ljava/lang/String;)V");
			global::java.io.PrintStream._print19305 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(Ljava/lang/Object;)V");
			global::java.io.PrintStream._print19306 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(Z)V");
			global::java.io.PrintStream._print19307 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(C)V");
			global::java.io.PrintStream._print19308 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(I)V");
			global::java.io.PrintStream._print19309 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(J)V");
			global::java.io.PrintStream._flush19310 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "flush", "()V");
			global::java.io.PrintStream._close19311 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "close", "()V");
			global::java.io.PrintStream._checkError19312 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "checkError", "()Z");
			global::java.io.PrintStream._setError19313 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "setError", "()V");
			global::java.io.PrintStream._clearError19314 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "clearError", "()V");
			global::java.io.PrintStream._printf19315 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
			global::java.io.PrintStream._printf19316 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
			global::java.io.PrintStream._PrintStream19317 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/OutputStream;Z)V");
			global::java.io.PrintStream._PrintStream19318 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/OutputStream;ZLjava/lang/String;)V");
			global::java.io.PrintStream._PrintStream19319 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.PrintStream._PrintStream19320 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.PrintStream._PrintStream19321 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.PrintStream._PrintStream19322 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.io.PrintStream._PrintStream19323 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
