namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLES11 : android.opengl.GLES10
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GLES11(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void glColorPointer(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m0.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m0 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glColorPointer", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void glDrawElements(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m1.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m1 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glDrawElements", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void glNormalPointer(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m2.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m2 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glNormalPointer", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void glTexCoordPointer(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m3.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m3 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexCoordPointer", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void glVertexPointer(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m4.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m4 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glVertexPointer", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void glBindBuffer(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m5.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m5 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glBindBuffer", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void glBufferData(int arg0, int arg1, java.nio.Buffer arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m6.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m6 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glBufferData", "(IILjava/nio/Buffer;I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void glBufferSubData(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m7.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m7 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glBufferSubData", "(IIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void glClipPlanef(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m8.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m8 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glClipPlanef", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static void glClipPlanef(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m9.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m9 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glClipPlanef", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static void glClipPlanex(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m10.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m10 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glClipPlanex", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static void glClipPlanex(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m11.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m11 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glClipPlanex", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void glColor4ub(byte arg0, byte arg1, byte arg2, byte arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m12.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m12 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glColor4ub", "(BBBB)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static void glDeleteBuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m13.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m13 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glDeleteBuffers", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static void glDeleteBuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m14.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m14 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glDeleteBuffers", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static void glGenBuffers(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m15.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m15 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGenBuffers", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static void glGenBuffers(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m16.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m16 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGenBuffers", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static void glGetBooleanv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m17.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m17 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetBooleanv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static void glGetBooleanv(int arg0, bool[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m18.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m18 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetBooleanv", "(I[ZI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static void glGetBufferParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m19.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m19 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetBufferParameteriv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static void glGetBufferParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m20.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m20 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetBufferParameteriv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static void glGetClipPlanef(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m21.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m21 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetClipPlanef", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static void glGetClipPlanef(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m22.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m22 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetClipPlanef", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static void glGetClipPlanex(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m23.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m23 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetClipPlanex", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static void glGetClipPlanex(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m24.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m24 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetClipPlanex", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static void glGetFixedv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m25.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m25 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetFixedv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static void glGetFixedv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m26.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m26 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetFixedv", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static void glGetFloatv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m27.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m27 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetFloatv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static void glGetFloatv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m28.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m28 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetFloatv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static void glGetLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m29.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m29 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetLightfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static void glGetLightfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m30.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m30 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetLightfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static void glGetLightxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m31.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m31 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetLightxv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static void glGetLightxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m32.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m32 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetLightxv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public static void glGetMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m33.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m33 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetMaterialfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public static void glGetMaterialfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m34.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m34 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetMaterialfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static void glGetMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m35.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m35 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetMaterialxv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public static void glGetMaterialxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m36.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m36 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetMaterialxv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public static void glGetTexEnvfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m37.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m37 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnvfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public static void glGetTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m38.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m38 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnvfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public static void glGetTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m39.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m39 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnviv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public static void glGetTexEnviv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m40.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m40 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnviv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public static void glGetTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m41.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m41 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public static void glGetTexEnvxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m42.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m42 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexEnvxv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public static void glGetTexParameterfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m43.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m43 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameterfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public static void glGetTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m44.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m44 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public static void glGetTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m45.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m45 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public static void glGetTexParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m46.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m46 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameteriv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public static void glGetTexParameterxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m47.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m47 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameterxv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public static void glGetTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m48.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m48 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glGetTexParameterxv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public static bool glIsBuffer(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m49.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m49 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glIsBuffer", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public static bool glIsEnabled(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m50.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m50 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glIsEnabled", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public static bool glIsTexture(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m51.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m51 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glIsTexture", "(I)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public static void glPointParameterf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m52.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m52 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterf", "(IF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public static void glPointParameterfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m53.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m53 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterfv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public static void glPointParameterfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m54.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m54 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterfv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public static void glPointParameterx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m55.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m55 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterx", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public static void glPointParameterxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m56.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m56 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterxv", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public static void glPointParameterxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m57.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m57 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointParameterxv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public static void glPointSizePointerOES(int arg0, int arg1, java.nio.Buffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m58.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m58 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glPointSizePointerOES", "(IILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public static void glTexEnvi(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m59.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m59 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexEnvi", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public static void glTexEnviv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m60.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m60 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexEnviv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public static void glTexEnviv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m61.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m61 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexEnviv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public static void glTexParameterfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m62.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m62 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameterfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public static void glTexParameterfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m63.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m63 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameterfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public static void glTexParameteri(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m64.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m64 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameteri", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public static void glTexParameteriv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m65.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m65 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameteriv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public static void glTexParameteriv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m66.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m66 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameteriv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public static void glTexParameterxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m67.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m67 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameterxv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public static void glTexParameterxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m68.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m68 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "glTexParameterxv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public GLES11() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES11._m69.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES11._m69 = @__env.GetMethodIDNoThrow(global::android.opengl.GLES11.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLES11.staticClass, global::android.opengl.GLES11._m69);
			Init(@__env, handle);
		}
		public static int GL_ACTIVE_TEXTURE
		{
			get
			{
				return 34016;
			}
		}
		public static int GL_ADD_SIGNED
		{
			get
			{
				return 34164;
			}
		}
		public static int GL_ALPHA_SCALE
		{
			get
			{
				return 3356;
			}
		}
		public static int GL_ALPHA_TEST_FUNC
		{
			get
			{
				return 3009;
			}
		}
		public static int GL_ALPHA_TEST_REF
		{
			get
			{
				return 3010;
			}
		}
		public static int GL_ARRAY_BUFFER
		{
			get
			{
				return 34962;
			}
		}
		public static int GL_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34964;
			}
		}
		public static int GL_BLEND_DST
		{
			get
			{
				return 3040;
			}
		}
		public static int GL_BLEND_SRC
		{
			get
			{
				return 3041;
			}
		}
		public static int GL_BUFFER_ACCESS
		{
			get
			{
				return 35003;
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
		public static int GL_CLIENT_ACTIVE_TEXTURE
		{
			get
			{
				return 34017;
			}
		}
		public static int GL_CLIP_PLANE0
		{
			get
			{
				return 12288;
			}
		}
		public static int GL_CLIP_PLANE1
		{
			get
			{
				return 12289;
			}
		}
		public static int GL_CLIP_PLANE2
		{
			get
			{
				return 12290;
			}
		}
		public static int GL_CLIP_PLANE3
		{
			get
			{
				return 12291;
			}
		}
		public static int GL_CLIP_PLANE4
		{
			get
			{
				return 12292;
			}
		}
		public static int GL_CLIP_PLANE5
		{
			get
			{
				return 12293;
			}
		}
		public static int GL_COLOR_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34968;
			}
		}
		public static int GL_COLOR_ARRAY_POINTER
		{
			get
			{
				return 32912;
			}
		}
		public static int GL_COLOR_ARRAY_SIZE
		{
			get
			{
				return 32897;
			}
		}
		public static int GL_COLOR_ARRAY_STRIDE
		{
			get
			{
				return 32899;
			}
		}
		public static int GL_COLOR_ARRAY_TYPE
		{
			get
			{
				return 32898;
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
		public static int GL_COMBINE
		{
			get
			{
				return 34160;
			}
		}
		public static int GL_COMBINE_ALPHA
		{
			get
			{
				return 34162;
			}
		}
		public static int GL_COMBINE_RGB
		{
			get
			{
				return 34161;
			}
		}
		public static int GL_CONSTANT
		{
			get
			{
				return 34166;
			}
		}
		public static int GL_COORD_REPLACE_OES
		{
			get
			{
				return 34914;
			}
		}
		public static int GL_CULL_FACE_MODE
		{
			get
			{
				return 2885;
			}
		}
		public static int GL_CURRENT_COLOR
		{
			get
			{
				return 2816;
			}
		}
		public static int GL_CURRENT_NORMAL
		{
			get
			{
				return 2818;
			}
		}
		public static int GL_CURRENT_TEXTURE_COORDS
		{
			get
			{
				return 2819;
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
		public static int GL_DOT3_RGB
		{
			get
			{
				return 34478;
			}
		}
		public static int GL_DOT3_RGBA
		{
			get
			{
				return 34479;
			}
		}
		public static int GL_DYNAMIC_DRAW
		{
			get
			{
				return 35048;
			}
		}
		public static int GL_ELEMENT_ARRAY_BUFFER
		{
			get
			{
				return 34963;
			}
		}
		public static int GL_ELEMENT_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34965;
			}
		}
		public static int GL_FRONT_FACE
		{
			get
			{
				return 2886;
			}
		}
		public static int GL_GENERATE_MIPMAP
		{
			get
			{
				return 33169;
			}
		}
		public static int GL_GENERATE_MIPMAP_HINT
		{
			get
			{
				return 33170;
			}
		}
		public static int GL_INTERPOLATE
		{
			get
			{
				return 34165;
			}
		}
		public static int GL_LINE_WIDTH
		{
			get
			{
				return 2849;
			}
		}
		public static int GL_LOGIC_OP_MODE
		{
			get
			{
				return 3056;
			}
		}
		public static int GL_MATRIX_MODE
		{
			get
			{
				return 2976;
			}
		}
		public static int GL_MAX_CLIP_PLANES
		{
			get
			{
				return 3378;
			}
		}
		public static int GL_MODELVIEW_MATRIX
		{
			get
			{
				return 2982;
			}
		}
		public static int GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES
		{
			get
			{
				return 35213;
			}
		}
		public static int GL_MODELVIEW_STACK_DEPTH
		{
			get
			{
				return 2979;
			}
		}
		public static int GL_NORMAL_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34967;
			}
		}
		public static int GL_NORMAL_ARRAY_POINTER
		{
			get
			{
				return 32911;
			}
		}
		public static int GL_NORMAL_ARRAY_STRIDE
		{
			get
			{
				return 32895;
			}
		}
		public static int GL_NORMAL_ARRAY_TYPE
		{
			get
			{
				return 32894;
			}
		}
		public static int GL_OPERAND0_ALPHA
		{
			get
			{
				return 34200;
			}
		}
		public static int GL_OPERAND0_RGB
		{
			get
			{
				return 34192;
			}
		}
		public static int GL_OPERAND1_ALPHA
		{
			get
			{
				return 34201;
			}
		}
		public static int GL_OPERAND1_RGB
		{
			get
			{
				return 34193;
			}
		}
		public static int GL_OPERAND2_ALPHA
		{
			get
			{
				return 34202;
			}
		}
		public static int GL_OPERAND2_RGB
		{
			get
			{
				return 34194;
			}
		}
		public static int GL_POINT_DISTANCE_ATTENUATION
		{
			get
			{
				return 33065;
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
		public static int GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES
		{
			get
			{
				return 35743;
			}
		}
		public static int GL_POINT_SIZE_ARRAY_OES
		{
			get
			{
				return 35740;
			}
		}
		public static int GL_POINT_SIZE_ARRAY_POINTER_OES
		{
			get
			{
				return 35212;
			}
		}
		public static int GL_POINT_SIZE_ARRAY_STRIDE_OES
		{
			get
			{
				return 35211;
			}
		}
		public static int GL_POINT_SIZE_ARRAY_TYPE_OES
		{
			get
			{
				return 35210;
			}
		}
		public static int GL_POINT_SIZE_MAX
		{
			get
			{
				return 33063;
			}
		}
		public static int GL_POINT_SIZE_MIN
		{
			get
			{
				return 33062;
			}
		}
		public static int GL_POINT_SPRITE_OES
		{
			get
			{
				return 34913;
			}
		}
		public static int GL_POLYGON_OFFSET_FACTOR
		{
			get
			{
				return 32824;
			}
		}
		public static int GL_POLYGON_OFFSET_UNITS
		{
			get
			{
				return 10752;
			}
		}
		public static int GL_PREVIOUS
		{
			get
			{
				return 34168;
			}
		}
		public static int GL_PRIMARY_COLOR
		{
			get
			{
				return 34167;
			}
		}
		public static int GL_PROJECTION_MATRIX
		{
			get
			{
				return 2983;
			}
		}
		public static int GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES
		{
			get
			{
				return 35214;
			}
		}
		public static int GL_PROJECTION_STACK_DEPTH
		{
			get
			{
				return 2980;
			}
		}
		public static int GL_RGB_SCALE
		{
			get
			{
				return 34163;
			}
		}
		public static int GL_SAMPLE_BUFFERS
		{
			get
			{
				return 32936;
			}
		}
		public static int GL_SAMPLE_COVERAGE_INVERT
		{
			get
			{
				return 32939;
			}
		}
		public static int GL_SAMPLE_COVERAGE_VALUE
		{
			get
			{
				return 32938;
			}
		}
		public static int GL_SAMPLES
		{
			get
			{
				return 32937;
			}
		}
		public static int GL_SCISSOR_BOX
		{
			get
			{
				return 3088;
			}
		}
		public static int GL_SHADE_MODEL
		{
			get
			{
				return 2900;
			}
		}
		public static int GL_SRC0_ALPHA
		{
			get
			{
				return 34184;
			}
		}
		public static int GL_SRC0_RGB
		{
			get
			{
				return 34176;
			}
		}
		public static int GL_SRC1_ALPHA
		{
			get
			{
				return 34185;
			}
		}
		public static int GL_SRC1_RGB
		{
			get
			{
				return 34177;
			}
		}
		public static int GL_SRC2_ALPHA
		{
			get
			{
				return 34186;
			}
		}
		public static int GL_SRC2_RGB
		{
			get
			{
				return 34178;
			}
		}
		public static int GL_STATIC_DRAW
		{
			get
			{
				return 35044;
			}
		}
		public static int GL_STENCIL_CLEAR_VALUE
		{
			get
			{
				return 2961;
			}
		}
		public static int GL_STENCIL_FAIL
		{
			get
			{
				return 2964;
			}
		}
		public static int GL_STENCIL_FUNC
		{
			get
			{
				return 2962;
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
		public static int GL_SUBTRACT
		{
			get
			{
				return 34023;
			}
		}
		public static int GL_TEXTURE_BINDING_2D
		{
			get
			{
				return 32873;
			}
		}
		public static int GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34970;
			}
		}
		public static int GL_TEXTURE_COORD_ARRAY_POINTER
		{
			get
			{
				return 32914;
			}
		}
		public static int GL_TEXTURE_COORD_ARRAY_SIZE
		{
			get
			{
				return 32904;
			}
		}
		public static int GL_TEXTURE_COORD_ARRAY_STRIDE
		{
			get
			{
				return 32906;
			}
		}
		public static int GL_TEXTURE_COORD_ARRAY_TYPE
		{
			get
			{
				return 32905;
			}
		}
		public static int GL_TEXTURE_MATRIX
		{
			get
			{
				return 2984;
			}
		}
		public static int GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES
		{
			get
			{
				return 35215;
			}
		}
		public static int GL_TEXTURE_STACK_DEPTH
		{
			get
			{
				return 2981;
			}
		}
		public static int GL_VERTEX_ARRAY_BUFFER_BINDING
		{
			get
			{
				return 34966;
			}
		}
		public static int GL_VERTEX_ARRAY_POINTER
		{
			get
			{
				return 32910;
			}
		}
		public static int GL_VERTEX_ARRAY_SIZE
		{
			get
			{
				return 32890;
			}
		}
		public static int GL_VERTEX_ARRAY_STRIDE
		{
			get
			{
				return 32892;
			}
		}
		public static int GL_VERTEX_ARRAY_TYPE
		{
			get
			{
				return 32891;
			}
		}
		public static int GL_VIEWPORT
		{
			get
			{
				return 2978;
			}
		}
		public static int GL_WRITE_ONLY
		{
			get
			{
				return 35001;
			}
		}
		static GLES11()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLES11.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLES11"));
		}
		internal static void InitJNI()
		{
		}
	}
}
