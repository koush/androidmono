namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MessageFormat : java.text.Format
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MessageFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class Field : java.text.Format.Field
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Field(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			protected override global::java.lang.Object readResolve()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.MessageFormat.Field.staticClass, "readResolve", "()Ljava/lang/Object;", ref global::java.text.MessageFormat.Field._m0) as java.lang.Object;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			protected Field(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.text.MessageFormat.Field._m1.native == global::System.IntPtr.Zero)
					global::java.text.MessageFormat.Field._m1 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.Field.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.MessageFormat.Field.staticClass, global::java.text.MessageFormat.Field._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _ARGUMENT6735;
			public static global::java.text.MessageFormat.Field ARGUMENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.MessageFormat.Field.staticClass, _ARGUMENT6735)) as java.text.MessageFormat.Field;
				}
			}
			static Field()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.text.MessageFormat.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/MessageFormat$Field"));
				global::java.text.MessageFormat.Field._ARGUMENT6735 = @__env.GetStaticFieldIDNoThrow(global::java.text.MessageFormat.Field.staticClass, "ARGUMENT", "Ljava/text/MessageFormat$Field;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.MessageFormat.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.MessageFormat._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.MessageFormat.staticClass, "hashCode", "()I", ref global::java.text.MessageFormat._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.MessageFormat.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.MessageFormat._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.StringBuffer format(java.lang.Object[] arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.text.MessageFormat.staticClass, "format", "([Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", ref global::java.text.MessageFormat._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public sealed override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.text.MessageFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", ref global::java.text.MessageFormat._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.lang.String format(java.lang.String arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.MessageFormat._m5.native == global::System.IntPtr.Zero)
				global::java.text.MessageFormat._m5 = @__env.GetStaticMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.text.MessageFormat.staticClass, global::java.text.MessageFormat._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.Object[] parse(java.lang.String arg0, java.text.ParsePosition arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.text.MessageFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)[Ljava/lang/Object;", ref global::java.text.MessageFormat._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.Object[] parse(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.text.MessageFormat.staticClass, "parse", "(Ljava/lang/String;)[Ljava/lang/Object;", ref global::java.text.MessageFormat._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setLocale(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.MessageFormat.staticClass, "setLocale", "(Ljava/util/Locale;)V", ref global::java.text.MessageFormat._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setFormat(int arg0, java.text.Format arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.MessageFormat.staticClass, "setFormat", "(ILjava/text/Format;)V", ref global::java.text.MessageFormat._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.util.Locale Locale
		{
			get
			{
				return getLocale();
			}
			set
			{
				setLocale(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.util.Locale getLocale()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Locale>(this, global::java.text.MessageFormat.staticClass, "getLocale", "()Ljava/util/Locale;", ref global::java.text.MessageFormat._m10) as java.util.Locale;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.MessageFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", ref global::java.text.MessageFormat._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::java.text.AttributedCharacterIterator formatToCharacterIterator(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.text.AttributedCharacterIterator>(this, global::java.text.MessageFormat.staticClass, "formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;", ref global::java.text.MessageFormat._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.text.AttributedCharacterIterator;
		}
		public new global::java.text.Format[] Formats
		{
			get
			{
				return getFormats();
			}
			set
			{
				setFormats(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.text.Format[] getFormats()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.text.Format>(this, global::java.text.MessageFormat.staticClass, "getFormats", "()[Ljava/text/Format;", ref global::java.text.MessageFormat._m13) as java.text.Format[];
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void applyPattern(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.MessageFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V", ref global::java.text.MessageFormat._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.lang.String toPattern()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.MessageFormat.staticClass, "toPattern", "()Ljava/lang/String;", ref global::java.text.MessageFormat._m15) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setFormatsByArgumentIndex(java.text.Format[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.MessageFormat.staticClass, "setFormatsByArgumentIndex", "([Ljava/text/Format;)V", ref global::java.text.MessageFormat._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setFormats(java.text.Format[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.MessageFormat.staticClass, "setFormats", "([Ljava/text/Format;)V", ref global::java.text.MessageFormat._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setFormatByArgumentIndex(int arg0, java.text.Format arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.MessageFormat.staticClass, "setFormatByArgumentIndex", "(ILjava/text/Format;)V", ref global::java.text.MessageFormat._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.text.Format[] FormatsByArgumentIndex
		{
			get
			{
				return getFormatsByArgumentIndex();
			}
			set
			{
				setFormatsByArgumentIndex(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::java.text.Format[] getFormatsByArgumentIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.text.Format>(this, global::java.text.MessageFormat.staticClass, "getFormatsByArgumentIndex", "()[Ljava/text/Format;", ref global::java.text.MessageFormat._m19) as java.text.Format[];
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public MessageFormat(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.MessageFormat._m20.native == global::System.IntPtr.Zero)
				global::java.text.MessageFormat._m20 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.MessageFormat.staticClass, global::java.text.MessageFormat._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public MessageFormat(java.lang.String arg0, java.util.Locale arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.MessageFormat._m21.native == global::System.IntPtr.Zero)
				global::java.text.MessageFormat._m21 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.MessageFormat.staticClass, global::java.text.MessageFormat._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static MessageFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.MessageFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/MessageFormat"));
		}
	}
}
