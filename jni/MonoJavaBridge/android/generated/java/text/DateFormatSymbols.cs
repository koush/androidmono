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
		internal static global::MonoJavaBridge.MethodId _equals25281;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DateFormatSymbols._equals25281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._equals25281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25282;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DateFormatSymbols._hashCode25282);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._hashCode25282);
		}
		internal static global::MonoJavaBridge.MethodId _clone25283;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._clone25283)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._clone25283)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25284;
		public static global::java.text.DateFormatSymbols getInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getInstance25284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormatSymbols;
		}
		public static global::java.text.DateFormatSymbols Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25285;
		public static global::java.text.DateFormatSymbols getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getInstance25285)) as java.text.DateFormatSymbols;
		}
		public static global::java.util.Locale[] AvailableLocales
		{
			get
			{
				return getAvailableLocales();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales25286;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getAvailableLocales25286)) as java.util.Locale[];
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
		internal static global::MonoJavaBridge.MethodId _getEras25287;
		public virtual global::java.lang.String[] getEras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getEras25287)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getEras25287)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEras25288;
		public virtual void setEras(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setEras25288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setEras25288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMonths25289;
		public virtual global::java.lang.String[] getMonths() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getMonths25289)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getMonths25289)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.MethodId _getShortMonths25290;
		public virtual global::java.lang.String[] getShortMonths() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getShortMonths25290)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getShortMonths25290)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.MethodId _getWeekdays25291;
		public virtual global::java.lang.String[] getWeekdays() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getWeekdays25291)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getWeekdays25291)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.MethodId _getShortWeekdays25292;
		public virtual global::java.lang.String[] getShortWeekdays() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getShortWeekdays25292)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getShortWeekdays25292)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.MethodId _getAmPmStrings25293;
		public virtual global::java.lang.String[] getAmPmStrings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getAmPmStrings25293)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getAmPmStrings25293)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setMonths25294;
		public virtual void setMonths(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setMonths25294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setMonths25294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setShortMonths25295;
		public virtual void setShortMonths(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setShortMonths25295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setShortMonths25295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWeekdays25296;
		public virtual void setWeekdays(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setWeekdays25296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setWeekdays25296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setShortWeekdays25297;
		public virtual void setShortWeekdays(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setShortWeekdays25297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setShortWeekdays25297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAmPmStrings25298;
		public virtual void setAmPmStrings(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setAmPmStrings25298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setAmPmStrings25298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getZoneStrings25299;
		public virtual global::java.lang.String[][] getZoneStrings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String[]>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getZoneStrings25299)) as java.lang.String[][];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String[]>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getZoneStrings25299)) as java.lang.String[][];
		}
		internal static global::MonoJavaBridge.MethodId _setZoneStrings25300;
		public virtual void setZoneStrings(java.lang.String[][] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setZoneStrings25300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setZoneStrings25300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLocalPatternChars25301;
		public virtual global::java.lang.String getLocalPatternChars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getLocalPatternChars25301)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getLocalPatternChars25301)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setLocalPatternChars25302;
		public virtual void setLocalPatternChars(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setLocalPatternChars25302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setLocalPatternChars25302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DateFormatSymbols25303;
		public DateFormatSymbols()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._DateFormatSymbols25303);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DateFormatSymbols25304;
		public DateFormatSymbols(java.util.Locale arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._DateFormatSymbols25304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DateFormatSymbols.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DateFormatSymbols"));
			global::java.text.DateFormatSymbols._equals25281 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.DateFormatSymbols._hashCode25282 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "hashCode", "()I");
			global::java.text.DateFormatSymbols._clone25283 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.DateFormatSymbols._getInstance25284 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/DateFormatSymbols;");
			global::java.text.DateFormatSymbols._getInstance25285 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getInstance", "()Ljava/text/DateFormatSymbols;");
			global::java.text.DateFormatSymbols._getAvailableLocales25286 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.DateFormatSymbols._getEras25287 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getEras", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._setEras25288 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setEras", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._getMonths25289 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getMonths", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._getShortMonths25290 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getShortMonths", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._getWeekdays25291 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getWeekdays", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._getShortWeekdays25292 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getShortWeekdays", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._getAmPmStrings25293 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getAmPmStrings", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._setMonths25294 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setMonths", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._setShortMonths25295 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setShortMonths", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._setWeekdays25296 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setWeekdays", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._setShortWeekdays25297 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setShortWeekdays", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._setAmPmStrings25298 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setAmPmStrings", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._getZoneStrings25299 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getZoneStrings", "()[[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._setZoneStrings25300 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setZoneStrings", "([[Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._getLocalPatternChars25301 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getLocalPatternChars", "()Ljava/lang/String;");
			global::java.text.DateFormatSymbols._setLocalPatternChars25302 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setLocalPatternChars", "(Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._DateFormatSymbols25303 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "<init>", "()V");
			global::java.text.DateFormatSymbols._DateFormatSymbols25304 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "<init>", "(Ljava/util/Locale;)V");
		}
	}
}
