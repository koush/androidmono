namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface MenuItem_OnMenuItemClickListener 
	{ 
		bool onMenuItemClick(android.view.MenuItem arg0); 
	} 

	public partial class MenuItem_OnMenuItemClickListener_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __MenuItem_OnMenuItemClickListener.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __MenuItem_OnMenuItemClickListener : java.lang.Object, MenuItem_OnMenuItemClickListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static __MenuItem_OnMenuItemClickListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.__MenuItem_OnMenuItemClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.__MenuItem_OnMenuItemClickListener(@__env); 
			} 
		} 
		internal __MenuItem_OnMenuItemClickListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMenuItemClick7904; 
		 bool android.view.MenuItem_OnMenuItemClickListener.onMenuItemClick(android.view.MenuItem arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.__MenuItem_OnMenuItemClickListener)) 
				return @__env.CallBooleanMethod(this, global::android.view.__MenuItem_OnMenuItemClickListener._onMenuItemClick7904, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.__MenuItem_OnMenuItemClickListener.staticClass, global::android.view.__MenuItem_OnMenuItemClickListener._onMenuItemClick7904, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.__MenuItem_OnMenuItemClickListener.staticClass = @__class; 
			global::android.view.__MenuItem_OnMenuItemClickListener._onMenuItemClick7904 = @__env.GetMethodID(global::android.view.__MenuItem_OnMenuItemClickListener.staticClass, "android.view.MenuItem_OnMenuItemClickListener.onMenuItemClick", "(Landroid/view/MenuItem;)Z"); 
		} 
	} 
} 
