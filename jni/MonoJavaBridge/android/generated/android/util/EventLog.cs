namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EventLog : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EventLog()
		{
			InitJNI();
		}
		protected EventLog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Event : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Event()
			{
				InitJNI();
			}
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
			internal static global::MonoJavaBridge.MethodId _getData9045;
			public global::java.lang.Object getData() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.EventLog.Event._getData9045)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getData9045)) as java.lang.Object;
			}
			public new int Tag
			{
				get
				{
					return getTag();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTag9046;
			public int getTag() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.util.EventLog.Event._getTag9046);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getTag9046);
			}
			public new int ThreadId
			{
				get
				{
					return getThreadId();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getThreadId9047;
			public int getThreadId() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.util.EventLog.Event._getThreadId9047);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getThreadId9047);
			}
			public new int ProcessId
			{
				get
				{
					return getProcessId();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getProcessId9048;
			public int getProcessId() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.util.EventLog.Event._getProcessId9048);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getProcessId9048);
			}
			public new long TimeNanos
			{
				get
				{
					return getTimeNanos();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTimeNanos9049;
			public long getTimeNanos() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.util.EventLog.Event._getTimeNanos9049);
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getTimeNanos9049);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.util.EventLog.Event.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLog$Event"));
				global::android.util.EventLog.Event._getData9045 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.Event.staticClass, "getData", "()Ljava/lang/Object;");
				global::android.util.EventLog.Event._getTag9046 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.Event.staticClass, "getTag", "()I");
				global::android.util.EventLog.Event._getThreadId9047 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.Event.staticClass, "getThreadId", "()I");
				global::android.util.EventLog.Event._getProcessId9048 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.Event.staticClass, "getProcessId", "()I");
				global::android.util.EventLog.Event._getTimeNanos9049 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.Event.staticClass, "getTimeNanos", "()J");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTagName9050;
		public static global::java.lang.String getTagName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.EventLog.staticClass, global::android.util.EventLog._getTagName9050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeEvent9051;
		public static int writeEvent(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent9051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeEvent9052;
		public static int writeEvent(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent9052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeEvent9053;
		public static int writeEvent(int arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent9053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeEvent9054;
		public static int writeEvent(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent9054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readEvents9055;
		public static void readEvents(int[] arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.util.EventLog.staticClass, global::android.util.EventLog._readEvents9055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTagCode9056;
		public static int getTagCode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._getTagCode9056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _EventLog9057;
		public EventLog()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.EventLog.staticClass, global::android.util.EventLog._EventLog9057);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.EventLog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLog"));
			global::android.util.EventLog._getTagName9050 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "getTagName", "(I)Ljava/lang/String;");
			global::android.util.EventLog._writeEvent9051 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(IJ)I");
			global::android.util.EventLog._writeEvent9052 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(ILjava/lang/String;)I");
			global::android.util.EventLog._writeEvent9053 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(I[Ljava/lang/Object;)I");
			global::android.util.EventLog._writeEvent9054 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(II)I");
			global::android.util.EventLog._readEvents9055 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "readEvents", "([ILjava/util/Collection;)V");
			global::android.util.EventLog._getTagCode9056 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "getTagCode", "(Ljava/lang/String;)I");
			global::android.util.EventLog._EventLog9057 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.staticClass, "<init>", "()V");
		}
	}
}
