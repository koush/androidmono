namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AliasActivity : android.app.Activity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AliasActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AliasActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V", ref global::android.app.AliasActivity._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public AliasActivity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.AliasActivity._m1.native == global::System.IntPtr.Zero)
				global::android.app.AliasActivity._m1 = @__env.GetMethodIDNoThrow(global::android.app.AliasActivity.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AliasActivity.staticClass, global::android.app.AliasActivity._m1);
			Init(@__env, handle);
		}
		static AliasActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.AliasActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/AliasActivity"));
		}
	}
}
