namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SurfaceHolder_BadSurfaceTypeException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SurfaceHolder_BadSurfaceTypeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SurfaceHolder_BadSurfaceTypeException14565;
		public SurfaceHolder_BadSurfaceTypeException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.SurfaceHolder_BadSurfaceTypeException._SurfaceHolder_BadSurfaceTypeException14565.native == global::System.IntPtr.Zero)
				global::android.view.SurfaceHolder_BadSurfaceTypeException._SurfaceHolder_BadSurfaceTypeException14565 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_BadSurfaceTypeException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceHolder_BadSurfaceTypeException.staticClass, global::android.view.SurfaceHolder_BadSurfaceTypeException._SurfaceHolder_BadSurfaceTypeException14565);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SurfaceHolder_BadSurfaceTypeException14566;
		public SurfaceHolder_BadSurfaceTypeException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.SurfaceHolder_BadSurfaceTypeException._SurfaceHolder_BadSurfaceTypeException14566.native == global::System.IntPtr.Zero)
				global::android.view.SurfaceHolder_BadSurfaceTypeException._SurfaceHolder_BadSurfaceTypeException14566 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_BadSurfaceTypeException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceHolder_BadSurfaceTypeException.staticClass, global::android.view.SurfaceHolder_BadSurfaceTypeException._SurfaceHolder_BadSurfaceTypeException14566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SurfaceHolder_BadSurfaceTypeException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.SurfaceHolder_BadSurfaceTypeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/SurfaceHolder$BadSurfaceTypeException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
