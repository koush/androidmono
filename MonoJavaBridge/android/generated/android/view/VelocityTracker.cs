namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class VelocityTracker : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal VelocityTracker(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clear14608;
		public void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.VelocityTracker.staticClass, "clear", "()V", ref global::android.view.VelocityTracker._clear14608);
		}
		internal static global::MonoJavaBridge.MethodId _obtain14609;
		public static global::android.view.VelocityTracker obtain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.VelocityTracker._obtain14609.native == global::System.IntPtr.Zero)
				global::android.view.VelocityTracker._obtain14609 = @__env.GetStaticMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "obtain", "()Landroid/view/VelocityTracker;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.VelocityTracker>(@__env.CallStaticObjectMethod(android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._obtain14609)) as android.view.VelocityTracker;
		}
		internal static global::MonoJavaBridge.MethodId _recycle14610;
		public void recycle()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.VelocityTracker.staticClass, "recycle", "()V", ref global::android.view.VelocityTracker._recycle14610);
		}
		internal static global::MonoJavaBridge.MethodId _addMovement14611;
		public void addMovement(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.VelocityTracker.staticClass, "addMovement", "(Landroid/view/MotionEvent;)V", ref global::android.view.VelocityTracker._addMovement14611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeCurrentVelocity14612;
		public void computeCurrentVelocity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(I)V", ref global::android.view.VelocityTracker._computeCurrentVelocity14612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeCurrentVelocity14613;
		public void computeCurrentVelocity(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(IF)V", ref global::android.view.VelocityTracker._computeCurrentVelocity14613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new float XVelocity
		{
			get
			{
				return getXVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getXVelocity14614;
		public float getXVelocity()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.VelocityTracker.staticClass, "getXVelocity", "()F", ref global::android.view.VelocityTracker._getXVelocity14614);
		}
		internal static global::MonoJavaBridge.MethodId _getXVelocity14615;
		public float getXVelocity(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.VelocityTracker.staticClass, "getXVelocity", "(I)F", ref global::android.view.VelocityTracker._getXVelocity14615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float YVelocity
		{
			get
			{
				return getYVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYVelocity14616;
		public float getYVelocity()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.VelocityTracker.staticClass, "getYVelocity", "()F", ref global::android.view.VelocityTracker._getYVelocity14616);
		}
		internal static global::MonoJavaBridge.MethodId _getYVelocity14617;
		public float getYVelocity(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.VelocityTracker.staticClass, "getYVelocity", "(I)F", ref global::android.view.VelocityTracker._getYVelocity14617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
