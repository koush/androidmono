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
		internal static global::MonoJavaBridge.MethodId _assertOnScreen7825;
		public static void assertOnScreen(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertOnScreen7825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertOffScreenBelow7826;
		public static void assertOffScreenBelow(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertOffScreenBelow7826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertOffScreenAbove7827;
		public static void assertOffScreenAbove(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertOffScreenAbove7827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertHasScreenCoordinates7828;
		public static void assertHasScreenCoordinates(android.view.View arg0, android.view.View arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertHasScreenCoordinates7828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _assertBaselineAligned7829;
		public static void assertBaselineAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertBaselineAligned7829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertRightAligned7830;
		public static void assertRightAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertRightAligned7830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertRightAligned7831;
		public static void assertRightAligned(android.view.View arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertRightAligned7831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertLeftAligned7832;
		public static void assertLeftAligned(android.view.View arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertLeftAligned7832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertLeftAligned7833;
		public static void assertLeftAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertLeftAligned7833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertBottomAligned7834;
		public static void assertBottomAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertBottomAligned7834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertBottomAligned7835;
		public static void assertBottomAligned(android.view.View arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertBottomAligned7835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertTopAligned7836;
		public static void assertTopAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertTopAligned7836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertTopAligned7837;
		public static void assertTopAligned(android.view.View arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertTopAligned7837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertHorizontalCenterAligned7838;
		public static void assertHorizontalCenterAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertHorizontalCenterAligned7838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertVerticalCenterAligned7839;
		public static void assertVerticalCenterAligned(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertVerticalCenterAligned7839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertGroupIntegrity7840;
		public static void assertGroupIntegrity(android.view.ViewGroup arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertGroupIntegrity7840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertGroupContains7841;
		public static void assertGroupContains(android.view.ViewGroup arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertGroupContains7841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertGroupNotContains7842;
		public static void assertGroupNotContains(android.view.ViewGroup arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.test.ViewAsserts.staticClass, global::android.test.ViewAsserts._assertGroupNotContains7842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ViewAsserts.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ViewAsserts"));
			global::android.test.ViewAsserts._assertOnScreen7825 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertOnScreen", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertOffScreenBelow7826 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertOffScreenBelow", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertOffScreenAbove7827 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertOffScreenAbove", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertHasScreenCoordinates7828 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertHasScreenCoordinates", "(Landroid/view/View;Landroid/view/View;II)V");
			global::android.test.ViewAsserts._assertBaselineAligned7829 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertBaselineAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertRightAligned7830 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertRightAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertRightAligned7831 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertRightAligned", "(Landroid/view/View;Landroid/view/View;I)V");
			global::android.test.ViewAsserts._assertLeftAligned7832 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertLeftAligned", "(Landroid/view/View;Landroid/view/View;I)V");
			global::android.test.ViewAsserts._assertLeftAligned7833 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertLeftAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertBottomAligned7834 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertBottomAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertBottomAligned7835 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertBottomAligned", "(Landroid/view/View;Landroid/view/View;I)V");
			global::android.test.ViewAsserts._assertTopAligned7836 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertTopAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertTopAligned7837 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertTopAligned", "(Landroid/view/View;Landroid/view/View;I)V");
			global::android.test.ViewAsserts._assertHorizontalCenterAligned7838 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertHorizontalCenterAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertVerticalCenterAligned7839 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertVerticalCenterAligned", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertGroupIntegrity7840 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertGroupIntegrity", "(Landroid/view/ViewGroup;)V");
			global::android.test.ViewAsserts._assertGroupContains7841 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertGroupContains", "(Landroid/view/ViewGroup;Landroid/view/View;)V");
			global::android.test.ViewAsserts._assertGroupNotContains7842 = @__env.GetStaticMethodIDNoThrow(global::android.test.ViewAsserts.staticClass, "assertGroupNotContains", "(Landroid/view/ViewGroup;Landroid/view/View;)V");
		}
	}
}
