namespace javax.microedition.khronos.opengles
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.microedition.khronos.opengles.GL11ExtensionPack_))]
	public partial interface GL11ExtensionPack : GL
	{
		void glBindTexture(int arg0, int arg1);
		void glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7);
		void glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7);
		void glEnable(int arg0);
		void glGetIntegerv(int arg0, int[] arg1, int arg2);
		void glGetIntegerv(int arg0, java.nio.IntBuffer arg1);
		void glStencilOp(int arg0, int arg1, int arg2);
		void glTexEnvf(int arg0, int arg1, float arg2);
		void glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3);
		void glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2);
		void glTexEnvx(int arg0, int arg1, int arg2);
		void glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3);
		void glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glTexParameterf(int arg0, int arg1, float arg2);
		bool glIsRenderbufferOES(int arg0);
		void glBindRenderbufferOES(int arg0, int arg1);
		void glDeleteRenderbuffersOES(int arg0, int[] arg1, int arg2);
		void glDeleteRenderbuffersOES(int arg0, java.nio.IntBuffer arg1);
		void glGenRenderbuffersOES(int arg0, int[] arg1, int arg2);
		void glGenRenderbuffersOES(int arg0, java.nio.IntBuffer arg1);
		void glRenderbufferStorageOES(int arg0, int arg1, int arg2, int arg3);
		void glGetRenderbufferParameterivOES(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glGetRenderbufferParameterivOES(int arg0, int arg1, int[] arg2, int arg3);
		bool glIsFramebufferOES(int arg0);
		void glBindFramebufferOES(int arg0, int arg1);
		void glDeleteFramebuffersOES(int arg0, int[] arg1, int arg2);
		void glDeleteFramebuffersOES(int arg0, java.nio.IntBuffer arg1);
		void glGenFramebuffersOES(int arg0, java.nio.IntBuffer arg1);
		void glGenFramebuffersOES(int arg0, int[] arg1, int arg2);
		int glCheckFramebufferStatusOES(int arg0);
		void glFramebufferRenderbufferOES(int arg0, int arg1, int arg2, int arg3);
		void glFramebufferTexture2DOES(int arg0, int arg1, int arg2, int arg3, int arg4);
		void glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3);
		void glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, int[] arg3, int arg4);
		void glGenerateMipmapOES(int arg0);
		void glBlendEquation(int arg0);
		void glBlendEquationSeparate(int arg0, int arg1);
		void glBlendFuncSeparate(int arg0, int arg1, int arg2, int arg3);
		void glGetTexGenfv(int arg0, int arg1, java.nio.FloatBuffer arg2);
		void glGetTexGenfv(int arg0, int arg1, float[] arg2, int arg3);
		void glGetTexGeniv(int arg0, int arg1, int[] arg2, int arg3);
		void glGetTexGeniv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glGetTexGenxv(int arg0, int arg1, int[] arg2, int arg3);
		void glGetTexGenxv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glTexGenf(int arg0, int arg1, float arg2);
		void glTexGenfv(int arg0, int arg1, java.nio.FloatBuffer arg2);
		void glTexGenfv(int arg0, int arg1, float[] arg2, int arg3);
		void glTexGeni(int arg0, int arg1, int arg2);
		void glTexGeniv(int arg0, int arg1, int[] arg2, int arg3);
		void glTexGeniv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glTexGenx(int arg0, int arg1, int arg2);
		void glTexGenxv(int arg0, int arg1, int[] arg2, int arg3);
		void glTexGenxv(int arg0, int arg1, java.nio.IntBuffer arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.opengles.GL11ExtensionPack))]
	internal sealed partial class GL11ExtensionPack_ : java.lang.Object, GL11ExtensionPack
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GL11ExtensionPack_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glBindTexture(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBindTexture", "(II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glCopyTexImage2D", "(IIIIIIII)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glEnable(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glEnable", "(I)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetIntegerv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetIntegerv", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetIntegerv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glStencilOp(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glStencilOp", "(III)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvf", "(IIF)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvx", "(III)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexParameterf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexParameterf", "(IIF)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		bool javax.microedition.khronos.opengles.GL11ExtensionPack.glIsRenderbufferOES(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glIsRenderbufferOES", "(I)Z", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glBindRenderbufferOES(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBindRenderbufferOES", "(II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteRenderbuffersOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteRenderbuffersOES", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteRenderbuffersOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteRenderbuffersOES", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenRenderbuffersOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenRenderbuffersOES", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenRenderbuffersOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenRenderbuffersOES", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glRenderbufferStorageOES(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glRenderbufferStorageOES", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetRenderbufferParameterivOES(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetRenderbufferParameterivOES", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetRenderbufferParameterivOES(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetRenderbufferParameterivOES", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		bool javax.microedition.khronos.opengles.GL11ExtensionPack.glIsFramebufferOES(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glIsFramebufferOES", "(I)Z", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glBindFramebufferOES(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBindFramebufferOES", "(II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteFramebuffersOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteFramebuffersOES", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteFramebuffersOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteFramebuffersOES", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenFramebuffersOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenFramebuffersOES", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenFramebuffersOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenFramebuffersOES", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		int javax.microedition.khronos.opengles.GL11ExtensionPack.glCheckFramebufferStatusOES(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glCheckFramebufferStatusOES", "(I)I", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glFramebufferRenderbufferOES(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glFramebufferRenderbufferOES", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glFramebufferTexture2DOES(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glFramebufferTexture2DOES", "(IIIII)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetFramebufferAttachmentParameterivOES", "(IIILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, int[] arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetFramebufferAttachmentParameterivOES", "(III[II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenerateMipmapOES(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenerateMipmapOES", "(I)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glBlendEquation(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBlendEquation", "(I)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glBlendEquationSeparate(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBlendEquationSeparate", "(II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glBlendFuncSeparate(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBlendFuncSeparate", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGeniv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGeniv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGeniv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGeniv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenf", "(IIF)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGeni(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGeni", "(III)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGeniv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGeniv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGeniv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGeniv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenx", "(III)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL11ExtensionPack_._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static GL11ExtensionPack_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/opengles/GL11ExtensionPack"));
		}
		internal static void InitJNI()
		{
		}
	}
}
