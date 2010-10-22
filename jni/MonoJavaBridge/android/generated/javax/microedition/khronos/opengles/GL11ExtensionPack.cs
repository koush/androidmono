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
		internal static global::MonoJavaBridge.MethodId _glBindTexture29551;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glBindTexture(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindTexture29551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindTexture29551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexImage2D29552;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCompressedTexImage2D29552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCompressedTexImage2D29552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexImage2D29553;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCopyTexImage2D29553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCopyTexImage2D29553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glEnable29554;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glEnable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glEnable29554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glEnable29554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv29555;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetIntegerv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv29555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv29555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv29556;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetIntegerv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv29556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv29556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilOp29557;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glStencilOp(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glStencilOp29557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glStencilOp29557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvf29558;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvf29558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvf29558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv29559;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv29559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv29559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv29560;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv29560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv29560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvx29561;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvx29561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvx29561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv29562;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv29562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv29562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv29563;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv29563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv29563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterf29564;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexParameterf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexParameterf29564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexParameterf29564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glIsRenderbufferOES29565;
		 bool javax.microedition.khronos.opengles.GL11ExtensionPack.glIsRenderbufferOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsRenderbufferOES29565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsRenderbufferOES29565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBindRenderbufferOES29566;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glBindRenderbufferOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindRenderbufferOES29566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindRenderbufferOES29566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteRenderbuffersOES29567;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteRenderbuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES29567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES29567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteRenderbuffersOES29568;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteRenderbuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES29568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES29568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenRenderbuffersOES29569;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenRenderbuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES29569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES29569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenRenderbuffersOES29570;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenRenderbuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES29570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES29570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glRenderbufferStorageOES29571;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glRenderbufferStorageOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glRenderbufferStorageOES29571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glRenderbufferStorageOES29571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetRenderbufferParameterivOES29572;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetRenderbufferParameterivOES(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES29572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES29572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetRenderbufferParameterivOES29573;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetRenderbufferParameterivOES(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES29573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES29573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glIsFramebufferOES29574;
		 bool javax.microedition.khronos.opengles.GL11ExtensionPack.glIsFramebufferOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsFramebufferOES29574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsFramebufferOES29574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBindFramebufferOES29575;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glBindFramebufferOES(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindFramebufferOES29575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindFramebufferOES29575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteFramebuffersOES29576;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteFramebuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES29576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES29576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteFramebuffersOES29577;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glDeleteFramebuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES29577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES29577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenFramebuffersOES29578;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenFramebuffersOES(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES29578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES29578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGenFramebuffersOES29579;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenFramebuffersOES(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES29579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES29579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glCheckFramebufferStatusOES29580;
		 int javax.microedition.khronos.opengles.GL11ExtensionPack.glCheckFramebufferStatusOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCheckFramebufferStatusOES29580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCheckFramebufferStatusOES29580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFramebufferRenderbufferOES29581;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glFramebufferRenderbufferOES(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferRenderbufferOES29581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferRenderbufferOES29581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glFramebufferTexture2DOES29582;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glFramebufferTexture2DOES(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferTexture2DOES29582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferTexture2DOES29582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFramebufferAttachmentParameterivOES29583;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, java.nio.IntBuffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES29583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES29583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetFramebufferAttachmentParameterivOES29584;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetFramebufferAttachmentParameterivOES(int arg0, int arg1, int arg2, int[] arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES29584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES29584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glGenerateMipmapOES29585;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGenerateMipmapOES(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenerateMipmapOES29585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenerateMipmapOES29585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendEquation29586;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glBlendEquation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquation29586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquation29586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendEquationSeparate29587;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glBlendEquationSeparate(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquationSeparate29587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquationSeparate29587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendFuncSeparate29588;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glBlendFuncSeparate(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendFuncSeparate29588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendFuncSeparate29588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenfv29589;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv29589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv29589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenfv29590;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv29590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv29590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGeniv29591;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGeniv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv29591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv29591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGeniv29592;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGeniv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv29592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv29592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenxv29593;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv29593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv29593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glGetTexGenxv29594;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glGetTexGenxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv29594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv29594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenf29595;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenf29595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenf29595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenfv29596;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv29596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv29596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenfv29597;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv29597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv29597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGeni29598;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGeni(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeni29598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeni29598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGeniv29599;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGeniv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv29599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv29599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGeniv29600;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGeniv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv29600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv29600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenx29601;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenx29601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenx29601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenxv29602;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv29602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv29602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexGenxv29603;
		 void javax.microedition.khronos.opengles.GL11ExtensionPack.glTexGenxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv29603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv29603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/opengles/GL11ExtensionPack"));
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindTexture29551 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBindTexture", "(II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCompressedTexImage2D29552 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCopyTexImage2D29553 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glCopyTexImage2D", "(IIIIIIII)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glEnable29554 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glEnable", "(I)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv29555 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetIntegerv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetIntegerv29556 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glStencilOp29557 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glStencilOp", "(III)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvf29558 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv29559 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvfv29560 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvx29561 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvx", "(III)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv29562 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexEnvxv29563 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexParameterf29564 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexParameterf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsRenderbufferOES29565 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glIsRenderbufferOES", "(I)Z");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindRenderbufferOES29566 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBindRenderbufferOES", "(II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES29567 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteRenderbuffersOES", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteRenderbuffersOES29568 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteRenderbuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES29569 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenRenderbuffersOES", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenRenderbuffersOES29570 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenRenderbuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glRenderbufferStorageOES29571 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glRenderbufferStorageOES", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES29572 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetRenderbufferParameterivOES", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetRenderbufferParameterivOES29573 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetRenderbufferParameterivOES", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glIsFramebufferOES29574 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glIsFramebufferOES", "(I)Z");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBindFramebufferOES29575 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBindFramebufferOES", "(II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES29576 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteFramebuffersOES", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glDeleteFramebuffersOES29577 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glDeleteFramebuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES29578 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenFramebuffersOES", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenFramebuffersOES29579 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenFramebuffersOES", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glCheckFramebufferStatusOES29580 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glCheckFramebufferStatusOES", "(I)I");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferRenderbufferOES29581 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glFramebufferRenderbufferOES", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glFramebufferTexture2DOES29582 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glFramebufferTexture2DOES", "(IIIII)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES29583 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetFramebufferAttachmentParameterivOES", "(IIILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetFramebufferAttachmentParameterivOES29584 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetFramebufferAttachmentParameterivOES", "(III[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGenerateMipmapOES29585 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGenerateMipmapOES", "(I)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquation29586 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBlendEquation", "(I)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendEquationSeparate29587 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBlendEquationSeparate", "(II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glBlendFuncSeparate29588 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glBlendFuncSeparate", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv29589 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenfv29590 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv29591 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGeniv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGeniv29592 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGeniv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv29593 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glGetTexGenxv29594 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glGetTexGenxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenf29595 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv29596 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenfv29597 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeni29598 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGeni", "(III)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv29599 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGeniv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGeniv29600 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGeniv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenx29601 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenx", "(III)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv29602 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL11ExtensionPack_._glTexGenxv29603 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL11ExtensionPack_.staticClass, "glTexGenxv", "(IILjava/nio/IntBuffer;)V");
		}
	}
}
