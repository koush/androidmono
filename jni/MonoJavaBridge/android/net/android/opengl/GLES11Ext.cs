namespace android.opengl 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GLES11Ext : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GLES11Ext() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.opengl.GLES11Ext), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _glBlendEquationSeparateOES4894; 
		public static void glBlendEquationSeparateOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glBlendEquationSeparateOES4894, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBlendFuncSeparateOES4895; 
		public static void glBlendFuncSeparateOES(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glBlendFuncSeparateOES4895, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBlendEquationOES4896; 
		public static void glBlendEquationOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glBlendEquationOES4896, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexsOES4897; 
		public static void glDrawTexsOES(short arg0, short arg1, short arg2, short arg3, short arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDrawTexsOES4897, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexiOES4898; 
		public static void glDrawTexiOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDrawTexiOES4898, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexxOES4899; 
		public static void glDrawTexxOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDrawTexxOES4899, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexsvOES4900; 
		public static void glDrawTexsvOES(short[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDrawTexsvOES4900, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexsvOES4901; 
		public static void glDrawTexsvOES(java.nio.ShortBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDrawTexsvOES4901, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexivOES4902; 
		public static void glDrawTexivOES(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDrawTexivOES4902, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexivOES4903; 
		public static void glDrawTexivOES(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDrawTexivOES4903, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexxvOES4904; 
		public static void glDrawTexxvOES(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDrawTexxvOES4904, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexxvOES4905; 
		public static void glDrawTexxvOES(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDrawTexxvOES4905, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexfOES4906; 
		public static void glDrawTexfOES(float arg0, float arg1, float arg2, float arg3, float arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDrawTexfOES4906, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexfvOES4907; 
		public static void glDrawTexfvOES(float[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDrawTexfvOES4907, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexfvOES4908; 
		public static void glDrawTexfvOES(java.nio.FloatBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDrawTexfvOES4908, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glEGLImageTargetTexture2DOES4909; 
		public static void glEGLImageTargetTexture2DOES(int arg0, java.nio.Buffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glEGLImageTargetTexture2DOES4909, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glEGLImageTargetRenderbufferStorageOES4910; 
		public static void glEGLImageTargetRenderbufferStorageOES(int arg0, java.nio.Buffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glEGLImageTargetRenderbufferStorageOES4910, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glAlphaFuncxOES4911; 
		public static void glAlphaFuncxOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glAlphaFuncxOES4911, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearColorxOES4912; 
		public static void glClearColorxOES(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glClearColorxOES4912, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearDepthxOES4913; 
		public static void glClearDepthxOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glClearDepthxOES4913, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanexOES4914; 
		public static void glClipPlanexOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glClipPlanexOES4914, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanexOES4915; 
		public static void glClipPlanexOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glClipPlanexOES4915, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glColor4xOES4916; 
		public static void glColor4xOES(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glColor4xOES4916, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthRangexOES4917; 
		public static void glDepthRangexOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDepthRangexOES4917, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogxOES4918; 
		public static void glFogxOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glFogxOES4918, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogxvOES4919; 
		public static void glFogxvOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glFogxvOES4919, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogxvOES4920; 
		public static void glFogxvOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glFogxvOES4920, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFrustumxOES4921; 
		public static void glFrustumxOES(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glFrustumxOES4921, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanexOES4922; 
		public static void glGetClipPlanexOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetClipPlanexOES4922, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanexOES4923; 
		public static void glGetClipPlanexOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetClipPlanexOES4923, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetFixedvOES4924; 
		public static void glGetFixedvOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetFixedvOES4924, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetFixedvOES4925; 
		public static void glGetFixedvOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetFixedvOES4925, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetLightxvOES4926; 
		public static void glGetLightxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetLightxvOES4926, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetLightxvOES4927; 
		public static void glGetLightxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetLightxvOES4927, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetMaterialxvOES4928; 
		public static void glGetMaterialxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetMaterialxvOES4928, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetMaterialxvOES4929; 
		public static void glGetMaterialxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetMaterialxvOES4929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnvxvOES4930; 
		public static void glGetTexEnvxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetTexEnvxvOES4930, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnvxvOES4931; 
		public static void glGetTexEnvxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetTexEnvxvOES4931, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterxvOES4932; 
		public static void glGetTexParameterxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetTexParameterxvOES4932, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterxvOES4933; 
		public static void glGetTexParameterxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetTexParameterxvOES4933, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxOES4934; 
		public static void glLightModelxOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glLightModelxOES4934, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxvOES4935; 
		public static void glLightModelxvOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glLightModelxvOES4935, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxvOES4936; 
		public static void glLightModelxvOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glLightModelxvOES4936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightxOES4937; 
		public static void glLightxOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glLightxOES4937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightxvOES4938; 
		public static void glLightxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glLightxvOES4938, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightxvOES4939; 
		public static void glLightxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glLightxvOES4939, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLineWidthxOES4940; 
		public static void glLineWidthxOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glLineWidthxOES4940, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixxOES4941; 
		public static void glLoadMatrixxOES(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glLoadMatrixxOES4941, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixxOES4942; 
		public static void glLoadMatrixxOES(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glLoadMatrixxOES4942, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxOES4943; 
		public static void glMaterialxOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glMaterialxOES4943, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxvOES4944; 
		public static void glMaterialxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glMaterialxvOES4944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxvOES4945; 
		public static void glMaterialxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glMaterialxvOES4945, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixxOES4946; 
		public static void glMultMatrixxOES(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glMultMatrixxOES4946, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixxOES4947; 
		public static void glMultMatrixxOES(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glMultMatrixxOES4947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultiTexCoord4xOES4948; 
		public static void glMultiTexCoord4xOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glMultiTexCoord4xOES4948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glNormal3xOES4949; 
		public static void glNormal3xOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glNormal3xOES4949, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glOrthoxOES4950; 
		public static void glOrthoxOES(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glOrthoxOES4950, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterxOES4951; 
		public static void glPointParameterxOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glPointParameterxOES4951, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterxvOES4952; 
		public static void glPointParameterxvOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glPointParameterxvOES4952, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterxvOES4953; 
		public static void glPointParameterxvOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glPointParameterxvOES4953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointSizexOES4954; 
		public static void glPointSizexOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glPointSizexOES4954, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPolygonOffsetxOES4955; 
		public static void glPolygonOffsetxOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glPolygonOffsetxOES4955, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glRotatexOES4956; 
		public static void glRotatexOES(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glRotatexOES4956, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glSampleCoveragexOES4957; 
		public static void glSampleCoveragexOES(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glSampleCoveragexOES4957, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glScalexOES4958; 
		public static void glScalexOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glScalexOES4958, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxOES4959; 
		public static void glTexEnvxOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTexEnvxOES4959, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxvOES4960; 
		public static void glTexEnvxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTexEnvxvOES4960, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxvOES4961; 
		public static void glTexEnvxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTexEnvxvOES4961, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterxOES4962; 
		public static void glTexParameterxOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTexParameterxOES4962, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterxvOES4963; 
		public static void glTexParameterxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTexParameterxvOES4963, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterxvOES4964; 
		public static void glTexParameterxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTexParameterxvOES4964, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTranslatexOES4965; 
		public static void glTranslatexOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTranslatexOES4965, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glIsRenderbufferOES4966; 
		public static bool glIsRenderbufferOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11Ext.staticClass, _glIsRenderbufferOES4966, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBindRenderbufferOES4967; 
		public static void glBindRenderbufferOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glBindRenderbufferOES4967, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteRenderbuffersOES4968; 
		public static void glDeleteRenderbuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDeleteRenderbuffersOES4968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteRenderbuffersOES4969; 
		public static void glDeleteRenderbuffersOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDeleteRenderbuffersOES4969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenRenderbuffersOES4970; 
		public static void glGenRenderbuffersOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGenRenderbuffersOES4970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenRenderbuffersOES4971; 
		public static void glGenRenderbuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGenRenderbuffersOES4971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glRenderbufferStorageOES4972; 
		public static void glRenderbufferStorageOES(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glRenderbufferStorageOES4972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetRenderbufferParameterivOES4973; 
		public static void glGetRenderbufferParameterivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetRenderbufferParameterivOES4973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetRenderbufferParameterivOES4974; 
		public static void glGetRenderbufferParameterivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetRenderbufferParameterivOES4974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glIsFramebufferOES4975; 
		public static bool glIsFramebufferOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11Ext.staticClass, _glIsFramebufferOES4975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBindFramebufferOES4976; 
		public static void glBindFramebufferOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glBindFramebufferOES4976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteFramebuffersOES4977; 
		public static void glDeleteFramebuffersOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDeleteFramebuffersOES4977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteFramebuffersOES4978; 
		public static void glDeleteFramebuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDeleteFramebuffersOES4978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenFramebuffersOES4979; 
		public static void glGenFramebuffersOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGenFramebuffersOES4979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenFramebuffersOES4980; 
		public static void glGenFramebuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGenFramebuffersOES4980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCheckFramebufferStatusOES4981; 
		public static int glCheckFramebufferStatusOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.opengl.GLES11Ext.staticClass, _glCheckFramebufferStatusOES4981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFramebufferRenderbufferOES4982; 
		public static void glFramebufferRenderbufferOES(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glFramebufferRenderbufferOES4982, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFramebufferTexture2DOES4983; 
		public static void glFramebufferTexture2DOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glFramebufferTexture2DOES4983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetFramebufferAttachmentParameterivOES4984; 
		public static void glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, int[] arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetFramebufferAttachmentParameterivOES4984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetFramebufferAttachmentParameterivOES4985; 
		public static void glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetFramebufferAttachmentParameterivOES4985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenerateMipmapOES4986; 
		public static void glGenerateMipmapOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGenerateMipmapOES4986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCurrentPaletteMatrixOES4987; 
		public static void glCurrentPaletteMatrixOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glCurrentPaletteMatrixOES4987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadPaletteFromModelViewMatrixOES4988; 
		public static void glLoadPaletteFromModelViewMatrixOES() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glLoadPaletteFromModelViewMatrixOES4988); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMatrixIndexPointerOES4989; 
		public static void glMatrixIndexPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glMatrixIndexPointerOES4989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glWeightPointerOES4990; 
		public static void glWeightPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glWeightPointerOES4990, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthRangefOES4991; 
		public static void glDepthRangefOES(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glDepthRangefOES4991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFrustumfOES4992; 
		public static void glFrustumfOES(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glFrustumfOES4992, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glOrthofOES4993; 
		public static void glOrthofOES(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glOrthofOES4993, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanefOES4994; 
		public static void glClipPlanefOES(int arg0, float[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glClipPlanefOES4994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanefOES4995; 
		public static void glClipPlanefOES(int arg0, java.nio.FloatBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glClipPlanefOES4995, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanefOES4996; 
		public static void glGetClipPlanefOES(int arg0, float[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetClipPlanefOES4996, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanefOES4997; 
		public static void glGetClipPlanefOES(int arg0, java.nio.FloatBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetClipPlanefOES4997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearDepthfOES4998; 
		public static void glClearDepthfOES(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glClearDepthfOES4998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenfOES4999; 
		public static void glTexGenfOES(int arg0, int arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTexGenfOES4999, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenfvOES5000; 
		public static void glTexGenfvOES(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTexGenfvOES5000, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenfvOES5001; 
		public static void glTexGenfvOES(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTexGenfvOES5001, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGeniOES5002; 
		public static void glTexGeniOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTexGeniOES5002, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenivOES5003; 
		public static void glTexGenivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTexGenivOES5003, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenivOES5004; 
		public static void glTexGenivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTexGenivOES5004, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenxOES5005; 
		public static void glTexGenxOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTexGenxOES5005, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenxvOES5006; 
		public static void glTexGenxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTexGenxvOES5006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenxvOES5007; 
		public static void glTexGenxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glTexGenxvOES5007, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenfvOES5008; 
		public static void glGetTexGenfvOES(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetTexGenfvOES5008, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenfvOES5009; 
		public static void glGetTexGenfvOES(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetTexGenfvOES5009, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenivOES5010; 
		public static void glGetTexGenivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetTexGenivOES5010, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenivOES5011; 
		public static void glGetTexGenivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetTexGenivOES5011, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenxvOES5012; 
		public static void glGetTexGenxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetTexGenxvOES5012, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenxvOES5013; 
		public static void glGetTexGenxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, _glGetTexGenxvOES5013, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GLES11Ext5014; 
		public GLES11Ext()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.opengl.GLES11Ext.staticClass, _GLES11Ext5014, this); 
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
			global::android.opengl.GLES11Ext._glBlendEquationSeparateOES4894 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glBlendEquationSeparateOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glBlendFuncSeparateOES4895 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glBlendFuncSeparateOES", "(IIII)V"); 
			global::android.opengl.GLES11Ext._glBlendEquationOES4896 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glBlendEquationOES", "(I)V"); 
			global::android.opengl.GLES11Ext._glDrawTexsOES4897 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsOES", "(SSSSS)V"); 
			global::android.opengl.GLES11Ext._glDrawTexiOES4898 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexiOES", "(IIIII)V"); 
			global::android.opengl.GLES11Ext._glDrawTexxOES4899 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxOES", "(IIIII)V"); 
			global::android.opengl.GLES11Ext._glDrawTexsvOES4900 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsvOES", "([SI)V"); 
			global::android.opengl.GLES11Ext._glDrawTexsvOES4901 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsvOES", "(Ljava/nio/ShortBuffer;)V"); 
			global::android.opengl.GLES11Ext._glDrawTexivOES4902 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexivOES", "([II)V"); 
			global::android.opengl.GLES11Ext._glDrawTexivOES4903 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexivOES", "(Ljava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glDrawTexxvOES4904 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxvOES", "([II)V"); 
			global::android.opengl.GLES11Ext._glDrawTexxvOES4905 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxvOES", "(Ljava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glDrawTexfOES4906 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfOES", "(FFFFF)V"); 
			global::android.opengl.GLES11Ext._glDrawTexfvOES4907 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfvOES", "([FI)V"); 
			global::android.opengl.GLES11Ext._glDrawTexfvOES4908 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfvOES", "(Ljava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11Ext._glEGLImageTargetTexture2DOES4909 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glEGLImageTargetTexture2DOES", "(ILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES11Ext._glEGLImageTargetRenderbufferStorageOES4910 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glEGLImageTargetRenderbufferStorageOES", "(ILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES11Ext._glAlphaFuncxOES4911 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glAlphaFuncxOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glClearColorxOES4912 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClearColorxOES", "(IIII)V"); 
			global::android.opengl.GLES11Ext._glClearDepthxOES4913 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClearDepthxOES", "(I)V"); 
			global::android.opengl.GLES11Ext._glClipPlanexOES4914 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClipPlanexOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glClipPlanexOES4915 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClipPlanexOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glColor4xOES4916 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glColor4xOES", "(IIII)V"); 
			global::android.opengl.GLES11Ext._glDepthRangexOES4917 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDepthRangexOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glFogxOES4918 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFogxOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glFogxvOES4919 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFogxvOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glFogxvOES4920 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFogxvOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glFrustumxOES4921 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFrustumxOES", "(IIIIII)V"); 
			global::android.opengl.GLES11Ext._glGetClipPlanexOES4922 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanexOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glGetClipPlanexOES4923 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanexOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetFixedvOES4924 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetFixedvOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetFixedvOES4925 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetFixedvOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glGetLightxvOES4926 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetLightxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glGetLightxvOES4927 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetLightxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetMaterialxvOES4928 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetMaterialxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glGetMaterialxvOES4929 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetMaterialxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetTexEnvxvOES4930 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexEnvxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetTexEnvxvOES4931 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexEnvxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glGetTexParameterxvOES4932 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexParameterxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glGetTexParameterxvOES4933 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexParameterxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glLightModelxOES4934 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightModelxOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glLightModelxvOES4935 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightModelxvOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glLightModelxvOES4936 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightModelxvOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glLightxOES4937 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightxOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glLightxvOES4938 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glLightxvOES4939 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glLineWidthxOES4940 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLineWidthxOES", "(I)V"); 
			global::android.opengl.GLES11Ext._glLoadMatrixxOES4941 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLoadMatrixxOES", "([II)V"); 
			global::android.opengl.GLES11Ext._glLoadMatrixxOES4942 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLoadMatrixxOES", "(Ljava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glMaterialxOES4943 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMaterialxOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glMaterialxvOES4944 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMaterialxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glMaterialxvOES4945 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMaterialxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glMultMatrixxOES4946 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMultMatrixxOES", "([II)V"); 
			global::android.opengl.GLES11Ext._glMultMatrixxOES4947 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMultMatrixxOES", "(Ljava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glMultiTexCoord4xOES4948 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMultiTexCoord4xOES", "(IIIII)V"); 
			global::android.opengl.GLES11Ext._glNormal3xOES4949 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glNormal3xOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glOrthoxOES4950 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glOrthoxOES", "(IIIIII)V"); 
			global::android.opengl.GLES11Ext._glPointParameterxOES4951 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glPointParameterxvOES4952 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxvOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glPointParameterxvOES4953 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxvOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glPointSizexOES4954 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glPointSizexOES", "(I)V"); 
			global::android.opengl.GLES11Ext._glPolygonOffsetxOES4955 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glPolygonOffsetxOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glRotatexOES4956 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glRotatexOES", "(IIII)V"); 
			global::android.opengl.GLES11Ext._glSampleCoveragexOES4957 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glSampleCoveragexOES", "(IZ)V"); 
			global::android.opengl.GLES11Ext._glScalexOES4958 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glScalexOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glTexEnvxOES4959 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glTexEnvxvOES4960 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glTexEnvxvOES4961 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glTexParameterxOES4962 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glTexParameterxvOES4963 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glTexParameterxvOES4964 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glTranslatexOES4965 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTranslatexOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glIsRenderbufferOES4966 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glIsRenderbufferOES", "(I)Z"); 
			global::android.opengl.GLES11Ext._glBindRenderbufferOES4967 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glBindRenderbufferOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES4968 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDeleteRenderbuffersOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES4969 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDeleteRenderbuffersOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glGenRenderbuffersOES4970 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGenRenderbuffersOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glGenRenderbuffersOES4971 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGenRenderbuffersOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glRenderbufferStorageOES4972 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glRenderbufferStorageOES", "(IIII)V"); 
			global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES4973 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetRenderbufferParameterivOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES4974 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetRenderbufferParameterivOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glIsFramebufferOES4975 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glIsFramebufferOES", "(I)Z"); 
			global::android.opengl.GLES11Ext._glBindFramebufferOES4976 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glBindFramebufferOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glDeleteFramebuffersOES4977 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDeleteFramebuffersOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glDeleteFramebuffersOES4978 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDeleteFramebuffersOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGenFramebuffersOES4979 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGenFramebuffersOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glGenFramebuffersOES4980 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGenFramebuffersOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glCheckFramebufferStatusOES4981 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glCheckFramebufferStatusOES", "(I)I"); 
			global::android.opengl.GLES11Ext._glFramebufferRenderbufferOES4982 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFramebufferRenderbufferOES", "(IIII)V"); 
			global::android.opengl.GLES11Ext._glFramebufferTexture2DOES4983 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFramebufferTexture2DOES", "(IIIII)V"); 
			global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES4984 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetFramebufferAttachmentParameterivOES", "(III[II)V"); 
			global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES4985 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetFramebufferAttachmentParameterivOES", "(IIILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGenerateMipmapOES4986 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGenerateMipmapOES", "(I)V"); 
			global::android.opengl.GLES11Ext._glCurrentPaletteMatrixOES4987 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glCurrentPaletteMatrixOES", "(I)V"); 
			global::android.opengl.GLES11Ext._glLoadPaletteFromModelViewMatrixOES4988 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLoadPaletteFromModelViewMatrixOES", "()V"); 
			global::android.opengl.GLES11Ext._glMatrixIndexPointerOES4989 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMatrixIndexPointerOES", "(IIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES11Ext._glWeightPointerOES4990 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glWeightPointerOES", "(IIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES11Ext._glDepthRangefOES4991 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDepthRangefOES", "(FF)V"); 
			global::android.opengl.GLES11Ext._glFrustumfOES4992 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFrustumfOES", "(FFFFFF)V"); 
			global::android.opengl.GLES11Ext._glOrthofOES4993 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glOrthofOES", "(FFFFFF)V"); 
			global::android.opengl.GLES11Ext._glClipPlanefOES4994 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClipPlanefOES", "(I[FI)V"); 
			global::android.opengl.GLES11Ext._glClipPlanefOES4995 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClipPlanefOES", "(ILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetClipPlanefOES4996 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanefOES", "(I[FI)V"); 
			global::android.opengl.GLES11Ext._glGetClipPlanefOES4997 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanefOES", "(ILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11Ext._glClearDepthfOES4998 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClearDepthfOES", "(F)V"); 
			global::android.opengl.GLES11Ext._glTexGenfOES4999 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenfOES", "(IIF)V"); 
			global::android.opengl.GLES11Ext._glTexGenfvOES5000 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenfvOES", "(II[FI)V"); 
			global::android.opengl.GLES11Ext._glTexGenfvOES5001 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenfvOES", "(IILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11Ext._glTexGeniOES5002 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGeniOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glTexGenivOES5003 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenivOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glTexGenivOES5004 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenivOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glTexGenxOES5005 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenxOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glTexGenxvOES5006 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glTexGenxvOES5007 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetTexGenfvOES5008 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenfvOES", "(II[FI)V"); 
			global::android.opengl.GLES11Ext._glGetTexGenfvOES5009 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenfvOES", "(IILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetTexGenivOES5010 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenivOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glGetTexGenivOES5011 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenivOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetTexGenxvOES5012 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glGetTexGenxvOES5013 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._GLES11Ext5014 = @__env.GetMethodID(global::android.opengl.GLES11Ext.staticClass, "<init>", "()V"); 
		} 
	} 
} 
