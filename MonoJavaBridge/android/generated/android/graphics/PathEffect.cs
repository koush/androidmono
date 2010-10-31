namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PathEffect : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PathEffect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.PathEffect.staticClass, "finalize", "()V", ref global::android.graphics.PathEffect._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public PathEffect() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PathEffect._m1.native == global::System.IntPtr.Zero)
				global::android.graphics.PathEffect._m1 = @__env.GetMethodIDNoThrow(global::android.graphics.PathEffect.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PathEffect.staticClass, global::android.graphics.PathEffect._m1);
			Init(@__env, handle);
		}
		static PathEffect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PathEffect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PathEffect"));
		}
	}
}
