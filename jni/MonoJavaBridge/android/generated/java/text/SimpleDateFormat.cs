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
		internal static global::MonoJavaBridge.MethodId _equals25511;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.SimpleDateFormat._equals25511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._equals25511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25512;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.SimpleDateFormat._hashCode25512);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._hashCode25512);
		}
		internal static global::MonoJavaBridge.MethodId _clone25513;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._clone25513)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._clone25513)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format25514;
		public override global::java.lang.StringBuffer format(java.util.Date arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._format25514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._format25514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _parse25515;
		public override global::java.util.Date parse(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._parse25515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._parse25515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _formatToCharacterIterator25516;
		public override global::java.text.AttributedCharacterIterator formatToCharacterIterator(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._formatToCharacterIterator25516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._formatToCharacterIterator25516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
		}
		internal static global::MonoJavaBridge.MethodId _applyPattern25517;
		public virtual void applyPattern(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat._applyPattern25517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._applyPattern25517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toPattern25518;
		public virtual global::java.lang.String toPattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._toPattern25518)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._toPattern25518)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toLocalizedPattern25519;
		public virtual global::java.lang.String toLocalizedPattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._toLocalizedPattern25519)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._toLocalizedPattern25519)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _applyLocalizedPattern25520;
		public virtual void applyLocalizedPattern(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat._applyLocalizedPattern25520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._applyLocalizedPattern25520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set2DigitYearStart25521;
		public virtual void set2DigitYearStart(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat._set2DigitYearStart25521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._set2DigitYearStart25521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get2DigitYearStart25522;
		public virtual global::java.util.Date get2DigitYearStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._get2DigitYearStart25522)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._get2DigitYearStart25522)) as java.util.Date;
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
		internal static global::MonoJavaBridge.MethodId _getDateFormatSymbols25523;
		public virtual global::java.text.DateFormatSymbols getDateFormatSymbols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._getDateFormatSymbols25523)) as java.text.DateFormatSymbols;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._getDateFormatSymbols25523)) as java.text.DateFormatSymbols;
		}
		internal static global::MonoJavaBridge.MethodId _setDateFormatSymbols25524;
		public virtual void setDateFormatSymbols(java.text.DateFormatSymbols arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat._setDateFormatSymbols25524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._setDateFormatSymbols25524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SimpleDateFormat25525;
		public SimpleDateFormat(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._SimpleDateFormat25525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleDateFormat25526;
		public SimpleDateFormat(java.lang.String arg0, java.util.Locale arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._SimpleDateFormat25526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleDateFormat25527;
		public SimpleDateFormat(java.lang.String arg0, java.text.DateFormatSymbols arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._SimpleDateFormat25527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleDateFormat25528;
		public SimpleDateFormat()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._SimpleDateFormat25528);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.SimpleDateFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/SimpleDateFormat"));
			global::java.text.SimpleDateFormat._equals25511 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.SimpleDateFormat._hashCode25512 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "hashCode", "()I");
			global::java.text.SimpleDateFormat._clone25513 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.SimpleDateFormat._format25514 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.SimpleDateFormat._parse25515 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;");
			global::java.text.SimpleDateFormat._formatToCharacterIterator25516 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;");
			global::java.text.SimpleDateFormat._applyPattern25517 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V");
			global::java.text.SimpleDateFormat._toPattern25518 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "toPattern", "()Ljava/lang/String;");
			global::java.text.SimpleDateFormat._toLocalizedPattern25519 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "toLocalizedPattern", "()Ljava/lang/String;");
			global::java.text.SimpleDateFormat._applyLocalizedPattern25520 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "applyLocalizedPattern", "(Ljava/lang/String;)V");
			global::java.text.SimpleDateFormat._set2DigitYearStart25521 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "set2DigitYearStart", "(Ljava/util/Date;)V");
			global::java.text.SimpleDateFormat._get2DigitYearStart25522 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "get2DigitYearStart", "()Ljava/util/Date;");
			global::java.text.SimpleDateFormat._getDateFormatSymbols25523 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "getDateFormatSymbols", "()Ljava/text/DateFormatSymbols;");
			global::java.text.SimpleDateFormat._setDateFormatSymbols25524 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "setDateFormatSymbols", "(Ljava/text/DateFormatSymbols;)V");
			global::java.text.SimpleDateFormat._SimpleDateFormat25525 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.SimpleDateFormat._SimpleDateFormat25526 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.text.SimpleDateFormat._SimpleDateFormat25527 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/text/DateFormatSymbols;)V");
			global::java.text.SimpleDateFormat._SimpleDateFormat25528 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "()V");
		}
	}
}
