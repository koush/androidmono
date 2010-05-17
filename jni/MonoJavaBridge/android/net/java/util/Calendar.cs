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
		internal static global::net.sf.jni4net.jni.MethodId _add11851; 
		public abstract void add(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _get11852; 
		public virtual int get(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _get11852, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _get11852, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11853; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _hashCode11853); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _hashCode11853); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone11854; 
		public virtual java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _clone11854)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Calendar.staticClass, _clone11854)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11855; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallBooleanMethod(this, _equals11855, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Calendar.staticClass, _equals11855, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11856; 
		public virtual int compareTo(java.util.Calendar arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _compareTo11856, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _compareTo11856, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11857; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _compareTo11857, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _compareTo11857, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear11858; 
		public virtual void clear(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _clear11858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _clear11858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear11859; 
		public virtual void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _clear11859); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _clear11859); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11860; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11860)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Calendar.staticClass, _toString11860)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance11861; 
		public static java.util.Calendar getInstance(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Calendar.staticClass, _getInstance11861, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance11862; 
		public static java.util.Calendar getInstance(java.util.TimeZone arg0, java.util.Locale arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Calendar.staticClass, _getInstance11862, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance11863; 
		public static java.util.Calendar getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Calendar.staticClass, _getInstance11863)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance11864; 
		public static java.util.Calendar getInstance(java.util.TimeZone arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Calendar.staticClass, _getInstance11864, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set11865; 
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _set11865, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _set11865, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set11866; 
		public virtual void set(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _set11866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _set11866, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set11867; 
		public virtual void set(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _set11867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _set11867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set11868; 
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _set11868, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _set11868, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSet11869; 
		public virtual bool isSet(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallBooleanMethod(this, _isSet11869, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Calendar.staticClass, _isSet11869, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _after11870; 
		public virtual bool after(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallBooleanMethod(this, _after11870, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Calendar.staticClass, _after11870, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _before11871; 
		public virtual bool before(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallBooleanMethod(this, _before11871, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Calendar.staticClass, _before11871, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _complete11872; 
		protected virtual void complete() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _complete11872); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _complete11872); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableLocales11873; 
		public static java.util.Locale[] getAvailableLocales() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.Calendar.staticClass, _getAvailableLocales11873)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName11874; 
		public virtual java.lang.String getDisplayName(int arg0, int arg1, java.util.Locale arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayName11874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Calendar.staticClass, _getDisplayName11874, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTime11875; 
		public virtual void setTime(java.util.Date arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _setTime11875, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _setTime11875, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTime11876; 
		public virtual java.util.Date getTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallObjectMethodPtr(this, _getTime11876)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Calendar.staticClass, _getTime11876)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimeZone11877; 
		public virtual java.util.TimeZone getTimeZone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.TimeZone>(@__env, @__env.CallObjectMethodPtr(this, _getTimeZone11877)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.TimeZone>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Calendar.staticClass, _getTimeZone11877)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTimeZone11878; 
		public virtual void setTimeZone(java.util.TimeZone arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _setTimeZone11878, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _setTimeZone11878, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimeInMillis11879; 
		public virtual long getTimeInMillis() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallLongMethod(this, _getTimeInMillis11879); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.Calendar.staticClass, _getTimeInMillis11879); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeTime11880; 
		protected abstract void computeTime(); 
		internal static global::net.sf.jni4net.jni.MethodId _computeFields11881; 
		protected abstract void computeFields(); 
		internal static global::net.sf.jni4net.jni.MethodId _setTimeInMillis11882; 
		public virtual void setTimeInMillis(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _setTimeInMillis11882, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _setTimeInMillis11882, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _internalGet11883; 
		protected virtual int internalGet(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _internalGet11883, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _internalGet11883, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayNames11884; 
		public virtual java.util.Map getDisplayNames(int arg0, int arg1, java.util.Locale arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayNames11884, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Calendar.staticClass, _getDisplayNames11884, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _roll11885; 
		public virtual void roll(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _roll11885, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _roll11885, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _roll11886; 
		public abstract void roll(int arg0, bool arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _setLenient11887; 
		public virtual void setLenient(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _setLenient11887, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _setLenient11887, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLenient11888; 
		public virtual bool isLenient() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallBooleanMethod(this, _isLenient11888); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Calendar.staticClass, _isLenient11888); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFirstDayOfWeek11889; 
		public virtual void setFirstDayOfWeek(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _setFirstDayOfWeek11889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _setFirstDayOfWeek11889, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFirstDayOfWeek11890; 
		public virtual int getFirstDayOfWeek() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _getFirstDayOfWeek11890); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _getFirstDayOfWeek11890); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMinimalDaysInFirstWeek11891; 
		public virtual void setMinimalDaysInFirstWeek(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				@__env.CallVoidMethod(this, _setMinimalDaysInFirstWeek11891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Calendar.staticClass, _setMinimalDaysInFirstWeek11891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimalDaysInFirstWeek11892; 
		public virtual int getMinimalDaysInFirstWeek() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _getMinimalDaysInFirstWeek11892); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _getMinimalDaysInFirstWeek11892); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimum11893; 
		public abstract int getMinimum(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getMaximum11894; 
		public abstract int getMaximum(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getGreatestMinimum11895; 
		public abstract int getGreatestMinimum(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getLeastMaximum11896; 
		public abstract int getLeastMaximum(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getActualMinimum11897; 
		public virtual int getActualMinimum(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _getActualMinimum11897, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _getActualMinimum11897, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getActualMaximum11898; 
		public virtual int getActualMaximum(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Calendar)) 
				return @__env.CallIntMethod(this, _getActualMaximum11898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Calendar.staticClass, _getActualMaximum11898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Calendar11899; 
		protected Calendar(java.util.TimeZone arg0, java.util.Locale arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Calendar.staticClass, _Calendar11899, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Calendar11900; 
		protected Calendar()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Calendar.staticClass, _Calendar11900, this); 
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
			global::java.util.Calendar._add11851 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "add", "(II)V"); 
			global::java.util.Calendar._get11852 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "get", "(I)I"); 
			global::java.util.Calendar._hashCode11853 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "hashCode", "()I"); 
			global::java.util.Calendar._clone11854 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::java.util.Calendar._equals11855 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.util.Calendar._compareTo11856 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "compareTo", "(Ljava/util/Calendar;)I"); 
			global::java.util.Calendar._compareTo11857 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.util.Calendar._clear11858 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "clear", "(I)V"); 
			global::java.util.Calendar._clear11859 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "clear", "()V"); 
			global::java.util.Calendar._toString11860 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.Calendar._getInstance11861 = @__env.GetStaticMethodID(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/util/Calendar;"); 
			global::java.util.Calendar._getInstance11862 = @__env.GetStaticMethodID(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/util/Calendar;"); 
			global::java.util.Calendar._getInstance11863 = @__env.GetStaticMethodID(global::java.util.Calendar.staticClass, "getInstance", "()Ljava/util/Calendar;"); 
			global::java.util.Calendar._getInstance11864 = @__env.GetStaticMethodID(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/TimeZone;)Ljava/util/Calendar;"); 
			global::java.util.Calendar._set11865 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "set", "(IIIII)V"); 
			global::java.util.Calendar._set11866 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "set", "(II)V"); 
			global::java.util.Calendar._set11867 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "set", "(III)V"); 
			global::java.util.Calendar._set11868 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "set", "(IIIIII)V"); 
			global::java.util.Calendar._isSet11869 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "isSet", "(I)Z"); 
			global::java.util.Calendar._after11870 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "after", "(Ljava/lang/Object;)Z"); 
			global::java.util.Calendar._before11871 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "before", "(Ljava/lang/Object;)Z"); 
			global::java.util.Calendar._complete11872 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "complete", "()V"); 
			global::java.util.Calendar._getAvailableLocales11873 = @__env.GetStaticMethodID(global::java.util.Calendar.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;"); 
			global::java.util.Calendar._getDisplayName11874 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getDisplayName", "(IILjava/util/Locale;)Ljava/lang/String;"); 
			global::java.util.Calendar._setTime11875 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setTime", "(Ljava/util/Date;)V"); 
			global::java.util.Calendar._getTime11876 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getTime", "()Ljava/util/Date;"); 
			global::java.util.Calendar._getTimeZone11877 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getTimeZone", "()Ljava/util/TimeZone;"); 
			global::java.util.Calendar._setTimeZone11878 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V"); 
			global::java.util.Calendar._getTimeInMillis11879 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getTimeInMillis", "()J"); 
			global::java.util.Calendar._computeTime11880 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "computeTime", "()V"); 
			global::java.util.Calendar._computeFields11881 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "computeFields", "()V"); 
			global::java.util.Calendar._setTimeInMillis11882 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setTimeInMillis", "(J)V"); 
			global::java.util.Calendar._internalGet11883 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "internalGet", "(I)I"); 
			global::java.util.Calendar._getDisplayNames11884 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getDisplayNames", "(IILjava/util/Locale;)Ljava/util/Map;"); 
			global::java.util.Calendar._roll11885 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "roll", "(II)V"); 
			global::java.util.Calendar._roll11886 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "roll", "(IZ)V"); 
			global::java.util.Calendar._setLenient11887 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setLenient", "(Z)V"); 
			global::java.util.Calendar._isLenient11888 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "isLenient", "()Z"); 
			global::java.util.Calendar._setFirstDayOfWeek11889 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setFirstDayOfWeek", "(I)V"); 
			global::java.util.Calendar._getFirstDayOfWeek11890 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getFirstDayOfWeek", "()I"); 
			global::java.util.Calendar._setMinimalDaysInFirstWeek11891 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "setMinimalDaysInFirstWeek", "(I)V"); 
			global::java.util.Calendar._getMinimalDaysInFirstWeek11892 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getMinimalDaysInFirstWeek", "()I"); 
			global::java.util.Calendar._getMinimum11893 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getMinimum", "(I)I"); 
			global::java.util.Calendar._getMaximum11894 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getMaximum", "(I)I"); 
			global::java.util.Calendar._getGreatestMinimum11895 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getGreatestMinimum", "(I)I"); 
			global::java.util.Calendar._getLeastMaximum11896 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getLeastMaximum", "(I)I"); 
			global::java.util.Calendar._getActualMinimum11897 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getActualMinimum", "(I)I"); 
			global::java.util.Calendar._getActualMaximum11898 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "getActualMaximum", "(I)I"); 
			global::java.util.Calendar._Calendar11899 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V"); 
			global::java.util.Calendar._Calendar11900 = @__env.GetMethodID(global::java.util.Calendar.staticClass, "<init>", "()V"); 
		} 
	} 
} 
