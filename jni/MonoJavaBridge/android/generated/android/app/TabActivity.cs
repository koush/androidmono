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
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState2156;
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TabActivity._onRestoreInstanceState2156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onRestoreInstanceState2156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPostCreate2157;
		protected override void onPostCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TabActivity._onPostCreate2157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onPostCreate2157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState2158;
		protected override void onSaveInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TabActivity._onSaveInstanceState2158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onSaveInstanceState2158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged2159;
		public override void onContentChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TabActivity._onContentChanged2159);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onContentChanged2159);
		}
		internal static global::MonoJavaBridge.MethodId _onChildTitleChanged2160;
		protected override void onChildTitleChanged(android.app.Activity arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TabActivity._onChildTitleChanged2160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._onChildTitleChanged2160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultTab2161;
		public virtual void setDefaultTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TabActivity._setDefaultTab2161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._setDefaultTab2161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultTab2162;
		public virtual void setDefaultTab(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.TabActivity._setDefaultTab2162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._setDefaultTab2162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.TabHost TabHost
		{
			get
			{
				return getTabHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTabHost2163;
		public virtual global::android.widget.TabHost getTabHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.TabActivity._getTabHost2163)) as android.widget.TabHost;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._getTabHost2163)) as android.widget.TabHost;
		}
		public new global::android.widget.TabWidget TabWidget
		{
			get
			{
				return getTabWidget();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTabWidget2164;
		public virtual global::android.widget.TabWidget getTabWidget() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.TabActivity._getTabWidget2164)) as android.widget.TabWidget;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.TabActivity.staticClass, global::android.app.TabActivity._getTabWidget2164)) as android.widget.TabWidget;
		}
		internal static global::MonoJavaBridge.MethodId _TabActivity2165;
		public TabActivity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.TabActivity.staticClass, global::android.app.TabActivity._TabActivity2165);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.TabActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/TabActivity"));
			global::android.app.TabActivity._onRestoreInstanceState2156 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.TabActivity._onPostCreate2157 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "onPostCreate", "(Landroid/os/Bundle;)V");
			global::android.app.TabActivity._onSaveInstanceState2158 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.TabActivity._onContentChanged2159 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "onContentChanged", "()V");
			global::android.app.TabActivity._onChildTitleChanged2160 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V");
			global::android.app.TabActivity._setDefaultTab2161 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "setDefaultTab", "(I)V");
			global::android.app.TabActivity._setDefaultTab2162 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "setDefaultTab", "(Ljava/lang/String;)V");
			global::android.app.TabActivity._getTabHost2163 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "getTabHost", "()Landroid/widget/TabHost;");
			global::android.app.TabActivity._getTabWidget2164 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "getTabWidget", "()Landroid/widget/TabWidget;");
			global::android.app.TabActivity._TabActivity2165 = @__env.GetMethodIDNoThrow(global::android.app.TabActivity.staticClass, "<init>", "()V");
		}
	}
}
