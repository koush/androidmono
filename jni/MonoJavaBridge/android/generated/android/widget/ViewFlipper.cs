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
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow18269;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._onAttachedToWindow18269);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._onAttachedToWindow18269);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow18270;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._onDetachedFromWindow18270);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._onDetachedFromWindow18270);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowVisibilityChanged18271;
		protected override void onWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._onWindowVisibilityChanged18271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._onWindowVisibilityChanged18271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFlipInterval18272;
		public virtual void setFlipInterval(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._setFlipInterval18272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._setFlipInterval18272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startFlipping18273;
		public virtual void startFlipping() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._startFlipping18273);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._startFlipping18273);
		}
		internal static global::MonoJavaBridge.MethodId _stopFlipping18274;
		public virtual void stopFlipping() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._stopFlipping18274);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._stopFlipping18274);
		}
		internal static global::MonoJavaBridge.MethodId _isFlipping18275;
		public virtual bool isFlipping() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper._isFlipping18275);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._isFlipping18275);
		}
		internal static global::MonoJavaBridge.MethodId _setAutoStart18276;
		public virtual void setAutoStart(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._setAutoStart18276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._setAutoStart18276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAutoStart18277;
		public virtual bool isAutoStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper._isAutoStart18277);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._isAutoStart18277);
		}
		internal static global::MonoJavaBridge.MethodId _ViewFlipper18278;
		public ViewFlipper(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._ViewFlipper18278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewFlipper18279;
		public ViewFlipper(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._ViewFlipper18279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ViewFlipper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewFlipper"));
			global::android.widget.ViewFlipper._onAttachedToWindow18269 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.ViewFlipper._onDetachedFromWindow18270 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.ViewFlipper._onWindowVisibilityChanged18271 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.widget.ViewFlipper._setFlipInterval18272 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "setFlipInterval", "(I)V");
			global::android.widget.ViewFlipper._startFlipping18273 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "startFlipping", "()V");
			global::android.widget.ViewFlipper._stopFlipping18274 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "stopFlipping", "()V");
			global::android.widget.ViewFlipper._isFlipping18275 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "isFlipping", "()Z");
			global::android.widget.ViewFlipper._setAutoStart18276 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "setAutoStart", "(Z)V");
			global::android.widget.ViewFlipper._isAutoStart18277 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "isAutoStart", "()Z");
			global::android.widget.ViewFlipper._ViewFlipper18278 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ViewFlipper._ViewFlipper18279 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
