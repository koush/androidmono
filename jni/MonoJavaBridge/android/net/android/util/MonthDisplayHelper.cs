namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MonthDisplayHelper : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static MonthDisplayHelper() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.MonthDisplayHelper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getOffset7572; 
		public virtual int getOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getOffset7572); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getOffset7572); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getYear7573; 
		public virtual int getYear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getYear7573); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getYear7573); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMonth7574; 
		public virtual int getMonth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getMonth7574); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getMonth7574); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWeekStartDay7575; 
		public virtual int getWeekStartDay() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getWeekStartDay7575); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getWeekStartDay7575); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFirstDayOfMonth7576; 
		public virtual int getFirstDayOfMonth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getFirstDayOfMonth7576); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getFirstDayOfMonth7576); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumberOfDaysInMonth7577; 
		public virtual int getNumberOfDaysInMonth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth7577); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth7577); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDigitsForRow7578; 
		public virtual int[] getDigitsForRow(int arg0) 
		{ 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.util.MonthDisplayHelper._getDigitsForRow7578, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getDigitsForRow7578, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDayAt7579; 
		public virtual int getDayAt(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getDayAt7579, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getDayAt7579, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRowOf7580; 
		public virtual int getRowOf(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getRowOf7580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getRowOf7580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnOf7581; 
		public virtual int getColumnOf(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getColumnOf7581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getColumnOf7581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _previousMonth7582; 
		public virtual void previousMonth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				@__env.CallVoidMethod(this, global::android.util.MonthDisplayHelper._previousMonth7582); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._previousMonth7582); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextMonth7583; 
		public virtual void nextMonth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				@__env.CallVoidMethod(this, global::android.util.MonthDisplayHelper._nextMonth7583); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._nextMonth7583); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isWithinCurrentMonth7584; 
		public virtual bool isWithinCurrentMonth(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.util.MonthDisplayHelper)) 
				return @__env.CallBooleanMethod(this, global::android.util.MonthDisplayHelper._isWithinCurrentMonth7584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._isWithinCurrentMonth7584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MonthDisplayHelper7585; 
		public MonthDisplayHelper(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._MonthDisplayHelper7585, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MonthDisplayHelper7586; 
		public MonthDisplayHelper(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._MonthDisplayHelper7586, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.MonthDisplayHelper.staticClass = @__class; 
			global::android.util.MonthDisplayHelper._getOffset7572 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getOffset", "()I"); 
			global::android.util.MonthDisplayHelper._getYear7573 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getYear", "()I"); 
			global::android.util.MonthDisplayHelper._getMonth7574 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getMonth", "()I"); 
			global::android.util.MonthDisplayHelper._getWeekStartDay7575 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getWeekStartDay", "()I"); 
			global::android.util.MonthDisplayHelper._getFirstDayOfMonth7576 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getFirstDayOfMonth", "()I"); 
			global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth7577 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getNumberOfDaysInMonth", "()I"); 
			global::android.util.MonthDisplayHelper._getDigitsForRow7578 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getDigitsForRow", "(I)[I"); 
			global::android.util.MonthDisplayHelper._getDayAt7579 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getDayAt", "(II)I"); 
			global::android.util.MonthDisplayHelper._getRowOf7580 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getRowOf", "(I)I"); 
			global::android.util.MonthDisplayHelper._getColumnOf7581 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getColumnOf", "(I)I"); 
			global::android.util.MonthDisplayHelper._previousMonth7582 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "previousMonth", "()V"); 
			global::android.util.MonthDisplayHelper._nextMonth7583 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "nextMonth", "()V"); 
			global::android.util.MonthDisplayHelper._isWithinCurrentMonth7584 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "isWithinCurrentMonth", "(II)Z"); 
			global::android.util.MonthDisplayHelper._MonthDisplayHelper7585 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(III)V"); 
			global::android.util.MonthDisplayHelper._MonthDisplayHelper7586 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(II)V"); 
		} 
	} 
} 
