namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Formatter : java.lang.Object, java.io.Closeable, java.io.Flushable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Formatter()
		{
			InitJNI();
		}
		internal Formatter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class BigDecimalLayoutForm : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static BigDecimalLayoutForm()
			{
				InitJNI();
			}
			internal BigDecimalLayoutForm(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values20244;
			public static global::java.util.Formatter.BigDecimalLayoutForm[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Formatter.BigDecimalLayoutForm>(@__env.CallStaticObjectMethod(java.util.Formatter.BigDecimalLayoutForm.staticClass, global::java.util.Formatter.BigDecimalLayoutForm._values20244)) as java.util.Formatter.BigDecimalLayoutForm[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf20245;
			public static global::java.util.Formatter.BigDecimalLayoutForm valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Formatter.BigDecimalLayoutForm.staticClass, global::java.util.Formatter.BigDecimalLayoutForm._valueOf20245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Formatter.BigDecimalLayoutForm;
			}
			internal static global::MonoJavaBridge.FieldId _SCIENTIFIC20246;
			public static global::java.util.Formatter.BigDecimalLayoutForm SCIENTIFIC
			{
				get
				{
					return default(global::java.util.Formatter.BigDecimalLayoutForm);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DECIMAL_FLOAT20247;
			public static global::java.util.Formatter.BigDecimalLayoutForm DECIMAL_FLOAT
			{
				get
				{
					return default(global::java.util.Formatter.BigDecimalLayoutForm);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.Formatter.BigDecimalLayoutForm.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Formatter$BigDecimalLayoutForm"));
				global::java.util.Formatter.BigDecimalLayoutForm._values20244 = @__env.GetStaticMethodIDNoThrow(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, "values", "()[Ljava/util/Formatter/BigDecimalLayoutForm;");
				global::java.util.Formatter.BigDecimalLayoutForm._valueOf20245 = @__env.GetStaticMethodIDNoThrow(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/util/Formatter$BigDecimalLayoutForm;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString20248;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._toString20248)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._toString20248)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _format20249;
		public global::java.util.Formatter format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._format20249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Formatter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._format20249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Formatter;
		}
		internal static global::MonoJavaBridge.MethodId _format20250;
		public global::java.util.Formatter format(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._format20250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Formatter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._format20250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Formatter;
		}
		internal static global::MonoJavaBridge.MethodId _out20251;
		public global::java.lang.Appendable @out() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._out20251)) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._out20251)) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _flush20252;
		public void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Formatter._flush20252);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._flush20252);
		}
		internal static global::MonoJavaBridge.MethodId _close20253;
		public void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Formatter._close20253);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._close20253);
		}
		internal static global::MonoJavaBridge.MethodId _locale20254;
		public global::java.util.Locale locale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._locale20254)) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._locale20254)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _ioException20255;
		public global::java.io.IOException ioException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._ioException20255)) as java.io.IOException;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._ioException20255)) as java.io.IOException;
		}
		internal static global::MonoJavaBridge.MethodId _Formatter20256;
		public Formatter(java.io.OutputStream arg0, java.lang.String arg1, java.util.Locale arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter20256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter20257;
		public Formatter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter20257);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter20258;
		public Formatter(java.lang.Appendable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter20258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter20259;
		public Formatter(java.util.Locale arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter20259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter20260;
		public Formatter(java.lang.Appendable arg0, java.util.Locale arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter20260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter20261;
		public Formatter(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter20261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter20262;
		public Formatter(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter20262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter20263;
		public Formatter(java.lang.String arg0, java.lang.String arg1, java.util.Locale arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter20263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter20264;
		public Formatter(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter20264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter20265;
		public Formatter(java.io.File arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter20265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter20266;
		public Formatter(java.io.File arg0, java.lang.String arg1, java.util.Locale arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter20266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter20267;
		public Formatter(java.io.PrintStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter20267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter20268;
		public Formatter(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter20268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter20269;
		public Formatter(java.io.OutputStream arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter20269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Formatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Formatter"));
			global::java.util.Formatter._toString20248 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Formatter._format20249 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;");
			global::java.util.Formatter._format20250 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;");
			global::java.util.Formatter._out20251 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "@out", "()Ljava/lang/Appendable;");
			global::java.util.Formatter._flush20252 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "flush", "()V");
			global::java.util.Formatter._close20253 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "close", "()V");
			global::java.util.Formatter._locale20254 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "locale", "()Ljava/util/Locale;");
			global::java.util.Formatter._ioException20255 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "ioException", "()Ljava/io/IOException;");
			global::java.util.Formatter._Formatter20256 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter20257 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "()V");
			global::java.util.Formatter._Formatter20258 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/Appendable;)V");
			global::java.util.Formatter._Formatter20259 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter20260 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/Appendable;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter20261 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.Formatter._Formatter20262 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Formatter._Formatter20263 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter20264 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.util.Formatter._Formatter20265 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.util.Formatter._Formatter20266 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter20267 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/PrintStream;)V");
			global::java.util.Formatter._Formatter20268 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::java.util.Formatter._Formatter20269 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
		}
	}
}
