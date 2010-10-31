namespace javax.microedition.khronos.egl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.microedition.khronos.egl.EGLContext_))]
	public abstract partial class EGLContext : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EGLContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::javax.microedition.khronos.opengles.GL getGL();
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::javax.microedition.khronos.egl.EGL getEGL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.egl.EGLContext._m1.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.egl.EGLContext._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.microedition.khronos.egl.EGLContext.staticClass, "getEGL", "()Ljavax/microedition/khronos/egl/EGL;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.egl.EGL>(@__env.CallStaticObjectMethod(javax.microedition.khronos.egl.EGLContext.staticClass, global::javax.microedition.khronos.egl.EGLContext._m1)) as javax.microedition.khronos.egl.EGL;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public EGLContext() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.microedition.khronos.egl.EGLContext._m2.native == global::System.IntPtr.Zero)
				global::javax.microedition.khronos.egl.EGLContext._m2 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGLContext.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.microedition.khronos.egl.EGLContext.staticClass, global::javax.microedition.khronos.egl.EGLContext._m2);
			Init(@__env, handle);
		}
		static EGLContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLContext"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.egl.EGLContext))]
	internal sealed partial class EGLContext_ : javax.microedition.khronos.egl.EGLContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EGLContext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::javax.microedition.khronos.opengles.GL getGL()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.microedition.khronos.opengles.GL>(this, global::javax.microedition.khronos.egl.EGLContext_.staticClass, "getGL", "()Ljavax/microedition/khronos/opengles/GL;", ref global::javax.microedition.khronos.egl.EGLContext_._m0) as javax.microedition.khronos.opengles.GL;
		}
		static EGLContext_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGLContext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGLContext"));
		}
	}
}
