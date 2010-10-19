namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZoomButton : android.widget.ImageButton, android.view.View.OnLongClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ZoomButton()
		{
			InitJNI();
		}
		protected ZoomButton(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setEnabled12994;
		public override void setEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButton._setEnabled12994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButton.staticClass, global::android.widget.ZoomButton._setEnabled12994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp12995;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomButton._onKeyUp12995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomButton.staticClass, global::android.widget.ZoomButton._onKeyUp12995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent12996;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomButton._onTouchEvent12996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomButton.staticClass, global::android.widget.ZoomButton._onTouchEvent12996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchUnhandledMove12997;
		public override bool dispatchUnhandledMove(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomButton._dispatchUnhandledMove12997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomButton.staticClass, global::android.widget.ZoomButton._dispatchUnhandledMove12997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onLongClick12998;
		public virtual bool onLongClick(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomButton._onLongClick12998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomButton.staticClass, global::android.widget.ZoomButton._onLongClick12998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setZoomSpeed12999;
		public virtual void setZoomSpeed(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomButton._setZoomSpeed12999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomButton.staticClass, global::android.widget.ZoomButton._setZoomSpeed12999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ZoomButton13000;
		public ZoomButton(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomButton.staticClass, global::android.widget.ZoomButton._ZoomButton13000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ZoomButton13001;
		public ZoomButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomButton.staticClass, global::android.widget.ZoomButton._ZoomButton13001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ZoomButton13002;
		public ZoomButton(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomButton.staticClass, global::android.widget.ZoomButton._ZoomButton13002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ZoomButton.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ZoomButton"));
			global::android.widget.ZoomButton._setEnabled12994 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButton.staticClass, "setEnabled", "(Z)V");
			global::android.widget.ZoomButton._onKeyUp12995 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButton.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.ZoomButton._onTouchEvent12996 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButton.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ZoomButton._dispatchUnhandledMove12997 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButton.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z");
			global::android.widget.ZoomButton._onLongClick12998 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButton.staticClass, "onLongClick", "(Landroid/view/View;)Z");
			global::android.widget.ZoomButton._setZoomSpeed12999 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButton.staticClass, "setZoomSpeed", "(J)V");
			global::android.widget.ZoomButton._ZoomButton13000 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ZoomButton._ZoomButton13001 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.ZoomButton._ZoomButton13002 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomButton.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
