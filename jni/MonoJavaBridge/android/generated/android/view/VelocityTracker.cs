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
		internal static global::MonoJavaBridge.MethodId _clear14608;
		public void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._clear14608);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._clear14608);
		}
		internal static global::MonoJavaBridge.MethodId _obtain14609;
		public static global::android.view.VelocityTracker obtain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.view.VelocityTracker>(@__env.CallStaticObjectMethod(android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._obtain14609)) as android.view.VelocityTracker;
		}
		internal static global::MonoJavaBridge.MethodId _recycle14610;
		public void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._recycle14610);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._recycle14610);
		}
		internal static global::MonoJavaBridge.MethodId _addMovement14611;
		public void addMovement(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._addMovement14611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._addMovement14611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeCurrentVelocity14612;
		public void computeCurrentVelocity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._computeCurrentVelocity14612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._computeCurrentVelocity14612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeCurrentVelocity14613;
		public void computeCurrentVelocity(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._computeCurrentVelocity14613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._computeCurrentVelocity14613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getXVelocity14614);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getXVelocity14614);
		}
		internal static global::MonoJavaBridge.MethodId _getXVelocity14615;
		public float getXVelocity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getXVelocity14615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getXVelocity14615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getYVelocity14616);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getYVelocity14616);
		}
		internal static global::MonoJavaBridge.MethodId _getYVelocity14617;
		public float getYVelocity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getYVelocity14617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getYVelocity14617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.VelocityTracker.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/VelocityTracker"));
			global::android.view.VelocityTracker._clear14608 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "clear", "()V");
			global::android.view.VelocityTracker._obtain14609 = @__env.GetStaticMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "obtain", "()Landroid/view/VelocityTracker;");
			global::android.view.VelocityTracker._recycle14610 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "recycle", "()V");
			global::android.view.VelocityTracker._addMovement14611 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "addMovement", "(Landroid/view/MotionEvent;)V");
			global::android.view.VelocityTracker._computeCurrentVelocity14612 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(I)V");
			global::android.view.VelocityTracker._computeCurrentVelocity14613 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(IF)V");
			global::android.view.VelocityTracker._getXVelocity14614 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getXVelocity", "()F");
			global::android.view.VelocityTracker._getXVelocity14615 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getXVelocity", "(I)F");
			global::android.view.VelocityTracker._getYVelocity14616 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getYVelocity", "()F");
			global::android.view.VelocityTracker._getYVelocity14617 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getYVelocity", "(I)F");
		}
	}
}
