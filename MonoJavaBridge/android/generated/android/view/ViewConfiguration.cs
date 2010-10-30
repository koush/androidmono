namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ViewConfiguration : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ViewConfiguration(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.view.ViewConfiguration get(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m0.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m0 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "get", "(Landroid/content/Context;)Landroid/view/ViewConfiguration;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewConfiguration;
		}
		public static int ScrollBarSize
		{
			get
			{
				return getScrollBarSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int getScrollBarSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m1.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m1 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollBarSize", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m1);
		}
		public new int ScaledScrollBarSize
		{
			get
			{
				return getScaledScrollBarSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getScaledScrollBarSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, "getScaledScrollBarSize", "()I", ref global::android.view.ViewConfiguration._m2);
		}
		public static int ScrollBarFadeDuration
		{
			get
			{
				return getScrollBarFadeDuration();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static int getScrollBarFadeDuration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m3.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m3 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollBarFadeDuration", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m3);
		}
		public static int ScrollDefaultDelay
		{
			get
			{
				return getScrollDefaultDelay();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int getScrollDefaultDelay()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m4.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m4 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollDefaultDelay", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m4);
		}
		public static int FadingEdgeLength
		{
			get
			{
				return getFadingEdgeLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static int getFadingEdgeLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m5.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m5 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getFadingEdgeLength", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m5);
		}
		public new int ScaledFadingEdgeLength
		{
			get
			{
				return getScaledFadingEdgeLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getScaledFadingEdgeLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, "getScaledFadingEdgeLength", "()I", ref global::android.view.ViewConfiguration._m6);
		}
		public static int PressedStateDuration
		{
			get
			{
				return getPressedStateDuration();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static int getPressedStateDuration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m7.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m7 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getPressedStateDuration", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m7);
		}
		public static int LongPressTimeout
		{
			get
			{
				return getLongPressTimeout();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static int getLongPressTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m8.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m8 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getLongPressTimeout", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m8);
		}
		public static int TapTimeout
		{
			get
			{
				return getTapTimeout();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static int getTapTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m9.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m9 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getTapTimeout", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m9);
		}
		public static int JumpTapTimeout
		{
			get
			{
				return getJumpTapTimeout();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static int getJumpTapTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m10.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m10 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getJumpTapTimeout", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m10);
		}
		public static int DoubleTapTimeout
		{
			get
			{
				return getDoubleTapTimeout();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static int getDoubleTapTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m11.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m11 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getDoubleTapTimeout", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m11);
		}
		public static int EdgeSlop
		{
			get
			{
				return getEdgeSlop();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static int getEdgeSlop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m12.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m12 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getEdgeSlop", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m12);
		}
		public new int ScaledEdgeSlop
		{
			get
			{
				return getScaledEdgeSlop();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int getScaledEdgeSlop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, "getScaledEdgeSlop", "()I", ref global::android.view.ViewConfiguration._m13);
		}
		public static int TouchSlop
		{
			get
			{
				return getTouchSlop();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static int getTouchSlop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m14.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m14 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getTouchSlop", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m14);
		}
		public new int ScaledTouchSlop
		{
			get
			{
				return getScaledTouchSlop();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int getScaledTouchSlop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, "getScaledTouchSlop", "()I", ref global::android.view.ViewConfiguration._m15);
		}
		public new int ScaledPagingTouchSlop
		{
			get
			{
				return getScaledPagingTouchSlop();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int getScaledPagingTouchSlop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, "getScaledPagingTouchSlop", "()I", ref global::android.view.ViewConfiguration._m16);
		}
		public new int ScaledDoubleTapSlop
		{
			get
			{
				return getScaledDoubleTapSlop();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual int getScaledDoubleTapSlop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, "getScaledDoubleTapSlop", "()I", ref global::android.view.ViewConfiguration._m17);
		}
		public static int WindowTouchSlop
		{
			get
			{
				return getWindowTouchSlop();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static int getWindowTouchSlop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m18.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m18 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getWindowTouchSlop", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m18);
		}
		public new int ScaledWindowTouchSlop
		{
			get
			{
				return getScaledWindowTouchSlop();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int getScaledWindowTouchSlop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, "getScaledWindowTouchSlop", "()I", ref global::android.view.ViewConfiguration._m19);
		}
		public static int MinimumFlingVelocity
		{
			get
			{
				return getMinimumFlingVelocity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static int getMinimumFlingVelocity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m20.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m20 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getMinimumFlingVelocity", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m20);
		}
		public new int ScaledMinimumFlingVelocity
		{
			get
			{
				return getScaledMinimumFlingVelocity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual int getScaledMinimumFlingVelocity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, "getScaledMinimumFlingVelocity", "()I", ref global::android.view.ViewConfiguration._m21);
		}
		public static int MaximumFlingVelocity
		{
			get
			{
				return getMaximumFlingVelocity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static int getMaximumFlingVelocity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m22.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m22 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getMaximumFlingVelocity", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m22);
		}
		public new int ScaledMaximumFlingVelocity
		{
			get
			{
				return getScaledMaximumFlingVelocity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual int getScaledMaximumFlingVelocity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, "getScaledMaximumFlingVelocity", "()I", ref global::android.view.ViewConfiguration._m23);
		}
		public static int MaximumDrawingCacheSize
		{
			get
			{
				return getMaximumDrawingCacheSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static int getMaximumDrawingCacheSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m24.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m24 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getMaximumDrawingCacheSize", "()I");
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m24);
		}
		public new int ScaledMaximumDrawingCacheSize
		{
			get
			{
				return getScaledMaximumDrawingCacheSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual int getScaledMaximumDrawingCacheSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewConfiguration.staticClass, "getScaledMaximumDrawingCacheSize", "()I", ref global::android.view.ViewConfiguration._m25);
		}
		public static long ZoomControlsTimeout
		{
			get
			{
				return getZoomControlsTimeout();
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static long getZoomControlsTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m26.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m26 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getZoomControlsTimeout", "()J");
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m26);
		}
		public static long GlobalActionKeyTimeout
		{
			get
			{
				return getGlobalActionKeyTimeout();
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static long getGlobalActionKeyTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m27.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m27 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getGlobalActionKeyTimeout", "()J");
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m27);
		}
		public static float ScrollFriction
		{
			get
			{
				return getScrollFriction();
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static float getScrollFriction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m28.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m28 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollFriction", "()F");
			return @__env.CallStaticFloatMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public ViewConfiguration() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewConfiguration._m29.native == global::System.IntPtr.Zero)
				global::android.view.ViewConfiguration._m29 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._m29);
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
