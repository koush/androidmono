namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateFormatSymbols : java.lang.Object, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DateFormatSymbols(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.DateFormatSymbols.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.DateFormatSymbols._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DateFormatSymbols.staticClass, "hashCode", "()I", ref global::java.text.DateFormatSymbols._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DateFormatSymbols.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.DateFormatSymbols._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.text.DateFormatSymbols getInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormatSymbols._m3.native == global::System.IntPtr.Zero)
				global::java.text.DateFormatSymbols._m3 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/DateFormatSymbols;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormatSymbols;
		}
		public static global::java.text.DateFormatSymbols Instance
		{
			get
			{
				return getInstance();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.text.DateFormatSymbols getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormatSymbols._m4.native == global::System.IntPtr.Zero)
				global::java.text.DateFormatSymbols._m4 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getInstance", "()Ljava/text/DateFormatSymbols;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._m4)) as java.text.DateFormatSymbols;
		}
		public static global::java.util.Locale[] AvailableLocales
		{
			get
			{
				return getAvailableLocales();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.util.Locale[] getAvailableLocales()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormatSymbols._m5.native == global::System.IntPtr.Zero)
				global::java.text.DateFormatSymbols._m5 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._m5)) as java.util.Locale[];
		}
		public new global::java.lang.String[] Eras
		{
			get
			{
				return getEras();
			}
			set
			{
				setEras(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String[] getEras()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.text.DateFormatSymbols.staticClass, "getEras", "()[Ljava/lang/String;", ref global::java.text.DateFormatSymbols._m6) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setEras(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DateFormatSymbols.staticClass, "setEras", "([Ljava/lang/String;)V", ref global::java.text.DateFormatSymbols._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String[] Months
		{
			get
			{
				return getMonths();
			}
			set
			{
				setMonths(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.String[] getMonths()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.text.DateFormatSymbols.staticClass, "getMonths", "()[Ljava/lang/String;", ref global::java.text.DateFormatSymbols._m8) as java.lang.String[];
		}
		public new global::java.lang.String[] ShortMonths
		{
			get
			{
				return getShortMonths();
			}
			set
			{
				setShortMonths(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.String[] getShortMonths()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.text.DateFormatSymbols.staticClass, "getShortMonths", "()[Ljava/lang/String;", ref global::java.text.DateFormatSymbols._m9) as java.lang.String[];
		}
		public new global::java.lang.String[] Weekdays
		{
			get
			{
				return getWeekdays();
			}
			set
			{
				setWeekdays(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.String[] getWeekdays()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.text.DateFormatSymbols.staticClass, "getWeekdays", "()[Ljava/lang/String;", ref global::java.text.DateFormatSymbols._m10) as java.lang.String[];
		}
		public new global::java.lang.String[] ShortWeekdays
		{
			get
			{
				return getShortWeekdays();
			}
			set
			{
				setShortWeekdays(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.String[] getShortWeekdays()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.text.DateFormatSymbols.staticClass, "getShortWeekdays", "()[Ljava/lang/String;", ref global::java.text.DateFormatSymbols._m11) as java.lang.String[];
		}
		public new global::java.lang.String[] AmPmStrings
		{
			get
			{
				return getAmPmStrings();
			}
			set
			{
				setAmPmStrings(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.String[] getAmPmStrings()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.text.DateFormatSymbols.staticClass, "getAmPmStrings", "()[Ljava/lang/String;", ref global::java.text.DateFormatSymbols._m12) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setMonths(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DateFormatSymbols.staticClass, "setMonths", "([Ljava/lang/String;)V", ref global::java.text.DateFormatSymbols._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setShortMonths(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DateFormatSymbols.staticClass, "setShortMonths", "([Ljava/lang/String;)V", ref global::java.text.DateFormatSymbols._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setWeekdays(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DateFormatSymbols.staticClass, "setWeekdays", "([Ljava/lang/String;)V", ref global::java.text.DateFormatSymbols._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setShortWeekdays(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DateFormatSymbols.staticClass, "setShortWeekdays", "([Ljava/lang/String;)V", ref global::java.text.DateFormatSymbols._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setAmPmStrings(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DateFormatSymbols.staticClass, "setAmPmStrings", "([Ljava/lang/String;)V", ref global::java.text.DateFormatSymbols._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String[][] ZoneStrings
		{
			get
			{
				return getZoneStrings();
			}
			set
			{
				setZoneStrings(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.lang.String[][] getZoneStrings()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String[]>(this, global::java.text.DateFormatSymbols.staticClass, "getZoneStrings", "()[[Ljava/lang/String;", ref global::java.text.DateFormatSymbols._m18) as java.lang.String[][];
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setZoneStrings(java.lang.String[][] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DateFormatSymbols.staticClass, "setZoneStrings", "([[Ljava/lang/String;)V", ref global::java.text.DateFormatSymbols._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String LocalPatternChars
		{
			get
			{
				return getLocalPatternChars();
			}
			set
			{
				setLocalPatternChars(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.lang.String getLocalPatternChars()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.DateFormatSymbols.staticClass, "getLocalPatternChars", "()Ljava/lang/String;", ref global::java.text.DateFormatSymbols._m20) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setLocalPatternChars(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DateFormatSymbols.staticClass, "setLocalPatternChars", "(Ljava/lang/String;)V", ref global::java.text.DateFormatSymbols._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public DateFormatSymbols() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormatSymbols._m22.native == global::System.IntPtr.Zero)
				global::java.text.DateFormatSymbols._m22 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._m22);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public DateFormatSymbols(java.util.Locale arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormatSymbols._m23.native == global::System.IntPtr.Zero)
				global::java.text.DateFormatSymbols._m23 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DateFormatSymbols()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DateFormatSymbols.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DateFormatSymbols"));
		}
	}
}
