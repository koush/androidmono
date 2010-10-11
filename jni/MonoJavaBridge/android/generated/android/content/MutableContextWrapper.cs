namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MutableContextWrapper : android.content.ContextWrapper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MutableContextWrapper()
		{
			InitJNI();
		}
		protected MutableContextWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setBaseContext1728;
		public virtual void setBaseContext(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.MutableContextWrapper._setBaseContext1728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.MutableContextWrapper.staticClass, global::android.content.MutableContextWrapper._setBaseContext1728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _MutableContextWrapper1729;
		public MutableContextWrapper(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.MutableContextWrapper.staticClass, global::android.content.MutableContextWrapper._MutableContextWrapper1729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.MutableContextWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/MutableContextWrapper"));
			global::android.content.MutableContextWrapper._setBaseContext1728 = @__env.GetMethodIDNoThrow(global::android.content.MutableContextWrapper.staticClass, "setBaseContext", "(Landroid/content/Context;)V");
			global::android.content.MutableContextWrapper._MutableContextWrapper1729 = @__env.GetMethodIDNoThrow(global::android.content.MutableContextWrapper.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
