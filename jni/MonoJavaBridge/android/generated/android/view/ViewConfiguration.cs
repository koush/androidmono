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
		internal static global::MonoJavaBridge.MethodId _get9399;
		public static global::android.view.ViewConfiguration get(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._get9399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewConfiguration;
		}
		internal static global::MonoJavaBridge.MethodId _getScrollBarSize9400;
		public static int getScrollBarSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollBarSize9400);
		}
		internal static global::MonoJavaBridge.MethodId _getScaledScrollBarSize9401;
		public virtual int getScaledScrollBarSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledScrollBarSize9401);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledScrollBarSize9401);
		}
		internal static global::MonoJavaBridge.MethodId _getScrollBarFadeDuration9402;
		public static int getScrollBarFadeDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollBarFadeDuration9402);
		}
		internal static global::MonoJavaBridge.MethodId _getScrollDefaultDelay9403;
		public static int getScrollDefaultDelay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollDefaultDelay9403);
		}
		internal static global::MonoJavaBridge.MethodId _getFadingEdgeLength9404;
		public static int getFadingEdgeLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getFadingEdgeLength9404);
		}
		internal static global::MonoJavaBridge.MethodId _getScaledFadingEdgeLength9405;
		public virtual int getScaledFadingEdgeLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledFadingEdgeLength9405);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledFadingEdgeLength9405);
		}
		internal static global::MonoJavaBridge.MethodId _getPressedStateDuration9406;
		public static int getPressedStateDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getPressedStateDuration9406);
		}
		internal static global::MonoJavaBridge.MethodId _getLongPressTimeout9407;
		public static int getLongPressTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getLongPressTimeout9407);
		}
		internal static global::MonoJavaBridge.MethodId _getTapTimeout9408;
		public static int getTapTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getTapTimeout9408);
		}
		internal static global::MonoJavaBridge.MethodId _getJumpTapTimeout9409;
		public static int getJumpTapTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getJumpTapTimeout9409);
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleTapTimeout9410;
		public static int getDoubleTapTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getDoubleTapTimeout9410);
		}
		internal static global::MonoJavaBridge.MethodId _getEdgeSlop9411;
		public static int getEdgeSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getEdgeSlop9411);
		}
		internal static global::MonoJavaBridge.MethodId _getScaledEdgeSlop9412;
		public virtual int getScaledEdgeSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledEdgeSlop9412);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledEdgeSlop9412);
		}
		internal static global::MonoJavaBridge.MethodId _getTouchSlop9413;
		public static int getTouchSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getTouchSlop9413);
		}
		internal static global::MonoJavaBridge.MethodId _getScaledTouchSlop9414;
		public virtual int getScaledTouchSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledTouchSlop9414);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledTouchSlop9414);
		}
		internal static global::MonoJavaBridge.MethodId _getScaledPagingTouchSlop9415;
		public virtual int getScaledPagingTouchSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledPagingTouchSlop9415);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledPagingTouchSlop9415);
		}
		internal static global::MonoJavaBridge.MethodId _getScaledDoubleTapSlop9416;
		public virtual int getScaledDoubleTapSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledDoubleTapSlop9416);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledDoubleTapSlop9416);
		}
		internal static global::MonoJavaBridge.MethodId _getWindowTouchSlop9417;
		public static int getWindowTouchSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getWindowTouchSlop9417);
		}
		internal static global::MonoJavaBridge.MethodId _getScaledWindowTouchSlop9418;
		public virtual int getScaledWindowTouchSlop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledWindowTouchSlop9418);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledWindowTouchSlop9418);
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumFlingVelocity9419;
		public static int getMinimumFlingVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getMinimumFlingVelocity9419);
		}
		internal static global::MonoJavaBridge.MethodId _getScaledMinimumFlingVelocity9420;
		public virtual int getScaledMinimumFlingVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity9420);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity9420);
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumFlingVelocity9421;
		public static int getMaximumFlingVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getMaximumFlingVelocity9421);
		}
		internal static global::MonoJavaBridge.MethodId _getScaledMaximumFlingVelocity9422;
		public virtual int getScaledMaximumFlingVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity9422);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity9422);
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumDrawingCacheSize9423;
		public static int getMaximumDrawingCacheSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getMaximumDrawingCacheSize9423);
		}
		internal static global::MonoJavaBridge.MethodId _getScaledMaximumDrawingCacheSize9424;
		public virtual int getScaledMaximumDrawingCacheSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize9424);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize9424);
		}
		internal static global::MonoJavaBridge.MethodId _getZoomControlsTimeout9425;
		public static long getZoomControlsTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getZoomControlsTimeout9425);
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalActionKeyTimeout9426;
		public static long getGlobalActionKeyTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getGlobalActionKeyTimeout9426);
		}
		internal static global::MonoJavaBridge.MethodId _getScrollFriction9427;
		public static float getScrollFriction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollFriction9427);
		}
		internal static global::MonoJavaBridge.MethodId _ViewConfiguration9428;
		public ViewConfiguration()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._ViewConfiguration9428);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewConfiguration.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewConfiguration"));
			global::android.view.ViewConfiguration._get9399 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "get", "(Landroid/content/Context;)Landroid/view/ViewConfiguration;");
			global::android.view.ViewConfiguration._getScrollBarSize9400 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollBarSize", "()I");
			global::android.view.ViewConfiguration._getScaledScrollBarSize9401 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledScrollBarSize", "()I");
			global::android.view.ViewConfiguration._getScrollBarFadeDuration9402 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollBarFadeDuration", "()I");
			global::android.view.ViewConfiguration._getScrollDefaultDelay9403 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollDefaultDelay", "()I");
			global::android.view.ViewConfiguration._getFadingEdgeLength9404 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getFadingEdgeLength", "()I");
			global::android.view.ViewConfiguration._getScaledFadingEdgeLength9405 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledFadingEdgeLength", "()I");
			global::android.view.ViewConfiguration._getPressedStateDuration9406 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getPressedStateDuration", "()I");
			global::android.view.ViewConfiguration._getLongPressTimeout9407 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getLongPressTimeout", "()I");
			global::android.view.ViewConfiguration._getTapTimeout9408 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getTapTimeout", "()I");
			global::android.view.ViewConfiguration._getJumpTapTimeout9409 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getJumpTapTimeout", "()I");
			global::android.view.ViewConfiguration._getDoubleTapTimeout9410 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getDoubleTapTimeout", "()I");
			global::android.view.ViewConfiguration._getEdgeSlop9411 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getEdgeSlop", "()I");
			global::android.view.ViewConfiguration._getScaledEdgeSlop9412 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledEdgeSlop", "()I");
			global::android.view.ViewConfiguration._getTouchSlop9413 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledTouchSlop9414 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledPagingTouchSlop9415 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledPagingTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledDoubleTapSlop9416 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledDoubleTapSlop", "()I");
			global::android.view.ViewConfiguration._getWindowTouchSlop9417 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getWindowTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledWindowTouchSlop9418 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledWindowTouchSlop", "()I");
			global::android.view.ViewConfiguration._getMinimumFlingVelocity9419 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getMinimumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity9420 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledMinimumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getMaximumFlingVelocity9421 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getMaximumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity9422 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledMaximumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getMaximumDrawingCacheSize9423 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getMaximumDrawingCacheSize", "()I");
			global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize9424 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScaledMaximumDrawingCacheSize", "()I");
			global::android.view.ViewConfiguration._getZoomControlsTimeout9425 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getZoomControlsTimeout", "()J");
			global::android.view.ViewConfiguration._getGlobalActionKeyTimeout9426 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getGlobalActionKeyTimeout", "()J");
			global::android.view.ViewConfiguration._getScrollFriction9427 = @__env.GetStaticMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "getScrollFriction", "()F");
			global::android.view.ViewConfiguration._ViewConfiguration9428 = @__env.GetMethodIDNoThrow(global::android.view.ViewConfiguration.staticClass, "<init>", "()V");
		}
	}
}
