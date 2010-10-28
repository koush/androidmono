namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SimpleDateFormat : java.text.DateFormat
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SimpleDateFormat()
		{
			InitJNI();
		}
		protected SimpleDateFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25630;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.SimpleDateFormat._equals25630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._equals25630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25631;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.SimpleDateFormat._hashCode25631);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._hashCode25631);
		}
		internal static global::MonoJavaBridge.MethodId _clone25632;
		public override global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._clone25632)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._clone25632)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format25633;
		public override global::java.lang.StringBuffer format(java.util.Date arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._format25633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._format25633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _parse25634;
		public override global::java.util.Date parse(java.lang.String arg0, java.text.ParsePosition arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._parse25634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._parse25634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _formatToCharacterIterator25635;
		public override global::java.text.AttributedCharacterIterator formatToCharacterIterator(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._formatToCharacterIterator25635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._formatToCharacterIterator25635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
		}
		internal static global::MonoJavaBridge.MethodId _applyPattern25636;
		public virtual void applyPattern(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat._applyPattern25636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._applyPattern25636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toPattern25637;
		public virtual global::java.lang.String toPattern()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._toPattern25637)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._toPattern25637)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toLocalizedPattern25638;
		public virtual global::java.lang.String toLocalizedPattern()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._toLocalizedPattern25638)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._toLocalizedPattern25638)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _applyLocalizedPattern25639;
		public virtual void applyLocalizedPattern(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat._applyLocalizedPattern25639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._applyLocalizedPattern25639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set2DigitYearStart25640;
		public virtual void set2DigitYearStart(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat._set2DigitYearStart25640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._set2DigitYearStart25640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get2DigitYearStart25641;
		public virtual global::java.util.Date get2DigitYearStart()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._get2DigitYearStart25641)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._get2DigitYearStart25641)) as java.util.Date;
		}
		public new global::java.text.DateFormatSymbols DateFormatSymbols
		{
			get
			{
				return getDateFormatSymbols();
			}
			set
			{
				setDateFormatSymbols(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDateFormatSymbols25642;
		public virtual global::java.text.DateFormatSymbols getDateFormatSymbols()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._getDateFormatSymbols25642)) as java.text.DateFormatSymbols;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._getDateFormatSymbols25642)) as java.text.DateFormatSymbols;
		}
		internal static global::MonoJavaBridge.MethodId _setDateFormatSymbols25643;
		public virtual void setDateFormatSymbols(java.text.DateFormatSymbols arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat._setDateFormatSymbols25643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._setDateFormatSymbols25643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SimpleDateFormat25644;
		public SimpleDateFormat(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._SimpleDateFormat25644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleDateFormat25645;
		public SimpleDateFormat(java.lang.String arg0, java.util.Locale arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._SimpleDateFormat25645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleDateFormat25646;
		public SimpleDateFormat(java.lang.String arg0, java.text.DateFormatSymbols arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._SimpleDateFormat25646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleDateFormat25647;
		public SimpleDateFormat() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._SimpleDateFormat25647);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.SimpleDateFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/SimpleDateFormat"));
			global::java.text.SimpleDateFormat._equals25630 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.SimpleDateFormat._hashCode25631 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "hashCode", "()I");
			global::java.text.SimpleDateFormat._clone25632 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.SimpleDateFormat._format25633 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.SimpleDateFormat._parse25634 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;");
			global::java.text.SimpleDateFormat._formatToCharacterIterator25635 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;");
			global::java.text.SimpleDateFormat._applyPattern25636 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V");
			global::java.text.SimpleDateFormat._toPattern25637 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "toPattern", "()Ljava/lang/String;");
			global::java.text.SimpleDateFormat._toLocalizedPattern25638 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "toLocalizedPattern", "()Ljava/lang/String;");
			global::java.text.SimpleDateFormat._applyLocalizedPattern25639 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "applyLocalizedPattern", "(Ljava/lang/String;)V");
			global::java.text.SimpleDateFormat._set2DigitYearStart25640 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "set2DigitYearStart", "(Ljava/util/Date;)V");
			global::java.text.SimpleDateFormat._get2DigitYearStart25641 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "get2DigitYearStart", "()Ljava/util/Date;");
			global::java.text.SimpleDateFormat._getDateFormatSymbols25642 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "getDateFormatSymbols", "()Ljava/text/DateFormatSymbols;");
			global::java.text.SimpleDateFormat._setDateFormatSymbols25643 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "setDateFormatSymbols", "(Ljava/text/DateFormatSymbols;)V");
			global::java.text.SimpleDateFormat._SimpleDateFormat25644 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.SimpleDateFormat._SimpleDateFormat25645 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.text.SimpleDateFormat._SimpleDateFormat25646 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/text/DateFormatSymbols;)V");
			global::java.text.SimpleDateFormat._SimpleDateFormat25647 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "()V");
		}
	}
}
