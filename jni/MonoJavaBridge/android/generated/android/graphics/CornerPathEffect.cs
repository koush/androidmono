namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CornerPathEffect : android.graphics.PathEffect
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CornerPathEffect()
		{
			InitJNI();
		}
		protected CornerPathEffect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CornerPathEffect3305;
		public CornerPathEffect(float arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.CornerPathEffect.staticClass, global::android.graphics.CornerPathEffect._CornerPathEffect3305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.CornerPathEffect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/CornerPathEffect"));
			global::android.graphics.CornerPathEffect._CornerPathEffect3305 = @__env.GetMethodIDNoThrow(global::android.graphics.CornerPathEffect.staticClass, "<init>", "(F)V");
		}
	}
}
