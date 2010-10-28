namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PorterDuffColorFilter : android.graphics.ColorFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PorterDuffColorFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _PorterDuffColorFilter5662;
		public PorterDuffColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PorterDuffColorFilter.staticClass, global::android.graphics.PorterDuffColorFilter._PorterDuffColorFilter5662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static PorterDuffColorFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PorterDuffColorFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PorterDuffColorFilter"));
			global::android.graphics.PorterDuffColorFilter._PorterDuffColorFilter5662 = @__env.GetMethodIDNoThrow(global::android.graphics.PorterDuffColorFilter.staticClass, "<init>", "(ILandroid/graphics/PorterDuff$Mode;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
