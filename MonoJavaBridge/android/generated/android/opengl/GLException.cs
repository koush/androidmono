namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GLException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _GLException9419;
		public GLException(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLException._GLException9419.native == global::System.IntPtr.Zero)
				global::android.opengl.GLException._GLException9419 = @__env.GetMethodIDNoThrow(global::android.opengl.GLException.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLException.staticClass, global::android.opengl.GLException._GLException9419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GLException9420;
		public GLException(int arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLException._GLException9420.native == global::System.IntPtr.Zero)
				global::android.opengl.GLException._GLException9420 = @__env.GetMethodIDNoThrow(global::android.opengl.GLException.staticClass, "<init>", "(ILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLException.staticClass, global::android.opengl.GLException._GLException9420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static GLException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
