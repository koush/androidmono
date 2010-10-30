namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EmbossMaskFilter : android.graphics.MaskFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EmbossMaskFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public EmbossMaskFilter(float[] arg0, float arg1, float arg2, float arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.EmbossMaskFilter._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.EmbossMaskFilter._m0 = @__env.GetMethodIDNoThrow(global::android.graphics.EmbossMaskFilter.staticClass, "<init>", "([FFFF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.EmbossMaskFilter.staticClass, global::android.graphics.EmbossMaskFilter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static EmbossMaskFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.EmbossMaskFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/EmbossMaskFilter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
