namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SweepGradient : android.graphics.Shader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SweepGradient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SweepGradient5804;
		public SweepGradient(float arg0, float arg1, int[] arg2, float[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.SweepGradient.staticClass, global::android.graphics.SweepGradient._SweepGradient5804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SweepGradient5805;
		public SweepGradient(float arg0, float arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.SweepGradient.staticClass, global::android.graphics.SweepGradient._SweepGradient5805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static SweepGradient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.SweepGradient.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/SweepGradient"));
			global::android.graphics.SweepGradient._SweepGradient5804 = @__env.GetMethodIDNoThrow(global::android.graphics.SweepGradient.staticClass, "<init>", "(FF[I[F)V");
			global::android.graphics.SweepGradient._SweepGradient5805 = @__env.GetMethodIDNoThrow(global::android.graphics.SweepGradient.staticClass, "<init>", "(FFII)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
