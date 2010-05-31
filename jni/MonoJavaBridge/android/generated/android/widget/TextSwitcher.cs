namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TextSwitcher : android.widget.ViewSwitcher
	{
		internal new static global::java.lang.Class staticClass;
		static TextSwitcher()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.TextSwitcher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.TextSwitcher(@__env);
			}
		}
		protected TextSwitcher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _setText11010;
		public virtual void setText(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextSwitcher._setText11010, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextSwitcher.staticClass, global::android.widget.TextSwitcher._setText11010, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView11011;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextSwitcher._addView11011, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextSwitcher.staticClass, global::android.widget.TextSwitcher._addView11011, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCurrentText11012;
		public virtual void setCurrentText(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TextSwitcher._setCurrentText11012, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TextSwitcher.staticClass, global::android.widget.TextSwitcher._setCurrentText11012, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setCurrentText(string arg0)
		{
			setCurrentText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _TextSwitcher11013;
		public TextSwitcher(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.TextSwitcher.staticClass, global::android.widget.TextSwitcher._TextSwitcher11013, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TextSwitcher11014;
		public TextSwitcher(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.TextSwitcher.staticClass, global::android.widget.TextSwitcher._TextSwitcher11014, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.TextSwitcher.staticClass = @__class;
			global::android.widget.TextSwitcher._setText11010 = @__env.GetMethodID(global::android.widget.TextSwitcher.staticClass, "setText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextSwitcher._addView11011 = @__env.GetMethodID(global::android.widget.TextSwitcher.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.TextSwitcher._setCurrentText11012 = @__env.GetMethodID(global::android.widget.TextSwitcher.staticClass, "setCurrentText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.TextSwitcher._TextSwitcher11013 = @__env.GetMethodID(global::android.widget.TextSwitcher.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TextSwitcher._TextSwitcher11014 = @__env.GetMethodID(global::android.widget.TextSwitcher.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
