namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class VelocityTracker : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static VelocityTracker() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.VelocityTracker), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _clear7536; 
		public void clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.VelocityTracker)) 
				@__env.CallVoidMethod(this, _clear7536); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.VelocityTracker.staticClass, _clear7536); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain7537; 
		public static android.view.VelocityTracker obtain() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.VelocityTracker>(@__env, @__env.CallStaticObjectMethodPtr(android.view.VelocityTracker.staticClass, _obtain7537)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recycle7538; 
		public void recycle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.VelocityTracker)) 
				@__env.CallVoidMethod(this, _recycle7538); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.VelocityTracker.staticClass, _recycle7538); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addMovement7539; 
		public void addMovement(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.VelocityTracker)) 
				@__env.CallVoidMethod(this, _addMovement7539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.VelocityTracker.staticClass, _addMovement7539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeCurrentVelocity7540; 
		public void computeCurrentVelocity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.VelocityTracker)) 
				@__env.CallVoidMethod(this, _computeCurrentVelocity7540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.VelocityTracker.staticClass, _computeCurrentVelocity7540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeCurrentVelocity7541; 
		public void computeCurrentVelocity(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.VelocityTracker)) 
				@__env.CallVoidMethod(this, _computeCurrentVelocity7541, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.VelocityTracker.staticClass, _computeCurrentVelocity7541, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getXVelocity7542; 
		public float getXVelocity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.VelocityTracker)) 
				return @__env.CallFloatMethod(this, _getXVelocity7542); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.VelocityTracker.staticClass, _getXVelocity7542); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getYVelocity7543; 
		public float getYVelocity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.VelocityTracker)) 
				return @__env.CallFloatMethod(this, _getYVelocity7543); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.VelocityTracker.staticClass, _getYVelocity7543); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.VelocityTracker.staticClass = @__class; 
			global::android.view.VelocityTracker._clear7536 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "clear", "()V"); 
			global::android.view.VelocityTracker._obtain7537 = @__env.GetStaticMethodID(global::android.view.VelocityTracker.staticClass, "obtain", "()Landroid/view/VelocityTracker;"); 
			global::android.view.VelocityTracker._recycle7538 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "recycle", "()V"); 
			global::android.view.VelocityTracker._addMovement7539 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "addMovement", "(Landroid/view/MotionEvent;)V"); 
			global::android.view.VelocityTracker._computeCurrentVelocity7540 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(I)V"); 
			global::android.view.VelocityTracker._computeCurrentVelocity7541 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "computeCurrentVelocity", "(IF)V"); 
			global::android.view.VelocityTracker._getXVelocity7542 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "getXVelocity", "()F"); 
			global::android.view.VelocityTracker._getYVelocity7543 = @__env.GetMethodID(global::android.view.VelocityTracker.staticClass, "getYVelocity", "()F"); 
		} 
	} 
} 
