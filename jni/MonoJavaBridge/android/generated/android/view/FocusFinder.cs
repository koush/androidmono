namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FocusFinder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FocusFinder()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getInstance14023;
		public static global::android.view.FocusFinder getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.FocusFinder.staticClass, global::android.view.FocusFinder._getInstance14023)) as android.view.FocusFinder;
		}
		internal static global::MonoJavaBridge.MethodId _findNextFocus14024;
		public virtual global::android.view.View findNextFocus(android.view.ViewGroup arg0, android.view.View arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.FocusFinder._findNextFocus14024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.FocusFinder.staticClass, global::android.view.FocusFinder._findNextFocus14024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _findNextFocusFromRect14025;
		public virtual global::android.view.View findNextFocusFromRect(android.view.ViewGroup arg0, android.graphics.Rect arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.FocusFinder._findNextFocusFromRect14025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.FocusFinder.staticClass, global::android.view.FocusFinder._findNextFocusFromRect14025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _findNearestTouchable14026;
		public virtual global::android.view.View findNearestTouchable(android.view.ViewGroup arg0, int arg1, int arg2, int arg3, int[] arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.FocusFinder._findNearestTouchable14026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.FocusFinder.staticClass, global::android.view.FocusFinder._findNearestTouchable14026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.view.View;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.FocusFinder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/FocusFinder"));
			global::android.view.FocusFinder._getInstance14023 = @__env.GetStaticMethodIDNoThrow(global::android.view.FocusFinder.staticClass, "getInstance", "()Landroid/view/FocusFinder;");
			global::android.view.FocusFinder._findNextFocus14024 = @__env.GetMethodIDNoThrow(global::android.view.FocusFinder.staticClass, "findNextFocus", "(Landroid/view/ViewGroup;Landroid/view/View;I)Landroid/view/View;");
			global::android.view.FocusFinder._findNextFocusFromRect14025 = @__env.GetMethodIDNoThrow(global::android.view.FocusFinder.staticClass, "findNextFocusFromRect", "(Landroid/view/ViewGroup;Landroid/graphics/Rect;I)Landroid/view/View;");
			global::android.view.FocusFinder._findNearestTouchable14026 = @__env.GetMethodIDNoThrow(global::android.view.FocusFinder.staticClass, "findNearestTouchable", "(Landroid/view/ViewGroup;III[I)Landroid/view/View;");
		}
	}
}
