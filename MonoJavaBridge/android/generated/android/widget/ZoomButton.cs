namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZoomButton : android.widget.ImageButton, android.view.View.OnLongClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ZoomButton(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new bool Enabled
		{
			set
			{
				setEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButton.staticClass, "setEnabled", "(Z)V", ref global::android.widget.ZoomButton._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ZoomButton.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.ZoomButton._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ZoomButton.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.widget.ZoomButton._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool dispatchUnhandledMove(android.view.View arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ZoomButton.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z", ref global::android.widget.ZoomButton._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool onLongClick(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ZoomButton.staticClass, "onLongClick", "(Landroid/view/View;)Z", ref global::android.widget.ZoomButton._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ZoomSpeed
		{
			set
			{
				setZoomSpeed(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setZoomSpeed(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ZoomButton.staticClass, "setZoomSpeed", "(J)V", ref global::android.widget.ZoomButton._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ZoomButton(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ZoomButton._m6.native == global::System.IntPtr.Zero)
				global::android.widget.ZoomButton._m6 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomButton.staticClass, global::android.widget.ZoomButton._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public ZoomButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ZoomButton._m7.native == global::System.IntPtr.Zero)
				global::android.widget.ZoomButton._m7 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomButton.staticClass, global::android.widget.ZoomButton._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public ZoomButton(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ZoomButton._m8.native == global::System.IntPtr.Zero)
				global::android.widget.ZoomButton._m8 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButton.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomButton.staticClass, global::android.widget.ZoomButton._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ZoomButton()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ZoomButton.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ZoomButton"));
		}
	}
}
