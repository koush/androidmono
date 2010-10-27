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
		internal static global::MonoJavaBridge.MethodId _add25903;
		public abstract void add(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _get25904;
		public virtual int get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._get25904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._get25904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals25905;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Calendar._equals25905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._equals25905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25906;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._toString25906)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._toString25906)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25907;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._hashCode25907);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._hashCode25907);
		}
		internal static global::MonoJavaBridge.MethodId _clone25908;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._clone25908)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._clone25908)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo25909;
		public virtual int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._compareTo25909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._compareTo25909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo25910;
		public virtual int compareTo(java.util.Calendar arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._compareTo25910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._compareTo25910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear25911;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._clear25911);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._clear25911);
		}
		internal static global::MonoJavaBridge.MethodId _clear25912;
		public virtual void clear(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._clear25912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._clear25912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25913;
		public static global::java.util.Calendar getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance25913)) as java.util.Calendar;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25914;
		public static global::java.util.Calendar getInstance(java.util.TimeZone arg0, java.util.Locale arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance25914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Calendar;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25915;
		public static global::java.util.Calendar getInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance25915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Calendar;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25916;
		public static global::java.util.Calendar getInstance(java.util.TimeZone arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance25916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Calendar;
		}
		internal static global::MonoJavaBridge.MethodId _isSet25917;
		public virtual bool isSet(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Calendar._isSet25917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._isSet25917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set25918;
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._set25918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._set25918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _set25919;
		public virtual void set(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._set25919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._set25919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set25920;
		public virtual void set(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._set25920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._set25920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _set25921;
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._set25921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._set25921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _after25922;
		public virtual bool after(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Calendar._after25922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._after25922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _before25923;
		public virtual bool before(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Calendar._before25923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._before25923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _complete25924;
		protected virtual void complete()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._complete25924);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._complete25924);
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales25925;
		public static global::java.util.Locale[] getAvailableLocales()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._getAvailableLocales25925)) as java.util.Locale[];
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName25926;
		public virtual global::java.lang.String getDisplayName(int arg0, int arg1, java.util.Locale arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._getDisplayName25926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getDisplayName25926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTime25927;
		public virtual void setTime(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setTime25927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setTime25927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTime25928;
		public virtual global::java.util.Date getTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._getTime25928)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getTime25928)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeZone25929;
		public virtual global::java.util.TimeZone getTimeZone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._getTimeZone25929)) as java.util.TimeZone;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getTimeZone25929)) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _setTimeZone25930;
		public virtual void setTimeZone(java.util.TimeZone arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setTimeZone25930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setTimeZone25930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeInMillis25931;
		public virtual long getTimeInMillis()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.Calendar._getTimeInMillis25931);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getTimeInMillis25931);
		}
		internal static global::MonoJavaBridge.MethodId _computeTime25932;
		protected abstract void computeTime();
		internal static global::MonoJavaBridge.MethodId _computeFields25933;
		protected abstract void computeFields();
		internal static global::MonoJavaBridge.MethodId _setTimeInMillis25934;
		public virtual void setTimeInMillis(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setTimeInMillis25934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setTimeInMillis25934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _internalGet25935;
		protected virtual int internalGet(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._internalGet25935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._internalGet25935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayNames25936;
		public virtual global::java.util.Map getDisplayNames(int arg0, int arg1, java.util.Locale arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._getDisplayNames25936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getDisplayNames25936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _roll25937;
		public virtual void roll(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._roll25937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._roll25937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _roll25938;
		public abstract void roll(int arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _setLenient25939;
		public virtual void setLenient(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setLenient25939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setLenient25939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLenient25940;
		public virtual bool isLenient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Calendar._isLenient25940);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._isLenient25940);
		}
		internal static global::MonoJavaBridge.MethodId _setFirstDayOfWeek25941;
		public virtual void setFirstDayOfWeek(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setFirstDayOfWeek25941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setFirstDayOfWeek25941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstDayOfWeek25942;
		public virtual int getFirstDayOfWeek()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._getFirstDayOfWeek25942);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getFirstDayOfWeek25942);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimalDaysInFirstWeek25943;
		public virtual void setMinimalDaysInFirstWeek(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setMinimalDaysInFirstWeek25943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setMinimalDaysInFirstWeek25943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimalDaysInFirstWeek25944;
		public virtual int getMinimalDaysInFirstWeek()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._getMinimalDaysInFirstWeek25944);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getMinimalDaysInFirstWeek25944);
		}
		internal static global::MonoJavaBridge.MethodId _getMinimum25945;
		public abstract int getMinimum(int arg0);
		internal static global::MonoJavaBridge.MethodId _getMaximum25946;
		public abstract int getMaximum(int arg0);
		internal static global::MonoJavaBridge.MethodId _getGreatestMinimum25947;
		public abstract int getGreatestMinimum(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLeastMaximum25948;
		public abstract int getLeastMaximum(int arg0);
		internal static global::MonoJavaBridge.MethodId _getActualMinimum25949;
		public virtual int getActualMinimum(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._getActualMinimum25949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getActualMinimum25949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActualMaximum25950;
		public virtual int getActualMaximum(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._getActualMaximum25950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getActualMaximum25950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Calendar25951;
		protected Calendar(java.util.TimeZone arg0, java.util.Locale arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Calendar.staticClass, global::java.util.Calendar._Calendar25951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Calendar25952;
		protected Calendar() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Calendar.staticClass, global::java.util.Calendar._Calendar25952);
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
			global::java.util.Calendar._add25903 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "add", "(II)V");
			global::java.util.Calendar._get25904 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "get", "(I)I");
			global::java.util.Calendar._equals25905 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Calendar._toString25906 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Calendar._hashCode25907 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "hashCode", "()I");
			global::java.util.Calendar._clone25908 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Calendar._compareTo25909 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.util.Calendar._compareTo25910 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "compareTo", "(Ljava/util/Calendar;)I");
			global::java.util.Calendar._clear25911 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "clear", "()V");
			global::java.util.Calendar._clear25912 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "clear", "(I)V");
			global::java.util.Calendar._getInstance25913 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "()Ljava/util/Calendar;");
			global::java.util.Calendar._getInstance25914 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/util/Calendar;");
			global::java.util.Calendar._getInstance25915 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/util/Calendar;");
			global::java.util.Calendar._getInstance25916 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/TimeZone;)Ljava/util/Calendar;");
			global::java.util.Calendar._isSet25917 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "isSet", "(I)Z");
			global::java.util.Calendar._set25918 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "set", "(IIIIII)V");
			global::java.util.Calendar._set25919 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "set", "(II)V");
			global::java.util.Calendar._set25920 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "set", "(III)V");
			global::java.util.Calendar._set25921 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "set", "(IIIII)V");
			global::java.util.Calendar._after25922 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "after", "(Ljava/lang/Object;)Z");
			global::java.util.Calendar._before25923 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "before", "(Ljava/lang/Object;)Z");
			global::java.util.Calendar._complete25924 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "complete", "()V");
			global::java.util.Calendar._getAvailableLocales25925 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.util.Calendar._getDisplayName25926 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getDisplayName", "(IILjava/util/Locale;)Ljava/lang/String;");
			global::java.util.Calendar._setTime25927 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setTime", "(Ljava/util/Date;)V");
			global::java.util.Calendar._getTime25928 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getTime", "()Ljava/util/Date;");
			global::java.util.Calendar._getTimeZone25929 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getTimeZone", "()Ljava/util/TimeZone;");
			global::java.util.Calendar._setTimeZone25930 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V");
			global::java.util.Calendar._getTimeInMillis25931 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getTimeInMillis", "()J");
			global::java.util.Calendar._computeTime25932 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "computeTime", "()V");
			global::java.util.Calendar._computeFields25933 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "computeFields", "()V");
			global::java.util.Calendar._setTimeInMillis25934 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setTimeInMillis", "(J)V");
			global::java.util.Calendar._internalGet25935 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "internalGet", "(I)I");
			global::java.util.Calendar._getDisplayNames25936 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getDisplayNames", "(IILjava/util/Locale;)Ljava/util/Map;");
			global::java.util.Calendar._roll25937 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "roll", "(II)V");
			global::java.util.Calendar._roll25938 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "roll", "(IZ)V");
			global::java.util.Calendar._setLenient25939 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setLenient", "(Z)V");
			global::java.util.Calendar._isLenient25940 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "isLenient", "()Z");
			global::java.util.Calendar._setFirstDayOfWeek25941 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setFirstDayOfWeek", "(I)V");
			global::java.util.Calendar._getFirstDayOfWeek25942 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getFirstDayOfWeek", "()I");
			global::java.util.Calendar._setMinimalDaysInFirstWeek25943 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setMinimalDaysInFirstWeek", "(I)V");
			global::java.util.Calendar._getMinimalDaysInFirstWeek25944 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getMinimalDaysInFirstWeek", "()I");
			global::java.util.Calendar._getMinimum25945 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getMinimum", "(I)I");
			global::java.util.Calendar._getMaximum25946 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getMaximum", "(I)I");
			global::java.util.Calendar._getGreatestMinimum25947 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getGreatestMinimum", "(I)I");
			global::java.util.Calendar._getLeastMaximum25948 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getLeastMaximum", "(I)I");
			global::java.util.Calendar._getActualMinimum25949 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getActualMinimum", "(I)I");
			global::java.util.Calendar._getActualMaximum25950 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getActualMaximum", "(I)I");
			global::java.util.Calendar._Calendar25951 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V");
			global::java.util.Calendar._Calendar25952 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Calendar))]
	internal sealed partial class Calendar_ : java.util.Calendar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Calendar_()
		{
			InitJNI();
		}
		internal Calendar_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add25997;
		public override void add(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar_._add25997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._add25997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeTime25998;
		protected override void computeTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar_._computeTime25998);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._computeTime25998);
		}
		internal static global::MonoJavaBridge.MethodId _computeFields25999;
		protected override void computeFields()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar_._computeFields25999);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._computeFields25999);
		}
		internal static global::MonoJavaBridge.MethodId _roll26000;
		public override void roll(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar_._roll26000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._roll26000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimum26001;
		public override int getMinimum(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar_._getMinimum26001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._getMinimum26001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximum26002;
		public override int getMaximum(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar_._getMaximum26002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._getMaximum26002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGreatestMinimum26003;
		public override int getGreatestMinimum(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar_._getGreatestMinimum26003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._getGreatestMinimum26003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLeastMaximum26004;
		public override int getLeastMaximum(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar_._getLeastMaximum26004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._getLeastMaximum26004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Calendar_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Calendar"));
			global::java.util.Calendar_._add25997 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "add", "(II)V");
			global::java.util.Calendar_._computeTime25998 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "computeTime", "()V");
			global::java.util.Calendar_._computeFields25999 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "computeFields", "()V");
			global::java.util.Calendar_._roll26000 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "roll", "(IZ)V");
			global::java.util.Calendar_._getMinimum26001 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "getMinimum", "(I)I");
			global::java.util.Calendar_._getMaximum26002 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "getMaximum", "(I)I");
			global::java.util.Calendar_._getGreatestMinimum26003 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "getGreatestMinimum", "(I)I");
			global::java.util.Calendar_._getLeastMaximum26004 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "getLeastMaximum", "(I)I");
		}
	}
}
