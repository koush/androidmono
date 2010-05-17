namespace javax.microedition.khronos.egl 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface EGL10 : EGL
	{ 
		bool eglChooseConfig(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1, javax.microedition.khronos.egl.EGLConfig[] arg2, int arg3, int[] arg4); 
		bool eglCopyBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, java.lang.Object arg2); 
		javax.microedition.khronos.egl.EGLContext eglCreateContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, javax.microedition.khronos.egl.EGLContext arg2, int[] arg3); 
		javax.microedition.khronos.egl.EGLSurface eglCreatePbufferSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int[] arg2); 
		javax.microedition.khronos.egl.EGLSurface eglCreatePixmapSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3); 
		javax.microedition.khronos.egl.EGLSurface eglCreateWindowSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3); 
		bool eglDestroyContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1); 
		bool eglDestroySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1); 
		bool eglGetConfigAttrib(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int arg2, int[] arg3); 
		bool eglGetConfigs(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig[] arg1, int arg2, int[] arg3); 
		javax.microedition.khronos.egl.EGLContext eglGetCurrentContext(); 
		javax.microedition.khronos.egl.EGLDisplay eglGetCurrentDisplay(); 
		javax.microedition.khronos.egl.EGLSurface eglGetCurrentSurface(int arg0); 
		javax.microedition.khronos.egl.EGLDisplay eglGetDisplay(java.lang.Object arg0); 
		int eglGetError(); 
		bool eglInitialize(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1); 
		bool eglMakeCurrent(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, javax.microedition.khronos.egl.EGLSurface arg2, javax.microedition.khronos.egl.EGLContext arg3); 
		bool eglQueryContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1, int arg2, int[] arg3); 
		java.lang.String eglQueryString(javax.microedition.khronos.egl.EGLDisplay arg0, int arg1); 
		bool eglQuerySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, int arg2, int[] arg3); 
		bool eglSwapBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1); 
		bool eglTerminate(javax.microedition.khronos.egl.EGLDisplay arg0); 
		bool eglWaitGL(); 
		bool eglWaitNative(int arg0, java.lang.Object arg1); 
	} 
} 
