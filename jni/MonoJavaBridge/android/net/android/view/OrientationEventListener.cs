namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class OrientationEventListener : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static OrientationEventListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.OrientationEventListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected OrientationEventListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enable7478; 
		public virtual void enable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.OrientationEventListener)) 
				@__env.CallVoidMethod(this, _enable7478); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.OrientationEventListener.staticClass, _enable7478); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _disable7479; 
		public virtual void disable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.OrientationEventListener)) 
				@__env.CallVoidMethod(this, _disable7479); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.OrientationEventListener.staticClass, _disable7479); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canDetectOrientation7480; 
		public virtual bool canDetectOrientation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.OrientationEventListener)) 
				return @__env.CallBooleanMethod(this, _canDetectOrientation7480); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.OrientationEventListener.staticClass, _canDetectOrientation7480); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onOrientationChanged7481; 
		public abstract void onOrientationChanged(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _OrientationEventListener7482; 
		public OrientationEventListener(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.OrientationEventListener.staticClass, _OrientationEventListener7482, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _OrientationEventListener7483; 
		public OrientationEventListener(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.OrientationEventListener.staticClass, _OrientationEventListener7483, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
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
			global::android.view.OrientationEventListener.staticClass = @__class; 
			global::android.view.OrientationEventListener._enable7478 = @__env.GetMethodID(global::android.view.OrientationEventListener.staticClass, "enable", "()V"); 
			global::android.view.OrientationEventListener._disable7479 = @__env.GetMethodID(global::android.view.OrientationEventListener.staticClass, "disable", "()V"); 
			global::android.view.OrientationEventListener._canDetectOrientation7480 = @__env.GetMethodID(global::android.view.OrientationEventListener.staticClass, "canDetectOrientation", "()Z"); 
			global::android.view.OrientationEventListener._onOrientationChanged7481 = @__env.GetMethodID(global::android.view.OrientationEventListener.staticClass, "onOrientationChanged", "(I)V"); 
			global::android.view.OrientationEventListener._OrientationEventListener7482 = @__env.GetMethodID(global::android.view.OrientationEventListener.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.view.OrientationEventListener._OrientationEventListener7483 = @__env.GetMethodID(global::android.view.OrientationEventListener.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
		} 
	} 
} 
