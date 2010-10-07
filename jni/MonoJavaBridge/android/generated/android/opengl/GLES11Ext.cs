namespace android.opengl
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class GLES11Ext : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static GLES11Ext()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.GLES11Ext), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.opengl.GLES11Ext(@__env);
			}
		}
		protected GLES11Ext(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBlendEquationSeparateOES5484;
		public static void glBlendEquationSeparateOES(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBlendEquationSeparateOES5484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBlendFuncSeparateOES5485;
		public static void glBlendFuncSeparateOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBlendFuncSeparateOES5485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBlendEquationOES5486;
		public static void glBlendEquationOES(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBlendEquationOES5486, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexsOES5487;
		public static void glDrawTexsOES(short arg0, short arg1, short arg2, short arg3, short arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexsOES5487, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexiOES5488;
		public static void glDrawTexiOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexiOES5488, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexxOES5489;
		public static void glDrawTexxOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexxOES5489, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexsvOES5490;
		public static void glDrawTexsvOES(short[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexsvOES5490, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexsvOES5491;
		public static void glDrawTexsvOES(java.nio.ShortBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexsvOES5491, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexivOES5492;
		public static void glDrawTexivOES(int[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexivOES5492, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexivOES5493;
		public static void glDrawTexivOES(java.nio.IntBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexivOES5493, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexxvOES5494;
		public static void glDrawTexxvOES(int[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexxvOES5494, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexxvOES5495;
		public static void glDrawTexxvOES(java.nio.IntBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexxvOES5495, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexfOES5496;
		public static void glDrawTexfOES(float arg0, float arg1, float arg2, float arg3, float arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexfOES5496, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexfvOES5497;
		public static void glDrawTexfvOES(float[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexfvOES5497, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexfvOES5498;
		public static void glDrawTexfvOES(java.nio.FloatBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexfvOES5498, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glEGLImageTargetTexture2DOES5499;
		public static void glEGLImageTargetTexture2DOES(int arg0, java.nio.Buffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glEGLImageTargetTexture2DOES5499, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glEGLImageTargetRenderbufferStorageOES5500;
		public static void glEGLImageTargetRenderbufferStorageOES(int arg0, java.nio.Buffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glEGLImageTargetRenderbufferStorageOES5500, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glAlphaFuncxOES5501;
		public static void glAlphaFuncxOES(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glAlphaFuncxOES5501, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClearColorxOES5502;
		public static void glClearColorxOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClearColorxOES5502, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClearDepthxOES5503;
		public static void glClearDepthxOES(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClearDepthxOES5503, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanexOES5504;
		public static void glClipPlanexOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanexOES5504, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanexOES5505;
		public static void glClipPlanexOES(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanexOES5505, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glColor4xOES5506;
		public static void glColor4xOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glColor4xOES5506, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDepthRangexOES5507;
		public static void glDepthRangexOES(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDepthRangexOES5507, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFogxOES5508;
		public static void glFogxOES(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFogxOES5508, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFogxvOES5509;
		public static void glFogxvOES(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFogxvOES5509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFogxvOES5510;
		public static void glFogxvOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFogxvOES5510, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFrustumxOES5511;
		public static void glFrustumxOES(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFrustumxOES5511, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanexOES5512;
		public static void glGetClipPlanexOES(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanexOES5512, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanexOES5513;
		public static void glGetClipPlanexOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanexOES5513, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetFixedvOES5514;
		public static void glGetFixedvOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFixedvOES5514, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetFixedvOES5515;
		public static void glGetFixedvOES(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFixedvOES5515, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetLightxvOES5516;
		public static void glGetLightxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetLightxvOES5516, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetLightxvOES5517;
		public static void glGetLightxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetLightxvOES5517, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetMaterialxvOES5518;
		public static void glGetMaterialxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetMaterialxvOES5518, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetMaterialxvOES5519;
		public static void glGetMaterialxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetMaterialxvOES5519, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnvxvOES5520;
		public static void glGetTexEnvxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexEnvxvOES5520, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnvxvOES5521;
		public static void glGetTexEnvxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexEnvxvOES5521, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterxvOES5522;
		public static void glGetTexParameterxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexParameterxvOES5522, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterxvOES5523;
		public static void glGetTexParameterxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexParameterxvOES5523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxOES5524;
		public static void glLightModelxOES(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightModelxOES5524, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxvOES5525;
		public static void glLightModelxvOES(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightModelxvOES5525, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxvOES5526;
		public static void glLightModelxvOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightModelxvOES5526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightxOES5527;
		public static void glLightxOES(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightxOES5527, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightxvOES5528;
		public static void glLightxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightxvOES5528, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightxvOES5529;
		public static void glLightxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightxvOES5529, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLineWidthxOES5530;
		public static void glLineWidthxOES(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLineWidthxOES5530, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixxOES5531;
		public static void glLoadMatrixxOES(int[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLoadMatrixxOES5531, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixxOES5532;
		public static void glLoadMatrixxOES(java.nio.IntBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLoadMatrixxOES5532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxOES5533;
		public static void glMaterialxOES(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMaterialxOES5533, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxvOES5534;
		public static void glMaterialxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMaterialxvOES5534, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxvOES5535;
		public static void glMaterialxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMaterialxvOES5535, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixxOES5536;
		public static void glMultMatrixxOES(int[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMultMatrixxOES5536, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixxOES5537;
		public static void glMultMatrixxOES(java.nio.IntBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMultMatrixxOES5537, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMultiTexCoord4xOES5538;
		public static void glMultiTexCoord4xOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMultiTexCoord4xOES5538, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glNormal3xOES5539;
		public static void glNormal3xOES(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glNormal3xOES5539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glOrthoxOES5540;
		public static void glOrthoxOES(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glOrthoxOES5540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterxOES5541;
		public static void glPointParameterxOES(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointParameterxOES5541, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterxvOES5542;
		public static void glPointParameterxvOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointParameterxvOES5542, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterxvOES5543;
		public static void glPointParameterxvOES(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointParameterxvOES5543, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPointSizexOES5544;
		public static void glPointSizexOES(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointSizexOES5544, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPolygonOffsetxOES5545;
		public static void glPolygonOffsetxOES(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPolygonOffsetxOES5545, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glRotatexOES5546;
		public static void glRotatexOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glRotatexOES5546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glSampleCoveragexOES5547;
		public static void glSampleCoveragexOES(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glSampleCoveragexOES5547, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glScalexOES5548;
		public static void glScalexOES(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glScalexOES5548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxOES5549;
		public static void glTexEnvxOES(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexEnvxOES5549, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxvOES5550;
		public static void glTexEnvxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexEnvxvOES5550, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxvOES5551;
		public static void glTexEnvxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexEnvxvOES5551, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterxOES5552;
		public static void glTexParameterxOES(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexParameterxOES5552, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterxvOES5553;
		public static void glTexParameterxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexParameterxvOES5553, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterxvOES5554;
		public static void glTexParameterxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexParameterxvOES5554, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTranslatexOES5555;
		public static void glTranslatexOES(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTranslatexOES5555, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glIsRenderbufferOES5556;
		public static bool glIsRenderbufferOES(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glIsRenderbufferOES5556, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBindRenderbufferOES5557;
		public static void glBindRenderbufferOES(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBindRenderbufferOES5557, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteRenderbuffersOES5558;
		public static void glDeleteRenderbuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES5558, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteRenderbuffersOES5559;
		public static void glDeleteRenderbuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES5559, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenRenderbuffersOES5560;
		public static void glGenRenderbuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenRenderbuffersOES5560, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenRenderbuffersOES5561;
		public static void glGenRenderbuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenRenderbuffersOES5561, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glRenderbufferStorageOES5562;
		public static void glRenderbufferStorageOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glRenderbufferStorageOES5562, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetRenderbufferParameterivOES5563;
		public static void glGetRenderbufferParameterivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES5563, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetRenderbufferParameterivOES5564;
		public static void glGetRenderbufferParameterivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES5564, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glIsFramebufferOES5565;
		public static bool glIsFramebufferOES(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glIsFramebufferOES5565, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBindFramebufferOES5566;
		public static void glBindFramebufferOES(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBindFramebufferOES5566, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteFramebuffersOES5567;
		public static void glDeleteFramebuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteFramebuffersOES5567, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteFramebuffersOES5568;
		public static void glDeleteFramebuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteFramebuffersOES5568, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenFramebuffersOES5569;
		public static void glGenFramebuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenFramebuffersOES5569, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenFramebuffersOES5570;
		public static void glGenFramebuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenFramebuffersOES5570, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCheckFramebufferStatusOES5571;
		public static int glCheckFramebufferStatusOES(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glCheckFramebufferStatusOES5571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFramebufferRenderbufferOES5572;
		public static void glFramebufferRenderbufferOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFramebufferRenderbufferOES5572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFramebufferTexture2DOES5573;
		public static void glFramebufferTexture2DOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFramebufferTexture2DOES5573, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetFramebufferAttachmentParameterivOES5574;
		public static void glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, int[] arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES5574, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetFramebufferAttachmentParameterivOES5575;
		public static void glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES5575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenerateMipmapOES5576;
		public static void glGenerateMipmapOES(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenerateMipmapOES5576, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCurrentPaletteMatrixOES5577;
		public static void glCurrentPaletteMatrixOES(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glCurrentPaletteMatrixOES5577, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLoadPaletteFromModelViewMatrixOES5578;
		public static void glLoadPaletteFromModelViewMatrixOES() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLoadPaletteFromModelViewMatrixOES5578);
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMatrixIndexPointerOES5579;
		public static void glMatrixIndexPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMatrixIndexPointerOES5579, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glWeightPointerOES5580;
		public static void glWeightPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glWeightPointerOES5580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDepthRangefOES5581;
		public static void glDepthRangefOES(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDepthRangefOES5581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFrustumfOES5582;
		public static void glFrustumfOES(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFrustumfOES5582, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glOrthofOES5583;
		public static void glOrthofOES(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glOrthofOES5583, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanefOES5584;
		public static void glClipPlanefOES(int arg0, float[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanefOES5584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanefOES5585;
		public static void glClipPlanefOES(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanefOES5585, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanefOES5586;
		public static void glGetClipPlanefOES(int arg0, float[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanefOES5586, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanefOES5587;
		public static void glGetClipPlanefOES(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanefOES5587, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClearDepthfOES5588;
		public static void glClearDepthfOES(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClearDepthfOES5588, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenfOES5589;
		public static void glTexGenfOES(int arg0, int arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenfOES5589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenfvOES5590;
		public static void glTexGenfvOES(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenfvOES5590, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenfvOES5591;
		public static void glTexGenfvOES(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenfvOES5591, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexGeniOES5592;
		public static void glTexGeniOES(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGeniOES5592, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenivOES5593;
		public static void glTexGenivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenivOES5593, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenivOES5594;
		public static void glTexGenivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenivOES5594, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenxOES5595;
		public static void glTexGenxOES(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenxOES5595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenxvOES5596;
		public static void glTexGenxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenxvOES5596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenxvOES5597;
		public static void glTexGenxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenxvOES5597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenfvOES5598;
		public static void glGetTexGenfvOES(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenfvOES5598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenfvOES5599;
		public static void glGetTexGenfvOES(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenfvOES5599, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenivOES5600;
		public static void glGetTexGenivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenivOES5600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenivOES5601;
		public static void glGetTexGenivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenivOES5601, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenxvOES5602;
		public static void glGetTexGenxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenxvOES5602, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenxvOES5603;
		public static void glGetTexGenxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenxvOES5603, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GLES11Ext5604;
		public GLES11Ext()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._GLES11Ext5604, this);
		}
		public static int GL_BLEND_EQUATION_RGB_OES
		{
			get
			{
				return 32777;
			}
		}
		public static int GL_BLEND_EQUATION_ALPHA_OES
		{
			get
			{
				return 34877;
			}
		}
		public static int GL_BLEND_DST_RGB_OES
		{
			get
			{
				return 32968;
			}
		}
		public static int GL_BLEND_SRC_RGB_OES
		{
			get
			{
				return 32969;
			}
		}
		public static int GL_BLEND_DST_ALPHA_OES
		{
			get
			{
				return 32970;
			}
		}
		public static int GL_BLEND_SRC_ALPHA_OES
		{
			get
			{
				return 32971;
			}
		}
		public static int GL_BLEND_EQUATION_OES
		{
			get
			{
				return 32777;
			}
		}
		public static int GL_FUNC_ADD_OES
		{
			get
			{
				return 32774;
			}
		}
		public static int GL_FUNC_SUBTRACT_OES
		{
			get
			{
				return 32778;
			}
		}
		public static int GL_FUNC_REVERSE_SUBTRACT_OES
		{
			get
			{
				return 32779;
			}
		}
		public static int GL_ETC1_RGB8_OES
		{
			get
			{
				return 36196;
			}
		}
		public static int GL_DEPTH_COMPONENT24_OES
		{
			get
			{
				return 33190;
			}
		}
		public static int GL_DEPTH_COMPONENT32_OES
		{
			get
			{
				return 33191;
			}
		}
		public static int GL_TEXTURE_CROP_RECT_OES
		{
			get
			{
				return 35741;
			}
		}
		public static int GL_FIXED_OES
		{
			get
			{
				return 5132;
			}
		}
		public static int GL_NONE_OES
		{
			get
			{
				return 0;
			}
		}
		public static int GL_FRAMEBUFFER_OES
		{
			get
			{
				return 36160;
			}
		}
		public static int GL_RENDERBUFFER_OES
		{
			get
			{
				return 36161;
			}
		}
		public static int GL_RGBA4_OES
		{
			get
			{
				return 32854;
			}
		}
		public static int GL_RGB5_A1_OES
		{
			get
			{
				return 32855;
			}
		}
		public static int GL_RGB565_OES
		{
			get
			{
				return 36194;
			}
		}
		public static int GL_DEPTH_COMPONENT16_OES
		{
			get
			{
				return 33189;
			}
		}
		public static int GL_RENDERBUFFER_WIDTH_OES
		{
			get
			{
				return 36162;
			}
		}
		public static int GL_RENDERBUFFER_HEIGHT_OES
		{
			get
			{
				return 36163;
			}
		}
		public static int GL_RENDERBUFFER_INTERNAL_FORMAT_OES
		{
			get
			{
				return 36164;
			}
		}
		public static int GL_RENDERBUFFER_RED_SIZE_OES
		{
			get
			{
				return 36176;
			}
		}
		public static int GL_RENDERBUFFER_GREEN_SIZE_OES
		{
			get
			{
				return 36177;
			}
		}
		public static int GL_RENDERBUFFER_BLUE_SIZE_OES
		{
			get
			{
				return 36178;
			}
		}
		public static int GL_RENDERBUFFER_ALPHA_SIZE_OES
		{
			get
			{
				return 36179;
			}
		}
		public static int GL_RENDERBUFFER_DEPTH_SIZE_OES
		{
			get
			{
				return 36180;
			}
		}
		public static int GL_RENDERBUFFER_STENCIL_SIZE_OES
		{
			get
			{
				return 36181;
			}
		}
		public static int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES
		{
			get
			{
				return 36048;
			}
		}
		public static int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES
		{
			get
			{
				return 36049;
			}
		}
		public static int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES
		{
			get
			{
				return 36050;
			}
		}
		public static int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES
		{
			get
			{
				return 36051;
			}
		}
		public static int GL_COLOR_ATTACHMENT0_OES
		{
			get
			{
				return 36064;
			}
		}
		public static int GL_DEPTH_ATTACHMENT_OES
		{
			get
			{
				return 36096;
			}
		}
		public static int GL_STENCIL_ATTACHMENT_OES
		{
			get
			{
				return 36128;
			}
		}
		public static int GL_FRAMEBUFFER_COMPLETE_OES
		{
			get
			{
				return 36053;
			}
		}
		public static int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES
		{
			get
			{
				return 36054;
			}
		}
		public static int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES
		{
			get
			{
				return 36055;
			}
		}
		public static int GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES
		{
			get
			{
				return 36057;
			}
		}
		public static int GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES
		{
			get
			{
				return 36058;
			}
		}
		public static int GL_FRAMEBUFFER_UNSUPPORTED_OES
		{
			get
			{
				return 36061;
			}
		}
		public static int GL_FRAMEBUFFER_BINDING_OES
		{
			get
			{
				return 36006;
			}
		}
		public static int GL_RENDERBUFFER_BINDING_OES
		{
			get
			{
				return 36007;
			}
		}
		public static int GL_MAX_RENDERBUFFER_SIZE_OES
		{
			get
			{
				return 34024;
			}
		}
		public static int GL_INVALID_FRAMEBUFFER_OPERATION_OES
		{
			get
			{
				return 1286;
			}
		}
		public static int GL_WRITE_ONLY_OES
		{
			get
			{
				return 35001;
			}
		}
		public static int GL_BUFFER_ACCESS_OES
		{
			get
			{
				return 35003;
			}
		}
		public static int GL_BUFFER_MAPPED_OES
		{
			get
			{
				return 35004;
			}
		}
		public static int GL_BUFFER_MAP_POINTER_OES
		{
			get
			{
				return 35005;
			}
		}
		public static int GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES
		{
			get
			{
				return 35213;
			}
		}
		public static int GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES
		{
			get
			{
				return 35214;
			}
		}
		public static int GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES
		{
			get
			{
				return 35215;
			}
		}
		public static int GL_MAX_VERTEX_UNITS_OES
		{
			get
			{
				return 34468;
			}
		}
		public static int GL_MAX_PALETTE_MATRICES_OES
		{
			get
			{
				return 34882;
			}
		}
		public static int GL_MATRIX_PALETTE_OES
		{
			get
			{
				return 34880;
			}
		}
		public static int GL_MATRIX_INDEX_ARRAY_OES
		{
			get
			{
				return 34884;
			}
		}
		public static int GL_WEIGHT_ARRAY_OES
		{
			get
			{
				return 34477;
			}
		}
		public static int GL_CURRENT_PALETTE_MATRIX_OES
		{
			get
			{
				return 34883;
			}
		}
		public static int GL_MATRIX_INDEX_ARRAY_SIZE_OES
		{
			get
			{
				return 34886;
			}
		}
		public static int GL_MATRIX_INDEX_ARRAY_TYPE_OES
		{
			get
			{
				return 34887;
			}
		}
		public static int GL_MATRIX_INDEX_ARRAY_STRIDE_OES
		{
			get
			{
				return 34888;
			}
		}
		public static int GL_MATRIX_INDEX_ARRAY_POINTER_OES
		{
			get
			{
				return 34889;
			}
		}
		public static int GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES
		{
			get
			{
				return 35742;
			}
		}
		public static int GL_WEIGHT_ARRAY_SIZE_OES
		{
			get
			{
				return 34475;
			}
		}
		public static int GL_WEIGHT_ARRAY_TYPE_OES
		{
			get
			{
				return 34473;
			}
		}
		public static int GL_WEIGHT_ARRAY_STRIDE_OES
		{
			get
			{
				return 34474;
			}
		}
		public static int GL_WEIGHT_ARRAY_POINTER_OES
		{
			get
			{
				return 34476;
			}
		}
		public static int GL_WEIGHT_ARRAY_BUFFER_BINDING_OES
		{
			get
			{
				return 34974;
			}
		}
		public static int GL_DEPTH_STENCIL_OES
		{
			get
			{
				return 34041;
			}
		}
		public static int GL_UNSIGNED_INT_24_8_OES
		{
			get
			{
				return 34042;
			}
		}
		public static int GL_DEPTH24_STENCIL8_OES
		{
			get
			{
				return 35056;
			}
		}
		public static int GL_RGB8_OES
		{
			get
			{
				return 32849;
			}
		}
		public static int GL_RGBA8_OES
		{
			get
			{
				return 32856;
			}
		}
		public static int GL_STENCIL_INDEX1_OES
		{
			get
			{
				return 36166;
			}
		}
		public static int GL_STENCIL_INDEX4_OES
		{
			get
			{
				return 36167;
			}
		}
		public static int GL_STENCIL_INDEX8_OES
		{
			get
			{
				return 36168;
			}
		}
		public static int GL_INCR_WRAP_OES
		{
			get
			{
				return 34055;
			}
		}
		public static int GL_DECR_WRAP_OES
		{
			get
			{
				return 34056;
			}
		}
		public static int GL_NORMAL_MAP_OES
		{
			get
			{
				return 34065;
			}
		}
		public static int GL_REFLECTION_MAP_OES
		{
			get
			{
				return 34066;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_OES
		{
			get
			{
				return 34067;
			}
		}
		public static int GL_TEXTURE_BINDING_CUBE_MAP_OES
		{
			get
			{
				return 34068;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES
		{
			get
			{
				return 34069;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES
		{
			get
			{
				return 34070;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES
		{
			get
			{
				return 34071;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES
		{
			get
			{
				return 34072;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES
		{
			get
			{
				return 34073;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES
		{
			get
			{
				return 34074;
			}
		}
		public static int GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES
		{
			get
			{
				return 34076;
			}
		}
		public static int GL_TEXTURE_GEN_MODE_OES
		{
			get
			{
				return 9472;
			}
		}
		public static int GL_TEXTURE_GEN_STR_OES
		{
			get
			{
				return 36192;
			}
		}
		public static int GL_MIRRORED_REPEAT_OES
		{
			get
			{
				return 33648;
			}
		}
		public static int GL_3DC_X_AMD
		{
			get
			{
				return 34809;
			}
		}
		public static int GL_3DC_XY_AMD
		{
			get
			{
				return 34810;
			}
		}
		public static int GL_ATC_RGB_AMD
		{
			get
			{
				return 35986;
			}
		}
		public static int GL_ATC_RGBA_EXPLICIT_ALPHA_AMD
		{
			get
			{
				return 35987;
			}
		}
		public static int GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD
		{
			get
			{
				return 34798;
			}
		}
		public static int GL_TEXTURE_MAX_ANISOTROPY_EXT
		{
			get
			{
				return 34046;
			}
		}
		public static int GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT
		{
			get
			{
				return 34047;
			}
		}
		public static int GL_BGRA
		{
			get
			{
				return 32993;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.opengl.GLES11Ext.staticClass = @__class;
			global::android.opengl.GLES11Ext._glBlendEquationSeparateOES5484 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glBlendEquationSeparateOES", "(II)V");
			global::android.opengl.GLES11Ext._glBlendFuncSeparateOES5485 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glBlendFuncSeparateOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glBlendEquationOES5486 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glBlendEquationOES", "(I)V");
			global::android.opengl.GLES11Ext._glDrawTexsOES5487 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsOES", "(SSSSS)V");
			global::android.opengl.GLES11Ext._glDrawTexiOES5488 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexiOES", "(IIIII)V");
			global::android.opengl.GLES11Ext._glDrawTexxOES5489 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxOES", "(IIIII)V");
			global::android.opengl.GLES11Ext._glDrawTexsvOES5490 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsvOES", "([SI)V");
			global::android.opengl.GLES11Ext._glDrawTexsvOES5491 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsvOES", "(Ljava/nio/ShortBuffer;)V");
			global::android.opengl.GLES11Ext._glDrawTexivOES5492 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexivOES", "([II)V");
			global::android.opengl.GLES11Ext._glDrawTexivOES5493 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexivOES", "(Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glDrawTexxvOES5494 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxvOES", "([II)V");
			global::android.opengl.GLES11Ext._glDrawTexxvOES5495 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxvOES", "(Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glDrawTexfOES5496 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfOES", "(FFFFF)V");
			global::android.opengl.GLES11Ext._glDrawTexfvOES5497 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfvOES", "([FI)V");
			global::android.opengl.GLES11Ext._glDrawTexfvOES5498 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfvOES", "(Ljava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11Ext._glEGLImageTargetTexture2DOES5499 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glEGLImageTargetTexture2DOES", "(ILjava/nio/Buffer;)V");
			global::android.opengl.GLES11Ext._glEGLImageTargetRenderbufferStorageOES5500 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glEGLImageTargetRenderbufferStorageOES", "(ILjava/nio/Buffer;)V");
			global::android.opengl.GLES11Ext._glAlphaFuncxOES5501 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glAlphaFuncxOES", "(II)V");
			global::android.opengl.GLES11Ext._glClearColorxOES5502 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClearColorxOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glClearDepthxOES5503 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClearDepthxOES", "(I)V");
			global::android.opengl.GLES11Ext._glClipPlanexOES5504 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClipPlanexOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glClipPlanexOES5505 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClipPlanexOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glColor4xOES5506 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glColor4xOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glDepthRangexOES5507 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDepthRangexOES", "(II)V");
			global::android.opengl.GLES11Ext._glFogxOES5508 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFogxOES", "(II)V");
			global::android.opengl.GLES11Ext._glFogxvOES5509 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFogxvOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glFogxvOES5510 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFogxvOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glFrustumxOES5511 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFrustumxOES", "(IIIIII)V");
			global::android.opengl.GLES11Ext._glGetClipPlanexOES5512 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanexOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glGetClipPlanexOES5513 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanexOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetFixedvOES5514 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetFixedvOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetFixedvOES5515 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetFixedvOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glGetLightxvOES5516 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetLightxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetLightxvOES5517 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetLightxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetMaterialxvOES5518 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetMaterialxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetMaterialxvOES5519 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetMaterialxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetTexEnvxvOES5520 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexEnvxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetTexEnvxvOES5521 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexEnvxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetTexParameterxvOES5522 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexParameterxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetTexParameterxvOES5523 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexParameterxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glLightModelxOES5524 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightModelxOES", "(II)V");
			global::android.opengl.GLES11Ext._glLightModelxvOES5525 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightModelxvOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glLightModelxvOES5526 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightModelxvOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glLightxOES5527 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightxOES", "(III)V");
			global::android.opengl.GLES11Ext._glLightxvOES5528 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glLightxvOES5529 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glLineWidthxOES5530 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLineWidthxOES", "(I)V");
			global::android.opengl.GLES11Ext._glLoadMatrixxOES5531 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLoadMatrixxOES", "([II)V");
			global::android.opengl.GLES11Ext._glLoadMatrixxOES5532 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLoadMatrixxOES", "(Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glMaterialxOES5533 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMaterialxOES", "(III)V");
			global::android.opengl.GLES11Ext._glMaterialxvOES5534 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMaterialxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glMaterialxvOES5535 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMaterialxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glMultMatrixxOES5536 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMultMatrixxOES", "([II)V");
			global::android.opengl.GLES11Ext._glMultMatrixxOES5537 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMultMatrixxOES", "(Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glMultiTexCoord4xOES5538 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMultiTexCoord4xOES", "(IIIII)V");
			global::android.opengl.GLES11Ext._glNormal3xOES5539 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glNormal3xOES", "(III)V");
			global::android.opengl.GLES11Ext._glOrthoxOES5540 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glOrthoxOES", "(IIIIII)V");
			global::android.opengl.GLES11Ext._glPointParameterxOES5541 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxOES", "(II)V");
			global::android.opengl.GLES11Ext._glPointParameterxvOES5542 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxvOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glPointParameterxvOES5543 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxvOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glPointSizexOES5544 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glPointSizexOES", "(I)V");
			global::android.opengl.GLES11Ext._glPolygonOffsetxOES5545 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glPolygonOffsetxOES", "(II)V");
			global::android.opengl.GLES11Ext._glRotatexOES5546 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glRotatexOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glSampleCoveragexOES5547 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glSampleCoveragexOES", "(IZ)V");
			global::android.opengl.GLES11Ext._glScalexOES5548 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glScalexOES", "(III)V");
			global::android.opengl.GLES11Ext._glTexEnvxOES5549 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxOES", "(III)V");
			global::android.opengl.GLES11Ext._glTexEnvxvOES5550 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glTexEnvxvOES5551 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glTexParameterxOES5552 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxOES", "(III)V");
			global::android.opengl.GLES11Ext._glTexParameterxvOES5553 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glTexParameterxvOES5554 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glTranslatexOES5555 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTranslatexOES", "(III)V");
			global::android.opengl.GLES11Ext._glIsRenderbufferOES5556 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glIsRenderbufferOES", "(I)Z");
			global::android.opengl.GLES11Ext._glBindRenderbufferOES5557 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glBindRenderbufferOES", "(II)V");
			global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES5558 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDeleteRenderbuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES5559 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDeleteRenderbuffersOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glGenRenderbuffersOES5560 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGenRenderbuffersOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glGenRenderbuffersOES5561 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGenRenderbuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glRenderbufferStorageOES5562 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glRenderbufferStorageOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES5563 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetRenderbufferParameterivOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES5564 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetRenderbufferParameterivOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glIsFramebufferOES5565 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glIsFramebufferOES", "(I)Z");
			global::android.opengl.GLES11Ext._glBindFramebufferOES5566 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glBindFramebufferOES", "(II)V");
			global::android.opengl.GLES11Ext._glDeleteFramebuffersOES5567 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDeleteFramebuffersOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glDeleteFramebuffersOES5568 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDeleteFramebuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGenFramebuffersOES5569 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGenFramebuffersOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glGenFramebuffersOES5570 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGenFramebuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glCheckFramebufferStatusOES5571 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glCheckFramebufferStatusOES", "(I)I");
			global::android.opengl.GLES11Ext._glFramebufferRenderbufferOES5572 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFramebufferRenderbufferOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glFramebufferTexture2DOES5573 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFramebufferTexture2DOES", "(IIIII)V");
			global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES5574 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetFramebufferAttachmentParameterivOES", "(III[II)V");
			global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES5575 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetFramebufferAttachmentParameterivOES", "(IIILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGenerateMipmapOES5576 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGenerateMipmapOES", "(I)V");
			global::android.opengl.GLES11Ext._glCurrentPaletteMatrixOES5577 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glCurrentPaletteMatrixOES", "(I)V");
			global::android.opengl.GLES11Ext._glLoadPaletteFromModelViewMatrixOES5578 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLoadPaletteFromModelViewMatrixOES", "()V");
			global::android.opengl.GLES11Ext._glMatrixIndexPointerOES5579 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMatrixIndexPointerOES", "(IIILjava/nio/Buffer;)V");
			global::android.opengl.GLES11Ext._glWeightPointerOES5580 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glWeightPointerOES", "(IIILjava/nio/Buffer;)V");
			global::android.opengl.GLES11Ext._glDepthRangefOES5581 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDepthRangefOES", "(FF)V");
			global::android.opengl.GLES11Ext._glFrustumfOES5582 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFrustumfOES", "(FFFFFF)V");
			global::android.opengl.GLES11Ext._glOrthofOES5583 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glOrthofOES", "(FFFFFF)V");
			global::android.opengl.GLES11Ext._glClipPlanefOES5584 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClipPlanefOES", "(I[FI)V");
			global::android.opengl.GLES11Ext._glClipPlanefOES5585 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClipPlanefOES", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11Ext._glGetClipPlanefOES5586 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanefOES", "(I[FI)V");
			global::android.opengl.GLES11Ext._glGetClipPlanefOES5587 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanefOES", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11Ext._glClearDepthfOES5588 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClearDepthfOES", "(F)V");
			global::android.opengl.GLES11Ext._glTexGenfOES5589 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenfOES", "(IIF)V");
			global::android.opengl.GLES11Ext._glTexGenfvOES5590 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenfvOES", "(II[FI)V");
			global::android.opengl.GLES11Ext._glTexGenfvOES5591 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenfvOES", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11Ext._glTexGeniOES5592 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGeniOES", "(III)V");
			global::android.opengl.GLES11Ext._glTexGenivOES5593 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenivOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glTexGenivOES5594 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenivOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glTexGenxOES5595 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenxOES", "(III)V");
			global::android.opengl.GLES11Ext._glTexGenxvOES5596 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glTexGenxvOES5597 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetTexGenfvOES5598 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenfvOES", "(II[FI)V");
			global::android.opengl.GLES11Ext._glGetTexGenfvOES5599 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenfvOES", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11Ext._glGetTexGenivOES5600 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenivOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetTexGenivOES5601 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenivOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetTexGenxvOES5602 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetTexGenxvOES5603 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._GLES11Ext5604 = @__env.GetMethodID(global::android.opengl.GLES11Ext.staticClass, "<init>", "()V");
		}
	}
}
