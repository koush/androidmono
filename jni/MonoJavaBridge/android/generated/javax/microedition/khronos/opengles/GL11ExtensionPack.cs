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
		static GL11ExtensionPack_()
		{
			InitJNI();
		}
		internal GL11ExtensionPack_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _glBindTexture29669;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glBindTexture(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindTexture29669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindTexture29669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexImage2D29670;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCompressedTexImage2D29670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCompressedTexImage2D29670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexImage2D29671;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCopyTexImage2D29671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCopyTexImage2D29671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glEnable29672;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glEnable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glEnable29672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glEnable29672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv29673;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetIntegerv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv29673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv29673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv29674;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetIntegerv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv29674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv29674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilOp29675;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glStencilOp(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glStencilOp29675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glStencilOp29675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvf29676;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvf29676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvf29676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv29677;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv29677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv29677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv29678;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv29678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv29678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvx29679;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvx29679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvx29679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv29680;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv29680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv29680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv29681;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv29681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv29681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterf29682;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexParameterf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexParameterf29682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexParameterf29682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glIsRenderbufferOES29683;
		bool javax.microedition.khronos.opengles.GL11ExtensionPack.glIsRenderbufferOES(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsRenderbufferOES29683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsRenderbufferOES29683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBindRenderbufferOES29684;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glBindRenderbufferOES(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindRenderbufferOES29684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindRenderbufferOES29684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteRenderbuffersOES29685;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteRenderbuffersOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES29685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES29685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteRenderbuffersOES29686;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteRenderbuffersOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES29686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES29686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenRenderbuffersOES29687;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenRenderbuffersOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES29687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES29687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenRenderbuffersOES29688;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenRenderbuffersOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES29688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES29688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glRenderbufferStorageOES29689;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glRenderbufferStorageOES(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glRenderbufferStorageOES29689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glRenderbufferStorageOES29689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetRenderbufferParameterivOES29690;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetRenderbufferParameterivOES(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES29690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES29690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetRenderbufferParameterivOES29691;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetRenderbufferParameterivOES(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES29691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES29691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glIsFramebufferOES29692;
		bool javax.microedition.khronos.opengles.GL11ExtensionPack.glIsFramebufferOES(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsFramebufferOES29692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsFramebufferOES29692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBindFramebufferOES29693;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glBindFramebufferOES(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindFramebufferOES29693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindFramebufferOES29693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteFramebuffersOES29694;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteFramebuffersOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES29694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES29694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteFramebuffersOES29695;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteFramebuffersOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES29695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES29695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenFramebuffersOES29696;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenFramebuffersOES(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES29696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES29696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenFramebuffersOES29697;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenFramebuffersOES(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES29697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES29697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glCheckFramebufferStatusOES29698;
		int javax.microedition.khronos.opengles.GL11ExtensionPack.glCheckFramebufferStatusOES(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCheckFramebufferStatusOES29698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCheckFramebufferStatusOES29698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFramebufferRenderbufferOES29699;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glFramebufferRenderbufferOES(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferRenderbufferOES29699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferRenderbufferOES29699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glFramebufferTexture2DOES29700;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glFramebufferTexture2DOES(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferTexture2DOES29700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferTexture2DOES29700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFramebufferAttachmentParameterivOES29701;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES29701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES29701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFramebufferAttachmentParameterivOES29702;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, int[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES29702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES29702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glGenerateMipmapOES29703;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenerateMipmapOES(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenerateMipmapOES29703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenerateMipmapOES29703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendEquation29704;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glBlendEquation(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquation29704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquation29704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendEquationSeparate29705;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glBlendEquationSeparate(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquationSeparate29705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquationSeparate29705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendFuncSeparate29706;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glBlendFuncSeparate(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendFuncSeparate29706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendFuncSeparate29706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenfv29707;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv29707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv29707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenfv29708;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv29708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv29708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGeniv29709;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGeniv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv29709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv29709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGeniv29710;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGeniv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv29710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv29710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenxv29711;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv29711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv29711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenxv29712;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv29712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv29712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenf29713;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenf29713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenf29713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenfv29714;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv29714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv29714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenfv29715;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv29715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv29715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGeni29716;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGeni(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeni29716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeni29716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGeniv29717;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGeniv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv29717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv29717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGeniv29718;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGeniv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv29718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv29718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenx29719;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenx29719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenx29719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenxv29720;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv29720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv29720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenxv29721;
		void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv29721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv29721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/opengles/GL11ExtensionPack"));
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindTexture29669 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBindTexture", "(II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCompressedTexImage2D29670 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCopyTexImage2D29671 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glCopyTexImage2D", "(IIIIIIII)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glEnable29672 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glEnable", "(I)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv29673 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetIntegerv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv29674 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glStencilOp29675 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glStencilOp", "(III)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvf29676 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv29677 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv29678 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvx29679 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvx", "(III)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv29680 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv29681 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexParameterf29682 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexParameterf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsRenderbufferOES29683 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glIsRenderbufferOES", "(I)Z");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindRenderbufferOES29684 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBindRenderbufferOES", "(II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES29685 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteRenderbuffersOES", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES29686 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteRenderbuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES29687 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenRenderbuffersOES", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES29688 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenRenderbuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glRenderbufferStorageOES29689 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glRenderbufferStorageOES", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES29690 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetRenderbufferParameterivOES", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES29691 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetRenderbufferParameterivOES", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsFramebufferOES29692 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glIsFramebufferOES", "(I)Z");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindFramebufferOES29693 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBindFramebufferOES", "(II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES29694 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteFramebuffersOES", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES29695 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteFramebuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES29696 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenFramebuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES29697 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenFramebuffersOES", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCheckFramebufferStatusOES29698 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glCheckFramebufferStatusOES", "(I)I");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferRenderbufferOES29699 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glFramebufferRenderbufferOES", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferTexture2DOES29700 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glFramebufferTexture2DOES", "(IIIII)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES29701 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetFramebufferAttachmentParameterivOES", "(IIILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES29702 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetFramebufferAttachmentParameterivOES", "(III[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenerateMipmapOES29703 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenerateMipmapOES", "(I)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquation29704 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBlendEquation", "(I)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquationSeparate29705 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBlendEquationSeparate", "(II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendFuncSeparate29706 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBlendFuncSeparate", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv29707 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv29708 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv29709 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGeniv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv29710 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGeniv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv29711 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv29712 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenf29713 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv29714 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv29715 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeni29716 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGeni", "(III)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv29717 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGeniv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv29718 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGeniv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenx29719 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenx", "(III)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv29720 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv29721 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenxv", "(IILjava/nio/IntBuffer;)V");
		}
	}
}
