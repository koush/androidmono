namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ViewManager 
	{ 
		void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1); 
		void updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1); 
		void removeView(android.view.View arg0); 
	} 

	public partial class ViewManager_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __ViewManager.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __ViewManager : java.lang.Object, ViewManager
	{ 
		internal static global::java.lang.Class staticClass; 
		static __ViewManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.__ViewManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.__ViewManager(@__env); 
			} 
		} 
		internal __ViewManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView8610; 
		 void android.view.ViewManager.addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.__ViewManager._addView8610, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ViewManager.staticClass, global::android.view.__ViewManager._addView8610, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateViewLayout8611; 
		 void android.view.ViewManager.updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.__ViewManager._updateViewLayout8611, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ViewManager.staticClass, global::android.view.__ViewManager._updateViewLayout8611, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeView8612; 
		 void android.view.ViewManager.removeView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.__ViewManager._removeView8612, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.__ViewManager.staticClass, global::android.view.__ViewManager._removeView8612, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.__ViewManager.staticClass = @__class; 
			global::android.view.__ViewManager._addView8610 = @__env.GetMethodID(global::android.view.__ViewManager.staticClass, "android.view.ViewManager.addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.__ViewManager._updateViewLayout8611 = @__env.GetMethodID(global::android.view.__ViewManager.staticClass, "android.view.ViewManager.updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.__ViewManager._removeView8612 = @__env.GetMethodID(global::android.view.__ViewManager.staticClass, "android.view.ViewManager.removeView", "(Landroid/view/View;)V"); 
		} 
	} 
} 
