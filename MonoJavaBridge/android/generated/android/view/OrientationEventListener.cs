namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.OrientationEventListener_))]
	public abstract partial class OrientationEventListener : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OrientationEventListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void enable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationEventListener.staticClass, "enable", "()V", ref global::android.view.OrientationEventListener._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void disable()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationEventListener.staticClass, "disable", "()V", ref global::android.view.OrientationEventListener._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool canDetectOrientation()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.OrientationEventListener.staticClass, "canDetectOrientation", "()Z", ref global::android.view.OrientationEventListener._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void onOrientationChanged(int arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public OrientationEventListener(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.OrientationEventListener._m4.native == global::System.IntPtr.Zero)
				global::android.view.OrientationEventListener._m4 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.OrientationEventListener.staticClass, global::android.view.OrientationEventListener._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public OrientationEventListener(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.OrientationEventListener._m5.native == global::System.IntPtr.Zero)
				global::android.view.OrientationEventListener._m5 = @__env.GetMethodIDNoThrow(global::android.view.OrientationEventListener.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.OrientationEventListener.staticClass, global::android.view.OrientationEventListener._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.OrientationEventListener))]
	internal sealed partial class OrientationEventListener_ : android.view.OrientationEventListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal OrientationEventListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void onOrientationChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.OrientationEventListener_.staticClass, "onOrientationChanged", "(I)V", ref global::android.view.OrientationEventListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static OrientationEventListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.OrientationEventListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/OrientationEventListener"));
		}
	}
}
