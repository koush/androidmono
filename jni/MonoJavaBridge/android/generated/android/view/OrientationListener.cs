namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.OrientationListener_))]
	public abstract partial class OrientationListener : java.lang.Object, android.hardware.SensorListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OrientationListener()
		{
			InitJNI();
		}
		protected OrientationListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _enable9518;
		public virtual void enable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.OrientationListener._enable9518);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.OrientationListener.staticClass, global::android.view.OrientationListener._enable9518);
		}
		internal static global::MonoJavaBridge.MethodId _disable9519;
		public virtual void disable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.OrientationListener._disable9519);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.OrientationListener.staticClass, global::android.view.OrientationListener._disable9519);
		}
		internal static global::MonoJavaBridge.MethodId _onSensorChanged9520;
		public virtual void onSensorChanged(int arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.OrientationListener._onSensorChanged9520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.OrientationListener.staticClass, global::android.view.OrientationListener._onSensorChanged9520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onAccuracyChanged9521;
		public virtual void onAccuracyChanged(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.OrientationListener._onAccuracyChanged9521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.OrientationListener.staticClass, global::android.view.OrientationListener._onAccuracyChanged9521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onOrientationChanged9522;
		public abstract void onOrientationChanged(int arg0);
		internal static global::MonoJavaBridge.MethodId _OrientationListener9523;
		public OrientationListener(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.OrientationListener.staticClass, global::android.view.OrientationListener._OrientationListener9523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OrientationListener9524;
		public OrientationListener(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.OrientationListener.staticClass, global::android.view.OrientationListener._OrientationListener9524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int ORIENTATION_UNKNOWN
		{
			get
			{
				return -1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.OrientationListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/OrientationListener"));
			global::android.view.OrientationListener._enable9518 = @__env.GetMethodIDNoThrow(global::android.view.OrientationListener.staticClass, "enable", "()V");
			global::android.view.OrientationListener._disable9519 = @__env.GetMethodIDNoThrow(global::android.view.OrientationListener.staticClass, "disable", "()V");
			global::android.view.OrientationListener._onSensorChanged9520 = @__env.GetMethodIDNoThrow(global::android.view.OrientationListener.staticClass, "onSensorChanged", "(I[F)V");
			global::android.view.OrientationListener._onAccuracyChanged9521 = @__env.GetMethodIDNoThrow(global::android.view.OrientationListener.staticClass, "onAccuracyChanged", "(II)V");
			global::android.view.OrientationListener._onOrientationChanged9522 = @__env.GetMethodIDNoThrow(global::android.view.OrientationListener.staticClass, "onOrientationChanged", "(I)V");
			global::android.view.OrientationListener._OrientationListener9523 = @__env.GetMethodIDNoThrow(global::android.view.OrientationListener.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.view.OrientationListener._OrientationListener9524 = @__env.GetMethodIDNoThrow(global::android.view.OrientationListener.staticClass, "<init>", "(Landroid/content/Context;I)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.OrientationListener))]
	public sealed partial class OrientationListener_ : android.view.OrientationListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OrientationListener_()
		{
			InitJNI();
		}
		internal OrientationListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onOrientationChanged9525;
		public override void onOrientationChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.OrientationListener_._onOrientationChanged9525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.OrientationListener_.staticClass, global::android.view.OrientationListener_._onOrientationChanged9525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.OrientationListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/OrientationListener"));
			global::android.view.OrientationListener_._onOrientationChanged9525 = @__env.GetMethodIDNoThrow(global::android.view.OrientationListener_.staticClass, "onOrientationChanged", "(I)V");
		}
	}
}
