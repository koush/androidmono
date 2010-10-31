namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DashPathEffect : android.graphics.PathEffect
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DashPathEffect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public DashPathEffect(float[] arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.DashPathEffect._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.DashPathEffect._m0 = @__env.GetMethodIDNoThrow(global::android.graphics.DashPathEffect.staticClass, "<init>", "([FF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.DashPathEffect.staticClass, global::android.graphics.DashPathEffect._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DashPathEffect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.DashPathEffect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/DashPathEffect"));
		}
	}
}
