namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ContextMenu_ContextMenuInfo 
	{ 
	} 

	public partial class ContextMenu_ContextMenuInfo_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __ContextMenu_ContextMenuInfo.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __ContextMenu_ContextMenuInfo : java.lang.Object, ContextMenu_ContextMenuInfo
	{ 
		internal static global::java.lang.Class staticClass; 
		static __ContextMenu_ContextMenuInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.__ContextMenu_ContextMenuInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.__ContextMenu_ContextMenuInfo(@__env); 
			} 
		} 
		internal __ContextMenu_ContextMenuInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.__ContextMenu_ContextMenuInfo.staticClass = @__class; 
		} 
	} 
} 
