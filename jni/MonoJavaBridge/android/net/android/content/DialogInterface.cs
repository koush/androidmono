namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface DialogInterface 
	{ 
		void cancel(); 
		void dismiss(); 
	} 

	public partial class DialogInterface_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __DialogInterface.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __DialogInterface : java.lang.Object, DialogInterface
	{ 
		internal static global::java.lang.Class staticClass; 
		static __DialogInterface() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.__DialogInterface), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.__DialogInterface(@__env); 
			} 
		} 
		internal __DialogInterface(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel1277; 
		 void android.content.DialogInterface.cancel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__DialogInterface)) 
				@__env.CallVoidMethod(this, global::android.content.__DialogInterface._cancel1277); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.__DialogInterface.staticClass, global::android.content.__DialogInterface._cancel1277); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dismiss1278; 
		 void android.content.DialogInterface.dismiss() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__DialogInterface)) 
				@__env.CallVoidMethod(this, global::android.content.__DialogInterface._dismiss1278); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.content.__DialogInterface.staticClass, global::android.content.__DialogInterface._dismiss1278); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.__DialogInterface.staticClass = @__class; 
			global::android.content.__DialogInterface._cancel1277 = @__env.GetMethodID(global::android.content.__DialogInterface.staticClass, "android.content.DialogInterface.cancel", "()V"); 
			global::android.content.__DialogInterface._dismiss1278 = @__env.GetMethodID(global::android.content.__DialogInterface.staticClass, "android.content.DialogInterface.dismiss", "()V"); 
		} 
	} 
} 
