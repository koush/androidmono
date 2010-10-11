namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TabActivity : android.app.ActivityGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TabActivity()
		{
			InitJNI();
		}
		protected TabActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState811;
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TabActivity._onRestoreInstanceState811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onRestoreInstanceState811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPostCreate812;
		protected override void onPostCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TabActivity._onPostCreate812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onPostCreate812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState813;
		protected override void onSaveInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TabActivity._onSaveInstanceState813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onSaveInstanceState813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged814;
		public override void onContentChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TabActivity._onContentChanged814);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onContentChanged814);
		}
		internal static global::MonoJavaBridge.MethodId _onChildTitleChanged815;
		protected override void onChildTitleChanged(android.app.Activity arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TabActivity._onChildTitleChanged815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onChildTitleChanged815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultTab816;
		public virtual void setDefaultTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TabActivity._setDefaultTab816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._setDefaultTab816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultTab817;
		public virtual void setDefaultTab(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TabActivity._setDefaultTab817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._setDefaultTab817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTabHost818;
		public virtual global::android.widget.TabHost getTabHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.TabActivity._getTabHost818)) as android.widget.TabHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._getTabHost818)) as android.widget.TabHost;
		}
		internal static global::MonoJavaBridge.MethodId _getTabWidget819;
		public virtual global::android.widget.TabWidget getTabWidget() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.TabActivity._getTabWidget819)) as android.widget.TabWidget;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._getTabWidget819)) as android.widget.TabWidget;
		}
		internal static global::MonoJavaBridge.MethodId _TabActivity820;
		public TabActivity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.TabActivity.staticClass, global::android.app.TabActivity._TabActivity820);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.TabActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/TabActivity"));
			global::android.app.TabActivity._onRestoreInstanceState811 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.TabActivity._onPostCreate812 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "onPostCreate", "(Landroid/os/Bundle;)V");
			global::android.app.TabActivity._onSaveInstanceState813 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.TabActivity._onContentChanged814 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "onContentChanged", "()V");
			global::android.app.TabActivity._onChildTitleChanged815 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V");
			global::android.app.TabActivity._setDefaultTab816 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "setDefaultTab", "(I)V");
			global::android.app.TabActivity._setDefaultTab817 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "setDefaultTab", "(Ljava/lang/String;)V");
			global::android.app.TabActivity._getTabHost818 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "getTabHost", "()Landroid/widget/TabHost;");
			global::android.app.TabActivity._getTabWidget819 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "getTabWidget", "()Landroid/widget/TabWidget;");
			global::android.app.TabActivity._TabActivity820 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "<init>", "()V");
		}
	}
}
