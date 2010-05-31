namespace javax.microedition.khronos.egl
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface EGL10 : EGL
	{
		bool eglChooseConfig(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1, javax.microedition.khronos.egl.EGLConfig[] arg2, int arg3, int[] arg4);
		bool eglCopyBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, java.lang.Object arg2);
		global::javax.microedition.khronos.egl.EGLContext eglCreateContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, javax.microedition.khronos.egl.EGLContext arg2, int[] arg3);
		global::javax.microedition.khronos.egl.EGLSurface eglCreatePbufferSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int[] arg2);
		global::javax.microedition.khronos.egl.EGLSurface eglCreatePixmapSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3);
		global::javax.microedition.khronos.egl.EGLSurface eglCreateWindowSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3);
		bool eglDestroyContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1);
		bool eglDestroySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1);
		bool eglGetConfigAttrib(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int arg2, int[] arg3);
		bool eglGetConfigs(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig[] arg1, int arg2, int[] arg3);
		global::javax.microedition.khronos.egl.EGLContext eglGetCurrentContext();
		global::javax.microedition.khronos.egl.EGLDisplay eglGetCurrentDisplay();
		global::javax.microedition.khronos.egl.EGLSurface eglGetCurrentSurface(int arg0);
		global::javax.microedition.khronos.egl.EGLDisplay eglGetDisplay(java.lang.Object arg0);
		int eglGetError();
		bool eglInitialize(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1);
		bool eglMakeCurrent(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, javax.microedition.khronos.egl.EGLSurface arg2, javax.microedition.khronos.egl.EGLContext arg3);
		bool eglQueryContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1, int arg2, int[] arg3);
		global::java.lang.String eglQueryString(javax.microedition.khronos.egl.EGLDisplay arg0, int arg1);
		bool eglQuerySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, int arg2, int[] arg3);
		bool eglSwapBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1);
		bool eglTerminate(javax.microedition.khronos.egl.EGLDisplay arg0);
		bool eglWaitGL();
		bool eglWaitNative(int arg0, java.lang.Object arg1);
	}

	public partial class EGL10_
	{
		public static global::java.lang.Class _class
		{
			get { return __EGL10.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __EGL10 : java.lang.Object, EGL10
	{
		internal static global::java.lang.Class staticClass;
		static __EGL10()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::javax.microedition.khronos.egl.__EGL10), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::javax.microedition.khronos.egl.__EGL10(@__env);
			}
		}
		internal __EGL10(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglChooseConfig13101;
		 bool javax.microedition.khronos.egl.EGL10.eglChooseConfig(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1, javax.microedition.khronos.egl.EGLConfig[] arg2, int arg3, int[] arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10._eglChooseConfig13101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglChooseConfig13101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglCopyBuffers13102;
		 bool javax.microedition.khronos.egl.EGL10.eglCopyBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, java.lang.Object arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10._eglCopyBuffers13102, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglCopyBuffers13102, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglCreateContext13103;
		 global::javax.microedition.khronos.egl.EGLContext javax.microedition.khronos.egl.EGL10.eglCreateContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, javax.microedition.khronos.egl.EGLContext arg2, int[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLContext>(@__env, @__env.CallObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10._eglCreateContext13103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLContext>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglCreateContext13103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglCreatePbufferSurface13104;
		 global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglCreatePbufferSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLSurface>(@__env, @__env.CallObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10._eglCreatePbufferSurface13104, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLSurface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglCreatePbufferSurface13104, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglCreatePixmapSurface13105;
		 global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglCreatePixmapSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLSurface>(@__env, @__env.CallObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10._eglCreatePixmapSurface13105, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLSurface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglCreatePixmapSurface13105, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglCreateWindowSurface13106;
		 global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglCreateWindowSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLSurface>(@__env, @__env.CallObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10._eglCreateWindowSurface13106, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLSurface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglCreateWindowSurface13106, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglDestroyContext13107;
		 bool javax.microedition.khronos.egl.EGL10.eglDestroyContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10._eglDestroyContext13107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglDestroyContext13107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglDestroySurface13108;
		 bool javax.microedition.khronos.egl.EGL10.eglDestroySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10._eglDestroySurface13108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglDestroySurface13108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglGetConfigAttrib13109;
		 bool javax.microedition.khronos.egl.EGL10.eglGetConfigAttrib(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int arg2, int[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10._eglGetConfigAttrib13109, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglGetConfigAttrib13109, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglGetConfigs13110;
		 bool javax.microedition.khronos.egl.EGL10.eglGetConfigs(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig[] arg1, int arg2, int[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10._eglGetConfigs13110, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglGetConfigs13110, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglGetCurrentContext13111;
		 global::javax.microedition.khronos.egl.EGLContext javax.microedition.khronos.egl.EGL10.eglGetCurrentContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLContext>(@__env, @__env.CallObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10._eglGetCurrentContext13111));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLContext>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglGetCurrentContext13111));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglGetCurrentDisplay13112;
		 global::javax.microedition.khronos.egl.EGLDisplay javax.microedition.khronos.egl.EGL10.eglGetCurrentDisplay() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLDisplay>(@__env, @__env.CallObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10._eglGetCurrentDisplay13112));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLDisplay>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglGetCurrentDisplay13112));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglGetCurrentSurface13113;
		 global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglGetCurrentSurface(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLSurface>(@__env, @__env.CallObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10._eglGetCurrentSurface13113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLSurface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglGetCurrentSurface13113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglGetDisplay13114;
		 global::javax.microedition.khronos.egl.EGLDisplay javax.microedition.khronos.egl.EGL10.eglGetDisplay(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLDisplay>(@__env, @__env.CallObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10._eglGetDisplay13114, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLDisplay>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglGetDisplay13114, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglGetError13115;
		 int javax.microedition.khronos.egl.EGL10.eglGetError() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::javax.microedition.khronos.egl.__EGL10._eglGetError13115);
			else
				return @__env.CallNonVirtualIntMethod(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglGetError13115);
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglInitialize13116;
		 bool javax.microedition.khronos.egl.EGL10.eglInitialize(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10._eglInitialize13116, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglInitialize13116, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglMakeCurrent13117;
		 bool javax.microedition.khronos.egl.EGL10.eglMakeCurrent(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, javax.microedition.khronos.egl.EGLSurface arg2, javax.microedition.khronos.egl.EGLContext arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10._eglMakeCurrent13117, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglMakeCurrent13117, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglQueryContext13118;
		 bool javax.microedition.khronos.egl.EGL10.eglQueryContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1, int arg2, int[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10._eglQueryContext13118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglQueryContext13118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglQueryString13119;
		 global::java.lang.String javax.microedition.khronos.egl.EGL10.eglQueryString(javax.microedition.khronos.egl.EGLDisplay arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10._eglQueryString13119, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglQueryString13119, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglQuerySurface13120;
		 bool javax.microedition.khronos.egl.EGL10.eglQuerySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, int arg2, int[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10._eglQuerySurface13120, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglQuerySurface13120, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglSwapBuffers13121;
		 bool javax.microedition.khronos.egl.EGL10.eglSwapBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10._eglSwapBuffers13121, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglSwapBuffers13121, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglTerminate13122;
		 bool javax.microedition.khronos.egl.EGL10.eglTerminate(javax.microedition.khronos.egl.EGLDisplay arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10._eglTerminate13122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglTerminate13122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglWaitGL13123;
		 bool javax.microedition.khronos.egl.EGL10.eglWaitGL() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10._eglWaitGL13123);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglWaitGL13123);
		}
		internal static global::net.sf.jni4net.jni.MethodId _eglWaitNative13124;
		 bool javax.microedition.khronos.egl.EGL10.eglWaitNative(int arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10._eglWaitNative13124, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::javax.microedition.khronos.egl.__EGL10.staticClass, global::javax.microedition.khronos.egl.__EGL10._eglWaitNative13124, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::javax.microedition.khronos.egl.__EGL10.staticClass = @__class;
			global::javax.microedition.khronos.egl.__EGL10._eglChooseConfig13101 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglChooseConfig", "(Ljavax/microedition/khronos/egl/EGLDisplay;[I[Ljavax/microedition/khronos/egl/EGLConfig;I[I)Z");
			global::javax.microedition.khronos.egl.__EGL10._eglCopyBuffers13102 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglCopyBuffers", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;Ljava/lang/Object;)Z");
			global::javax.microedition.khronos.egl.__EGL10._eglCreateContext13103 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglCreateContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljavax/microedition/khronos/egl/EGLContext;[I)Ljavax/microedition/khronos/egl/EGLContext;");
			global::javax.microedition.khronos.egl.__EGL10._eglCreatePbufferSurface13104 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglCreatePbufferSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;[I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.__EGL10._eglCreatePixmapSurface13105 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglCreatePixmapSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljava/lang/Object;[I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.__EGL10._eglCreateWindowSurface13106 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglCreateWindowSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljava/lang/Object;[I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.__EGL10._eglDestroyContext13107 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglDestroyContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;)Z");
			global::javax.microedition.khronos.egl.__EGL10._eglDestroySurface13108 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglDestroySurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;)Z");
			global::javax.microedition.khronos.egl.__EGL10._eglGetConfigAttrib13109 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglGetConfigAttrib", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;I[I)Z");
			global::javax.microedition.khronos.egl.__EGL10._eglGetConfigs13110 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglGetConfigs", "(Ljavax/microedition/khronos/egl/EGLDisplay;[Ljavax/microedition/khronos/egl/EGLConfig;I[I)Z");
			global::javax.microedition.khronos.egl.__EGL10._eglGetCurrentContext13111 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglGetCurrentContext", "()Ljavax/microedition/khronos/egl/EGLContext;");
			global::javax.microedition.khronos.egl.__EGL10._eglGetCurrentDisplay13112 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglGetCurrentDisplay", "()Ljavax/microedition/khronos/egl/EGLDisplay;");
			global::javax.microedition.khronos.egl.__EGL10._eglGetCurrentSurface13113 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglGetCurrentSurface", "(I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.__EGL10._eglGetDisplay13114 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglGetDisplay", "(Ljava/lang/Object;)Ljavax/microedition/khronos/egl/EGLDisplay;");
			global::javax.microedition.khronos.egl.__EGL10._eglGetError13115 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglGetError", "()I");
			global::javax.microedition.khronos.egl.__EGL10._eglInitialize13116 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglInitialize", "(Ljavax/microedition/khronos/egl/EGLDisplay;[I)Z");
			global::javax.microedition.khronos.egl.__EGL10._eglMakeCurrent13117 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglMakeCurrent", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;Ljavax/microedition/khronos/egl/EGLSurface;Ljavax/microedition/khronos/egl/EGLContext;)Z");
			global::javax.microedition.khronos.egl.__EGL10._eglQueryContext13118 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglQueryContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;I[I)Z");
			global::javax.microedition.khronos.egl.__EGL10._eglQueryString13119 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglQueryString", "(Ljavax/microedition/khronos/egl/EGLDisplay;I)Ljava/lang/String;");
			global::javax.microedition.khronos.egl.__EGL10._eglQuerySurface13120 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglQuerySurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;I[I)Z");
			global::javax.microedition.khronos.egl.__EGL10._eglSwapBuffers13121 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglSwapBuffers", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;)Z");
			global::javax.microedition.khronos.egl.__EGL10._eglTerminate13122 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglTerminate", "(Ljavax/microedition/khronos/egl/EGLDisplay;)Z");
			global::javax.microedition.khronos.egl.__EGL10._eglWaitGL13123 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglWaitGL", "()Z");
			global::javax.microedition.khronos.egl.__EGL10._eglWaitNative13124 = @__env.GetMethodID(global::javax.microedition.khronos.egl.__EGL10.staticClass, "javax.microedition.khronos.egl.EGL10.eglWaitNative", "(ILjava/lang/Object;)Z");
		}
	}
}
