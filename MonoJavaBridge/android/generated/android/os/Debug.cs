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
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual bool resetAndStart()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Debug.InstructionCount.staticClass, "resetAndStart", "()Z", ref global::android.os.Debug.InstructionCount._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual bool collect()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Debug.InstructionCount.staticClass, "collect", "()Z", ref global::android.os.Debug.InstructionCount._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual int globalTotal()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Debug.InstructionCount.staticClass, "globalTotal", "()I", ref global::android.os.Debug.InstructionCount._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual int globalMethodInvocations()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Debug.InstructionCount.staticClass, "globalMethodInvocations", "()I", ref global::android.os.Debug.InstructionCount._m3);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public InstructionCount() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.Debug.InstructionCount._m4.native == global::System.IntPtr.Zero)
					global::android.os.Debug.InstructionCount._m4 = @__env.GetMethodIDNoThrow(global::android.os.Debug.InstructionCount.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Debug.InstructionCount.staticClass, global::android.os.Debug.InstructionCount._m4);
				Init(@__env, handle);
			}
			static InstructionCount()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Debug.InstructionCount.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Debug$InstructionCount"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Debug.MemoryInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.os.Debug.MemoryInfo._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual int describeContents()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, "describeContents", "()I", ref global::android.os.Debug.MemoryInfo._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void readFromParcel(android.os.Parcel arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Debug.MemoryInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.os.Debug.MemoryInfo._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int TotalPss
			{
				get
				{
					return getTotalPss();
				}
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual int getTotalPss()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, "getTotalPss", "()I", ref global::android.os.Debug.MemoryInfo._m3);
			}
			public new int TotalPrivateDirty
			{
				get
				{
					return getTotalPrivateDirty();
				}
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual int getTotalPrivateDirty()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, "getTotalPrivateDirty", "()I", ref global::android.os.Debug.MemoryInfo._m4);
			}
			public new int TotalSharedDirty
			{
				get
				{
					return getTotalSharedDirty();
				}
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual int getTotalSharedDirty()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Debug.MemoryInfo.staticClass, "getTotalSharedDirty", "()I", ref global::android.os.Debug.MemoryInfo._m5);
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public MemoryInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.Debug.MemoryInfo._m6.native == global::System.IntPtr.Zero)
					global::android.os.Debug.MemoryInfo._m6 = @__env.GetMethodIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Debug.MemoryInfo.staticClass, global::android.os.Debug.MemoryInfo._m6);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _dalvikPss3948;
			public int dalvikPss
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _dalvikPss3948);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _dalvikPrivateDirty3949;
			public int dalvikPrivateDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _dalvikPrivateDirty3949);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _dalvikSharedDirty3950;
			public int dalvikSharedDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _dalvikSharedDirty3950);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _nativePss3951;
			public int nativePss
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _nativePss3951);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _nativePrivateDirty3952;
			public int nativePrivateDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _nativePrivateDirty3952);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _nativeSharedDirty3953;
			public int nativeSharedDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _nativeSharedDirty3953);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _otherPss3954;
			public int otherPss
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _otherPss3954);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _otherPrivateDirty3955;
			public int otherPrivateDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _otherPrivateDirty3955);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _otherSharedDirty3956;
			public int otherSharedDirty
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _otherSharedDirty3956);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR3957;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.Debug.MemoryInfo.staticClass, _CREATOR3957)) as android.os.Parcelable_Creator;
				}
			}
			static MemoryInfo()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.Debug.MemoryInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Debug$MemoryInfo"));
				global::android.os.Debug.MemoryInfo._dalvikPss3948 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "dalvikPss", "I");
				global::android.os.Debug.MemoryInfo._dalvikPrivateDirty3949 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "dalvikPrivateDirty", "I");
				global::android.os.Debug.MemoryInfo._dalvikSharedDirty3950 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "dalvikSharedDirty", "I");
				global::android.os.Debug.MemoryInfo._nativePss3951 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "nativePss", "I");
				global::android.os.Debug.MemoryInfo._nativePrivateDirty3952 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "nativePrivateDirty", "I");
				global::android.os.Debug.MemoryInfo._nativeSharedDirty3953 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "nativeSharedDirty", "I");
				global::android.os.Debug.MemoryInfo._otherPss3954 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "otherPss", "I");
				global::android.os.Debug.MemoryInfo._otherPrivateDirty3955 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "otherPrivateDirty", "I");
				global::android.os.Debug.MemoryInfo._otherSharedDirty3956 = @__env.GetFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "otherSharedDirty", "I");
				global::android.os.Debug.MemoryInfo._CREATOR3957 = @__env.GetStaticFieldIDNoThrow(global::android.os.Debug.MemoryInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void getMemoryInfo(android.os.Debug.MemoryInfo arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m0.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m0 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getMemoryInfo", "(Landroid/os/Debug$MemoryInfo;)V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void waitForDebugger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m1.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m1 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "waitForDebugger", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static bool waitingForDebugger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m2.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m2 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "waitingForDebugger", "()Z");
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static bool isDebuggerConnected()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m3.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m3 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "isDebuggerConnected", "()Z");
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void changeDebugPort(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m4.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m4 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "changeDebugPort", "(I)V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void startNativeTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m5.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m5 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startNativeTracing", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void stopNativeTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m6.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m6 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "stopNativeTracing", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void enableEmulatorTraceOutput()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m7.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m7 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "enableEmulatorTraceOutput", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void startMethodTracing(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m8.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m8 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static void startMethodTracing(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m9.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m9 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;I)V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static void startMethodTracing(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m10.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m10 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "(Ljava/lang/String;II)V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static void startMethodTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m11.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m11 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startMethodTracing", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void stopMethodTracing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m12.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m12 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "stopMethodTracing", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static long threadCpuTimeNanos()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m13.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m13 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "threadCpuTimeNanos", "()J");
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static void startAllocCounting()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m14.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m14 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "startAllocCounting", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static void stopAllocCounting()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m15.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m15 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "stopAllocCounting", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m15);
		}
		public static int GlobalAllocCount
		{
			get
			{
				return getGlobalAllocCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static int getGlobalAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m16.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m16 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalAllocCount", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m16);
		}
		public static int GlobalAllocSize
		{
			get
			{
				return getGlobalAllocSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static int getGlobalAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m17.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m17 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalAllocSize", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m17);
		}
		public static int GlobalFreedCount
		{
			get
			{
				return getGlobalFreedCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static int getGlobalFreedCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m18.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m18 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalFreedCount", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m18);
		}
		public static int GlobalFreedSize
		{
			get
			{
				return getGlobalFreedSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static int getGlobalFreedSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m19.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m19 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalFreedSize", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m19);
		}
		public static int GlobalClassInitCount
		{
			get
			{
				return getGlobalClassInitCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static int getGlobalClassInitCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m20.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m20 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalClassInitCount", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m20);
		}
		public static int GlobalClassInitTime
		{
			get
			{
				return getGlobalClassInitTime();
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static int getGlobalClassInitTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m21.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m21 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalClassInitTime", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m21);
		}
		public static int GlobalExternalAllocCount
		{
			get
			{
				return getGlobalExternalAllocCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static int getGlobalExternalAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m22.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m22 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalAllocCount", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m22);
		}
		public static int GlobalExternalAllocSize
		{
			get
			{
				return getGlobalExternalAllocSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static int getGlobalExternalAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m23.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m23 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalAllocSize", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m23);
		}
		public static int GlobalExternalFreedCount
		{
			get
			{
				return getGlobalExternalFreedCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static int getGlobalExternalFreedCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m24.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m24 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalFreedCount", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m24);
		}
		public static int GlobalExternalFreedSize
		{
			get
			{
				return getGlobalExternalFreedSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static int getGlobalExternalFreedSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m25.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m25 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalExternalFreedSize", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m25);
		}
		public static int GlobalGcInvocationCount
		{
			get
			{
				return getGlobalGcInvocationCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static int getGlobalGcInvocationCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m26.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m26 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getGlobalGcInvocationCount", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m26);
		}
		public static int ThreadAllocCount
		{
			get
			{
				return getThreadAllocCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static int getThreadAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m27.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m27 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadAllocCount", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m27);
		}
		public static int ThreadAllocSize
		{
			get
			{
				return getThreadAllocSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static int getThreadAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m28.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m28 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadAllocSize", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m28);
		}
		public static int ThreadExternalAllocCount
		{
			get
			{
				return getThreadExternalAllocCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static int getThreadExternalAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m29.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m29 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadExternalAllocCount", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m29);
		}
		public static int ThreadExternalAllocSize
		{
			get
			{
				return getThreadExternalAllocSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static int getThreadExternalAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m30.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m30 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadExternalAllocSize", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m30);
		}
		public static int ThreadGcInvocationCount
		{
			get
			{
				return getThreadGcInvocationCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static int getThreadGcInvocationCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m31.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m31 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getThreadGcInvocationCount", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static void resetGlobalAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m32.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m32 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalAllocCount", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public static void resetGlobalAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m33.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m33 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalAllocSize", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public static void resetGlobalFreedCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m34.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m34 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalFreedCount", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m34);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static void resetGlobalFreedSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m35.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m35 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalFreedSize", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public static void resetGlobalClassInitCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m36.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m36 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalClassInitCount", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m36);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public static void resetGlobalClassInitTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m37.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m37 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalClassInitTime", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public static void resetGlobalExternalAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m38.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m38 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalAllocCount", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m38);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public static void resetGlobalExternalAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m39.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m39 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalAllocSize", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m39);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public static void resetGlobalExternalFreedCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m40.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m40 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalFreedCount", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m40);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public static void resetGlobalExternalFreedSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m41.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m41 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalExternalFreedSize", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m41);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public static void resetGlobalGcInvocationCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m42.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m42 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetGlobalGcInvocationCount", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m42);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public static void resetThreadAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m43.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m43 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadAllocCount", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m43);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public static void resetThreadAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m44.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m44 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadAllocSize", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m44);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public static void resetThreadExternalAllocCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m45.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m45 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadExternalAllocCount", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m45);
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public static void resetThreadExternalAllocSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m46.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m46 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadExternalAllocSize", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m46);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public static void resetThreadGcInvocationCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m47.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m47 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetThreadGcInvocationCount", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m47);
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public static void resetAllCounts()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m48.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m48 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "resetAllCounts", "()V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m48);
		}
		public static long NativeHeapSize
		{
			get
			{
				return getNativeHeapSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public static long getNativeHeapSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m49.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m49 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getNativeHeapSize", "()J");
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._m49);
		}
		public static long NativeHeapAllocatedSize
		{
			get
			{
				return getNativeHeapAllocatedSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public static long getNativeHeapAllocatedSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m50.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m50 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getNativeHeapAllocatedSize", "()J");
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._m50);
		}
		public static long NativeHeapFreeSize
		{
			get
			{
				return getNativeHeapFreeSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public static long getNativeHeapFreeSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m51.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m51 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getNativeHeapFreeSize", "()J");
			return @__env.CallStaticLongMethod(android.os.Debug.staticClass, global::android.os.Debug._m51);
		}
		public static int AllocationLimit
		{
			set
			{
				setAllocationLimit(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public static int setAllocationLimit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m52.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m52 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "setAllocationLimit", "(I)I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int GlobalAllocationLimit
		{
			set
			{
				setGlobalAllocationLimit(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public static int setGlobalAllocationLimit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m53.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m53 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "setGlobalAllocationLimit", "(I)I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public static void printLoadedClasses(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m54.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m54 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "printLoadedClasses", "(I)V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int LoadedClassCount
		{
			get
			{
				return getLoadedClassCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public static int getLoadedClassCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m55.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m55 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getLoadedClassCount", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m55);
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public static void dumpHprofData(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m56.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m56 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "dumpHprofData", "(Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.os.Debug.staticClass, global::android.os.Debug._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int BinderSentTransactions
		{
			get
			{
				return getBinderSentTransactions();
			}
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public static int getBinderSentTransactions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m57.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m57 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderSentTransactions", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m57);
		}
		public static int BinderReceivedTransactions
		{
			get
			{
				return getBinderReceivedTransactions();
			}
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public static int getBinderReceivedTransactions()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m58.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m58 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderReceivedTransactions", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m58);
		}
		public static int BinderLocalObjectCount
		{
			get
			{
				return getBinderLocalObjectCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public static int getBinderLocalObjectCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m59.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m59 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderLocalObjectCount", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m59);
		}
		public static int BinderProxyObjectCount
		{
			get
			{
				return getBinderProxyObjectCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public static int getBinderProxyObjectCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m60.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m60 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderProxyObjectCount", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m60);
		}
		public static int BinderDeathObjectCount
		{
			get
			{
				return getBinderDeathObjectCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public static int getBinderDeathObjectCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m61.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m61 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "getBinderDeathObjectCount", "()I");
			return @__env.CallStaticIntMethod(android.os.Debug.staticClass, global::android.os.Debug._m61);
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public static bool dumpService(java.lang.String arg0, java.io.FileDescriptor arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Debug._m62.native == global::System.IntPtr.Zero)
				global::android.os.Debug._m62 = @__env.GetStaticMethodIDNoThrow(global::android.os.Debug.staticClass, "dumpService", "(Ljava/lang/String;Ljava/io/FileDescriptor;[Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.os.Debug.staticClass, global::android.os.Debug._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		}
		internal static void InitJNI()
		{
		}
	}
}
