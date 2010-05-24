namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface DialogInterface_OnClickListener 
	{ 
		void onClick(android.content.DialogInterface arg0, int arg1); 
	} 

	public partial class DialogInterface_OnClickListener_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __DialogInterface_OnClickListener.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __DialogInterface_OnClickListener : java.lang.Object, DialogInterface_OnClickListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static __DialogInterface_OnClickListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.__DialogInterface_OnClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.__DialogInterface_OnClickListener(@__env); 
			} 
		} 
		internal __DialogInterface_OnClickListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick1273; 
		 void android.content.DialogInterface_OnClickListener.onClick(android.content.DialogInterface arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__DialogInterface_OnClickListener)) 
				@__env.CallVoidMethod(this, _onClick1273, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.__DialogInterface_OnClickListener.staticClass, _onClick1273, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.__DialogInterface_OnClickListener.staticClass = @__class; 
			global::android.content.__DialogInterface_OnClickListener._onClick1273 = @__env.GetMethodID(global::android.content.__DialogInterface_OnClickListener.staticClass, "android.content.DialogInterface_OnClickListener.onClick", "(Landroid/content/DialogInterface;I)V"); 
		} 
	} 
} 
