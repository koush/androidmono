namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EventLog : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EventLog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Event : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Event(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public new global::java.lang.Object Data
			{
				get
				{
					return getData();
				}
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public global::java.lang.Object getData()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.util.EventLog.Event.staticClass, "getData", "()Ljava/lang/Object;", ref global::android.util.EventLog.Event._m0) as java.lang.Object;
			}
			public new int Tag
			{
				get
				{
					return getTag();
				}
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public int getTag()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.EventLog.Event.staticClass, "getTag", "()I", ref global::android.util.EventLog.Event._m1);
			}
			public new int ThreadId
			{
				get
				{
					return getThreadId();
				}
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public int getThreadId()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.EventLog.Event.staticClass, "getThreadId", "()I", ref global::android.util.EventLog.Event._m2);
			}
			public new int ProcessId
			{
				get
				{
					return getProcessId();
				}
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public int getProcessId()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.util.EventLog.Event.staticClass, "getProcessId", "()I", ref global::android.util.EventLog.Event._m3);
			}
			public new long TimeNanos
			{
				get
				{
					return getTimeNanos();
				}
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public long getTimeNanos()
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.util.EventLog.Event.staticClass, "getTimeNanos", "()J", ref global::android.util.EventLog.Event._m4);
			}
			static Event()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.util.EventLog.Event.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLog$Event"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.String getTagName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.EventLog._m0.native == global::System.IntPtr.Zero)
				global::android.util.EventLog._m0 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "getTagName", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.EventLog.staticClass, global::android.util.EventLog._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int writeEvent(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.EventLog._m1.native == global::System.IntPtr.Zero)
				global::android.util.EventLog._m1 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(IJ)I");
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static int writeEvent(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.EventLog._m2.native == global::System.IntPtr.Zero)
				global::android.util.EventLog._m2 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(ILjava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static int writeEvent(int arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.EventLog._m3.native == global::System.IntPtr.Zero)
				global::android.util.EventLog._m3 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(I[Ljava/lang/Object;)I");
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int writeEvent(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.EventLog._m4.native == global::System.IntPtr.Zero)
				global::android.util.EventLog._m4 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(II)I");
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void readEvents(int[] arg0, java.util.Collection arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.EventLog._m5.native == global::System.IntPtr.Zero)
				global::android.util.EventLog._m5 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "readEvents", "([ILjava/util/Collection;)V");
			@__env.CallStaticVoidMethod(android.util.EventLog.staticClass, global::android.util.EventLog._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static int getTagCode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.EventLog._m6.native == global::System.IntPtr.Zero)
				global::android.util.EventLog._m6 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "getTagCode", "(Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public EventLog() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.EventLog._m7.native == global::System.IntPtr.Zero)
				global::android.util.EventLog._m7 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.EventLog.staticClass, global::android.util.EventLog._m7);
			Init(@__env, handle);
		}
		static EventLog()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.EventLog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLog"));
		}
		internal static void InitJNI()
		{
		}
	}
}
