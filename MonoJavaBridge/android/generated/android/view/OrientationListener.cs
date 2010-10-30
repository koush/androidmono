namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.OrientationListener_))]
	public abstract partial class OrientationListener : java.lang.Object, android.hardware.SensorListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OrientationListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void enable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationListener.staticClass, "enable", "()V", ref global::android.view.OrientationListener._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void disable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationListener.staticClass, "disable", "()V", ref global::android.view.OrientationListener._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void onSensorChanged(int arg0, float[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationListener.staticClass, "onSensorChanged", "(I[F)V", ref global::android.view.OrientationListener._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void onAccuracyChanged(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationListener.staticClass, "onAccuracyChanged", "(II)V", ref global::android.view.OrientationListener._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract void onOrientationChanged(int arg0);
		private static global::MonoJavaBridge.MethodId _m5;
		public OrientationListener(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.OrientationListener._m5.native == global::System.IntPtr.Zero)
				global::android.view.OrientationListener._m5 = @__env.GetMethodIDNoThrow(global::android.view.OrientationListener.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.OrientationListener.staticClass, global::android.view.OrientationListener._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public OrientationListener(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.OrientationListener._m6.native == global::System.IntPtr.Zero)
				global::android.view.OrientationListener._m6 = @__env.GetMethodIDNoThrow(global::android.view.OrientationListener.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.OrientationListener.staticClass, global::android.view.OrientationListener._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override void onOrientationChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationListener_.staticClass, "onOrientationChanged", "(I)V", ref global::android.view.OrientationListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
