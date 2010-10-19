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
		internal static global::MonoJavaBridge.MethodId _equals19735;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.SimpleDateFormat._equals19735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._equals19735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19736;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.SimpleDateFormat._hashCode19736);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._hashCode19736);
		}
		internal static global::MonoJavaBridge.MethodId _clone19737;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._clone19737)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._clone19737)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format19738;
		public override global::java.lang.StringBuffer format(java.util.Date arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._format19738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._format19738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _parse19739;
		public override global::java.util.Date parse(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._parse19739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._parse19739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _formatToCharacterIterator19740;
		public override global::java.text.AttributedCharacterIterator formatToCharacterIterator(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._formatToCharacterIterator19740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._formatToCharacterIterator19740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
		}
		internal static global::MonoJavaBridge.MethodId _applyPattern19741;
		public virtual void applyPattern(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat._applyPattern19741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._applyPattern19741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toPattern19742;
		public virtual global::java.lang.String toPattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._toPattern19742)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._toPattern19742)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toLocalizedPattern19743;
		public virtual global::java.lang.String toLocalizedPattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._toLocalizedPattern19743)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._toLocalizedPattern19743)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _applyLocalizedPattern19744;
		public virtual void applyLocalizedPattern(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat._applyLocalizedPattern19744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._applyLocalizedPattern19744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set2DigitYearStart19745;
		public virtual void set2DigitYearStart(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat._set2DigitYearStart19745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._set2DigitYearStart19745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get2DigitYearStart19746;
		public virtual global::java.util.Date get2DigitYearStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._get2DigitYearStart19746)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._get2DigitYearStart19746)) as java.util.Date;
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
		internal static global::MonoJavaBridge.MethodId _getDateFormatSymbols19747;
		public virtual global::java.text.DateFormatSymbols getDateFormatSymbols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat._getDateFormatSymbols19747)) as java.text.DateFormatSymbols;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._getDateFormatSymbols19747)) as java.text.DateFormatSymbols;
		}
		internal static global::MonoJavaBridge.MethodId _setDateFormatSymbols19748;
		public virtual void setDateFormatSymbols(java.text.DateFormatSymbols arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat._setDateFormatSymbols19748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._setDateFormatSymbols19748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SimpleDateFormat19749;
		public SimpleDateFormat(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._SimpleDateFormat19749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleDateFormat19750;
		public SimpleDateFormat(java.lang.String arg0, java.util.Locale arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._SimpleDateFormat19750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleDateFormat19751;
		public SimpleDateFormat(java.lang.String arg0, java.text.DateFormatSymbols arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._SimpleDateFormat19751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SimpleDateFormat19752;
		public SimpleDateFormat()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._SimpleDateFormat19752);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.SimpleDateFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/SimpleDateFormat"));
			global::java.text.SimpleDateFormat._equals19735 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.SimpleDateFormat._hashCode19736 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "hashCode", "()I");
			global::java.text.SimpleDateFormat._clone19737 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.SimpleDateFormat._format19738 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.SimpleDateFormat._parse19739 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;");
			global::java.text.SimpleDateFormat._formatToCharacterIterator19740 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;");
			global::java.text.SimpleDateFormat._applyPattern19741 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V");
			global::java.text.SimpleDateFormat._toPattern19742 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "toPattern", "()Ljava/lang/String;");
			global::java.text.SimpleDateFormat._toLocalizedPattern19743 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "toLocalizedPattern", "()Ljava/lang/String;");
			global::java.text.SimpleDateFormat._applyLocalizedPattern19744 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "applyLocalizedPattern", "(Ljava/lang/String;)V");
			global::java.text.SimpleDateFormat._set2DigitYearStart19745 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "set2DigitYearStart", "(Ljava/util/Date;)V");
			global::java.text.SimpleDateFormat._get2DigitYearStart19746 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "get2DigitYearStart", "()Ljava/util/Date;");
			global::java.text.SimpleDateFormat._getDateFormatSymbols19747 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "getDateFormatSymbols", "()Ljava/text/DateFormatSymbols;");
			global::java.text.SimpleDateFormat._setDateFormatSymbols19748 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "setDateFormatSymbols", "(Ljava/text/DateFormatSymbols;)V");
			global::java.text.SimpleDateFormat._SimpleDateFormat19749 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.SimpleDateFormat._SimpleDateFormat19750 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/util/Locale;)V");
			global::java.text.SimpleDateFormat._SimpleDateFormat19751 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/text/DateFormatSymbols;)V");
			global::java.text.SimpleDateFormat._SimpleDateFormat19752 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "()V");
		}
	}
}
