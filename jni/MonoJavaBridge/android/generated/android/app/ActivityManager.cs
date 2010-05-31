namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ActivityManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ActivityManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.ActivityManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.ActivityManager.MemoryInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel279;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.MemoryInfo._writeToParcel279, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._writeToParcel279, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _describeContents280;
			public virtual int describeContents() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.app.ActivityManager.MemoryInfo._describeContents280);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._describeContents280);
			}
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel281;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.MemoryInfo._readFromParcel281, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._readFromParcel281, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _MemoryInfo282;
			public MemoryInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._MemoryInfo282, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _availMem283;
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
			internal static global::net.sf.jni4net.jni.FieldId _threshold284;
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
			internal static global::net.sf.jni4net.jni.FieldId _lowMemory285;
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
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR286;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.ActivityManager.MemoryInfo.staticClass = @__class;
				global::android.app.ActivityManager.MemoryInfo._writeToParcel279 = @__env.GetMethodID(global::android.app.ActivityManager.MemoryInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.MemoryInfo._describeContents280 = @__env.GetMethodID(global::android.app.ActivityManager.MemoryInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.MemoryInfo._readFromParcel281 = @__env.GetMethodID(global::android.app.ActivityManager.MemoryInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.MemoryInfo._MemoryInfo282 = @__env.GetMethodID(global::android.app.ActivityManager.MemoryInfo.staticClass, "<init>", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class ProcessErrorStateInfo : java.lang.Object, android.os.Parcelable
		{
			internal static global::java.lang.Class staticClass;
			static ProcessErrorStateInfo()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.ActivityManager.ProcessErrorStateInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel287;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.ProcessErrorStateInfo._writeToParcel287, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._writeToParcel287, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _describeContents288;
			public virtual int describeContents() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.app.ActivityManager.ProcessErrorStateInfo._describeContents288);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._describeContents288);
			}
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel289;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.ProcessErrorStateInfo._readFromParcel289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._readFromParcel289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _ProcessErrorStateInfo290;
			public ProcessErrorStateInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._ProcessErrorStateInfo290, this);
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
			internal static global::net.sf.jni4net.jni.FieldId _condition291;
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
			internal static global::net.sf.jni4net.jni.FieldId _processName292;
			public global::java.lang.String processName
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _pid293;
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
			internal static global::net.sf.jni4net.jni.FieldId _uid294;
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
			internal static global::net.sf.jni4net.jni.FieldId _tag295;
			public global::java.lang.String tag
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _shortMsg296;
			public global::java.lang.String shortMsg
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _longMsg297;
			public global::java.lang.String longMsg
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _crashData298;
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
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR299;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass = @__class;
				global::android.app.ActivityManager.ProcessErrorStateInfo._writeToParcel287 = @__env.GetMethodID(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.ProcessErrorStateInfo._describeContents288 = @__env.GetMethodID(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.ProcessErrorStateInfo._readFromParcel289 = @__env.GetMethodID(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.ProcessErrorStateInfo._ProcessErrorStateInfo290 = @__env.GetMethodID(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "<init>", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class RecentTaskInfo : java.lang.Object, android.os.Parcelable
		{
			internal static global::java.lang.Class staticClass;
			static RecentTaskInfo()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.ActivityManager.RecentTaskInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel300;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RecentTaskInfo._writeToParcel300, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._writeToParcel300, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _describeContents301;
			public virtual int describeContents() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.app.ActivityManager.RecentTaskInfo._describeContents301);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._describeContents301);
			}
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel302;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RecentTaskInfo._readFromParcel302, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._readFromParcel302, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _RecentTaskInfo303;
			public RecentTaskInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._RecentTaskInfo303, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _id304;
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
			internal static global::net.sf.jni4net.jni.FieldId _baseIntent305;
			public global::android.content.Intent baseIntent
			{
				get
				{
					return default(global::android.content.Intent);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _origActivity306;
			public global::android.content.ComponentName origActivity
			{
				get
				{
					return default(global::android.content.ComponentName);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR307;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.ActivityManager.RecentTaskInfo.staticClass = @__class;
				global::android.app.ActivityManager.RecentTaskInfo._writeToParcel300 = @__env.GetMethodID(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RecentTaskInfo._describeContents301 = @__env.GetMethodID(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RecentTaskInfo._readFromParcel302 = @__env.GetMethodID(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RecentTaskInfo._RecentTaskInfo303 = @__env.GetMethodID(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "<init>", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class RunningAppProcessInfo : java.lang.Object, android.os.Parcelable
		{
			internal static global::java.lang.Class staticClass;
			static RunningAppProcessInfo()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.ActivityManager.RunningAppProcessInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel308;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RunningAppProcessInfo._writeToParcel308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._writeToParcel308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _describeContents309;
			public virtual int describeContents() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.app.ActivityManager.RunningAppProcessInfo._describeContents309);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._describeContents309);
			}
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel310;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RunningAppProcessInfo._readFromParcel310, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._readFromParcel310, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _RunningAppProcessInfo311;
			public RunningAppProcessInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo311, this);
			}
			internal static global::net.sf.jni4net.jni.MethodId _RunningAppProcessInfo312;
			public RunningAppProcessInfo(java.lang.String arg0, int arg1, java.lang.String[] arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo312, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
			}
			internal static global::net.sf.jni4net.jni.FieldId _processName313;
			public global::java.lang.String processName
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _pid314;
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
			internal static global::net.sf.jni4net.jni.FieldId _uid315;
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
			internal static global::net.sf.jni4net.jni.FieldId _pkgList316;
			public global::java.lang.String[] pkgList
			{
				get
				{
					return default(global::java.lang.String[]);
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
			internal static global::net.sf.jni4net.jni.FieldId _importance317;
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
			internal static global::net.sf.jni4net.jni.FieldId _lru318;
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
			internal static global::net.sf.jni4net.jni.FieldId _importanceReasonCode319;
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
			internal static global::net.sf.jni4net.jni.FieldId _importanceReasonPid320;
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
			internal static global::net.sf.jni4net.jni.FieldId _importanceReasonComponent321;
			public global::android.content.ComponentName importanceReasonComponent
			{
				get
				{
					return default(global::android.content.ComponentName);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR322;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.ActivityManager.RunningAppProcessInfo.staticClass = @__class;
				global::android.app.ActivityManager.RunningAppProcessInfo._writeToParcel308 = @__env.GetMethodID(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RunningAppProcessInfo._describeContents309 = @__env.GetMethodID(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RunningAppProcessInfo._readFromParcel310 = @__env.GetMethodID(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo311 = @__env.GetMethodID(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "<init>", "()V");
				global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo312 = @__env.GetMethodID(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "<init>", "(Ljava/lang/String;I[Ljava/lang/String;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class RunningServiceInfo : java.lang.Object, android.os.Parcelable
		{
			internal static global::java.lang.Class staticClass;
			static RunningServiceInfo()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.ActivityManager.RunningServiceInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel323;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RunningServiceInfo._writeToParcel323, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._writeToParcel323, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _describeContents324;
			public virtual int describeContents() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.app.ActivityManager.RunningServiceInfo._describeContents324);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._describeContents324);
			}
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel325;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RunningServiceInfo._readFromParcel325, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._readFromParcel325, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _RunningServiceInfo326;
			public RunningServiceInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._RunningServiceInfo326, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _service327;
			public global::android.content.ComponentName service
			{
				get
				{
					return default(global::android.content.ComponentName);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _pid328;
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
			internal static global::net.sf.jni4net.jni.FieldId _uid329;
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
			internal static global::net.sf.jni4net.jni.FieldId _process330;
			public global::java.lang.String process
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _foreground331;
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
			internal static global::net.sf.jni4net.jni.FieldId _activeSince332;
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
			internal static global::net.sf.jni4net.jni.FieldId _started333;
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
			internal static global::net.sf.jni4net.jni.FieldId _clientCount334;
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
			internal static global::net.sf.jni4net.jni.FieldId _crashCount335;
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
			internal static global::net.sf.jni4net.jni.FieldId _lastActivityTime336;
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
			internal static global::net.sf.jni4net.jni.FieldId _restarting337;
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
			internal static global::net.sf.jni4net.jni.FieldId _flags338;
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
			internal static global::net.sf.jni4net.jni.FieldId _clientPackage339;
			public global::java.lang.String clientPackage
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _clientLabel340;
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
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR341;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.ActivityManager.RunningServiceInfo.staticClass = @__class;
				global::android.app.ActivityManager.RunningServiceInfo._writeToParcel323 = @__env.GetMethodID(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RunningServiceInfo._describeContents324 = @__env.GetMethodID(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RunningServiceInfo._readFromParcel325 = @__env.GetMethodID(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RunningServiceInfo._RunningServiceInfo326 = @__env.GetMethodID(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "<init>", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class RunningTaskInfo : java.lang.Object, android.os.Parcelable
		{
			internal static global::java.lang.Class staticClass;
			static RunningTaskInfo()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.ActivityManager.RunningTaskInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel342;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RunningTaskInfo._writeToParcel342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._writeToParcel342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _describeContents343;
			public virtual int describeContents() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.app.ActivityManager.RunningTaskInfo._describeContents343);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._describeContents343);
			}
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel344;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RunningTaskInfo._readFromParcel344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._readFromParcel344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _RunningTaskInfo345;
			public RunningTaskInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._RunningTaskInfo345, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _id346;
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
			internal static global::net.sf.jni4net.jni.FieldId _baseActivity347;
			public global::android.content.ComponentName baseActivity
			{
				get
				{
					return default(global::android.content.ComponentName);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _topActivity348;
			public global::android.content.ComponentName topActivity
			{
				get
				{
					return default(global::android.content.ComponentName);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _thumbnail349;
			public global::android.graphics.Bitmap thumbnail
			{
				get
				{
					return default(global::android.graphics.Bitmap);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _description350;
			public global::java.lang.CharSequence description
			{
				get
				{
					return default(global::java.lang.CharSequence);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _numActivities351;
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
			internal static global::net.sf.jni4net.jni.FieldId _numRunning352;
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
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR353;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.ActivityManager.RunningTaskInfo.staticClass = @__class;
				global::android.app.ActivityManager.RunningTaskInfo._writeToParcel342 = @__env.GetMethodID(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RunningTaskInfo._describeContents343 = @__env.GetMethodID(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RunningTaskInfo._readFromParcel344 = @__env.GetMethodID(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RunningTaskInfo._RunningTaskInfo345 = @__env.GetMethodID(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMemoryClass354;
		public virtual int getMemoryClass() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.ActivityManager._getMemoryClass354);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getMemoryClass354);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRecentTasks355;
		public virtual global::java.util.List getRecentTasks(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getRecentTasks355, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRecentTasks355, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRunningTasks356;
		public virtual global::java.util.List getRunningTasks(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getRunningTasks356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningTasks356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRunningServices357;
		public virtual global::java.util.List getRunningServices(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getRunningServices357, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningServices357, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRunningServiceControlPanel358;
		public virtual global::android.app.PendingIntent getRunningServiceControlPanel(android.content.ComponentName arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getRunningServiceControlPanel358, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningServiceControlPanel358, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMemoryInfo359;
		public virtual void getMemoryInfo(android.app.ActivityManager.MemoryInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityManager._getMemoryInfo359, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getMemoryInfo359, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProcessesInErrorState360;
		public virtual global::java.util.List getProcessesInErrorState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getProcessesInErrorState360));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getProcessesInErrorState360));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRunningAppProcesses361;
		public virtual global::java.util.List getRunningAppProcesses() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getRunningAppProcesses361));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningAppProcesses361));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProcessMemoryInfo362;
		public virtual global::android.os.Debug.MemoryInfo[] getProcessMemoryInfo(int[] arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getProcessMemoryInfo362, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getProcessMemoryInfo362, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _restartPackage363;
		public virtual void restartPackage(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityManager._restartPackage363, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._restartPackage363, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDeviceConfigurationInfo364;
		public virtual global::android.content.pm.ConfigurationInfo getDeviceConfigurationInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ConfigurationInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getDeviceConfigurationInfo364));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ConfigurationInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getDeviceConfigurationInfo364));
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
			global::android.app.ActivityManager._getMemoryClass354 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getMemoryClass", "()I");
			global::android.app.ActivityManager._getRecentTasks355 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getRecentTasks", "(II)Ljava/util/List;");
			global::android.app.ActivityManager._getRunningTasks356 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getRunningTasks", "(I)Ljava/util/List;");
			global::android.app.ActivityManager._getRunningServices357 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getRunningServices", "(I)Ljava/util/List;");
			global::android.app.ActivityManager._getRunningServiceControlPanel358 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getRunningServiceControlPanel", "(Landroid/content/ComponentName;)Landroid/app/PendingIntent;");
			global::android.app.ActivityManager._getMemoryInfo359 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getMemoryInfo", "(Landroid/app/ActivityManager$MemoryInfo;)V");
			global::android.app.ActivityManager._getProcessesInErrorState360 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getProcessesInErrorState", "()Ljava/util/List;");
			global::android.app.ActivityManager._getRunningAppProcesses361 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getRunningAppProcesses", "()Ljava/util/List;");
			global::android.app.ActivityManager._getProcessMemoryInfo362 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getProcessMemoryInfo", "([I)[Landroid/os/Debug/MemoryInfo;");
			global::android.app.ActivityManager._restartPackage363 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "restartPackage", "(Ljava/lang/String;)V");
			global::android.app.ActivityManager._getDeviceConfigurationInfo364 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getDeviceConfigurationInfo", "()Landroid/content/pm/ConfigurationInfo;");
		}
	}
}
