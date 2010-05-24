namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ContextThemeWrapper : android.content.ContextWrapper
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ContextThemeWrapper() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.ContextThemeWrapper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.ContextThemeWrapper(@__env); 
			} 
		} 
		protected ContextThemeWrapper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _attachBaseContext7731; 
		protected override void attachBaseContext(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ContextThemeWrapper)) 
				@__env.CallVoidMethod(this, _attachBaseContext7731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ContextThemeWrapper.staticClass, _attachBaseContext7731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTheme7732; 
		public override void setTheme(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ContextThemeWrapper)) 
				@__env.CallVoidMethod(this, _setTheme7732, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ContextThemeWrapper.staticClass, _setTheme7732, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTheme7733; 
		public override android.content.res.Resources.Theme getTheme() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ContextThemeWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources.Theme>(@__env, @__env.CallObjectMethodPtr(this, _getTheme7733)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.Resources.Theme>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.ContextThemeWrapper.staticClass, _getTheme7733)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSystemService7734; 
		public override java.lang.Object getSystemService(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ContextThemeWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getSystemService7734, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.ContextThemeWrapper.staticClass, _getSystemService7734, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onApplyThemeResource7735; 
		protected virtual void onApplyThemeResource(android.content.res.Resources.Theme arg0, int arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ContextThemeWrapper)) 
				@__env.CallVoidMethod(this, _onApplyThemeResource7735, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ContextThemeWrapper.staticClass, _onApplyThemeResource7735, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContextThemeWrapper7736; 
		public ContextThemeWrapper()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.ContextThemeWrapper.staticClass, _ContextThemeWrapper7736, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContextThemeWrapper7737; 
		public ContextThemeWrapper(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.ContextThemeWrapper.staticClass, _ContextThemeWrapper7737, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.ContextThemeWrapper.staticClass = @__class; 
			global::android.view.ContextThemeWrapper._attachBaseContext7731 = @__env.GetMethodID(global::android.view.ContextThemeWrapper.staticClass, "attachBaseContext", "(Landroid/content/Context;)V"); 
			global::android.view.ContextThemeWrapper._setTheme7732 = @__env.GetMethodID(global::android.view.ContextThemeWrapper.staticClass, "setTheme", "(I)V"); 
			global::android.view.ContextThemeWrapper._getTheme7733 = @__env.GetMethodID(global::android.view.ContextThemeWrapper.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;"); 
			global::android.view.ContextThemeWrapper._getSystemService7734 = @__env.GetMethodID(global::android.view.ContextThemeWrapper.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;"); 
			global::android.view.ContextThemeWrapper._onApplyThemeResource7735 = @__env.GetMethodID(global::android.view.ContextThemeWrapper.staticClass, "onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V"); 
			global::android.view.ContextThemeWrapper._ContextThemeWrapper7736 = @__env.GetMethodID(global::android.view.ContextThemeWrapper.staticClass, "<init>", "()V"); 
			global::android.view.ContextThemeWrapper._ContextThemeWrapper7737 = @__env.GetMethodID(global::android.view.ContextThemeWrapper.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
		} 
	} 
} 
