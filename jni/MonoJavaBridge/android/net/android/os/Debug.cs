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
			internal static global::net.sf.jni4net.jni.MethodId _resetAndStart5486; 
			public virtual bool resetAndStart() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.os.Debug.InstructionCount._resetAndStart5486); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._resetAndStart5486); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _collect5487; 
			public virtual bool collect() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.os.Debug.InstructionCount._collect5487); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._collect5487); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _globalTotal5488; 
			public virtual int globalTotal() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallIntMethod(this, global::android.os.Debug.InstructionCount._globalTotal5488); 
				else 
					return @__env.CallNonVirtualIntMethod(this, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._globalTotal5488); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _globalMethodInvocations5489; 
			public virtual int globalMethodInvocations() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallIntMethod(this, global::android.os.Debug.InstructionCount._globalMethodInvocations5489); 
				else 
					return @__env.CallNonVirtualIntMethod(this, global::android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._globalMethodInvocations5489); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _InstructionCount5490; 
			public InstructionCount()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._InstructionCount5490, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.os.Debug.InstructionCount.staticClass = @__class; 
				global::android.os.Debug.InstructionCount._resetAndStart5486 = @__env.GetMethodID(global::android.os.Debug.InstructionCount.staticClass, "resetAndStart", "()Z"); 
				global::android.os.Debug.InstructionCount._collect5487 = @__env.GetMethodID(global::android.os.Debug.InstructionCount.staticClass, "collect", "()Z"); 
				global::android.os.Debug.InstructionCount._globalTotal5488 = @__env.GetMethodID(global::android.os.Debug.InstructionCount.staticClass, "globalTotal", "()I"); 
				global::android.os.Debug.InstructionCount._globalMethodInvocations5489 = @__env.GetMethodID(global::android.os.Debug.InstructionCount.staticClass, "globalMethodInvocations", "()I"); 
				global::android.os.Debug.InstructionCount._InstructionCount5490 = @__env.GetMethodID(global::android.os.Debug.InstructionCount.staticClass, "<init>", "()V"); 
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
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel5491; 
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.os.Debug.MemoryInfo._writeToParcel5491, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._writeToParcel5491, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _describeContents5492; 
			public virtual int describeContents() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallIntMethod(this, global::android.os.Debug.MemoryInfo._describeContents5492); 
				else 
					return @__env.CallNonVirtualIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._describeContents5492); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel5493; 
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.os.Debug.MemoryInfo._readFromParcel5493, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._readFromParcel5493, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getTotalPss5494; 
			public virtual int getTotalPss() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallIntMethod(this, global::android.os.Debug.MemoryInfo._getTotalPss5494); 
				else 
					return @__env.CallNonVirtualIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._getTotalPss5494); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getTotalPrivateDirty5495; 
			public virtual int getTotalPrivateDirty() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallIntMethod(this, global::android.os.Debug.MemoryInfo._getTotalPrivateDirty5495); 
				else 
					return @__env.CallNonVirtualIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._getTotalPrivateDirty5495); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getTotalSharedDirty5496; 
			public virtual int getTotalSharedDirty() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallIntMethod(this, global::android.os.Debug.MemoryInfo._getTotalSharedDirty5496); 
				else 
					return @__env.CallNonVirtualIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._getTotalSharedDirty5496); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _MemoryInfo5497; 
			public MemoryInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._MemoryInfo5497, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _dalvikPss5498; 
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
			internal static global::net.sf.jni4net.jni.FieldId _dalvikPrivateDirty5499; 
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
			internal static global::net.sf.jni4net.jni.FieldId _dalvikSharedDirty5500; 
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
			internal static global::net.sf.jni4net.jni.FieldId _nativePss5501; 
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
			internal static global::net.sf.jni4net.jni.FieldId _nativePrivateDirty5502; 
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
			internal static global::net.sf.jni4net.jni.FieldId _nativeSharedDirty5503; 
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
			internal static global::net.sf.jni4net.jni.FieldId _otherPss5504; 
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
			internal static global::net.sf.jni4net.jni.FieldId _otherPrivateDirty5505; 
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
			internal static global::net.sf.jni4net.jni.FieldId _otherSharedDirty5506; 
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
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR5507; 
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
				global::android.os.Debug.MemoryInfo._writeToParcel5491 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
				global::android.os.Debug.MemoryInfo._describeContents5492 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "describeContents", "()I"); 
				global::android.os.Debug.MemoryInfo._readFromParcel5493 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
				global::android.os.Debug.MemoryInfo._getTotalPss5494 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "getTotalPss", "()I"); 
				global::android.os.Debug.MemoryInfo._getTotalPrivateDirty5495 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "getTotalPrivateDirty", "()I"); 
				global::android.os.Debug.MemoryInfo._getTotalSharedDirty5496 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "getTotalSharedDirty", "()I"); 
				global::android.os.Debug.MemoryInfo._MemoryInfo5497 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMemoryInfo5508; 
		public static void getMemoryInfo(android.os.Debug.MemoryInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._getMemoryInfo5508, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _waitForDebugger5509; 
		public static void waitForDebugger() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._waitForDebugger5509); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _waitingForDebugger5510; 
		public static bool waitingForDebugger() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._waitingForDebugger5510); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDebuggerConnected5511; 
		public static bool isDebuggerConnected() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._isDebuggerConnected5511); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _changeDebugPort5512; 
		public static void changeDebugPort(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._changeDebugPort5512, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startNativeTracing5513; 
		public static void startNativeTracing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startNativeTracing5513); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopNativeTracing5514; 
		public static void stopNativeTracing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._stopNativeTracing5514); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enableEmulatorTraceOutput5515; 
		public static void enableEmulatorTraceOutput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._enableEmulatorTraceOutput5515); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startMethodTracing5516; 
		public static void startMethodTracing(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing5516, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startMethodTracing5517; 
		public static void startMethodTracing(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing5517, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startMethodTracing5518; 
		public static void startMethodTracing(java.lang.String arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing5518, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startMethodTracing5519; 
		public static void startMethodTracing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startMethodTracing5519); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopMethodTracing5520; 
		public static void stopMethodTracing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._stopMethodTracing5520); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _threadCpuTimeNanos5521; 
		public static long threadCpuTimeNanos() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._threadCpuTimeNanos5521); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startAllocCounting5522; 
		public static void startAllocCounting() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._startAllocCounting5522); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopAllocCounting5523; 
		public static void stopAllocCounting() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._stopAllocCounting5523); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalAllocCount5524; 
		public static int getGlobalAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalAllocCount5524); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalAllocSize5525; 
		public static int getGlobalAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalAllocSize5525); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalFreedCount5526; 
		public static int getGlobalFreedCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalFreedCount5526); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalFreedSize5527; 
		public static int getGlobalFreedSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalFreedSize5527); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalExternalAllocCount5528; 
		public static int getGlobalExternalAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalAllocCount5528); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalExternalAllocSize5529; 
		public static int getGlobalExternalAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalAllocSize5529); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalExternalFreedCount5530; 
		public static int getGlobalExternalFreedCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalFreedCount5530); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalExternalFreedSize5531; 
		public static int getGlobalExternalFreedSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalExternalFreedSize5531); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalGcInvocationCount5532; 
		public static int getGlobalGcInvocationCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getGlobalGcInvocationCount5532); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThreadAllocCount5533; 
		public static int getThreadAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadAllocCount5533); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThreadAllocSize5534; 
		public static int getThreadAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadAllocSize5534); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThreadExternalAllocCount5535; 
		public static int getThreadExternalAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadExternalAllocCount5535); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThreadExternalAllocSize5536; 
		public static int getThreadExternalAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadExternalAllocSize5536); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThreadGcInvocationCount5537; 
		public static int getThreadGcInvocationCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getThreadGcInvocationCount5537); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalAllocCount5538; 
		public static void resetGlobalAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalAllocCount5538); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalAllocSize5539; 
		public static void resetGlobalAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalAllocSize5539); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalFreedCount5540; 
		public static void resetGlobalFreedCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalFreedCount5540); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalFreedSize5541; 
		public static void resetGlobalFreedSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalFreedSize5541); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalExternalAllocCount5542; 
		public static void resetGlobalExternalAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalAllocCount5542); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalExternalAllocSize5543; 
		public static void resetGlobalExternalAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalAllocSize5543); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalExternalFreedCount5544; 
		public static void resetGlobalExternalFreedCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalFreedCount5544); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalExternalFreedSize5545; 
		public static void resetGlobalExternalFreedSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalExternalFreedSize5545); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalGcInvocationCount5546; 
		public static void resetGlobalGcInvocationCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetGlobalGcInvocationCount5546); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetThreadAllocCount5547; 
		public static void resetThreadAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadAllocCount5547); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetThreadAllocSize5548; 
		public static void resetThreadAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadAllocSize5548); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetThreadExternalAllocCount5549; 
		public static void resetThreadExternalAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadExternalAllocCount5549); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetThreadExternalAllocSize5550; 
		public static void resetThreadExternalAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadExternalAllocSize5550); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetThreadGcInvocationCount5551; 
		public static void resetThreadGcInvocationCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetThreadGcInvocationCount5551); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetAllCounts5552; 
		public static void resetAllCounts() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._resetAllCounts5552); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNativeHeapSize5553; 
		public static long getNativeHeapSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._getNativeHeapSize5553); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNativeHeapAllocatedSize5554; 
		public static long getNativeHeapAllocatedSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._getNativeHeapAllocatedSize5554); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNativeHeapFreeSize5555; 
		public static long getNativeHeapFreeSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._getNativeHeapFreeSize5555); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAllocationLimit5556; 
		public static int setAllocationLimit(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._setAllocationLimit5556, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGlobalAllocationLimit5557; 
		public static int setGlobalAllocationLimit(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._setGlobalAllocationLimit5557, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _printLoadedClasses5558; 
		public static void printLoadedClasses(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._printLoadedClasses5558, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLoadedClassCount5559; 
		public static int getLoadedClassCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getLoadedClassCount5559); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpHprofData5560; 
		public static void dumpHprofData(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._dumpHprofData5560, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBinderSentTransactions5561; 
		public static int getBinderSentTransactions() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderSentTransactions5561); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBinderReceivedTransactions5562; 
		public static int getBinderReceivedTransactions() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderReceivedTransactions5562); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBinderLocalObjectCount5563; 
		public static int getBinderLocalObjectCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderLocalObjectCount5563); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBinderProxyObjectCount5564; 
		public static int getBinderProxyObjectCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderProxyObjectCount5564); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBinderDeathObjectCount5565; 
		public static int getBinderDeathObjectCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._getBinderDeathObjectCount5565); 
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
			global::android.os.Debug._getMemoryInfo5508 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getMemoryInfo", "(Landroid/os/Debug$MemoryInfo;)V"); 
			global::android.os.Debug._waitForDebugger5509 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "waitForDebugger", "()V"); 
			global::android.os.Debug._waitingForDebugger5510 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "waitingForDebugger", "()Z"); 
			global::android.os.Debug._isDebuggerConnected5511 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "isDebuggerConnected", "()Z"); 
			global::android.os.Debug._changeDebugPort5512 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "changeDebugPort", "(I)V"); 
			global::android.os.Debug._startNativeTracing5513 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startNativeTracing", "()V"); 
			global::android.os.Debug._stopNativeTracing5514 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "stopNativeTracing", "()V"); 
			global::android.os.Debug._enableEmulatorTraceOutput5515 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "enableEmulatorTraceOutput", "()V"); 
			global::android.os.Debug._startMethodTracing5516 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;)V"); 
			global::android.os.Debug._startMethodTracing5517 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;I)V"); 
			global::android.os.Debug._startMethodTracing5518 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;II)V"); 
			global::android.os.Debug._startMethodTracing5519 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startMethodTracing", "()V"); 
			global::android.os.Debug._stopMethodTracing5520 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "stopMethodTracing", "()V"); 
			global::android.os.Debug._threadCpuTimeNanos5521 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "threadCpuTimeNanos", "()J"); 
			global::android.os.Debug._startAllocCounting5522 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startAllocCounting", "()V"); 
			global::android.os.Debug._stopAllocCounting5523 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "stopAllocCounting", "()V"); 
			global::android.os.Debug._getGlobalAllocCount5524 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalAllocCount", "()I"); 
			global::android.os.Debug._getGlobalAllocSize5525 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalAllocSize", "()I"); 
			global::android.os.Debug._getGlobalFreedCount5526 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalFreedCount", "()I"); 
			global::android.os.Debug._getGlobalFreedSize5527 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalFreedSize", "()I"); 
			global::android.os.Debug._getGlobalExternalAllocCount5528 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalExternalAllocCount", "()I"); 
			global::android.os.Debug._getGlobalExternalAllocSize5529 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalExternalAllocSize", "()I"); 
			global::android.os.Debug._getGlobalExternalFreedCount5530 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalExternalFreedCount", "()I"); 
			global::android.os.Debug._getGlobalExternalFreedSize5531 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalExternalFreedSize", "()I"); 
			global::android.os.Debug._getGlobalGcInvocationCount5532 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalGcInvocationCount", "()I"); 
			global::android.os.Debug._getThreadAllocCount5533 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getThreadAllocCount", "()I"); 
			global::android.os.Debug._getThreadAllocSize5534 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getThreadAllocSize", "()I"); 
			global::android.os.Debug._getThreadExternalAllocCount5535 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getThreadExternalAllocCount", "()I"); 
			global::android.os.Debug._getThreadExternalAllocSize5536 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getThreadExternalAllocSize", "()I"); 
			global::android.os.Debug._getThreadGcInvocationCount5537 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getThreadGcInvocationCount", "()I"); 
			global::android.os.Debug._resetGlobalAllocCount5538 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalAllocCount", "()V"); 
			global::android.os.Debug._resetGlobalAllocSize5539 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalAllocSize", "()V"); 
			global::android.os.Debug._resetGlobalFreedCount5540 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalFreedCount", "()V"); 
			global::android.os.Debug._resetGlobalFreedSize5541 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalFreedSize", "()V"); 
			global::android.os.Debug._resetGlobalExternalAllocCount5542 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalExternalAllocCount", "()V"); 
			global::android.os.Debug._resetGlobalExternalAllocSize5543 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalExternalAllocSize", "()V"); 
			global::android.os.Debug._resetGlobalExternalFreedCount5544 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalExternalFreedCount", "()V"); 
			global::android.os.Debug._resetGlobalExternalFreedSize5545 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalExternalFreedSize", "()V"); 
			global::android.os.Debug._resetGlobalGcInvocationCount5546 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalGcInvocationCount", "()V"); 
			global::android.os.Debug._resetThreadAllocCount5547 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetThreadAllocCount", "()V"); 
			global::android.os.Debug._resetThreadAllocSize5548 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetThreadAllocSize", "()V"); 
			global::android.os.Debug._resetThreadExternalAllocCount5549 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetThreadExternalAllocCount", "()V"); 
			global::android.os.Debug._resetThreadExternalAllocSize5550 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetThreadExternalAllocSize", "()V"); 
			global::android.os.Debug._resetThreadGcInvocationCount5551 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetThreadGcInvocationCount", "()V"); 
			global::android.os.Debug._resetAllCounts5552 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetAllCounts", "()V"); 
			global::android.os.Debug._getNativeHeapSize5553 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getNativeHeapSize", "()J"); 
			global::android.os.Debug._getNativeHeapAllocatedSize5554 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getNativeHeapAllocatedSize", "()J"); 
			global::android.os.Debug._getNativeHeapFreeSize5555 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getNativeHeapFreeSize", "()J"); 
			global::android.os.Debug._setAllocationLimit5556 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "setAllocationLimit", "(I)I"); 
			global::android.os.Debug._setGlobalAllocationLimit5557 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "setGlobalAllocationLimit", "(I)I"); 
			global::android.os.Debug._printLoadedClasses5558 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "printLoadedClasses", "(I)V"); 
			global::android.os.Debug._getLoadedClassCount5559 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getLoadedClassCount", "()I"); 
			global::android.os.Debug._dumpHprofData5560 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "dumpHprofData", "(Ljava/lang/String;)V"); 
			global::android.os.Debug._getBinderSentTransactions5561 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getBinderSentTransactions", "()I"); 
			global::android.os.Debug._getBinderReceivedTransactions5562 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getBinderReceivedTransactions", "()I"); 
			global::android.os.Debug._getBinderLocalObjectCount5563 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getBinderLocalObjectCount", "()I"); 
			global::android.os.Debug._getBinderProxyObjectCount5564 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getBinderProxyObjectCount", "()I"); 
			global::android.os.Debug._getBinderDeathObjectCount5565 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getBinderDeathObjectCount", "()I"); 
		} 
	} 
} 
