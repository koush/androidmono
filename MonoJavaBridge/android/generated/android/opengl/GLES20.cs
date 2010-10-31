namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLES20 : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GLES20(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void glActiveTexture(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m0.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m0 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glActiveTexture", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void glBindTexture(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m1.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m1 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBindTexture", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void glBlendFunc(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m2.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m2 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBlendFunc", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void glClear(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m3.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m3 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glClear", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void glClearColor(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m4.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m4 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glClearColor", "(FFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void glClearDepthf(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m5.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m5 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glClearDepthf", "(F)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void glClearStencil(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m6.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m6 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glClearStencil", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void glColorMask(bool arg0, bool arg1, bool arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m7.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m7 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glColorMask", "(ZZZZ)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m8.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m8 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static void glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m9.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m9 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static void glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m10.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m10 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCopyTexImage2D", "(IIIIIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static void glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m11.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m11 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCopyTexSubImage2D", "(IIIIIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void glCullFace(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m12.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m12 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCullFace", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static void glDeleteTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m13.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m13 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteTextures", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static void glDeleteTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m14.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m14 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteTextures", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static void glDepthFunc(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m15.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m15 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDepthFunc", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static void glDepthMask(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m16.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m16 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDepthMask", "(Z)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static void glDepthRangef(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m17.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m17 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDepthRangef", "(FF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static void glDisable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m18.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m18 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDisable", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static void glDrawArrays(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m19.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m19 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDrawArrays", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static void glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m20.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m20 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDrawElements", "(IIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static void glEnable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m21.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m21 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glEnable", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static void glFinish()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m22.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m22 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glFinish", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static void glFlush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m23.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m23 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glFlush", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static void glFrontFace(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m24.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m24 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glFrontFace", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static void glGenTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m25.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m25 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenTextures", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static void glGenTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m26.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m26 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenTextures", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static int glGetError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m27.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m27 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetError", "()I");
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static void glGetIntegerv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m28.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m28 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static void glGetIntegerv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m29.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m29 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetIntegerv", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static global::java.lang.String glGetString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m30.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m30 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static void glHint(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m31.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m31 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glHint", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static void glLineWidth(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m32.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m32 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glLineWidth", "(F)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public static void glPixelStorei(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m33.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m33 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glPixelStorei", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public static void glPolygonOffset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m34.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m34 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glPolygonOffset", "(FF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static void glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m35.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m35 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glReadPixels", "(IIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public static void glSampleCoverage(float arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m36.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m36 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glSampleCoverage", "(FZ)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public static void glScissor(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m37.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m37 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glScissor", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public static void glStencilFunc(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m38.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m38 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glStencilFunc", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public static void glStencilMask(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m39.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m39 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glStencilMask", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public static void glStencilOp(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m40.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m40 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glStencilOp", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public static void glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m41.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m41 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public static void glTexParameterf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m42.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m42 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexParameterf", "(IIF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public static void glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m43.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m43 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public static void glViewport(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m44.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m44 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glViewport", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public static void glBindBuffer(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m45.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m45 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBindBuffer", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public static void glBufferData(int arg0, int arg1, java.nio.Buffer arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m46.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m46 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBufferData", "(IILjava/nio/Buffer;I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public static void glBufferSubData(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m47.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m47 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBufferSubData", "(IIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public static void glDeleteBuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m48.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m48 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteBuffers", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public static void glDeleteBuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m49.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m49 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteBuffers", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public static void glGenBuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m50.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m50 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenBuffers", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public static void glGenBuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m51.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m51 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenBuffers", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public static void glGetBooleanv(int arg0, bool[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m52.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m52 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetBooleanv", "(I[ZI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public static void glGetBooleanv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m53.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m53 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetBooleanv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public static void glGetBufferParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m54.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m54 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetBufferParameteriv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public static void glGetBufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m55.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m55 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetBufferParameteriv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public static void glGetFloatv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m56.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m56 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetFloatv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public static void glGetFloatv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m57.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m57 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetFloatv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public static void glGetTexParameterfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m58.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m58 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetTexParameterfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public static void glGetTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m59.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m59 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public static void glGetTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m60.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m60 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public static void glGetTexParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m61.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m61 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetTexParameteriv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public static bool glIsBuffer(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m62.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m62 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glIsBuffer", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public static bool glIsEnabled(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m63.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m63 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glIsEnabled", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public static bool glIsTexture(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m64.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m64 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glIsTexture", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public static void glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m65.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m65 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexParameterfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public static void glTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m66.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m66 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public static void glTexParameteri(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m67.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m67 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexParameteri", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public static void glTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m68.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m68 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public static void glTexParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m69.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m69 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glTexParameteriv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public static void glAttachShader(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m70.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m70 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glAttachShader", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public static void glBindAttribLocation(int arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m71.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m71 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBindAttribLocation", "(IILjava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public static void glBindFramebuffer(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m72.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m72 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBindFramebuffer", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public static void glBindRenderbuffer(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m73.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m73 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBindRenderbuffer", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public static void glBlendColor(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m74.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m74 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBlendColor", "(FFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public static void glBlendEquation(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m75.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m75 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBlendEquation", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public static void glBlendEquationSeparate(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m76.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m76 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBlendEquationSeparate", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public static void glBlendFuncSeparate(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m77.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m77 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glBlendFuncSeparate", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public static int glCheckFramebufferStatus(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m78.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m78 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCheckFramebufferStatus", "(I)I");
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public static void glCompileShader(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m79.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m79 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCompileShader", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m80;
		public static int glCreateProgram()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m80.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m80 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCreateProgram", "()I");
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m80);
		}
		private static global::MonoJavaBridge.MethodId _m81;
		public static int glCreateShader(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m81.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m81 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glCreateShader", "(I)I");
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m82;
		public static void glDeleteFramebuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m82.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m82 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteFramebuffers", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public static void glDeleteFramebuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m83.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m83 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteFramebuffers", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m84;
		public static void glDeleteProgram(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m84.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m84 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteProgram", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m85;
		public static void glDeleteRenderbuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m85.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m85 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteRenderbuffers", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m85, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m86;
		public static void glDeleteRenderbuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m86.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m86 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteRenderbuffers", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m86, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m87;
		public static void glDeleteShader(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m87.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m87 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDeleteShader", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m87, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m88;
		public static void glDetachShader(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m88.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m88 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDetachShader", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m88, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m89;
		public static void glDisableVertexAttribArray(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m89.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m89 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glDisableVertexAttribArray", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m89, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m90;
		public static void glEnableVertexAttribArray(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m90.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m90 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glEnableVertexAttribArray", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m91;
		public static void glFramebufferRenderbuffer(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m91.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m91 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glFramebufferRenderbuffer", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m91, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m92;
		public static void glFramebufferTexture2D(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m92.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m92 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glFramebufferTexture2D", "(IIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m92, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m93;
		public static void glGenerateMipmap(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m93.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m93 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenerateMipmap", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m93, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m94;
		public static void glGenFramebuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m94.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m94 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenFramebuffers", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m94, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m95;
		public static void glGenFramebuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m95.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m95 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenFramebuffers", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m95, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m96;
		public static void glGenRenderbuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m96.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m96 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenRenderbuffers", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m96, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m97;
		public static void glGenRenderbuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m97.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m97 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGenRenderbuffers", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m97, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m98;
		public static void glGetActiveAttrib(int arg0, int arg1, int arg2, int[] arg3, int arg4, int[] arg5, int arg6, int[] arg7, int arg8, byte[] arg9, int arg10)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m98.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m98 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetActiveAttrib", "(III[II[II[II[BI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m98, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
		}
		private static global::MonoJavaBridge.MethodId _m99;
		public static void glGetActiveAttrib(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3, java.nio.IntBuffer arg4, java.nio.IntBuffer arg5, byte arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m99.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m99 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetActiveAttrib", "(IIILjava/nio/IntBuffer;Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;B)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m99, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m100;
		public static void glGetActiveUniform(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3, java.nio.IntBuffer arg4, java.nio.IntBuffer arg5, byte arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m100.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m100 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetActiveUniform", "(IIILjava/nio/IntBuffer;Ljava/nio/IntBuffer;Ljava/nio/IntBuffer;B)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m101;
		public static void glGetActiveUniform(int arg0, int arg1, int arg2, int[] arg3, int arg4, int[] arg5, int arg6, int[] arg7, int arg8, byte[] arg9, int arg10)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m101.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m101 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetActiveUniform", "(III[II[II[II[BI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
		}
		private static global::MonoJavaBridge.MethodId _m102;
		public static void glGetAttachedShaders(int arg0, int arg1, int[] arg2, int arg3, int[] arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m102.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m102 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetAttachedShaders", "(II[II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m103;
		public static void glGetAttachedShaders(int arg0, int arg1, java.nio.IntBuffer arg2, java.nio.IntBuffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m103.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m103 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetAttachedShaders", "(IILjava/nio/IntBuffer;Ljava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m104;
		public static int glGetAttribLocation(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m104.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m104 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetAttribLocation", "(ILjava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m105;
		public static void glGetFramebufferAttachmentParameteriv(int arg0, int arg1, int arg2, int[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m105.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m105 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetFramebufferAttachmentParameteriv", "(III[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m106;
		public static void glGetFramebufferAttachmentParameteriv(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m106.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m106 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetFramebufferAttachmentParameteriv", "(IIILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m107;
		public static void glGetProgramiv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m107.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m107 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetProgramiv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m108;
		public static void glGetProgramiv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m108.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m108 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetProgramiv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m109;
		public static global::java.lang.String glGetProgramInfoLog(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m109.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m109 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetProgramInfoLog", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m110;
		public static void glGetRenderbufferParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m110.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m110 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetRenderbufferParameteriv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m111;
		public static void glGetRenderbufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m111.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m111 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetRenderbufferParameteriv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m112;
		public static void glGetShaderiv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m112.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m112 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetShaderiv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m113;
		public static void glGetShaderiv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m113.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m113 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetShaderiv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m114;
		public static global::java.lang.String glGetShaderInfoLog(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m114.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m114 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetShaderInfoLog", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m115;
		public static void glGetShaderPrecisionFormat(int arg0, int arg1, java.nio.IntBuffer arg2, java.nio.IntBuffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m115.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m115 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetShaderPrecisionFormat", "(IILjava/nio/IntBuffer;Ljava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m116;
		public static void glGetShaderPrecisionFormat(int arg0, int arg1, int[] arg2, int arg3, int[] arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m116.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m116 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetShaderPrecisionFormat", "(II[II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m117;
		public static void glGetShaderSource(int arg0, int arg1, java.nio.IntBuffer arg2, byte arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m117.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m117 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetShaderSource", "(IILjava/nio/IntBuffer;B)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m118;
		public static void glGetShaderSource(int arg0, int arg1, int[] arg2, int arg3, byte[] arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m118.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m118 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetShaderSource", "(II[II[BI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m119;
		public static void glGetUniformfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m119.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m119 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetUniformfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m120;
		public static void glGetUniformfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m120.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m120 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetUniformfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m121;
		public static void glGetUniformiv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m121.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m121 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetUniformiv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m122;
		public static void glGetUniformiv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m122.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m122 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetUniformiv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m123;
		public static int glGetUniformLocation(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m123.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m123 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetUniformLocation", "(ILjava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m124;
		public static void glGetVertexAttribfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m124.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m124 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetVertexAttribfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m125;
		public static void glGetVertexAttribfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m125.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m125 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetVertexAttribfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m126;
		public static void glGetVertexAttribiv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m126.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m126 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetVertexAttribiv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m127;
		public static void glGetVertexAttribiv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m127.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m127 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glGetVertexAttribiv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m128;
		public static bool glIsFramebuffer(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m128.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m128 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glIsFramebuffer", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m129;
		public static bool glIsProgram(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m129.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m129 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glIsProgram", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m130;
		public static bool glIsRenderbuffer(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m130.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m130 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glIsRenderbuffer", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m131;
		public static bool glIsShader(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m131.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m131 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glIsShader", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m132;
		public static void glLinkProgram(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m132.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m132 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glLinkProgram", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m133;
		public static void glReleaseShaderCompiler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m133.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m133 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glReleaseShaderCompiler", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m133);
		}
		private static global::MonoJavaBridge.MethodId _m134;
		public static void glRenderbufferStorage(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m134.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m134 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glRenderbufferStorage", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m135;
		public static void glShaderBinary(int arg0, java.nio.IntBuffer arg1, int arg2, java.nio.Buffer arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m135.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m135 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glShaderBinary", "(ILjava/nio/IntBuffer;ILjava/nio/Buffer;I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m136;
		public static void glShaderBinary(int arg0, int[] arg1, int arg2, int arg3, java.nio.Buffer arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m136.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m136 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glShaderBinary", "(I[IIILjava/nio/Buffer;I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m137;
		public static void glShaderSource(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m137.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m137 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glShaderSource", "(ILjava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m138;
		public static void glStencilFuncSeparate(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m138.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m138 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glStencilFuncSeparate", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m139;
		public static void glStencilMaskSeparate(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m139.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m139 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glStencilMaskSeparate", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m140;
		public static void glStencilOpSeparate(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m140.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m140 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glStencilOpSeparate", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m141;
		public static void glUniform1f(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m141.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m141 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform1f", "(IF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m142;
		public static void glUniform1fv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m142.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m142 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform1fv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m143;
		public static void glUniform1fv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m143.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m143 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform1fv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m144;
		public static void glUniform1i(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m144.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m144 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform1i", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m145;
		public static void glUniform1iv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m145.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m145 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform1iv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m146;
		public static void glUniform1iv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m146.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m146 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform1iv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m147;
		public static void glUniform2f(int arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m147.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m147 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform2f", "(IFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m148;
		public static void glUniform2fv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m148.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m148 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform2fv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m149;
		public static void glUniform2fv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m149.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m149 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform2fv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m150;
		public static void glUniform2i(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m150.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m150 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform2i", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m151;
		public static void glUniform2iv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m151.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m151 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform2iv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m152;
		public static void glUniform2iv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m152.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m152 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform2iv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m153;
		public static void glUniform3f(int arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m153.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m153 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform3f", "(IFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m154;
		public static void glUniform3fv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m154.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m154 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform3fv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m155;
		public static void glUniform3fv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m155.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m155 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform3fv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m156;
		public static void glUniform3i(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m156.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m156 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform3i", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m157;
		public static void glUniform3iv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m157.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m157 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform3iv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m158;
		public static void glUniform3iv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m158.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m158 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform3iv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m159;
		public static void glUniform4f(int arg0, float arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m159.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m159 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform4f", "(IFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m160;
		public static void glUniform4fv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m160.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m160 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform4fv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m161;
		public static void glUniform4fv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m161.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m161 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform4fv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m162;
		public static void glUniform4i(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m162.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m162 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform4i", "(IIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m163;
		public static void glUniform4iv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m163.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m163 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform4iv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m164;
		public static void glUniform4iv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m164.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m164 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniform4iv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m165;
		public static void glUniformMatrix2fv(int arg0, int arg1, bool arg2, java.nio.FloatBuffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m165.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m165 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniformMatrix2fv", "(IIZLjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m166;
		public static void glUniformMatrix2fv(int arg0, int arg1, bool arg2, float[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m166.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m166 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniformMatrix2fv", "(IIZ[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m167;
		public static void glUniformMatrix3fv(int arg0, int arg1, bool arg2, java.nio.FloatBuffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m167.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m167 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniformMatrix3fv", "(IIZLjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m168;
		public static void glUniformMatrix3fv(int arg0, int arg1, bool arg2, float[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m168.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m168 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniformMatrix3fv", "(IIZ[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m169;
		public static void glUniformMatrix4fv(int arg0, int arg1, bool arg2, java.nio.FloatBuffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m169.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m169 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniformMatrix4fv", "(IIZLjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m170;
		public static void glUniformMatrix4fv(int arg0, int arg1, bool arg2, float[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m170.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m170 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUniformMatrix4fv", "(IIZ[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m171;
		public static void glUseProgram(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m171.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m171 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glUseProgram", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m172;
		public static void glValidateProgram(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m172.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m172 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glValidateProgram", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m173;
		public static void glVertexAttrib1f(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m173.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m173 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib1f", "(IF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m174;
		public static void glVertexAttrib1fv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m174.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m174 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib1fv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m175;
		public static void glVertexAttrib1fv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m175.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m175 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib1fv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m176;
		public static void glVertexAttrib2f(int arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m176.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m176 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib2f", "(IFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m177;
		public static void glVertexAttrib2fv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m177.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m177 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib2fv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m178;
		public static void glVertexAttrib2fv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m178.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m178 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib2fv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m179;
		public static void glVertexAttrib3f(int arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m179.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m179 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib3f", "(IFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m180;
		public static void glVertexAttrib3fv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m180.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m180 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib3fv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m181;
		public static void glVertexAttrib3fv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m181.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m181 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib3fv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m182;
		public static void glVertexAttrib4f(int arg0, float arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m182.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m182 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib4f", "(IFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m183;
		public static void glVertexAttrib4fv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m183.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m183 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib4fv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m184;
		public static void glVertexAttrib4fv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m184.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m184 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttrib4fv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m185;
		public static void glVertexAttribPointer(int arg0, int arg1, int arg2, bool arg3, int arg4, java.nio.Buffer arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m185.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m185 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "glVertexAttribPointer", "(IIIZILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m186;
		public GLES20() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES20._m186.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES20._m186 = @__env.GetMethodIDNoThrow(global::android.opengl.GLES20.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLES20.staticClass, global::android.opengl.GLES20._m186);
			Init(@__env, handle);
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
		static GLES20()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLES20.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLES20"));
		}
	}
}
