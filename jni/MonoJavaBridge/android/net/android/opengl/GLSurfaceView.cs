namespace android.opengl 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GLSurfaceView : android.view.SurfaceView, android.view.SurfaceHolder_Callback
	{ 
		internal new static global::java.lang.Class staticClass; 
		static GLSurfaceView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.opengl.GLSurfaceView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.opengl.GLSurfaceView(@__env); 
			} 
		} 
		protected GLSurfaceView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface EGLConfigChooser 
		{ 
			javax.microedition.khronos.egl.EGLConfig chooseConfig(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface EGLContextFactory 
		{ 
			javax.microedition.khronos.egl.EGLContext createContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2); 
			void destroyContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLContext arg2); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface EGLWindowSurfaceFactory 
		{ 
			javax.microedition.khronos.egl.EGLSurface createWindowSurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2, java.lang.Object arg3); 
			void destroySurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLSurface arg2); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface GLWrapper 
		{ 
			javax.microedition.khronos.opengles.GL wrap(javax.microedition.khronos.opengles.GL arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface Renderer 
		{ 
			void onSurfaceCreated(javax.microedition.khronos.opengles.GL10 arg0, javax.microedition.khronos.egl.EGLConfig arg1); 
			void onSurfaceChanged(javax.microedition.khronos.opengles.GL10 arg0, int arg1, int arg2); 
			void onDrawFrame(javax.microedition.khronos.opengles.GL10 arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onResume5017; 
		public virtual void onResume() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _onResume5017); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _onResume5017); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPause5018; 
		public virtual void onPause() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _onPause5018); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _onPause5018); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow5019; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow5019); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _onDetachedFromWindow5019); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGLWrapper5020; 
		public virtual void setGLWrapper(android.opengl.GLSurfaceView.GLWrapper arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _setGLWrapper5020, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _setGLWrapper5020, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDebugFlags5021; 
		public virtual void setDebugFlags(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _setDebugFlags5021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _setDebugFlags5021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDebugFlags5022; 
		public virtual int getDebugFlags() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				return @__env.CallIntMethod(this, _getDebugFlags5022); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.opengl.GLSurfaceView.staticClass, _getDebugFlags5022); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRenderer5023; 
		public virtual void setRenderer(android.opengl.GLSurfaceView.Renderer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _setRenderer5023, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _setRenderer5023, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEGLContextFactory5024; 
		public virtual void setEGLContextFactory(android.opengl.GLSurfaceView.EGLContextFactory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _setEGLContextFactory5024, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _setEGLContextFactory5024, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEGLWindowSurfaceFactory5025; 
		public virtual void setEGLWindowSurfaceFactory(android.opengl.GLSurfaceView.EGLWindowSurfaceFactory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _setEGLWindowSurfaceFactory5025, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _setEGLWindowSurfaceFactory5025, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEGLConfigChooser5026; 
		public virtual void setEGLConfigChooser(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _setEGLConfigChooser5026, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _setEGLConfigChooser5026, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEGLConfigChooser5027; 
		public virtual void setEGLConfigChooser(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _setEGLConfigChooser5027, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _setEGLConfigChooser5027, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEGLConfigChooser5028; 
		public virtual void setEGLConfigChooser(android.opengl.GLSurfaceView.EGLConfigChooser arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _setEGLConfigChooser5028, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _setEGLConfigChooser5028, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRenderMode5029; 
		public virtual void setRenderMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _setRenderMode5029, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _setRenderMode5029, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRenderMode5030; 
		public virtual int getRenderMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				return @__env.CallIntMethod(this, _getRenderMode5030); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.opengl.GLSurfaceView.staticClass, _getRenderMode5030); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestRender5031; 
		public virtual void requestRender() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _requestRender5031); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _requestRender5031); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _surfaceCreated5032; 
		public virtual void surfaceCreated(android.view.SurfaceHolder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _surfaceCreated5032, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _surfaceCreated5032, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _surfaceDestroyed5033; 
		public virtual void surfaceDestroyed(android.view.SurfaceHolder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _surfaceDestroyed5033, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _surfaceDestroyed5033, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _surfaceChanged5034; 
		public virtual void surfaceChanged(android.view.SurfaceHolder arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _surfaceChanged5034, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _surfaceChanged5034, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _queueEvent5035; 
		public virtual void queueEvent(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.opengl.GLSurfaceView)) 
				@__env.CallVoidMethod(this, _queueEvent5035, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.opengl.GLSurfaceView.staticClass, _queueEvent5035, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GLSurfaceView5036; 
		public GLSurfaceView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.opengl.GLSurfaceView.staticClass, _GLSurfaceView5036, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GLSurfaceView5037; 
		public GLSurfaceView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.opengl.GLSurfaceView.staticClass, _GLSurfaceView5037, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.opengl.GLSurfaceView.staticClass = @__class; 
			global::android.opengl.GLSurfaceView._onResume5017 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "onResume", "()V"); 
			global::android.opengl.GLSurfaceView._onPause5018 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "onPause", "()V"); 
			global::android.opengl.GLSurfaceView._onDetachedFromWindow5019 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.opengl.GLSurfaceView._setGLWrapper5020 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setGLWrapper", "(Landroid/opengl/GLSurfaceView$GLWrapper;)V"); 
			global::android.opengl.GLSurfaceView._setDebugFlags5021 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setDebugFlags", "(I)V"); 
			global::android.opengl.GLSurfaceView._getDebugFlags5022 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "getDebugFlags", "()I"); 
			global::android.opengl.GLSurfaceView._setRenderer5023 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setRenderer", "(Landroid/opengl/GLSurfaceView$Renderer;)V"); 
			global::android.opengl.GLSurfaceView._setEGLContextFactory5024 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setEGLContextFactory", "(Landroid/opengl/GLSurfaceView$EGLContextFactory;)V"); 
			global::android.opengl.GLSurfaceView._setEGLWindowSurfaceFactory5025 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setEGLWindowSurfaceFactory", "(Landroid/opengl/GLSurfaceView$EGLWindowSurfaceFactory;)V"); 
			global::android.opengl.GLSurfaceView._setEGLConfigChooser5026 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setEGLConfigChooser", "(Z)V"); 
			global::android.opengl.GLSurfaceView._setEGLConfigChooser5027 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setEGLConfigChooser", "(IIIIII)V"); 
			global::android.opengl.GLSurfaceView._setEGLConfigChooser5028 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setEGLConfigChooser", "(Landroid/opengl/GLSurfaceView$EGLConfigChooser;)V"); 
			global::android.opengl.GLSurfaceView._setRenderMode5029 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setRenderMode", "(I)V"); 
			global::android.opengl.GLSurfaceView._getRenderMode5030 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "getRenderMode", "()I"); 
			global::android.opengl.GLSurfaceView._requestRender5031 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "requestRender", "()V"); 
			global::android.opengl.GLSurfaceView._surfaceCreated5032 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V"); 
			global::android.opengl.GLSurfaceView._surfaceDestroyed5033 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V"); 
			global::android.opengl.GLSurfaceView._surfaceChanged5034 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V"); 
			global::android.opengl.GLSurfaceView._queueEvent5035 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "queueEvent", "(Ljava/lang/Runnable;)V"); 
			global::android.opengl.GLSurfaceView._GLSurfaceView5036 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.opengl.GLSurfaceView._GLSurfaceView5037 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
