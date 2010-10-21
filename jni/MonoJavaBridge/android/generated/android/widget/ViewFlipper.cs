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
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow18152;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._onAttachedToWindow18152);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._onAttachedToWindow18152);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow18153;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._onDetachedFromWindow18153);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._onDetachedFromWindow18153);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowVisibilityChanged18154;
		protected override void onWindowVisibilityChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._onWindowVisibilityChanged18154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._onWindowVisibilityChanged18154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFlipInterval18155;
		public virtual void setFlipInterval(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._setFlipInterval18155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._setFlipInterval18155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startFlipping18156;
		public virtual void startFlipping() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._startFlipping18156);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._startFlipping18156);
		}
		internal static global::MonoJavaBridge.MethodId _stopFlipping18157;
		public virtual void stopFlipping() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._stopFlipping18157);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._stopFlipping18157);
		}
		internal static global::MonoJavaBridge.MethodId _isFlipping18158;
		public virtual bool isFlipping() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper._isFlipping18158);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._isFlipping18158);
		}
		internal static global::MonoJavaBridge.MethodId _setAutoStart18159;
		public virtual void setAutoStart(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper._setAutoStart18159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._setAutoStart18159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAutoStart18160;
		public virtual bool isAutoStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper._isAutoStart18160);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._isAutoStart18160);
		}
		internal static global::MonoJavaBridge.MethodId _ViewFlipper18161;
		public ViewFlipper(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._ViewFlipper18161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewFlipper18162;
		public ViewFlipper(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._ViewFlipper18162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ViewFlipper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewFlipper"));
			global::android.widget.ViewFlipper._onAttachedToWindow18152 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.ViewFlipper._onDetachedFromWindow18153 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.ViewFlipper._onWindowVisibilityChanged18154 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.widget.ViewFlipper._setFlipInterval18155 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "setFlipInterval", "(I)V");
			global::android.widget.ViewFlipper._startFlipping18156 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "startFlipping", "()V");
			global::android.widget.ViewFlipper._stopFlipping18157 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "stopFlipping", "()V");
			global::android.widget.ViewFlipper._isFlipping18158 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "isFlipping", "()Z");
			global::android.widget.ViewFlipper._setAutoStart18159 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "setAutoStart", "(Z)V");
			global::android.widget.ViewFlipper._isAutoStart18160 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "isAutoStart", "()Z");
			global::android.widget.ViewFlipper._ViewFlipper18161 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ViewFlipper._ViewFlipper18162 = @__env.GetMethodIDNoThrow(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
