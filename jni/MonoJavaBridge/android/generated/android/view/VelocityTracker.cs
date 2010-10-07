namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class VelocityTracker : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static VelocityTracker()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.VelocityTracker), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.VelocityTracker(@__env);
			}
		}
		internal VelocityTracker(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear8782;
		public void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.VelocityTracker._clear8782);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._clear8782);
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain8783;
		public static global::android.view.VelocityTracker obtain() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.VelocityTracker>(@__env, @__env.CallStaticObjectMethodPtr(android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._obtain8783));
		}
		internal static global::net.sf.jni4net.jni.MethodId _recycle8784;
		public void recycle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.VelocityTracker._recycle8784);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._recycle8784);
		}
		internal static global::net.sf.jni4net.jni.MethodId _addMovement8785;
		public void addMovement(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.VelocityTracker._addMovement8785, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._addMovement8785, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeCurrentVelocity8786;
		public void computeCurrentVelocity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.VelocityTracker._computeCurrentVelocity8786, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._computeCurrentVelocity8786, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeCurrentVelocity8787;
		public void computeCurrentVelocity(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.VelocityTracker._computeCurrentVelocity8787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._computeCurrentVelocity8787, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getXVelocity8788;
		public float getXVelocity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.VelocityTracker._getXVelocity8788);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getXVelocity8788);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getXVelocity8789;
		public float getXVelocity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.VelocityTracker._getXVelocity8789, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getXVelocity8789, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getYVelocity8790;
		public float getYVelocity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.VelocityTracker._getYVelocity8790);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getYVelocity8790);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getYVelocity8791;
		public float getYVelocity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.VelocityTracker._getYVelocity8791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getYVelocity8791, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.VelocityTracker.staticClass = @__class;
			global::android.view.VelocityTracker._clear8782 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "clear", "()V");
			global::android.view.VelocityTracker._obtain8783 = @__env.GetStaticMethodID(global::android.view.VelocityTracker.staticClass, "obtain", "()Landroid/view/VelocityTracker;");
			global::android.view.VelocityTracker._recycle8784 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "recycle", "()V");
			global::android.view.VelocityTracker._addMovement8785 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "addMovement", "(Landroid/view/MotionEvent;)V");
			global::android.view.VelocityTracker._computeCurrentVelocity8786 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(I)V");
			global::android.view.VelocityTracker._computeCurrentVelocity8787 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(IF)V");
			global::android.view.VelocityTracker._getXVelocity8788 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "getXVelocity", "()F");
			global::android.view.VelocityTracker._getXVelocity8789 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "getXVelocity", "(I)F");
			global::android.view.VelocityTracker._getYVelocity8790 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "getYVelocity", "()F");
			global::android.view.VelocityTracker._getYVelocity8791 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "getYVelocity", "(I)F");
		}
	}
}
