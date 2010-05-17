namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ActivityManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ActivityManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.ActivityManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.ActivityManager(@__env); 
			} 
		} 
		protected ActivityManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class MemoryInfo : java.lang.Object, android.os.Parcelable
		{ 
			internal static global::java.lang.Class staticClass; 
			static MemoryInfo() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.ActivityManager.MemoryInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.app.ActivityManager.MemoryInfo(@__env); 
				} 
			} 
			protected MemoryInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel272; 
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.MemoryInfo)) 
					@__env.CallVoidMethod(this, _writeToParcel272, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.app.ActivityManager.MemoryInfo.staticClass, _writeToParcel272, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _describeContents273; 
			public virtual int describeContents() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.MemoryInfo)) 
					return @__env.CallIntMethod(this, _describeContents273); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.app.ActivityManager.MemoryInfo.staticClass, _describeContents273); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel274; 
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.MemoryInfo)) 
					@__env.CallVoidMethod(this, _readFromParcel274, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.app.ActivityManager.MemoryInfo.staticClass, _readFromParcel274, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _MemoryInfo275; 
			public MemoryInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.ActivityManager.MemoryInfo.staticClass, _MemoryInfo275, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _availMem276; 
			public long availMem
			{ 
				get 
				{ 
					return default(long); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _threshold277; 
			public long threshold
			{ 
				get 
				{ 
					return default(long); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _lowMemory278; 
			public bool lowMemory
			{ 
				get 
				{ 
					return default(bool); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR279; 
			public static android.os.Parcelable_Creator CREATOR
			{ 
				get 
				{ 
					return default(android.os.Parcelable_Creator); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.ActivityManager.MemoryInfo.staticClass = @__class; 
				global::android.app.ActivityManager.MemoryInfo._writeToParcel272 = @__env.GetMethodID(global::android.app.ActivityManager.MemoryInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
				global::android.app.ActivityManager.MemoryInfo._describeContents273 = @__env.GetMethodID(global::android.app.ActivityManager.MemoryInfo.staticClass, "describeContents", "()I"); 
				global::android.app.ActivityManager.MemoryInfo._readFromParcel274 = @__env.GetMethodID(global::android.app.ActivityManager.MemoryInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
				global::android.app.ActivityManager.MemoryInfo._MemoryInfo275 = @__env.GetMethodID(global::android.app.ActivityManager.MemoryInfo.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class ProcessErrorStateInfo : java.lang.Object, android.os.Parcelable
		{ 
			internal static global::java.lang.Class staticClass; 
			static ProcessErrorStateInfo() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.ActivityManager.ProcessErrorStateInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.app.ActivityManager.ProcessErrorStateInfo(@__env); 
				} 
			} 
			protected ProcessErrorStateInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel280; 
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.ProcessErrorStateInfo)) 
					@__env.CallVoidMethod(this, _writeToParcel280, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.app.ActivityManager.ProcessErrorStateInfo.staticClass, _writeToParcel280, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _describeContents281; 
			public virtual int describeContents() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.ProcessErrorStateInfo)) 
					return @__env.CallIntMethod(this, _describeContents281); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.app.ActivityManager.ProcessErrorStateInfo.staticClass, _describeContents281); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel282; 
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.ProcessErrorStateInfo)) 
					@__env.CallVoidMethod(this, _readFromParcel282, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.app.ActivityManager.ProcessErrorStateInfo.staticClass, _readFromParcel282, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _ProcessErrorStateInfo283; 
			public ProcessErrorStateInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.ActivityManager.ProcessErrorStateInfo.staticClass, _ProcessErrorStateInfo283, this); 
			} 
			public static int NO_ERROR
			{ 
				get 
				{ 
					return 0; 
				} 
			} 
			public static int CRASHED
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			public static int NOT_RESPONDING
			{ 
				get 
				{ 
					return 2; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _condition284; 
			public int condition
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _processName285; 
			public java.lang.String processName
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _pid286; 
			public int pid
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _uid287; 
			public int uid
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _tag288; 
			public java.lang.String tag
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _shortMsg289; 
			public java.lang.String shortMsg
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _longMsg290; 
			public java.lang.String longMsg
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _crashData291; 
			public byte[] crashData
			{ 
				get 
				{ 
					return default(byte[]); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR292; 
			public static android.os.Parcelable_Creator CREATOR
			{ 
				get 
				{ 
					return default(android.os.Parcelable_Creator); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass = @__class; 
				global::android.app.ActivityManager.ProcessErrorStateInfo._writeToParcel280 = @__env.GetMethodID(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
				global::android.app.ActivityManager.ProcessErrorStateInfo._describeContents281 = @__env.GetMethodID(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "describeContents", "()I"); 
				global::android.app.ActivityManager.ProcessErrorStateInfo._readFromParcel282 = @__env.GetMethodID(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
				global::android.app.ActivityManager.ProcessErrorStateInfo._ProcessErrorStateInfo283 = @__env.GetMethodID(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class RecentTaskInfo : java.lang.Object, android.os.Parcelable
		{ 
			internal static global::java.lang.Class staticClass; 
			static RecentTaskInfo() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.ActivityManager.RecentTaskInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.app.ActivityManager.RecentTaskInfo(@__env); 
				} 
			} 
			protected RecentTaskInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel293; 
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.RecentTaskInfo)) 
					@__env.CallVoidMethod(this, _writeToParcel293, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.app.ActivityManager.RecentTaskInfo.staticClass, _writeToParcel293, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _describeContents294; 
			public virtual int describeContents() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.RecentTaskInfo)) 
					return @__env.CallIntMethod(this, _describeContents294); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.app.ActivityManager.RecentTaskInfo.staticClass, _describeContents294); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel295; 
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.RecentTaskInfo)) 
					@__env.CallVoidMethod(this, _readFromParcel295, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.app.ActivityManager.RecentTaskInfo.staticClass, _readFromParcel295, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _RecentTaskInfo296; 
			public RecentTaskInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.ActivityManager.RecentTaskInfo.staticClass, _RecentTaskInfo296, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _id297; 
			public int id
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _baseIntent298; 
			public android.content.Intent baseIntent
			{ 
				get 
				{ 
					return default(android.content.Intent); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _origActivity299; 
			public android.content.ComponentName origActivity
			{ 
				get 
				{ 
					return default(android.content.ComponentName); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR300; 
			public static android.os.Parcelable_Creator CREATOR
			{ 
				get 
				{ 
					return default(android.os.Parcelable_Creator); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.ActivityManager.RecentTaskInfo.staticClass = @__class; 
				global::android.app.ActivityManager.RecentTaskInfo._writeToParcel293 = @__env.GetMethodID(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
				global::android.app.ActivityManager.RecentTaskInfo._describeContents294 = @__env.GetMethodID(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "describeContents", "()I"); 
				global::android.app.ActivityManager.RecentTaskInfo._readFromParcel295 = @__env.GetMethodID(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
				global::android.app.ActivityManager.RecentTaskInfo._RecentTaskInfo296 = @__env.GetMethodID(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class RunningAppProcessInfo : java.lang.Object, android.os.Parcelable
		{ 
			internal static global::java.lang.Class staticClass; 
			static RunningAppProcessInfo() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.ActivityManager.RunningAppProcessInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.app.ActivityManager.RunningAppProcessInfo(@__env); 
				} 
			} 
			protected RunningAppProcessInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel301; 
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.RunningAppProcessInfo)) 
					@__env.CallVoidMethod(this, _writeToParcel301, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.app.ActivityManager.RunningAppProcessInfo.staticClass, _writeToParcel301, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _describeContents302; 
			public virtual int describeContents() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.RunningAppProcessInfo)) 
					return @__env.CallIntMethod(this, _describeContents302); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.app.ActivityManager.RunningAppProcessInfo.staticClass, _describeContents302); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel303; 
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.RunningAppProcessInfo)) 
					@__env.CallVoidMethod(this, _readFromParcel303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.app.ActivityManager.RunningAppProcessInfo.staticClass, _readFromParcel303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _RunningAppProcessInfo304; 
			public RunningAppProcessInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.ActivityManager.RunningAppProcessInfo.staticClass, _RunningAppProcessInfo304, this); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _RunningAppProcessInfo305; 
			public RunningAppProcessInfo(java.lang.String arg0, int arg1, java.lang.String[] arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.ActivityManager.RunningAppProcessInfo.staticClass, _RunningAppProcessInfo305, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _processName306; 
			public java.lang.String processName
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _pid307; 
			public int pid
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _uid308; 
			public int uid
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _pkgList309; 
			public java.lang.String[] pkgList
			{ 
				get 
				{ 
					return default(java.lang.String[]); 
				} 
				set 
				{ 
				} 
			} 
			public static int IMPORTANCE_FOREGROUND
			{ 
				get 
				{ 
					return 100; 
				} 
			} 
			public static int IMPORTANCE_VISIBLE
			{ 
				get 
				{ 
					return 200; 
				} 
			} 
			public static int IMPORTANCE_SERVICE
			{ 
				get 
				{ 
					return 300; 
				} 
			} 
			public static int IMPORTANCE_BACKGROUND
			{ 
				get 
				{ 
					return 400; 
				} 
			} 
			public static int IMPORTANCE_EMPTY
			{ 
				get 
				{ 
					return 500; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _importance310; 
			public int importance
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _lru311; 
			public int lru
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			public static int REASON_UNKNOWN
			{ 
				get 
				{ 
					return 0; 
				} 
			} 
			public static int REASON_PROVIDER_IN_USE
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			public static int REASON_SERVICE_IN_USE
			{ 
				get 
				{ 
					return 2; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _importanceReasonCode312; 
			public int importanceReasonCode
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _importanceReasonPid313; 
			public int importanceReasonPid
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _importanceReasonComponent314; 
			public android.content.ComponentName importanceReasonComponent
			{ 
				get 
				{ 
					return default(android.content.ComponentName); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR315; 
			public static android.os.Parcelable_Creator CREATOR
			{ 
				get 
				{ 
					return default(android.os.Parcelable_Creator); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.ActivityManager.RunningAppProcessInfo.staticClass = @__class; 
				global::android.app.ActivityManager.RunningAppProcessInfo._writeToParcel301 = @__env.GetMethodID(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
				global::android.app.ActivityManager.RunningAppProcessInfo._describeContents302 = @__env.GetMethodID(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "describeContents", "()I"); 
				global::android.app.ActivityManager.RunningAppProcessInfo._readFromParcel303 = @__env.GetMethodID(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
				global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo304 = @__env.GetMethodID(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "<init>", "()V"); 
				global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo305 = @__env.GetMethodID(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "<init>", "(Ljava/lang/String;I[Ljava/lang/String;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class RunningServiceInfo : java.lang.Object, android.os.Parcelable
		{ 
			internal static global::java.lang.Class staticClass; 
			static RunningServiceInfo() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.ActivityManager.RunningServiceInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.app.ActivityManager.RunningServiceInfo(@__env); 
				} 
			} 
			protected RunningServiceInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel316; 
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.RunningServiceInfo)) 
					@__env.CallVoidMethod(this, _writeToParcel316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.app.ActivityManager.RunningServiceInfo.staticClass, _writeToParcel316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _describeContents317; 
			public virtual int describeContents() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.RunningServiceInfo)) 
					return @__env.CallIntMethod(this, _describeContents317); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.app.ActivityManager.RunningServiceInfo.staticClass, _describeContents317); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel318; 
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.RunningServiceInfo)) 
					@__env.CallVoidMethod(this, _readFromParcel318, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.app.ActivityManager.RunningServiceInfo.staticClass, _readFromParcel318, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _RunningServiceInfo319; 
			public RunningServiceInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.ActivityManager.RunningServiceInfo.staticClass, _RunningServiceInfo319, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _service320; 
			public android.content.ComponentName service
			{ 
				get 
				{ 
					return default(android.content.ComponentName); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _pid321; 
			public int pid
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _uid322; 
			public int uid
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _process323; 
			public java.lang.String process
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _foreground324; 
			public bool foreground
			{ 
				get 
				{ 
					return default(bool); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _activeSince325; 
			public long activeSince
			{ 
				get 
				{ 
					return default(long); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _started326; 
			public bool started
			{ 
				get 
				{ 
					return default(bool); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _clientCount327; 
			public int clientCount
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _crashCount328; 
			public int crashCount
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _lastActivityTime329; 
			public long lastActivityTime
			{ 
				get 
				{ 
					return default(long); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _restarting330; 
			public long restarting
			{ 
				get 
				{ 
					return default(long); 
				} 
				set 
				{ 
				} 
			} 
			public static int FLAG_STARTED
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			public static int FLAG_FOREGROUND
			{ 
				get 
				{ 
					return 2; 
				} 
			} 
			public static int FLAG_SYSTEM_PROCESS
			{ 
				get 
				{ 
					return 4; 
				} 
			} 
			public static int FLAG_PERSISTENT_PROCESS
			{ 
				get 
				{ 
					return 8; 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _flags331; 
			public int flags
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _clientPackage332; 
			public java.lang.String clientPackage
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _clientLabel333; 
			public int clientLabel
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR334; 
			public static android.os.Parcelable_Creator CREATOR
			{ 
				get 
				{ 
					return default(android.os.Parcelable_Creator); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.ActivityManager.RunningServiceInfo.staticClass = @__class; 
				global::android.app.ActivityManager.RunningServiceInfo._writeToParcel316 = @__env.GetMethodID(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
				global::android.app.ActivityManager.RunningServiceInfo._describeContents317 = @__env.GetMethodID(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "describeContents", "()I"); 
				global::android.app.ActivityManager.RunningServiceInfo._readFromParcel318 = @__env.GetMethodID(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
				global::android.app.ActivityManager.RunningServiceInfo._RunningServiceInfo319 = @__env.GetMethodID(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class RunningTaskInfo : java.lang.Object, android.os.Parcelable
		{ 
			internal static global::java.lang.Class staticClass; 
			static RunningTaskInfo() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.ActivityManager.RunningTaskInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.app.ActivityManager.RunningTaskInfo(@__env); 
				} 
			} 
			protected RunningTaskInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel335; 
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.RunningTaskInfo)) 
					@__env.CallVoidMethod(this, _writeToParcel335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.app.ActivityManager.RunningTaskInfo.staticClass, _writeToParcel335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _describeContents336; 
			public virtual int describeContents() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.RunningTaskInfo)) 
					return @__env.CallIntMethod(this, _describeContents336); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.app.ActivityManager.RunningTaskInfo.staticClass, _describeContents336); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel337; 
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.ActivityManager.RunningTaskInfo)) 
					@__env.CallVoidMethod(this, _readFromParcel337, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.app.ActivityManager.RunningTaskInfo.staticClass, _readFromParcel337, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _RunningTaskInfo338; 
			public RunningTaskInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.ActivityManager.RunningTaskInfo.staticClass, _RunningTaskInfo338, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _id339; 
			public int id
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _baseActivity340; 
			public android.content.ComponentName baseActivity
			{ 
				get 
				{ 
					return default(android.content.ComponentName); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _topActivity341; 
			public android.content.ComponentName topActivity
			{ 
				get 
				{ 
					return default(android.content.ComponentName); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _thumbnail342; 
			public android.graphics.Bitmap thumbnail
			{ 
				get 
				{ 
					return default(android.graphics.Bitmap); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _description343; 
			public java.lang.CharSequence description
			{ 
				get 
				{ 
					return default(java.lang.CharSequence); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _numActivities344; 
			public int numActivities
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _numRunning345; 
			public int numRunning
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR346; 
			public static android.os.Parcelable_Creator CREATOR
			{ 
				get 
				{ 
					return default(android.os.Parcelable_Creator); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.ActivityManager.RunningTaskInfo.staticClass = @__class; 
				global::android.app.ActivityManager.RunningTaskInfo._writeToParcel335 = @__env.GetMethodID(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
				global::android.app.ActivityManager.RunningTaskInfo._describeContents336 = @__env.GetMethodID(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "describeContents", "()I"); 
				global::android.app.ActivityManager.RunningTaskInfo._readFromParcel337 = @__env.GetMethodID(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
				global::android.app.ActivityManager.RunningTaskInfo._RunningTaskInfo338 = @__env.GetMethodID(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMemoryClass347; 
		public virtual int getMemoryClass() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityManager)) 
				return @__env.CallIntMethod(this, _getMemoryClass347); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.ActivityManager.staticClass, _getMemoryClass347); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRecentTasks348; 
		public virtual java.util.List getRecentTasks(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getRecentTasks348, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.ActivityManager.staticClass, _getRecentTasks348, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRunningTasks349; 
		public virtual java.util.List getRunningTasks(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getRunningTasks349, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.ActivityManager.staticClass, _getRunningTasks349, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRunningServices350; 
		public virtual java.util.List getRunningServices(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getRunningServices350, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.ActivityManager.staticClass, _getRunningServices350, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRunningServiceControlPanel351; 
		public virtual android.app.PendingIntent getRunningServiceControlPanel(android.content.ComponentName arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallObjectMethodPtr(this, _getRunningServiceControlPanel351, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.ActivityManager.staticClass, _getRunningServiceControlPanel351, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMemoryInfo352; 
		public virtual void getMemoryInfo(android.app.ActivityManager.MemoryInfo arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityManager)) 
				@__env.CallVoidMethod(this, _getMemoryInfo352, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ActivityManager.staticClass, _getMemoryInfo352, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProcessesInErrorState353; 
		public virtual java.util.List getProcessesInErrorState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getProcessesInErrorState353)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.ActivityManager.staticClass, _getProcessesInErrorState353)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRunningAppProcesses354; 
		public virtual java.util.List getRunningAppProcesses() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getRunningAppProcesses354)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.ActivityManager.staticClass, _getRunningAppProcesses354)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProcessMemoryInfo355; 
		public virtual android.os.Debug.MemoryInfo[] getProcessMemoryInfo(int[] arg0) 
		{ 
			if (GetType() == typeof(android.app.ActivityManager)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getProcessMemoryInfo355, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.ActivityManager.staticClass, _getProcessMemoryInfo355, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restartPackage356; 
		public virtual void restartPackage(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityManager)) 
				@__env.CallVoidMethod(this, _restartPackage356, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ActivityManager.staticClass, _restartPackage356, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeviceConfigurationInfo357; 
		public virtual android.content.pm.ConfigurationInfo getDeviceConfigurationInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ActivityManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ConfigurationInfo>(@__env, @__env.CallObjectMethodPtr(this, _getDeviceConfigurationInfo357)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ConfigurationInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.ActivityManager.staticClass, _getDeviceConfigurationInfo357)); 
		} 
		public static int RECENT_WITH_EXCLUDED
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.ActivityManager.staticClass = @__class; 
			global::android.app.ActivityManager._getMemoryClass347 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getMemoryClass", "()I"); 
			global::android.app.ActivityManager._getRecentTasks348 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getRecentTasks", "(II)Ljava/util/List;"); 
			global::android.app.ActivityManager._getRunningTasks349 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getRunningTasks", "(I)Ljava/util/List;"); 
			global::android.app.ActivityManager._getRunningServices350 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getRunningServices", "(I)Ljava/util/List;"); 
			global::android.app.ActivityManager._getRunningServiceControlPanel351 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getRunningServiceControlPanel", "(Landroid/content/ComponentName;)Landroid/app/PendingIntent;"); 
			global::android.app.ActivityManager._getMemoryInfo352 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getMemoryInfo", "(Landroid/app/ActivityManager$MemoryInfo;)V"); 
			global::android.app.ActivityManager._getProcessesInErrorState353 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getProcessesInErrorState", "()Ljava/util/List;"); 
			global::android.app.ActivityManager._getRunningAppProcesses354 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getRunningAppProcesses", "()Ljava/util/List;"); 
			global::android.app.ActivityManager._getProcessMemoryInfo355 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getProcessMemoryInfo", "([I)[Landroid/os/Debug/MemoryInfo;"); 
			global::android.app.ActivityManager._restartPackage356 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "restartPackage", "(Ljava/lang/String;)V"); 
			global::android.app.ActivityManager._getDeviceConfigurationInfo357 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getDeviceConfigurationInfo", "()Landroid/content/pm/ConfigurationInfo;"); 
		} 
	} 
} 
