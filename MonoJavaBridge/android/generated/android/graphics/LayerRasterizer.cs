namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LayerRasterizer : android.graphics.Rasterizer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LayerRasterizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void addLayer(android.graphics.Paint arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.LayerRasterizer.staticClass, "addLayer", "(Landroid/graphics/Paint;FF)V", ref global::android.graphics.LayerRasterizer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void addLayer(android.graphics.Paint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.LayerRasterizer.staticClass, "addLayer", "(Landroid/graphics/Paint;)V", ref global::android.graphics.LayerRasterizer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public LayerRasterizer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.LayerRasterizer._m2.native == global::System.IntPtr.Zero)
				global::android.graphics.LayerRasterizer._m2 = @__env.GetMethodIDNoThrow(global::android.graphics.LayerRasterizer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.LayerRasterizer.staticClass, global::android.graphics.LayerRasterizer._m2);
			Init(@__env, handle);
		}
		static LayerRasterizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.LayerRasterizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/LayerRasterizer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
