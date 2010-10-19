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
		internal static global::MonoJavaBridge.MethodId _dragQuarterScreenDown7789;
		public static void dragQuarterScreenDown(android.test.ActivityInstrumentationTestCase arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragQuarterScreenDown7789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dragQuarterScreenDown7790;
		public static void dragQuarterScreenDown(android.test.InstrumentationTestCase arg0, android.app.Activity arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragQuarterScreenDown7790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dragQuarterScreenUp7791;
		public static void dragQuarterScreenUp(android.test.ActivityInstrumentationTestCase arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragQuarterScreenUp7791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dragQuarterScreenUp7792;
		public static void dragQuarterScreenUp(android.test.InstrumentationTestCase arg0, android.app.Activity arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragQuarterScreenUp7792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scrollToBottom7793;
		public static void scrollToBottom(android.test.ActivityInstrumentationTestCase arg0, android.view.ViewGroup arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._scrollToBottom7793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scrollToBottom7794;
		public static void scrollToBottom(android.test.InstrumentationTestCase arg0, android.app.Activity arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._scrollToBottom7794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _scrollToTop7795;
		public static void scrollToTop(android.test.InstrumentationTestCase arg0, android.app.Activity arg1, android.view.ViewGroup arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._scrollToTop7795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _scrollToTop7796;
		public static void scrollToTop(android.test.ActivityInstrumentationTestCase arg0, android.view.ViewGroup arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._scrollToTop7796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToBottom7797;
		public static void dragViewToBottom(android.test.InstrumentationTestCase arg0, android.app.Activity arg1, android.view.View arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToBottom7797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToBottom7798;
		public static void dragViewToBottom(android.test.InstrumentationTestCase arg0, android.app.Activity arg1, android.view.View arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToBottom7798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToBottom7799;
		public static void dragViewToBottom(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToBottom7799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToBottom7800;
		public static void dragViewToBottom(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToBottom7800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tapView7801;
		public static void tapView(android.test.InstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._tapView7801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _touchAndCancelView7802;
		public static void touchAndCancelView(android.test.InstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._touchAndCancelView7802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clickView7803;
		public static void clickView(android.test.InstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._clickView7803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _longClickView7804;
		public static void longClickView(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._longClickView7804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _longClickView7805;
		public static void longClickView(android.test.InstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._longClickView7805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToTop7806;
		public static void dragViewToTop(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToTop7806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToTop7807;
		public static void dragViewToTop(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToTop7807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToTop7808;
		public static void dragViewToTop(android.test.InstrumentationTestCase arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToTop7808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToTop7809;
		public static void dragViewToTop(android.test.InstrumentationTestCase arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToTop7809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewBy7810;
		public static int dragViewBy(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewBy7810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewBy7811;
		public static int dragViewBy(android.test.InstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewBy7811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewTo7812;
		public static int dragViewTo(android.test.InstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewTo7812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewTo7813;
		public static int dragViewTo(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewTo7813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToX7814;
		public static int dragViewToX(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToX7814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToX7815;
		public static int dragViewToX(android.test.InstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToX7815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToY7816;
		public static int dragViewToY(android.test.ActivityInstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToY7816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _dragViewToY7817;
		public static int dragViewToY(android.test.InstrumentationTestCase arg0, android.view.View arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._dragViewToY7817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _drag7818;
		public static void drag(android.test.ActivityInstrumentationTestCase arg0, float arg1, float arg2, float arg3, float arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._drag7818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _drag7819;
		public static void drag(android.test.InstrumentationTestCase arg0, float arg1, float arg2, float arg3, float arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._drag7819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _TouchUtils7820;
		public TouchUtils()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.TouchUtils.staticClass, global::android.test.TouchUtils._TouchUtils7820);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.TouchUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/TouchUtils"));
			global::android.test.TouchUtils._dragQuarterScreenDown7789 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragQuarterScreenDown", "(Landroid/test/ActivityInstrumentationTestCase;)V");
			global::android.test.TouchUtils._dragQuarterScreenDown7790 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragQuarterScreenDown", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;)V");
			global::android.test.TouchUtils._dragQuarterScreenUp7791 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragQuarterScreenUp", "(Landroid/test/ActivityInstrumentationTestCase;)V");
			global::android.test.TouchUtils._dragQuarterScreenUp7792 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragQuarterScreenUp", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;)V");
			global::android.test.TouchUtils._scrollToBottom7793 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "scrollToBottom", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/ViewGroup;)V");
			global::android.test.TouchUtils._scrollToBottom7794 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "scrollToBottom", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/ViewGroup;)V");
			global::android.test.TouchUtils._scrollToTop7795 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "scrollToTop", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/ViewGroup;)V");
			global::android.test.TouchUtils._scrollToTop7796 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "scrollToTop", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/ViewGroup;)V");
			global::android.test.TouchUtils._dragViewToBottom7797 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToBottom", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/View;I)V");
			global::android.test.TouchUtils._dragViewToBottom7798 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToBottom", "(Landroid/test/InstrumentationTestCase;Landroid/app/Activity;Landroid/view/View;)V");
			global::android.test.TouchUtils._dragViewToBottom7799 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToBottom", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;I)V");
			global::android.test.TouchUtils._dragViewToBottom7800 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToBottom", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._tapView7801 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "tapView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._touchAndCancelView7802 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "touchAndCancelView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._clickView7803 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "clickView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._longClickView7804 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "longClickView", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._longClickView7805 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "longClickView", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._dragViewToTop7806 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToTop", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;I)V");
			global::android.test.TouchUtils._dragViewToTop7807 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToTop", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._dragViewToTop7808 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToTop", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;)V");
			global::android.test.TouchUtils._dragViewToTop7809 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToTop", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;I)V");
			global::android.test.TouchUtils._dragViewBy7810 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewBy", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;III)I");
			global::android.test.TouchUtils._dragViewBy7811 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewBy", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;III)I");
			global::android.test.TouchUtils._dragViewTo7812 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewTo", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;III)I");
			global::android.test.TouchUtils._dragViewTo7813 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewTo", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;III)I");
			global::android.test.TouchUtils._dragViewToX7814 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToX", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;II)I");
			global::android.test.TouchUtils._dragViewToX7815 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToX", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;II)I");
			global::android.test.TouchUtils._dragViewToY7816 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToY", "(Landroid/test/ActivityInstrumentationTestCase;Landroid/view/View;II)I");
			global::android.test.TouchUtils._dragViewToY7817 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "dragViewToY", "(Landroid/test/InstrumentationTestCase;Landroid/view/View;II)I");
			global::android.test.TouchUtils._drag7818 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "drag", "(Landroid/test/ActivityInstrumentationTestCase;FFFFI)V");
			global::android.test.TouchUtils._drag7819 = @__env.GetStaticMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "drag", "(Landroid/test/InstrumentationTestCase;FFFFI)V");
			global::android.test.TouchUtils._TouchUtils7820 = @__env.GetMethodIDNoThrow(global::android.test.TouchUtils.staticClass, "<init>", "()V");
		}
	}
}
