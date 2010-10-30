namespace android.os
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.IInterface_))]
	public partial interface IInterface  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.os.IBinder asBinder();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.IInterface))]
	internal sealed partial class IInterface_ : java.lang.Object, IInterface
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal IInterface_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _asBinder9911;
		global::android.os.IBinder android.os.IInterface.asBinder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.IInterface_._asBinder9911.native == global::System.IntPtr.Zero)
				global::android.os.IInterface_._asBinder9911 = @__env.GetMethodIDNoThrow(global::android.os.IInterface_.staticClass, "asBinder", "()Landroid/os/IBinder;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.IInterface_._asBinder9911)) as android.os.IBinder;
		}
		static IInterface_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.IInterface_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/IInterface"));
		}
		internal static void InitJNI()
		{
		}
	}

	public delegate android.os.IBinder IInterfaceDelegate();

	internal partial class IInterfaceDelegateWrapper : java.lang.Object, IInterface
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IInterfaceDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IInterfaceDelegateWrapper9912;
		public IInterfaceDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.IInterfaceDelegateWrapper._IInterfaceDelegateWrapper9912.native == global::System.IntPtr.Zero)
				global::android.os.IInterfaceDelegateWrapper._IInterfaceDelegateWrapper9912 = @__env.GetMethodIDNoThrow(global::android.os.IInterfaceDelegateWrapper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.IInterfaceDelegateWrapper.staticClass, global::android.os.IInterfaceDelegateWrapper._IInterfaceDelegateWrapper9912);
			Init(@__env, handle);
		}
		static IInterfaceDelegateWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.IInterfaceDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/IInterfaceDelegateWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
	internal partial class IInterfaceDelegateWrapper
	{
		private IInterfaceDelegate myDelegate;
		public android.os.IBinder asBinder()
		{
			return myDelegate();
		}
		public static implicit operator IInterfaceDelegateWrapper(IInterfaceDelegate d)
		{
			global::android.os.IInterfaceDelegateWrapper ret = new global::android.os.IInterfaceDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}
