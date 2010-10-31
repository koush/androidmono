namespace javax.microedition.khronos.opengles
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.microedition.khronos.opengles.GL10_))]
	public partial interface GL10 : GL
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
	internal sealed partial class GL10_ : java.lang.Object, GL10
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GL10_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void javax.microedition.khronos.opengles.GL10.glActiveTexture(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glActiveTexture", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void javax.microedition.khronos.opengles.GL10.glAlphaFunc(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glAlphaFunc", "(IF)V", ref global::javax.microedition.khronos.opengles.GL10_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void javax.microedition.khronos.opengles.GL10.glAlphaFuncx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glAlphaFuncx", "(II)V", ref global::javax.microedition.khronos.opengles.GL10_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void javax.microedition.khronos.opengles.GL10.glBindTexture(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glBindTexture", "(II)V", ref global::javax.microedition.khronos.opengles.GL10_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void javax.microedition.khronos.opengles.GL10.glBlendFunc(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glBlendFunc", "(II)V", ref global::javax.microedition.khronos.opengles.GL10_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void javax.microedition.khronos.opengles.GL10.glClear(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClear", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void javax.microedition.khronos.opengles.GL10.glClearColor(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClearColor", "(FFFF)V", ref global::javax.microedition.khronos.opengles.GL10_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void javax.microedition.khronos.opengles.GL10.glClearColorx(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClearColorx", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL10_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void javax.microedition.khronos.opengles.GL10.glClearDepthf(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClearDepthf", "(F)V", ref global::javax.microedition.khronos.opengles.GL10_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void javax.microedition.khronos.opengles.GL10.glClearDepthx(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClearDepthx", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void javax.microedition.khronos.opengles.GL10.glClearStencil(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClearStencil", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void javax.microedition.khronos.opengles.GL10.glClientActiveTexture(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClientActiveTexture", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void javax.microedition.khronos.opengles.GL10.glColor4f(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glColor4f", "(FFFF)V", ref global::javax.microedition.khronos.opengles.GL10_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void javax.microedition.khronos.opengles.GL10.glColor4x(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glColor4x", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL10_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		void javax.microedition.khronos.opengles.GL10.glColorMask(bool arg0, bool arg1, bool arg2, bool arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glColorMask", "(ZZZZ)V", ref global::javax.microedition.khronos.opengles.GL10_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void javax.microedition.khronos.opengles.GL10.glColorPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glColorPointer", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void javax.microedition.khronos.opengles.GL10.glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		void javax.microedition.khronos.opengles.GL10.glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void javax.microedition.khronos.opengles.GL10.glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glCopyTexImage2D", "(IIIIIIII)V", ref global::javax.microedition.khronos.opengles.GL10_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		void javax.microedition.khronos.opengles.GL10.glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glCopyTexSubImage2D", "(IIIIIIII)V", ref global::javax.microedition.khronos.opengles.GL10_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		void javax.microedition.khronos.opengles.GL10.glCullFace(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glCullFace", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDeleteTextures", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL10_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDeleteTextures", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		void javax.microedition.khronos.opengles.GL10.glDepthFunc(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDepthFunc", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		void javax.microedition.khronos.opengles.GL10.glDepthMask(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDepthMask", "(Z)V", ref global::javax.microedition.khronos.opengles.GL10_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		void javax.microedition.khronos.opengles.GL10.glDepthRangef(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDepthRangef", "(FF)V", ref global::javax.microedition.khronos.opengles.GL10_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		void javax.microedition.khronos.opengles.GL10.glDepthRangex(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDepthRangex", "(II)V", ref global::javax.microedition.khronos.opengles.GL10_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		void javax.microedition.khronos.opengles.GL10.glDisable(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDisable", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		void javax.microedition.khronos.opengles.GL10.glDisableClientState(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDisableClientState", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		void javax.microedition.khronos.opengles.GL10.glDrawArrays(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDrawArrays", "(III)V", ref global::javax.microedition.khronos.opengles.GL10_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		void javax.microedition.khronos.opengles.GL10.glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDrawElements", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		void javax.microedition.khronos.opengles.GL10.glEnable(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glEnable", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		void javax.microedition.khronos.opengles.GL10.glEnableClientState(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glEnableClientState", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		void javax.microedition.khronos.opengles.GL10.glFinish()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFinish", "()V", ref global::javax.microedition.khronos.opengles.GL10_._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		void javax.microedition.khronos.opengles.GL10.glFlush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFlush", "()V", ref global::javax.microedition.khronos.opengles.GL10_._m34);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		void javax.microedition.khronos.opengles.GL10.glFogf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogf", "(IF)V", ref global::javax.microedition.khronos.opengles.GL10_._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogfv", "(I[FI)V", ref global::javax.microedition.khronos.opengles.GL10_._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogfv", "(ILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		void javax.microedition.khronos.opengles.GL10.glFogx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogx", "(II)V", ref global::javax.microedition.khronos.opengles.GL10_._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogxv", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL10_._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogxv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		void javax.microedition.khronos.opengles.GL10.glFrontFace(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFrontFace", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		void javax.microedition.khronos.opengles.GL10.glFrustumf(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFrustumf", "(FFFFFF)V", ref global::javax.microedition.khronos.opengles.GL10_._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		void javax.microedition.khronos.opengles.GL10.glFrustumx(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFrustumx", "(IIIIII)V", ref global::javax.microedition.khronos.opengles.GL10_._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGenTextures", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL10_._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGenTextures", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		int javax.microedition.khronos.opengles.GL10.glGetError()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGetError", "()I", ref global::javax.microedition.khronos.opengles.GL10_._m46);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGetIntegerv", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL10_._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		global::java.lang.String javax.microedition.khronos.opengles.GL10.glGetString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGetString", "(I)Ljava/lang/String;", ref global::javax.microedition.khronos.opengles.GL10_._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m50;
		void javax.microedition.khronos.opengles.GL10.glHint(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glHint", "(II)V", ref global::javax.microedition.khronos.opengles.GL10_._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		void javax.microedition.khronos.opengles.GL10.glLightModelf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelf", "(IF)V", ref global::javax.microedition.khronos.opengles.GL10_._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelfv", "(I[FI)V", ref global::javax.microedition.khronos.opengles.GL10_._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelfv", "(ILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		void javax.microedition.khronos.opengles.GL10.glLightModelx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelx", "(II)V", ref global::javax.microedition.khronos.opengles.GL10_._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelxv", "(I[II)V", ref global::javax.microedition.khronos.opengles.GL10_._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelxv", "(ILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		void javax.microedition.khronos.opengles.GL10.glLightf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightf", "(IIF)V", ref global::javax.microedition.khronos.opengles.GL10_._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL10_._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		void javax.microedition.khronos.opengles.GL10.glLightx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightx", "(III)V", ref global::javax.microedition.khronos.opengles.GL10_._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL10_._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		void javax.microedition.khronos.opengles.GL10.glLineWidth(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLineWidth", "(F)V", ref global::javax.microedition.khronos.opengles.GL10_._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		void javax.microedition.khronos.opengles.GL10.glLineWidthx(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLineWidthx", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		void javax.microedition.khronos.opengles.GL10.glLoadIdentity()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLoadIdentity", "()V", ref global::javax.microedition.khronos.opengles.GL10_._m65);
		}
		private static global::MonoJavaBridge.MethodId _m66;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLoadMatrixf", "([FI)V", ref global::javax.microedition.khronos.opengles.GL10_._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLoadMatrixx", "([II)V", ref global::javax.microedition.khronos.opengles.GL10_._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLoadMatrixx", "(Ljava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		void javax.microedition.khronos.opengles.GL10.glLogicOp(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLogicOp", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		void javax.microedition.khronos.opengles.GL10.glMaterialf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialf", "(IIF)V", ref global::javax.microedition.khronos.opengles.GL10_._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m72;
		void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL10_._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m73;
		void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m74;
		void javax.microedition.khronos.opengles.GL10.glMaterialx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialx", "(III)V", ref global::javax.microedition.khronos.opengles.GL10_._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m75;
		void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL10_._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m76;
		void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		void javax.microedition.khronos.opengles.GL10.glMatrixMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMatrixMode", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m78;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixf(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultMatrixf", "([FI)V", ref global::javax.microedition.khronos.opengles.GL10_._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m79;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixf(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultMatrixf", "(Ljava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m80;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixx(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultMatrixx", "([II)V", ref global::javax.microedition.khronos.opengles.GL10_._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m81;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixx(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultMatrixx", "(Ljava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m82;
		void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4f(int arg0, float arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultiTexCoord4f", "(IFFFF)V", ref global::javax.microedition.khronos.opengles.GL10_._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m83;
		void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4x(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultiTexCoord4x", "(IIIII)V", ref global::javax.microedition.khronos.opengles.GL10_._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m84;
		void javax.microedition.khronos.opengles.GL10.glNormal3f(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glNormal3f", "(FFF)V", ref global::javax.microedition.khronos.opengles.GL10_._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m85;
		void javax.microedition.khronos.opengles.GL10.glNormal3x(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glNormal3x", "(III)V", ref global::javax.microedition.khronos.opengles.GL10_._m85, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m86;
		void javax.microedition.khronos.opengles.GL10.glNormalPointer(int arg0, int arg1, java.nio.Buffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glNormalPointer", "(IILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m86, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m87;
		void javax.microedition.khronos.opengles.GL10.glOrthof(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glOrthof", "(FFFFFF)V", ref global::javax.microedition.khronos.opengles.GL10_._m87, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m88;
		void javax.microedition.khronos.opengles.GL10.glOrthox(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glOrthox", "(IIIIII)V", ref global::javax.microedition.khronos.opengles.GL10_._m88, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m89;
		void javax.microedition.khronos.opengles.GL10.glPixelStorei(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPixelStorei", "(II)V", ref global::javax.microedition.khronos.opengles.GL10_._m89, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m90;
		void javax.microedition.khronos.opengles.GL10.glPointSize(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPointSize", "(F)V", ref global::javax.microedition.khronos.opengles.GL10_._m90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m91;
		void javax.microedition.khronos.opengles.GL10.glPointSizex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPointSizex", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m91, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m92;
		void javax.microedition.khronos.opengles.GL10.glPolygonOffset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPolygonOffset", "(FF)V", ref global::javax.microedition.khronos.opengles.GL10_._m92, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m93;
		void javax.microedition.khronos.opengles.GL10.glPolygonOffsetx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPolygonOffsetx", "(II)V", ref global::javax.microedition.khronos.opengles.GL10_._m93, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m94;
		void javax.microedition.khronos.opengles.GL10.glPopMatrix()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPopMatrix", "()V", ref global::javax.microedition.khronos.opengles.GL10_._m94);
		}
		private static global::MonoJavaBridge.MethodId _m95;
		void javax.microedition.khronos.opengles.GL10.glPushMatrix()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPushMatrix", "()V", ref global::javax.microedition.khronos.opengles.GL10_._m95);
		}
		private static global::MonoJavaBridge.MethodId _m96;
		void javax.microedition.khronos.opengles.GL10.glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glReadPixels", "(IIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m96, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m97;
		void javax.microedition.khronos.opengles.GL10.glRotatef(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glRotatef", "(FFFF)V", ref global::javax.microedition.khronos.opengles.GL10_._m97, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m98;
		void javax.microedition.khronos.opengles.GL10.glRotatex(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glRotatex", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL10_._m98, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m99;
		void javax.microedition.khronos.opengles.GL10.glSampleCoverage(float arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glSampleCoverage", "(FZ)V", ref global::javax.microedition.khronos.opengles.GL10_._m99, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m100;
		void javax.microedition.khronos.opengles.GL10.glSampleCoveragex(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glSampleCoveragex", "(IZ)V", ref global::javax.microedition.khronos.opengles.GL10_._m100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m101;
		void javax.microedition.khronos.opengles.GL10.glScalef(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glScalef", "(FFF)V", ref global::javax.microedition.khronos.opengles.GL10_._m101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m102;
		void javax.microedition.khronos.opengles.GL10.glScalex(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glScalex", "(III)V", ref global::javax.microedition.khronos.opengles.GL10_._m102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m103;
		void javax.microedition.khronos.opengles.GL10.glScissor(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glScissor", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL10_._m103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m104;
		void javax.microedition.khronos.opengles.GL10.glShadeModel(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glShadeModel", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m105;
		void javax.microedition.khronos.opengles.GL10.glStencilFunc(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glStencilFunc", "(III)V", ref global::javax.microedition.khronos.opengles.GL10_._m105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m106;
		void javax.microedition.khronos.opengles.GL10.glStencilMask(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glStencilMask", "(I)V", ref global::javax.microedition.khronos.opengles.GL10_._m106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m107;
		void javax.microedition.khronos.opengles.GL10.glStencilOp(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glStencilOp", "(III)V", ref global::javax.microedition.khronos.opengles.GL10_._m107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m108;
		void javax.microedition.khronos.opengles.GL10.glTexCoordPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexCoordPointer", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m109;
		void javax.microedition.khronos.opengles.GL10.glTexEnvf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvf", "(IIF)V", ref global::javax.microedition.khronos.opengles.GL10_._m109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m110;
		void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvfv", "(II[FI)V", ref global::javax.microedition.khronos.opengles.GL10_._m110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m111;
		void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m112;
		void javax.microedition.khronos.opengles.GL10.glTexEnvx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvx", "(III)V", ref global::javax.microedition.khronos.opengles.GL10_._m112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m113;
		void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvxv", "(II[II)V", ref global::javax.microedition.khronos.opengles.GL10_._m113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m114;
		void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m115;
		void javax.microedition.khronos.opengles.GL10.glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		private static global::MonoJavaBridge.MethodId _m116;
		void javax.microedition.khronos.opengles.GL10.glTexParameterf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexParameterf", "(IIF)V", ref global::javax.microedition.khronos.opengles.GL10_._m116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m117;
		void javax.microedition.khronos.opengles.GL10.glTexParameterx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexParameterx", "(III)V", ref global::javax.microedition.khronos.opengles.GL10_._m117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m118;
		void javax.microedition.khronos.opengles.GL10.glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		private static global::MonoJavaBridge.MethodId _m119;
		void javax.microedition.khronos.opengles.GL10.glTranslatef(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTranslatef", "(FFF)V", ref global::javax.microedition.khronos.opengles.GL10_._m119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m120;
		void javax.microedition.khronos.opengles.GL10.glTranslatex(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTranslatex", "(III)V", ref global::javax.microedition.khronos.opengles.GL10_._m120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m121;
		void javax.microedition.khronos.opengles.GL10.glVertexPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glVertexPointer", "(IIILjava/nio/Buffer;)V", ref global::javax.microedition.khronos.opengles.GL10_._m121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m122;
		void javax.microedition.khronos.opengles.GL10.glViewport(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.microedition.khronos.opengles.GL10_.staticClass, "glViewport", "(IIII)V", ref global::javax.microedition.khronos.opengles.GL10_._m122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		static GL10_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.opengles.GL10_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/opengles/GL10"));
		}
	}
}
