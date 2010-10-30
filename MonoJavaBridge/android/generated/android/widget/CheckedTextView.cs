namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CheckedTextView : android.widget.TextView, Checkable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CheckedTextView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void toggle()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CheckedTextView.staticClass, "toggle", "()V", ref global::android.widget.CheckedTextView._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool isChecked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.CheckedTextView.staticClass, "isChecked", "()Z", ref global::android.widget.CheckedTextView._m1);
		}
		public new bool Checked
		{
			set
			{
				setChecked(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setChecked(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CheckedTextView.staticClass, "setChecked", "(Z)V", ref global::android.widget.CheckedTextView._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.CheckedTextView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", ref global::android.widget.CheckedTextView._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CheckedTextView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.CheckedTextView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CheckedTextView.staticClass, "drawableStateChanged", "()V", ref global::android.widget.CheckedTextView._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override int[] onCreateDrawableState(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.widget.CheckedTextView.staticClass, "onCreateDrawableState", "(I)[I", ref global::android.widget.CheckedTextView._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CheckedTextView.staticClass, "setPadding", "(IIII)V", ref global::android.widget.CheckedTextView._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setCheckMarkDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CheckedTextView.staticClass, "setCheckMarkDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.CheckedTextView._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setCheckMarkDrawable(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.CheckedTextView.staticClass, "setCheckMarkDrawable", "(I)V", ref global::android.widget.CheckedTextView._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public CheckedTextView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._m10.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._m10 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public CheckedTextView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._m11.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._m11 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public CheckedTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.CheckedTextView._m12.native == global::System.IntPtr.Zero)
				global::android.widget.CheckedTextView._m12 = @__env.GetMethodIDNoThrow(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
