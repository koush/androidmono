namespace android.opengl 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GLSurfaceView : android.view.SurfaceView, android.view.SurfaceHolder_Callback
	{ 
		internal new static global::java.lang.Class staticClass; 
		static GLSurfaceView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.GLSurfaceView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			global::javax.microedition.khronos.egl.EGLConfig chooseConfig(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1); 
		} 

		public partial class EGLConfigChooser_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __EGLConfigChooser.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __EGLConfigChooser : java.lang.Object, EGLConfigChooser
		{ 
			internal static global::java.lang.Class staticClass; 
			static __EGLConfigChooser() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.GLSurfaceView.__EGLConfigChooser), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.opengl.GLSurfaceView.__EGLConfigChooser(@__env); 
				} 
			} 
			internal __EGLConfigChooser(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _chooseConfig5266; 
			 global::javax.microedition.khronos.egl.EGLConfig android.opengl.GLSurfaceView.EGLConfigChooser.chooseConfig(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLConfig>(@__env, @__env.CallObjectMethodPtr(this, global::android.opengl.GLSurfaceView.__EGLConfigChooser._chooseConfig5266, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLConfig>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.opengl.GLSurfaceView.__EGLConfigChooser.staticClass, global::android.opengl.GLSurfaceView.__EGLConfigChooser._chooseConfig5266, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.opengl.GLSurfaceView.__EGLConfigChooser.staticClass = @__class; 
				global::android.opengl.GLSurfaceView.__EGLConfigChooser._chooseConfig5266 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.__EGLConfigChooser.staticClass, "android.opengl.GLSurfaceView.EGLConfigChooser.chooseConfig", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;)Ljavax/microedition/khronos/egl/EGLConfig;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface EGLContextFactory 
		{ 
			global::javax.microedition.khronos.egl.EGLContext createContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2); 
			void destroyContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLContext arg2); 
		} 

		public partial class EGLContextFactory_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __EGLContextFactory.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __EGLContextFactory : java.lang.Object, EGLContextFactory
		{ 
			internal static global::java.lang.Class staticClass; 
			static __EGLContextFactory() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.GLSurfaceView.__EGLContextFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.opengl.GLSurfaceView.__EGLContextFactory(@__env); 
				} 
			} 
			internal __EGLContextFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _createContext5267; 
			 global::javax.microedition.khronos.egl.EGLContext android.opengl.GLSurfaceView.EGLContextFactory.createContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLContext>(@__env, @__env.CallObjectMethodPtr(this, global::android.opengl.GLSurfaceView.__EGLContextFactory._createContext5267, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLContext>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.opengl.GLSurfaceView.__EGLContextFactory.staticClass, global::android.opengl.GLSurfaceView.__EGLContextFactory._createContext5267, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _destroyContext5268; 
			 void android.opengl.GLSurfaceView.EGLContextFactory.destroyContext(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLContext arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView.__EGLContextFactory._destroyContext5268, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.__EGLContextFactory.staticClass, global::android.opengl.GLSurfaceView.__EGLContextFactory._destroyContext5268, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.opengl.GLSurfaceView.__EGLContextFactory.staticClass = @__class; 
				global::android.opengl.GLSurfaceView.__EGLContextFactory._createContext5267 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.__EGLContextFactory.staticClass, "android.opengl.GLSurfaceView.EGLContextFactory.createContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;)Ljavax/microedition/khronos/egl/EGLContext;"); 
				global::android.opengl.GLSurfaceView.__EGLContextFactory._destroyContext5268 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.__EGLContextFactory.staticClass, "android.opengl.GLSurfaceView.EGLContextFactory.destroyContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface EGLWindowSurfaceFactory 
		{ 
			global::javax.microedition.khronos.egl.EGLSurface createWindowSurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2, java.lang.Object arg3); 
			void destroySurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLSurface arg2); 
		} 

		public partial class EGLWindowSurfaceFactory_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __EGLWindowSurfaceFactory.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __EGLWindowSurfaceFactory : java.lang.Object, EGLWindowSurfaceFactory
		{ 
			internal static global::java.lang.Class staticClass; 
			static __EGLWindowSurfaceFactory() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.GLSurfaceView.__EGLWindowSurfaceFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.opengl.GLSurfaceView.__EGLWindowSurfaceFactory(@__env); 
				} 
			} 
			internal __EGLWindowSurfaceFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _createWindowSurface5269; 
			 global::javax.microedition.khronos.egl.EGLSurface android.opengl.GLSurfaceView.EGLWindowSurfaceFactory.createWindowSurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLConfig arg2, java.lang.Object arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLSurface>(@__env, @__env.CallObjectMethodPtr(this, global::android.opengl.GLSurfaceView.__EGLWindowSurfaceFactory._createWindowSurface5269, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.microedition.khronos.egl.EGLSurface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.opengl.GLSurfaceView.__EGLWindowSurfaceFactory.staticClass, global::android.opengl.GLSurfaceView.__EGLWindowSurfaceFactory._createWindowSurface5269, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _destroySurface5270; 
			 void android.opengl.GLSurfaceView.EGLWindowSurfaceFactory.destroySurface(javax.microedition.khronos.egl.EGL10 arg0, javax.microedition.khronos.egl.EGLDisplay arg1, javax.microedition.khronos.egl.EGLSurface arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView.__EGLWindowSurfaceFactory._destroySurface5270, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.__EGLWindowSurfaceFactory.staticClass, global::android.opengl.GLSurfaceView.__EGLWindowSurfaceFactory._destroySurface5270, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.opengl.GLSurfaceView.__EGLWindowSurfaceFactory.staticClass = @__class; 
				global::android.opengl.GLSurfaceView.__EGLWindowSurfaceFactory._createWindowSurface5269 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.__EGLWindowSurfaceFactory.staticClass, "android.opengl.GLSurfaceView.EGLWindowSurfaceFactory.createWindowSurface", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljava/lang/Object;)Ljavax/microedition/khronos/egl/EGLSurface;"); 
				global::android.opengl.GLSurfaceView.__EGLWindowSurfaceFactory._destroySurface5270 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.__EGLWindowSurfaceFactory.staticClass, "android.opengl.GLSurfaceView.EGLWindowSurfaceFactory.destroySurface", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface GLWrapper 
		{ 
			global::javax.microedition.khronos.opengles.GL wrap(javax.microedition.khronos.opengles.GL arg0); 
		} 

		public partial class GLWrapper_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __GLWrapper.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __GLWrapper : java.lang.Object, GLWrapper
		{ 
			internal static global::java.lang.Class staticClass; 
			static __GLWrapper() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.GLSurfaceView.__GLWrapper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.opengl.GLSurfaceView.__GLWrapper(@__env); 
				} 
			} 
			internal __GLWrapper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _wrap5271; 
			 global::javax.microedition.khronos.opengles.GL android.opengl.GLSurfaceView.GLWrapper.wrap(javax.microedition.khronos.opengles.GL arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<javax.microedition.khronos.opengles.GL>(@__env, @__env.CallObjectMethodPtr(this, global::android.opengl.GLSurfaceView.__GLWrapper._wrap5271, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<javax.microedition.khronos.opengles.GL>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.opengl.GLSurfaceView.__GLWrapper.staticClass, global::android.opengl.GLSurfaceView.__GLWrapper._wrap5271, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.opengl.GLSurfaceView.__GLWrapper.staticClass = @__class; 
				global::android.opengl.GLSurfaceView.__GLWrapper._wrap5271 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.__GLWrapper.staticClass, "android.opengl.GLSurfaceView.GLWrapper.wrap", "(Ljavax/microedition/khronos/opengles/GL;)Ljavax/microedition/khronos/opengles/GL;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface Renderer 
		{ 
			void onSurfaceCreated(javax.microedition.khronos.opengles.GL10 arg0, javax.microedition.khronos.egl.EGLConfig arg1); 
			void onSurfaceChanged(javax.microedition.khronos.opengles.GL10 arg0, int arg1, int arg2); 
			void onDrawFrame(javax.microedition.khronos.opengles.GL10 arg0); 
		} 

		public partial class Renderer_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __Renderer.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __Renderer : java.lang.Object, Renderer
		{ 
			internal static global::java.lang.Class staticClass; 
			static __Renderer() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.GLSurfaceView.__Renderer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.opengl.GLSurfaceView.__Renderer(@__env); 
				} 
			} 
			internal __Renderer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSurfaceCreated5272; 
			 void android.opengl.GLSurfaceView.Renderer.onSurfaceCreated(javax.microedition.khronos.opengles.GL10 arg0, javax.microedition.khronos.egl.EGLConfig arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView.__Renderer._onSurfaceCreated5272, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.__Renderer.staticClass, global::android.opengl.GLSurfaceView.__Renderer._onSurfaceCreated5272, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSurfaceChanged5273; 
			 void android.opengl.GLSurfaceView.Renderer.onSurfaceChanged(javax.microedition.khronos.opengles.GL10 arg0, int arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView.__Renderer._onSurfaceChanged5273, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.__Renderer.staticClass, global::android.opengl.GLSurfaceView.__Renderer._onSurfaceChanged5273, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDrawFrame5274; 
			 void android.opengl.GLSurfaceView.Renderer.onDrawFrame(javax.microedition.khronos.opengles.GL10 arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView.__Renderer._onDrawFrame5274, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.__Renderer.staticClass, global::android.opengl.GLSurfaceView.__Renderer._onDrawFrame5274, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.opengl.GLSurfaceView.__Renderer.staticClass = @__class; 
				global::android.opengl.GLSurfaceView.__Renderer._onSurfaceCreated5272 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.__Renderer.staticClass, "android.opengl.GLSurfaceView.Renderer.onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V"); 
				global::android.opengl.GLSurfaceView.__Renderer._onSurfaceChanged5273 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.__Renderer.staticClass, "android.opengl.GLSurfaceView.Renderer.onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V"); 
				global::android.opengl.GLSurfaceView.__Renderer._onDrawFrame5274 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.__Renderer.staticClass, "android.opengl.GLSurfaceView.Renderer.onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onResume5275; 
		public virtual void onResume() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._onResume5275); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._onResume5275); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPause5276; 
		public virtual void onPause() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._onPause5276); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._onPause5276); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow5277; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._onDetachedFromWindow5277); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._onDetachedFromWindow5277); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGLWrapper5278; 
		public virtual void setGLWrapper(android.opengl.GLSurfaceView.GLWrapper arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._setGLWrapper5278, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setGLWrapper5278, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDebugFlags5279; 
		public virtual void setDebugFlags(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._setDebugFlags5279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setDebugFlags5279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDebugFlags5280; 
		public virtual int getDebugFlags() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.opengl.GLSurfaceView._getDebugFlags5280); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._getDebugFlags5280); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRenderer5281; 
		public virtual void setRenderer(android.opengl.GLSurfaceView.Renderer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._setRenderer5281, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setRenderer5281, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEGLContextFactory5282; 
		public virtual void setEGLContextFactory(android.opengl.GLSurfaceView.EGLContextFactory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._setEGLContextFactory5282, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLContextFactory5282, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEGLWindowSurfaceFactory5283; 
		public virtual void setEGLWindowSurfaceFactory(android.opengl.GLSurfaceView.EGLWindowSurfaceFactory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._setEGLWindowSurfaceFactory5283, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLWindowSurfaceFactory5283, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEGLConfigChooser5284; 
		public virtual void setEGLConfigChooser(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._setEGLConfigChooser5284, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLConfigChooser5284, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEGLConfigChooser5285; 
		public virtual void setEGLConfigChooser(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._setEGLConfigChooser5285, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLConfigChooser5285, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEGLConfigChooser5286; 
		public virtual void setEGLConfigChooser(android.opengl.GLSurfaceView.EGLConfigChooser arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._setEGLConfigChooser5286, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setEGLConfigChooser5286, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRenderMode5287; 
		public virtual void setRenderMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._setRenderMode5287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._setRenderMode5287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRenderMode5288; 
		public virtual int getRenderMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.opengl.GLSurfaceView._getRenderMode5288); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._getRenderMode5288); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestRender5289; 
		public virtual void requestRender() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._requestRender5289); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._requestRender5289); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _surfaceCreated5290; 
		public virtual void surfaceCreated(android.view.SurfaceHolder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._surfaceCreated5290, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._surfaceCreated5290, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _surfaceDestroyed5291; 
		public virtual void surfaceDestroyed(android.view.SurfaceHolder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._surfaceDestroyed5291, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._surfaceDestroyed5291, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _surfaceChanged5292; 
		public virtual void surfaceChanged(android.view.SurfaceHolder arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._surfaceChanged5292, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._surfaceChanged5292, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _queueEvent5293; 
		public virtual void queueEvent(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.opengl.GLSurfaceView._queueEvent5293, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._queueEvent5293, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GLSurfaceView5294; 
		public GLSurfaceView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._GLSurfaceView5294, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GLSurfaceView5295; 
		public GLSurfaceView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.opengl.GLSurfaceView.staticClass, global::android.opengl.GLSurfaceView._GLSurfaceView5295, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
			global::android.opengl.GLSurfaceView._onResume5275 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "onResume", "()V"); 
			global::android.opengl.GLSurfaceView._onPause5276 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "onPause", "()V"); 
			global::android.opengl.GLSurfaceView._onDetachedFromWindow5277 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.opengl.GLSurfaceView._setGLWrapper5278 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setGLWrapper", "(Landroid/opengl/GLSurfaceView$GLWrapper;)V"); 
			global::android.opengl.GLSurfaceView._setDebugFlags5279 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setDebugFlags", "(I)V"); 
			global::android.opengl.GLSurfaceView._getDebugFlags5280 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "getDebugFlags", "()I"); 
			global::android.opengl.GLSurfaceView._setRenderer5281 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setRenderer", "(Landroid/opengl/GLSurfaceView$Renderer;)V"); 
			global::android.opengl.GLSurfaceView._setEGLContextFactory5282 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setEGLContextFactory", "(Landroid/opengl/GLSurfaceView$EGLContextFactory;)V"); 
			global::android.opengl.GLSurfaceView._setEGLWindowSurfaceFactory5283 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setEGLWindowSurfaceFactory", "(Landroid/opengl/GLSurfaceView$EGLWindowSurfaceFactory;)V"); 
			global::android.opengl.GLSurfaceView._setEGLConfigChooser5284 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setEGLConfigChooser", "(Z)V"); 
			global::android.opengl.GLSurfaceView._setEGLConfigChooser5285 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setEGLConfigChooser", "(IIIIII)V"); 
			global::android.opengl.GLSurfaceView._setEGLConfigChooser5286 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setEGLConfigChooser", "(Landroid/opengl/GLSurfaceView$EGLConfigChooser;)V"); 
			global::android.opengl.GLSurfaceView._setRenderMode5287 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "setRenderMode", "(I)V"); 
			global::android.opengl.GLSurfaceView._getRenderMode5288 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "getRenderMode", "()I"); 
			global::android.opengl.GLSurfaceView._requestRender5289 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "requestRender", "()V"); 
			global::android.opengl.GLSurfaceView._surfaceCreated5290 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V"); 
			global::android.opengl.GLSurfaceView._surfaceDestroyed5291 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V"); 
			global::android.opengl.GLSurfaceView._surfaceChanged5292 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V"); 
			global::android.opengl.GLSurfaceView._queueEvent5293 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "queueEvent", "(Ljava/lang/Runnable;)V"); 
			global::android.opengl.GLSurfaceView._GLSurfaceView5294 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.opengl.GLSurfaceView._GLSurfaceView5295 = @__env.GetMethodID(global::android.opengl.GLSurfaceView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
