namespace android.location 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class GpsStatus : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GpsStatus() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.location.GpsStatus), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface NmeaListener 
		{ 
			void onNmeaReceived(long arg0, java.lang.String arg1); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimeToFirstFix4046; 
		public int getTimeToFirstFix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsStatus)) 
				return @__env.CallIntMethod(this, _getTimeToFirstFix4046); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.location.GpsStatus.staticClass, _getTimeToFirstFix4046); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSatellites4047; 
		public java.lang.Iterable getSatellites() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsStatus)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Iterable>(@__env, @__env.CallObjectMethodPtr(this, _getSatellites4047)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Iterable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.GpsStatus.staticClass, _getSatellites4047)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxSatellites4048; 
		public int getMaxSatellites() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.GpsStatus)) 
				return @__env.CallIntMethod(this, _getMaxSatellites4048); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.location.GpsStatus.staticClass, _getMaxSatellites4048); 
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
			global::android.location.GpsStatus._getTimeToFirstFix4046 = @__env.GetMethodID(global::android.location.GpsStatus.staticClass, "getTimeToFirstFix", "()I"); 
			global::android.location.GpsStatus._getSatellites4047 = @__env.GetMethodID(global::android.location.GpsStatus.staticClass, "getSatellites", "()Ljava/lang/Iterable;"); 
			global::android.location.GpsStatus._getMaxSatellites4048 = @__env.GetMethodID(global::android.location.GpsStatus.staticClass, "getMaxSatellites", "()I"); 
		} 
	} 
} 
