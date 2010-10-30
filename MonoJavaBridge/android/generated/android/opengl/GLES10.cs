namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLES10 : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GLES10(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _glActiveTexture8150;
		public static void glActiveTexture(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glActiveTexture8150.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glActiveTexture8150 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glActiveTexture", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glActiveTexture8150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFunc8151;
		public static void glAlphaFunc(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glAlphaFunc8151.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glAlphaFunc8151 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glAlphaFunc", "(IF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glAlphaFunc8151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFuncx8152;
		public static void glAlphaFuncx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glAlphaFuncx8152.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glAlphaFuncx8152 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glAlphaFuncx", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glAlphaFuncx8152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBindTexture8153;
		public static void glBindTexture(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glBindTexture8153.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glBindTexture8153 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glBindTexture", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glBindTexture8153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendFunc8154;
		public static void glBlendFunc(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glBlendFunc8154.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glBlendFunc8154 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glBlendFunc", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glBlendFunc8154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClear8155;
		public static void glClear(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glClear8155.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glClear8155 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClear", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glClear8155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColor8156;
		public static void glClearColor(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glClearColor8156.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glClearColor8156 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClearColor", "(FFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glClearColor8156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColorx8157;
		public static void glClearColorx(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glClearColorx8157.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glClearColorx8157 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClearColorx", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glClearColorx8157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthf8158;
		public static void glClearDepthf(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glClearDepthf8158.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glClearDepthf8158 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClearDepthf", "(F)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glClearDepthf8158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthx8159;
		public static void glClearDepthx(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glClearDepthx8159.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glClearDepthx8159 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClearDepthx", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glClearDepthx8159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearStencil8160;
		public static void glClearStencil(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glClearStencil8160.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glClearStencil8160 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClearStencil", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glClearStencil8160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClientActiveTexture8161;
		public static void glClientActiveTexture(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glClientActiveTexture8161.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glClientActiveTexture8161 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glClientActiveTexture", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glClientActiveTexture8161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4f8162;
		public static void glColor4f(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glColor4f8162.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glColor4f8162 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glColor4f", "(FFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glColor4f8162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4x8163;
		public static void glColor4x(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glColor4x8163.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glColor4x8163 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glColor4x", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glColor4x8163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColorMask8164;
		public static void glColorMask(bool arg0, bool arg1, bool arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glColorMask8164.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glColorMask8164 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glColorMask", "(ZZZZ)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glColorMask8164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColorPointer8165;
		public static void glColorPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glColorPointer8165.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glColorPointer8165 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glColorPointer", "(IIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glColorPointer8165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexImage2D8166;
		public static void glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glCompressedTexImage2D8166.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glCompressedTexImage2D8166 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glCompressedTexImage2D8166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexSubImage2D8167;
		public static void glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glCompressedTexSubImage2D8167.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glCompressedTexSubImage2D8167 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glCompressedTexSubImage2D8167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexImage2D8168;
		public static void glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glCopyTexImage2D8168.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glCopyTexImage2D8168 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glCopyTexImage2D", "(IIIIIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glCopyTexImage2D8168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexSubImage2D8169;
		public static void glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glCopyTexSubImage2D8169.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glCopyTexSubImage2D8169 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glCopyTexSubImage2D", "(IIIIIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glCopyTexSubImage2D8169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCullFace8170;
		public static void glCullFace(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glCullFace8170.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glCullFace8170 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glCullFace", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glCullFace8170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures8171;
		public static void glDeleteTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glDeleteTextures8171.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glDeleteTextures8171 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDeleteTextures", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDeleteTextures8171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures8172;
		public static void glDeleteTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glDeleteTextures8172.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glDeleteTextures8172 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDeleteTextures", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDeleteTextures8172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthFunc8173;
		public static void glDepthFunc(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glDepthFunc8173.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glDepthFunc8173 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDepthFunc", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDepthFunc8173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthMask8174;
		public static void glDepthMask(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glDepthMask8174.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glDepthMask8174 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDepthMask", "(Z)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDepthMask8174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangef8175;
		public static void glDepthRangef(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glDepthRangef8175.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glDepthRangef8175 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDepthRangef", "(FF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDepthRangef8175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangex8176;
		public static void glDepthRangex(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glDepthRangex8176.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glDepthRangex8176 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDepthRangex", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDepthRangex8176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDisable8177;
		public static void glDisable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glDisable8177.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glDisable8177 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDisable", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDisable8177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDisableClientState8178;
		public static void glDisableClientState(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glDisableClientState8178.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glDisableClientState8178 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDisableClientState", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDisableClientState8178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawArrays8179;
		public static void glDrawArrays(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glDrawArrays8179.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glDrawArrays8179 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDrawArrays", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDrawArrays8179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawElements8180;
		public static void glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glDrawElements8180.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glDrawElements8180 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glDrawElements", "(IIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glDrawElements8180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glEnable8181;
		public static void glEnable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glEnable8181.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glEnable8181 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glEnable", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glEnable8181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glEnableClientState8182;
		public static void glEnableClientState(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glEnableClientState8182.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glEnableClientState8182 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glEnableClientState", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glEnableClientState8182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFinish8183;
		public static void glFinish()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glFinish8183.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glFinish8183 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFinish", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFinish8183);
		}
		internal static global::MonoJavaBridge.MethodId _glFlush8184;
		public static void glFlush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glFlush8184.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glFlush8184 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFlush", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFlush8184);
		}
		internal static global::MonoJavaBridge.MethodId _glFogf8185;
		public static void glFogf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glFogf8185.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glFogf8185 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogf", "(IF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFogf8185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogfv8186;
		public static void glFogfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glFogfv8186.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glFogfv8186 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogfv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFogfv8186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogfv8187;
		public static void glFogfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glFogfv8187.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glFogfv8187 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogfv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFogfv8187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogx8188;
		public static void glFogx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glFogx8188.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glFogx8188 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogx", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFogx8188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxv8189;
		public static void glFogxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glFogxv8189.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glFogxv8189 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogxv", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFogxv8189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxv8190;
		public static void glFogxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glFogxv8190.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glFogxv8190 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFogxv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFogxv8190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFrontFace8191;
		public static void glFrontFace(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glFrontFace8191.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glFrontFace8191 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFrontFace", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFrontFace8191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumf8192;
		public static void glFrustumf(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glFrustumf8192.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glFrustumf8192 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFrustumf", "(FFFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFrustumf8192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumx8193;
		public static void glFrustumx(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glFrustumx8193.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glFrustumx8193 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glFrustumx", "(IIIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glFrustumx8193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures8194;
		public static void glGenTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glGenTextures8194.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glGenTextures8194 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGenTextures", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glGenTextures8194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures8195;
		public static void glGenTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glGenTextures8195.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glGenTextures8195 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGenTextures", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glGenTextures8195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetError8196;
		public static int glGetError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glGetError8196.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glGetError8196 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGetError", "()I");
			return @__env.CallStaticIntMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glGetError8196);
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv8197;
		public static void glGetIntegerv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glGetIntegerv8197.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glGetIntegerv8197 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGetIntegerv", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glGetIntegerv8197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv8198;
		public static void glGetIntegerv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glGetIntegerv8198.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glGetIntegerv8198 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glGetIntegerv8198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetString8199;
		public static global::java.lang.String glGetString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glGetString8199.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glGetString8199 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glGetString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glGetString8199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _glHint8200;
		public static void glHint(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glHint8200.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glHint8200 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glHint", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glHint8200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelf8201;
		public static void glLightModelf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLightModelf8201.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLightModelf8201 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelf", "(IF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightModelf8201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelfv8202;
		public static void glLightModelfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLightModelfv8202.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLightModelfv8202 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelfv", "(I[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightModelfv8202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelfv8203;
		public static void glLightModelfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLightModelfv8203.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLightModelfv8203 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelfv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightModelfv8203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelx8204;
		public static void glLightModelx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLightModelx8204.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLightModelx8204 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelx", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightModelx8204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxv8205;
		public static void glLightModelxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLightModelxv8205.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLightModelxv8205 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelxv", "(I[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightModelxv8205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxv8206;
		public static void glLightModelxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLightModelxv8206.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLightModelxv8206 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightModelxv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightModelxv8206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightf8207;
		public static void glLightf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLightf8207.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLightf8207 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightf", "(IIF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightf8207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightfv8208;
		public static void glLightfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLightfv8208.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLightfv8208 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightfv8208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightfv8209;
		public static void glLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLightfv8209.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLightfv8209 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightfv8209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightx8210;
		public static void glLightx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLightx8210.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLightx8210 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightx", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightx8210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxv8211;
		public static void glLightxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLightxv8211.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLightxv8211 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightxv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightxv8211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxv8212;
		public static void glLightxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLightxv8212.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLightxv8212 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLightxv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLightxv8212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidth8213;
		public static void glLineWidth(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLineWidth8213.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLineWidth8213 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLineWidth", "(F)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLineWidth8213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidthx8214;
		public static void glLineWidthx(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLineWidthx8214.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLineWidthx8214 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLineWidthx", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLineWidthx8214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadIdentity8215;
		public static void glLoadIdentity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLoadIdentity8215.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLoadIdentity8215 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLoadIdentity", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLoadIdentity8215);
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixf8216;
		public static void glLoadMatrixf(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLoadMatrixf8216.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLoadMatrixf8216 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLoadMatrixf", "([FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLoadMatrixf8216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixf8217;
		public static void glLoadMatrixf(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLoadMatrixf8217.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLoadMatrixf8217 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLoadMatrixf8217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixx8218;
		public static void glLoadMatrixx(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLoadMatrixx8218.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLoadMatrixx8218 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLoadMatrixx", "([II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLoadMatrixx8218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixx8219;
		public static void glLoadMatrixx(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLoadMatrixx8219.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLoadMatrixx8219 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLoadMatrixx", "(Ljava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLoadMatrixx8219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLogicOp8220;
		public static void glLogicOp(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glLogicOp8220.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glLogicOp8220 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glLogicOp", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glLogicOp8220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialf8221;
		public static void glMaterialf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glMaterialf8221.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glMaterialf8221 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialf", "(IIF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMaterialf8221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialfv8222;
		public static void glMaterialfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glMaterialfv8222.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glMaterialfv8222 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMaterialfv8222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialfv8223;
		public static void glMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glMaterialfv8223.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glMaterialfv8223 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMaterialfv8223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialx8224;
		public static void glMaterialx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glMaterialx8224.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glMaterialx8224 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialx", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMaterialx8224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxv8225;
		public static void glMaterialxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glMaterialxv8225.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glMaterialxv8225 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialxv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMaterialxv8225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxv8226;
		public static void glMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glMaterialxv8226.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glMaterialxv8226 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMaterialxv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMaterialxv8226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMatrixMode8227;
		public static void glMatrixMode(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glMatrixMode8227.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glMatrixMode8227 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMatrixMode", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMatrixMode8227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixf8228;
		public static void glMultMatrixf(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glMultMatrixf8228.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glMultMatrixf8228 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultMatrixf", "([FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMultMatrixf8228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixf8229;
		public static void glMultMatrixf(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glMultMatrixf8229.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glMultMatrixf8229 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultMatrixf", "(Ljava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMultMatrixf8229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixx8230;
		public static void glMultMatrixx(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glMultMatrixx8230.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glMultMatrixx8230 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultMatrixx", "([II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMultMatrixx8230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixx8231;
		public static void glMultMatrixx(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glMultMatrixx8231.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glMultMatrixx8231 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultMatrixx", "(Ljava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMultMatrixx8231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4f8232;
		public static void glMultiTexCoord4f(int arg0, float arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glMultiTexCoord4f8232.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glMultiTexCoord4f8232 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultiTexCoord4f", "(IFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMultiTexCoord4f8232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4x8233;
		public static void glMultiTexCoord4x(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glMultiTexCoord4x8233.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glMultiTexCoord4x8233 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glMultiTexCoord4x", "(IIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glMultiTexCoord4x8233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3f8234;
		public static void glNormal3f(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glNormal3f8234.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glNormal3f8234 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glNormal3f", "(FFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glNormal3f8234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3x8235;
		public static void glNormal3x(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glNormal3x8235.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glNormal3x8235 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glNormal3x", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glNormal3x8235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glNormalPointer8236;
		public static void glNormalPointer(int arg0, int arg1, java.nio.Buffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glNormalPointer8236.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glNormalPointer8236 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glNormalPointer", "(IILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glNormalPointer8236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthof8237;
		public static void glOrthof(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glOrthof8237.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glOrthof8237 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glOrthof", "(FFFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glOrthof8237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthox8238;
		public static void glOrthox(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glOrthox8238.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glOrthox8238 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glOrthox", "(IIIIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glOrthox8238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glPixelStorei8239;
		public static void glPixelStorei(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glPixelStorei8239.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glPixelStorei8239 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPixelStorei", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glPixelStorei8239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSize8240;
		public static void glPointSize(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glPointSize8240.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glPointSize8240 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPointSize", "(F)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glPointSize8240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSizex8241;
		public static void glPointSizex(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glPointSizex8241.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glPointSizex8241 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPointSizex", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glPointSizex8241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffset8242;
		public static void glPolygonOffset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glPolygonOffset8242.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glPolygonOffset8242 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPolygonOffset", "(FF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glPolygonOffset8242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffsetx8243;
		public static void glPolygonOffsetx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glPolygonOffsetx8243.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glPolygonOffsetx8243 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPolygonOffsetx", "(II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glPolygonOffsetx8243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPopMatrix8244;
		public static void glPopMatrix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glPopMatrix8244.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glPopMatrix8244 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPopMatrix", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glPopMatrix8244);
		}
		internal static global::MonoJavaBridge.MethodId _glPushMatrix8245;
		public static void glPushMatrix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glPushMatrix8245.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glPushMatrix8245 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glPushMatrix", "()V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glPushMatrix8245);
		}
		internal static global::MonoJavaBridge.MethodId _glReadPixels8246;
		public static void glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glReadPixels8246.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glReadPixels8246 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glReadPixels", "(IIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glReadPixels8246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatef8247;
		public static void glRotatef(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glRotatef8247.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glRotatef8247 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glRotatef", "(FFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glRotatef8247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatex8248;
		public static void glRotatex(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glRotatex8248.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glRotatex8248 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glRotatex", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glRotatex8248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoverage8249;
		public static void glSampleCoverage(float arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glSampleCoverage8249.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glSampleCoverage8249 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glSampleCoverage", "(FZ)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glSampleCoverage8249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoveragex8250;
		public static void glSampleCoveragex(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glSampleCoveragex8250.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glSampleCoveragex8250 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glSampleCoveragex", "(IZ)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glSampleCoveragex8250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glScalef8251;
		public static void glScalef(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glScalef8251.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glScalef8251 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glScalef", "(FFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glScalef8251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glScalex8252;
		public static void glScalex(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glScalex8252.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glScalex8252 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glScalex", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glScalex8252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glScissor8253;
		public static void glScissor(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glScissor8253.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glScissor8253 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glScissor", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glScissor8253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glShadeModel8254;
		public static void glShadeModel(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glShadeModel8254.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glShadeModel8254 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glShadeModel", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glShadeModel8254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilFunc8255;
		public static void glStencilFunc(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glStencilFunc8255.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glStencilFunc8255 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glStencilFunc", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glStencilFunc8255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilMask8256;
		public static void glStencilMask(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glStencilMask8256.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glStencilMask8256 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glStencilMask", "(I)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glStencilMask8256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilOp8257;
		public static void glStencilOp(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glStencilOp8257.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glStencilOp8257 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glStencilOp", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glStencilOp8257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexCoordPointer8258;
		public static void glTexCoordPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glTexCoordPointer8258.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glTexCoordPointer8258 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexCoordPointer", "(IIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexCoordPointer8258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvf8259;
		public static void glTexEnvf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glTexEnvf8259.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glTexEnvf8259 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvf", "(IIF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexEnvf8259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv8260;
		public static void glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glTexEnvfv8260.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glTexEnvfv8260 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvfv", "(II[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexEnvfv8260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv8261;
		public static void glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glTexEnvfv8261.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glTexEnvfv8261 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexEnvfv8261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvx8262;
		public static void glTexEnvx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glTexEnvx8262.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glTexEnvx8262 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvx", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexEnvx8262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv8263;
		public static void glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glTexEnvxv8263.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glTexEnvxv8263 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvxv", "(II[II)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexEnvxv8263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv8264;
		public static void glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glTexEnvxv8264.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glTexEnvxv8264 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexEnvxv8264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexImage2D8265;
		public static void glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glTexImage2D8265.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glTexImage2D8265 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexImage2D8265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterf8266;
		public static void glTexParameterf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glTexParameterf8266.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glTexParameterf8266 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexParameterf", "(IIF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexParameterf8266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterx8267;
		public static void glTexParameterx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glTexParameterx8267.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glTexParameterx8267 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexParameterx", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexParameterx8267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexSubImage2D8268;
		public static void glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glTexSubImage2D8268.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glTexSubImage2D8268 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTexSubImage2D8268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatef8269;
		public static void glTranslatef(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glTranslatef8269.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glTranslatef8269 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTranslatef", "(FFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTranslatef8269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatex8270;
		public static void glTranslatex(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glTranslatex8270.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glTranslatex8270 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glTranslatex", "(III)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glTranslatex8270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexPointer8271;
		public static void glVertexPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glVertexPointer8271.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glVertexPointer8271 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glVertexPointer", "(IIILjava/nio/Buffer;)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glVertexPointer8271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glViewport8272;
		public static void glViewport(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._glViewport8272.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._glViewport8272 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "glViewport", "(IIII)V");
			@__env.CallStaticVoidMethod(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._glViewport8272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _GLES108273;
		public GLES10() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLES10._GLES108273.native == global::System.IntPtr.Zero)
				global::android.opengl.GLES10._GLES108273 = @__env.GetMethodIDNoThrow(global::android.opengl.GLES10.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLES10.staticClass, global::android.opengl.GLES10._GLES108273);
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
