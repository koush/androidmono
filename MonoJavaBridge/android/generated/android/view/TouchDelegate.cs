namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TouchDelegate : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TouchDelegate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent14602;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.TouchDelegate.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.TouchDelegate._onTouchEvent14602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TouchDelegate14603;
		public TouchDelegate(android.graphics.Rect arg0, android.view.View arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.TouchDelegate._TouchDelegate14603.native == global::System.IntPtr.Zero)
				global::android.view.TouchDelegate._TouchDelegate14603 = @__env.GetMethodIDNoThrow(global::android.view.TouchDelegate.staticClass, "<init>", "(Landroid/graphics/Rect;Landroid/view/View;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.TouchDelegate.staticClass, global::android.view.TouchDelegate._TouchDelegate14603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int ABOVE
		{
			get
			{
				return 1;
			}
		}
		public static int BELOW
		{
			get
			{
				return 2;
			}
		}
		public static int TO_LEFT
		{
			get
			{
				return 4;
			}
		}
		public static int TO_RIGHT
		{
			get
			{
				return 8;
			}
		}
		static TouchDelegate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.TouchDelegate.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/TouchDelegate"));
		}
		internal static void InitJNI()
		{
		}
	}
}
