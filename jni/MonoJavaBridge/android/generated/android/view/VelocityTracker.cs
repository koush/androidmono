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
		internal static global::MonoJavaBridge.MethodId _clear14540;
		public void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._clear14540);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._clear14540);
		}
		internal static global::MonoJavaBridge.MethodId _obtain14541;
		public static global::android.view.VelocityTracker obtain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._obtain14541)) as android.view.VelocityTracker;
		}
		internal static global::MonoJavaBridge.MethodId _recycle14542;
		public void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._recycle14542);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._recycle14542);
		}
		internal static global::MonoJavaBridge.MethodId _addMovement14543;
		public void addMovement(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._addMovement14543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._addMovement14543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeCurrentVelocity14544;
		public void computeCurrentVelocity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._computeCurrentVelocity14544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._computeCurrentVelocity14544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeCurrentVelocity14545;
		public void computeCurrentVelocity(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._computeCurrentVelocity14545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._computeCurrentVelocity14545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new float XVelocity
		{
			get
			{
				return getXVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getXVelocity14546;
		public float getXVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getXVelocity14546);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getXVelocity14546);
		}
		internal static global::MonoJavaBridge.MethodId _getXVelocity14547;
		public float getXVelocity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getXVelocity14547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getXVelocity14547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float YVelocity
		{
			get
			{
				return getYVelocity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYVelocity14548;
		public float getYVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getYVelocity14548);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getYVelocity14548);
		}
		internal static global::MonoJavaBridge.MethodId _getYVelocity14549;
		public float getYVelocity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getYVelocity14549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getYVelocity14549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.VelocityTracker.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/VelocityTracker"));
			global::android.view.VelocityTracker._clear14540 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "clear", "()V");
			global::android.view.VelocityTracker._obtain14541 = @__env.GetStaticMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "obtain", "()Landroid/view/VelocityTracker;");
			global::android.view.VelocityTracker._recycle14542 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "recycle", "()V");
			global::android.view.VelocityTracker._addMovement14543 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "addMovement", "(Landroid/view/MotionEvent;)V");
			global::android.view.VelocityTracker._computeCurrentVelocity14544 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(I)V");
			global::android.view.VelocityTracker._computeCurrentVelocity14545 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(IF)V");
			global::android.view.VelocityTracker._getXVelocity14546 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getXVelocity", "()F");
			global::android.view.VelocityTracker._getXVelocity14547 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getXVelocity", "(I)F");
			global::android.view.VelocityTracker._getYVelocity14548 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getYVelocity", "()F");
			global::android.view.VelocityTracker._getYVelocity14549 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getYVelocity", "(I)F");
		}
	}
}
