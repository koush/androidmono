namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SweepGradient : android.graphics.Shader
	{
		internal new static global::java.lang.Class staticClass;
		static SweepGradient()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.SweepGradient), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.SweepGradient(@__env);
			}
		}
		protected SweepGradient(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _SweepGradient3415;
		public SweepGradient(float arg0, float arg1, int[] arg2, float[] arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.SweepGradient.staticClass, global::android.graphics.SweepGradient._SweepGradient3415, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SweepGradient3416;
		public SweepGradient(float arg0, float arg1, int arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.SweepGradient.staticClass, global::android.graphics.SweepGradient._SweepGradient3416, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.SweepGradient.staticClass = @__class;
			global::android.graphics.SweepGradient._SweepGradient3415 = @__env.GetMethodID(global::android.graphics.SweepGradient.staticClass, "<init>", "(FF[I[F)V");
			global::android.graphics.SweepGradient._SweepGradient3416 = @__env.GetMethodID(global::android.graphics.SweepGradient.staticClass, "<init>", "(FFII)V");
		}
	}
}
