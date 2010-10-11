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
		internal static global::MonoJavaBridge.MethodId _clear9091;
		public void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._clear9091);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._clear9091);
		}
		internal static global::MonoJavaBridge.MethodId _obtain9092;
		public static global::android.view.VelocityTracker obtain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._obtain9092)) as android.view.VelocityTracker;
		}
		internal static global::MonoJavaBridge.MethodId _recycle9093;
		public void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._recycle9093);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._recycle9093);
		}
		internal static global::MonoJavaBridge.MethodId _addMovement9094;
		public void addMovement(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._addMovement9094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._addMovement9094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeCurrentVelocity9095;
		public void computeCurrentVelocity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._computeCurrentVelocity9095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._computeCurrentVelocity9095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeCurrentVelocity9096;
		public void computeCurrentVelocity(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.VelocityTracker._computeCurrentVelocity9096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._computeCurrentVelocity9096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getXVelocity9097;
		public float getXVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getXVelocity9097);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getXVelocity9097);
		}
		internal static global::MonoJavaBridge.MethodId _getXVelocity9098;
		public float getXVelocity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getXVelocity9098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getXVelocity9098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getYVelocity9099;
		public float getYVelocity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getYVelocity9099);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getYVelocity9099);
		}
		internal static global::MonoJavaBridge.MethodId _getYVelocity9100;
		public float getYVelocity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.VelocityTracker._getYVelocity9100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getYVelocity9100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.VelocityTracker.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/VelocityTracker"));
			global::android.view.VelocityTracker._clear9091 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "clear", "()V");
			global::android.view.VelocityTracker._obtain9092 = @__env.GetStaticMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "obtain", "()Landroid/view/VelocityTracker;");
			global::android.view.VelocityTracker._recycle9093 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "recycle", "()V");
			global::android.view.VelocityTracker._addMovement9094 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "addMovement", "(Landroid/view/MotionEvent;)V");
			global::android.view.VelocityTracker._computeCurrentVelocity9095 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(I)V");
			global::android.view.VelocityTracker._computeCurrentVelocity9096 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(IF)V");
			global::android.view.VelocityTracker._getXVelocity9097 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getXVelocity", "()F");
			global::android.view.VelocityTracker._getXVelocity9098 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getXVelocity", "(I)F");
			global::android.view.VelocityTracker._getYVelocity9099 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getYVelocity", "()F");
			global::android.view.VelocityTracker._getYVelocity9100 = @__env.GetMethodIDNoThrow(global::android.view.VelocityTracker.staticClass, "getYVelocity", "(I)F");
		}
	}
}
