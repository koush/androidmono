namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Xfermode : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Xfermode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize5825;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Xfermode._finalize5825);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Xfermode.staticClass, global::android.graphics.Xfermode._finalize5825);
		}
		internal static global::MonoJavaBridge.MethodId _Xfermode5826;
		public Xfermode() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Xfermode.staticClass, global::android.graphics.Xfermode._Xfermode5826);
			Init(@__env, handle);
		}
		static Xfermode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Xfermode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Xfermode"));
			global::android.graphics.Xfermode._finalize5825 = @__env.GetMethodIDNoThrow(global::android.graphics.Xfermode.staticClass, "finalize", "()V");
			global::android.graphics.Xfermode._Xfermode5826 = @__env.GetMethodIDNoThrow(global::android.graphics.Xfermode.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
