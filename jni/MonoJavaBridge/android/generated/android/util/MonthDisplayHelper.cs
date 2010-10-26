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
		internal static global::MonoJavaBridge.MethodId _getOffset13798;
		public virtual int getOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getOffset13798);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getOffset13798);
		}
		public new int Year
		{
			get
			{
				return getYear();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYear13799;
		public virtual int getYear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getYear13799);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getYear13799);
		}
		public new int Month
		{
			get
			{
				return getMonth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMonth13800;
		public virtual int getMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getMonth13800);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getMonth13800);
		}
		public new int WeekStartDay
		{
			get
			{
				return getWeekStartDay();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWeekStartDay13801;
		public virtual int getWeekStartDay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getWeekStartDay13801);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getWeekStartDay13801);
		}
		public new int FirstDayOfMonth
		{
			get
			{
				return getFirstDayOfMonth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFirstDayOfMonth13802;
		public virtual int getFirstDayOfMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getFirstDayOfMonth13802);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getFirstDayOfMonth13802);
		}
		public new int NumberOfDaysInMonth
		{
			get
			{
				return getNumberOfDaysInMonth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNumberOfDaysInMonth13803;
		public virtual int getNumberOfDaysInMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth13803);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth13803);
		}
		internal static global::MonoJavaBridge.MethodId _getDigitsForRow13804;
		public virtual int[] getDigitsForRow(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getDigitsForRow13804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getDigitsForRow13804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getDayAt13805;
		public virtual int getDayAt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getDayAt13805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getDayAt13805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getRowOf13806;
		public virtual int getRowOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getRowOf13806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getRowOf13806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnOf13807;
		public virtual int getColumnOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getColumnOf13807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getColumnOf13807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _previousMonth13808;
		public virtual void previousMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._previousMonth13808);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._previousMonth13808);
		}
		internal static global::MonoJavaBridge.MethodId _nextMonth13809;
		public virtual void nextMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._nextMonth13809);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._nextMonth13809);
		}
		internal static global::MonoJavaBridge.MethodId _isWithinCurrentMonth13810;
		public virtual bool isWithinCurrentMonth(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._isWithinCurrentMonth13810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._isWithinCurrentMonth13810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _MonthDisplayHelper13811;
		public MonthDisplayHelper(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._MonthDisplayHelper13811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MonthDisplayHelper13812;
		public MonthDisplayHelper(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._MonthDisplayHelper13812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.MonthDisplayHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/MonthDisplayHelper"));
			global::android.util.MonthDisplayHelper._getOffset13798 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getOffset", "()I");
			global::android.util.MonthDisplayHelper._getYear13799 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getYear", "()I");
			global::android.util.MonthDisplayHelper._getMonth13800 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getMonth", "()I");
			global::android.util.MonthDisplayHelper._getWeekStartDay13801 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getWeekStartDay", "()I");
			global::android.util.MonthDisplayHelper._getFirstDayOfMonth13802 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getFirstDayOfMonth", "()I");
			global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth13803 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getNumberOfDaysInMonth", "()I");
			global::android.util.MonthDisplayHelper._getDigitsForRow13804 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getDigitsForRow", "(I)[I");
			global::android.util.MonthDisplayHelper._getDayAt13805 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getDayAt", "(II)I");
			global::android.util.MonthDisplayHelper._getRowOf13806 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getRowOf", "(I)I");
			global::android.util.MonthDisplayHelper._getColumnOf13807 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getColumnOf", "(I)I");
			global::android.util.MonthDisplayHelper._previousMonth13808 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "previousMonth", "()V");
			global::android.util.MonthDisplayHelper._nextMonth13809 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "nextMonth", "()V");
			global::android.util.MonthDisplayHelper._isWithinCurrentMonth13810 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "isWithinCurrentMonth", "(II)Z");
			global::android.util.MonthDisplayHelper._MonthDisplayHelper13811 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(III)V");
			global::android.util.MonthDisplayHelper._MonthDisplayHelper13812 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(II)V");
		}
	}
}
