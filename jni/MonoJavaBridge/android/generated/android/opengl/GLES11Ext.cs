namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLES11Ext : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GLES11Ext()
		{
			InitJNI();
		}
		protected GLES11Ext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _glBlendEquationSeparateOES5748;
		public static void glBlendEquationSeparateOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBlendEquationSeparateOES5748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendFuncSeparateOES5749;
		public static void glBlendFuncSeparateOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBlendFuncSeparateOES5749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendEquationOES5750;
		public static void glBlendEquationOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBlendEquationOES5750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexsOES5751;
		public static void glDrawTexsOES(short arg0, short arg1, short arg2, short arg3, short arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexsOES5751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexiOES5752;
		public static void glDrawTexiOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexiOES5752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexxOES5753;
		public static void glDrawTexxOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexxOES5753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexsvOES5754;
		public static void glDrawTexsvOES(short[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexsvOES5754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexsvOES5755;
		public static void glDrawTexsvOES(java.nio.ShortBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexsvOES5755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexivOES5756;
		public static void glDrawTexivOES(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexivOES5756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexivOES5757;
		public static void glDrawTexivOES(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexivOES5757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexxvOES5758;
		public static void glDrawTexxvOES(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexxvOES5758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexxvOES5759;
		public static void glDrawTexxvOES(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexxvOES5759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexfOES5760;
		public static void glDrawTexfOES(float arg0, float arg1, float arg2, float arg3, float arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexfOES5760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexfvOES5761;
		public static void glDrawTexfvOES(float[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexfvOES5761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexfvOES5762;
		public static void glDrawTexfvOES(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexfvOES5762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glEGLImageTargetTexture2DOES5763;
		public static void glEGLImageTargetTexture2DOES(int arg0, java.nio.Buffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glEGLImageTargetTexture2DOES5763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glEGLImageTargetRenderbufferStorageOES5764;
		public static void glEGLImageTargetRenderbufferStorageOES(int arg0, java.nio.Buffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glEGLImageTargetRenderbufferStorageOES5764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFuncxOES5765;
		public static void glAlphaFuncxOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glAlphaFuncxOES5765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColorxOES5766;
		public static void glClearColorxOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClearColorxOES5766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthxOES5767;
		public static void glClearDepthxOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClearDepthxOES5767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanexOES5768;
		public static void glClipPlanexOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanexOES5768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanexOES5769;
		public static void glClipPlanexOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanexOES5769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4xOES5770;
		public static void glColor4xOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glColor4xOES5770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangexOES5771;
		public static void glDepthRangexOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDepthRangexOES5771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxOES5772;
		public static void glFogxOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFogxOES5772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxvOES5773;
		public static void glFogxvOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFogxvOES5773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxvOES5774;
		public static void glFogxvOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFogxvOES5774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumxOES5775;
		public static void glFrustumxOES(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFrustumxOES5775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanexOES5776;
		public static void glGetClipPlanexOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanexOES5776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanexOES5777;
		public static void glGetClipPlanexOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanexOES5777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFixedvOES5778;
		public static void glGetFixedvOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFixedvOES5778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFixedvOES5779;
		public static void glGetFixedvOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFixedvOES5779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightxvOES5780;
		public static void glGetLightxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetLightxvOES5780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightxvOES5781;
		public static void glGetLightxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetLightxvOES5781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialxvOES5782;
		public static void glGetMaterialxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetMaterialxvOES5782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialxvOES5783;
		public static void glGetMaterialxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetMaterialxvOES5783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvxvOES5784;
		public static void glGetTexEnvxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexEnvxvOES5784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvxvOES5785;
		public static void glGetTexEnvxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexEnvxvOES5785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterxvOES5786;
		public static void glGetTexParameterxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexParameterxvOES5786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterxvOES5787;
		public static void glGetTexParameterxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexParameterxvOES5787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxOES5788;
		public static void glLightModelxOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightModelxOES5788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxvOES5789;
		public static void glLightModelxvOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightModelxvOES5789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxvOES5790;
		public static void glLightModelxvOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightModelxvOES5790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxOES5791;
		public static void glLightxOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightxOES5791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxvOES5792;
		public static void glLightxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightxvOES5792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxvOES5793;
		public static void glLightxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightxvOES5793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidthxOES5794;
		public static void glLineWidthxOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLineWidthxOES5794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixxOES5795;
		public static void glLoadMatrixxOES(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLoadMatrixxOES5795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixxOES5796;
		public static void glLoadMatrixxOES(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLoadMatrixxOES5796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxOES5797;
		public static void glMaterialxOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMaterialxOES5797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxvOES5798;
		public static void glMaterialxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMaterialxvOES5798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxvOES5799;
		public static void glMaterialxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMaterialxvOES5799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixxOES5800;
		public static void glMultMatrixxOES(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMultMatrixxOES5800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixxOES5801;
		public static void glMultMatrixxOES(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMultMatrixxOES5801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4xOES5802;
		public static void glMultiTexCoord4xOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMultiTexCoord4xOES5802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3xOES5803;
		public static void glNormal3xOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glNormal3xOES5803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthoxOES5804;
		public static void glOrthoxOES(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glOrthoxOES5804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxOES5805;
		public static void glPointParameterxOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointParameterxOES5805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxvOES5806;
		public static void glPointParameterxvOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointParameterxvOES5806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxvOES5807;
		public static void glPointParameterxvOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointParameterxvOES5807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSizexOES5808;
		public static void glPointSizexOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointSizexOES5808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffsetxOES5809;
		public static void glPolygonOffsetxOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPolygonOffsetxOES5809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatexOES5810;
		public static void glRotatexOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glRotatexOES5810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoveragexOES5811;
		public static void glSampleCoveragexOES(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glSampleCoveragexOES5811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glScalexOES5812;
		public static void glScalexOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glScalexOES5812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxOES5813;
		public static void glTexEnvxOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexEnvxOES5813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxvOES5814;
		public static void glTexEnvxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexEnvxvOES5814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxvOES5815;
		public static void glTexEnvxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexEnvxvOES5815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxOES5816;
		public static void glTexParameterxOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexParameterxOES5816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxvOES5817;
		public static void glTexParameterxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexParameterxvOES5817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxvOES5818;
		public static void glTexParameterxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexParameterxvOES5818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatexOES5819;
		public static void glTranslatexOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTranslatexOES5819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glIsRenderbufferOES5820;
		public static bool glIsRenderbufferOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glIsRenderbufferOES5820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBindRenderbufferOES5821;
		public static void glBindRenderbufferOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBindRenderbufferOES5821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteRenderbuffersOES5822;
		public static void glDeleteRenderbuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES5822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteRenderbuffersOES5823;
		public static void glDeleteRenderbuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES5823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenRenderbuffersOES5824;
		public static void glGenRenderbuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenRenderbuffersOES5824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenRenderbuffersOES5825;
		public static void glGenRenderbuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenRenderbuffersOES5825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glRenderbufferStorageOES5826;
		public static void glRenderbufferStorageOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glRenderbufferStorageOES5826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetRenderbufferParameterivOES5827;
		public static void glGetRenderbufferParameterivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES5827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetRenderbufferParameterivOES5828;
		public static void glGetRenderbufferParameterivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES5828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glIsFramebufferOES5829;
		public static bool glIsFramebufferOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glIsFramebufferOES5829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBindFramebufferOES5830;
		public static void glBindFramebufferOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBindFramebufferOES5830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteFramebuffersOES5831;
		public static void glDeleteFramebuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteFramebuffersOES5831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteFramebuffersOES5832;
		public static void glDeleteFramebuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteFramebuffersOES5832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenFramebuffersOES5833;
		public static void glGenFramebuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenFramebuffersOES5833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenFramebuffersOES5834;
		public static void glGenFramebuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenFramebuffersOES5834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glCheckFramebufferStatusOES5835;
		public static int glCheckFramebufferStatusOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glCheckFramebufferStatusOES5835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFramebufferRenderbufferOES5836;
		public static void glFramebufferRenderbufferOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFramebufferRenderbufferOES5836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glFramebufferTexture2DOES5837;
		public static void glFramebufferTexture2DOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFramebufferTexture2DOES5837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFramebufferAttachmentParameterivOES5838;
		public static void glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, int[] arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES5838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFramebufferAttachmentParameterivOES5839;
		public static void glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES5839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGenerateMipmapOES5840;
		public static void glGenerateMipmapOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenerateMipmapOES5840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glCurrentPaletteMatrixOES5841;
		public static void glCurrentPaletteMatrixOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glCurrentPaletteMatrixOES5841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadPaletteFromModelViewMatrixOES5842;
		public static void glLoadPaletteFromModelViewMatrixOES() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLoadPaletteFromModelViewMatrixOES5842);
		}
		internal static global::MonoJavaBridge.MethodId _glMatrixIndexPointerOES5843;
		public static void glMatrixIndexPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMatrixIndexPointerOES5843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glWeightPointerOES5844;
		public static void glWeightPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glWeightPointerOES5844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangefOES5845;
		public static void glDepthRangefOES(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDepthRangefOES5845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumfOES5846;
		public static void glFrustumfOES(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFrustumfOES5846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthofOES5847;
		public static void glOrthofOES(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glOrthofOES5847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanefOES5848;
		public static void glClipPlanefOES(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanefOES5848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanefOES5849;
		public static void glClipPlanefOES(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanefOES5849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanefOES5850;
		public static void glGetClipPlanefOES(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanefOES5850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanefOES5851;
		public static void glGetClipPlanefOES(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanefOES5851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthfOES5852;
		public static void glClearDepthfOES(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClearDepthfOES5852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenfOES5853;
		public static void glTexGenfOES(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenfOES5853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenfvOES5854;
		public static void glTexGenfvOES(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenfvOES5854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenfvOES5855;
		public static void glTexGenfvOES(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenfvOES5855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGeniOES5856;
		public static void glTexGeniOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGeniOES5856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenivOES5857;
		public static void glTexGenivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenivOES5857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenivOES5858;
		public static void glTexGenivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenivOES5858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenxOES5859;
		public static void glTexGenxOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenxOES5859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenxvOES5860;
		public static void glTexGenxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenxvOES5860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenxvOES5861;
		public static void glTexGenxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenxvOES5861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenfvOES5862;
		public static void glGetTexGenfvOES(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenfvOES5862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenfvOES5863;
		public static void glGetTexGenfvOES(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenfvOES5863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenivOES5864;
		public static void glGetTexGenivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenivOES5864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenivOES5865;
		public static void glGetTexGenivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenivOES5865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenxvOES5866;
		public static void glGetTexGenxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenxvOES5866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenxvOES5867;
		public static void glGetTexGenxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenxvOES5867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _GLES11Ext5868;
		public GLES11Ext()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._GLES11Ext5868);
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLES11Ext.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLES11Ext"));
			global::android.opengl.GLES11Ext._glBlendEquationSeparateOES5748 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glBlendEquationSeparateOES", "(II)V");
			global::android.opengl.GLES11Ext._glBlendFuncSeparateOES5749 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glBlendFuncSeparateOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glBlendEquationOES5750 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glBlendEquationOES", "(I)V");
			global::android.opengl.GLES11Ext._glDrawTexsOES5751 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsOES", "(SSSSS)V");
			global::android.opengl.GLES11Ext._glDrawTexiOES5752 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexiOES", "(IIIII)V");
			global::android.opengl.GLES11Ext._glDrawTexxOES5753 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxOES", "(IIIII)V");
			global::android.opengl.GLES11Ext._glDrawTexsvOES5754 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsvOES", "([SI)V");
			global::android.opengl.GLES11Ext._glDrawTexsvOES5755 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsvOES", "(Ljava/nio/ShortBuffer;)V");
			global::android.opengl.GLES11Ext._glDrawTexivOES5756 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexivOES", "([II)V");
			global::android.opengl.GLES11Ext._glDrawTexivOES5757 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexivOES", "(Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glDrawTexxvOES5758 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxvOES", "([II)V");
			global::android.opengl.GLES11Ext._glDrawTexxvOES5759 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxvOES", "(Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glDrawTexfOES5760 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfOES", "(FFFFF)V");
			global::android.opengl.GLES11Ext._glDrawTexfvOES5761 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfvOES", "([FI)V");
			global::android.opengl.GLES11Ext._glDrawTexfvOES5762 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfvOES", "(Ljava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11Ext._glEGLImageTargetTexture2DOES5763 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glEGLImageTargetTexture2DOES", "(ILjava/nio/Buffer;)V");
			global::android.opengl.GLES11Ext._glEGLImageTargetRenderbufferStorageOES5764 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glEGLImageTargetRenderbufferStorageOES", "(ILjava/nio/Buffer;)V");
			global::android.opengl.GLES11Ext._glAlphaFuncxOES5765 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glAlphaFuncxOES", "(II)V");
			global::android.opengl.GLES11Ext._glClearColorxOES5766 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClearColorxOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glClearDepthxOES5767 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClearDepthxOES", "(I)V");
			global::android.opengl.GLES11Ext._glClipPlanexOES5768 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClipPlanexOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glClipPlanexOES5769 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClipPlanexOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glColor4xOES5770 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glColor4xOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glDepthRangexOES5771 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDepthRangexOES", "(II)V");
			global::android.opengl.GLES11Ext._glFogxOES5772 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFogxOES", "(II)V");
			global::android.opengl.GLES11Ext._glFogxvOES5773 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFogxvOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glFogxvOES5774 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFogxvOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glFrustumxOES5775 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFrustumxOES", "(IIIIII)V");
			global::android.opengl.GLES11Ext._glGetClipPlanexOES5776 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanexOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glGetClipPlanexOES5777 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanexOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetFixedvOES5778 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetFixedvOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetFixedvOES5779 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetFixedvOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glGetLightxvOES5780 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetLightxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetLightxvOES5781 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetLightxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetMaterialxvOES5782 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetMaterialxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetMaterialxvOES5783 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetMaterialxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetTexEnvxvOES5784 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexEnvxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetTexEnvxvOES5785 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexEnvxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetTexParameterxvOES5786 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexParameterxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetTexParameterxvOES5787 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexParameterxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glLightModelxOES5788 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightModelxOES", "(II)V");
			global::android.opengl.GLES11Ext._glLightModelxvOES5789 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightModelxvOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glLightModelxvOES5790 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightModelxvOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glLightxOES5791 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightxOES", "(III)V");
			global::android.opengl.GLES11Ext._glLightxvOES5792 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glLightxvOES5793 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glLineWidthxOES5794 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLineWidthxOES", "(I)V");
			global::android.opengl.GLES11Ext._glLoadMatrixxOES5795 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLoadMatrixxOES", "([II)V");
			global::android.opengl.GLES11Ext._glLoadMatrixxOES5796 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLoadMatrixxOES", "(Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glMaterialxOES5797 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMaterialxOES", "(III)V");
			global::android.opengl.GLES11Ext._glMaterialxvOES5798 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMaterialxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glMaterialxvOES5799 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMaterialxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glMultMatrixxOES5800 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMultMatrixxOES", "([II)V");
			global::android.opengl.GLES11Ext._glMultMatrixxOES5801 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMultMatrixxOES", "(Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glMultiTexCoord4xOES5802 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMultiTexCoord4xOES", "(IIIII)V");
			global::android.opengl.GLES11Ext._glNormal3xOES5803 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glNormal3xOES", "(III)V");
			global::android.opengl.GLES11Ext._glOrthoxOES5804 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glOrthoxOES", "(IIIIII)V");
			global::android.opengl.GLES11Ext._glPointParameterxOES5805 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxOES", "(II)V");
			global::android.opengl.GLES11Ext._glPointParameterxvOES5806 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxvOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glPointParameterxvOES5807 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxvOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glPointSizexOES5808 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glPointSizexOES", "(I)V");
			global::android.opengl.GLES11Ext._glPolygonOffsetxOES5809 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glPolygonOffsetxOES", "(II)V");
			global::android.opengl.GLES11Ext._glRotatexOES5810 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glRotatexOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glSampleCoveragexOES5811 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glSampleCoveragexOES", "(IZ)V");
			global::android.opengl.GLES11Ext._glScalexOES5812 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glScalexOES", "(III)V");
			global::android.opengl.GLES11Ext._glTexEnvxOES5813 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxOES", "(III)V");
			global::android.opengl.GLES11Ext._glTexEnvxvOES5814 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glTexEnvxvOES5815 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glTexParameterxOES5816 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxOES", "(III)V");
			global::android.opengl.GLES11Ext._glTexParameterxvOES5817 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glTexParameterxvOES5818 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glTranslatexOES5819 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTranslatexOES", "(III)V");
			global::android.opengl.GLES11Ext._glIsRenderbufferOES5820 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glIsRenderbufferOES", "(I)Z");
			global::android.opengl.GLES11Ext._glBindRenderbufferOES5821 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glBindRenderbufferOES", "(II)V");
			global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES5822 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDeleteRenderbuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES5823 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDeleteRenderbuffersOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glGenRenderbuffersOES5824 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGenRenderbuffersOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glGenRenderbuffersOES5825 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGenRenderbuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glRenderbufferStorageOES5826 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glRenderbufferStorageOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES5827 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetRenderbufferParameterivOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES5828 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetRenderbufferParameterivOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glIsFramebufferOES5829 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glIsFramebufferOES", "(I)Z");
			global::android.opengl.GLES11Ext._glBindFramebufferOES5830 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glBindFramebufferOES", "(II)V");
			global::android.opengl.GLES11Ext._glDeleteFramebuffersOES5831 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDeleteFramebuffersOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glDeleteFramebuffersOES5832 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDeleteFramebuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGenFramebuffersOES5833 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGenFramebuffersOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glGenFramebuffersOES5834 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGenFramebuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glCheckFramebufferStatusOES5835 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glCheckFramebufferStatusOES", "(I)I");
			global::android.opengl.GLES11Ext._glFramebufferRenderbufferOES5836 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFramebufferRenderbufferOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glFramebufferTexture2DOES5837 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFramebufferTexture2DOES", "(IIIII)V");
			global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES5838 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetFramebufferAttachmentParameterivOES", "(III[II)V");
			global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES5839 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetFramebufferAttachmentParameterivOES", "(IIILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGenerateMipmapOES5840 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGenerateMipmapOES", "(I)V");
			global::android.opengl.GLES11Ext._glCurrentPaletteMatrixOES5841 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glCurrentPaletteMatrixOES", "(I)V");
			global::android.opengl.GLES11Ext._glLoadPaletteFromModelViewMatrixOES5842 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLoadPaletteFromModelViewMatrixOES", "()V");
			global::android.opengl.GLES11Ext._glMatrixIndexPointerOES5843 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMatrixIndexPointerOES", "(IIILjava/nio/Buffer;)V");
			global::android.opengl.GLES11Ext._glWeightPointerOES5844 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glWeightPointerOES", "(IIILjava/nio/Buffer;)V");
			global::android.opengl.GLES11Ext._glDepthRangefOES5845 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDepthRangefOES", "(FF)V");
			global::android.opengl.GLES11Ext._glFrustumfOES5846 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFrustumfOES", "(FFFFFF)V");
			global::android.opengl.GLES11Ext._glOrthofOES5847 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glOrthofOES", "(FFFFFF)V");
			global::android.opengl.GLES11Ext._glClipPlanefOES5848 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClipPlanefOES", "(I[FI)V");
			global::android.opengl.GLES11Ext._glClipPlanefOES5849 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClipPlanefOES", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11Ext._glGetClipPlanefOES5850 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanefOES", "(I[FI)V");
			global::android.opengl.GLES11Ext._glGetClipPlanefOES5851 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanefOES", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11Ext._glClearDepthfOES5852 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClearDepthfOES", "(F)V");
			global::android.opengl.GLES11Ext._glTexGenfOES5853 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenfOES", "(IIF)V");
			global::android.opengl.GLES11Ext._glTexGenfvOES5854 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenfvOES", "(II[FI)V");
			global::android.opengl.GLES11Ext._glTexGenfvOES5855 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenfvOES", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11Ext._glTexGeniOES5856 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGeniOES", "(III)V");
			global::android.opengl.GLES11Ext._glTexGenivOES5857 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenivOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glTexGenivOES5858 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenivOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glTexGenxOES5859 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenxOES", "(III)V");
			global::android.opengl.GLES11Ext._glTexGenxvOES5860 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glTexGenxvOES5861 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetTexGenfvOES5862 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenfvOES", "(II[FI)V");
			global::android.opengl.GLES11Ext._glGetTexGenfvOES5863 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenfvOES", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11Ext._glGetTexGenivOES5864 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenivOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetTexGenivOES5865 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenivOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetTexGenxvOES5866 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetTexGenxvOES5867 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._GLES11Ext5868 = @__env.GetMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "<init>", "()V");
		}
	}
}
