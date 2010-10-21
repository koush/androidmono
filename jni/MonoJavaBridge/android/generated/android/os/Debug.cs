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
			internal static global::MonoJavaBridge.MethodId _resetAndStart9654;
			public virtual bool resetAndStart() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Debug.InstructionCount._resetAndStart9654);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._resetAndStart9654);
			}
			internal static global::MonoJavaBridge.MethodId _collect9655;
			public virtual bool collect() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Debug.InstructionCount._collect9655);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._collect9655);
			}
			internal static global::MonoJavaBridge.MethodId _globalTotal9656;
			public virtual int globalTotal() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.os.Debug.InstructionCount._globalTotal9656);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._globalTotal9656);
			}
			internal static global::MonoJavaBridge.MethodId _globalMethodInvocations9657;
			public virtual int globalMethodInvocations() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.os.Debug.InstructionCount._globalMethodInvocations9657);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._globalMethodInvocations9657);
			}
			internal static global::MonoJavaBridge.MethodId _InstructionCount9658;
			public InstructionCount()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._InstructionCount9658);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Debug.InstructionCount.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Debug$InstructionCount"));
				global::android.os.Debug.InstructionCount._resetAndStart9654 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "resetAndStart", "()Z");
				global::android.os.Debug.InstructionCount._collect9655 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "collect", "()Z");
				global::android.os.Debug.InstructionCount._globalTotal9656 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "globalTotal", "()I");
				global::android.os.Debug.InstructionCount._globalMethodInvocations9657 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "globalMethodInvocations", "()I");
				global::android.os.Debug.InstructionCount._InstructionCount9658 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _writeToParcel9659;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo._writeToParcel9659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._writeToParcel9659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents9660;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo._describeContents9660);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._describeContents9660);
			}
			internal static global::MonoJavaBridge.MethodId _readFromParcel9661;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo._readFromParcel9661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._readFromParcel9661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int TotalPss
			{
				get
				{
					return getTotalPss();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTotalPss9662;
			public virtual int getTotalPss() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo._getTotalPss9662);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._getTotalPss9662);
			}
			public new int TotalPrivateDirty
			{
				get
				{
					return getTotalPrivateDirty();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTotalPrivateDirty9663;
			public virtual int getTotalPrivateDirty() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo._getTotalPrivateDirty9663);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._getTotalPrivateDirty9663);
			}
			public new int TotalSharedDirty
			{
				get
				{
					return getTotalSharedDirty();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTotalSharedDirty9664;
			public virtual int getTotalSharedDirty() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo._getTotalSharedDirty9664);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._getTotalSharedDirty9664);
			}
			internal static global::MonoJavaBridge.MethodId _MemoryInfo9665;
			public MemoryInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._MemoryInfo9665);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _dalvikPss9666;
			public int dalvikPss
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _dalvikPss9666);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _dalvikPrivateDirty9667;
			public int dalvikPrivateDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _dalvikPrivateDirty9667);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _dalvikSharedDirty9668;
			public int dalvikSharedDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _dalvikSharedDirty9668);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _nativePss9669;
			public int nativePss
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _nativePss9669);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _nativePrivateDirty9670;
			public int nativePrivateDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _nativePrivateDirty9670);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _nativeSharedDirty9671;
			public int nativeSharedDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _nativeSharedDirty9671);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _otherPss9672;
			public int otherPss
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _otherPss9672);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _otherPrivateDirty9673;
			public int otherPrivateDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _otherPrivateDirty9673);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _otherSharedDirty9674;
			public int otherSharedDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _otherSharedDirty9674);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR9675;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.Debug.MemoryInfo.staticClass, _CREATOR9675)) as android.os.Parcelable_Creator;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Debug.MemoryInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Debug$MemoryInfo"));
				global::android.os.Debug.MemoryInfo._writeToParcel9659 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.os.Debug.MemoryInfo._describeContents9660 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "describeContents", "()I");
				global::android.os.Debug.MemoryInfo._readFromParcel9661 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.os.Debug.MemoryInfo._getTotalPss9662 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "getTotalPss", "()I");
				global::android.os.Debug.MemoryInfo._getTotalPrivateDirty9663 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "getTotalPrivateDirty", "()I");
				global::android.os.Debug.MemoryInfo._getTotalSharedDirty9664 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "getTotalSharedDirty", "()I");
				global::android.os.Debug.MemoryInfo._MemoryInfo9665 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "<init>", "()V");
				global::android.os.Debug.MemoryInfo._dalvikPss9666 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "dalvikPss", "I");
				global::android.os.Debug.MemoryInfo._dalvikPrivateDirty9667 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "dalvikPrivateDirty", "I");
				global::android.os.Debug.MemoryInfo._dalvikSharedDirty9668 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "dalvikSharedDirty", "I");
				global::android.os.Debug.MemoryInfo._nativePss9669 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "nativePss", "I");
				global::android.os.Debug.MemoryInfo._nativePrivateDirty9670 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "nativePrivateDirty", "I");
				global::android.os.Debug.MemoryInfo._nativeSharedDirty9671 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "nativeSharedDirty", "I");
				global::android.os.Debug.MemoryInfo._otherPss9672 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "otherPss", "I");
				global::android.os.Debug.MemoryInfo._otherPrivateDirty9673 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "otherPrivateDirty", "I");
				global::android.os.Debug.MemoryInfo._otherSharedDirty9674 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "otherSharedDirty", "I");
				global::android.os.Debug.MemoryInfo._CREATOR9675 = @__env.GetStaticFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMemoryInfo9676;
		public static void getMemoryInfo(android.os.Debug.MemoryInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._getMemoryInfo9676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _waitForDebugger9677;
		public static void waitForDebugger() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._waitForDebugger9677);
		}
		internal static global::MonoJavaBridge.MethodId _waitingForDebugger9678;
		public static bool waitingForDebugger() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._waitingForDebugger9678);
		}
		internal static global::MonoJavaBridge.MethodId _isDebuggerConnected9679;
		public static bool isDebuggerConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._isDebuggerConnected9679);
		}
		internal static global::MonoJavaBridge.MethodId _changeDebugPort9680;
		public static void changeDebugPort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._changeDebugPort9680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startNativeTracing9681;
		public static void startNativeTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startNativeTracing9681);
		}
		internal static global::MonoJavaBridge.MethodId _stopNativeTracing9682;
		public static void stopNativeTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._stopNativeTracing9682);
		}
		internal static global::MonoJavaBridge.MethodId _enableEmulatorTraceOutput9683;
		public static void enableEmulatorTraceOutput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._enableEmulatorTraceOutput9683);
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing9684;
		public static void startMethodTracing(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing9684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing9685;
		public static void startMethodTracing(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing9685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing9686;
		public static void startMethodTracing(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing9686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startMethodTracing9687;
		public static void startMethodTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing9687);
		}
		internal static global::MonoJavaBridge.MethodId _stopMethodTracing9688;
		public static void stopMethodTracing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._stopMethodTracing9688);
		}
		internal static global::MonoJavaBridge.MethodId _threadCpuTimeNanos9689;
		public static long threadCpuTimeNanos() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._threadCpuTimeNanos9689);
		}
		internal static global::MonoJavaBridge.MethodId _startAllocCounting9690;
		public static void startAllocCounting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startAllocCounting9690);
		}
		internal static global::MonoJavaBridge.MethodId _stopAllocCounting9691;
		public static void stopAllocCounting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._stopAllocCounting9691);
		}
		public static int GlobalAllocCount
		{
			get
			{
				return getGlobalAllocCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalAllocCount9692;
		public static int getGlobalAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalAllocCount9692);
		}
		public static int GlobalAllocSize
		{
			get
			{
				return getGlobalAllocSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalAllocSize9693;
		public static int getGlobalAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalAllocSize9693);
		}
		public static int GlobalFreedCount
		{
			get
			{
				return getGlobalFreedCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalFreedCount9694;
		public static int getGlobalFreedCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalFreedCount9694);
		}
		public static int GlobalFreedSize
		{
			get
			{
				return getGlobalFreedSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalFreedSize9695;
		public static int getGlobalFreedSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalFreedSize9695);
		}
		public static int GlobalClassInitCount
		{
			get
			{
				return getGlobalClassInitCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalClassInitCount9696;
		public static int getGlobalClassInitCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalClassInitCount9696);
		}
		public static int GlobalClassInitTime
		{
			get
			{
				return getGlobalClassInitTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalClassInitTime9697;
		public static int getGlobalClassInitTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalClassInitTime9697);
		}
		public static int GlobalExternalAllocCount
		{
			get
			{
				return getGlobalExternalAllocCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalExternalAllocCount9698;
		public static int getGlobalExternalAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalAllocCount9698);
		}
		public static int GlobalExternalAllocSize
		{
			get
			{
				return getGlobalExternalAllocSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalExternalAllocSize9699;
		public static int getGlobalExternalAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalAllocSize9699);
		}
		public static int GlobalExternalFreedCount
		{
			get
			{
				return getGlobalExternalFreedCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalExternalFreedCount9700;
		public static int getGlobalExternalFreedCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalFreedCount9700);
		}
		public static int GlobalExternalFreedSize
		{
			get
			{
				return getGlobalExternalFreedSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalExternalFreedSize9701;
		public static int getGlobalExternalFreedSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalFreedSize9701);
		}
		public static int GlobalGcInvocationCount
		{
			get
			{
				return getGlobalGcInvocationCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGlobalGcInvocationCount9702;
		public static int getGlobalGcInvocationCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalGcInvocationCount9702);
		}
		public static int ThreadAllocCount
		{
			get
			{
				return getThreadAllocCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadAllocCount9703;
		public static int getThreadAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadAllocCount9703);
		}
		public static int ThreadAllocSize
		{
			get
			{
				return getThreadAllocSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadAllocSize9704;
		public static int getThreadAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadAllocSize9704);
		}
		public static int ThreadExternalAllocCount
		{
			get
			{
				return getThreadExternalAllocCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadExternalAllocCount9705;
		public static int getThreadExternalAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadExternalAllocCount9705);
		}
		public static int ThreadExternalAllocSize
		{
			get
			{
				return getThreadExternalAllocSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadExternalAllocSize9706;
		public static int getThreadExternalAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadExternalAllocSize9706);
		}
		public static int ThreadGcInvocationCount
		{
			get
			{
				return getThreadGcInvocationCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadGcInvocationCount9707;
		public static int getThreadGcInvocationCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadGcInvocationCount9707);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalAllocCount9708;
		public static void resetGlobalAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalAllocCount9708);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalAllocSize9709;
		public static void resetGlobalAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalAllocSize9709);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalFreedCount9710;
		public static void resetGlobalFreedCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalFreedCount9710);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalFreedSize9711;
		public static void resetGlobalFreedSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalFreedSize9711);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalClassInitCount9712;
		public static void resetGlobalClassInitCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalClassInitCount9712);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalClassInitTime9713;
		public static void resetGlobalClassInitTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalClassInitTime9713);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalExternalAllocCount9714;
		public static void resetGlobalExternalAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalAllocCount9714);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalExternalAllocSize9715;
		public static void resetGlobalExternalAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalAllocSize9715);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalExternalFreedCount9716;
		public static void resetGlobalExternalFreedCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalFreedCount9716);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalExternalFreedSize9717;
		public static void resetGlobalExternalFreedSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalFreedSize9717);
		}
		internal static global::MonoJavaBridge.MethodId _resetGlobalGcInvocationCount9718;
		public static void resetGlobalGcInvocationCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalGcInvocationCount9718);
		}
		internal static global::MonoJavaBridge.MethodId _resetThreadAllocCount9719;
		public static void resetThreadAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadAllocCount9719);
		}
		internal static global::MonoJavaBridge.MethodId _resetThreadAllocSize9720;
		public static void resetThreadAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadAllocSize9720);
		}
		internal static global::MonoJavaBridge.MethodId _resetThreadExternalAllocCount9721;
		public static void resetThreadExternalAllocCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadExternalAllocCount9721);
		}
		internal static global::MonoJavaBridge.MethodId _resetThreadExternalAllocSize9722;
		public static void resetThreadExternalAllocSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadExternalAllocSize9722);
		}
		internal static global::MonoJavaBridge.MethodId _resetThreadGcInvocationCount9723;
		public static void resetThreadGcInvocationCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadGcInvocationCount9723);
		}
		internal static global::MonoJavaBridge.MethodId _resetAllCounts9724;
		public static void resetAllCounts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetAllCounts9724);
		}
		public static long NativeHeapSize
		{
			get
			{
				return getNativeHeapSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNativeHeapSize9725;
		public static long getNativeHeapSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._getNativeHeapSize9725);
		}
		public static long NativeHeapAllocatedSize
		{
			get
			{
				return getNativeHeapAllocatedSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNativeHeapAllocatedSize9726;
		public static long getNativeHeapAllocatedSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._getNativeHeapAllocatedSize9726);
		}
		public static long NativeHeapFreeSize
		{
			get
			{
				return getNativeHeapFreeSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNativeHeapFreeSize9727;
		public static long getNativeHeapFreeSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._getNativeHeapFreeSize9727);
		}
		internal static global::MonoJavaBridge.MethodId _setAllocationLimit9728;
		public static int setAllocationLimit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._setAllocationLimit9728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGlobalAllocationLimit9729;
		public static int setGlobalAllocationLimit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._setGlobalAllocationLimit9729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _printLoadedClasses9730;
		public static void printLoadedClasses(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._printLoadedClasses9730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int LoadedClassCount
		{
			get
			{
				return getLoadedClassCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoadedClassCount9731;
		public static int getLoadedClassCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getLoadedClassCount9731);
		}
		internal static global::MonoJavaBridge.MethodId _dumpHprofData9732;
		public static void dumpHprofData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._dumpHprofData9732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int BinderSentTransactions
		{
			get
			{
				return getBinderSentTransactions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderSentTransactions9733;
		public static int getBinderSentTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderSentTransactions9733);
		}
		public static int BinderReceivedTransactions
		{
			get
			{
				return getBinderReceivedTransactions();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderReceivedTransactions9734;
		public static int getBinderReceivedTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderReceivedTransactions9734);
		}
		public static int BinderLocalObjectCount
		{
			get
			{
				return getBinderLocalObjectCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderLocalObjectCount9735;
		public static int getBinderLocalObjectCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderLocalObjectCount9735);
		}
		public static int BinderProxyObjectCount
		{
			get
			{
				return getBinderProxyObjectCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderProxyObjectCount9736;
		public static int getBinderProxyObjectCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderProxyObjectCount9736);
		}
		public static int BinderDeathObjectCount
		{
			get
			{
				return getBinderDeathObjectCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderDeathObjectCount9737;
		public static int getBinderDeathObjectCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderDeathObjectCount9737);
		}
		internal static global::MonoJavaBridge.MethodId _dumpService9738;
		public static bool dumpService(java.lang.String arg0, java.io.FileDescriptor arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._dumpService9738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
			global::android.os.Debug._getMemoryInfo9676 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getMemoryInfo", "(Landroid/os/Debug$MemoryInfo;)V");
			global::android.os.Debug._waitForDebugger9677 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "waitForDebugger", "()V");
			global::android.os.Debug._waitingForDebugger9678 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "waitingForDebugger", "()Z");
			global::android.os.Debug._isDebuggerConnected9679 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "isDebuggerConnected", "()Z");
			global::android.os.Debug._changeDebugPort9680 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "changeDebugPort", "(I)V");
			global::android.os.Debug._startNativeTracing9681 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startNativeTracing", "()V");
			global::android.os.Debug._stopNativeTracing9682 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "stopNativeTracing", "()V");
			global::android.os.Debug._enableEmulatorTraceOutput9683 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "enableEmulatorTraceOutput", "()V");
			global::android.os.Debug._startMethodTracing9684 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;)V");
			global::android.os.Debug._startMethodTracing9685 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;I)V");
			global::android.os.Debug._startMethodTracing9686 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;II)V");
			global::android.os.Debug._startMethodTracing9687 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "()V");
			global::android.os.Debug._stopMethodTracing9688 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "stopMethodTracing", "()V");
			global::android.os.Debug._threadCpuTimeNanos9689 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "threadCpuTimeNanos", "()J");
			global::android.os.Debug._startAllocCounting9690 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startAllocCounting", "()V");
			global::android.os.Debug._stopAllocCounting9691 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "stopAllocCounting", "()V");
			global::android.os.Debug._getGlobalAllocCount9692 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalAllocCount", "()I");
			global::android.os.Debug._getGlobalAllocSize9693 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalAllocSize", "()I");
			global::android.os.Debug._getGlobalFreedCount9694 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalFreedCount", "()I");
			global::android.os.Debug._getGlobalFreedSize9695 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalFreedSize", "()I");
			global::android.os.Debug._getGlobalClassInitCount9696 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalClassInitCount", "()I");
			global::android.os.Debug._getGlobalClassInitTime9697 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalClassInitTime", "()I");
			global::android.os.Debug._getGlobalExternalAllocCount9698 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalAllocCount", "()I");
			global::android.os.Debug._getGlobalExternalAllocSize9699 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalAllocSize", "()I");
			global::android.os.Debug._getGlobalExternalFreedCount9700 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalFreedCount", "()I");
			global::android.os.Debug._getGlobalExternalFreedSize9701 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalFreedSize", "()I");
			global::android.os.Debug._getGlobalGcInvocationCount9702 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalGcInvocationCount", "()I");
			global::android.os.Debug._getThreadAllocCount9703 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadAllocCount", "()I");
			global::android.os.Debug._getThreadAllocSize9704 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadAllocSize", "()I");
			global::android.os.Debug._getThreadExternalAllocCount9705 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadExternalAllocCount", "()I");
			global::android.os.Debug._getThreadExternalAllocSize9706 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadExternalAllocSize", "()I");
			global::android.os.Debug._getThreadGcInvocationCount9707 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadGcInvocationCount", "()I");
			global::android.os.Debug._resetGlobalAllocCount9708 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalAllocCount", "()V");
			global::android.os.Debug._resetGlobalAllocSize9709 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalAllocSize", "()V");
			global::android.os.Debug._resetGlobalFreedCount9710 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalFreedCount", "()V");
			global::android.os.Debug._resetGlobalFreedSize9711 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalFreedSize", "()V");
			global::android.os.Debug._resetGlobalClassInitCount9712 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalClassInitCount", "()V");
			global::android.os.Debug._resetGlobalClassInitTime9713 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalClassInitTime", "()V");
			global::android.os.Debug._resetGlobalExternalAllocCount9714 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalAllocCount", "()V");
			global::android.os.Debug._resetGlobalExternalAllocSize9715 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalAllocSize", "()V");
			global::android.os.Debug._resetGlobalExternalFreedCount9716 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalFreedCount", "()V");
			global::android.os.Debug._resetGlobalExternalFreedSize9717 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalFreedSize", "()V");
			global::android.os.Debug._resetGlobalGcInvocationCount9718 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalGcInvocationCount", "()V");
			global::android.os.Debug._resetThreadAllocCount9719 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadAllocCount", "()V");
			global::android.os.Debug._resetThreadAllocSize9720 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadAllocSize", "()V");
			global::android.os.Debug._resetThreadExternalAllocCount9721 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadExternalAllocCount", "()V");
			global::android.os.Debug._resetThreadExternalAllocSize9722 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadExternalAllocSize", "()V");
			global::android.os.Debug._resetThreadGcInvocationCount9723 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadGcInvocationCount", "()V");
			global::android.os.Debug._resetAllCounts9724 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetAllCounts", "()V");
			global::android.os.Debug._getNativeHeapSize9725 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getNativeHeapSize", "()J");
			global::android.os.Debug._getNativeHeapAllocatedSize9726 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getNativeHeapAllocatedSize", "()J");
			global::android.os.Debug._getNativeHeapFreeSize9727 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getNativeHeapFreeSize", "()J");
			global::android.os.Debug._setAllocationLimit9728 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "setAllocationLimit", "(I)I");
			global::android.os.Debug._setGlobalAllocationLimit9729 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "setGlobalAllocationLimit", "(I)I");
			global::android.os.Debug._printLoadedClasses9730 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "printLoadedClasses", "(I)V");
			global::android.os.Debug._getLoadedClassCount9731 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getLoadedClassCount", "()I");
			global::android.os.Debug._dumpHprofData9732 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "dumpHprofData", "(Ljava/lang/String;)V");
			global::android.os.Debug._getBinderSentTransactions9733 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderSentTransactions", "()I");
			global::android.os.Debug._getBinderReceivedTransactions9734 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderReceivedTransactions", "()I");
			global::android.os.Debug._getBinderLocalObjectCount9735 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderLocalObjectCount", "()I");
			global::android.os.Debug._getBinderProxyObjectCount9736 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderProxyObjectCount", "()I");
			global::android.os.Debug._getBinderDeathObjectCount9737 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderDeathObjectCount", "()I");
			global::android.os.Debug._dumpService9738 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "dumpService", "(Ljava/lang/String;Ljava/io/FileDescriptor;[Ljava/lang/String;)Z");
		}
	}
}
