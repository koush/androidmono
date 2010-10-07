namespace javax.microedition.khronos.opengles
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
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

	public partial class GL10_
	{
		public static global::java.lang.Class _class
		{
			get { return __GL10.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __GL10 : java.lang.Object, GL10
	{
		internal static global::java.lang.Class staticClass;
		static __GL10()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::javax.microedition.khronos.opengles.__GL10), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::javax.microedition.khronos.opengles.__GL10(@__env);
			}
		}
		internal __GL10(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _glActiveTexture13962;
		 void javax.microedition.khronos.opengles.GL10.glActiveTexture(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glActiveTexture13962, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glActiveTexture13962, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glAlphaFunc13963;
		 void javax.microedition.khronos.opengles.GL10.glAlphaFunc(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glAlphaFunc13963, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glAlphaFunc13963, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glAlphaFuncx13964;
		 void javax.microedition.khronos.opengles.GL10.glAlphaFuncx(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glAlphaFuncx13964, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glAlphaFuncx13964, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBindTexture13965;
		 void javax.microedition.khronos.opengles.GL10.glBindTexture(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glBindTexture13965, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glBindTexture13965, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glBlendFunc13966;
		 void javax.microedition.khronos.opengles.GL10.glBlendFunc(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glBlendFunc13966, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glBlendFunc13966, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClear13967;
		 void javax.microedition.khronos.opengles.GL10.glClear(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glClear13967, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glClear13967, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClearColor13968;
		 void javax.microedition.khronos.opengles.GL10.glClearColor(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glClearColor13968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glClearColor13968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClearColorx13969;
		 void javax.microedition.khronos.opengles.GL10.glClearColorx(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glClearColorx13969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glClearColorx13969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClearDepthf13970;
		 void javax.microedition.khronos.opengles.GL10.glClearDepthf(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glClearDepthf13970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glClearDepthf13970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClearDepthx13971;
		 void javax.microedition.khronos.opengles.GL10.glClearDepthx(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glClearDepthx13971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glClearDepthx13971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClearStencil13972;
		 void javax.microedition.khronos.opengles.GL10.glClearStencil(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glClearStencil13972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glClearStencil13972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glClientActiveTexture13973;
		 void javax.microedition.khronos.opengles.GL10.glClientActiveTexture(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glClientActiveTexture13973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glClientActiveTexture13973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glColor4f13974;
		 void javax.microedition.khronos.opengles.GL10.glColor4f(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glColor4f13974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glColor4f13974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glColor4x13975;
		 void javax.microedition.khronos.opengles.GL10.glColor4x(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glColor4x13975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glColor4x13975, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glColorMask13976;
		 void javax.microedition.khronos.opengles.GL10.glColorMask(bool arg0, bool arg1, bool arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glColorMask13976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glColorMask13976, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glColorPointer13977;
		 void javax.microedition.khronos.opengles.GL10.glColorPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glColorPointer13977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glColorPointer13977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCompressedTexImage2D13978;
		 void javax.microedition.khronos.opengles.GL10.glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glCompressedTexImage2D13978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glCompressedTexImage2D13978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCompressedTexSubImage2D13979;
		 void javax.microedition.khronos.opengles.GL10.glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glCompressedTexSubImage2D13979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glCompressedTexSubImage2D13979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCopyTexImage2D13980;
		 void javax.microedition.khronos.opengles.GL10.glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glCopyTexImage2D13980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glCopyTexImage2D13980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCopyTexSubImage2D13981;
		 void javax.microedition.khronos.opengles.GL10.glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glCopyTexSubImage2D13981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glCopyTexSubImage2D13981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glCullFace13982;
		 void javax.microedition.khronos.opengles.GL10.glCullFace(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glCullFace13982, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glCullFace13982, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteTextures13983;
		 void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDeleteTextures13983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDeleteTextures13983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteTextures13984;
		 void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDeleteTextures13984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDeleteTextures13984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDepthFunc13985;
		 void javax.microedition.khronos.opengles.GL10.glDepthFunc(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDepthFunc13985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDepthFunc13985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDepthMask13986;
		 void javax.microedition.khronos.opengles.GL10.glDepthMask(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDepthMask13986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDepthMask13986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDepthRangef13987;
		 void javax.microedition.khronos.opengles.GL10.glDepthRangef(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDepthRangef13987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDepthRangef13987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDepthRangex13988;
		 void javax.microedition.khronos.opengles.GL10.glDepthRangex(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDepthRangex13988, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDepthRangex13988, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDisable13989;
		 void javax.microedition.khronos.opengles.GL10.glDisable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDisable13989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDisable13989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDisableClientState13990;
		 void javax.microedition.khronos.opengles.GL10.glDisableClientState(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDisableClientState13990, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDisableClientState13990, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawArrays13991;
		 void javax.microedition.khronos.opengles.GL10.glDrawArrays(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDrawArrays13991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDrawArrays13991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glDrawElements13992;
		 void javax.microedition.khronos.opengles.GL10.glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDrawElements13992, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDrawElements13992, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glEnable13993;
		 void javax.microedition.khronos.opengles.GL10.glEnable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glEnable13993, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glEnable13993, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glEnableClientState13994;
		 void javax.microedition.khronos.opengles.GL10.glEnableClientState(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glEnableClientState13994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glEnableClientState13994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFinish13995;
		 void javax.microedition.khronos.opengles.GL10.glFinish() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFinish13995);
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFinish13995);
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFlush13996;
		 void javax.microedition.khronos.opengles.GL10.glFlush() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFlush13996);
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFlush13996);
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFogf13997;
		 void javax.microedition.khronos.opengles.GL10.glFogf(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFogf13997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFogf13997, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFogfv13998;
		 void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, float[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFogfv13998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFogfv13998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFogfv13999;
		 void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFogfv13999, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFogfv13999, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFogx14000;
		 void javax.microedition.khronos.opengles.GL10.glFogx(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFogx14000, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFogx14000, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFogxv14001;
		 void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFogxv14001, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFogxv14001, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFogxv14002;
		 void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFogxv14002, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFogxv14002, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFrontFace14003;
		 void javax.microedition.khronos.opengles.GL10.glFrontFace(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFrontFace14003, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFrontFace14003, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFrustumf14004;
		 void javax.microedition.khronos.opengles.GL10.glFrustumf(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFrustumf14004, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFrustumf14004, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glFrustumx14005;
		 void javax.microedition.khronos.opengles.GL10.glFrustumx(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFrustumx14005, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFrustumx14005, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenTextures14006;
		 void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glGenTextures14006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glGenTextures14006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGenTextures14007;
		 void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glGenTextures14007, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glGenTextures14007, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetError14008;
		 int javax.microedition.khronos.opengles.GL10.glGetError() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::javax.microedition.khronos.opengles.__GL10._glGetError14008);
			else
				return @__env.CallNonVirtualIntMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glGetError14008);
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetIntegerv14009;
		 void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glGetIntegerv14009, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glGetIntegerv14009, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetIntegerv14010;
		 void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glGetIntegerv14010, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glGetIntegerv14010, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glGetString14011;
		 global::java.lang.String javax.microedition.khronos.opengles.GL10.glGetString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::javax.microedition.khronos.opengles.__GL10._glGetString14011, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glGetString14011, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glHint14012;
		 void javax.microedition.khronos.opengles.GL10.glHint(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glHint14012, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glHint14012, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelf14013;
		 void javax.microedition.khronos.opengles.GL10.glLightModelf(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightModelf14013, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightModelf14013, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelfv14014;
		 void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, float[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightModelfv14014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightModelfv14014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelfv14015;
		 void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, java.nio.FloatBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightModelfv14015, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightModelfv14015, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelx14016;
		 void javax.microedition.khronos.opengles.GL10.glLightModelx(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightModelx14016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightModelx14016, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxv14017;
		 void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, int[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightModelxv14017, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightModelxv14017, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxv14018;
		 void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, java.nio.IntBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightModelxv14018, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightModelxv14018, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightf14019;
		 void javax.microedition.khronos.opengles.GL10.glLightf(int arg0, int arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightf14019, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightf14019, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightfv14020;
		 void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightfv14020, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightfv14020, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightfv14021;
		 void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightfv14021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightfv14021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightx14022;
		 void javax.microedition.khronos.opengles.GL10.glLightx(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightx14022, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightx14022, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightxv14023;
		 void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightxv14023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightxv14023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLightxv14024;
		 void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightxv14024, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightxv14024, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLineWidth14025;
		 void javax.microedition.khronos.opengles.GL10.glLineWidth(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLineWidth14025, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLineWidth14025, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLineWidthx14026;
		 void javax.microedition.khronos.opengles.GL10.glLineWidthx(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLineWidthx14026, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLineWidthx14026, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLoadIdentity14027;
		 void javax.microedition.khronos.opengles.GL10.glLoadIdentity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLoadIdentity14027);
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLoadIdentity14027);
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixf14028;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(float[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixf14028, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixf14028, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixf14029;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(java.nio.FloatBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixf14029, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixf14029, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixx14030;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(int[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixx14030, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixx14030, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixx14031;
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(java.nio.IntBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixx14031, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixx14031, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glLogicOp14032;
		 void javax.microedition.khronos.opengles.GL10.glLogicOp(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLogicOp14032, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLogicOp14032, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialf14033;
		 void javax.microedition.khronos.opengles.GL10.glMaterialf(int arg0, int arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMaterialf14033, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMaterialf14033, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialfv14034;
		 void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMaterialfv14034, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMaterialfv14034, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialfv14035;
		 void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMaterialfv14035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMaterialfv14035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialx14036;
		 void javax.microedition.khronos.opengles.GL10.glMaterialx(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMaterialx14036, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMaterialx14036, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxv14037;
		 void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMaterialxv14037, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMaterialxv14037, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxv14038;
		 void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMaterialxv14038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMaterialxv14038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMatrixMode14039;
		 void javax.microedition.khronos.opengles.GL10.glMatrixMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMatrixMode14039, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMatrixMode14039, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixf14040;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixf(float[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixf14040, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixf14040, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixf14041;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixf(java.nio.FloatBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixf14041, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixf14041, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixx14042;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixx(int[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixx14042, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixx14042, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixx14043;
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixx(java.nio.IntBuffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixx14043, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixx14043, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMultiTexCoord4f14044;
		 void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4f(int arg0, float arg1, float arg2, float arg3, float arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMultiTexCoord4f14044, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMultiTexCoord4f14044, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glMultiTexCoord4x14045;
		 void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4x(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMultiTexCoord4x14045, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMultiTexCoord4x14045, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glNormal3f14046;
		 void javax.microedition.khronos.opengles.GL10.glNormal3f(float arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glNormal3f14046, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glNormal3f14046, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glNormal3x14047;
		 void javax.microedition.khronos.opengles.GL10.glNormal3x(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glNormal3x14047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glNormal3x14047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glNormalPointer14048;
		 void javax.microedition.khronos.opengles.GL10.glNormalPointer(int arg0, int arg1, java.nio.Buffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glNormalPointer14048, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glNormalPointer14048, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glOrthof14049;
		 void javax.microedition.khronos.opengles.GL10.glOrthof(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glOrthof14049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glOrthof14049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glOrthox14050;
		 void javax.microedition.khronos.opengles.GL10.glOrthox(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glOrthox14050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glOrthox14050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPixelStorei14051;
		 void javax.microedition.khronos.opengles.GL10.glPixelStorei(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glPixelStorei14051, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glPixelStorei14051, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPointSize14052;
		 void javax.microedition.khronos.opengles.GL10.glPointSize(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glPointSize14052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glPointSize14052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPointSizex14053;
		 void javax.microedition.khronos.opengles.GL10.glPointSizex(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glPointSizex14053, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glPointSizex14053, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPolygonOffset14054;
		 void javax.microedition.khronos.opengles.GL10.glPolygonOffset(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glPolygonOffset14054, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glPolygonOffset14054, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPolygonOffsetx14055;
		 void javax.microedition.khronos.opengles.GL10.glPolygonOffsetx(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glPolygonOffsetx14055, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glPolygonOffsetx14055, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPopMatrix14056;
		 void javax.microedition.khronos.opengles.GL10.glPopMatrix() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glPopMatrix14056);
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glPopMatrix14056);
		}
		internal static global::net.sf.jni4net.jni.MethodId _glPushMatrix14057;
		 void javax.microedition.khronos.opengles.GL10.glPushMatrix() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glPushMatrix14057);
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glPushMatrix14057);
		}
		internal static global::net.sf.jni4net.jni.MethodId _glReadPixels14058;
		 void javax.microedition.khronos.opengles.GL10.glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glReadPixels14058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glReadPixels14058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glRotatef14059;
		 void javax.microedition.khronos.opengles.GL10.glRotatef(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glRotatef14059, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glRotatef14059, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glRotatex14060;
		 void javax.microedition.khronos.opengles.GL10.glRotatex(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glRotatex14060, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glRotatex14060, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glSampleCoverage14061;
		 void javax.microedition.khronos.opengles.GL10.glSampleCoverage(float arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glSampleCoverage14061, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glSampleCoverage14061, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glSampleCoveragex14062;
		 void javax.microedition.khronos.opengles.GL10.glSampleCoveragex(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glSampleCoveragex14062, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glSampleCoveragex14062, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glScalef14063;
		 void javax.microedition.khronos.opengles.GL10.glScalef(float arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glScalef14063, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glScalef14063, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glScalex14064;
		 void javax.microedition.khronos.opengles.GL10.glScalex(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glScalex14064, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glScalex14064, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glScissor14065;
		 void javax.microedition.khronos.opengles.GL10.glScissor(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glScissor14065, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glScissor14065, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glShadeModel14066;
		 void javax.microedition.khronos.opengles.GL10.glShadeModel(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glShadeModel14066, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glShadeModel14066, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glStencilFunc14067;
		 void javax.microedition.khronos.opengles.GL10.glStencilFunc(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glStencilFunc14067, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glStencilFunc14067, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glStencilMask14068;
		 void javax.microedition.khronos.opengles.GL10.glStencilMask(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glStencilMask14068, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glStencilMask14068, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glStencilOp14069;
		 void javax.microedition.khronos.opengles.GL10.glStencilOp(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glStencilOp14069, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glStencilOp14069, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexCoordPointer14070;
		 void javax.microedition.khronos.opengles.GL10.glTexCoordPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexCoordPointer14070, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexCoordPointer14070, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvf14071;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvf(int arg0, int arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexEnvf14071, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexEnvf14071, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvfv14072;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexEnvfv14072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexEnvfv14072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvfv14073;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexEnvfv14073, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexEnvfv14073, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvx14074;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvx(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexEnvx14074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexEnvx14074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxv14075;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexEnvxv14075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexEnvxv14075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxv14076;
		 void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexEnvxv14076, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexEnvxv14076, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexImage2D14077;
		 void javax.microedition.khronos.opengles.GL10.glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexImage2D14077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexImage2D14077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterf14078;
		 void javax.microedition.khronos.opengles.GL10.glTexParameterf(int arg0, int arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexParameterf14078, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexParameterf14078, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterx14079;
		 void javax.microedition.khronos.opengles.GL10.glTexParameterx(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexParameterx14079, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexParameterx14079, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTexSubImage2D14080;
		 void javax.microedition.khronos.opengles.GL10.glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexSubImage2D14080, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexSubImage2D14080, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTranslatef14081;
		 void javax.microedition.khronos.opengles.GL10.glTranslatef(float arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTranslatef14081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTranslatef14081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glTranslatex14082;
		 void javax.microedition.khronos.opengles.GL10.glTranslatex(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTranslatex14082, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTranslatex14082, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glVertexPointer14083;
		 void javax.microedition.khronos.opengles.GL10.glVertexPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glVertexPointer14083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glVertexPointer14083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _glViewport14084;
		 void javax.microedition.khronos.opengles.GL10.glViewport(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glViewport14084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glViewport14084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::javax.microedition.khronos.opengles.__GL10.staticClass = @__class;
			global::javax.microedition.khronos.opengles.__GL10._glActiveTexture13962 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glActiveTexture", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glAlphaFunc13963 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glAlphaFunc", "(IF)V");
			global::javax.microedition.khronos.opengles.__GL10._glAlphaFuncx13964 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glAlphaFuncx", "(II)V");
			global::javax.microedition.khronos.opengles.__GL10._glBindTexture13965 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glBindTexture", "(II)V");
			global::javax.microedition.khronos.opengles.__GL10._glBlendFunc13966 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glBlendFunc", "(II)V");
			global::javax.microedition.khronos.opengles.__GL10._glClear13967 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glClear", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glClearColor13968 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glClearColor", "(FFFF)V");
			global::javax.microedition.khronos.opengles.__GL10._glClearColorx13969 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glClearColorx", "(IIII)V");
			global::javax.microedition.khronos.opengles.__GL10._glClearDepthf13970 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glClearDepthf", "(F)V");
			global::javax.microedition.khronos.opengles.__GL10._glClearDepthx13971 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glClearDepthx", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glClearStencil13972 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glClearStencil", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glClientActiveTexture13973 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glClientActiveTexture", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glColor4f13974 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glColor4f", "(FFFF)V");
			global::javax.microedition.khronos.opengles.__GL10._glColor4x13975 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glColor4x", "(IIII)V");
			global::javax.microedition.khronos.opengles.__GL10._glColorMask13976 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glColorMask", "(ZZZZ)V");
			global::javax.microedition.khronos.opengles.__GL10._glColorPointer13977 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glColorPointer", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glCompressedTexImage2D13978 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glCompressedTexSubImage2D13979 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glCopyTexImage2D13980 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glCopyTexImage2D", "(IIIIIIII)V");
			global::javax.microedition.khronos.opengles.__GL10._glCopyTexSubImage2D13981 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glCopyTexSubImage2D", "(IIIIIIII)V");
			global::javax.microedition.khronos.opengles.__GL10._glCullFace13982 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glCullFace", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glDeleteTextures13983 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDeleteTextures", "(I[II)V");
			global::javax.microedition.khronos.opengles.__GL10._glDeleteTextures13984 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDeleteTextures", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glDepthFunc13985 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDepthFunc", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glDepthMask13986 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDepthMask", "(Z)V");
			global::javax.microedition.khronos.opengles.__GL10._glDepthRangef13987 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDepthRangef", "(FF)V");
			global::javax.microedition.khronos.opengles.__GL10._glDepthRangex13988 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDepthRangex", "(II)V");
			global::javax.microedition.khronos.opengles.__GL10._glDisable13989 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDisable", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glDisableClientState13990 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDisableClientState", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glDrawArrays13991 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDrawArrays", "(III)V");
			global::javax.microedition.khronos.opengles.__GL10._glDrawElements13992 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDrawElements", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glEnable13993 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glEnable", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glEnableClientState13994 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glEnableClientState", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glFinish13995 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFinish", "()V");
			global::javax.microedition.khronos.opengles.__GL10._glFlush13996 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFlush", "()V");
			global::javax.microedition.khronos.opengles.__GL10._glFogf13997 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFogf", "(IF)V");
			global::javax.microedition.khronos.opengles.__GL10._glFogfv13998 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFogfv", "(I[FI)V");
			global::javax.microedition.khronos.opengles.__GL10._glFogfv13999 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFogfv", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glFogx14000 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFogx", "(II)V");
			global::javax.microedition.khronos.opengles.__GL10._glFogxv14001 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFogxv", "(I[II)V");
			global::javax.microedition.khronos.opengles.__GL10._glFogxv14002 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFogxv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glFrontFace14003 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFrontFace", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glFrustumf14004 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFrustumf", "(FFFFFF)V");
			global::javax.microedition.khronos.opengles.__GL10._glFrustumx14005 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFrustumx", "(IIIIII)V");
			global::javax.microedition.khronos.opengles.__GL10._glGenTextures14006 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glGenTextures", "(I[II)V");
			global::javax.microedition.khronos.opengles.__GL10._glGenTextures14007 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glGenTextures", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glGetError14008 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glGetError", "()I");
			global::javax.microedition.khronos.opengles.__GL10._glGetIntegerv14009 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glGetIntegerv", "(I[II)V");
			global::javax.microedition.khronos.opengles.__GL10._glGetIntegerv14010 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glGetIntegerv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glGetString14011 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glGetString", "(I)Ljava/lang/String;");
			global::javax.microedition.khronos.opengles.__GL10._glHint14012 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glHint", "(II)V");
			global::javax.microedition.khronos.opengles.__GL10._glLightModelf14013 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightModelf", "(IF)V");
			global::javax.microedition.khronos.opengles.__GL10._glLightModelfv14014 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightModelfv", "(I[FI)V");
			global::javax.microedition.khronos.opengles.__GL10._glLightModelfv14015 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightModelfv", "(ILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glLightModelx14016 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightModelx", "(II)V");
			global::javax.microedition.khronos.opengles.__GL10._glLightModelxv14017 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightModelxv", "(I[II)V");
			global::javax.microedition.khronos.opengles.__GL10._glLightModelxv14018 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightModelxv", "(ILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glLightf14019 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightf", "(IIF)V");
			global::javax.microedition.khronos.opengles.__GL10._glLightfv14020 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.__GL10._glLightfv14021 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glLightx14022 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightx", "(III)V");
			global::javax.microedition.khronos.opengles.__GL10._glLightxv14023 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.__GL10._glLightxv14024 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glLineWidth14025 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLineWidth", "(F)V");
			global::javax.microedition.khronos.opengles.__GL10._glLineWidthx14026 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLineWidthx", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glLoadIdentity14027 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLoadIdentity", "()V");
			global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixf14028 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLoadMatrixf", "([FI)V");
			global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixf14029 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixx14030 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLoadMatrixx", "([II)V");
			global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixx14031 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLoadMatrixx", "(Ljava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glLogicOp14032 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLogicOp", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glMaterialf14033 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMaterialf", "(IIF)V");
			global::javax.microedition.khronos.opengles.__GL10._glMaterialfv14034 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMaterialfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.__GL10._glMaterialfv14035 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMaterialfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glMaterialx14036 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMaterialx", "(III)V");
			global::javax.microedition.khronos.opengles.__GL10._glMaterialxv14037 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMaterialxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.__GL10._glMaterialxv14038 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMaterialxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glMatrixMode14039 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMatrixMode", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glMultMatrixf14040 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMultMatrixf", "([FI)V");
			global::javax.microedition.khronos.opengles.__GL10._glMultMatrixf14041 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMultMatrixf", "(Ljava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glMultMatrixx14042 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMultMatrixx", "([II)V");
			global::javax.microedition.khronos.opengles.__GL10._glMultMatrixx14043 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMultMatrixx", "(Ljava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glMultiTexCoord4f14044 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMultiTexCoord4f", "(IFFFF)V");
			global::javax.microedition.khronos.opengles.__GL10._glMultiTexCoord4x14045 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMultiTexCoord4x", "(IIIII)V");
			global::javax.microedition.khronos.opengles.__GL10._glNormal3f14046 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glNormal3f", "(FFF)V");
			global::javax.microedition.khronos.opengles.__GL10._glNormal3x14047 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glNormal3x", "(III)V");
			global::javax.microedition.khronos.opengles.__GL10._glNormalPointer14048 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glNormalPointer", "(IILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glOrthof14049 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glOrthof", "(FFFFFF)V");
			global::javax.microedition.khronos.opengles.__GL10._glOrthox14050 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glOrthox", "(IIIIII)V");
			global::javax.microedition.khronos.opengles.__GL10._glPixelStorei14051 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glPixelStorei", "(II)V");
			global::javax.microedition.khronos.opengles.__GL10._glPointSize14052 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glPointSize", "(F)V");
			global::javax.microedition.khronos.opengles.__GL10._glPointSizex14053 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glPointSizex", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glPolygonOffset14054 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glPolygonOffset", "(FF)V");
			global::javax.microedition.khronos.opengles.__GL10._glPolygonOffsetx14055 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glPolygonOffsetx", "(II)V");
			global::javax.microedition.khronos.opengles.__GL10._glPopMatrix14056 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glPopMatrix", "()V");
			global::javax.microedition.khronos.opengles.__GL10._glPushMatrix14057 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glPushMatrix", "()V");
			global::javax.microedition.khronos.opengles.__GL10._glReadPixels14058 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glReadPixels", "(IIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glRotatef14059 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glRotatef", "(FFFF)V");
			global::javax.microedition.khronos.opengles.__GL10._glRotatex14060 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glRotatex", "(IIII)V");
			global::javax.microedition.khronos.opengles.__GL10._glSampleCoverage14061 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glSampleCoverage", "(FZ)V");
			global::javax.microedition.khronos.opengles.__GL10._glSampleCoveragex14062 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glSampleCoveragex", "(IZ)V");
			global::javax.microedition.khronos.opengles.__GL10._glScalef14063 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glScalef", "(FFF)V");
			global::javax.microedition.khronos.opengles.__GL10._glScalex14064 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glScalex", "(III)V");
			global::javax.microedition.khronos.opengles.__GL10._glScissor14065 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glScissor", "(IIII)V");
			global::javax.microedition.khronos.opengles.__GL10._glShadeModel14066 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glShadeModel", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glStencilFunc14067 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glStencilFunc", "(III)V");
			global::javax.microedition.khronos.opengles.__GL10._glStencilMask14068 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glStencilMask", "(I)V");
			global::javax.microedition.khronos.opengles.__GL10._glStencilOp14069 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glStencilOp", "(III)V");
			global::javax.microedition.khronos.opengles.__GL10._glTexCoordPointer14070 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexCoordPointer", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glTexEnvf14071 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexEnvf", "(IIF)V");
			global::javax.microedition.khronos.opengles.__GL10._glTexEnvfv14072 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexEnvfv", "(II[FI)V");
			global::javax.microedition.khronos.opengles.__GL10._glTexEnvfv14073 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexEnvfv", "(IILjava/nio/FloatBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glTexEnvx14074 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexEnvx", "(III)V");
			global::javax.microedition.khronos.opengles.__GL10._glTexEnvxv14075 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexEnvxv", "(II[II)V");
			global::javax.microedition.khronos.opengles.__GL10._glTexEnvxv14076 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexEnvxv", "(IILjava/nio/IntBuffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glTexImage2D14077 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glTexParameterf14078 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexParameterf", "(IIF)V");
			global::javax.microedition.khronos.opengles.__GL10._glTexParameterx14079 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexParameterx", "(III)V");
			global::javax.microedition.khronos.opengles.__GL10._glTexSubImage2D14080 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glTranslatef14081 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTranslatef", "(FFF)V");
			global::javax.microedition.khronos.opengles.__GL10._glTranslatex14082 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTranslatex", "(III)V");
			global::javax.microedition.khronos.opengles.__GL10._glVertexPointer14083 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glVertexPointer", "(IIILjava/nio/Buffer;)V");
			global::javax.microedition.khronos.opengles.__GL10._glViewport14084 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glViewport", "(IIII)V");
		}
	}
}
