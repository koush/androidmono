namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class NotificationManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static NotificationManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.NotificationManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.NotificationManager(@__env); 
			} 
		} 
		protected NotificationManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notify673; 
		public virtual void notify(int arg0, android.app.Notification arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.NotificationManager)) 
				@__env.CallVoidMethod(this, _notify673, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.NotificationManager.staticClass, _notify673, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notify674; 
		public virtual void notify(java.lang.String arg0, int arg1, android.app.Notification arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.NotificationManager)) 
				@__env.CallVoidMethod(this, _notify674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.NotificationManager.staticClass, _notify674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel675; 
		public virtual void cancel(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.NotificationManager)) 
				@__env.CallVoidMethod(this, _cancel675, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.NotificationManager.staticClass, _cancel675, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel676; 
		public virtual void cancel(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.NotificationManager)) 
				@__env.CallVoidMethod(this, _cancel676, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.NotificationManager.staticClass, _cancel676, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelAll677; 
		public virtual void cancelAll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.NotificationManager)) 
				@__env.CallVoidMethod(this, _cancelAll677); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.NotificationManager.staticClass, _cancelAll677); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.NotificationManager.staticClass = @__class; 
			global::android.app.NotificationManager._notify673 = @__env.GetMethodID(global::android.app.NotificationManager.staticClass, "notify", "(ILandroid/app/Notification;)V"); 
			global::android.app.NotificationManager._notify674 = @__env.GetMethodID(global::android.app.NotificationManager.staticClass, "notify", "(Ljava/lang/String;ILandroid/app/Notification;)V"); 
			global::android.app.NotificationManager._cancel675 = @__env.GetMethodID(global::android.app.NotificationManager.staticClass, "cancel", "(I)V"); 
			global::android.app.NotificationManager._cancel676 = @__env.GetMethodID(global::android.app.NotificationManager.staticClass, "cancel", "(Ljava/lang/String;I)V"); 
			global::android.app.NotificationManager._cancelAll677 = @__env.GetMethodID(global::android.app.NotificationManager.staticClass, "cancelAll", "()V"); 
		} 
	} 
} 
