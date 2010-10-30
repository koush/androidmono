namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContextThemeWrapper : android.content.ContextWrapper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContextThemeWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void attachBaseContext(android.content.Context arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ContextThemeWrapper.staticClass, "attachBaseContext", "(Landroid/content/Context;)V", ref global::android.view.ContextThemeWrapper._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void setTheme(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ContextThemeWrapper.staticClass, "setTheme", "(I)V", ref global::android.view.ContextThemeWrapper._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.res.Resources.Theme Theme
		{
			get
			{
				return getTheme();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::android.content.res.Resources.Theme getTheme()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.res.Resources.Theme>(this, global::android.view.ContextThemeWrapper.staticClass, "getTheme", "()Landroid/content/res/Resources$Theme;", ref global::android.view.ContextThemeWrapper._m2) as android.content.res.Resources.Theme;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.Object getSystemService(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.ContextThemeWrapper.staticClass, "getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::android.view.ContextThemeWrapper._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual void onApplyThemeResource(android.content.res.Resources.Theme arg0, int arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ContextThemeWrapper.staticClass, "onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V", ref global::android.view.ContextThemeWrapper._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ContextThemeWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ContextThemeWrapper._m5.native == global::System.IntPtr.Zero)
				global::android.view.ContextThemeWrapper._m5 = @__env.GetMethodIDNoThrow(global::android.view.ContextThemeWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ContextThemeWrapper.staticClass, global::android.view.ContextThemeWrapper._m5);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ContextThemeWrapper(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ContextThemeWrapper._m6.native == global::System.IntPtr.Zero)
				global::android.view.ContextThemeWrapper._m6 = @__env.GetMethodIDNoThrow(global::android.view.ContextThemeWrapper.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ContextThemeWrapper.staticClass, global::android.view.ContextThemeWrapper._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ContextThemeWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ContextThemeWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ContextThemeWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
}
