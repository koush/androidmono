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
		internal static global::net.sf.jni4net.jni.MethodId _register5851; 
		public virtual bool register(android.os.IInterface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				return @__env.CallBooleanMethod(this, _register5851, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.RemoteCallbackList.staticClass, _register5851, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _register5852; 
		public virtual bool register(android.os.IInterface arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				return @__env.CallBooleanMethod(this, _register5852, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.RemoteCallbackList.staticClass, _register5852, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregister5853; 
		public virtual bool unregister(android.os.IInterface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				return @__env.CallBooleanMethod(this, _unregister5853, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.RemoteCallbackList.staticClass, _unregister5853, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _kill5854; 
		public virtual void kill() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				@__env.CallVoidMethod(this, _kill5854); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.RemoteCallbackList.staticClass, _kill5854); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCallbackDied5855; 
		public virtual void onCallbackDied(android.os.IInterface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				@__env.CallVoidMethod(this, _onCallbackDied5855, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.RemoteCallbackList.staticClass, _onCallbackDied5855, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCallbackDied5856; 
		public virtual void onCallbackDied(android.os.IInterface arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				@__env.CallVoidMethod(this, _onCallbackDied5856, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.RemoteCallbackList.staticClass, _onCallbackDied5856, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _beginBroadcast5857; 
		public virtual int beginBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				return @__env.CallIntMethod(this, _beginBroadcast5857); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.RemoteCallbackList.staticClass, _beginBroadcast5857); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBroadcastItem5858; 
		public virtual android.os.IInterface getBroadcastItem(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IInterface>(@__env, @__env.CallObjectMethodPtr(this, _getBroadcastItem5858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IInterface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.RemoteCallbackList.staticClass, _getBroadcastItem5858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBroadcastCookie5859; 
		public virtual java.lang.Object getBroadcastCookie(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getBroadcastCookie5859, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.RemoteCallbackList.staticClass, _getBroadcastCookie5859, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finishBroadcast5860; 
		public virtual void finishBroadcast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.RemoteCallbackList)) 
				@__env.CallVoidMethod(this, _finishBroadcast5860); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.RemoteCallbackList.staticClass, _finishBroadcast5860); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RemoteCallbackList5861; 
		public RemoteCallbackList()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.RemoteCallbackList.staticClass, _RemoteCallbackList5861, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.RemoteCallbackList.staticClass = @__class; 
			global::android.os.RemoteCallbackList._register5851 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "register", "(Landroid/os/IInterface;)Z"); 
			global::android.os.RemoteCallbackList._register5852 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "register", "(Landroid/os/IInterface;Ljava/lang/Object;)Z"); 
			global::android.os.RemoteCallbackList._unregister5853 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "unregister", "(Landroid/os/IInterface;)Z"); 
			global::android.os.RemoteCallbackList._kill5854 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "kill", "()V"); 
			global::android.os.RemoteCallbackList._onCallbackDied5855 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "onCallbackDied", "(Landroid/os/IInterface;)V"); 
			global::android.os.RemoteCallbackList._onCallbackDied5856 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "onCallbackDied", "(Landroid/os/IInterface;Ljava/lang/Object;)V"); 
			global::android.os.RemoteCallbackList._beginBroadcast5857 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "beginBroadcast", "()I"); 
			global::android.os.RemoteCallbackList._getBroadcastItem5858 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "getBroadcastItem", "(I)Landroid/os/IInterface;"); 
			global::android.os.RemoteCallbackList._getBroadcastCookie5859 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "getBroadcastCookie", "(I)Ljava/lang/Object;"); 
			global::android.os.RemoteCallbackList._finishBroadcast5860 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "finishBroadcast", "()V"); 
			global::android.os.RemoteCallbackList._RemoteCallbackList5861 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "<init>", "()V"); 
		} 
	} 
} 
