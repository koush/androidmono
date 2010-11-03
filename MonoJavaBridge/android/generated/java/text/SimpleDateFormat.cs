namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SimpleDateFormat : java.text.DateFormat
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SimpleDateFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.SimpleDateFormat.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.SimpleDateFormat._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.SimpleDateFormat.staticClass, "hashCode", "()I", ref global::java.text.SimpleDateFormat._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.SimpleDateFormat.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.SimpleDateFormat._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.StringBuffer format(java.util.Date arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.text.SimpleDateFormat.staticClass, "format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", ref global::java.text.SimpleDateFormat._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.util.Date parse(java.lang.String arg0, java.text.ParsePosition arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.SimpleDateFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;", ref global::java.text.SimpleDateFormat._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.text.AttributedCharacterIterator formatToCharacterIterator(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.text.AttributedCharacterIterator>(this, global::java.text.SimpleDateFormat.staticClass, "formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;", ref global::java.text.SimpleDateFormat._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.text.AttributedCharacterIterator;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void applyPattern(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.SimpleDateFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V", ref global::java.text.SimpleDateFormat._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String toPattern()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.SimpleDateFormat.staticClass, "toPattern", "()Ljava/lang/String;", ref global::java.text.SimpleDateFormat._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.String toLocalizedPattern()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.SimpleDateFormat.staticClass, "toLocalizedPattern", "()Ljava/lang/String;", ref global::java.text.SimpleDateFormat._m8) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void applyLocalizedPattern(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.SimpleDateFormat.staticClass, "applyLocalizedPattern", "(Ljava/lang/String;)V", ref global::java.text.SimpleDateFormat._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void set2DigitYearStart(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.SimpleDateFormat.staticClass, "set2DigitYearStart", "(Ljava/util/Date;)V", ref global::java.text.SimpleDateFormat._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.util.Date get2DigitYearStart()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.SimpleDateFormat.staticClass, "get2DigitYearStart", "()Ljava/util/Date;", ref global::java.text.SimpleDateFormat._m11) as java.util.Date;
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
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.text.DateFormatSymbols getDateFormatSymbols()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.SimpleDateFormat.staticClass, "getDateFormatSymbols", "()Ljava/text/DateFormatSymbols;", ref global::java.text.SimpleDateFormat._m12) as java.text.DateFormatSymbols;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setDateFormatSymbols(java.text.DateFormatSymbols arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.SimpleDateFormat.staticClass, "setDateFormatSymbols", "(Ljava/text/DateFormatSymbols;)V", ref global::java.text.SimpleDateFormat._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public SimpleDateFormat(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.SimpleDateFormat._m14.native == global::System.IntPtr.Zero)
				global::java.text.SimpleDateFormat._m14 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public SimpleDateFormat(java.lang.String arg0, java.util.Locale arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.SimpleDateFormat._m15.native == global::System.IntPtr.Zero)
				global::java.text.SimpleDateFormat._m15 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public SimpleDateFormat(java.lang.String arg0, java.text.DateFormatSymbols arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.SimpleDateFormat._m16.native == global::System.IntPtr.Zero)
				global::java.text.SimpleDateFormat._m16 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/text/DateFormatSymbols;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public SimpleDateFormat() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.SimpleDateFormat._m17.native == global::System.IntPtr.Zero)
				global::java.text.SimpleDateFormat._m17 = @__env.GetMethodIDNoThrow(global::java.text.SimpleDateFormat.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.SimpleDateFormat.staticClass, global::java.text.SimpleDateFormat._m17);
			Init(@__env, handle);
		}
		static SimpleDateFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.SimpleDateFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/SimpleDateFormat"));
		}
	}
}
