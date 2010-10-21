namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TouchDelegate : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TouchDelegate()
		{
			InitJNI();
		}
		protected TouchDelegate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent14534;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.TouchDelegate._onTouchEvent14534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.TouchDelegate.staticClass, global::android.view.TouchDelegate._onTouchEvent14534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TouchDelegate14535;
		public TouchDelegate(android.graphics.Rect arg0, android.view.View arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.TouchDelegate.staticClass, global::android.view.TouchDelegate._TouchDelegate14535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.TouchDelegate.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/TouchDelegate"));
			global::android.view.TouchDelegate._onTouchEvent14534 = @__env.GetMethodIDNoThrow(global::android.view.TouchDelegate.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.TouchDelegate._TouchDelegate14535 = @__env.GetMethodIDNoThrow(global::android.view.TouchDelegate.staticClass, "<init>", "(Landroid/graphics/Rect;Landroid/view/View;)V");
		}
	}
}
