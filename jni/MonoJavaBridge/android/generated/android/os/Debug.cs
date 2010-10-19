namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Debug : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Debug()
		{
			InitJNI();
		}
		internal Debug(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class InstructionCount : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static InstructionCount()
			{
				InitJNI();
			}
			protected InstructionCount(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _resetAndStart6292;
			public virtual bool resetAndStart() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Debug.InstructionCount._resetAndStart6292);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._resetAndStart6292);
			}
			internal static global::MonoJavaBridge.MethodId _collect6293;
			public virtual bool collect() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Debug.InstructionCount._collect6293);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._collect6293);
			}
			internal static global::MonoJavaBridge.MethodId _globalTotal6294;
			public virtual int globalTotal() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.os.Debug.InstructionCount._globalTotal6294);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._globalTotal6294);
			}
			internal static global::MonoJavaBridge.MethodId _globalMethodInvocations6295;
			public virtual int globalMethodInvocations() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.os.Debug.InstructionCount._globalMethodInvocations6295);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._globalMethodInvocations6295);
			}
			internal static global::MonoJavaBridge.MethodId _InstructionCount6296;
			public InstructionCount()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._InstructionCount6296);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Debug.InstructionCount.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Debug$InstructionCount"));
				global::android.os.Debug.InstructionCount._resetAndStart6292 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "resetAndStart", "()Z");
				global::android.os.Debug.InstructionCount._collect6293 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "collect", "()Z");
				global::android.os.Debug.InstructionCount._globalTotal6294 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "globalTotal", "()I");
				global::android.os.Debug.InstructionCount._globalMethodInvocations6295 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "globalMethodInvocations", "()I");
				global::android.os.Debug.InstructionCount._InstructionCount6296 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MemoryInfo : java.lang.Object, Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static MemoryInfo()
			{
				InitJNI();
			}
			protected MemoryInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel6297;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo._writeToParcel6297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._writeToParcel6297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents6298;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo._describeContents6298);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._describeContents6298);
			}
			internal static global::MonoJavaBridge.MethodId _readFromParcel6299;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo._readFromParcel6299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._readFromParcel6299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int TotalPss
			{
				get
				{
					return getTotalPss();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTotalPss6300;
			public virtual int getTotalPss() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo._getTotalPss6300);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._getTotalPss6300);
			}
			public new int TotalPrivateDirty
			{
				get
				{
					return getTotalPrivateDirty();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTotalPrivateDirty6301;
			public virtual int getTotalPrivateDirty() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo._getTotalPrivateDirty6301);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._getTotalPrivateDirty6301);
			}
			public new int TotalSharedDirty
			{
				get
				{
					return getTotalSharedDirty();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTotalSharedDirty6302;
			public virtual int getTotalSharedDirty() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo._getTotalSharedDirty6302);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._getTotalSharedDirty6302);
			}
			internal static global::MonoJavaBridge.MethodId _MemoryInfo6303;
			public MemoryInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._MemoryInfo6303);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _dalvikPss6304;
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
			internal static global::MonoJavaBridge.FieldId _dalvikPrivateDirty6305;
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
			internal static global::MonoJavaBridge.FieldId _dalvikSharedDirty6306;
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
			internal static global::MonoJavaBridge.FieldId _nativePss6307;
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
			internal static global::MonoJavaBridge.FieldId _nativePrivateDirty6308;
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
			internal static global::MonoJavaBridge.FieldId _nativeSharedDirty6309;
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
			internal static global::MonoJavaBridge.FieldId _otherPss6310;
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
			internal static global::MonoJavaBridge.FieldId _otherPrivateDirty6311;
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
			internal static global::MonoJavaBridge.FieldId _otherSharedDirty6312;
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
			internal static global::MonoJavaBridge.FieldId _CREATOR6313;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Debug.MemoryInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Debug$MemoryInfo"));
				global::android.os.Debug.MemoryInfo._writeToParcel6297 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.os.Debug.MemoryInfo._describeContents6298 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "describeContents", "()I");
				global::android.os.Debug.MemoryInfo._readFromParcel6299 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.os.Debug.MemoryInfo._getTotalPss6300 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "getTotalPss", "()I");
				global::android.os.Debug.MemoryInfo._getTotalPrivateDirty6301 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "getTotalPrivateDirty", "()I");
				global::android.os.Debug.MemoryInfo._getTotalSharedDirty6302 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "getTotalSharedDirty", "()I");
				global::android.os.Debug.MemoryInfo._MemoryInfo6303 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMemoryInfo6314;
		public static void getMemoryInfo(android.os.Debug.MemoryInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._getMemoryInfo6314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _waitForDebugger6315;
		public static void waitForDebugger() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._waitForDebugger6315);
		}
		internal static global::MonoJavaBridge.MethodId _waitingForDebugger6316;
		public static bool waitingForDebugger() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._waitingForDebugger6316);
		}
		internal static global::MonoJavaBridge.MethodId _isDebuggerConnected6317;
		public static bool isDebuggerConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._isDebuggerConnected6317);
		}
		internal static global::MonoJavaBridge.MethodId _changeDebugPort6318;
		public static void changeDebugPort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._changeDebugPort6318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startNativeTracing6319;
		public static void startNativeTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startNativeTracing6319);
		}
		internal static global::MonoJavaBridge.MethodId _stopNativeTracing6320;
		public static void stopNativeTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._stopNativeTracing6320);
		}
		internal static global::MonoJavaBridge.MethodId _enableEmulatorTraceOutput6321;
		public static void enableEmulatorTraceOutput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._enableEmulatorTraceOutput6321);
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing6322;
		public static void startMethodTracing(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing6322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing6323;
		public static void startMethodTracing(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing6323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing6324;
		public static void startMethodTracing(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing6324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing6325;
		public static void startMethodTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing6325);
		}
		internal static global::MonoJavaBridge.MethodId _stopMethodTracing6326;
		public static void stopMethodTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._stopMethodTracing6326);
		}
		internal static global::MonoJavaBridge.MethodId _threadCpuTimeNanos6327;
		public static long threadCpuTimeNanos() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._threadCpuTimeNanos6327);
		}
		internal static global::MonoJavaBridge.MethodId _startAllocCounting6328;
		public static void startAllocCounting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startAllocCounting6328);
		}
		internal static global::MonoJavaBridge.MethodId _stopAllocCounting6329;
		public static void stopAllocCounting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._stopAllocCounting6329);
		}
		public static int GlobalAllocCount
		{
			get
			{
				return getGlobalAllocCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalAllocCount6330;
		public static int getGlobalAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalAllocCount6330);
		}
		public static int GlobalAllocSize
		{
			get
			{
				return getGlobalAllocSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalAllocSize6331;
		public static int getGlobalAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalAllocSize6331);
		}
		public static int GlobalFreedCount
		{
			get
			{
				return getGlobalFreedCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalFreedCount6332;
		public static int getGlobalFreedCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalFreedCount6332);
		}
		public static int GlobalFreedSize
		{
			get
			{
				return getGlobalFreedSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalFreedSize6333;
		public static int getGlobalFreedSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalFreedSize6333);
		}
		public static int GlobalClassInitCount
		{
			get
			{
				return getGlobalClassInitCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalClassInitCount6334;
		public static int getGlobalClassInitCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalClassInitCount6334);
		}
		public static int GlobalClassInitTime
		{
			get
			{
				return getGlobalClassInitTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalClassInitTime6335;
		public static int getGlobalClassInitTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalClassInitTime6335);
		}
		public static int GlobalExternalAllocCount
		{
			get
			{
				return getGlobalExternalAllocCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalExternalAllocCount6336;
		public static int getGlobalExternalAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalAllocCount6336);
		}
		public static int GlobalExternalAllocSize
		{
			get
			{
				return getGlobalExternalAllocSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalExternalAllocSize6337;
		public static int getGlobalExternalAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalAllocSize6337);
		}
		public static int GlobalExternalFreedCount
		{
			get
			{
				return getGlobalExternalFreedCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalExternalFreedCount6338;
		public static int getGlobalExternalFreedCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalFreedCount6338);
		}
		public static int GlobalExternalFreedSize
		{
			get
			{
				return getGlobalExternalFreedSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalExternalFreedSize6339;
		public static int getGlobalExternalFreedSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalFreedSize6339);
		}
		public static int GlobalGcInvocationCount
		{
			get
			{
				return getGlobalGcInvocationCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalGcInvocationCount6340;
		public static int getGlobalGcInvocationCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalGcInvocationCount6340);
		}
		public static int ThreadAllocCount
		{
			get
			{
				return getThreadAllocCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadAllocCount6341;
		public static int getThreadAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadAllocCount6341);
		}
		public static int ThreadAllocSize
		{
			get
			{
				return getThreadAllocSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadAllocSize6342;
		public static int getThreadAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadAllocSize6342);
		}
		public static int ThreadExternalAllocCount
		{
			get
			{
				return getThreadExternalAllocCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadExternalAllocCount6343;
		public static int getThreadExternalAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadExternalAllocCount6343);
		}
		public static int ThreadExternalAllocSize
		{
			get
			{
				return getThreadExternalAllocSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadExternalAllocSize6344;
		public static int getThreadExternalAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadExternalAllocSize6344);
		}
		public static int ThreadGcInvocationCount
		{
			get
			{
				return getThreadGcInvocationCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadGcInvocationCount6345;
		public static int getThreadGcInvocationCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadGcInvocationCount6345);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalAllocCount6346;
		public static void resetGlobalAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalAllocCount6346);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalAllocSize6347;
		public static void resetGlobalAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalAllocSize6347);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalFreedCount6348;
		public static void resetGlobalFreedCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalFreedCount6348);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalFreedSize6349;
		public static void resetGlobalFreedSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalFreedSize6349);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalClassInitCount6350;
		public static void resetGlobalClassInitCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalClassInitCount6350);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalClassInitTime6351;
		public static void resetGlobalClassInitTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalClassInitTime6351);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalExternalAllocCount6352;
		public static void resetGlobalExternalAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalAllocCount6352);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalExternalAllocSize6353;
		public static void resetGlobalExternalAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalAllocSize6353);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalExternalFreedCount6354;
		public static void resetGlobalExternalFreedCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalFreedCount6354);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalExternalFreedSize6355;
		public static void resetGlobalExternalFreedSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalFreedSize6355);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalGcInvocationCount6356;
		public static void resetGlobalGcInvocationCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalGcInvocationCount6356);
		}
		internal static global::MonoJavaBridge.MethodId _resetThreadAllocCount6357;
		public static void resetThreadAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadAllocCount6357);
		}
		internal static global::MonoJavaBridge.MethodId _resetThreadAllocSize6358;
		public static void resetThreadAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadAllocSize6358);
		}
		internal static global::MonoJavaBridge.MethodId _resetThreadExternalAllocCount6359;
		public static void resetThreadExternalAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadExternalAllocCount6359);
		}
		internal static global::MonoJavaBridge.MethodId _resetThreadExternalAllocSize6360;
		public static void resetThreadExternalAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadExternalAllocSize6360);
		}
		internal static global::MonoJavaBridge.MethodId _resetThreadGcInvocationCount6361;
		public static void resetThreadGcInvocationCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadGcInvocationCount6361);
		}
		internal static global::MonoJavaBridge.MethodId _resetAllCounts6362;
		public static void resetAllCounts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetAllCounts6362);
		}
		public static long NativeHeapSize
		{
			get
			{
				return getNativeHeapSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNativeHeapSize6363;
		public static long getNativeHeapSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._getNativeHeapSize6363);
		}
		public static long NativeHeapAllocatedSize
		{
			get
			{
				return getNativeHeapAllocatedSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNativeHeapAllocatedSize6364;
		public static long getNativeHeapAllocatedSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._getNativeHeapAllocatedSize6364);
		}
		public static long NativeHeapFreeSize
		{
			get
			{
				return getNativeHeapFreeSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNativeHeapFreeSize6365;
		public static long getNativeHeapFreeSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._getNativeHeapFreeSize6365);
		}
		internal static global::MonoJavaBridge.MethodId _setAllocationLimit6366;
		public static int setAllocationLimit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._setAllocationLimit6366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGlobalAllocationLimit6367;
		public static int setGlobalAllocationLimit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._setGlobalAllocationLimit6367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _printLoadedClasses6368;
		public static void printLoadedClasses(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._printLoadedClasses6368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int LoadedClassCount
		{
			get
			{
				return getLoadedClassCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoadedClassCount6369;
		public static int getLoadedClassCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getLoadedClassCount6369);
		}
		internal static global::MonoJavaBridge.MethodId _dumpHprofData6370;
		public static void dumpHprofData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._dumpHprofData6370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int BinderSentTransactions
		{
			get
			{
				return getBinderSentTransactions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderSentTransactions6371;
		public static int getBinderSentTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderSentTransactions6371);
		}
		public static int BinderReceivedTransactions
		{
			get
			{
				return getBinderReceivedTransactions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderReceivedTransactions6372;
		public static int getBinderReceivedTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderReceivedTransactions6372);
		}
		public static int BinderLocalObjectCount
		{
			get
			{
				return getBinderLocalObjectCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderLocalObjectCount6373;
		public static int getBinderLocalObjectCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderLocalObjectCount6373);
		}
		public static int BinderProxyObjectCount
		{
			get
			{
				return getBinderProxyObjectCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderProxyObjectCount6374;
		public static int getBinderProxyObjectCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderProxyObjectCount6374);
		}
		public static int BinderDeathObjectCount
		{
			get
			{
				return getBinderDeathObjectCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderDeathObjectCount6375;
		public static int getBinderDeathObjectCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderDeathObjectCount6375);
		}
		internal static global::MonoJavaBridge.MethodId _dumpService6376;
		public static bool dumpService(java.lang.String arg0, java.io.FileDescriptor arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._dumpService6376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Debug.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Debug"));
			global::android.os.Debug._getMemoryInfo6314 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getMemoryInfo", "(Landroid/os/Debug$MemoryInfo;)V");
			global::android.os.Debug._waitForDebugger6315 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "waitForDebugger", "()V");
			global::android.os.Debug._waitingForDebugger6316 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "waitingForDebugger", "()Z");
			global::android.os.Debug._isDebuggerConnected6317 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "isDebuggerConnected", "()Z");
			global::android.os.Debug._changeDebugPort6318 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "changeDebugPort", "(I)V");
			global::android.os.Debug._startNativeTracing6319 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startNativeTracing", "()V");
			global::android.os.Debug._stopNativeTracing6320 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "stopNativeTracing", "()V");
			global::android.os.Debug._enableEmulatorTraceOutput6321 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "enableEmulatorTraceOutput", "()V");
			global::android.os.Debug._startMethodTracing6322 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;)V");
			global::android.os.Debug._startMethodTracing6323 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;I)V");
			global::android.os.Debug._startMethodTracing6324 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;II)V");
			global::android.os.Debug._startMethodTracing6325 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "()V");
			global::android.os.Debug._stopMethodTracing6326 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "stopMethodTracing", "()V");
			global::android.os.Debug._threadCpuTimeNanos6327 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "threadCpuTimeNanos", "()J");
			global::android.os.Debug._startAllocCounting6328 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startAllocCounting", "()V");
			global::android.os.Debug._stopAllocCounting6329 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "stopAllocCounting", "()V");
			global::android.os.Debug._getGlobalAllocCount6330 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalAllocCount", "()I");
			global::android.os.Debug._getGlobalAllocSize6331 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalAllocSize", "()I");
			global::android.os.Debug._getGlobalFreedCount6332 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalFreedCount", "()I");
			global::android.os.Debug._getGlobalFreedSize6333 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalFreedSize", "()I");
			global::android.os.Debug._getGlobalClassInitCount6334 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalClassInitCount", "()I");
			global::android.os.Debug._getGlobalClassInitTime6335 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalClassInitTime", "()I");
			global::android.os.Debug._getGlobalExternalAllocCount6336 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalAllocCount", "()I");
			global::android.os.Debug._getGlobalExternalAllocSize6337 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalAllocSize", "()I");
			global::android.os.Debug._getGlobalExternalFreedCount6338 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalFreedCount", "()I");
			global::android.os.Debug._getGlobalExternalFreedSize6339 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalFreedSize", "()I");
			global::android.os.Debug._getGlobalGcInvocationCount6340 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalGcInvocationCount", "()I");
			global::android.os.Debug._getThreadAllocCount6341 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadAllocCount", "()I");
			global::android.os.Debug._getThreadAllocSize6342 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadAllocSize", "()I");
			global::android.os.Debug._getThreadExternalAllocCount6343 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadExternalAllocCount", "()I");
			global::android.os.Debug._getThreadExternalAllocSize6344 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadExternalAllocSize", "()I");
			global::android.os.Debug._getThreadGcInvocationCount6345 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadGcInvocationCount", "()I");
			global::android.os.Debug._resetGlobalAllocCount6346 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalAllocCount", "()V");
			global::android.os.Debug._resetGlobalAllocSize6347 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalAllocSize", "()V");
			global::android.os.Debug._resetGlobalFreedCount6348 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalFreedCount", "()V");
			global::android.os.Debug._resetGlobalFreedSize6349 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalFreedSize", "()V");
			global::android.os.Debug._resetGlobalClassInitCount6350 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalClassInitCount", "()V");
			global::android.os.Debug._resetGlobalClassInitTime6351 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalClassInitTime", "()V");
			global::android.os.Debug._resetGlobalExternalAllocCount6352 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalAllocCount", "()V");
			global::android.os.Debug._resetGlobalExternalAllocSize6353 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalAllocSize", "()V");
			global::android.os.Debug._resetGlobalExternalFreedCount6354 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalFreedCount", "()V");
			global::android.os.Debug._resetGlobalExternalFreedSize6355 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalFreedSize", "()V");
			global::android.os.Debug._resetGlobalGcInvocationCount6356 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalGcInvocationCount", "()V");
			global::android.os.Debug._resetThreadAllocCount6357 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadAllocCount", "()V");
			global::android.os.Debug._resetThreadAllocSize6358 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadAllocSize", "()V");
			global::android.os.Debug._resetThreadExternalAllocCount6359 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadExternalAllocCount", "()V");
			global::android.os.Debug._resetThreadExternalAllocSize6360 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadExternalAllocSize", "()V");
			global::android.os.Debug._resetThreadGcInvocationCount6361 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadGcInvocationCount", "()V");
			global::android.os.Debug._resetAllCounts6362 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetAllCounts", "()V");
			global::android.os.Debug._getNativeHeapSize6363 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getNativeHeapSize", "()J");
			global::android.os.Debug._getNativeHeapAllocatedSize6364 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getNativeHeapAllocatedSize", "()J");
			global::android.os.Debug._getNativeHeapFreeSize6365 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getNativeHeapFreeSize", "()J");
			global::android.os.Debug._setAllocationLimit6366 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "setAllocationLimit", "(I)I");
			global::android.os.Debug._setGlobalAllocationLimit6367 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "setGlobalAllocationLimit", "(I)I");
			global::android.os.Debug._printLoadedClasses6368 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "printLoadedClasses", "(I)V");
			global::android.os.Debug._getLoadedClassCount6369 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getLoadedClassCount", "()I");
			global::android.os.Debug._dumpHprofData6370 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "dumpHprofData", "(Ljava/lang/String;)V");
			global::android.os.Debug._getBinderSentTransactions6371 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderSentTransactions", "()I");
			global::android.os.Debug._getBinderReceivedTransactions6372 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderReceivedTransactions", "()I");
			global::android.os.Debug._getBinderLocalObjectCount6373 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderLocalObjectCount", "()I");
			global::android.os.Debug._getBinderProxyObjectCount6374 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderProxyObjectCount", "()I");
			global::android.os.Debug._getBinderDeathObjectCount6375 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderDeathObjectCount", "()I");
			global::android.os.Debug._dumpService6376 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "dumpService", "(Ljava/lang/String;Ljava/io/FileDescriptor;[Ljava/lang/String;)Z");
		}
	}
}
