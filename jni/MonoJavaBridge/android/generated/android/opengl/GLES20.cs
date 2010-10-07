namespace android.opengl
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class GLES20 : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static GLES20()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.GLES20), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.opengl.GLES20(@__env);
			}
		}
		protected GLES20(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _glActiveTexture5605;
		public static void glActiveTexture(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glActiveTexture5605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBindTexture5606;
		public static void glBindTexture(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBindTexture5606, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBlendFunc5607;
		public static void glBlendFunc(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBlendFunc5607, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClear5608;
		public static void glClear(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glClear5608, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClearColor5609;
		public static void glClearColor(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glClearColor5609, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClearDepthf5610;
		public static void glClearDepthf(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glClearDepthf5610, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClearStencil5611;
		public static void glClearStencil(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glClearStencil5611, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glColorMask5612;
		public static void glColorMask(bool arg0, bool arg1, bool arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glColorMask5612, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCompressedTexImage2D5613;
		public static void glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCompressedTexImage2D5613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCompressedTexSubImage2D5614;
		public static void glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCompressedTexSubImage2D5614, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCopyTexImage2D5615;
		public static void glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCopyTexImage2D5615, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCopyTexSubImage2D5616;
		public static void glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCopyTexSubImage2D5616, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCullFace5617;
		public static void glCullFace(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCullFace5617, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteTextures5618;
		public static void glDeleteTextures(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteTextures5618, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteTextures5619;
		public static void glDeleteTextures(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteTextures5619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDepthFunc5620;
		public static void glDepthFunc(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDepthFunc5620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDepthMask5621;
		public static void glDepthMask(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDepthMask5621, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDepthRangef5622;
		public static void glDepthRangef(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDepthRangef5622, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDisable5623;
		public static void glDisable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDisable5623, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawArrays5624;
		public static void glDrawArrays(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDrawArrays5624, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawElements5625;
		public static void glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDrawElements5625, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glEnable5626;
		public static void glEnable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glEnable5626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFinish5627;
		public static void glFinish() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glFinish5627);
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFlush5628;
		public static void glFlush() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glFlush5628);
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFrontFace5629;
		public static void glFrontFace(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glFrontFace5629, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenTextures5630;
		public static void glGenTextures(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenTextures5630, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenTextures5631;
		public static void glGenTextures(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenTextures5631, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetError5632;
		public static int glGetError() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetError5632);
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetIntegerv5633;
		public static void glGetIntegerv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetIntegerv5633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetIntegerv5634;
		public static void glGetIntegerv(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetIntegerv5634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetString5635;
		public static global::java.lang.String glGetString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetString5635, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glHint5636;
		public static void glHint(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glHint5636, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLineWidth5637;
		public static void glLineWidth(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glLineWidth5637, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPixelStorei5638;
		public static void glPixelStorei(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glPixelStorei5638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPolygonOffset5639;
		public static void glPolygonOffset(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glPolygonOffset5639, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glReadPixels5640;
		public static void glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glReadPixels5640, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glSampleCoverage5641;
		public static void glSampleCoverage(float arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glSampleCoverage5641, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glScissor5642;
		public static void glScissor(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glScissor5642, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glStencilFunc5643;
		public static void glStencilFunc(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glStencilFunc5643, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glStencilMask5644;
		public static void glStencilMask(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glStencilMask5644, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glStencilOp5645;
		public static void glStencilOp(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glStencilOp5645, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexImage2D5646;
		public static void glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexImage2D5646, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterf5647;
		public static void glTexParameterf(int arg0, int arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexParameterf5647, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexSubImage2D5648;
		public static void glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexSubImage2D5648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glViewport5649;
		public static void glViewport(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glViewport5649, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBindBuffer5650;
		public static void glBindBuffer(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBindBuffer5650, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBufferData5651;
		public static void glBufferData(int arg0, int arg1, java.nio.Buffer arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBufferData5651, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBufferSubData5652;
		public static void glBufferSubData(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBufferSubData5652, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteBuffers5653;
		public static void glDeleteBuffers(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteBuffers5653, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteBuffers5654;
		public static void glDeleteBuffers(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteBuffers5654, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenBuffers5655;
		public static void glGenBuffers(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenBuffers5655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenBuffers5656;
		public static void glGenBuffers(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenBuffers5656, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetBooleanv5657;
		public static void glGetBooleanv(int arg0, bool[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetBooleanv5657, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetBooleanv5658;
		public static void glGetBooleanv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetBooleanv5658, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetBufferParameteriv5659;
		public static void glGetBufferParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetBufferParameteriv5659, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetBufferParameteriv5660;
		public static void glGetBufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetBufferParameteriv5660, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetFloatv5661;
		public static void glGetFloatv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetFloatv5661, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetFloatv5662;
		public static void glGetFloatv(int arg0, float[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetFloatv5662, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterfv5663;
		public static void glGetTexParameterfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetTexParameterfv5663, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameterfv5664;
		public static void glGetTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetTexParameterfv5664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameteriv5665;
		public static void glGetTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetTexParameteriv5665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetTexParameteriv5666;
		public static void glGetTexParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetTexParameteriv5666, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glIsBuffer5667;
		public static bool glIsBuffer(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glIsBuffer5667, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glIsEnabled5668;
		public static bool glIsEnabled(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glIsEnabled5668, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glIsTexture5669;
		public static bool glIsTexture(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glIsTexture5669, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterfv5670;
		public static void glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexParameterfv5670, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterfv5671;
		public static void glTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexParameterfv5671, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameteri5672;
		public static void glTexParameteri(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexParameteri5672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameteriv5673;
		public static void glTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexParameteriv5673, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameteriv5674;
		public static void glTexParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glTexParameteriv5674, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glAttachShader5675;
		public static void glAttachShader(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glAttachShader5675, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBindAttribLocation5676;
		public static void glBindAttribLocation(int arg0, int arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBindAttribLocation5676, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBindFramebuffer5677;
		public static void glBindFramebuffer(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBindFramebuffer5677, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBindRenderbuffer5678;
		public static void glBindRenderbuffer(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBindRenderbuffer5678, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBlendColor5679;
		public static void glBlendColor(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBlendColor5679, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBlendEquation5680;
		public static void glBlendEquation(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBlendEquation5680, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBlendEquationSeparate5681;
		public static void glBlendEquationSeparate(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBlendEquationSeparate5681, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBlendFuncSeparate5682;
		public static void glBlendFuncSeparate(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glBlendFuncSeparate5682, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCheckFramebufferStatus5683;
		public static int glCheckFramebufferStatus(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCheckFramebufferStatus5683, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCompileShader5684;
		public static void glCompileShader(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCompileShader5684, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCreateProgram5685;
		public static int glCreateProgram() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCreateProgram5685);
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCreateShader5686;
		public static int glCreateShader(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glCreateShader5686, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteFramebuffers5687;
		public static void glDeleteFramebuffers(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteFramebuffers5687, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteFramebuffers5688;
		public static void glDeleteFramebuffers(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteFramebuffers5688, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteProgram5689;
		public static void glDeleteProgram(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteProgram5689, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteRenderbuffers5690;
		public static void glDeleteRenderbuffers(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteRenderbuffers5690, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteRenderbuffers5691;
		public static void glDeleteRenderbuffers(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteRenderbuffers5691, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteShader5692;
		public static void glDeleteShader(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDeleteShader5692, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDetachShader5693;
		public static void glDetachShader(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDetachShader5693, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDisableVertexAttribArray5694;
		public static void glDisableVertexAttribArray(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glDisableVertexAttribArray5694, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glEnableVertexAttribArray5695;
		public static void glEnableVertexAttribArray(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glEnableVertexAttribArray5695, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFramebufferRenderbuffer5696;
		public static void glFramebufferRenderbuffer(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glFramebufferRenderbuffer5696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFramebufferTexture2D5697;
		public static void glFramebufferTexture2D(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glFramebufferTexture2D5697, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenerateMipmap5698;
		public static void glGenerateMipmap(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenerateMipmap5698, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenFramebuffers5699;
		public static void glGenFramebuffers(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenFramebuffers5699, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenFramebuffers5700;
		public static void glGenFramebuffers(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenFramebuffers5700, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenRenderbuffers5701;
		public static void glGenRenderbuffers(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenRenderbuffers5701, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenRenderbuffers5702;
		public static void glGenRenderbuffers(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGenRenderbuffers5702, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetActiveAttrib5703;
		public static void glGetActiveAttrib(int arg0, int arg1, int arg2, int[] arg3, int arg4, int[] arg5, int arg6, int[] arg7, int arg8, byte[] arg9, int arg10) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetActiveAttrib5703, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetActiveAttrib5704;
		public static void glGetActiveAttrib(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3, java.nio.IntBuffer arg4, java.nio.IntBuffer arg5, byte arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetActiveAttrib5704, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetActiveUniform5705;
		public static void glGetActiveUniform(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3, java.nio.IntBuffer arg4, java.nio.IntBuffer arg5, byte arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetActiveUniform5705, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetActiveUniform5706;
		public static void glGetActiveUniform(int arg0, int arg1, int arg2, int[] arg3, int arg4, int[] arg5, int arg6, int[] arg7, int arg8, byte[] arg9, int arg10) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetActiveUniform5706, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetAttachedShaders5707;
		public static void glGetAttachedShaders(int arg0, int arg1, int[] arg2, int arg3, int[] arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetAttachedShaders5707, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetAttachedShaders5708;
		public static void glGetAttachedShaders(int arg0, int arg1, java.nio.IntBuffer arg2, java.nio.IntBuffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetAttachedShaders5708, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetAttribLocation5709;
		public static int glGetAttribLocation(int arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetAttribLocation5709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetFramebufferAttachmentParameteriv5710;
		public static void glGetFramebufferAttachmentParameteriv(int arg0, int arg1, int arg2, int[] arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetFramebufferAttachmentParameteriv5710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetFramebufferAttachmentParameteriv5711;
		public static void glGetFramebufferAttachmentParameteriv(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetFramebufferAttachmentParameteriv5711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetProgramiv5712;
		public static void glGetProgramiv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetProgramiv5712, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetProgramiv5713;
		public static void glGetProgramiv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetProgramiv5713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetProgramInfoLog5714;
		public static global::java.lang.String glGetProgramInfoLog(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetProgramInfoLog5714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetRenderbufferParameteriv5715;
		public static void glGetRenderbufferParameteriv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetRenderbufferParameteriv5715, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetRenderbufferParameteriv5716;
		public static void glGetRenderbufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetRenderbufferParameteriv5716, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetShaderiv5717;
		public static void glGetShaderiv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetShaderiv5717, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetShaderiv5718;
		public static void glGetShaderiv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetShaderiv5718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetShaderInfoLog5719;
		public static global::java.lang.String glGetShaderInfoLog(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetShaderInfoLog5719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetShaderPrecisionFormat5720;
		public static void glGetShaderPrecisionFormat(int arg0, int arg1, java.nio.IntBuffer arg2, java.nio.IntBuffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetShaderPrecisionFormat5720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetShaderPrecisionFormat5721;
		public static void glGetShaderPrecisionFormat(int arg0, int arg1, int[] arg2, int arg3, int[] arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetShaderPrecisionFormat5721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetShaderSource5722;
		public static void glGetShaderSource(int arg0, int arg1, java.nio.IntBuffer arg2, byte arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetShaderSource5722, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetShaderSource5723;
		public static void glGetShaderSource(int arg0, int arg1, int[] arg2, int arg3, byte[] arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetShaderSource5723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetUniformfv5724;
		public static void glGetUniformfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetUniformfv5724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetUniformfv5725;
		public static void glGetUniformfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetUniformfv5725, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetUniformiv5726;
		public static void glGetUniformiv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetUniformiv5726, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetUniformiv5727;
		public static void glGetUniformiv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetUniformiv5727, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetUniformLocation5728;
		public static int glGetUniformLocation(int arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetUniformLocation5728, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetVertexAttribfv5729;
		public static void glGetVertexAttribfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetVertexAttribfv5729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetVertexAttribfv5730;
		public static void glGetVertexAttribfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetVertexAttribfv5730, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetVertexAttribiv5731;
		public static void glGetVertexAttribiv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetVertexAttribiv5731, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetVertexAttribiv5732;
		public static void glGetVertexAttribiv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glGetVertexAttribiv5732, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glIsFramebuffer5733;
		public static bool glIsFramebuffer(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glIsFramebuffer5733, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glIsProgram5734;
		public static bool glIsProgram(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glIsProgram5734, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glIsRenderbuffer5735;
		public static bool glIsRenderbuffer(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glIsRenderbuffer5735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glIsShader5736;
		public static bool glIsShader(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glIsShader5736, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLinkProgram5737;
		public static void glLinkProgram(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glLinkProgram5737, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glReleaseShaderCompiler5738;
		public static void glReleaseShaderCompiler() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glReleaseShaderCompiler5738);
		}
		internal static global::net.sf.jni4net.jni.MethodId _glRenderbufferStorage5739;
		public static void glRenderbufferStorage(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glRenderbufferStorage5739, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glShaderBinary5740;
		public static void glShaderBinary(int arg0, java.nio.IntBuffer arg1, int arg2, java.nio.Buffer arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glShaderBinary5740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glShaderBinary5741;
		public static void glShaderBinary(int arg0, int[] arg1, int arg2, int arg3, java.nio.Buffer arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glShaderBinary5741, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glShaderSource5742;
		public static void glShaderSource(int arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glShaderSource5742, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glStencilFuncSeparate5743;
		public static void glStencilFuncSeparate(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glStencilFuncSeparate5743, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glStencilMaskSeparate5744;
		public static void glStencilMaskSeparate(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glStencilMaskSeparate5744, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glStencilOpSeparate5745;
		public static void glStencilOpSeparate(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glStencilOpSeparate5745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform1f5746;
		public static void glUniform1f(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform1f5746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform1fv5747;
		public static void glUniform1fv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform1fv5747, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform1fv5748;
		public static void glUniform1fv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform1fv5748, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform1i5749;
		public static void glUniform1i(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform1i5749, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform1iv5750;
		public static void glUniform1iv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform1iv5750, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform1iv5751;
		public static void glUniform1iv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform1iv5751, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform2f5752;
		public static void glUniform2f(int arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform2f5752, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform2fv5753;
		public static void glUniform2fv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform2fv5753, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform2fv5754;
		public static void glUniform2fv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform2fv5754, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform2i5755;
		public static void glUniform2i(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform2i5755, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform2iv5756;
		public static void glUniform2iv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform2iv5756, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform2iv5757;
		public static void glUniform2iv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform2iv5757, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform3f5758;
		public static void glUniform3f(int arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform3f5758, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform3fv5759;
		public static void glUniform3fv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform3fv5759, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform3fv5760;
		public static void glUniform3fv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform3fv5760, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform3i5761;
		public static void glUniform3i(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform3i5761, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform3iv5762;
		public static void glUniform3iv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform3iv5762, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform3iv5763;
		public static void glUniform3iv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform3iv5763, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform4f5764;
		public static void glUniform4f(int arg0, float arg1, float arg2, float arg3, float arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform4f5764, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform4fv5765;
		public static void glUniform4fv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform4fv5765, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform4fv5766;
		public static void glUniform4fv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform4fv5766, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform4i5767;
		public static void glUniform4i(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform4i5767, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform4iv5768;
		public static void glUniform4iv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform4iv5768, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniform4iv5769;
		public static void glUniform4iv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniform4iv5769, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniformMatrix2fv5770;
		public static void glUniformMatrix2fv(int arg0, int arg1, bool arg2, java.nio.FloatBuffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniformMatrix2fv5770, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniformMatrix2fv5771;
		public static void glUniformMatrix2fv(int arg0, int arg1, bool arg2, float[] arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniformMatrix2fv5771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniformMatrix3fv5772;
		public static void glUniformMatrix3fv(int arg0, int arg1, bool arg2, java.nio.FloatBuffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniformMatrix3fv5772, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniformMatrix3fv5773;
		public static void glUniformMatrix3fv(int arg0, int arg1, bool arg2, float[] arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniformMatrix3fv5773, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniformMatrix4fv5774;
		public static void glUniformMatrix4fv(int arg0, int arg1, bool arg2, java.nio.FloatBuffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniformMatrix4fv5774, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUniformMatrix4fv5775;
		public static void glUniformMatrix4fv(int arg0, int arg1, bool arg2, float[] arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUniformMatrix4fv5775, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glUseProgram5776;
		public static void glUseProgram(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glUseProgram5776, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glValidateProgram5777;
		public static void glValidateProgram(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glValidateProgram5777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glVertexAttrib1f5778;
		public static void glVertexAttrib1f(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib1f5778, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glVertexAttrib1fv5779;
		public static void glVertexAttrib1fv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib1fv5779, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glVertexAttrib1fv5780;
		public static void glVertexAttrib1fv(int arg0, float[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib1fv5780, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glVertexAttrib2f5781;
		public static void glVertexAttrib2f(int arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib2f5781, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glVertexAttrib2fv5782;
		public static void glVertexAttrib2fv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib2fv5782, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glVertexAttrib2fv5783;
		public static void glVertexAttrib2fv(int arg0, float[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib2fv5783, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glVertexAttrib3f5784;
		public static void glVertexAttrib3f(int arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib3f5784, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glVertexAttrib3fv5785;
		public static void glVertexAttrib3fv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib3fv5785, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glVertexAttrib3fv5786;
		public static void glVertexAttrib3fv(int arg0, float[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib3fv5786, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glVertexAttrib4f5787;
		public static void glVertexAttrib4f(int arg0, float arg1, float arg2, float arg3, float arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib4f5787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glVertexAttrib4fv5788;
		public static void glVertexAttrib4fv(int arg0, float[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib4fv5788, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glVertexAttrib4fv5789;
		public static void glVertexAttrib4fv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttrib4fv5789, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glVertexAttribPointer5790;
		public static void glVertexAttribPointer(int arg0, int arg1, int arg2, bool arg3, int arg4, java.nio.Buffer arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._glVertexAttribPointer5790, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GLES205791;
		public GLES20()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._GLES205791, this);
		}
		public static int GL_ACTIVE_TEXTURE
		{
			get
			{
				return 34016;
			}
		}
		public static int GL_DEPTH_BUFFER_BIT
		{
			get
			{
				return 256;
			}
		}
		public static int GL_STENCIL_BUFFER_BIT
		{
			get
			{
				return 1024;
			}
		}
		public static int GL_COLOR_BUFFER_BIT
		{
			get
			{
				return 16384;
			}
		}
		public static int GL_FALSE
		{
			get
			{
				return 0;
			}
		}
		public static int GL_TRUE
		{
			get
			{
				return 1;
			}
		}
		public static int GL_POINTS
		{
			get
			{
				return 0;
			}
		}
		public static int GL_LINES
		{
			get
			{
				return 1;
			}
		}
		public static int GL_LINE_LOOP
		{
			get
			{
				return 2;
			}
		}
		public static int GL_LINE_STRIP
		{
			get
			{
				return 3;
			}
		}
		public static int GL_TRIANGLES
		{
			get
			{
				return 4;
			}
		}
		public static int GL_TRIANGLE_STRIP
		{
			get
			{
				return 5;
			}
		}
		public static int GL_TRIANGLE_FAN
		{
			get
			{
				return 6;
			}
		}
		public static int GL_ZERO
		{
			get
			{
				return 0;
			}
		}
		public static int GL_ONE
		{
			get
			{
				return 1;
			}
		}
		public static int GL_SRC_COLOR
		{
			get
			{
				return 768;
			}
		}
		public static int GL_ONE_MINUS_SRC_COLOR
		{
			get
			{
				return 769;
			}
		}
		public static int GL_SRC_ALPHA
		{
			get
			{
				return 770;
			}
		}
		public static int GL_ONE_MINUS_SRC_ALPHA
		{
			get
			{
				return 771;
			}
		}
		public static int GL_DST_ALPHA
		{
			get
			{
				return 772;
			}
		}
		public static int GL_ONE_MINUS_DST_ALPHA
		{
			get
			{
				return 773;
			}
		}
		public static int GL_DST_COLOR
		{
			get
			{
				return 774;
			}
		}
		public static int GL_ONE_MINUS_DST_COLOR
		{
			get
			{
				return 775;
			}
		}
		public static int GL_SRC_ALPHA_SATURATE
		{
			get
			{
				return 776;
			}
		}
		public static int GL_FUNC_ADD
		{
			get
			{
				return 32774;
			}
		}
		public static int GL_BLEND_EQUATION
		{
			get
			{
				return 32777;
			}
		}
		public static int GL_BLEND_EQUATION_RGB
		{
			get
			{
				return 32777;
			}
		}
		public static int GL_BLEND_EQUATION_ALPHA
		{
			get
			{
				return 34877;
			}
		}
		public static int GL_FUNC_SUBTRACT
		{
			get
			{
				return 32778;
			}
		}
		public static int GL_FUNC_REVERSE_SUBTRACT
		{
			get
			{
				return 32779;
			}
		}
		public static int GL_BLEND_DST_RGB
		{
			get
			{
				return 32968;
			}
		}
		public static int GL_BLEND_SRC_RGB
		{
			get
			{
				return 32969;
			}
		}
		public static int GL_BLEND_DST_ALPHA
		{
			get
			{
				return 32970;
			}
		}
		public static int GL_BLEND_SRC_ALPHA
		{
			get
			{
				return 32971;
			}
		}
		public static int GL_CONSTANT_COLOR
		{
			get
			{
				return 32769;
			}
		}
		public static int GL_ONE_MINUS_CONSTANT_COLOR
		{
			get
			{
				return 32770;
			}
		}
		public static int GL_CONSTANT_ALPHA
		{
			get
			{
				return 32771;
			}
		}
		public static int GL_ONE_MINUS_CONSTANT_ALPHA
		{
			get
			{
				return 32772;
			}
		}
		public static int GL_BLEND_COLOR
		{
			get
			{
				return 32773;
			}
		}
		public static int GL_ARRAY_BUFFER
		{
			get
			{
				return 34962;
			}
		}
		public static int GL_ELEMENT_ARRAY_BUFFER
		{
			get
			{
				return 34963;
			}
		}
		public static int GL_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34964;
			}
		}
		public static int GL_ELEMENT_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34965;
			}
		}
		public static int GL_STREAM_DRAW
		{
			get
			{
				return 35040;
			}
		}
		public static int GL_STATIC_DRAW
		{
			get
			{
				return 35044;
			}
		}
		public static int GL_DYNAMIC_DRAW
		{
			get
			{
				return 35048;
			}
		}
		public static int GL_BUFFER_SIZE
		{
			get
			{
				return 34660;
			}
		}
		public static int GL_BUFFER_USAGE
		{
			get
			{
				return 34661;
			}
		}
		public static int GL_CURRENT_VERTEX_ATTRIB
		{
			get
			{
				return 34342;
			}
		}
		public static int GL_FRONT
		{
			get
			{
				return 1028;
			}
		}
		public static int GL_BACK
		{
			get
			{
				return 1029;
			}
		}
		public static int GL_FRONT_AND_BACK
		{
			get
			{
				return 1032;
			}
		}
		public static int GL_TEXTURE_2D
		{
			get
			{
				return 3553;
			}
		}
		public static int GL_CULL_FACE
		{
			get
			{
				return 2884;
			}
		}
		public static int GL_BLEND
		{
			get
			{
				return 3042;
			}
		}
		public static int GL_DITHER
		{
			get
			{
				return 3024;
			}
		}
		public static int GL_STENCIL_TEST
		{
			get
			{
				return 2960;
			}
		}
		public static int GL_DEPTH_TEST
		{
			get
			{
				return 2929;
			}
		}
		public static int GL_SCISSOR_TEST
		{
			get
			{
				return 3089;
			}
		}
		public static int GL_POLYGON_OFFSET_FILL
		{
			get
			{
				return 32823;
			}
		}
		public static int GL_SAMPLE_ALPHA_TO_COVERAGE
		{
			get
			{
				return 32926;
			}
		}
		public static int GL_SAMPLE_COVERAGE
		{
			get
			{
				return 32928;
			}
		}
		public static int GL_NO_ERROR
		{
			get
			{
				return 0;
			}
		}
		public static int GL_INVALID_ENUM
		{
			get
			{
				return 1280;
			}
		}
		public static int GL_INVALID_VALUE
		{
			get
			{
				return 1281;
			}
		}
		public static int GL_INVALID_OPERATION
		{
			get
			{
				return 1282;
			}
		}
		public static int GL_OUT_OF_MEMORY
		{
			get
			{
				return 1285;
			}
		}
		public static int GL_CW
		{
			get
			{
				return 2304;
			}
		}
		public static int GL_CCW
		{
			get
			{
				return 2305;
			}
		}
		public static int GL_LINE_WIDTH
		{
			get
			{
				return 2849;
			}
		}
		public static int GL_ALIASED_POINT_SIZE_RANGE
		{
			get
			{
				return 33901;
			}
		}
		public static int GL_ALIASED_LINE_WIDTH_RANGE
		{
			get
			{
				return 33902;
			}
		}
		public static int GL_CULL_FACE_MODE
		{
			get
			{
				return 2885;
			}
		}
		public static int GL_FRONT_FACE
		{
			get
			{
				return 2886;
			}
		}
		public static int GL_DEPTH_RANGE
		{
			get
			{
				return 2928;
			}
		}
		public static int GL_DEPTH_WRITEMASK
		{
			get
			{
				return 2930;
			}
		}
		public static int GL_DEPTH_CLEAR_VALUE
		{
			get
			{
				return 2931;
			}
		}
		public static int GL_DEPTH_FUNC
		{
			get
			{
				return 2932;
			}
		}
		public static int GL_STENCIL_CLEAR_VALUE
		{
			get
			{
				return 2961;
			}
		}
		public static int GL_STENCIL_FUNC
		{
			get
			{
				return 2962;
			}
		}
		public static int GL_STENCIL_FAIL
		{
			get
			{
				return 2964;
			}
		}
		public static int GL_STENCIL_PASS_DEPTH_FAIL
		{
			get
			{
				return 2965;
			}
		}
		public static int GL_STENCIL_PASS_DEPTH_PASS
		{
			get
			{
				return 2966;
			}
		}
		public static int GL_STENCIL_REF
		{
			get
			{
				return 2967;
			}
		}
		public static int GL_STENCIL_VALUE_MASK
		{
			get
			{
				return 2963;
			}
		}
		public static int GL_STENCIL_WRITEMASK
		{
			get
			{
				return 2968;
			}
		}
		public static int GL_STENCIL_BACK_FUNC
		{
			get
			{
				return 34816;
			}
		}
		public static int GL_STENCIL_BACK_FAIL
		{
			get
			{
				return 34817;
			}
		}
		public static int GL_STENCIL_BACK_PASS_DEPTH_FAIL
		{
			get
			{
				return 34818;
			}
		}
		public static int GL_STENCIL_BACK_PASS_DEPTH_PASS
		{
			get
			{
				return 34819;
			}
		}
		public static int GL_STENCIL_BACK_REF
		{
			get
			{
				return 36003;
			}
		}
		public static int GL_STENCIL_BACK_VALUE_MASK
		{
			get
			{
				return 36004;
			}
		}
		public static int GL_STENCIL_BACK_WRITEMASK
		{
			get
			{
				return 36005;
			}
		}
		public static int GL_VIEWPORT
		{
			get
			{
				return 2978;
			}
		}
		public static int GL_SCISSOR_BOX
		{
			get
			{
				return 3088;
			}
		}
		public static int GL_COLOR_CLEAR_VALUE
		{
			get
			{
				return 3106;
			}
		}
		public static int GL_COLOR_WRITEMASK
		{
			get
			{
				return 3107;
			}
		}
		public static int GL_UNPACK_ALIGNMENT
		{
			get
			{
				return 3317;
			}
		}
		public static int GL_PACK_ALIGNMENT
		{
			get
			{
				return 3333;
			}
		}
		public static int GL_MAX_TEXTURE_SIZE
		{
			get
			{
				return 3379;
			}
		}
		public static int GL_MAX_VIEWPORT_DIMS
		{
			get
			{
				return 3386;
			}
		}
		public static int GL_SUBPIXEL_BITS
		{
			get
			{
				return 3408;
			}
		}
		public static int GL_RED_BITS
		{
			get
			{
				return 3410;
			}
		}
		public static int GL_GREEN_BITS
		{
			get
			{
				return 3411;
			}
		}
		public static int GL_BLUE_BITS
		{
			get
			{
				return 3412;
			}
		}
		public static int GL_ALPHA_BITS
		{
			get
			{
				return 3413;
			}
		}
		public static int GL_DEPTH_BITS
		{
			get
			{
				return 3414;
			}
		}
		public static int GL_STENCIL_BITS
		{
			get
			{
				return 3415;
			}
		}
		public static int GL_POLYGON_OFFSET_UNITS
		{
			get
			{
				return 10752;
			}
		}
		public static int GL_POLYGON_OFFSET_FACTOR
		{
			get
			{
				return 32824;
			}
		}
		public static int GL_TEXTURE_BINDING_2D
		{
			get
			{
				return 32873;
			}
		}
		public static int GL_SAMPLE_BUFFERS
		{
			get
			{
				return 32936;
			}
		}
		public static int GL_SAMPLES
		{
			get
			{
				return 32937;
			}
		}
		public static int GL_SAMPLE_COVERAGE_VALUE
		{
			get
			{
				return 32938;
			}
		}
		public static int GL_SAMPLE_COVERAGE_INVERT
		{
			get
			{
				return 32939;
			}
		}
		public static int GL_NUM_COMPRESSED_TEXTURE_FORMATS
		{
			get
			{
				return 34466;
			}
		}
		public static int GL_COMPRESSED_TEXTURE_FORMATS
		{
			get
			{
				return 34467;
			}
		}
		public static int GL_DONT_CARE
		{
			get
			{
				return 4352;
			}
		}
		public static int GL_FASTEST
		{
			get
			{
				return 4353;
			}
		}
		public static int GL_NICEST
		{
			get
			{
				return 4354;
			}
		}
		public static int GL_GENERATE_MIPMAP_HINT
		{
			get
			{
				return 33170;
			}
		}
		public static int GL_BYTE
		{
			get
			{
				return 5120;
			}
		}
		public static int GL_UNSIGNED_BYTE
		{
			get
			{
				return 5121;
			}
		}
		public static int GL_SHORT
		{
			get
			{
				return 5122;
			}
		}
		public static int GL_UNSIGNED_SHORT
		{
			get
			{
				return 5123;
			}
		}
		public static int GL_INT
		{
			get
			{
				return 5124;
			}
		}
		public static int GL_UNSIGNED_INT
		{
			get
			{
				return 5125;
			}
		}
		public static int GL_FLOAT
		{
			get
			{
				return 5126;
			}
		}
		public static int GL_FIXED
		{
			get
			{
				return 5132;
			}
		}
		public static int GL_DEPTH_COMPONENT
		{
			get
			{
				return 6402;
			}
		}
		public static int GL_ALPHA
		{
			get
			{
				return 6406;
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
		public static int GL_FRAGMENT_SHADER
		{
			get
			{
				return 35632;
			}
		}
		public static int GL_VERTEX_SHADER
		{
			get
			{
				return 35633;
			}
		}
		public static int GL_MAX_VERTEX_ATTRIBS
		{
			get
			{
				return 34921;
			}
		}
		public static int GL_MAX_VERTEX_UNIFORM_VECTORS
		{
			get
			{
				return 36347;
			}
		}
		public static int GL_MAX_VARYING_VECTORS
		{
			get
			{
				return 36348;
			}
		}
		public static int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS
		{
			get
			{
				return 35661;
			}
		}
		public static int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS
		{
			get
			{
				return 35660;
			}
		}
		public static int GL_MAX_TEXTURE_IMAGE_UNITS
		{
			get
			{
				return 34930;
			}
		}
		public static int GL_MAX_FRAGMENT_UNIFORM_VECTORS
		{
			get
			{
				return 36349;
			}
		}
		public static int GL_SHADER_TYPE
		{
			get
			{
				return 35663;
			}
		}
		public static int GL_DELETE_STATUS
		{
			get
			{
				return 35712;
			}
		}
		public static int GL_LINK_STATUS
		{
			get
			{
				return 35714;
			}
		}
		public static int GL_VALIDATE_STATUS
		{
			get
			{
				return 35715;
			}
		}
		public static int GL_ATTACHED_SHADERS
		{
			get
			{
				return 35717;
			}
		}
		public static int GL_ACTIVE_UNIFORMS
		{
			get
			{
				return 35718;
			}
		}
		public static int GL_ACTIVE_UNIFORM_MAX_LENGTH
		{
			get
			{
				return 35719;
			}
		}
		public static int GL_ACTIVE_ATTRIBUTES
		{
			get
			{
				return 35721;
			}
		}
		public static int GL_ACTIVE_ATTRIBUTE_MAX_LENGTH
		{
			get
			{
				return 35722;
			}
		}
		public static int GL_SHADING_LANGUAGE_VERSION
		{
			get
			{
				return 35724;
			}
		}
		public static int GL_CURRENT_PROGRAM
		{
			get
			{
				return 35725;
			}
		}
		public static int GL_NEVER
		{
			get
			{
				return 512;
			}
		}
		public static int GL_LESS
		{
			get
			{
				return 513;
			}
		}
		public static int GL_EQUAL
		{
			get
			{
				return 514;
			}
		}
		public static int GL_LEQUAL
		{
			get
			{
				return 515;
			}
		}
		public static int GL_GREATER
		{
			get
			{
				return 516;
			}
		}
		public static int GL_NOTEQUAL
		{
			get
			{
				return 517;
			}
		}
		public static int GL_GEQUAL
		{
			get
			{
				return 518;
			}
		}
		public static int GL_ALWAYS
		{
			get
			{
				return 519;
			}
		}
		public static int GL_KEEP
		{
			get
			{
				return 7680;
			}
		}
		public static int GL_REPLACE
		{
			get
			{
				return 7681;
			}
		}
		public static int GL_INCR
		{
			get
			{
				return 7682;
			}
		}
		public static int GL_DECR
		{
			get
			{
				return 7683;
			}
		}
		public static int GL_INVERT
		{
			get
			{
				return 5386;
			}
		}
		public static int GL_INCR_WRAP
		{
			get
			{
				return 34055;
			}
		}
		public static int GL_DECR_WRAP
		{
			get
			{
				return 34056;
			}
		}
		public static int GL_VENDOR
		{
			get
			{
				return 7936;
			}
		}
		public static int GL_RENDERER
		{
			get
			{
				return 7937;
			}
		}
		public static int GL_VERSION
		{
			get
			{
				return 7938;
			}
		}
		public static int GL_EXTENSIONS
		{
			get
			{
				return 7939;
			}
		}
		public static int GL_NEAREST
		{
			get
			{
				return 9728;
			}
		}
		public static int GL_LINEAR
		{
			get
			{
				return 9729;
			}
		}
		public static int GL_NEAREST_MIPMAP_NEAREST
		{
			get
			{
				return 9984;
			}
		}
		public static int GL_LINEAR_MIPMAP_NEAREST
		{
			get
			{
				return 9985;
			}
		}
		public static int GL_NEAREST_MIPMAP_LINEAR
		{
			get
			{
				return 9986;
			}
		}
		public static int GL_LINEAR_MIPMAP_LINEAR
		{
			get
			{
				return 9987;
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
		public static int GL_TEXTURE
		{
			get
			{
				return 5890;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP
		{
			get
			{
				return 34067;
			}
		}
		public static int GL_TEXTURE_BINDING_CUBE_MAP
		{
			get
			{
				return 34068;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_POSITIVE_X
		{
			get
			{
				return 34069;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_NEGATIVE_X
		{
			get
			{
				return 34070;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_POSITIVE_Y
		{
			get
			{
				return 34071;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y
		{
			get
			{
				return 34072;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_POSITIVE_Z
		{
			get
			{
				return 34073;
			}
		}
		public static int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z
		{
			get
			{
				return 34074;
			}
		}
		public static int GL_MAX_CUBE_MAP_TEXTURE_SIZE
		{
			get
			{
				return 34076;
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
		public static int GL_REPEAT
		{
			get
			{
				return 10497;
			}
		}
		public static int GL_CLAMP_TO_EDGE
		{
			get
			{
				return 33071;
			}
		}
		public static int GL_MIRRORED_REPEAT
		{
			get
			{
				return 33648;
			}
		}
		public static int GL_FLOAT_VEC2
		{
			get
			{
				return 35664;
			}
		}
		public static int GL_FLOAT_VEC3
		{
			get
			{
				return 35665;
			}
		}
		public static int GL_FLOAT_VEC4
		{
			get
			{
				return 35666;
			}
		}
		public static int GL_INT_VEC2
		{
			get
			{
				return 35667;
			}
		}
		public static int GL_INT_VEC3
		{
			get
			{
				return 35668;
			}
		}
		public static int GL_INT_VEC4
		{
			get
			{
				return 35669;
			}
		}
		public static int GL_BOOL
		{
			get
			{
				return 35670;
			}
		}
		public static int GL_BOOL_VEC2
		{
			get
			{
				return 35671;
			}
		}
		public static int GL_BOOL_VEC3
		{
			get
			{
				return 35672;
			}
		}
		public static int GL_BOOL_VEC4
		{
			get
			{
				return 35673;
			}
		}
		public static int GL_FLOAT_MAT2
		{
			get
			{
				return 35674;
			}
		}
		public static int GL_FLOAT_MAT3
		{
			get
			{
				return 35675;
			}
		}
		public static int GL_FLOAT_MAT4
		{
			get
			{
				return 35676;
			}
		}
		public static int GL_SAMPLER_2D
		{
			get
			{
				return 35678;
			}
		}
		public static int GL_SAMPLER_CUBE
		{
			get
			{
				return 35680;
			}
		}
		public static int GL_VERTEX_ATTRIB_ARRAY_ENABLED
		{
			get
			{
				return 34338;
			}
		}
		public static int GL_VERTEX_ATTRIB_ARRAY_SIZE
		{
			get
			{
				return 34339;
			}
		}
		public static int GL_VERTEX_ATTRIB_ARRAY_STRIDE
		{
			get
			{
				return 34340;
			}
		}
		public static int GL_VERTEX_ATTRIB_ARRAY_TYPE
		{
			get
			{
				return 34341;
			}
		}
		public static int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED
		{
			get
			{
				return 34922;
			}
		}
		public static int GL_VERTEX_ATTRIB_ARRAY_POINTER
		{
			get
			{
				return 34373;
			}
		}
		public static int GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34975;
			}
		}
		public static int GL_IMPLEMENTATION_COLOR_READ_TYPE
		{
			get
			{
				return 35738;
			}
		}
		public static int GL_IMPLEMENTATION_COLOR_READ_FORMAT
		{
			get
			{
				return 35739;
			}
		}
		public static int GL_COMPILE_STATUS
		{
			get
			{
				return 35713;
			}
		}
		public static int GL_INFO_LOG_LENGTH
		{
			get
			{
				return 35716;
			}
		}
		public static int GL_SHADER_SOURCE_LENGTH
		{
			get
			{
				return 35720;
			}
		}
		public static int GL_SHADER_COMPILER
		{
			get
			{
				return 36346;
			}
		}
		public static int GL_SHADER_BINARY_FORMATS
		{
			get
			{
				return 36344;
			}
		}
		public static int GL_NUM_SHADER_BINARY_FORMATS
		{
			get
			{
				return 36345;
			}
		}
		public static int GL_LOW_FLOAT
		{
			get
			{
				return 36336;
			}
		}
		public static int GL_MEDIUM_FLOAT
		{
			get
			{
				return 36337;
			}
		}
		public static int GL_HIGH_FLOAT
		{
			get
			{
				return 36338;
			}
		}
		public static int GL_LOW_INT
		{
			get
			{
				return 36339;
			}
		}
		public static int GL_MEDIUM_INT
		{
			get
			{
				return 36340;
			}
		}
		public static int GL_HIGH_INT
		{
			get
			{
				return 36341;
			}
		}
		public static int GL_FRAMEBUFFER
		{
			get
			{
				return 36160;
			}
		}
		public static int GL_RENDERBUFFER
		{
			get
			{
				return 36161;
			}
		}
		public static int GL_RGBA4
		{
			get
			{
				return 32854;
			}
		}
		public static int GL_RGB5_A1
		{
			get
			{
				return 32855;
			}
		}
		public static int GL_RGB565
		{
			get
			{
				return 36194;
			}
		}
		public static int GL_DEPTH_COMPONENT16
		{
			get
			{
				return 33189;
			}
		}
		public static int GL_STENCIL_INDEX
		{
			get
			{
				return 6401;
			}
		}
		public static int GL_STENCIL_INDEX8
		{
			get
			{
				return 36168;
			}
		}
		public static int GL_RENDERBUFFER_WIDTH
		{
			get
			{
				return 36162;
			}
		}
		public static int GL_RENDERBUFFER_HEIGHT
		{
			get
			{
				return 36163;
			}
		}
		public static int GL_RENDERBUFFER_INTERNAL_FORMAT
		{
			get
			{
				return 36164;
			}
		}
		public static int GL_RENDERBUFFER_RED_SIZE
		{
			get
			{
				return 36176;
			}
		}
		public static int GL_RENDERBUFFER_GREEN_SIZE
		{
			get
			{
				return 36177;
			}
		}
		public static int GL_RENDERBUFFER_BLUE_SIZE
		{
			get
			{
				return 36178;
			}
		}
		public static int GL_RENDERBUFFER_ALPHA_SIZE
		{
			get
			{
				return 36179;
			}
		}
		public static int GL_RENDERBUFFER_DEPTH_SIZE
		{
			get
			{
				return 36180;
			}
		}
		public static int GL_RENDERBUFFER_STENCIL_SIZE
		{
			get
			{
				return 36181;
			}
		}
		public static int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE
		{
			get
			{
				return 36048;
			}
		}
		public static int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME
		{
			get
			{
				return 36049;
			}
		}
		public static int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL
		{
			get
			{
				return 36050;
			}
		}
		public static int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE
		{
			get
			{
				return 36051;
			}
		}
		public static int GL_COLOR_ATTACHMENT0
		{
			get
			{
				return 36064;
			}
		}
		public static int GL_DEPTH_ATTACHMENT
		{
			get
			{
				return 36096;
			}
		}
		public static int GL_STENCIL_ATTACHMENT
		{
			get
			{
				return 36128;
			}
		}
		public static int GL_NONE
		{
			get
			{
				return 0;
			}
		}
		public static int GL_FRAMEBUFFER_COMPLETE
		{
			get
			{
				return 36053;
			}
		}
		public static int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT
		{
			get
			{
				return 36054;
			}
		}
		public static int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT
		{
			get
			{
				return 36055;
			}
		}
		public static int GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS
		{
			get
			{
				return 36057;
			}
		}
		public static int GL_FRAMEBUFFER_UNSUPPORTED
		{
			get
			{
				return 36061;
			}
		}
		public static int GL_FRAMEBUFFER_BINDING
		{
			get
			{
				return 36006;
			}
		}
		public static int GL_RENDERBUFFER_BINDING
		{
			get
			{
				return 36007;
			}
		}
		public static int GL_MAX_RENDERBUFFER_SIZE
		{
			get
			{
				return 34024;
			}
		}
		public static int GL_INVALID_FRAMEBUFFER_OPERATION
		{
			get
			{
				return 1286;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.opengl.GLES20.staticClass = @__class;
			global::android.opengl.GLES20._glActiveTexture5605 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glActiveTexture", "(I)V");
			global::android.opengl.GLES20._glBindTexture5606 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glBindTexture", "(II)V");
			global::android.opengl.GLES20._glBlendFunc5607 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glBlendFunc", "(II)V");
			global::android.opengl.GLES20._glClear5608 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glClear", "(I)V");
			global::android.opengl.GLES20._glClearColor5609 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glClearColor", "(FFFF)V");
			global::android.opengl.GLES20._glClearDepthf5610 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glClearDepthf", "(F)V");
			global::android.opengl.GLES20._glClearStencil5611 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glClearStencil", "(I)V");
			global::android.opengl.GLES20._glColorMask5612 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glColorMask", "(ZZZZ)V");
			global::android.opengl.GLES20._glCompressedTexImage2D5613 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V");
			global::android.opengl.GLES20._glCompressedTexSubImage2D5614 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::android.opengl.GLES20._glCopyTexImage2D5615 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glCopyTexImage2D", "(IIIIIIII)V");
			global::android.opengl.GLES20._glCopyTexSubImage2D5616 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glCopyTexSubImage2D", "(IIIIIIII)V");
			global::android.opengl.GLES20._glCullFace5617 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glCullFace", "(I)V");
			global::android.opengl.GLES20._glDeleteTextures5618 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDeleteTextures", "(I[II)V");
			global::android.opengl.GLES20._glDeleteTextures5619 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDeleteTextures", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glDepthFunc5620 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDepthFunc", "(I)V");
			global::android.opengl.GLES20._glDepthMask5621 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDepthMask", "(Z)V");
			global::android.opengl.GLES20._glDepthRangef5622 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDepthRangef", "(FF)V");
			global::android.opengl.GLES20._glDisable5623 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDisable", "(I)V");
			global::android.opengl.GLES20._glDrawArrays5624 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDrawArrays", "(III)V");
			global::android.opengl.GLES20._glDrawElements5625 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDrawElements", "(IIILjava/nio/Buffer;)V");
			global::android.opengl.GLES20._glEnable5626 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glEnable", "(I)V");
			global::android.opengl.GLES20._glFinish5627 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glFinish", "()V");
			global::android.opengl.GLES20._glFlush5628 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glFlush", "()V");
			global::android.opengl.GLES20._glFrontFace5629 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glFrontFace", "(I)V");
			global::android.opengl.GLES20._glGenTextures5630 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGenTextures", "(I[II)V");
			global::android.opengl.GLES20._glGenTextures5631 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGenTextures", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glGetError5632 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetError", "()I");
			global::android.opengl.GLES20._glGetIntegerv5633 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glGetIntegerv5634 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetIntegerv", "(I[II)V");
			global::android.opengl.GLES20._glGetString5635 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetString", "(I)Ljava/lang/String;");
			global::android.opengl.GLES20._glHint5636 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glHint", "(II)V");
			global::android.opengl.GLES20._glLineWidth5637 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glLineWidth", "(F)V");
			global::android.opengl.GLES20._glPixelStorei5638 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glPixelStorei", "(II)V");
			global::android.opengl.GLES20._glPolygonOffset5639 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glPolygonOffset", "(FF)V");
			global::android.opengl.GLES20._glReadPixels5640 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glReadPixels", "(IIIIIILjava/nio/Buffer;)V");
			global::android.opengl.GLES20._glSampleCoverage5641 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glSampleCoverage", "(FZ)V");
			global::android.opengl.GLES20._glScissor5642 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glScissor", "(IIII)V");
			global::android.opengl.GLES20._glStencilFunc5643 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glStencilFunc", "(III)V");
			global::android.opengl.GLES20._glStencilMask5644 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glStencilMask", "(I)V");
			global::android.opengl.GLES20._glStencilOp5645 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glStencilOp", "(III)V");
			global::android.opengl.GLES20._glTexImage2D5646 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::android.opengl.GLES20._glTexParameterf5647 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glTexParameterf", "(IIF)V");
			global::android.opengl.GLES20._glTexSubImage2D5648 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::android.opengl.GLES20._glViewport5649 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glViewport", "(IIII)V");
			global::android.opengl.GLES20._glBindBuffer5650 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glBindBuffer", "(II)V");
			global::android.opengl.GLES20._glBufferData5651 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glBufferData", "(IILjava/nio/Buffer;I)V");
			global::android.opengl.GLES20._glBufferSubData5652 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glBufferSubData", "(IIILjava/nio/Buffer;)V");
			global::android.opengl.GLES20._glDeleteBuffers5653 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDeleteBuffers", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glDeleteBuffers5654 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDeleteBuffers", "(I[II)V");
			global::android.opengl.GLES20._glGenBuffers5655 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGenBuffers", "(I[II)V");
			global::android.opengl.GLES20._glGenBuffers5656 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGenBuffers", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glGetBooleanv5657 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetBooleanv", "(I[ZI)V");
			global::android.opengl.GLES20._glGetBooleanv5658 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetBooleanv", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glGetBufferParameteriv5659 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetBufferParameteriv", "(II[II)V");
			global::android.opengl.GLES20._glGetBufferParameteriv5660 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetBufferParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glGetFloatv5661 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetFloatv", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glGetFloatv5662 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetFloatv", "(I[FI)V");
			global::android.opengl.GLES20._glGetTexParameterfv5663 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetTexParameterfv", "(II[FI)V");
			global::android.opengl.GLES20._glGetTexParameterfv5664 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glGetTexParameteriv5665 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glGetTexParameteriv5666 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetTexParameteriv", "(II[II)V");
			global::android.opengl.GLES20._glIsBuffer5667 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glIsBuffer", "(I)Z");
			global::android.opengl.GLES20._glIsEnabled5668 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glIsEnabled", "(I)Z");
			global::android.opengl.GLES20._glIsTexture5669 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glIsTexture", "(I)Z");
			global::android.opengl.GLES20._glTexParameterfv5670 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glTexParameterfv", "(II[FI)V");
			global::android.opengl.GLES20._glTexParameterfv5671 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glTexParameteri5672 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glTexParameteri", "(III)V");
			global::android.opengl.GLES20._glTexParameteriv5673 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glTexParameteriv5674 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glTexParameteriv", "(II[II)V");
			global::android.opengl.GLES20._glAttachShader5675 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glAttachShader", "(II)V");
			global::android.opengl.GLES20._glBindAttribLocation5676 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glBindAttribLocation", "(IILjava/lang/String;)V");
			global::android.opengl.GLES20._glBindFramebuffer5677 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glBindFramebuffer", "(II)V");
			global::android.opengl.GLES20._glBindRenderbuffer5678 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glBindRenderbuffer", "(II)V");
			global::android.opengl.GLES20._glBlendColor5679 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glBlendColor", "(FFFF)V");
			global::android.opengl.GLES20._glBlendEquation5680 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glBlendEquation", "(I)V");
			global::android.opengl.GLES20._glBlendEquationSeparate5681 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glBlendEquationSeparate", "(II)V");
			global::android.opengl.GLES20._glBlendFuncSeparate5682 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glBlendFuncSeparate", "(IIII)V");
			global::android.opengl.GLES20._glCheckFramebufferStatus5683 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glCheckFramebufferStatus", "(I)I");
			global::android.opengl.GLES20._glCompileShader5684 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glCompileShader", "(I)V");
			global::android.opengl.GLES20._glCreateProgram5685 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glCreateProgram", "()I");
			global::android.opengl.GLES20._glCreateShader5686 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glCreateShader", "(I)I");
			global::android.opengl.GLES20._glDeleteFramebuffers5687 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDeleteFramebuffers", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glDeleteFramebuffers5688 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDeleteFramebuffers", "(I[II)V");
			global::android.opengl.GLES20._glDeleteProgram5689 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDeleteProgram", "(I)V");
			global::android.opengl.GLES20._glDeleteRenderbuffers5690 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDeleteRenderbuffers", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glDeleteRenderbuffers5691 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDeleteRenderbuffers", "(I[II)V");
			global::android.opengl.GLES20._glDeleteShader5692 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDeleteShader", "(I)V");
			global::android.opengl.GLES20._glDetachShader5693 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDetachShader", "(II)V");
			global::android.opengl.GLES20._glDisableVertexAttribArray5694 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glDisableVertexAttribArray", "(I)V");
			global::android.opengl.GLES20._glEnableVertexAttribArray5695 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glEnableVertexAttribArray", "(I)V");
			global::android.opengl.GLES20._glFramebufferRenderbuffer5696 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glFramebufferRenderbuffer", "(IIII)V");
			global::android.opengl.GLES20._glFramebufferTexture2D5697 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glFramebufferTexture2D", "(IIIII)V");
			global::android.opengl.GLES20._glGenerateMipmap5698 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGenerateMipmap", "(I)V");
			global::android.opengl.GLES20._glGenFramebuffers5699 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGenFramebuffers", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glGenFramebuffers5700 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGenFramebuffers", "(I[II)V");
			global::android.opengl.GLES20._glGenRenderbuffers5701 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGenRenderbuffers", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glGenRenderbuffers5702 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGenRenderbuffers", "(I[II)V");
			global::android.opengl.GLES20._glGetActiveAttrib5703 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetActiveAttrib", "(III[II[II[II[BI)V");
			global::android.opengl.GLES20._glGetActiveAttrib5704 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetActiveAttrib", "(IIILjava/nio/IntBuffer;Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;B)V");
			global::android.opengl.GLES20._glGetActiveUniform5705 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetActiveUniform", "(IIILjava/nio/IntBuffer;Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;B)V");
			global::android.opengl.GLES20._glGetActiveUniform5706 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetActiveUniform", "(III[II[II[II[BI)V");
			global::android.opengl.GLES20._glGetAttachedShaders5707 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetAttachedShaders", "(II[II[II)V");
			global::android.opengl.GLES20._glGetAttachedShaders5708 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetAttachedShaders", "(IILjava/nio/IntBuffer;Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glGetAttribLocation5709 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetAttribLocation", "(ILjava/lang/String;)I");
			global::android.opengl.GLES20._glGetFramebufferAttachmentParameteriv5710 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetFramebufferAttachmentParameteriv", "(III[II)V");
			global::android.opengl.GLES20._glGetFramebufferAttachmentParameteriv5711 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetFramebufferAttachmentParameteriv", "(IIILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glGetProgramiv5712 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetProgramiv", "(II[II)V");
			global::android.opengl.GLES20._glGetProgramiv5713 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetProgramiv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glGetProgramInfoLog5714 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetProgramInfoLog", "(I)Ljava/lang/String;");
			global::android.opengl.GLES20._glGetRenderbufferParameteriv5715 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetRenderbufferParameteriv", "(II[II)V");
			global::android.opengl.GLES20._glGetRenderbufferParameteriv5716 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetRenderbufferParameteriv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glGetShaderiv5717 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetShaderiv", "(II[II)V");
			global::android.opengl.GLES20._glGetShaderiv5718 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetShaderiv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glGetShaderInfoLog5719 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetShaderInfoLog", "(I)Ljava/lang/String;");
			global::android.opengl.GLES20._glGetShaderPrecisionFormat5720 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetShaderPrecisionFormat", "(IILjava/nio/IntBuffer;Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glGetShaderPrecisionFormat5721 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetShaderPrecisionFormat", "(II[II[II)V");
			global::android.opengl.GLES20._glGetShaderSource5722 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetShaderSource", "(IILjava/nio/IntBuffer;B)V");
			global::android.opengl.GLES20._glGetShaderSource5723 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetShaderSource", "(II[II[BI)V");
			global::android.opengl.GLES20._glGetUniformfv5724 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetUniformfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glGetUniformfv5725 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetUniformfv", "(II[FI)V");
			global::android.opengl.GLES20._glGetUniformiv5726 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetUniformiv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glGetUniformiv5727 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetUniformiv", "(II[II)V");
			global::android.opengl.GLES20._glGetUniformLocation5728 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetUniformLocation", "(ILjava/lang/String;)I");
			global::android.opengl.GLES20._glGetVertexAttribfv5729 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetVertexAttribfv", "(II[FI)V");
			global::android.opengl.GLES20._glGetVertexAttribfv5730 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetVertexAttribfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glGetVertexAttribiv5731 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetVertexAttribiv", "(II[II)V");
			global::android.opengl.GLES20._glGetVertexAttribiv5732 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glGetVertexAttribiv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glIsFramebuffer5733 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glIsFramebuffer", "(I)Z");
			global::android.opengl.GLES20._glIsProgram5734 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glIsProgram", "(I)Z");
			global::android.opengl.GLES20._glIsRenderbuffer5735 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glIsRenderbuffer", "(I)Z");
			global::android.opengl.GLES20._glIsShader5736 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glIsShader", "(I)Z");
			global::android.opengl.GLES20._glLinkProgram5737 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glLinkProgram", "(I)V");
			global::android.opengl.GLES20._glReleaseShaderCompiler5738 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glReleaseShaderCompiler", "()V");
			global::android.opengl.GLES20._glRenderbufferStorage5739 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glRenderbufferStorage", "(IIII)V");
			global::android.opengl.GLES20._glShaderBinary5740 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glShaderBinary", "(ILjava/nio/IntBuffer;ILjava/nio/Buffer;I)V");
			global::android.opengl.GLES20._glShaderBinary5741 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glShaderBinary", "(I[IIILjava/nio/Buffer;I)V");
			global::android.opengl.GLES20._glShaderSource5742 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glShaderSource", "(ILjava/lang/String;)V");
			global::android.opengl.GLES20._glStencilFuncSeparate5743 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glStencilFuncSeparate", "(IIII)V");
			global::android.opengl.GLES20._glStencilMaskSeparate5744 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glStencilMaskSeparate", "(II)V");
			global::android.opengl.GLES20._glStencilOpSeparate5745 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glStencilOpSeparate", "(IIII)V");
			global::android.opengl.GLES20._glUniform1f5746 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform1f", "(IF)V");
			global::android.opengl.GLES20._glUniform1fv5747 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform1fv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glUniform1fv5748 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform1fv", "(II[FI)V");
			global::android.opengl.GLES20._glUniform1i5749 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform1i", "(II)V");
			global::android.opengl.GLES20._glUniform1iv5750 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform1iv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glUniform1iv5751 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform1iv", "(II[II)V");
			global::android.opengl.GLES20._glUniform2f5752 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform2f", "(IFF)V");
			global::android.opengl.GLES20._glUniform2fv5753 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform2fv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glUniform2fv5754 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform2fv", "(II[FI)V");
			global::android.opengl.GLES20._glUniform2i5755 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform2i", "(III)V");
			global::android.opengl.GLES20._glUniform2iv5756 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform2iv", "(II[II)V");
			global::android.opengl.GLES20._glUniform2iv5757 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform2iv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glUniform3f5758 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform3f", "(IFFF)V");
			global::android.opengl.GLES20._glUniform3fv5759 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform3fv", "(II[FI)V");
			global::android.opengl.GLES20._glUniform3fv5760 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform3fv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glUniform3i5761 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform3i", "(IIII)V");
			global::android.opengl.GLES20._glUniform3iv5762 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform3iv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glUniform3iv5763 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform3iv", "(II[II)V");
			global::android.opengl.GLES20._glUniform4f5764 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform4f", "(IFFFF)V");
			global::android.opengl.GLES20._glUniform4fv5765 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform4fv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glUniform4fv5766 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform4fv", "(II[FI)V");
			global::android.opengl.GLES20._glUniform4i5767 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform4i", "(IIIII)V");
			global::android.opengl.GLES20._glUniform4iv5768 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform4iv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES20._glUniform4iv5769 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniform4iv", "(II[II)V");
			global::android.opengl.GLES20._glUniformMatrix2fv5770 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniformMatrix2fv", "(IIZLjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glUniformMatrix2fv5771 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniformMatrix2fv", "(IIZ[FI)V");
			global::android.opengl.GLES20._glUniformMatrix3fv5772 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniformMatrix3fv", "(IIZLjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glUniformMatrix3fv5773 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniformMatrix3fv", "(IIZ[FI)V");
			global::android.opengl.GLES20._glUniformMatrix4fv5774 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniformMatrix4fv", "(IIZLjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glUniformMatrix4fv5775 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUniformMatrix4fv", "(IIZ[FI)V");
			global::android.opengl.GLES20._glUseProgram5776 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glUseProgram", "(I)V");
			global::android.opengl.GLES20._glValidateProgram5777 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glValidateProgram", "(I)V");
			global::android.opengl.GLES20._glVertexAttrib1f5778 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glVertexAttrib1f", "(IF)V");
			global::android.opengl.GLES20._glVertexAttrib1fv5779 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glVertexAttrib1fv", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glVertexAttrib1fv5780 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glVertexAttrib1fv", "(I[FI)V");
			global::android.opengl.GLES20._glVertexAttrib2f5781 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glVertexAttrib2f", "(IFF)V");
			global::android.opengl.GLES20._glVertexAttrib2fv5782 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glVertexAttrib2fv", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glVertexAttrib2fv5783 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glVertexAttrib2fv", "(I[FI)V");
			global::android.opengl.GLES20._glVertexAttrib3f5784 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glVertexAttrib3f", "(IFFF)V");
			global::android.opengl.GLES20._glVertexAttrib3fv5785 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glVertexAttrib3fv", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glVertexAttrib3fv5786 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glVertexAttrib3fv", "(I[FI)V");
			global::android.opengl.GLES20._glVertexAttrib4f5787 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glVertexAttrib4f", "(IFFFF)V");
			global::android.opengl.GLES20._glVertexAttrib4fv5788 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glVertexAttrib4fv", "(I[FI)V");
			global::android.opengl.GLES20._glVertexAttrib4fv5789 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glVertexAttrib4fv", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES20._glVertexAttribPointer5790 = @__env.GetStaticMethodID(global::android.opengl.GLES20.staticClass, "glVertexAttribPointer", "(IIIZILjava/nio/Buffer;)V");
			global::android.opengl.GLES20._GLES205791 = @__env.GetMethodID(global::android.opengl.GLES20.staticClass, "<init>", "()V");
		}
	}
}
