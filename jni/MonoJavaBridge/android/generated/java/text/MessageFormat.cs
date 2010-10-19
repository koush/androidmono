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
			internal static global::MonoJavaBridge.MethodId _readResolve19636;
			protected override global::java.lang.Object readResolve() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat.Field._readResolve19636)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.Field.staticClass, global::java.text.MessageFormat.Field._readResolve19636)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _Field19637;
			protected Field(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.MessageFormat.Field.staticClass, global::java.text.MessageFormat.Field._Field19637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _ARGUMENT19638;
			public static global::java.text.MessageFormat.Field ARGUMENT
			{
				get
				{
					return default(global::java.text.MessageFormat.Field);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.text.MessageFormat.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/MessageFormat$Field"));
				global::java.text.MessageFormat.Field._readResolve19636 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.Field.staticClass, "readResolve", "()Ljava/lang/Object;");
				global::java.text.MessageFormat.Field._Field19637 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.Field.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals19639;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.MessageFormat._equals19639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._equals19639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19640;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.MessageFormat._hashCode19640);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._hashCode19640);
		}
		internal static global::MonoJavaBridge.MethodId _clone19641;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._clone19641)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._clone19641)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format19642;
		public virtual global::java.lang.StringBuffer format(java.lang.Object[] arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._format19642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._format19642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format19643;
		public sealed override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._format19643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._format19643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format19644;
		public static global::java.lang.String format(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.MessageFormat.staticClass, global::java.text.MessageFormat._format19644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parse19645;
		public virtual global::java.lang.Object[] parse(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._parse19645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._parse19645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _parse19646;
		public virtual global::java.lang.Object[] parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._parse19646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._parse19646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _setLocale19647;
		public virtual void setLocale(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.MessageFormat._setLocale19647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._setLocale19647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormat19648;
		public virtual void setFormat(int arg0, java.text.Format arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.MessageFormat._setFormat19648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._setFormat19648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getLocale19649;
		public virtual global::java.util.Locale getLocale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._getLocale19649)) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._getLocale19649)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _parseObject19650;
		public override global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._parseObject19650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._parseObject19650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _formatToCharacterIterator19651;
		public override global::java.text.AttributedCharacterIterator formatToCharacterIterator(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._formatToCharacterIterator19651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._formatToCharacterIterator19651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
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
		internal static global::MonoJavaBridge.MethodId _getFormats19652;
		public virtual global::java.text.Format[] getFormats() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.text.Format>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._getFormats19652)) as java.text.Format[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.text.Format>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._getFormats19652)) as java.text.Format[];
		}
		internal static global::MonoJavaBridge.MethodId _applyPattern19653;
		public virtual void applyPattern(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.MessageFormat._applyPattern19653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._applyPattern19653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toPattern19654;
		public virtual global::java.lang.String toPattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._toPattern19654)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._toPattern19654)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFormatsByArgumentIndex19655;
		public virtual void setFormatsByArgumentIndex(java.text.Format[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.MessageFormat._setFormatsByArgumentIndex19655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._setFormatsByArgumentIndex19655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormats19656;
		public virtual void setFormats(java.text.Format[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.MessageFormat._setFormats19656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._setFormats19656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormatByArgumentIndex19657;
		public virtual void setFormatByArgumentIndex(int arg0, java.text.Format arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.MessageFormat._setFormatByArgumentIndex19657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._setFormatByArgumentIndex19657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getFormatsByArgumentIndex19658;
		public virtual global::java.text.Format[] getFormatsByArgumentIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.text.Format>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.MessageFormat._getFormatsByArgumentIndex19658)) as java.text.Format[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.text.Format>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.MessageFormat.staticClass, global::java.text.MessageFormat._getFormatsByArgumentIndex19658)) as java.text.Format[];
		}
		internal static global::MonoJavaBridge.MethodId _MessageFormat19659;
		public MessageFormat(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.MessageFormat.staticClass, global::java.text.MessageFormat._MessageFormat19659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MessageFormat19660;
		public MessageFormat(java.lang.String arg0, java.util.Locale arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.MessageFormat.staticClass, global::java.text.MessageFormat._MessageFormat19660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.MessageFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/MessageFormat"));
			global::java.text.MessageFormat._equals19639 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.MessageFormat._hashCode19640 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "hashCode", "()I");
			global::java.text.MessageFormat._clone19641 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.MessageFormat._format19642 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "format", "([Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.MessageFormat._format19643 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.MessageFormat._format19644 = @__env.GetStaticMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;");
			global::java.text.MessageFormat._parse19645 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)[Ljava/lang/Object;");
			global::java.text.MessageFormat._parse19646 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "parse", "(Ljava/lang/String;)[Ljava/lang/Object;");
			global::java.text.MessageFormat._setLocale19647 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "setLocale", "(Ljava/util/Locale;)V");
			global::java.text.MessageFormat._setFormat19648 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "setFormat", "(ILjava/text/Format;)V");
			global::java.text.MessageFormat._getLocale19649 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "getLocale", "()Ljava/util/Locale;");
			global::java.text.MessageFormat._parseObject19650 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;");
			global::java.text.MessageFormat._formatToCharacterIterator19651 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;");
			global::java.text.MessageFormat._getFormats19652 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "getFormats", "()[Ljava/text/Format;");
			global::java.text.MessageFormat._applyPattern19653 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V");
			global::java.text.MessageFormat._toPattern19654 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "toPattern", "()Ljava/lang/String;");
			global::java.text.MessageFormat._setFormatsByArgumentIndex19655 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "setFormatsByArgumentIndex", "([Ljava/text/Format;)V");
			global::java.text.MessageFormat._setFormats19656 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "setFormats", "([Ljava/text/Format;)V");
			global::java.text.MessageFormat._setFormatByArgumentIndex19657 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "setFormatByArgumentIndex", "(ILjava/text/Format;)V");
			global::java.text.MessageFormat._getFormatsByArgumentIndex19658 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "getFormatsByArgumentIndex", "()[Ljava/text/Format;");
			global::java.text.MessageFormat._MessageFormat19659 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.MessageFormat._MessageFormat19660 = @__env.GetMethodIDNoThrow(global::java.text.MessageFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/util/Locale;)V");
		}
	}
}
