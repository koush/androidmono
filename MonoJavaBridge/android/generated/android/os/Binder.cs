namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Binder : java.lang.Object, IBinder
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Binder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Binder.staticClass, "finalize", "()V", ref global::android.os.Binder._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected virtual void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Binder.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", ref global::android.os.Binder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void dump(java.io.FileDescriptor arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Binder.staticClass, "dump", "(Ljava/io/FileDescriptor;[Ljava/lang/String;)V", ref global::android.os.Binder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String InterfaceDescriptor
		{
			get
			{
				return getInterfaceDescriptor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getInterfaceDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.Binder.staticClass, "getInterfaceDescriptor", "()Ljava/lang/String;", ref global::android.os.Binder._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool pingBinder()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Binder.staticClass, "pingBinder", "()Z", ref global::android.os.Binder._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isBinderAlive()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Binder.staticClass, "isBinderAlive", "()Z", ref global::android.os.Binder._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.os.IInterface queryLocalInterface(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IInterface>(this, global::android.os.Binder.staticClass, "queryLocalInterface", "(Ljava/lang/String;)Landroid/os/IInterface;", ref global::android.os.Binder._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.IInterface;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool transact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Binder.staticClass, "transact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", ref global::android.os.Binder._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void linkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Binder.staticClass, "linkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)V", ref global::android.os.Binder._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void linkToDeath(global::android.os.IBinder_DeathRecipientDelegate arg0, int arg1)
		{
			linkToDeath((global::android.os.IBinder_DeathRecipientDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool unlinkToDeath(android.os.IBinder_DeathRecipient arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Binder.staticClass, "unlinkToDeath", "(Landroid/os/IBinder$DeathRecipient;I)Z", ref global::android.os.Binder._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool unlinkToDeath(global::android.os.IBinder_DeathRecipientDelegate arg0, int arg1)
		{
			return unlinkToDeath((global::android.os.IBinder_DeathRecipientDelegateWrapper)arg0, arg1);
		}
		public static int CallingPid
		{
			get
			{
				return getCallingPid();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static int getCallingPid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Binder._m10.native == global::System.IntPtr.Zero)
				global::android.os.Binder._m10 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "getCallingPid", "()I");
			return @__env.CallStaticIntMethod(android.os.Binder.staticClass, global::android.os.Binder._m10);
		}
		public static int CallingUid
		{
			get
			{
				return getCallingUid();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static int getCallingUid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Binder._m11.native == global::System.IntPtr.Zero)
				global::android.os.Binder._m11 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "getCallingUid", "()I");
			return @__env.CallStaticIntMethod(android.os.Binder.staticClass, global::android.os.Binder._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static long clearCallingIdentity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Binder._m12.native == global::System.IntPtr.Zero)
				global::android.os.Binder._m12 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "clearCallingIdentity", "()J");
			return @__env.CallStaticLongMethod(android.os.Binder.staticClass, global::android.os.Binder._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static void restoreCallingIdentity(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Binder._m13.native == global::System.IntPtr.Zero)
				global::android.os.Binder._m13 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "restoreCallingIdentity", "(J)V");
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, global::android.os.Binder._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static void flushPendingCommands()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Binder._m14.native == global::System.IntPtr.Zero)
				global::android.os.Binder._m14 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "flushPendingCommands", "()V");
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, global::android.os.Binder._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static void joinThreadPool()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Binder._m15.native == global::System.IntPtr.Zero)
				global::android.os.Binder._m15 = @__env.GetStaticMethodIDNoThrow(global::android.os.Binder.staticClass, "joinThreadPool", "()V");
			@__env.CallStaticVoidMethod(android.os.Binder.staticClass, global::android.os.Binder._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void attachInterface(android.os.IInterface arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Binder.staticClass, "attachInterface", "(Landroid/os/IInterface;Ljava/lang/String;)V", ref global::android.os.Binder._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void attachInterface(global::android.os.IInterfaceDelegate arg0, java.lang.String arg1)
		{
			attachInterface((global::android.os.IInterfaceDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected virtual bool onTransact(int arg0, android.os.Parcel arg1, android.os.Parcel arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Binder.staticClass, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", ref global::android.os.Binder._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public Binder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Binder._m18.native == global::System.IntPtr.Zero)
				global::android.os.Binder._m18 = @__env.GetMethodIDNoThrow(global::android.os.Binder.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Binder.staticClass, global::android.os.Binder._m18);
			Init(@__env, handle);
		}
		static Binder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Binder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Binder"));
		}
		internal static void InitJNI()
		{
		}
	}
}
