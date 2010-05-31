namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class LinearGradient : android.graphics.Shader
	{
		internal new static global::java.lang.Class staticClass;
		static LinearGradient()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.LinearGradient), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.LinearGradient(@__env);
			}
		}
		protected LinearGradient(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _LinearGradient2956;
		public LinearGradient(float arg0, float arg1, float arg2, float arg3, int[] arg4, float[] arg5, android.graphics.Shader.TileMode arg6)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.LinearGradient.staticClass, global::android.graphics.LinearGradient._LinearGradient2956, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _LinearGradient2957;
		public LinearGradient(float arg0, float arg1, float arg2, float arg3, int arg4, int arg5, android.graphics.Shader.TileMode arg6)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.LinearGradient.staticClass, global::android.graphics.LinearGradient._LinearGradient2957, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.LinearGradient.staticClass = @__class;
			global::android.graphics.LinearGradient._LinearGradient2956 = @__env.GetMethodID(global::android.graphics.LinearGradient.staticClass, "<init>", "(FFFF[I[FLandroid/graphics/Shader$TileMode;)V");
			global::android.graphics.LinearGradient._LinearGradient2957 = @__env.GetMethodID(global::android.graphics.LinearGradient.staticClass, "<init>", "(FFFFIILandroid/graphics/Shader$TileMode;)V");
		}
	}
}
