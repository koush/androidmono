namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LayerRasterizer : android.graphics.Rasterizer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LayerRasterizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addLayer5292;
		public virtual void addLayer(android.graphics.Paint arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.LayerRasterizer.staticClass, global::android.graphics.LayerRasterizer._addLayer5292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addLayer5293;
		public virtual void addLayer(android.graphics.Paint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.LayerRasterizer.staticClass, global::android.graphics.LayerRasterizer._addLayer5293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LayerRasterizer5294;
		public LayerRasterizer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.LayerRasterizer.staticClass, global::android.graphics.LayerRasterizer._LayerRasterizer5294);
			Init(@__env, handle);
		}
		static LayerRasterizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.LayerRasterizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/LayerRasterizer"));
			global::android.graphics.LayerRasterizer._addLayer5292 = @__env.GetMethodIDNoThrow(global::android.graphics.LayerRasterizer.staticClass, "addLayer", "(Landroid/graphics/Paint;FF)V");
			global::android.graphics.LayerRasterizer._addLayer5293 = @__env.GetMethodIDNoThrow(global::android.graphics.LayerRasterizer.staticClass, "addLayer", "(Landroid/graphics/Paint;)V");
			global::android.graphics.LayerRasterizer._LayerRasterizer5294 = @__env.GetMethodIDNoThrow(global::android.graphics.LayerRasterizer.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
