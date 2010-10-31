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
			private static global::MonoJavaBridge.MethodId _m0;
			global::javax.microedition.khronos.egl.EGLConfig android.opengl.GLSurfaceView.EGLConfigChooser.chooseConfig(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.opengl.GLSurfaceView.EGLConfigChooser_.staticClass, "chooseConfig", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;)Ljavax/microedition/khronos/egl/EGLConfig;", ref global::android.opengl.GLSurfaceView.EGLConfigChooser_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as javax.microedition.khronos.egl.EGLConfig;
			}
			static EGLConfigChooser_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.EGLConfigChooser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView$EGLConfigChooser"));
			}
		}

		public delegate javax.microedition.khronos.egl.EGLConfig EGLConfigChooserDelegate(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1);

		internal partial class EGLConfigChooserDelegateWrapper : java.lang.Object, EGLConfigChooser
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected EGLConfigChooserDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public EGLConfigChooserDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.opengl.GLSurfaceView.EGLConfigChooserDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.opengl.GLSurfaceView.EGLConfigChooserDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.EGLConfigChooserDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLSurfaceView.EGLConfigChooserDelegateWrapper.staticClass, global::android.opengl.GLSurfaceView.EGLConfigChooserDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static EGLConfigChooserDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.EGLConfigChooserDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView_EGLConfigChooserDelegateWrapper"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			global::javax.microedition.khronos.egl.EGLContext android.opengl.GLSurfaceView.EGLContextFactory.createContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.opengl.GLSurfaceView.EGLContextFactory_.staticClass, "createContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;)Ljavax/microedition/khronos/egl/EGLContext;", ref global::android.opengl.GLSurfaceView.EGLContextFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as javax.microedition.khronos.egl.EGLContext;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.opengl.GLSurfaceView.EGLContextFactory.destroyContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLContext arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.EGLContextFactory_.staticClass, "destroyContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;)V", ref global::android.opengl.GLSurfaceView.EGLContextFactory_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static EGLContextFactory_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.EGLContextFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView$EGLContextFactory"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			global::javax.microedition.khronos.egl.EGLSurface android.opengl.GLSurfaceView.EGLWindowSurfaceFactory.createWindowSurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2, java.lang.Object arg3)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_.staticClass, "createWindowSurface", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljava/lang/Object;)Ljavax/microedition/khronos/egl/EGLSurface;", ref global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.microedition.khronos.egl.EGLSurface;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.opengl.GLSurfaceView.EGLWindowSurfaceFactory.destroySurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLSurface arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_.staticClass, "destroySurface", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;)V", ref global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static EGLWindowSurfaceFactory_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.EGLWindowSurfaceFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView$EGLWindowSurfaceFactory"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			global::javax.microedition.khronos.opengles.GL android.opengl.GLSurfaceView.GLWrapper.wrap(javax.microedition.khronos.opengles.GL arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.microedition.khronos.opengles.GL>(this, global::android.opengl.GLSurfaceView.GLWrapper_.staticClass, "wrap", "(Ljavax/microedition/khronos/opengles/GL;)Ljavax/microedition/khronos/opengles/GL;", ref global::android.opengl.GLSurfaceView.GLWrapper_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.microedition.khronos.opengles.GL;
			}
			static GLWrapper_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.GLWrapper_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView$GLWrapper"));
			}
		}

		public delegate javax.microedition.khronos.opengles.GL GLWrapperDelegate(javax.microedition.khronos.opengles.GL arg0);

		internal partial class GLWrapperDelegateWrapper : java.lang.Object, GLWrapper
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected GLWrapperDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public GLWrapperDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.opengl.GLSurfaceView.GLWrapperDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.opengl.GLSurfaceView.GLWrapperDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.GLWrapperDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLSurfaceView.GLWrapperDelegateWrapper.staticClass, global::android.opengl.GLSurfaceView.GLWrapperDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static GLWrapperDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.GLWrapperDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView_GLWrapperDelegateWrapper"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			void android.opengl.GLSurfaceView.Renderer.onSurfaceCreated(javax.microedition.khronos.opengles.GL10 arg0, javax.microedition.khronos.egl.EGLConfig arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.Renderer_.staticClass, "onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V", ref global::android.opengl.GLSurfaceView.Renderer_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.opengl.GLSurfaceView.Renderer.onSurfaceChanged(javax.microedition.khronos.opengles.GL10 arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.Renderer_.staticClass, "onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V", ref global::android.opengl.GLSurfaceView.Renderer_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			void android.opengl.GLSurfaceView.Renderer.onDrawFrame(javax.microedition.khronos.opengles.GL10 arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.Renderer_.staticClass, "onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V", ref global::android.opengl.GLSurfaceView.Renderer_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static Renderer_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.opengl.GLSurfaceView.Renderer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLSurfaceView$Renderer"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void onResume()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "onResume", "()V", ref global::android.opengl.GLSurfaceView._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onPause()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "onPause", "()V", ref global::android.opengl.GLSurfaceView._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "onDetachedFromWindow", "()V", ref global::android.opengl.GLSurfaceView._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setGLWrapper(android.opengl.GLSurfaceView.GLWrapper arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "setGLWrapper", "(Landroid/opengl/GLSurfaceView$GLWrapper;)V", ref global::android.opengl.GLSurfaceView._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setGLWrapper(global::android.opengl.GLSurfaceView.GLWrapperDelegate arg0)
		{
			setGLWrapper((global::android.opengl.GLSurfaceView.GLWrapperDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setDebugFlags(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "setDebugFlags", "(I)V", ref global::android.opengl.GLSurfaceView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getDebugFlags()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.opengl.GLSurfaceView.staticClass, "getDebugFlags", "()I", ref global::android.opengl.GLSurfaceView._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setRenderer(android.opengl.GLSurfaceView.Renderer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "setRenderer", "(Landroid/opengl/GLSurfaceView$Renderer;)V", ref global::android.opengl.GLSurfaceView._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setEGLContextFactory(android.opengl.GLSurfaceView.EGLContextFactory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "setEGLContextFactory", "(Landroid/opengl/GLSurfaceView$EGLContextFactory;)V", ref global::android.opengl.GLSurfaceView._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setEGLWindowSurfaceFactory(android.opengl.GLSurfaceView.EGLWindowSurfaceFactory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "setEGLWindowSurfaceFactory", "(Landroid/opengl/GLSurfaceView$EGLWindowSurfaceFactory;)V", ref global::android.opengl.GLSurfaceView._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setEGLConfigChooser(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "setEGLConfigChooser", "(Z)V", ref global::android.opengl.GLSurfaceView._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setEGLConfigChooser(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "setEGLConfigChooser", "(IIIIII)V", ref global::android.opengl.GLSurfaceView._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setEGLConfigChooser(android.opengl.GLSurfaceView.EGLConfigChooser arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "setEGLConfigChooser", "(Landroid/opengl/GLSurfaceView$EGLConfigChooser;)V", ref global::android.opengl.GLSurfaceView._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setEGLContextClientVersion(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "setEGLContextClientVersion", "(I)V", ref global::android.opengl.GLSurfaceView._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setRenderMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "setRenderMode", "(I)V", ref global::android.opengl.GLSurfaceView._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int getRenderMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.opengl.GLSurfaceView.staticClass, "getRenderMode", "()I", ref global::android.opengl.GLSurfaceView._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void requestRender()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "requestRender", "()V", ref global::android.opengl.GLSurfaceView._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void surfaceCreated(android.view.SurfaceHolder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V", ref global::android.opengl.GLSurfaceView._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void surfaceDestroyed(android.view.SurfaceHolder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", ref global::android.opengl.GLSurfaceView._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void surfaceChanged(android.view.SurfaceHolder arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", ref global::android.opengl.GLSurfaceView._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void queueEvent(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, "queueEvent", "(Ljava/lang/Runnable;)V", ref global::android.opengl.GLSurfaceView._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void queueEvent(global::java.lang.RunnableDelegate arg0)
		{
			queueEvent((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public GLSurfaceView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLSurfaceView._m20.native == global::System.IntPtr.Zero)
				global::android.opengl.GLSurfaceView._m20 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public GLSurfaceView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLSurfaceView._m21.native == global::System.IntPtr.Zero)
				global::android.opengl.GLSurfaceView._m21 = @__env.GetMethodIDNoThrow(global::android.opengl.GLSurfaceView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		}
	}
}
