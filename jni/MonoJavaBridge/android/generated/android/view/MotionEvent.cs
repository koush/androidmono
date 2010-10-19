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
		internal static global::MonoJavaBridge.MethodId _toString9463;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.MotionEvent._toString9463)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._toString9463)) as java.lang.String;
		}
		public new float Size
		{
			get
			{
				return getSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSize9464;
		public float getSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getSize9464);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getSize9464);
		}
		internal static global::MonoJavaBridge.MethodId _getSize9465;
		public float getSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getSize9465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getSize9465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getY9466;
		public float getY(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getY9466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getY9466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float Y
		{
			get
			{
				return getY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getY9467;
		public float getY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getY9467);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getY9467);
		}
		internal static global::MonoJavaBridge.MethodId _getX9468;
		public float getX(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getX9468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getX9468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float X
		{
			get
			{
				return getX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getX9469;
		public float getX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getX9469);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getX9469);
		}
		public new long EventTime
		{
			get
			{
				return getEventTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEventTime9470;
		public long getEventTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.MotionEvent._getEventTime9470);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getEventTime9470);
		}
		internal static global::MonoJavaBridge.MethodId _obtain9471;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain9471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9472;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, int arg3, float arg4, float arg5, float arg6, float arg7, int arg8, float arg9, float arg10, int arg11, int arg12) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain9472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg12))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9473;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, float arg5, float arg6, int arg7, float arg8, float arg9, int arg10, int arg11) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain9473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain9474;
		public static global::android.view.MotionEvent obtain(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain9474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _recycle9475;
		public void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._recycle9475);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._recycle9475);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel9476;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._writeToParcel9476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._writeToParcel9476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents9477;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._describeContents9477);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._describeContents9477);
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
		internal static global::MonoJavaBridge.MethodId _getAction9478;
		public int getAction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getAction9478);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getAction9478);
		}
		internal static global::MonoJavaBridge.MethodId _setAction9479;
		public void setAction(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._setAction9479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setAction9479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MetaState
		{
			get
			{
				return getMetaState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMetaState9480;
		public int getMetaState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getMetaState9480);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getMetaState9480);
		}
		public new long DownTime
		{
			get
			{
				return getDownTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDownTime9481;
		public long getDownTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.MotionEvent._getDownTime9481);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getDownTime9481);
		}
		public new int DeviceId
		{
			get
			{
				return getDeviceId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeviceId9482;
		public int getDeviceId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getDeviceId9482);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getDeviceId9482);
		}
		internal static global::MonoJavaBridge.MethodId _obtainNoHistory9483;
		public static global::android.view.MotionEvent obtainNoHistory(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtainNoHistory9483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MotionEvent;
		}
		public new int ActionMasked
		{
			get
			{
				return getActionMasked();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActionMasked9484;
		public int getActionMasked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getActionMasked9484);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getActionMasked9484);
		}
		public new int ActionIndex
		{
			get
			{
				return getActionIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActionIndex9485;
		public int getActionIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getActionIndex9485);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getActionIndex9485);
		}
		public new float Pressure
		{
			get
			{
				return getPressure();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPressure9486;
		public float getPressure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getPressure9486);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPressure9486);
		}
		internal static global::MonoJavaBridge.MethodId _getPressure9487;
		public float getPressure(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getPressure9487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPressure9487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int PointerCount
		{
			get
			{
				return getPointerCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPointerCount9488;
		public int getPointerCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getPointerCount9488);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPointerCount9488);
		}
		internal static global::MonoJavaBridge.MethodId _getPointerId9489;
		public int getPointerId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getPointerId9489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPointerId9489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findPointerIndex9490;
		public int findPointerIndex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._findPointerIndex9490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._findPointerIndex9490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float RawX
		{
			get
			{
				return getRawX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawX9491;
		public float getRawX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getRawX9491);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getRawX9491);
		}
		public new float RawY
		{
			get
			{
				return getRawY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawY9492;
		public float getRawY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getRawY9492);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getRawY9492);
		}
		public new float XPrecision
		{
			get
			{
				return getXPrecision();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getXPrecision9493;
		public float getXPrecision() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getXPrecision9493);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getXPrecision9493);
		}
		public new float YPrecision
		{
			get
			{
				return getYPrecision();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYPrecision9494;
		public float getYPrecision() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getYPrecision9494);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getYPrecision9494);
		}
		public new int HistorySize
		{
			get
			{
				return getHistorySize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHistorySize9495;
		public int getHistorySize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getHistorySize9495);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistorySize9495);
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalEventTime9496;
		public long getHistoricalEventTime(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalEventTime9496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalEventTime9496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalX9497;
		public float getHistoricalX(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalX9497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalX9497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalX9498;
		public float getHistoricalX(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalX9498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalX9498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalY9499;
		public float getHistoricalY(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalY9499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalY9499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalY9500;
		public float getHistoricalY(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalY9500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalY9500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalPressure9501;
		public float getHistoricalPressure(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalPressure9501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalPressure9501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalPressure9502;
		public float getHistoricalPressure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalPressure9502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalPressure9502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalSize9503;
		public float getHistoricalSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalSize9503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalSize9503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalSize9504;
		public float getHistoricalSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.MotionEvent._getHistoricalSize9504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalSize9504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getEdgeFlags9505;
		public int getEdgeFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.MotionEvent._getEdgeFlags9505);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getEdgeFlags9505);
		}
		internal static global::MonoJavaBridge.MethodId _setEdgeFlags9506;
		public void setEdgeFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._setEdgeFlags9506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setEdgeFlags9506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offsetLocation9507;
		public void offsetLocation(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._offsetLocation9507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._offsetLocation9507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLocation9508;
		public void setLocation(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._setLocation9508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setLocation9508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addBatch9509;
		public void addBatch(long arg0, float arg1, float arg2, float arg3, float arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MotionEvent._addBatch9509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._addBatch9509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR9510;
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
			global::android.view.MotionEvent._toString9463 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.MotionEvent._getSize9464 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getSize", "()F");
			global::android.view.MotionEvent._getSize9465 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getSize", "(I)F");
			global::android.view.MotionEvent._getY9466 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getY", "(I)F");
			global::android.view.MotionEvent._getY9467 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getY", "()F");
			global::android.view.MotionEvent._getX9468 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getX", "(I)F");
			global::android.view.MotionEvent._getX9469 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getX", "()F");
			global::android.view.MotionEvent._getEventTime9470 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getEventTime", "()J");
			global::android.view.MotionEvent._obtain9471 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFI)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._obtain9472 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(JJIIFFFFIFFII)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._obtain9473 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFFFIFFII)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._obtain9474 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._recycle9475 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "recycle", "()V");
			global::android.view.MotionEvent._writeToParcel9476 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.MotionEvent._describeContents9477 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "describeContents", "()I");
			global::android.view.MotionEvent._getAction9478 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getAction", "()I");
			global::android.view.MotionEvent._setAction9479 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "setAction", "(I)V");
			global::android.view.MotionEvent._getMetaState9480 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getMetaState", "()I");
			global::android.view.MotionEvent._getDownTime9481 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getDownTime", "()J");
			global::android.view.MotionEvent._getDeviceId9482 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getDeviceId", "()I");
			global::android.view.MotionEvent._obtainNoHistory9483 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtainNoHistory", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;");
			global::android.view.MotionEvent._getActionMasked9484 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getActionMasked", "()I");
			global::android.view.MotionEvent._getActionIndex9485 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getActionIndex", "()I");
			global::android.view.MotionEvent._getPressure9486 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPressure", "()F");
			global::android.view.MotionEvent._getPressure9487 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPressure", "(I)F");
			global::android.view.MotionEvent._getPointerCount9488 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPointerCount", "()I");
			global::android.view.MotionEvent._getPointerId9489 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPointerId", "(I)I");
			global::android.view.MotionEvent._findPointerIndex9490 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "findPointerIndex", "(I)I");
			global::android.view.MotionEvent._getRawX9491 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getRawX", "()F");
			global::android.view.MotionEvent._getRawY9492 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getRawY", "()F");
			global::android.view.MotionEvent._getXPrecision9493 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getXPrecision", "()F");
			global::android.view.MotionEvent._getYPrecision9494 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getYPrecision", "()F");
			global::android.view.MotionEvent._getHistorySize9495 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistorySize", "()I");
			global::android.view.MotionEvent._getHistoricalEventTime9496 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalEventTime", "(I)J");
			global::android.view.MotionEvent._getHistoricalX9497 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalX", "(II)F");
			global::android.view.MotionEvent._getHistoricalX9498 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalX", "(I)F");
			global::android.view.MotionEvent._getHistoricalY9499 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalY", "(I)F");
			global::android.view.MotionEvent._getHistoricalY9500 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalY", "(II)F");
			global::android.view.MotionEvent._getHistoricalPressure9501 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(I)F");
			global::android.view.MotionEvent._getHistoricalPressure9502 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(II)F");
			global::android.view.MotionEvent._getHistoricalSize9503 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(II)F");
			global::android.view.MotionEvent._getHistoricalSize9504 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(I)F");
			global::android.view.MotionEvent._getEdgeFlags9505 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getEdgeFlags", "()I");
			global::android.view.MotionEvent._setEdgeFlags9506 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "setEdgeFlags", "(I)V");
			global::android.view.MotionEvent._offsetLocation9507 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "offsetLocation", "(FF)V");
			global::android.view.MotionEvent._setLocation9508 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "setLocation", "(FF)V");
			global::android.view.MotionEvent._addBatch9509 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "addBatch", "(JFFFFI)V");
		}
	}
}
