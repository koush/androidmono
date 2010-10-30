namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.OrientationEventListener_))]
	public abstract partial class OrientationEventListener : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OrientationEventListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _enable14448;
		public virtual void enable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationEventListener.staticClass, "enable", "()V", ref global::android.view.OrientationEventListener._enable14448);
		}
		internal static global::MonoJavaBridge.MethodId _disable14449;
		public virtual void disable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationEventListener.staticClass, "disable", "()V", ref global::android.view.OrientationEventListener._disable14449);
		}
		internal static global::MonoJavaBridge.MethodId _canDetectOrientation14450;
		public virtual bool canDetectOrientation()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.OrientationEventListener.staticClass, "canDetectOrientation", "()Z", ref global::android.view.OrientationEventListener._canDetectOrientation14450);
		}
		internal static global::MonoJavaBridge.MethodId _onOrientationChanged14451;
		public abstract void onOrientationChanged(int arg0);
		internal static global::MonoJavaBridge.MethodId _OrientationEventListener14452;
		public OrientationEventListener(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.OrientationEventListener._OrientationEventListener14452.native == global::System.IntPtr.Zero)
				global::android.view.OrientationEventListener._OrientationEventListener14452 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.OrientationEventListener.staticClass, global::android.view.OrientationEventListener._OrientationEventListener14452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OrientationEventListener14453;
		public OrientationEventListener(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.OrientationEventListener._OrientationEventListener14453.native == global::System.IntPtr.Zero)
				global::android.view.OrientationEventListener._OrientationEventListener14453 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.OrientationEventListener.staticClass, global::android.view.OrientationEventListener._OrientationEventListener14453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int ORIENTATION_UNKNOWN
		{
			get
			{
				return -1;
			}
		}
		static OrientationEventListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.OrientationEventListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/OrientationEventListener"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.OrientationEventListener))]
	internal sealed partial class OrientationEventListener_ : android.view.OrientationEventListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal OrientationEventListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onOrientationChanged14455;
		public override void onOrientationChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationEventListener_.staticClass, "onOrientationChanged", "(I)V", ref global::android.view.OrientationEventListener_._onOrientationChanged14455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static OrientationEventListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.OrientationEventListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/OrientationEventListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}
