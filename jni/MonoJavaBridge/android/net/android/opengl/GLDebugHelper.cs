namespace android.opengl 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GLDebugHelper : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GLDebugHelper() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.opengl.GLDebugHelper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.opengl.GLDebugHelper(@__env); 
			} 
		} 
		protected GLDebugHelper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wrap4694; 
		public static javax.microedition.khronos.opengles.GL wrap(javax.microedition.khronos.opengles.GL arg0, int arg1, java.io.Writer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<javax.microedition.khronos.opengles.GL>(@__env, @__env.CallStaticObjectMethodPtr(android.opengl.GLDebugHelper.staticClass, _wrap4694, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wrap4695; 
		public static javax.microedition.khronos.egl.EGL wrap(javax.microedition.khronos.egl.EGL arg0, int arg1, java.io.Writer arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<javax.microedition.khronos.egl.EGL>(@__env, @__env.CallStaticObjectMethodPtr(android.opengl.GLDebugHelper.staticClass, _wrap4695, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GLDebugHelper4696; 
		public GLDebugHelper()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.opengl.GLDebugHelper.staticClass, _GLDebugHelper4696, this); 
		} 
		public static int CONFIG_CHECK_GL_ERROR
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int CONFIG_CHECK_THREAD
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int CONFIG_LOG_ARGUMENT_NAMES
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int ERROR_WRONG_THREAD
		{ 
			get 
			{ 
				return 28672; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.opengl.GLDebugHelper.staticClass = @__class; 
			global::android.opengl.GLDebugHelper._wrap4694 = @__env.GetStaticMethodID(global::android.opengl.GLDebugHelper.staticClass, "wrap", "(Ljavax/microedition/khronos/opengles/GL;ILjava/io/Writer;)Ljavax/microedition/khronos/opengles/GL;"); 
			global::android.opengl.GLDebugHelper._wrap4695 = @__env.GetStaticMethodID(global::android.opengl.GLDebugHelper.staticClass, "wrap", "(Ljavax/microedition/khronos/egl/EGL;ILjava/io/Writer;)Ljavax/microedition/khronos/egl/EGL;"); 
			global::android.opengl.GLDebugHelper._GLDebugHelper4696 = @__env.GetMethodID(global::android.opengl.GLDebugHelper.staticClass, "<init>", "()V"); 
		} 
	} 
} 
