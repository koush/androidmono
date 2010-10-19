namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextSwitcher : android.widget.ViewSwitcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TextSwitcher()
		{
			InitJNI();
		}
		protected TextSwitcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setText12660;
		public virtual void setText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextSwitcher._setText12660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextSwitcher.staticClass, global::android.widget.TextSwitcher._setText12660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _addView12661;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextSwitcher._addView12661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextSwitcher.staticClass, global::android.widget.TextSwitcher._addView12661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCurrentText12662;
		public virtual void setCurrentText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TextSwitcher._setCurrentText12662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TextSwitcher.staticClass, global::android.widget.TextSwitcher._setCurrentText12662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setCurrentText(string arg0)
		{
			setCurrentText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _TextSwitcher12663;
		public TextSwitcher(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextSwitcher.staticClass, global::android.widget.TextSwitcher._TextSwitcher12663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TextSwitcher12664;
		public TextSwitcher(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TextSwitcher.staticClass, global::android.widget.TextSwitcher._TextSwitcher12664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TextSwitcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TextSwitcher"));
			global::android.widget.TextSwitcher._setText12660 = @__env.GetMethodIDNoThrow(global::android.widget.TextSwitcher.staticClass, "setText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextSwitcher._addView12661 = @__env.GetMethodIDNoThrow(global::android.widget.TextSwitcher.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.TextSwitcher._setCurrentText12662 = @__env.GetMethodIDNoThrow(global::android.widget.TextSwitcher.staticClass, "setCurrentText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextSwitcher._TextSwitcher12663 = @__env.GetMethodIDNoThrow(global::android.widget.TextSwitcher.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TextSwitcher._TextSwitcher12664 = @__env.GetMethodIDNoThrow(global::android.widget.TextSwitcher.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
