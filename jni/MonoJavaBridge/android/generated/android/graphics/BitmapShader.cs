namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BitmapShader : android.graphics.Shader
	{
		internal new static global::java.lang.Class staticClass;
		static BitmapShader()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.BitmapShader), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.BitmapShader(@__env);
			}
		}
		protected BitmapShader(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _BitmapShader2784;
		public BitmapShader(android.graphics.Bitmap arg0, android.graphics.Shader.TileMode arg1, android.graphics.Shader.TileMode arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.BitmapShader.staticClass, global::android.graphics.BitmapShader._BitmapShader2784, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.BitmapShader.staticClass = @__class;
			global::android.graphics.BitmapShader._BitmapShader2784 = @__env.GetMethodID(global::android.graphics.BitmapShader.staticClass, "<init>", "(Landroid/graphics/Bitmap;Landroid/graphics/Shader$TileMode;Landroid/graphics/Shader$TileMode;)V");
		}
	}
}
