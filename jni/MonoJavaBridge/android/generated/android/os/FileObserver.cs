namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class FileObserver : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static FileObserver()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.FileObserver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected FileObserver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _startWatching6145;
		public virtual void startWatching() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.FileObserver._startWatching6145);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.FileObserver.staticClass, global::android.os.FileObserver._startWatching6145);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopWatching6146;
		public virtual void stopWatching() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.FileObserver._stopWatching6146);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.FileObserver.staticClass, global::android.os.FileObserver._stopWatching6146);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onEvent6147;
		public abstract void onEvent(int arg0, java.lang.String arg1);
		internal static global::net.sf.jni4net.jni.MethodId _FileObserver6148;
		public FileObserver(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.FileObserver.staticClass, global::android.os.FileObserver._FileObserver6148, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _FileObserver6149;
		public FileObserver(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.FileObserver.staticClass, global::android.os.FileObserver._FileObserver6149, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.FileObserver.staticClass = @__class;
			global::android.os.FileObserver._startWatching6145 = @__env.GetMethodID(global::android.os.FileObserver.staticClass, "startWatching", "()V");
			global::android.os.FileObserver._stopWatching6146 = @__env.GetMethodID(global::android.os.FileObserver.staticClass, "stopWatching", "()V");
			global::android.os.FileObserver._onEvent6147 = @__env.GetMethodID(global::android.os.FileObserver.staticClass, "onEvent", "(ILjava/lang/String;)V");
			global::android.os.FileObserver._FileObserver6148 = @__env.GetMethodID(global::android.os.FileObserver.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.os.FileObserver._FileObserver6149 = @__env.GetMethodID(global::android.os.FileObserver.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}
}
