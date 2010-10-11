namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class MotionEvent : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MotionEvent()
		{
			InitJNI();
		}
		internal MotionEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString8917;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MotionEvent._toString8917)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._toString8917)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSize8918;
		public float getSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getSize8918);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getSize8918);
		}
		internal static global::MonoJavaBridge.MethodId _getSize8919;
		public float getSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getSize8919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getSize8919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getY8920;
		public float getY(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getY8920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getY8920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getY8921;
		public float getY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getY8921);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getY8921);
		}
		internal static global::MonoJavaBridge.MethodId _getX8922;
		public float getX(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getX8922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getX8922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getX8923;
		public float getX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getX8923);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getX8923);
		}
		internal static global::MonoJavaBridge.MethodId _getEventTime8924;
		public long getEventTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.MotionEvent._getEventTime8924);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getEventTime8924);
		}
		internal static global::MonoJavaBridge.MethodId _obtain8925;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain8925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain8926;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, int arg3, float arg4, float arg5, float arg6, float arg7, int arg8, float arg9, float arg10, int arg11, int arg12) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain8926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg12))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain8927;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, float arg5, float arg6, int arg7, float arg8, float arg9, int arg10, int arg11) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain8927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain8928;
		public static global::android.view.MotionEvent obtain(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain8928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _recycle8929;
		public void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._recycle8929);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._recycle8929);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8930;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._writeToParcel8930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._writeToParcel8930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8931;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._describeContents8931);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._describeContents8931);
		}
		internal static global::MonoJavaBridge.MethodId _getAction8932;
		public int getAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getAction8932);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getAction8932);
		}
		internal static global::MonoJavaBridge.MethodId _setAction8933;
		public void setAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._setAction8933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setAction8933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMetaState8934;
		public int getMetaState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getMetaState8934);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getMetaState8934);
		}
		internal static global::MonoJavaBridge.MethodId _getDownTime8935;
		public long getDownTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.MotionEvent._getDownTime8935);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getDownTime8935);
		}
		internal static global::MonoJavaBridge.MethodId _getDeviceId8936;
		public int getDeviceId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getDeviceId8936);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getDeviceId8936);
		}
		internal static global::MonoJavaBridge.MethodId _obtainNoHistory8937;
		public static global::android.view.MotionEvent obtainNoHistory(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtainNoHistory8937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _getActionMasked8938;
		public int getActionMasked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getActionMasked8938);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getActionMasked8938);
		}
		internal static global::MonoJavaBridge.MethodId _getActionIndex8939;
		public int getActionIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getActionIndex8939);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getActionIndex8939);
		}
		internal static global::MonoJavaBridge.MethodId _getPressure8940;
		public float getPressure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getPressure8940);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPressure8940);
		}
		internal static global::MonoJavaBridge.MethodId _getPressure8941;
		public float getPressure(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getPressure8941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPressure8941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPointerCount8942;
		public int getPointerCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getPointerCount8942);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPointerCount8942);
		}
		internal static global::MonoJavaBridge.MethodId _getPointerId8943;
		public int getPointerId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getPointerId8943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPointerId8943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findPointerIndex8944;
		public int findPointerIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._findPointerIndex8944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._findPointerIndex8944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRawX8945;
		public float getRawX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getRawX8945);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getRawX8945);
		}
		internal static global::MonoJavaBridge.MethodId _getRawY8946;
		public float getRawY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getRawY8946);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getRawY8946);
		}
		internal static global::MonoJavaBridge.MethodId _getXPrecision8947;
		public float getXPrecision() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getXPrecision8947);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getXPrecision8947);
		}
		internal static global::MonoJavaBridge.MethodId _getYPrecision8948;
		public float getYPrecision() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getYPrecision8948);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getYPrecision8948);
		}
		internal static global::MonoJavaBridge.MethodId _getHistorySize8949;
		public int getHistorySize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getHistorySize8949);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistorySize8949);
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalEventTime8950;
		public long getHistoricalEventTime(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalEventTime8950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalEventTime8950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalX8951;
		public float getHistoricalX(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalX8951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalX8951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalX8952;
		public float getHistoricalX(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalX8952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalX8952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalY8953;
		public float getHistoricalY(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalY8953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalY8953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalY8954;
		public float getHistoricalY(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalY8954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalY8954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalPressure8955;
		public float getHistoricalPressure(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalPressure8955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalPressure8955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalPressure8956;
		public float getHistoricalPressure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalPressure8956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalPressure8956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalSize8957;
		public float getHistoricalSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalSize8957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalSize8957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalSize8958;
		public float getHistoricalSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalSize8958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalSize8958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEdgeFlags8959;
		public int getEdgeFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getEdgeFlags8959);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getEdgeFlags8959);
		}
		internal static global::MonoJavaBridge.MethodId _setEdgeFlags8960;
		public void setEdgeFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._setEdgeFlags8960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setEdgeFlags8960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offsetLocation8961;
		public void offsetLocation(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._offsetLocation8961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._offsetLocation8961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLocation8962;
		public void setLocation(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._setLocation8962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setLocation8962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addBatch8963;
		public void addBatch(long arg0, float arg1, float arg2, float arg3, float arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._addBatch8963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._addBatch8963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR8964;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.MotionEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/MotionEvent"));
			global::android.view.MotionEvent._toString8917 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.MotionEvent._getSize8918 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getSize", "()F");
			global::android.view.MotionEvent._getSize8919 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getSize", "(I)F");
			global::android.view.MotionEvent._getY8920 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getY", "(I)F");
			global::android.view.MotionEvent._getY8921 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getY", "()F");
			global::android.view.MotionEvent._getX8922 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getX", "(I)F");
			global::android.view.MotionEvent._getX8923 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getX", "()F");
			global::android.view.MotionEvent._getEventTime8924 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getEventTime", "()J");
			global::android.view.MotionEvent._obtain8925 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFI)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._obtain8926 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(JJIIFFFFIFFII)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._obtain8927 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFFFIFFII)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._obtain8928 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._recycle8929 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "recycle", "()V");
			global::android.view.MotionEvent._writeToParcel8930 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.MotionEvent._describeContents8931 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "describeContents", "()I");
			global::android.view.MotionEvent._getAction8932 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getAction", "()I");
			global::android.view.MotionEvent._setAction8933 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "setAction", "(I)V");
			global::android.view.MotionEvent._getMetaState8934 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getMetaState", "()I");
			global::android.view.MotionEvent._getDownTime8935 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getDownTime", "()J");
			global::android.view.MotionEvent._getDeviceId8936 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getDeviceId", "()I");
			global::android.view.MotionEvent._obtainNoHistory8937 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtainNoHistory", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._getActionMasked8938 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getActionMasked", "()I");
			global::android.view.MotionEvent._getActionIndex8939 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getActionIndex", "()I");
			global::android.view.MotionEvent._getPressure8940 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPressure", "()F");
			global::android.view.MotionEvent._getPressure8941 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPressure", "(I)F");
			global::android.view.MotionEvent._getPointerCount8942 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPointerCount", "()I");
			global::android.view.MotionEvent._getPointerId8943 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPointerId", "(I)I");
			global::android.view.MotionEvent._findPointerIndex8944 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "findPointerIndex", "(I)I");
			global::android.view.MotionEvent._getRawX8945 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getRawX", "()F");
			global::android.view.MotionEvent._getRawY8946 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getRawY", "()F");
			global::android.view.MotionEvent._getXPrecision8947 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getXPrecision", "()F");
			global::android.view.MotionEvent._getYPrecision8948 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getYPrecision", "()F");
			global::android.view.MotionEvent._getHistorySize8949 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistorySize", "()I");
			global::android.view.MotionEvent._getHistoricalEventTime8950 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalEventTime", "(I)J");
			global::android.view.MotionEvent._getHistoricalX8951 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalX", "(II)F");
			global::android.view.MotionEvent._getHistoricalX8952 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalX", "(I)F");
			global::android.view.MotionEvent._getHistoricalY8953 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalY", "(I)F");
			global::android.view.MotionEvent._getHistoricalY8954 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalY", "(II)F");
			global::android.view.MotionEvent._getHistoricalPressure8955 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(I)F");
			global::android.view.MotionEvent._getHistoricalPressure8956 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(II)F");
			global::android.view.MotionEvent._getHistoricalSize8957 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(II)F");
			global::android.view.MotionEvent._getHistoricalSize8958 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(I)F");
			global::android.view.MotionEvent._getEdgeFlags8959 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getEdgeFlags", "()I");
			global::android.view.MotionEvent._setEdgeFlags8960 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "setEdgeFlags", "(I)V");
			global::android.view.MotionEvent._offsetLocation8961 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "offsetLocation", "(FF)V");
			global::android.view.MotionEvent._setLocation8962 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "setLocation", "(FF)V");
			global::android.view.MotionEvent._addBatch8963 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "addBatch", "(JFFFFI)V");
		}
	}
}
