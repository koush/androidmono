namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Binder : java.lang.Object, IBinder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Binder()
		{
			InitJNI();
		}
		protected Binder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize6147;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Binder._finalize6147);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._finalize6147);
		}
		internal static global::MonoJavaBridge.MethodId _dump6148;
		protected virtual void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Binder._dump6148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._dump6148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dump6149;
		public virtual void dump(java.io.FileDescriptor arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Binder._dump6149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._dump6149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInterfaceDescriptor6150;
		public virtual global::java.lang.String getInterfaceDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Binder._getInterfaceDescriptor6150)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._getInterfaceDescriptor6150)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _pingBinder6151;
		public virtual bool pingBinder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Binder._pingBinder6151);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._pingBinder6151);
		}
		internal static global::MonoJavaBridge.MethodId _isBinderAlive6152;
		public virtual bool isBinderAlive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Binder._isBinderAlive6152);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._isBinderAlive6152);
		}
		internal static global::MonoJavaBridge.MethodId _queryLocalInterface6153;
		public virtual global::android.os.IInterface queryLocalInterface(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IInterface>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Binder._queryLocalInterface6153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IInterface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IInterface>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._queryLocalInterface6153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IInterface;
		}
		internal static global::MonoJavaBridge.MethodId _transact6154;
		public virtual bool transact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Binder._transact6154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._transact6154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _linkToDeath6155;
		public virtual void linkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Binder._linkToDeath6155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._linkToDeath6155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unlinkToDeath6156;
		public virtual bool unlinkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Binder._unlinkToDeath6156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._unlinkToDeath6156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCallingPid6157;
		public static int getCallingPid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Binder.staticClass, global::android.os.Binder._getCallingPid6157);
		}
		internal static global::MonoJavaBridge.MethodId _getCallingUid6158;
		public static int getCallingUid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Binder.staticClass, global::android.os.Binder._getCallingUid6158);
		}
		internal static global::MonoJavaBridge.MethodId _clearCallingIdentity6159;
		public static long clearCallingIdentity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Binder.staticClass, global::android.os.Binder._clearCallingIdentity6159);
		}
		internal static global::MonoJavaBridge.MethodId _restoreCallingIdentity6160;
		public static void restoreCallingIdentity(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, global::android.os.Binder._restoreCallingIdentity6160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flushPendingCommands6161;
		public static void flushPendingCommands() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, global::android.os.Binder._flushPendingCommands6161);
		}
		internal static global::MonoJavaBridge.MethodId _joinThreadPool6162;
		public static void joinThreadPool() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, global::android.os.Binder._joinThreadPool6162);
		}
		internal static global::MonoJavaBridge.MethodId _attachInterface6163;
		public virtual void attachInterface(android.os.IInterface arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Binder._attachInterface6163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._attachInterface6163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTransact6164;
		protected virtual bool onTransact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Binder._onTransact6164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._onTransact6164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _Binder6165;
		public Binder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Binder.staticClass, global::android.os.Binder._Binder6165);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Binder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Binder"));
			global::android.os.Binder._finalize6147 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "finalize", "()V");
			global::android.os.Binder._dump6148 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V");
			global::android.os.Binder._dump6149 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "dump", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V");
			global::android.os.Binder._getInterfaceDescriptor6150 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "getInterfaceDescriptor", "()Ljava/lang/String;");
			global::android.os.Binder._pingBinder6151 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "pingBinder", "()Z");
			global::android.os.Binder._isBinderAlive6152 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "isBinderAlive", "()Z");
			global::android.os.Binder._queryLocalInterface6153 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "queryLocalInterface", "(Ljava/lang/String;)Landroid/os/IInterface;");
			global::android.os.Binder._transact6154 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "transact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			global::android.os.Binder._linkToDeath6155 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "linkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)V");
			global::android.os.Binder._unlinkToDeath6156 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "unlinkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)Z");
			global::android.os.Binder._getCallingPid6157 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "getCallingPid", "()I");
			global::android.os.Binder._getCallingUid6158 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "getCallingUid", "()I");
			global::android.os.Binder._clearCallingIdentity6159 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "clearCallingIdentity", "()J");
			global::android.os.Binder._restoreCallingIdentity6160 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "restoreCallingIdentity", "(J)V");
			global::android.os.Binder._flushPendingCommands6161 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "flushPendingCommands", "()V");
			global::android.os.Binder._joinThreadPool6162 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "joinThreadPool", "()V");
			global::android.os.Binder._attachInterface6163 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "attachInterface", "(Landroid/os/IInterface;Ljava/lang/String;)V");
			global::android.os.Binder._onTransact6164 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			global::android.os.Binder._Binder6165 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "<init>", "()V");
		}
	}
}
