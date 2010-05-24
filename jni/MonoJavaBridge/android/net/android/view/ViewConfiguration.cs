namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ViewConfiguration : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ViewConfiguration() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.ViewConfiguration), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.ViewConfiguration(@__env); 
			} 
		} 
		protected ViewConfiguration(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get8388; 
		public static android.view.ViewConfiguration get(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewConfiguration>(@__env, @__env.CallStaticObjectMethodPtr(android.view.ViewConfiguration.staticClass, _get8388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScrollBarSize8389; 
		public static int getScrollBarSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getScrollBarSize8389); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledScrollBarSize8390; 
		public virtual int getScaledScrollBarSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledScrollBarSize8390); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledScrollBarSize8390); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScrollBarFadeDuration8391; 
		public static int getScrollBarFadeDuration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getScrollBarFadeDuration8391); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScrollDefaultDelay8392; 
		public static int getScrollDefaultDelay() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getScrollDefaultDelay8392); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFadingEdgeLength8393; 
		public static int getFadingEdgeLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getFadingEdgeLength8393); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledFadingEdgeLength8394; 
		public virtual int getScaledFadingEdgeLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledFadingEdgeLength8394); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledFadingEdgeLength8394); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPressedStateDuration8395; 
		public static int getPressedStateDuration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getPressedStateDuration8395); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLongPressTimeout8396; 
		public static int getLongPressTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getLongPressTimeout8396); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTapTimeout8397; 
		public static int getTapTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getTapTimeout8397); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getJumpTapTimeout8398; 
		public static int getJumpTapTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getJumpTapTimeout8398); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDoubleTapTimeout8399; 
		public static int getDoubleTapTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getDoubleTapTimeout8399); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEdgeSlop8400; 
		public static int getEdgeSlop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getEdgeSlop8400); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledEdgeSlop8401; 
		public virtual int getScaledEdgeSlop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledEdgeSlop8401); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledEdgeSlop8401); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTouchSlop8402; 
		public static int getTouchSlop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getTouchSlop8402); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledTouchSlop8403; 
		public virtual int getScaledTouchSlop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledTouchSlop8403); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledTouchSlop8403); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledDoubleTapSlop8404; 
		public virtual int getScaledDoubleTapSlop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledDoubleTapSlop8404); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledDoubleTapSlop8404); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindowTouchSlop8405; 
		public static int getWindowTouchSlop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getWindowTouchSlop8405); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledWindowTouchSlop8406; 
		public virtual int getScaledWindowTouchSlop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledWindowTouchSlop8406); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledWindowTouchSlop8406); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumFlingVelocity8407; 
		public static int getMinimumFlingVelocity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getMinimumFlingVelocity8407); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledMinimumFlingVelocity8408; 
		public virtual int getScaledMinimumFlingVelocity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledMinimumFlingVelocity8408); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledMinimumFlingVelocity8408); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumFlingVelocity8409; 
		public static int getMaximumFlingVelocity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getMaximumFlingVelocity8409); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledMaximumFlingVelocity8410; 
		public virtual int getScaledMaximumFlingVelocity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledMaximumFlingVelocity8410); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledMaximumFlingVelocity8410); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumDrawingCacheSize8411; 
		public static int getMaximumDrawingCacheSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getMaximumDrawingCacheSize8411); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledMaximumDrawingCacheSize8412; 
		public virtual int getScaledMaximumDrawingCacheSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledMaximumDrawingCacheSize8412); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledMaximumDrawingCacheSize8412); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getZoomControlsTimeout8413; 
		public static long getZoomControlsTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, _getZoomControlsTimeout8413); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalActionKeyTimeout8414; 
		public static long getGlobalActionKeyTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, _getGlobalActionKeyTimeout8414); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScrollFriction8415; 
		public static float getScrollFriction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticFloatMethod(android.view.ViewConfiguration.staticClass, _getScrollFriction8415); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewConfiguration8416; 
		public ViewConfiguration()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.ViewConfiguration.staticClass, _ViewConfiguration8416, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.ViewConfiguration.staticClass = @__class; 
			global::android.view.ViewConfiguration._get8388 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "get", "(Landroid/content/Context;)Landroid/view/ViewConfiguration;"); 
			global::android.view.ViewConfiguration._getScrollBarSize8389 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getScrollBarSize", "()I"); 
			global::android.view.ViewConfiguration._getScaledScrollBarSize8390 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledScrollBarSize", "()I"); 
			global::android.view.ViewConfiguration._getScrollBarFadeDuration8391 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getScrollBarFadeDuration", "()I"); 
			global::android.view.ViewConfiguration._getScrollDefaultDelay8392 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getScrollDefaultDelay", "()I"); 
			global::android.view.ViewConfiguration._getFadingEdgeLength8393 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getFadingEdgeLength", "()I"); 
			global::android.view.ViewConfiguration._getScaledFadingEdgeLength8394 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledFadingEdgeLength", "()I"); 
			global::android.view.ViewConfiguration._getPressedStateDuration8395 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getPressedStateDuration", "()I"); 
			global::android.view.ViewConfiguration._getLongPressTimeout8396 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getLongPressTimeout", "()I"); 
			global::android.view.ViewConfiguration._getTapTimeout8397 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getTapTimeout", "()I"); 
			global::android.view.ViewConfiguration._getJumpTapTimeout8398 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getJumpTapTimeout", "()I"); 
			global::android.view.ViewConfiguration._getDoubleTapTimeout8399 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getDoubleTapTimeout", "()I"); 
			global::android.view.ViewConfiguration._getEdgeSlop8400 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getEdgeSlop", "()I"); 
			global::android.view.ViewConfiguration._getScaledEdgeSlop8401 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledEdgeSlop", "()I"); 
			global::android.view.ViewConfiguration._getTouchSlop8402 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getTouchSlop", "()I"); 
			global::android.view.ViewConfiguration._getScaledTouchSlop8403 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledTouchSlop", "()I"); 
			global::android.view.ViewConfiguration._getScaledDoubleTapSlop8404 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledDoubleTapSlop", "()I"); 
			global::android.view.ViewConfiguration._getWindowTouchSlop8405 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getWindowTouchSlop", "()I"); 
			global::android.view.ViewConfiguration._getScaledWindowTouchSlop8406 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledWindowTouchSlop", "()I"); 
			global::android.view.ViewConfiguration._getMinimumFlingVelocity8407 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getMinimumFlingVelocity", "()I"); 
			global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity8408 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledMinimumFlingVelocity", "()I"); 
			global::android.view.ViewConfiguration._getMaximumFlingVelocity8409 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getMaximumFlingVelocity", "()I"); 
			global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity8410 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledMaximumFlingVelocity", "()I"); 
			global::android.view.ViewConfiguration._getMaximumDrawingCacheSize8411 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getMaximumDrawingCacheSize", "()I"); 
			global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize8412 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledMaximumDrawingCacheSize", "()I"); 
			global::android.view.ViewConfiguration._getZoomControlsTimeout8413 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getZoomControlsTimeout", "()J"); 
			global::android.view.ViewConfiguration._getGlobalActionKeyTimeout8414 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getGlobalActionKeyTimeout", "()J"); 
			global::android.view.ViewConfiguration._getScrollFriction8415 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getScrollFriction", "()F"); 
			global::android.view.ViewConfiguration._ViewConfiguration8416 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "<init>", "()V"); 
		} 
	} 
} 
