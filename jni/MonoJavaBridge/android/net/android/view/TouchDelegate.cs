namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TouchDelegate : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static TouchDelegate() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.TouchDelegate), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.TouchDelegate(@__env); 
			} 
		} 
		protected TouchDelegate(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent8086; 
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.TouchDelegate)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent8086, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.TouchDelegate.staticClass, _onTouchEvent8086, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TouchDelegate8087; 
		public TouchDelegate(android.graphics.Rect arg0, android.view.View arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.TouchDelegate.staticClass, _TouchDelegate8087, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		public static int ABOVE
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int BELOW
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int TO_LEFT
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int TO_RIGHT
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.TouchDelegate.staticClass = @__class; 
			global::android.view.TouchDelegate._onTouchEvent8086 = @__env.GetMethodID(global::android.view.TouchDelegate.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.TouchDelegate._TouchDelegate8087 = @__env.GetMethodID(global::android.view.TouchDelegate.staticClass, "<init>", "(Landroid/graphics/Rect;Landroid/view/View;)V"); 
		} 
	} 
} 
