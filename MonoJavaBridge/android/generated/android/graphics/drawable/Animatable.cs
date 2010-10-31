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
		private static global::MonoJavaBridge.MethodId _m0;
		void android.graphics.drawable.Animatable.start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Animatable_.staticClass, "start", "()V", ref global::android.graphics.drawable.Animatable_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.graphics.drawable.Animatable.stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Animatable_.staticClass, "stop", "()V", ref global::android.graphics.drawable.Animatable_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool android.graphics.drawable.Animatable.isRunning()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Animatable_.staticClass, "isRunning", "()Z", ref global::android.graphics.drawable.Animatable_._m2);
		}
		static Animatable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.Animatable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Animatable"));
		}
	}
}
