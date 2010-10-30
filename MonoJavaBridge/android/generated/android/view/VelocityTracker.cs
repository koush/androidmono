namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class VelocityTracker : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal VelocityTracker(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.VelocityTracker.staticClass, "clear", "()V", ref global::android.view.VelocityTracker._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.view.VelocityTracker obtain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.VelocityTracker._m1.native == global::System.IntPtr.Zero)
				global::android.view.VelocityTracker._m1 = @__env.GetStaticMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "obtain", "()Landroid/view/VelocityTracker;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.VelocityTracker>(@__env.CallStaticObjectMethod(android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._m1)) as android.view.VelocityTracker;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void recycle()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.VelocityTracker.staticClass, "recycle", "()V", ref global::android.view.VelocityTracker._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void addMovement(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.VelocityTracker.staticClass, "addMovement", "(Landroid/view/MotionEvent;)V", ref global::android.view.VelocityTracker._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void computeCurrentVelocity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(I)V", ref global::android.view.VelocityTracker._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void computeCurrentVelocity(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(IF)V", ref global::android.view.VelocityTracker._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new float XVelocity
		{
			get
			{
				return getXVelocity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public float getXVelocity()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.VelocityTracker.staticClass, "getXVelocity", "()F", ref global::android.view.VelocityTracker._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public float getXVelocity(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.VelocityTracker.staticClass, "getXVelocity", "(I)F", ref global::android.view.VelocityTracker._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float YVelocity
		{
			get
			{
				return getYVelocity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public float getYVelocity()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.VelocityTracker.staticClass, "getYVelocity", "()F", ref global::android.view.VelocityTracker._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public float getYVelocity(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.VelocityTracker.staticClass, "getYVelocity", "(I)F", ref global::android.view.VelocityTracker._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static VelocityTracker()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.VelocityTracker.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/VelocityTracker"));
		}
		internal static void InitJNI()
		{
		}
	}
}
