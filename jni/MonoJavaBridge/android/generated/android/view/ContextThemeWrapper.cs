namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContextThemeWrapper : android.content.ContextWrapper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContextThemeWrapper()
		{
			InitJNI();
		}
		protected ContextThemeWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _attachBaseContext14007;
		protected override void attachBaseContext(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextThemeWrapper._attachBaseContext14007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextThemeWrapper.staticClass, global::android.view.ContextThemeWrapper._attachBaseContext14007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTheme14008;
		public override void setTheme(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextThemeWrapper._setTheme14008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextThemeWrapper.staticClass, global::android.view.ContextThemeWrapper._setTheme14008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.Resources.Theme Theme
		{
			get
			{
				return getTheme();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTheme14009;
		public override global::android.content.res.Resources.Theme getTheme() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.res.Resources.Theme>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextThemeWrapper._getTheme14009)) as android.content.res.Resources.Theme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.res.Resources.Theme>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextThemeWrapper.staticClass, global::android.view.ContextThemeWrapper._getTheme14009)) as android.content.res.Resources.Theme;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemService14010;
		public override global::java.lang.Object getSystemService(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ContextThemeWrapper._getSystemService14010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ContextThemeWrapper.staticClass, global::android.view.ContextThemeWrapper._getSystemService14010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _onApplyThemeResource14011;
		protected virtual void onApplyThemeResource(android.content.res.Resources.Theme arg0, int arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ContextThemeWrapper._onApplyThemeResource14011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ContextThemeWrapper.staticClass, global::android.view.ContextThemeWrapper._onApplyThemeResource14011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _ContextThemeWrapper14012;
		public ContextThemeWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ContextThemeWrapper.staticClass, global::android.view.ContextThemeWrapper._ContextThemeWrapper14012);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ContextThemeWrapper14013;
		public ContextThemeWrapper(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ContextThemeWrapper.staticClass, global::android.view.ContextThemeWrapper._ContextThemeWrapper14013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ContextThemeWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ContextThemeWrapper"));
			global::android.view.ContextThemeWrapper._attachBaseContext14007 = @__env.GetMethodIDNoThrow(global::android.view.ContextThemeWrapper.staticClass, "attachBaseContext", "(Landroid/content/Context;)V");
			global::android.view.ContextThemeWrapper._setTheme14008 = @__env.GetMethodIDNoThrow(global::android.view.ContextThemeWrapper.staticClass, "setTheme", "(I)V");
			global::android.view.ContextThemeWrapper._getTheme14009 = @__env.GetMethodIDNoThrow(global::android.view.ContextThemeWrapper.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;");
			global::android.view.ContextThemeWrapper._getSystemService14010 = @__env.GetMethodIDNoThrow(global::android.view.ContextThemeWrapper.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.view.ContextThemeWrapper._onApplyThemeResource14011 = @__env.GetMethodIDNoThrow(global::android.view.ContextThemeWrapper.staticClass, "onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V");
			global::android.view.ContextThemeWrapper._ContextThemeWrapper14012 = @__env.GetMethodIDNoThrow(global::android.view.ContextThemeWrapper.staticClass, "<init>", "()V");
			global::android.view.ContextThemeWrapper._ContextThemeWrapper14013 = @__env.GetMethodIDNoThrow(global::android.view.ContextThemeWrapper.staticClass, "<init>", "(Landroid/content/Context;I)V");
		}
	}
}
