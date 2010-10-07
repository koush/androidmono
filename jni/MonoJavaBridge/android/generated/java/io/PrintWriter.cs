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
		internal static global::net.sf.jni4net.jni.MethodId _println12140;
		public virtual void println(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println12140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println12141;
		public virtual void println() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println12141);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12141);
		}
		internal static global::net.sf.jni4net.jni.MethodId _println12142;
		public virtual void println(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println12142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println12143;
		public virtual void println(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println12143, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12143, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println12144;
		public virtual void println(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println12144, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12144, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println12145;
		public virtual void println(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println12145, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12145, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println12146;
		public virtual void println(double arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println12146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println12147;
		public virtual void println(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println12147, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12147, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println12148;
		public virtual void println(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println12148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _println12149;
		public virtual void println(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._println12149, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._println12149, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _append12150;
		public virtual new global::java.io.PrintWriter append(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintWriter._append12150, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._append12150, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		public java.io.PrintWriter append(string arg0)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _append12151;
		public virtual new global::java.io.PrintWriter append(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintWriter._append12151, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._append12151, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		public java.io.PrintWriter append(string arg0, int arg1, int arg2)
		{
			return append((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::net.sf.jni4net.jni.MethodId _append12152;
		public virtual new global::java.io.PrintWriter append(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintWriter._append12152, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._append12152, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _format12153;
		public virtual global::java.io.PrintWriter format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintWriter._format12153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._format12153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _format12154;
		public virtual global::java.io.PrintWriter format(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintWriter._format12154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._format12154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write12155;
		public override void write(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._write12155, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write12155, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write12156;
		public override void write(char[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._write12156, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write12156, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write12157;
		public override void write(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._write12157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write12157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write12158;
		public override void write(java.lang.String arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._write12158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write12158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write12159;
		public override void write(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._write12159, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._write12159, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print12160;
		public virtual void print(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print12160, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12160, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print12161;
		public virtual void print(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print12161, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12161, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print12162;
		public virtual void print(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print12162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print12163;
		public virtual void print(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print12163, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12163, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print12164;
		public virtual void print(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print12164, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12164, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print12165;
		public virtual void print(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print12165, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12165, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print12166;
		public virtual void print(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print12166, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12166, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print12167;
		public virtual void print(double arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print12167, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12167, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _print12168;
		public virtual void print(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._print12168, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._print12168, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flush12169;
		public override void flush() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._flush12169);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._flush12169);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close12170;
		public override void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._close12170);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._close12170);
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkError12171;
		public virtual bool checkError() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.io.PrintWriter._checkError12171);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._checkError12171);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setError12172;
		protected virtual void setError() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._setError12172);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._setError12172);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearError12173;
		protected virtual void clearError() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.io.PrintWriter._clearError12173);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._clearError12173);
		}
		internal static global::net.sf.jni4net.jni.MethodId _printf12174;
		public virtual global::java.io.PrintWriter printf(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintWriter._printf12174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._printf12174, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _printf12175;
		public virtual global::java.io.PrintWriter printf(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintWriter._printf12175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.PrintWriter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.io.PrintWriter.staticClass, global::java.io.PrintWriter._printf12175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter12176;
		public PrintWriter(java.io.Writer arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12176, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter12177;
		public PrintWriter(java.io.OutputStream arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12177, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter12178;
		public PrintWriter(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12178, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter12179;
		public PrintWriter(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12179, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter12180;
		public PrintWriter(java.io.File arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12180, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter12181;
		public PrintWriter(java.io.File arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12181, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter12182;
		public PrintWriter(java.io.Writer arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12182, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PrintWriter12183;
		public PrintWriter(java.io.OutputStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.io.PrintWriter.staticClass, global::java.io.PrintWriter._PrintWriter12183, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.io.PrintWriter.staticClass = @__class;
			global::java.io.PrintWriter._println12140 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(C)V");
			global::java.io.PrintWriter._println12141 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "()V");
			global::java.io.PrintWriter._println12142 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(Z)V");
			global::java.io.PrintWriter._println12143 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(Ljava/lang/Object;)V");
			global::java.io.PrintWriter._println12144 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._println12145 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "([C)V");
			global::java.io.PrintWriter._println12146 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(D)V");
			global::java.io.PrintWriter._println12147 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(F)V");
			global::java.io.PrintWriter._println12148 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(J)V");
			global::java.io.PrintWriter._println12149 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "println", "(I)V");
			global::java.io.PrintWriter._append12150 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._append12151 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._append12152 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "append", "(C)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._format12153 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._format12154 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._write12155 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "write", "([C)V");
			global::java.io.PrintWriter._write12156 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "write", "([CII)V");
			global::java.io.PrintWriter._write12157 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "write", "(I)V");
			global::java.io.PrintWriter._write12158 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "write", "(Ljava/lang/String;II)V");
			global::java.io.PrintWriter._write12159 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "write", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._print12160 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._print12161 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(Ljava/lang/Object;)V");
			global::java.io.PrintWriter._print12162 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(Z)V");
			global::java.io.PrintWriter._print12163 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(C)V");
			global::java.io.PrintWriter._print12164 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(I)V");
			global::java.io.PrintWriter._print12165 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(J)V");
			global::java.io.PrintWriter._print12166 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(F)V");
			global::java.io.PrintWriter._print12167 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "(D)V");
			global::java.io.PrintWriter._print12168 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "print", "([C)V");
			global::java.io.PrintWriter._flush12169 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "flush", "()V");
			global::java.io.PrintWriter._close12170 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "close", "()V");
			global::java.io.PrintWriter._checkError12171 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "checkError", "()Z");
			global::java.io.PrintWriter._setError12172 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "setError", "()V");
			global::java.io.PrintWriter._clearError12173 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "clearError", "()V");
			global::java.io.PrintWriter._printf12174 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._printf12175 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintWriter;");
			global::java.io.PrintWriter._PrintWriter12176 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/Writer;Z)V");
			global::java.io.PrintWriter._PrintWriter12177 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/OutputStream;Z)V");
			global::java.io.PrintWriter._PrintWriter12178 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.PrintWriter._PrintWriter12179 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.io.PrintWriter._PrintWriter12180 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.io.PrintWriter._PrintWriter12181 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.io.PrintWriter._PrintWriter12182 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/Writer;)V");
			global::java.io.PrintWriter._PrintWriter12183 = @__env.GetMethodID(global::java.io.PrintWriter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
		}
	}
}
