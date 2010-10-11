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
		internal static global::MonoJavaBridge.MethodId _getOffset8542;
		public virtual int getOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getOffset8542);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getOffset8542);
		}
		internal static global::MonoJavaBridge.MethodId _getYear8543;
		public virtual int getYear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getYear8543);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getYear8543);
		}
		internal static global::MonoJavaBridge.MethodId _getMonth8544;
		public virtual int getMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getMonth8544);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getMonth8544);
		}
		internal static global::MonoJavaBridge.MethodId _getWeekStartDay8545;
		public virtual int getWeekStartDay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getWeekStartDay8545);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getWeekStartDay8545);
		}
		internal static global::MonoJavaBridge.MethodId _getFirstDayOfMonth8546;
		public virtual int getFirstDayOfMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getFirstDayOfMonth8546);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getFirstDayOfMonth8546);
		}
		internal static global::MonoJavaBridge.MethodId _getNumberOfDaysInMonth8547;
		public virtual int getNumberOfDaysInMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth8547);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth8547);
		}
		internal static global::MonoJavaBridge.MethodId _getDigitsForRow8548;
		public virtual int[] getDigitsForRow(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getDigitsForRow8548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getDigitsForRow8548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getDayAt8549;
		public virtual int getDayAt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getDayAt8549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getDayAt8549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getRowOf8550;
		public virtual int getRowOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getRowOf8550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getRowOf8550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnOf8551;
		public virtual int getColumnOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._getColumnOf8551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getColumnOf8551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _previousMonth8552;
		public virtual void previousMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._previousMonth8552);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._previousMonth8552);
		}
		internal static global::MonoJavaBridge.MethodId _nextMonth8553;
		public virtual void nextMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._nextMonth8553);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._nextMonth8553);
		}
		internal static global::MonoJavaBridge.MethodId _isWithinCurrentMonth8554;
		public virtual bool isWithinCurrentMonth(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.util.MonthDisplayHelper._isWithinCurrentMonth8554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._isWithinCurrentMonth8554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _MonthDisplayHelper8555;
		public MonthDisplayHelper(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._MonthDisplayHelper8555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MonthDisplayHelper8556;
		public MonthDisplayHelper(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._MonthDisplayHelper8556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.MonthDisplayHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/MonthDisplayHelper"));
			global::android.util.MonthDisplayHelper._getOffset8542 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getOffset", "()I");
			global::android.util.MonthDisplayHelper._getYear8543 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getYear", "()I");
			global::android.util.MonthDisplayHelper._getMonth8544 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getMonth", "()I");
			global::android.util.MonthDisplayHelper._getWeekStartDay8545 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getWeekStartDay", "()I");
			global::android.util.MonthDisplayHelper._getFirstDayOfMonth8546 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getFirstDayOfMonth", "()I");
			global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth8547 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getNumberOfDaysInMonth", "()I");
			global::android.util.MonthDisplayHelper._getDigitsForRow8548 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getDigitsForRow", "(I)[I");
			global::android.util.MonthDisplayHelper._getDayAt8549 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getDayAt", "(II)I");
			global::android.util.MonthDisplayHelper._getRowOf8550 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getRowOf", "(I)I");
			global::android.util.MonthDisplayHelper._getColumnOf8551 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "getColumnOf", "(I)I");
			global::android.util.MonthDisplayHelper._previousMonth8552 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "previousMonth", "()V");
			global::android.util.MonthDisplayHelper._nextMonth8553 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "nextMonth", "()V");
			global::android.util.MonthDisplayHelper._isWithinCurrentMonth8554 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "isWithinCurrentMonth", "(II)Z");
			global::android.util.MonthDisplayHelper._MonthDisplayHelper8555 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(III)V");
			global::android.util.MonthDisplayHelper._MonthDisplayHelper8556 = @__env.GetMethodIDNoThrow(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(II)V");
		}
	}
}
