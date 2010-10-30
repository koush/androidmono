namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Debug : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Debug(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class InstructionCount : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected InstructionCount(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _resetAndStart9696;
			public virtual bool resetAndStart()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._resetAndStart9696);
			}
			internal static global::MonoJavaBridge.MethodId _collect9697;
			public virtual bool collect()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._collect9697);
			}
			internal static global::MonoJavaBridge.MethodId _globalTotal9698;
			public virtual int globalTotal()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._globalTotal9698);
			}
			internal static global::MonoJavaBridge.MethodId _globalMethodInvocations9699;
			public virtual int globalMethodInvocations()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._globalMethodInvocations9699);
			}
			internal static global::MonoJavaBridge.MethodId _InstructionCount9700;
			public InstructionCount() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._InstructionCount9700);
				Init(@__env, handle);
			}
			static InstructionCount()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Debug.InstructionCount.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Debug$InstructionCount"));
				global::android.os.Debug.InstructionCount._resetAndStart9696 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "resetAndStart", "()Z");
				global::android.os.Debug.InstructionCount._collect9697 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "collect", "()Z");
				global::android.os.Debug.InstructionCount._globalTotal9698 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "globalTotal", "()I");
				global::android.os.Debug.InstructionCount._globalMethodInvocations9699 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "globalMethodInvocations", "()I");
				global::android.os.Debug.InstructionCount._InstructionCount9700 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MemoryInfo : java.lang.Object, Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected MemoryInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel9701;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._writeToParcel9701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents9702;
			public virtual int describeContents()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._describeContents9702);
			}
			internal static global::MonoJavaBridge.MethodId _readFromParcel9703;
			public virtual void readFromParcel(android.os.Parcel arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._readFromParcel9703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int TotalPss
			{
				get
				{
					return getTotalPss();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTotalPss9704;
			public virtual int getTotalPss()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._getTotalPss9704);
			}
			public new int TotalPrivateDirty
			{
				get
				{
					return getTotalPrivateDirty();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTotalPrivateDirty9705;
			public virtual int getTotalPrivateDirty()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._getTotalPrivateDirty9705);
			}
			public new int TotalSharedDirty
			{
				get
				{
					return getTotalSharedDirty();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTotalSharedDirty9706;
			public virtual int getTotalSharedDirty()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._getTotalSharedDirty9706);
			}
			internal static global::MonoJavaBridge.MethodId _MemoryInfo9707;
			public MemoryInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._MemoryInfo9707);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _dalvikPss9708;
			public int dalvikPss
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _dalvikPss9708);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _dalvikPrivateDirty9709;
			public int dalvikPrivateDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _dalvikPrivateDirty9709);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _dalvikSharedDirty9710;
			public int dalvikSharedDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _dalvikSharedDirty9710);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _nativePss9711;
			public int nativePss
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _nativePss9711);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _nativePrivateDirty9712;
			public int nativePrivateDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _nativePrivateDirty9712);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _nativeSharedDirty9713;
			public int nativeSharedDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _nativeSharedDirty9713);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _otherPss9714;
			public int otherPss
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _otherPss9714);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _otherPrivateDirty9715;
			public int otherPrivateDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _otherPrivateDirty9715);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _otherSharedDirty9716;
			public int otherSharedDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _otherSharedDirty9716);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR9717;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.Debug.MemoryInfo.staticClass, _CREATOR9717)) as android.os.Parcelable_Creator;
				}
			}
			static MemoryInfo()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Debug.MemoryInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Debug$MemoryInfo"));
				global::android.os.Debug.MemoryInfo._writeToParcel9701 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.os.Debug.MemoryInfo._describeContents9702 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "describeContents", "()I");
				global::android.os.Debug.MemoryInfo._readFromParcel9703 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.os.Debug.MemoryInfo._getTotalPss9704 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "getTotalPss", "()I");
				global::android.os.Debug.MemoryInfo._getTotalPrivateDirty9705 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "getTotalPrivateDirty", "()I");
				global::android.os.Debug.MemoryInfo._getTotalSharedDirty9706 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "getTotalSharedDirty", "()I");
				global::android.os.Debug.MemoryInfo._MemoryInfo9707 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "<init>", "()V");
				global::android.os.Debug.MemoryInfo._dalvikPss9708 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "dalvikPss", "I");
				global::android.os.Debug.MemoryInfo._dalvikPrivateDirty9709 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "dalvikPrivateDirty", "I");
				global::android.os.Debug.MemoryInfo._dalvikSharedDirty9710 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "dalvikSharedDirty", "I");
				global::android.os.Debug.MemoryInfo._nativePss9711 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "nativePss", "I");
				global::android.os.Debug.MemoryInfo._nativePrivateDirty9712 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "nativePrivateDirty", "I");
				global::android.os.Debug.MemoryInfo._nativeSharedDirty9713 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "nativeSharedDirty", "I");
				global::android.os.Debug.MemoryInfo._otherPss9714 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "otherPss", "I");
				global::android.os.Debug.MemoryInfo._otherPrivateDirty9715 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "otherPrivateDirty", "I");
				global::android.os.Debug.MemoryInfo._otherSharedDirty9716 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "otherSharedDirty", "I");
				global::android.os.Debug.MemoryInfo._CREATOR9717 = @__env.GetStaticFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMemoryInfo9718;
		public static void getMemoryInfo(android.os.Debug.MemoryInfo arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._getMemoryInfo9718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _waitForDebugger9719;
		public static void waitForDebugger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._waitForDebugger9719);
		}
		internal static global::MonoJavaBridge.MethodId _waitingForDebugger9720;
		public static bool waitingForDebugger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._waitingForDebugger9720);
		}
		internal static global::MonoJavaBridge.MethodId _isDebuggerConnected9721;
		public static bool isDebuggerConnected()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._isDebuggerConnected9721);
		}
		internal static global::MonoJavaBridge.MethodId _changeDebugPort9722;
		public static void changeDebugPort(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._changeDebugPort9722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startNativeTracing9723;
		public static void startNativeTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startNativeTracing9723);
		}
		internal static global::MonoJavaBridge.MethodId _stopNativeTracing9724;
		public static void stopNativeTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._stopNativeTracing9724);
		}
		internal static global::MonoJavaBridge.MethodId _enableEmulatorTraceOutput9725;
		public static void enableEmulatorTraceOutput()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._enableEmulatorTraceOutput9725);
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing9726;
		public static void startMethodTracing(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing9726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing9727;
		public static void startMethodTracing(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing9727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing9728;
		public static void startMethodTracing(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing9728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing9729;
		public static void startMethodTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing9729);
		}
		internal static global::MonoJavaBridge.MethodId _stopMethodTracing9730;
		public static void stopMethodTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._stopMethodTracing9730);
		}
		internal static global::MonoJavaBridge.MethodId _threadCpuTimeNanos9731;
		public static long threadCpuTimeNanos()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._threadCpuTimeNanos9731);
		}
		internal static global::MonoJavaBridge.MethodId _startAllocCounting9732;
		public static void startAllocCounting()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startAllocCounting9732);
		}
		internal static global::MonoJavaBridge.MethodId _stopAllocCounting9733;
		public static void stopAllocCounting()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._stopAllocCounting9733);
		}
		public static int GlobalAllocCount
		{
			get
			{
				return getGlobalAllocCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalAllocCount9734;
		public static int getGlobalAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalAllocCount9734);
		}
		public static int GlobalAllocSize
		{
			get
			{
				return getGlobalAllocSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalAllocSize9735;
		public static int getGlobalAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalAllocSize9735);
		}
		public static int GlobalFreedCount
		{
			get
			{
				return getGlobalFreedCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalFreedCount9736;
		public static int getGlobalFreedCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalFreedCount9736);
		}
		public static int GlobalFreedSize
		{
			get
			{
				return getGlobalFreedSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalFreedSize9737;
		public static int getGlobalFreedSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalFreedSize9737);
		}
		public static int GlobalClassInitCount
		{
			get
			{
				return getGlobalClassInitCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalClassInitCount9738;
		public static int getGlobalClassInitCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalClassInitCount9738);
		}
		public static int GlobalClassInitTime
		{
			get
			{
				return getGlobalClassInitTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalClassInitTime9739;
		public static int getGlobalClassInitTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalClassInitTime9739);
		}
		public static int GlobalExternalAllocCount
		{
			get
			{
				return getGlobalExternalAllocCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalExternalAllocCount9740;
		public static int getGlobalExternalAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalAllocCount9740);
		}
		public static int GlobalExternalAllocSize
		{
			get
			{
				return getGlobalExternalAllocSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalExternalAllocSize9741;
		public static int getGlobalExternalAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalAllocSize9741);
		}
		public static int GlobalExternalFreedCount
		{
			get
			{
				return getGlobalExternalFreedCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalExternalFreedCount9742;
		public static int getGlobalExternalFreedCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalFreedCount9742);
		}
		public static int GlobalExternalFreedSize
		{
			get
			{
				return getGlobalExternalFreedSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalExternalFreedSize9743;
		public static int getGlobalExternalFreedSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalFreedSize9743);
		}
		public static int GlobalGcInvocationCount
		{
			get
			{
				return getGlobalGcInvocationCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalGcInvocationCount9744;
		public static int getGlobalGcInvocationCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalGcInvocationCount9744);
		}
		public static int ThreadAllocCount
		{
			get
			{
				return getThreadAllocCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadAllocCount9745;
		public static int getThreadAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadAllocCount9745);
		}
		public static int ThreadAllocSize
		{
			get
			{
				return getThreadAllocSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadAllocSize9746;
		public static int getThreadAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadAllocSize9746);
		}
		public static int ThreadExternalAllocCount
		{
			get
			{
				return getThreadExternalAllocCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadExternalAllocCount9747;
		public static int getThreadExternalAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadExternalAllocCount9747);
		}
		public static int ThreadExternalAllocSize
		{
			get
			{
				return getThreadExternalAllocSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadExternalAllocSize9748;
		public static int getThreadExternalAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadExternalAllocSize9748);
		}
		public static int ThreadGcInvocationCount
		{
			get
			{
				return getThreadGcInvocationCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadGcInvocationCount9749;
		public static int getThreadGcInvocationCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadGcInvocationCount9749);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalAllocCount9750;
		public static void resetGlobalAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalAllocCount9750);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalAllocSize9751;
		public static void resetGlobalAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalAllocSize9751);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalFreedCount9752;
		public static void resetGlobalFreedCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalFreedCount9752);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalFreedSize9753;
		public static void resetGlobalFreedSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalFreedSize9753);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalClassInitCount9754;
		public static void resetGlobalClassInitCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalClassInitCount9754);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalClassInitTime9755;
		public static void resetGlobalClassInitTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalClassInitTime9755);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalExternalAllocCount9756;
		public static void resetGlobalExternalAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalAllocCount9756);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalExternalAllocSize9757;
		public static void resetGlobalExternalAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalAllocSize9757);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalExternalFreedCount9758;
		public static void resetGlobalExternalFreedCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalFreedCount9758);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalExternalFreedSize9759;
		public static void resetGlobalExternalFreedSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalFreedSize9759);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalGcInvocationCount9760;
		public static void resetGlobalGcInvocationCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalGcInvocationCount9760);
		}
		internal static global::MonoJavaBridge.MethodId _resetThreadAllocCount9761;
		public static void resetThreadAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadAllocCount9761);
		}
		internal static global::MonoJavaBridge.MethodId _resetThreadAllocSize9762;
		public static void resetThreadAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadAllocSize9762);
		}
		internal static global::MonoJavaBridge.MethodId _resetThreadExternalAllocCount9763;
		public static void resetThreadExternalAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadExternalAllocCount9763);
		}
		internal static global::MonoJavaBridge.MethodId _resetThreadExternalAllocSize9764;
		public static void resetThreadExternalAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadExternalAllocSize9764);
		}
		internal static global::MonoJavaBridge.MethodId _resetThreadGcInvocationCount9765;
		public static void resetThreadGcInvocationCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadGcInvocationCount9765);
		}
		internal static global::MonoJavaBridge.MethodId _resetAllCounts9766;
		public static void resetAllCounts()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetAllCounts9766);
		}
		public static long NativeHeapSize
		{
			get
			{
				return getNativeHeapSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNativeHeapSize9767;
		public static long getNativeHeapSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._getNativeHeapSize9767);
		}
		public static long NativeHeapAllocatedSize
		{
			get
			{
				return getNativeHeapAllocatedSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNativeHeapAllocatedSize9768;
		public static long getNativeHeapAllocatedSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._getNativeHeapAllocatedSize9768);
		}
		public static long NativeHeapFreeSize
		{
			get
			{
				return getNativeHeapFreeSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNativeHeapFreeSize9769;
		public static long getNativeHeapFreeSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._getNativeHeapFreeSize9769);
		}
		public static int AllocationLimit
		{
			set
			{
				setAllocationLimit(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAllocationLimit9770;
		public static int setAllocationLimit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._setAllocationLimit9770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int GlobalAllocationLimit
		{
			set
			{
				setGlobalAllocationLimit(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setGlobalAllocationLimit9771;
		public static int setGlobalAllocationLimit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._setGlobalAllocationLimit9771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _printLoadedClasses9772;
		public static void printLoadedClasses(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._printLoadedClasses9772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int LoadedClassCount
		{
			get
			{
				return getLoadedClassCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoadedClassCount9773;
		public static int getLoadedClassCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getLoadedClassCount9773);
		}
		internal static global::MonoJavaBridge.MethodId _dumpHprofData9774;
		public static void dumpHprofData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._dumpHprofData9774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int BinderSentTransactions
		{
			get
			{
				return getBinderSentTransactions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderSentTransactions9775;
		public static int getBinderSentTransactions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderSentTransactions9775);
		}
		public static int BinderReceivedTransactions
		{
			get
			{
				return getBinderReceivedTransactions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderReceivedTransactions9776;
		public static int getBinderReceivedTransactions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderReceivedTransactions9776);
		}
		public static int BinderLocalObjectCount
		{
			get
			{
				return getBinderLocalObjectCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderLocalObjectCount9777;
		public static int getBinderLocalObjectCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderLocalObjectCount9777);
		}
		public static int BinderProxyObjectCount
		{
			get
			{
				return getBinderProxyObjectCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderProxyObjectCount9778;
		public static int getBinderProxyObjectCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderProxyObjectCount9778);
		}
		public static int BinderDeathObjectCount
		{
			get
			{
				return getBinderDeathObjectCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderDeathObjectCount9779;
		public static int getBinderDeathObjectCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderDeathObjectCount9779);
		}
		internal static global::MonoJavaBridge.MethodId _dumpService9780;
		public static bool dumpService(java.lang.String arg0, java.io.FileDescriptor arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._dumpService9780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		static Debug()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Debug.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Debug"));
			global::android.os.Debug._getMemoryInfo9718 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getMemoryInfo", "(Landroid/os/Debug$MemoryInfo;)V");
			global::android.os.Debug._waitForDebugger9719 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "waitForDebugger", "()V");
			global::android.os.Debug._waitingForDebugger9720 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "waitingForDebugger", "()Z");
			global::android.os.Debug._isDebuggerConnected9721 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "isDebuggerConnected", "()Z");
			global::android.os.Debug._changeDebugPort9722 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "changeDebugPort", "(I)V");
			global::android.os.Debug._startNativeTracing9723 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startNativeTracing", "()V");
			global::android.os.Debug._stopNativeTracing9724 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "stopNativeTracing", "()V");
			global::android.os.Debug._enableEmulatorTraceOutput9725 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "enableEmulatorTraceOutput", "()V");
			global::android.os.Debug._startMethodTracing9726 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;)V");
			global::android.os.Debug._startMethodTracing9727 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;I)V");
			global::android.os.Debug._startMethodTracing9728 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;II)V");
			global::android.os.Debug._startMethodTracing9729 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "()V");
			global::android.os.Debug._stopMethodTracing9730 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "stopMethodTracing", "()V");
			global::android.os.Debug._threadCpuTimeNanos9731 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "threadCpuTimeNanos", "()J");
			global::android.os.Debug._startAllocCounting9732 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startAllocCounting", "()V");
			global::android.os.Debug._stopAllocCounting9733 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "stopAllocCounting", "()V");
			global::android.os.Debug._getGlobalAllocCount9734 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalAllocCount", "()I");
			global::android.os.Debug._getGlobalAllocSize9735 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalAllocSize", "()I");
			global::android.os.Debug._getGlobalFreedCount9736 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalFreedCount", "()I");
			global::android.os.Debug._getGlobalFreedSize9737 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalFreedSize", "()I");
			global::android.os.Debug._getGlobalClassInitCount9738 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalClassInitCount", "()I");
			global::android.os.Debug._getGlobalClassInitTime9739 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalClassInitTime", "()I");
			global::android.os.Debug._getGlobalExternalAllocCount9740 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalAllocCount", "()I");
			global::android.os.Debug._getGlobalExternalAllocSize9741 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalAllocSize", "()I");
			global::android.os.Debug._getGlobalExternalFreedCount9742 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalFreedCount", "()I");
			global::android.os.Debug._getGlobalExternalFreedSize9743 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalFreedSize", "()I");
			global::android.os.Debug._getGlobalGcInvocationCount9744 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalGcInvocationCount", "()I");
			global::android.os.Debug._getThreadAllocCount9745 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadAllocCount", "()I");
			global::android.os.Debug._getThreadAllocSize9746 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadAllocSize", "()I");
			global::android.os.Debug._getThreadExternalAllocCount9747 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadExternalAllocCount", "()I");
			global::android.os.Debug._getThreadExternalAllocSize9748 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadExternalAllocSize", "()I");
			global::android.os.Debug._getThreadGcInvocationCount9749 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadGcInvocationCount", "()I");
			global::android.os.Debug._resetGlobalAllocCount9750 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalAllocCount", "()V");
			global::android.os.Debug._resetGlobalAllocSize9751 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalAllocSize", "()V");
			global::android.os.Debug._resetGlobalFreedCount9752 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalFreedCount", "()V");
			global::android.os.Debug._resetGlobalFreedSize9753 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalFreedSize", "()V");
			global::android.os.Debug._resetGlobalClassInitCount9754 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalClassInitCount", "()V");
			global::android.os.Debug._resetGlobalClassInitTime9755 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalClassInitTime", "()V");
			global::android.os.Debug._resetGlobalExternalAllocCount9756 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalAllocCount", "()V");
			global::android.os.Debug._resetGlobalExternalAllocSize9757 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalAllocSize", "()V");
			global::android.os.Debug._resetGlobalExternalFreedCount9758 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalFreedCount", "()V");
			global::android.os.Debug._resetGlobalExternalFreedSize9759 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalFreedSize", "()V");
			global::android.os.Debug._resetGlobalGcInvocationCount9760 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalGcInvocationCount", "()V");
			global::android.os.Debug._resetThreadAllocCount9761 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadAllocCount", "()V");
			global::android.os.Debug._resetThreadAllocSize9762 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadAllocSize", "()V");
			global::android.os.Debug._resetThreadExternalAllocCount9763 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadExternalAllocCount", "()V");
			global::android.os.Debug._resetThreadExternalAllocSize9764 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadExternalAllocSize", "()V");
			global::android.os.Debug._resetThreadGcInvocationCount9765 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadGcInvocationCount", "()V");
			global::android.os.Debug._resetAllCounts9766 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetAllCounts", "()V");
			global::android.os.Debug._getNativeHeapSize9767 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getNativeHeapSize", "()J");
			global::android.os.Debug._getNativeHeapAllocatedSize9768 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getNativeHeapAllocatedSize", "()J");
			global::android.os.Debug._getNativeHeapFreeSize9769 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getNativeHeapFreeSize", "()J");
			global::android.os.Debug._setAllocationLimit9770 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "setAllocationLimit", "(I)I");
			global::android.os.Debug._setGlobalAllocationLimit9771 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "setGlobalAllocationLimit", "(I)I");
			global::android.os.Debug._printLoadedClasses9772 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "printLoadedClasses", "(I)V");
			global::android.os.Debug._getLoadedClassCount9773 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getLoadedClassCount", "()I");
			global::android.os.Debug._dumpHprofData9774 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "dumpHprofData", "(Ljava/lang/String;)V");
			global::android.os.Debug._getBinderSentTransactions9775 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderSentTransactions", "()I");
			global::android.os.Debug._getBinderReceivedTransactions9776 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderReceivedTransactions", "()I");
			global::android.os.Debug._getBinderLocalObjectCount9777 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderLocalObjectCount", "()I");
			global::android.os.Debug._getBinderProxyObjectCount9778 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderProxyObjectCount", "()I");
			global::android.os.Debug._getBinderDeathObjectCount9779 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderDeathObjectCount", "()I");
			global::android.os.Debug._dumpService9780 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "dumpService", "(Ljava/lang/String;Ljava/io/FileDescriptor;[Ljava/lang/String;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
