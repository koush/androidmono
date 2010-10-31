namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MaskFilter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MaskFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.MaskFilter.staticClass, "finalize", "()V", ref global::android.graphics.MaskFilter._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public MaskFilter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.MaskFilter._m1.native == global::System.IntPtr.Zero)
				global::android.graphics.MaskFilter._m1 = @__env.GetMethodIDNoThrow(global::android.graphics.MaskFilter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.MaskFilter.staticClass, global::android.graphics.MaskFilter._m1);
			Init(@__env, handle);
		}
		static MaskFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.MaskFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/MaskFilter"));
		}
	}
}
