namespace android.os
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.os.FileObserver_))]
	public abstract partial class FileObserver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileObserver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.FileObserver.staticClass, "finalize", "()V", ref global::android.os.FileObserver._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void startWatching()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.FileObserver.staticClass, "startWatching", "()V", ref global::android.os.FileObserver._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void stopWatching()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.FileObserver.staticClass, "stopWatching", "()V", ref global::android.os.FileObserver._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void onEvent(int arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m4;
		public FileObserver(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.FileObserver._m4.native == global::System.IntPtr.Zero)
				global::android.os.FileObserver._m4 = @__env.GetMethodIDNoThrow(global::android.os.FileObserver.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.FileObserver.staticClass, global::android.os.FileObserver._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public FileObserver(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.FileObserver._m5.native == global::System.IntPtr.Zero)
				global::android.os.FileObserver._m5 = @__env.GetMethodIDNoThrow(global::android.os.FileObserver.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.FileObserver.staticClass, global::android.os.FileObserver._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override void onEvent(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.FileObserver_.staticClass, "onEvent", "(ILjava/lang/String;)V", ref global::android.os.FileObserver_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
