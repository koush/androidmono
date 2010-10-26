namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MessageFormat : java.text.Format
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MessageFormat()
		{
			InitJNI();
		}
		protected MessageFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class Field : java.text.Format.Field
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Field()
			{
				InitJNI();
			}
			protected Field(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _readResolve25528;
			protected override global::java.lang.Object readResolve() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat.Field._readResolve25528)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.Field.staticClass, global::java.text.MessageFormat.Field._readResolve25528)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _Field25529;
			protected Field(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.MessageFormat.Field.staticClass, global::java.text.MessageFormat.Field._Field25529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _ARGUMENT25530;
			public static global::java.text.MessageFormat.Field ARGUMENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.MessageFormat.Field.staticClass, _ARGUMENT25530)) as java.text.MessageFormat.Field;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.text.MessageFormat.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/MessageFormat$Field"));
				global::java.text.MessageFormat.Field._readResolve25528 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.Field.staticClass, "readResolve", "()Ljava/lang/Object;");
				global::java.text.MessageFormat.Field._Field25529 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.Field.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::java.text.MessageFormat.Field._ARGUMENT25530 = @__env.GetStaticFieldIDNoThrow(global::java.text.MessageFormat.Field.staticClass, "ARGUMENT", "Ljava/text/MessageFormat$Field;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals25531;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.MessageFormat._equals25531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._equals25531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25532;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.MessageFormat._hashCode25532);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._hashCode25532);
		}
		internal static global::MonoJavaBridge.MethodId _clone25533;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._clone25533)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._clone25533)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format25534;
		public virtual global::java.lang.StringBuffer format(java.lang.Object[] arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._format25534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._format25534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25535;
		public sealed override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._format25535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._format25535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25536;
		public static global::java.lang.String format(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.text.MessageFormat.staticClass, global::java.text.MessageFormat._format25536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parse25537;
		public virtual global::java.lang.Object[] parse(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._parse25537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._parse25537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _parse25538;
		public virtual global::java.lang.Object[] parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._parse25538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._parse25538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _setLocale25539;
		public virtual void setLocale(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.MessageFormat._setLocale25539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._setLocale25539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormat25540;
		public virtual void setFormat(int arg0, java.text.Format arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.MessageFormat._setFormat25540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._setFormat25540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getLocale25541;
		public virtual global::java.util.Locale getLocale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._getLocale25541)) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._getLocale25541)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _parseObject25542;
		public override global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._parseObject25542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._parseObject25542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _formatToCharacterIterator25543;
		public override global::java.text.AttributedCharacterIterator formatToCharacterIterator(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._formatToCharacterIterator25543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._formatToCharacterIterator25543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
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
		internal static global::MonoJavaBridge.MethodId _getFormats25544;
		public virtual global::java.text.Format[] getFormats() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.text.Format>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._getFormats25544)) as java.text.Format[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.text.Format>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._getFormats25544)) as java.text.Format[];
		}
		internal static global::MonoJavaBridge.MethodId _applyPattern25545;
		public virtual void applyPattern(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.MessageFormat._applyPattern25545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._applyPattern25545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toPattern25546;
		public virtual global::java.lang.String toPattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._toPattern25546)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._toPattern25546)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFormatsByArgumentIndex25547;
		public virtual void setFormatsByArgumentIndex(java.text.Format[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.MessageFormat._setFormatsByArgumentIndex25547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._setFormatsByArgumentIndex25547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormats25548;
		public virtual void setFormats(java.text.Format[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.MessageFormat._setFormats25548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._setFormats25548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormatByArgumentIndex25549;
		public virtual void setFormatByArgumentIndex(int arg0, java.text.Format arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.MessageFormat._setFormatByArgumentIndex25549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._setFormatByArgumentIndex25549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getFormatsByArgumentIndex25550;
		public virtual global::java.text.Format[] getFormatsByArgumentIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.text.Format>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._getFormatsByArgumentIndex25550)) as java.text.Format[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.text.Format>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._getFormatsByArgumentIndex25550)) as java.text.Format[];
		}
		internal static global::MonoJavaBridge.MethodId _MessageFormat25551;
		public MessageFormat(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.MessageFormat.staticClass, global::java.text.MessageFormat._MessageFormat25551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MessageFormat25552;
		public MessageFormat(java.lang.String arg0, java.util.Locale arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.MessageFormat.staticClass, global::java.text.MessageFormat._MessageFormat25552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.MessageFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/MessageFormat"));
			global::java.text.MessageFormat._equals25531 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.MessageFormat._hashCode25532 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "hashCode", "()I");
			global::java.text.MessageFormat._clone25533 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.MessageFormat._format25534 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "format", "([Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.MessageFormat._format25535 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.MessageFormat._format25536 = @__env.GetStaticMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;");
			global::java.text.MessageFormat._parse25537 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)[Ljava/lang/Object;");
			global::java.text.MessageFormat._parse25538 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "parse", "(Ljava/lang/String;)[Ljava/lang/Object;");
			global::java.text.MessageFormat._setLocale25539 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "setLocale", "(Ljava/util/Locale;)V");
			global::java.text.MessageFormat._setFormat25540 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "setFormat", "(ILjava/text/Format;)V");
			global::java.text.MessageFormat._getLocale25541 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "getLocale", "()Ljava/util/Locale;");
			global::java.text.MessageFormat._parseObject25542 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;");
			global::java.text.MessageFormat._formatToCharacterIterator25543 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;");
			global::java.text.MessageFormat._getFormats25544 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "getFormats", "()[Ljava/text/Format;");
			global::java.text.MessageFormat._applyPattern25545 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V");
			global::java.text.MessageFormat._toPattern25546 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "toPattern", "()Ljava/lang/String;");
			global::java.text.MessageFormat._setFormatsByArgumentIndex25547 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "setFormatsByArgumentIndex", "([Ljava/text/Format;)V");
			global::java.text.MessageFormat._setFormats25548 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "setFormats", "([Ljava/text/Format;)V");
			global::java.text.MessageFormat._setFormatByArgumentIndex25549 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "setFormatByArgumentIndex", "(ILjava/text/Format;)V");
			global::java.text.MessageFormat._getFormatsByArgumentIndex25550 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "getFormatsByArgumentIndex", "()[Ljava/text/Format;");
			global::java.text.MessageFormat._MessageFormat25551 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.MessageFormat._MessageFormat25552 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/util/Locale;)V");
		}
	}
}
