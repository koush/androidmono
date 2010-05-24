namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface DialogInterface_OnDismissListener 
	{ 
		void onDismiss(android.content.DialogInterface arg0); 
	} 

	public partial class DialogInterface_OnDismissListener_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __DialogInterface_OnDismissListener.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __DialogInterface_OnDismissListener : java.lang.Object, DialogInterface_OnDismissListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static __DialogInterface_OnDismissListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.__DialogInterface_OnDismissListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.__DialogInterface_OnDismissListener(@__env); 
			} 
		} 
		internal __DialogInterface_OnDismissListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDismiss1274; 
		 void android.content.DialogInterface_OnDismissListener.onDismiss(android.content.DialogInterface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__DialogInterface_OnDismissListener)) 
				@__env.CallVoidMethod(this, _onDismiss1274, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.__DialogInterface_OnDismissListener.staticClass, _onDismiss1274, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.__DialogInterface_OnDismissListener.staticClass = @__class; 
			global::android.content.__DialogInterface_OnDismissListener._onDismiss1274 = @__env.GetMethodID(global::android.content.__DialogInterface_OnDismissListener.staticClass, "android.content.DialogInterface_OnDismissListener.onDismiss", "(Landroid/content/DialogInterface;)V"); 
		} 
	} 
} 
