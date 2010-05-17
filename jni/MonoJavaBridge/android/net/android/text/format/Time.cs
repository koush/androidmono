namespace android.text.format 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Time : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Time() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.format.Time), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.format.Time(@__env); 
			} 
		} 
		protected Time(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear6715; 
		public virtual void clear(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				@__env.CallVoidMethod(this, _clear6715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.format.Time.staticClass, _clear6715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString6716; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString6716)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.format.Time.staticClass, _toString6716)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format6717; 
		public virtual java.lang.String format(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _format6717, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.format.Time.staticClass, _format6717, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compare6718; 
		public static int compare(android.text.format.Time arg0, android.text.format.Time arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.format.Time.staticClass, _compare6718, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set6719; 
		public virtual void set(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				@__env.CallVoidMethod(this, _set6719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.format.Time.staticClass, _set6719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set6720; 
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				@__env.CallVoidMethod(this, _set6720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.format.Time.staticClass, _set6720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set6721; 
		public virtual void set(android.text.format.Time arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				@__env.CallVoidMethod(this, _set6721, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.format.Time.staticClass, _set6721, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set6722; 
		public virtual void set(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				@__env.CallVoidMethod(this, _set6722, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.format.Time.staticClass, _set6722, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _normalize6723; 
		public virtual long normalize(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				return @__env.CallLongMethod(this, _normalize6723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.text.format.Time.staticClass, _normalize6723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _after6724; 
		public virtual bool after(android.text.format.Time arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				return @__env.CallBooleanMethod(this, _after6724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.format.Time.staticClass, _after6724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _before6725; 
		public virtual bool before(android.text.format.Time arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				return @__env.CallBooleanMethod(this, _before6725, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.format.Time.staticClass, _before6725, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parse6726; 
		public virtual bool parse(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				return @__env.CallBooleanMethod(this, _parse6726, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.format.Time.staticClass, _parse6726, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toMillis6727; 
		public virtual long toMillis(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				return @__env.CallLongMethod(this, _toMillis6727, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.text.format.Time.staticClass, _toMillis6727, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getActualMaximum6728; 
		public virtual int getActualMaximum(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				return @__env.CallIntMethod(this, _getActualMaximum6728, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.format.Time.staticClass, _getActualMaximum6728, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _switchTimezone6729; 
		public virtual void switchTimezone(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				@__env.CallVoidMethod(this, _switchTimezone6729, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.format.Time.staticClass, _switchTimezone6729, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parse33396730; 
		public virtual bool parse3339(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				return @__env.CallBooleanMethod(this, _parse33396730, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.format.Time.staticClass, _parse33396730, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentTimezone6731; 
		public static java.lang.String getCurrentTimezone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.Time.staticClass, _getCurrentTimezone6731)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setToNow6732; 
		public virtual void setToNow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				@__env.CallVoidMethod(this, _setToNow6732); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.format.Time.staticClass, _setToNow6732); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format24456733; 
		public virtual java.lang.String format2445() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _format24456733)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.format.Time.staticClass, _format24456733)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWeekNumber6734; 
		public virtual int getWeekNumber() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				return @__env.CallIntMethod(this, _getWeekNumber6734); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.format.Time.staticClass, _getWeekNumber6734); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format33396735; 
		public virtual java.lang.String format3339(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _format33396735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.format.Time.staticClass, _format33396735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEpoch6736; 
		public static bool isEpoch(android.text.format.Time arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.format.Time.staticClass, _isEpoch6736, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getJulianDay6737; 
		public static int getJulianDay(long arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.format.Time.staticClass, _getJulianDay6737, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setJulianDay6738; 
		public virtual long setJulianDay(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.format.Time)) 
				return @__env.CallLongMethod(this, _setJulianDay6738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.text.format.Time.staticClass, _setJulianDay6738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Time6739; 
		public Time(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.format.Time.staticClass, _Time6739, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Time6740; 
		public Time()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.format.Time.staticClass, _Time6740, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Time6741; 
		public Time(android.text.format.Time arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.format.Time.staticClass, _Time6741, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static java.lang.String TIMEZONE_UTC
		{ 
			get 
			{ 
				return "UTC"; 
			} 
		} 
		public static int EPOCH_JULIAN_DAY
		{ 
			get 
			{ 
				return 2440588; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _allDay6742; 
		public bool allDay
		{ 
			get 
			{ 
				return default(bool); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _second6743; 
		public int second
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _minute6744; 
		public int minute
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _hour6745; 
		public int hour
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _monthDay6746; 
		public int monthDay
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _month6747; 
		public int month
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _year6748; 
		public int year
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _weekDay6749; 
		public int weekDay
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _yearDay6750; 
		public int yearDay
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _isDst6751; 
		public int isDst
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _gmtoff6752; 
		public long gmtoff
		{ 
			get 
			{ 
				return default(long); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _timezone6753; 
		public java.lang.String timezone
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		public static int SECOND
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int MINUTE
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int HOUR
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int MONTH_DAY
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int MONTH
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		public static int YEAR
		{ 
			get 
			{ 
				return 6; 
			} 
		} 
		public static int WEEK_DAY
		{ 
			get 
			{ 
				return 7; 
			} 
		} 
		public static int YEAR_DAY
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		public static int WEEK_NUM
		{ 
			get 
			{ 
				return 9; 
			} 
		} 
		public static int SUNDAY
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int MONDAY
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int TUESDAY
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int WEDNESDAY
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int THURSDAY
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int FRIDAY
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		public static int SATURDAY
		{ 
			get 
			{ 
				return 6; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.format.Time.staticClass = @__class; 
			global::android.text.format.Time._clear6715 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "clear", "(Ljava/lang/String;)V"); 
			global::android.text.format.Time._toString6716 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.text.format.Time._format6717 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "format", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.text.format.Time._compare6718 = @__env.GetStaticMethodID(global::android.text.format.Time.staticClass, "compare", "(Landroid/text/format/Time;Landroid/text/format/Time;)I"); 
			global::android.text.format.Time._set6719 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "set", "(J)V"); 
			global::android.text.format.Time._set6720 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "set", "(IIIIII)V"); 
			global::android.text.format.Time._set6721 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "set", "(Landroid/text/format/Time;)V"); 
			global::android.text.format.Time._set6722 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "set", "(III)V"); 
			global::android.text.format.Time._normalize6723 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "normalize", "(Z)J"); 
			global::android.text.format.Time._after6724 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "after", "(Landroid/text/format/Time;)Z"); 
			global::android.text.format.Time._before6725 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "before", "(Landroid/text/format/Time;)Z"); 
			global::android.text.format.Time._parse6726 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "parse", "(Ljava/lang/String;)Z"); 
			global::android.text.format.Time._toMillis6727 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "toMillis", "(Z)J"); 
			global::android.text.format.Time._getActualMaximum6728 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "getActualMaximum", "(I)I"); 
			global::android.text.format.Time._switchTimezone6729 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "switchTimezone", "(Ljava/lang/String;)V"); 
			global::android.text.format.Time._parse33396730 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "parse3339", "(Ljava/lang/String;)Z"); 
			global::android.text.format.Time._getCurrentTimezone6731 = @__env.GetStaticMethodID(global::android.text.format.Time.staticClass, "getCurrentTimezone", "()Ljava/lang/String;"); 
			global::android.text.format.Time._setToNow6732 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "setToNow", "()V"); 
			global::android.text.format.Time._format24456733 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "format2445", "()Ljava/lang/String;"); 
			global::android.text.format.Time._getWeekNumber6734 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "getWeekNumber", "()I"); 
			global::android.text.format.Time._format33396735 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "format3339", "(Z)Ljava/lang/String;"); 
			global::android.text.format.Time._isEpoch6736 = @__env.GetStaticMethodID(global::android.text.format.Time.staticClass, "isEpoch", "(Landroid/text/format/Time;)Z"); 
			global::android.text.format.Time._getJulianDay6737 = @__env.GetStaticMethodID(global::android.text.format.Time.staticClass, "getJulianDay", "(JJ)I"); 
			global::android.text.format.Time._setJulianDay6738 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "setJulianDay", "(I)J"); 
			global::android.text.format.Time._Time6739 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.text.format.Time._Time6740 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "<init>", "()V"); 
			global::android.text.format.Time._Time6741 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "<init>", "(Landroid/text/format/Time;)V"); 
		} 
	} 
} 
