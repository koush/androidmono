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
		internal static global::net.sf.jni4net.jni.MethodId _getOffset8238;
		public virtual int getOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getOffset8238);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getOffset8238);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getYear8239;
		public virtual int getYear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getYear8239);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getYear8239);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMonth8240;
		public virtual int getMonth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getMonth8240);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getMonth8240);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWeekStartDay8241;
		public virtual int getWeekStartDay() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getWeekStartDay8241);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getWeekStartDay8241);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFirstDayOfMonth8242;
		public virtual int getFirstDayOfMonth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getFirstDayOfMonth8242);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getFirstDayOfMonth8242);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNumberOfDaysInMonth8243;
		public virtual int getNumberOfDaysInMonth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth8243);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth8243);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDigitsForRow8244;
		public virtual int[] getDigitsForRow(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.util.MonthDisplayHelper._getDigitsForRow8244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getDigitsForRow8244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDayAt8245;
		public virtual int getDayAt(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getDayAt8245, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getDayAt8245, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRowOf8246;
		public virtual int getRowOf(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getRowOf8246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getRowOf8246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnOf8247;
		public virtual int getColumnOf(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.util.MonthDisplayHelper._getColumnOf8247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._getColumnOf8247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _previousMonth8248;
		public virtual void previousMonth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.MonthDisplayHelper._previousMonth8248);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._previousMonth8248);
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextMonth8249;
		public virtual void nextMonth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.util.MonthDisplayHelper._nextMonth8249);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._nextMonth8249);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isWithinCurrentMonth8250;
		public virtual bool isWithinCurrentMonth(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.util.MonthDisplayHelper._isWithinCurrentMonth8250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._isWithinCurrentMonth8250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _MonthDisplayHelper8251;
		public MonthDisplayHelper(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._MonthDisplayHelper8251, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _MonthDisplayHelper8252;
		public MonthDisplayHelper(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.MonthDisplayHelper.staticClass, global::android.util.MonthDisplayHelper._MonthDisplayHelper8252, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.MonthDisplayHelper.staticClass = @__class;
			global::android.util.MonthDisplayHelper._getOffset8238 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getOffset", "()I");
			global::android.util.MonthDisplayHelper._getYear8239 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getYear", "()I");
			global::android.util.MonthDisplayHelper._getMonth8240 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getMonth", "()I");
			global::android.util.MonthDisplayHelper._getWeekStartDay8241 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getWeekStartDay", "()I");
			global::android.util.MonthDisplayHelper._getFirstDayOfMonth8242 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getFirstDayOfMonth", "()I");
			global::android.util.MonthDisplayHelper._getNumberOfDaysInMonth8243 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getNumberOfDaysInMonth", "()I");
			global::android.util.MonthDisplayHelper._getDigitsForRow8244 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getDigitsForRow", "(I)[I");
			global::android.util.MonthDisplayHelper._getDayAt8245 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getDayAt", "(II)I");
			global::android.util.MonthDisplayHelper._getRowOf8246 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getRowOf", "(I)I");
			global::android.util.MonthDisplayHelper._getColumnOf8247 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "getColumnOf", "(I)I");
			global::android.util.MonthDisplayHelper._previousMonth8248 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "previousMonth", "()V");
			global::android.util.MonthDisplayHelper._nextMonth8249 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "nextMonth", "()V");
			global::android.util.MonthDisplayHelper._isWithinCurrentMonth8250 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "isWithinCurrentMonth", "(II)Z");
			global::android.util.MonthDisplayHelper._MonthDisplayHelper8251 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(III)V");
			global::android.util.MonthDisplayHelper._MonthDisplayHelper8252 = @__env.GetMethodID(global::android.util.MonthDisplayHelper.staticClass, "<init>", "(II)V");
		}
	}
}
