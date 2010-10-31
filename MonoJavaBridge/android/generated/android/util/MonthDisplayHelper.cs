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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getOffset", "()I", ref global::android.util.MonthDisplayHelper._m0);
		}
		public new int Year
		{
			get
			{
				return getYear();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getYear()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getYear", "()I", ref global::android.util.MonthDisplayHelper._m1);
		}
		public new int Month
		{
			get
			{
				return getMonth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getMonth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getMonth", "()I", ref global::android.util.MonthDisplayHelper._m2);
		}
		public new int WeekStartDay
		{
			get
			{
				return getWeekStartDay();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getWeekStartDay()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getWeekStartDay", "()I", ref global::android.util.MonthDisplayHelper._m3);
		}
		public new int FirstDayOfMonth
		{
			get
			{
				return getFirstDayOfMonth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getFirstDayOfMonth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getFirstDayOfMonth", "()I", ref global::android.util.MonthDisplayHelper._m4);
		}
		public new int NumberOfDaysInMonth
		{
			get
			{
				return getNumberOfDaysInMonth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getNumberOfDaysInMonth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getNumberOfDaysInMonth", "()I", ref global::android.util.MonthDisplayHelper._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int[] getDigitsForRow(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.util.MonthDisplayHelper.staticClass, "getDigitsForRow", "(I)[I", ref global::android.util.MonthDisplayHelper._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getDayAt(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getDayAt", "(II)I", ref global::android.util.MonthDisplayHelper._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getRowOf(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getRowOf", "(I)I", ref global::android.util.MonthDisplayHelper._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getColumnOf(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, "getColumnOf", "(I)I", ref global::android.util.MonthDisplayHelper._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void previousMonth()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.MonthDisplayHelper.staticClass, "previousMonth", "()V", ref global::android.util.MonthDisplayHelper._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void nextMonth()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.MonthDisplayHelper.staticClass, "nextMonth", "()V", ref global::android.util.MonthDisplayHelper._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool isWithinCurrentMonth(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.util.MonthDisplayHelper.staticClass, "isWithinCurrentMonth", "(II)Z", ref global::android.util.MonthDisplayHelper._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public MonthDisplayHelper(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.MonthDisplayHelper._m13.native == global::System.IntPtr.Zero)
				global::android.util.MonthDisplayHelper._m13 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public MonthDisplayHelper(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.MonthDisplayHelper._m14.native == global::System.IntPtr.Zero)
				global::android.util.MonthDisplayHelper._m14 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static MonthDisplayHelper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.MonthDisplayHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/MonthDisplayHelper"));
		}
	}
}
