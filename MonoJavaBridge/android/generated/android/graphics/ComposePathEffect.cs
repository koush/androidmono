namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ComposePathEffect : android.graphics.PathEffect
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ComposePathEffect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ComposePathEffect5258;
		public ComposePathEffect(android.graphics.PathEffect arg0, android.graphics.PathEffect arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ComposePathEffect.staticClass, global::android.graphics.ComposePathEffect._ComposePathEffect5258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ComposePathEffect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.ComposePathEffect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/ComposePathEffect"));
			global::android.graphics.ComposePathEffect._ComposePathEffect5258 = @__env.GetMethodIDNoThrow(global::android.graphics.ComposePathEffect.staticClass, "<init>", "(Landroid/graphics/PathEffect;Landroid/graphics/PathEffect;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
