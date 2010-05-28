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
		internal static global::net.sf.jni4net.jni.MethodId _glBlendEquationSeparateOES5143; 
		public static void glBlendEquationSeparateOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBlendEquationSeparateOES5143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBlendFuncSeparateOES5144; 
		public static void glBlendFuncSeparateOES(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBlendFuncSeparateOES5144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBlendEquationOES5145; 
		public static void glBlendEquationOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBlendEquationOES5145, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexsOES5146; 
		public static void glDrawTexsOES(short arg0, short arg1, short arg2, short arg3, short arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexsOES5146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexiOES5147; 
		public static void glDrawTexiOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexiOES5147, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexxOES5148; 
		public static void glDrawTexxOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexxOES5148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexsvOES5149; 
		public static void glDrawTexsvOES(short[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexsvOES5149, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexsvOES5150; 
		public static void glDrawTexsvOES(java.nio.ShortBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexsvOES5150, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexivOES5151; 
		public static void glDrawTexivOES(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexivOES5151, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexivOES5152; 
		public static void glDrawTexivOES(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexivOES5152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexxvOES5153; 
		public static void glDrawTexxvOES(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexxvOES5153, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexxvOES5154; 
		public static void glDrawTexxvOES(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexxvOES5154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexfOES5155; 
		public static void glDrawTexfOES(float arg0, float arg1, float arg2, float arg3, float arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexfOES5155, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexfvOES5156; 
		public static void glDrawTexfvOES(float[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexfvOES5156, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawTexfvOES5157; 
		public static void glDrawTexfvOES(java.nio.FloatBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDrawTexfvOES5157, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glEGLImageTargetTexture2DOES5158; 
		public static void glEGLImageTargetTexture2DOES(int arg0, java.nio.Buffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glEGLImageTargetTexture2DOES5158, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glEGLImageTargetRenderbufferStorageOES5159; 
		public static void glEGLImageTargetRenderbufferStorageOES(int arg0, java.nio.Buffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glEGLImageTargetRenderbufferStorageOES5159, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glAlphaFuncxOES5160; 
		public static void glAlphaFuncxOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glAlphaFuncxOES5160, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearColorxOES5161; 
		public static void glClearColorxOES(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClearColorxOES5161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearDepthxOES5162; 
		public static void glClearDepthxOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClearDepthxOES5162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanexOES5163; 
		public static void glClipPlanexOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanexOES5163, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanexOES5164; 
		public static void glClipPlanexOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanexOES5164, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glColor4xOES5165; 
		public static void glColor4xOES(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glColor4xOES5165, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthRangexOES5166; 
		public static void glDepthRangexOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDepthRangexOES5166, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogxOES5167; 
		public static void glFogxOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFogxOES5167, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogxvOES5168; 
		public static void glFogxvOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFogxvOES5168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogxvOES5169; 
		public static void glFogxvOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFogxvOES5169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFrustumxOES5170; 
		public static void glFrustumxOES(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFrustumxOES5170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanexOES5171; 
		public static void glGetClipPlanexOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanexOES5171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanexOES5172; 
		public static void glGetClipPlanexOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanexOES5172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetFixedvOES5173; 
		public static void glGetFixedvOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFixedvOES5173, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetFixedvOES5174; 
		public static void glGetFixedvOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFixedvOES5174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetLightxvOES5175; 
		public static void glGetLightxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetLightxvOES5175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetLightxvOES5176; 
		public static void glGetLightxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetLightxvOES5176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetMaterialxvOES5177; 
		public static void glGetMaterialxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetMaterialxvOES5177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetMaterialxvOES5178; 
		public static void glGetMaterialxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetMaterialxvOES5178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnvxvOES5179; 
		public static void glGetTexEnvxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexEnvxvOES5179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexEnvxvOES5180; 
		public static void glGetTexEnvxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexEnvxvOES5180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterxvOES5181; 
		public static void glGetTexParameterxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexParameterxvOES5181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterxvOES5182; 
		public static void glGetTexParameterxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexParameterxvOES5182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxOES5183; 
		public static void glLightModelxOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightModelxOES5183, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxvOES5184; 
		public static void glLightModelxvOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightModelxvOES5184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxvOES5185; 
		public static void glLightModelxvOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightModelxvOES5185, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightxOES5186; 
		public static void glLightxOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightxOES5186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightxvOES5187; 
		public static void glLightxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightxvOES5187, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightxvOES5188; 
		public static void glLightxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLightxvOES5188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLineWidthxOES5189; 
		public static void glLineWidthxOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLineWidthxOES5189, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixxOES5190; 
		public static void glLoadMatrixxOES(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLoadMatrixxOES5190, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixxOES5191; 
		public static void glLoadMatrixxOES(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLoadMatrixxOES5191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxOES5192; 
		public static void glMaterialxOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMaterialxOES5192, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxvOES5193; 
		public static void glMaterialxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMaterialxvOES5193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxvOES5194; 
		public static void glMaterialxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMaterialxvOES5194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixxOES5195; 
		public static void glMultMatrixxOES(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMultMatrixxOES5195, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixxOES5196; 
		public static void glMultMatrixxOES(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMultMatrixxOES5196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultiTexCoord4xOES5197; 
		public static void glMultiTexCoord4xOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMultiTexCoord4xOES5197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glNormal3xOES5198; 
		public static void glNormal3xOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glNormal3xOES5198, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glOrthoxOES5199; 
		public static void glOrthoxOES(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glOrthoxOES5199, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterxOES5200; 
		public static void glPointParameterxOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointParameterxOES5200, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterxvOES5201; 
		public static void glPointParameterxvOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointParameterxvOES5201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointParameterxvOES5202; 
		public static void glPointParameterxvOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointParameterxvOES5202, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointSizexOES5203; 
		public static void glPointSizexOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPointSizexOES5203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPolygonOffsetxOES5204; 
		public static void glPolygonOffsetxOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glPolygonOffsetxOES5204, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glRotatexOES5205; 
		public static void glRotatexOES(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glRotatexOES5205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glSampleCoveragexOES5206; 
		public static void glSampleCoveragexOES(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glSampleCoveragexOES5206, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glScalexOES5207; 
		public static void glScalexOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glScalexOES5207, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxOES5208; 
		public static void glTexEnvxOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexEnvxOES5208, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxvOES5209; 
		public static void glTexEnvxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexEnvxvOES5209, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxvOES5210; 
		public static void glTexEnvxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexEnvxvOES5210, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterxOES5211; 
		public static void glTexParameterxOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexParameterxOES5211, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterxvOES5212; 
		public static void glTexParameterxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexParameterxvOES5212, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterxvOES5213; 
		public static void glTexParameterxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexParameterxvOES5213, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTranslatexOES5214; 
		public static void glTranslatexOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTranslatexOES5214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glIsRenderbufferOES5215; 
		public static bool glIsRenderbufferOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glIsRenderbufferOES5215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBindRenderbufferOES5216; 
		public static void glBindRenderbufferOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBindRenderbufferOES5216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteRenderbuffersOES5217; 
		public static void glDeleteRenderbuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES5217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteRenderbuffersOES5218; 
		public static void glDeleteRenderbuffersOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES5218, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenRenderbuffersOES5219; 
		public static void glGenRenderbuffersOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenRenderbuffersOES5219, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenRenderbuffersOES5220; 
		public static void glGenRenderbuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenRenderbuffersOES5220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glRenderbufferStorageOES5221; 
		public static void glRenderbufferStorageOES(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glRenderbufferStorageOES5221, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetRenderbufferParameterivOES5222; 
		public static void glGetRenderbufferParameterivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES5222, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetRenderbufferParameterivOES5223; 
		public static void glGetRenderbufferParameterivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES5223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glIsFramebufferOES5224; 
		public static bool glIsFramebufferOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glIsFramebufferOES5224, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBindFramebufferOES5225; 
		public static void glBindFramebufferOES(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glBindFramebufferOES5225, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteFramebuffersOES5226; 
		public static void glDeleteFramebuffersOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteFramebuffersOES5226, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteFramebuffersOES5227; 
		public static void glDeleteFramebuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDeleteFramebuffersOES5227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenFramebuffersOES5228; 
		public static void glGenFramebuffersOES(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenFramebuffersOES5228, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenFramebuffersOES5229; 
		public static void glGenFramebuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenFramebuffersOES5229, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCheckFramebufferStatusOES5230; 
		public static int glCheckFramebufferStatusOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glCheckFramebufferStatusOES5230, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFramebufferRenderbufferOES5231; 
		public static void glFramebufferRenderbufferOES(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFramebufferRenderbufferOES5231, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFramebufferTexture2DOES5232; 
		public static void glFramebufferTexture2DOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFramebufferTexture2DOES5232, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetFramebufferAttachmentParameterivOES5233; 
		public static void glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, int[] arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES5233, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetFramebufferAttachmentParameterivOES5234; 
		public static void glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES5234, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenerateMipmapOES5235; 
		public static void glGenerateMipmapOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGenerateMipmapOES5235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCurrentPaletteMatrixOES5236; 
		public static void glCurrentPaletteMatrixOES(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glCurrentPaletteMatrixOES5236, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadPaletteFromModelViewMatrixOES5237; 
		public static void glLoadPaletteFromModelViewMatrixOES() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glLoadPaletteFromModelViewMatrixOES5237); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMatrixIndexPointerOES5238; 
		public static void glMatrixIndexPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glMatrixIndexPointerOES5238, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glWeightPointerOES5239; 
		public static void glWeightPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glWeightPointerOES5239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthRangefOES5240; 
		public static void glDepthRangefOES(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glDepthRangefOES5240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFrustumfOES5241; 
		public static void glFrustumfOES(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glFrustumfOES5241, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glOrthofOES5242; 
		public static void glOrthofOES(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glOrthofOES5242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanefOES5243; 
		public static void glClipPlanefOES(int arg0, float[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanefOES5243, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClipPlanefOES5244; 
		public static void glClipPlanefOES(int arg0, java.nio.FloatBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClipPlanefOES5244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanefOES5245; 
		public static void glGetClipPlanefOES(int arg0, float[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanefOES5245, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetClipPlanefOES5246; 
		public static void glGetClipPlanefOES(int arg0, java.nio.FloatBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetClipPlanefOES5246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearDepthfOES5247; 
		public static void glClearDepthfOES(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glClearDepthfOES5247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenfOES5248; 
		public static void glTexGenfOES(int arg0, int arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenfOES5248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenfvOES5249; 
		public static void glTexGenfvOES(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenfvOES5249, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenfvOES5250; 
		public static void glTexGenfvOES(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenfvOES5250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGeniOES5251; 
		public static void glTexGeniOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGeniOES5251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenivOES5252; 
		public static void glTexGenivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenivOES5252, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenivOES5253; 
		public static void glTexGenivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenivOES5253, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenxOES5254; 
		public static void glTexGenxOES(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenxOES5254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenxvOES5255; 
		public static void glTexGenxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenxvOES5255, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexGenxvOES5256; 
		public static void glTexGenxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glTexGenxvOES5256, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenfvOES5257; 
		public static void glGetTexGenfvOES(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenfvOES5257, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenfvOES5258; 
		public static void glGetTexGenfvOES(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenfvOES5258, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenivOES5259; 
		public static void glGetTexGenivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenivOES5259, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenivOES5260; 
		public static void glGetTexGenivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenivOES5260, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenxvOES5261; 
		public static void glGetTexGenxvOES(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenxvOES5261, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexGenxvOES5262; 
		public static void glGetTexGenxvOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._glGetTexGenxvOES5262, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GLES11Ext5263; 
		public GLES11Ext()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._GLES11Ext5263, this); 
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
			global::android.opengl.GLES11Ext._glBlendEquationSeparateOES5143 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glBlendEquationSeparateOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glBlendFuncSeparateOES5144 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glBlendFuncSeparateOES", "(IIII)V"); 
			global::android.opengl.GLES11Ext._glBlendEquationOES5145 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glBlendEquationOES", "(I)V"); 
			global::android.opengl.GLES11Ext._glDrawTexsOES5146 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsOES", "(SSSSS)V"); 
			global::android.opengl.GLES11Ext._glDrawTexiOES5147 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexiOES", "(IIIII)V"); 
			global::android.opengl.GLES11Ext._glDrawTexxOES5148 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxOES", "(IIIII)V"); 
			global::android.opengl.GLES11Ext._glDrawTexsvOES5149 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsvOES", "([SI)V"); 
			global::android.opengl.GLES11Ext._glDrawTexsvOES5150 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsvOES", "(Ljava/nio/ShortBuffer;)V"); 
			global::android.opengl.GLES11Ext._glDrawTexivOES5151 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexivOES", "([II)V"); 
			global::android.opengl.GLES11Ext._glDrawTexivOES5152 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexivOES", "(Ljava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glDrawTexxvOES5153 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxvOES", "([II)V"); 
			global::android.opengl.GLES11Ext._glDrawTexxvOES5154 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxvOES", "(Ljava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glDrawTexfOES5155 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfOES", "(FFFFF)V"); 
			global::android.opengl.GLES11Ext._glDrawTexfvOES5156 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfvOES", "([FI)V"); 
			global::android.opengl.GLES11Ext._glDrawTexfvOES5157 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfvOES", "(Ljava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11Ext._glEGLImageTargetTexture2DOES5158 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glEGLImageTargetTexture2DOES", "(ILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES11Ext._glEGLImageTargetRenderbufferStorageOES5159 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glEGLImageTargetRenderbufferStorageOES", "(ILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES11Ext._glAlphaFuncxOES5160 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glAlphaFuncxOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glClearColorxOES5161 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClearColorxOES", "(IIII)V"); 
			global::android.opengl.GLES11Ext._glClearDepthxOES5162 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClearDepthxOES", "(I)V"); 
			global::android.opengl.GLES11Ext._glClipPlanexOES5163 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClipPlanexOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glClipPlanexOES5164 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClipPlanexOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glColor4xOES5165 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glColor4xOES", "(IIII)V"); 
			global::android.opengl.GLES11Ext._glDepthRangexOES5166 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDepthRangexOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glFogxOES5167 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFogxOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glFogxvOES5168 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFogxvOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glFogxvOES5169 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFogxvOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glFrustumxOES5170 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFrustumxOES", "(IIIIII)V"); 
			global::android.opengl.GLES11Ext._glGetClipPlanexOES5171 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanexOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glGetClipPlanexOES5172 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanexOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetFixedvOES5173 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetFixedvOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetFixedvOES5174 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetFixedvOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glGetLightxvOES5175 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetLightxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glGetLightxvOES5176 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetLightxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetMaterialxvOES5177 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetMaterialxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glGetMaterialxvOES5178 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetMaterialxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetTexEnvxvOES5179 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexEnvxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetTexEnvxvOES5180 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexEnvxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glGetTexParameterxvOES5181 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexParameterxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glGetTexParameterxvOES5182 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexParameterxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glLightModelxOES5183 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightModelxOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glLightModelxvOES5184 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightModelxvOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glLightModelxvOES5185 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightModelxvOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glLightxOES5186 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightxOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glLightxvOES5187 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glLightxvOES5188 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLightxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glLineWidthxOES5189 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLineWidthxOES", "(I)V"); 
			global::android.opengl.GLES11Ext._glLoadMatrixxOES5190 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLoadMatrixxOES", "([II)V"); 
			global::android.opengl.GLES11Ext._glLoadMatrixxOES5191 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLoadMatrixxOES", "(Ljava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glMaterialxOES5192 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMaterialxOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glMaterialxvOES5193 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMaterialxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glMaterialxvOES5194 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMaterialxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glMultMatrixxOES5195 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMultMatrixxOES", "([II)V"); 
			global::android.opengl.GLES11Ext._glMultMatrixxOES5196 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMultMatrixxOES", "(Ljava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glMultiTexCoord4xOES5197 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMultiTexCoord4xOES", "(IIIII)V"); 
			global::android.opengl.GLES11Ext._glNormal3xOES5198 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glNormal3xOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glOrthoxOES5199 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glOrthoxOES", "(IIIIII)V"); 
			global::android.opengl.GLES11Ext._glPointParameterxOES5200 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glPointParameterxvOES5201 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxvOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glPointParameterxvOES5202 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxvOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glPointSizexOES5203 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glPointSizexOES", "(I)V"); 
			global::android.opengl.GLES11Ext._glPolygonOffsetxOES5204 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glPolygonOffsetxOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glRotatexOES5205 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glRotatexOES", "(IIII)V"); 
			global::android.opengl.GLES11Ext._glSampleCoveragexOES5206 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glSampleCoveragexOES", "(IZ)V"); 
			global::android.opengl.GLES11Ext._glScalexOES5207 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glScalexOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glTexEnvxOES5208 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glTexEnvxvOES5209 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glTexEnvxvOES5210 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glTexParameterxOES5211 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glTexParameterxvOES5212 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glTexParameterxvOES5213 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glTranslatexOES5214 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTranslatexOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glIsRenderbufferOES5215 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glIsRenderbufferOES", "(I)Z"); 
			global::android.opengl.GLES11Ext._glBindRenderbufferOES5216 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glBindRenderbufferOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES5217 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDeleteRenderbuffersOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glDeleteRenderbuffersOES5218 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDeleteRenderbuffersOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glGenRenderbuffersOES5219 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGenRenderbuffersOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glGenRenderbuffersOES5220 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGenRenderbuffersOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glRenderbufferStorageOES5221 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glRenderbufferStorageOES", "(IIII)V"); 
			global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES5222 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetRenderbufferParameterivOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glGetRenderbufferParameterivOES5223 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetRenderbufferParameterivOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glIsFramebufferOES5224 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glIsFramebufferOES", "(I)Z"); 
			global::android.opengl.GLES11Ext._glBindFramebufferOES5225 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glBindFramebufferOES", "(II)V"); 
			global::android.opengl.GLES11Ext._glDeleteFramebuffersOES5226 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDeleteFramebuffersOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glDeleteFramebuffersOES5227 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDeleteFramebuffersOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGenFramebuffersOES5228 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGenFramebuffersOES", "(I[II)V"); 
			global::android.opengl.GLES11Ext._glGenFramebuffersOES5229 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGenFramebuffersOES", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glCheckFramebufferStatusOES5230 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glCheckFramebufferStatusOES", "(I)I"); 
			global::android.opengl.GLES11Ext._glFramebufferRenderbufferOES5231 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFramebufferRenderbufferOES", "(IIII)V"); 
			global::android.opengl.GLES11Ext._glFramebufferTexture2DOES5232 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFramebufferTexture2DOES", "(IIIII)V"); 
			global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES5233 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetFramebufferAttachmentParameterivOES", "(III[II)V"); 
			global::android.opengl.GLES11Ext._glGetFramebufferAttachmentParameterivOES5234 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetFramebufferAttachmentParameterivOES", "(IIILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGenerateMipmapOES5235 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGenerateMipmapOES", "(I)V"); 
			global::android.opengl.GLES11Ext._glCurrentPaletteMatrixOES5236 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glCurrentPaletteMatrixOES", "(I)V"); 
			global::android.opengl.GLES11Ext._glLoadPaletteFromModelViewMatrixOES5237 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glLoadPaletteFromModelViewMatrixOES", "()V"); 
			global::android.opengl.GLES11Ext._glMatrixIndexPointerOES5238 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glMatrixIndexPointerOES", "(IIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES11Ext._glWeightPointerOES5239 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glWeightPointerOES", "(IIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES11Ext._glDepthRangefOES5240 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glDepthRangefOES", "(FF)V"); 
			global::android.opengl.GLES11Ext._glFrustumfOES5241 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glFrustumfOES", "(FFFFFF)V"); 
			global::android.opengl.GLES11Ext._glOrthofOES5242 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glOrthofOES", "(FFFFFF)V"); 
			global::android.opengl.GLES11Ext._glClipPlanefOES5243 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClipPlanefOES", "(I[FI)V"); 
			global::android.opengl.GLES11Ext._glClipPlanefOES5244 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClipPlanefOES", "(ILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetClipPlanefOES5245 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanefOES", "(I[FI)V"); 
			global::android.opengl.GLES11Ext._glGetClipPlanefOES5246 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanefOES", "(ILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11Ext._glClearDepthfOES5247 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glClearDepthfOES", "(F)V"); 
			global::android.opengl.GLES11Ext._glTexGenfOES5248 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenfOES", "(IIF)V"); 
			global::android.opengl.GLES11Ext._glTexGenfvOES5249 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenfvOES", "(II[FI)V"); 
			global::android.opengl.GLES11Ext._glTexGenfvOES5250 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenfvOES", "(IILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11Ext._glTexGeniOES5251 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGeniOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glTexGenivOES5252 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenivOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glTexGenivOES5253 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenivOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glTexGenxOES5254 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenxOES", "(III)V"); 
			global::android.opengl.GLES11Ext._glTexGenxvOES5255 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glTexGenxvOES5256 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glTexGenxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetTexGenfvOES5257 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenfvOES", "(II[FI)V"); 
			global::android.opengl.GLES11Ext._glGetTexGenfvOES5258 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenfvOES", "(IILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetTexGenivOES5259 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenivOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glGetTexGenivOES5260 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenivOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._glGetTexGenxvOES5261 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenxvOES", "(II[II)V"); 
			global::android.opengl.GLES11Ext._glGetTexGenxvOES5262 = @__env.GetStaticMethodID(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenxvOES", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES11Ext._GLES11Ext5263 = @__env.GetMethodID(global::android.opengl.GLES11Ext.staticClass, "<init>", "()V"); 
		} 
	} 
} 
