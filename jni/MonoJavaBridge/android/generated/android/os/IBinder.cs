namespace android.os
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.IBinder_))]
	public interface IBinder  : global::MonoJavaBridge.IJavaObject 
	{
		void dump(java.io.FileDescriptor arg0, java.lang.String[] arg1);
		global::java.lang.String getInterfaceDescriptor();
		bool pingBinder();
		bool isBinderAlive();
		global::android.os.IInterface queryLocalInterface(java.lang.String arg0);
		bool transact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3);
		void linkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1);
		bool unlinkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.IBinder))]
	public sealed partial class IBinder_ : java.lang.Object, IBinder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IBinder_()
		{
			InitJNI();
		}
		internal IBinder_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _dump6462;
		 void android.os.IBinder.dump(java.io.FileDescriptor arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.IBinder_._dump6462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.IBinder_.staticClass, global::android.os.IBinder_._dump6462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInterfaceDescriptor6463;
		 global::java.lang.String android.os.IBinder.getInterfaceDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.IBinder_._getInterfaceDescriptor6463)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.IBinder_.staticClass, global::android.os.IBinder_._getInterfaceDescriptor6463)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _pingBinder6464;
		 bool android.os.IBinder.pingBinder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.IBinder_._pingBinder6464);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.IBinder_.staticClass, global::android.os.IBinder_._pingBinder6464);
		}
		internal static global::MonoJavaBridge.MethodId _isBinderAlive6465;
		 bool android.os.IBinder.isBinderAlive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.IBinder_._isBinderAlive6465);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.IBinder_.staticClass, global::android.os.IBinder_._isBinderAlive6465);
		}
		internal static global::MonoJavaBridge.MethodId _queryLocalInterface6466;
		 global::android.os.IInterface android.os.IBinder.queryLocalInterface(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IInterface>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.IBinder_._queryLocalInterface6466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IInterface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IInterface>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.IBinder_.staticClass, global::android.os.IBinder_._queryLocalInterface6466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IInterface;
		}
		internal static global::MonoJavaBridge.MethodId _transact6467;
		 bool android.os.IBinder.transact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.IBinder_._transact6467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.IBinder_.staticClass, global::android.os.IBinder_._transact6467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _linkToDeath6468;
		 void android.os.IBinder.linkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.IBinder_._linkToDeath6468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.IBinder_.staticClass, global::android.os.IBinder_._linkToDeath6468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unlinkToDeath6469;
		 bool android.os.IBinder.unlinkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.IBinder_._unlinkToDeath6469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.IBinder_.staticClass, global::android.os.IBinder_._unlinkToDeath6469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.IBinder_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/IBinder"));
			global::android.os.IBinder_._dump6462 = @__env.GetMethodIDNoThrow(global::android.os.IBinder_.staticClass, "dump", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V");
			global::android.os.IBinder_._getInterfaceDescriptor6463 = @__env.GetMethodIDNoThrow(global::android.os.IBinder_.staticClass, "getInterfaceDescriptor", "()Ljava/lang/String;");
			global::android.os.IBinder_._pingBinder6464 = @__env.GetMethodIDNoThrow(global::android.os.IBinder_.staticClass, "pingBinder", "()Z");
			global::android.os.IBinder_._isBinderAlive6465 = @__env.GetMethodIDNoThrow(global::android.os.IBinder_.staticClass, "isBinderAlive", "()Z");
			global::android.os.IBinder_._queryLocalInterface6466 = @__env.GetMethodIDNoThrow(global::android.os.IBinder_.staticClass, "queryLocalInterface", "(Ljava/lang/String;)Landroid/os/IInterface;");
			global::android.os.IBinder_._transact6467 = @__env.GetMethodIDNoThrow(global::android.os.IBinder_.staticClass, "transact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			global::android.os.IBinder_._linkToDeath6468 = @__env.GetMethodIDNoThrow(global::android.os.IBinder_.staticClass, "linkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)V");
			global::android.os.IBinder_._unlinkToDeath6469 = @__env.GetMethodIDNoThrow(global::android.os.IBinder_.staticClass, "unlinkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)Z");
		}
	}
}
