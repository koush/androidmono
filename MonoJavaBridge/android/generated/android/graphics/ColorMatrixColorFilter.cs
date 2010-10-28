namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ColorMatrixColorFilter : android.graphics.ColorFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ColorMatrixColorFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ColorMatrixColorFilter5256;
		public ColorMatrixColorFilter(android.graphics.ColorMatrix arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrixColorFilter.staticClass, global::android.graphics.ColorMatrixColorFilter._ColorMatrixColorFilter5256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ColorMatrixColorFilter5257;
		public ColorMatrixColorFilter(float[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrixColorFilter.staticClass, global::android.graphics.ColorMatrixColorFilter._ColorMatrixColorFilter5257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ColorMatrixColorFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.ColorMatrixColorFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/ColorMatrixColorFilter"));
			global::android.graphics.ColorMatrixColorFilter._ColorMatrixColorFilter5256 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrixColorFilter.staticClass, "<init>", "(Landroid/graphics/ColorMatrix;)V");
			global::android.graphics.ColorMatrixColorFilter._ColorMatrixColorFilter5257 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrixColorFilter.staticClass, "<init>", "([F)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
