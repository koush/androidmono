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
			internal static global::MonoJavaBridge.MethodId _readResolve25529;
			protected override global::java.lang.Object readResolve()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.MessageFormat.Field.staticClass, "readResolve", "()Ljava/lang/Object;", ref global::java.text.MessageFormat.Field._readResolve25529) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _Field25530;
			protected Field(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.text.MessageFormat.Field._Field25530.native == global::System.IntPtr.Zero)
					global::java.text.MessageFormat.Field._Field25530 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.Field.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.MessageFormat.Field.staticClass, global::java.text.MessageFormat.Field._Field25530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _ARGUMENT25531;
			public static global::java.text.MessageFormat.Field ARGUMENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.MessageFormat.Field.staticClass, _ARGUMENT25531)) as java.text.MessageFormat.Field;
				}
			}
			static Field()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.text.MessageFormat.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/MessageFormat$Field"));
				global::java.text.MessageFormat.Field._ARGUMENT25531 = @__env.GetStaticFieldIDNoThrow(global::java.text.MessageFormat.Field.staticClass, "ARGUMENT", "Ljava/text/MessageFormat$Field;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals25532;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.MessageFormat.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.MessageFormat._equals25532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25533;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.MessageFormat.staticClass, "hashCode", "()I", ref global::java.text.MessageFormat._hashCode25533);
		}
		internal static global::MonoJavaBridge.MethodId _clone25534;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.MessageFormat.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.MessageFormat._clone25534) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format25535;
		public virtual global::java.lang.StringBuffer format(java.lang.Object[] arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.text.MessageFormat.staticClass, "format", "([Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", ref global::java.text.MessageFormat._format25535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25536;
		public sealed override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.text.MessageFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", ref global::java.text.MessageFormat._format25536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25537;
		public static global::java.lang.String format(java.lang.String arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.MessageFormat._format25537.native == global::System.IntPtr.Zero)
				global::java.text.MessageFormat._format25537 = @__env.GetStaticMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.text.MessageFormat.staticClass, global::java.text.MessageFormat._format25537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parse25538;
		public virtual global::java.lang.Object[] parse(java.lang.String arg0, java.text.ParsePosition arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.text.MessageFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)[Ljava/lang/Object;", ref global::java.text.MessageFormat._parse25538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _parse25539;
		public virtual global::java.lang.Object[] parse(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.text.MessageFormat.staticClass, "parse", "(Ljava/lang/String;)[Ljava/lang/Object;", ref global::java.text.MessageFormat._parse25539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _setLocale25540;
		public virtual void setLocale(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.MessageFormat.staticClass, "setLocale", "(Ljava/util/Locale;)V", ref global::java.text.MessageFormat._setLocale25540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormat25541;
		public virtual void setFormat(int arg0, java.text.Format arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.MessageFormat.staticClass, "setFormat", "(ILjava/text/Format;)V", ref global::java.text.MessageFormat._setFormat25541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getLocale25542;
		public virtual global::java.util.Locale getLocale()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Locale>(this, global::java.text.MessageFormat.staticClass, "getLocale", "()Ljava/util/Locale;", ref global::java.text.MessageFormat._getLocale25542) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _parseObject25543;
		public override global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.MessageFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", ref global::java.text.MessageFormat._parseObject25543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _formatToCharacterIterator25544;
		public override global::java.text.AttributedCharacterIterator formatToCharacterIterator(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.text.AttributedCharacterIterator>(this, global::java.text.MessageFormat.staticClass, "formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;", ref global::java.text.MessageFormat._formatToCharacterIterator25544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.text.AttributedCharacterIterator;
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
		internal static global::MonoJavaBridge.MethodId _getFormats25545;
		public virtual global::java.text.Format[] getFormats()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.text.Format>(this, global::java.text.MessageFormat.staticClass, "getFormats", "()[Ljava/text/Format;", ref global::java.text.MessageFormat._getFormats25545) as java.text.Format[];
		}
		internal static global::MonoJavaBridge.MethodId _applyPattern25546;
		public virtual void applyPattern(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.MessageFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V", ref global::java.text.MessageFormat._applyPattern25546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toPattern25547;
		public virtual global::java.lang.String toPattern()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.MessageFormat.staticClass, "toPattern", "()Ljava/lang/String;", ref global::java.text.MessageFormat._toPattern25547) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFormatsByArgumentIndex25548;
		public virtual void setFormatsByArgumentIndex(java.text.Format[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.MessageFormat.staticClass, "setFormatsByArgumentIndex", "([Ljava/text/Format;)V", ref global::java.text.MessageFormat._setFormatsByArgumentIndex25548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormats25549;
		public virtual void setFormats(java.text.Format[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.MessageFormat.staticClass, "setFormats", "([Ljava/text/Format;)V", ref global::java.text.MessageFormat._setFormats25549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormatByArgumentIndex25550;
		public virtual void setFormatByArgumentIndex(int arg0, java.text.Format arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.MessageFormat.staticClass, "setFormatByArgumentIndex", "(ILjava/text/Format;)V", ref global::java.text.MessageFormat._setFormatByArgumentIndex25550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getFormatsByArgumentIndex25551;
		public virtual global::java.text.Format[] getFormatsByArgumentIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.text.Format>(this, global::java.text.MessageFormat.staticClass, "getFormatsByArgumentIndex", "()[Ljava/text/Format;", ref global::java.text.MessageFormat._getFormatsByArgumentIndex25551) as java.text.Format[];
		}
		internal static global::MonoJavaBridge.MethodId _MessageFormat25552;
		public MessageFormat(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.MessageFormat._MessageFormat25552.native == global::System.IntPtr.Zero)
				global::java.text.MessageFormat._MessageFormat25552 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.MessageFormat.staticClass, global::java.text.MessageFormat._MessageFormat25552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MessageFormat25553;
		public MessageFormat(java.lang.String arg0, java.util.Locale arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.MessageFormat._MessageFormat25553.native == global::System.IntPtr.Zero)
				global::java.text.MessageFormat._MessageFormat25553 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.MessageFormat.staticClass, global::java.text.MessageFormat._MessageFormat25553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static MessageFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.MessageFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/MessageFormat"));
		}
		internal static void InitJNI()
		{
		}
	}
}
