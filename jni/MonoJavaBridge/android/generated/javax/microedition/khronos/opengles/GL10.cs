namespace javax.microedition.khronos.opengles
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.microedition.khronos.opengles.GL10_))]
	public interface GL10 : GL
	{
		void glActiveTexture(int arg0);
		void glAlphaFunc(int arg0, float arg1);
		void glAlphaFuncx(int arg0, int arg1);
		void glBindTexture(int arg0, int arg1);
		void glBlendFunc(int arg0, int arg1);
		void glClear(int arg0);
		void glClearColor(float arg0, float arg1, float arg2, float arg3);
		void glClearColorx(int arg0, int arg1, int arg2, int arg3);
		void glClearDepthf(float arg0);
		void glClearDepthx(int arg0);
		void glClearStencil(int arg0);
		void glClientActiveTexture(int arg0);
		void glColor4f(float arg0, float arg1, float arg2, float arg3);
		void glColor4x(int arg0, int arg1, int arg2, int arg3);
		void glColorMask(bool arg0, bool arg1, bool arg2, bool arg3);
		void glColorPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3);
		void glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7);
		void glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8);
		void glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7);
		void glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7);
		void glCullFace(int arg0);
		void glDeleteTextures(int arg0, int[] arg1, int arg2);
		void glDeleteTextures(int arg0, java.nio.IntBuffer arg1);
		void glDepthFunc(int arg0);
		void glDepthMask(bool arg0);
		void glDepthRangef(float arg0, float arg1);
		void glDepthRangex(int arg0, int arg1);
		void glDisable(int arg0);
		void glDisableClientState(int arg0);
		void glDrawArrays(int arg0, int arg1, int arg2);
		void glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3);
		void glEnable(int arg0);
		void glEnableClientState(int arg0);
		void glFinish();
		void glFlush();
		void glFogf(int arg0, float arg1);
		void glFogfv(int arg0, float[] arg1, int arg2);
		void glFogfv(int arg0, java.nio.FloatBuffer arg1);
		void glFogx(int arg0, int arg1);
		void glFogxv(int arg0, int[] arg1, int arg2);
		void glFogxv(int arg0, java.nio.IntBuffer arg1);
		void glFrontFace(int arg0);
		void glFrustumf(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5);
		void glFrustumx(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);
		void glGenTextures(int arg0, int[] arg1, int arg2);
		void glGenTextures(int arg0, java.nio.IntBuffer arg1);
		int glGetError();
		void glGetIntegerv(int arg0, int[] arg1, int arg2);
		void glGetIntegerv(int arg0, java.nio.IntBuffer arg1);
		global::java.lang.String glGetString(int arg0);
		void glHint(int arg0, int arg1);
		void glLightModelf(int arg0, float arg1);
		void glLightModelfv(int arg0, float[] arg1, int arg2);
		void glLightModelfv(int arg0, java.nio.FloatBuffer arg1);
		void glLightModelx(int arg0, int arg1);
		void glLightModelxv(int arg0, int[] arg1, int arg2);
		void glLightModelxv(int arg0, java.nio.IntBuffer arg1);
		void glLightf(int arg0, int arg1, float arg2);
		void glLightfv(int arg0, int arg1, float[] arg2, int arg3);
		void glLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2);
		void glLightx(int arg0, int arg1, int arg2);
		void glLightxv(int arg0, int arg1, int[] arg2, int arg3);
		void glLightxv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glLineWidth(float arg0);
		void glLineWidthx(int arg0);
		void glLoadIdentity();
		void glLoadMatrixf(float[] arg0, int arg1);
		void glLoadMatrixf(java.nio.FloatBuffer arg0);
		void glLoadMatrixx(int[] arg0, int arg1);
		void glLoadMatrixx(java.nio.IntBuffer arg0);
		void glLogicOp(int arg0);
		void glMaterialf(int arg0, int arg1, float arg2);
		void glMaterialfv(int arg0, int arg1, float[] arg2, int arg3);
		void glMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2);
		void glMaterialx(int arg0, int arg1, int arg2);
		void glMaterialxv(int arg0, int arg1, int[] arg2, int arg3);
		void glMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glMatrixMode(int arg0);
		void glMultMatrixf(float[] arg0, int arg1);
		void glMultMatrixf(java.nio.FloatBuffer arg0);
		void glMultMatrixx(int[] arg0, int arg1);
		void glMultMatrixx(java.nio.IntBuffer arg0);
		void glMultiTexCoord4f(int arg0, float arg1, float arg2, float arg3, float arg4);
		void glMultiTexCoord4x(int arg0, int arg1, int arg2, int arg3, int arg4);
		void glNormal3f(float arg0, float arg1, float arg2);
		void glNormal3x(int arg0, int arg1, int arg2);
		void glNormalPointer(int arg0, int arg1, java.nio.Buffer arg2);
		void glOrthof(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5);
		void glOrthox(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);
		void glPixelStorei(int arg0, int arg1);
		void glPointSize(float arg0);
		void glPointSizex(int arg0);
		void glPolygonOffset(float arg0, float arg1);
		void glPolygonOffsetx(int arg0, int arg1);
		void glPopMatrix();
		void glPushMatrix();
		void glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6);
		void glRotatef(float arg0, float arg1, float arg2, float arg3);
		void glRotatex(int arg0, int arg1, int arg2, int arg3);
		void glSampleCoverage(float arg0, bool arg1);
		void glSampleCoveragex(int arg0, bool arg1);
		void glScalef(float arg0, float arg1, float arg2);
		void glScalex(int arg0, int arg1, int arg2);
		void glScissor(int arg0, int arg1, int arg2, int arg3);
		void glShadeModel(int arg0);
		void glStencilFunc(int arg0, int arg1, int arg2);
		void glStencilMask(int arg0);
		void glStencilOp(int arg0, int arg1, int arg2);
		void glTexCoordPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3);
		void glTexEnvf(int arg0, int arg1, float arg2);
		void glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3);
		void glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2);
		void glTexEnvx(int arg0, int arg1, int arg2);
		void glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3);
		void glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2);
		void glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8);
		void glTexParameterf(int arg0, int arg1, float arg2);
		void glTexParameterx(int arg0, int arg1, int arg2);
		void glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8);
		void glTranslatef(float arg0, float arg1, float arg2);
		void glTranslatex(int arg0, int arg1, int arg2);
		void glVertexPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3);
		void glViewport(int arg0, int arg1, int arg2, int arg3);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.opengles.GL10))]
	public sealed partial class GL10_ : java.lang.Object, GL10
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GL10_()
		{
			InitJNI();
		}
		internal GL10_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _glActiveTexture22869;
		 void javax.microedition.khronos.opengles.GL10.glActiveTexture(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glActiveTexture22869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glActiveTexture22869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFunc22870;
		 void javax.microedition.khronos.opengles.GL10.glAlphaFunc(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glAlphaFunc22870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glAlphaFunc22870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFuncx22871;
		 void javax.microedition.khronos.opengles.GL10.glAlphaFuncx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glAlphaFuncx22871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glAlphaFuncx22871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBindTexture22872;
		 void javax.microedition.khronos.opengles.GL10.glBindTexture(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glBindTexture22872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glBindTexture22872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendFunc22873;
		 void javax.microedition.khronos.opengles.GL10.glBlendFunc(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glBlendFunc22873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glBlendFunc22873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClear22874;
		 void javax.microedition.khronos.opengles.GL10.glClear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glClear22874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glClear22874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColor22875;
		 void javax.microedition.khronos.opengles.GL10.glClearColor(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glClearColor22875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glClearColor22875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColorx22876;
		 void javax.microedition.khronos.opengles.GL10.glClearColorx(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glClearColorx22876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glClearColorx22876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthf22877;
		 void javax.microedition.khronos.opengles.GL10.glClearDepthf(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glClearDepthf22877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glClearDepthf22877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthx22878;
		 void javax.microedition.khronos.opengles.GL10.glClearDepthx(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glClearDepthx22878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glClearDepthx22878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearStencil22879;
		 void javax.microedition.khronos.opengles.GL10.glClearStencil(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glClearStencil22879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glClearStencil22879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClientActiveTexture22880;
		 void javax.microedition.khronos.opengles.GL10.glClientActiveTexture(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glClientActiveTexture22880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glClientActiveTexture22880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4f22881;
		 void javax.microedition.khronos.opengles.GL10.glColor4f(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glColor4f22881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glColor4f22881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4x22882;
		 void javax.microedition.khronos.opengles.GL10.glColor4x(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glColor4x22882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glColor4x22882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColorMask22883;
		 void javax.microedition.khronos.opengles.GL10.glColorMask(bool arg0, bool arg1, bool arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glColorMask22883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glColorMask22883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColorPointer22884;
		 void javax.microedition.khronos.opengles.GL10.glColorPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glColorPointer22884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glColorPointer22884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexImage2D22885;
		 void javax.microedition.khronos.opengles.GL10.glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glCompressedTexImage2D22885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glCompressedTexImage2D22885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexSubImage2D22886;
		 void javax.microedition.khronos.opengles.GL10.glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glCompressedTexSubImage2D22886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glCompressedTexSubImage2D22886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexImage2D22887;
		 void javax.microedition.khronos.opengles.GL10.glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glCopyTexImage2D22887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glCopyTexImage2D22887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexSubImage2D22888;
		 void javax.microedition.khronos.opengles.GL10.glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glCopyTexSubImage2D22888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glCopyTexSubImage2D22888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCullFace22889;
		 void javax.microedition.khronos.opengles.GL10.glCullFace(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glCullFace22889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glCullFace22889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures22890;
		 void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDeleteTextures22890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glDeleteTextures22890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures22891;
		 void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDeleteTextures22891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glDeleteTextures22891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthFunc22892;
		 void javax.microedition.khronos.opengles.GL10.glDepthFunc(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDepthFunc22892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glDepthFunc22892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthMask22893;
		 void javax.microedition.khronos.opengles.GL10.glDepthMask(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDepthMask22893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glDepthMask22893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangef22894;
		 void javax.microedition.khronos.opengles.GL10.glDepthRangef(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDepthRangef22894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glDepthRangef22894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangex22895;
		 void javax.microedition.khronos.opengles.GL10.glDepthRangex(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDepthRangex22895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glDepthRangex22895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDisable22896;
		 void javax.microedition.khronos.opengles.GL10.glDisable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDisable22896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glDisable22896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDisableClientState22897;
		 void javax.microedition.khronos.opengles.GL10.glDisableClientState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDisableClientState22897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glDisableClientState22897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawArrays22898;
		 void javax.microedition.khronos.opengles.GL10.glDrawArrays(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDrawArrays22898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glDrawArrays22898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawElements22899;
		 void javax.microedition.khronos.opengles.GL10.glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDrawElements22899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glDrawElements22899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glEnable22900;
		 void javax.microedition.khronos.opengles.GL10.glEnable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glEnable22900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glEnable22900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glEnableClientState22901;
		 void javax.microedition.khronos.opengles.GL10.glEnableClientState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glEnableClientState22901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glEnableClientState22901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFinish22902;
		 void javax.microedition.khronos.opengles.GL10.glFinish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFinish22902);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glFinish22902);
		}
		internal static global::MonoJavaBridge.MethodId _glFlush22903;
		 void javax.microedition.khronos.opengles.GL10.glFlush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFlush22903);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glFlush22903);
		}
		internal static global::MonoJavaBridge.MethodId _glFogf22904;
		 void javax.microedition.khronos.opengles.GL10.glFogf(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFogf22904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glFogf22904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogfv22905;
		 void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFogfv22905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glFogfv22905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogfv22906;
		 void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFogfv22906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glFogfv22906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogx22907;
		 void javax.microedition.khronos.opengles.GL10.glFogx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFogx22907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glFogx22907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxv22908;
		 void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFogxv22908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glFogxv22908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxv22909;
		 void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFogxv22909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glFogxv22909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFrontFace22910;
		 void javax.microedition.khronos.opengles.GL10.glFrontFace(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFrontFace22910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glFrontFace22910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumf22911;
		 void javax.microedition.khronos.opengles.GL10.glFrustumf(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFrustumf22911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glFrustumf22911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumx22912;
		 void javax.microedition.khronos.opengles.GL10.glFrustumx(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFrustumx22912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glFrustumx22912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures22913;
		 void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glGenTextures22913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glGenTextures22913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures22914;
		 void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glGenTextures22914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glGenTextures22914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetError22915;
		 int javax.microedition.khronos.opengles.GL10.glGetError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glGetError22915);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glGetError22915);
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv22916;
		 void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glGetIntegerv22916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glGetIntegerv22916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv22917;
		 void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glGetIntegerv22917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glGetIntegerv22917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetString22918;
		 global::java.lang.String javax.microedition.khronos.opengles.GL10.glGetString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glGetString22918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glGetString22918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _glHint22919;
		 void javax.microedition.khronos.opengles.GL10.glHint(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glHint22919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glHint22919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelf22920;
		 void javax.microedition.khronos.opengles.GL10.glLightModelf(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightModelf22920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLightModelf22920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelfv22921;
		 void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, float[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightModelfv22921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLightModelfv22921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelfv22922;
		 void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightModelfv22922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLightModelfv22922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelx22923;
		 void javax.microedition.khronos.opengles.GL10.glLightModelx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightModelx22923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLightModelx22923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxv22924;
		 void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, int[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightModelxv22924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLightModelxv22924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxv22925;
		 void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightModelxv22925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLightModelxv22925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightf22926;
		 void javax.microedition.khronos.opengles.GL10.glLightf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightf22926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLightf22926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightfv22927;
		 void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightfv22927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLightfv22927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightfv22928;
		 void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightfv22928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLightfv22928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightx22929;
		 void javax.microedition.khronos.opengles.GL10.glLightx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightx22929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLightx22929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxv22930;
		 void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightxv22930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLightxv22930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxv22931;
		 void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightxv22931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLightxv22931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidth22932;
		 void javax.microedition.khronos.opengles.GL10.glLineWidth(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLineWidth22932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLineWidth22932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidthx22933;
		 void javax.microedition.khronos.opengles.GL10.glLineWidthx(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLineWidthx22933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLineWidthx22933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadIdentity22934;
		 void javax.microedition.khronos.opengles.GL10.glLoadIdentity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLoadIdentity22934);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLoadIdentity22934);
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixf22935;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(float[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixf22935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixf22935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixf22936;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixf22936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixf22936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixx22937;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixx22937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixx22937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixx22938;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixx22938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixx22938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLogicOp22939;
		 void javax.microedition.khronos.opengles.GL10.glLogicOp(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLogicOp22939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glLogicOp22939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialf22940;
		 void javax.microedition.khronos.opengles.GL10.glMaterialf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMaterialf22940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glMaterialf22940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialfv22941;
		 void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMaterialfv22941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glMaterialfv22941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialfv22942;
		 void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMaterialfv22942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glMaterialfv22942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialx22943;
		 void javax.microedition.khronos.opengles.GL10.glMaterialx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMaterialx22943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glMaterialx22943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxv22944;
		 void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMaterialxv22944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glMaterialxv22944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxv22945;
		 void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMaterialxv22945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glMaterialxv22945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMatrixMode22946;
		 void javax.microedition.khronos.opengles.GL10.glMatrixMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMatrixMode22946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glMatrixMode22946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixf22947;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixf(float[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMultMatrixf22947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glMultMatrixf22947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixf22948;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixf(java.nio.FloatBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMultMatrixf22948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glMultMatrixf22948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixx22949;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixx(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMultMatrixx22949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glMultMatrixx22949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixx22950;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixx(java.nio.IntBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMultMatrixx22950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glMultMatrixx22950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4f22951;
		 void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4f(int arg0, float arg1, float arg2, float arg3, float arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMultiTexCoord4f22951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glMultiTexCoord4f22951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4x22952;
		 void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4x(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMultiTexCoord4x22952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glMultiTexCoord4x22952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3f22953;
		 void javax.microedition.khronos.opengles.GL10.glNormal3f(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glNormal3f22953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glNormal3f22953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3x22954;
		 void javax.microedition.khronos.opengles.GL10.glNormal3x(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glNormal3x22954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glNormal3x22954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glNormalPointer22955;
		 void javax.microedition.khronos.opengles.GL10.glNormalPointer(int arg0, int arg1, java.nio.Buffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glNormalPointer22955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glNormalPointer22955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthof22956;
		 void javax.microedition.khronos.opengles.GL10.glOrthof(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glOrthof22956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glOrthof22956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthox22957;
		 void javax.microedition.khronos.opengles.GL10.glOrthox(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glOrthox22957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glOrthox22957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glPixelStorei22958;
		 void javax.microedition.khronos.opengles.GL10.glPixelStorei(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glPixelStorei22958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glPixelStorei22958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSize22959;
		 void javax.microedition.khronos.opengles.GL10.glPointSize(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glPointSize22959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glPointSize22959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSizex22960;
		 void javax.microedition.khronos.opengles.GL10.glPointSizex(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glPointSizex22960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glPointSizex22960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffset22961;
		 void javax.microedition.khronos.opengles.GL10.glPolygonOffset(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glPolygonOffset22961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glPolygonOffset22961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffsetx22962;
		 void javax.microedition.khronos.opengles.GL10.glPolygonOffsetx(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glPolygonOffsetx22962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glPolygonOffsetx22962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPopMatrix22963;
		 void javax.microedition.khronos.opengles.GL10.glPopMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glPopMatrix22963);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glPopMatrix22963);
		}
		internal static global::MonoJavaBridge.MethodId _glPushMatrix22964;
		 void javax.microedition.khronos.opengles.GL10.glPushMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glPushMatrix22964);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glPushMatrix22964);
		}
		internal static global::MonoJavaBridge.MethodId _glReadPixels22965;
		 void javax.microedition.khronos.opengles.GL10.glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glReadPixels22965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glReadPixels22965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatef22966;
		 void javax.microedition.khronos.opengles.GL10.glRotatef(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glRotatef22966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glRotatef22966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatex22967;
		 void javax.microedition.khronos.opengles.GL10.glRotatex(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glRotatex22967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glRotatex22967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoverage22968;
		 void javax.microedition.khronos.opengles.GL10.glSampleCoverage(float arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glSampleCoverage22968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glSampleCoverage22968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoveragex22969;
		 void javax.microedition.khronos.opengles.GL10.glSampleCoveragex(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glSampleCoveragex22969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glSampleCoveragex22969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glScalef22970;
		 void javax.microedition.khronos.opengles.GL10.glScalef(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glScalef22970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glScalef22970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glScalex22971;
		 void javax.microedition.khronos.opengles.GL10.glScalex(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glScalex22971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glScalex22971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glScissor22972;
		 void javax.microedition.khronos.opengles.GL10.glScissor(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glScissor22972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glScissor22972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glShadeModel22973;
		 void javax.microedition.khronos.opengles.GL10.glShadeModel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glShadeModel22973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glShadeModel22973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilFunc22974;
		 void javax.microedition.khronos.opengles.GL10.glStencilFunc(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glStencilFunc22974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glStencilFunc22974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilMask22975;
		 void javax.microedition.khronos.opengles.GL10.glStencilMask(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glStencilMask22975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glStencilMask22975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilOp22976;
		 void javax.microedition.khronos.opengles.GL10.glStencilOp(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glStencilOp22976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glStencilOp22976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexCoordPointer22977;
		 void javax.microedition.khronos.opengles.GL10.glTexCoordPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexCoordPointer22977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glTexCoordPointer22977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvf22978;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexEnvf22978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glTexEnvf22978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv22979;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexEnvfv22979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glTexEnvfv22979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv22980;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexEnvfv22980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glTexEnvfv22980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvx22981;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexEnvx22981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glTexEnvx22981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv22982;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexEnvxv22982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glTexEnvxv22982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv22983;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexEnvxv22983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glTexEnvxv22983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexImage2D22984;
		 void javax.microedition.khronos.opengles.GL10.glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexImage2D22984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glTexImage2D22984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterf22985;
		 void javax.microedition.khronos.opengles.GL10.glTexParameterf(int arg0, int arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexParameterf22985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glTexParameterf22985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterx22986;
		 void javax.microedition.khronos.opengles.GL10.glTexParameterx(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexParameterx22986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glTexParameterx22986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexSubImage2D22987;
		 void javax.microedition.khronos.opengles.GL10.glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexSubImage2D22987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glTexSubImage2D22987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatef22988;
		 void javax.microedition.khronos.opengles.GL10.glTranslatef(float arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTranslatef22988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glTranslatef22988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatex22989;
		 void javax.microedition.khronos.opengles.GL10.glTranslatex(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTranslatex22989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glTranslatex22989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexPointer22990;
		 void javax.microedition.khronos.opengles.GL10.glVertexPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glVertexPointer22990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glVertexPointer22990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glViewport22991;
		 void javax.microedition.khronos.opengles.GL10.glViewport(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glViewport22991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_.staticClass, global::javax.microedition.khronos.opengles.GL10_._glViewport22991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.opengles.GL10_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/opengles/GL10"));
			global::javax.microedition.khronos.opengles.GL10_._glActiveTexture22869 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glActiveTexture", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glAlphaFunc22870 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glAlphaFunc", "(IF)V");
			global::javax.microedition.khronos.opengles.GL10_._glAlphaFuncx22871 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glAlphaFuncx", "(II)V");
			global::javax.microedition.khronos.opengles.GL10_._glBindTexture22872 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glBindTexture", "(II)V");
			global::javax.microedition.khronos.opengles.GL10_._glBlendFunc22873 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glBlendFunc", "(II)V");
			global::javax.microedition.khronos.opengles.GL10_._glClear22874 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClear", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glClearColor22875 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClearColor", "(FFFF)V");
			global::javax.microedition.khronos.opengles.GL10_._glClearColorx22876 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClearColorx", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL10_._glClearDepthf22877 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClearDepthf", "(F)V");
			global::javax.microedition.khronos.opengles.GL10_._glClearDepthx22878 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClearDepthx", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glClearStencil22879 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClearStencil", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glClientActiveTexture22880 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClientActiveTexture", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glColor4f22881 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glColor4f", "(FFFF)V");
			global::javax.microedition.khronos.opengles.GL10_._glColor4x22882 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glColor4x", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL10_._glColorMask22883 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glColorMask", "(ZZZZ)V");
			global::javax.microedition.khronos.opengles.GL10_._glColorPointer22884 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glColorPointer", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glCompressedTexImage2D22885 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glCompressedTexSubImage2D22886 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glCopyTexImage2D22887 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glCopyTexImage2D", "(IIIIIIII)V");
			global::javax.microedition.khronos.opengles.GL10_._glCopyTexSubImage2D22888 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glCopyTexSubImage2D", "(IIIIIIII)V");
			global::javax.microedition.khronos.opengles.GL10_._glCullFace22889 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glCullFace", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glDeleteTextures22890 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDeleteTextures", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL10_._glDeleteTextures22891 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDeleteTextures", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glDepthFunc22892 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDepthFunc", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glDepthMask22893 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDepthMask", "(Z)V");
			global::javax.microedition.khronos.opengles.GL10_._glDepthRangef22894 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDepthRangef", "(FF)V");
			global::javax.microedition.khronos.opengles.GL10_._glDepthRangex22895 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDepthRangex", "(II)V");
			global::javax.microedition.khronos.opengles.GL10_._glDisable22896 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDisable", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glDisableClientState22897 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDisableClientState", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glDrawArrays22898 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDrawArrays", "(III)V");
			global::javax.microedition.khronos.opengles.GL10_._glDrawElements22899 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDrawElements", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glEnable22900 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glEnable", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glEnableClientState22901 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glEnableClientState", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glFinish22902 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFinish", "()V");
			global::javax.microedition.khronos.opengles.GL10_._glFlush22903 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFlush", "()V");
			global::javax.microedition.khronos.opengles.GL10_._glFogf22904 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogf", "(IF)V");
			global::javax.microedition.khronos.opengles.GL10_._glFogfv22905 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogfv", "(I[FI)V");
			global::javax.microedition.khronos.opengles.GL10_._glFogfv22906 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogfv", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glFogx22907 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogx", "(II)V");
			global::javax.microedition.khronos.opengles.GL10_._glFogxv22908 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogxv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL10_._glFogxv22909 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogxv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glFrontFace22910 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFrontFace", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glFrustumf22911 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFrustumf", "(FFFFFF)V");
			global::javax.microedition.khronos.opengles.GL10_._glFrustumx22912 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFrustumx", "(IIIIII)V");
			global::javax.microedition.khronos.opengles.GL10_._glGenTextures22913 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGenTextures", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL10_._glGenTextures22914 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGenTextures", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glGetError22915 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGetError", "()I");
			global::javax.microedition.khronos.opengles.GL10_._glGetIntegerv22916 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGetIntegerv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL10_._glGetIntegerv22917 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glGetString22918 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGetString", "(I)Ljava/lang/String;");
			global::javax.microedition.khronos.opengles.GL10_._glHint22919 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glHint", "(II)V");
			global::javax.microedition.khronos.opengles.GL10_._glLightModelf22920 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelf", "(IF)V");
			global::javax.microedition.khronos.opengles.GL10_._glLightModelfv22921 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelfv", "(I[FI)V");
			global::javax.microedition.khronos.opengles.GL10_._glLightModelfv22922 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelfv", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glLightModelx22923 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelx", "(II)V");
			global::javax.microedition.khronos.opengles.GL10_._glLightModelxv22924 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelxv", "(I[II)V");
			global::javax.microedition.khronos.opengles.GL10_._glLightModelxv22925 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelxv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glLightf22926 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL10_._glLightfv22927 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL10_._glLightfv22928 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glLightx22929 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightx", "(III)V");
			global::javax.microedition.khronos.opengles.GL10_._glLightxv22930 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL10_._glLightxv22931 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glLineWidth22932 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLineWidth", "(F)V");
			global::javax.microedition.khronos.opengles.GL10_._glLineWidthx22933 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLineWidthx", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glLoadIdentity22934 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLoadIdentity", "()V");
			global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixf22935 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLoadMatrixf", "([FI)V");
			global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixf22936 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixx22937 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLoadMatrixx", "([II)V");
			global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixx22938 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLoadMatrixx", "(Ljava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glLogicOp22939 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLogicOp", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glMaterialf22940 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL10_._glMaterialfv22941 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL10_._glMaterialfv22942 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glMaterialx22943 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialx", "(III)V");
			global::javax.microedition.khronos.opengles.GL10_._glMaterialxv22944 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL10_._glMaterialxv22945 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glMatrixMode22946 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMatrixMode", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glMultMatrixf22947 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultMatrixf", "([FI)V");
			global::javax.microedition.khronos.opengles.GL10_._glMultMatrixf22948 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultMatrixf", "(Ljava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glMultMatrixx22949 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultMatrixx", "([II)V");
			global::javax.microedition.khronos.opengles.GL10_._glMultMatrixx22950 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultMatrixx", "(Ljava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glMultiTexCoord4f22951 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultiTexCoord4f", "(IFFFF)V");
			global::javax.microedition.khronos.opengles.GL10_._glMultiTexCoord4x22952 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultiTexCoord4x", "(IIIII)V");
			global::javax.microedition.khronos.opengles.GL10_._glNormal3f22953 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glNormal3f", "(FFF)V");
			global::javax.microedition.khronos.opengles.GL10_._glNormal3x22954 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glNormal3x", "(III)V");
			global::javax.microedition.khronos.opengles.GL10_._glNormalPointer22955 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glNormalPointer", "(IILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glOrthof22956 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glOrthof", "(FFFFFF)V");
			global::javax.microedition.khronos.opengles.GL10_._glOrthox22957 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glOrthox", "(IIIIII)V");
			global::javax.microedition.khronos.opengles.GL10_._glPixelStorei22958 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPixelStorei", "(II)V");
			global::javax.microedition.khronos.opengles.GL10_._glPointSize22959 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPointSize", "(F)V");
			global::javax.microedition.khronos.opengles.GL10_._glPointSizex22960 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPointSizex", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glPolygonOffset22961 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPolygonOffset", "(FF)V");
			global::javax.microedition.khronos.opengles.GL10_._glPolygonOffsetx22962 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPolygonOffsetx", "(II)V");
			global::javax.microedition.khronos.opengles.GL10_._glPopMatrix22963 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPopMatrix", "()V");
			global::javax.microedition.khronos.opengles.GL10_._glPushMatrix22964 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPushMatrix", "()V");
			global::javax.microedition.khronos.opengles.GL10_._glReadPixels22965 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glReadPixels", "(IIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glRotatef22966 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glRotatef", "(FFFF)V");
			global::javax.microedition.khronos.opengles.GL10_._glRotatex22967 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glRotatex", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL10_._glSampleCoverage22968 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glSampleCoverage", "(FZ)V");
			global::javax.microedition.khronos.opengles.GL10_._glSampleCoveragex22969 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glSampleCoveragex", "(IZ)V");
			global::javax.microedition.khronos.opengles.GL10_._glScalef22970 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glScalef", "(FFF)V");
			global::javax.microedition.khronos.opengles.GL10_._glScalex22971 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glScalex", "(III)V");
			global::javax.microedition.khronos.opengles.GL10_._glScissor22972 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glScissor", "(IIII)V");
			global::javax.microedition.khronos.opengles.GL10_._glShadeModel22973 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glShadeModel", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glStencilFunc22974 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glStencilFunc", "(III)V");
			global::javax.microedition.khronos.opengles.GL10_._glStencilMask22975 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glStencilMask", "(I)V");
			global::javax.microedition.khronos.opengles.GL10_._glStencilOp22976 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glStencilOp", "(III)V");
			global::javax.microedition.khronos.opengles.GL10_._glTexCoordPointer22977 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexCoordPointer", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glTexEnvf22978 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL10_._glTexEnvfv22979 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.GL10_._glTexEnvfv22980 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glTexEnvx22981 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvx", "(III)V");
			global::javax.microedition.khronos.opengles.GL10_._glTexEnvxv22982 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.GL10_._glTexEnvxv22983 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glTexImage2D22984 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glTexParameterf22985 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexParameterf", "(IIF)V");
			global::javax.microedition.khronos.opengles.GL10_._glTexParameterx22986 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexParameterx", "(III)V");
			global::javax.microedition.khronos.opengles.GL10_._glTexSubImage2D22987 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glTranslatef22988 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTranslatef", "(FFF)V");
			global::javax.microedition.khronos.opengles.GL10_._glTranslatex22989 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTranslatex", "(III)V");
			global::javax.microedition.khronos.opengles.GL10_._glVertexPointer22990 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glVertexPointer", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.GL10_._glViewport22991 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glViewport", "(IIII)V");
		}
	}
}
