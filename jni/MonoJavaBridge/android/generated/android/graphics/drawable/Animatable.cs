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
		internal static global::MonoJavaBridge.MethodId _start5815;
		 void android.graphics.drawable.Animatable.start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Animatable_._start5815);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Animatable_.staticClass, global::android.graphics.drawable.Animatable_._start5815);
		}
		internal static global::MonoJavaBridge.MethodId _stop5816;
		 void android.graphics.drawable.Animatable.stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Animatable_._stop5816);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.Animatable_.staticClass, global::android.graphics.drawable.Animatable_._stop5816);
		}
		internal static global::MonoJavaBridge.MethodId _isRunning5817;
		 bool android.graphics.drawable.Animatable.isRunning() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Animatable_._isRunning5817);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.Animatable_.staticClass, global::android.graphics.drawable.Animatable_._isRunning5817);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.Animatable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Animatable"));
			global::android.graphics.drawable.Animatable_._start5815 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Animatable_.staticClass, "start", "()V");
			global::android.graphics.drawable.Animatable_._stop5816 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Animatable_.staticClass, "stop", "()V");
			global::android.graphics.drawable.Animatable_._isRunning5817 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Animatable_.staticClass, "isRunning", "()Z");
		}
	}
}
