namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Binder : java.lang.Object, IBinder
	{ 
		internal static global::java.lang.Class staticClass; 
		static Binder() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.Binder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.Binder(@__env); 
			} 
		} 
		protected Binder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump5094; 
		protected virtual void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Binder)) 
				@__env.CallVoidMethod(this, _dump5094, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Binder.staticClass, _dump5094, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump5095; 
		public virtual void dump(java.io.FileDescriptor arg0, java.lang.String[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Binder)) 
				@__env.CallVoidMethod(this, _dump5095, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Binder.staticClass, _dump5095, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInterfaceDescriptor5096; 
		public virtual java.lang.String getInterfaceDescriptor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Binder)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getInterfaceDescriptor5096)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Binder.staticClass, _getInterfaceDescriptor5096)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pingBinder5097; 
		public virtual bool pingBinder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Binder)) 
				return @__env.CallBooleanMethod(this, _pingBinder5097); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Binder.staticClass, _pingBinder5097); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBinderAlive5098; 
		public virtual bool isBinderAlive() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Binder)) 
				return @__env.CallBooleanMethod(this, _isBinderAlive5098); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Binder.staticClass, _isBinderAlive5098); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _queryLocalInterface5099; 
		public virtual android.os.IInterface queryLocalInterface(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Binder)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IInterface>(@__env, @__env.CallObjectMethodPtr(this, _queryLocalInterface5099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IInterface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Binder.staticClass, _queryLocalInterface5099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _transact5100; 
		public virtual bool transact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Binder)) 
				return @__env.CallBooleanMethod(this, _transact5100, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Binder.staticClass, _transact5100, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _linkToDeath5101; 
		public virtual void linkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Binder)) 
				@__env.CallVoidMethod(this, _linkToDeath5101, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Binder.staticClass, _linkToDeath5101, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unlinkToDeath5102; 
		public virtual bool unlinkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Binder)) 
				return @__env.CallBooleanMethod(this, _unlinkToDeath5102, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Binder.staticClass, _unlinkToDeath5102, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCallingPid5103; 
		public static int getCallingPid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Binder.staticClass, _getCallingPid5103); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCallingUid5104; 
		public static int getCallingUid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Binder.staticClass, _getCallingUid5104); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearCallingIdentity5105; 
		public static long clearCallingIdentity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.os.Binder.staticClass, _clearCallingIdentity5105); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restoreCallingIdentity5106; 
		public static void restoreCallingIdentity(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, _restoreCallingIdentity5106, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flushPendingCommands5107; 
		public static void flushPendingCommands() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, _flushPendingCommands5107); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _joinThreadPool5108; 
		public static void joinThreadPool() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, _joinThreadPool5108); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _attachInterface5109; 
		public virtual void attachInterface(android.os.IInterface arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Binder)) 
				@__env.CallVoidMethod(this, _attachInterface5109, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Binder.staticClass, _attachInterface5109, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTransact5110; 
		protected virtual bool onTransact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Binder)) 
				return @__env.CallBooleanMethod(this, _onTransact5110, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Binder.staticClass, _onTransact5110, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Binder5111; 
		public Binder()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Binder.staticClass, _Binder5111, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.Binder.staticClass = @__class; 
			global::android.os.Binder._dump5094 = @__env.GetMethodID(global::android.os.Binder.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V"); 
			global::android.os.Binder._dump5095 = @__env.GetMethodID(global::android.os.Binder.staticClass, "dump", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V"); 
			global::android.os.Binder._getInterfaceDescriptor5096 = @__env.GetMethodID(global::android.os.Binder.staticClass, "getInterfaceDescriptor", "()Ljava/lang/String;"); 
			global::android.os.Binder._pingBinder5097 = @__env.GetMethodID(global::android.os.Binder.staticClass, "pingBinder", "()Z"); 
			global::android.os.Binder._isBinderAlive5098 = @__env.GetMethodID(global::android.os.Binder.staticClass, "isBinderAlive", "()Z"); 
			global::android.os.Binder._queryLocalInterface5099 = @__env.GetMethodID(global::android.os.Binder.staticClass, "queryLocalInterface", "(Ljava/lang/String;)Landroid/os/IInterface;"); 
			global::android.os.Binder._transact5100 = @__env.GetMethodID(global::android.os.Binder.staticClass, "transact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z"); 
			global::android.os.Binder._linkToDeath5101 = @__env.GetMethodID(global::android.os.Binder.staticClass, "linkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)V"); 
			global::android.os.Binder._unlinkToDeath5102 = @__env.GetMethodID(global::android.os.Binder.staticClass, "unlinkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)Z"); 
			global::android.os.Binder._getCallingPid5103 = @__env.GetStaticMethodID(global::android.os.Binder.staticClass, "getCallingPid", "()I"); 
			global::android.os.Binder._getCallingUid5104 = @__env.GetStaticMethodID(global::android.os.Binder.staticClass, "getCallingUid", "()I"); 
			global::android.os.Binder._clearCallingIdentity5105 = @__env.GetStaticMethodID(global::android.os.Binder.staticClass, "clearCallingIdentity", "()J"); 
			global::android.os.Binder._restoreCallingIdentity5106 = @__env.GetStaticMethodID(global::android.os.Binder.staticClass, "restoreCallingIdentity", "(J)V"); 
			global::android.os.Binder._flushPendingCommands5107 = @__env.GetStaticMethodID(global::android.os.Binder.staticClass, "flushPendingCommands", "()V"); 
			global::android.os.Binder._joinThreadPool5108 = @__env.GetStaticMethodID(global::android.os.Binder.staticClass, "joinThreadPool", "()V"); 
			global::android.os.Binder._attachInterface5109 = @__env.GetMethodID(global::android.os.Binder.staticClass, "attachInterface", "(Landroid/os/IInterface;Ljava/lang/String;)V"); 
			global::android.os.Binder._onTransact5110 = @__env.GetMethodID(global::android.os.Binder.staticClass, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z"); 
			global::android.os.Binder._Binder5111 = @__env.GetMethodID(global::android.os.Binder.staticClass, "<init>", "()V"); 
		} 
	} 
} 
