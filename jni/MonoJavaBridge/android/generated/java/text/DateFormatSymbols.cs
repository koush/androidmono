namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateFormatSymbols : java.lang.Object, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DateFormatSymbols()
		{
			InitJNI();
		}
		protected DateFormatSymbols(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals19507;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DateFormatSymbols._equals19507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._equals19507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19508;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DateFormatSymbols._hashCode19508);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._hashCode19508);
		}
		internal static global::MonoJavaBridge.MethodId _clone19509;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._clone19509)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._clone19509)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance19510;
		public static global::java.text.DateFormatSymbols getInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getInstance19510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormatSymbols;
		}
		public static global::java.text.DateFormatSymbols Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance19511;
		public static global::java.text.DateFormatSymbols getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getInstance19511)) as java.text.DateFormatSymbols;
		}
		public static global::java.util.Locale[] AvailableLocales
		{
			get
			{
				return getAvailableLocales();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales19512;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getAvailableLocales19512)) as java.util.Locale[];
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
		internal static global::MonoJavaBridge.MethodId _getEras19513;
		public virtual global::java.lang.String[] getEras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getEras19513)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getEras19513)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEras19514;
		public virtual void setEras(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setEras19514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setEras19514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMonths19515;
		public virtual global::java.lang.String[] getMonths() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getMonths19515)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getMonths19515)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.MethodId _getShortMonths19516;
		public virtual global::java.lang.String[] getShortMonths() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getShortMonths19516)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getShortMonths19516)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.MethodId _getWeekdays19517;
		public virtual global::java.lang.String[] getWeekdays() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getWeekdays19517)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getWeekdays19517)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.MethodId _getShortWeekdays19518;
		public virtual global::java.lang.String[] getShortWeekdays() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getShortWeekdays19518)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getShortWeekdays19518)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.MethodId _getAmPmStrings19519;
		public virtual global::java.lang.String[] getAmPmStrings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getAmPmStrings19519)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getAmPmStrings19519)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setMonths19520;
		public virtual void setMonths(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setMonths19520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setMonths19520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setShortMonths19521;
		public virtual void setShortMonths(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setShortMonths19521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setShortMonths19521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWeekdays19522;
		public virtual void setWeekdays(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setWeekdays19522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setWeekdays19522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setShortWeekdays19523;
		public virtual void setShortWeekdays(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setShortWeekdays19523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setShortWeekdays19523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAmPmStrings19524;
		public virtual void setAmPmStrings(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setAmPmStrings19524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setAmPmStrings19524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getZoneStrings19525;
		public virtual global::java.lang.String[][] getZoneStrings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String[]>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getZoneStrings19525)) as java.lang.String[][];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String[]>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getZoneStrings19525)) as java.lang.String[][];
		}
		internal static global::MonoJavaBridge.MethodId _setZoneStrings19526;
		public virtual void setZoneStrings(java.lang.String[][] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setZoneStrings19526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setZoneStrings19526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLocalPatternChars19527;
		public virtual global::java.lang.String getLocalPatternChars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getLocalPatternChars19527)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getLocalPatternChars19527)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setLocalPatternChars19528;
		public virtual void setLocalPatternChars(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setLocalPatternChars19528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setLocalPatternChars19528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DateFormatSymbols19529;
		public DateFormatSymbols()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._DateFormatSymbols19529);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DateFormatSymbols19530;
		public DateFormatSymbols(java.util.Locale arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._DateFormatSymbols19530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DateFormatSymbols.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DateFormatSymbols"));
			global::java.text.DateFormatSymbols._equals19507 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.DateFormatSymbols._hashCode19508 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "hashCode", "()I");
			global::java.text.DateFormatSymbols._clone19509 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.DateFormatSymbols._getInstance19510 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/DateFormatSymbols;");
			global::java.text.DateFormatSymbols._getInstance19511 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getInstance", "()Ljava/text/DateFormatSymbols;");
			global::java.text.DateFormatSymbols._getAvailableLocales19512 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.DateFormatSymbols._getEras19513 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getEras", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._setEras19514 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setEras", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._getMonths19515 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getMonths", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._getShortMonths19516 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getShortMonths", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._getWeekdays19517 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getWeekdays", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._getShortWeekdays19518 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getShortWeekdays", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._getAmPmStrings19519 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getAmPmStrings", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._setMonths19520 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setMonths", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._setShortMonths19521 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setShortMonths", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._setWeekdays19522 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setWeekdays", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._setShortWeekdays19523 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setShortWeekdays", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._setAmPmStrings19524 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setAmPmStrings", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._getZoneStrings19525 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getZoneStrings", "()[[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._setZoneStrings19526 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setZoneStrings", "([[Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._getLocalPatternChars19527 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getLocalPatternChars", "()Ljava/lang/String;");
			global::java.text.DateFormatSymbols._setLocalPatternChars19528 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setLocalPatternChars", "(Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._DateFormatSymbols19529 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "<init>", "()V");
			global::java.text.DateFormatSymbols._DateFormatSymbols19530 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "<init>", "(Ljava/util/Locale;)V");
		}
	}
}
