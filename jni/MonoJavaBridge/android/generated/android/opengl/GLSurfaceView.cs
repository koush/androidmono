namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLSurfaceView : android.view.SurfaceView, android.view.SurfaceHolder_Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GLSurfaceView()
		{
			InitJNI();
		}
		protected GLSurfaceView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.opengl.GLSurfaceView.EGLConfigChooser_))]
		public partial interface EGLConfigChooser  : global::MonoJavaBridge.IJavaObject 
		{
			global::javax.microedition.khronos.egl.EGLConfig chooseConfig(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.opengl.GLSurfaceView.EGLConfigChooser))]
		public sealed partial class EGLConfigChooser_ : java.lang.Object, EGLConfigChooser
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static EGLConfigChooser_()
			{
				InitJNI();
			}
			internal EGLConfigChooser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _chooseConfig9381;
			 global::javax.microedition.khronos.egl.EGLConfig android.opengl.GLSurfaceView.EGLConfigChooser.chooseConfig(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.EGLConfigChooser_._chooseConfig9381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.microedition.khronos.egl.EGLConfig;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.EGLConfigChooser_.staticClass, global::android.opengl.GLSurfaceView.EGLConfigChooser_._chooseConfig9381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.microedition.khronos.egl.EGLConfig;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.EGLConfigChooser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView$EGLConfigChooser"));
				global::android.opengl.GLSurfaceView.EGLConfigChooser_._chooseConfig9381 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.EGLConfigChooser_.staticClass, "chooseConfig", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;)Ljavax/microedition/khronos/egl/EGLConfig;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.opengl.GLSurfaceView.EGLContextFactory_))]
		public partial interface EGLContextFactory  : global::MonoJavaBridge.IJavaObject 
		{
			global::javax.microedition.khronos.egl.EGLContext createContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2);
			void destroyContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLContext arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.opengl.GLSurfaceView.EGLContextFactory))]
		public sealed partial class EGLContextFactory_ : java.lang.Object, EGLContextFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static EGLContextFactory_()
			{
				InitJNI();
			}
			internal EGLContextFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _createContext9382;
			 global::javax.microedition.khronos.egl.EGLContext android.opengl.GLSurfaceView.EGLContextFactory.createContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.EGLContextFactory_._createContext9382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.microedition.khronos.egl.EGLContext;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.EGLContextFactory_.staticClass, global::android.opengl.GLSurfaceView.EGLContextFactory_._createContext9382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.microedition.khronos.egl.EGLContext;
			}
			internal static global::MonoJavaBridge.MethodId _destroyContext9383;
			 void android.opengl.GLSurfaceView.EGLContextFactory.destroyContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLContext arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.EGLContextFactory_._destroyContext9383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.EGLContextFactory_.staticClass, global::android.opengl.GLSurfaceView.EGLContextFactory_._destroyContext9383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.EGLContextFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView$EGLContextFactory"));
				global::android.opengl.GLSurfaceView.EGLContextFactory_._createContext9382 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.EGLContextFactory_.staticClass, "createContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;)Ljavax/microedition/khronos/egl/EGLContext;");
				global::android.opengl.GLSurfaceView.EGLContextFactory_._destroyContext9383 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.EGLContextFactory_.staticClass, "destroyContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_))]
		public partial interface EGLWindowSurfaceFactory  : global::MonoJavaBridge.IJavaObject 
		{
			global::javax.microedition.khronos.egl.EGLSurface createWindowSurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2, java.lang.Object arg3);
			void destroySurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLSurface arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory))]
		public sealed partial class EGLWindowSurfaceFactory_ : java.lang.Object, EGLWindowSurfaceFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static EGLWindowSurfaceFactory_()
			{
				InitJNI();
			}
			internal EGLWindowSurfaceFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _createWindowSurface9384;
			 global::javax.microedition.khronos.egl.EGLSurface android.opengl.GLSurfaceView.EGLWindowSurfaceFactory.createWindowSurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2, java.lang.Object arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_._createWindowSurface9384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLSurface;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_.staticClass, global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_._createWindowSurface9384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLSurface;
			}
			internal static global::MonoJavaBridge.MethodId _destroySurface9385;
			 void android.opengl.GLSurfaceView.EGLWindowSurfaceFactory.destroySurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLSurface arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_._destroySurface9385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_.staticClass, global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_._destroySurface9385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView$EGLWindowSurfaceFactory"));
				global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_._createWindowSurface9384 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_.staticClass, "createWindowSurface", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljava/lang/Object;)Ljavax/microedition/khronos/egl/EGLSurface;");
				global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_._destroySurface9385 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_.staticClass, "destroySurface", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.opengl.GLSurfaceView.GLWrapper_))]
		public partial interface GLWrapper  : global::MonoJavaBridge.IJavaObject 
		{
			global::javax.microedition.khronos.opengles.GL wrap(javax.microedition.khronos.opengles.GL arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.opengl.GLSurfaceView.GLWrapper))]
		public sealed partial class GLWrapper_ : java.lang.Object, GLWrapper
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static GLWrapper_()
			{
				InitJNI();
			}
			internal GLWrapper_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _wrap9386;
			 global::javax.microedition.khronos.opengles.GL android.opengl.GLSurfaceView.GLWrapper.wrap(javax.microedition.khronos.opengles.GL arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.opengles.GL>(@__env.CallObjectMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.GLWrapper_._wrap9386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.microedition.khronos.opengles.GL;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.opengles.GL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.GLWrapper_.staticClass, global::android.opengl.GLSurfaceView.GLWrapper_._wrap9386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.microedition.khronos.opengles.GL;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.GLWrapper_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView$GLWrapper"));
				global::android.opengl.GLSurfaceView.GLWrapper_._wrap9386 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.GLWrapper_.staticClass, "wrap", "(Ljavax/microedition/khronos/opengles/GL;)Ljavax/microedition/khronos/opengles/GL;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.opengl.GLSurfaceView.Renderer_))]
		public partial interface Renderer  : global::MonoJavaBridge.IJavaObject 
		{
			void onSurfaceCreated(javax.microedition.khronos.opengles.GL10 arg0, javax.microedition.khronos.egl.EGLConfig arg1);
			void onSurfaceChanged(javax.microedition.khronos.opengles.GL10 arg0, int arg1, int arg2);
			void onDrawFrame(javax.microedition.khronos.opengles.GL10 arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.opengl.GLSurfaceView.Renderer))]
		public sealed partial class Renderer_ : java.lang.Object, Renderer
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Renderer_()
			{
				InitJNI();
			}
			internal Renderer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onSurfaceCreated9387;
			 void android.opengl.GLSurfaceView.Renderer.onSurfaceCreated(javax.microedition.khronos.opengles.GL10 arg0, javax.microedition.khronos.egl.EGLConfig arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.Renderer_._onSurfaceCreated9387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.Renderer_.staticClass, global::android.opengl.GLSurfaceView.Renderer_._onSurfaceCreated9387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onSurfaceChanged9388;
			 void android.opengl.GLSurfaceView.Renderer.onSurfaceChanged(javax.microedition.khronos.opengles.GL10 arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.Renderer_._onSurfaceChanged9388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.Renderer_.staticClass, global::android.opengl.GLSurfaceView.Renderer_._onSurfaceChanged9388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _onDrawFrame9389;
			 void android.opengl.GLSurfaceView.Renderer.onDrawFrame(javax.microedition.khronos.opengles.GL10 arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.Renderer_._onDrawFrame9389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.Renderer_.staticClass, global::android.opengl.GLSurfaceView.Renderer_._onDrawFrame9389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.Renderer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView$Renderer"));
				global::android.opengl.GLSurfaceView.Renderer_._onSurfaceCreated9387 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.Renderer_.staticClass, "onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V");
				global::android.opengl.GLSurfaceView.Renderer_._onSurfaceChanged9388 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.Renderer_.staticClass, "onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V");
				global::android.opengl.GLSurfaceView.Renderer_._onDrawFrame9389 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.Renderer_.staticClass, "onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onResume9390;
		public virtual void onResume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._onResume9390);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._onResume9390);
		}
		internal static global::MonoJavaBridge.MethodId _onPause9391;
		public virtual void onPause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._onPause9391);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._onPause9391);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow9392;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._onDetachedFromWindow9392);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._onDetachedFromWindow9392);
		}
		internal static global::MonoJavaBridge.MethodId _setGLWrapper9393;
		public virtual void setGLWrapper(android.opengl.GLSurfaceView.GLWrapper arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._setGLWrapper9393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setGLWrapper9393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDebugFlags9394;
		public virtual void setDebugFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._setDebugFlags9394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setDebugFlags9394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DebugFlags
		{
			get
			{
				return getDebugFlags();
			}
			set
			{
				setDebugFlags(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDebugFlags9395;
		public virtual int getDebugFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._getDebugFlags9395);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._getDebugFlags9395);
		}
		internal static global::MonoJavaBridge.MethodId _setRenderer9396;
		public virtual void setRenderer(android.opengl.GLSurfaceView.Renderer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._setRenderer9396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setRenderer9396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEGLContextFactory9397;
		public virtual void setEGLContextFactory(android.opengl.GLSurfaceView.EGLContextFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._setEGLContextFactory9397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLContextFactory9397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEGLWindowSurfaceFactory9398;
		public virtual void setEGLWindowSurfaceFactory(android.opengl.GLSurfaceView.EGLWindowSurfaceFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._setEGLWindowSurfaceFactory9398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLWindowSurfaceFactory9398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEGLConfigChooser9399;
		public virtual void setEGLConfigChooser(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._setEGLConfigChooser9399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLConfigChooser9399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEGLConfigChooser9400;
		public virtual void setEGLConfigChooser(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._setEGLConfigChooser9400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLConfigChooser9400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _setEGLConfigChooser9401;
		public virtual void setEGLConfigChooser(android.opengl.GLSurfaceView.EGLConfigChooser arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._setEGLConfigChooser9401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLConfigChooser9401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEGLContextClientVersion9402;
		public virtual void setEGLContextClientVersion(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._setEGLContextClientVersion9402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLContextClientVersion9402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRenderMode9403;
		public virtual void setRenderMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._setRenderMode9403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setRenderMode9403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int RenderMode
		{
			get
			{
				return getRenderMode();
			}
			set
			{
				setRenderMode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRenderMode9404;
		public virtual int getRenderMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._getRenderMode9404);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._getRenderMode9404);
		}
		internal static global::MonoJavaBridge.MethodId _requestRender9405;
		public virtual void requestRender() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._requestRender9405);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._requestRender9405);
		}
		internal static global::MonoJavaBridge.MethodId _surfaceCreated9406;
		public virtual void surfaceCreated(android.view.SurfaceHolder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._surfaceCreated9406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._surfaceCreated9406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _surfaceDestroyed9407;
		public virtual void surfaceDestroyed(android.view.SurfaceHolder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._surfaceDestroyed9407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._surfaceDestroyed9407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _surfaceChanged9408;
		public virtual void surfaceChanged(android.view.SurfaceHolder arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._surfaceChanged9408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._surfaceChanged9408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _queueEvent9409;
		public virtual void queueEvent(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView._queueEvent9409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._queueEvent9409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _GLSurfaceView9410;
		public GLSurfaceView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._GLSurfaceView9410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GLSurfaceView9411;
		public GLSurfaceView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._GLSurfaceView9411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int RENDERMODE_WHEN_DIRTY
		{
			get
			{
				return 0;
			}
		}
		public static int RENDERMODE_CONTINUOUSLY
		{
			get
			{
				return 1;
			}
		}
		public static int DEBUG_CHECK_GL_ERROR
		{
			get
			{
				return 1;
			}
		}
		public static int DEBUG_LOG_GL_CALLS
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLSurfaceView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView"));
			global::android.opengl.GLSurfaceView._onResume9390 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "onResume", "()V");
			global::android.opengl.GLSurfaceView._onPause9391 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "onPause", "()V");
			global::android.opengl.GLSurfaceView._onDetachedFromWindow9392 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "onDetachedFromWindow", "()V");
			global::android.opengl.GLSurfaceView._setGLWrapper9393 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setGLWrapper", "(Landroid/opengl/GLSurfaceView$GLWrapper;)V");
			global::android.opengl.GLSurfaceView._setDebugFlags9394 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setDebugFlags", "(I)V");
			global::android.opengl.GLSurfaceView._getDebugFlags9395 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "getDebugFlags", "()I");
			global::android.opengl.GLSurfaceView._setRenderer9396 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setRenderer", "(Landroid/opengl/GLSurfaceView$Renderer;)V");
			global::android.opengl.GLSurfaceView._setEGLContextFactory9397 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setEGLContextFactory", "(Landroid/opengl/GLSurfaceView$EGLContextFactory;)V");
			global::android.opengl.GLSurfaceView._setEGLWindowSurfaceFactory9398 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setEGLWindowSurfaceFactory", "(Landroid/opengl/GLSurfaceView$EGLWindowSurfaceFactory;)V");
			global::android.opengl.GLSurfaceView._setEGLConfigChooser9399 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setEGLConfigChooser", "(Z)V");
			global::android.opengl.GLSurfaceView._setEGLConfigChooser9400 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setEGLConfigChooser", "(IIIIII)V");
			global::android.opengl.GLSurfaceView._setEGLConfigChooser9401 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setEGLConfigChooser", "(Landroid/opengl/GLSurfaceView$EGLConfigChooser;)V");
			global::android.opengl.GLSurfaceView._setEGLContextClientVersion9402 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setEGLContextClientVersion", "(I)V");
			global::android.opengl.GLSurfaceView._setRenderMode9403 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setRenderMode", "(I)V");
			global::android.opengl.GLSurfaceView._getRenderMode9404 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "getRenderMode", "()I");
			global::android.opengl.GLSurfaceView._requestRender9405 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "requestRender", "()V");
			global::android.opengl.GLSurfaceView._surfaceCreated9406 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V");
			global::android.opengl.GLSurfaceView._surfaceDestroyed9407 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V");
			global::android.opengl.GLSurfaceView._surfaceChanged9408 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V");
			global::android.opengl.GLSurfaceView._queueEvent9409 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "queueEvent", "(Ljava/lang/Runnable;)V");
			global::android.opengl.GLSurfaceView._GLSurfaceView9410 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.opengl.GLSurfaceView._GLSurfaceView9411 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
