namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MonthDisplayHelper : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MonthDisplayHelper()
		{
			InitJNI();
		}
		protected MonthDisplayHelper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Offset
		{
			get
			{
				return getOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOffset13734;
		public virtual int getOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getOffset13734);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getOffset13734);
		}
		public new int Year
		{
			get
			{
				return getYear();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYear13735;
		public virtual int getYear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getYear13735);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getYear13735);
		}
		public new int Month
		{
			get
			{
				return getMonth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMonth13736;
		public virtual int getMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getMonth13736);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getMonth13736);
		}
		public new int WeekStartDay
		{
			get
			{
				return getWeekStartDay();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWeekStartDay13737;
		public virtual int getWeekStartDay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getWeekStartDay13737);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getWeekStartDay13737);
		}
		public new int FirstDayOfMonth
		{
			get
			{
				return getFirstDayOfMonth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFirstDayOfMonth13738;
		public virtual int getFirstDayOfMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getFirstDayOfMonth13738);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getFirstDayOfMonth13738);
		}
		public new int NumberOfDaysInMonth
		{
			get
			{
				return getNumberOfDaysInMonth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNumberOfDaysInMonth13739;
		public virtual int getNumberOfDaysInMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth13739);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth13739);
		}
		internal static global::MonoJavaBridge.MethodId _getDigitsForRow13740;
		public virtual int[] getDigitsForRow(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getDigitsForRow13740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getDigitsForRow13740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getDayAt13741;
		public virtual int getDayAt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getDayAt13741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getDayAt13741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getRowOf13742;
		public virtual int getRowOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getRowOf13742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getRowOf13742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnOf13743;
		public virtual int getColumnOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getColumnOf13743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getColumnOf13743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _previousMonth13744;
		public virtual void previousMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._previousMonth13744);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._previousMonth13744);
		}
		internal static global::MonoJavaBridge.MethodId _nextMonth13745;
		public virtual void nextMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._nextMonth13745);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._nextMonth13745);
		}
		internal static global::MonoJavaBridge.MethodId _isWithinCurrentMonth13746;
		public virtual bool isWithinCurrentMonth(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._isWithinCurrentMonth13746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._isWithinCurrentMonth13746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _MonthDisplayHelper13747;
		public MonthDisplayHelper(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._MonthDisplayHelper13747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MonthDisplayHelper13748;
		public MonthDisplayHelper(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._MonthDisplayHelper13748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.MonthDisplayHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/MonthDisplayHelper"));
			global::android.util.MonthDisplayHelper._getOffset13734 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getOffset", "()I");
			global::android.util.MonthDisplayHelper._getYear13735 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getYear", "()I");
			global::android.util.MonthDisplayHelper._getMonth13736 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getMonth", "()I");
			global::android.util.MonthDisplayHelper._getWeekStartDay13737 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getWeekStartDay", "()I");
			global::android.util.MonthDisplayHelper._getFirstDayOfMonth13738 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getFirstDayOfMonth", "()I");
			global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth13739 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getNumberOfDaysInMonth", "()I");
			global::android.util.MonthDisplayHelper._getDigitsForRow13740 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getDigitsForRow", "(I)[I");
			global::android.util.MonthDisplayHelper._getDayAt13741 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getDayAt", "(II)I");
			global::android.util.MonthDisplayHelper._getRowOf13742 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getRowOf", "(I)I");
			global::android.util.MonthDisplayHelper._getColumnOf13743 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getColumnOf", "(I)I");
			global::android.util.MonthDisplayHelper._previousMonth13744 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "previousMonth", "()V");
			global::android.util.MonthDisplayHelper._nextMonth13745 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "nextMonth", "()V");
			global::android.util.MonthDisplayHelper._isWithinCurrentMonth13746 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "isWithinCurrentMonth", "(II)Z");
			global::android.util.MonthDisplayHelper._MonthDisplayHelper13747 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(III)V");
			global::android.util.MonthDisplayHelper._MonthDisplayHelper13748 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(II)V");
		}
	}
}
