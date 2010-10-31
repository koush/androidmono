namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RemoteCallbackList : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RemoteCallbackList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool register(android.os.IInterface arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.RemoteCallbackList.staticClass, "register", "(Landroid/os/IInterface;)Z", ref global::android.os.RemoteCallbackList._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool register(global::android.os.IInterfaceDelegate arg0)
		{
			return register((global::android.os.IInterfaceDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool register(android.os.IInterface arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.RemoteCallbackList.staticClass, "register", "(Landroid/os/IInterface;Ljava/lang/Object;)Z", ref global::android.os.RemoteCallbackList._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool register(global::android.os.IInterfaceDelegate arg0, java.lang.Object arg1)
		{
			return register((global::android.os.IInterfaceDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool unregister(android.os.IInterface arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.RemoteCallbackList.staticClass, "unregister", "(Landroid/os/IInterface;)Z", ref global::android.os.RemoteCallbackList._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool unregister(global::android.os.IInterfaceDelegate arg0)
		{
			return unregister((global::android.os.IInterfaceDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void kill()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.RemoteCallbackList.staticClass, "kill", "()V", ref global::android.os.RemoteCallbackList._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void onCallbackDied(android.os.IInterface arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.RemoteCallbackList.staticClass, "onCallbackDied", "(Landroid/os/IInterface;)V", ref global::android.os.RemoteCallbackList._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void onCallbackDied(global::android.os.IInterfaceDelegate arg0)
		{
			onCallbackDied((global::android.os.IInterfaceDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void onCallbackDied(android.os.IInterface arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.RemoteCallbackList.staticClass, "onCallbackDied", "(Landroid/os/IInterface;Ljava/lang/Object;)V", ref global::android.os.RemoteCallbackList._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void onCallbackDied(global::android.os.IInterfaceDelegate arg0, java.lang.Object arg1)
		{
			onCallbackDied((global::android.os.IInterfaceDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int beginBroadcast()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.RemoteCallbackList.staticClass, "beginBroadcast", "()I", ref global::android.os.RemoteCallbackList._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.os.IInterface getBroadcastItem(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IInterface>(this, global::android.os.RemoteCallbackList.staticClass, "getBroadcastItem", "(I)Landroid/os/IInterface;", ref global::android.os.RemoteCallbackList._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.IInterface;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.Object getBroadcastCookie(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.RemoteCallbackList.staticClass, "getBroadcastCookie", "(I)Ljava/lang/Object;", ref global::android.os.RemoteCallbackList._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void finishBroadcast()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.RemoteCallbackList.staticClass, "finishBroadcast", "()V", ref global::android.os.RemoteCallbackList._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public RemoteCallbackList() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.RemoteCallbackList._m10.native == global::System.IntPtr.Zero)
				global::android.os.RemoteCallbackList._m10 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._m10);
			Init(@__env, handle);
		}
		static RemoteCallbackList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.RemoteCallbackList.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/RemoteCallbackList"));
		}
	}
}
