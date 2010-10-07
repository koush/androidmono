namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class RemoteCallbackList : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static RemoteCallbackList()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.RemoteCallbackList), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _register6430;
		public virtual bool register(android.os.IInterface arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.RemoteCallbackList._register6430, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._register6430, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _register6431;
		public virtual bool register(android.os.IInterface arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.RemoteCallbackList._register6431, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._register6431, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregister6432;
		public virtual bool unregister(android.os.IInterface arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.RemoteCallbackList._unregister6432, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._unregister6432, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _kill6433;
		public virtual void kill() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.RemoteCallbackList._kill6433);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._kill6433);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCallbackDied6434;
		public virtual void onCallbackDied(android.os.IInterface arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.RemoteCallbackList._onCallbackDied6434, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._onCallbackDied6434, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCallbackDied6435;
		public virtual void onCallbackDied(android.os.IInterface arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.RemoteCallbackList._onCallbackDied6435, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._onCallbackDied6435, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _beginBroadcast6436;
		public virtual int beginBroadcast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.RemoteCallbackList._beginBroadcast6436);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._beginBroadcast6436);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBroadcastItem6437;
		public virtual global::android.os.IInterface getBroadcastItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IInterface>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.RemoteCallbackList._getBroadcastItem6437, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IInterface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._getBroadcastItem6437, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBroadcastCookie6438;
		public virtual global::java.lang.Object getBroadcastCookie(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.RemoteCallbackList._getBroadcastCookie6438, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._getBroadcastCookie6438, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _finishBroadcast6439;
		public virtual void finishBroadcast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.RemoteCallbackList._finishBroadcast6439);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._finishBroadcast6439);
		}
		internal static global::net.sf.jni4net.jni.MethodId _RemoteCallbackList6440;
		public RemoteCallbackList()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.RemoteCallbackList.staticClass, global::android.os.RemoteCallbackList._RemoteCallbackList6440, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.RemoteCallbackList.staticClass = @__class;
			global::android.os.RemoteCallbackList._register6430 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "register", "(Landroid/os/IInterface;)Z");
			global::android.os.RemoteCallbackList._register6431 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "register", "(Landroid/os/IInterface;Ljava/lang/Object;)Z");
			global::android.os.RemoteCallbackList._unregister6432 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "unregister", "(Landroid/os/IInterface;)Z");
			global::android.os.RemoteCallbackList._kill6433 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "kill", "()V");
			global::android.os.RemoteCallbackList._onCallbackDied6434 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "onCallbackDied", "(Landroid/os/IInterface;)V");
			global::android.os.RemoteCallbackList._onCallbackDied6435 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "onCallbackDied", "(Landroid/os/IInterface;Ljava/lang/Object;)V");
			global::android.os.RemoteCallbackList._beginBroadcast6436 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "beginBroadcast", "()I");
			global::android.os.RemoteCallbackList._getBroadcastItem6437 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "getBroadcastItem", "(I)Landroid/os/IInterface;");
			global::android.os.RemoteCallbackList._getBroadcastCookie6438 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "getBroadcastCookie", "(I)Ljava/lang/Object;");
			global::android.os.RemoteCallbackList._finishBroadcast6439 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "finishBroadcast", "()V");
			global::android.os.RemoteCallbackList._RemoteCallbackList6440 = @__env.GetMethodID(global::android.os.RemoteCallbackList.staticClass, "<init>", "()V");
		}
	}
}
