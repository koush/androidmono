namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ToggleButton : android.widget.CompoundButton
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ToggleButton(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new bool Checked
		{
			set
			{
				setChecked(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setChecked18203;
		public override void setChecked(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ToggleButton._setChecked18203.native == global::System.IntPtr.Zero)
				global::android.widget.ToggleButton._setChecked18203 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "setChecked", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._setChecked18203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable BackgroundDrawable
		{
			set
			{
				setBackgroundDrawable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable18204;
		public override void setBackgroundDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ToggleButton._setBackgroundDrawable18204.native == global::System.IntPtr.Zero)
				global::android.widget.ToggleButton._setBackgroundDrawable18204 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._setBackgroundDrawable18204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate18205;
		protected override void onFinishInflate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ToggleButton._onFinishInflate18205.native == global::System.IntPtr.Zero)
				global::android.widget.ToggleButton._onFinishInflate18205 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "onFinishInflate", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._onFinishInflate18205);
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged18206;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ToggleButton._drawableStateChanged18206.native == global::System.IntPtr.Zero)
				global::android.widget.ToggleButton._drawableStateChanged18206 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "drawableStateChanged", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._drawableStateChanged18206);
		}
		public new string TextOn
		{
			get
			{
				return getTextOn().toString();
			}
			set
			{
				setTextOn((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextOn18207;
		public virtual global::java.lang.CharSequence getTextOn()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ToggleButton._getTextOn18207.native == global::System.IntPtr.Zero)
				global::android.widget.ToggleButton._getTextOn18207 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "getTextOn", "()Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._getTextOn18207) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setTextOn18208;
		public virtual void setTextOn(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ToggleButton._setTextOn18208.native == global::System.IntPtr.Zero)
				global::android.widget.ToggleButton._setTextOn18208 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "setTextOn", "(Ljava/lang/CharSequence;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._setTextOn18208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTextOn(string arg0)
		{
			setTextOn((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new string TextOff
		{
			get
			{
				return getTextOff().toString();
			}
			set
			{
				setTextOff((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTextOff18209;
		public virtual global::java.lang.CharSequence getTextOff()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ToggleButton._getTextOff18209.native == global::System.IntPtr.Zero)
				global::android.widget.ToggleButton._getTextOff18209 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "getTextOff", "()Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._getTextOff18209) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setTextOff18210;
		public virtual void setTextOff(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ToggleButton._setTextOff18210.native == global::System.IntPtr.Zero)
				global::android.widget.ToggleButton._setTextOff18210 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "setTextOff", "(Ljava/lang/CharSequence;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._setTextOff18210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTextOff(string arg0)
		{
			setTextOff((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _ToggleButton18211;
		public ToggleButton(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ToggleButton._ToggleButton18211.native == global::System.IntPtr.Zero)
				global::android.widget.ToggleButton._ToggleButton18211 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._ToggleButton18211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ToggleButton18212;
		public ToggleButton(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ToggleButton._ToggleButton18212.native == global::System.IntPtr.Zero)
				global::android.widget.ToggleButton._ToggleButton18212 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._ToggleButton18212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ToggleButton18213;
		public ToggleButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ToggleButton._ToggleButton18213.native == global::System.IntPtr.Zero)
				global::android.widget.ToggleButton._ToggleButton18213 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._ToggleButton18213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ToggleButton()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ToggleButton.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ToggleButton"));
		}
		internal static void InitJNI()
		{
		}
	}
}
