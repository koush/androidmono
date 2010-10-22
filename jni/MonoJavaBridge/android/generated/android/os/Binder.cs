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
		internal static global::MonoJavaBridge.MethodId _finalize9497;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Binder._finalize9497);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._finalize9497);
		}
		internal static global::MonoJavaBridge.MethodId _dump9498;
		protected virtual void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Binder._dump9498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._dump9498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _dump9499;
		public virtual void dump(java.io.FileDescriptor arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Binder._dump9499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._dump9499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String InterfaceDescriptor
		{
			get
			{
				return getInterfaceDescriptor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInterfaceDescriptor9500;
		public virtual global::java.lang.String getInterfaceDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Binder._getInterfaceDescriptor9500)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._getInterfaceDescriptor9500)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _pingBinder9501;
		public virtual bool pingBinder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Binder._pingBinder9501);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._pingBinder9501);
		}
		internal static global::MonoJavaBridge.MethodId _isBinderAlive9502;
		public virtual bool isBinderAlive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Binder._isBinderAlive9502);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._isBinderAlive9502);
		}
		internal static global::MonoJavaBridge.MethodId _queryLocalInterface9503;
		public virtual global::android.os.IInterface queryLocalInterface(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IInterface>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Binder._queryLocalInterface9503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IInterface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IInterface>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._queryLocalInterface9503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IInterface;
		}
		internal static global::MonoJavaBridge.MethodId _transact9504;
		public virtual bool transact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Binder._transact9504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._transact9504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _linkToDeath9505;
		public virtual void linkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Binder._linkToDeath9505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._linkToDeath9505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unlinkToDeath9506;
		public virtual bool unlinkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Binder._unlinkToDeath9506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._unlinkToDeath9506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int CallingPid
		{
			get
			{
				return getCallingPid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCallingPid9507;
		public static int getCallingPid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Binder.staticClass, global::android.os.Binder._getCallingPid9507);
		}
		public static int CallingUid
		{
			get
			{
				return getCallingUid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCallingUid9508;
		public static int getCallingUid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Binder.staticClass, global::android.os.Binder._getCallingUid9508);
		}
		internal static global::MonoJavaBridge.MethodId _clearCallingIdentity9509;
		public static long clearCallingIdentity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Binder.staticClass, global::android.os.Binder._clearCallingIdentity9509);
		}
		internal static global::MonoJavaBridge.MethodId _restoreCallingIdentity9510;
		public static void restoreCallingIdentity(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, global::android.os.Binder._restoreCallingIdentity9510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flushPendingCommands9511;
		public static void flushPendingCommands() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, global::android.os.Binder._flushPendingCommands9511);
		}
		internal static global::MonoJavaBridge.MethodId _joinThreadPool9512;
		public static void joinThreadPool() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, global::android.os.Binder._joinThreadPool9512);
		}
		internal static global::MonoJavaBridge.MethodId _attachInterface9513;
		public virtual void attachInterface(android.os.IInterface arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Binder._attachInterface9513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._attachInterface9513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTransact9514;
		protected virtual bool onTransact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Binder._onTransact9514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Binder.staticClass, global::android.os.Binder._onTransact9514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _Binder9515;
		public Binder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Binder.staticClass, global::android.os.Binder._Binder9515);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Binder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Binder"));
			global::android.os.Binder._finalize9497 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "finalize", "()V");
			global::android.os.Binder._dump9498 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V");
			global::android.os.Binder._dump9499 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "dump", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V");
			global::android.os.Binder._getInterfaceDescriptor9500 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "getInterfaceDescriptor", "()Ljava/lang/String;");
			global::android.os.Binder._pingBinder9501 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "pingBinder", "()Z");
			global::android.os.Binder._isBinderAlive9502 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "isBinderAlive", "()Z");
			global::android.os.Binder._queryLocalInterface9503 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "queryLocalInterface", "(Ljava/lang/String;)Landroid/os/IInterface;");
			global::android.os.Binder._transact9504 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "transact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			global::android.os.Binder._linkToDeath9505 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "linkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)V");
			global::android.os.Binder._unlinkToDeath9506 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "unlinkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)Z");
			global::android.os.Binder._getCallingPid9507 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "getCallingPid", "()I");
			global::android.os.Binder._getCallingUid9508 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "getCallingUid", "()I");
			global::android.os.Binder._clearCallingIdentity9509 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "clearCallingIdentity", "()J");
			global::android.os.Binder._restoreCallingIdentity9510 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "restoreCallingIdentity", "(J)V");
			global::android.os.Binder._flushPendingCommands9511 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "flushPendingCommands", "()V");
			global::android.os.Binder._joinThreadPool9512 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "joinThreadPool", "()V");
			global::android.os.Binder._attachInterface9513 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "attachInterface", "(Landroid/os/IInterface;Ljava/lang/String;)V");
			global::android.os.Binder._onTransact9514 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			global::android.os.Binder._Binder9515 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "<init>", "()V");
		}
	}
}
