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
		internal static global::MonoJavaBridge.MethodId _assertOnScreen12361;
		public static void assertOnScreen(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertOnScreen12361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertOffScreenBelow12362;
		public static void assertOffScreenBelow(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertOffScreenBelow12362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertOffScreenAbove12363;
		public static void assertOffScreenAbove(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertOffScreenAbove12363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertHasScreenCoordinates12364;
		public static void assertHasScreenCoordinates(android.view.View arg0, android.view.View arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertHasScreenCoordinates12364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _assertBaselineAligned12365;
		public static void assertBaselineAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertBaselineAligned12365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertRightAligned12366;
		public static void assertRightAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertRightAligned12366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertRightAligned12367;
		public static void assertRightAligned(android.view.View arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertRightAligned12367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertLeftAligned12368;
		public static void assertLeftAligned(android.view.View arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertLeftAligned12368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertLeftAligned12369;
		public static void assertLeftAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertLeftAligned12369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertBottomAligned12370;
		public static void assertBottomAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertBottomAligned12370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertBottomAligned12371;
		public static void assertBottomAligned(android.view.View arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertBottomAligned12371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertTopAligned12372;
		public static void assertTopAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertTopAligned12372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertTopAligned12373;
		public static void assertTopAligned(android.view.View arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertTopAligned12373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertHorizontalCenterAligned12374;
		public static void assertHorizontalCenterAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertHorizontalCenterAligned12374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertVerticalCenterAligned12375;
		public static void assertVerticalCenterAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertVerticalCenterAligned12375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertGroupIntegrity12376;
		public static void assertGroupIntegrity(android.view.ViewGroup arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertGroupIntegrity12376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertGroupContains12377;
		public static void assertGroupContains(android.view.ViewGroup arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertGroupContains12377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertGroupNotContains12378;
		public static void assertGroupNotContains(android.view.ViewGroup arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertGroupNotContains12378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ViewAsserts.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ViewAsserts"));
			global::android.test.ViewAsserts._assertOnScreen12361 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertOnScreen", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertOffScreenBelow12362 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertOffScreenBelow", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertOffScreenAbove12363 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertOffScreenAbove", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertHasScreenCoordinates12364 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertHasScreenCoordinates", "(Landroid/view/View;Landroid/view/View;II)V");
			global::android.test.ViewAsserts._assertBaselineAligned12365 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertBaselineAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertRightAligned12366 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertRightAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertRightAligned12367 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertRightAligned", "(Landroid/view/View;Landroid/view/View;I)V");
			global::android.test.ViewAsserts._assertLeftAligned12368 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertLeftAligned", "(Landroid/view/View;Landroid/view/View;I)V");
			global::android.test.ViewAsserts._assertLeftAligned12369 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertLeftAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertBottomAligned12370 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertBottomAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertBottomAligned12371 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertBottomAligned", "(Landroid/view/View;Landroid/view/View;I)V");
			global::android.test.ViewAsserts._assertTopAligned12372 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertTopAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertTopAligned12373 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertTopAligned", "(Landroid/view/View;Landroid/view/View;I)V");
			global::android.test.ViewAsserts._assertHorizontalCenterAligned12374 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertHorizontalCenterAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertVerticalCenterAligned12375 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertVerticalCenterAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertGroupIntegrity12376 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertGroupIntegrity", "(Landroid/view/ViewGroup;)V");
			global::android.test.ViewAsserts._assertGroupContains12377 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertGroupContains", "(Landroid/view/ViewGroup;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertGroupNotContains12378 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertGroupNotContains", "(Landroid/view/ViewGroup;Landroid/view/View;)V");
		}
	}
}
