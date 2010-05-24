namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Calendar : java.lang.Object, java.io.Serializable, java.lang.Cloneable, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Calendar() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.Calendar), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Calendar(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _add12759; 
		public abstract void add(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _get12760; 
		public virtual int get(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _get12760, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _get12760, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12761; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _hashCode12761); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _hashCode12761); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone12762; 
		public virtual java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _clone12762)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Calendar.staticClass, _clone12762)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12763; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallBooleanMethod(this, _equals12763, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Calendar.staticClass, _equals12763, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12764; 
		public virtual int compareTo(java.util.Calendar arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _compareTo12764, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _compareTo12764, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12765; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _compareTo12765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _compareTo12765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear12766; 
		public virtual void clear(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _clear12766, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _clear12766, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear12767; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _clear12767); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _clear12767); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12768; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString12768)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Calendar.staticClass, _toString12768)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance12769; 
		public static java.util.Calendar getInstance(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Calendar.staticClass, _getInstance12769, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance12770; 
		public static java.util.Calendar getInstance(java.util.TimeZone arg0, java.util.Locale arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Calendar.staticClass, _getInstance12770, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance12771; 
		public static java.util.Calendar getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Calendar.staticClass, _getInstance12771)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance12772; 
		public static java.util.Calendar getInstance(java.util.TimeZone arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Calendar.staticClass, _getInstance12772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set12773; 
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _set12773, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _set12773, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set12774; 
		public virtual void set(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _set12774, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _set12774, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set12775; 
		public virtual void set(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _set12775, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _set12775, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set12776; 
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _set12776, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _set12776, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSet12777; 
		public virtual bool isSet(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallBooleanMethod(this, _isSet12777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Calendar.staticClass, _isSet12777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _after12778; 
		public virtual bool after(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallBooleanMethod(this, _after12778, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Calendar.staticClass, _after12778, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _before12779; 
		public virtual bool before(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallBooleanMethod(this, _before12779, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Calendar.staticClass, _before12779, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _complete12780; 
		protected virtual void complete() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _complete12780); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _complete12780); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableLocales12781; 
		public static java.util.Locale[] getAvailableLocales() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.Calendar.staticClass, _getAvailableLocales12781)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName12782; 
		public virtual java.lang.String getDisplayName(int arg0, int arg1, java.util.Locale arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayName12782, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Calendar.staticClass, _getDisplayName12782, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTime12783; 
		public virtual void setTime(java.util.Date arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _setTime12783, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _setTime12783, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTime12784; 
		public virtual java.util.Date getTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallObjectMethodPtr(this, _getTime12784)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Calendar.staticClass, _getTime12784)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimeZone12785; 
		public virtual java.util.TimeZone getTimeZone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.TimeZone>(@__env, @__env.CallObjectMethodPtr(this, _getTimeZone12785)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.TimeZone>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Calendar.staticClass, _getTimeZone12785)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTimeZone12786; 
		public virtual void setTimeZone(java.util.TimeZone arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _setTimeZone12786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _setTimeZone12786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimeInMillis12787; 
		public virtual long getTimeInMillis() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallLongMethod(this, _getTimeInMillis12787); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.Calendar.staticClass, _getTimeInMillis12787); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeTime12788; 
		protected abstract void computeTime(); 
		internal static global::net.sf.jni4net.jni.MethodId _computeFields12789; 
		protected abstract void computeFields(); 
		internal static global::net.sf.jni4net.jni.MethodId _setTimeInMillis12790; 
		public virtual void setTimeInMillis(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _setTimeInMillis12790, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _setTimeInMillis12790, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _internalGet12791; 
		protected virtual int internalGet(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _internalGet12791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _internalGet12791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayNames12792; 
		public virtual java.util.Map getDisplayNames(int arg0, int arg1, java.util.Locale arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayNames12792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Calendar.staticClass, _getDisplayNames12792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _roll12793; 
		public virtual void roll(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _roll12793, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _roll12793, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _roll12794; 
		public abstract void roll(int arg0, bool arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _setLenient12795; 
		public virtual void setLenient(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _setLenient12795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _setLenient12795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLenient12796; 
		public virtual bool isLenient() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallBooleanMethod(this, _isLenient12796); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Calendar.staticClass, _isLenient12796); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFirstDayOfWeek12797; 
		public virtual void setFirstDayOfWeek(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _setFirstDayOfWeek12797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _setFirstDayOfWeek12797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFirstDayOfWeek12798; 
		public virtual int getFirstDayOfWeek() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _getFirstDayOfWeek12798); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _getFirstDayOfWeek12798); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinimalDaysInFirstWeek12799; 
		public virtual void setMinimalDaysInFirstWeek(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _setMinimalDaysInFirstWeek12799, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _setMinimalDaysInFirstWeek12799, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimalDaysInFirstWeek12800; 
		public virtual int getMinimalDaysInFirstWeek() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _getMinimalDaysInFirstWeek12800); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _getMinimalDaysInFirstWeek12800); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimum12801; 
		public abstract int getMinimum(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getMaximum12802; 
		public abstract int getMaximum(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getGreatestMinimum12803; 
		public abstract int getGreatestMinimum(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getLeastMaximum12804; 
		public abstract int getLeastMaximum(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getActualMinimum12805; 
		public virtual int getActualMinimum(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _getActualMinimum12805, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _getActualMinimum12805, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getActualMaximum12806; 
		public virtual int getActualMaximum(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _getActualMaximum12806, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _getActualMaximum12806, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Calendar12807; 
		protected Calendar(java.util.TimeZone arg0, java.util.Locale arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Calendar.staticClass, _Calendar12807, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Calendar12808; 
		protected Calendar()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Calendar.staticClass, _Calendar12808, this); 
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
			global::java.util.Calendar._add12759 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "add", "(II)V"); 
			global::java.util.Calendar._get12760 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "get", "(I)I"); 
			global::java.util.Calendar._hashCode12761 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "hashCode", "()I"); 
			global::java.util.Calendar._clone12762 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::java.util.Calendar._equals12763 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.util.Calendar._compareTo12764 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "compareTo", "(Ljava/util/Calendar;)I"); 
			global::java.util.Calendar._compareTo12765 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.util.Calendar._clear12766 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "clear", "(I)V"); 
			global::java.util.Calendar._clear12767 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "clear", "()V"); 
			global::java.util.Calendar._toString12768 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.Calendar._getInstance12769 = @__env.GetStaticMethodID(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/util/Calendar;"); 
			global::java.util.Calendar._getInstance12770 = @__env.GetStaticMethodID(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/util/Calendar;"); 
			global::java.util.Calendar._getInstance12771 = @__env.GetStaticMethodID(global::java.util.Calendar.staticClass, "getInstance", "()Ljava/util/Calendar;"); 
			global::java.util.Calendar._getInstance12772 = @__env.GetStaticMethodID(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/TimeZone;)Ljava/util/Calendar;"); 
			global::java.util.Calendar._set12773 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "set", "(IIIII)V"); 
			global::java.util.Calendar._set12774 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "set", "(II)V"); 
			global::java.util.Calendar._set12775 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "set", "(III)V"); 
			global::java.util.Calendar._set12776 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "set", "(IIIIII)V"); 
			global::java.util.Calendar._isSet12777 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "isSet", "(I)Z"); 
			global::java.util.Calendar._after12778 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "after", "(Ljava/lang/Object;)Z"); 
			global::java.util.Calendar._before12779 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "before", "(Ljava/lang/Object;)Z"); 
			global::java.util.Calendar._complete12780 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "complete", "()V"); 
			global::java.util.Calendar._getAvailableLocales12781 = @__env.GetStaticMethodID(global::java.util.Calendar.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;"); 
			global::java.util.Calendar._getDisplayName12782 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getDisplayName", "(IILjava/util/Locale;)Ljava/lang/String;"); 
			global::java.util.Calendar._setTime12783 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setTime", "(Ljava/util/Date;)V"); 
			global::java.util.Calendar._getTime12784 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getTime", "()Ljava/util/Date;"); 
			global::java.util.Calendar._getTimeZone12785 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getTimeZone", "()Ljava/util/TimeZone;"); 
			global::java.util.Calendar._setTimeZone12786 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V"); 
			global::java.util.Calendar._getTimeInMillis12787 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getTimeInMillis", "()J"); 
			global::java.util.Calendar._computeTime12788 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "computeTime", "()V"); 
			global::java.util.Calendar._computeFields12789 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "computeFields", "()V"); 
			global::java.util.Calendar._setTimeInMillis12790 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setTimeInMillis", "(J)V"); 
			global::java.util.Calendar._internalGet12791 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "internalGet", "(I)I"); 
			global::java.util.Calendar._getDisplayNames12792 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getDisplayNames", "(IILjava/util/Locale;)Ljava/util/Map;"); 
			global::java.util.Calendar._roll12793 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "roll", "(II)V"); 
			global::java.util.Calendar._roll12794 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "roll", "(IZ)V"); 
			global::java.util.Calendar._setLenient12795 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setLenient", "(Z)V"); 
			global::java.util.Calendar._isLenient12796 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "isLenient", "()Z"); 
			global::java.util.Calendar._setFirstDayOfWeek12797 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setFirstDayOfWeek", "(I)V"); 
			global::java.util.Calendar._getFirstDayOfWeek12798 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getFirstDayOfWeek", "()I"); 
			global::java.util.Calendar._setMinimalDaysInFirstWeek12799 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setMinimalDaysInFirstWeek", "(I)V"); 
			global::java.util.Calendar._getMinimalDaysInFirstWeek12800 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getMinimalDaysInFirstWeek", "()I"); 
			global::java.util.Calendar._getMinimum12801 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getMinimum", "(I)I"); 
			global::java.util.Calendar._getMaximum12802 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getMaximum", "(I)I"); 
			global::java.util.Calendar._getGreatestMinimum12803 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getGreatestMinimum", "(I)I"); 
			global::java.util.Calendar._getLeastMaximum12804 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getLeastMaximum", "(I)I"); 
			global::java.util.Calendar._getActualMinimum12805 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getActualMinimum", "(I)I"); 
			global::java.util.Calendar._getActualMaximum12806 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getActualMaximum", "(I)I"); 
			global::java.util.Calendar._Calendar12807 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V"); 
			global::java.util.Calendar._Calendar12808 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "<init>", "()V"); 
		} 
	} 
} 
