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
		internal static global::MonoJavaBridge.MethodId _glActiveTexture28958;
		void javax.microedition.khronos.opengles.GL10.glActiveTexture(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glActiveTexture28958.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glActiveTexture28958 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glActiveTexture", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glActiveTexture28958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFunc28959;
		void javax.microedition.khronos.opengles.GL10.glAlphaFunc(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glAlphaFunc28959.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glAlphaFunc28959 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glAlphaFunc", "(IF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glAlphaFunc28959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glAlphaFuncx28960;
		void javax.microedition.khronos.opengles.GL10.glAlphaFuncx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glAlphaFuncx28960.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glAlphaFuncx28960 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glAlphaFuncx", "(II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glAlphaFuncx28960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBindTexture28961;
		void javax.microedition.khronos.opengles.GL10.glBindTexture(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glBindTexture28961.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glBindTexture28961 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glBindTexture", "(II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glBindTexture28961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glBlendFunc28962;
		void javax.microedition.khronos.opengles.GL10.glBlendFunc(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glBlendFunc28962.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glBlendFunc28962 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glBlendFunc", "(II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glBlendFunc28962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glClear28963;
		void javax.microedition.khronos.opengles.GL10.glClear(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glClear28963.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glClear28963 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClear", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glClear28963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColor28964;
		void javax.microedition.khronos.opengles.GL10.glClearColor(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glClearColor28964.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glClearColor28964 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClearColor", "(FFFF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glClearColor28964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearColorx28965;
		void javax.microedition.khronos.opengles.GL10.glClearColorx(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glClearColorx28965.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glClearColorx28965 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClearColorx", "(IIII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glClearColorx28965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthf28966;
		void javax.microedition.khronos.opengles.GL10.glClearDepthf(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glClearDepthf28966.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glClearDepthf28966 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClearDepthf", "(F)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glClearDepthf28966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearDepthx28967;
		void javax.microedition.khronos.opengles.GL10.glClearDepthx(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glClearDepthx28967.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glClearDepthx28967 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClearDepthx", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glClearDepthx28967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClearStencil28968;
		void javax.microedition.khronos.opengles.GL10.glClearStencil(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glClearStencil28968.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glClearStencil28968 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClearStencil", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glClearStencil28968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glClientActiveTexture28969;
		void javax.microedition.khronos.opengles.GL10.glClientActiveTexture(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glClientActiveTexture28969.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glClientActiveTexture28969 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glClientActiveTexture", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glClientActiveTexture28969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4f28970;
		void javax.microedition.khronos.opengles.GL10.glColor4f(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glColor4f28970.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glColor4f28970 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glColor4f", "(FFFF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glColor4f28970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColor4x28971;
		void javax.microedition.khronos.opengles.GL10.glColor4x(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glColor4x28971.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glColor4x28971 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glColor4x", "(IIII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glColor4x28971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColorMask28972;
		void javax.microedition.khronos.opengles.GL10.glColorMask(bool arg0, bool arg1, bool arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glColorMask28972.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glColorMask28972 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glColorMask", "(ZZZZ)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glColorMask28972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glColorPointer28973;
		void javax.microedition.khronos.opengles.GL10.glColorPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glColorPointer28973.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glColorPointer28973 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glColorPointer", "(IIILjava/nio/Buffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glColorPointer28973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexImage2D28974;
		void javax.microedition.khronos.opengles.GL10.glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glCompressedTexImage2D28974.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glCompressedTexImage2D28974 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glCompressedTexImage2D28974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCompressedTexSubImage2D28975;
		void javax.microedition.khronos.opengles.GL10.glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glCompressedTexSubImage2D28975.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glCompressedTexSubImage2D28975 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glCompressedTexSubImage2D28975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexImage2D28976;
		void javax.microedition.khronos.opengles.GL10.glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glCopyTexImage2D28976.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glCopyTexImage2D28976 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glCopyTexImage2D", "(IIIIIIII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glCopyTexImage2D28976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCopyTexSubImage2D28977;
		void javax.microedition.khronos.opengles.GL10.glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glCopyTexSubImage2D28977.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glCopyTexSubImage2D28977 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glCopyTexSubImage2D", "(IIIIIIII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glCopyTexSubImage2D28977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _glCullFace28978;
		void javax.microedition.khronos.opengles.GL10.glCullFace(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glCullFace28978.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glCullFace28978 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glCullFace", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glCullFace28978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures28979;
		void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glDeleteTextures28979.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glDeleteTextures28979 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDeleteTextures", "(I[II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDeleteTextures28979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDeleteTextures28980;
		void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glDeleteTextures28980.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glDeleteTextures28980 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDeleteTextures", "(ILjava/nio/IntBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDeleteTextures28980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthFunc28981;
		void javax.microedition.khronos.opengles.GL10.glDepthFunc(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glDepthFunc28981.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glDepthFunc28981 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDepthFunc", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDepthFunc28981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthMask28982;
		void javax.microedition.khronos.opengles.GL10.glDepthMask(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glDepthMask28982.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glDepthMask28982 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDepthMask", "(Z)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDepthMask28982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangef28983;
		void javax.microedition.khronos.opengles.GL10.glDepthRangef(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glDepthRangef28983.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glDepthRangef28983 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDepthRangef", "(FF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDepthRangef28983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDepthRangex28984;
		void javax.microedition.khronos.opengles.GL10.glDepthRangex(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glDepthRangex28984.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glDepthRangex28984 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDepthRangex", "(II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDepthRangex28984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glDisable28985;
		void javax.microedition.khronos.opengles.GL10.glDisable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glDisable28985.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glDisable28985 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDisable", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDisable28985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDisableClientState28986;
		void javax.microedition.khronos.opengles.GL10.glDisableClientState(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glDisableClientState28986.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glDisableClientState28986 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDisableClientState", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDisableClientState28986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawArrays28987;
		void javax.microedition.khronos.opengles.GL10.glDrawArrays(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glDrawArrays28987.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glDrawArrays28987 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDrawArrays", "(III)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDrawArrays28987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glDrawElements28988;
		void javax.microedition.khronos.opengles.GL10.glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glDrawElements28988.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glDrawElements28988 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glDrawElements", "(IIILjava/nio/Buffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glDrawElements28988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glEnable28989;
		void javax.microedition.khronos.opengles.GL10.glEnable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glEnable28989.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glEnable28989 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glEnable", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glEnable28989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glEnableClientState28990;
		void javax.microedition.khronos.opengles.GL10.glEnableClientState(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glEnableClientState28990.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glEnableClientState28990 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glEnableClientState", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glEnableClientState28990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFinish28991;
		void javax.microedition.khronos.opengles.GL10.glFinish()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glFinish28991.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glFinish28991 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFinish", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFinish28991);
		}
		internal static global::MonoJavaBridge.MethodId _glFlush28992;
		void javax.microedition.khronos.opengles.GL10.glFlush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glFlush28992.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glFlush28992 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFlush", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFlush28992);
		}
		internal static global::MonoJavaBridge.MethodId _glFogf28993;
		void javax.microedition.khronos.opengles.GL10.glFogf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glFogf28993.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glFogf28993 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogf", "(IF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFogf28993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogfv28994;
		void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glFogfv28994.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glFogfv28994 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogfv", "(I[FI)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFogfv28994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogfv28995;
		void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glFogfv28995.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glFogfv28995 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogfv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFogfv28995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogx28996;
		void javax.microedition.khronos.opengles.GL10.glFogx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glFogx28996.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glFogx28996 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogx", "(II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFogx28996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxv28997;
		void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glFogxv28997.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glFogxv28997 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogxv", "(I[II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFogxv28997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glFogxv28998;
		void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glFogxv28998.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glFogxv28998 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFogxv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFogxv28998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glFrontFace28999;
		void javax.microedition.khronos.opengles.GL10.glFrontFace(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glFrontFace28999.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glFrontFace28999 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFrontFace", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFrontFace28999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumf29000;
		void javax.microedition.khronos.opengles.GL10.glFrustumf(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glFrustumf29000.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glFrustumf29000 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFrustumf", "(FFFFFF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFrustumf29000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glFrustumx29001;
		void javax.microedition.khronos.opengles.GL10.glFrustumx(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glFrustumx29001.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glFrustumx29001 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glFrustumx", "(IIIIII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glFrustumx29001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures29002;
		void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glGenTextures29002.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glGenTextures29002 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGenTextures", "(I[II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glGenTextures29002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGenTextures29003;
		void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glGenTextures29003.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glGenTextures29003 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGenTextures", "(ILjava/nio/IntBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glGenTextures29003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetError29004;
		int javax.microedition.khronos.opengles.GL10.glGetError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glGetError29004.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glGetError29004 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGetError", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glGetError29004);
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv29005;
		void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glGetIntegerv29005.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glGetIntegerv29005 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGetIntegerv", "(I[II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glGetIntegerv29005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glGetIntegerv29006;
		void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glGetIntegerv29006.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glGetIntegerv29006 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGetIntegerv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glGetIntegerv29006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glGetString29007;
		global::java.lang.String javax.microedition.khronos.opengles.GL10.glGetString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glGetString29007.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glGetString29007 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glGetString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glGetString29007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _glHint29008;
		void javax.microedition.khronos.opengles.GL10.glHint(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glHint29008.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glHint29008 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glHint", "(II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glHint29008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelf29009;
		void javax.microedition.khronos.opengles.GL10.glLightModelf(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLightModelf29009.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLightModelf29009 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelf", "(IF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightModelf29009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelfv29010;
		void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, float[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLightModelfv29010.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLightModelfv29010 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelfv", "(I[FI)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightModelfv29010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelfv29011;
		void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, java.nio.FloatBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLightModelfv29011.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLightModelfv29011 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelfv", "(ILjava/nio/FloatBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightModelfv29011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelx29012;
		void javax.microedition.khronos.opengles.GL10.glLightModelx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLightModelx29012.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLightModelx29012 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelx", "(II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightModelx29012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxv29013;
		void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, int[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLightModelxv29013.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLightModelxv29013 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelxv", "(I[II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightModelxv29013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightModelxv29014;
		void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, java.nio.IntBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLightModelxv29014.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLightModelxv29014 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightModelxv", "(ILjava/nio/IntBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightModelxv29014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLightf29015;
		void javax.microedition.khronos.opengles.GL10.glLightf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLightf29015.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLightf29015 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightf", "(IIF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightf29015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightfv29016;
		void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLightfv29016.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLightfv29016 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightfv", "(II[FI)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightfv29016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightfv29017;
		void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLightfv29017.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLightfv29017 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightfv29017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightx29018;
		void javax.microedition.khronos.opengles.GL10.glLightx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLightx29018.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLightx29018 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightx", "(III)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightx29018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxv29019;
		void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLightxv29019.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLightxv29019 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightxv", "(II[II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightxv29019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glLightxv29020;
		void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLightxv29020.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLightxv29020 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLightxv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLightxv29020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidth29021;
		void javax.microedition.khronos.opengles.GL10.glLineWidth(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLineWidth29021.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLineWidth29021 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLineWidth", "(F)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLineWidth29021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLineWidthx29022;
		void javax.microedition.khronos.opengles.GL10.glLineWidthx(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLineWidthx29022.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLineWidthx29022 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLineWidthx", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLineWidthx29022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadIdentity29023;
		void javax.microedition.khronos.opengles.GL10.glLoadIdentity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLoadIdentity29023.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLoadIdentity29023 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLoadIdentity", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLoadIdentity29023);
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixf29024;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixf29024.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixf29024 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLoadMatrixf", "([FI)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixf29024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixf29025;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixf29025.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixf29025 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixf29025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixx29026;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixx29026.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixx29026 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLoadMatrixx", "([II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixx29026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glLoadMatrixx29027;
		void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixx29027.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixx29027 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLoadMatrixx", "(Ljava/nio/IntBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLoadMatrixx29027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glLogicOp29028;
		void javax.microedition.khronos.opengles.GL10.glLogicOp(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glLogicOp29028.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glLogicOp29028 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glLogicOp", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glLogicOp29028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialf29029;
		void javax.microedition.khronos.opengles.GL10.glMaterialf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glMaterialf29029.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glMaterialf29029 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialf", "(IIF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMaterialf29029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialfv29030;
		void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glMaterialfv29030.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glMaterialfv29030 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialfv", "(II[FI)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMaterialfv29030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialfv29031;
		void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glMaterialfv29031.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glMaterialfv29031 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMaterialfv29031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialx29032;
		void javax.microedition.khronos.opengles.GL10.glMaterialx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glMaterialx29032.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glMaterialx29032 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialx", "(III)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMaterialx29032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxv29033;
		void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glMaterialxv29033.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glMaterialxv29033 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialxv", "(II[II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMaterialxv29033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glMaterialxv29034;
		void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glMaterialxv29034.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glMaterialxv29034 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMaterialxv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMaterialxv29034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glMatrixMode29035;
		void javax.microedition.khronos.opengles.GL10.glMatrixMode(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glMatrixMode29035.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glMatrixMode29035 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMatrixMode", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMatrixMode29035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixf29036;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixf(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glMultMatrixf29036.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glMultMatrixf29036 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultMatrixf", "([FI)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMultMatrixf29036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixf29037;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixf(java.nio.FloatBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glMultMatrixf29037.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glMultMatrixf29037 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultMatrixf", "(Ljava/nio/FloatBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMultMatrixf29037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixx29038;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixx(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glMultMatrixx29038.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glMultMatrixx29038 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultMatrixx", "([II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMultMatrixx29038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glMultMatrixx29039;
		void javax.microedition.khronos.opengles.GL10.glMultMatrixx(java.nio.IntBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glMultMatrixx29039.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glMultMatrixx29039 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultMatrixx", "(Ljava/nio/IntBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMultMatrixx29039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4f29040;
		void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4f(int arg0, float arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glMultiTexCoord4f29040.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glMultiTexCoord4f29040 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultiTexCoord4f", "(IFFFF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMultiTexCoord4f29040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glMultiTexCoord4x29041;
		void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4x(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glMultiTexCoord4x29041.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glMultiTexCoord4x29041 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glMultiTexCoord4x", "(IIIII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glMultiTexCoord4x29041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3f29042;
		void javax.microedition.khronos.opengles.GL10.glNormal3f(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glNormal3f29042.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glNormal3f29042 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glNormal3f", "(FFF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glNormal3f29042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glNormal3x29043;
		void javax.microedition.khronos.opengles.GL10.glNormal3x(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glNormal3x29043.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glNormal3x29043 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glNormal3x", "(III)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glNormal3x29043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glNormalPointer29044;
		void javax.microedition.khronos.opengles.GL10.glNormalPointer(int arg0, int arg1, java.nio.Buffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glNormalPointer29044.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glNormalPointer29044 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glNormalPointer", "(IILjava/nio/Buffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glNormalPointer29044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthof29045;
		void javax.microedition.khronos.opengles.GL10.glOrthof(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glOrthof29045.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glOrthof29045 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glOrthof", "(FFFFFF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glOrthof29045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glOrthox29046;
		void javax.microedition.khronos.opengles.GL10.glOrthox(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glOrthox29046.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glOrthox29046 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glOrthox", "(IIIIII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glOrthox29046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _glPixelStorei29047;
		void javax.microedition.khronos.opengles.GL10.glPixelStorei(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glPixelStorei29047.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glPixelStorei29047 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPixelStorei", "(II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glPixelStorei29047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSize29048;
		void javax.microedition.khronos.opengles.GL10.glPointSize(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glPointSize29048.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glPointSize29048 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPointSize", "(F)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glPointSize29048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPointSizex29049;
		void javax.microedition.khronos.opengles.GL10.glPointSizex(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glPointSizex29049.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glPointSizex29049 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPointSizex", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glPointSizex29049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffset29050;
		void javax.microedition.khronos.opengles.GL10.glPolygonOffset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glPolygonOffset29050.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glPolygonOffset29050 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPolygonOffset", "(FF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glPolygonOffset29050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPolygonOffsetx29051;
		void javax.microedition.khronos.opengles.GL10.glPolygonOffsetx(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glPolygonOffsetx29051.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glPolygonOffsetx29051 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPolygonOffsetx", "(II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glPolygonOffsetx29051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glPopMatrix29052;
		void javax.microedition.khronos.opengles.GL10.glPopMatrix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glPopMatrix29052.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glPopMatrix29052 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPopMatrix", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glPopMatrix29052);
		}
		internal static global::MonoJavaBridge.MethodId _glPushMatrix29053;
		void javax.microedition.khronos.opengles.GL10.glPushMatrix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glPushMatrix29053.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glPushMatrix29053 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glPushMatrix", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glPushMatrix29053);
		}
		internal static global::MonoJavaBridge.MethodId _glReadPixels29054;
		void javax.microedition.khronos.opengles.GL10.glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glReadPixels29054.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glReadPixels29054 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glReadPixels", "(IIIIIILjava/nio/Buffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glReadPixels29054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatef29055;
		void javax.microedition.khronos.opengles.GL10.glRotatef(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glRotatef29055.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glRotatef29055 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glRotatef", "(FFFF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glRotatef29055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glRotatex29056;
		void javax.microedition.khronos.opengles.GL10.glRotatex(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glRotatex29056.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glRotatex29056 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glRotatex", "(IIII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glRotatex29056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoverage29057;
		void javax.microedition.khronos.opengles.GL10.glSampleCoverage(float arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glSampleCoverage29057.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glSampleCoverage29057 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glSampleCoverage", "(FZ)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glSampleCoverage29057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glSampleCoveragex29058;
		void javax.microedition.khronos.opengles.GL10.glSampleCoveragex(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glSampleCoveragex29058.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glSampleCoveragex29058 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glSampleCoveragex", "(IZ)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glSampleCoveragex29058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _glScalef29059;
		void javax.microedition.khronos.opengles.GL10.glScalef(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glScalef29059.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glScalef29059 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glScalef", "(FFF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glScalef29059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glScalex29060;
		void javax.microedition.khronos.opengles.GL10.glScalex(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glScalex29060.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glScalex29060 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glScalex", "(III)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glScalex29060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glScissor29061;
		void javax.microedition.khronos.opengles.GL10.glScissor(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glScissor29061.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glScissor29061 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glScissor", "(IIII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glScissor29061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glShadeModel29062;
		void javax.microedition.khronos.opengles.GL10.glShadeModel(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glShadeModel29062.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glShadeModel29062 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glShadeModel", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glShadeModel29062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilFunc29063;
		void javax.microedition.khronos.opengles.GL10.glStencilFunc(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glStencilFunc29063.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glStencilFunc29063 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glStencilFunc", "(III)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glStencilFunc29063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilMask29064;
		void javax.microedition.khronos.opengles.GL10.glStencilMask(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glStencilMask29064.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glStencilMask29064 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glStencilMask", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glStencilMask29064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _glStencilOp29065;
		void javax.microedition.khronos.opengles.GL10.glStencilOp(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glStencilOp29065.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glStencilOp29065 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glStencilOp", "(III)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glStencilOp29065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexCoordPointer29066;
		void javax.microedition.khronos.opengles.GL10.glTexCoordPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glTexCoordPointer29066.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glTexCoordPointer29066 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexCoordPointer", "(IIILjava/nio/Buffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexCoordPointer29066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvf29067;
		void javax.microedition.khronos.opengles.GL10.glTexEnvf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glTexEnvf29067.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glTexEnvf29067 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvf", "(IIF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexEnvf29067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv29068;
		void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glTexEnvfv29068.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glTexEnvfv29068 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvfv", "(II[FI)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexEnvfv29068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvfv29069;
		void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glTexEnvfv29069.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glTexEnvfv29069 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvfv", "(IILjava/nio/FloatBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexEnvfv29069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvx29070;
		void javax.microedition.khronos.opengles.GL10.glTexEnvx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glTexEnvx29070.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glTexEnvx29070 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvx", "(III)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexEnvx29070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv29071;
		void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glTexEnvxv29071.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glTexEnvxv29071 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvxv", "(II[II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexEnvxv29071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glTexEnvxv29072;
		void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glTexEnvxv29072.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glTexEnvxv29072 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexEnvxv29072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexImage2D29073;
		void javax.microedition.khronos.opengles.GL10.glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glTexImage2D29073.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glTexImage2D29073 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexImage2D29073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterf29074;
		void javax.microedition.khronos.opengles.GL10.glTexParameterf(int arg0, int arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glTexParameterf29074.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glTexParameterf29074 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexParameterf", "(IIF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexParameterf29074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexParameterx29075;
		void javax.microedition.khronos.opengles.GL10.glTexParameterx(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glTexParameterx29075.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glTexParameterx29075 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexParameterx", "(III)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexParameterx29075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTexSubImage2D29076;
		void javax.microedition.khronos.opengles.GL10.glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glTexSubImage2D29076.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glTexSubImage2D29076 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTexSubImage2D29076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatef29077;
		void javax.microedition.khronos.opengles.GL10.glTranslatef(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glTranslatef29077.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glTranslatef29077 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTranslatef", "(FFF)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTranslatef29077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glTranslatex29078;
		void javax.microedition.khronos.opengles.GL10.glTranslatex(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glTranslatex29078.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glTranslatex29078 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glTranslatex", "(III)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glTranslatex29078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _glVertexPointer29079;
		void javax.microedition.khronos.opengles.GL10.glVertexPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glVertexPointer29079.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glVertexPointer29079 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glVertexPointer", "(IIILjava/nio/Buffer;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glVertexPointer29079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _glViewport29080;
		void javax.microedition.khronos.opengles.GL10.glViewport(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.opengles.GL10_._glViewport29080.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.opengles.GL10_._glViewport29080 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.opengles.GL10_.staticClass, "glViewport", "(IIII)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.microedition.khronos.opengles.GL10_._glViewport29080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		static GL10_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.opengles.GL10_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/opengles/GL10"));
		}
		internal static void InitJNI()
		{
		}
	}
}
