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
		internal static global::MonoJavaBridge.MethodId _println13822;
		public virtual void println(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println13822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println13822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13823;
		public virtual void println() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println13823);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println13823);
		}
		internal static global::MonoJavaBridge.MethodId _println13824;
		public virtual void println(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println13824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println13824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13825;
		public virtual void println(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println13825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println13825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13826;
		public virtual void println(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println13826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println13826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13827;
		public virtual void println(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println13827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println13827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13828;
		public virtual void println(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println13828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println13828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13829;
		public virtual void println(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println13829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println13829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13830;
		public virtual void println(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println13830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println13830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _println13831;
		public virtual void println(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._println13831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println13831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _append13832;
		public virtual global::java.io.PrintWriter append(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._append13832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._append13832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.PrintWriter;
		}
		public java.io.PrintWriter append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _append13833;
		public virtual global::java.io.PrintWriter append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._append13833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._append13833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
		}
		public java.io.PrintWriter append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _append13834;
		public virtual global::java.io.PrintWriter append(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._append13834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._append13834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _format13835;
		public virtual global::java.io.PrintWriter format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._format13835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._format13835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _format13836;
		public virtual global::java.io.PrintWriter format(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._format13836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._format13836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _write13837;
		public override void write(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._write13837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write13837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13838;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._write13838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write13838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write13839;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._write13839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write13839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write13840;
		public override void write(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._write13840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write13840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write13841;
		public override void write(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._write13841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write13841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13842;
		public virtual void print(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print13842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print13842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13843;
		public virtual void print(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print13843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print13843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13844;
		public virtual void print(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print13844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print13844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13845;
		public virtual void print(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print13845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print13845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13846;
		public virtual void print(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print13846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print13846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13847;
		public virtual void print(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print13847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print13847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13848;
		public virtual void print(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print13848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print13848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13849;
		public virtual void print(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print13849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print13849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _print13850;
		public virtual void print(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._print13850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print13850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flush13851;
		public override void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._flush13851);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._flush13851);
		}
		internal static global::MonoJavaBridge.MethodId _close13852;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._close13852);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._close13852);
		}
		internal static global::MonoJavaBridge.MethodId _checkError13853;
		public virtual bool checkError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PrintWriter._checkError13853);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._checkError13853);
		}
		internal static global::MonoJavaBridge.MethodId _setError13854;
		protected virtual void setError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._setError13854);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._setError13854);
		}
		internal static global::MonoJavaBridge.MethodId _clearError13855;
		protected virtual void clearError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PrintWriter._clearError13855);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._clearError13855);
		}
		internal static global::MonoJavaBridge.MethodId _printf13856;
		public virtual global::java.io.PrintWriter printf(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._printf13856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._printf13856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _printf13857;
		public virtual global::java.io.PrintWriter printf(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.PrintWriter._printf13857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._printf13857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.io.PrintWriter;
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter13858;
		public PrintWriter(java.io.Writer arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter13858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter13859;
		public PrintWriter(java.io.OutputStream arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter13859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter13860;
		public PrintWriter(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter13860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter13861;
		public PrintWriter(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter13861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter13862;
		public PrintWriter(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter13862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter13863;
		public PrintWriter(java.io.File arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter13863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter13864;
		public PrintWriter(java.io.Writer arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter13864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PrintWriter13865;
		public PrintWriter(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter13865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PrintWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PrintWriter"));
			global::java.io.PrintWriter._println13822 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(C)V");
			global::java.io.PrintWriter._println13823 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "()V");
			global::java.io.PrintWriter._println13824 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(Z)V");
			global::java.io.PrintWriter._println13825 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(Ljava/lang/Object;)V");
			global::java.io.PrintWriter._println13826 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._println13827 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "([C)V");
			global::java.io.PrintWriter._println13828 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(D)V");
			global::java.io.PrintWriter._println13829 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(F)V");
			global::java.io.PrintWriter._println13830 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(J)V");
			global::java.io.PrintWriter._println13831 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "println", "(I)V");
			global::java.io.PrintWriter._append13832 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._append13833 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._append13834 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "append", "(C)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._format13835 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._format13836 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._write13837 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "write", "([C)V");
			global::java.io.PrintWriter._write13838 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "write", "([CII)V");
			global::java.io.PrintWriter._write13839 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "write", "(I)V");
			global::java.io.PrintWriter._write13840 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.PrintWriter._write13841 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "write", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._print13842 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._print13843 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(Ljava/lang/Object;)V");
			global::java.io.PrintWriter._print13844 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(Z)V");
			global::java.io.PrintWriter._print13845 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(C)V");
			global::java.io.PrintWriter._print13846 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(I)V");
			global::java.io.PrintWriter._print13847 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(J)V");
			global::java.io.PrintWriter._print13848 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(F)V");
			global::java.io.PrintWriter._print13849 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "(D)V");
			global::java.io.PrintWriter._print13850 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "print", "([C)V");
			global::java.io.PrintWriter._flush13851 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "flush", "()V");
			global::java.io.PrintWriter._close13852 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "close", "()V");
			global::java.io.PrintWriter._checkError13853 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "checkError", "()Z");
			global::java.io.PrintWriter._setError13854 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "setError", "()V");
			global::java.io.PrintWriter._clearError13855 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "clearError", "()V");
			global::java.io.PrintWriter._printf13856 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._printf13857 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._PrintWriter13858 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/Writer;Z)V");
			global::java.io.PrintWriter._PrintWriter13859 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Z)V");
			global::java.io.PrintWriter._PrintWriter13860 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._PrintWriter13861 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.PrintWriter._PrintWriter13862 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.PrintWriter._PrintWriter13863 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.io.PrintWriter._PrintWriter13864 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/Writer;)V");
			global::java.io.PrintWriter._PrintWriter13865 = @__env.GetMethodIDNoThrow(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
