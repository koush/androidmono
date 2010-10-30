namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PathEffect : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PathEffect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize5571;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.PathEffect.staticClass, "finalize", "()V", ref global::android.graphics.PathEffect._finalize5571);
		}
		internal static global::MonoJavaBridge.MethodId _PathEffect5572;
		public PathEffect() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PathEffect._PathEffect5572.native == global::System.IntPtr.Zero)
				global::android.graphics.PathEffect._PathEffect5572 = @__env.GetMethodIDNoThrow(global::android.graphics.PathEffect.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PathEffect.staticClass, global::android.graphics.PathEffect._PathEffect5572);
			Init(@__env, handle);
		}
		static PathEffect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PathEffect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PathEffect"));
		}
		internal static void InitJNI()
		{
		}
	}
}
