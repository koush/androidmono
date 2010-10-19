namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class VelocityTracker : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static VelocityTracker()
		{
			InitJNI();
		}
		internal VelocityTracker(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clear9637;
		public void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._clear9637);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._clear9637);
		}
		internal static global::MonoJavaBridge.MethodId _obtain9638;
		public static global::android.view.VelocityTracker obtain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._obtain9638)) as android.view.VelocityTracker;
		}
		internal static global::MonoJavaBridge.MethodId _recycle9639;
		public void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._recycle9639);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._recycle9639);
		}
		internal static global::MonoJavaBridge.MethodId _addMovement9640;
		public void addMovement(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._addMovement9640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._addMovement9640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeCurrentVelocity9641;
		public void computeCurrentVelocity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._computeCurrentVelocity9641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._computeCurrentVelocity9641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeCurrentVelocity9642;
		public void computeCurrentVelocity(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._computeCurrentVelocity9642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._computeCurrentVelocity9642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new float XVelocity
		{
			get
			{
				return getXVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getXVelocity9643;
		public float getXVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getXVelocity9643);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getXVelocity9643);
		}
		internal static global::MonoJavaBridge.MethodId _getXVelocity9644;
		public float getXVelocity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getXVelocity9644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getXVelocity9644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float YVelocity
		{
			get
			{
				return getYVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYVelocity9645;
		public float getYVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getYVelocity9645);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getYVelocity9645);
		}
		internal static global::MonoJavaBridge.MethodId _getYVelocity9646;
		public float getYVelocity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getYVelocity9646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getYVelocity9646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.VelocityTracker.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/VelocityTracker"));
			global::android.view.VelocityTracker._clear9637 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "clear", "()V");
			global::android.view.VelocityTracker._obtain9638 = @__env.GetStaticMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "obtain", "()Landroid/view/VelocityTracker;");
			global::android.view.VelocityTracker._recycle9639 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "recycle", "()V");
			global::android.view.VelocityTracker._addMovement9640 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "addMovement", "(Landroid/view/MotionEvent;)V");
			global::android.view.VelocityTracker._computeCurrentVelocity9641 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(I)V");
			global::android.view.VelocityTracker._computeCurrentVelocity9642 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(IF)V");
			global::android.view.VelocityTracker._getXVelocity9643 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getXVelocity", "()F");
			global::android.view.VelocityTracker._getXVelocity9644 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getXVelocity", "(I)F");
			global::android.view.VelocityTracker._getYVelocity9645 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getYVelocity", "()F");
			global::android.view.VelocityTracker._getYVelocity9646 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getYVelocity", "(I)F");
		}
	}
}
