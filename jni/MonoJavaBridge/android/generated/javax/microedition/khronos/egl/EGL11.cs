namespace javax.microedition.khronos.egl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.microedition.khronos.egl.EGL11_))]
	public interface EGL11 : EGL10
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.egl.EGL11))]
	public sealed partial class EGL11_ : java.lang.Object, EGL11
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EGL11_()
		{
			InitJNI();
		}
		internal EGL11_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _eglChooseConfig22838;
		 bool javax.microedition.khronos.egl.EGL10.eglChooseConfig(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1, javax.microedition.khronos.egl.EGLConfig[] arg2, int arg3, int[] arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglChooseConfig22838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglChooseConfig22838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _eglCopyBuffers22839;
		 bool javax.microedition.khronos.egl.EGL10.eglCopyBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglCopyBuffers22839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglCopyBuffers22839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _eglCreateContext22840;
		 global::javax.microedition.khronos.egl.EGLContext javax.microedition.khronos.egl.EGL10.eglCreateContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, javax.microedition.khronos.egl.EGLContext arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglCreateContext22840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglCreateContext22840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLContext;
		}
		internal static global::MonoJavaBridge.MethodId _eglCreatePbufferSurface22841;
		 global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglCreatePbufferSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglCreatePbufferSurface22841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.microedition.khronos.egl.EGLSurface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglCreatePbufferSurface22841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.microedition.khronos.egl.EGLSurface;
		}
		internal static global::MonoJavaBridge.MethodId _eglCreatePixmapSurface22842;
		 global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglCreatePixmapSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglCreatePixmapSurface22842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLSurface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglCreatePixmapSurface22842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLSurface;
		}
		internal static global::MonoJavaBridge.MethodId _eglCreateWindowSurface22843;
		 global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglCreateWindowSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglCreateWindowSurface22843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLSurface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglCreateWindowSurface22843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLSurface;
		}
		internal static global::MonoJavaBridge.MethodId _eglDestroyContext22844;
		 bool javax.microedition.khronos.egl.EGL10.eglDestroyContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglDestroyContext22844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglDestroyContext22844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _eglDestroySurface22845;
		 bool javax.microedition.khronos.egl.EGL10.eglDestroySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglDestroySurface22845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglDestroySurface22845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _eglGetConfigAttrib22846;
		 bool javax.microedition.khronos.egl.EGL10.eglGetConfigAttrib(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglGetConfigAttrib22846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglGetConfigAttrib22846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _eglGetConfigs22847;
		 bool javax.microedition.khronos.egl.EGL10.eglGetConfigs(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig[] arg1, int arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglGetConfigs22847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglGetConfigs22847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _eglGetCurrentContext22848;
		 global::javax.microedition.khronos.egl.EGLContext javax.microedition.khronos.egl.EGL10.eglGetCurrentContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglGetCurrentContext22848)) as javax.microedition.khronos.egl.EGLContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglGetCurrentContext22848)) as javax.microedition.khronos.egl.EGLContext;
		}
		internal static global::MonoJavaBridge.MethodId _eglGetCurrentDisplay22849;
		 global::javax.microedition.khronos.egl.EGLDisplay javax.microedition.khronos.egl.EGL10.eglGetCurrentDisplay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglGetCurrentDisplay22849)) as javax.microedition.khronos.egl.EGLDisplay;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglGetCurrentDisplay22849)) as javax.microedition.khronos.egl.EGLDisplay;
		}
		internal static global::MonoJavaBridge.MethodId _eglGetCurrentSurface22850;
		 global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglGetCurrentSurface(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglGetCurrentSurface22850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.microedition.khronos.egl.EGLSurface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglGetCurrentSurface22850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.microedition.khronos.egl.EGLSurface;
		}
		internal static global::MonoJavaBridge.MethodId _eglGetDisplay22851;
		 global::javax.microedition.khronos.egl.EGLDisplay javax.microedition.khronos.egl.EGL10.eglGetDisplay(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglGetDisplay22851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.microedition.khronos.egl.EGLDisplay;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglGetDisplay22851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.microedition.khronos.egl.EGLDisplay;
		}
		internal static global::MonoJavaBridge.MethodId _eglGetError22852;
		 int javax.microedition.khronos.egl.EGL10.eglGetError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglGetError22852);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglGetError22852);
		}
		internal static global::MonoJavaBridge.MethodId _eglInitialize22853;
		 bool javax.microedition.khronos.egl.EGL10.eglInitialize(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglInitialize22853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglInitialize22853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _eglMakeCurrent22854;
		 bool javax.microedition.khronos.egl.EGL10.eglMakeCurrent(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, javax.microedition.khronos.egl.EGLSurface arg2, javax.microedition.khronos.egl.EGLContext arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglMakeCurrent22854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglMakeCurrent22854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _eglQueryContext22855;
		 bool javax.microedition.khronos.egl.EGL10.eglQueryContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1, int arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglQueryContext22855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglQueryContext22855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _eglQueryString22856;
		 global::java.lang.String javax.microedition.khronos.egl.EGL10.eglQueryString(javax.microedition.khronos.egl.EGLDisplay arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglQueryString22856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglQueryString22856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _eglQuerySurface22857;
		 bool javax.microedition.khronos.egl.EGL10.eglQuerySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, int arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglQuerySurface22857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglQuerySurface22857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _eglSwapBuffers22858;
		 bool javax.microedition.khronos.egl.EGL10.eglSwapBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglSwapBuffers22858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglSwapBuffers22858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _eglTerminate22859;
		 bool javax.microedition.khronos.egl.EGL10.eglTerminate(javax.microedition.khronos.egl.EGLDisplay arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglTerminate22859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglTerminate22859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _eglWaitGL22860;
		 bool javax.microedition.khronos.egl.EGL10.eglWaitGL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglWaitGL22860);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglWaitGL22860);
		}
		internal static global::MonoJavaBridge.MethodId _eglWaitNative22861;
		 bool javax.microedition.khronos.egl.EGL10.eglWaitNative(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_._eglWaitNative22861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL11_.staticClass, global::javax.microedition.khronos.egl.EGL11_._eglWaitNative22861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGL11_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGL11"));
			global::javax.microedition.khronos.egl.EGL11_._eglChooseConfig22838 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglChooseConfig", "(Ljavax/microedition/khronos/egl/EGLDisplay;[I[Ljavax/microedition/khronos/egl/EGLConfig;I[I)Z");
			global::javax.microedition.khronos.egl.EGL11_._eglCopyBuffers22839 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglCopyBuffers", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;Ljava/lang/Object;)Z");
			global::javax.microedition.khronos.egl.EGL11_._eglCreateContext22840 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglCreateContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljavax/microedition/khronos/egl/EGLContext;[I)Ljavax/microedition/khronos/egl/EGLContext;");
			global::javax.microedition.khronos.egl.EGL11_._eglCreatePbufferSurface22841 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglCreatePbufferSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;[I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.EGL11_._eglCreatePixmapSurface22842 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglCreatePixmapSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljava/lang/Object;[I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.EGL11_._eglCreateWindowSurface22843 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglCreateWindowSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljava/lang/Object;[I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.EGL11_._eglDestroyContext22844 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglDestroyContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;)Z");
			global::javax.microedition.khronos.egl.EGL11_._eglDestroySurface22845 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglDestroySurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;)Z");
			global::javax.microedition.khronos.egl.EGL11_._eglGetConfigAttrib22846 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglGetConfigAttrib", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;I[I)Z");
			global::javax.microedition.khronos.egl.EGL11_._eglGetConfigs22847 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglGetConfigs", "(Ljavax/microedition/khronos/egl/EGLDisplay;[Ljavax/microedition/khronos/egl/EGLConfig;I[I)Z");
			global::javax.microedition.khronos.egl.EGL11_._eglGetCurrentContext22848 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglGetCurrentContext", "()Ljavax/microedition/khronos/egl/EGLContext;");
			global::javax.microedition.khronos.egl.EGL11_._eglGetCurrentDisplay22849 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglGetCurrentDisplay", "()Ljavax/microedition/khronos/egl/EGLDisplay;");
			global::javax.microedition.khronos.egl.EGL11_._eglGetCurrentSurface22850 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglGetCurrentSurface", "(I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.EGL11_._eglGetDisplay22851 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglGetDisplay", "(Ljava/lang/Object;)Ljavax/microedition/khronos/egl/EGLDisplay;");
			global::javax.microedition.khronos.egl.EGL11_._eglGetError22852 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglGetError", "()I");
			global::javax.microedition.khronos.egl.EGL11_._eglInitialize22853 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglInitialize", "(Ljavax/microedition/khronos/egl/EGLDisplay;[I)Z");
			global::javax.microedition.khronos.egl.EGL11_._eglMakeCurrent22854 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglMakeCurrent", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;Ljavax/microedition/khronos/egl/EGLSurface;Ljavax/microedition/khronos/egl/EGLContext;)Z");
			global::javax.microedition.khronos.egl.EGL11_._eglQueryContext22855 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglQueryContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;I[I)Z");
			global::javax.microedition.khronos.egl.EGL11_._eglQueryString22856 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglQueryString", "(Ljavax/microedition/khronos/egl/EGLDisplay;I)Ljava/lang/String;");
			global::javax.microedition.khronos.egl.EGL11_._eglQuerySurface22857 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglQuerySurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;I[I)Z");
			global::javax.microedition.khronos.egl.EGL11_._eglSwapBuffers22858 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglSwapBuffers", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;)Z");
			global::javax.microedition.khronos.egl.EGL11_._eglTerminate22859 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglTerminate", "(Ljavax/microedition/khronos/egl/EGLDisplay;)Z");
			global::javax.microedition.khronos.egl.EGL11_._eglWaitGL22860 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglWaitGL", "()Z");
			global::javax.microedition.khronos.egl.EGL11_._eglWaitNative22861 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL11_.staticClass, "eglWaitNative", "(ILjava/lang/Object;)Z");
		}
	}
}
