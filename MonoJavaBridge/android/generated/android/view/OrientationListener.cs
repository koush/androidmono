namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.OrientationListener_))]
	public abstract partial class OrientationListener : java.lang.Object, android.hardware.SensorListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OrientationListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _enable14456;
		public virtual void enable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationListener.staticClass, "enable", "()V", ref global::android.view.OrientationListener._enable14456);
		}
		internal static global::MonoJavaBridge.MethodId _disable14457;
		public virtual void disable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationListener.staticClass, "disable", "()V", ref global::android.view.OrientationListener._disable14457);
		}
		internal static global::MonoJavaBridge.MethodId _onSensorChanged14458;
		public virtual void onSensorChanged(int arg0, float[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationListener.staticClass, "onSensorChanged", "(I[F)V", ref global::android.view.OrientationListener._onSensorChanged14458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onAccuracyChanged14459;
		public virtual void onAccuracyChanged(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationListener.staticClass, "onAccuracyChanged", "(II)V", ref global::android.view.OrientationListener._onAccuracyChanged14459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onOrientationChanged14460;
		public abstract void onOrientationChanged(int arg0);
		internal static global::MonoJavaBridge.MethodId _OrientationListener14461;
		public OrientationListener(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.OrientationListener._OrientationListener14461.native == global::System.IntPtr.Zero)
				global::android.view.OrientationListener._OrientationListener14461 = @__env.GetMethodIDNoThrow(global::android.view.OrientationListener.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.OrientationListener.staticClass, global::android.view.OrientationListener._OrientationListener14461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OrientationListener14462;
		public OrientationListener(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.OrientationListener._OrientationListener14462.native == global::System.IntPtr.Zero)
				global::android.view.OrientationListener._OrientationListener14462 = @__env.GetMethodIDNoThrow(global::android.view.OrientationListener.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.OrientationListener.staticClass, global::android.view.OrientationListener._OrientationListener14462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int ORIENTATION_UNKNOWN
		{
			get
			{
				return -1;
			}
		}
		static OrientationListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.OrientationListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/OrientationListener"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.OrientationListener))]
	internal sealed partial class OrientationListener_ : android.view.OrientationListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal OrientationListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onOrientationChanged14464;
		public override void onOrientationChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationListener_.staticClass, "onOrientationChanged", "(I)V", ref global::android.view.OrientationListener_._onOrientationChanged14464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static OrientationListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.OrientationListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/OrientationListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}
