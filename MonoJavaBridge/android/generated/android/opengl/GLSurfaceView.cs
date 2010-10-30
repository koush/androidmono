namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLSurfaceView : android.view.SurfaceView, android.view.SurfaceHolder_Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GLSurfaceView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.opengl.GLSurfaceView.EGLConfigChooser_))]
		public partial interface EGLConfigChooser  : global::MonoJavaBridge.IJavaObject 
		{
			global::javax.microedition.khronos.egl.EGLConfig chooseConfig(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.opengl.GLSurfaceView.EGLConfigChooser))]
		internal sealed partial class EGLConfigChooser_ : java.lang.Object, EGLConfigChooser
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal EGLConfigChooser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _chooseConfig9421;
			global::javax.microedition.khronos.egl.EGLConfig android.opengl.GLSurfaceView.EGLConfigChooser.chooseConfig(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.EGLConfigChooser_._chooseConfig9421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.microedition.khronos.egl.EGLConfig;
			}
			static EGLConfigChooser_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.EGLConfigChooser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView$EGLConfigChooser"));
				global::android.opengl.GLSurfaceView.EGLConfigChooser_._chooseConfig9421 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.EGLConfigChooser_.staticClass, "chooseConfig", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;)Ljavax/microedition/khronos/egl/EGLConfig;");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate javax.microedition.khronos.egl.EGLConfig EGLConfigChooserDelegate(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1);

		internal partial class EGLConfigChooserDelegateWrapper : java.lang.Object, EGLConfigChooser
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected EGLConfigChooserDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _EGLConfigChooserDelegateWrapper9422;
			public EGLConfigChooserDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLSurfaceView.EGLConfigChooserDelegateWrapper.staticClass, global::android.opengl.GLSurfaceView.EGLConfigChooserDelegateWrapper._EGLConfigChooserDelegateWrapper9422);
				Init(@__env, handle);
			}
			static EGLConfigChooserDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.EGLConfigChooserDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView_EGLConfigChooserDelegateWrapper"));
				global::android.opengl.GLSurfaceView.EGLConfigChooserDelegateWrapper._EGLConfigChooserDelegateWrapper9422 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.EGLConfigChooserDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class EGLConfigChooserDelegateWrapper
		{
			private EGLConfigChooserDelegate myDelegate;
			public javax.microedition.khronos.egl.EGLConfig chooseConfig(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1)
			{
				return myDelegate(arg0, arg1);
			}
			public static implicit operator EGLConfigChooserDelegateWrapper(EGLConfigChooserDelegate d)
			{
				global::android.opengl.GLSurfaceView.EGLConfigChooserDelegateWrapper ret = new global::android.opengl.GLSurfaceView.EGLConfigChooserDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.opengl.GLSurfaceView.EGLContextFactory_))]
		public partial interface EGLContextFactory  : global::MonoJavaBridge.IJavaObject 
		{
			global::javax.microedition.khronos.egl.EGLContext createContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2);
			void destroyContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLContext arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.opengl.GLSurfaceView.EGLContextFactory))]
		internal sealed partial class EGLContextFactory_ : java.lang.Object, EGLContextFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal EGLContextFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _createContext9423;
			global::javax.microedition.khronos.egl.EGLContext android.opengl.GLSurfaceView.EGLContextFactory.createContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.EGLContextFactory_._createContext9423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.microedition.khronos.egl.EGLContext;
			}
			internal static global::MonoJavaBridge.MethodId _destroyContext9424;
			void android.opengl.GLSurfaceView.EGLContextFactory.destroyContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLContext arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.EGLContextFactory_._destroyContext9424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static EGLContextFactory_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.EGLContextFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView$EGLContextFactory"));
				global::android.opengl.GLSurfaceView.EGLContextFactory_._createContext9423 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.EGLContextFactory_.staticClass, "createContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;)Ljavax/microedition/khronos/egl/EGLContext;");
				global::android.opengl.GLSurfaceView.EGLContextFactory_._destroyContext9424 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.EGLContextFactory_.staticClass, "destroyContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_))]
		public partial interface EGLWindowSurfaceFactory  : global::MonoJavaBridge.IJavaObject 
		{
			global::javax.microedition.khronos.egl.EGLSurface createWindowSurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2, java.lang.Object arg3);
			void destroySurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLSurface arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory))]
		internal sealed partial class EGLWindowSurfaceFactory_ : java.lang.Object, EGLWindowSurfaceFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal EGLWindowSurfaceFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _createWindowSurface9425;
			global::javax.microedition.khronos.egl.EGLSurface android.opengl.GLSurfaceView.EGLWindowSurfaceFactory.createWindowSurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2, java.lang.Object arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_._createWindowSurface9425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLSurface;
			}
			internal static global::MonoJavaBridge.MethodId _destroySurface9426;
			void android.opengl.GLSurfaceView.EGLWindowSurfaceFactory.destroySurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLSurface arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_._destroySurface9426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static EGLWindowSurfaceFactory_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView$EGLWindowSurfaceFactory"));
				global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_._createWindowSurface9425 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_.staticClass, "createWindowSurface", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljava/lang/Object;)Ljavax/microedition/khronos/egl/EGLSurface;");
				global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_._destroySurface9426 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_.staticClass, "destroySurface", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.opengl.GLSurfaceView.GLWrapper_))]
		public partial interface GLWrapper  : global::MonoJavaBridge.IJavaObject 
		{
			global::javax.microedition.khronos.opengles.GL wrap(javax.microedition.khronos.opengles.GL arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.opengl.GLSurfaceView.GLWrapper))]
		internal sealed partial class GLWrapper_ : java.lang.Object, GLWrapper
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal GLWrapper_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _wrap9427;
			global::javax.microedition.khronos.opengles.GL android.opengl.GLSurfaceView.GLWrapper.wrap(javax.microedition.khronos.opengles.GL arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.opengles.GL>(@__env.CallObjectMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.GLWrapper_._wrap9427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.microedition.khronos.opengles.GL;
			}
			static GLWrapper_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.GLWrapper_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView$GLWrapper"));
				global::android.opengl.GLSurfaceView.GLWrapper_._wrap9427 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.GLWrapper_.staticClass, "wrap", "(Ljavax/microedition/khronos/opengles/GL;)Ljavax/microedition/khronos/opengles/GL;");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate javax.microedition.khronos.opengles.GL GLWrapperDelegate(javax.microedition.khronos.opengles.GL arg0);

		internal partial class GLWrapperDelegateWrapper : java.lang.Object, GLWrapper
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected GLWrapperDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _GLWrapperDelegateWrapper9428;
			public GLWrapperDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLSurfaceView.GLWrapperDelegateWrapper.staticClass, global::android.opengl.GLSurfaceView.GLWrapperDelegateWrapper._GLWrapperDelegateWrapper9428);
				Init(@__env, handle);
			}
			static GLWrapperDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.GLWrapperDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView_GLWrapperDelegateWrapper"));
				global::android.opengl.GLSurfaceView.GLWrapperDelegateWrapper._GLWrapperDelegateWrapper9428 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.GLWrapperDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class GLWrapperDelegateWrapper
		{
			private GLWrapperDelegate myDelegate;
			public javax.microedition.khronos.opengles.GL wrap(javax.microedition.khronos.opengles.GL arg0)
			{
				return myDelegate(arg0);
			}
			public static implicit operator GLWrapperDelegateWrapper(GLWrapperDelegate d)
			{
				global::android.opengl.GLSurfaceView.GLWrapperDelegateWrapper ret = new global::android.opengl.GLSurfaceView.GLWrapperDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
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
		internal sealed partial class Renderer_ : java.lang.Object, Renderer
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Renderer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onSurfaceCreated9429;
			void android.opengl.GLSurfaceView.Renderer.onSurfaceCreated(javax.microedition.khronos.opengles.GL10 arg0, javax.microedition.khronos.egl.EGLConfig arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.Renderer_._onSurfaceCreated9429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onSurfaceChanged9430;
			void android.opengl.GLSurfaceView.Renderer.onSurfaceChanged(javax.microedition.khronos.opengles.GL10 arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.Renderer_._onSurfaceChanged9430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _onDrawFrame9431;
			void android.opengl.GLSurfaceView.Renderer.onDrawFrame(javax.microedition.khronos.opengles.GL10 arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.opengl.GLSurfaceView.Renderer_._onDrawFrame9431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static Renderer_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.Renderer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView$Renderer"));
				global::android.opengl.GLSurfaceView.Renderer_._onSurfaceCreated9429 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.Renderer_.staticClass, "onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V");
				global::android.opengl.GLSurfaceView.Renderer_._onSurfaceChanged9430 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.Renderer_.staticClass, "onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V");
				global::android.opengl.GLSurfaceView.Renderer_._onDrawFrame9431 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.Renderer_.staticClass, "onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _onResume9432;
		public virtual void onResume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._onResume9432);
		}
		internal static global::MonoJavaBridge.MethodId _onPause9433;
		public virtual void onPause()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._onPause9433);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow9434;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._onDetachedFromWindow9434);
		}
		internal static global::MonoJavaBridge.MethodId _setGLWrapper9435;
		public virtual void setGLWrapper(android.opengl.GLSurfaceView.GLWrapper arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setGLWrapper9435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setGLWrapper(global::android.opengl.GLSurfaceView.GLWrapperDelegate arg0)
		{
			setGLWrapper((global::android.opengl.GLSurfaceView.GLWrapperDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setDebugFlags9436;
		public virtual void setDebugFlags(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setDebugFlags9436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDebugFlags9437;
		public virtual int getDebugFlags()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._getDebugFlags9437);
		}
		internal static global::MonoJavaBridge.MethodId _setRenderer9438;
		public virtual void setRenderer(android.opengl.GLSurfaceView.Renderer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setRenderer9438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEGLContextFactory9439;
		public virtual void setEGLContextFactory(android.opengl.GLSurfaceView.EGLContextFactory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLContextFactory9439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEGLWindowSurfaceFactory9440;
		public virtual void setEGLWindowSurfaceFactory(android.opengl.GLSurfaceView.EGLWindowSurfaceFactory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLWindowSurfaceFactory9440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEGLConfigChooser9441;
		public virtual void setEGLConfigChooser(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLConfigChooser9441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEGLConfigChooser9442;
		public virtual void setEGLConfigChooser(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLConfigChooser9442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _setEGLConfigChooser9443;
		public virtual void setEGLConfigChooser(android.opengl.GLSurfaceView.EGLConfigChooser arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLConfigChooser9443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setEGLConfigChooser(global::android.opengl.GLSurfaceView.EGLConfigChooserDelegate arg0)
		{
			setEGLConfigChooser((global::android.opengl.GLSurfaceView.EGLConfigChooserDelegateWrapper)arg0);
		}
		public new int EGLContextClientVersion
		{
			set
			{
				setEGLContextClientVersion(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEGLContextClientVersion9444;
		public virtual void setEGLContextClientVersion(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLContextClientVersion9444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRenderMode9445;
		public virtual void setRenderMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setRenderMode9445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getRenderMode9446;
		public virtual int getRenderMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._getRenderMode9446);
		}
		internal static global::MonoJavaBridge.MethodId _requestRender9447;
		public virtual void requestRender()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._requestRender9447);
		}
		internal static global::MonoJavaBridge.MethodId _surfaceCreated9448;
		public virtual void surfaceCreated(android.view.SurfaceHolder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._surfaceCreated9448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _surfaceDestroyed9449;
		public virtual void surfaceDestroyed(android.view.SurfaceHolder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._surfaceDestroyed9449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _surfaceChanged9450;
		public virtual void surfaceChanged(android.view.SurfaceHolder arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._surfaceChanged9450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _queueEvent9451;
		public virtual void queueEvent(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._queueEvent9451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void queueEvent(global::java.lang.RunnableDelegate arg0)
		{
			queueEvent((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _GLSurfaceView9452;
		public GLSurfaceView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._GLSurfaceView9452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GLSurfaceView9453;
		public GLSurfaceView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._GLSurfaceView9453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		static GLSurfaceView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLSurfaceView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView"));
			global::android.opengl.GLSurfaceView._onResume9432 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "onResume", "()V");
			global::android.opengl.GLSurfaceView._onPause9433 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "onPause", "()V");
			global::android.opengl.GLSurfaceView._onDetachedFromWindow9434 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "onDetachedFromWindow", "()V");
			global::android.opengl.GLSurfaceView._setGLWrapper9435 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setGLWrapper", "(Landroid/opengl/GLSurfaceView$GLWrapper;)V");
			global::android.opengl.GLSurfaceView._setDebugFlags9436 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setDebugFlags", "(I)V");
			global::android.opengl.GLSurfaceView._getDebugFlags9437 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "getDebugFlags", "()I");
			global::android.opengl.GLSurfaceView._setRenderer9438 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setRenderer", "(Landroid/opengl/GLSurfaceView$Renderer;)V");
			global::android.opengl.GLSurfaceView._setEGLContextFactory9439 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setEGLContextFactory", "(Landroid/opengl/GLSurfaceView$EGLContextFactory;)V");
			global::android.opengl.GLSurfaceView._setEGLWindowSurfaceFactory9440 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setEGLWindowSurfaceFactory", "(Landroid/opengl/GLSurfaceView$EGLWindowSurfaceFactory;)V");
			global::android.opengl.GLSurfaceView._setEGLConfigChooser9441 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setEGLConfigChooser", "(Z)V");
			global::android.opengl.GLSurfaceView._setEGLConfigChooser9442 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setEGLConfigChooser", "(IIIIII)V");
			global::android.opengl.GLSurfaceView._setEGLConfigChooser9443 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setEGLConfigChooser", "(Landroid/opengl/GLSurfaceView$EGLConfigChooser;)V");
			global::android.opengl.GLSurfaceView._setEGLContextClientVersion9444 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setEGLContextClientVersion", "(I)V");
			global::android.opengl.GLSurfaceView._setRenderMode9445 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "setRenderMode", "(I)V");
			global::android.opengl.GLSurfaceView._getRenderMode9446 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "getRenderMode", "()I");
			global::android.opengl.GLSurfaceView._requestRender9447 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "requestRender", "()V");
			global::android.opengl.GLSurfaceView._surfaceCreated9448 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V");
			global::android.opengl.GLSurfaceView._surfaceDestroyed9449 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V");
			global::android.opengl.GLSurfaceView._surfaceChanged9450 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V");
			global::android.opengl.GLSurfaceView._queueEvent9451 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "queueEvent", "(Ljava/lang/Runnable;)V");
			global::android.opengl.GLSurfaceView._GLSurfaceView9452 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.opengl.GLSurfaceView._GLSurfaceView9453 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
