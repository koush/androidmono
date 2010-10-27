namespace android.view.animation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.animation.Interpolator_))]
	public partial interface Interpolator  : global::MonoJavaBridge.IJavaObject 
	{
		float getInterpolation(float arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.animation.Interpolator))]
	internal sealed partial class Interpolator_ : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Interpolator_()
		{
			InitJNI();
		}
		internal Interpolator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation15710;
		float android.view.animation.Interpolator.getInterpolation(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.Interpolator_._getInterpolation15710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.Interpolator_.staticClass, global::android.view.animation.Interpolator_._getInterpolation15710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.Interpolator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Interpolator"));
			global::android.view.animation.Interpolator_._getInterpolation15710 = @__env.GetMethodIDNoThrow(global::android.view.animation.Interpolator_.staticClass, "getInterpolation", "(F)F");
		}
	}

	public delegate float InterpolatorDelegate(float arg0);

	internal partial class InterpolatorDelegateWrapper : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InterpolatorDelegateWrapper()
		{
			InitJNI();
		}
		protected InterpolatorDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InterpolatorDelegateWrapper15711;
		public InterpolatorDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.InterpolatorDelegateWrapper.staticClass, global::android.view.animation.InterpolatorDelegateWrapper._InterpolatorDelegateWrapper15711);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.InterpolatorDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/InterpolatorDelegateWrapper"));
			global::android.view.animation.InterpolatorDelegateWrapper._InterpolatorDelegateWrapper15711 = @__env.GetMethodIDNoThrow(global::android.view.animation.InterpolatorDelegateWrapper.staticClass, "<init>", "()V");
		}
	}
	internal partial class InterpolatorDelegateWrapper
	{
		private InterpolatorDelegate myDelegate;
		public float getInterpolation(float arg0)
		{
			return myDelegate(arg0);
		}
		public static implicit operator InterpolatorDelegateWrapper(InterpolatorDelegate d)
		{
			global::android.view.animation.InterpolatorDelegateWrapper ret = new global::android.view.animation.InterpolatorDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
