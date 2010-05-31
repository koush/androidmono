namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TabActivity : android.app.ActivityGroup
	{
		internal new static global::java.lang.Class staticClass;
		static TabActivity()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.TabActivity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.TabActivity(@__env);
			}
		}
		protected TabActivity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState760;
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.TabActivity._onRestoreInstanceState760, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onRestoreInstanceState760, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPostCreate761;
		protected override void onPostCreate(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.TabActivity._onPostCreate761, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onPostCreate761, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState762;
		protected override void onSaveInstanceState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.TabActivity._onSaveInstanceState762, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onSaveInstanceState762, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged763;
		public override void onContentChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.TabActivity._onContentChanged763);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onContentChanged763);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onChildTitleChanged764;
		protected override void onChildTitleChanged(android.app.Activity arg0, java.lang.CharSequence arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.TabActivity._onChildTitleChanged764, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onChildTitleChanged764, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultTab765;
		public virtual void setDefaultTab(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.TabActivity._setDefaultTab765, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._setDefaultTab765, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultTab766;
		public virtual void setDefaultTab(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.TabActivity._setDefaultTab766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._setDefaultTab766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTabHost767;
		public virtual global::android.widget.TabHost getTabHost() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.TabActivity._getTabHost767));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._getTabHost767));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTabWidget768;
		public virtual global::android.widget.TabWidget getTabWidget() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabWidget>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.TabActivity._getTabWidget768));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabWidget>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._getTabWidget768));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TabActivity769;
		public TabActivity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.TabActivity.staticClass, global::android.app.TabActivity._TabActivity769, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.TabActivity.staticClass = @__class;
			global::android.app.TabActivity._onRestoreInstanceState760 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.TabActivity._onPostCreate761 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "onPostCreate", "(Landroid/os/Bundle;)V");
			global::android.app.TabActivity._onSaveInstanceState762 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.TabActivity._onContentChanged763 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "onContentChanged", "()V");
			global::android.app.TabActivity._onChildTitleChanged764 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V");
			global::android.app.TabActivity._setDefaultTab765 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "setDefaultTab", "(I)V");
			global::android.app.TabActivity._setDefaultTab766 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "setDefaultTab", "(Ljava/lang/String;)V");
			global::android.app.TabActivity._getTabHost767 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "getTabHost", "()Landroid/widget/TabHost;");
			global::android.app.TabActivity._getTabWidget768 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "getTabWidget", "()Landroid/widget/TabWidget;");
			global::android.app.TabActivity._TabActivity769 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "<init>", "()V");
		}
	}
}
