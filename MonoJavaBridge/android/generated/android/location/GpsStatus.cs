namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class GpsStatus : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			internal Listener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.location.GpsStatus.Listener.onGpsStatusChanged(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.GpsStatus.Listener_.staticClass, "onGpsStatusChanged", "(I)V", ref global::android.location.GpsStatus.Listener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static Listener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.location.GpsStatus.Listener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsStatus$Listener"));
			}
		}

		public delegate void ListenerDelegate(int arg0);

		internal partial class ListenerDelegateWrapper : java.lang.Object, Listener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public ListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.location.GpsStatus.ListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.location.GpsStatus.ListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.location.GpsStatus.ListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.GpsStatus.ListenerDelegateWrapper.staticClass, global::android.location.GpsStatus.ListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static ListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.location.GpsStatus.ListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsStatus_ListenerDelegateWrapper"));
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
			internal NmeaListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.location.GpsStatus.NmeaListener.onNmeaReceived(long arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.GpsStatus.NmeaListener_.staticClass, "onNmeaReceived", "(JLjava/lang/String;)V", ref global::android.location.GpsStatus.NmeaListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static NmeaListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.location.GpsStatus.NmeaListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsStatus$NmeaListener"));
			}
		}

		public delegate void NmeaListenerDelegate(long arg0, java.lang.String arg1);

		internal partial class NmeaListenerDelegateWrapper : java.lang.Object, NmeaListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected NmeaListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public NmeaListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.location.GpsStatus.NmeaListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.location.GpsStatus.NmeaListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.location.GpsStatus.NmeaListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.GpsStatus.NmeaListenerDelegateWrapper.staticClass, global::android.location.GpsStatus.NmeaListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static NmeaListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.location.GpsStatus.NmeaListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsStatus_NmeaListenerDelegateWrapper"));
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
		private static global::MonoJavaBridge.MethodId _m0;
		public int getTimeToFirstFix()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.GpsStatus.staticClass, "getTimeToFirstFix", "()I", ref global::android.location.GpsStatus._m0);
		}
		public new global::java.lang.Iterable Satellites
		{
			get
			{
				return getSatellites();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::java.lang.Iterable getSatellites()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.Iterable>(this, global::android.location.GpsStatus.staticClass, "getSatellites", "()Ljava/lang/Iterable;", ref global::android.location.GpsStatus._m1) as java.lang.Iterable;
		}
		public new int MaxSatellites
		{
			get
			{
				return getMaxSatellites();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public int getMaxSatellites()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.GpsStatus.staticClass, "getMaxSatellites", "()I", ref global::android.location.GpsStatus._m2);
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
		static GpsStatus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.GpsStatus.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsStatus"));
		}
	}
}
