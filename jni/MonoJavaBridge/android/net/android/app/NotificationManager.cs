namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class NotificationManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static NotificationManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.NotificationManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _notify682; 
		public virtual void notify(int arg0, android.app.Notification arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.NotificationManager._notify682, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.NotificationManager.staticClass, global::android.app.NotificationManager._notify682, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notify683; 
		public virtual void notify(java.lang.String arg0, int arg1, android.app.Notification arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.NotificationManager._notify683, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.NotificationManager.staticClass, global::android.app.NotificationManager._notify683, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel684; 
		public virtual void cancel(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.NotificationManager._cancel684, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.NotificationManager.staticClass, global::android.app.NotificationManager._cancel684, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel685; 
		public virtual void cancel(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.NotificationManager._cancel685, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.NotificationManager.staticClass, global::android.app.NotificationManager._cancel685, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelAll686; 
		public virtual void cancelAll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.NotificationManager._cancelAll686); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.NotificationManager.staticClass, global::android.app.NotificationManager._cancelAll686); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.NotificationManager.staticClass = @__class; 
			global::android.app.NotificationManager._notify682 = @__env.GetMethodID(global::android.app.NotificationManager.staticClass, "notify", "(ILandroid/app/Notification;)V"); 
			global::android.app.NotificationManager._notify683 = @__env.GetMethodID(global::android.app.NotificationManager.staticClass, "notify", "(Ljava/lang/String;ILandroid/app/Notification;)V"); 
			global::android.app.NotificationManager._cancel684 = @__env.GetMethodID(global::android.app.NotificationManager.staticClass, "cancel", "(I)V"); 
			global::android.app.NotificationManager._cancel685 = @__env.GetMethodID(global::android.app.NotificationManager.staticClass, "cancel", "(Ljava/lang/String;I)V"); 
			global::android.app.NotificationManager._cancelAll686 = @__env.GetMethodID(global::android.app.NotificationManager.staticClass, "cancelAll", "()V"); 
		} 
	} 
} 
