namespace android.os
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.os.FileObserver_))]
	public abstract partial class FileObserver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FileObserver()
		{
			InitJNI();
		}
		protected FileObserver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize6413;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.FileObserver._finalize6413);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.FileObserver.staticClass, global::android.os.FileObserver._finalize6413);
		}
		internal static global::MonoJavaBridge.MethodId _startWatching6414;
		public virtual void startWatching() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.FileObserver._startWatching6414);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.FileObserver.staticClass, global::android.os.FileObserver._startWatching6414);
		}
		internal static global::MonoJavaBridge.MethodId _stopWatching6415;
		public virtual void stopWatching() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.FileObserver._stopWatching6415);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.FileObserver.staticClass, global::android.os.FileObserver._stopWatching6415);
		}
		internal static global::MonoJavaBridge.MethodId _onEvent6416;
		public abstract void onEvent(int arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _FileObserver6417;
		public FileObserver(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.FileObserver.staticClass, global::android.os.FileObserver._FileObserver6417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FileObserver6418;
		public FileObserver(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.FileObserver.staticClass, global::android.os.FileObserver._FileObserver6418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.FileObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/FileObserver"));
			global::android.os.FileObserver._finalize6413 = @__env.GetMethodIDNoThrow(global::android.os.FileObserver.staticClass, "finalize", "()V");
			global::android.os.FileObserver._startWatching6414 = @__env.GetMethodIDNoThrow(global::android.os.FileObserver.staticClass, "startWatching", "()V");
			global::android.os.FileObserver._stopWatching6415 = @__env.GetMethodIDNoThrow(global::android.os.FileObserver.staticClass, "stopWatching", "()V");
			global::android.os.FileObserver._onEvent6416 = @__env.GetMethodIDNoThrow(global::android.os.FileObserver.staticClass, "onEvent", "(ILjava/lang/String;)V");
			global::android.os.FileObserver._FileObserver6417 = @__env.GetMethodIDNoThrow(global::android.os.FileObserver.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.os.FileObserver._FileObserver6418 = @__env.GetMethodIDNoThrow(global::android.os.FileObserver.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.FileObserver))]
	public sealed partial class FileObserver_ : android.os.FileObserver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FileObserver_()
		{
			InitJNI();
		}
		internal FileObserver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onEvent6419;
		public override void onEvent(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.FileObserver_._onEvent6419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.FileObserver_.staticClass, global::android.os.FileObserver_._onEvent6419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.FileObserver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/FileObserver"));
			global::android.os.FileObserver_._onEvent6419 = @__env.GetMethodIDNoThrow(global::android.os.FileObserver_.staticClass, "onEvent", "(ILjava/lang/String;)V");
		}
	}
}
