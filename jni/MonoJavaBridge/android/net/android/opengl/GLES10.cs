namespace android.opengl 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GLES10 : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GLES10() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.opengl.GLES10), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.opengl.GLES10(@__env); 
			} 
		} 
		protected GLES10(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glActiveTexture4946; 
		public static void glActiveTexture(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glActiveTexture4946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glAlphaFunc4947; 
		public static void glAlphaFunc(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glAlphaFunc4947, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glAlphaFuncx4948; 
		public static void glAlphaFuncx(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glAlphaFuncx4948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBindTexture4949; 
		public static void glBindTexture(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glBindTexture4949, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBlendFunc4950; 
		public static void glBlendFunc(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glBlendFunc4950, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClear4951; 
		public static void glClear(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glClear4951, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearColor4952; 
		public static void glClearColor(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glClearColor4952, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearColorx4953; 
		public static void glClearColorx(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glClearColorx4953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearDepthf4954; 
		public static void glClearDepthf(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glClearDepthf4954, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearDepthx4955; 
		public static void glClearDepthx(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glClearDepthx4955, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearStencil4956; 
		public static void glClearStencil(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glClearStencil4956, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClientActiveTexture4957; 
		public static void glClientActiveTexture(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glClientActiveTexture4957, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glColor4f4958; 
		public static void glColor4f(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glColor4f4958, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glColor4x4959; 
		public static void glColor4x(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glColor4x4959, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glColorMask4960; 
		public static void glColorMask(bool arg0, bool arg1, bool arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glColorMask4960, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glColorPointer4961; 
		public static void glColorPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glColorPointer4961, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCompressedTexImage2D4962; 
		public static void glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glCompressedTexImage2D4962, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCompressedTexSubImage2D4963; 
		public static void glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glCompressedTexSubImage2D4963, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCopyTexImage2D4964; 
		public static void glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glCopyTexImage2D4964, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCopyTexSubImage2D4965; 
		public static void glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glCopyTexSubImage2D4965, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCullFace4966; 
		public static void glCullFace(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glCullFace4966, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteTextures4967; 
		public static void glDeleteTextures(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDeleteTextures4967, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteTextures4968; 
		public static void glDeleteTextures(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDeleteTextures4968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthFunc4969; 
		public static void glDepthFunc(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDepthFunc4969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthMask4970; 
		public static void glDepthMask(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDepthMask4970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthRangef4971; 
		public static void glDepthRangef(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDepthRangef4971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthRangex4972; 
		public static void glDepthRangex(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDepthRangex4972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDisable4973; 
		public static void glDisable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDisable4973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDisableClientState4974; 
		public static void glDisableClientState(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDisableClientState4974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawArrays4975; 
		public static void glDrawArrays(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDrawArrays4975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawElements4976; 
		public static void glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDrawElements4976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glEnable4977; 
		public static void glEnable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glEnable4977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glEnableClientState4978; 
		public static void glEnableClientState(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glEnableClientState4978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFinish4979; 
		public static void glFinish() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFinish4979); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFlush4980; 
		public static void glFlush() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFlush4980); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogf4981; 
		public static void glFogf(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFogf4981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogfv4982; 
		public static void glFogfv(int arg0, float[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFogfv4982, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogfv4983; 
		public static void glFogfv(int arg0, java.nio.FloatBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFogfv4983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogx4984; 
		public static void glFogx(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFogx4984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogxv4985; 
		public static void glFogxv(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFogxv4985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogxv4986; 
		public static void glFogxv(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFogxv4986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFrontFace4987; 
		public static void glFrontFace(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFrontFace4987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFrustumf4988; 
		public static void glFrustumf(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFrustumf4988, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFrustumx4989; 
		public static void glFrustumx(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFrustumx4989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenTextures4990; 
		public static void glGenTextures(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glGenTextures4990, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenTextures4991; 
		public static void glGenTextures(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glGenTextures4991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetError4992; 
		public static int glGetError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.opengl.GLES10.staticClass, _glGetError4992); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetIntegerv4993; 
		public static void glGetIntegerv(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glGetIntegerv4993, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetIntegerv4994; 
		public static void glGetIntegerv(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glGetIntegerv4994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetString4995; 
		public static java.lang.String glGetString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.opengl.GLES10.staticClass, _glGetString4995, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glHint4996; 
		public static void glHint(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glHint4996, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelf4997; 
		public static void glLightModelf(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightModelf4997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelfv4998; 
		public static void glLightModelfv(int arg0, float[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightModelfv4998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelfv4999; 
		public static void glLightModelfv(int arg0, java.nio.FloatBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightModelfv4999, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelx5000; 
		public static void glLightModelx(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightModelx5000, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxv5001; 
		public static void glLightModelxv(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightModelxv5001, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxv5002; 
		public static void glLightModelxv(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightModelxv5002, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightf5003; 
		public static void glLightf(int arg0, int arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightf5003, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightfv5004; 
		public static void glLightfv(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightfv5004, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightfv5005; 
		public static void glLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightfv5005, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightx5006; 
		public static void glLightx(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightx5006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightxv5007; 
		public static void glLightxv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightxv5007, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightxv5008; 
		public static void glLightxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightxv5008, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLineWidth5009; 
		public static void glLineWidth(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLineWidth5009, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLineWidthx5010; 
		public static void glLineWidthx(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLineWidthx5010, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadIdentity5011; 
		public static void glLoadIdentity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLoadIdentity5011); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixf5012; 
		public static void glLoadMatrixf(float[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLoadMatrixf5012, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixf5013; 
		public static void glLoadMatrixf(java.nio.FloatBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLoadMatrixf5013, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixx5014; 
		public static void glLoadMatrixx(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLoadMatrixx5014, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixx5015; 
		public static void glLoadMatrixx(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLoadMatrixx5015, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLogicOp5016; 
		public static void glLogicOp(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLogicOp5016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialf5017; 
		public static void glMaterialf(int arg0, int arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMaterialf5017, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialfv5018; 
		public static void glMaterialfv(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMaterialfv5018, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialfv5019; 
		public static void glMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMaterialfv5019, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialx5020; 
		public static void glMaterialx(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMaterialx5020, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxv5021; 
		public static void glMaterialxv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMaterialxv5021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxv5022; 
		public static void glMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMaterialxv5022, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMatrixMode5023; 
		public static void glMatrixMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMatrixMode5023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixf5024; 
		public static void glMultMatrixf(float[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMultMatrixf5024, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixf5025; 
		public static void glMultMatrixf(java.nio.FloatBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMultMatrixf5025, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixx5026; 
		public static void glMultMatrixx(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMultMatrixx5026, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixx5027; 
		public static void glMultMatrixx(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMultMatrixx5027, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultiTexCoord4f5028; 
		public static void glMultiTexCoord4f(int arg0, float arg1, float arg2, float arg3, float arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMultiTexCoord4f5028, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultiTexCoord4x5029; 
		public static void glMultiTexCoord4x(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMultiTexCoord4x5029, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glNormal3f5030; 
		public static void glNormal3f(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glNormal3f5030, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glNormal3x5031; 
		public static void glNormal3x(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glNormal3x5031, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glNormalPointer5032; 
		public static void glNormalPointer(int arg0, int arg1, java.nio.Buffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glNormalPointer5032, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glOrthof5033; 
		public static void glOrthof(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glOrthof5033, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glOrthox5034; 
		public static void glOrthox(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glOrthox5034, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPixelStorei5035; 
		public static void glPixelStorei(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glPixelStorei5035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointSize5036; 
		public static void glPointSize(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glPointSize5036, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointSizex5037; 
		public static void glPointSizex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glPointSizex5037, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPolygonOffset5038; 
		public static void glPolygonOffset(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glPolygonOffset5038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPolygonOffsetx5039; 
		public static void glPolygonOffsetx(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glPolygonOffsetx5039, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPopMatrix5040; 
		public static void glPopMatrix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glPopMatrix5040); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPushMatrix5041; 
		public static void glPushMatrix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glPushMatrix5041); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glReadPixels5042; 
		public static void glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glReadPixels5042, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glRotatef5043; 
		public static void glRotatef(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glRotatef5043, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glRotatex5044; 
		public static void glRotatex(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glRotatex5044, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glSampleCoverage5045; 
		public static void glSampleCoverage(float arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glSampleCoverage5045, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glSampleCoveragex5046; 
		public static void glSampleCoveragex(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glSampleCoveragex5046, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glScalef5047; 
		public static void glScalef(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glScalef5047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glScalex5048; 
		public static void glScalex(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glScalex5048, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glScissor5049; 
		public static void glScissor(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glScissor5049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glShadeModel5050; 
		public static void glShadeModel(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glShadeModel5050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glStencilFunc5051; 
		public static void glStencilFunc(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glStencilFunc5051, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glStencilMask5052; 
		public static void glStencilMask(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glStencilMask5052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glStencilOp5053; 
		public static void glStencilOp(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glStencilOp5053, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexCoordPointer5054; 
		public static void glTexCoordPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexCoordPointer5054, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvf5055; 
		public static void glTexEnvf(int arg0, int arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexEnvf5055, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvfv5056; 
		public static void glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexEnvfv5056, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvfv5057; 
		public static void glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexEnvfv5057, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvx5058; 
		public static void glTexEnvx(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexEnvx5058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxv5059; 
		public static void glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexEnvxv5059, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxv5060; 
		public static void glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexEnvxv5060, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexImage2D5061; 
		public static void glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexImage2D5061, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterf5062; 
		public static void glTexParameterf(int arg0, int arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexParameterf5062, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterx5063; 
		public static void glTexParameterx(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexParameterx5063, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexSubImage2D5064; 
		public static void glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexSubImage2D5064, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTranslatef5065; 
		public static void glTranslatef(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTranslatef5065, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTranslatex5066; 
		public static void glTranslatex(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTranslatex5066, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glVertexPointer5067; 
		public static void glVertexPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glVertexPointer5067, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glViewport5068; 
		public static void glViewport(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glViewport5068, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GLES105069; 
		public GLES10()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.opengl.GLES10.staticClass, _GLES105069, this); 
		} 
		public static int GL_ADD
		{ 
			get 
			{ 
				return 260; 
			} 
		} 
		public static int GL_ALIASED_LINE_WIDTH_RANGE
		{ 
			get 
			{ 
				return 33902; 
			} 
		} 
		public static int GL_ALIASED_POINT_SIZE_RANGE
		{ 
			get 
			{ 
				return 33901; 
			} 
		} 
		public static int GL_ALPHA
		{ 
			get 
			{ 
				return 6406; 
			} 
		} 
		public static int GL_ALPHA_BITS
		{ 
			get 
			{ 
				return 3413; 
			} 
		} 
		public static int GL_ALPHA_TEST
		{ 
			get 
			{ 
				return 3008; 
			} 
		} 
		public static int GL_ALWAYS
		{ 
			get 
			{ 
				return 519; 
			} 
		} 
		public static int GL_AMBIENT
		{ 
			get 
			{ 
				return 4608; 
			} 
		} 
		public static int GL_AMBIENT_AND_DIFFUSE
		{ 
			get 
			{ 
				return 5634; 
			} 
		} 
		public static int GL_AND
		{ 
			get 
			{ 
				return 5377; 
			} 
		} 
		public static int GL_AND_INVERTED
		{ 
			get 
			{ 
				return 5380; 
			} 
		} 
		public static int GL_AND_REVERSE
		{ 
			get 
			{ 
				return 5378; 
			} 
		} 
		public static int GL_BACK
		{ 
			get 
			{ 
				return 1029; 
			} 
		} 
		public static int GL_BLEND
		{ 
			get 
			{ 
				return 3042; 
			} 
		} 
		public static int GL_BLUE_BITS
		{ 
			get 
			{ 
				return 3412; 
			} 
		} 
		public static int GL_BYTE
		{ 
			get 
			{ 
				return 5120; 
			} 
		} 
		public static int GL_CCW
		{ 
			get 
			{ 
				return 2305; 
			} 
		} 
		public static int GL_CLAMP_TO_EDGE
		{ 
			get 
			{ 
				return 33071; 
			} 
		} 
		public static int GL_CLEAR
		{ 
			get 
			{ 
				return 5376; 
			} 
		} 
		public static int GL_COLOR_ARRAY
		{ 
			get 
			{ 
				return 32886; 
			} 
		} 
		public static int GL_COLOR_BUFFER_BIT
		{ 
			get 
			{ 
				return 16384; 
			} 
		} 
		public static int GL_COLOR_LOGIC_OP
		{ 
			get 
			{ 
				return 3058; 
			} 
		} 
		public static int GL_COLOR_MATERIAL
		{ 
			get 
			{ 
				return 2903; 
			} 
		} 
		public static int GL_COMPRESSED_TEXTURE_FORMATS
		{ 
			get 
			{ 
				return 34467; 
			} 
		} 
		public static int GL_CONSTANT_ATTENUATION
		{ 
			get 
			{ 
				return 4615; 
			} 
		} 
		public static int GL_COPY
		{ 
			get 
			{ 
				return 5379; 
			} 
		} 
		public static int GL_COPY_INVERTED
		{ 
			get 
			{ 
				return 5388; 
			} 
		} 
		public static int GL_CULL_FACE
		{ 
			get 
			{ 
				return 2884; 
			} 
		} 
		public static int GL_CW
		{ 
			get 
			{ 
				return 2304; 
			} 
		} 
		public static int GL_DECAL
		{ 
			get 
			{ 
				return 8449; 
			} 
		} 
		public static int GL_DECR
		{ 
			get 
			{ 
				return 7683; 
			} 
		} 
		public static int GL_DEPTH_BITS
		{ 
			get 
			{ 
				return 3414; 
			} 
		} 
		public static int GL_DEPTH_BUFFER_BIT
		{ 
			get 
			{ 
				return 256; 
			} 
		} 
		public static int GL_DEPTH_TEST
		{ 
			get 
			{ 
				return 2929; 
			} 
		} 
		public static int GL_DIFFUSE
		{ 
			get 
			{ 
				return 4609; 
			} 
		} 
		public static int GL_DITHER
		{ 
			get 
			{ 
				return 3024; 
			} 
		} 
		public static int GL_DONT_CARE
		{ 
			get 
			{ 
				return 4352; 
			} 
		} 
		public static int GL_DST_ALPHA
		{ 
			get 
			{ 
				return 772; 
			} 
		} 
		public static int GL_DST_COLOR
		{ 
			get 
			{ 
				return 774; 
			} 
		} 
		public static int GL_EMISSION
		{ 
			get 
			{ 
				return 5632; 
			} 
		} 
		public static int GL_EQUAL
		{ 
			get 
			{ 
				return 514; 
			} 
		} 
		public static int GL_EQUIV
		{ 
			get 
			{ 
				return 5385; 
			} 
		} 
		public static int GL_EXP
		{ 
			get 
			{ 
				return 2048; 
			} 
		} 
		public static int GL_EXP2
		{ 
			get 
			{ 
				return 2049; 
			} 
		} 
		public static int GL_EXTENSIONS
		{ 
			get 
			{ 
				return 7939; 
			} 
		} 
		public static int GL_FALSE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int GL_FASTEST
		{ 
			get 
			{ 
				return 4353; 
			} 
		} 
		public static int GL_FIXED
		{ 
			get 
			{ 
				return 5132; 
			} 
		} 
		public static int GL_FLAT
		{ 
			get 
			{ 
				return 7424; 
			} 
		} 
		public static int GL_FLOAT
		{ 
			get 
			{ 
				return 5126; 
			} 
		} 
		public static int GL_FOG
		{ 
			get 
			{ 
				return 2912; 
			} 
		} 
		public static int GL_FOG_COLOR
		{ 
			get 
			{ 
				return 2918; 
			} 
		} 
		public static int GL_FOG_DENSITY
		{ 
			get 
			{ 
				return 2914; 
			} 
		} 
		public static int GL_FOG_END
		{ 
			get 
			{ 
				return 2916; 
			} 
		} 
		public static int GL_FOG_HINT
		{ 
			get 
			{ 
				return 3156; 
			} 
		} 
		public static int GL_FOG_MODE
		{ 
			get 
			{ 
				return 2917; 
			} 
		} 
		public static int GL_FOG_START
		{ 
			get 
			{ 
				return 2915; 
			} 
		} 
		public static int GL_FRONT
		{ 
			get 
			{ 
				return 1028; 
			} 
		} 
		public static int GL_FRONT_AND_BACK
		{ 
			get 
			{ 
				return 1032; 
			} 
		} 
		public static int GL_GEQUAL
		{ 
			get 
			{ 
				return 518; 
			} 
		} 
		public static int GL_GREATER
		{ 
			get 
			{ 
				return 516; 
			} 
		} 
		public static int GL_GREEN_BITS
		{ 
			get 
			{ 
				return 3411; 
			} 
		} 
		public static int GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES
		{ 
			get 
			{ 
				return 35739; 
			} 
		} 
		public static int GL_IMPLEMENTATION_COLOR_READ_TYPE_OES
		{ 
			get 
			{ 
				return 35738; 
			} 
		} 
		public static int GL_INCR
		{ 
			get 
			{ 
				return 7682; 
			} 
		} 
		public static int GL_INVALID_ENUM
		{ 
			get 
			{ 
				return 1280; 
			} 
		} 
		public static int GL_INVALID_OPERATION
		{ 
			get 
			{ 
				return 1282; 
			} 
		} 
		public static int GL_INVALID_VALUE
		{ 
			get 
			{ 
				return 1281; 
			} 
		} 
		public static int GL_INVERT
		{ 
			get 
			{ 
				return 5386; 
			} 
		} 
		public static int GL_KEEP
		{ 
			get 
			{ 
				return 7680; 
			} 
		} 
		public static int GL_LEQUAL
		{ 
			get 
			{ 
				return 515; 
			} 
		} 
		public static int GL_LESS
		{ 
			get 
			{ 
				return 513; 
			} 
		} 
		public static int GL_LIGHT_MODEL_AMBIENT
		{ 
			get 
			{ 
				return 2899; 
			} 
		} 
		public static int GL_LIGHT_MODEL_TWO_SIDE
		{ 
			get 
			{ 
				return 2898; 
			} 
		} 
		public static int GL_LIGHT0
		{ 
			get 
			{ 
				return 16384; 
			} 
		} 
		public static int GL_LIGHT1
		{ 
			get 
			{ 
				return 16385; 
			} 
		} 
		public static int GL_LIGHT2
		{ 
			get 
			{ 
				return 16386; 
			} 
		} 
		public static int GL_LIGHT3
		{ 
			get 
			{ 
				return 16387; 
			} 
		} 
		public static int GL_LIGHT4
		{ 
			get 
			{ 
				return 16388; 
			} 
		} 
		public static int GL_LIGHT5
		{ 
			get 
			{ 
				return 16389; 
			} 
		} 
		public static int GL_LIGHT6
		{ 
			get 
			{ 
				return 16390; 
			} 
		} 
		public static int GL_LIGHT7
		{ 
			get 
			{ 
				return 16391; 
			} 
		} 
		public static int GL_LIGHTING
		{ 
			get 
			{ 
				return 2896; 
			} 
		} 
		public static int GL_LINE_LOOP
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int GL_LINE_SMOOTH
		{ 
			get 
			{ 
				return 2848; 
			} 
		} 
		public static int GL_LINE_SMOOTH_HINT
		{ 
			get 
			{ 
				return 3154; 
			} 
		} 
		public static int GL_LINE_STRIP
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int GL_LINEAR
		{ 
			get 
			{ 
				return 9729; 
			} 
		} 
		public static int GL_LINEAR_ATTENUATION
		{ 
			get 
			{ 
				return 4616; 
			} 
		} 
		public static int GL_LINEAR_MIPMAP_LINEAR
		{ 
			get 
			{ 
				return 9987; 
			} 
		} 
		public static int GL_LINEAR_MIPMAP_NEAREST
		{ 
			get 
			{ 
				return 9985; 
			} 
		} 
		public static int GL_LINES
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int GL_LUMINANCE
		{ 
			get 
			{ 
				return 6409; 
			} 
		} 
		public static int GL_LUMINANCE_ALPHA
		{ 
			get 
			{ 
				return 6410; 
			} 
		} 
		public static int GL_MAX_ELEMENTS_INDICES
		{ 
			get 
			{ 
				return 33001; 
			} 
		} 
		public static int GL_MAX_ELEMENTS_VERTICES
		{ 
			get 
			{ 
				return 33000; 
			} 
		} 
		public static int GL_MAX_LIGHTS
		{ 
			get 
			{ 
				return 3377; 
			} 
		} 
		public static int GL_MAX_MODELVIEW_STACK_DEPTH
		{ 
			get 
			{ 
				return 3382; 
			} 
		} 
		public static int GL_MAX_PROJECTION_STACK_DEPTH
		{ 
			get 
			{ 
				return 3384; 
			} 
		} 
		public static int GL_MAX_TEXTURE_SIZE
		{ 
			get 
			{ 
				return 3379; 
			} 
		} 
		public static int GL_MAX_TEXTURE_STACK_DEPTH
		{ 
			get 
			{ 
				return 3385; 
			} 
		} 
		public static int GL_MAX_TEXTURE_UNITS
		{ 
			get 
			{ 
				return 34018; 
			} 
		} 
		public static int GL_MAX_VIEWPORT_DIMS
		{ 
			get 
			{ 
				return 3386; 
			} 
		} 
		public static int GL_MODELVIEW
		{ 
			get 
			{ 
				return 5888; 
			} 
		} 
		public static int GL_MODULATE
		{ 
			get 
			{ 
				return 8448; 
			} 
		} 
		public static int GL_MULTISAMPLE
		{ 
			get 
			{ 
				return 32925; 
			} 
		} 
		public static int GL_NAND
		{ 
			get 
			{ 
				return 5390; 
			} 
		} 
		public static int GL_NEAREST
		{ 
			get 
			{ 
				return 9728; 
			} 
		} 
		public static int GL_NEAREST_MIPMAP_LINEAR
		{ 
			get 
			{ 
				return 9986; 
			} 
		} 
		public static int GL_NEAREST_MIPMAP_NEAREST
		{ 
			get 
			{ 
				return 9984; 
			} 
		} 
		public static int GL_NEVER
		{ 
			get 
			{ 
				return 512; 
			} 
		} 
		public static int GL_NICEST
		{ 
			get 
			{ 
				return 4354; 
			} 
		} 
		public static int GL_NO_ERROR
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int GL_NOOP
		{ 
			get 
			{ 
				return 5381; 
			} 
		} 
		public static int GL_NOR
		{ 
			get 
			{ 
				return 5384; 
			} 
		} 
		public static int GL_NORMAL_ARRAY
		{ 
			get 
			{ 
				return 32885; 
			} 
		} 
		public static int GL_NORMALIZE
		{ 
			get 
			{ 
				return 2977; 
			} 
		} 
		public static int GL_NOTEQUAL
		{ 
			get 
			{ 
				return 517; 
			} 
		} 
		public static int GL_NUM_COMPRESSED_TEXTURE_FORMATS
		{ 
			get 
			{ 
				return 34466; 
			} 
		} 
		public static int GL_ONE
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int GL_ONE_MINUS_DST_ALPHA
		{ 
			get 
			{ 
				return 773; 
			} 
		} 
		public static int GL_ONE_MINUS_DST_COLOR
		{ 
			get 
			{ 
				return 775; 
			} 
		} 
		public static int GL_ONE_MINUS_SRC_ALPHA
		{ 
			get 
			{ 
				return 771; 
			} 
		} 
		public static int GL_ONE_MINUS_SRC_COLOR
		{ 
			get 
			{ 
				return 769; 
			} 
		} 
		public static int GL_OR
		{ 
			get 
			{ 
				return 5383; 
			} 
		} 
		public static int GL_OR_INVERTED
		{ 
			get 
			{ 
				return 5389; 
			} 
		} 
		public static int GL_OR_REVERSE
		{ 
			get 
			{ 
				return 5387; 
			} 
		} 
		public static int GL_OUT_OF_MEMORY
		{ 
			get 
			{ 
				return 1285; 
			} 
		} 
		public static int GL_PACK_ALIGNMENT
		{ 
			get 
			{ 
				return 3333; 
			} 
		} 
		public static int GL_PALETTE4_R5_G6_B5_OES
		{ 
			get 
			{ 
				return 35730; 
			} 
		} 
		public static int GL_PALETTE4_RGB5_A1_OES
		{ 
			get 
			{ 
				return 35732; 
			} 
		} 
		public static int GL_PALETTE4_RGB8_OES
		{ 
			get 
			{ 
				return 35728; 
			} 
		} 
		public static int GL_PALETTE4_RGBA4_OES
		{ 
			get 
			{ 
				return 35731; 
			} 
		} 
		public static int GL_PALETTE4_RGBA8_OES
		{ 
			get 
			{ 
				return 35729; 
			} 
		} 
		public static int GL_PALETTE8_R5_G6_B5_OES
		{ 
			get 
			{ 
				return 35735; 
			} 
		} 
		public static int GL_PALETTE8_RGB5_A1_OES
		{ 
			get 
			{ 
				return 35737; 
			} 
		} 
		public static int GL_PALETTE8_RGB8_OES
		{ 
			get 
			{ 
				return 35733; 
			} 
		} 
		public static int GL_PALETTE8_RGBA4_OES
		{ 
			get 
			{ 
				return 35736; 
			} 
		} 
		public static int GL_PALETTE8_RGBA8_OES
		{ 
			get 
			{ 
				return 35734; 
			} 
		} 
		public static int GL_PERSPECTIVE_CORRECTION_HINT
		{ 
			get 
			{ 
				return 3152; 
			} 
		} 
		public static int GL_POINT_SMOOTH
		{ 
			get 
			{ 
				return 2832; 
			} 
		} 
		public static int GL_POINT_SMOOTH_HINT
		{ 
			get 
			{ 
				return 3153; 
			} 
		} 
		public static int GL_POINTS
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int GL_POINT_FADE_THRESHOLD_SIZE
		{ 
			get 
			{ 
				return 33064; 
			} 
		} 
		public static int GL_POINT_SIZE
		{ 
			get 
			{ 
				return 2833; 
			} 
		} 
		public static int GL_POLYGON_OFFSET_FILL
		{ 
			get 
			{ 
				return 32823; 
			} 
		} 
		public static int GL_POLYGON_SMOOTH_HINT
		{ 
			get 
			{ 
				return 3155; 
			} 
		} 
		public static int GL_POSITION
		{ 
			get 
			{ 
				return 4611; 
			} 
		} 
		public static int GL_PROJECTION
		{ 
			get 
			{ 
				return 5889; 
			} 
		} 
		public static int GL_QUADRATIC_ATTENUATION
		{ 
			get 
			{ 
				return 4617; 
			} 
		} 
		public static int GL_RED_BITS
		{ 
			get 
			{ 
				return 3410; 
			} 
		} 
		public static int GL_RENDERER
		{ 
			get 
			{ 
				return 7937; 
			} 
		} 
		public static int GL_REPEAT
		{ 
			get 
			{ 
				return 10497; 
			} 
		} 
		public static int GL_REPLACE
		{ 
			get 
			{ 
				return 7681; 
			} 
		} 
		public static int GL_RESCALE_NORMAL
		{ 
			get 
			{ 
				return 32826; 
			} 
		} 
		public static int GL_RGB
		{ 
			get 
			{ 
				return 6407; 
			} 
		} 
		public static int GL_RGBA
		{ 
			get 
			{ 
				return 6408; 
			} 
		} 
		public static int GL_SAMPLE_ALPHA_TO_COVERAGE
		{ 
			get 
			{ 
				return 32926; 
			} 
		} 
		public static int GL_SAMPLE_ALPHA_TO_ONE
		{ 
			get 
			{ 
				return 32927; 
			} 
		} 
		public static int GL_SAMPLE_COVERAGE
		{ 
			get 
			{ 
				return 32928; 
			} 
		} 
		public static int GL_SCISSOR_TEST
		{ 
			get 
			{ 
				return 3089; 
			} 
		} 
		public static int GL_SET
		{ 
			get 
			{ 
				return 5391; 
			} 
		} 
		public static int GL_SHININESS
		{ 
			get 
			{ 
				return 5633; 
			} 
		} 
		public static int GL_SHORT
		{ 
			get 
			{ 
				return 5122; 
			} 
		} 
		public static int GL_SMOOTH
		{ 
			get 
			{ 
				return 7425; 
			} 
		} 
		public static int GL_SMOOTH_LINE_WIDTH_RANGE
		{ 
			get 
			{ 
				return 2850; 
			} 
		} 
		public static int GL_SMOOTH_POINT_SIZE_RANGE
		{ 
			get 
			{ 
				return 2834; 
			} 
		} 
		public static int GL_SPECULAR
		{ 
			get 
			{ 
				return 4610; 
			} 
		} 
		public static int GL_SPOT_CUTOFF
		{ 
			get 
			{ 
				return 4614; 
			} 
		} 
		public static int GL_SPOT_DIRECTION
		{ 
			get 
			{ 
				return 4612; 
			} 
		} 
		public static int GL_SPOT_EXPONENT
		{ 
			get 
			{ 
				return 4613; 
			} 
		} 
		public static int GL_SRC_ALPHA
		{ 
			get 
			{ 
				return 770; 
			} 
		} 
		public static int GL_SRC_ALPHA_SATURATE
		{ 
			get 
			{ 
				return 776; 
			} 
		} 
		public static int GL_SRC_COLOR
		{ 
			get 
			{ 
				return 768; 
			} 
		} 
		public static int GL_STACK_OVERFLOW
		{ 
			get 
			{ 
				return 1283; 
			} 
		} 
		public static int GL_STACK_UNDERFLOW
		{ 
			get 
			{ 
				return 1284; 
			} 
		} 
		public static int GL_STENCIL_BITS
		{ 
			get 
			{ 
				return 3415; 
			} 
		} 
		public static int GL_STENCIL_BUFFER_BIT
		{ 
			get 
			{ 
				return 1024; 
			} 
		} 
		public static int GL_STENCIL_TEST
		{ 
			get 
			{ 
				return 2960; 
			} 
		} 
		public static int GL_SUBPIXEL_BITS
		{ 
			get 
			{ 
				return 3408; 
			} 
		} 
		public static int GL_TEXTURE
		{ 
			get 
			{ 
				return 5890; 
			} 
		} 
		public static int GL_TEXTURE_2D
		{ 
			get 
			{ 
				return 3553; 
			} 
		} 
		public static int GL_TEXTURE_COORD_ARRAY
		{ 
			get 
			{ 
				return 32888; 
			} 
		} 
		public static int GL_TEXTURE_ENV
		{ 
			get 
			{ 
				return 8960; 
			} 
		} 
		public static int GL_TEXTURE_ENV_COLOR
		{ 
			get 
			{ 
				return 8705; 
			} 
		} 
		public static int GL_TEXTURE_ENV_MODE
		{ 
			get 
			{ 
				return 8704; 
			} 
		} 
		public static int GL_TEXTURE_MAG_FILTER
		{ 
			get 
			{ 
				return 10240; 
			} 
		} 
		public static int GL_TEXTURE_MIN_FILTER
		{ 
			get 
			{ 
				return 10241; 
			} 
		} 
		public static int GL_TEXTURE_WRAP_S
		{ 
			get 
			{ 
				return 10242; 
			} 
		} 
		public static int GL_TEXTURE_WRAP_T
		{ 
			get 
			{ 
				return 10243; 
			} 
		} 
		public static int GL_TEXTURE0
		{ 
			get 
			{ 
				return 33984; 
			} 
		} 
		public static int GL_TEXTURE1
		{ 
			get 
			{ 
				return 33985; 
			} 
		} 
		public static int GL_TEXTURE2
		{ 
			get 
			{ 
				return 33986; 
			} 
		} 
		public static int GL_TEXTURE3
		{ 
			get 
			{ 
				return 33987; 
			} 
		} 
		public static int GL_TEXTURE4
		{ 
			get 
			{ 
				return 33988; 
			} 
		} 
		public static int GL_TEXTURE5
		{ 
			get 
			{ 
				return 33989; 
			} 
		} 
		public static int GL_TEXTURE6
		{ 
			get 
			{ 
				return 33990; 
			} 
		} 
		public static int GL_TEXTURE7
		{ 
			get 
			{ 
				return 33991; 
			} 
		} 
		public static int GL_TEXTURE8
		{ 
			get 
			{ 
				return 33992; 
			} 
		} 
		public static int GL_TEXTURE9
		{ 
			get 
			{ 
				return 33993; 
			} 
		} 
		public static int GL_TEXTURE10
		{ 
			get 
			{ 
				return 33994; 
			} 
		} 
		public static int GL_TEXTURE11
		{ 
			get 
			{ 
				return 33995; 
			} 
		} 
		public static int GL_TEXTURE12
		{ 
			get 
			{ 
				return 33996; 
			} 
		} 
		public static int GL_TEXTURE13
		{ 
			get 
			{ 
				return 33997; 
			} 
		} 
		public static int GL_TEXTURE14
		{ 
			get 
			{ 
				return 33998; 
			} 
		} 
		public static int GL_TEXTURE15
		{ 
			get 
			{ 
				return 33999; 
			} 
		} 
		public static int GL_TEXTURE16
		{ 
			get 
			{ 
				return 34000; 
			} 
		} 
		public static int GL_TEXTURE17
		{ 
			get 
			{ 
				return 34001; 
			} 
		} 
		public static int GL_TEXTURE18
		{ 
			get 
			{ 
				return 34002; 
			} 
		} 
		public static int GL_TEXTURE19
		{ 
			get 
			{ 
				return 34003; 
			} 
		} 
		public static int GL_TEXTURE20
		{ 
			get 
			{ 
				return 34004; 
			} 
		} 
		public static int GL_TEXTURE21
		{ 
			get 
			{ 
				return 34005; 
			} 
		} 
		public static int GL_TEXTURE22
		{ 
			get 
			{ 
				return 34006; 
			} 
		} 
		public static int GL_TEXTURE23
		{ 
			get 
			{ 
				return 34007; 
			} 
		} 
		public static int GL_TEXTURE24
		{ 
			get 
			{ 
				return 34008; 
			} 
		} 
		public static int GL_TEXTURE25
		{ 
			get 
			{ 
				return 34009; 
			} 
		} 
		public static int GL_TEXTURE26
		{ 
			get 
			{ 
				return 34010; 
			} 
		} 
		public static int GL_TEXTURE27
		{ 
			get 
			{ 
				return 34011; 
			} 
		} 
		public static int GL_TEXTURE28
		{ 
			get 
			{ 
				return 34012; 
			} 
		} 
		public static int GL_TEXTURE29
		{ 
			get 
			{ 
				return 34013; 
			} 
		} 
		public static int GL_TEXTURE30
		{ 
			get 
			{ 
				return 34014; 
			} 
		} 
		public static int GL_TEXTURE31
		{ 
			get 
			{ 
				return 34015; 
			} 
		} 
		public static int GL_TRIANGLE_FAN
		{ 
			get 
			{ 
				return 6; 
			} 
		} 
		public static int GL_TRIANGLE_STRIP
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		public static int GL_TRIANGLES
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int GL_TRUE
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int GL_UNPACK_ALIGNMENT
		{ 
			get 
			{ 
				return 3317; 
			} 
		} 
		public static int GL_UNSIGNED_BYTE
		{ 
			get 
			{ 
				return 5121; 
			} 
		} 
		public static int GL_UNSIGNED_SHORT
		{ 
			get 
			{ 
				return 5123; 
			} 
		} 
		public static int GL_UNSIGNED_SHORT_4_4_4_4
		{ 
			get 
			{ 
				return 32819; 
			} 
		} 
		public static int GL_UNSIGNED_SHORT_5_5_5_1
		{ 
			get 
			{ 
				return 32820; 
			} 
		} 
		public static int GL_UNSIGNED_SHORT_5_6_5
		{ 
			get 
			{ 
				return 33635; 
			} 
		} 
		public static int GL_VENDOR
		{ 
			get 
			{ 
				return 7936; 
			} 
		} 
		public static int GL_VERSION
		{ 
			get 
			{ 
				return 7938; 
			} 
		} 
		public static int GL_VERTEX_ARRAY
		{ 
			get 
			{ 
				return 32884; 
			} 
		} 
		public static int GL_XOR
		{ 
			get 
			{ 
				return 5382; 
			} 
		} 
		public static int GL_ZERO
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.opengl.GLES10.staticClass = @__class; 
			global::android.opengl.GLES10._glActiveTexture4946 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glActiveTexture", "(I)V"); 
			global::android.opengl.GLES10._glAlphaFunc4947 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glAlphaFunc", "(IF)V"); 
			global::android.opengl.GLES10._glAlphaFuncx4948 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glAlphaFuncx", "(II)V"); 
			global::android.opengl.GLES10._glBindTexture4949 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glBindTexture", "(II)V"); 
			global::android.opengl.GLES10._glBlendFunc4950 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glBlendFunc", "(II)V"); 
			global::android.opengl.GLES10._glClear4951 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glClear", "(I)V"); 
			global::android.opengl.GLES10._glClearColor4952 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glClearColor", "(FFFF)V"); 
			global::android.opengl.GLES10._glClearColorx4953 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glClearColorx", "(IIII)V"); 
			global::android.opengl.GLES10._glClearDepthf4954 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glClearDepthf", "(F)V"); 
			global::android.opengl.GLES10._glClearDepthx4955 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glClearDepthx", "(I)V"); 
			global::android.opengl.GLES10._glClearStencil4956 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glClearStencil", "(I)V"); 
			global::android.opengl.GLES10._glClientActiveTexture4957 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glClientActiveTexture", "(I)V"); 
			global::android.opengl.GLES10._glColor4f4958 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glColor4f", "(FFFF)V"); 
			global::android.opengl.GLES10._glColor4x4959 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glColor4x", "(IIII)V"); 
			global::android.opengl.GLES10._glColorMask4960 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glColorMask", "(ZZZZ)V"); 
			global::android.opengl.GLES10._glColorPointer4961 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glColorPointer", "(IIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glCompressedTexImage2D4962 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glCompressedTexSubImage2D4963 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glCopyTexImage2D4964 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glCopyTexImage2D", "(IIIIIIII)V"); 
			global::android.opengl.GLES10._glCopyTexSubImage2D4965 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glCopyTexSubImage2D", "(IIIIIIII)V"); 
			global::android.opengl.GLES10._glCullFace4966 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glCullFace", "(I)V"); 
			global::android.opengl.GLES10._glDeleteTextures4967 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDeleteTextures", "(I[II)V"); 
			global::android.opengl.GLES10._glDeleteTextures4968 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDeleteTextures", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glDepthFunc4969 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDepthFunc", "(I)V"); 
			global::android.opengl.GLES10._glDepthMask4970 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDepthMask", "(Z)V"); 
			global::android.opengl.GLES10._glDepthRangef4971 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDepthRangef", "(FF)V"); 
			global::android.opengl.GLES10._glDepthRangex4972 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDepthRangex", "(II)V"); 
			global::android.opengl.GLES10._glDisable4973 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDisable", "(I)V"); 
			global::android.opengl.GLES10._glDisableClientState4974 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDisableClientState", "(I)V"); 
			global::android.opengl.GLES10._glDrawArrays4975 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDrawArrays", "(III)V"); 
			global::android.opengl.GLES10._glDrawElements4976 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDrawElements", "(IIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glEnable4977 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glEnable", "(I)V"); 
			global::android.opengl.GLES10._glEnableClientState4978 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glEnableClientState", "(I)V"); 
			global::android.opengl.GLES10._glFinish4979 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFinish", "()V"); 
			global::android.opengl.GLES10._glFlush4980 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFlush", "()V"); 
			global::android.opengl.GLES10._glFogf4981 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFogf", "(IF)V"); 
			global::android.opengl.GLES10._glFogfv4982 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFogfv", "(I[FI)V"); 
			global::android.opengl.GLES10._glFogfv4983 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFogfv", "(ILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES10._glFogx4984 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFogx", "(II)V"); 
			global::android.opengl.GLES10._glFogxv4985 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFogxv", "(I[II)V"); 
			global::android.opengl.GLES10._glFogxv4986 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFogxv", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glFrontFace4987 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFrontFace", "(I)V"); 
			global::android.opengl.GLES10._glFrustumf4988 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFrustumf", "(FFFFFF)V"); 
			global::android.opengl.GLES10._glFrustumx4989 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFrustumx", "(IIIIII)V"); 
			global::android.opengl.GLES10._glGenTextures4990 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glGenTextures", "(I[II)V"); 
			global::android.opengl.GLES10._glGenTextures4991 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glGenTextures", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glGetError4992 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glGetError", "()I"); 
			global::android.opengl.GLES10._glGetIntegerv4993 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glGetIntegerv", "(I[II)V"); 
			global::android.opengl.GLES10._glGetIntegerv4994 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glGetString4995 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glGetString", "(I)Ljava/lang/String;"); 
			global::android.opengl.GLES10._glHint4996 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glHint", "(II)V"); 
			global::android.opengl.GLES10._glLightModelf4997 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightModelf", "(IF)V"); 
			global::android.opengl.GLES10._glLightModelfv4998 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightModelfv", "(I[FI)V"); 
			global::android.opengl.GLES10._glLightModelfv4999 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightModelfv", "(ILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES10._glLightModelx5000 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightModelx", "(II)V"); 
			global::android.opengl.GLES10._glLightModelxv5001 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightModelxv", "(I[II)V"); 
			global::android.opengl.GLES10._glLightModelxv5002 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightModelxv", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glLightf5003 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightf", "(IIF)V"); 
			global::android.opengl.GLES10._glLightfv5004 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightfv", "(II[FI)V"); 
			global::android.opengl.GLES10._glLightfv5005 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightfv", "(IILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES10._glLightx5006 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightx", "(III)V"); 
			global::android.opengl.GLES10._glLightxv5007 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightxv", "(II[II)V"); 
			global::android.opengl.GLES10._glLightxv5008 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightxv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glLineWidth5009 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLineWidth", "(F)V"); 
			global::android.opengl.GLES10._glLineWidthx5010 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLineWidthx", "(I)V"); 
			global::android.opengl.GLES10._glLoadIdentity5011 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLoadIdentity", "()V"); 
			global::android.opengl.GLES10._glLoadMatrixf5012 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLoadMatrixf", "([FI)V"); 
			global::android.opengl.GLES10._glLoadMatrixf5013 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES10._glLoadMatrixx5014 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLoadMatrixx", "([II)V"); 
			global::android.opengl.GLES10._glLoadMatrixx5015 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLoadMatrixx", "(Ljava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glLogicOp5016 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLogicOp", "(I)V"); 
			global::android.opengl.GLES10._glMaterialf5017 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMaterialf", "(IIF)V"); 
			global::android.opengl.GLES10._glMaterialfv5018 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMaterialfv", "(II[FI)V"); 
			global::android.opengl.GLES10._glMaterialfv5019 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMaterialfv", "(IILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES10._glMaterialx5020 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMaterialx", "(III)V"); 
			global::android.opengl.GLES10._glMaterialxv5021 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMaterialxv", "(II[II)V"); 
			global::android.opengl.GLES10._glMaterialxv5022 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMaterialxv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glMatrixMode5023 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMatrixMode", "(I)V"); 
			global::android.opengl.GLES10._glMultMatrixf5024 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMultMatrixf", "([FI)V"); 
			global::android.opengl.GLES10._glMultMatrixf5025 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMultMatrixf", "(Ljava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES10._glMultMatrixx5026 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMultMatrixx", "([II)V"); 
			global::android.opengl.GLES10._glMultMatrixx5027 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMultMatrixx", "(Ljava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glMultiTexCoord4f5028 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMultiTexCoord4f", "(IFFFF)V"); 
			global::android.opengl.GLES10._glMultiTexCoord4x5029 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMultiTexCoord4x", "(IIIII)V"); 
			global::android.opengl.GLES10._glNormal3f5030 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glNormal3f", "(FFF)V"); 
			global::android.opengl.GLES10._glNormal3x5031 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glNormal3x", "(III)V"); 
			global::android.opengl.GLES10._glNormalPointer5032 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glNormalPointer", "(IILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glOrthof5033 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glOrthof", "(FFFFFF)V"); 
			global::android.opengl.GLES10._glOrthox5034 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glOrthox", "(IIIIII)V"); 
			global::android.opengl.GLES10._glPixelStorei5035 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glPixelStorei", "(II)V"); 
			global::android.opengl.GLES10._glPointSize5036 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glPointSize", "(F)V"); 
			global::android.opengl.GLES10._glPointSizex5037 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glPointSizex", "(I)V"); 
			global::android.opengl.GLES10._glPolygonOffset5038 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glPolygonOffset", "(FF)V"); 
			global::android.opengl.GLES10._glPolygonOffsetx5039 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glPolygonOffsetx", "(II)V"); 
			global::android.opengl.GLES10._glPopMatrix5040 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glPopMatrix", "()V"); 
			global::android.opengl.GLES10._glPushMatrix5041 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glPushMatrix", "()V"); 
			global::android.opengl.GLES10._glReadPixels5042 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glReadPixels", "(IIIIIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glRotatef5043 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glRotatef", "(FFFF)V"); 
			global::android.opengl.GLES10._glRotatex5044 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glRotatex", "(IIII)V"); 
			global::android.opengl.GLES10._glSampleCoverage5045 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glSampleCoverage", "(FZ)V"); 
			global::android.opengl.GLES10._glSampleCoveragex5046 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glSampleCoveragex", "(IZ)V"); 
			global::android.opengl.GLES10._glScalef5047 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glScalef", "(FFF)V"); 
			global::android.opengl.GLES10._glScalex5048 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glScalex", "(III)V"); 
			global::android.opengl.GLES10._glScissor5049 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glScissor", "(IIII)V"); 
			global::android.opengl.GLES10._glShadeModel5050 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glShadeModel", "(I)V"); 
			global::android.opengl.GLES10._glStencilFunc5051 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glStencilFunc", "(III)V"); 
			global::android.opengl.GLES10._glStencilMask5052 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glStencilMask", "(I)V"); 
			global::android.opengl.GLES10._glStencilOp5053 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glStencilOp", "(III)V"); 
			global::android.opengl.GLES10._glTexCoordPointer5054 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexCoordPointer", "(IIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glTexEnvf5055 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexEnvf", "(IIF)V"); 
			global::android.opengl.GLES10._glTexEnvfv5056 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexEnvfv", "(II[FI)V"); 
			global::android.opengl.GLES10._glTexEnvfv5057 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES10._glTexEnvx5058 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexEnvx", "(III)V"); 
			global::android.opengl.GLES10._glTexEnvxv5059 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexEnvxv", "(II[II)V"); 
			global::android.opengl.GLES10._glTexEnvxv5060 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glTexImage2D5061 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glTexParameterf5062 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexParameterf", "(IIF)V"); 
			global::android.opengl.GLES10._glTexParameterx5063 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexParameterx", "(III)V"); 
			global::android.opengl.GLES10._glTexSubImage2D5064 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glTranslatef5065 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTranslatef", "(FFF)V"); 
			global::android.opengl.GLES10._glTranslatex5066 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTranslatex", "(III)V"); 
			global::android.opengl.GLES10._glVertexPointer5067 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glVertexPointer", "(IIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glViewport5068 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glViewport", "(IIII)V"); 
			global::android.opengl.GLES10._GLES105069 = @__env.GetMethodID(global::android.opengl.GLES10.staticClass, "<init>", "()V"); 
		} 
	} 
} 
