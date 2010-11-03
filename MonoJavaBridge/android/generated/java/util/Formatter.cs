namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Formatter : java.lang.Object, java.io.Closeable, java.io.Flushable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Formatter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class BigDecimalLayoutForm : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal BigDecimalLayoutForm(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::java.util.Formatter.BigDecimalLayoutForm[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.Formatter.BigDecimalLayoutForm._m0.native == global::System.IntPtr.Zero)
					global::java.util.Formatter.BigDecimalLayoutForm._m0 = @__env.GetStaticMethodIDNoThrow(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, "values", "()[Ljava/util/Formatter/BigDecimalLayoutForm;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Formatter.BigDecimalLayoutForm>(@__env.CallStaticObjectMethod(java.util.Formatter.BigDecimalLayoutForm.staticClass, global::java.util.Formatter.BigDecimalLayoutForm._m0)) as java.util.Formatter.BigDecimalLayoutForm[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::java.util.Formatter.BigDecimalLayoutForm valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.util.Formatter.BigDecimalLayoutForm._m1.native == global::System.IntPtr.Zero)
					global::java.util.Formatter.BigDecimalLayoutForm._m1 = @__env.GetStaticMethodIDNoThrow(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/util/Formatter$BigDecimalLayoutForm;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Formatter.BigDecimalLayoutForm>(@__env.CallStaticObjectMethod(java.util.Formatter.BigDecimalLayoutForm.staticClass, global::java.util.Formatter.BigDecimalLayoutForm._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Formatter.BigDecimalLayoutForm;
			}
			internal static global::MonoJavaBridge.FieldId _SCIENTIFIC6799;
			public static global::java.util.Formatter.BigDecimalLayoutForm SCIENTIFIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Formatter.BigDecimalLayoutForm>(@__env.GetStaticObjectField(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, _SCIENTIFIC6799)) as java.util.Formatter.BigDecimalLayoutForm;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DECIMAL_FLOAT6800;
			public static global::java.util.Formatter.BigDecimalLayoutForm DECIMAL_FLOAT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Formatter.BigDecimalLayoutForm>(@__env.GetStaticObjectField(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, _DECIMAL_FLOAT6800)) as java.util.Formatter.BigDecimalLayoutForm;
				}
			}
			static BigDecimalLayoutForm()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.Formatter.BigDecimalLayoutForm.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Formatter$BigDecimalLayoutForm"));
				global::java.util.Formatter.BigDecimalLayoutForm._SCIENTIFIC6799 = @__env.GetStaticFieldIDNoThrow(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, "SCIENTIFIC", "Ljava/util/Formatter$BigDecimalLayoutForm;");
				global::java.util.Formatter.BigDecimalLayoutForm._DECIMAL_FLOAT6800 = @__env.GetStaticFieldIDNoThrow(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, "DECIMAL_FLOAT", "Ljava/util/Formatter$BigDecimalLayoutForm;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Formatter.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.Formatter._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::java.util.Formatter format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Formatter>(this, global::java.util.Formatter.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;", ref global::java.util.Formatter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.util.Formatter;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.util.Formatter format(java.lang.String arg0, java.lang.Object[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Formatter>(this, global::java.util.Formatter.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;", ref global::java.util.Formatter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.Formatter;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.lang.Appendable @out()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Appendable>(this, global::java.util.Formatter.staticClass, "@out", "()Ljava/lang/Appendable;", ref global::java.util.Formatter._m3) as java.lang.Appendable;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Formatter.staticClass, "flush", "()V", ref global::java.util.Formatter._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Formatter.staticClass, "close", "()V", ref global::java.util.Formatter._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.util.Locale locale()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Locale>(this, global::java.util.Formatter.staticClass, "locale", "()Ljava/util/Locale;", ref global::java.util.Formatter._m6) as java.util.Locale;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::java.io.IOException ioException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Formatter.staticClass, "ioException", "()Ljava/io/IOException;", ref global::java.util.Formatter._m7) as java.io.IOException;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public Formatter(java.io.OutputStream arg0, java.lang.String arg1, java.util.Locale arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Formatter._m8.native == global::System.IntPtr.Zero)
				global::java.util.Formatter._m8 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public Formatter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Formatter._m9.native == global::System.IntPtr.Zero)
				global::java.util.Formatter._m9 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._m9);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public Formatter(java.lang.Appendable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Formatter._m10.native == global::System.IntPtr.Zero)
				global::java.util.Formatter._m10 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/Appendable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public Formatter(java.util.Locale arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Formatter._m11.native == global::System.IntPtr.Zero)
				global::java.util.Formatter._m11 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public Formatter(java.lang.Appendable arg0, java.util.Locale arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Formatter._m12.native == global::System.IntPtr.Zero)
				global::java.util.Formatter._m12 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/Appendable;Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public Formatter(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Formatter._m13.native == global::System.IntPtr.Zero)
				global::java.util.Formatter._m13 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public Formatter(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Formatter._m14.native == global::System.IntPtr.Zero)
				global::java.util.Formatter._m14 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public Formatter(java.lang.String arg0, java.lang.String arg1, java.util.Locale arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Formatter._m15.native == global::System.IntPtr.Zero)
				global::java.util.Formatter._m15 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public Formatter(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Formatter._m16.native == global::System.IntPtr.Zero)
				global::java.util.Formatter._m16 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public Formatter(java.io.File arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Formatter._m17.native == global::System.IntPtr.Zero)
				global::java.util.Formatter._m17 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public Formatter(java.io.File arg0, java.lang.String arg1, java.util.Locale arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Formatter._m18.native == global::System.IntPtr.Zero)
				global::java.util.Formatter._m18 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public Formatter(java.io.PrintStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Formatter._m19.native == global::System.IntPtr.Zero)
				global::java.util.Formatter._m19 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/PrintStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public Formatter(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Formatter._m20.native == global::System.IntPtr.Zero)
				global::java.util.Formatter._m20 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public Formatter(java.io.OutputStream arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Formatter._m21.native == global::System.IntPtr.Zero)
				global::java.util.Formatter._m21 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static Formatter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Formatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Formatter"));
		}
	}
}
