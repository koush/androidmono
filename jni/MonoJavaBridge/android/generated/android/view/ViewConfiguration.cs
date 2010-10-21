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
		internal static global::MonoJavaBridge.MethodId _get14873;
		public static global::android.view.ViewConfiguration get(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._get14873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewConfiguration;
		}
		public static int ScrollBarSize
		{
			get
			{
				return getScrollBarSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollBarSize14874;
		public static int getScrollBarSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollBarSize14874);
		}
		public new int ScaledScrollBarSize
		{
			get
			{
				return getScaledScrollBarSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledScrollBarSize14875;
		public virtual int getScaledScrollBarSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledScrollBarSize14875);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledScrollBarSize14875);
		}
		public static int ScrollBarFadeDuration
		{
			get
			{
				return getScrollBarFadeDuration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollBarFadeDuration14876;
		public static int getScrollBarFadeDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollBarFadeDuration14876);
		}
		public static int ScrollDefaultDelay
		{
			get
			{
				return getScrollDefaultDelay();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollDefaultDelay14877;
		public static int getScrollDefaultDelay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollDefaultDelay14877);
		}
		public static int FadingEdgeLength
		{
			get
			{
				return getFadingEdgeLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFadingEdgeLength14878;
		public static int getFadingEdgeLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getFadingEdgeLength14878);
		}
		public new int ScaledFadingEdgeLength
		{
			get
			{
				return getScaledFadingEdgeLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledFadingEdgeLength14879;
		public virtual int getScaledFadingEdgeLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledFadingEdgeLength14879);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledFadingEdgeLength14879);
		}
		public static int PressedStateDuration
		{
			get
			{
				return getPressedStateDuration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPressedStateDuration14880;
		public static int getPressedStateDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getPressedStateDuration14880);
		}
		public static int LongPressTimeout
		{
			get
			{
				return getLongPressTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLongPressTimeout14881;
		public static int getLongPressTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getLongPressTimeout14881);
		}
		public static int TapTimeout
		{
			get
			{
				return getTapTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTapTimeout14882;
		public static int getTapTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getTapTimeout14882);
		}
		public static int JumpTapTimeout
		{
			get
			{
				return getJumpTapTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getJumpTapTimeout14883;
		public static int getJumpTapTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getJumpTapTimeout14883);
		}
		public static int DoubleTapTimeout
		{
			get
			{
				return getDoubleTapTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleTapTimeout14884;
		public static int getDoubleTapTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getDoubleTapTimeout14884);
		}
		public static int EdgeSlop
		{
			get
			{
				return getEdgeSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEdgeSlop14885;
		public static int getEdgeSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getEdgeSlop14885);
		}
		public new int ScaledEdgeSlop
		{
			get
			{
				return getScaledEdgeSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledEdgeSlop14886;
		public virtual int getScaledEdgeSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledEdgeSlop14886);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledEdgeSlop14886);
		}
		public static int TouchSlop
		{
			get
			{
				return getTouchSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTouchSlop14887;
		public static int getTouchSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getTouchSlop14887);
		}
		public new int ScaledTouchSlop
		{
			get
			{
				return getScaledTouchSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledTouchSlop14888;
		public virtual int getScaledTouchSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledTouchSlop14888);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledTouchSlop14888);
		}
		public new int ScaledPagingTouchSlop
		{
			get
			{
				return getScaledPagingTouchSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledPagingTouchSlop14889;
		public virtual int getScaledPagingTouchSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledPagingTouchSlop14889);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledPagingTouchSlop14889);
		}
		public new int ScaledDoubleTapSlop
		{
			get
			{
				return getScaledDoubleTapSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledDoubleTapSlop14890;
		public virtual int getScaledDoubleTapSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledDoubleTapSlop14890);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledDoubleTapSlop14890);
		}
		public static int WindowTouchSlop
		{
			get
			{
				return getWindowTouchSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindowTouchSlop14891;
		public static int getWindowTouchSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getWindowTouchSlop14891);
		}
		public new int ScaledWindowTouchSlop
		{
			get
			{
				return getScaledWindowTouchSlop();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledWindowTouchSlop14892;
		public virtual int getScaledWindowTouchSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledWindowTouchSlop14892);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledWindowTouchSlop14892);
		}
		public static int MinimumFlingVelocity
		{
			get
			{
				return getMinimumFlingVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumFlingVelocity14893;
		public static int getMinimumFlingVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getMinimumFlingVelocity14893);
		}
		public new int ScaledMinimumFlingVelocity
		{
			get
			{
				return getScaledMinimumFlingVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledMinimumFlingVelocity14894;
		public virtual int getScaledMinimumFlingVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity14894);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity14894);
		}
		public static int MaximumFlingVelocity
		{
			get
			{
				return getMaximumFlingVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumFlingVelocity14895;
		public static int getMaximumFlingVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getMaximumFlingVelocity14895);
		}
		public new int ScaledMaximumFlingVelocity
		{
			get
			{
				return getScaledMaximumFlingVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledMaximumFlingVelocity14896;
		public virtual int getScaledMaximumFlingVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity14896);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity14896);
		}
		public static int MaximumDrawingCacheSize
		{
			get
			{
				return getMaximumDrawingCacheSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumDrawingCacheSize14897;
		public static int getMaximumDrawingCacheSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getMaximumDrawingCacheSize14897);
		}
		public new int ScaledMaximumDrawingCacheSize
		{
			get
			{
				return getScaledMaximumDrawingCacheSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaledMaximumDrawingCacheSize14898;
		public virtual int getScaledMaximumDrawingCacheSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize14898);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize14898);
		}
		public static long ZoomControlsTimeout
		{
			get
			{
				return getZoomControlsTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getZoomControlsTimeout14899;
		public static long getZoomControlsTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getZoomControlsTimeout14899);
		}
		public static long GlobalActionKeyTimeout
		{
			get
			{
				return getGlobalActionKeyTimeout();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalActionKeyTimeout14900;
		public static long getGlobalActionKeyTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getGlobalActionKeyTimeout14900);
		}
		public static float ScrollFriction
		{
			get
			{
				return getScrollFriction();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScrollFriction14901;
		public static float getScrollFriction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollFriction14901);
		}
		internal static global::MonoJavaBridge.MethodId _ViewConfiguration14902;
		public ViewConfiguration()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._ViewConfiguration14902);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewConfiguration.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewConfiguration"));
			global::android.view.ViewConfiguration._get14873 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "get", "(Landroid/content/Context;)Landroid/view/ViewConfiguration;");
			global::android.view.ViewConfiguration._getScrollBarSize14874 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollBarSize", "()I");
			global::android.view.ViewConfiguration._getScaledScrollBarSize14875 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledScrollBarSize", "()I");
			global::android.view.ViewConfiguration._getScrollBarFadeDuration14876 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollBarFadeDuration", "()I");
			global::android.view.ViewConfiguration._getScrollDefaultDelay14877 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollDefaultDelay", "()I");
			global::android.view.ViewConfiguration._getFadingEdgeLength14878 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getFadingEdgeLength", "()I");
			global::android.view.ViewConfiguration._getScaledFadingEdgeLength14879 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledFadingEdgeLength", "()I");
			global::android.view.ViewConfiguration._getPressedStateDuration14880 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getPressedStateDuration", "()I");
			global::android.view.ViewConfiguration._getLongPressTimeout14881 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getLongPressTimeout", "()I");
			global::android.view.ViewConfiguration._getTapTimeout14882 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getTapTimeout", "()I");
			global::android.view.ViewConfiguration._getJumpTapTimeout14883 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getJumpTapTimeout", "()I");
			global::android.view.ViewConfiguration._getDoubleTapTimeout14884 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getDoubleTapTimeout", "()I");
			global::android.view.ViewConfiguration._getEdgeSlop14885 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getEdgeSlop", "()I");
			global::android.view.ViewConfiguration._getScaledEdgeSlop14886 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledEdgeSlop", "()I");
			global::android.view.ViewConfiguration._getTouchSlop14887 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledTouchSlop14888 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledPagingTouchSlop14889 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledPagingTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledDoubleTapSlop14890 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledDoubleTapSlop", "()I");
			global::android.view.ViewConfiguration._getWindowTouchSlop14891 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getWindowTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledWindowTouchSlop14892 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledWindowTouchSlop", "()I");
			global::android.view.ViewConfiguration._getMinimumFlingVelocity14893 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getMinimumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity14894 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledMinimumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getMaximumFlingVelocity14895 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getMaximumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity14896 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledMaximumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getMaximumDrawingCacheSize14897 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getMaximumDrawingCacheSize", "()I");
			global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize14898 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledMaximumDrawingCacheSize", "()I");
			global::android.view.ViewConfiguration._getZoomControlsTimeout14899 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getZoomControlsTimeout", "()J");
			global::android.view.ViewConfiguration._getGlobalActionKeyTimeout14900 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getGlobalActionKeyTimeout", "()J");
			global::android.view.ViewConfiguration._getScrollFriction14901 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollFriction", "()F");
			global::android.view.ViewConfiguration._ViewConfiguration14902 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "<init>", "()V");
		}
	}
}
