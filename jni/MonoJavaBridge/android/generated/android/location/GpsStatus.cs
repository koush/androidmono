namespace android.location
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class GpsStatus : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static GpsStatus()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.location.GpsStatus), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.location.GpsStatus(@__env);
			}
		}
		internal GpsStatus(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface Listener 
		{
			void onGpsStatusChanged(int arg0);
		}

		public partial class Listener_
		{
			public static global::java.lang.Class _class
			{
				get { return __Listener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __Listener : java.lang.Object, Listener
		{
			internal static global::java.lang.Class staticClass;
			static __Listener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.location.GpsStatus.__Listener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.location.GpsStatus.__Listener(@__env);
				}
			}
			internal __Listener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onGpsStatusChanged4269;
			 void android.location.GpsStatus.Listener.onGpsStatusChanged(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.location.GpsStatus.__Listener._onGpsStatusChanged4269, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.location.GpsStatus.__Listener.staticClass, global::android.location.GpsStatus.__Listener._onGpsStatusChanged4269, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.location.GpsStatus.__Listener.staticClass = @__class;
				global::android.location.GpsStatus.__Listener._onGpsStatusChanged4269 = @__env.GetMethodID(global::android.location.GpsStatus.__Listener.staticClass, "android.location.GpsStatus.Listener.onGpsStatusChanged", "(I)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface NmeaListener 
		{
			void onNmeaReceived(long arg0, java.lang.String arg1);
		}

		public partial class NmeaListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __NmeaListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __NmeaListener : java.lang.Object, NmeaListener
		{
			internal static global::java.lang.Class staticClass;
			static __NmeaListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.location.GpsStatus.__NmeaListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.location.GpsStatus.__NmeaListener(@__env);
				}
			}
			internal __NmeaListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onNmeaReceived4270;
			 void android.location.GpsStatus.NmeaListener.onNmeaReceived(long arg0, java.lang.String arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.location.GpsStatus.__NmeaListener._onNmeaReceived4270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.location.GpsStatus.__NmeaListener.staticClass, global::android.location.GpsStatus.__NmeaListener._onNmeaReceived4270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.location.GpsStatus.__NmeaListener.staticClass = @__class;
				global::android.location.GpsStatus.__NmeaListener._onNmeaReceived4270 = @__env.GetMethodID(global::android.location.GpsStatus.__NmeaListener.staticClass, "android.location.GpsStatus.NmeaListener.onNmeaReceived", "(JLjava/lang/String;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTimeToFirstFix4271;
		public int getTimeToFirstFix() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.location.GpsStatus._getTimeToFirstFix4271);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.location.GpsStatus.staticClass, global::android.location.GpsStatus._getTimeToFirstFix4271);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSatellites4272;
		public global::java.lang.Iterable getSatellites() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Iterable>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.GpsStatus._getSatellites4272));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Iterable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.GpsStatus.staticClass, global::android.location.GpsStatus._getSatellites4272));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaxSatellites4273;
		public int getMaxSatellites() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.location.GpsStatus._getMaxSatellites4273);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.location.GpsStatus.staticClass, global::android.location.GpsStatus._getMaxSatellites4273);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.location.GpsStatus.staticClass = @__class;
			global::android.location.GpsStatus._getTimeToFirstFix4271 = @__env.GetMethodID(global::android.location.GpsStatus.staticClass, "getTimeToFirstFix", "()I");
			global::android.location.GpsStatus._getSatellites4272 = @__env.GetMethodID(global::android.location.GpsStatus.staticClass, "getSatellites", "()Ljava/lang/Iterable;");
			global::android.location.GpsStatus._getMaxSatellites4273 = @__env.GetMethodID(global::android.location.GpsStatus.staticClass, "getMaxSatellites", "()I");
		}
	}
}
