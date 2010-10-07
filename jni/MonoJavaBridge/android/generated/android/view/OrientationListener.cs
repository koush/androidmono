namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class OrientationListener : java.lang.Object, android.hardware.SensorListener
	{
		internal static global::java.lang.Class staticClass;
		static OrientationListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.OrientationListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected OrientationListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _enable8665;
		public virtual void enable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.OrientationListener._enable8665);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.OrientationListener.staticClass, global::android.view.OrientationListener._enable8665);
		}
		internal static global::net.sf.jni4net.jni.MethodId _disable8666;
		public virtual void disable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.OrientationListener._disable8666);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.OrientationListener.staticClass, global::android.view.OrientationListener._disable8666);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSensorChanged8667;
		public virtual void onSensorChanged(int arg0, float[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.OrientationListener._onSensorChanged8667, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.OrientationListener.staticClass, global::android.view.OrientationListener._onSensorChanged8667, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAccuracyChanged8668;
		public virtual void onAccuracyChanged(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.OrientationListener._onAccuracyChanged8668, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.OrientationListener.staticClass, global::android.view.OrientationListener._onAccuracyChanged8668, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onOrientationChanged8669;
		public abstract void onOrientationChanged(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _OrientationListener8670;
		public OrientationListener(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.OrientationListener.staticClass, global::android.view.OrientationListener._OrientationListener8670, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _OrientationListener8671;
		public OrientationListener(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.OrientationListener.staticClass, global::android.view.OrientationListener._OrientationListener8671, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		public static int ORIENTATION_UNKNOWN
		{
			get
			{
				return -1;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.OrientationListener.staticClass = @__class;
			global::android.view.OrientationListener._enable8665 = @__env.GetMethodID(global::android.view.OrientationListener.staticClass, "enable", "()V");
			global::android.view.OrientationListener._disable8666 = @__env.GetMethodID(global::android.view.OrientationListener.staticClass, "disable", "()V");
			global::android.view.OrientationListener._onSensorChanged8667 = @__env.GetMethodID(global::android.view.OrientationListener.staticClass, "onSensorChanged", "(I[F)V");
			global::android.view.OrientationListener._onAccuracyChanged8668 = @__env.GetMethodID(global::android.view.OrientationListener.staticClass, "onAccuracyChanged", "(II)V");
			global::android.view.OrientationListener._onOrientationChanged8669 = @__env.GetMethodID(global::android.view.OrientationListener.staticClass, "onOrientationChanged", "(I)V");
			global::android.view.OrientationListener._OrientationListener8670 = @__env.GetMethodID(global::android.view.OrientationListener.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.view.OrientationListener._OrientationListener8671 = @__env.GetMethodID(global::android.view.OrientationListener.staticClass, "<init>", "(Landroid/content/Context;I)V");
		}
	}
}
