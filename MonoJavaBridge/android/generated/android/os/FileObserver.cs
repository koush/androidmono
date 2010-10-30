namespace android.os
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.os.FileObserver_))]
	public abstract partial class FileObserver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileObserver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize9833;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.FileObserver._finalize9833.native == global::System.IntPtr.Zero)
				global::android.os.FileObserver._finalize9833 = @__env.GetMethodIDNoThrow(global::android.os.FileObserver.staticClass, "finalize", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.FileObserver.staticClass, global::android.os.FileObserver._finalize9833);
		}
		internal static global::MonoJavaBridge.MethodId _startWatching9834;
		public virtual void startWatching()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.FileObserver._startWatching9834.native == global::System.IntPtr.Zero)
				global::android.os.FileObserver._startWatching9834 = @__env.GetMethodIDNoThrow(global::android.os.FileObserver.staticClass, "startWatching", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.FileObserver.staticClass, global::android.os.FileObserver._startWatching9834);
		}
		internal static global::MonoJavaBridge.MethodId _stopWatching9835;
		public virtual void stopWatching()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.FileObserver._stopWatching9835.native == global::System.IntPtr.Zero)
				global::android.os.FileObserver._stopWatching9835 = @__env.GetMethodIDNoThrow(global::android.os.FileObserver.staticClass, "stopWatching", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.FileObserver.staticClass, global::android.os.FileObserver._stopWatching9835);
		}
		internal static global::MonoJavaBridge.MethodId _onEvent9836;
		public abstract void onEvent(int arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _FileObserver9837;
		public FileObserver(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.FileObserver._FileObserver9837.native == global::System.IntPtr.Zero)
				global::android.os.FileObserver._FileObserver9837 = @__env.GetMethodIDNoThrow(global::android.os.FileObserver.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.FileObserver.staticClass, global::android.os.FileObserver._FileObserver9837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileObserver9838;
		public FileObserver(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.FileObserver._FileObserver9838.native == global::System.IntPtr.Zero)
				global::android.os.FileObserver._FileObserver9838 = @__env.GetMethodIDNoThrow(global::android.os.FileObserver.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.FileObserver.staticClass, global::android.os.FileObserver._FileObserver9838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int ACCESS
		{
			get
			{
				return 1;
			}
		}
		public static int MODIFY
		{
			get
			{
				return 2;
			}
		}
		public static int ATTRIB
		{
			get
			{
				return 4;
			}
		}
		public static int CLOSE_WRITE
		{
			get
			{
				return 8;
			}
		}
		public static int CLOSE_NOWRITE
		{
			get
			{
				return 16;
			}
		}
		public static int OPEN
		{
			get
			{
				return 32;
			}
		}
		public static int MOVED_FROM
		{
			get
			{
				return 64;
			}
		}
		public static int MOVED_TO
		{
			get
			{
				return 128;
			}
		}
		public static int CREATE
		{
			get
			{
				return 256;
			}
		}
		public static int DELETE
		{
			get
			{
				return 512;
			}
		}
		public static int DELETE_SELF
		{
			get
			{
				return 1024;
			}
		}
		public static int MOVE_SELF
		{
			get
			{
				return 2048;
			}
		}
		public static int ALL_EVENTS
		{
			get
			{
				return 4095;
			}
		}
		static FileObserver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.FileObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/FileObserver"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.FileObserver))]
	internal sealed partial class FileObserver_ : android.os.FileObserver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FileObserver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onEvent9852;
		public override void onEvent(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.FileObserver_._onEvent9852.native == global::System.IntPtr.Zero)
				global::android.os.FileObserver_._onEvent9852 = @__env.GetMethodIDNoThrow(global::android.os.FileObserver_.staticClass, "onEvent", "(ILjava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.os.FileObserver_._onEvent9852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static FileObserver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.FileObserver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/FileObserver"));
		}
		internal static void InitJNI()
		{
		}
	}
}
