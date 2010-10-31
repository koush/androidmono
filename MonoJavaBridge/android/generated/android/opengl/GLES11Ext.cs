namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLES11Ext : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GLES11Ext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void glBlendEquationSeparateOES(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m0.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m0 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glBlendEquationSeparateOES", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void glBlendFuncSeparateOES(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m1.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m1 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glBlendFuncSeparateOES", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void glBlendEquationOES(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m2.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m2 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glBlendEquationOES", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void glDrawTexsOES(short arg0, short arg1, short arg2, short arg3, short arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m3.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m3 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsOES", "(SSSSS)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void glDrawTexiOES(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m4.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m4 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexiOES", "(IIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void glDrawTexxOES(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m5.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m5 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxOES", "(IIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void glDrawTexsvOES(short[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m6.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m6 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsvOES", "([SI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void glDrawTexsvOES(java.nio.ShortBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m7.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m7 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexsvOES", "(Ljava/nio/ShortBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void glDrawTexivOES(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m8.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m8 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexivOES", "([II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static void glDrawTexivOES(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m9.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m9 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexivOES", "(Ljava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static void glDrawTexxvOES(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m10.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m10 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxvOES", "([II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static void glDrawTexxvOES(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m11.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m11 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexxvOES", "(Ljava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void glDrawTexfOES(float arg0, float arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m12.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m12 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfOES", "(FFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static void glDrawTexfvOES(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m13.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m13 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfvOES", "([FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static void glDrawTexfvOES(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m14.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m14 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDrawTexfvOES", "(Ljava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static void glEGLImageTargetTexture2DOES(int arg0, java.nio.Buffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m15.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m15 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glEGLImageTargetTexture2DOES", "(ILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static void glEGLImageTargetRenderbufferStorageOES(int arg0, java.nio.Buffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m16.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m16 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glEGLImageTargetRenderbufferStorageOES", "(ILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static void glAlphaFuncxOES(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m17.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m17 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glAlphaFuncxOES", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static void glClearColorxOES(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m18.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m18 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClearColorxOES", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static void glClearDepthxOES(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m19.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m19 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClearDepthxOES", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static void glClipPlanexOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m20.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m20 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClipPlanexOES", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static void glClipPlanexOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m21.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m21 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClipPlanexOES", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static void glColor4xOES(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m22.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m22 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glColor4xOES", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static void glDepthRangexOES(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m23.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m23 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDepthRangexOES", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static void glFogxOES(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m24.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m24 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFogxOES", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static void glFogxvOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m25.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m25 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFogxvOES", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static void glFogxvOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m26.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m26 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFogxvOES", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static void glFrustumxOES(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m27.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m27 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFrustumxOES", "(IIIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static void glGetClipPlanexOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m28.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m28 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanexOES", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static void glGetClipPlanexOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m29.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m29 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanexOES", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static void glGetFixedvOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m30.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m30 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetFixedvOES", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static void glGetFixedvOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m31.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m31 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetFixedvOES", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static void glGetLightxvOES(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m32.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m32 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetLightxvOES", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public static void glGetLightxvOES(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m33.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m33 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetLightxvOES", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public static void glGetMaterialxvOES(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m34.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m34 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetMaterialxvOES", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static void glGetMaterialxvOES(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m35.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m35 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetMaterialxvOES", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public static void glGetTexEnvxvOES(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m36.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m36 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexEnvxvOES", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public static void glGetTexEnvxvOES(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m37.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m37 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexEnvxvOES", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public static void glGetTexParameterxvOES(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m38.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m38 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexParameterxvOES", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public static void glGetTexParameterxvOES(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m39.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m39 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexParameterxvOES", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public static void glLightModelxOES(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m40.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m40 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightModelxOES", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public static void glLightModelxvOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m41.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m41 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightModelxvOES", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public static void glLightModelxvOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m42.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m42 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightModelxvOES", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public static void glLightxOES(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m43.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m43 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightxOES", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public static void glLightxvOES(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m44.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m44 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightxvOES", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public static void glLightxvOES(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m45.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m45 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLightxvOES", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public static void glLineWidthxOES(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m46.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m46 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLineWidthxOES", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public static void glLoadMatrixxOES(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m47.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m47 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLoadMatrixxOES", "([II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public static void glLoadMatrixxOES(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m48.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m48 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLoadMatrixxOES", "(Ljava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public static void glMaterialxOES(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m49.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m49 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMaterialxOES", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public static void glMaterialxvOES(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m50.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m50 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMaterialxvOES", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public static void glMaterialxvOES(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m51.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m51 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMaterialxvOES", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public static void glMultMatrixxOES(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m52.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m52 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMultMatrixxOES", "([II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public static void glMultMatrixxOES(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m53.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m53 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMultMatrixxOES", "(Ljava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public static void glMultiTexCoord4xOES(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m54.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m54 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMultiTexCoord4xOES", "(IIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public static void glNormal3xOES(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m55.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m55 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glNormal3xOES", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public static void glOrthoxOES(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m56.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m56 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glOrthoxOES", "(IIIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public static void glPointParameterxOES(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m57.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m57 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxOES", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public static void glPointParameterxvOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m58.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m58 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxvOES", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public static void glPointParameterxvOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m59.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m59 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glPointParameterxvOES", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public static void glPointSizexOES(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m60.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m60 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glPointSizexOES", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public static void glPolygonOffsetxOES(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m61.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m61 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glPolygonOffsetxOES", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public static void glRotatexOES(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m62.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m62 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glRotatexOES", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public static void glSampleCoveragexOES(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m63.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m63 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glSampleCoveragexOES", "(IZ)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public static void glScalexOES(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m64.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m64 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glScalexOES", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public static void glTexEnvxOES(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m65.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m65 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxOES", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public static void glTexEnvxvOES(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m66.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m66 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxvOES", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public static void glTexEnvxvOES(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m67.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m67 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexEnvxvOES", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public static void glTexParameterxOES(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m68.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m68 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxOES", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public static void glTexParameterxvOES(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m69.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m69 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxvOES", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public static void glTexParameterxvOES(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m70.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m70 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexParameterxvOES", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public static void glTranslatexOES(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m71.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m71 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTranslatexOES", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public static bool glIsRenderbufferOES(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m72.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m72 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glIsRenderbufferOES", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public static void glBindRenderbufferOES(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m73.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m73 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glBindRenderbufferOES", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public static void glDeleteRenderbuffersOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m74.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m74 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDeleteRenderbuffersOES", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public static void glDeleteRenderbuffersOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m75.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m75 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDeleteRenderbuffersOES", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public static void glGenRenderbuffersOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m76.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m76 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGenRenderbuffersOES", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public static void glGenRenderbuffersOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m77.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m77 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGenRenderbuffersOES", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public static void glRenderbufferStorageOES(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m78.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m78 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glRenderbufferStorageOES", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public static void glGetRenderbufferParameterivOES(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m79.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m79 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetRenderbufferParameterivOES", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m80;
		public static void glGetRenderbufferParameterivOES(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m80.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m80 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetRenderbufferParameterivOES", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m81;
		public static bool glIsFramebufferOES(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m81.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m81 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glIsFramebufferOES", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m82;
		public static void glBindFramebufferOES(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m82.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m82 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glBindFramebufferOES", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public static void glDeleteFramebuffersOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m83.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m83 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDeleteFramebuffersOES", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m84;
		public static void glDeleteFramebuffersOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m84.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m84 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDeleteFramebuffersOES", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m85;
		public static void glGenFramebuffersOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m85.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m85 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGenFramebuffersOES", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m85, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m86;
		public static void glGenFramebuffersOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m86.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m86 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGenFramebuffersOES", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m86, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m87;
		public static int glCheckFramebufferStatusOES(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m87.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m87 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glCheckFramebufferStatusOES", "(I)I");
			return @__env.CallStaticIntMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m87, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m88;
		public static void glFramebufferRenderbufferOES(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m88.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m88 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFramebufferRenderbufferOES", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m88, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m89;
		public static void glFramebufferTexture2DOES(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m89.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m89 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFramebufferTexture2DOES", "(IIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m89, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m90;
		public static void glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, int[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m90.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m90 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetFramebufferAttachmentParameterivOES", "(III[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m91;
		public static void glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m91.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m91 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetFramebufferAttachmentParameterivOES", "(IIILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m91, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m92;
		public static void glGenerateMipmapOES(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m92.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m92 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGenerateMipmapOES", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m92, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m93;
		public static void glCurrentPaletteMatrixOES(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m93.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m93 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glCurrentPaletteMatrixOES", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m93, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m94;
		public static void glLoadPaletteFromModelViewMatrixOES()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m94.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m94 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glLoadPaletteFromModelViewMatrixOES", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m94);
		}
		private static global::MonoJavaBridge.MethodId _m95;
		public static void glMatrixIndexPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m95.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m95 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glMatrixIndexPointerOES", "(IIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m95, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m96;
		public static void glWeightPointerOES(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m96.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m96 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glWeightPointerOES", "(IIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m96, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m97;
		public static void glDepthRangefOES(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m97.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m97 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glDepthRangefOES", "(FF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m97, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m98;
		public static void glFrustumfOES(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m98.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m98 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glFrustumfOES", "(FFFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m98, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m99;
		public static void glOrthofOES(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m99.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m99 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glOrthofOES", "(FFFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m99, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m100;
		public static void glClipPlanefOES(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m100.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m100 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClipPlanefOES", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m101;
		public static void glClipPlanefOES(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m101.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m101 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClipPlanefOES", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m102;
		public static void glGetClipPlanefOES(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m102.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m102 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanefOES", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m103;
		public static void glGetClipPlanefOES(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m103.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m103 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetClipPlanefOES", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m104;
		public static void glClearDepthfOES(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m104.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m104 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glClearDepthfOES", "(F)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m105;
		public static void glTexGenfOES(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m105.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m105 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenfOES", "(IIF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m106;
		public static void glTexGenfvOES(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m106.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m106 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenfvOES", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m107;
		public static void glTexGenfvOES(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m107.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m107 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenfvOES", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m108;
		public static void glTexGeniOES(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m108.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m108 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGeniOES", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m109;
		public static void glTexGenivOES(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m109.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m109 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenivOES", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m110;
		public static void glTexGenivOES(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m110.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m110 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenivOES", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m111;
		public static void glTexGenxOES(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m111.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m111 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenxOES", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m112;
		public static void glTexGenxvOES(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m112.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m112 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenxvOES", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m113;
		public static void glTexGenxvOES(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m113.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m113 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glTexGenxvOES", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m114;
		public static void glGetTexGenfvOES(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m114.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m114 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenfvOES", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m115;
		public static void glGetTexGenfvOES(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m115.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m115 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenfvOES", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m116;
		public static void glGetTexGenivOES(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m116.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m116 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenivOES", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m117;
		public static void glGetTexGenivOES(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m117.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m117 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenivOES", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m118;
		public static void glGetTexGenxvOES(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m118.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m118 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenxvOES", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m119;
		public static void glGetTexGenxvOES(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m119.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m119 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "glGetTexGenxvOES", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m120;
		public GLES11Ext() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11Ext._m120.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11Ext._m120 = @__env.GetMethodIDNoThrow(global::android.opengl.GLES11Ext.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLES11Ext.staticClass, global::android.opengl.GLES11Ext._m120);
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
		static GLES11Ext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLES11Ext.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLES11Ext"));
		}
	}
}
