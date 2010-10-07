namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class MotionEvent : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static MotionEvent()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.MotionEvent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.MotionEvent(@__env);
			}
		}
		internal MotionEvent(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString8611;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.MotionEvent._toString8611));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._toString8611));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSize8612;
		public float getSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getSize8612);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getSize8612);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSize8613;
		public float getSize(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getSize8613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getSize8613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getY8614;
		public float getY(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getY8614, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getY8614, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getY8615;
		public float getY() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getY8615);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getY8615);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getX8616;
		public float getX(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getX8616, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getX8616, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getX8617;
		public float getX() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getX8617);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getX8617);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEventTime8618;
		public long getEventTime() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.MotionEvent._getEventTime8618);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getEventTime8618);
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain8619;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MotionEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain8619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain8620;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, int arg3, float arg4, float arg5, float arg6, float arg7, int arg8, float arg9, float arg10, int arg11, int arg12) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MotionEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain8620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg11), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg12)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain8621;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, float arg5, float arg6, int arg7, float arg8, float arg9, int arg10, int arg11) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MotionEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain8621, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg11)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain8622;
		public static global::android.view.MotionEvent obtain(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MotionEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain8622, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _recycle8623;
		public void recycle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.MotionEvent._recycle8623);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._recycle8623);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8624;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.MotionEvent._writeToParcel8624, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._writeToParcel8624, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8625;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._describeContents8625);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._describeContents8625);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAction8626;
		public int getAction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getAction8626);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getAction8626);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAction8627;
		public void setAction(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.MotionEvent._setAction8627, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setAction8627, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMetaState8628;
		public int getMetaState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getMetaState8628);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getMetaState8628);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDownTime8629;
		public long getDownTime() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.MotionEvent._getDownTime8629);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getDownTime8629);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDeviceId8630;
		public int getDeviceId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getDeviceId8630);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getDeviceId8630);
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtainNoHistory8631;
		public static global::android.view.MotionEvent obtainNoHistory(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.MotionEvent>(@__env, @__env.CallStaticObjectMethodPtr(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtainNoHistory8631, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getActionMasked8632;
		public int getActionMasked() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getActionMasked8632);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getActionMasked8632);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getActionIndex8633;
		public int getActionIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getActionIndex8633);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getActionIndex8633);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPressure8634;
		public float getPressure() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getPressure8634);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPressure8634);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPressure8635;
		public float getPressure(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getPressure8635, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPressure8635, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPointerCount8636;
		public int getPointerCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getPointerCount8636);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPointerCount8636);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPointerId8637;
		public int getPointerId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getPointerId8637, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPointerId8637, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findPointerIndex8638;
		public int findPointerIndex(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._findPointerIndex8638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._findPointerIndex8638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRawX8639;
		public float getRawX() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getRawX8639);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getRawX8639);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRawY8640;
		public float getRawY() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getRawY8640);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getRawY8640);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getXPrecision8641;
		public float getXPrecision() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getXPrecision8641);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getXPrecision8641);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getYPrecision8642;
		public float getYPrecision() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getYPrecision8642);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getYPrecision8642);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHistorySize8643;
		public int getHistorySize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getHistorySize8643);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistorySize8643);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalEventTime8644;
		public long getHistoricalEventTime(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.MotionEvent._getHistoricalEventTime8644, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalEventTime8644, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalX8645;
		public float getHistoricalX(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalX8645, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalX8645, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalX8646;
		public float getHistoricalX(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalX8646, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalX8646, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalY8647;
		public float getHistoricalY(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalY8647, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalY8647, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalY8648;
		public float getHistoricalY(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalY8648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalY8648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalPressure8649;
		public float getHistoricalPressure(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalPressure8649, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalPressure8649, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalPressure8650;
		public float getHistoricalPressure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalPressure8650, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalPressure8650, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalSize8651;
		public float getHistoricalSize(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalSize8651, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalSize8651, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHistoricalSize8652;
		public float getHistoricalSize(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.MotionEvent._getHistoricalSize8652, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalSize8652, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEdgeFlags8653;
		public int getEdgeFlags() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.MotionEvent._getEdgeFlags8653);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getEdgeFlags8653);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEdgeFlags8654;
		public void setEdgeFlags(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.MotionEvent._setEdgeFlags8654, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setEdgeFlags8654, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _offsetLocation8655;
		public void offsetLocation(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.MotionEvent._offsetLocation8655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._offsetLocation8655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLocation8656;
		public void setLocation(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.MotionEvent._setLocation8656, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setLocation8656, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addBatch8657;
		public void addBatch(long arg0, float arg1, float arg2, float arg3, float arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.MotionEvent._addBatch8657, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._addBatch8657, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		public static int ACTION_MASK
		{
			get
			{
				return 255;
			}
		}
		public static int ACTION_DOWN
		{
			get
			{
				return 0;
			}
		}
		public static int ACTION_UP
		{
			get
			{
				return 1;
			}
		}
		public static int ACTION_MOVE
		{
			get
			{
				return 2;
			}
		}
		public static int ACTION_CANCEL
		{
			get
			{
				return 3;
			}
		}
		public static int ACTION_OUTSIDE
		{
			get
			{
				return 4;
			}
		}
		public static int ACTION_POINTER_DOWN
		{
			get
			{
				return 5;
			}
		}
		public static int ACTION_POINTER_UP
		{
			get
			{
				return 6;
			}
		}
		public static int ACTION_POINTER_INDEX_MASK
		{
			get
			{
				return 65280;
			}
		}
		public static int ACTION_POINTER_INDEX_SHIFT
		{
			get
			{
				return 8;
			}
		}
		public static int ACTION_POINTER_1_DOWN
		{
			get
			{
				return 5;
			}
		}
		public static int ACTION_POINTER_2_DOWN
		{
			get
			{
				return 261;
			}
		}
		public static int ACTION_POINTER_3_DOWN
		{
			get
			{
				return 517;
			}
		}
		public static int ACTION_POINTER_1_UP
		{
			get
			{
				return 6;
			}
		}
		public static int ACTION_POINTER_2_UP
		{
			get
			{
				return 262;
			}
		}
		public static int ACTION_POINTER_3_UP
		{
			get
			{
				return 518;
			}
		}
		public static int ACTION_POINTER_ID_MASK
		{
			get
			{
				return 65280;
			}
		}
		public static int ACTION_POINTER_ID_SHIFT
		{
			get
			{
				return 8;
			}
		}
		public static int EDGE_TOP
		{
			get
			{
				return 1;
			}
		}
		public static int EDGE_BOTTOM
		{
			get
			{
				return 2;
			}
		}
		public static int EDGE_LEFT
		{
			get
			{
				return 4;
			}
		}
		public static int EDGE_RIGHT
		{
			get
			{
				return 8;
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR8658;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.MotionEvent.staticClass = @__class;
			global::android.view.MotionEvent._toString8611 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.MotionEvent._getSize8612 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getSize", "()F");
			global::android.view.MotionEvent._getSize8613 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getSize", "(I)F");
			global::android.view.MotionEvent._getY8614 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getY", "(I)F");
			global::android.view.MotionEvent._getY8615 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getY", "()F");
			global::android.view.MotionEvent._getX8616 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getX", "(I)F");
			global::android.view.MotionEvent._getX8617 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getX", "()F");
			global::android.view.MotionEvent._getEventTime8618 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getEventTime", "()J");
			global::android.view.MotionEvent._obtain8619 = @__env.GetStaticMethodID(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFI)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._obtain8620 = @__env.GetStaticMethodID(global::android.view.MotionEvent.staticClass, "obtain", "(JJIIFFFFIFFII)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._obtain8621 = @__env.GetStaticMethodID(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFFFIFFII)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._obtain8622 = @__env.GetStaticMethodID(global::android.view.MotionEvent.staticClass, "obtain", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._recycle8623 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "recycle", "()V");
			global::android.view.MotionEvent._writeToParcel8624 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.MotionEvent._describeContents8625 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "describeContents", "()I");
			global::android.view.MotionEvent._getAction8626 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getAction", "()I");
			global::android.view.MotionEvent._setAction8627 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "setAction", "(I)V");
			global::android.view.MotionEvent._getMetaState8628 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getMetaState", "()I");
			global::android.view.MotionEvent._getDownTime8629 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getDownTime", "()J");
			global::android.view.MotionEvent._getDeviceId8630 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getDeviceId", "()I");
			global::android.view.MotionEvent._obtainNoHistory8631 = @__env.GetStaticMethodID(global::android.view.MotionEvent.staticClass, "obtainNoHistory", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._getActionMasked8632 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getActionMasked", "()I");
			global::android.view.MotionEvent._getActionIndex8633 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getActionIndex", "()I");
			global::android.view.MotionEvent._getPressure8634 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getPressure", "()F");
			global::android.view.MotionEvent._getPressure8635 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getPressure", "(I)F");
			global::android.view.MotionEvent._getPointerCount8636 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getPointerCount", "()I");
			global::android.view.MotionEvent._getPointerId8637 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getPointerId", "(I)I");
			global::android.view.MotionEvent._findPointerIndex8638 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "findPointerIndex", "(I)I");
			global::android.view.MotionEvent._getRawX8639 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getRawX", "()F");
			global::android.view.MotionEvent._getRawY8640 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getRawY", "()F");
			global::android.view.MotionEvent._getXPrecision8641 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getXPrecision", "()F");
			global::android.view.MotionEvent._getYPrecision8642 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getYPrecision", "()F");
			global::android.view.MotionEvent._getHistorySize8643 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistorySize", "()I");
			global::android.view.MotionEvent._getHistoricalEventTime8644 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalEventTime", "(I)J");
			global::android.view.MotionEvent._getHistoricalX8645 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalX", "(II)F");
			global::android.view.MotionEvent._getHistoricalX8646 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalX", "(I)F");
			global::android.view.MotionEvent._getHistoricalY8647 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalY", "(I)F");
			global::android.view.MotionEvent._getHistoricalY8648 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalY", "(II)F");
			global::android.view.MotionEvent._getHistoricalPressure8649 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(I)F");
			global::android.view.MotionEvent._getHistoricalPressure8650 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(II)F");
			global::android.view.MotionEvent._getHistoricalSize8651 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(II)F");
			global::android.view.MotionEvent._getHistoricalSize8652 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(I)F");
			global::android.view.MotionEvent._getEdgeFlags8653 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "getEdgeFlags", "()I");
			global::android.view.MotionEvent._setEdgeFlags8654 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "setEdgeFlags", "(I)V");
			global::android.view.MotionEvent._offsetLocation8655 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "offsetLocation", "(FF)V");
			global::android.view.MotionEvent._setLocation8656 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "setLocation", "(FF)V");
			global::android.view.MotionEvent._addBatch8657 = @__env.GetMethodID(global::android.view.MotionEvent.staticClass, "addBatch", "(JFFFFI)V");
		}
	}
}
