namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Formatter : java.lang.Object, java.io.Closeable, java.io.Flushable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Formatter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.Formatter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString11942; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Formatter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11942)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Formatter.staticClass, _toString11942)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format11943; 
		public java.util.Formatter format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Formatter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Formatter>(@__env, @__env.CallObjectMethodPtr(this, _format11943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Formatter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Formatter.staticClass, _format11943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format11944; 
		public java.util.Formatter format(java.lang.String arg0, java.lang.Object[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Formatter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Formatter>(@__env, @__env.CallObjectMethodPtr(this, _format11944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Formatter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Formatter.staticClass, _format11944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _out11945; 
		public java.lang.Appendable @out() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Formatter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, _out11945)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Appendable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Formatter.staticClass, _out11945)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flush11946; 
		public void flush() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Formatter)) 
				@__env.CallVoidMethod(this, _flush11946); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Formatter.staticClass, _flush11946); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close11947; 
		public void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Formatter)) 
				@__env.CallVoidMethod(this, _close11947); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Formatter.staticClass, _close11947); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _locale11948; 
		public java.util.Locale locale() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Formatter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallObjectMethodPtr(this, _locale11948)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Formatter.staticClass, _locale11948)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ioException11949; 
		public java.io.IOException ioException() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Formatter)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.IOException>(@__env, @__env.CallObjectMethodPtr(this, _ioException11949)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.IOException>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Formatter.staticClass, _ioException11949)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter11950; 
		public Formatter(java.io.OutputStream arg0, java.lang.String arg1, java.util.Locale arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Formatter.staticClass, _Formatter11950, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter11951; 
		public Formatter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Formatter.staticClass, _Formatter11951, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter11952; 
		public Formatter(java.lang.Appendable arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Formatter.staticClass, _Formatter11952, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter11953; 
		public Formatter(java.util.Locale arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Formatter.staticClass, _Formatter11953, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter11954; 
		public Formatter(java.lang.Appendable arg0, java.util.Locale arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Formatter.staticClass, _Formatter11954, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter11955; 
		public Formatter(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Formatter.staticClass, _Formatter11955, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter11956; 
		public Formatter(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Formatter.staticClass, _Formatter11956, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter11957; 
		public Formatter(java.lang.String arg0, java.lang.String arg1, java.util.Locale arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Formatter.staticClass, _Formatter11957, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter11958; 
		public Formatter(java.io.File arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Formatter.staticClass, _Formatter11958, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter11959; 
		public Formatter(java.io.File arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Formatter.staticClass, _Formatter11959, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter11960; 
		public Formatter(java.io.File arg0, java.lang.String arg1, java.util.Locale arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Formatter.staticClass, _Formatter11960, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter11961; 
		public Formatter(java.io.PrintStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Formatter.staticClass, _Formatter11961, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter11962; 
		public Formatter(java.io.OutputStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Formatter.staticClass, _Formatter11962, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Formatter11963; 
		public Formatter(java.io.OutputStream arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Formatter.staticClass, _Formatter11963, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.Formatter.staticClass = @__class; 
			global::java.util.Formatter._toString11942 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.Formatter._format11943 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;"); 
			global::java.util.Formatter._format11944 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;"); 
			global::java.util.Formatter._out11945 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "@out", "()Ljava/lang/Appendable;"); 
			global::java.util.Formatter._flush11946 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "flush", "()V"); 
			global::java.util.Formatter._close11947 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "close", "()V"); 
			global::java.util.Formatter._locale11948 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "locale", "()Ljava/util/Locale;"); 
			global::java.util.Formatter._ioException11949 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "ioException", "()Ljava/io/IOException;"); 
			global::java.util.Formatter._Formatter11950 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/util/Locale;)V"); 
			global::java.util.Formatter._Formatter11951 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "()V"); 
			global::java.util.Formatter._Formatter11952 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/Appendable;)V"); 
			global::java.util.Formatter._Formatter11953 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/util/Locale;)V"); 
			global::java.util.Formatter._Formatter11954 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/Appendable;Ljava/util/Locale;)V"); 
			global::java.util.Formatter._Formatter11955 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::java.util.Formatter._Formatter11956 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.util.Formatter._Formatter11957 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)V"); 
			global::java.util.Formatter._Formatter11958 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;)V"); 
			global::java.util.Formatter._Formatter11959 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V"); 
			global::java.util.Formatter._Formatter11960 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;Ljava/util/Locale;)V"); 
			global::java.util.Formatter._Formatter11961 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/PrintStream;)V"); 
			global::java.util.Formatter._Formatter11962 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;)V"); 
			global::java.util.Formatter._Formatter11963 = @__env.GetMethodID(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;)V"); 
		} 
	} 
} 
