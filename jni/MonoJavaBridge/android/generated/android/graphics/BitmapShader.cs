namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BitmapShader : android.graphics.Shader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BitmapShader()
		{
			InitJNI();
		}
		protected BitmapShader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _BitmapShader5093;
		public BitmapShader(android.graphics.Bitmap arg0, android.graphics.Shader.TileMode arg1, android.graphics.Shader.TileMode arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.BitmapShader.staticClass, global::android.graphics.BitmapShader._BitmapShader5093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.BitmapShader.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BitmapShader"));
			global::android.graphics.BitmapShader._BitmapShader5093 = @__env.GetMethodIDNoThrow(global::android.graphics.BitmapShader.staticClass, "<init>", "(Landroid/graphics/Bitmap;Landroid/graphics/Shader$TileMode;Landroid/graphics/Shader$TileMode;)V");
		}
	}
}
