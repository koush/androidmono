namespace android.location 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface LocationListener 
	{ 
		void onStatusChanged(java.lang.String arg0, int arg1, android.os.Bundle arg2); 
		void onLocationChanged(android.location.Location arg0); 
		void onProviderEnabled(java.lang.String arg0); 
		void onProviderDisabled(java.lang.String arg0); 
	} 

	public partial class LocationListener_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __LocationListener.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __LocationListener : java.lang.Object, LocationListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static __LocationListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.location.__LocationListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.location.__LocationListener(@__env); 
			} 
		} 
		internal __LocationListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStatusChanged4314; 
		 void android.location.LocationListener.onStatusChanged(java.lang.String arg0, int arg1, android.os.Bundle arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.__LocationListener._onStatusChanged4314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.__LocationListener.staticClass, global::android.location.__LocationListener._onStatusChanged4314, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLocationChanged4315; 
		 void android.location.LocationListener.onLocationChanged(android.location.Location arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.__LocationListener._onLocationChanged4315, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.__LocationListener.staticClass, global::android.location.__LocationListener._onLocationChanged4315, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onProviderEnabled4316; 
		 void android.location.LocationListener.onProviderEnabled(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.__LocationListener._onProviderEnabled4316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.__LocationListener.staticClass, global::android.location.__LocationListener._onProviderEnabled4316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onProviderDisabled4317; 
		 void android.location.LocationListener.onProviderDisabled(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.__LocationListener._onProviderDisabled4317, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.__LocationListener.staticClass, global::android.location.__LocationListener._onProviderDisabled4317, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.location.__LocationListener.staticClass = @__class; 
			global::android.location.__LocationListener._onStatusChanged4314 = @__env.GetMethodID(global::android.location.__LocationListener.staticClass, "android.location.LocationListener.onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V"); 
			global::android.location.__LocationListener._onLocationChanged4315 = @__env.GetMethodID(global::android.location.__LocationListener.staticClass, "android.location.LocationListener.onLocationChanged", "(Landroid/location/Location;)V"); 
			global::android.location.__LocationListener._onProviderEnabled4316 = @__env.GetMethodID(global::android.location.__LocationListener.staticClass, "android.location.LocationListener.onProviderEnabled", "(Ljava/lang/String;)V"); 
			global::android.location.__LocationListener._onProviderDisabled4317 = @__env.GetMethodID(global::android.location.__LocationListener.staticClass, "android.location.LocationListener.onProviderDisabled", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
