namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CheckedTextView : android.widget.TextView, Checkable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CheckedTextView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toggle16846;
		public virtual void toggle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._toggle16846.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._toggle16846 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "toggle", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._toggle16846);
		}
		internal static global::MonoJavaBridge.MethodId _isChecked16847;
		public virtual bool isChecked()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._isChecked16847.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._isChecked16847 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "isChecked", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._isChecked16847);
		}
		public new bool Checked
		{
			set
			{
				setChecked(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setChecked16848;
		public virtual void setChecked(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._setChecked16848.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._setChecked16848 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "setChecked", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setChecked16848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent16849;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._dispatchPopulateAccessibilityEvent16849.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._dispatchPopulateAccessibilityEvent16849 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._dispatchPopulateAccessibilityEvent16849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDraw16850;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._onDraw16850.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._onDraw16850 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._onDraw16850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged16851;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._drawableStateChanged16851.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._drawableStateChanged16851 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "drawableStateChanged", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._drawableStateChanged16851);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState16852;
		protected override int[] onCreateDrawableState(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._onCreateDrawableState16852.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._onCreateDrawableState16852 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "onCreateDrawableState", "(I)[I");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._onCreateDrawableState16852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setPadding16853;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._setPadding16853.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._setPadding16853 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "setPadding", "(IIII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setPadding16853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setCheckMarkDrawable16854;
		public virtual void setCheckMarkDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._setCheckMarkDrawable16854.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._setCheckMarkDrawable16854 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "setCheckMarkDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setCheckMarkDrawable16854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCheckMarkDrawable16855;
		public virtual void setCheckMarkDrawable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._setCheckMarkDrawable16855.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._setCheckMarkDrawable16855 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "setCheckMarkDrawable", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setCheckMarkDrawable16855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CheckedTextView16856;
		public CheckedTextView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._CheckedTextView16856.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._CheckedTextView16856 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._CheckedTextView16856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CheckedTextView16857;
		public CheckedTextView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._CheckedTextView16857.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._CheckedTextView16857 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._CheckedTextView16857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CheckedTextView16858;
		public CheckedTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._CheckedTextView16858.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._CheckedTextView16858 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._CheckedTextView16858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static CheckedTextView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.CheckedTextView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/CheckedTextView"));
		}
		internal static void InitJNI()
		{
		}
	}
}
