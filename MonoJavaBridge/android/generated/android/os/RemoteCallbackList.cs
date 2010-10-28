namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RemoteCallbackList : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RemoteCallbackList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register10184;
		public virtual bool register(android.os.IInterface arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.RemoteCallbackList._register10184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._register10184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool register(global::android.os.IInterfaceDelegate arg0)
		{
			return register((global::android.os.IInterfaceDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _register10185;
		public virtual bool register(android.os.IInterface arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.RemoteCallbackList._register10185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._register10185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool register(global::android.os.IInterfaceDelegate arg0, java.lang.Object arg1)
		{
			return register((global::android.os.IInterfaceDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _unregister10186;
		public virtual bool unregister(android.os.IInterface arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.RemoteCallbackList._unregister10186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._unregister10186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool unregister(global::android.os.IInterfaceDelegate arg0)
		{
			return unregister((global::android.os.IInterfaceDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _kill10187;
		public virtual void kill()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList._kill10187);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._kill10187);
		}
		internal static global::MonoJavaBridge.MethodId _onCallbackDied10188;
		public virtual void onCallbackDied(android.os.IInterface arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList._onCallbackDied10188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._onCallbackDied10188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void onCallbackDied(global::android.os.IInterfaceDelegate arg0)
		{
			onCallbackDied((global::android.os.IInterfaceDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _onCallbackDied10189;
		public virtual void onCallbackDied(android.os.IInterface arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList._onCallbackDied10189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._onCallbackDied10189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void onCallbackDied(global::android.os.IInterfaceDelegate arg0, java.lang.Object arg1)
		{
			onCallbackDied((global::android.os.IInterfaceDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _beginBroadcast10190;
		public virtual int beginBroadcast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.RemoteCallbackList._beginBroadcast10190);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._beginBroadcast10190);
		}
		internal static global::MonoJavaBridge.MethodId _getBroadcastItem10191;
		public virtual global::android.os.IInterface getBroadcastItem(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IInterface>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.RemoteCallbackList._getBroadcastItem10191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IInterface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IInterface>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._getBroadcastItem10191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IInterface;
		}
		internal static global::MonoJavaBridge.MethodId _getBroadcastCookie10192;
		public virtual global::java.lang.Object getBroadcastCookie(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.RemoteCallbackList._getBroadcastCookie10192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._getBroadcastCookie10192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _finishBroadcast10193;
		public virtual void finishBroadcast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList._finishBroadcast10193);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._finishBroadcast10193);
		}
		internal static global::MonoJavaBridge.MethodId _RemoteCallbackList10194;
		public RemoteCallbackList() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._RemoteCallbackList10194);
			Init(@__env, handle);
		}
		static RemoteCallbackList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.RemoteCallbackList.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/RemoteCallbackList"));
			global::android.os.RemoteCallbackList._register10184 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "register", "(Landroid/os/IInterface;)Z");
			global::android.os.RemoteCallbackList._register10185 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "register", "(Landroid/os/IInterface;Ljava/lang/Object;)Z");
			global::android.os.RemoteCallbackList._unregister10186 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "unregister", "(Landroid/os/IInterface;)Z");
			global::android.os.RemoteCallbackList._kill10187 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "kill", "()V");
			global::android.os.RemoteCallbackList._onCallbackDied10188 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "onCallbackDied", "(Landroid/os/IInterface;)V");
			global::android.os.RemoteCallbackList._onCallbackDied10189 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "onCallbackDied", "(Landroid/os/IInterface;Ljava/lang/Object;)V");
			global::android.os.RemoteCallbackList._beginBroadcast10190 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "beginBroadcast", "()I");
			global::android.os.RemoteCallbackList._getBroadcastItem10191 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "getBroadcastItem", "(I)Landroid/os/IInterface;");
			global::android.os.RemoteCallbackList._getBroadcastCookie10192 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "getBroadcastCookie", "(I)Ljava/lang/Object;");
			global::android.os.RemoteCallbackList._finishBroadcast10193 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "finishBroadcast", "()V");
			global::android.os.RemoteCallbackList._RemoteCallbackList10194 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
