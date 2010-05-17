namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TabActivity : android.app.ActivityGroup
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TabActivity() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.TabActivity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState748; 
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TabActivity)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.TabActivity.staticClass, _onRestoreInstanceState748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPostCreate749; 
		protected override void onPostCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TabActivity)) 
				@__env.CallVoidMethod(this, _onPostCreate749, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.TabActivity.staticClass, _onPostCreate749, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState750; 
		protected override void onSaveInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TabActivity)) 
				@__env.CallVoidMethod(this, _onSaveInstanceState750, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.TabActivity.staticClass, _onSaveInstanceState750, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged751; 
		public override void onContentChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TabActivity)) 
				@__env.CallVoidMethod(this, _onContentChanged751); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.TabActivity.staticClass, _onContentChanged751); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onChildTitleChanged752; 
		protected override void onChildTitleChanged(android.app.Activity arg0, java.lang.CharSequence arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TabActivity)) 
				@__env.CallVoidMethod(this, _onChildTitleChanged752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.TabActivity.staticClass, _onChildTitleChanged752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultTab753; 
		public virtual void setDefaultTab(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TabActivity)) 
				@__env.CallVoidMethod(this, _setDefaultTab753, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.TabActivity.staticClass, _setDefaultTab753, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultTab754; 
		public virtual void setDefaultTab(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TabActivity)) 
				@__env.CallVoidMethod(this, _setDefaultTab754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.TabActivity.staticClass, _setDefaultTab754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTabHost755; 
		public virtual android.widget.TabHost getTabHost() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TabActivity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost>(@__env, @__env.CallObjectMethodPtr(this, _getTabHost755)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabHost>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.TabActivity.staticClass, _getTabHost755)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTabWidget756; 
		public virtual android.widget.TabWidget getTabWidget() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.TabActivity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabWidget>(@__env, @__env.CallObjectMethodPtr(this, _getTabWidget756)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TabWidget>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.TabActivity.staticClass, _getTabWidget756)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TabActivity757; 
		public TabActivity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.TabActivity.staticClass, _TabActivity757, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.TabActivity.staticClass = @__class; 
			global::android.app.TabActivity._onRestoreInstanceState748 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.app.TabActivity._onPostCreate749 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "onPostCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.TabActivity._onSaveInstanceState750 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.app.TabActivity._onContentChanged751 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "onContentChanged", "()V"); 
			global::android.app.TabActivity._onChildTitleChanged752 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "onChildTitleChanged", "(Landroid/app/Activity;Ljava/lang/CharSequence;)V"); 
			global::android.app.TabActivity._setDefaultTab753 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "setDefaultTab", "(I)V"); 
			global::android.app.TabActivity._setDefaultTab754 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "setDefaultTab", "(Ljava/lang/String;)V"); 
			global::android.app.TabActivity._getTabHost755 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "getTabHost", "()Landroid/widget/TabHost;"); 
			global::android.app.TabActivity._getTabWidget756 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "getTabWidget", "()Landroid/widget/TabWidget;"); 
			global::android.app.TabActivity._TabActivity757 = @__env.GetMethodID(global::android.app.TabActivity.staticClass, "<init>", "()V"); 
		} 
	} 
} 
