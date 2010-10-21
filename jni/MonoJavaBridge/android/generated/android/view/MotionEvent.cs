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
		internal static global::MonoJavaBridge.MethodId _toString14310;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MotionEvent._toString14310)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._toString14310)) as java.lang.String;
		}
		public new float Size
		{
			get
			{
				return getSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSize14311;
		public float getSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getSize14311);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getSize14311);
		}
		internal static global::MonoJavaBridge.MethodId _getSize14312;
		public float getSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getSize14312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getSize14312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getY14313;
		public float getY(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getY14313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getY14313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float Y
		{
			get
			{
				return getY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getY14314;
		public float getY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getY14314);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getY14314);
		}
		internal static global::MonoJavaBridge.MethodId _getX14315;
		public float getX(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getX14315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getX14315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float X
		{
			get
			{
				return getX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getX14316;
		public float getX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getX14316);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getX14316);
		}
		public new long EventTime
		{
			get
			{
				return getEventTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEventTime14317;
		public long getEventTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.MotionEvent._getEventTime14317);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getEventTime14317);
		}
		internal static global::MonoJavaBridge.MethodId _obtain14318;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain14318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain14319;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, int arg3, float arg4, float arg5, float arg6, float arg7, int arg8, float arg9, float arg10, int arg11, int arg12) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain14319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg12))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain14320;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, float arg5, float arg6, int arg7, float arg8, float arg9, int arg10, int arg11) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain14320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain14321;
		public static global::android.view.MotionEvent obtain(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain14321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _recycle14322;
		public void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._recycle14322);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._recycle14322);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel14323;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._writeToParcel14323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._writeToParcel14323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents14324;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._describeContents14324);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._describeContents14324);
		}
		public new int Action
		{
			get
			{
				return getAction();
			}
			set
			{
				setAction(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAction14325;
		public int getAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getAction14325);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getAction14325);
		}
		internal static global::MonoJavaBridge.MethodId _setAction14326;
		public void setAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._setAction14326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setAction14326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MetaState
		{
			get
			{
				return getMetaState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMetaState14327;
		public int getMetaState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getMetaState14327);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getMetaState14327);
		}
		public new long DownTime
		{
			get
			{
				return getDownTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDownTime14328;
		public long getDownTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.MotionEvent._getDownTime14328);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getDownTime14328);
		}
		public new int DeviceId
		{
			get
			{
				return getDeviceId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeviceId14329;
		public int getDeviceId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getDeviceId14329);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getDeviceId14329);
		}
		internal static global::MonoJavaBridge.MethodId _obtainNoHistory14330;
		public static global::android.view.MotionEvent obtainNoHistory(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtainNoHistory14330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MotionEvent;
		}
		public new int ActionMasked
		{
			get
			{
				return getActionMasked();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActionMasked14331;
		public int getActionMasked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getActionMasked14331);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getActionMasked14331);
		}
		public new int ActionIndex
		{
			get
			{
				return getActionIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActionIndex14332;
		public int getActionIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getActionIndex14332);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getActionIndex14332);
		}
		public new float Pressure
		{
			get
			{
				return getPressure();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPressure14333;
		public float getPressure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getPressure14333);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPressure14333);
		}
		internal static global::MonoJavaBridge.MethodId _getPressure14334;
		public float getPressure(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getPressure14334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPressure14334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int PointerCount
		{
			get
			{
				return getPointerCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPointerCount14335;
		public int getPointerCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getPointerCount14335);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPointerCount14335);
		}
		internal static global::MonoJavaBridge.MethodId _getPointerId14336;
		public int getPointerId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getPointerId14336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPointerId14336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findPointerIndex14337;
		public int findPointerIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._findPointerIndex14337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._findPointerIndex14337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float RawX
		{
			get
			{
				return getRawX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawX14338;
		public float getRawX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getRawX14338);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getRawX14338);
		}
		public new float RawY
		{
			get
			{
				return getRawY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawY14339;
		public float getRawY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getRawY14339);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getRawY14339);
		}
		public new float XPrecision
		{
			get
			{
				return getXPrecision();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getXPrecision14340;
		public float getXPrecision() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getXPrecision14340);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getXPrecision14340);
		}
		public new float YPrecision
		{
			get
			{
				return getYPrecision();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYPrecision14341;
		public float getYPrecision() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getYPrecision14341);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getYPrecision14341);
		}
		public new int HistorySize
		{
			get
			{
				return getHistorySize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHistorySize14342;
		public int getHistorySize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getHistorySize14342);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistorySize14342);
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalEventTime14343;
		public long getHistoricalEventTime(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalEventTime14343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalEventTime14343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalX14344;
		public float getHistoricalX(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalX14344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalX14344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalX14345;
		public float getHistoricalX(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalX14345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalX14345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalY14346;
		public float getHistoricalY(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalY14346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalY14346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalY14347;
		public float getHistoricalY(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalY14347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalY14347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalPressure14348;
		public float getHistoricalPressure(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalPressure14348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalPressure14348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalPressure14349;
		public float getHistoricalPressure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalPressure14349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalPressure14349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalSize14350;
		public float getHistoricalSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalSize14350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalSize14350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalSize14351;
		public float getHistoricalSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalSize14351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalSize14351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int EdgeFlags
		{
			get
			{
				return getEdgeFlags();
			}
			set
			{
				setEdgeFlags(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEdgeFlags14352;
		public int getEdgeFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getEdgeFlags14352);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getEdgeFlags14352);
		}
		internal static global::MonoJavaBridge.MethodId _setEdgeFlags14353;
		public void setEdgeFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._setEdgeFlags14353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setEdgeFlags14353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offsetLocation14354;
		public void offsetLocation(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._offsetLocation14354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._offsetLocation14354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLocation14355;
		public void setLocation(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._setLocation14355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setLocation14355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addBatch14356;
		public void addBatch(long arg0, float arg1, float arg2, float arg3, float arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._addBatch14356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._addBatch14356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR14379;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.MotionEvent.staticClass, _CREATOR14379)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.MotionEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/MotionEvent"));
			global::android.view.MotionEvent._toString14310 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.MotionEvent._getSize14311 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getSize", "()F");
			global::android.view.MotionEvent._getSize14312 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getSize", "(I)F");
			global::android.view.MotionEvent._getY14313 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getY", "(I)F");
			global::android.view.MotionEvent._getY14314 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getY", "()F");
			global::android.view.MotionEvent._getX14315 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getX", "(I)F");
			global::android.view.MotionEvent._getX14316 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getX", "()F");
			global::android.view.MotionEvent._getEventTime14317 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getEventTime", "()J");
			global::android.view.MotionEvent._obtain14318 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFI)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._obtain14319 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(JJIIFFFFIFFII)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._obtain14320 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFFFIFFII)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._obtain14321 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._recycle14322 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "recycle", "()V");
			global::android.view.MotionEvent._writeToParcel14323 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.MotionEvent._describeContents14324 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "describeContents", "()I");
			global::android.view.MotionEvent._getAction14325 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getAction", "()I");
			global::android.view.MotionEvent._setAction14326 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "setAction", "(I)V");
			global::android.view.MotionEvent._getMetaState14327 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getMetaState", "()I");
			global::android.view.MotionEvent._getDownTime14328 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getDownTime", "()J");
			global::android.view.MotionEvent._getDeviceId14329 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getDeviceId", "()I");
			global::android.view.MotionEvent._obtainNoHistory14330 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtainNoHistory", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._getActionMasked14331 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getActionMasked", "()I");
			global::android.view.MotionEvent._getActionIndex14332 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getActionIndex", "()I");
			global::android.view.MotionEvent._getPressure14333 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPressure", "()F");
			global::android.view.MotionEvent._getPressure14334 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPressure", "(I)F");
			global::android.view.MotionEvent._getPointerCount14335 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPointerCount", "()I");
			global::android.view.MotionEvent._getPointerId14336 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPointerId", "(I)I");
			global::android.view.MotionEvent._findPointerIndex14337 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "findPointerIndex", "(I)I");
			global::android.view.MotionEvent._getRawX14338 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getRawX", "()F");
			global::android.view.MotionEvent._getRawY14339 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getRawY", "()F");
			global::android.view.MotionEvent._getXPrecision14340 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getXPrecision", "()F");
			global::android.view.MotionEvent._getYPrecision14341 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getYPrecision", "()F");
			global::android.view.MotionEvent._getHistorySize14342 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistorySize", "()I");
			global::android.view.MotionEvent._getHistoricalEventTime14343 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalEventTime", "(I)J");
			global::android.view.MotionEvent._getHistoricalX14344 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalX", "(II)F");
			global::android.view.MotionEvent._getHistoricalX14345 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalX", "(I)F");
			global::android.view.MotionEvent._getHistoricalY14346 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalY", "(I)F");
			global::android.view.MotionEvent._getHistoricalY14347 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalY", "(II)F");
			global::android.view.MotionEvent._getHistoricalPressure14348 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(I)F");
			global::android.view.MotionEvent._getHistoricalPressure14349 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(II)F");
			global::android.view.MotionEvent._getHistoricalSize14350 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(II)F");
			global::android.view.MotionEvent._getHistoricalSize14351 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(I)F");
			global::android.view.MotionEvent._getEdgeFlags14352 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getEdgeFlags", "()I");
			global::android.view.MotionEvent._setEdgeFlags14353 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "setEdgeFlags", "(I)V");
			global::android.view.MotionEvent._offsetLocation14354 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "offsetLocation", "(FF)V");
			global::android.view.MotionEvent._setLocation14355 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "setLocation", "(FF)V");
			global::android.view.MotionEvent._addBatch14356 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "addBatch", "(JFFFFI)V");
			global::android.view.MotionEvent._CREATOR14379 = @__env.GetStaticFieldIDNoThrow(global::android.view.MotionEvent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
