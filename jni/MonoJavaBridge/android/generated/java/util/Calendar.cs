namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Calendar : java.lang.Object, java.io.Serializable, java.lang.Cloneable, java.lang.Comparable
	{
		internal static global::java.lang.Class staticClass;
		static Calendar()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.Calendar), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Calendar(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _add13587;
		public abstract void add(int arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _get13588;
		public virtual int get(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Calendar._get13588, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._get13588, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13589;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.Calendar._equals13589, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._equals13589, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13590;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Calendar._toString13590));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._toString13590));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13591;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Calendar._hashCode13591);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._hashCode13591);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone13592;
		public virtual global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Calendar._clone13592));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._clone13592));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo13593;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Calendar._compareTo13593, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._compareTo13593, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo13594;
		public virtual int compareTo(java.util.Calendar arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Calendar._compareTo13594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._compareTo13594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear13595;
		public virtual void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Calendar._clear13595);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._clear13595);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear13596;
		public virtual void clear(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Calendar._clear13596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._clear13596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance13597;
		public static global::java.util.Calendar getInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance13597));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance13598;
		public static global::java.util.Calendar getInstance(java.util.TimeZone arg0, java.util.Locale arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance13598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance13599;
		public static global::java.util.Calendar getInstance(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance13599, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance13600;
		public static global::java.util.Calendar getInstance(java.util.TimeZone arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Calendar.staticClass, global::java.util.Calendar._getInstance13600, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSet13601;
		public virtual bool isSet(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.Calendar._isSet13601, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._isSet13601, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set13602;
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Calendar._set13602, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._set13602, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set13603;
		public virtual void set(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Calendar._set13603, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._set13603, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set13604;
		public virtual void set(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Calendar._set13604, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._set13604, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set13605;
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Calendar._set13605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._set13605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _after13606;
		public virtual bool after(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.Calendar._after13606, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._after13606, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _before13607;
		public virtual bool before(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.Calendar._before13607, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._before13607, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _complete13608;
		protected virtual void complete() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Calendar._complete13608);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._complete13608);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableLocales13609;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.Calendar.staticClass, global::java.util.Calendar._getAvailableLocales13609));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName13610;
		public virtual global::java.lang.String getDisplayName(int arg0, int arg1, java.util.Locale arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Calendar._getDisplayName13610, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._getDisplayName13610, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTime13611;
		public virtual void setTime(java.util.Date arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Calendar._setTime13611, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._setTime13611, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTime13612;
		public virtual global::java.util.Date getTime() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Calendar._getTime13612));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._getTime13612));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTimeZone13613;
		public virtual global::java.util.TimeZone getTimeZone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.TimeZone>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Calendar._getTimeZone13613));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.TimeZone>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._getTimeZone13613));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTimeZone13614;
		public virtual void setTimeZone(java.util.TimeZone arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Calendar._setTimeZone13614, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._setTimeZone13614, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTimeInMillis13615;
		public virtual long getTimeInMillis() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.util.Calendar._getTimeInMillis13615);
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._getTimeInMillis13615);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeTime13616;
		protected abstract void computeTime();
		internal static global::net.sf.jni4net.jni.MethodId _computeFields13617;
		protected abstract void computeFields();
		internal static global::net.sf.jni4net.jni.MethodId _setTimeInMillis13618;
		public virtual void setTimeInMillis(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Calendar._setTimeInMillis13618, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._setTimeInMillis13618, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _internalGet13619;
		protected virtual int internalGet(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Calendar._internalGet13619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._internalGet13619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayNames13620;
		public virtual global::java.util.Map getDisplayNames(int arg0, int arg1, java.util.Locale arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Calendar._getDisplayNames13620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._getDisplayNames13620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _roll13621;
		public virtual void roll(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Calendar._roll13621, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._roll13621, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _roll13622;
		public abstract void roll(int arg0, bool arg1);
		internal static global::net.sf.jni4net.jni.MethodId _setLenient13623;
		public virtual void setLenient(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Calendar._setLenient13623, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._setLenient13623, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLenient13624;
		public virtual bool isLenient() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.Calendar._isLenient13624);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._isLenient13624);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFirstDayOfWeek13625;
		public virtual void setFirstDayOfWeek(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Calendar._setFirstDayOfWeek13625, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._setFirstDayOfWeek13625, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFirstDayOfWeek13626;
		public virtual int getFirstDayOfWeek() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Calendar._getFirstDayOfWeek13626);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._getFirstDayOfWeek13626);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMinimalDaysInFirstWeek13627;
		public virtual void setMinimalDaysInFirstWeek(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.Calendar._setMinimalDaysInFirstWeek13627, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._setMinimalDaysInFirstWeek13627, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimalDaysInFirstWeek13628;
		public virtual int getMinimalDaysInFirstWeek() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Calendar._getMinimalDaysInFirstWeek13628);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._getMinimalDaysInFirstWeek13628);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimum13629;
		public abstract int getMinimum(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getMaximum13630;
		public abstract int getMaximum(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getGreatestMinimum13631;
		public abstract int getGreatestMinimum(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getLeastMaximum13632;
		public abstract int getLeastMaximum(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getActualMinimum13633;
		public virtual int getActualMinimum(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Calendar._getActualMinimum13633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._getActualMinimum13633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getActualMaximum13634;
		public virtual int getActualMaximum(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Calendar._getActualMaximum13634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Calendar.staticClass, global::java.util.Calendar._getActualMaximum13634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Calendar13635;
		protected Calendar(java.util.TimeZone arg0, java.util.Locale arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Calendar.staticClass, global::java.util.Calendar._Calendar13635, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Calendar13636;
		protected Calendar()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Calendar.staticClass, global::java.util.Calendar._Calendar13636, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.Calendar.staticClass = @__class;
			global::java.util.Calendar._add13587 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "add", "(II)V");
			global::java.util.Calendar._get13588 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "get", "(I)I");
			global::java.util.Calendar._equals13589 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Calendar._toString13590 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Calendar._hashCode13591 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "hashCode", "()I");
			global::java.util.Calendar._clone13592 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Calendar._compareTo13593 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.util.Calendar._compareTo13594 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "compareTo", "(Ljava/util/Calendar;)I");
			global::java.util.Calendar._clear13595 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "clear", "()V");
			global::java.util.Calendar._clear13596 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "clear", "(I)V");
			global::java.util.Calendar._getInstance13597 = @__env.GetStaticMethodID(global::java.util.Calendar.staticClass, "getInstance", "()Ljava/util/Calendar;");
			global::java.util.Calendar._getInstance13598 = @__env.GetStaticMethodID(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/util/Calendar;");
			global::java.util.Calendar._getInstance13599 = @__env.GetStaticMethodID(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/util/Calendar;");
			global::java.util.Calendar._getInstance13600 = @__env.GetStaticMethodID(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/TimeZone;)Ljava/util/Calendar;");
			global::java.util.Calendar._isSet13601 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "isSet", "(I)Z");
			global::java.util.Calendar._set13602 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "set", "(IIIIII)V");
			global::java.util.Calendar._set13603 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "set", "(II)V");
			global::java.util.Calendar._set13604 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "set", "(III)V");
			global::java.util.Calendar._set13605 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "set", "(IIIII)V");
			global::java.util.Calendar._after13606 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "after", "(Ljava/lang/Object;)Z");
			global::java.util.Calendar._before13607 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "before", "(Ljava/lang/Object;)Z");
			global::java.util.Calendar._complete13608 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "complete", "()V");
			global::java.util.Calendar._getAvailableLocales13609 = @__env.GetStaticMethodID(global::java.util.Calendar.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.util.Calendar._getDisplayName13610 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getDisplayName", "(IILjava/util/Locale;)Ljava/lang/String;");
			global::java.util.Calendar._setTime13611 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setTime", "(Ljava/util/Date;)V");
			global::java.util.Calendar._getTime13612 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getTime", "()Ljava/util/Date;");
			global::java.util.Calendar._getTimeZone13613 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getTimeZone", "()Ljava/util/TimeZone;");
			global::java.util.Calendar._setTimeZone13614 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V");
			global::java.util.Calendar._getTimeInMillis13615 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getTimeInMillis", "()J");
			global::java.util.Calendar._computeTime13616 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "computeTime", "()V");
			global::java.util.Calendar._computeFields13617 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "computeFields", "()V");
			global::java.util.Calendar._setTimeInMillis13618 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setTimeInMillis", "(J)V");
			global::java.util.Calendar._internalGet13619 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "internalGet", "(I)I");
			global::java.util.Calendar._getDisplayNames13620 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getDisplayNames", "(IILjava/util/Locale;)Ljava/util/Map;");
			global::java.util.Calendar._roll13621 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "roll", "(II)V");
			global::java.util.Calendar._roll13622 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "roll", "(IZ)V");
			global::java.util.Calendar._setLenient13623 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setLenient", "(Z)V");
			global::java.util.Calendar._isLenient13624 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "isLenient", "()Z");
			global::java.util.Calendar._setFirstDayOfWeek13625 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setFirstDayOfWeek", "(I)V");
			global::java.util.Calendar._getFirstDayOfWeek13626 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getFirstDayOfWeek", "()I");
			global::java.util.Calendar._setMinimalDaysInFirstWeek13627 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setMinimalDaysInFirstWeek", "(I)V");
			global::java.util.Calendar._getMinimalDaysInFirstWeek13628 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getMinimalDaysInFirstWeek", "()I");
			global::java.util.Calendar._getMinimum13629 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getMinimum", "(I)I");
			global::java.util.Calendar._getMaximum13630 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getMaximum", "(I)I");
			global::java.util.Calendar._getGreatestMinimum13631 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getGreatestMinimum", "(I)I");
			global::java.util.Calendar._getLeastMaximum13632 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getLeastMaximum", "(I)I");
			global::java.util.Calendar._getActualMinimum13633 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getActualMinimum", "(I)I");
			global::java.util.Calendar._getActualMaximum13634 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getActualMaximum", "(I)I");
			global::java.util.Calendar._Calendar13635 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V");
			global::java.util.Calendar._Calendar13636 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "<init>", "()V");
		}
	}
}
