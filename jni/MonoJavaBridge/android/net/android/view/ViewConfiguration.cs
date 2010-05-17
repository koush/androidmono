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
		internal static global::net.sf.jni4net.jni.MethodId _get7830; 
		public static android.view.ViewConfiguration get(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewConfiguration>(@__env, @__env.CallStaticObjectMethodPtr(android.view.ViewConfiguration.staticClass, _get7830, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScrollBarSize7831; 
		public static int getScrollBarSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getScrollBarSize7831); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledScrollBarSize7832; 
		public virtual int getScaledScrollBarSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledScrollBarSize7832); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledScrollBarSize7832); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScrollBarFadeDuration7833; 
		public static int getScrollBarFadeDuration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getScrollBarFadeDuration7833); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScrollDefaultDelay7834; 
		public static int getScrollDefaultDelay() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getScrollDefaultDelay7834); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFadingEdgeLength7835; 
		public static int getFadingEdgeLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getFadingEdgeLength7835); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledFadingEdgeLength7836; 
		public virtual int getScaledFadingEdgeLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledFadingEdgeLength7836); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledFadingEdgeLength7836); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPressedStateDuration7837; 
		public static int getPressedStateDuration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getPressedStateDuration7837); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLongPressTimeout7838; 
		public static int getLongPressTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getLongPressTimeout7838); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTapTimeout7839; 
		public static int getTapTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getTapTimeout7839); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getJumpTapTimeout7840; 
		public static int getJumpTapTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getJumpTapTimeout7840); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDoubleTapTimeout7841; 
		public static int getDoubleTapTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getDoubleTapTimeout7841); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEdgeSlop7842; 
		public static int getEdgeSlop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getEdgeSlop7842); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledEdgeSlop7843; 
		public virtual int getScaledEdgeSlop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledEdgeSlop7843); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledEdgeSlop7843); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTouchSlop7844; 
		public static int getTouchSlop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getTouchSlop7844); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledTouchSlop7845; 
		public virtual int getScaledTouchSlop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledTouchSlop7845); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledTouchSlop7845); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledDoubleTapSlop7846; 
		public virtual int getScaledDoubleTapSlop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledDoubleTapSlop7846); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledDoubleTapSlop7846); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindowTouchSlop7847; 
		public static int getWindowTouchSlop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getWindowTouchSlop7847); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledWindowTouchSlop7848; 
		public virtual int getScaledWindowTouchSlop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledWindowTouchSlop7848); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledWindowTouchSlop7848); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumFlingVelocity7849; 
		public static int getMinimumFlingVelocity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getMinimumFlingVelocity7849); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledMinimumFlingVelocity7850; 
		public virtual int getScaledMinimumFlingVelocity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledMinimumFlingVelocity7850); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledMinimumFlingVelocity7850); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumFlingVelocity7851; 
		public static int getMaximumFlingVelocity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getMaximumFlingVelocity7851); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledMaximumFlingVelocity7852; 
		public virtual int getScaledMaximumFlingVelocity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledMaximumFlingVelocity7852); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledMaximumFlingVelocity7852); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumDrawingCacheSize7853; 
		public static int getMaximumDrawingCacheSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, _getMaximumDrawingCacheSize7853); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledMaximumDrawingCacheSize7854; 
		public virtual int getScaledMaximumDrawingCacheSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewConfiguration)) 
				return @__env.CallIntMethod(this, _getScaledMaximumDrawingCacheSize7854); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewConfiguration.staticClass, _getScaledMaximumDrawingCacheSize7854); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getZoomControlsTimeout7855; 
		public static long getZoomControlsTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, _getZoomControlsTimeout7855); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalActionKeyTimeout7856; 
		public static long getGlobalActionKeyTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, _getGlobalActionKeyTimeout7856); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScrollFriction7857; 
		public static float getScrollFriction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticFloatMethod(android.view.ViewConfiguration.staticClass, _getScrollFriction7857); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewConfiguration7858; 
		public ViewConfiguration()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.ViewConfiguration.staticClass, _ViewConfiguration7858, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.ViewConfiguration.staticClass = @__class; 
			global::android.view.ViewConfiguration._get7830 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "get", "(Landroid/content/Context;)Landroid/view/ViewConfiguration;"); 
			global::android.view.ViewConfiguration._getScrollBarSize7831 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getScrollBarSize", "()I"); 
			global::android.view.ViewConfiguration._getScaledScrollBarSize7832 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledScrollBarSize", "()I"); 
			global::android.view.ViewConfiguration._getScrollBarFadeDuration7833 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getScrollBarFadeDuration", "()I"); 
			global::android.view.ViewConfiguration._getScrollDefaultDelay7834 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getScrollDefaultDelay", "()I"); 
			global::android.view.ViewConfiguration._getFadingEdgeLength7835 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getFadingEdgeLength", "()I"); 
			global::android.view.ViewConfiguration._getScaledFadingEdgeLength7836 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledFadingEdgeLength", "()I"); 
			global::android.view.ViewConfiguration._getPressedStateDuration7837 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getPressedStateDuration", "()I"); 
			global::android.view.ViewConfiguration._getLongPressTimeout7838 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getLongPressTimeout", "()I"); 
			global::android.view.ViewConfiguration._getTapTimeout7839 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getTapTimeout", "()I"); 
			global::android.view.ViewConfiguration._getJumpTapTimeout7840 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getJumpTapTimeout", "()I"); 
			global::android.view.ViewConfiguration._getDoubleTapTimeout7841 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getDoubleTapTimeout", "()I"); 
			global::android.view.ViewConfiguration._getEdgeSlop7842 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getEdgeSlop", "()I"); 
			global::android.view.ViewConfiguration._getScaledEdgeSlop7843 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledEdgeSlop", "()I"); 
			global::android.view.ViewConfiguration._getTouchSlop7844 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getTouchSlop", "()I"); 
			global::android.view.ViewConfiguration._getScaledTouchSlop7845 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledTouchSlop", "()I"); 
			global::android.view.ViewConfiguration._getScaledDoubleTapSlop7846 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledDoubleTapSlop", "()I"); 
			global::android.view.ViewConfiguration._getWindowTouchSlop7847 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getWindowTouchSlop", "()I"); 
			global::android.view.ViewConfiguration._getScaledWindowTouchSlop7848 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledWindowTouchSlop", "()I"); 
			global::android.view.ViewConfiguration._getMinimumFlingVelocity7849 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getMinimumFlingVelocity", "()I"); 
			global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity7850 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledMinimumFlingVelocity", "()I"); 
			global::android.view.ViewConfiguration._getMaximumFlingVelocity7851 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getMaximumFlingVelocity", "()I"); 
			global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity7852 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledMaximumFlingVelocity", "()I"); 
			global::android.view.ViewConfiguration._getMaximumDrawingCacheSize7853 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getMaximumDrawingCacheSize", "()I"); 
			global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize7854 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledMaximumDrawingCacheSize", "()I"); 
			global::android.view.ViewConfiguration._getZoomControlsTimeout7855 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getZoomControlsTimeout", "()J"); 
			global::android.view.ViewConfiguration._getGlobalActionKeyTimeout7856 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getGlobalActionKeyTimeout", "()J"); 
			global::android.view.ViewConfiguration._getScrollFriction7857 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getScrollFriction", "()F"); 
			global::android.view.ViewConfiguration._ViewConfiguration7858 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "<init>", "()V"); 
		} 
	} 
} 
