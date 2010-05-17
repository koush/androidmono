namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MonthDisplayHelper : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static MonthDisplayHelper() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.util.MonthDisplayHelper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.util.MonthDisplayHelper(@__env); 
			} 
		} 
		protected MonthDisplayHelper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOffset7170; 
		public virtual int getOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, _getOffset7170); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.MonthDisplayHelper.staticClass, _getOffset7170); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getYear7171; 
		public virtual int getYear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, _getYear7171); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.MonthDisplayHelper.staticClass, _getYear7171); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMonth7172; 
		public virtual int getMonth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, _getMonth7172); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.MonthDisplayHelper.staticClass, _getMonth7172); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWeekStartDay7173; 
		public virtual int getWeekStartDay() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, _getWeekStartDay7173); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.MonthDisplayHelper.staticClass, _getWeekStartDay7173); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFirstDayOfMonth7174; 
		public virtual int getFirstDayOfMonth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, _getFirstDayOfMonth7174); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.MonthDisplayHelper.staticClass, _getFirstDayOfMonth7174); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumberOfDaysInMonth7175; 
		public virtual int getNumberOfDaysInMonth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, _getNumberOfDaysInMonth7175); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.MonthDisplayHelper.staticClass, _getNumberOfDaysInMonth7175); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDigitsForRow7176; 
		public virtual int[] getDigitsForRow(int arg0) 
		{ 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getDigitsForRow7176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.util.MonthDisplayHelper.staticClass, _getDigitsForRow7176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDayAt7177; 
		public virtual int getDayAt(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, _getDayAt7177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.MonthDisplayHelper.staticClass, _getDayAt7177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRowOf7178; 
		public virtual int getRowOf(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, _getRowOf7178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.MonthDisplayHelper.staticClass, _getRowOf7178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnOf7179; 
		public virtual int getColumnOf(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, _getColumnOf7179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.util.MonthDisplayHelper.staticClass, _getColumnOf7179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _previousMonth7180; 
		public virtual void previousMonth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				@__env.CallVoidMethod(this, _previousMonth7180); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.MonthDisplayHelper.staticClass, _previousMonth7180); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextMonth7181; 
		public virtual void nextMonth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				@__env.CallVoidMethod(this, _nextMonth7181); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.util.MonthDisplayHelper.staticClass, _nextMonth7181); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isWithinCurrentMonth7182; 
		public virtual bool isWithinCurrentMonth(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallBooleanMethod(this, _isWithinCurrentMonth7182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.util.MonthDisplayHelper.staticClass, _isWithinCurrentMonth7182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MonthDisplayHelper7183; 
		public MonthDisplayHelper(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.MonthDisplayHelper.staticClass, _MonthDisplayHelper7183, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MonthDisplayHelper7184; 
		public MonthDisplayHelper(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.MonthDisplayHelper.staticClass, _MonthDisplayHelper7184, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.MonthDisplayHelper.staticClass = @__class; 
			global::android.util.MonthDisplayHelper._getOffset7170 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getOffset", "()I"); 
			global::android.util.MonthDisplayHelper._getYear7171 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getYear", "()I"); 
			global::android.util.MonthDisplayHelper._getMonth7172 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getMonth", "()I"); 
			global::android.util.MonthDisplayHelper._getWeekStartDay7173 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getWeekStartDay", "()I"); 
			global::android.util.MonthDisplayHelper._getFirstDayOfMonth7174 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getFirstDayOfMonth", "()I"); 
			global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth7175 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getNumberOfDaysInMonth", "()I"); 
			global::android.util.MonthDisplayHelper._getDigitsForRow7176 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getDigitsForRow", "(I)[I"); 
			global::android.util.MonthDisplayHelper._getDayAt7177 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getDayAt", "(II)I"); 
			global::android.util.MonthDisplayHelper._getRowOf7178 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getRowOf", "(I)I"); 
			global::android.util.MonthDisplayHelper._getColumnOf7179 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getColumnOf", "(I)I"); 
			global::android.util.MonthDisplayHelper._previousMonth7180 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "previousMonth", "()V"); 
			global::android.util.MonthDisplayHelper._nextMonth7181 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "nextMonth", "()V"); 
			global::android.util.MonthDisplayHelper._isWithinCurrentMonth7182 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "isWithinCurrentMonth", "(II)Z"); 
			global::android.util.MonthDisplayHelper._MonthDisplayHelper7183 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(III)V"); 
			global::android.util.MonthDisplayHelper._MonthDisplayHelper7184 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(II)V"); 
		} 
	} 
} 
