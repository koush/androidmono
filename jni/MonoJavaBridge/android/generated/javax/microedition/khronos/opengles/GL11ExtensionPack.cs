namespace javax.microedition.khronos.opengles
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.microedition.khronos.opengles.GL11ExtensionPack_))]
	public interface GL11ExtensionPack : GL
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
	public sealed partial class GL11ExtensionPack_ : java.lang.Object, GL11ExtensionPack
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GL11ExtensionPack_()
		{
			InitJNI();
		}
		internal GL11ExtensionPack_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _glBindTexture23206;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glBindTexture(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindTexture23206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindTexture23206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexImage2D23207;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCompressedTexImage2D23207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCompressedTexImage2D23207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexImage2D23208;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCopyTexImage2D23208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCopyTexImage2D23208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glEnable23209;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glEnable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glEnable23209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glEnable23209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv23210;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetIntegerv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv23210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv23210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv23211;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetIntegerv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv23211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv23211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilOp23212;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glStencilOp(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glStencilOp23212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glStencilOp23212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvf23213;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvf23213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvf23213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv23214;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv23214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv23214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv23215;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv23215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv23215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvx23216;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvx23216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvx23216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv23217;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv23217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv23217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv23218;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv23218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv23218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterf23219;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexParameterf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexParameterf23219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexParameterf23219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glIsRenderbufferOES23220;
		 bool javax.microedition.khronos.opengles.GL11ExtensionPack.glIsRenderbufferOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsRenderbufferOES23220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsRenderbufferOES23220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBindRenderbufferOES23221;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glBindRenderbufferOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindRenderbufferOES23221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindRenderbufferOES23221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteRenderbuffersOES23222;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteRenderbuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES23222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES23222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteRenderbuffersOES23223;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteRenderbuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES23223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES23223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenRenderbuffersOES23224;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenRenderbuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES23224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES23224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenRenderbuffersOES23225;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenRenderbuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES23225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES23225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glRenderbufferStorageOES23226;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glRenderbufferStorageOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glRenderbufferStorageOES23226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glRenderbufferStorageOES23226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetRenderbufferParameterivOES23227;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetRenderbufferParameterivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES23227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES23227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetRenderbufferParameterivOES23228;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetRenderbufferParameterivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES23228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES23228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glIsFramebufferOES23229;
		 bool javax.microedition.khronos.opengles.GL11ExtensionPack.glIsFramebufferOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsFramebufferOES23229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsFramebufferOES23229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBindFramebufferOES23230;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glBindFramebufferOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindFramebufferOES23230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindFramebufferOES23230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteFramebuffersOES23231;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteFramebuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES23231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES23231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteFramebuffersOES23232;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteFramebuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES23232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES23232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenFramebuffersOES23233;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenFramebuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES23233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES23233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenFramebuffersOES23234;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenFramebuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES23234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES23234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glCheckFramebufferStatusOES23235;
		 int javax.microedition.khronos.opengles.GL11ExtensionPack.glCheckFramebufferStatusOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCheckFramebufferStatusOES23235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCheckFramebufferStatusOES23235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFramebufferRenderbufferOES23236;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glFramebufferRenderbufferOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferRenderbufferOES23236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferRenderbufferOES23236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glFramebufferTexture2DOES23237;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glFramebufferTexture2DOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferTexture2DOES23237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferTexture2DOES23237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFramebufferAttachmentParameterivOES23238;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES23238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES23238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFramebufferAttachmentParameterivOES23239;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, int[] arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES23239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES23239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glGenerateMipmapOES23240;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenerateMipmapOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenerateMipmapOES23240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenerateMipmapOES23240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendEquation23241;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glBlendEquation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquation23241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquation23241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendEquationSeparate23242;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glBlendEquationSeparate(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquationSeparate23242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquationSeparate23242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendFuncSeparate23243;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glBlendFuncSeparate(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendFuncSeparate23243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendFuncSeparate23243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenfv23244;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv23244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv23244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenfv23245;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv23245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv23245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGeniv23246;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGeniv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv23246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv23246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGeniv23247;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGeniv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv23247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv23247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenxv23248;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv23248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv23248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenxv23249;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv23249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv23249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenf23250;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenf23250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenf23250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenfv23251;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv23251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv23251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenfv23252;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv23252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv23252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGeni23253;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGeni(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeni23253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeni23253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGeniv23254;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGeniv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv23254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv23254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGeniv23255;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGeniv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv23255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv23255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenx23256;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenx23256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenx23256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenxv23257;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv23257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv23257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenxv23258;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv23258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv23258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/opengles/GL11ExtensionPack"));
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindTexture23206 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBindTexture", "(II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCompressedTexImage2D23207 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCopyTexImage2D23208 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glCopyTexImage2D", "(IIIIIIII)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glEnable23209 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glEnable", "(I)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv23210 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetIntegerv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv23211 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glStencilOp23212 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glStencilOp", "(III)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvf23213 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv23214 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv23215 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvx23216 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvx", "(III)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv23217 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv23218 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexParameterf23219 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexParameterf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsRenderbufferOES23220 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glIsRenderbufferOES", "(I)Z");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindRenderbufferOES23221 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBindRenderbufferOES", "(II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES23222 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteRenderbuffersOES", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES23223 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteRenderbuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES23224 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenRenderbuffersOES", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES23225 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenRenderbuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glRenderbufferStorageOES23226 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glRenderbufferStorageOES", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES23227 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetRenderbufferParameterivOES", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES23228 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetRenderbufferParameterivOES", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsFramebufferOES23229 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glIsFramebufferOES", "(I)Z");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindFramebufferOES23230 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBindFramebufferOES", "(II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES23231 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteFramebuffersOES", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES23232 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteFramebuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES23233 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenFramebuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES23234 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenFramebuffersOES", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCheckFramebufferStatusOES23235 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glCheckFramebufferStatusOES", "(I)I");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferRenderbufferOES23236 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glFramebufferRenderbufferOES", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferTexture2DOES23237 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glFramebufferTexture2DOES", "(IIIII)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES23238 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetFramebufferAttachmentParameterivOES", "(IIILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES23239 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetFramebufferAttachmentParameterivOES", "(III[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenerateMipmapOES23240 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenerateMipmapOES", "(I)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquation23241 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBlendEquation", "(I)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquationSeparate23242 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBlendEquationSeparate", "(II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendFuncSeparate23243 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBlendFuncSeparate", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv23244 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv23245 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv23246 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGeniv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv23247 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGeniv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv23248 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv23249 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenf23250 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv23251 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv23252 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeni23253 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGeni", "(III)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv23254 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGeniv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv23255 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGeniv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenx23256 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenx", "(III)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv23257 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv23258 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenxv", "(IILjava/nio/IntBuffer;)V");
		}
	}
}
