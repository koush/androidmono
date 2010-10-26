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
		internal static global::MonoJavaBridge.MethodId _glBlendEquationSeparateOES8706;
		public static void glBlendEquationSeparateOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBlendEquationSeparateOES8706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendFuncSeparateOES8707;
		public static void glBlendFuncSeparateOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBlendFuncSeparateOES8707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendEquationOES8708;
		public static void glBlendEquationOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBlendEquationOES8708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexsOES8709;
		public static void glDrawTexsOES(short arg0, short arg1, short arg2, short arg3, short arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexsOES8709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexiOES8710;
		public static void glDrawTexiOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexiOES8710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexxOES8711;
		public static void glDrawTexxOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexxOES8711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexsvOES8712;
		public static void glDrawTexsvOES(short[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexsvOES8712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexsvOES8713;
		public static void glDrawTexsvOES(java.nio.ShortBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexsvOES8713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexivOES8714;
		public static void glDrawTexivOES(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexivOES8714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexivOES8715;
		public static void glDrawTexivOES(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexivOES8715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexxvOES8716;
		public static void glDrawTexxvOES(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexxvOES8716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexxvOES8717;
		public static void glDrawTexxvOES(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexxvOES8717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexfOES8718;
		public static void glDrawTexfOES(float arg0, float arg1, float arg2, float arg3, float arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexfOES8718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexfvOES8719;
		public static void glDrawTexfvOES(float[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexfvOES8719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawTexfvOES8720;
		public static void glDrawTexfvOES(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexfvOES8720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glEGLImageTargetTexture2DOES8721;
		public static void glEGLImageTargetTexture2DOES(int arg0, java.nio.Buffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glEGLImageTargetTexture2DOES8721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glEGLImageTargetRenderbufferStorageOES8722;
		public static void glEGLImageTargetRenderbufferStorageOES(int arg0, java.nio.Buffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glEGLImageTargetRenderbufferStorageOES8722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFuncxOES8723;
		public static void glAlphaFuncxOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glAlphaFuncxOES8723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColorxOES8724;
		public static void glClearColorxOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClearColorxOES8724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthxOES8725;
		public static void glClearDepthxOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClearDepthxOES8725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanexOES8726;
		public static void glClipPlanexOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanexOES8726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanexOES8727;
		public static void glClipPlanexOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanexOES8727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4xOES8728;
		public static void glColor4xOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glColor4xOES8728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangexOES8729;
		public static void glDepthRangexOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDepthRangexOES8729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxOES8730;
		public static void glFogxOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFogxOES8730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxvOES8731;
		public static void glFogxvOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFogxvOES8731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxvOES8732;
		public static void glFogxvOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFogxvOES8732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumxOES8733;
		public static void glFrustumxOES(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFrustumxOES8733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanexOES8734;
		public static void glGetClipPlanexOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanexOES8734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanexOES8735;
		public static void glGetClipPlanexOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanexOES8735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFixedvOES8736;
		public static void glGetFixedvOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFixedvOES8736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFixedvOES8737;
		public static void glGetFixedvOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFixedvOES8737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightxvOES8738;
		public static void glGetLightxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetLightxvOES8738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetLightxvOES8739;
		public static void glGetLightxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetLightxvOES8739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialxvOES8740;
		public static void glGetMaterialxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetMaterialxvOES8740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetMaterialxvOES8741;
		public static void glGetMaterialxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetMaterialxvOES8741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvxvOES8742;
		public static void glGetTexEnvxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexEnvxvOES8742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexEnvxvOES8743;
		public static void glGetTexEnvxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexEnvxvOES8743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterxvOES8744;
		public static void glGetTexParameterxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexParameterxvOES8744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexParameterxvOES8745;
		public static void glGetTexParameterxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexParameterxvOES8745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxOES8746;
		public static void glLightModelxOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightModelxOES8746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxvOES8747;
		public static void glLightModelxvOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightModelxvOES8747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxvOES8748;
		public static void glLightModelxvOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightModelxvOES8748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxOES8749;
		public static void glLightxOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightxOES8749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxvOES8750;
		public static void glLightxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightxvOES8750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxvOES8751;
		public static void glLightxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightxvOES8751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidthxOES8752;
		public static void glLineWidthxOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLineWidthxOES8752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixxOES8753;
		public static void glLoadMatrixxOES(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLoadMatrixxOES8753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixxOES8754;
		public static void glLoadMatrixxOES(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLoadMatrixxOES8754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxOES8755;
		public static void glMaterialxOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMaterialxOES8755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxvOES8756;
		public static void glMaterialxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMaterialxvOES8756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxvOES8757;
		public static void glMaterialxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMaterialxvOES8757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixxOES8758;
		public static void glMultMatrixxOES(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMultMatrixxOES8758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixxOES8759;
		public static void glMultMatrixxOES(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMultMatrixxOES8759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4xOES8760;
		public static void glMultiTexCoord4xOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMultiTexCoord4xOES8760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3xOES8761;
		public static void glNormal3xOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glNormal3xOES8761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthoxOES8762;
		public static void glOrthoxOES(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glOrthoxOES8762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxOES8763;
		public static void glPointParameterxOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointParameterxOES8763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxvOES8764;
		public static void glPointParameterxvOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointParameterxvOES8764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointParameterxvOES8765;
		public static void glPointParameterxvOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointParameterxvOES8765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSizexOES8766;
		public static void glPointSizexOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointSizexOES8766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffsetxOES8767;
		public static void glPolygonOffsetxOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPolygonOffsetxOES8767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatexOES8768;
		public static void glRotatexOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glRotatexOES8768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoveragexOES8769;
		public static void glSampleCoveragexOES(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glSampleCoveragexOES8769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glScalexOES8770;
		public static void glScalexOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glScalexOES8770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxOES8771;
		public static void glTexEnvxOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexEnvxOES8771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxvOES8772;
		public static void glTexEnvxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexEnvxvOES8772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxvOES8773;
		public static void glTexEnvxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexEnvxvOES8773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxOES8774;
		public static void glTexParameterxOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexParameterxOES8774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxvOES8775;
		public static void glTexParameterxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexParameterxvOES8775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterxvOES8776;
		public static void glTexParameterxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexParameterxvOES8776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatexOES8777;
		public static void glTranslatexOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTranslatexOES8777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glIsRenderbufferOES8778;
		public static bool glIsRenderbufferOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glIsRenderbufferOES8778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBindRenderbufferOES8779;
		public static void glBindRenderbufferOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBindRenderbufferOES8779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteRenderbuffersOES8780;
		public static void glDeleteRenderbuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES8780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteRenderbuffersOES8781;
		public static void glDeleteRenderbuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES8781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenRenderbuffersOES8782;
		public static void glGenRenderbuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenRenderbuffersOES8782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenRenderbuffersOES8783;
		public static void glGenRenderbuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenRenderbuffersOES8783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glRenderbufferStorageOES8784;
		public static void glRenderbufferStorageOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glRenderbufferStorageOES8784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetRenderbufferParameterivOES8785;
		public static void glGetRenderbufferParameterivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES8785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetRenderbufferParameterivOES8786;
		public static void glGetRenderbufferParameterivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES8786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glIsFramebufferOES8787;
		public static bool glIsFramebufferOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glIsFramebufferOES8787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBindFramebufferOES8788;
		public static void glBindFramebufferOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBindFramebufferOES8788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteFramebuffersOES8789;
		public static void glDeleteFramebuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteFramebuffersOES8789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteFramebuffersOES8790;
		public static void glDeleteFramebuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteFramebuffersOES8790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenFramebuffersOES8791;
		public static void glGenFramebuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenFramebuffersOES8791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenFramebuffersOES8792;
		public static void glGenFramebuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenFramebuffersOES8792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glCheckFramebufferStatusOES8793;
		public static int glCheckFramebufferStatusOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glCheckFramebufferStatusOES8793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFramebufferRenderbufferOES8794;
		public static void glFramebufferRenderbufferOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFramebufferRenderbufferOES8794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glFramebufferTexture2DOES8795;
		public static void glFramebufferTexture2DOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFramebufferTexture2DOES8795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFramebufferAttachmentParameterivOES8796;
		public static void glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, int[] arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES8796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFramebufferAttachmentParameterivOES8797;
		public static void glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES8797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGenerateMipmapOES8798;
		public static void glGenerateMipmapOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenerateMipmapOES8798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glCurrentPaletteMatrixOES8799;
		public static void glCurrentPaletteMatrixOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glCurrentPaletteMatrixOES8799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadPaletteFromModelViewMatrixOES8800;
		public static void glLoadPaletteFromModelViewMatrixOES() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLoadPaletteFromModelViewMatrixOES8800);
		}
		internal static global::MonoJavaBridge.MethodId _glMatrixIndexPointerOES8801;
		public static void glMatrixIndexPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMatrixIndexPointerOES8801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glWeightPointerOES8802;
		public static void glWeightPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glWeightPointerOES8802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangefOES8803;
		public static void glDepthRangefOES(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDepthRangefOES8803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumfOES8804;
		public static void glFrustumfOES(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFrustumfOES8804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthofOES8805;
		public static void glOrthofOES(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glOrthofOES8805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanefOES8806;
		public static void glClipPlanefOES(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanefOES8806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glClipPlanefOES8807;
		public static void glClipPlanefOES(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanefOES8807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanefOES8808;
		public static void glGetClipPlanefOES(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanefOES8808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetClipPlanefOES8809;
		public static void glGetClipPlanefOES(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanefOES8809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthfOES8810;
		public static void glClearDepthfOES(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClearDepthfOES8810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenfOES8811;
		public static void glTexGenfOES(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenfOES8811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenfvOES8812;
		public static void glTexGenfvOES(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenfvOES8812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenfvOES8813;
		public static void glTexGenfvOES(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenfvOES8813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGeniOES8814;
		public static void glTexGeniOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGeniOES8814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenivOES8815;
		public static void glTexGenivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenivOES8815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenivOES8816;
		public static void glTexGenivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenivOES8816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenxOES8817;
		public static void glTexGenxOES(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenxOES8817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenxvOES8818;
		public static void glTexGenxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenxvOES8818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenxvOES8819;
		public static void glTexGenxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenxvOES8819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenfvOES8820;
		public static void glGetTexGenfvOES(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenfvOES8820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenfvOES8821;
		public static void glGetTexGenfvOES(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenfvOES8821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenivOES8822;
		public static void glGetTexGenivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenivOES8822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenivOES8823;
		public static void glGetTexGenivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenivOES8823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenxvOES8824;
		public static void glGetTexGenxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenxvOES8824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenxvOES8825;
		public static void glGetTexGenxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenxvOES8825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _GLES11Ext8826;
		public GLES11Ext()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._GLES11Ext8826);
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
			global::android.opengl.GLES11Ext._glBlendEquationSeparateOES8706 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glBlendEquationSeparateOES", "(II)V");
			global::android.opengl.GLES11Ext._glBlendFuncSeparateOES8707 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glBlendFuncSeparateOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glBlendEquationOES8708 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glBlendEquationOES", "(I)V");
			global::android.opengl.GLES11Ext._glDrawTexsOES8709 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsOES", "(SSSSS)V");
			global::android.opengl.GLES11Ext._glDrawTexiOES8710 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexiOES", "(IIIII)V");
			global::android.opengl.GLES11Ext._glDrawTexxOES8711 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxOES", "(IIIII)V");
			global::android.opengl.GLES11Ext._glDrawTexsvOES8712 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsvOES", "([SI)V");
			global::android.opengl.GLES11Ext._glDrawTexsvOES8713 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsvOES", "(Ljava/nio/ShortBuffer;)V");
			global::android.opengl.GLES11Ext._glDrawTexivOES8714 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexivOES", "([II)V");
			global::android.opengl.GLES11Ext._glDrawTexivOES8715 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexivOES", "(Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glDrawTexxvOES8716 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxvOES", "([II)V");
			global::android.opengl.GLES11Ext._glDrawTexxvOES8717 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxvOES", "(Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glDrawTexfOES8718 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfOES", "(FFFFF)V");
			global::android.opengl.GLES11Ext._glDrawTexfvOES8719 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfvOES", "([FI)V");
			global::android.opengl.GLES11Ext._glDrawTexfvOES8720 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfvOES", "(Ljava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11Ext._glEGLImageTargetTexture2DOES8721 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glEGLImageTargetTexture2DOES", "(ILjava/nio/Buffer;)V");
			global::android.opengl.GLES11Ext._glEGLImageTargetRenderbufferStorageOES8722 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glEGLImageTargetRenderbufferStorageOES", "(ILjava/nio/Buffer;)V");
			global::android.opengl.GLES11Ext._glAlphaFuncxOES8723 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glAlphaFuncxOES", "(II)V");
			global::android.opengl.GLES11Ext._glClearColorxOES8724 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClearColorxOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glClearDepthxOES8725 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClearDepthxOES", "(I)V");
			global::android.opengl.GLES11Ext._glClipPlanexOES8726 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClipPlanexOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glClipPlanexOES8727 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClipPlanexOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glColor4xOES8728 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glColor4xOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glDepthRangexOES8729 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDepthRangexOES", "(II)V");
			global::android.opengl.GLES11Ext._glFogxOES8730 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFogxOES", "(II)V");
			global::android.opengl.GLES11Ext._glFogxvOES8731 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFogxvOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glFogxvOES8732 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFogxvOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glFrustumxOES8733 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFrustumxOES", "(IIIIII)V");
			global::android.opengl.GLES11Ext._glGetClipPlanexOES8734 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanexOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glGetClipPlanexOES8735 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanexOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetFixedvOES8736 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetFixedvOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetFixedvOES8737 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetFixedvOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glGetLightxvOES8738 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetLightxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetLightxvOES8739 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetLightxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetMaterialxvOES8740 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetMaterialxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetMaterialxvOES8741 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetMaterialxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetTexEnvxvOES8742 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexEnvxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetTexEnvxvOES8743 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexEnvxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetTexParameterxvOES8744 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexParameterxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetTexParameterxvOES8745 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexParameterxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glLightModelxOES8746 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightModelxOES", "(II)V");
			global::android.opengl.GLES11Ext._glLightModelxvOES8747 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightModelxvOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glLightModelxvOES8748 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightModelxvOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glLightxOES8749 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightxOES", "(III)V");
			global::android.opengl.GLES11Ext._glLightxvOES8750 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glLightxvOES8751 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glLineWidthxOES8752 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLineWidthxOES", "(I)V");
			global::android.opengl.GLES11Ext._glLoadMatrixxOES8753 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLoadMatrixxOES", "([II)V");
			global::android.opengl.GLES11Ext._glLoadMatrixxOES8754 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLoadMatrixxOES", "(Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glMaterialxOES8755 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMaterialxOES", "(III)V");
			global::android.opengl.GLES11Ext._glMaterialxvOES8756 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMaterialxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glMaterialxvOES8757 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMaterialxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glMultMatrixxOES8758 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMultMatrixxOES", "([II)V");
			global::android.opengl.GLES11Ext._glMultMatrixxOES8759 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMultMatrixxOES", "(Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glMultiTexCoord4xOES8760 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMultiTexCoord4xOES", "(IIIII)V");
			global::android.opengl.GLES11Ext._glNormal3xOES8761 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glNormal3xOES", "(III)V");
			global::android.opengl.GLES11Ext._glOrthoxOES8762 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glOrthoxOES", "(IIIIII)V");
			global::android.opengl.GLES11Ext._glPointParameterxOES8763 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxOES", "(II)V");
			global::android.opengl.GLES11Ext._glPointParameterxvOES8764 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxvOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glPointParameterxvOES8765 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxvOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glPointSizexOES8766 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glPointSizexOES", "(I)V");
			global::android.opengl.GLES11Ext._glPolygonOffsetxOES8767 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glPolygonOffsetxOES", "(II)V");
			global::android.opengl.GLES11Ext._glRotatexOES8768 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glRotatexOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glSampleCoveragexOES8769 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glSampleCoveragexOES", "(IZ)V");
			global::android.opengl.GLES11Ext._glScalexOES8770 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glScalexOES", "(III)V");
			global::android.opengl.GLES11Ext._glTexEnvxOES8771 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxOES", "(III)V");
			global::android.opengl.GLES11Ext._glTexEnvxvOES8772 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glTexEnvxvOES8773 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glTexParameterxOES8774 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxOES", "(III)V");
			global::android.opengl.GLES11Ext._glTexParameterxvOES8775 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glTexParameterxvOES8776 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glTranslatexOES8777 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTranslatexOES", "(III)V");
			global::android.opengl.GLES11Ext._glIsRenderbufferOES8778 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glIsRenderbufferOES", "(I)Z");
			global::android.opengl.GLES11Ext._glBindRenderbufferOES8779 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glBindRenderbufferOES", "(II)V");
			global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES8780 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDeleteRenderbuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES8781 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDeleteRenderbuffersOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glGenRenderbuffersOES8782 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGenRenderbuffersOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glGenRenderbuffersOES8783 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGenRenderbuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glRenderbufferStorageOES8784 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glRenderbufferStorageOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES8785 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetRenderbufferParameterivOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES8786 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetRenderbufferParameterivOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glIsFramebufferOES8787 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glIsFramebufferOES", "(I)Z");
			global::android.opengl.GLES11Ext._glBindFramebufferOES8788 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glBindFramebufferOES", "(II)V");
			global::android.opengl.GLES11Ext._glDeleteFramebuffersOES8789 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDeleteFramebuffersOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glDeleteFramebuffersOES8790 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDeleteFramebuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGenFramebuffersOES8791 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGenFramebuffersOES", "(I[II)V");
			global::android.opengl.GLES11Ext._glGenFramebuffersOES8792 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGenFramebuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glCheckFramebufferStatusOES8793 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glCheckFramebufferStatusOES", "(I)I");
			global::android.opengl.GLES11Ext._glFramebufferRenderbufferOES8794 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFramebufferRenderbufferOES", "(IIII)V");
			global::android.opengl.GLES11Ext._glFramebufferTexture2DOES8795 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFramebufferTexture2DOES", "(IIIII)V");
			global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES8796 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetFramebufferAttachmentParameterivOES", "(III[II)V");
			global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES8797 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetFramebufferAttachmentParameterivOES", "(IIILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGenerateMipmapOES8798 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGenerateMipmapOES", "(I)V");
			global::android.opengl.GLES11Ext._glCurrentPaletteMatrixOES8799 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glCurrentPaletteMatrixOES", "(I)V");
			global::android.opengl.GLES11Ext._glLoadPaletteFromModelViewMatrixOES8800 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLoadPaletteFromModelViewMatrixOES", "()V");
			global::android.opengl.GLES11Ext._glMatrixIndexPointerOES8801 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMatrixIndexPointerOES", "(IIILjava/nio/Buffer;)V");
			global::android.opengl.GLES11Ext._glWeightPointerOES8802 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glWeightPointerOES", "(IIILjava/nio/Buffer;)V");
			global::android.opengl.GLES11Ext._glDepthRangefOES8803 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDepthRangefOES", "(FF)V");
			global::android.opengl.GLES11Ext._glFrustumfOES8804 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFrustumfOES", "(FFFFFF)V");
			global::android.opengl.GLES11Ext._glOrthofOES8805 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glOrthofOES", "(FFFFFF)V");
			global::android.opengl.GLES11Ext._glClipPlanefOES8806 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClipPlanefOES", "(I[FI)V");
			global::android.opengl.GLES11Ext._glClipPlanefOES8807 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClipPlanefOES", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11Ext._glGetClipPlanefOES8808 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanefOES", "(I[FI)V");
			global::android.opengl.GLES11Ext._glGetClipPlanefOES8809 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanefOES", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11Ext._glClearDepthfOES8810 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClearDepthfOES", "(F)V");
			global::android.opengl.GLES11Ext._glTexGenfOES8811 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenfOES", "(IIF)V");
			global::android.opengl.GLES11Ext._glTexGenfvOES8812 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenfvOES", "(II[FI)V");
			global::android.opengl.GLES11Ext._glTexGenfvOES8813 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenfvOES", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11Ext._glTexGeniOES8814 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGeniOES", "(III)V");
			global::android.opengl.GLES11Ext._glTexGenivOES8815 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenivOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glTexGenivOES8816 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenivOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glTexGenxOES8817 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenxOES", "(III)V");
			global::android.opengl.GLES11Ext._glTexGenxvOES8818 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glTexGenxvOES8819 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetTexGenfvOES8820 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenfvOES", "(II[FI)V");
			global::android.opengl.GLES11Ext._glGetTexGenfvOES8821 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenfvOES", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES11Ext._glGetTexGenivOES8822 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenivOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetTexGenivOES8823 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenivOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._glGetTexGenxvOES8824 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenxvOES", "(II[II)V");
			global::android.opengl.GLES11Ext._glGetTexGenxvOES8825 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenxvOES", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES11Ext._GLES11Ext8826 = @__env.GetMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "<init>", "()V");
		}
	}
}
