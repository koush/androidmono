namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DiscretePathEffect : android.graphics.PathEffect
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DiscretePathEffect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DiscretePathEffect5263;
		public DiscretePathEffect(float arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.DiscretePathEffect.staticClass, global::android.graphics.DiscretePathEffect._DiscretePathEffect5263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DiscretePathEffect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.DiscretePathEffect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/DiscretePathEffect"));
			global::android.graphics.DiscretePathEffect._DiscretePathEffect5263 = @__env.GetMethodIDNoThrow(global::android.graphics.DiscretePathEffect.staticClass, "<init>", "(FF)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
