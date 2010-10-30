namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ViewConfiguration : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ViewConfiguration(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get14947;
		public static global::android.view.ViewConfiguration get(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._get14947.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._get14947 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "get", "(Landroid/content/Context;)Landroid/view/ViewConfiguration;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._get14947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewConfiguration;
		}
		public static int ScrollBarSize
		{
			get
			{
				return getScrollBarSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollBarSize14948;
		public static int getScrollBarSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getScrollBarSize14948.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getScrollBarSize14948 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollBarSize", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollBarSize14948);
		}
		public new int ScaledScrollBarSize
		{
			get
			{
				return getScaledScrollBarSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledScrollBarSize14949;
		public virtual int getScaledScrollBarSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getScaledScrollBarSize14949.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getScaledScrollBarSize14949 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledScrollBarSize", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledScrollBarSize14949);
		}
		public static int ScrollBarFadeDuration
		{
			get
			{
				return getScrollBarFadeDuration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollBarFadeDuration14950;
		public static int getScrollBarFadeDuration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getScrollBarFadeDuration14950.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getScrollBarFadeDuration14950 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollBarFadeDuration", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollBarFadeDuration14950);
		}
		public static int ScrollDefaultDelay
		{
			get
			{
				return getScrollDefaultDelay();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollDefaultDelay14951;
		public static int getScrollDefaultDelay()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getScrollDefaultDelay14951.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getScrollDefaultDelay14951 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollDefaultDelay", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollDefaultDelay14951);
		}
		public static int FadingEdgeLength
		{
			get
			{
				return getFadingEdgeLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFadingEdgeLength14952;
		public static int getFadingEdgeLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getFadingEdgeLength14952.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getFadingEdgeLength14952 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getFadingEdgeLength", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getFadingEdgeLength14952);
		}
		public new int ScaledFadingEdgeLength
		{
			get
			{
				return getScaledFadingEdgeLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledFadingEdgeLength14953;
		public virtual int getScaledFadingEdgeLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getScaledFadingEdgeLength14953.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getScaledFadingEdgeLength14953 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledFadingEdgeLength", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledFadingEdgeLength14953);
		}
		public static int PressedStateDuration
		{
			get
			{
				return getPressedStateDuration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPressedStateDuration14954;
		public static int getPressedStateDuration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getPressedStateDuration14954.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getPressedStateDuration14954 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getPressedStateDuration", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getPressedStateDuration14954);
		}
		public static int LongPressTimeout
		{
			get
			{
				return getLongPressTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLongPressTimeout14955;
		public static int getLongPressTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getLongPressTimeout14955.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getLongPressTimeout14955 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getLongPressTimeout", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getLongPressTimeout14955);
		}
		public static int TapTimeout
		{
			get
			{
				return getTapTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTapTimeout14956;
		public static int getTapTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getTapTimeout14956.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getTapTimeout14956 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getTapTimeout", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getTapTimeout14956);
		}
		public static int JumpTapTimeout
		{
			get
			{
				return getJumpTapTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getJumpTapTimeout14957;
		public static int getJumpTapTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getJumpTapTimeout14957.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getJumpTapTimeout14957 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getJumpTapTimeout", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getJumpTapTimeout14957);
		}
		public static int DoubleTapTimeout
		{
			get
			{
				return getDoubleTapTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleTapTimeout14958;
		public static int getDoubleTapTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getDoubleTapTimeout14958.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getDoubleTapTimeout14958 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getDoubleTapTimeout", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getDoubleTapTimeout14958);
		}
		public static int EdgeSlop
		{
			get
			{
				return getEdgeSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEdgeSlop14959;
		public static int getEdgeSlop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getEdgeSlop14959.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getEdgeSlop14959 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getEdgeSlop", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getEdgeSlop14959);
		}
		public new int ScaledEdgeSlop
		{
			get
			{
				return getScaledEdgeSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledEdgeSlop14960;
		public virtual int getScaledEdgeSlop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getScaledEdgeSlop14960.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getScaledEdgeSlop14960 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledEdgeSlop", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledEdgeSlop14960);
		}
		public static int TouchSlop
		{
			get
			{
				return getTouchSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTouchSlop14961;
		public static int getTouchSlop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getTouchSlop14961.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getTouchSlop14961 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getTouchSlop", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getTouchSlop14961);
		}
		public new int ScaledTouchSlop
		{
			get
			{
				return getScaledTouchSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledTouchSlop14962;
		public virtual int getScaledTouchSlop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getScaledTouchSlop14962.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getScaledTouchSlop14962 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledTouchSlop", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledTouchSlop14962);
		}
		public new int ScaledPagingTouchSlop
		{
			get
			{
				return getScaledPagingTouchSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledPagingTouchSlop14963;
		public virtual int getScaledPagingTouchSlop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getScaledPagingTouchSlop14963.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getScaledPagingTouchSlop14963 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledPagingTouchSlop", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledPagingTouchSlop14963);
		}
		public new int ScaledDoubleTapSlop
		{
			get
			{
				return getScaledDoubleTapSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledDoubleTapSlop14964;
		public virtual int getScaledDoubleTapSlop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getScaledDoubleTapSlop14964.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getScaledDoubleTapSlop14964 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledDoubleTapSlop", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledDoubleTapSlop14964);
		}
		public static int WindowTouchSlop
		{
			get
			{
				return getWindowTouchSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindowTouchSlop14965;
		public static int getWindowTouchSlop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getWindowTouchSlop14965.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getWindowTouchSlop14965 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getWindowTouchSlop", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getWindowTouchSlop14965);
		}
		public new int ScaledWindowTouchSlop
		{
			get
			{
				return getScaledWindowTouchSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledWindowTouchSlop14966;
		public virtual int getScaledWindowTouchSlop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getScaledWindowTouchSlop14966.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getScaledWindowTouchSlop14966 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledWindowTouchSlop", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledWindowTouchSlop14966);
		}
		public static int MinimumFlingVelocity
		{
			get
			{
				return getMinimumFlingVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumFlingVelocity14967;
		public static int getMinimumFlingVelocity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getMinimumFlingVelocity14967.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getMinimumFlingVelocity14967 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getMinimumFlingVelocity", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getMinimumFlingVelocity14967);
		}
		public new int ScaledMinimumFlingVelocity
		{
			get
			{
				return getScaledMinimumFlingVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledMinimumFlingVelocity14968;
		public virtual int getScaledMinimumFlingVelocity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity14968.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity14968 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledMinimumFlingVelocity", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity14968);
		}
		public static int MaximumFlingVelocity
		{
			get
			{
				return getMaximumFlingVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumFlingVelocity14969;
		public static int getMaximumFlingVelocity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getMaximumFlingVelocity14969.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getMaximumFlingVelocity14969 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getMaximumFlingVelocity", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getMaximumFlingVelocity14969);
		}
		public new int ScaledMaximumFlingVelocity
		{
			get
			{
				return getScaledMaximumFlingVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledMaximumFlingVelocity14970;
		public virtual int getScaledMaximumFlingVelocity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity14970.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity14970 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledMaximumFlingVelocity", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity14970);
		}
		public static int MaximumDrawingCacheSize
		{
			get
			{
				return getMaximumDrawingCacheSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumDrawingCacheSize14971;
		public static int getMaximumDrawingCacheSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getMaximumDrawingCacheSize14971.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getMaximumDrawingCacheSize14971 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getMaximumDrawingCacheSize", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getMaximumDrawingCacheSize14971);
		}
		public new int ScaledMaximumDrawingCacheSize
		{
			get
			{
				return getScaledMaximumDrawingCacheSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledMaximumDrawingCacheSize14972;
		public virtual int getScaledMaximumDrawingCacheSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize14972.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize14972 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledMaximumDrawingCacheSize", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize14972);
		}
		public static long ZoomControlsTimeout
		{
			get
			{
				return getZoomControlsTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getZoomControlsTimeout14973;
		public static long getZoomControlsTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getZoomControlsTimeout14973.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getZoomControlsTimeout14973 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getZoomControlsTimeout", "()J");
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getZoomControlsTimeout14973);
		}
		public static long GlobalActionKeyTimeout
		{
			get
			{
				return getGlobalActionKeyTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalActionKeyTimeout14974;
		public static long getGlobalActionKeyTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getGlobalActionKeyTimeout14974.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getGlobalActionKeyTimeout14974 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getGlobalActionKeyTimeout", "()J");
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getGlobalActionKeyTimeout14974);
		}
		public static float ScrollFriction
		{
			get
			{
				return getScrollFriction();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollFriction14975;
		public static float getScrollFriction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._getScrollFriction14975.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._getScrollFriction14975 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollFriction", "()F");
			return @__env.CallStaticFloatMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollFriction14975);
		}
		internal static global::MonoJavaBridge.MethodId _ViewConfiguration14976;
		public ViewConfiguration() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._ViewConfiguration14976.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._ViewConfiguration14976 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._ViewConfiguration14976);
			Init(@__env, handle);
		}
		static ViewConfiguration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewConfiguration.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewConfiguration"));
		}
		internal static void InitJNI()
		{
		}
	}
}
