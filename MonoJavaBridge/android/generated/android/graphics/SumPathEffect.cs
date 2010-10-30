namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SumPathEffect : android.graphics.PathEffect
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SumPathEffect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SumPathEffect5803;
		public SumPathEffect(android.graphics.PathEffect arg0, android.graphics.PathEffect arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.SumPathEffect._SumPathEffect5803.native == global::System.IntPtr.Zero)
				global::android.graphics.SumPathEffect._SumPathEffect5803 = @__env.GetMethodIDNoThrow(global::android.graphics.SumPathEffect.staticClass, "<init>", "(Landroid/graphics/PathEffect;Landroid/graphics/PathEffect;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.SumPathEffect.staticClass, global::android.graphics.SumPathEffect._SumPathEffect5803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static SumPathEffect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.SumPathEffect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/SumPathEffect"));
		}
		internal static void InitJNI()
		{
		}
	}
}
