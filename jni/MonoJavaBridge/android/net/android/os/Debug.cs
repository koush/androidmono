namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Debug : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Debug() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.Debug), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.Debug.InstructionCount), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _resetAndStart5228; 
			public virtual bool resetAndStart() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.Debug.InstructionCount)) 
					return @__env.CallBooleanMethod(this, _resetAndStart5228); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.os.Debug.InstructionCount.staticClass, _resetAndStart5228); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _collect5229; 
			public virtual bool collect() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.Debug.InstructionCount)) 
					return @__env.CallBooleanMethod(this, _collect5229); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.os.Debug.InstructionCount.staticClass, _collect5229); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _globalTotal5230; 
			public virtual int globalTotal() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.Debug.InstructionCount)) 
					return @__env.CallIntMethod(this, _globalTotal5230); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.os.Debug.InstructionCount.staticClass, _globalTotal5230); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _globalMethodInvocations5231; 
			public virtual int globalMethodInvocations() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.Debug.InstructionCount)) 
					return @__env.CallIntMethod(this, _globalMethodInvocations5231); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.os.Debug.InstructionCount.staticClass, _globalMethodInvocations5231); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _InstructionCount5232; 
			public InstructionCount()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.os.Debug.InstructionCount.staticClass, _InstructionCount5232, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.os.Debug.InstructionCount.staticClass = @__class; 
				global::android.os.Debug.InstructionCount._resetAndStart5228 = @__env.GetMethodID(global::android.os.Debug.InstructionCount.staticClass, "resetAndStart", "()Z"); 
				global::android.os.Debug.InstructionCount._collect5229 = @__env.GetMethodID(global::android.os.Debug.InstructionCount.staticClass, "collect", "()Z"); 
				global::android.os.Debug.InstructionCount._globalTotal5230 = @__env.GetMethodID(global::android.os.Debug.InstructionCount.staticClass, "globalTotal", "()I"); 
				global::android.os.Debug.InstructionCount._globalMethodInvocations5231 = @__env.GetMethodID(global::android.os.Debug.InstructionCount.staticClass, "globalMethodInvocations", "()I"); 
				global::android.os.Debug.InstructionCount._InstructionCount5232 = @__env.GetMethodID(global::android.os.Debug.InstructionCount.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class MemoryInfo : java.lang.Object, Parcelable
		{ 
			internal static global::java.lang.Class staticClass; 
			static MemoryInfo() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.Debug.MemoryInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel5233; 
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.Debug.MemoryInfo)) 
					@__env.CallVoidMethod(this, _writeToParcel5233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.os.Debug.MemoryInfo.staticClass, _writeToParcel5233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _describeContents5234; 
			public virtual int describeContents() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.Debug.MemoryInfo)) 
					return @__env.CallIntMethod(this, _describeContents5234); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.os.Debug.MemoryInfo.staticClass, _describeContents5234); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel5235; 
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.Debug.MemoryInfo)) 
					@__env.CallVoidMethod(this, _readFromParcel5235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.os.Debug.MemoryInfo.staticClass, _readFromParcel5235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getTotalPss5236; 
			public virtual int getTotalPss() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.Debug.MemoryInfo)) 
					return @__env.CallIntMethod(this, _getTotalPss5236); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.os.Debug.MemoryInfo.staticClass, _getTotalPss5236); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getTotalPrivateDirty5237; 
			public virtual int getTotalPrivateDirty() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.Debug.MemoryInfo)) 
					return @__env.CallIntMethod(this, _getTotalPrivateDirty5237); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.os.Debug.MemoryInfo.staticClass, _getTotalPrivateDirty5237); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getTotalSharedDirty5238; 
			public virtual int getTotalSharedDirty() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.Debug.MemoryInfo)) 
					return @__env.CallIntMethod(this, _getTotalSharedDirty5238); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.os.Debug.MemoryInfo.staticClass, _getTotalSharedDirty5238); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _MemoryInfo5239; 
			public MemoryInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.os.Debug.MemoryInfo.staticClass, _MemoryInfo5239, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _dalvikPss5240; 
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
			internal static global::net.sf.jni4net.jni.FieldId _dalvikPrivateDirty5241; 
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
			internal static global::net.sf.jni4net.jni.FieldId _dalvikSharedDirty5242; 
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
			internal static global::net.sf.jni4net.jni.FieldId _nativePss5243; 
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
			internal static global::net.sf.jni4net.jni.FieldId _nativePrivateDirty5244; 
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
			internal static global::net.sf.jni4net.jni.FieldId _nativeSharedDirty5245; 
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
			internal static global::net.sf.jni4net.jni.FieldId _otherPss5246; 
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
			internal static global::net.sf.jni4net.jni.FieldId _otherPrivateDirty5247; 
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
			internal static global::net.sf.jni4net.jni.FieldId _otherSharedDirty5248; 
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
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR5249; 
			public static android.os.Parcelable_Creator CREATOR
			{ 
				get 
				{ 
					return default(android.os.Parcelable_Creator); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.os.Debug.MemoryInfo.staticClass = @__class; 
				global::android.os.Debug.MemoryInfo._writeToParcel5233 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
				global::android.os.Debug.MemoryInfo._describeContents5234 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "describeContents", "()I"); 
				global::android.os.Debug.MemoryInfo._readFromParcel5235 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
				global::android.os.Debug.MemoryInfo._getTotalPss5236 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "getTotalPss", "()I"); 
				global::android.os.Debug.MemoryInfo._getTotalPrivateDirty5237 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "getTotalPrivateDirty", "()I"); 
				global::android.os.Debug.MemoryInfo._getTotalSharedDirty5238 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "getTotalSharedDirty", "()I"); 
				global::android.os.Debug.MemoryInfo._MemoryInfo5239 = @__env.GetMethodID(global::android.os.Debug.MemoryInfo.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMemoryInfo5250; 
		public static void getMemoryInfo(android.os.Debug.MemoryInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _getMemoryInfo5250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _waitForDebugger5251; 
		public static void waitForDebugger() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _waitForDebugger5251); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _waitingForDebugger5252; 
		public static bool waitingForDebugger() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, _waitingForDebugger5252); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDebuggerConnected5253; 
		public static bool isDebuggerConnected() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, _isDebuggerConnected5253); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _changeDebugPort5254; 
		public static void changeDebugPort(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _changeDebugPort5254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startNativeTracing5255; 
		public static void startNativeTracing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _startNativeTracing5255); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopNativeTracing5256; 
		public static void stopNativeTracing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _stopNativeTracing5256); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enableEmulatorTraceOutput5257; 
		public static void enableEmulatorTraceOutput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _enableEmulatorTraceOutput5257); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startMethodTracing5258; 
		public static void startMethodTracing(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _startMethodTracing5258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startMethodTracing5259; 
		public static void startMethodTracing(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _startMethodTracing5259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startMethodTracing5260; 
		public static void startMethodTracing(java.lang.String arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _startMethodTracing5260, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startMethodTracing5261; 
		public static void startMethodTracing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _startMethodTracing5261); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopMethodTracing5262; 
		public static void stopMethodTracing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _stopMethodTracing5262); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _threadCpuTimeNanos5263; 
		public static long threadCpuTimeNanos() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, _threadCpuTimeNanos5263); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startAllocCounting5264; 
		public static void startAllocCounting() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _startAllocCounting5264); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopAllocCounting5265; 
		public static void stopAllocCounting() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _stopAllocCounting5265); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalAllocCount5266; 
		public static int getGlobalAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getGlobalAllocCount5266); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalAllocSize5267; 
		public static int getGlobalAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getGlobalAllocSize5267); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalFreedCount5268; 
		public static int getGlobalFreedCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getGlobalFreedCount5268); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalFreedSize5269; 
		public static int getGlobalFreedSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getGlobalFreedSize5269); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalExternalAllocCount5270; 
		public static int getGlobalExternalAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getGlobalExternalAllocCount5270); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalExternalAllocSize5271; 
		public static int getGlobalExternalAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getGlobalExternalAllocSize5271); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalExternalFreedCount5272; 
		public static int getGlobalExternalFreedCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getGlobalExternalFreedCount5272); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalExternalFreedSize5273; 
		public static int getGlobalExternalFreedSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getGlobalExternalFreedSize5273); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlobalGcInvocationCount5274; 
		public static int getGlobalGcInvocationCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getGlobalGcInvocationCount5274); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThreadAllocCount5275; 
		public static int getThreadAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getThreadAllocCount5275); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThreadAllocSize5276; 
		public static int getThreadAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getThreadAllocSize5276); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThreadExternalAllocCount5277; 
		public static int getThreadExternalAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getThreadExternalAllocCount5277); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThreadExternalAllocSize5278; 
		public static int getThreadExternalAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getThreadExternalAllocSize5278); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThreadGcInvocationCount5279; 
		public static int getThreadGcInvocationCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getThreadGcInvocationCount5279); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalAllocCount5280; 
		public static void resetGlobalAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _resetGlobalAllocCount5280); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalAllocSize5281; 
		public static void resetGlobalAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _resetGlobalAllocSize5281); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalFreedCount5282; 
		public static void resetGlobalFreedCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _resetGlobalFreedCount5282); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalFreedSize5283; 
		public static void resetGlobalFreedSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _resetGlobalFreedSize5283); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalExternalAllocCount5284; 
		public static void resetGlobalExternalAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _resetGlobalExternalAllocCount5284); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalExternalAllocSize5285; 
		public static void resetGlobalExternalAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _resetGlobalExternalAllocSize5285); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalExternalFreedCount5286; 
		public static void resetGlobalExternalFreedCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _resetGlobalExternalFreedCount5286); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalExternalFreedSize5287; 
		public static void resetGlobalExternalFreedSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _resetGlobalExternalFreedSize5287); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetGlobalGcInvocationCount5288; 
		public static void resetGlobalGcInvocationCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _resetGlobalGcInvocationCount5288); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetThreadAllocCount5289; 
		public static void resetThreadAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _resetThreadAllocCount5289); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetThreadAllocSize5290; 
		public static void resetThreadAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _resetThreadAllocSize5290); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetThreadExternalAllocCount5291; 
		public static void resetThreadExternalAllocCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _resetThreadExternalAllocCount5291); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetThreadExternalAllocSize5292; 
		public static void resetThreadExternalAllocSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _resetThreadExternalAllocSize5292); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetThreadGcInvocationCount5293; 
		public static void resetThreadGcInvocationCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _resetThreadGcInvocationCount5293); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetAllCounts5294; 
		public static void resetAllCounts() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _resetAllCounts5294); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNativeHeapSize5295; 
		public static long getNativeHeapSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, _getNativeHeapSize5295); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNativeHeapAllocatedSize5296; 
		public static long getNativeHeapAllocatedSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, _getNativeHeapAllocatedSize5296); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNativeHeapFreeSize5297; 
		public static long getNativeHeapFreeSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, _getNativeHeapFreeSize5297); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAllocationLimit5298; 
		public static int setAllocationLimit(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _setAllocationLimit5298, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGlobalAllocationLimit5299; 
		public static int setGlobalAllocationLimit(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _setGlobalAllocationLimit5299, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _printLoadedClasses5300; 
		public static void printLoadedClasses(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _printLoadedClasses5300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLoadedClassCount5301; 
		public static int getLoadedClassCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getLoadedClassCount5301); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dumpHprofData5302; 
		public static void dumpHprofData(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, _dumpHprofData5302, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBinderSentTransactions5303; 
		public static int getBinderSentTransactions() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getBinderSentTransactions5303); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBinderReceivedTransactions5304; 
		public static int getBinderReceivedTransactions() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getBinderReceivedTransactions5304); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBinderLocalObjectCount5305; 
		public static int getBinderLocalObjectCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getBinderLocalObjectCount5305); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBinderProxyObjectCount5306; 
		public static int getBinderProxyObjectCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getBinderProxyObjectCount5306); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBinderDeathObjectCount5307; 
		public static int getBinderDeathObjectCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, _getBinderDeathObjectCount5307); 
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
			global::android.os.Debug._getMemoryInfo5250 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getMemoryInfo", "(Landroid/os/Debug$MemoryInfo;)V"); 
			global::android.os.Debug._waitForDebugger5251 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "waitForDebugger", "()V"); 
			global::android.os.Debug._waitingForDebugger5252 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "waitingForDebugger", "()Z"); 
			global::android.os.Debug._isDebuggerConnected5253 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "isDebuggerConnected", "()Z"); 
			global::android.os.Debug._changeDebugPort5254 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "changeDebugPort", "(I)V"); 
			global::android.os.Debug._startNativeTracing5255 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startNativeTracing", "()V"); 
			global::android.os.Debug._stopNativeTracing5256 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "stopNativeTracing", "()V"); 
			global::android.os.Debug._enableEmulatorTraceOutput5257 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "enableEmulatorTraceOutput", "()V"); 
			global::android.os.Debug._startMethodTracing5258 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;)V"); 
			global::android.os.Debug._startMethodTracing5259 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;I)V"); 
			global::android.os.Debug._startMethodTracing5260 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;II)V"); 
			global::android.os.Debug._startMethodTracing5261 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startMethodTracing", "()V"); 
			global::android.os.Debug._stopMethodTracing5262 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "stopMethodTracing", "()V"); 
			global::android.os.Debug._threadCpuTimeNanos5263 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "threadCpuTimeNanos", "()J"); 
			global::android.os.Debug._startAllocCounting5264 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "startAllocCounting", "()V"); 
			global::android.os.Debug._stopAllocCounting5265 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "stopAllocCounting", "()V"); 
			global::android.os.Debug._getGlobalAllocCount5266 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalAllocCount", "()I"); 
			global::android.os.Debug._getGlobalAllocSize5267 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalAllocSize", "()I"); 
			global::android.os.Debug._getGlobalFreedCount5268 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalFreedCount", "()I"); 
			global::android.os.Debug._getGlobalFreedSize5269 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalFreedSize", "()I"); 
			global::android.os.Debug._getGlobalExternalAllocCount5270 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalExternalAllocCount", "()I"); 
			global::android.os.Debug._getGlobalExternalAllocSize5271 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalExternalAllocSize", "()I"); 
			global::android.os.Debug._getGlobalExternalFreedCount5272 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalExternalFreedCount", "()I"); 
			global::android.os.Debug._getGlobalExternalFreedSize5273 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalExternalFreedSize", "()I"); 
			global::android.os.Debug._getGlobalGcInvocationCount5274 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getGlobalGcInvocationCount", "()I"); 
			global::android.os.Debug._getThreadAllocCount5275 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getThreadAllocCount", "()I"); 
			global::android.os.Debug._getThreadAllocSize5276 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getThreadAllocSize", "()I"); 
			global::android.os.Debug._getThreadExternalAllocCount5277 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getThreadExternalAllocCount", "()I"); 
			global::android.os.Debug._getThreadExternalAllocSize5278 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getThreadExternalAllocSize", "()I"); 
			global::android.os.Debug._getThreadGcInvocationCount5279 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getThreadGcInvocationCount", "()I"); 
			global::android.os.Debug._resetGlobalAllocCount5280 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalAllocCount", "()V"); 
			global::android.os.Debug._resetGlobalAllocSize5281 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalAllocSize", "()V"); 
			global::android.os.Debug._resetGlobalFreedCount5282 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalFreedCount", "()V"); 
			global::android.os.Debug._resetGlobalFreedSize5283 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalFreedSize", "()V"); 
			global::android.os.Debug._resetGlobalExternalAllocCount5284 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalExternalAllocCount", "()V"); 
			global::android.os.Debug._resetGlobalExternalAllocSize5285 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalExternalAllocSize", "()V"); 
			global::android.os.Debug._resetGlobalExternalFreedCount5286 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalExternalFreedCount", "()V"); 
			global::android.os.Debug._resetGlobalExternalFreedSize5287 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalExternalFreedSize", "()V"); 
			global::android.os.Debug._resetGlobalGcInvocationCount5288 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetGlobalGcInvocationCount", "()V"); 
			global::android.os.Debug._resetThreadAllocCount5289 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetThreadAllocCount", "()V"); 
			global::android.os.Debug._resetThreadAllocSize5290 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetThreadAllocSize", "()V"); 
			global::android.os.Debug._resetThreadExternalAllocCount5291 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetThreadExternalAllocCount", "()V"); 
			global::android.os.Debug._resetThreadExternalAllocSize5292 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetThreadExternalAllocSize", "()V"); 
			global::android.os.Debug._resetThreadGcInvocationCount5293 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetThreadGcInvocationCount", "()V"); 
			global::android.os.Debug._resetAllCounts5294 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "resetAllCounts", "()V"); 
			global::android.os.Debug._getNativeHeapSize5295 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getNativeHeapSize", "()J"); 
			global::android.os.Debug._getNativeHeapAllocatedSize5296 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getNativeHeapAllocatedSize", "()J"); 
			global::android.os.Debug._getNativeHeapFreeSize5297 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getNativeHeapFreeSize", "()J"); 
			global::android.os.Debug._setAllocationLimit5298 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "setAllocationLimit", "(I)I"); 
			global::android.os.Debug._setGlobalAllocationLimit5299 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "setGlobalAllocationLimit", "(I)I"); 
			global::android.os.Debug._printLoadedClasses5300 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "printLoadedClasses", "(I)V"); 
			global::android.os.Debug._getLoadedClassCount5301 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getLoadedClassCount", "()I"); 
			global::android.os.Debug._dumpHprofData5302 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "dumpHprofData", "(Ljava/lang/String;)V"); 
			global::android.os.Debug._getBinderSentTransactions5303 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getBinderSentTransactions", "()I"); 
			global::android.os.Debug._getBinderReceivedTransactions5304 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getBinderReceivedTransactions", "()I"); 
			global::android.os.Debug._getBinderLocalObjectCount5305 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getBinderLocalObjectCount", "()I"); 
			global::android.os.Debug._getBinderProxyObjectCount5306 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getBinderProxyObjectCount", "()I"); 
			global::android.os.Debug._getBinderDeathObjectCount5307 = @__env.GetStaticMethodID(global::android.os.Debug.staticClass, "getBinderDeathObjectCount", "()I"); 
		} 
	} 
} 
