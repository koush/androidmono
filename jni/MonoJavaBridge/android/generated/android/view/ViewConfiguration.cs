namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ViewConfiguration : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ViewConfiguration()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewConfiguration), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _get9090;
		public static global::android.view.ViewConfiguration get(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewConfiguration>(@__env, @__env.CallStaticObjectMethodPtr(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._get9090, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScrollBarSize9091;
		public static int getScrollBarSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollBarSize9091);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledScrollBarSize9092;
		public virtual int getScaledScrollBarSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewConfiguration._getScaledScrollBarSize9092);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledScrollBarSize9092);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScrollBarFadeDuration9093;
		public static int getScrollBarFadeDuration() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollBarFadeDuration9093);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScrollDefaultDelay9094;
		public static int getScrollDefaultDelay() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollDefaultDelay9094);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFadingEdgeLength9095;
		public static int getFadingEdgeLength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getFadingEdgeLength9095);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledFadingEdgeLength9096;
		public virtual int getScaledFadingEdgeLength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewConfiguration._getScaledFadingEdgeLength9096);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledFadingEdgeLength9096);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPressedStateDuration9097;
		public static int getPressedStateDuration() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getPressedStateDuration9097);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLongPressTimeout9098;
		public static int getLongPressTimeout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getLongPressTimeout9098);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTapTimeout9099;
		public static int getTapTimeout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getTapTimeout9099);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getJumpTapTimeout9100;
		public static int getJumpTapTimeout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getJumpTapTimeout9100);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDoubleTapTimeout9101;
		public static int getDoubleTapTimeout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getDoubleTapTimeout9101);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEdgeSlop9102;
		public static int getEdgeSlop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getEdgeSlop9102);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledEdgeSlop9103;
		public virtual int getScaledEdgeSlop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewConfiguration._getScaledEdgeSlop9103);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledEdgeSlop9103);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTouchSlop9104;
		public static int getTouchSlop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getTouchSlop9104);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledTouchSlop9105;
		public virtual int getScaledTouchSlop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewConfiguration._getScaledTouchSlop9105);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledTouchSlop9105);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledPagingTouchSlop9106;
		public virtual int getScaledPagingTouchSlop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewConfiguration._getScaledPagingTouchSlop9106);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledPagingTouchSlop9106);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledDoubleTapSlop9107;
		public virtual int getScaledDoubleTapSlop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewConfiguration._getScaledDoubleTapSlop9107);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledDoubleTapSlop9107);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWindowTouchSlop9108;
		public static int getWindowTouchSlop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getWindowTouchSlop9108);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledWindowTouchSlop9109;
		public virtual int getScaledWindowTouchSlop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewConfiguration._getScaledWindowTouchSlop9109);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledWindowTouchSlop9109);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumFlingVelocity9110;
		public static int getMinimumFlingVelocity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getMinimumFlingVelocity9110);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledMinimumFlingVelocity9111;
		public virtual int getScaledMinimumFlingVelocity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity9111);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity9111);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumFlingVelocity9112;
		public static int getMaximumFlingVelocity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getMaximumFlingVelocity9112);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledMaximumFlingVelocity9113;
		public virtual int getScaledMaximumFlingVelocity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity9113);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity9113);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumDrawingCacheSize9114;
		public static int getMaximumDrawingCacheSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getMaximumDrawingCacheSize9114);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledMaximumDrawingCacheSize9115;
		public virtual int getScaledMaximumDrawingCacheSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize9115);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize9115);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getZoomControlsTimeout9116;
		public static long getZoomControlsTimeout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getZoomControlsTimeout9116);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalActionKeyTimeout9117;
		public static long getGlobalActionKeyTimeout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getGlobalActionKeyTimeout9117);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScrollFriction9118;
		public static float getScrollFriction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._getScrollFriction9118);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewConfiguration9119;
		public ViewConfiguration()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.ViewConfiguration.staticClass, global::android.view.ViewConfiguration._ViewConfiguration9119, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.ViewConfiguration.staticClass = @__class;
			global::android.view.ViewConfiguration._get9090 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "get", "(Landroid/content/Context;)Landroid/view/ViewConfiguration;");
			global::android.view.ViewConfiguration._getScrollBarSize9091 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getScrollBarSize", "()I");
			global::android.view.ViewConfiguration._getScaledScrollBarSize9092 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledScrollBarSize", "()I");
			global::android.view.ViewConfiguration._getScrollBarFadeDuration9093 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getScrollBarFadeDuration", "()I");
			global::android.view.ViewConfiguration._getScrollDefaultDelay9094 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getScrollDefaultDelay", "()I");
			global::android.view.ViewConfiguration._getFadingEdgeLength9095 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getFadingEdgeLength", "()I");
			global::android.view.ViewConfiguration._getScaledFadingEdgeLength9096 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledFadingEdgeLength", "()I");
			global::android.view.ViewConfiguration._getPressedStateDuration9097 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getPressedStateDuration", "()I");
			global::android.view.ViewConfiguration._getLongPressTimeout9098 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getLongPressTimeout", "()I");
			global::android.view.ViewConfiguration._getTapTimeout9099 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getTapTimeout", "()I");
			global::android.view.ViewConfiguration._getJumpTapTimeout9100 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getJumpTapTimeout", "()I");
			global::android.view.ViewConfiguration._getDoubleTapTimeout9101 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getDoubleTapTimeout", "()I");
			global::android.view.ViewConfiguration._getEdgeSlop9102 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getEdgeSlop", "()I");
			global::android.view.ViewConfiguration._getScaledEdgeSlop9103 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledEdgeSlop", "()I");
			global::android.view.ViewConfiguration._getTouchSlop9104 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledTouchSlop9105 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledPagingTouchSlop9106 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledPagingTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledDoubleTapSlop9107 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledDoubleTapSlop", "()I");
			global::android.view.ViewConfiguration._getWindowTouchSlop9108 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getWindowTouchSlop", "()I");
			global::android.view.ViewConfiguration._getScaledWindowTouchSlop9109 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledWindowTouchSlop", "()I");
			global::android.view.ViewConfiguration._getMinimumFlingVelocity9110 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getMinimumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getScaledMinimumFlingVelocity9111 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledMinimumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getMaximumFlingVelocity9112 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getMaximumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getScaledMaximumFlingVelocity9113 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledMaximumFlingVelocity", "()I");
			global::android.view.ViewConfiguration._getMaximumDrawingCacheSize9114 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getMaximumDrawingCacheSize", "()I");
			global::android.view.ViewConfiguration._getScaledMaximumDrawingCacheSize9115 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "getScaledMaximumDrawingCacheSize", "()I");
			global::android.view.ViewConfiguration._getZoomControlsTimeout9116 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getZoomControlsTimeout", "()J");
			global::android.view.ViewConfiguration._getGlobalActionKeyTimeout9117 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getGlobalActionKeyTimeout", "()J");
			global::android.view.ViewConfiguration._getScrollFriction9118 = @__env.GetStaticMethodID(global::android.view.ViewConfiguration.staticClass, "getScrollFriction", "()F");
			global::android.view.ViewConfiguration._ViewConfiguration9119 = @__env.GetMethodID(global::android.view.ViewConfiguration.staticClass, "<init>", "()V");
		}
	}
}
