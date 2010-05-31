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
		internal static global::net.sf.jni4net.jni.MethodId _toString12852;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Formatter._toString12852));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._toString12852));
		}
		internal static global::net.sf.jni4net.jni.MethodId _format12853;
		public global::java.util.Formatter format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Formatter>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Formatter._format12853, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Formatter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._format12853, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _format12854;
		public global::java.util.Formatter format(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Formatter>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Formatter._format12854, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Formatter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._format12854, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _out12855;
		public global::java.lang.Appendable @out() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Formatter._out12855));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._out12855));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flush12856;
		public void flush() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Formatter._flush12856);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._flush12856);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close12857;
		public void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Formatter._close12857);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._close12857);
		}
		internal static global::net.sf.jni4net.jni.MethodId _locale12858;
		public global::java.util.Locale locale() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Formatter._locale12858));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._locale12858));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ioException12859;
		public global::java.io.IOException ioException() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.IOException>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Formatter._ioException12859));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.IOException>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Formatter.staticClass, global::java.util.Formatter._ioException12859));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter12860;
		public Formatter(java.io.OutputStream arg0, java.lang.String arg1, java.util.Locale arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter12860, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter12861;
		public Formatter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter12861, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter12862;
		public Formatter(java.lang.Appendable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter12862, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter12863;
		public Formatter(java.util.Locale arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter12863, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter12864;
		public Formatter(java.lang.Appendable arg0, java.util.Locale arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter12864, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter12865;
		public Formatter(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter12865, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter12866;
		public Formatter(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter12866, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter12867;
		public Formatter(java.lang.String arg0, java.lang.String arg1, java.util.Locale arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter12867, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter12868;
		public Formatter(java.io.File arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter12868, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter12869;
		public Formatter(java.io.File arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter12869, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter12870;
		public Formatter(java.io.File arg0, java.lang.String arg1, java.util.Locale arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter12870, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter12871;
		public Formatter(java.io.PrintStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter12871, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter12872;
		public Formatter(java.io.OutputStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter12872, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Formatter12873;
		public Formatter(java.io.OutputStream arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter12873, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.Formatter.staticClass = @__class;
			global::java.util.Formatter._toString12852 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Formatter._format12853 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;");
			global::java.util.Formatter._format12854 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;");
			global::java.util.Formatter._out12855 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "@out", "()Ljava/lang/Appendable;");
			global::java.util.Formatter._flush12856 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "flush", "()V");
			global::java.util.Formatter._close12857 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "close", "()V");
			global::java.util.Formatter._locale12858 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "locale", "()Ljava/util/Locale;");
			global::java.util.Formatter._ioException12859 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "ioException", "()Ljava/io/IOException;");
			global::java.util.Formatter._Formatter12860 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter12861 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "()V");
			global::java.util.Formatter._Formatter12862 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/Appendable;)V");
			global::java.util.Formatter._Formatter12863 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter12864 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/Appendable;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter12865 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.Formatter._Formatter12866 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Formatter._Formatter12867 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter12868 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.util.Formatter._Formatter12869 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.util.Formatter._Formatter12870 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter12871 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/PrintStream;)V");
			global::java.util.Formatter._Formatter12872 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::java.util.Formatter._Formatter12873 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
		}
	}
}
