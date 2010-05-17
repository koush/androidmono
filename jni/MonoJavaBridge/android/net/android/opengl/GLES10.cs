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
		internal static global::net.sf.jni4net.jni.MethodId _glActiveTexture4697; 
		public static void glActiveTexture(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glActiveTexture4697, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glAlphaFunc4698; 
		public static void glAlphaFunc(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glAlphaFunc4698, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glAlphaFuncx4699; 
		public static void glAlphaFuncx(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glAlphaFuncx4699, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBindTexture4700; 
		public static void glBindTexture(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glBindTexture4700, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBlendFunc4701; 
		public static void glBlendFunc(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glBlendFunc4701, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClear4702; 
		public static void glClear(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glClear4702, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearColor4703; 
		public static void glClearColor(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glClearColor4703, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearColorx4704; 
		public static void glClearColorx(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glClearColorx4704, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearDepthf4705; 
		public static void glClearDepthf(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glClearDepthf4705, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearDepthx4706; 
		public static void glClearDepthx(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glClearDepthx4706, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearStencil4707; 
		public static void glClearStencil(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glClearStencil4707, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClientActiveTexture4708; 
		public static void glClientActiveTexture(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glClientActiveTexture4708, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glColor4f4709; 
		public static void glColor4f(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glColor4f4709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glColor4x4710; 
		public static void glColor4x(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glColor4x4710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glColorMask4711; 
		public static void glColorMask(bool arg0, bool arg1, bool arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glColorMask4711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glColorPointer4712; 
		public static void glColorPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glColorPointer4712, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCompressedTexImage2D4713; 
		public static void glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glCompressedTexImage2D4713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCompressedTexSubImage2D4714; 
		public static void glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glCompressedTexSubImage2D4714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCopyTexImage2D4715; 
		public static void glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glCopyTexImage2D4715, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCopyTexSubImage2D4716; 
		public static void glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glCopyTexSubImage2D4716, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCullFace4717; 
		public static void glCullFace(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glCullFace4717, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteTextures4718; 
		public static void glDeleteTextures(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDeleteTextures4718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteTextures4719; 
		public static void glDeleteTextures(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDeleteTextures4719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthFunc4720; 
		public static void glDepthFunc(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDepthFunc4720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthMask4721; 
		public static void glDepthMask(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDepthMask4721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthRangef4722; 
		public static void glDepthRangef(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDepthRangef4722, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthRangex4723; 
		public static void glDepthRangex(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDepthRangex4723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDisable4724; 
		public static void glDisable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDisable4724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDisableClientState4725; 
		public static void glDisableClientState(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDisableClientState4725, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawArrays4726; 
		public static void glDrawArrays(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDrawArrays4726, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawElements4727; 
		public static void glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glDrawElements4727, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glEnable4728; 
		public static void glEnable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glEnable4728, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glEnableClientState4729; 
		public static void glEnableClientState(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glEnableClientState4729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFinish4730; 
		public static void glFinish() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFinish4730); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFlush4731; 
		public static void glFlush() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFlush4731); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogf4732; 
		public static void glFogf(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFogf4732, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogfv4733; 
		public static void glFogfv(int arg0, float[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFogfv4733, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogfv4734; 
		public static void glFogfv(int arg0, java.nio.FloatBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFogfv4734, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogx4735; 
		public static void glFogx(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFogx4735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogxv4736; 
		public static void glFogxv(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFogxv4736, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogxv4737; 
		public static void glFogxv(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFogxv4737, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFrontFace4738; 
		public static void glFrontFace(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFrontFace4738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFrustumf4739; 
		public static void glFrustumf(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFrustumf4739, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFrustumx4740; 
		public static void glFrustumx(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glFrustumx4740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenTextures4741; 
		public static void glGenTextures(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glGenTextures4741, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenTextures4742; 
		public static void glGenTextures(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glGenTextures4742, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetError4743; 
		public static int glGetError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.opengl.GLES10.staticClass, _glGetError4743); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetIntegerv4744; 
		public static void glGetIntegerv(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glGetIntegerv4744, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetIntegerv4745; 
		public static void glGetIntegerv(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glGetIntegerv4745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetString4746; 
		public static java.lang.String glGetString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.opengl.GLES10.staticClass, _glGetString4746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glHint4747; 
		public static void glHint(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glHint4747, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelf4748; 
		public static void glLightModelf(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightModelf4748, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelfv4749; 
		public static void glLightModelfv(int arg0, float[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightModelfv4749, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelfv4750; 
		public static void glLightModelfv(int arg0, java.nio.FloatBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightModelfv4750, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelx4751; 
		public static void glLightModelx(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightModelx4751, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxv4752; 
		public static void glLightModelxv(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightModelxv4752, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxv4753; 
		public static void glLightModelxv(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightModelxv4753, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightf4754; 
		public static void glLightf(int arg0, int arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightf4754, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightfv4755; 
		public static void glLightfv(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightfv4755, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightfv4756; 
		public static void glLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightfv4756, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightx4757; 
		public static void glLightx(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightx4757, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightxv4758; 
		public static void glLightxv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightxv4758, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightxv4759; 
		public static void glLightxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLightxv4759, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLineWidth4760; 
		public static void glLineWidth(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLineWidth4760, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLineWidthx4761; 
		public static void glLineWidthx(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLineWidthx4761, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadIdentity4762; 
		public static void glLoadIdentity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLoadIdentity4762); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixf4763; 
		public static void glLoadMatrixf(float[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLoadMatrixf4763, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixf4764; 
		public static void glLoadMatrixf(java.nio.FloatBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLoadMatrixf4764, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixx4765; 
		public static void glLoadMatrixx(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLoadMatrixx4765, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixx4766; 
		public static void glLoadMatrixx(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLoadMatrixx4766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLogicOp4767; 
		public static void glLogicOp(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glLogicOp4767, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialf4768; 
		public static void glMaterialf(int arg0, int arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMaterialf4768, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialfv4769; 
		public static void glMaterialfv(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMaterialfv4769, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialfv4770; 
		public static void glMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMaterialfv4770, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialx4771; 
		public static void glMaterialx(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMaterialx4771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxv4772; 
		public static void glMaterialxv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMaterialxv4772, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxv4773; 
		public static void glMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMaterialxv4773, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMatrixMode4774; 
		public static void glMatrixMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMatrixMode4774, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixf4775; 
		public static void glMultMatrixf(float[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMultMatrixf4775, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixf4776; 
		public static void glMultMatrixf(java.nio.FloatBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMultMatrixf4776, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixx4777; 
		public static void glMultMatrixx(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMultMatrixx4777, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixx4778; 
		public static void glMultMatrixx(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMultMatrixx4778, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultiTexCoord4f4779; 
		public static void glMultiTexCoord4f(int arg0, float arg1, float arg2, float arg3, float arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMultiTexCoord4f4779, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultiTexCoord4x4780; 
		public static void glMultiTexCoord4x(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glMultiTexCoord4x4780, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glNormal3f4781; 
		public static void glNormal3f(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glNormal3f4781, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glNormal3x4782; 
		public static void glNormal3x(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glNormal3x4782, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glNormalPointer4783; 
		public static void glNormalPointer(int arg0, int arg1, java.nio.Buffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glNormalPointer4783, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glOrthof4784; 
		public static void glOrthof(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glOrthof4784, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glOrthox4785; 
		public static void glOrthox(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glOrthox4785, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPixelStorei4786; 
		public static void glPixelStorei(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glPixelStorei4786, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointSize4787; 
		public static void glPointSize(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glPointSize4787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointSizex4788; 
		public static void glPointSizex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glPointSizex4788, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPolygonOffset4789; 
		public static void glPolygonOffset(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glPolygonOffset4789, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPolygonOffsetx4790; 
		public static void glPolygonOffsetx(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glPolygonOffsetx4790, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPopMatrix4791; 
		public static void glPopMatrix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glPopMatrix4791); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPushMatrix4792; 
		public static void glPushMatrix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glPushMatrix4792); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glReadPixels4793; 
		public static void glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glReadPixels4793, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glRotatef4794; 
		public static void glRotatef(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glRotatef4794, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glRotatex4795; 
		public static void glRotatex(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glRotatex4795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glSampleCoverage4796; 
		public static void glSampleCoverage(float arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glSampleCoverage4796, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glSampleCoveragex4797; 
		public static void glSampleCoveragex(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glSampleCoveragex4797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glScalef4798; 
		public static void glScalef(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glScalef4798, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glScalex4799; 
		public static void glScalex(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glScalex4799, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glScissor4800; 
		public static void glScissor(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glScissor4800, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glShadeModel4801; 
		public static void glShadeModel(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glShadeModel4801, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glStencilFunc4802; 
		public static void glStencilFunc(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glStencilFunc4802, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glStencilMask4803; 
		public static void glStencilMask(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glStencilMask4803, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glStencilOp4804; 
		public static void glStencilOp(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glStencilOp4804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexCoordPointer4805; 
		public static void glTexCoordPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexCoordPointer4805, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvf4806; 
		public static void glTexEnvf(int arg0, int arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexEnvf4806, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvfv4807; 
		public static void glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexEnvfv4807, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvfv4808; 
		public static void glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexEnvfv4808, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvx4809; 
		public static void glTexEnvx(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexEnvx4809, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxv4810; 
		public static void glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexEnvxv4810, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxv4811; 
		public static void glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexEnvxv4811, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexImage2D4812; 
		public static void glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexImage2D4812, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterf4813; 
		public static void glTexParameterf(int arg0, int arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexParameterf4813, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterx4814; 
		public static void glTexParameterx(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexParameterx4814, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexSubImage2D4815; 
		public static void glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTexSubImage2D4815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTranslatef4816; 
		public static void glTranslatef(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTranslatef4816, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTranslatex4817; 
		public static void glTranslatex(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glTranslatex4817, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glVertexPointer4818; 
		public static void glVertexPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glVertexPointer4818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glViewport4819; 
		public static void glViewport(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, _glViewport4819, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GLES104820; 
		public GLES10()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.opengl.GLES10.staticClass, _GLES104820, this); 
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
			global::android.opengl.GLES10._glActiveTexture4697 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glActiveTexture", "(I)V"); 
			global::android.opengl.GLES10._glAlphaFunc4698 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glAlphaFunc", "(IF)V"); 
			global::android.opengl.GLES10._glAlphaFuncx4699 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glAlphaFuncx", "(II)V"); 
			global::android.opengl.GLES10._glBindTexture4700 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glBindTexture", "(II)V"); 
			global::android.opengl.GLES10._glBlendFunc4701 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glBlendFunc", "(II)V"); 
			global::android.opengl.GLES10._glClear4702 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glClear", "(I)V"); 
			global::android.opengl.GLES10._glClearColor4703 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glClearColor", "(FFFF)V"); 
			global::android.opengl.GLES10._glClearColorx4704 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glClearColorx", "(IIII)V"); 
			global::android.opengl.GLES10._glClearDepthf4705 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glClearDepthf", "(F)V"); 
			global::android.opengl.GLES10._glClearDepthx4706 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glClearDepthx", "(I)V"); 
			global::android.opengl.GLES10._glClearStencil4707 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glClearStencil", "(I)V"); 
			global::android.opengl.GLES10._glClientActiveTexture4708 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glClientActiveTexture", "(I)V"); 
			global::android.opengl.GLES10._glColor4f4709 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glColor4f", "(FFFF)V"); 
			global::android.opengl.GLES10._glColor4x4710 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glColor4x", "(IIII)V"); 
			global::android.opengl.GLES10._glColorMask4711 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glColorMask", "(ZZZZ)V"); 
			global::android.opengl.GLES10._glColorPointer4712 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glColorPointer", "(IIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glCompressedTexImage2D4713 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glCompressedTexSubImage2D4714 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glCopyTexImage2D4715 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glCopyTexImage2D", "(IIIIIIII)V"); 
			global::android.opengl.GLES10._glCopyTexSubImage2D4716 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glCopyTexSubImage2D", "(IIIIIIII)V"); 
			global::android.opengl.GLES10._glCullFace4717 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glCullFace", "(I)V"); 
			global::android.opengl.GLES10._glDeleteTextures4718 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDeleteTextures", "(I[II)V"); 
			global::android.opengl.GLES10._glDeleteTextures4719 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDeleteTextures", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glDepthFunc4720 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDepthFunc", "(I)V"); 
			global::android.opengl.GLES10._glDepthMask4721 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDepthMask", "(Z)V"); 
			global::android.opengl.GLES10._glDepthRangef4722 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDepthRangef", "(FF)V"); 
			global::android.opengl.GLES10._glDepthRangex4723 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDepthRangex", "(II)V"); 
			global::android.opengl.GLES10._glDisable4724 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDisable", "(I)V"); 
			global::android.opengl.GLES10._glDisableClientState4725 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDisableClientState", "(I)V"); 
			global::android.opengl.GLES10._glDrawArrays4726 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDrawArrays", "(III)V"); 
			global::android.opengl.GLES10._glDrawElements4727 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glDrawElements", "(IIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glEnable4728 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glEnable", "(I)V"); 
			global::android.opengl.GLES10._glEnableClientState4729 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glEnableClientState", "(I)V"); 
			global::android.opengl.GLES10._glFinish4730 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFinish", "()V"); 
			global::android.opengl.GLES10._glFlush4731 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFlush", "()V"); 
			global::android.opengl.GLES10._glFogf4732 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFogf", "(IF)V"); 
			global::android.opengl.GLES10._glFogfv4733 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFogfv", "(I[FI)V"); 
			global::android.opengl.GLES10._glFogfv4734 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFogfv", "(ILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES10._glFogx4735 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFogx", "(II)V"); 
			global::android.opengl.GLES10._glFogxv4736 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFogxv", "(I[II)V"); 
			global::android.opengl.GLES10._glFogxv4737 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFogxv", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glFrontFace4738 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFrontFace", "(I)V"); 
			global::android.opengl.GLES10._glFrustumf4739 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFrustumf", "(FFFFFF)V"); 
			global::android.opengl.GLES10._glFrustumx4740 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glFrustumx", "(IIIIII)V"); 
			global::android.opengl.GLES10._glGenTextures4741 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glGenTextures", "(I[II)V"); 
			global::android.opengl.GLES10._glGenTextures4742 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glGenTextures", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glGetError4743 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glGetError", "()I"); 
			global::android.opengl.GLES10._glGetIntegerv4744 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glGetIntegerv", "(I[II)V"); 
			global::android.opengl.GLES10._glGetIntegerv4745 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glGetString4746 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glGetString", "(I)Ljava/lang/String;"); 
			global::android.opengl.GLES10._glHint4747 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glHint", "(II)V"); 
			global::android.opengl.GLES10._glLightModelf4748 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightModelf", "(IF)V"); 
			global::android.opengl.GLES10._glLightModelfv4749 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightModelfv", "(I[FI)V"); 
			global::android.opengl.GLES10._glLightModelfv4750 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightModelfv", "(ILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES10._glLightModelx4751 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightModelx", "(II)V"); 
			global::android.opengl.GLES10._glLightModelxv4752 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightModelxv", "(I[II)V"); 
			global::android.opengl.GLES10._glLightModelxv4753 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightModelxv", "(ILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glLightf4754 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightf", "(IIF)V"); 
			global::android.opengl.GLES10._glLightfv4755 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightfv", "(II[FI)V"); 
			global::android.opengl.GLES10._glLightfv4756 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightfv", "(IILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES10._glLightx4757 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightx", "(III)V"); 
			global::android.opengl.GLES10._glLightxv4758 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightxv", "(II[II)V"); 
			global::android.opengl.GLES10._glLightxv4759 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLightxv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glLineWidth4760 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLineWidth", "(F)V"); 
			global::android.opengl.GLES10._glLineWidthx4761 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLineWidthx", "(I)V"); 
			global::android.opengl.GLES10._glLoadIdentity4762 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLoadIdentity", "()V"); 
			global::android.opengl.GLES10._glLoadMatrixf4763 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLoadMatrixf", "([FI)V"); 
			global::android.opengl.GLES10._glLoadMatrixf4764 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES10._glLoadMatrixx4765 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLoadMatrixx", "([II)V"); 
			global::android.opengl.GLES10._glLoadMatrixx4766 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLoadMatrixx", "(Ljava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glLogicOp4767 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glLogicOp", "(I)V"); 
			global::android.opengl.GLES10._glMaterialf4768 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMaterialf", "(IIF)V"); 
			global::android.opengl.GLES10._glMaterialfv4769 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMaterialfv", "(II[FI)V"); 
			global::android.opengl.GLES10._glMaterialfv4770 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMaterialfv", "(IILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES10._glMaterialx4771 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMaterialx", "(III)V"); 
			global::android.opengl.GLES10._glMaterialxv4772 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMaterialxv", "(II[II)V"); 
			global::android.opengl.GLES10._glMaterialxv4773 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMaterialxv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glMatrixMode4774 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMatrixMode", "(I)V"); 
			global::android.opengl.GLES10._glMultMatrixf4775 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMultMatrixf", "([FI)V"); 
			global::android.opengl.GLES10._glMultMatrixf4776 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMultMatrixf", "(Ljava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES10._glMultMatrixx4777 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMultMatrixx", "([II)V"); 
			global::android.opengl.GLES10._glMultMatrixx4778 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMultMatrixx", "(Ljava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glMultiTexCoord4f4779 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMultiTexCoord4f", "(IFFFF)V"); 
			global::android.opengl.GLES10._glMultiTexCoord4x4780 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glMultiTexCoord4x", "(IIIII)V"); 
			global::android.opengl.GLES10._glNormal3f4781 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glNormal3f", "(FFF)V"); 
			global::android.opengl.GLES10._glNormal3x4782 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glNormal3x", "(III)V"); 
			global::android.opengl.GLES10._glNormalPointer4783 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glNormalPointer", "(IILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glOrthof4784 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glOrthof", "(FFFFFF)V"); 
			global::android.opengl.GLES10._glOrthox4785 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glOrthox", "(IIIIII)V"); 
			global::android.opengl.GLES10._glPixelStorei4786 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glPixelStorei", "(II)V"); 
			global::android.opengl.GLES10._glPointSize4787 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glPointSize", "(F)V"); 
			global::android.opengl.GLES10._glPointSizex4788 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glPointSizex", "(I)V"); 
			global::android.opengl.GLES10._glPolygonOffset4789 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glPolygonOffset", "(FF)V"); 
			global::android.opengl.GLES10._glPolygonOffsetx4790 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glPolygonOffsetx", "(II)V"); 
			global::android.opengl.GLES10._glPopMatrix4791 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glPopMatrix", "()V"); 
			global::android.opengl.GLES10._glPushMatrix4792 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glPushMatrix", "()V"); 
			global::android.opengl.GLES10._glReadPixels4793 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glReadPixels", "(IIIIIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glRotatef4794 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glRotatef", "(FFFF)V"); 
			global::android.opengl.GLES10._glRotatex4795 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glRotatex", "(IIII)V"); 
			global::android.opengl.GLES10._glSampleCoverage4796 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glSampleCoverage", "(FZ)V"); 
			global::android.opengl.GLES10._glSampleCoveragex4797 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glSampleCoveragex", "(IZ)V"); 
			global::android.opengl.GLES10._glScalef4798 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glScalef", "(FFF)V"); 
			global::android.opengl.GLES10._glScalex4799 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glScalex", "(III)V"); 
			global::android.opengl.GLES10._glScissor4800 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glScissor", "(IIII)V"); 
			global::android.opengl.GLES10._glShadeModel4801 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glShadeModel", "(I)V"); 
			global::android.opengl.GLES10._glStencilFunc4802 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glStencilFunc", "(III)V"); 
			global::android.opengl.GLES10._glStencilMask4803 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glStencilMask", "(I)V"); 
			global::android.opengl.GLES10._glStencilOp4804 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glStencilOp", "(III)V"); 
			global::android.opengl.GLES10._glTexCoordPointer4805 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexCoordPointer", "(IIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glTexEnvf4806 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexEnvf", "(IIF)V"); 
			global::android.opengl.GLES10._glTexEnvfv4807 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexEnvfv", "(II[FI)V"); 
			global::android.opengl.GLES10._glTexEnvfv4808 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V"); 
			global::android.opengl.GLES10._glTexEnvx4809 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexEnvx", "(III)V"); 
			global::android.opengl.GLES10._glTexEnvxv4810 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexEnvxv", "(II[II)V"); 
			global::android.opengl.GLES10._glTexEnvxv4811 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V"); 
			global::android.opengl.GLES10._glTexImage2D4812 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glTexParameterf4813 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexParameterf", "(IIF)V"); 
			global::android.opengl.GLES10._glTexParameterx4814 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexParameterx", "(III)V"); 
			global::android.opengl.GLES10._glTexSubImage2D4815 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glTranslatef4816 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTranslatef", "(FFF)V"); 
			global::android.opengl.GLES10._glTranslatex4817 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glTranslatex", "(III)V"); 
			global::android.opengl.GLES10._glVertexPointer4818 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glVertexPointer", "(IIILjava/nio/Buffer;)V"); 
			global::android.opengl.GLES10._glViewport4819 = @__env.GetStaticMethodID(global::android.opengl.GLES10.staticClass, "glViewport", "(IIII)V"); 
			global::android.opengl.GLES10._GLES104820 = @__env.GetMethodID(global::android.opengl.GLES10.staticClass, "<init>", "()V"); 
		} 
	} 
} 
