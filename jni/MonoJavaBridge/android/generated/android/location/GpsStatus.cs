namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class GpsStatus : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GpsStatus()
		{
			InitJNI();
		}
		internal GpsStatus(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.location.GpsStatus.Listener_))]
		public partial interface Listener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGpsStatusChanged(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.location.GpsStatus.Listener))]
		internal sealed partial class Listener_ : java.lang.Object, Listener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Listener_()
			{
				InitJNI();
			}
			internal Listener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGpsStatusChanged6875;
			void android.location.GpsStatus.Listener.onGpsStatusChanged(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.location.GpsStatus.Listener_._onGpsStatusChanged6875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.GpsStatus.Listener_.staticClass, global::android.location.GpsStatus.Listener_._onGpsStatusChanged6875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.location.GpsStatus.Listener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsStatus$Listener"));
				global::android.location.GpsStatus.Listener_._onGpsStatusChanged6875 = @__env.GetMethodIDNoThrow(global::android.location.GpsStatus.Listener_.staticClass, "onGpsStatusChanged", "(I)V");
			}
		}

		public delegate void ListenerDelegate(int arg0);

		internal partial class ListenerDelegateWrapper : java.lang.Object, Listener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ListenerDelegateWrapper()
			{
				InitJNI();
			}
			protected ListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _ListenerDelegateWrapper6876;
			public ListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.GpsStatus.ListenerDelegateWrapper.staticClass, global::android.location.GpsStatus.ListenerDelegateWrapper._ListenerDelegateWrapper6876);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.location.GpsStatus.ListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsStatus_ListenerDelegateWrapper"));
				global::android.location.GpsStatus.ListenerDelegateWrapper._ListenerDelegateWrapper6876 = @__env.GetMethodIDNoThrow(global::android.location.GpsStatus.ListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class ListenerDelegateWrapper
		{
			private ListenerDelegate myDelegate;
			public void onGpsStatusChanged(int arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator ListenerDelegateWrapper(ListenerDelegate d)
			{
				global::android.location.GpsStatus.ListenerDelegateWrapper ret = new global::android.location.GpsStatus.ListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.location.GpsStatus.NmeaListener_))]
		public partial interface NmeaListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onNmeaReceived(long arg0, java.lang.String arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.location.GpsStatus.NmeaListener))]
		internal sealed partial class NmeaListener_ : java.lang.Object, NmeaListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static NmeaListener_()
			{
				InitJNI();
			}
			internal NmeaListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onNmeaReceived6877;
			void android.location.GpsStatus.NmeaListener.onNmeaReceived(long arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.location.GpsStatus.NmeaListener_._onNmeaReceived6877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.GpsStatus.NmeaListener_.staticClass, global::android.location.GpsStatus.NmeaListener_._onNmeaReceived6877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.location.GpsStatus.NmeaListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsStatus$NmeaListener"));
				global::android.location.GpsStatus.NmeaListener_._onNmeaReceived6877 = @__env.GetMethodIDNoThrow(global::android.location.GpsStatus.NmeaListener_.staticClass, "onNmeaReceived", "(JLjava/lang/String;)V");
			}
		}

		public delegate void NmeaListenerDelegate(long arg0, java.lang.String arg1);

		internal partial class NmeaListenerDelegateWrapper : java.lang.Object, NmeaListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static NmeaListenerDelegateWrapper()
			{
				InitJNI();
			}
			protected NmeaListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _NmeaListenerDelegateWrapper6878;
			public NmeaListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.GpsStatus.NmeaListenerDelegateWrapper.staticClass, global::android.location.GpsStatus.NmeaListenerDelegateWrapper._NmeaListenerDelegateWrapper6878);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.location.GpsStatus.NmeaListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsStatus_NmeaListenerDelegateWrapper"));
				global::android.location.GpsStatus.NmeaListenerDelegateWrapper._NmeaListenerDelegateWrapper6878 = @__env.GetMethodIDNoThrow(global::android.location.GpsStatus.NmeaListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class NmeaListenerDelegateWrapper
		{
			private NmeaListenerDelegate myDelegate;
			public void onNmeaReceived(long arg0, java.lang.String arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator NmeaListenerDelegateWrapper(NmeaListenerDelegate d)
			{
				global::android.location.GpsStatus.NmeaListenerDelegateWrapper ret = new global::android.location.GpsStatus.NmeaListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		public new int TimeToFirstFix
		{
			get
			{
				return getTimeToFirstFix();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimeToFirstFix6879;
		public int getTimeToFirstFix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.GpsStatus._getTimeToFirstFix6879);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.GpsStatus.staticClass, global::android.location.GpsStatus._getTimeToFirstFix6879);
		}
		public new global::java.lang.Iterable Satellites
		{
			get
			{
				return getSatellites();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSatellites6880;
		public global::java.lang.Iterable getSatellites()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Iterable>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.GpsStatus._getSatellites6880)) as java.lang.Iterable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Iterable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.GpsStatus.staticClass, global::android.location.GpsStatus._getSatellites6880)) as java.lang.Iterable;
		}
		public new int MaxSatellites
		{
			get
			{
				return getMaxSatellites();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxSatellites6881;
		public int getMaxSatellites()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.GpsStatus._getMaxSatellites6881);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.GpsStatus.staticClass, global::android.location.GpsStatus._getMaxSatellites6881);
		}
		public static int GPS_EVENT_STARTED
		{
			get
			{
				return 1;
			}
		}
		public static int GPS_EVENT_STOPPED
		{
			get
			{
				return 2;
			}
		}
		public static int GPS_EVENT_FIRST_FIX
		{
			get
			{
				return 3;
			}
		}
		public static int GPS_EVENT_SATELLITE_STATUS
		{
			get
			{
				return 4;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.GpsStatus.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsStatus"));
			global::android.location.GpsStatus._getTimeToFirstFix6879 = @__env.GetMethodIDNoThrow(global::android.location.GpsStatus.staticClass, "getTimeToFirstFix", "()I");
			global::android.location.GpsStatus._getSatellites6880 = @__env.GetMethodIDNoThrow(global::android.location.GpsStatus.staticClass, "getSatellites", "()Ljava/lang/Iterable;");
			global::android.location.GpsStatus._getMaxSatellites6881 = @__env.GetMethodIDNoThrow(global::android.location.GpsStatus.staticClass, "getMaxSatellites", "()I");
		}
	}
}
