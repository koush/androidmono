namespace javax.microedition.khronos.egl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.microedition.khronos.egl.EGLContext_))]
	public abstract partial class EGLContext : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EGLContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getGL28952;
		public abstract global::javax.microedition.khronos.opengles.GL getGL();
		internal static global::MonoJavaBridge.MethodId _getEGL28953;
		public static global::javax.microedition.khronos.egl.EGL getEGL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.egl.EGLContext._getEGL28953.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.egl.EGLContext._getEGL28953 = @__env.GetStaticMethodIDNoThrow(global::javax.microedition.khronos.egl.EGLContext.staticClass, "getEGL", "()Ljavax/microedition/khronos/egl/EGL;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.egl.EGL>(@__env.CallStaticObjectMethod(javax.microedition.khronos.egl.EGLContext.staticClass, global::javax.microedition.khronos.egl.EGLContext._getEGL28953)) as javax.microedition.khronos.egl.EGL;
		}
		internal static global::MonoJavaBridge.MethodId _EGLContext28954;
		public EGLContext() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.egl.EGLContext._EGLContext28954.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.egl.EGLContext._EGLContext28954 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGLContext.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.microedition.khronos.egl.EGLContext.staticClass, global::javax.microedition.khronos.egl.EGLContext._EGLContext28954);
			Init(@__env, handle);
		}
		static EGLContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLContext"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.egl.EGLContext))]
	internal sealed partial class EGLContext_ : javax.microedition.khronos.egl.EGLContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EGLContext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getGL28955;
		public override global::javax.microedition.khronos.opengles.GL getGL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.egl.EGLContext_._getGL28955.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.egl.EGLContext_._getGL28955 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGLContext_.staticClass, "getGL", "()Ljavax/microedition/khronos/opengles/GL;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.opengles.GL>(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGLContext_._getGL28955)) as javax.microedition.khronos.opengles.GL;
		}
		static EGLContext_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLContext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLContext"));
		}
		internal static void InitJNI()
		{
		}
	}
}
