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
			internal static global::MonoJavaBridge.MethodId _values26186;
			public static global::java.util.Formatter.BigDecimalLayoutForm[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Formatter.BigDecimalLayoutForm>(@__env.CallStaticObjectMethod(java.util.Formatter.BigDecimalLayoutForm.staticClass, global::java.util.Formatter.BigDecimalLayoutForm._values26186)) as java.util.Formatter.BigDecimalLayoutForm[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf26187;
			public static global::java.util.Formatter.BigDecimalLayoutForm valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Formatter.BigDecimalLayoutForm>(@__env.CallStaticObjectMethod(java.util.Formatter.BigDecimalLayoutForm.staticClass, global::java.util.Formatter.BigDecimalLayoutForm._valueOf26187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Formatter.BigDecimalLayoutForm;
			}
			internal static global::MonoJavaBridge.FieldId _SCIENTIFIC26188;
			public static global::java.util.Formatter.BigDecimalLayoutForm SCIENTIFIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Formatter.BigDecimalLayoutForm>(@__env.GetStaticObjectField(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, _SCIENTIFIC26188)) as java.util.Formatter.BigDecimalLayoutForm;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DECIMAL_FLOAT26189;
			public static global::java.util.Formatter.BigDecimalLayoutForm DECIMAL_FLOAT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Formatter.BigDecimalLayoutForm>(@__env.GetStaticObjectField(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, _DECIMAL_FLOAT26189)) as java.util.Formatter.BigDecimalLayoutForm;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.util.Formatter.BigDecimalLayoutForm.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Formatter$BigDecimalLayoutForm"));
				global::java.util.Formatter.BigDecimalLayoutForm._values26186 = @__env.GetStaticMethodIDNoThrow(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, "values", "()[Ljava/util/Formatter/BigDecimalLayoutForm;");
				global::java.util.Formatter.BigDecimalLayoutForm._valueOf26187 = @__env.GetStaticMethodIDNoThrow(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/util/Formatter$BigDecimalLayoutForm;");
				global::java.util.Formatter.BigDecimalLayoutForm._SCIENTIFIC26188 = @__env.GetStaticFieldIDNoThrow(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, "SCIENTIFIC", "Ljava/util/Formatter$BigDecimalLayoutForm;");
				global::java.util.Formatter.BigDecimalLayoutForm._DECIMAL_FLOAT26189 = @__env.GetStaticFieldIDNoThrow(global::java.util.Formatter.BigDecimalLayoutForm.staticClass, "DECIMAL_FLOAT", "Ljava/util/Formatter$BigDecimalLayoutForm;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString26190;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._toString26190)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._toString26190)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _format26191;
		public global::java.util.Formatter format(java.util.Locale arg0, java.lang.String arg1, java.lang.Object[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Formatter>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._format26191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Formatter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Formatter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._format26191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Formatter;
		}
		internal static global::MonoJavaBridge.MethodId _format26192;
		public global::java.util.Formatter format(java.lang.String arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Formatter>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._format26192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Formatter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Formatter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._format26192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Formatter;
		}
		internal static global::MonoJavaBridge.MethodId _out26193;
		public global::java.lang.Appendable @out()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._out26193)) as java.lang.Appendable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Appendable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._out26193)) as java.lang.Appendable;
		}
		internal static global::MonoJavaBridge.MethodId _flush26194;
		public void flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Formatter._flush26194);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._flush26194);
		}
		internal static global::MonoJavaBridge.MethodId _close26195;
		public void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Formatter._close26195);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._close26195);
		}
		internal static global::MonoJavaBridge.MethodId _locale26196;
		public global::java.util.Locale locale()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._locale26196)) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._locale26196)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _ioException26197;
		public global::java.io.IOException ioException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Formatter._ioException26197)) as java.io.IOException;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Formatter.staticClass, global::java.util.Formatter._ioException26197)) as java.io.IOException;
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26198;
		public Formatter(java.io.OutputStream arg0, java.lang.String arg1, java.util.Locale arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26199;
		public Formatter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26199);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26200;
		public Formatter(java.lang.Appendable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26201;
		public Formatter(java.util.Locale arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26202;
		public Formatter(java.lang.Appendable arg0, java.util.Locale arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26203;
		public Formatter(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26204;
		public Formatter(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26205;
		public Formatter(java.lang.String arg0, java.lang.String arg1, java.util.Locale arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26206;
		public Formatter(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26207;
		public Formatter(java.io.File arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26208;
		public Formatter(java.io.File arg0, java.lang.String arg1, java.util.Locale arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26209;
		public Formatter(java.io.PrintStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26210;
		public Formatter(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Formatter26211;
		public Formatter(java.io.OutputStream arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Formatter.staticClass, global::java.util.Formatter._Formatter26211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Formatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Formatter"));
			global::java.util.Formatter._toString26190 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Formatter._format26191 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;");
			global::java.util.Formatter._format26192 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/util/Formatter;");
			global::java.util.Formatter._out26193 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "@out", "()Ljava/lang/Appendable;");
			global::java.util.Formatter._flush26194 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "flush", "()V");
			global::java.util.Formatter._close26195 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "close", "()V");
			global::java.util.Formatter._locale26196 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "locale", "()Ljava/util/Locale;");
			global::java.util.Formatter._ioException26197 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "ioException", "()Ljava/io/IOException;");
			global::java.util.Formatter._Formatter26198 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter26199 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "()V");
			global::java.util.Formatter._Formatter26200 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/Appendable;)V");
			global::java.util.Formatter._Formatter26201 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter26202 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/Appendable;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter26203 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.Formatter._Formatter26204 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Formatter._Formatter26205 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter26206 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;)V");
			global::java.util.Formatter._Formatter26207 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::java.util.Formatter._Formatter26208 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.util.Formatter._Formatter26209 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/PrintStream;)V");
			global::java.util.Formatter._Formatter26210 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::java.util.Formatter._Formatter26211 = @__env.GetMethodIDNoThrow(global::java.util.Formatter.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
		}
	}
}
