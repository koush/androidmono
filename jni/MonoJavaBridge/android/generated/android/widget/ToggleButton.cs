namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ToggleButton : android.widget.CompoundButton
	{
		internal new static global::java.lang.Class staticClass;
		static ToggleButton()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ToggleButton), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.ToggleButton(@__env);
			}
		}
		protected ToggleButton(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChecked11247;
		public override void setChecked(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ToggleButton._setChecked11247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._setChecked11247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundDrawable11248;
		public override void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ToggleButton._setBackgroundDrawable11248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._setBackgroundDrawable11248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate11249;
		protected override void onFinishInflate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ToggleButton._onFinishInflate11249);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._onFinishInflate11249);
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged11250;
		protected override void drawableStateChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ToggleButton._drawableStateChanged11250);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._drawableStateChanged11250);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextOn11251;
		public virtual global::java.lang.CharSequence getTextOn() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ToggleButton._getTextOn11251));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._getTextOn11251));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextOn11252;
		public virtual void setTextOn(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ToggleButton._setTextOn11252, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._setTextOn11252, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setTextOn(string arg0)
		{
			setTextOn((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTextOff11253;
		public virtual global::java.lang.CharSequence getTextOff() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ToggleButton._getTextOff11253));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._getTextOff11253));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextOff11254;
		public virtual void setTextOff(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ToggleButton._setTextOff11254, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._setTextOff11254, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setTextOff(string arg0)
		{
			setTextOff((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ToggleButton11255;
		public ToggleButton(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._ToggleButton11255, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ToggleButton11256;
		public ToggleButton(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._ToggleButton11256, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ToggleButton11257;
		public ToggleButton(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ToggleButton.staticClass, global::android.widget.ToggleButton._ToggleButton11257, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ToggleButton.staticClass = @__class;
			global::android.widget.ToggleButton._setChecked11247 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "setChecked", "(Z)V");
			global::android.widget.ToggleButton._setBackgroundDrawable11248 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ToggleButton._onFinishInflate11249 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "onFinishInflate", "()V");
			global::android.widget.ToggleButton._drawableStateChanged11250 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "drawableStateChanged", "()V");
			global::android.widget.ToggleButton._getTextOn11251 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "getTextOn", "()Ljava/lang/CharSequence;");
			global::android.widget.ToggleButton._setTextOn11252 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "setTextOn", "(Ljava/lang/CharSequence;)V");
			global::android.widget.ToggleButton._getTextOff11253 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "getTextOff", "()Ljava/lang/CharSequence;");
			global::android.widget.ToggleButton._setTextOff11254 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "setTextOff", "(Ljava/lang/CharSequence;)V");
			global::android.widget.ToggleButton._ToggleButton11255 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ToggleButton._ToggleButton11256 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ToggleButton._ToggleButton11257 = @__env.GetMethodID(global::android.widget.ToggleButton.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
