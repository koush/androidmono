namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TouchUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TouchUtils()
		{
			InitJNI();
		}
		protected TouchUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _dragQuarterScreenDown12267;
		public static void dragQuarterScreenDown(android.test.ActivityInstrumentationTestCase arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragQuarterScreenDown12267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dragQuarterScreenDown12268;
		public static void dragQuarterScreenDown(android.test.InstrumentationTestCase arg0, android.app.Activity arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragQuarterScreenDown12268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dragQuarterScreenUp12269;
		public static void dragQuarterScreenUp(android.test.ActivityInstrumentationTestCase arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragQuarterScreenUp12269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dragQuarterScreenUp12270;
		public static void dragQuarterScreenUp(android.test.InstrumentationTestCase arg0, android.app.Activity arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragQuarterScreenUp12270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scrollToBottom12271;
		public static void scrollToBottom(android.test.ActivityInstrumentationTestCase arg0, android.view.ViewGroup arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._scrollToBottom12271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scrollToBottom12272;
		public static void scrollToBottom(android.test.InstrumentationTestCase arg0, android.app.Activity arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._scrollToBottom12272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _scrollToTop12273;
		public static void scrollToTop(android.test.InstrumentationTestCase arg0, android.app.Activity arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._scrollToTop12273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _scrollToTop12274;
		public static void scrollToTop(android.test.ActivityInstrumentationTestCase arg0, android.view.ViewGroup arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._scrollToTop12274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToBottom12275;
		public static void dragViewToBottom(android.test.InstrumentationTestCase arg0, android.app.Activity arg1, android.view.View arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToBottom12275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToBottom12276;
		public static void dragViewToBottom(android.test.InstrumentationTestCase arg0, android.app.Activity arg1, android.view.View arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToBottom12276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToBottom12277;
		public static void dragViewToBottom(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToBottom12277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToBottom12278;
		public static void dragViewToBottom(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToBottom12278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tapView12279;
		public static void tapView(android.test.InstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._tapView12279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _touchAndCancelView12280;
		public static void touchAndCancelView(android.test.InstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._touchAndCancelView12280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clickView12281;
		public static void clickView(android.test.InstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._clickView12281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _longClickView12282;
		public static void longClickView(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._longClickView12282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _longClickView12283;
		public static void longClickView(android.test.InstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._longClickView12283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToTop12284;
		public static void dragViewToTop(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToTop12284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToTop12285;
		public static void dragViewToTop(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToTop12285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToTop12286;
		public static void dragViewToTop(android.test.InstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToTop12286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToTop12287;
		public static void dragViewToTop(android.test.InstrumentationTestCase arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToTop12287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewBy12288;
		public static int dragViewBy(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewBy12288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewBy12289;
		public static int dragViewBy(android.test.InstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewBy12289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewTo12290;
		public static int dragViewTo(android.test.InstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewTo12290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewTo12291;
		public static int dragViewTo(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewTo12291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToX12292;
		public static int dragViewToX(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToX12292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToX12293;
		public static int dragViewToX(android.test.InstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToX12293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToY12294;
		public static int dragViewToY(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToY12294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToY12295;
		public static int dragViewToY(android.test.InstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToY12295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drag12296;
		public static void drag(android.test.ActivityInstrumentationTestCase arg0, float arg1, float arg2, float arg3, float arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._drag12296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _drag12297;
		public static void drag(android.test.InstrumentationTestCase arg0, float arg1, float arg2, float arg3, float arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._drag12297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _TouchUtils12298;
		public TouchUtils()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._TouchUtils12298);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.TouchUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/TouchUtils"));
			global::android.test.TouchUtils._dragQuarterScreenDown12267 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragQuarterScreenDown", "(Landroid/test/ActivityInstrumentationTestCase;)V");
			global::android.test.TouchUtils._dragQuarterScreenDown12268 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragQuarterScreenDown", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;)V");
			global::android.test.TouchUtils._dragQuarterScreenUp12269 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragQuarterScreenUp", "(Landroid/test/ActivityInstrumentationTestCase;)V");
			global::android.test.TouchUtils._dragQuarterScreenUp12270 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragQuarterScreenUp", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;)V");
			global::android.test.TouchUtils._scrollToBottom12271 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "scrollToBottom", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/ViewGroup;)V");
			global::android.test.TouchUtils._scrollToBottom12272 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "scrollToBottom", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/ViewGroup;)V");
			global::android.test.TouchUtils._scrollToTop12273 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "scrollToTop", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/ViewGroup;)V");
			global::android.test.TouchUtils._scrollToTop12274 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "scrollToTop", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/ViewGroup;)V");
			global::android.test.TouchUtils._dragViewToBottom12275 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToBottom", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/View;I)V");
			global::android.test.TouchUtils._dragViewToBottom12276 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToBottom", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/View;)V");
			global::android.test.TouchUtils._dragViewToBottom12277 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToBottom", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;I)V");
			global::android.test.TouchUtils._dragViewToBottom12278 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToBottom", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._tapView12279 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "tapView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._touchAndCancelView12280 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "touchAndCancelView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._clickView12281 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "clickView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._longClickView12282 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "longClickView", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._longClickView12283 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "longClickView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._dragViewToTop12284 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToTop", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;I)V");
			global::android.test.TouchUtils._dragViewToTop12285 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToTop", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._dragViewToTop12286 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToTop", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._dragViewToTop12287 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToTop", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;I)V");
			global::android.test.TouchUtils._dragViewBy12288 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewBy", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;III)I");
			global::android.test.TouchUtils._dragViewBy12289 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewBy", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;III)I");
			global::android.test.TouchUtils._dragViewTo12290 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewTo", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;III)I");
			global::android.test.TouchUtils._dragViewTo12291 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewTo", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;III)I");
			global::android.test.TouchUtils._dragViewToX12292 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToX", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;II)I");
			global::android.test.TouchUtils._dragViewToX12293 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToX", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;II)I");
			global::android.test.TouchUtils._dragViewToY12294 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToY", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;II)I");
			global::android.test.TouchUtils._dragViewToY12295 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToY", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;II)I");
			global::android.test.TouchUtils._drag12296 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "drag", "(Landroid/test/ActivityInstrumentationTestCase;FFFFI)V");
			global::android.test.TouchUtils._drag12297 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "drag", "(Landroid/test/InstrumentationTestCase;FFFFI)V");
			global::android.test.TouchUtils._TouchUtils12298 = @__env.GetMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "<init>", "()V");
		}
	}
}
