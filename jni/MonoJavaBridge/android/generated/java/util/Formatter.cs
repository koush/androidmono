namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class Formatter : java.lang.Object, java.io.Closeable, java.io.Flushable
	{
		internal static global::java.lang.Class staticClass;
		static Formatter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.Formatter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.util.Formatter(@__env);
			}
		}
		internal Formatter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13683;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Formatter._toString13683));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._toString13683));
		}
		internal static global::net.sf.jni4net.jni.MethodId _format13684;
		public global::java.util.Formatter format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Formatter>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Formatter._format13684, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Formatter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._format13684, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _format13685;
		public global::java.util.Formatter format(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Formatter>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Formatter._format13685, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Formatter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._format13685, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _out13686;
		public global::java.lang.Appendable @out() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Formatter._out13686));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._out13686));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flush13687;
		public void flush() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Formatter._flush13687);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._flush13687);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close13688;
		public void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Formatter._close13688);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._close13688);
		}
		internal static global::net.sf.jni4net.jni.MethodId _locale13689;
		public global::java.util.Locale locale() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Formatter._locale13689));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._locale13689));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ioException13690;
		public global::java.io.IOException ioException() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.IOException>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Formatter._ioException13690));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.IOException>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._ioException13690));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter13691;
		public Formatter(java.io.OutputStream arg0, java.lang.String arg1, java.util.Locale arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter13691, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter13692;
		public Formatter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter13692, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter13693;
		public Formatter(java.lang.Appendable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter13693, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter13694;
		public Formatter(java.util.Locale arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter13694, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter13695;
		public Formatter(java.lang.Appendable arg0, java.util.Locale arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter13695, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter13696;
		public Formatter(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter13696, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter13697;
		public Formatter(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter13697, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter13698;
		public Formatter(java.lang.String arg0, java.lang.String arg1, java.util.Locale arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter13698, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter13699;
		public Formatter(java.io.File arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter13699, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter13700;
		public Formatter(java.io.File arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter13700, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter13701;
		public Formatter(java.io.File arg0, java.lang.String arg1, java.util.Locale arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter13701, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter13702;
		public Formatter(java.io.PrintStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter13702, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter13703;
		public Formatter(java.io.OutputStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter13703, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter13704;
		public Formatter(java.io.OutputStream arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter13704, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.Formatter.staticClass = @__class;
			global::java.util.Formatter._toString13683 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Formatter._format13684 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;");
			global::java.util.Formatter._format13685 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;");
			global::java.util.Formatter._out13686 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "@out", "()Ljava/lang/Appendable;");
			global::java.util.Formatter._flush13687 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "flush", "()V");
			global::java.util.Formatter._close13688 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "close", "()V");
			global::java.util.Formatter._locale13689 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "locale", "()Ljava/util/Locale;");
			global::java.util.Formatter._ioException13690 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "ioException", "()Ljava/io/IOException;");
			global::java.util.Formatter._Formatter13691 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter13692 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "()V");
			global::java.util.Formatter._Formatter13693 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/Appendable;)V");
			global::java.util.Formatter._Formatter13694 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter13695 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/Appendable;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter13696 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.Formatter._Formatter13697 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Formatter._Formatter13698 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter13699 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.util.Formatter._Formatter13700 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.util.Formatter._Formatter13701 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter13702 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/PrintStream;)V");
			global::java.util.Formatter._Formatter13703 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::java.util.Formatter._Formatter13704 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
		}
	}
}
