namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CheckedTextView : android.widget.TextView, Checkable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CheckedTextView()
		{
			InitJNI();
		}
		protected CheckedTextView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toggle11607;
		public virtual void toggle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView._toggle11607);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._toggle11607);
		}
		internal static global::MonoJavaBridge.MethodId _isChecked11608;
		public virtual bool isChecked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CheckedTextView._isChecked11608);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._isChecked11608);
		}
		internal static global::MonoJavaBridge.MethodId _setChecked11609;
		public virtual void setChecked(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView._setChecked11609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setChecked11609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent11610;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CheckedTextView._dispatchPopulateAccessibilityEvent11610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._dispatchPopulateAccessibilityEvent11610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw11611;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView._onDraw11611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._onDraw11611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged11612;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView._drawableStateChanged11612);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._drawableStateChanged11612);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState11613;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CheckedTextView._onCreateDrawableState11613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._onCreateDrawableState11613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setPadding11614;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView._setPadding11614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setPadding11614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCheckMarkDrawable11615;
		public virtual void setCheckMarkDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView._setCheckMarkDrawable11615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setCheckMarkDrawable11615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCheckMarkDrawable11616;
		public virtual void setCheckMarkDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView._setCheckMarkDrawable11616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setCheckMarkDrawable11616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CheckedTextView11617;
		public CheckedTextView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._CheckedTextView11617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CheckedTextView11618;
		public CheckedTextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._CheckedTextView11618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CheckedTextView11619;
		public CheckedTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._CheckedTextView11619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CheckedTextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CheckedTextView"));
			global::android.widget.CheckedTextView._toggle11607 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "toggle", "()V");
			global::android.widget.CheckedTextView._isChecked11608 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "isChecked", "()Z");
			global::android.widget.CheckedTextView._setChecked11609 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "setChecked", "(Z)V");
			global::android.widget.CheckedTextView._dispatchPopulateAccessibilityEvent11610 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.CheckedTextView._onDraw11611 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.CheckedTextView._drawableStateChanged11612 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.CheckedTextView._onCreateDrawableState11613 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.CheckedTextView._setPadding11614 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "setPadding", "(IIII)V");
			global::android.widget.CheckedTextView._setCheckMarkDrawable11615 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "setCheckMarkDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.CheckedTextView._setCheckMarkDrawable11616 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "setCheckMarkDrawable", "(I)V");
			global::android.widget.CheckedTextView._CheckedTextView11617 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.CheckedTextView._CheckedTextView11618 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.CheckedTextView._CheckedTextView11619 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
