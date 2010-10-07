namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class Debug : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Debug()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Debug), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.os.Debug(@__env);
			}
		}
		internal Debug(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class InstructionCount : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static InstructionCount()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Debug.InstructionCount), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.os.Debug.InstructionCount(@__env);
				}
			}
			protected InstructionCount(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _resetAndStart6024;
			public virtual bool resetAndStart() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.os.Debug.InstructionCount._resetAndStart6024);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._resetAndStart6024);
			}
			internal static global::net.sf.jni4net.jni.MethodId _collect6025;
			public virtual bool collect() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.os.Debug.InstructionCount._collect6025);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._collect6025);
			}
			internal static global::net.sf.jni4net.jni.MethodId _globalTotal6026;
			public virtual int globalTotal() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.os.Debug.InstructionCount._globalTotal6026);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._globalTotal6026);
			}
			internal static global::net.sf.jni4net.jni.MethodId _globalMethodInvocations6027;
			public virtual int globalMethodInvocations() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.os.Debug.InstructionCount._globalMethodInvocations6027);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._globalMethodInvocations6027);
			}
			internal static global::net.sf.jni4net.jni.MethodId _InstructionCount6028;
			public InstructionCount()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._InstructionCount6028, this);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.os.Debug.InstructionCount.staticClass = @__class;
				global::android.os.Debug.InstructionCount._resetAndStart6024 = @__env.GetMethodID(global::android.os.Debug.InstructionCount.staticClass, "resetAndStart", "()Z");
				global::android.os.Debug.InstructionCount._collect6025 = @__env.GetMethodID(global::android.os.Debug.InstructionCount.staticClass, "collect", "()Z");
				global::android.os.Debug.InstructionCount._globalTotal6026 = @__env.GetMethodID(global::android.os.Debug.InstructionCount.staticClass, "globalTotal", "()I");
				global::android.os.Debug.InstructionCount._globalMethodInvocations6027 = @__env.GetMethodID(global::android.os.Debug.InstructionCount.staticClass, "globalMethodInvocations", "()I");
				global::android.os.Debug.InstructionCount._InstructionCount6028 = @__env.GetMethodID(global::android.os.Debug.InstructionCount.staticClass, "<init>", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class MemoryInfo : java.lang.Object, Parcelable
		{
			internal static global::java.lang.Class staticClass;
			static MemoryInfo()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Debug.MemoryInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.os.Debug.MemoryInfo(@__env);
				}
			}
			protected MemoryInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6029;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.os.Debug.MemoryInfo._writeToParcel6029, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._writeToParcel6029, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _describeContents6030;
			public virtual int describeContents() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.os.Debug.MemoryInfo._describeContents6030);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._describeContents6030);
			}
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel6031;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.os.Debug.MemoryInfo._readFromParcel6031, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._readFromParcel6031, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getTotalPss6032;
			public virtual int getTotalPss() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.os.Debug.MemoryInfo._getTotalPss6032);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._getTotalPss6032);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getTotalPrivateDirty6033;
			public virtual int getTotalPrivateDirty() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.os.Debug.MemoryInfo._getTotalPrivateDirty6033);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._getTotalPrivateDirty6033);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getTotalSharedDirty6034;
			public virtual int getTotalSharedDirty() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.os.Debug.MemoryInfo._getTotalSharedDirty6034);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._getTotalSharedDirty6034);
			}
			internal static global::net.sf.jni4net.jni.MethodId _MemoryInfo6035;
			public MemoryInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._MemoryInfo6035, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _dalvikPss6036;
			public int dalvikPss
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _dalvikPrivateDirty6037;
			public int dalvikPrivateDirty
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _dalvikSharedDirty6038;
			public int dalvikSharedDirty
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _nativePss6039;
			public int nativePss
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _nativePrivateDirty6040;
			public int nativePrivateDirty
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _nativeSharedDirty6041;
			public int nativeSharedDirty
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _otherPss6042;
			public int otherPss
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _otherPrivateDirty6043;
			public int otherPrivateDirty
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _otherSharedDirty6044;
			public int otherSharedDirty
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR6045;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.os.Debug.MemoryInfo.staticClass = @__class;
				global::android.os.Debug.MemoryInfo._writeToParcel6029 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.os.Debug.MemoryInfo._describeContents6030 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "describeContents", "()I");
				global::android.os.Debug.MemoryInfo._readFromParcel6031 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.os.Debug.MemoryInfo._getTotalPss6032 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "getTotalPss", "()I");
				global::android.os.Debug.MemoryInfo._getTotalPrivateDirty6033 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "getTotalPrivateDirty", "()I");
				global::android.os.Debug.MemoryInfo._getTotalSharedDirty6034 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "getTotalSharedDirty", "()I");
				global::android.os.Debug.MemoryInfo._MemoryInfo6035 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMemoryInfo6046;
		public static void getMemoryInfo(android.os.Debug.MemoryInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._getMemoryInfo6046, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _waitForDebugger6047;
		public static void waitForDebugger() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._waitForDebugger6047);
		}
		internal static global::net.sf.jni4net.jni.MethodId _waitingForDebugger6048;
		public static bool waitingForDebugger() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._waitingForDebugger6048);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDebuggerConnected6049;
		public static bool isDebuggerConnected() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._isDebuggerConnected6049);
		}
		internal static global::net.sf.jni4net.jni.MethodId _changeDebugPort6050;
		public static void changeDebugPort(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._changeDebugPort6050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startNativeTracing6051;
		public static void startNativeTracing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startNativeTracing6051);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopNativeTracing6052;
		public static void stopNativeTracing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._stopNativeTracing6052);
		}
		internal static global::net.sf.jni4net.jni.MethodId _enableEmulatorTraceOutput6053;
		public static void enableEmulatorTraceOutput() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._enableEmulatorTraceOutput6053);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startMethodTracing6054;
		public static void startMethodTracing(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing6054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startMethodTracing6055;
		public static void startMethodTracing(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing6055, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startMethodTracing6056;
		public static void startMethodTracing(java.lang.String arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing6056, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startMethodTracing6057;
		public static void startMethodTracing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing6057);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopMethodTracing6058;
		public static void stopMethodTracing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._stopMethodTracing6058);
		}
		internal static global::net.sf.jni4net.jni.MethodId _threadCpuTimeNanos6059;
		public static long threadCpuTimeNanos() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._threadCpuTimeNanos6059);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startAllocCounting6060;
		public static void startAllocCounting() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startAllocCounting6060);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopAllocCounting6061;
		public static void stopAllocCounting() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._stopAllocCounting6061);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalAllocCount6062;
		public static int getGlobalAllocCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalAllocCount6062);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalAllocSize6063;
		public static int getGlobalAllocSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalAllocSize6063);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalFreedCount6064;
		public static int getGlobalFreedCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalFreedCount6064);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalFreedSize6065;
		public static int getGlobalFreedSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalFreedSize6065);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalClassInitCount6066;
		public static int getGlobalClassInitCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalClassInitCount6066);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalClassInitTime6067;
		public static int getGlobalClassInitTime() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalClassInitTime6067);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalExternalAllocCount6068;
		public static int getGlobalExternalAllocCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalAllocCount6068);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalExternalAllocSize6069;
		public static int getGlobalExternalAllocSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalAllocSize6069);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalExternalFreedCount6070;
		public static int getGlobalExternalFreedCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalFreedCount6070);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalExternalFreedSize6071;
		public static int getGlobalExternalFreedSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalFreedSize6071);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalGcInvocationCount6072;
		public static int getGlobalGcInvocationCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalGcInvocationCount6072);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getThreadAllocCount6073;
		public static int getThreadAllocCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadAllocCount6073);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getThreadAllocSize6074;
		public static int getThreadAllocSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadAllocSize6074);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getThreadExternalAllocCount6075;
		public static int getThreadExternalAllocCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadExternalAllocCount6075);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getThreadExternalAllocSize6076;
		public static int getThreadExternalAllocSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadExternalAllocSize6076);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getThreadGcInvocationCount6077;
		public static int getThreadGcInvocationCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadGcInvocationCount6077);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalAllocCount6078;
		public static void resetGlobalAllocCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalAllocCount6078);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalAllocSize6079;
		public static void resetGlobalAllocSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalAllocSize6079);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalFreedCount6080;
		public static void resetGlobalFreedCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalFreedCount6080);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalFreedSize6081;
		public static void resetGlobalFreedSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalFreedSize6081);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalClassInitCount6082;
		public static void resetGlobalClassInitCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalClassInitCount6082);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalClassInitTime6083;
		public static void resetGlobalClassInitTime() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalClassInitTime6083);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalExternalAllocCount6084;
		public static void resetGlobalExternalAllocCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalAllocCount6084);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalExternalAllocSize6085;
		public static void resetGlobalExternalAllocSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalAllocSize6085);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalExternalFreedCount6086;
		public static void resetGlobalExternalFreedCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalFreedCount6086);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalExternalFreedSize6087;
		public static void resetGlobalExternalFreedSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalFreedSize6087);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalGcInvocationCount6088;
		public static void resetGlobalGcInvocationCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalGcInvocationCount6088);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetThreadAllocCount6089;
		public static void resetThreadAllocCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadAllocCount6089);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetThreadAllocSize6090;
		public static void resetThreadAllocSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadAllocSize6090);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetThreadExternalAllocCount6091;
		public static void resetThreadExternalAllocCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadExternalAllocCount6091);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetThreadExternalAllocSize6092;
		public static void resetThreadExternalAllocSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadExternalAllocSize6092);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetThreadGcInvocationCount6093;
		public static void resetThreadGcInvocationCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadGcInvocationCount6093);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetAllCounts6094;
		public static void resetAllCounts() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetAllCounts6094);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNativeHeapSize6095;
		public static long getNativeHeapSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._getNativeHeapSize6095);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNativeHeapAllocatedSize6096;
		public static long getNativeHeapAllocatedSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._getNativeHeapAllocatedSize6096);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNativeHeapFreeSize6097;
		public static long getNativeHeapFreeSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._getNativeHeapFreeSize6097);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAllocationLimit6098;
		public static int setAllocationLimit(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._setAllocationLimit6098, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGlobalAllocationLimit6099;
		public static int setGlobalAllocationLimit(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._setGlobalAllocationLimit6099, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _printLoadedClasses6100;
		public static void printLoadedClasses(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._printLoadedClasses6100, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLoadedClassCount6101;
		public static int getLoadedClassCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getLoadedClassCount6101);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpHprofData6102;
		public static void dumpHprofData(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._dumpHprofData6102, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBinderSentTransactions6103;
		public static int getBinderSentTransactions() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderSentTransactions6103);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBinderReceivedTransactions6104;
		public static int getBinderReceivedTransactions() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderReceivedTransactions6104);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBinderLocalObjectCount6105;
		public static int getBinderLocalObjectCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderLocalObjectCount6105);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBinderProxyObjectCount6106;
		public static int getBinderProxyObjectCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderProxyObjectCount6106);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBinderDeathObjectCount6107;
		public static int getBinderDeathObjectCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderDeathObjectCount6107);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpService6108;
		public static bool dumpService(java.lang.String arg0, java.io.FileDescriptor arg1, java.lang.String[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._dumpService6108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
		}
		public static int TRACE_COUNT_ALLOCS
		{
			get
			{
				return 1;
			}
		}
		public static int SHOW_FULL_DETAIL
		{
			get
			{
				return 1;
			}
		}
		public static int SHOW_CLASSLOADER
		{
			get
			{
				return 2;
			}
		}
		public static int SHOW_INITIALIZED
		{
			get
			{
				return 4;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.Debug.staticClass = @__class;
			global::android.os.Debug._getMemoryInfo6046 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getMemoryInfo", "(Landroid/os/Debug$MemoryInfo;)V");
			global::android.os.Debug._waitForDebugger6047 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "waitForDebugger", "()V");
			global::android.os.Debug._waitingForDebugger6048 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "waitingForDebugger", "()Z");
			global::android.os.Debug._isDebuggerConnected6049 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "isDebuggerConnected", "()Z");
			global::android.os.Debug._changeDebugPort6050 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "changeDebugPort", "(I)V");
			global::android.os.Debug._startNativeTracing6051 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startNativeTracing", "()V");
			global::android.os.Debug._stopNativeTracing6052 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "stopNativeTracing", "()V");
			global::android.os.Debug._enableEmulatorTraceOutput6053 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "enableEmulatorTraceOutput", "()V");
			global::android.os.Debug._startMethodTracing6054 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;)V");
			global::android.os.Debug._startMethodTracing6055 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;I)V");
			global::android.os.Debug._startMethodTracing6056 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;II)V");
			global::android.os.Debug._startMethodTracing6057 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startMethodTracing", "()V");
			global::android.os.Debug._stopMethodTracing6058 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "stopMethodTracing", "()V");
			global::android.os.Debug._threadCpuTimeNanos6059 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "threadCpuTimeNanos", "()J");
			global::android.os.Debug._startAllocCounting6060 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startAllocCounting", "()V");
			global::android.os.Debug._stopAllocCounting6061 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "stopAllocCounting", "()V");
			global::android.os.Debug._getGlobalAllocCount6062 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalAllocCount", "()I");
			global::android.os.Debug._getGlobalAllocSize6063 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalAllocSize", "()I");
			global::android.os.Debug._getGlobalFreedCount6064 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalFreedCount", "()I");
			global::android.os.Debug._getGlobalFreedSize6065 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalFreedSize", "()I");
			global::android.os.Debug._getGlobalClassInitCount6066 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalClassInitCount", "()I");
			global::android.os.Debug._getGlobalClassInitTime6067 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalClassInitTime", "()I");
			global::android.os.Debug._getGlobalExternalAllocCount6068 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalExternalAllocCount", "()I");
			global::android.os.Debug._getGlobalExternalAllocSize6069 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalExternalAllocSize", "()I");
			global::android.os.Debug._getGlobalExternalFreedCount6070 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalExternalFreedCount", "()I");
			global::android.os.Debug._getGlobalExternalFreedSize6071 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalExternalFreedSize", "()I");
			global::android.os.Debug._getGlobalGcInvocationCount6072 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalGcInvocationCount", "()I");
			global::android.os.Debug._getThreadAllocCount6073 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getThreadAllocCount", "()I");
			global::android.os.Debug._getThreadAllocSize6074 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getThreadAllocSize", "()I");
			global::android.os.Debug._getThreadExternalAllocCount6075 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getThreadExternalAllocCount", "()I");
			global::android.os.Debug._getThreadExternalAllocSize6076 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getThreadExternalAllocSize", "()I");
			global::android.os.Debug._getThreadGcInvocationCount6077 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getThreadGcInvocationCount", "()I");
			global::android.os.Debug._resetGlobalAllocCount6078 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalAllocCount", "()V");
			global::android.os.Debug._resetGlobalAllocSize6079 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalAllocSize", "()V");
			global::android.os.Debug._resetGlobalFreedCount6080 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalFreedCount", "()V");
			global::android.os.Debug._resetGlobalFreedSize6081 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalFreedSize", "()V");
			global::android.os.Debug._resetGlobalClassInitCount6082 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalClassInitCount", "()V");
			global::android.os.Debug._resetGlobalClassInitTime6083 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalClassInitTime", "()V");
			global::android.os.Debug._resetGlobalExternalAllocCount6084 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalExternalAllocCount", "()V");
			global::android.os.Debug._resetGlobalExternalAllocSize6085 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalExternalAllocSize", "()V");
			global::android.os.Debug._resetGlobalExternalFreedCount6086 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalExternalFreedCount", "()V");
			global::android.os.Debug._resetGlobalExternalFreedSize6087 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalExternalFreedSize", "()V");
			global::android.os.Debug._resetGlobalGcInvocationCount6088 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalGcInvocationCount", "()V");
			global::android.os.Debug._resetThreadAllocCount6089 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetThreadAllocCount", "()V");
			global::android.os.Debug._resetThreadAllocSize6090 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetThreadAllocSize", "()V");
			global::android.os.Debug._resetThreadExternalAllocCount6091 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetThreadExternalAllocCount", "()V");
			global::android.os.Debug._resetThreadExternalAllocSize6092 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetThreadExternalAllocSize", "()V");
			global::android.os.Debug._resetThreadGcInvocationCount6093 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetThreadGcInvocationCount", "()V");
			global::android.os.Debug._resetAllCounts6094 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetAllCounts", "()V");
			global::android.os.Debug._getNativeHeapSize6095 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getNativeHeapSize", "()J");
			global::android.os.Debug._getNativeHeapAllocatedSize6096 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getNativeHeapAllocatedSize", "()J");
			global::android.os.Debug._getNativeHeapFreeSize6097 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getNativeHeapFreeSize", "()J");
			global::android.os.Debug._setAllocationLimit6098 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "setAllocationLimit", "(I)I");
			global::android.os.Debug._setGlobalAllocationLimit6099 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "setGlobalAllocationLimit", "(I)I");
			global::android.os.Debug._printLoadedClasses6100 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "printLoadedClasses", "(I)V");
			global::android.os.Debug._getLoadedClassCount6101 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getLoadedClassCount", "()I");
			global::android.os.Debug._dumpHprofData6102 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "dumpHprofData", "(Ljava/lang/String;)V");
			global::android.os.Debug._getBinderSentTransactions6103 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getBinderSentTransactions", "()I");
			global::android.os.Debug._getBinderReceivedTransactions6104 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getBinderReceivedTransactions", "()I");
			global::android.os.Debug._getBinderLocalObjectCount6105 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getBinderLocalObjectCount", "()I");
			global::android.os.Debug._getBinderProxyObjectCount6106 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getBinderProxyObjectCount", "()I");
			global::android.os.Debug._getBinderDeathObjectCount6107 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getBinderDeathObjectCount", "()I");
			global::android.os.Debug._dumpService6108 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "dumpService", "(Ljava/lang/String;Ljava/io/FileDescriptor;[Ljava/lang/String;)Z");
		}
	}
}
