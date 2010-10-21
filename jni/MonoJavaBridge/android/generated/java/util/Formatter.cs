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
			internal static global::MonoJavaBridge.MethodId _values26067;
			public static global::java.util.Formatter.BigDecimalLayoutForm[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Formatter.BigDecimalLayoutForm>(@__env.CallStaticObjectMethod(java.util.Formatter.BigDecimalLayoutForm.staticClass, global::java.util.Formatter.BigDecimalLayoutForm._values26067)) as java.util.Formatter.BigDecimalLayoutForm[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf26068;
			public static global::java.util.Formatter.BigDecimalLayoutForm valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Formatter.BigDecimalLayoutForm.staticClass, global::java.util.Formatter.BigDecimalLayoutForm._valueOf26068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Formatter.BigDecimalLayoutForm;
			}
			internal static global::MonoJavaBridge.FieldId _SCIENTIFIC26069;
			public static global::java.util.Formatter.BigDecimalLayoutForm SCIENTIFIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, _SCIENTIFIC26069)) as java.util.Formatter.BigDecimalLayoutForm;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DECIMAL_FLOAT26070;
			public static global::java.util.Formatter.BigDecimalLayoutForm DECIMAL_FLOAT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, _DECIMAL_FLOAT26070)) as java.util.Formatter.BigDecimalLayoutForm;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.Formatter.BigDecimalLayoutForm.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Formatter$BigDecimalLayoutForm"));
				global::java.util.Formatter.BigDecimalLayoutForm._values26067 = @__env.GetStaticMethodIDNoThrow(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, "values", "()[Ljava/util/Formatter/BigDecimalLayoutForm;");
				global::java.util.Formatter.BigDecimalLayoutForm._valueOf26068 = @__env.GetStaticMethodIDNoThrow(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/util/Formatter$BigDecimalLayoutForm;");
				global::java.util.Formatter.BigDecimalLayoutForm._SCIENTIFIC26069 = @__env.GetStaticFieldIDNoThrow(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, "SCIENTIFIC", "Ljava/util/Formatter$BigDecimalLayoutForm;");
				global::java.util.Formatter.BigDecimalLayoutForm._DECIMAL_FLOAT26070 = @__env.GetStaticFieldIDNoThrow(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, "DECIMAL_FLOAT", "Ljava/util/Formatter$BigDecimalLayoutForm;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString26071;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._toString26071)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._toString26071)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _format26072;
		public global::java.util.Formatter format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._format26072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Formatter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._format26072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Formatter;
		}
		internal static global::MonoJavaBridge.MethodId _format26073;
		public global::java.util.Formatter format(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._format26073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Formatter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._format26073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Formatter;
		}
		internal static global::MonoJavaBridge.MethodId _out26074;
		public global::java.lang.Appendable @out() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._out26074)) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._out26074)) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _flush26075;
		public void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Formatter._flush26075);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._flush26075);
		}
		internal static global::MonoJavaBridge.MethodId _close26076;
		public void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Formatter._close26076);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._close26076);
		}
		internal static global::MonoJavaBridge.MethodId _locale26077;
		public global::java.util.Locale locale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._locale26077)) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._locale26077)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _ioException26078;
		public global::java.io.IOException ioException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._ioException26078)) as java.io.IOException;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._ioException26078)) as java.io.IOException;
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26079;
		public Formatter(java.io.OutputStream arg0, java.lang.String arg1, java.util.Locale arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26080;
		public Formatter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26080);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26081;
		public Formatter(java.lang.Appendable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26082;
		public Formatter(java.util.Locale arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26083;
		public Formatter(java.lang.Appendable arg0, java.util.Locale arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26084;
		public Formatter(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26085;
		public Formatter(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26086;
		public Formatter(java.lang.String arg0, java.lang.String arg1, java.util.Locale arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26087;
		public Formatter(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26088;
		public Formatter(java.io.File arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26089;
		public Formatter(java.io.File arg0, java.lang.String arg1, java.util.Locale arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26090;
		public Formatter(java.io.PrintStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26091;
		public Formatter(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26092;
		public Formatter(java.io.OutputStream arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Formatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Formatter"));
			global::java.util.Formatter._toString26071 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Formatter._format26072 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;");
			global::java.util.Formatter._format26073 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;");
			global::java.util.Formatter._out26074 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "@out", "()Ljava/lang/Appendable;");
			global::java.util.Formatter._flush26075 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "flush", "()V");
			global::java.util.Formatter._close26076 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "close", "()V");
			global::java.util.Formatter._locale26077 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "locale", "()Ljava/util/Locale;");
			global::java.util.Formatter._ioException26078 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "ioException", "()Ljava/io/IOException;");
			global::java.util.Formatter._Formatter26079 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter26080 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "()V");
			global::java.util.Formatter._Formatter26081 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/Appendable;)V");
			global::java.util.Formatter._Formatter26082 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter26083 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/Appendable;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter26084 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.Formatter._Formatter26085 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Formatter._Formatter26086 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter26087 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.util.Formatter._Formatter26088 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.util.Formatter._Formatter26089 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter26090 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/PrintStream;)V");
			global::java.util.Formatter._Formatter26091 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::java.util.Formatter._Formatter26092 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
		}
	}
}
