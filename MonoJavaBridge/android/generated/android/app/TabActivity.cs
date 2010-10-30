namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TabActivity : android.app.ActivityGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TabActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState2163;
		protected override void onRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TabActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V", ref global::android.app.TabActivity._onRestoreInstanceState2163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPostCreate2164;
		protected override void onPostCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TabActivity.staticClass, "onPostCreate", "(Landroid/os/Bundle;)V", ref global::android.app.TabActivity._onPostCreate2164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState2165;
		protected override void onSaveInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TabActivity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V", ref global::android.app.TabActivity._onSaveInstanceState2165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged2166;
		public override void onContentChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TabActivity.staticClass, "onContentChanged", "()V", ref global::android.app.TabActivity._onContentChanged2166);
		}
		internal static global::MonoJavaBridge.MethodId _onChildTitleChanged2167;
		protected override void onChildTitleChanged(android.app.Activity arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TabActivity.staticClass, "onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V", ref global::android.app.TabActivity._onChildTitleChanged2167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void onChildTitleChanged(android.app.Activity arg0, string arg1)
		{
			onChildTitleChanged(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultTab2168;
		public virtual void setDefaultTab(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TabActivity.staticClass, "setDefaultTab", "(I)V", ref global::android.app.TabActivity._setDefaultTab2168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultTab2169;
		public virtual void setDefaultTab(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TabActivity.staticClass, "setDefaultTab", "(Ljava/lang/String;)V", ref global::android.app.TabActivity._setDefaultTab2169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.TabHost TabHost
		{
			get
			{
				return getTabHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTabHost2170;
		public virtual global::android.widget.TabHost getTabHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.TabActivity.staticClass, "getTabHost", "()Landroid/widget/TabHost;", ref global::android.app.TabActivity._getTabHost2170) as android.widget.TabHost;
		}
		public new global::android.widget.TabWidget TabWidget
		{
			get
			{
				return getTabWidget();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTabWidget2171;
		public virtual global::android.widget.TabWidget getTabWidget()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.TabActivity.staticClass, "getTabWidget", "()Landroid/widget/TabWidget;", ref global::android.app.TabActivity._getTabWidget2171) as android.widget.TabWidget;
		}
		internal static global::MonoJavaBridge.MethodId _TabActivity2172;
		public TabActivity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.TabActivity._TabActivity2172.native == global::System.IntPtr.Zero)
				global::android.app.TabActivity._TabActivity2172 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.TabActivity.staticClass, global::android.app.TabActivity._TabActivity2172);
			Init(@__env, handle);
		}
		static TabActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.TabActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/TabActivity"));
		}
		internal static void InitJNI()
		{
		}
	}
}
