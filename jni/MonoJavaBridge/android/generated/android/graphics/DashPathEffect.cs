namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DashPathEffect : android.graphics.PathEffect
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DashPathEffect()
		{
			InitJNI();
		}
		protected DashPathEffect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DashPathEffect3306;
		public DashPathEffect(float[] arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.DashPathEffect.staticClass, global::android.graphics.DashPathEffect._DashPathEffect3306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.DashPathEffect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/DashPathEffect"));
			global::android.graphics.DashPathEffect._DashPathEffect3306 = @__env.GetMethodIDNoThrow(global::android.graphics.DashPathEffect.staticClass, "<init>", "([FF)V");
		}
	}
}
