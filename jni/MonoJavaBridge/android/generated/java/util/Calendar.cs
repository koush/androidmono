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
		internal static global::MonoJavaBridge.MethodId _add25785;
		public abstract void add(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _get25786;
		public virtual int get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._get25786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._get25786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals25787;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Calendar._equals25787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._equals25787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25788;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._toString25788)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._toString25788)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25789;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._hashCode25789);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._hashCode25789);
		}
		internal static global::MonoJavaBridge.MethodId _clone25790;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._clone25790)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._clone25790)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo25791;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._compareTo25791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._compareTo25791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo25792;
		public virtual int compareTo(java.util.Calendar arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._compareTo25792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._compareTo25792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear25793;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._clear25793);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._clear25793);
		}
		internal static global::MonoJavaBridge.MethodId _clear25794;
		public virtual void clear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._clear25794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._clear25794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25795;
		public static global::java.util.Calendar getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance25795)) as java.util.Calendar;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25796;
		public static global::java.util.Calendar getInstance(java.util.TimeZone arg0, java.util.Locale arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance25796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Calendar;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25797;
		public static global::java.util.Calendar getInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance25797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Calendar;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25798;
		public static global::java.util.Calendar getInstance(java.util.TimeZone arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance25798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Calendar;
		}
		internal static global::MonoJavaBridge.MethodId _isSet25799;
		public virtual bool isSet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Calendar._isSet25799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._isSet25799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set25800;
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._set25800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._set25800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _set25801;
		public virtual void set(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._set25801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._set25801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set25802;
		public virtual void set(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._set25802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._set25802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _set25803;
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._set25803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._set25803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _after25804;
		public virtual bool after(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Calendar._after25804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._after25804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _before25805;
		public virtual bool before(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Calendar._before25805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._before25805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _complete25806;
		protected virtual void complete() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._complete25806);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._complete25806);
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales25807;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._getAvailableLocales25807)) as java.util.Locale[];
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName25808;
		public virtual global::java.lang.String getDisplayName(int arg0, int arg1, java.util.Locale arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._getDisplayName25808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getDisplayName25808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTime25809;
		public virtual void setTime(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setTime25809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setTime25809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTime25810;
		public virtual global::java.util.Date getTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._getTime25810)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getTime25810)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeZone25811;
		public virtual global::java.util.TimeZone getTimeZone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._getTimeZone25811)) as java.util.TimeZone;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getTimeZone25811)) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _setTimeZone25812;
		public virtual void setTimeZone(java.util.TimeZone arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setTimeZone25812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setTimeZone25812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeInMillis25813;
		public virtual long getTimeInMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.Calendar._getTimeInMillis25813);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getTimeInMillis25813);
		}
		internal static global::MonoJavaBridge.MethodId _computeTime25814;
		protected abstract void computeTime();
		internal static global::MonoJavaBridge.MethodId _computeFields25815;
		protected abstract void computeFields();
		internal static global::MonoJavaBridge.MethodId _setTimeInMillis25816;
		public virtual void setTimeInMillis(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setTimeInMillis25816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setTimeInMillis25816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _internalGet25817;
		protected virtual int internalGet(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._internalGet25817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._internalGet25817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayNames25818;
		public virtual global::java.util.Map getDisplayNames(int arg0, int arg1, java.util.Locale arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Calendar._getDisplayNames25818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getDisplayNames25818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _roll25819;
		public virtual void roll(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._roll25819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._roll25819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _roll25820;
		public abstract void roll(int arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _setLenient25821;
		public virtual void setLenient(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setLenient25821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setLenient25821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLenient25822;
		public virtual bool isLenient() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Calendar._isLenient25822);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._isLenient25822);
		}
		internal static global::MonoJavaBridge.MethodId _setFirstDayOfWeek25823;
		public virtual void setFirstDayOfWeek(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setFirstDayOfWeek25823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setFirstDayOfWeek25823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstDayOfWeek25824;
		public virtual int getFirstDayOfWeek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._getFirstDayOfWeek25824);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getFirstDayOfWeek25824);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimalDaysInFirstWeek25825;
		public virtual void setMinimalDaysInFirstWeek(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar._setMinimalDaysInFirstWeek25825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._setMinimalDaysInFirstWeek25825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimalDaysInFirstWeek25826;
		public virtual int getMinimalDaysInFirstWeek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._getMinimalDaysInFirstWeek25826);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getMinimalDaysInFirstWeek25826);
		}
		internal static global::MonoJavaBridge.MethodId _getMinimum25827;
		public abstract int getMinimum(int arg0);
		internal static global::MonoJavaBridge.MethodId _getMaximum25828;
		public abstract int getMaximum(int arg0);
		internal static global::MonoJavaBridge.MethodId _getGreatestMinimum25829;
		public abstract int getGreatestMinimum(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLeastMaximum25830;
		public abstract int getLeastMaximum(int arg0);
		internal static global::MonoJavaBridge.MethodId _getActualMinimum25831;
		public virtual int getActualMinimum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._getActualMinimum25831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getActualMinimum25831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActualMaximum25832;
		public virtual int getActualMaximum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar._getActualMaximum25832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar.staticClass, global::java.util.Calendar._getActualMaximum25832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Calendar25833;
		protected Calendar(java.util.TimeZone arg0, java.util.Locale arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Calendar.staticClass, global::java.util.Calendar._Calendar25833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Calendar25834;
		protected Calendar()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Calendar.staticClass, global::java.util.Calendar._Calendar25834);
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
			global::java.util.Calendar._add25785 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "add", "(II)V");
			global::java.util.Calendar._get25786 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "get", "(I)I");
			global::java.util.Calendar._equals25787 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Calendar._toString25788 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Calendar._hashCode25789 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "hashCode", "()I");
			global::java.util.Calendar._clone25790 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Calendar._compareTo25791 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.util.Calendar._compareTo25792 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "compareTo", "(Ljava/util/Calendar;)I");
			global::java.util.Calendar._clear25793 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "clear", "()V");
			global::java.util.Calendar._clear25794 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "clear", "(I)V");
			global::java.util.Calendar._getInstance25795 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "()Ljava/util/Calendar;");
			global::java.util.Calendar._getInstance25796 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/util/Calendar;");
			global::java.util.Calendar._getInstance25797 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/util/Calendar;");
			global::java.util.Calendar._getInstance25798 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/TimeZone;)Ljava/util/Calendar;");
			global::java.util.Calendar._isSet25799 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "isSet", "(I)Z");
			global::java.util.Calendar._set25800 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "set", "(IIIIII)V");
			global::java.util.Calendar._set25801 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "set", "(II)V");
			global::java.util.Calendar._set25802 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "set", "(III)V");
			global::java.util.Calendar._set25803 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "set", "(IIIII)V");
			global::java.util.Calendar._after25804 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "after", "(Ljava/lang/Object;)Z");
			global::java.util.Calendar._before25805 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "before", "(Ljava/lang/Object;)Z");
			global::java.util.Calendar._complete25806 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "complete", "()V");
			global::java.util.Calendar._getAvailableLocales25807 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.util.Calendar._getDisplayName25808 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getDisplayName", "(IILjava/util/Locale;)Ljava/lang/String;");
			global::java.util.Calendar._setTime25809 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setTime", "(Ljava/util/Date;)V");
			global::java.util.Calendar._getTime25810 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getTime", "()Ljava/util/Date;");
			global::java.util.Calendar._getTimeZone25811 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getTimeZone", "()Ljava/util/TimeZone;");
			global::java.util.Calendar._setTimeZone25812 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V");
			global::java.util.Calendar._getTimeInMillis25813 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getTimeInMillis", "()J");
			global::java.util.Calendar._computeTime25814 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "computeTime", "()V");
			global::java.util.Calendar._computeFields25815 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "computeFields", "()V");
			global::java.util.Calendar._setTimeInMillis25816 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setTimeInMillis", "(J)V");
			global::java.util.Calendar._internalGet25817 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "internalGet", "(I)I");
			global::java.util.Calendar._getDisplayNames25818 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getDisplayNames", "(IILjava/util/Locale;)Ljava/util/Map;");
			global::java.util.Calendar._roll25819 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "roll", "(II)V");
			global::java.util.Calendar._roll25820 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "roll", "(IZ)V");
			global::java.util.Calendar._setLenient25821 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setLenient", "(Z)V");
			global::java.util.Calendar._isLenient25822 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "isLenient", "()Z");
			global::java.util.Calendar._setFirstDayOfWeek25823 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setFirstDayOfWeek", "(I)V");
			global::java.util.Calendar._getFirstDayOfWeek25824 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getFirstDayOfWeek", "()I");
			global::java.util.Calendar._setMinimalDaysInFirstWeek25825 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "setMinimalDaysInFirstWeek", "(I)V");
			global::java.util.Calendar._getMinimalDaysInFirstWeek25826 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getMinimalDaysInFirstWeek", "()I");
			global::java.util.Calendar._getMinimum25827 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getMinimum", "(I)I");
			global::java.util.Calendar._getMaximum25828 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getMaximum", "(I)I");
			global::java.util.Calendar._getGreatestMinimum25829 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getGreatestMinimum", "(I)I");
			global::java.util.Calendar._getLeastMaximum25830 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getLeastMaximum", "(I)I");
			global::java.util.Calendar._getActualMinimum25831 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getActualMinimum", "(I)I");
			global::java.util.Calendar._getActualMaximum25832 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "getActualMaximum", "(I)I");
			global::java.util.Calendar._Calendar25833 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V");
			global::java.util.Calendar._Calendar25834 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _add25879;
		public override void add(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar_._add25879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._add25879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _computeTime25880;
		protected override void computeTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar_._computeTime25880);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._computeTime25880);
		}
		internal static global::MonoJavaBridge.MethodId _computeFields25881;
		protected override void computeFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar_._computeFields25881);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._computeFields25881);
		}
		internal static global::MonoJavaBridge.MethodId _roll25882;
		public override void roll(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Calendar_._roll25882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._roll25882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimum25883;
		public override int getMinimum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar_._getMinimum25883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._getMinimum25883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximum25884;
		public override int getMaximum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar_._getMaximum25884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._getMaximum25884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getGreatestMinimum25885;
		public override int getGreatestMinimum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar_._getGreatestMinimum25885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._getGreatestMinimum25885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLeastMaximum25886;
		public override int getLeastMaximum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Calendar_._getLeastMaximum25886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Calendar_.staticClass, global::java.util.Calendar_._getLeastMaximum25886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Calendar_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Calendar"));
			global::java.util.Calendar_._add25879 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "add", "(II)V");
			global::java.util.Calendar_._computeTime25880 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "computeTime", "()V");
			global::java.util.Calendar_._computeFields25881 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "computeFields", "()V");
			global::java.util.Calendar_._roll25882 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "roll", "(IZ)V");
			global::java.util.Calendar_._getMinimum25883 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "getMinimum", "(I)I");
			global::java.util.Calendar_._getMaximum25884 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "getMaximum", "(I)I");
			global::java.util.Calendar_._getGreatestMinimum25885 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "getGreatestMinimum", "(I)I");
			global::java.util.Calendar_._getLeastMaximum25886 = @__env.GetMethodIDNoThrow(global::java.util.Calendar_.staticClass, "getLeastMaximum", "(I)I");
		}
	}
}
