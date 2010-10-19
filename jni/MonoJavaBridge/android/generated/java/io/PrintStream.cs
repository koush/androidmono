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
		internal static global::MonoJavaBridge.MethodId _println13782;
		public virtual void println(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println13782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println13782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13783;
		public virtual void println() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println13783);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println13783);
		}
		internal static global::MonoJavaBridge.MethodId _println13784;
		public virtual void println(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println13784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println13784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13785;
		public virtual void println(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println13785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println13785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13786;
		public virtual void println(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println13786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println13786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13787;
		public virtual void println(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println13787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println13787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13788;
		public virtual void println(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println13788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println13788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13789;
		public virtual void println(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println13789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println13789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13790;
		public virtual void println(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println13790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println13790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13791;
		public virtual void println(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._println13791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._println13791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append13792;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._append13792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._append13792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append13793;
		public virtual global::java.lang.Appendable append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._append13793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._append13793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Appendable;
		}
		public java.lang.Appendable append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append13794;
		public virtual global::java.lang.Appendable append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._append13794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._append13794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _format13795;
		public virtual global::java.io.PrintStream format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._format13795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._format13795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintStream;
		}
		internal static global::MonoJavaBridge.MethodId _format13796;
		public virtual global::java.io.PrintStream format(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._format13796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._format13796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintStream;
		}
		internal static global::MonoJavaBridge.MethodId _write13797;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._write13797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._write13797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write13798;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._write13798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._write13798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13799;
		public virtual void print(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print13799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print13799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13800;
		public virtual void print(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print13800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print13800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13801;
		public virtual void print(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print13801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print13801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13802;
		public virtual void print(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print13802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print13802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13803;
		public virtual void print(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print13803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print13803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13804;
		public virtual void print(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print13804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print13804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13805;
		public virtual void print(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print13805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print13805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13806;
		public virtual void print(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print13806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print13806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13807;
		public virtual void print(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._print13807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._print13807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush13808;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._flush13808);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._flush13808);
		}
		internal static global::MonoJavaBridge.MethodId _close13809;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._close13809);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._close13809);
		}
		internal static global::MonoJavaBridge.MethodId _checkError13810;
		public virtual bool checkError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PrintStream._checkError13810);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._checkError13810);
		}
		internal static global::MonoJavaBridge.MethodId _setError13811;
		protected virtual void setError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._setError13811);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._setError13811);
		}
		internal static global::MonoJavaBridge.MethodId _clearError13812;
		protected virtual void clearError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintStream._clearError13812);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._clearError13812);
		}
		internal static global::MonoJavaBridge.MethodId _printf13813;
		public virtual global::java.io.PrintStream printf(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._printf13813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._printf13813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintStream;
		}
		internal static global::MonoJavaBridge.MethodId _printf13814;
		public virtual global::java.io.PrintStream printf(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintStream._printf13814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintStream.staticClass, global::java.io.PrintStream._printf13814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintStream;
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream13815;
		public PrintStream(java.io.OutputStream arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream13815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream13816;
		public PrintStream(java.io.OutputStream arg0, bool arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream13816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream13817;
		public PrintStream(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream13817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream13818;
		public PrintStream(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream13818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream13819;
		public PrintStream(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream13819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream13820;
		public PrintStream(java.io.File arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream13820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintStream13821;
		public PrintStream(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintStream.staticClass, global::java.io.PrintStream._PrintStream13821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PrintStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PrintStream"));
			global::java.io.PrintStream._println13782 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(C)V");
			global::java.io.PrintStream._println13783 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "()V");
			global::java.io.PrintStream._println13784 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(Z)V");
			global::java.io.PrintStream._println13785 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(Ljava/lang/Object;)V");
			global::java.io.PrintStream._println13786 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(Ljava/lang/String;)V");
			global::java.io.PrintStream._println13787 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "([C)V");
			global::java.io.PrintStream._println13788 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(D)V");
			global::java.io.PrintStream._println13789 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(F)V");
			global::java.io.PrintStream._println13790 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(J)V");
			global::java.io.PrintStream._println13791 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "println", "(I)V");
			global::java.io.PrintStream._append13792 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			global::java.io.PrintStream._append13793 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			global::java.io.PrintStream._append13794 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "append", "(C)Ljava/lang/Appendable;");
			global::java.io.PrintStream._format13795 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
			global::java.io.PrintStream._format13796 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
			global::java.io.PrintStream._write13797 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "write", "([BII)V");
			global::java.io.PrintStream._write13798 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "write", "(I)V");
			global::java.io.PrintStream._print13799 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(F)V");
			global::java.io.PrintStream._print13800 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(D)V");
			global::java.io.PrintStream._print13801 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "([C)V");
			global::java.io.PrintStream._print13802 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(Ljava/lang/String;)V");
			global::java.io.PrintStream._print13803 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(Ljava/lang/Object;)V");
			global::java.io.PrintStream._print13804 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(Z)V");
			global::java.io.PrintStream._print13805 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(C)V");
			global::java.io.PrintStream._print13806 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(I)V");
			global::java.io.PrintStream._print13807 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "print", "(J)V");
			global::java.io.PrintStream._flush13808 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "flush", "()V");
			global::java.io.PrintStream._close13809 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "close", "()V");
			global::java.io.PrintStream._checkError13810 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "checkError", "()Z");
			global::java.io.PrintStream._setError13811 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "setError", "()V");
			global::java.io.PrintStream._clearError13812 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "clearError", "()V");
			global::java.io.PrintStream._printf13813 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
			global::java.io.PrintStream._printf13814 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
			global::java.io.PrintStream._PrintStream13815 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/OutputStream;Z)V");
			global::java.io.PrintStream._PrintStream13816 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/OutputStream;ZLjava/lang/String;)V");
			global::java.io.PrintStream._PrintStream13817 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.PrintStream._PrintStream13818 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.PrintStream._PrintStream13819 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.PrintStream._PrintStream13820 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.io.PrintStream._PrintStream13821 = @__env.GetMethodIDNoThrow(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
