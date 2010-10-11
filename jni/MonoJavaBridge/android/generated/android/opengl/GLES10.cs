namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLES10 : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GLES10()
		{
			InitJNI();
		}
		protected GLES10(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _glActiveTexture5551;
		public static void glActiveTexture(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glActiveTexture5551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFunc5552;
		public static void glAlphaFunc(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glAlphaFunc5552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFuncx5553;
		public static void glAlphaFuncx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glAlphaFuncx5553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBindTexture5554;
		public static void glBindTexture(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glBindTexture5554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendFunc5555;
		public static void glBlendFunc(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glBlendFunc5555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClear5556;
		public static void glClear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glClear5556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColor5557;
		public static void glClearColor(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glClearColor5557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColorx5558;
		public static void glClearColorx(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glClearColorx5558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthf5559;
		public static void glClearDepthf(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glClearDepthf5559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthx5560;
		public static void glClearDepthx(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glClearDepthx5560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearStencil5561;
		public static void glClearStencil(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glClearStencil5561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClientActiveTexture5562;
		public static void glClientActiveTexture(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glClientActiveTexture5562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4f5563;
		public static void glColor4f(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glColor4f5563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4x5564;
		public static void glColor4x(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glColor4x5564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColorMask5565;
		public static void glColorMask(bool arg0, bool arg1, bool arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glColorMask5565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColorPointer5566;
		public static void glColorPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glColorPointer5566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexImage2D5567;
		public static void glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glCompressedTexImage2D5567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexSubImage2D5568;
		public static void glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glCompressedTexSubImage2D5568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexImage2D5569;
		public static void glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glCopyTexImage2D5569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexSubImage2D5570;
		public static void glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glCopyTexSubImage2D5570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCullFace5571;
		public static void glCullFace(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glCullFace5571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures5572;
		public static void glDeleteTextures(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDeleteTextures5572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures5573;
		public static void glDeleteTextures(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDeleteTextures5573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthFunc5574;
		public static void glDepthFunc(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDepthFunc5574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthMask5575;
		public static void glDepthMask(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDepthMask5575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangef5576;
		public static void glDepthRangef(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDepthRangef5576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangex5577;
		public static void glDepthRangex(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDepthRangex5577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDisable5578;
		public static void glDisable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDisable5578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDisableClientState5579;
		public static void glDisableClientState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDisableClientState5579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawArrays5580;
		public static void glDrawArrays(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDrawArrays5580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawElements5581;
		public static void glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDrawElements5581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glEnable5582;
		public static void glEnable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glEnable5582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glEnableClientState5583;
		public static void glEnableClientState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glEnableClientState5583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFinish5584;
		public static void glFinish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFinish5584);
		}
		internal static global::MonoJavaBridge.MethodId _glFlush5585;
		public static void glFlush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFlush5585);
		}
		internal static global::MonoJavaBridge.MethodId _glFogf5586;
		public static void glFogf(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFogf5586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogfv5587;
		public static void glFogfv(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFogfv5587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogfv5588;
		public static void glFogfv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFogfv5588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogx5589;
		public static void glFogx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFogx5589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxv5590;
		public static void glFogxv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFogxv5590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxv5591;
		public static void glFogxv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFogxv5591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFrontFace5592;
		public static void glFrontFace(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFrontFace5592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumf5593;
		public static void glFrustumf(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFrustumf5593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumx5594;
		public static void glFrustumx(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFrustumx5594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures5595;
		public static void glGenTextures(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glGenTextures5595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures5596;
		public static void glGenTextures(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glGenTextures5596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetError5597;
		public static int glGetError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glGetError5597);
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv5598;
		public static void glGetIntegerv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glGetIntegerv5598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv5599;
		public static void glGetIntegerv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glGetIntegerv5599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetString5600;
		public static global::java.lang.String glGetString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glGetString5600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _glHint5601;
		public static void glHint(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glHint5601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelf5602;
		public static void glLightModelf(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightModelf5602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelfv5603;
		public static void glLightModelfv(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightModelfv5603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelfv5604;
		public static void glLightModelfv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightModelfv5604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelx5605;
		public static void glLightModelx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightModelx5605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxv5606;
		public static void glLightModelxv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightModelxv5606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxv5607;
		public static void glLightModelxv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightModelxv5607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightf5608;
		public static void glLightf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightf5608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightfv5609;
		public static void glLightfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightfv5609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightfv5610;
		public static void glLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightfv5610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightx5611;
		public static void glLightx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightx5611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxv5612;
		public static void glLightxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightxv5612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxv5613;
		public static void glLightxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightxv5613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidth5614;
		public static void glLineWidth(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLineWidth5614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidthx5615;
		public static void glLineWidthx(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLineWidthx5615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadIdentity5616;
		public static void glLoadIdentity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLoadIdentity5616);
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixf5617;
		public static void glLoadMatrixf(float[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLoadMatrixf5617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixf5618;
		public static void glLoadMatrixf(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLoadMatrixf5618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixx5619;
		public static void glLoadMatrixx(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLoadMatrixx5619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixx5620;
		public static void glLoadMatrixx(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLoadMatrixx5620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLogicOp5621;
		public static void glLogicOp(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLogicOp5621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialf5622;
		public static void glMaterialf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMaterialf5622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialfv5623;
		public static void glMaterialfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMaterialfv5623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialfv5624;
		public static void glMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMaterialfv5624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialx5625;
		public static void glMaterialx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMaterialx5625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxv5626;
		public static void glMaterialxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMaterialxv5626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxv5627;
		public static void glMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMaterialxv5627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMatrixMode5628;
		public static void glMatrixMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMatrixMode5628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixf5629;
		public static void glMultMatrixf(float[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMultMatrixf5629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixf5630;
		public static void glMultMatrixf(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMultMatrixf5630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixx5631;
		public static void glMultMatrixx(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMultMatrixx5631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixx5632;
		public static void glMultMatrixx(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMultMatrixx5632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4f5633;
		public static void glMultiTexCoord4f(int arg0, float arg1, float arg2, float arg3, float arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMultiTexCoord4f5633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4x5634;
		public static void glMultiTexCoord4x(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMultiTexCoord4x5634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3f5635;
		public static void glNormal3f(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glNormal3f5635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3x5636;
		public static void glNormal3x(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glNormal3x5636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glNormalPointer5637;
		public static void glNormalPointer(int arg0, int arg1, java.nio.Buffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glNormalPointer5637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthof5638;
		public static void glOrthof(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glOrthof5638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthox5639;
		public static void glOrthox(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glOrthox5639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glPixelStorei5640;
		public static void glPixelStorei(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glPixelStorei5640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSize5641;
		public static void glPointSize(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glPointSize5641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSizex5642;
		public static void glPointSizex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glPointSizex5642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffset5643;
		public static void glPolygonOffset(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glPolygonOffset5643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffsetx5644;
		public static void glPolygonOffsetx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glPolygonOffsetx5644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPopMatrix5645;
		public static void glPopMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glPopMatrix5645);
		}
		internal static global::MonoJavaBridge.MethodId _glPushMatrix5646;
		public static void glPushMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glPushMatrix5646);
		}
		internal static global::MonoJavaBridge.MethodId _glReadPixels5647;
		public static void glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glReadPixels5647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatef5648;
		public static void glRotatef(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glRotatef5648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatex5649;
		public static void glRotatex(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glRotatex5649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoverage5650;
		public static void glSampleCoverage(float arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glSampleCoverage5650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoveragex5651;
		public static void glSampleCoveragex(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glSampleCoveragex5651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glScalef5652;
		public static void glScalef(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glScalef5652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glScalex5653;
		public static void glScalex(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glScalex5653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glScissor5654;
		public static void glScissor(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glScissor5654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glShadeModel5655;
		public static void glShadeModel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glShadeModel5655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilFunc5656;
		public static void glStencilFunc(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glStencilFunc5656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilMask5657;
		public static void glStencilMask(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glStencilMask5657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilOp5658;
		public static void glStencilOp(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glStencilOp5658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexCoordPointer5659;
		public static void glTexCoordPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexCoordPointer5659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvf5660;
		public static void glTexEnvf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexEnvf5660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv5661;
		public static void glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexEnvfv5661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv5662;
		public static void glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexEnvfv5662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvx5663;
		public static void glTexEnvx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexEnvx5663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv5664;
		public static void glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexEnvxv5664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv5665;
		public static void glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexEnvxv5665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexImage2D5666;
		public static void glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexImage2D5666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterf5667;
		public static void glTexParameterf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexParameterf5667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterx5668;
		public static void glTexParameterx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexParameterx5668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexSubImage2D5669;
		public static void glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexSubImage2D5669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatef5670;
		public static void glTranslatef(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTranslatef5670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatex5671;
		public static void glTranslatex(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTranslatex5671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexPointer5672;
		public static void glVertexPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glVertexPointer5672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glViewport5673;
		public static void glViewport(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glViewport5673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _GLES105674;
		public GLES10()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._GLES105674);
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLES10.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLES10"));
			global::android.opengl.GLES10._glActiveTexture5551 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glActiveTexture", "(I)V");
			global::android.opengl.GLES10._glAlphaFunc5552 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glAlphaFunc", "(IF)V");
			global::android.opengl.GLES10._glAlphaFuncx5553 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glAlphaFuncx", "(II)V");
			global::android.opengl.GLES10._glBindTexture5554 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glBindTexture", "(II)V");
			global::android.opengl.GLES10._glBlendFunc5555 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glBlendFunc", "(II)V");
			global::android.opengl.GLES10._glClear5556 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClear", "(I)V");
			global::android.opengl.GLES10._glClearColor5557 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClearColor", "(FFFF)V");
			global::android.opengl.GLES10._glClearColorx5558 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClearColorx", "(IIII)V");
			global::android.opengl.GLES10._glClearDepthf5559 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClearDepthf", "(F)V");
			global::android.opengl.GLES10._glClearDepthx5560 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClearDepthx", "(I)V");
			global::android.opengl.GLES10._glClearStencil5561 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClearStencil", "(I)V");
			global::android.opengl.GLES10._glClientActiveTexture5562 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClientActiveTexture", "(I)V");
			global::android.opengl.GLES10._glColor4f5563 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glColor4f", "(FFFF)V");
			global::android.opengl.GLES10._glColor4x5564 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glColor4x", "(IIII)V");
			global::android.opengl.GLES10._glColorMask5565 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glColorMask", "(ZZZZ)V");
			global::android.opengl.GLES10._glColorPointer5566 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glColorPointer", "(IIILjava/nio/Buffer;)V");
			global::android.opengl.GLES10._glCompressedTexImage2D5567 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V");
			global::android.opengl.GLES10._glCompressedTexSubImage2D5568 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::android.opengl.GLES10._glCopyTexImage2D5569 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glCopyTexImage2D", "(IIIIIIII)V");
			global::android.opengl.GLES10._glCopyTexSubImage2D5570 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glCopyTexSubImage2D", "(IIIIIIII)V");
			global::android.opengl.GLES10._glCullFace5571 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glCullFace", "(I)V");
			global::android.opengl.GLES10._glDeleteTextures5572 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDeleteTextures", "(I[II)V");
			global::android.opengl.GLES10._glDeleteTextures5573 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDeleteTextures", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES10._glDepthFunc5574 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDepthFunc", "(I)V");
			global::android.opengl.GLES10._glDepthMask5575 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDepthMask", "(Z)V");
			global::android.opengl.GLES10._glDepthRangef5576 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDepthRangef", "(FF)V");
			global::android.opengl.GLES10._glDepthRangex5577 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDepthRangex", "(II)V");
			global::android.opengl.GLES10._glDisable5578 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDisable", "(I)V");
			global::android.opengl.GLES10._glDisableClientState5579 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDisableClientState", "(I)V");
			global::android.opengl.GLES10._glDrawArrays5580 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDrawArrays", "(III)V");
			global::android.opengl.GLES10._glDrawElements5581 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDrawElements", "(IIILjava/nio/Buffer;)V");
			global::android.opengl.GLES10._glEnable5582 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glEnable", "(I)V");
			global::android.opengl.GLES10._glEnableClientState5583 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glEnableClientState", "(I)V");
			global::android.opengl.GLES10._glFinish5584 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFinish", "()V");
			global::android.opengl.GLES10._glFlush5585 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFlush", "()V");
			global::android.opengl.GLES10._glFogf5586 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogf", "(IF)V");
			global::android.opengl.GLES10._glFogfv5587 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogfv", "(I[FI)V");
			global::android.opengl.GLES10._glFogfv5588 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogfv", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES10._glFogx5589 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogx", "(II)V");
			global::android.opengl.GLES10._glFogxv5590 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogxv", "(I[II)V");
			global::android.opengl.GLES10._glFogxv5591 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogxv", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES10._glFrontFace5592 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFrontFace", "(I)V");
			global::android.opengl.GLES10._glFrustumf5593 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFrustumf", "(FFFFFF)V");
			global::android.opengl.GLES10._glFrustumx5594 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFrustumx", "(IIIIII)V");
			global::android.opengl.GLES10._glGenTextures5595 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGenTextures", "(I[II)V");
			global::android.opengl.GLES10._glGenTextures5596 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGenTextures", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES10._glGetError5597 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGetError", "()I");
			global::android.opengl.GLES10._glGetIntegerv5598 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGetIntegerv", "(I[II)V");
			global::android.opengl.GLES10._glGetIntegerv5599 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES10._glGetString5600 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGetString", "(I)Ljava/lang/String;");
			global::android.opengl.GLES10._glHint5601 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glHint", "(II)V");
			global::android.opengl.GLES10._glLightModelf5602 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelf", "(IF)V");
			global::android.opengl.GLES10._glLightModelfv5603 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelfv", "(I[FI)V");
			global::android.opengl.GLES10._glLightModelfv5604 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelfv", "(ILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES10._glLightModelx5605 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelx", "(II)V");
			global::android.opengl.GLES10._glLightModelxv5606 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelxv", "(I[II)V");
			global::android.opengl.GLES10._glLightModelxv5607 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelxv", "(ILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES10._glLightf5608 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightf", "(IIF)V");
			global::android.opengl.GLES10._glLightfv5609 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightfv", "(II[FI)V");
			global::android.opengl.GLES10._glLightfv5610 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES10._glLightx5611 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightx", "(III)V");
			global::android.opengl.GLES10._glLightxv5612 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightxv", "(II[II)V");
			global::android.opengl.GLES10._glLightxv5613 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES10._glLineWidth5614 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLineWidth", "(F)V");
			global::android.opengl.GLES10._glLineWidthx5615 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLineWidthx", "(I)V");
			global::android.opengl.GLES10._glLoadIdentity5616 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLoadIdentity", "()V");
			global::android.opengl.GLES10._glLoadMatrixf5617 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLoadMatrixf", "([FI)V");
			global::android.opengl.GLES10._glLoadMatrixf5618 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V");
			global::android.opengl.GLES10._glLoadMatrixx5619 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLoadMatrixx", "([II)V");
			global::android.opengl.GLES10._glLoadMatrixx5620 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLoadMatrixx", "(Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES10._glLogicOp5621 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLogicOp", "(I)V");
			global::android.opengl.GLES10._glMaterialf5622 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialf", "(IIF)V");
			global::android.opengl.GLES10._glMaterialfv5623 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialfv", "(II[FI)V");
			global::android.opengl.GLES10._glMaterialfv5624 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES10._glMaterialx5625 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialx", "(III)V");
			global::android.opengl.GLES10._glMaterialxv5626 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialxv", "(II[II)V");
			global::android.opengl.GLES10._glMaterialxv5627 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES10._glMatrixMode5628 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMatrixMode", "(I)V");
			global::android.opengl.GLES10._glMultMatrixf5629 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultMatrixf", "([FI)V");
			global::android.opengl.GLES10._glMultMatrixf5630 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultMatrixf", "(Ljava/nio/FloatBuffer;)V");
			global::android.opengl.GLES10._glMultMatrixx5631 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultMatrixx", "([II)V");
			global::android.opengl.GLES10._glMultMatrixx5632 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultMatrixx", "(Ljava/nio/IntBuffer;)V");
			global::android.opengl.GLES10._glMultiTexCoord4f5633 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultiTexCoord4f", "(IFFFF)V");
			global::android.opengl.GLES10._glMultiTexCoord4x5634 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultiTexCoord4x", "(IIIII)V");
			global::android.opengl.GLES10._glNormal3f5635 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glNormal3f", "(FFF)V");
			global::android.opengl.GLES10._glNormal3x5636 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glNormal3x", "(III)V");
			global::android.opengl.GLES10._glNormalPointer5637 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glNormalPointer", "(IILjava/nio/Buffer;)V");
			global::android.opengl.GLES10._glOrthof5638 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glOrthof", "(FFFFFF)V");
			global::android.opengl.GLES10._glOrthox5639 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glOrthox", "(IIIIII)V");
			global::android.opengl.GLES10._glPixelStorei5640 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPixelStorei", "(II)V");
			global::android.opengl.GLES10._glPointSize5641 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPointSize", "(F)V");
			global::android.opengl.GLES10._glPointSizex5642 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPointSizex", "(I)V");
			global::android.opengl.GLES10._glPolygonOffset5643 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPolygonOffset", "(FF)V");
			global::android.opengl.GLES10._glPolygonOffsetx5644 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPolygonOffsetx", "(II)V");
			global::android.opengl.GLES10._glPopMatrix5645 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPopMatrix", "()V");
			global::android.opengl.GLES10._glPushMatrix5646 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPushMatrix", "()V");
			global::android.opengl.GLES10._glReadPixels5647 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glReadPixels", "(IIIIIILjava/nio/Buffer;)V");
			global::android.opengl.GLES10._glRotatef5648 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glRotatef", "(FFFF)V");
			global::android.opengl.GLES10._glRotatex5649 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glRotatex", "(IIII)V");
			global::android.opengl.GLES10._glSampleCoverage5650 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glSampleCoverage", "(FZ)V");
			global::android.opengl.GLES10._glSampleCoveragex5651 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glSampleCoveragex", "(IZ)V");
			global::android.opengl.GLES10._glScalef5652 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glScalef", "(FFF)V");
			global::android.opengl.GLES10._glScalex5653 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glScalex", "(III)V");
			global::android.opengl.GLES10._glScissor5654 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glScissor", "(IIII)V");
			global::android.opengl.GLES10._glShadeModel5655 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glShadeModel", "(I)V");
			global::android.opengl.GLES10._glStencilFunc5656 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glStencilFunc", "(III)V");
			global::android.opengl.GLES10._glStencilMask5657 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glStencilMask", "(I)V");
			global::android.opengl.GLES10._glStencilOp5658 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glStencilOp", "(III)V");
			global::android.opengl.GLES10._glTexCoordPointer5659 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexCoordPointer", "(IIILjava/nio/Buffer;)V");
			global::android.opengl.GLES10._glTexEnvf5660 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvf", "(IIF)V");
			global::android.opengl.GLES10._glTexEnvfv5661 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvfv", "(II[FI)V");
			global::android.opengl.GLES10._glTexEnvfv5662 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V");
			global::android.opengl.GLES10._glTexEnvx5663 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvx", "(III)V");
			global::android.opengl.GLES10._glTexEnvxv5664 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvxv", "(II[II)V");
			global::android.opengl.GLES10._glTexEnvxv5665 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			global::android.opengl.GLES10._glTexImage2D5666 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::android.opengl.GLES10._glTexParameterf5667 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexParameterf", "(IIF)V");
			global::android.opengl.GLES10._glTexParameterx5668 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexParameterx", "(III)V");
			global::android.opengl.GLES10._glTexSubImage2D5669 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::android.opengl.GLES10._glTranslatef5670 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTranslatef", "(FFF)V");
			global::android.opengl.GLES10._glTranslatex5671 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTranslatex", "(III)V");
			global::android.opengl.GLES10._glVertexPointer5672 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glVertexPointer", "(IIILjava/nio/Buffer;)V");
			global::android.opengl.GLES10._glViewport5673 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glViewport", "(IIII)V");
			global::android.opengl.GLES10._GLES105674 = @__env.GetMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "<init>", "()V");
		}
	}
}
