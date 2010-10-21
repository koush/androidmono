namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SurfaceHolder_BadSurfaceTypeException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SurfaceHolder_BadSurfaceTypeException()
		{
			InitJNI();
		}
		protected SurfaceHolder_BadSurfaceTypeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SurfaceHolder_BadSurfaceTypeException14497;
		public SurfaceHolder_BadSurfaceTypeException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceHolder_BadSurfaceTypeException.staticClass, global::android.view.SurfaceHolder_BadSurfaceTypeException._SurfaceHolder_BadSurfaceTypeException14497);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SurfaceHolder_BadSurfaceTypeException14498;
		public SurfaceHolder_BadSurfaceTypeException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceHolder_BadSurfaceTypeException.staticClass, global::android.view.SurfaceHolder_BadSurfaceTypeException._SurfaceHolder_BadSurfaceTypeException14498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.SurfaceHolder_BadSurfaceTypeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/SurfaceHolder_BadSurfaceTypeException"));
			global::android.view.SurfaceHolder_BadSurfaceTypeException._SurfaceHolder_BadSurfaceTypeException14497 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_BadSurfaceTypeException.staticClass, "<init>", "()V");
			global::android.view.SurfaceHolder_BadSurfaceTypeException._SurfaceHolder_BadSurfaceTypeException14498 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceHolder_BadSurfaceTypeException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
