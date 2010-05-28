namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SyncStatusObserver 
	{ 
		void onStatusChanged(int arg0); 
	} 

	public partial class SyncStatusObserver_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __SyncStatusObserver.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __SyncStatusObserver : java.lang.Object, SyncStatusObserver
	{ 
		internal static global::java.lang.Class staticClass; 
		static __SyncStatusObserver() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.__SyncStatusObserver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.__SyncStatusObserver(@__env); 
			} 
		} 
		internal __SyncStatusObserver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStatusChanged1564; 
		 void android.content.SyncStatusObserver.onStatusChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__SyncStatusObserver)) 
				@__env.CallVoidMethod(this, global::android.content.__SyncStatusObserver._onStatusChanged1564, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.__SyncStatusObserver.staticClass, global::android.content.__SyncStatusObserver._onStatusChanged1564, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.__SyncStatusObserver.staticClass = @__class; 
			global::android.content.__SyncStatusObserver._onStatusChanged1564 = @__env.GetMethodID(global::android.content.__SyncStatusObserver.staticClass, "android.content.SyncStatusObserver.onStatusChanged", "(I)V"); 
		} 
	} 
} 
