namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FocusFinder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FocusFinder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.view.FocusFinder Instance
		{
			get
			{
				return getInstance();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.view.FocusFinder getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.FocusFinder._m0.native == global::System.IntPtr.Zero)
				global::android.view.FocusFinder._m0 = @__env.GetStaticMethodIDNoThrow(global::android.view.FocusFinder.staticClass, "getInstance", "()Landroid/view/FocusFinder;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.FocusFinder.staticClass, global::android.view.FocusFinder._m0)) as android.view.FocusFinder;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.view.View findNextFocus(android.view.ViewGroup arg0, android.view.View arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.FocusFinder.staticClass, "findNextFocus", "(Landroid/view/ViewGroup;Landroid/view/View;I)Landroid/view/View;", ref global::android.view.FocusFinder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.view.View findNextFocusFromRect(android.view.ViewGroup arg0, android.graphics.Rect arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.FocusFinder.staticClass, "findNextFocusFromRect", "(Landroid/view/ViewGroup;Landroid/graphics/Rect;I)Landroid/view/View;", ref global::android.view.FocusFinder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.view.View findNearestTouchable(android.view.ViewGroup arg0, int arg1, int arg2, int arg3, int[] arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.FocusFinder.staticClass, "findNearestTouchable", "(Landroid/view/ViewGroup;III[I)Landroid/view/View;", ref global::android.view.FocusFinder._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as android.view.View;
		}
		static FocusFinder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.FocusFinder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/FocusFinder"));
		}
		internal static void InitJNI()
		{
		}
	}
}
