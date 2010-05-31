namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface WindowManager : ViewManager
	{
		global::android.view.Display getDefaultDisplay();
		void removeViewImmediate(android.view.View arg0);
	}

	public partial class WindowManager_
	{
		public static global::java.lang.Class _class
		{
			get { return __WindowManager.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __WindowManager : java.lang.Object, WindowManager
	{
		internal static global::java.lang.Class staticClass;
		static __WindowManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.__WindowManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.__WindowManager(@__env);
			}
		}
		internal __WindowManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultDisplay8783;
		 global::android.view.Display android.view.WindowManager.getDefaultDisplay() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Display>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.__WindowManager._getDefaultDisplay8783));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Display>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.__WindowManager.staticClass, global::android.view.__WindowManager._getDefaultDisplay8783));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeViewImmediate8784;
		 void android.view.WindowManager.removeViewImmediate(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__WindowManager._removeViewImmediate8784, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__WindowManager.staticClass, global::android.view.__WindowManager._removeViewImmediate8784, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView8785;
		 void android.view.ViewManager.addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__WindowManager._addView8785, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__WindowManager.staticClass, global::android.view.__WindowManager._addView8785, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateViewLayout8786;
		 void android.view.ViewManager.updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__WindowManager._updateViewLayout8786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__WindowManager.staticClass, global::android.view.__WindowManager._updateViewLayout8786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeView8787;
		 void android.view.ViewManager.removeView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.__WindowManager._removeView8787, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__WindowManager.staticClass, global::android.view.__WindowManager._removeView8787, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.__WindowManager.staticClass = @__class;
			global::android.view.__WindowManager._getDefaultDisplay8783 = @__env.GetMethodID(global::android.view.__WindowManager.staticClass, "android.view.WindowManager.getDefaultDisplay", "()Landroid/view/Display;");
			global::android.view.__WindowManager._removeViewImmediate8784 = @__env.GetMethodID(global::android.view.__WindowManager.staticClass, "android.view.WindowManager.removeViewImmediate", "(Landroid/view/View;)V");
			global::android.view.__WindowManager._addView8785 = @__env.GetMethodID(global::android.view.__WindowManager.staticClass, "android.view.ViewManager.addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.__WindowManager._updateViewLayout8786 = @__env.GetMethodID(global::android.view.__WindowManager.staticClass, "android.view.ViewManager.updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.__WindowManager._removeView8787 = @__env.GetMethodID(global::android.view.__WindowManager.staticClass, "android.view.ViewManager.removeView", "(Landroid/view/View;)V");
		}
	}
}
