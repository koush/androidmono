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
		private static global::MonoJavaBridge.MethodId _m0;
		public override void setChecked(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ToggleButton.staticClass, "setChecked", "(Z)V", ref global::android.widget.ToggleButton._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable BackgroundDrawable
		{
			set
			{
				setBackgroundDrawable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void setBackgroundDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ToggleButton.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.ToggleButton._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onFinishInflate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ToggleButton.staticClass, "onFinishInflate", "()V", ref global::android.widget.ToggleButton._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ToggleButton.staticClass, "drawableStateChanged", "()V", ref global::android.widget.ToggleButton._m3);
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
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.CharSequence getTextOn()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.ToggleButton.staticClass, "getTextOn", "()Ljava/lang/CharSequence;", ref global::android.widget.ToggleButton._m4) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setTextOn(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ToggleButton.staticClass, "setTextOn", "(Ljava/lang/CharSequence;)V", ref global::android.widget.ToggleButton._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.CharSequence getTextOff()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.ToggleButton.staticClass, "getTextOff", "()Ljava/lang/CharSequence;", ref global::android.widget.ToggleButton._m6) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setTextOff(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ToggleButton.staticClass, "setTextOff", "(Ljava/lang/CharSequence;)V", ref global::android.widget.ToggleButton._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTextOff(string arg0)
		{
			setTextOff((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public ToggleButton(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ToggleButton._m8.native == global::System.IntPtr.Zero)
				global::android.widget.ToggleButton._m8 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public ToggleButton(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ToggleButton._m9.native == global::System.IntPtr.Zero)
				global::android.widget.ToggleButton._m9 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public ToggleButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ToggleButton._m10.native == global::System.IntPtr.Zero)
				global::android.widget.ToggleButton._m10 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
