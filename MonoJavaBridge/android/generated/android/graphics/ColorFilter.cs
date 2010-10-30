namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ColorFilter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ColorFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.ColorFilter.staticClass, "finalize", "()V", ref global::android.graphics.ColorFilter._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ColorFilter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ColorFilter._m1.native == global::System.IntPtr.Zero)
				global::android.graphics.ColorFilter._m1 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorFilter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorFilter.staticClass, global::android.graphics.ColorFilter._m1);
			Init(@__env, handle);
		}
		static ColorFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.ColorFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/ColorFilter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
