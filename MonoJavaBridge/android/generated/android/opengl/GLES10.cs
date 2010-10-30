namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLES10 : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GLES10(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void glActiveTexture(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m0.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m0 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glActiveTexture", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void glAlphaFunc(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m1.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m1 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glAlphaFunc", "(IF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void glAlphaFuncx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m2.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m2 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glAlphaFuncx", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void glBindTexture(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m3.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m3 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glBindTexture", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void glBlendFunc(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m4.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m4 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glBlendFunc", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void glClear(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m5.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m5 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClear", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void glClearColor(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m6.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m6 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClearColor", "(FFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void glClearColorx(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m7.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m7 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClearColorx", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void glClearDepthf(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m8.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m8 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClearDepthf", "(F)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static void glClearDepthx(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m9.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m9 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClearDepthx", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static void glClearStencil(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m10.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m10 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClearStencil", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static void glClientActiveTexture(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m11.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m11 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClientActiveTexture", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void glColor4f(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m12.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m12 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glColor4f", "(FFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static void glColor4x(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m13.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m13 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glColor4x", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static void glColorMask(bool arg0, bool arg1, bool arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m14.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m14 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glColorMask", "(ZZZZ)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static void glColorPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m15.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m15 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glColorPointer", "(IIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static void glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m16.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m16 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static void glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m17.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m17 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static void glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m18.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m18 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glCopyTexImage2D", "(IIIIIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static void glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m19.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m19 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glCopyTexSubImage2D", "(IIIIIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static void glCullFace(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m20.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m20 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glCullFace", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static void glDeleteTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m21.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m21 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDeleteTextures", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static void glDeleteTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m22.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m22 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDeleteTextures", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static void glDepthFunc(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m23.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m23 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDepthFunc", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static void glDepthMask(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m24.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m24 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDepthMask", "(Z)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static void glDepthRangef(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m25.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m25 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDepthRangef", "(FF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static void glDepthRangex(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m26.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m26 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDepthRangex", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static void glDisable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m27.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m27 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDisable", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static void glDisableClientState(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m28.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m28 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDisableClientState", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static void glDrawArrays(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m29.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m29 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDrawArrays", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static void glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m30.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m30 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDrawElements", "(IIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static void glEnable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m31.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m31 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glEnable", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static void glEnableClientState(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m32.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m32 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glEnableClientState", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public static void glFinish()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m33.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m33 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFinish", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public static void glFlush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m34.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m34 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFlush", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m34);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static void glFogf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m35.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m35 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogf", "(IF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public static void glFogfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m36.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m36 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogfv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public static void glFogfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m37.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m37 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogfv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public static void glFogx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m38.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m38 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogx", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public static void glFogxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m39.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m39 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogxv", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public static void glFogxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m40.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m40 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogxv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public static void glFrontFace(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m41.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m41 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFrontFace", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public static void glFrustumf(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m42.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m42 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFrustumf", "(FFFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public static void glFrustumx(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m43.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m43 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFrustumx", "(IIIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public static void glGenTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m44.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m44 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGenTextures", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public static void glGenTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m45.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m45 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGenTextures", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public static int glGetError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m46.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m46 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGetError", "()I");
			return @__env.CallStaticIntMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m46);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public static void glGetIntegerv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m47.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m47 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGetIntegerv", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public static void glGetIntegerv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m48.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m48 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public static global::java.lang.String glGetString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m49.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m49 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGetString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public static void glHint(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m50.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m50 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glHint", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public static void glLightModelf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m51.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m51 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelf", "(IF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public static void glLightModelfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m52.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m52 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelfv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public static void glLightModelfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m53.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m53 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelfv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public static void glLightModelx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m54.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m54 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelx", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public static void glLightModelxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m55.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m55 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelxv", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public static void glLightModelxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m56.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m56 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelxv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public static void glLightf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m57.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m57 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightf", "(IIF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public static void glLightfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m58.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m58 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public static void glLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m59.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m59 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public static void glLightx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m60.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m60 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightx", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public static void glLightxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m61.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m61 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightxv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public static void glLightxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m62.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m62 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightxv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public static void glLineWidth(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m63.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m63 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLineWidth", "(F)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public static void glLineWidthx(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m64.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m64 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLineWidthx", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public static void glLoadIdentity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m65.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m65 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLoadIdentity", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m65);
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public static void glLoadMatrixf(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m66.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m66 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLoadMatrixf", "([FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public static void glLoadMatrixf(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m67.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m67 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public static void glLoadMatrixx(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m68.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m68 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLoadMatrixx", "([II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public static void glLoadMatrixx(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m69.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m69 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLoadMatrixx", "(Ljava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public static void glLogicOp(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m70.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m70 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLogicOp", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public static void glMaterialf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m71.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m71 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialf", "(IIF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public static void glMaterialfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m72.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m72 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public static void glMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m73.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m73 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public static void glMaterialx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m74.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m74 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialx", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public static void glMaterialxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m75.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m75 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialxv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public static void glMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m76.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m76 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialxv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public static void glMatrixMode(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m77.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m77 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMatrixMode", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public static void glMultMatrixf(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m78.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m78 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultMatrixf", "([FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public static void glMultMatrixf(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m79.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m79 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultMatrixf", "(Ljava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m80;
		public static void glMultMatrixx(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m80.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m80 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultMatrixx", "([II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m81;
		public static void glMultMatrixx(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m81.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m81 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultMatrixx", "(Ljava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m82;
		public static void glMultiTexCoord4f(int arg0, float arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m82.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m82 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultiTexCoord4f", "(IFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public static void glMultiTexCoord4x(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m83.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m83 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultiTexCoord4x", "(IIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m84;
		public static void glNormal3f(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m84.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m84 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glNormal3f", "(FFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m85;
		public static void glNormal3x(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m85.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m85 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glNormal3x", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m85, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m86;
		public static void glNormalPointer(int arg0, int arg1, java.nio.Buffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m86.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m86 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glNormalPointer", "(IILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m86, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m87;
		public static void glOrthof(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m87.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m87 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glOrthof", "(FFFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m87, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m88;
		public static void glOrthox(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m88.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m88 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glOrthox", "(IIIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m88, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m89;
		public static void glPixelStorei(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m89.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m89 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPixelStorei", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m89, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m90;
		public static void glPointSize(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m90.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m90 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPointSize", "(F)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m91;
		public static void glPointSizex(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m91.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m91 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPointSizex", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m91, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m92;
		public static void glPolygonOffset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m92.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m92 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPolygonOffset", "(FF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m92, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m93;
		public static void glPolygonOffsetx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m93.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m93 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPolygonOffsetx", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m93, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m94;
		public static void glPopMatrix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m94.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m94 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPopMatrix", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m94);
		}
		private static global::MonoJavaBridge.MethodId _m95;
		public static void glPushMatrix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m95.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m95 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPushMatrix", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m95);
		}
		private static global::MonoJavaBridge.MethodId _m96;
		public static void glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m96.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m96 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glReadPixels", "(IIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m96, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m97;
		public static void glRotatef(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m97.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m97 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glRotatef", "(FFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m97, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m98;
		public static void glRotatex(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m98.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m98 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glRotatex", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m98, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m99;
		public static void glSampleCoverage(float arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m99.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m99 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glSampleCoverage", "(FZ)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m99, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m100;
		public static void glSampleCoveragex(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m100.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m100 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glSampleCoveragex", "(IZ)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m101;
		public static void glScalef(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m101.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m101 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glScalef", "(FFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m102;
		public static void glScalex(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m102.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m102 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glScalex", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m103;
		public static void glScissor(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m103.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m103 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glScissor", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m104;
		public static void glShadeModel(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m104.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m104 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glShadeModel", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m105;
		public static void glStencilFunc(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m105.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m105 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glStencilFunc", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m106;
		public static void glStencilMask(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m106.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m106 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glStencilMask", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m107;
		public static void glStencilOp(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m107.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m107 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glStencilOp", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m108;
		public static void glTexCoordPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m108.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m108 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexCoordPointer", "(IIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m109;
		public static void glTexEnvf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m109.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m109 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvf", "(IIF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m110;
		public static void glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m110.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m110 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m111;
		public static void glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m111.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m111 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m112;
		public static void glTexEnvx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m112.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m112 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvx", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m113;
		public static void glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m113.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m113 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvxv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m114;
		public static void glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m114.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m114 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m115;
		public static void glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m115.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m115 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		private static global::MonoJavaBridge.MethodId _m116;
		public static void glTexParameterf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m116.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m116 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexParameterf", "(IIF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m117;
		public static void glTexParameterx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m117.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m117 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexParameterx", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m118;
		public static void glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m118.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m118 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		private static global::MonoJavaBridge.MethodId _m119;
		public static void glTranslatef(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m119.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m119 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTranslatef", "(FFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m120;
		public static void glTranslatex(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m120.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m120 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTranslatex", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m121;
		public static void glVertexPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m121.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m121 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glVertexPointer", "(IIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m122;
		public static void glViewport(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m122.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m122 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glViewport", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m123;
		public GLES10() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._m123.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._m123 = @__env.GetMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._m123);
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
		static GLES10()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLES10.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLES10"));
		}
		internal static void InitJNI()
		{
		}
	}
}
