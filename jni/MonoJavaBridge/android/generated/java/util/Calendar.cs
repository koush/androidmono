namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.Calendar_))]
	public abstract partial class Calendar : java.lang.Object, java.io.Serializable, java.lang.Cloneable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Calendar()
		{
			InitJNI();
		}
		protected Calendar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add20009;
		public abstract void add(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _get20010;
		public virtual int get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._get20010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._get20010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals20011;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Calendar._equals20011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._equals20011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20012;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._toString20012)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._toString20012)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20013;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._hashCode20013);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._hashCode20013);
		}
		internal static global::MonoJavaBridge.MethodId _clone20014;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._clone20014)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._clone20014)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20015;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._compareTo20015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._compareTo20015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20016;
		public virtual int compareTo(java.util.Calendar arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._compareTo20016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._compareTo20016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear20017;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._clear20017);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._clear20017);
		}
		internal static global::MonoJavaBridge.MethodId _clear20018;
		public virtual void clear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._clear20018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._clear20018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInstance20019;
		public static global::java.util.Calendar getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance20019)) as java.util.Calendar;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance20020;
		public static global::java.util.Calendar getInstance(java.util.TimeZone arg0, java.util.Locale arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance20020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Calendar;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance20021;
		public static global::java.util.Calendar getInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance20021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Calendar;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance20022;
		public static global::java.util.Calendar getInstance(java.util.TimeZone arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance20022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Calendar;
		}
		internal static global::MonoJavaBridge.MethodId _isSet20023;
		public virtual bool isSet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Calendar._isSet20023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._isSet20023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set20024;
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._set20024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._set20024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _set20025;
		public virtual void set(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._set20025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._set20025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set20026;
		public virtual void set(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._set20026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._set20026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _set20027;
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._set20027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._set20027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _after20028;
		public virtual bool after(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Calendar._after20028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._after20028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _before20029;
		public virtual bool before(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Calendar._before20029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._before20029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _complete20030;
		protected virtual void complete() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._complete20030);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._complete20030);
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales20031;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._getAvailableLocales20031)) as java.util.Locale[];
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName20032;
		public virtual global::java.lang.String getDisplayName(int arg0, int arg1, java.util.Locale arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._getDisplayName20032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getDisplayName20032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTime20033;
		public virtual void setTime(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setTime20033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setTime20033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTime20034;
		public virtual global::java.util.Date getTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._getTime20034)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getTime20034)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeZone20035;
		public virtual global::java.util.TimeZone getTimeZone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._getTimeZone20035)) as java.util.TimeZone;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getTimeZone20035)) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _setTimeZone20036;
		public virtual void setTimeZone(java.util.TimeZone arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setTimeZone20036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setTimeZone20036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeInMillis20037;
		public virtual long getTimeInMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.Calendar._getTimeInMillis20037);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getTimeInMillis20037);
		}
		internal static global::MonoJavaBridge.MethodId _computeTime20038;
		protected abstract void computeTime();
		internal static global::MonoJavaBridge.MethodId _computeFields20039;
		protected abstract void computeFields();
		internal static global::MonoJavaBridge.MethodId _setTimeInMillis20040;
		public virtual void setTimeInMillis(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setTimeInMillis20040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setTimeInMillis20040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _internalGet20041;
		protected virtual int internalGet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._internalGet20041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._internalGet20041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayNames20042;
		public virtual global::java.util.Map getDisplayNames(int arg0, int arg1, java.util.Locale arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._getDisplayNames20042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getDisplayNames20042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _roll20043;
		public virtual void roll(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._roll20043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._roll20043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _roll20044;
		public abstract void roll(int arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _setLenient20045;
		public virtual void setLenient(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setLenient20045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setLenient20045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLenient20046;
		public virtual bool isLenient() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Calendar._isLenient20046);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._isLenient20046);
		}
		internal static global::MonoJavaBridge.MethodId _setFirstDayOfWeek20047;
		public virtual void setFirstDayOfWeek(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setFirstDayOfWeek20047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setFirstDayOfWeek20047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstDayOfWeek20048;
		public virtual int getFirstDayOfWeek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._getFirstDayOfWeek20048);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getFirstDayOfWeek20048);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimalDaysInFirstWeek20049;
		public virtual void setMinimalDaysInFirstWeek(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setMinimalDaysInFirstWeek20049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setMinimalDaysInFirstWeek20049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimalDaysInFirstWeek20050;
		public virtual int getMinimalDaysInFirstWeek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._getMinimalDaysInFirstWeek20050);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getMinimalDaysInFirstWeek20050);
		}
		internal static global::MonoJavaBridge.MethodId _getMinimum20051;
		public abstract int getMinimum(int arg0);
		internal static global::MonoJavaBridge.MethodId _getMaximum20052;
		public abstract int getMaximum(int arg0);
		internal static global::MonoJavaBridge.MethodId _getGreatestMinimum20053;
		public abstract int getGreatestMinimum(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLeastMaximum20054;
		public abstract int getLeastMaximum(int arg0);
		internal static global::MonoJavaBridge.MethodId _getActualMinimum20055;
		public virtual int getActualMinimum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._getActualMinimum20055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getActualMinimum20055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActualMaximum20056;
		public virtual int getActualMaximum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._getActualMaximum20056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getActualMaximum20056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Calendar20057;
		protected Calendar(java.util.TimeZone arg0, java.util.Locale arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Calendar.staticClass, global::java.util.Calendar._Calendar20057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Calendar20058;
		protected Calendar()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Calendar.staticClass, global::java.util.Calendar._Calendar20058);
			Init(@__env, handle);
		}
		public static int ERA
		{
			get
			{
				return 0;
			}
		}
		public static int YEAR
		{
			get
			{
				return 1;
			}
		}
		public static int MONTH
		{
			get
			{
				return 2;
			}
		}
		public static int WEEK_OF_YEAR
		{
			get
			{
				return 3;
			}
		}
		public static int WEEK_OF_MONTH
		{
			get
			{
				return 4;
			}
		}
		public static int DATE
		{
			get
			{
				return 5;
			}
		}
		public static int DAY_OF_MONTH
		{
			get
			{
				return 5;
			}
		}
		public static int DAY_OF_YEAR
		{
			get
			{
				return 6;
			}
		}
		public static int DAY_OF_WEEK
		{
			get
			{
				return 7;
			}
		}
		public static int DAY_OF_WEEK_IN_MONTH
		{
			get
			{
				return 8;
			}
		}
		public static int AM_PM
		{
			get
			{
				return 9;
			}
		}
		public static int HOUR
		{
			get
			{
				return 10;
			}
		}
		public static int HOUR_OF_DAY
		{
			get
			{
				return 11;
			}
		}
		public static int MINUTE
		{
			get
			{
				return 12;
			}
		}
		public static int SECOND
		{
			get
			{
				return 13;
			}
		}
		public static int MILLISECOND
		{
			get
			{
				return 14;
			}
		}
		public static int ZONE_OFFSET
		{
			get
			{
				return 15;
			}
		}
		public static int DST_OFFSET
		{
			get
			{
				return 16;
			}
		}
		public static int FIELD_COUNT
		{
			get
			{
				return 17;
			}
		}
		public static int SUNDAY
		{
			get
			{
				return 1;
			}
		}
		public static int MONDAY
		{
			get
			{
				return 2;
			}
		}
		public static int TUESDAY
		{
			get
			{
				return 3;
			}
		}
		public static int WEDNESDAY
		{
			get
			{
				return 4;
			}
		}
		public static int THURSDAY
		{
			get
			{
				return 5;
			}
		}
		public static int FRIDAY
		{
			get
			{
				return 6;
			}
		}
		public static int SATURDAY
		{
			get
			{
				return 7;
			}
		}
		public static int JANUARY
		{
			get
			{
				return 0;
			}
		}
		public static int FEBRUARY
		{
			get
			{
				return 1;
			}
		}
		public static int MARCH
		{
			get
			{
				return 2;
			}
		}
		public static int APRIL
		{
			get
			{
				return 3;
			}
		}
		public static int MAY
		{
			get
			{
				return 4;
			}
		}
		public static int JUNE
		{
			get
			{
				return 5;
			}
		}
		public static int JULY
		{
			get
			{
				return 6;
			}
		}
		public static int AUGUST
		{
			get
			{
				return 7;
			}
		}
		public static int SEPTEMBER
		{
			get
			{
				return 8;
			}
		}
		public static int OCTOBER
		{
			get
			{
				return 9;
			}
		}
		public static int NOVEMBER
		{
			get
			{
				return 10;
			}
		}
		public static int DECEMBER
		{
			get
			{
				return 11;
			}
		}
		public static int UNDECIMBER
		{
			get
			{
				return 12;
			}
		}
		public static int AM
		{
			get
			{
				return 0;
			}
		}
		public static int PM
		{
			get
			{
				return 1;
			}
		}
		public static int ALL_STYLES
		{
			get
			{
				return 0;
			}
		}
		public static int SHORT
		{
			get
			{
				return 1;
			}
		}
		public static int LONG
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Calendar.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Calendar"));
			global::java.util.Calendar._add20009 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "add", "(II)V");
			global::java.util.Calendar._get20010 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "get", "(I)I");
			global::java.util.Calendar._equals20011 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Calendar._toString20012 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Calendar._hashCode20013 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "hashCode", "()I");
			global::java.util.Calendar._clone20014 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Calendar._compareTo20015 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.util.Calendar._compareTo20016 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "compareTo", "(Ljava/util/Calendar;)I");
			global::java.util.Calendar._clear20017 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "clear", "()V");
			global::java.util.Calendar._clear20018 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "clear", "(I)V");
			global::java.util.Calendar._getInstance20019 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "()Ljava/util/Calendar;");
			global::java.util.Calendar._getInstance20020 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/util/Calendar;");
			global::java.util.Calendar._getInstance20021 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/util/Calendar;");
			global::java.util.Calendar._getInstance20022 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/TimeZone;)Ljava/util/Calendar;");
			global::java.util.Calendar._isSet20023 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "isSet", "(I)Z");
			global::java.util.Calendar._set20024 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "set", "(IIIIII)V");
			global::java.util.Calendar._set20025 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "set", "(II)V");
			global::java.util.Calendar._set20026 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "set", "(III)V");
			global::java.util.Calendar._set20027 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "set", "(IIIII)V");
			global::java.util.Calendar._after20028 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "after", "(Ljava/lang/Object;)Z");
			global::java.util.Calendar._before20029 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "before", "(Ljava/lang/Object;)Z");
			global::java.util.Calendar._complete20030 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "complete", "()V");
			global::java.util.Calendar._getAvailableLocales20031 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.util.Calendar._getDisplayName20032 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getDisplayName", "(IILjava/util/Locale;)Ljava/lang/String;");
			global::java.util.Calendar._setTime20033 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setTime", "(Ljava/util/Date;)V");
			global::java.util.Calendar._getTime20034 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getTime", "()Ljava/util/Date;");
			global::java.util.Calendar._getTimeZone20035 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getTimeZone", "()Ljava/util/TimeZone;");
			global::java.util.Calendar._setTimeZone20036 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V");
			global::java.util.Calendar._getTimeInMillis20037 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getTimeInMillis", "()J");
			global::java.util.Calendar._computeTime20038 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "computeTime", "()V");
			global::java.util.Calendar._computeFields20039 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "computeFields", "()V");
			global::java.util.Calendar._setTimeInMillis20040 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setTimeInMillis", "(J)V");
			global::java.util.Calendar._internalGet20041 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "internalGet", "(I)I");
			global::java.util.Calendar._getDisplayNames20042 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getDisplayNames", "(IILjava/util/Locale;)Ljava/util/Map;");
			global::java.util.Calendar._roll20043 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "roll", "(II)V");
			global::java.util.Calendar._roll20044 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "roll", "(IZ)V");
			global::java.util.Calendar._setLenient20045 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setLenient", "(Z)V");
			global::java.util.Calendar._isLenient20046 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "isLenient", "()Z");
			global::java.util.Calendar._setFirstDayOfWeek20047 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setFirstDayOfWeek", "(I)V");
			global::java.util.Calendar._getFirstDayOfWeek20048 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getFirstDayOfWeek", "()I");
			global::java.util.Calendar._setMinimalDaysInFirstWeek20049 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setMinimalDaysInFirstWeek", "(I)V");
			global::java.util.Calendar._getMinimalDaysInFirstWeek20050 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getMinimalDaysInFirstWeek", "()I");
			global::java.util.Calendar._getMinimum20051 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getMinimum", "(I)I");
			global::java.util.Calendar._getMaximum20052 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getMaximum", "(I)I");
			global::java.util.Calendar._getGreatestMinimum20053 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getGreatestMinimum", "(I)I");
			global::java.util.Calendar._getLeastMaximum20054 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getLeastMaximum", "(I)I");
			global::java.util.Calendar._getActualMinimum20055 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getActualMinimum", "(I)I");
			global::java.util.Calendar._getActualMaximum20056 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getActualMaximum", "(I)I");
			global::java.util.Calendar._Calendar20057 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V");
			global::java.util.Calendar._Calendar20058 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Calendar))]
	public sealed partial class Calendar_ : java.util.Calendar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Calendar_()
		{
			InitJNI();
		}
		internal Calendar_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add20059;
		public override void add(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar_._add20059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._add20059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeTime20060;
		protected override void computeTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar_._computeTime20060);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._computeTime20060);
		}
		internal static global::MonoJavaBridge.MethodId _computeFields20061;
		protected override void computeFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar_._computeFields20061);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._computeFields20061);
		}
		internal static global::MonoJavaBridge.MethodId _roll20062;
		public override void roll(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar_._roll20062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._roll20062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimum20063;
		public override int getMinimum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar_._getMinimum20063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._getMinimum20063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximum20064;
		public override int getMaximum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar_._getMaximum20064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._getMaximum20064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGreatestMinimum20065;
		public override int getGreatestMinimum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar_._getGreatestMinimum20065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._getGreatestMinimum20065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLeastMaximum20066;
		public override int getLeastMaximum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar_._getLeastMaximum20066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._getLeastMaximum20066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Calendar_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Calendar"));
			global::java.util.Calendar_._add20059 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "add", "(II)V");
			global::java.util.Calendar_._computeTime20060 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "computeTime", "()V");
			global::java.util.Calendar_._computeFields20061 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "computeFields", "()V");
			global::java.util.Calendar_._roll20062 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "roll", "(IZ)V");
			global::java.util.Calendar_._getMinimum20063 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "getMinimum", "(I)I");
			global::java.util.Calendar_._getMaximum20064 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "getMaximum", "(I)I");
			global::java.util.Calendar_._getGreatestMinimum20065 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "getGreatestMinimum", "(I)I");
			global::java.util.Calendar_._getLeastMaximum20066 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "getLeastMaximum", "(I)I");
		}
	}
}
