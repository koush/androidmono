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
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel283;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.MemoryInfo._writeToParcel283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._writeToParcel283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _describeContents284;
			public virtual int describeContents() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.app.ActivityManager.MemoryInfo._describeContents284);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._describeContents284);
			}
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel285;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.MemoryInfo._readFromParcel285, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._readFromParcel285, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _MemoryInfo286;
			public MemoryInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.ActivityManager.MemoryInfo.staticClass, global::android.app.ActivityManager.MemoryInfo._MemoryInfo286, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _availMem287;
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
			internal static global::net.sf.jni4net.jni.FieldId _threshold288;
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
			internal static global::net.sf.jni4net.jni.FieldId _lowMemory289;
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
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR290;
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
				global::android.app.ActivityManager.MemoryInfo._writeToParcel283 = @__env.GetMethodID(global::android.app.ActivityManager.MemoryInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.MemoryInfo._describeContents284 = @__env.GetMethodID(global::android.app.ActivityManager.MemoryInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.MemoryInfo._readFromParcel285 = @__env.GetMethodID(global::android.app.ActivityManager.MemoryInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.MemoryInfo._MemoryInfo286 = @__env.GetMethodID(global::android.app.ActivityManager.MemoryInfo.staticClass, "<init>", "()V");
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
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel291;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.ProcessErrorStateInfo._writeToParcel291, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._writeToParcel291, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _describeContents292;
			public virtual int describeContents() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.app.ActivityManager.ProcessErrorStateInfo._describeContents292);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._describeContents292);
			}
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel293;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.ProcessErrorStateInfo._readFromParcel293, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._readFromParcel293, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _ProcessErrorStateInfo294;
			public ProcessErrorStateInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.ActivityManager.ProcessErrorStateInfo.staticClass, global::android.app.ActivityManager.ProcessErrorStateInfo._ProcessErrorStateInfo294, this);
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
			internal static global::net.sf.jni4net.jni.FieldId _condition295;
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
			internal static global::net.sf.jni4net.jni.FieldId _processName296;
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
			internal static global::net.sf.jni4net.jni.FieldId _pid297;
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
			internal static global::net.sf.jni4net.jni.FieldId _uid298;
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
			internal static global::net.sf.jni4net.jni.FieldId _tag299;
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
			internal static global::net.sf.jni4net.jni.FieldId _shortMsg300;
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
			internal static global::net.sf.jni4net.jni.FieldId _longMsg301;
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
			internal static global::net.sf.jni4net.jni.FieldId _stackTrace302;
			public global::java.lang.String stackTrace
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _crashData303;
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
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR304;
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
				global::android.app.ActivityManager.ProcessErrorStateInfo._writeToParcel291 = @__env.GetMethodID(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.ProcessErrorStateInfo._describeContents292 = @__env.GetMethodID(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.ProcessErrorStateInfo._readFromParcel293 = @__env.GetMethodID(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.ProcessErrorStateInfo._ProcessErrorStateInfo294 = @__env.GetMethodID(global::android.app.ActivityManager.ProcessErrorStateInfo.staticClass, "<init>", "()V");
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
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel305;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RecentTaskInfo._writeToParcel305, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._writeToParcel305, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _describeContents306;
			public virtual int describeContents() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.app.ActivityManager.RecentTaskInfo._describeContents306);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._describeContents306);
			}
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel307;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RecentTaskInfo._readFromParcel307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._readFromParcel307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _RecentTaskInfo308;
			public RecentTaskInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.ActivityManager.RecentTaskInfo.staticClass, global::android.app.ActivityManager.RecentTaskInfo._RecentTaskInfo308, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _id309;
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
			internal static global::net.sf.jni4net.jni.FieldId _baseIntent310;
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
			internal static global::net.sf.jni4net.jni.FieldId _origActivity311;
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
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR312;
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
				global::android.app.ActivityManager.RecentTaskInfo._writeToParcel305 = @__env.GetMethodID(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RecentTaskInfo._describeContents306 = @__env.GetMethodID(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RecentTaskInfo._readFromParcel307 = @__env.GetMethodID(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RecentTaskInfo._RecentTaskInfo308 = @__env.GetMethodID(global::android.app.ActivityManager.RecentTaskInfo.staticClass, "<init>", "()V");
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
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel313;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RunningAppProcessInfo._writeToParcel313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._writeToParcel313, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _describeContents314;
			public virtual int describeContents() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.app.ActivityManager.RunningAppProcessInfo._describeContents314);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._describeContents314);
			}
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel315;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RunningAppProcessInfo._readFromParcel315, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._readFromParcel315, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _RunningAppProcessInfo316;
			public RunningAppProcessInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo316, this);
			}
			internal static global::net.sf.jni4net.jni.MethodId _RunningAppProcessInfo317;
			public RunningAppProcessInfo(java.lang.String arg0, int arg1, java.lang.String[] arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.ActivityManager.RunningAppProcessInfo.staticClass, global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo317, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
			}
			internal static global::net.sf.jni4net.jni.FieldId _processName318;
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
			internal static global::net.sf.jni4net.jni.FieldId _pid319;
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
			internal static global::net.sf.jni4net.jni.FieldId _uid320;
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
			internal static global::net.sf.jni4net.jni.FieldId _pkgList321;
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
			internal static global::net.sf.jni4net.jni.FieldId _importance322;
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
			internal static global::net.sf.jni4net.jni.FieldId _lru323;
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
			internal static global::net.sf.jni4net.jni.FieldId _importanceReasonCode324;
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
			internal static global::net.sf.jni4net.jni.FieldId _importanceReasonPid325;
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
			internal static global::net.sf.jni4net.jni.FieldId _importanceReasonComponent326;
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
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR327;
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
				global::android.app.ActivityManager.RunningAppProcessInfo._writeToParcel313 = @__env.GetMethodID(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RunningAppProcessInfo._describeContents314 = @__env.GetMethodID(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RunningAppProcessInfo._readFromParcel315 = @__env.GetMethodID(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo316 = @__env.GetMethodID(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "<init>", "()V");
				global::android.app.ActivityManager.RunningAppProcessInfo._RunningAppProcessInfo317 = @__env.GetMethodID(global::android.app.ActivityManager.RunningAppProcessInfo.staticClass, "<init>", "(Ljava/lang/String;I[Ljava/lang/String;)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel328;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RunningServiceInfo._writeToParcel328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._writeToParcel328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _describeContents329;
			public virtual int describeContents() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.app.ActivityManager.RunningServiceInfo._describeContents329);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._describeContents329);
			}
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel330;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RunningServiceInfo._readFromParcel330, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._readFromParcel330, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _RunningServiceInfo331;
			public RunningServiceInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.ActivityManager.RunningServiceInfo.staticClass, global::android.app.ActivityManager.RunningServiceInfo._RunningServiceInfo331, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _service332;
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
			internal static global::net.sf.jni4net.jni.FieldId _pid333;
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
			internal static global::net.sf.jni4net.jni.FieldId _uid334;
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
			internal static global::net.sf.jni4net.jni.FieldId _process335;
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
			internal static global::net.sf.jni4net.jni.FieldId _foreground336;
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
			internal static global::net.sf.jni4net.jni.FieldId _activeSince337;
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
			internal static global::net.sf.jni4net.jni.FieldId _started338;
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
			internal static global::net.sf.jni4net.jni.FieldId _clientCount339;
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
			internal static global::net.sf.jni4net.jni.FieldId _crashCount340;
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
			internal static global::net.sf.jni4net.jni.FieldId _lastActivityTime341;
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
			internal static global::net.sf.jni4net.jni.FieldId _restarting342;
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
			internal static global::net.sf.jni4net.jni.FieldId _flags343;
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
			internal static global::net.sf.jni4net.jni.FieldId _clientPackage344;
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
			internal static global::net.sf.jni4net.jni.FieldId _clientLabel345;
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
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR346;
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
				global::android.app.ActivityManager.RunningServiceInfo._writeToParcel328 = @__env.GetMethodID(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RunningServiceInfo._describeContents329 = @__env.GetMethodID(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RunningServiceInfo._readFromParcel330 = @__env.GetMethodID(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RunningServiceInfo._RunningServiceInfo331 = @__env.GetMethodID(global::android.app.ActivityManager.RunningServiceInfo.staticClass, "<init>", "()V");
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
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel347;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RunningTaskInfo._writeToParcel347, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._writeToParcel347, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _describeContents348;
			public virtual int describeContents() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.app.ActivityManager.RunningTaskInfo._describeContents348);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._describeContents348);
			}
			internal static global::net.sf.jni4net.jni.MethodId _readFromParcel349;
			public virtual void readFromParcel(android.os.Parcel arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.app.ActivityManager.RunningTaskInfo._readFromParcel349, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._readFromParcel349, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _RunningTaskInfo350;
			public RunningTaskInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.ActivityManager.RunningTaskInfo.staticClass, global::android.app.ActivityManager.RunningTaskInfo._RunningTaskInfo350, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _id351;
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
			internal static global::net.sf.jni4net.jni.FieldId _baseActivity352;
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
			internal static global::net.sf.jni4net.jni.FieldId _topActivity353;
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
			internal static global::net.sf.jni4net.jni.FieldId _thumbnail354;
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
			internal static global::net.sf.jni4net.jni.FieldId _description355;
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
			internal static global::net.sf.jni4net.jni.FieldId _numActivities356;
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
			internal static global::net.sf.jni4net.jni.FieldId _numRunning357;
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
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR358;
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
				global::android.app.ActivityManager.RunningTaskInfo._writeToParcel347 = @__env.GetMethodID(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.app.ActivityManager.RunningTaskInfo._describeContents348 = @__env.GetMethodID(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "describeContents", "()I");
				global::android.app.ActivityManager.RunningTaskInfo._readFromParcel349 = @__env.GetMethodID(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
				global::android.app.ActivityManager.RunningTaskInfo._RunningTaskInfo350 = @__env.GetMethodID(global::android.app.ActivityManager.RunningTaskInfo.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMemoryClass359;
		public virtual int getMemoryClass() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.ActivityManager._getMemoryClass359);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getMemoryClass359);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRecentTasks360;
		public virtual global::java.util.List getRecentTasks(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getRecentTasks360, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRecentTasks360, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRunningTasks361;
		public virtual global::java.util.List getRunningTasks(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getRunningTasks361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningTasks361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRunningServices362;
		public virtual global::java.util.List getRunningServices(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getRunningServices362, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningServices362, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRunningServiceControlPanel363;
		public virtual global::android.app.PendingIntent getRunningServiceControlPanel(android.content.ComponentName arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getRunningServiceControlPanel363, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.PendingIntent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningServiceControlPanel363, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMemoryInfo364;
		public virtual void getMemoryInfo(android.app.ActivityManager.MemoryInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityManager._getMemoryInfo364, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getMemoryInfo364, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProcessesInErrorState365;
		public virtual global::java.util.List getProcessesInErrorState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getProcessesInErrorState365));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getProcessesInErrorState365));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRunningAppProcesses366;
		public virtual global::java.util.List getRunningAppProcesses() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getRunningAppProcesses366));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getRunningAppProcesses366));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProcessMemoryInfo367;
		public virtual global::android.os.Debug.MemoryInfo[] getProcessMemoryInfo(int[] arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getProcessMemoryInfo367, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getProcessMemoryInfo367, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _restartPackage368;
		public virtual void restartPackage(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityManager._restartPackage368, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._restartPackage368, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _killBackgroundProcesses369;
		public virtual void killBackgroundProcesses(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ActivityManager._killBackgroundProcesses369, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._killBackgroundProcesses369, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDeviceConfigurationInfo370;
		public virtual global::android.content.pm.ConfigurationInfo getDeviceConfigurationInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ConfigurationInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ActivityManager._getDeviceConfigurationInfo370));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ConfigurationInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ActivityManager.staticClass, global::android.app.ActivityManager._getDeviceConfigurationInfo370));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isUserAMonkey371;
		public static bool isUserAMonkey() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.app.ActivityManager.staticClass, global::android.app.ActivityManager._isUserAMonkey371);
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
			global::android.app.ActivityManager._getMemoryClass359 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getMemoryClass", "()I");
			global::android.app.ActivityManager._getRecentTasks360 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getRecentTasks", "(II)Ljava/util/List;");
			global::android.app.ActivityManager._getRunningTasks361 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getRunningTasks", "(I)Ljava/util/List;");
			global::android.app.ActivityManager._getRunningServices362 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getRunningServices", "(I)Ljava/util/List;");
			global::android.app.ActivityManager._getRunningServiceControlPanel363 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getRunningServiceControlPanel", "(Landroid/content/ComponentName;)Landroid/app/PendingIntent;");
			global::android.app.ActivityManager._getMemoryInfo364 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getMemoryInfo", "(Landroid/app/ActivityManager$MemoryInfo;)V");
			global::android.app.ActivityManager._getProcessesInErrorState365 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getProcessesInErrorState", "()Ljava/util/List;");
			global::android.app.ActivityManager._getRunningAppProcesses366 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getRunningAppProcesses", "()Ljava/util/List;");
			global::android.app.ActivityManager._getProcessMemoryInfo367 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getProcessMemoryInfo", "([I)[Landroid/os/Debug/MemoryInfo;");
			global::android.app.ActivityManager._restartPackage368 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "restartPackage", "(Ljava/lang/String;)V");
			global::android.app.ActivityManager._killBackgroundProcesses369 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "killBackgroundProcesses", "(Ljava/lang/String;)V");
			global::android.app.ActivityManager._getDeviceConfigurationInfo370 = @__env.GetMethodID(global::android.app.ActivityManager.staticClass, "getDeviceConfigurationInfo", "()Landroid/content/pm/ConfigurationInfo;");
			global::android.app.ActivityManager._isUserAMonkey371 = @__env.GetStaticMethodID(global::android.app.ActivityManager.staticClass, "isUserAMonkey", "()Z");
		}
	}
}
