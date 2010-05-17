namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class OrientationListener : java.lang.Object, android.hardware.SensorListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static OrientationListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.OrientationListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected OrientationListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enable7484; 
		public virtual void enable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.OrientationListener)) 
				@__env.CallVoidMethod(this, _enable7484); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.OrientationListener.staticClass, _enable7484); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _disable7485; 
		public virtual void disable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.OrientationListener)) 
				@__env.CallVoidMethod(this, _disable7485); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.OrientationListener.staticClass, _disable7485); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSensorChanged7486; 
		public virtual void onSensorChanged(int arg0, float[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.OrientationListener)) 
				@__env.CallVoidMethod(this, _onSensorChanged7486, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.OrientationListener.staticClass, _onSensorChanged7486, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAccuracyChanged7487; 
		public virtual void onAccuracyChanged(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.OrientationListener)) 
				@__env.CallVoidMethod(this, _onAccuracyChanged7487, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.OrientationListener.staticClass, _onAccuracyChanged7487, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onOrientationChanged7488; 
		public abstract void onOrientationChanged(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _OrientationListener7489; 
		public OrientationListener(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.OrientationListener.staticClass, _OrientationListener7489, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OrientationListener7490; 
		public OrientationListener(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.OrientationListener.staticClass, _OrientationListener7490, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
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
			global::android.view.OrientationListener._enable7484 = @__env.GetMethodID(global::android.view.OrientationListener.staticClass, "enable", "()V"); 
			global::android.view.OrientationListener._disable7485 = @__env.GetMethodID(global::android.view.OrientationListener.staticClass, "disable", "()V"); 
			global::android.view.OrientationListener._onSensorChanged7486 = @__env.GetMethodID(global::android.view.OrientationListener.staticClass, "onSensorChanged", "(I[F)V"); 
			global::android.view.OrientationListener._onAccuracyChanged7487 = @__env.GetMethodID(global::android.view.OrientationListener.staticClass, "onAccuracyChanged", "(II)V"); 
			global::android.view.OrientationListener._onOrientationChanged7488 = @__env.GetMethodID(global::android.view.OrientationListener.staticClass, "onOrientationChanged", "(I)V"); 
			global::android.view.OrientationListener._OrientationListener7489 = @__env.GetMethodID(global::android.view.OrientationListener.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.view.OrientationListener._OrientationListener7490 = @__env.GetMethodID(global::android.view.OrientationListener.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
		} 
	} 
} 
