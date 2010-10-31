namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RasterizerSpan : android.text.style.CharacterStyle, UpdateAppearance
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RasterizerSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::android.graphics.Rasterizer Rasterizer
		{
			get
			{
				return getRasterizer();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.graphics.Rasterizer getRasterizer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.style.RasterizerSpan.staticClass, "getRasterizer", "()Landroid/graphics/Rasterizer;", ref global::android.text.style.RasterizerSpan._m0) as android.graphics.Rasterizer;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.RasterizerSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.RasterizerSpan._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public RasterizerSpan(android.graphics.Rasterizer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.RasterizerSpan._m2.native == global::System.IntPtr.Zero)
				global::android.text.style.RasterizerSpan._m2 = @__env.GetMethodIDNoThrow(global::android.text.style.RasterizerSpan.staticClass, "<init>", "(Landroid/graphics/Rasterizer;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.RasterizerSpan.staticClass, global::android.text.style.RasterizerSpan._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RasterizerSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.RasterizerSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/RasterizerSpan"));
		}
	}
}
