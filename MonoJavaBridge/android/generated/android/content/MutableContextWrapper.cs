namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MutableContextWrapper : android.content.ContextWrapper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MutableContextWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::android.content.Context BaseContext
		{
			set
			{
				setBaseContext(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setBaseContext(android.content.Context arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.MutableContextWrapper.staticClass, "setBaseContext", "(Landroid/content/Context;)V", ref global::android.content.MutableContextWrapper._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public MutableContextWrapper(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.MutableContextWrapper._m1.native == global::System.IntPtr.Zero)
				global::android.content.MutableContextWrapper._m1 = @__env.GetMethodIDNoThrow(global::android.content.MutableContextWrapper.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.MutableContextWrapper.staticClass, global::android.content.MutableContextWrapper._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MutableContextWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.MutableContextWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/MutableContextWrapper"));
		}
	}
}
