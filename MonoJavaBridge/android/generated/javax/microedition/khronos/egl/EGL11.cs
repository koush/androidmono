namespace javax.microedition.khronos.egl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.microedition.khronos.egl.EGL11_))]
	public partial interface EGL11 : EGL10
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.egl.EGL11))]
	internal sealed partial class EGL11_ : java.lang.Object, EGL11
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EGL11_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool javax.microedition.khronos.egl.EGL10.eglChooseConfig(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1, javax.microedition.khronos.egl.EGLConfig[] arg2, int arg3, int[] arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglChooseConfig", "(Ljavax/microedition/khronos/egl/EGLDisplay;[I[Ljavax/microedition/khronos/egl/EGLConfig;I[I)Z", ref global::javax.microedition.khronos.egl.EGL11_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool javax.microedition.khronos.egl.EGL10.eglCopyBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, java.lang.Object arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglCopyBuffers", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;Ljava/lang/Object;)Z", ref global::javax.microedition.khronos.egl.EGL11_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::javax.microedition.khronos.egl.EGLContext javax.microedition.khronos.egl.EGL10.eglCreateContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, javax.microedition.khronos.egl.EGLContext arg2, int[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglCreateContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljavax/microedition/khronos/egl/EGLContext;[I)Ljavax/microedition/khronos/egl/EGLContext;", ref global::javax.microedition.khronos.egl.EGL11_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.microedition.khronos.egl.EGLContext;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglCreatePbufferSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglCreatePbufferSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;[I)Ljavax/microedition/khronos/egl/EGLSurface;", ref global::javax.microedition.khronos.egl.EGL11_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as javax.microedition.khronos.egl.EGLSurface;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglCreatePixmapSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglCreatePixmapSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljava/lang/Object;[I)Ljavax/microedition/khronos/egl/EGLSurface;", ref global::javax.microedition.khronos.egl.EGL11_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.microedition.khronos.egl.EGLSurface;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglCreateWindowSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglCreateWindowSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljava/lang/Object;[I)Ljavax/microedition/khronos/egl/EGLSurface;", ref global::javax.microedition.khronos.egl.EGL11_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.microedition.khronos.egl.EGLSurface;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool javax.microedition.khronos.egl.EGL10.eglDestroyContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglDestroyContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;)Z", ref global::javax.microedition.khronos.egl.EGL11_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		bool javax.microedition.khronos.egl.EGL10.eglDestroySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglDestroySurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;)Z", ref global::javax.microedition.khronos.egl.EGL11_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		bool javax.microedition.khronos.egl.EGL10.eglGetConfigAttrib(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int arg2, int[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglGetConfigAttrib", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;I[I)Z", ref global::javax.microedition.khronos.egl.EGL11_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		bool javax.microedition.khronos.egl.EGL10.eglGetConfigs(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig[] arg1, int arg2, int[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglGetConfigs", "(Ljavax/microedition/khronos/egl/EGLDisplay;[Ljavax/microedition/khronos/egl/EGLConfig;I[I)Z", ref global::javax.microedition.khronos.egl.EGL11_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::javax.microedition.khronos.egl.EGLContext javax.microedition.khronos.egl.EGL10.eglGetCurrentContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglGetCurrentContext", "()Ljavax/microedition/khronos/egl/EGLContext;", ref global::javax.microedition.khronos.egl.EGL11_._m10) as javax.microedition.khronos.egl.EGLContext;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::javax.microedition.khronos.egl.EGLDisplay javax.microedition.khronos.egl.EGL10.eglGetCurrentDisplay()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglGetCurrentDisplay", "()Ljavax/microedition/khronos/egl/EGLDisplay;", ref global::javax.microedition.khronos.egl.EGL11_._m11) as javax.microedition.khronos.egl.EGLDisplay;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglGetCurrentSurface(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglGetCurrentSurface", "(I)Ljavax/microedition/khronos/egl/EGLSurface;", ref global::javax.microedition.khronos.egl.EGL11_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.microedition.khronos.egl.EGLSurface;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		global::javax.microedition.khronos.egl.EGLDisplay javax.microedition.khronos.egl.EGL10.eglGetDisplay(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglGetDisplay", "(Ljava/lang/Object;)Ljavax/microedition/khronos/egl/EGLDisplay;", ref global::javax.microedition.khronos.egl.EGL11_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.microedition.khronos.egl.EGLDisplay;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		int javax.microedition.khronos.egl.EGL10.eglGetError()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglGetError", "()I", ref global::javax.microedition.khronos.egl.EGL11_._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		bool javax.microedition.khronos.egl.EGL10.eglInitialize(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglInitialize", "(Ljavax/microedition/khronos/egl/EGLDisplay;[I)Z", ref global::javax.microedition.khronos.egl.EGL11_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		bool javax.microedition.khronos.egl.EGL10.eglMakeCurrent(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, javax.microedition.khronos.egl.EGLSurface arg2, javax.microedition.khronos.egl.EGLContext arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglMakeCurrent", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;Ljavax/microedition/khronos/egl/EGLSurface;Ljavax/microedition/khronos/egl/EGLContext;)Z", ref global::javax.microedition.khronos.egl.EGL11_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		bool javax.microedition.khronos.egl.EGL10.eglQueryContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1, int arg2, int[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglQueryContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;I[I)Z", ref global::javax.microedition.khronos.egl.EGL11_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		global::java.lang.String javax.microedition.khronos.egl.EGL10.eglQueryString(javax.microedition.khronos.egl.EGLDisplay arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglQueryString", "(Ljavax/microedition/khronos/egl/EGLDisplay;I)Ljava/lang/String;", ref global::javax.microedition.khronos.egl.EGL11_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		bool javax.microedition.khronos.egl.EGL10.eglQuerySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, int arg2, int[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglQuerySurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;I[I)Z", ref global::javax.microedition.khronos.egl.EGL11_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		bool javax.microedition.khronos.egl.EGL10.eglSwapBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglSwapBuffers", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;)Z", ref global::javax.microedition.khronos.egl.EGL11_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		bool javax.microedition.khronos.egl.EGL10.eglTerminate(javax.microedition.khronos.egl.EGLDisplay arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglTerminate", "(Ljavax/microedition/khronos/egl/EGLDisplay;)Z", ref global::javax.microedition.khronos.egl.EGL11_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		bool javax.microedition.khronos.egl.EGL10.eglWaitGL()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglWaitGL", "()Z", ref global::javax.microedition.khronos.egl.EGL11_._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		bool javax.microedition.khronos.egl.EGL10.eglWaitNative(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglWaitNative", "(ILjava/lang/Object;)Z", ref global::javax.microedition.khronos.egl.EGL11_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static EGL11_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGL11_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGL11"));
		}
		internal static void InitJNI()
		{
		}
	}
}
