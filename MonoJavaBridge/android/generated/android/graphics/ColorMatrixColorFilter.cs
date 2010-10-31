namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ColorMatrixColorFilter : android.graphics.ColorFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ColorMatrixColorFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ColorMatrixColorFilter(android.graphics.ColorMatrix arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrixColorFilter._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrixColorFilter._m0 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrixColorFilter.staticClass, "<init>", "(Landroid/graphics/ColorMatrix;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrixColorFilter.staticClass, global::android.graphics.ColorMatrixColorFilter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ColorMatrixColorFilter(float[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorMatrixColorFilter._m1.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorMatrixColorFilter._m1 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrixColorFilter.staticClass, "<init>", "([F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrixColorFilter.staticClass, global::android.graphics.ColorMatrixColorFilter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ColorMatrixColorFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.ColorMatrixColorFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/ColorMatrixColorFilter"));
		}
	}
}
