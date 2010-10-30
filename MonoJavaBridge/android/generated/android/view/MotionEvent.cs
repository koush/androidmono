namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class MotionEvent : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MotionEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.MotionEvent.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.MotionEvent._m0) as java.lang.String;
		}
		public new float Size
		{
			get
			{
				return getSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public float getSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getSize", "()F", ref global::android.view.MotionEvent._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public float getSize(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getSize", "(I)F", ref global::android.view.MotionEvent._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public float getY(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getY", "(I)F", ref global::android.view.MotionEvent._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float Y
		{
			get
			{
				return getY();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public float getY()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getY", "()F", ref global::android.view.MotionEvent._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public float getX(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getX", "(I)F", ref global::android.view.MotionEvent._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float X
		{
			get
			{
				return getX();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public float getX()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getX", "()F", ref global::android.view.MotionEvent._m6);
		}
		public new long EventTime
		{
			get
			{
				return getEventTime();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public long getEventTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.MotionEvent.staticClass, "getEventTime", "()J", ref global::android.view.MotionEvent._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._m8.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._m8 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFI)Landroid/view/MotionEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.MotionEvent>(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.view.MotionEvent;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, int arg3, float arg4, float arg5, float arg6, float arg7, int arg8, float arg9, float arg10, int arg11, int arg12)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._m9.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._m9 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(JJIIFFFFIFFII)Landroid/view/MotionEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.MotionEvent>(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg12))) as android.view.MotionEvent;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::android.view.MotionEvent obtain(long arg0, long arg1, int arg2, float arg3, float arg4, float arg5, float arg6, int arg7, float arg8, float arg9, int arg10, int arg11)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._m10.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._m10 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(JJIFFFFIFFII)Landroid/view/MotionEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.MotionEvent>(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11))) as android.view.MotionEvent;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::android.view.MotionEvent obtain(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._m11.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._m11 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtain", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.MotionEvent>(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MotionEvent;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public void recycle()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.MotionEvent.staticClass, "recycle", "()V", ref global::android.view.MotionEvent._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.MotionEvent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.view.MotionEvent._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.MotionEvent.staticClass, "describeContents", "()I", ref global::android.view.MotionEvent._m14);
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
		private static global::MonoJavaBridge.MethodId _m15;
		public int getAction()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.MotionEvent.staticClass, "getAction", "()I", ref global::android.view.MotionEvent._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public void setAction(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.MotionEvent.staticClass, "setAction", "(I)V", ref global::android.view.MotionEvent._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MetaState
		{
			get
			{
				return getMetaState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public int getMetaState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.MotionEvent.staticClass, "getMetaState", "()I", ref global::android.view.MotionEvent._m17);
		}
		public new long DownTime
		{
			get
			{
				return getDownTime();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public long getDownTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.MotionEvent.staticClass, "getDownTime", "()J", ref global::android.view.MotionEvent._m18);
		}
		public new int DeviceId
		{
			get
			{
				return getDeviceId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public int getDeviceId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.MotionEvent.staticClass, "getDeviceId", "()I", ref global::android.view.MotionEvent._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static global::android.view.MotionEvent obtainNoHistory(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.MotionEvent._m20.native == global::System.IntPtr.Zero)
				global::android.view.MotionEvent._m20 = @__env.GetStaticMethodIDNoThrow(global::android.view.MotionEvent.staticClass, "obtainNoHistory", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.MotionEvent>(@__env.CallStaticObjectMethod(android.view.MotionEvent.staticClass, global::android.view.MotionEvent._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.MotionEvent;
		}
		public new int ActionMasked
		{
			get
			{
				return getActionMasked();
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public int getActionMasked()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.MotionEvent.staticClass, "getActionMasked", "()I", ref global::android.view.MotionEvent._m21);
		}
		public new int ActionIndex
		{
			get
			{
				return getActionIndex();
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public int getActionIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.MotionEvent.staticClass, "getActionIndex", "()I", ref global::android.view.MotionEvent._m22);
		}
		public new float Pressure
		{
			get
			{
				return getPressure();
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public float getPressure()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getPressure", "()F", ref global::android.view.MotionEvent._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public float getPressure(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getPressure", "(I)F", ref global::android.view.MotionEvent._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int PointerCount
		{
			get
			{
				return getPointerCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public int getPointerCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.MotionEvent.staticClass, "getPointerCount", "()I", ref global::android.view.MotionEvent._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public int getPointerId(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.MotionEvent.staticClass, "getPointerId", "(I)I", ref global::android.view.MotionEvent._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public int findPointerIndex(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.MotionEvent.staticClass, "findPointerIndex", "(I)I", ref global::android.view.MotionEvent._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float RawX
		{
			get
			{
				return getRawX();
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public float getRawX()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getRawX", "()F", ref global::android.view.MotionEvent._m28);
		}
		public new float RawY
		{
			get
			{
				return getRawY();
			}
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public float getRawY()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getRawY", "()F", ref global::android.view.MotionEvent._m29);
		}
		public new float XPrecision
		{
			get
			{
				return getXPrecision();
			}
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public float getXPrecision()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getXPrecision", "()F", ref global::android.view.MotionEvent._m30);
		}
		public new float YPrecision
		{
			get
			{
				return getYPrecision();
			}
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public float getYPrecision()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getYPrecision", "()F", ref global::android.view.MotionEvent._m31);
		}
		public new int HistorySize
		{
			get
			{
				return getHistorySize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public int getHistorySize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.MotionEvent.staticClass, "getHistorySize", "()I", ref global::android.view.MotionEvent._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public long getHistoricalEventTime(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.MotionEvent.staticClass, "getHistoricalEventTime", "(I)J", ref global::android.view.MotionEvent._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public float getHistoricalX(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getHistoricalX", "(II)F", ref global::android.view.MotionEvent._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public float getHistoricalX(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getHistoricalX", "(I)F", ref global::android.view.MotionEvent._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public float getHistoricalY(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getHistoricalY", "(I)F", ref global::android.view.MotionEvent._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public float getHistoricalY(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getHistoricalY", "(II)F", ref global::android.view.MotionEvent._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public float getHistoricalPressure(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(I)F", ref global::android.view.MotionEvent._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public float getHistoricalPressure(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getHistoricalPressure", "(II)F", ref global::android.view.MotionEvent._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public float getHistoricalSize(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(II)F", ref global::android.view.MotionEvent._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public float getHistoricalSize(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.MotionEvent.staticClass, "getHistoricalSize", "(I)F", ref global::android.view.MotionEvent._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m42;
		public int getEdgeFlags()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.MotionEvent.staticClass, "getEdgeFlags", "()I", ref global::android.view.MotionEvent._m42);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public void setEdgeFlags(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.MotionEvent.staticClass, "setEdgeFlags", "(I)V", ref global::android.view.MotionEvent._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public void offsetLocation(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.MotionEvent.staticClass, "offsetLocation", "(FF)V", ref global::android.view.MotionEvent._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public void setLocation(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.MotionEvent.staticClass, "setLocation", "(FF)V", ref global::android.view.MotionEvent._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public void addBatch(long arg0, float arg1, float arg2, float arg3, float arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.MotionEvent.staticClass, "addBatch", "(JFFFFI)V", ref global::android.view.MotionEvent._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR5650;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.MotionEvent.staticClass, _CREATOR5650)) as android.os.Parcelable_Creator;
			}
		}
		static MotionEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.MotionEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/MotionEvent"));
			global::android.view.MotionEvent._CREATOR5650 = @__env.GetStaticFieldIDNoThrow(global::android.view.MotionEvent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
