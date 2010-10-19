namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ViewConfiguration : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ViewConfiguration()
		{
			InitJNI();
		}
		protected ViewConfiguration(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get9945;
		public static global::android.view.ViewConfiguration get(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._get9945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewConfiguration;
		}
		public static int ScrollBarSize
		{
			get
			{
				return getScrollBarSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollBarSize9946;
		public static int getScrollBarSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollBarSize9946);
		}
		public new int ScaledScrollBarSize
		{
			get
			{
				return getScaledScrollBarSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledScrollBarSize9947;
		public virtual int getScaledScrollBarSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledScrollBarSize9947);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledScrollBarSize9947);
		}
		public static int ScrollBarFadeDuration
		{
			get
			{
				return getScrollBarFadeDuration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollBarFadeDuration9948;
		public static int getScrollBarFadeDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollBarFadeDuration9948);
		}
		public static int ScrollDefaultDelay
		{
			get
			{
				return getScrollDefaultDelay();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollDefaultDelay9949;
		public static int getScrollDefaultDelay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollDefaultDelay9949);
		}
		public static int FadingEdgeLength
		{
			get
			{
				return getFadingEdgeLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFadingEdgeLength9950;
		public static int getFadingEdgeLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getFadingEdgeLength9950);
		}
		public new int ScaledFadingEdgeLength
		{
			get
			{
				return getScaledFadingEdgeLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledFadingEdgeLength9951;
		public virtual int getScaledFadingEdgeLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledFadingEdgeLength9951);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledFadingEdgeLength9951);
		}
		public static int PressedStateDuration
		{
			get
			{
				return getPressedStateDuration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPressedStateDuration9952;
		public static int getPressedStateDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getPressedStateDuration9952);
		}
		public static int LongPressTimeout
		{
			get
			{
				return getLongPressTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLongPressTimeout9953;
		public static int getLongPressTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getLongPressTimeout9953);
		}
		public static int TapTimeout
		{
			get
			{
				return getTapTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTapTimeout9954;
		public static int getTapTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getTapTimeout9954);
		}
		public static int JumpTapTimeout
		{
			get
			{
				return getJumpTapTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getJumpTapTimeout9955;
		public static int getJumpTapTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getJumpTapTimeout9955);
		}
		public static int DoubleTapTimeout
		{
			get
			{
				return getDoubleTapTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleTapTimeout9956;
		public static int getDoubleTapTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getDoubleTapTimeout9956);
		}
		public static int EdgeSlop
		{
			get
			{
				return getEdgeSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEdgeSlop9957;
		public static int getEdgeSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getEdgeSlop9957);
		}
		public new int ScaledEdgeSlop
		{
			get
			{
				return getScaledEdgeSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledEdgeSlop9958;
		public virtual int getScaledEdgeSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledEdgeSlop9958);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledEdgeSlop9958);
		}
		public static int TouchSlop
		{
			get
			{
				return getTouchSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTouchSlop9959;
		public static int getTouchSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getTouchSlop9959);
		}
		public new int ScaledTouchSlop
		{
			get
			{
				return getScaledTouchSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledTouchSlop9960;
		public virtual int getScaledTouchSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledTouchSlop9960);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledTouchSlop9960);
		}
		public new int ScaledPagingTouchSlop
		{
			get
			{
				return getScaledPagingTouchSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledPagingTouchSlop9961;
		public virtual int getScaledPagingTouchSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledPagingTouchSlop9961);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledPagingTouchSlop9961);
		}
		public new int ScaledDoubleTapSlop
		{
			get
			{
				return getScaledDoubleTapSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledDoubleTapSlop9962;
		public virtual int getScaledDoubleTapSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledDoubleTapSlop9962);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledDoubleTapSlop9962);
		}
		public static int WindowTouchSlop
		{
			get
			{
				return getWindowTouchSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindowTouchSlop9963;
		public static int getWindowTouchSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getWindowTouchSlop9963);
		}
		public new int ScaledWindowTouchSlop
		{
			get
			{
				return getScaledWindowTouchSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledWindowTouchSlop9964;
		public virtual int getScaledWindowTouchSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledWindowTouchSlop9964);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledWindowTouchSlop9964);
		}
		public static int MinimumFlingVelocity
		{
			get
			{
				return getMinimumFlingVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumFlingVelocity9965;
		public static int getMinimumFlingVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getMinimumFlingVelocity9965);
		}
		public new int ScaledMinimumFlingVelocity
		{
			get
			{
				return getScaledMinimumFlingVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledMinimumFlingVelocity9966;
		public virtual int getScaledMinimumFlingVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity9966);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity9966);
		}
		public static int MaximumFlingVelocity
		{
			get
			{
				return getMaximumFlingVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumFlingVelocity9967;
		public static int getMaximumFlingVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getMaximumFlingVelocity9967);
		}
		public new int ScaledMaximumFlingVelocity
		{
			get
			{
				return getScaledMaximumFlingVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledMaximumFlingVelocity9968;
		public virtual int getScaledMaximumFlingVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity9968);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity9968);
		}
		public static int MaximumDrawingCacheSize
		{
			get
			{
				return getMaximumDrawingCacheSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumDrawingCacheSize9969;
		public static int getMaximumDrawingCacheSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getMaximumDrawingCacheSize9969);
		}
		public new int ScaledMaximumDrawingCacheSize
		{
			get
			{
				return getScaledMaximumDrawingCacheSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledMaximumDrawingCacheSize9970;
		public virtual int getScaledMaximumDrawingCacheSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize9970);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize9970);
		}
		public static long ZoomControlsTimeout
		{
			get
			{
				return getZoomControlsTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getZoomControlsTimeout9971;
		public static long getZoomControlsTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getZoomControlsTimeout9971);
		}
		public static long GlobalActionKeyTimeout
		{
			get
			{
				return getGlobalActionKeyTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalActionKeyTimeout9972;
		public static long getGlobalActionKeyTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getGlobalActionKeyTimeout9972);
		}
		public static float ScrollFriction
		{
			get
			{
				return getScrollFriction();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollFriction9973;
		public static float getScrollFriction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollFriction9973);
		}
		internal static global::MonoJavaBridge.MethodId _ViewConfiguration9974;
		public ViewConfiguration()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._ViewConfiguration9974);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewConfiguration.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewConfiguration"));
			global::android.view.ViewConfiguration._get9945 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "get", "(Landroid/content/Context;)Landroid/view/ViewConfiguration;");
			global::android.view.ViewConfiguration._getScrollBarSize9946 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollBarSize", "()I");
			global::android.view.ViewConfiguration._getScaledScrollBarSize9947 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledScrollBarSize", "()I");
			global::android.view.ViewConfiguration._getScrollBarFadeDuration9948 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollBarFadeDuration", "()I");
			global::android.view.ViewConfiguration._getScrollDefaultDelay9949 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollDefaultDelay", "()I");
			global::android.view.ViewConfiguration._getFadingEdgeLength9950 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getFadingEdgeLength", "()I");
			global::android.view.ViewConfiguration._getScaledFadingEdgeLength9951 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledFadingEdgeLength", "()I");
			global::android.view.ViewConfiguration._getPressedStateDuration9952 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getPressedStateDuration", "()I");
			global::android.view.ViewConfiguration._getLongPressTimeout9953 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getLongPressTimeout", "()I");
			global::android.view.ViewConfiguration._getTapTimeout9954 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getTapTimeout", "()I");
			global::android.view.ViewConfiguration._getJumpTapTimeout9955 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getJumpTapTimeout", "()I");
			global::android.view.ViewConfiguration._getDoubleTapTimeout9956 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getDoubleTapTimeout", "()I");
			global::android.view.ViewConfiguration._getEdgeSlop9957 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getEdgeSlop", "()I");
			global::android.view.ViewConfiguration._getScaledEdgeSlop9958 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledEdgeSlop", "()I");
			global::android.view.ViewConfiguration._getTouchSlop9959 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledTouchSlop9960 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledPagingTouchSlop9961 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledPagingTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledDoubleTapSlop9962 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledDoubleTapSlop", "()I");
			global::android.view.ViewConfiguration._getWindowTouchSlop9963 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getWindowTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledWindowTouchSlop9964 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledWindowTouchSlop", "()I");
			global::android.view.ViewConfiguration._getMinimumFlingVelocity9965 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getMinimumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity9966 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledMinimumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getMaximumFlingVelocity9967 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getMaximumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity9968 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledMaximumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getMaximumDrawingCacheSize9969 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getMaximumDrawingCacheSize", "()I");
			global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize9970 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledMaximumDrawingCacheSize", "()I");
			global::android.view.ViewConfiguration._getZoomControlsTimeout9971 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getZoomControlsTimeout", "()J");
			global::android.view.ViewConfiguration._getGlobalActionKeyTimeout9972 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getGlobalActionKeyTimeout", "()J");
			global::android.view.ViewConfiguration._getScrollFriction9973 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollFriction", "()F");
			global::android.view.ViewConfiguration._ViewConfiguration9974 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "<init>", "()V");
		}
	}
}
