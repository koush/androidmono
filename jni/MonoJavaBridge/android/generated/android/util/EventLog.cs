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
			internal static global::MonoJavaBridge.MethodId _getData13749;
			public global::java.lang.Object getData()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.EventLog.Event._getData13749)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getData13749)) as java.lang.Object;
			}
			public new int Tag
			{
				get
				{
					return getTag();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTag13750;
			public int getTag()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.util.EventLog.Event._getTag13750);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getTag13750);
			}
			public new int ThreadId
			{
				get
				{
					return getThreadId();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getThreadId13751;
			public int getThreadId()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.util.EventLog.Event._getThreadId13751);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getThreadId13751);
			}
			public new int ProcessId
			{
				get
				{
					return getProcessId();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getProcessId13752;
			public int getProcessId()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.util.EventLog.Event._getProcessId13752);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getProcessId13752);
			}
			public new long TimeNanos
			{
				get
				{
					return getTimeNanos();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTimeNanos13753;
			public long getTimeNanos()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.util.EventLog.Event._getTimeNanos13753);
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getTimeNanos13753);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.util.EventLog.Event.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLog$Event"));
				global::android.util.EventLog.Event._getData13749 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.Event.staticClass, "getData", "()Ljava/lang/Object;");
				global::android.util.EventLog.Event._getTag13750 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.Event.staticClass, "getTag", "()I");
				global::android.util.EventLog.Event._getThreadId13751 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.Event.staticClass, "getThreadId", "()I");
				global::android.util.EventLog.Event._getProcessId13752 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.Event.staticClass, "getProcessId", "()I");
				global::android.util.EventLog.Event._getTimeNanos13753 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.Event.staticClass, "getTimeNanos", "()J");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTagName13754;
		public static global::java.lang.String getTagName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.EventLog.staticClass, global::android.util.EventLog._getTagName13754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeEvent13755;
		public static int writeEvent(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent13755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeEvent13756;
		public static int writeEvent(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent13756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeEvent13757;
		public static int writeEvent(int arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent13757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeEvent13758;
		public static int writeEvent(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent13758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readEvents13759;
		public static void readEvents(int[] arg0, java.util.Collection arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.util.EventLog.staticClass, global::android.util.EventLog._readEvents13759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTagCode13760;
		public static int getTagCode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._getTagCode13760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _EventLog13761;
		public EventLog() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.EventLog.staticClass, global::android.util.EventLog._EventLog13761);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.EventLog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLog"));
			global::android.util.EventLog._getTagName13754 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "getTagName", "(I)Ljava/lang/String;");
			global::android.util.EventLog._writeEvent13755 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(IJ)I");
			global::android.util.EventLog._writeEvent13756 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(ILjava/lang/String;)I");
			global::android.util.EventLog._writeEvent13757 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(I[Ljava/lang/Object;)I");
			global::android.util.EventLog._writeEvent13758 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(II)I");
			global::android.util.EventLog._readEvents13759 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "readEvents", "([ILjava/util/Collection;)V");
			global::android.util.EventLog._getTagCode13760 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "getTagCode", "(Ljava/lang/String;)I");
			global::android.util.EventLog._EventLog13761 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.staticClass, "<init>", "()V");
		}
	}
}
