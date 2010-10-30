namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MonthDisplayHelper : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getOffset", "()I", ref global::android.util.MonthDisplayHelper._getOffset13798);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getYear", "()I", ref global::android.util.MonthDisplayHelper._getYear13799);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getMonth", "()I", ref global::android.util.MonthDisplayHelper._getMonth13800);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getWeekStartDay", "()I", ref global::android.util.MonthDisplayHelper._getWeekStartDay13801);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getFirstDayOfMonth", "()I", ref global::android.util.MonthDisplayHelper._getFirstDayOfMonth13802);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getNumberOfDaysInMonth", "()I", ref global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth13803);
		}
		internal static global::MonoJavaBridge.MethodId _getDigitsForRow13804;
		public virtual int[] getDigitsForRow(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.util.MonthDisplayHelper.staticClass, "getDigitsForRow", "(I)[I", ref global::android.util.MonthDisplayHelper._getDigitsForRow13804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getDayAt13805;
		public virtual int getDayAt(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getDayAt", "(II)I", ref global::android.util.MonthDisplayHelper._getDayAt13805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getRowOf13806;
		public virtual int getRowOf(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getRowOf", "(I)I", ref global::android.util.MonthDisplayHelper._getRowOf13806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnOf13807;
		public virtual int getColumnOf(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getColumnOf", "(I)I", ref global::android.util.MonthDisplayHelper._getColumnOf13807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _previousMonth13808;
		public virtual void previousMonth()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.MonthDisplayHelper.staticClass, "previousMonth", "()V", ref global::android.util.MonthDisplayHelper._previousMonth13808);
		}
		internal static global::MonoJavaBridge.MethodId _nextMonth13809;
		public virtual void nextMonth()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.MonthDisplayHelper.staticClass, "nextMonth", "()V", ref global::android.util.MonthDisplayHelper._nextMonth13809);
		}
		internal static global::MonoJavaBridge.MethodId _isWithinCurrentMonth13810;
		public virtual bool isWithinCurrentMonth(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.util.MonthDisplayHelper.staticClass, "isWithinCurrentMonth", "(II)Z", ref global::android.util.MonthDisplayHelper._isWithinCurrentMonth13810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _MonthDisplayHelper13811;
		public MonthDisplayHelper(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.MonthDisplayHelper._MonthDisplayHelper13811.native == global::System.IntPtr.Zero)
				global::android.util.MonthDisplayHelper._MonthDisplayHelper13811 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._MonthDisplayHelper13811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MonthDisplayHelper13812;
		public MonthDisplayHelper(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.MonthDisplayHelper._MonthDisplayHelper13812.native == global::System.IntPtr.Zero)
				global::android.util.MonthDisplayHelper._MonthDisplayHelper13812 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._MonthDisplayHelper13812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static MonthDisplayHelper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.MonthDisplayHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/MonthDisplayHelper"));
		}
		internal static void InitJNI()
		{
		}
	}
}
