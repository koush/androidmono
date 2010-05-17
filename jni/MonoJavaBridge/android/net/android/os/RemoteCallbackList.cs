namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RemoteCallbackList : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static RemoteCallbackList() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.RemoteCallbackList), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.RemoteCallbackList(@__env); 
			} 
		} 
		protected RemoteCallbackList(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _register5577; 
		public virtual bool register(android.os.IInterface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				return @__env.CallBooleanMethod(this, _register5577, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.RemoteCallbackList.staticClass, _register5577, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _register5578; 
		public virtual bool register(android.os.IInterface arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				return @__env.CallBooleanMethod(this, _register5578, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.RemoteCallbackList.staticClass, _register5578, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregister5579; 
		public virtual bool unregister(android.os.IInterface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				return @__env.CallBooleanMethod(this, _unregister5579, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.RemoteCallbackList.staticClass, _unregister5579, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _kill5580; 
		public virtual void kill() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				@__env.CallVoidMethod(this, _kill5580); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.RemoteCallbackList.staticClass, _kill5580); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCallbackDied5581; 
		public virtual void onCallbackDied(android.os.IInterface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				@__env.CallVoidMethod(this, _onCallbackDied5581, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.RemoteCallbackList.staticClass, _onCallbackDied5581, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCallbackDied5582; 
		public virtual void onCallbackDied(android.os.IInterface arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				@__env.CallVoidMethod(this, _onCallbackDied5582, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.RemoteCallbackList.staticClass, _onCallbackDied5582, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _beginBroadcast5583; 
		public virtual int beginBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				return @__env.CallIntMethod(this, _beginBroadcast5583); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.RemoteCallbackList.staticClass, _beginBroadcast5583); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBroadcastItem5584; 
		public virtual android.os.IInterface getBroadcastItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IInterface>(@__env, @__env.CallObjectMethodPtr(this, _getBroadcastItem5584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IInterface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.RemoteCallbackList.staticClass, _getBroadcastItem5584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBroadcastCookie5585; 
		public virtual java.lang.Object getBroadcastCookie(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getBroadcastCookie5585, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.RemoteCallbackList.staticClass, _getBroadcastCookie5585, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finishBroadcast5586; 
		public virtual void finishBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				@__env.CallVoidMethod(this, _finishBroadcast5586); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.RemoteCallbackList.staticClass, _finishBroadcast5586); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RemoteCallbackList5587; 
		public RemoteCallbackList()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.RemoteCallbackList.staticClass, _RemoteCallbackList5587, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.RemoteCallbackList.staticClass = @__class; 
			global::android.os.RemoteCallbackList._register5577 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "register", "(Landroid/os/IInterface;)Z"); 
			global::android.os.RemoteCallbackList._register5578 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "register", "(Landroid/os/IInterface;Ljava/lang/Object;)Z"); 
			global::android.os.RemoteCallbackList._unregister5579 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "unregister", "(Landroid/os/IInterface;)Z"); 
			global::android.os.RemoteCallbackList._kill5580 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "kill", "()V"); 
			global::android.os.RemoteCallbackList._onCallbackDied5581 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "onCallbackDied", "(Landroid/os/IInterface;)V"); 
			global::android.os.RemoteCallbackList._onCallbackDied5582 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "onCallbackDied", "(Landroid/os/IInterface;Ljava/lang/Object;)V"); 
			global::android.os.RemoteCallbackList._beginBroadcast5583 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "beginBroadcast", "()I"); 
			global::android.os.RemoteCallbackList._getBroadcastItem5584 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "getBroadcastItem", "(I)Landroid/os/IInterface;"); 
			global::android.os.RemoteCallbackList._getBroadcastCookie5585 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "getBroadcastCookie", "(I)Ljava/lang/Object;"); 
			global::android.os.RemoteCallbackList._finishBroadcast5586 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "finishBroadcast", "()V"); 
			global::android.os.RemoteCallbackList._RemoteCallbackList5587 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "<init>", "()V"); 
		} 
	} 
} 
