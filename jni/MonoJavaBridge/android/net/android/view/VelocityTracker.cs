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
		internal static global::net.sf.jni4net.jni.MethodId _clear8088; 
		public void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.VelocityTracker._clear8088); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._clear8088); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain8089; 
		public static global::android.view.VelocityTracker obtain() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.VelocityTracker>(@__env, @__env.CallStaticObjectMethodPtr(android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._obtain8089)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recycle8090; 
		public void recycle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.VelocityTracker._recycle8090); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._recycle8090); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addMovement8091; 
		public void addMovement(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.VelocityTracker._addMovement8091, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._addMovement8091, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeCurrentVelocity8092; 
		public void computeCurrentVelocity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.VelocityTracker._computeCurrentVelocity8092, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._computeCurrentVelocity8092, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeCurrentVelocity8093; 
		public void computeCurrentVelocity(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.VelocityTracker._computeCurrentVelocity8093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._computeCurrentVelocity8093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getXVelocity8094; 
		public float getXVelocity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.view.VelocityTracker._getXVelocity8094); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getXVelocity8094); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getYVelocity8095; 
		public float getYVelocity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.view.VelocityTracker._getYVelocity8095); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.VelocityTracker.staticClass, global::android.view.VelocityTracker._getYVelocity8095); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.VelocityTracker.staticClass = @__class; 
			global::android.view.VelocityTracker._clear8088 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "clear", "()V"); 
			global::android.view.VelocityTracker._obtain8089 = @__env.GetStaticMethodID(global::android.view.VelocityTracker.staticClass, "obtain", "()Landroid/view/VelocityTracker;"); 
			global::android.view.VelocityTracker._recycle8090 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "recycle", "()V"); 
			global::android.view.VelocityTracker._addMovement8091 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "addMovement", "(Landroid/view/MotionEvent;)V"); 
			global::android.view.VelocityTracker._computeCurrentVelocity8092 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(I)V"); 
			global::android.view.VelocityTracker._computeCurrentVelocity8093 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(IF)V"); 
			global::android.view.VelocityTracker._getXVelocity8094 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "getXVelocity", "()F"); 
			global::android.view.VelocityTracker._getYVelocity8095 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "getYVelocity", "()F"); 
		} 
	} 
} 
