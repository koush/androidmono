namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SumPathEffect : android.graphics.PathEffect
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SumPathEffect()
		{
			InitJNI();
		}
		protected SumPathEffect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SumPathEffect5784;
		public SumPathEffect(android.graphics.PathEffect arg0, android.graphics.PathEffect arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.SumPathEffect.staticClass, global::android.graphics.SumPathEffect._SumPathEffect5784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.SumPathEffect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/SumPathEffect"));
			global::android.graphics.SumPathEffect._SumPathEffect5784 = @__env.GetMethodIDNoThrow(global::android.graphics.SumPathEffect.staticClass, "<init>", "(Landroid/graphics/PathEffect;Landroid/graphics/PathEffect;)V");
		}
	}
}
