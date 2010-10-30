namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.graphics.drawable.Animatable_))]
	public partial interface Animatable  : global::MonoJavaBridge.IJavaObject 
	{
		void start();
		void stop();
		bool isRunning();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.Animatable))]
	internal sealed partial class Animatable_ : java.lang.Object, Animatable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Animatable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _start5834;
		void android.graphics.drawable.Animatable.start()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.Animatable_._start5834.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.Animatable_._start5834 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Animatable_.staticClass, "start", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Animatable_._start5834);
		}
		internal static global::MonoJavaBridge.MethodId _stop5835;
		void android.graphics.drawable.Animatable.stop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.Animatable_._stop5835.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.Animatable_._stop5835 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Animatable_.staticClass, "stop", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Animatable_._stop5835);
		}
		internal static global::MonoJavaBridge.MethodId _isRunning5836;
		bool android.graphics.drawable.Animatable.isRunning()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.Animatable_._isRunning5836.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.Animatable_._isRunning5836 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Animatable_.staticClass, "isRunning", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Animatable_._isRunning5836);
		}
		static Animatable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.Animatable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Animatable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
