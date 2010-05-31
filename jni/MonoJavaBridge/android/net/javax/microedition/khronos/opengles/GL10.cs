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
		internal static global::net.sf.jni4net.jni.MethodId _glActiveTexture13131; 
		 void javax.microedition.khronos.opengles.GL10.glActiveTexture(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glActiveTexture13131, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glActiveTexture13131, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glAlphaFunc13132; 
		 void javax.microedition.khronos.opengles.GL10.glAlphaFunc(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glAlphaFunc13132, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glAlphaFunc13132, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glAlphaFuncx13133; 
		 void javax.microedition.khronos.opengles.GL10.glAlphaFuncx(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glAlphaFuncx13133, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glAlphaFuncx13133, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBindTexture13134; 
		 void javax.microedition.khronos.opengles.GL10.glBindTexture(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glBindTexture13134, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glBindTexture13134, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glBlendFunc13135; 
		 void javax.microedition.khronos.opengles.GL10.glBlendFunc(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glBlendFunc13135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glBlendFunc13135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClear13136; 
		 void javax.microedition.khronos.opengles.GL10.glClear(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glClear13136, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glClear13136, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearColor13137; 
		 void javax.microedition.khronos.opengles.GL10.glClearColor(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glClearColor13137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glClearColor13137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearColorx13138; 
		 void javax.microedition.khronos.opengles.GL10.glClearColorx(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glClearColorx13138, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glClearColorx13138, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearDepthf13139; 
		 void javax.microedition.khronos.opengles.GL10.glClearDepthf(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glClearDepthf13139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glClearDepthf13139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearDepthx13140; 
		 void javax.microedition.khronos.opengles.GL10.glClearDepthx(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glClearDepthx13140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glClearDepthx13140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClearStencil13141; 
		 void javax.microedition.khronos.opengles.GL10.glClearStencil(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glClearStencil13141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glClearStencil13141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glClientActiveTexture13142; 
		 void javax.microedition.khronos.opengles.GL10.glClientActiveTexture(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glClientActiveTexture13142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glClientActiveTexture13142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glColor4f13143; 
		 void javax.microedition.khronos.opengles.GL10.glColor4f(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glColor4f13143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glColor4f13143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glColor4x13144; 
		 void javax.microedition.khronos.opengles.GL10.glColor4x(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glColor4x13144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glColor4x13144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glColorMask13145; 
		 void javax.microedition.khronos.opengles.GL10.glColorMask(bool arg0, bool arg1, bool arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glColorMask13145, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glColorMask13145, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glColorPointer13146; 
		 void javax.microedition.khronos.opengles.GL10.glColorPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glColorPointer13146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glColorPointer13146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCompressedTexImage2D13147; 
		 void javax.microedition.khronos.opengles.GL10.glCompressedTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.nio.Buffer arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glCompressedTexImage2D13147, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glCompressedTexImage2D13147, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCompressedTexSubImage2D13148; 
		 void javax.microedition.khronos.opengles.GL10.glCompressedTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glCompressedTexSubImage2D13148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glCompressedTexSubImage2D13148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCopyTexImage2D13149; 
		 void javax.microedition.khronos.opengles.GL10.glCopyTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glCopyTexImage2D13149, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glCopyTexImage2D13149, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCopyTexSubImage2D13150; 
		 void javax.microedition.khronos.opengles.GL10.glCopyTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glCopyTexSubImage2D13150, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glCopyTexSubImage2D13150, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glCullFace13151; 
		 void javax.microedition.khronos.opengles.GL10.glCullFace(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glCullFace13151, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glCullFace13151, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteTextures13152; 
		 void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDeleteTextures13152, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDeleteTextures13152, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDeleteTextures13153; 
		 void javax.microedition.khronos.opengles.GL10.glDeleteTextures(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDeleteTextures13153, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDeleteTextures13153, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthFunc13154; 
		 void javax.microedition.khronos.opengles.GL10.glDepthFunc(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDepthFunc13154, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDepthFunc13154, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthMask13155; 
		 void javax.microedition.khronos.opengles.GL10.glDepthMask(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDepthMask13155, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDepthMask13155, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthRangef13156; 
		 void javax.microedition.khronos.opengles.GL10.glDepthRangef(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDepthRangef13156, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDepthRangef13156, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDepthRangex13157; 
		 void javax.microedition.khronos.opengles.GL10.glDepthRangex(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDepthRangex13157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDepthRangex13157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDisable13158; 
		 void javax.microedition.khronos.opengles.GL10.glDisable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDisable13158, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDisable13158, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDisableClientState13159; 
		 void javax.microedition.khronos.opengles.GL10.glDisableClientState(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDisableClientState13159, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDisableClientState13159, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawArrays13160; 
		 void javax.microedition.khronos.opengles.GL10.glDrawArrays(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDrawArrays13160, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDrawArrays13160, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glDrawElements13161; 
		 void javax.microedition.khronos.opengles.GL10.glDrawElements(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glDrawElements13161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glDrawElements13161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glEnable13162; 
		 void javax.microedition.khronos.opengles.GL10.glEnable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glEnable13162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glEnable13162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glEnableClientState13163; 
		 void javax.microedition.khronos.opengles.GL10.glEnableClientState(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glEnableClientState13163, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glEnableClientState13163, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFinish13164; 
		 void javax.microedition.khronos.opengles.GL10.glFinish() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFinish13164); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFinish13164); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFlush13165; 
		 void javax.microedition.khronos.opengles.GL10.glFlush() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFlush13165); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFlush13165); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogf13166; 
		 void javax.microedition.khronos.opengles.GL10.glFogf(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFogf13166, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFogf13166, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogfv13167; 
		 void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, float[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFogfv13167, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFogfv13167, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogfv13168; 
		 void javax.microedition.khronos.opengles.GL10.glFogfv(int arg0, java.nio.FloatBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFogfv13168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFogfv13168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogx13169; 
		 void javax.microedition.khronos.opengles.GL10.glFogx(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFogx13169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFogx13169, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogxv13170; 
		 void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFogxv13170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFogxv13170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFogxv13171; 
		 void javax.microedition.khronos.opengles.GL10.glFogxv(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFogxv13171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFogxv13171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFrontFace13172; 
		 void javax.microedition.khronos.opengles.GL10.glFrontFace(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFrontFace13172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFrontFace13172, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFrustumf13173; 
		 void javax.microedition.khronos.opengles.GL10.glFrustumf(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFrustumf13173, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFrustumf13173, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glFrustumx13174; 
		 void javax.microedition.khronos.opengles.GL10.glFrustumx(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glFrustumx13174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glFrustumx13174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenTextures13175; 
		 void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glGenTextures13175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glGenTextures13175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGenTextures13176; 
		 void javax.microedition.khronos.opengles.GL10.glGenTextures(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glGenTextures13176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glGenTextures13176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetError13177; 
		 int javax.microedition.khronos.opengles.GL10.glGetError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::javax.microedition.khronos.opengles.__GL10._glGetError13177); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glGetError13177); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetIntegerv13178; 
		 void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glGetIntegerv13178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glGetIntegerv13178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetIntegerv13179; 
		 void javax.microedition.khronos.opengles.GL10.glGetIntegerv(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glGetIntegerv13179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glGetIntegerv13179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glGetString13180; 
		 global::java.lang.String javax.microedition.khronos.opengles.GL10.glGetString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::javax.microedition.khronos.opengles.__GL10._glGetString13180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glGetString13180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glHint13181; 
		 void javax.microedition.khronos.opengles.GL10.glHint(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glHint13181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glHint13181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelf13182; 
		 void javax.microedition.khronos.opengles.GL10.glLightModelf(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightModelf13182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightModelf13182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelfv13183; 
		 void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, float[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightModelfv13183, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightModelfv13183, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelfv13184; 
		 void javax.microedition.khronos.opengles.GL10.glLightModelfv(int arg0, java.nio.FloatBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightModelfv13184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightModelfv13184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelx13185; 
		 void javax.microedition.khronos.opengles.GL10.glLightModelx(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightModelx13185, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightModelx13185, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxv13186; 
		 void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, int[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightModelxv13186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightModelxv13186, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightModelxv13187; 
		 void javax.microedition.khronos.opengles.GL10.glLightModelxv(int arg0, java.nio.IntBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightModelxv13187, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightModelxv13187, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightf13188; 
		 void javax.microedition.khronos.opengles.GL10.glLightf(int arg0, int arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightf13188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightf13188, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightfv13189; 
		 void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightfv13189, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightfv13189, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightfv13190; 
		 void javax.microedition.khronos.opengles.GL10.glLightfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightfv13190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightfv13190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightx13191; 
		 void javax.microedition.khronos.opengles.GL10.glLightx(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightx13191, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightx13191, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightxv13192; 
		 void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightxv13192, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightxv13192, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLightxv13193; 
		 void javax.microedition.khronos.opengles.GL10.glLightxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLightxv13193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLightxv13193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLineWidth13194; 
		 void javax.microedition.khronos.opengles.GL10.glLineWidth(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLineWidth13194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLineWidth13194, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLineWidthx13195; 
		 void javax.microedition.khronos.opengles.GL10.glLineWidthx(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLineWidthx13195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLineWidthx13195, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadIdentity13196; 
		 void javax.microedition.khronos.opengles.GL10.glLoadIdentity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLoadIdentity13196); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLoadIdentity13196); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixf13197; 
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(float[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixf13197, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixf13197, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixf13198; 
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixf(java.nio.FloatBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixf13198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixf13198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixx13199; 
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixx13199, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixx13199, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLoadMatrixx13200; 
		 void javax.microedition.khronos.opengles.GL10.glLoadMatrixx(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixx13200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixx13200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glLogicOp13201; 
		 void javax.microedition.khronos.opengles.GL10.glLogicOp(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glLogicOp13201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glLogicOp13201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialf13202; 
		 void javax.microedition.khronos.opengles.GL10.glMaterialf(int arg0, int arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMaterialf13202, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMaterialf13202, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialfv13203; 
		 void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMaterialfv13203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMaterialfv13203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialfv13204; 
		 void javax.microedition.khronos.opengles.GL10.glMaterialfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMaterialfv13204, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMaterialfv13204, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialx13205; 
		 void javax.microedition.khronos.opengles.GL10.glMaterialx(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMaterialx13205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMaterialx13205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxv13206; 
		 void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMaterialxv13206, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMaterialxv13206, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMaterialxv13207; 
		 void javax.microedition.khronos.opengles.GL10.glMaterialxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMaterialxv13207, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMaterialxv13207, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMatrixMode13208; 
		 void javax.microedition.khronos.opengles.GL10.glMatrixMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMatrixMode13208, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMatrixMode13208, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixf13209; 
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixf(float[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixf13209, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixf13209, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixf13210; 
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixf(java.nio.FloatBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixf13210, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixf13210, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixx13211; 
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixx(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixx13211, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixx13211, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultMatrixx13212; 
		 void javax.microedition.khronos.opengles.GL10.glMultMatrixx(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixx13212, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMultMatrixx13212, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultiTexCoord4f13213; 
		 void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4f(int arg0, float arg1, float arg2, float arg3, float arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMultiTexCoord4f13213, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMultiTexCoord4f13213, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glMultiTexCoord4x13214; 
		 void javax.microedition.khronos.opengles.GL10.glMultiTexCoord4x(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glMultiTexCoord4x13214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glMultiTexCoord4x13214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glNormal3f13215; 
		 void javax.microedition.khronos.opengles.GL10.glNormal3f(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glNormal3f13215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glNormal3f13215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glNormal3x13216; 
		 void javax.microedition.khronos.opengles.GL10.glNormal3x(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glNormal3x13216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glNormal3x13216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glNormalPointer13217; 
		 void javax.microedition.khronos.opengles.GL10.glNormalPointer(int arg0, int arg1, java.nio.Buffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glNormalPointer13217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glNormalPointer13217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glOrthof13218; 
		 void javax.microedition.khronos.opengles.GL10.glOrthof(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glOrthof13218, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glOrthof13218, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glOrthox13219; 
		 void javax.microedition.khronos.opengles.GL10.glOrthox(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glOrthox13219, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glOrthox13219, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPixelStorei13220; 
		 void javax.microedition.khronos.opengles.GL10.glPixelStorei(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glPixelStorei13220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glPixelStorei13220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointSize13221; 
		 void javax.microedition.khronos.opengles.GL10.glPointSize(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glPointSize13221, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glPointSize13221, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPointSizex13222; 
		 void javax.microedition.khronos.opengles.GL10.glPointSizex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glPointSizex13222, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glPointSizex13222, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPolygonOffset13223; 
		 void javax.microedition.khronos.opengles.GL10.glPolygonOffset(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glPolygonOffset13223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glPolygonOffset13223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPolygonOffsetx13224; 
		 void javax.microedition.khronos.opengles.GL10.glPolygonOffsetx(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glPolygonOffsetx13224, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glPolygonOffsetx13224, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPopMatrix13225; 
		 void javax.microedition.khronos.opengles.GL10.glPopMatrix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glPopMatrix13225); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glPopMatrix13225); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glPushMatrix13226; 
		 void javax.microedition.khronos.opengles.GL10.glPushMatrix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glPushMatrix13226); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glPushMatrix13226); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glReadPixels13227; 
		 void javax.microedition.khronos.opengles.GL10.glReadPixels(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.nio.Buffer arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glReadPixels13227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glReadPixels13227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glRotatef13228; 
		 void javax.microedition.khronos.opengles.GL10.glRotatef(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glRotatef13228, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glRotatef13228, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glRotatex13229; 
		 void javax.microedition.khronos.opengles.GL10.glRotatex(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glRotatex13229, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glRotatex13229, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glSampleCoverage13230; 
		 void javax.microedition.khronos.opengles.GL10.glSampleCoverage(float arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glSampleCoverage13230, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glSampleCoverage13230, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glSampleCoveragex13231; 
		 void javax.microedition.khronos.opengles.GL10.glSampleCoveragex(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glSampleCoveragex13231, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glSampleCoveragex13231, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glScalef13232; 
		 void javax.microedition.khronos.opengles.GL10.glScalef(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glScalef13232, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glScalef13232, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glScalex13233; 
		 void javax.microedition.khronos.opengles.GL10.glScalex(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glScalex13233, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glScalex13233, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glScissor13234; 
		 void javax.microedition.khronos.opengles.GL10.glScissor(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glScissor13234, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glScissor13234, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glShadeModel13235; 
		 void javax.microedition.khronos.opengles.GL10.glShadeModel(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glShadeModel13235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glShadeModel13235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glStencilFunc13236; 
		 void javax.microedition.khronos.opengles.GL10.glStencilFunc(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glStencilFunc13236, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glStencilFunc13236, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glStencilMask13237; 
		 void javax.microedition.khronos.opengles.GL10.glStencilMask(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glStencilMask13237, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glStencilMask13237, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glStencilOp13238; 
		 void javax.microedition.khronos.opengles.GL10.glStencilOp(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glStencilOp13238, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glStencilOp13238, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexCoordPointer13239; 
		 void javax.microedition.khronos.opengles.GL10.glTexCoordPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexCoordPointer13239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexCoordPointer13239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvf13240; 
		 void javax.microedition.khronos.opengles.GL10.glTexEnvf(int arg0, int arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexEnvf13240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexEnvf13240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvfv13241; 
		 void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, float[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexEnvfv13241, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexEnvfv13241, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvfv13242; 
		 void javax.microedition.khronos.opengles.GL10.glTexEnvfv(int arg0, int arg1, java.nio.FloatBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexEnvfv13242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexEnvfv13242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvx13243; 
		 void javax.microedition.khronos.opengles.GL10.glTexEnvx(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexEnvx13243, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexEnvx13243, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxv13244; 
		 void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, int[] arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexEnvxv13244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexEnvxv13244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexEnvxv13245; 
		 void javax.microedition.khronos.opengles.GL10.glTexEnvxv(int arg0, int arg1, java.nio.IntBuffer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexEnvxv13245, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexEnvxv13245, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexImage2D13246; 
		 void javax.microedition.khronos.opengles.GL10.glTexImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexImage2D13246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexImage2D13246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterf13247; 
		 void javax.microedition.khronos.opengles.GL10.glTexParameterf(int arg0, int arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexParameterf13247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexParameterf13247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexParameterx13248; 
		 void javax.microedition.khronos.opengles.GL10.glTexParameterx(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexParameterx13248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexParameterx13248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTexSubImage2D13249; 
		 void javax.microedition.khronos.opengles.GL10.glTexSubImage2D(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, java.nio.Buffer arg8) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTexSubImage2D13249, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTexSubImage2D13249, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTranslatef13250; 
		 void javax.microedition.khronos.opengles.GL10.glTranslatef(float arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTranslatef13250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTranslatef13250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glTranslatex13251; 
		 void javax.microedition.khronos.opengles.GL10.glTranslatex(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glTranslatex13251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glTranslatex13251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glVertexPointer13252; 
		 void javax.microedition.khronos.opengles.GL10.glVertexPointer(int arg0, int arg1, int arg2, java.nio.Buffer arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glVertexPointer13252, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glVertexPointer13252, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _glViewport13253; 
		 void javax.microedition.khronos.opengles.GL10.glViewport(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10._glViewport13253, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::javax.microedition.khronos.opengles.__GL10.staticClass, global::javax.microedition.khronos.opengles.__GL10._glViewport13253, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::javax.microedition.khronos.opengles.__GL10.staticClass = @__class; 
			global::javax.microedition.khronos.opengles.__GL10._glActiveTexture13131 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glActiveTexture", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glAlphaFunc13132 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glAlphaFunc", "(IF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glAlphaFuncx13133 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glAlphaFuncx", "(II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glBindTexture13134 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glBindTexture", "(II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glBlendFunc13135 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glBlendFunc", "(II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glClear13136 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glClear", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glClearColor13137 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glClearColor", "(FFFF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glClearColorx13138 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glClearColorx", "(IIII)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glClearDepthf13139 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glClearDepthf", "(F)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glClearDepthx13140 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glClearDepthx", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glClearStencil13141 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glClearStencil", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glClientActiveTexture13142 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glClientActiveTexture", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glColor4f13143 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glColor4f", "(FFFF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glColor4x13144 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glColor4x", "(IIII)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glColorMask13145 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glColorMask", "(ZZZZ)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glColorPointer13146 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glColorPointer", "(IIILjava/nio/Buffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glCompressedTexImage2D13147 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glCompressedTexImage2D", "(IIIIIIILjava/nio/Buffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glCompressedTexSubImage2D13148 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glCompressedTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glCopyTexImage2D13149 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glCopyTexImage2D", "(IIIIIIII)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glCopyTexSubImage2D13150 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glCopyTexSubImage2D", "(IIIIIIII)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glCullFace13151 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glCullFace", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glDeleteTextures13152 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDeleteTextures", "(I[II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glDeleteTextures13153 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDeleteTextures", "(ILjava/nio/IntBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glDepthFunc13154 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDepthFunc", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glDepthMask13155 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDepthMask", "(Z)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glDepthRangef13156 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDepthRangef", "(FF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glDepthRangex13157 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDepthRangex", "(II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glDisable13158 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDisable", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glDisableClientState13159 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDisableClientState", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glDrawArrays13160 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDrawArrays", "(III)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glDrawElements13161 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glDrawElements", "(IIILjava/nio/Buffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glEnable13162 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glEnable", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glEnableClientState13163 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glEnableClientState", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glFinish13164 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFinish", "()V"); 
			global::javax.microedition.khronos.opengles.__GL10._glFlush13165 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFlush", "()V"); 
			global::javax.microedition.khronos.opengles.__GL10._glFogf13166 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFogf", "(IF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glFogfv13167 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFogfv", "(I[FI)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glFogfv13168 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFogfv", "(ILjava/nio/FloatBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glFogx13169 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFogx", "(II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glFogxv13170 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFogxv", "(I[II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glFogxv13171 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFogxv", "(ILjava/nio/IntBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glFrontFace13172 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFrontFace", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glFrustumf13173 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFrustumf", "(FFFFFF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glFrustumx13174 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glFrustumx", "(IIIIII)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glGenTextures13175 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glGenTextures", "(I[II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glGenTextures13176 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glGenTextures", "(ILjava/nio/IntBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glGetError13177 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glGetError", "()I"); 
			global::javax.microedition.khronos.opengles.__GL10._glGetIntegerv13178 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glGetIntegerv", "(I[II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glGetIntegerv13179 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glGetIntegerv", "(ILjava/nio/IntBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glGetString13180 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glGetString", "(I)Ljava/lang/String;"); 
			global::javax.microedition.khronos.opengles.__GL10._glHint13181 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glHint", "(II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLightModelf13182 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightModelf", "(IF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLightModelfv13183 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightModelfv", "(I[FI)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLightModelfv13184 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightModelfv", "(ILjava/nio/FloatBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLightModelx13185 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightModelx", "(II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLightModelxv13186 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightModelxv", "(I[II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLightModelxv13187 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightModelxv", "(ILjava/nio/IntBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLightf13188 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightf", "(IIF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLightfv13189 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightfv", "(II[FI)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLightfv13190 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightfv", "(IILjava/nio/FloatBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLightx13191 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightx", "(III)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLightxv13192 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightxv", "(II[II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLightxv13193 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLightxv", "(IILjava/nio/IntBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLineWidth13194 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLineWidth", "(F)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLineWidthx13195 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLineWidthx", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLoadIdentity13196 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLoadIdentity", "()V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixf13197 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLoadMatrixf", "([FI)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixf13198 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLoadMatrixf", "(Ljava/nio/FloatBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixx13199 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLoadMatrixx", "([II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLoadMatrixx13200 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLoadMatrixx", "(Ljava/nio/IntBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glLogicOp13201 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glLogicOp", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glMaterialf13202 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMaterialf", "(IIF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glMaterialfv13203 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMaterialfv", "(II[FI)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glMaterialfv13204 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMaterialfv", "(IILjava/nio/FloatBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glMaterialx13205 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMaterialx", "(III)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glMaterialxv13206 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMaterialxv", "(II[II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glMaterialxv13207 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMaterialxv", "(IILjava/nio/IntBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glMatrixMode13208 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMatrixMode", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glMultMatrixf13209 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMultMatrixf", "([FI)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glMultMatrixf13210 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMultMatrixf", "(Ljava/nio/FloatBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glMultMatrixx13211 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMultMatrixx", "([II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glMultMatrixx13212 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMultMatrixx", "(Ljava/nio/IntBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glMultiTexCoord4f13213 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMultiTexCoord4f", "(IFFFF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glMultiTexCoord4x13214 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glMultiTexCoord4x", "(IIIII)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glNormal3f13215 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glNormal3f", "(FFF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glNormal3x13216 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glNormal3x", "(III)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glNormalPointer13217 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glNormalPointer", "(IILjava/nio/Buffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glOrthof13218 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glOrthof", "(FFFFFF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glOrthox13219 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glOrthox", "(IIIIII)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glPixelStorei13220 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glPixelStorei", "(II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glPointSize13221 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glPointSize", "(F)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glPointSizex13222 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glPointSizex", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glPolygonOffset13223 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glPolygonOffset", "(FF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glPolygonOffsetx13224 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glPolygonOffsetx", "(II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glPopMatrix13225 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glPopMatrix", "()V"); 
			global::javax.microedition.khronos.opengles.__GL10._glPushMatrix13226 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glPushMatrix", "()V"); 
			global::javax.microedition.khronos.opengles.__GL10._glReadPixels13227 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glReadPixels", "(IIIIIILjava/nio/Buffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glRotatef13228 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glRotatef", "(FFFF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glRotatex13229 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glRotatex", "(IIII)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glSampleCoverage13230 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glSampleCoverage", "(FZ)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glSampleCoveragex13231 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glSampleCoveragex", "(IZ)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glScalef13232 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glScalef", "(FFF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glScalex13233 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glScalex", "(III)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glScissor13234 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glScissor", "(IIII)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glShadeModel13235 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glShadeModel", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glStencilFunc13236 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glStencilFunc", "(III)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glStencilMask13237 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glStencilMask", "(I)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glStencilOp13238 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glStencilOp", "(III)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glTexCoordPointer13239 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexCoordPointer", "(IIILjava/nio/Buffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glTexEnvf13240 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexEnvf", "(IIF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glTexEnvfv13241 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexEnvfv", "(II[FI)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glTexEnvfv13242 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexEnvfv", "(IILjava/nio/FloatBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glTexEnvx13243 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexEnvx", "(III)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glTexEnvxv13244 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexEnvxv", "(II[II)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glTexEnvxv13245 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexEnvxv", "(IILjava/nio/IntBuffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glTexImage2D13246 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexImage2D", "(IIIIIIIILjava/nio/Buffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glTexParameterf13247 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexParameterf", "(IIF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glTexParameterx13248 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexParameterx", "(III)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glTexSubImage2D13249 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTexSubImage2D", "(IIIIIIIILjava/nio/Buffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glTranslatef13250 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTranslatef", "(FFF)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glTranslatex13251 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glTranslatex", "(III)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glVertexPointer13252 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glVertexPointer", "(IIILjava/nio/Buffer;)V"); 
			global::javax.microedition.khronos.opengles.__GL10._glViewport13253 = @__env.GetMethodID(global::javax.microedition.khronos.opengles.__GL10.staticClass, "javax.microedition.khronos.opengles.GL10.glViewport", "(IIII)V"); 
		} 
	} 
} 
