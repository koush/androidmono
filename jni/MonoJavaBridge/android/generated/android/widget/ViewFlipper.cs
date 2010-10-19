namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ViewFlipper : android.widget.ViewAnimator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ViewFlipper()
		{
			InitJNI();
		}
		protected ViewFlipper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow12963;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._onAttachedToWindow12963);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._onAttachedToWindow12963);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow12964;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._onDetachedFromWindow12964);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._onDetachedFromWindow12964);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowVisibilityChanged12965;
		protected override void onWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._onWindowVisibilityChanged12965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._onWindowVisibilityChanged12965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFlipInterval12966;
		public virtual void setFlipInterval(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._setFlipInterval12966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._setFlipInterval12966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startFlipping12967;
		public virtual void startFlipping() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._startFlipping12967);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._startFlipping12967);
		}
		internal static global::MonoJavaBridge.MethodId _stopFlipping12968;
		public virtual void stopFlipping() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._stopFlipping12968);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._stopFlipping12968);
		}
		internal static global::MonoJavaBridge.MethodId _isFlipping12969;
		public virtual bool isFlipping() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper._isFlipping12969);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._isFlipping12969);
		}
		internal static global::MonoJavaBridge.MethodId _setAutoStart12970;
		public virtual void setAutoStart(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._setAutoStart12970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._setAutoStart12970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAutoStart12971;
		public virtual bool isAutoStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper._isAutoStart12971);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._isAutoStart12971);
		}
		internal static global::MonoJavaBridge.MethodId _ViewFlipper12972;
		public ViewFlipper(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._ViewFlipper12972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewFlipper12973;
		public ViewFlipper(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._ViewFlipper12973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ViewFlipper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewFlipper"));
			global::android.widget.ViewFlipper._onAttachedToWindow12963 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.ViewFlipper._onDetachedFromWindow12964 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.ViewFlipper._onWindowVisibilityChanged12965 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.widget.ViewFlipper._setFlipInterval12966 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "setFlipInterval", "(I)V");
			global::android.widget.ViewFlipper._startFlipping12967 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "startFlipping", "()V");
			global::android.widget.ViewFlipper._stopFlipping12968 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "stopFlipping", "()V");
			global::android.widget.ViewFlipper._isFlipping12969 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "isFlipping", "()Z");
			global::android.widget.ViewFlipper._setAutoStart12970 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "setAutoStart", "(Z)V");
			global::android.widget.ViewFlipper._isAutoStart12971 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "isAutoStart", "()Z");
			global::android.widget.ViewFlipper._ViewFlipper12972 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ViewFlipper._ViewFlipper12973 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
