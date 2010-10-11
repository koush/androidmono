namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ToggleButton : android.widget.CompoundButton
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ToggleButton()
		{
			InitJNI();
		}
		protected ToggleButton(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setChecked12351;
		public override void setChecked(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ToggleButton._setChecked12351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._setChecked12351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable12352;
		public override void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ToggleButton._setBackgroundDrawable12352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._setBackgroundDrawable12352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFinishInflate12353;
		protected override void onFinishInflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ToggleButton._onFinishInflate12353);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._onFinishInflate12353);
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged12354;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ToggleButton._drawableStateChanged12354);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._drawableStateChanged12354);
		}
		internal static global::MonoJavaBridge.MethodId _getTextOn12355;
		public virtual global::java.lang.CharSequence getTextOn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ToggleButton._getTextOn12355)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._getTextOn12355)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setTextOn12356;
		public virtual void setTextOn(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ToggleButton._setTextOn12356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._setTextOn12356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTextOn(string arg0)
		{
			setTextOn((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getTextOff12357;
		public virtual global::java.lang.CharSequence getTextOff() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ToggleButton._getTextOff12357)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._getTextOff12357)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _setTextOff12358;
		public virtual void setTextOff(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ToggleButton._setTextOff12358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._setTextOff12358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTextOff(string arg0)
		{
			setTextOff((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _ToggleButton12359;
		public ToggleButton(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._ToggleButton12359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ToggleButton12360;
		public ToggleButton(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._ToggleButton12360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ToggleButton12361;
		public ToggleButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._ToggleButton12361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ToggleButton.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ToggleButton"));
			global::android.widget.ToggleButton._setChecked12351 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "setChecked", "(Z)V");
			global::android.widget.ToggleButton._setBackgroundDrawable12352 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ToggleButton._onFinishInflate12353 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "onFinishInflate", "()V");
			global::android.widget.ToggleButton._drawableStateChanged12354 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "drawableStateChanged", "()V");
			global::android.widget.ToggleButton._getTextOn12355 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "getTextOn", "()Ljava/lang/CharSequence;");
			global::android.widget.ToggleButton._setTextOn12356 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "setTextOn", "(Ljava/lang/CharSequence;)V");
			global::android.widget.ToggleButton._getTextOff12357 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "getTextOff", "()Ljava/lang/CharSequence;");
			global::android.widget.ToggleButton._setTextOff12358 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "setTextOff", "(Ljava/lang/CharSequence;)V");
			global::android.widget.ToggleButton._ToggleButton12359 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ToggleButton._ToggleButton12360 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ToggleButton._ToggleButton12361 = @__env.GetMethodIDNoThrow(global::android.widget.ToggleButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
