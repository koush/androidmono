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
		internal static global::MonoJavaBridge.MethodId _getOffset9088;
		public virtual int getOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getOffset9088);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getOffset9088);
		}
		public new int Year
		{
			get
			{
				return getYear();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYear9089;
		public virtual int getYear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getYear9089);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getYear9089);
		}
		public new int Month
		{
			get
			{
				return getMonth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMonth9090;
		public virtual int getMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getMonth9090);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getMonth9090);
		}
		public new int WeekStartDay
		{
			get
			{
				return getWeekStartDay();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWeekStartDay9091;
		public virtual int getWeekStartDay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getWeekStartDay9091);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getWeekStartDay9091);
		}
		public new int FirstDayOfMonth
		{
			get
			{
				return getFirstDayOfMonth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFirstDayOfMonth9092;
		public virtual int getFirstDayOfMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getFirstDayOfMonth9092);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getFirstDayOfMonth9092);
		}
		public new int NumberOfDaysInMonth
		{
			get
			{
				return getNumberOfDaysInMonth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNumberOfDaysInMonth9093;
		public virtual int getNumberOfDaysInMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth9093);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth9093);
		}
		internal static global::MonoJavaBridge.MethodId _getDigitsForRow9094;
		public virtual int[] getDigitsForRow(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getDigitsForRow9094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getDigitsForRow9094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getDayAt9095;
		public virtual int getDayAt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getDayAt9095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getDayAt9095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getRowOf9096;
		public virtual int getRowOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getRowOf9096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getRowOf9096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnOf9097;
		public virtual int getColumnOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getColumnOf9097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getColumnOf9097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _previousMonth9098;
		public virtual void previousMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._previousMonth9098);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._previousMonth9098);
		}
		internal static global::MonoJavaBridge.MethodId _nextMonth9099;
		public virtual void nextMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._nextMonth9099);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._nextMonth9099);
		}
		internal static global::MonoJavaBridge.MethodId _isWithinCurrentMonth9100;
		public virtual bool isWithinCurrentMonth(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._isWithinCurrentMonth9100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._isWithinCurrentMonth9100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _MonthDisplayHelper9101;
		public MonthDisplayHelper(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._MonthDisplayHelper9101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MonthDisplayHelper9102;
		public MonthDisplayHelper(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._MonthDisplayHelper9102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.MonthDisplayHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/MonthDisplayHelper"));
			global::android.util.MonthDisplayHelper._getOffset9088 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getOffset", "()I");
			global::android.util.MonthDisplayHelper._getYear9089 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getYear", "()I");
			global::android.util.MonthDisplayHelper._getMonth9090 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getMonth", "()I");
			global::android.util.MonthDisplayHelper._getWeekStartDay9091 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getWeekStartDay", "()I");
			global::android.util.MonthDisplayHelper._getFirstDayOfMonth9092 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getFirstDayOfMonth", "()I");
			global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth9093 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getNumberOfDaysInMonth", "()I");
			global::android.util.MonthDisplayHelper._getDigitsForRow9094 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getDigitsForRow", "(I)[I");
			global::android.util.MonthDisplayHelper._getDayAt9095 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getDayAt", "(II)I");
			global::android.util.MonthDisplayHelper._getRowOf9096 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getRowOf", "(I)I");
			global::android.util.MonthDisplayHelper._getColumnOf9097 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getColumnOf", "(I)I");
			global::android.util.MonthDisplayHelper._previousMonth9098 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "previousMonth", "()V");
			global::android.util.MonthDisplayHelper._nextMonth9099 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "nextMonth", "()V");
			global::android.util.MonthDisplayHelper._isWithinCurrentMonth9100 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "isWithinCurrentMonth", "(II)Z");
			global::android.util.MonthDisplayHelper._MonthDisplayHelper9101 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(III)V");
			global::android.util.MonthDisplayHelper._MonthDisplayHelper9102 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(II)V");
		}
	}
}
