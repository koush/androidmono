namespace android.opengl
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Visibility : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Visibility()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.Visibility), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.opengl.Visibility(@__env);
			}
		}
		protected Visibility(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _visibilityTest5327;
		public static int visibilityTest(float[] arg0, int arg1, float[] arg2, int arg3, char[] arg4, int arg5, int arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.Visibility.staticClass, global::android.opengl.Visibility._visibilityTest5327, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _frustumCullSpheres5328;
		public static int frustumCullSpheres(float[] arg0, int arg1, float[] arg2, int arg3, int arg4, int[] arg5, int arg6, int arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.Visibility.staticClass, global::android.opengl.Visibility._frustumCullSpheres5328, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeBoundingSphere5329;
		public static void computeBoundingSphere(float[] arg0, int arg1, int arg2, float[] arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Visibility.staticClass, global::android.opengl.Visibility._computeBoundingSphere5329, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Visibility5330;
		public Visibility()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.opengl.Visibility.staticClass, global::android.opengl.Visibility._Visibility5330, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.opengl.Visibility.staticClass = @__class;
			global::android.opengl.Visibility._visibilityTest5327 = @__env.GetStaticMethodID(global::android.opengl.Visibility.staticClass, "visibilityTest", "([FI[FI[CII)I");
			global::android.opengl.Visibility._frustumCullSpheres5328 = @__env.GetStaticMethodID(global::android.opengl.Visibility.staticClass, "frustumCullSpheres", "([FI[FII[III)I");
			global::android.opengl.Visibility._computeBoundingSphere5329 = @__env.GetStaticMethodID(global::android.opengl.Visibility.staticClass, "computeBoundingSphere", "([FII[FI)V");
			global::android.opengl.Visibility._Visibility5330 = @__env.GetMethodID(global::android.opengl.Visibility.staticClass, "<init>", "()V");
		}
	}
}
