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
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow12417;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._onAttachedToWindow12417);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._onAttachedToWindow12417);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow12418;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._onDetachedFromWindow12418);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._onDetachedFromWindow12418);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowVisibilityChanged12419;
		protected override void onWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._onWindowVisibilityChanged12419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._onWindowVisibilityChanged12419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFlipInterval12420;
		public virtual void setFlipInterval(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._setFlipInterval12420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._setFlipInterval12420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startFlipping12421;
		public virtual void startFlipping() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._startFlipping12421);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._startFlipping12421);
		}
		internal static global::MonoJavaBridge.MethodId _stopFlipping12422;
		public virtual void stopFlipping() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._stopFlipping12422);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._stopFlipping12422);
		}
		internal static global::MonoJavaBridge.MethodId _isFlipping12423;
		public virtual bool isFlipping() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper._isFlipping12423);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._isFlipping12423);
		}
		internal static global::MonoJavaBridge.MethodId _setAutoStart12424;
		public virtual void setAutoStart(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._setAutoStart12424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._setAutoStart12424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAutoStart12425;
		public virtual bool isAutoStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper._isAutoStart12425);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._isAutoStart12425);
		}
		internal static global::MonoJavaBridge.MethodId _ViewFlipper12426;
		public ViewFlipper(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._ViewFlipper12426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewFlipper12427;
		public ViewFlipper(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._ViewFlipper12427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ViewFlipper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewFlipper"));
			global::android.widget.ViewFlipper._onAttachedToWindow12417 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.ViewFlipper._onDetachedFromWindow12418 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.ViewFlipper._onWindowVisibilityChanged12419 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.widget.ViewFlipper._setFlipInterval12420 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "setFlipInterval", "(I)V");
			global::android.widget.ViewFlipper._startFlipping12421 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "startFlipping", "()V");
			global::android.widget.ViewFlipper._stopFlipping12422 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "stopFlipping", "()V");
			global::android.widget.ViewFlipper._isFlipping12423 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "isFlipping", "()Z");
			global::android.widget.ViewFlipper._setAutoStart12424 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "setAutoStart", "(Z)V");
			global::android.widget.ViewFlipper._isAutoStart12425 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "isAutoStart", "()Z");
			global::android.widget.ViewFlipper._ViewFlipper12426 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ViewFlipper._ViewFlipper12427 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
