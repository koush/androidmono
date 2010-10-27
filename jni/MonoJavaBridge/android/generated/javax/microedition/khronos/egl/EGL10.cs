namespace javax.microedition.khronos.egl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.microedition.khronos.egl.EGL10_))]
	public partial interface EGL10 : EGL
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

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.egl.EGL10))]
	internal sealed partial class EGL10_ : java.lang.Object, EGL10
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EGL10_()
		{
			InitJNI();
		}
		internal EGL10_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _eglChooseConfig28830;
		bool javax.microedition.khronos.egl.EGL10.eglChooseConfig(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1, javax.microedition.khronos.egl.EGLConfig[] arg2, int arg3, int[] arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglChooseConfig28830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglChooseConfig28830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _eglCopyBuffers28831;
		bool javax.microedition.khronos.egl.EGL10.eglCopyBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglCopyBuffers28831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglCopyBuffers28831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _eglCreateContext28832;
		global::javax.microedition.khronos.egl.EGLContext javax.microedition.khronos.egl.EGL10.eglCreateContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, javax.microedition.khronos.egl.EGLContext arg2, int[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglCreateContext28832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglCreateContext28832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLContext;
		}
		internal static global::MonoJavaBridge.MethodId _eglCreatePbufferSurface28833;
		global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglCreatePbufferSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglCreatePbufferSurface28833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.microedition.khronos.egl.EGLSurface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglCreatePbufferSurface28833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.microedition.khronos.egl.EGLSurface;
		}
		internal static global::MonoJavaBridge.MethodId _eglCreatePixmapSurface28834;
		global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglCreatePixmapSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglCreatePixmapSurface28834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLSurface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglCreatePixmapSurface28834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLSurface;
		}
		internal static global::MonoJavaBridge.MethodId _eglCreateWindowSurface28835;
		global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglCreateWindowSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglCreateWindowSurface28835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLSurface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglCreateWindowSurface28835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLSurface;
		}
		internal static global::MonoJavaBridge.MethodId _eglDestroyContext28836;
		bool javax.microedition.khronos.egl.EGL10.eglDestroyContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglDestroyContext28836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglDestroyContext28836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _eglDestroySurface28837;
		bool javax.microedition.khronos.egl.EGL10.eglDestroySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglDestroySurface28837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglDestroySurface28837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _eglGetConfigAttrib28838;
		bool javax.microedition.khronos.egl.EGL10.eglGetConfigAttrib(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int arg2, int[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglGetConfigAttrib28838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglGetConfigAttrib28838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _eglGetConfigs28839;
		bool javax.microedition.khronos.egl.EGL10.eglGetConfigs(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig[] arg1, int arg2, int[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglGetConfigs28839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglGetConfigs28839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _eglGetCurrentContext28840;
		global::javax.microedition.khronos.egl.EGLContext javax.microedition.khronos.egl.EGL10.eglGetCurrentContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentContext28840)) as javax.microedition.khronos.egl.EGLContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentContext28840)) as javax.microedition.khronos.egl.EGLContext;
		}
		internal static global::MonoJavaBridge.MethodId _eglGetCurrentDisplay28841;
		global::javax.microedition.khronos.egl.EGLDisplay javax.microedition.khronos.egl.EGL10.eglGetCurrentDisplay()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentDisplay28841)) as javax.microedition.khronos.egl.EGLDisplay;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentDisplay28841)) as javax.microedition.khronos.egl.EGLDisplay;
		}
		internal static global::MonoJavaBridge.MethodId _eglGetCurrentSurface28842;
		global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglGetCurrentSurface(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentSurface28842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.microedition.khronos.egl.EGLSurface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentSurface28842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.microedition.khronos.egl.EGLSurface;
		}
		internal static global::MonoJavaBridge.MethodId _eglGetDisplay28843;
		global::javax.microedition.khronos.egl.EGLDisplay javax.microedition.khronos.egl.EGL10.eglGetDisplay(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglGetDisplay28843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.microedition.khronos.egl.EGLDisplay;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglGetDisplay28843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.microedition.khronos.egl.EGLDisplay;
		}
		internal static global::MonoJavaBridge.MethodId _eglGetError28844;
		int javax.microedition.khronos.egl.EGL10.eglGetError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglGetError28844);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglGetError28844);
		}
		internal static global::MonoJavaBridge.MethodId _eglInitialize28845;
		bool javax.microedition.khronos.egl.EGL10.eglInitialize(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglInitialize28845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglInitialize28845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _eglMakeCurrent28846;
		bool javax.microedition.khronos.egl.EGL10.eglMakeCurrent(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, javax.microedition.khronos.egl.EGLSurface arg2, javax.microedition.khronos.egl.EGLContext arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglMakeCurrent28846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglMakeCurrent28846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _eglQueryContext28847;
		bool javax.microedition.khronos.egl.EGL10.eglQueryContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1, int arg2, int[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglQueryContext28847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglQueryContext28847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _eglQueryString28848;
		global::java.lang.String javax.microedition.khronos.egl.EGL10.eglQueryString(javax.microedition.khronos.egl.EGLDisplay arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglQueryString28848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglQueryString28848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _eglQuerySurface28849;
		bool javax.microedition.khronos.egl.EGL10.eglQuerySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, int arg2, int[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglQuerySurface28849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglQuerySurface28849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _eglSwapBuffers28850;
		bool javax.microedition.khronos.egl.EGL10.eglSwapBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglSwapBuffers28850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglSwapBuffers28850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _eglTerminate28851;
		bool javax.microedition.khronos.egl.EGL10.eglTerminate(javax.microedition.khronos.egl.EGLDisplay arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglTerminate28851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglTerminate28851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _eglWaitGL28852;
		bool javax.microedition.khronos.egl.EGL10.eglWaitGL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglWaitGL28852);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglWaitGL28852);
		}
		internal static global::MonoJavaBridge.MethodId _eglWaitNative28853;
		bool javax.microedition.khronos.egl.EGL10.eglWaitNative(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglWaitNative28853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglWaitNative28853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGL10_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGL10"));
			global::javax.microedition.khronos.egl.EGL10_._eglChooseConfig28830 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglChooseConfig", "(Ljavax/microedition/khronos/egl/EGLDisplay;[I[Ljavax/microedition/khronos/egl/EGLConfig;I[I)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglCopyBuffers28831 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglCopyBuffers", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;Ljava/lang/Object;)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglCreateContext28832 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglCreateContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljavax/microedition/khronos/egl/EGLContext;[I)Ljavax/microedition/khronos/egl/EGLContext;");
			global::javax.microedition.khronos.egl.EGL10_._eglCreatePbufferSurface28833 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglCreatePbufferSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;[I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.EGL10_._eglCreatePixmapSurface28834 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglCreatePixmapSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljava/lang/Object;[I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.EGL10_._eglCreateWindowSurface28835 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglCreateWindowSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljava/lang/Object;[I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.EGL10_._eglDestroyContext28836 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglDestroyContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglDestroySurface28837 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglDestroySurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglGetConfigAttrib28838 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglGetConfigAttrib", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;I[I)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglGetConfigs28839 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglGetConfigs", "(Ljavax/microedition/khronos/egl/EGLDisplay;[Ljavax/microedition/khronos/egl/EGLConfig;I[I)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentContext28840 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglGetCurrentContext", "()Ljavax/microedition/khronos/egl/EGLContext;");
			global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentDisplay28841 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglGetCurrentDisplay", "()Ljavax/microedition/khronos/egl/EGLDisplay;");
			global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentSurface28842 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglGetCurrentSurface", "(I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.EGL10_._eglGetDisplay28843 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglGetDisplay", "(Ljava/lang/Object;)Ljavax/microedition/khronos/egl/EGLDisplay;");
			global::javax.microedition.khronos.egl.EGL10_._eglGetError28844 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglGetError", "()I");
			global::javax.microedition.khronos.egl.EGL10_._eglInitialize28845 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglInitialize", "(Ljavax/microedition/khronos/egl/EGLDisplay;[I)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglMakeCurrent28846 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglMakeCurrent", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;Ljavax/microedition/khronos/egl/EGLSurface;Ljavax/microedition/khronos/egl/EGLContext;)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglQueryContext28847 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglQueryContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;I[I)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglQueryString28848 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglQueryString", "(Ljavax/microedition/khronos/egl/EGLDisplay;I)Ljava/lang/String;");
			global::javax.microedition.khronos.egl.EGL10_._eglQuerySurface28849 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglQuerySurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;I[I)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglSwapBuffers28850 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglSwapBuffers", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglTerminate28851 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglTerminate", "(Ljavax/microedition/khronos/egl/EGLDisplay;)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglWaitGL28852 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglWaitGL", "()Z");
			global::javax.microedition.khronos.egl.EGL10_._eglWaitNative28853 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglWaitNative", "(ILjava/lang/Object;)Z");
		}
	}
}
