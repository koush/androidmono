namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ViewFlipper : android.widget.ViewAnimator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ViewFlipper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewFlipper.staticClass, "onAttachedToWindow", "()V", ref global::android.widget.ViewFlipper._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewFlipper.staticClass, "onDetachedFromWindow", "()V", ref global::android.widget.ViewFlipper._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onWindowVisibilityChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewFlipper.staticClass, "onWindowVisibilityChanged", "(I)V", ref global::android.widget.ViewFlipper._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int FlipInterval
		{
			set
			{
				setFlipInterval(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setFlipInterval(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewFlipper.staticClass, "setFlipInterval", "(I)V", ref global::android.widget.ViewFlipper._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void startFlipping()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewFlipper.staticClass, "startFlipping", "()V", ref global::android.widget.ViewFlipper._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void stopFlipping()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewFlipper.staticClass, "stopFlipping", "()V", ref global::android.widget.ViewFlipper._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool isFlipping()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ViewFlipper.staticClass, "isFlipping", "()Z", ref global::android.widget.ViewFlipper._m6);
		}
		public new bool AutoStart
		{
			set
			{
				setAutoStart(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setAutoStart(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewFlipper.staticClass, "setAutoStart", "(Z)V", ref global::android.widget.ViewFlipper._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isAutoStart()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ViewFlipper.staticClass, "isAutoStart", "()Z", ref global::android.widget.ViewFlipper._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public ViewFlipper(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewFlipper._m9.native == global::System.IntPtr.Zero)
				global::android.widget.ViewFlipper._m9 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public ViewFlipper(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewFlipper._m10.native == global::System.IntPtr.Zero)
				global::android.widget.ViewFlipper._m10 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ViewFlipper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ViewFlipper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewFlipper"));
		}
		internal static void InitJNI()
		{
		}
	}
}
