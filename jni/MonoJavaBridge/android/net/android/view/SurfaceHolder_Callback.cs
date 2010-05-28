namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SurfaceHolder_Callback 
	{ 
		void surfaceCreated(android.view.SurfaceHolder arg0); 
		void surfaceDestroyed(android.view.SurfaceHolder arg0); 
		void surfaceChanged(android.view.SurfaceHolder arg0, int arg1, int arg2, int arg3); 
	} 

	public partial class SurfaceHolder_Callback_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __SurfaceHolder_Callback.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __SurfaceHolder_Callback : java.lang.Object, SurfaceHolder_Callback
	{ 
		internal static global::java.lang.Class staticClass; 
		static __SurfaceHolder_Callback() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.__SurfaceHolder_Callback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.__SurfaceHolder_Callback(@__env); 
			} 
		} 
		internal __SurfaceHolder_Callback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _surfaceCreated8054; 
		 void android.view.SurfaceHolder_Callback.surfaceCreated(android.view.SurfaceHolder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__SurfaceHolder_Callback)) 
				@__env.CallVoidMethod(this, global::android.view.__SurfaceHolder_Callback._surfaceCreated8054, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SurfaceHolder_Callback.staticClass, global::android.view.__SurfaceHolder_Callback._surfaceCreated8054, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _surfaceDestroyed8055; 
		 void android.view.SurfaceHolder_Callback.surfaceDestroyed(android.view.SurfaceHolder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__SurfaceHolder_Callback)) 
				@__env.CallVoidMethod(this, global::android.view.__SurfaceHolder_Callback._surfaceDestroyed8055, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SurfaceHolder_Callback.staticClass, global::android.view.__SurfaceHolder_Callback._surfaceDestroyed8055, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _surfaceChanged8056; 
		 void android.view.SurfaceHolder_Callback.surfaceChanged(android.view.SurfaceHolder arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__SurfaceHolder_Callback)) 
				@__env.CallVoidMethod(this, global::android.view.__SurfaceHolder_Callback._surfaceChanged8056, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__SurfaceHolder_Callback.staticClass, global::android.view.__SurfaceHolder_Callback._surfaceChanged8056, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.__SurfaceHolder_Callback.staticClass = @__class; 
			global::android.view.__SurfaceHolder_Callback._surfaceCreated8054 = @__env.GetMethodID(global::android.view.__SurfaceHolder_Callback.staticClass, "android.view.SurfaceHolder_Callback.surfaceCreated", "(Landroid/view/SurfaceHolder;)V"); 
			global::android.view.__SurfaceHolder_Callback._surfaceDestroyed8055 = @__env.GetMethodID(global::android.view.__SurfaceHolder_Callback.staticClass, "android.view.SurfaceHolder_Callback.surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V"); 
			global::android.view.__SurfaceHolder_Callback._surfaceChanged8056 = @__env.GetMethodID(global::android.view.__SurfaceHolder_Callback.staticClass, "android.view.SurfaceHolder_Callback.surfaceChanged", "(Landroid/view/SurfaceHolder;III)V"); 
		} 
	} 
} 
