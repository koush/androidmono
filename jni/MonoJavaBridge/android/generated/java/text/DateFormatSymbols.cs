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
		internal static global::MonoJavaBridge.MethodId _equals25400;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DateFormatSymbols._equals25400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._equals25400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25401;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DateFormatSymbols._hashCode25401);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._hashCode25401);
		}
		internal static global::MonoJavaBridge.MethodId _clone25402;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._clone25402)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._clone25402)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25403;
		public static global::java.text.DateFormatSymbols getInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getInstance25403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormatSymbols;
		}
		public static global::java.text.DateFormatSymbols Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25404;
		public static global::java.text.DateFormatSymbols getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getInstance25404)) as java.text.DateFormatSymbols;
		}
		public static global::java.util.Locale[] AvailableLocales
		{
			get
			{
				return getAvailableLocales();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales25405;
		public static global::java.util.Locale[] getAvailableLocales()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getAvailableLocales25405)) as java.util.Locale[];
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
		internal static global::MonoJavaBridge.MethodId _getEras25406;
		public virtual global::java.lang.String[] getEras()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getEras25406)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getEras25406)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setEras25407;
		public virtual void setEras(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setEras25407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setEras25407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMonths25408;
		public virtual global::java.lang.String[] getMonths()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getMonths25408)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getMonths25408)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.MethodId _getShortMonths25409;
		public virtual global::java.lang.String[] getShortMonths()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getShortMonths25409)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getShortMonths25409)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.MethodId _getWeekdays25410;
		public virtual global::java.lang.String[] getWeekdays()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getWeekdays25410)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getWeekdays25410)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.MethodId _getShortWeekdays25411;
		public virtual global::java.lang.String[] getShortWeekdays()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getShortWeekdays25411)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getShortWeekdays25411)) as java.lang.String[];
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
		internal static global::MonoJavaBridge.MethodId _getAmPmStrings25412;
		public virtual global::java.lang.String[] getAmPmStrings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getAmPmStrings25412)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getAmPmStrings25412)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _setMonths25413;
		public virtual void setMonths(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setMonths25413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setMonths25413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setShortMonths25414;
		public virtual void setShortMonths(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setShortMonths25414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setShortMonths25414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWeekdays25415;
		public virtual void setWeekdays(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setWeekdays25415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setWeekdays25415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setShortWeekdays25416;
		public virtual void setShortWeekdays(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setShortWeekdays25416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setShortWeekdays25416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAmPmStrings25417;
		public virtual void setAmPmStrings(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setAmPmStrings25417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setAmPmStrings25417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getZoneStrings25418;
		public virtual global::java.lang.String[][] getZoneStrings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String[]>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getZoneStrings25418)) as java.lang.String[][];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String[]>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getZoneStrings25418)) as java.lang.String[][];
		}
		internal static global::MonoJavaBridge.MethodId _setZoneStrings25419;
		public virtual void setZoneStrings(java.lang.String[][] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setZoneStrings25419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setZoneStrings25419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLocalPatternChars25420;
		public virtual global::java.lang.String getLocalPatternChars()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols._getLocalPatternChars25420)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._getLocalPatternChars25420)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setLocalPatternChars25421;
		public virtual void setLocalPatternChars(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols._setLocalPatternChars25421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._setLocalPatternChars25421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DateFormatSymbols25422;
		public DateFormatSymbols() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._DateFormatSymbols25422);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DateFormatSymbols25423;
		public DateFormatSymbols(java.util.Locale arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DateFormatSymbols.staticClass, global::java.text.DateFormatSymbols._DateFormatSymbols25423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DateFormatSymbols.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DateFormatSymbols"));
			global::java.text.DateFormatSymbols._equals25400 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.DateFormatSymbols._hashCode25401 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "hashCode", "()I");
			global::java.text.DateFormatSymbols._clone25402 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.DateFormatSymbols._getInstance25403 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/DateFormatSymbols;");
			global::java.text.DateFormatSymbols._getInstance25404 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getInstance", "()Ljava/text/DateFormatSymbols;");
			global::java.text.DateFormatSymbols._getAvailableLocales25405 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.DateFormatSymbols._getEras25406 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getEras", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._setEras25407 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setEras", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._getMonths25408 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getMonths", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._getShortMonths25409 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getShortMonths", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._getWeekdays25410 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getWeekdays", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._getShortWeekdays25411 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getShortWeekdays", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._getAmPmStrings25412 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getAmPmStrings", "()[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._setMonths25413 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setMonths", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._setShortMonths25414 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setShortMonths", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._setWeekdays25415 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setWeekdays", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._setShortWeekdays25416 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setShortWeekdays", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._setAmPmStrings25417 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setAmPmStrings", "([Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._getZoneStrings25418 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getZoneStrings", "()[[Ljava/lang/String;");
			global::java.text.DateFormatSymbols._setZoneStrings25419 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setZoneStrings", "([[Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._getLocalPatternChars25420 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "getLocalPatternChars", "()Ljava/lang/String;");
			global::java.text.DateFormatSymbols._setLocalPatternChars25421 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "setLocalPatternChars", "(Ljava/lang/String;)V");
			global::java.text.DateFormatSymbols._DateFormatSymbols25422 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "<init>", "()V");
			global::java.text.DateFormatSymbols._DateFormatSymbols25423 = @__env.GetMethodIDNoThrow(global::java.text.DateFormatSymbols.staticClass, "<init>", "(Ljava/util/Locale;)V");
		}
	}
}
