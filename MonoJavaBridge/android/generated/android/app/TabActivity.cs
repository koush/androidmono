namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TabActivity : android.app.ActivityGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TabActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TabActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V", ref global::android.app.TabActivity._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void onPostCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TabActivity.staticClass, "onPostCreate", "(Landroid/os/Bundle;)V", ref global::android.app.TabActivity._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onSaveInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TabActivity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V", ref global::android.app.TabActivity._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void onContentChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TabActivity.staticClass, "onContentChanged", "()V", ref global::android.app.TabActivity._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override void onChildTitleChanged(android.app.Activity arg0, java.lang.CharSequence arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TabActivity.staticClass, "onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V", ref global::android.app.TabActivity._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected void onChildTitleChanged(android.app.Activity arg0, string arg1)
		{
			onChildTitleChanged(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setDefaultTab(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TabActivity.staticClass, "setDefaultTab", "(I)V", ref global::android.app.TabActivity._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setDefaultTab(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.TabActivity.staticClass, "setDefaultTab", "(Ljava/lang/String;)V", ref global::android.app.TabActivity._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.TabHost TabHost
		{
			get
			{
				return getTabHost();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.widget.TabHost getTabHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.TabActivity.staticClass, "getTabHost", "()Landroid/widget/TabHost;", ref global::android.app.TabActivity._m7) as android.widget.TabHost;
		}
		public new global::android.widget.TabWidget TabWidget
		{
			get
			{
				return getTabWidget();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.widget.TabWidget getTabWidget()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.TabActivity.staticClass, "getTabWidget", "()Landroid/widget/TabWidget;", ref global::android.app.TabActivity._m8) as android.widget.TabWidget;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public TabActivity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.TabActivity._m9.native == global::System.IntPtr.Zero)
				global::android.app.TabActivity._m9 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.TabActivity.staticClass, global::android.app.TabActivity._m9);
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
