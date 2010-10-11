namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MenuInflater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MenuInflater()
		{
			InitJNI();
		}
		protected MenuInflater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _inflate8884;
		public virtual void inflate(int arg0, android.view.Menu arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.MenuInflater._inflate8884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.MenuInflater.staticClass, global::android.view.MenuInflater._inflate8884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _MenuInflater8885;
		public MenuInflater(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.MenuInflater.staticClass, global::android.view.MenuInflater._MenuInflater8885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.MenuInflater.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/MenuInflater"));
			global::android.view.MenuInflater._inflate8884 = @__env.GetMethodIDNoThrow(global::android.view.MenuInflater.staticClass, "inflate", "(ILandroid/view/Menu;)V");
			global::android.view.MenuInflater._MenuInflater8885 = @__env.GetMethodIDNoThrow(global::android.view.MenuInflater.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
