namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LightingColorFilter : android.graphics.ColorFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LightingColorFilter()
		{
			InitJNI();
		}
		protected LightingColorFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _LightingColorFilter5276;
		public LightingColorFilter(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.LightingColorFilter.staticClass, global::android.graphics.LightingColorFilter._LightingColorFilter5276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.LightingColorFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/LightingColorFilter"));
			global::android.graphics.LightingColorFilter._LightingColorFilter5276 = @__env.GetMethodIDNoThrow(global::android.graphics.LightingColorFilter.staticClass, "<init>", "(II)V");
		}
	}
}
