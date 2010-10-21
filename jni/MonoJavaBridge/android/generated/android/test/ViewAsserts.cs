namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ViewAsserts : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ViewAsserts()
		{
			InitJNI();
		}
		protected ViewAsserts(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _assertOnScreen12303;
		public static void assertOnScreen(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertOnScreen12303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertOffScreenBelow12304;
		public static void assertOffScreenBelow(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertOffScreenBelow12304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertOffScreenAbove12305;
		public static void assertOffScreenAbove(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertOffScreenAbove12305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertHasScreenCoordinates12306;
		public static void assertHasScreenCoordinates(android.view.View arg0, android.view.View arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertHasScreenCoordinates12306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _assertBaselineAligned12307;
		public static void assertBaselineAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertBaselineAligned12307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertRightAligned12308;
		public static void assertRightAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertRightAligned12308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertRightAligned12309;
		public static void assertRightAligned(android.view.View arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertRightAligned12309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertLeftAligned12310;
		public static void assertLeftAligned(android.view.View arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertLeftAligned12310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertLeftAligned12311;
		public static void assertLeftAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertLeftAligned12311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertBottomAligned12312;
		public static void assertBottomAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertBottomAligned12312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertBottomAligned12313;
		public static void assertBottomAligned(android.view.View arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertBottomAligned12313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertTopAligned12314;
		public static void assertTopAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertTopAligned12314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertTopAligned12315;
		public static void assertTopAligned(android.view.View arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertTopAligned12315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertHorizontalCenterAligned12316;
		public static void assertHorizontalCenterAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertHorizontalCenterAligned12316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertVerticalCenterAligned12317;
		public static void assertVerticalCenterAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertVerticalCenterAligned12317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertGroupIntegrity12318;
		public static void assertGroupIntegrity(android.view.ViewGroup arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertGroupIntegrity12318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertGroupContains12319;
		public static void assertGroupContains(android.view.ViewGroup arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertGroupContains12319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertGroupNotContains12320;
		public static void assertGroupNotContains(android.view.ViewGroup arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertGroupNotContains12320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ViewAsserts.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ViewAsserts"));
			global::android.test.ViewAsserts._assertOnScreen12303 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertOnScreen", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertOffScreenBelow12304 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertOffScreenBelow", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertOffScreenAbove12305 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertOffScreenAbove", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertHasScreenCoordinates12306 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertHasScreenCoordinates", "(Landroid/view/View;Landroid/view/View;II)V");
			global::android.test.ViewAsserts._assertBaselineAligned12307 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertBaselineAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertRightAligned12308 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertRightAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertRightAligned12309 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertRightAligned", "(Landroid/view/View;Landroid/view/View;I)V");
			global::android.test.ViewAsserts._assertLeftAligned12310 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertLeftAligned", "(Landroid/view/View;Landroid/view/View;I)V");
			global::android.test.ViewAsserts._assertLeftAligned12311 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertLeftAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertBottomAligned12312 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertBottomAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertBottomAligned12313 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertBottomAligned", "(Landroid/view/View;Landroid/view/View;I)V");
			global::android.test.ViewAsserts._assertTopAligned12314 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertTopAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertTopAligned12315 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertTopAligned", "(Landroid/view/View;Landroid/view/View;I)V");
			global::android.test.ViewAsserts._assertHorizontalCenterAligned12316 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertHorizontalCenterAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertVerticalCenterAligned12317 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertVerticalCenterAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertGroupIntegrity12318 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertGroupIntegrity", "(Landroid/view/ViewGroup;)V");
			global::android.test.ViewAsserts._assertGroupContains12319 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertGroupContains", "(Landroid/view/ViewGroup;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertGroupNotContains12320 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertGroupNotContains", "(Landroid/view/ViewGroup;Landroid/view/View;)V");
		}
	}
}
