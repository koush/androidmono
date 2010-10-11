namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.graphics.drawable.Animatable_))]
	public interface Animatable  : global::MonoJavaBridge.IJavaObject 
	{
		void start();
		void stop();
		bool isRunning();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.Animatable))]
	public sealed partial class Animatable_ : java.lang.Object, Animatable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Animatable_()
		{
			InitJNI();
		}
		internal Animatable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _start3830;
		 void android.graphics.drawable.Animatable.start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Animatable_._start3830);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Animatable_.staticClass, global::android.graphics.drawable.Animatable_._start3830);
		}
		internal static global::MonoJavaBridge.MethodId _stop3831;
		 void android.graphics.drawable.Animatable.stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Animatable_._stop3831);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Animatable_.staticClass, global::android.graphics.drawable.Animatable_._stop3831);
		}
		internal static global::MonoJavaBridge.MethodId _isRunning3832;
		 bool android.graphics.drawable.Animatable.isRunning() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Animatable_._isRunning3832);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Animatable_.staticClass, global::android.graphics.drawable.Animatable_._isRunning3832);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.Animatable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Animatable"));
			global::android.graphics.drawable.Animatable_._start3830 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Animatable_.staticClass, "start", "()V");
			global::android.graphics.drawable.Animatable_._stop3831 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Animatable_.staticClass, "stop", "()V");
			global::android.graphics.drawable.Animatable_._isRunning3832 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Animatable_.staticClass, "isRunning", "()Z");
		}
	}
}
