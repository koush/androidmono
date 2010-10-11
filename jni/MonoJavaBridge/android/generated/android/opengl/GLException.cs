namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GLException()
		{
			InitJNI();
		}
		protected GLException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _GLException6056;
		public GLException(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLException.staticClass, global::android.opengl.GLException._GLException6056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GLException6057;
		public GLException(int arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLException.staticClass, global::android.opengl.GLException._GLException6057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLException"));
			global::android.opengl.GLException._GLException6056 = @__env.GetMethodIDNoThrow(global::android.opengl.GLException.staticClass, "<init>", "(I)V");
			global::android.opengl.GLException._GLException6057 = @__env.GetMethodIDNoThrow(global::android.opengl.GLException.staticClass, "<init>", "(ILjava/lang/String;)V");
		}
	}
}
