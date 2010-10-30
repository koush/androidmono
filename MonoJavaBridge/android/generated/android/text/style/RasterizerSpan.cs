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
		internal static global::MonoJavaBridge.MethodId _getRasterizer13542;
		public virtual global::android.graphics.Rasterizer getRasterizer()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.style.RasterizerSpan.staticClass, global::android.text.style.RasterizerSpan._getRasterizer13542)) as android.graphics.Rasterizer;
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13543;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.RasterizerSpan.staticClass, global::android.text.style.RasterizerSpan._updateDrawState13543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RasterizerSpan13544;
		public RasterizerSpan(android.graphics.Rasterizer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.RasterizerSpan.staticClass, global::android.text.style.RasterizerSpan._RasterizerSpan13544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RasterizerSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.RasterizerSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/RasterizerSpan"));
			global::android.text.style.RasterizerSpan._getRasterizer13542 = @__env.GetMethodIDNoThrow(global::android.text.style.RasterizerSpan.staticClass, "getRasterizer", "()Landroid/graphics/Rasterizer;");
			global::android.text.style.RasterizerSpan._updateDrawState13543 = @__env.GetMethodIDNoThrow(global::android.text.style.RasterizerSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.RasterizerSpan._RasterizerSpan13544 = @__env.GetMethodIDNoThrow(global::android.text.style.RasterizerSpan.staticClass, "<init>", "(Landroid/graphics/Rasterizer;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
