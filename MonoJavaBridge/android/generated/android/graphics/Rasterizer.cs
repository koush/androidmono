namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Rasterizer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Rasterizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize5666;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Rasterizer.staticClass, "finalize", "()V", ref global::android.graphics.Rasterizer._finalize5666);
		}
		internal static global::MonoJavaBridge.MethodId _Rasterizer5667;
		public Rasterizer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Rasterizer._Rasterizer5667.native == global::System.IntPtr.Zero)
				global::android.graphics.Rasterizer._Rasterizer5667 = @__env.GetMethodIDNoThrow(global::android.graphics.Rasterizer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Rasterizer.staticClass, global::android.graphics.Rasterizer._Rasterizer5667);
			Init(@__env, handle);
		}
		static Rasterizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Rasterizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Rasterizer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
