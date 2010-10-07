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
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState799;
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.TabActivity._onRestoreInstanceState799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onRestoreInstanceState799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPostCreate800;
		protected override void onPostCreate(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.TabActivity._onPostCreate800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onPostCreate800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState801;
		protected override void onSaveInstanceState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.TabActivity._onSaveInstanceState801, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onSaveInstanceState801, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged802;
		public override void onContentChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.TabActivity._onContentChanged802);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onContentChanged802);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onChildTitleChanged803;
		protected override void onChildTitleChanged(android.app.Activity arg0, java.lang.CharSequence arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.TabActivity._onChildTitleChanged803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onChildTitleChanged803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultTab804;
		public virtual void setDefaultTab(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.TabActivity._setDefaultTab804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._setDefaultTab804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultTab805;
		public virtual void setDefaultTab(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.TabActivity._setDefaultTab805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._setDefaultTab805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTabHost806;
		public virtual global::android.widget.TabHost getTabHost() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.TabActivity._getTabHost806));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._getTabHost806));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTabWidget807;
		public virtual global::android.widget.TabWidget getTabWidget() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabWidget>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.TabActivity._getTabWidget807));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabWidget>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._getTabWidget807));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TabActivity808;
		public TabActivity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.TabActivity.staticClass, global::android.app.TabActivity._TabActivity808, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.TabActivity.staticClass = @__class;
			global::android.app.TabActivity._onRestoreInstanceState799 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.TabActivity._onPostCreate800 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "onPostCreate", "(Landroid/os/Bundle;)V");
			global::android.app.TabActivity._onSaveInstanceState801 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.TabActivity._onContentChanged802 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "onContentChanged", "()V");
			global::android.app.TabActivity._onChildTitleChanged803 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V");
			global::android.app.TabActivity._setDefaultTab804 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "setDefaultTab", "(I)V");
			global::android.app.TabActivity._setDefaultTab805 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "setDefaultTab", "(Ljava/lang/String;)V");
			global::android.app.TabActivity._getTabHost806 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "getTabHost", "()Landroid/widget/TabHost;");
			global::android.app.TabActivity._getTabWidget807 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "getTabWidget", "()Landroid/widget/TabWidget;");
			global::android.app.TabActivity._TabActivity808 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "<init>", "()V");
		}
	}
}
