namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextSwitcher : android.widget.ViewSwitcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TextSwitcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.CharSequence Text
		{
			set
			{
				setText(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setText17962;
		public virtual void setText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextSwitcher.staticClass, "setText", "(Ljava/lang/CharSequence;)V", ref global::android.widget.TextSwitcher._setText17962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _addView17963;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextSwitcher.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", ref global::android.widget.TextSwitcher._addView17963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.CharSequence CurrentText
		{
			set
			{
				setCurrentText(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentText17964;
		public virtual void setCurrentText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TextSwitcher.staticClass, "setCurrentText", "(Ljava/lang/CharSequence;)V", ref global::android.widget.TextSwitcher._setCurrentText17964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setCurrentText(string arg0)
		{
			setCurrentText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _TextSwitcher17965;
		public TextSwitcher(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TextSwitcher._TextSwitcher17965.native == global::System.IntPtr.Zero)
				global::android.widget.TextSwitcher._TextSwitcher17965 = @__env.GetMethodIDNoThrow(global::android.widget.TextSwitcher.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextSwitcher.staticClass, global::android.widget.TextSwitcher._TextSwitcher17965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextSwitcher17966;
		public TextSwitcher(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TextSwitcher._TextSwitcher17966.native == global::System.IntPtr.Zero)
				global::android.widget.TextSwitcher._TextSwitcher17966 = @__env.GetMethodIDNoThrow(global::android.widget.TextSwitcher.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextSwitcher.staticClass, global::android.widget.TextSwitcher._TextSwitcher17966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TextSwitcher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TextSwitcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextSwitcher"));
		}
		internal static void InitJNI()
		{
		}
	}
}
