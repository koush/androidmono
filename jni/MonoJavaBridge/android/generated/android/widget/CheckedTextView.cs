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
		internal static global::MonoJavaBridge.MethodId _toggle16752;
		public virtual void toggle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView._toggle16752);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._toggle16752);
		}
		internal static global::MonoJavaBridge.MethodId _isChecked16753;
		public virtual bool isChecked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CheckedTextView._isChecked16753);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._isChecked16753);
		}
		internal static global::MonoJavaBridge.MethodId _setChecked16754;
		public virtual void setChecked(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView._setChecked16754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setChecked16754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent16755;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.CheckedTextView._dispatchPopulateAccessibilityEvent16755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._dispatchPopulateAccessibilityEvent16755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw16756;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView._onDraw16756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._onDraw16756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged16757;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView._drawableStateChanged16757);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._drawableStateChanged16757);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState16758;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.CheckedTextView._onCreateDrawableState16758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._onCreateDrawableState16758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setPadding16759;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView._setPadding16759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setPadding16759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCheckMarkDrawable16760;
		public virtual void setCheckMarkDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView._setCheckMarkDrawable16760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setCheckMarkDrawable16760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCheckMarkDrawable16761;
		public virtual void setCheckMarkDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView._setCheckMarkDrawable16761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setCheckMarkDrawable16761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CheckedTextView16762;
		public CheckedTextView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._CheckedTextView16762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CheckedTextView16763;
		public CheckedTextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._CheckedTextView16763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CheckedTextView16764;
		public CheckedTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._CheckedTextView16764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CheckedTextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CheckedTextView"));
			global::android.widget.CheckedTextView._toggle16752 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "toggle", "()V");
			global::android.widget.CheckedTextView._isChecked16753 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "isChecked", "()Z");
			global::android.widget.CheckedTextView._setChecked16754 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "setChecked", "(Z)V");
			global::android.widget.CheckedTextView._dispatchPopulateAccessibilityEvent16755 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.CheckedTextView._onDraw16756 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.CheckedTextView._drawableStateChanged16757 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.CheckedTextView._onCreateDrawableState16758 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.CheckedTextView._setPadding16759 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "setPadding", "(IIII)V");
			global::android.widget.CheckedTextView._setCheckMarkDrawable16760 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "setCheckMarkDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.CheckedTextView._setCheckMarkDrawable16761 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "setCheckMarkDrawable", "(I)V");
			global::android.widget.CheckedTextView._CheckedTextView16762 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.CheckedTextView._CheckedTextView16763 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.CheckedTextView._CheckedTextView16764 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
