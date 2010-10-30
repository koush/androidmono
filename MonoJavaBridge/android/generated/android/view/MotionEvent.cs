namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class MotionEvent : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MotionEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString14378;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._toString14378.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._toString14378 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._toString14378)) as java.lang.String;
		}
		public new float Size
		{
			get
			{
				return getSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSize14379;
		public float getSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getSize14379.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getSize14379 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getSize", "()F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getSize14379);
		}
		internal static global::MonoJavaBridge.MethodId _getSize14380;
		public float getSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getSize14380.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getSize14380 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getSize", "(I)F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getSize14380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getY14381;
		public float getY(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getY14381.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getY14381 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getY", "(I)F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getY14381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float Y
		{
			get
			{
				return getY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getY14382;
		public float getY()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getY14382.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getY14382 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getY", "()F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getY14382);
		}
		internal static global::MonoJavaBridge.MethodId _getX14383;
		public float getX(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getX14383.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getX14383 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getX", "(I)F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getX14383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float X
		{
			get
			{
				return getX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getX14384;
		public float getX()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getX14384.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getX14384 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getX", "()F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getX14384);
		}
		public new long EventTime
		{
			get
			{
				return getEventTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEventTime14385;
		public long getEventTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getEventTime14385.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getEventTime14385 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getEventTime", "()J");
			return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getEventTime14385);
		}
		internal static global::MonoJavaBridge.MethodId _obtain14386;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._obtain14386.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._obtain14386 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFI)Landroid/view/MotionEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.MotionEvent>(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain14386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain14387;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, int arg3, float arg4, float arg5, float arg6, float arg7, int arg8, float arg9, float arg10, int arg11, int arg12)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._obtain14387.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._obtain14387 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(JJIIFFFFIFFII)Landroid/view/MotionEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.MotionEvent>(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain14387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg12))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain14388;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, float arg5, float arg6, int arg7, float arg8, float arg9, int arg10, int arg11)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._obtain14388.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._obtain14388 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFFFIFFII)Landroid/view/MotionEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.MotionEvent>(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain14388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _obtain14389;
		public static global::android.view.MotionEvent obtain(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._obtain14389.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._obtain14389 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.MotionEvent>(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtain14389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MotionEvent;
		}
		internal static global::MonoJavaBridge.MethodId _recycle14390;
		public void recycle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._recycle14390.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._recycle14390 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "recycle", "()V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._recycle14390);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel14391;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._writeToParcel14391.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._writeToParcel14391 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._writeToParcel14391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents14392;
		public int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._describeContents14392.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._describeContents14392 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "describeContents", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._describeContents14392);
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
		internal static global::MonoJavaBridge.MethodId _getAction14393;
		public int getAction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getAction14393.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getAction14393 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getAction", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getAction14393);
		}
		internal static global::MonoJavaBridge.MethodId _setAction14394;
		public void setAction(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._setAction14394.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._setAction14394 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "setAction", "(I)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setAction14394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MetaState
		{
			get
			{
				return getMetaState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMetaState14395;
		public int getMetaState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getMetaState14395.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getMetaState14395 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getMetaState", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getMetaState14395);
		}
		public new long DownTime
		{
			get
			{
				return getDownTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDownTime14396;
		public long getDownTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getDownTime14396.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getDownTime14396 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getDownTime", "()J");
			return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getDownTime14396);
		}
		public new int DeviceId
		{
			get
			{
				return getDeviceId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeviceId14397;
		public int getDeviceId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getDeviceId14397.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getDeviceId14397 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getDeviceId", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getDeviceId14397);
		}
		internal static global::MonoJavaBridge.MethodId _obtainNoHistory14398;
		public static global::android.view.MotionEvent obtainNoHistory(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._obtainNoHistory14398.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._obtainNoHistory14398 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtainNoHistory", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.MotionEvent>(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._obtainNoHistory14398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MotionEvent;
		}
		public new int ActionMasked
		{
			get
			{
				return getActionMasked();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActionMasked14399;
		public int getActionMasked()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getActionMasked14399.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getActionMasked14399 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getActionMasked", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getActionMasked14399);
		}
		public new int ActionIndex
		{
			get
			{
				return getActionIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getActionIndex14400;
		public int getActionIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getActionIndex14400.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getActionIndex14400 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getActionIndex", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getActionIndex14400);
		}
		public new float Pressure
		{
			get
			{
				return getPressure();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPressure14401;
		public float getPressure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getPressure14401.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getPressure14401 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPressure", "()F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPressure14401);
		}
		internal static global::MonoJavaBridge.MethodId _getPressure14402;
		public float getPressure(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getPressure14402.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getPressure14402 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPressure", "(I)F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPressure14402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int PointerCount
		{
			get
			{
				return getPointerCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPointerCount14403;
		public int getPointerCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getPointerCount14403.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getPointerCount14403 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPointerCount", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPointerCount14403);
		}
		internal static global::MonoJavaBridge.MethodId _getPointerId14404;
		public int getPointerId(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getPointerId14404.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getPointerId14404 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getPointerId", "(I)I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getPointerId14404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findPointerIndex14405;
		public int findPointerIndex(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._findPointerIndex14405.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._findPointerIndex14405 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "findPointerIndex", "(I)I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._findPointerIndex14405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float RawX
		{
			get
			{
				return getRawX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawX14406;
		public float getRawX()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getRawX14406.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getRawX14406 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getRawX", "()F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getRawX14406);
		}
		public new float RawY
		{
			get
			{
				return getRawY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRawY14407;
		public float getRawY()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getRawY14407.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getRawY14407 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getRawY", "()F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getRawY14407);
		}
		public new float XPrecision
		{
			get
			{
				return getXPrecision();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getXPrecision14408;
		public float getXPrecision()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getXPrecision14408.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getXPrecision14408 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getXPrecision", "()F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getXPrecision14408);
		}
		public new float YPrecision
		{
			get
			{
				return getYPrecision();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYPrecision14409;
		public float getYPrecision()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getYPrecision14409.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getYPrecision14409 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getYPrecision", "()F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getYPrecision14409);
		}
		public new int HistorySize
		{
			get
			{
				return getHistorySize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHistorySize14410;
		public int getHistorySize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getHistorySize14410.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getHistorySize14410 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistorySize", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistorySize14410);
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalEventTime14411;
		public long getHistoricalEventTime(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getHistoricalEventTime14411.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getHistoricalEventTime14411 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalEventTime", "(I)J");
			return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalEventTime14411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalX14412;
		public float getHistoricalX(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getHistoricalX14412.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getHistoricalX14412 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalX", "(II)F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalX14412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalX14413;
		public float getHistoricalX(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getHistoricalX14413.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getHistoricalX14413 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalX", "(I)F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalX14413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalY14414;
		public float getHistoricalY(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getHistoricalY14414.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getHistoricalY14414 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalY", "(I)F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalY14414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalY14415;
		public float getHistoricalY(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getHistoricalY14415.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getHistoricalY14415 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalY", "(II)F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalY14415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalPressure14416;
		public float getHistoricalPressure(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getHistoricalPressure14416.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getHistoricalPressure14416 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(I)F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalPressure14416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalPressure14417;
		public float getHistoricalPressure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getHistoricalPressure14417.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getHistoricalPressure14417 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(II)F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalPressure14417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalSize14418;
		public float getHistoricalSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getHistoricalSize14418.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getHistoricalSize14418 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(II)F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalSize14418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHistoricalSize14419;
		public float getHistoricalSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getHistoricalSize14419.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getHistoricalSize14419 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(I)F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getHistoricalSize14419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getEdgeFlags14420;
		public int getEdgeFlags()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._getEdgeFlags14420.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._getEdgeFlags14420 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "getEdgeFlags", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._getEdgeFlags14420);
		}
		internal static global::MonoJavaBridge.MethodId _setEdgeFlags14421;
		public void setEdgeFlags(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._setEdgeFlags14421.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._setEdgeFlags14421 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "setEdgeFlags", "(I)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setEdgeFlags14421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offsetLocation14422;
		public void offsetLocation(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._offsetLocation14422.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._offsetLocation14422 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "offsetLocation", "(FF)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._offsetLocation14422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLocation14423;
		public void setLocation(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._setLocation14423.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._setLocation14423 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "setLocation", "(FF)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._setLocation14423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addBatch14424;
		public void addBatch(long arg0, float arg1, float arg2, float arg3, float arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._addBatch14424.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._addBatch14424 = @__env.GetMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "addBatch", "(JFFFFI)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MotionEvent.staticClass, global::android.view.MotionEvent._addBatch14424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR14447;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.MotionEvent.staticClass, _CREATOR14447)) as android.os.Parcelable_Creator;
			}
		}
		static MotionEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.MotionEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/MotionEvent"));
			global::android.view.MotionEvent._CREATOR14447 = @__env.GetStaticFieldIDNoThrow(global::android.view.MotionEvent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
