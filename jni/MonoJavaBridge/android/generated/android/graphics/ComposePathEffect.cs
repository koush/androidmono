namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ComposePathEffect : android.graphics.PathEffect
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ComposePathEffect()
		{
			InitJNI();
		}
		protected ComposePathEffect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ComposePathEffect3302;
		public ComposePathEffect(android.graphics.PathEffect arg0, android.graphics.PathEffect arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ComposePathEffect.staticClass, global::android.graphics.ComposePathEffect._ComposePathEffect3302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.ComposePathEffect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/ComposePathEffect"));
			global::android.graphics.ComposePathEffect._ComposePathEffect3302 = @__env.GetMethodIDNoThrow(global::android.graphics.ComposePathEffect.staticClass, "<init>", "(Landroid/graphics/PathEffect;Landroid/graphics/PathEffect;)V");
		}
	}
}
