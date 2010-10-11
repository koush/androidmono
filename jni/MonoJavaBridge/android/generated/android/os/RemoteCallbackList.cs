namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RemoteCallbackList : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RemoteCallbackList()
		{
			InitJNI();
		}
		protected RemoteCallbackList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register6703;
		public virtual bool register(android.os.IInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.RemoteCallbackList._register6703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._register6703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _register6704;
		public virtual bool register(android.os.IInterface arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.RemoteCallbackList._register6704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._register6704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unregister6705;
		public virtual bool unregister(android.os.IInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.RemoteCallbackList._unregister6705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._unregister6705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _kill6706;
		public virtual void kill() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList._kill6706);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._kill6706);
		}
		internal static global::MonoJavaBridge.MethodId _onCallbackDied6707;
		public virtual void onCallbackDied(android.os.IInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList._onCallbackDied6707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._onCallbackDied6707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCallbackDied6708;
		public virtual void onCallbackDied(android.os.IInterface arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList._onCallbackDied6708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._onCallbackDied6708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _beginBroadcast6709;
		public virtual int beginBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.RemoteCallbackList._beginBroadcast6709);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._beginBroadcast6709);
		}
		internal static global::MonoJavaBridge.MethodId _getBroadcastItem6710;
		public virtual global::android.os.IInterface getBroadcastItem(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IInterface>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.RemoteCallbackList._getBroadcastItem6710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IInterface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IInterface>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._getBroadcastItem6710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IInterface;
		}
		internal static global::MonoJavaBridge.MethodId _getBroadcastCookie6711;
		public virtual global::java.lang.Object getBroadcastCookie(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.RemoteCallbackList._getBroadcastCookie6711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._getBroadcastCookie6711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _finishBroadcast6712;
		public virtual void finishBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList._finishBroadcast6712);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._finishBroadcast6712);
		}
		internal static global::MonoJavaBridge.MethodId _RemoteCallbackList6713;
		public RemoteCallbackList()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._RemoteCallbackList6713);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.RemoteCallbackList.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/RemoteCallbackList"));
			global::android.os.RemoteCallbackList._register6703 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "register", "(Landroid/os/IInterface;)Z");
			global::android.os.RemoteCallbackList._register6704 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "register", "(Landroid/os/IInterface;Ljava/lang/Object;)Z");
			global::android.os.RemoteCallbackList._unregister6705 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "unregister", "(Landroid/os/IInterface;)Z");
			global::android.os.RemoteCallbackList._kill6706 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "kill", "()V");
			global::android.os.RemoteCallbackList._onCallbackDied6707 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "onCallbackDied", "(Landroid/os/IInterface;)V");
			global::android.os.RemoteCallbackList._onCallbackDied6708 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "onCallbackDied", "(Landroid/os/IInterface;Ljava/lang/Object;)V");
			global::android.os.RemoteCallbackList._beginBroadcast6709 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "beginBroadcast", "()I");
			global::android.os.RemoteCallbackList._getBroadcastItem6710 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "getBroadcastItem", "(I)Landroid/os/IInterface;");
			global::android.os.RemoteCallbackList._getBroadcastCookie6711 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "getBroadcastCookie", "(I)Ljava/lang/Object;");
			global::android.os.RemoteCallbackList._finishBroadcast6712 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "finishBroadcast", "()V");
			global::android.os.RemoteCallbackList._RemoteCallbackList6713 = @__env.GetMethodIDNoThrow(global::android.os.RemoteCallbackList.staticClass, "<init>", "()V");
		}
	}
}
