namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Xfermode : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Xfermode()
		{
			InitJNI();
		}
		protected Xfermode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize3821;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Xfermode._finalize3821);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Xfermode.staticClass, global::android.graphics.Xfermode._finalize3821);
		}
		internal static global::MonoJavaBridge.MethodId _Xfermode3822;
		public Xfermode()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Xfermode.staticClass, global::android.graphics.Xfermode._Xfermode3822);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Xfermode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Xfermode"));
			global::android.graphics.Xfermode._finalize3821 = @__env.GetMethodIDNoThrow(global::android.graphics.Xfermode.staticClass, "finalize", "()V");
			global::android.graphics.Xfermode._Xfermode3822 = @__env.GetMethodIDNoThrow(global::android.graphics.Xfermode.staticClass, "<init>", "()V");
		}
	}
}
