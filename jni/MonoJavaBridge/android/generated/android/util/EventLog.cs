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
			internal static global::MonoJavaBridge.MethodId _getData13685;
			public global::java.lang.Object getData() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.util.EventLog.Event._getData13685)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getData13685)) as java.lang.Object;
			}
			public new int Tag
			{
				get
				{
					return getTag();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTag13686;
			public int getTag() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.util.EventLog.Event._getTag13686);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getTag13686);
			}
			public new int ThreadId
			{
				get
				{
					return getThreadId();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getThreadId13687;
			public int getThreadId() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.util.EventLog.Event._getThreadId13687);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getThreadId13687);
			}
			public new int ProcessId
			{
				get
				{
					return getProcessId();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getProcessId13688;
			public int getProcessId() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.util.EventLog.Event._getProcessId13688);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getProcessId13688);
			}
			public new long TimeNanos
			{
				get
				{
					return getTimeNanos();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTimeNanos13689;
			public long getTimeNanos() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.util.EventLog.Event._getTimeNanos13689);
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.util.EventLog.Event.staticClass, global::android.util.EventLog.Event._getTimeNanos13689);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.util.EventLog.Event.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLog$Event"));
				global::android.util.EventLog.Event._getData13685 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.Event.staticClass, "getData", "()Ljava/lang/Object;");
				global::android.util.EventLog.Event._getTag13686 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.Event.staticClass, "getTag", "()I");
				global::android.util.EventLog.Event._getThreadId13687 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.Event.staticClass, "getThreadId", "()I");
				global::android.util.EventLog.Event._getProcessId13688 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.Event.staticClass, "getProcessId", "()I");
				global::android.util.EventLog.Event._getTimeNanos13689 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.Event.staticClass, "getTimeNanos", "()J");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTagName13690;
		public static global::java.lang.String getTagName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.EventLog.staticClass, global::android.util.EventLog._getTagName13690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeEvent13691;
		public static int writeEvent(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent13691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeEvent13692;
		public static int writeEvent(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent13692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeEvent13693;
		public static int writeEvent(int arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent13693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeEvent13694;
		public static int writeEvent(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._writeEvent13694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readEvents13695;
		public static void readEvents(int[] arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.util.EventLog.staticClass, global::android.util.EventLog._readEvents13695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTagCode13696;
		public static int getTagCode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.util.EventLog.staticClass, global::android.util.EventLog._getTagCode13696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _EventLog13697;
		public EventLog()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.EventLog.staticClass, global::android.util.EventLog._EventLog13697);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.EventLog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/EventLog"));
			global::android.util.EventLog._getTagName13690 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "getTagName", "(I)Ljava/lang/String;");
			global::android.util.EventLog._writeEvent13691 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(IJ)I");
			global::android.util.EventLog._writeEvent13692 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(ILjava/lang/String;)I");
			global::android.util.EventLog._writeEvent13693 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(I[Ljava/lang/Object;)I");
			global::android.util.EventLog._writeEvent13694 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "writeEvent", "(II)I");
			global::android.util.EventLog._readEvents13695 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "readEvents", "([ILjava/util/Collection;)V");
			global::android.util.EventLog._getTagCode13696 = @__env.GetStaticMethodIDNoThrow(global::android.util.EventLog.staticClass, "getTagCode", "(Ljava/lang/String;)I");
			global::android.util.EventLog._EventLog13697 = @__env.GetMethodIDNoThrow(global::android.util.EventLog.staticClass, "<init>", "()V");
		}
	}
}
