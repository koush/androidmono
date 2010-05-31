namespace java.io
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PrintWriter : java.io.Writer
	{
		internal new static global::java.lang.Class staticClass;
		static PrintWriter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.io.PrintWriter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.io.PrintWriter(@__env);
			}
		}
		protected PrintWriter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _println11411;
		public virtual void println(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println11411, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println11411, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println11412;
		public virtual void println() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println11412);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println11412);
		}
		internal static global::net.sf.jni4net.jni.MethodId _println11413;
		public virtual void println(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println11413, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println11413, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println11414;
		public virtual void println(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println11414, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println11414, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println11415;
		public virtual void println(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println11415, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println11415, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println11416;
		public virtual void println(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println11416, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println11416, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println11417;
		public virtual void println(double arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println11417, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println11417, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println11418;
		public virtual void println(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println11418, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println11418, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println11419;
		public virtual void println(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println11419, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println11419, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println11420;
		public virtual void println(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println11420, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println11420, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _append11421;
		public virtual new global::java.io.PrintWriter append(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintWriter._append11421, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._append11421, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		public java.io.PrintWriter append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _append11422;
		public virtual new global::java.io.PrintWriter append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintWriter._append11422, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._append11422, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		public java.io.PrintWriter append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::net.sf.jni4net.jni.MethodId _append11423;
		public virtual new global::java.io.PrintWriter append(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintWriter._append11423, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._append11423, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _format11424;
		public virtual global::java.io.PrintWriter format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintWriter._format11424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._format11424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _format11425;
		public virtual global::java.io.PrintWriter format(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintWriter._format11425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._format11425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write11426;
		public override void write(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._write11426, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write11426, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write11427;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._write11427, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write11427, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write11428;
		public override void write(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._write11428, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write11428, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write11429;
		public override void write(java.lang.String arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._write11429, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write11429, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write11430;
		public override void write(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._write11430, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write11430, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print11431;
		public virtual void print(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print11431, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print11431, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print11432;
		public virtual void print(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print11432, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print11432, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print11433;
		public virtual void print(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print11433, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print11433, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print11434;
		public virtual void print(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print11434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print11434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print11435;
		public virtual void print(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print11435, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print11435, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print11436;
		public virtual void print(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print11436, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print11436, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print11437;
		public virtual void print(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print11437, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print11437, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print11438;
		public virtual void print(double arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print11438, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print11438, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print11439;
		public virtual void print(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print11439, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print11439, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flush11440;
		public override void flush() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._flush11440);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._flush11440);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close11441;
		public override void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._close11441);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._close11441);
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkError11442;
		public virtual bool checkError() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.io.PrintWriter._checkError11442);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._checkError11442);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setError11443;
		protected virtual void setError() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._setError11443);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._setError11443);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearError11444;
		protected virtual void clearError() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._clearError11444);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._clearError11444);
		}
		internal static global::net.sf.jni4net.jni.MethodId _printf11445;
		public virtual global::java.io.PrintWriter printf(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintWriter._printf11445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._printf11445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _printf11446;
		public virtual global::java.io.PrintWriter printf(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintWriter._printf11446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._printf11446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter11447;
		public PrintWriter(java.io.Writer arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter11447, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter11448;
		public PrintWriter(java.io.OutputStream arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter11448, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter11449;
		public PrintWriter(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter11449, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter11450;
		public PrintWriter(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter11450, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter11451;
		public PrintWriter(java.io.File arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter11451, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter11452;
		public PrintWriter(java.io.File arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter11452, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter11453;
		public PrintWriter(java.io.Writer arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter11453, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter11454;
		public PrintWriter(java.io.OutputStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter11454, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.io.PrintWriter.staticClass = @__class;
			global::java.io.PrintWriter._println11411 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(C)V");
			global::java.io.PrintWriter._println11412 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "()V");
			global::java.io.PrintWriter._println11413 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(Z)V");
			global::java.io.PrintWriter._println11414 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(Ljava/lang/Object;)V");
			global::java.io.PrintWriter._println11415 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._println11416 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "([C)V");
			global::java.io.PrintWriter._println11417 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(D)V");
			global::java.io.PrintWriter._println11418 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(F)V");
			global::java.io.PrintWriter._println11419 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(J)V");
			global::java.io.PrintWriter._println11420 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(I)V");
			global::java.io.PrintWriter._append11421 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._append11422 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._append11423 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "append", "(C)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._format11424 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._format11425 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._write11426 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "write", "([C)V");
			global::java.io.PrintWriter._write11427 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "write", "([CII)V");
			global::java.io.PrintWriter._write11428 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "write", "(I)V");
			global::java.io.PrintWriter._write11429 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.PrintWriter._write11430 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "write", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._print11431 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._print11432 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(Ljava/lang/Object;)V");
			global::java.io.PrintWriter._print11433 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(Z)V");
			global::java.io.PrintWriter._print11434 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(C)V");
			global::java.io.PrintWriter._print11435 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(I)V");
			global::java.io.PrintWriter._print11436 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(J)V");
			global::java.io.PrintWriter._print11437 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(F)V");
			global::java.io.PrintWriter._print11438 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(D)V");
			global::java.io.PrintWriter._print11439 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "([C)V");
			global::java.io.PrintWriter._flush11440 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "flush", "()V");
			global::java.io.PrintWriter._close11441 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "close", "()V");
			global::java.io.PrintWriter._checkError11442 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "checkError", "()Z");
			global::java.io.PrintWriter._setError11443 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "setError", "()V");
			global::java.io.PrintWriter._clearError11444 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "clearError", "()V");
			global::java.io.PrintWriter._printf11445 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._printf11446 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._PrintWriter11447 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/Writer;Z)V");
			global::java.io.PrintWriter._PrintWriter11448 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Z)V");
			global::java.io.PrintWriter._PrintWriter11449 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._PrintWriter11450 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.PrintWriter._PrintWriter11451 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.PrintWriter._PrintWriter11452 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.io.PrintWriter._PrintWriter11453 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/Writer;)V");
			global::java.io.PrintWriter._PrintWriter11454 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
