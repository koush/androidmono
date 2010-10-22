namespace android.location
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.location.LocationProvider_))]
	public abstract partial class LocationProvider : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LocationProvider()
		{
			InitJNI();
		}
		protected LocationProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getName6941;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.LocationProvider._getName6941)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.LocationProvider.staticClass, global::android.location.LocationProvider._getName6941)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAccuracy6942;
		public abstract int getAccuracy();
		internal static global::MonoJavaBridge.MethodId _getPowerRequirement6943;
		public abstract int getPowerRequirement();
		internal static global::MonoJavaBridge.MethodId _requiresNetwork6944;
		public abstract bool requiresNetwork();
		internal static global::MonoJavaBridge.MethodId _requiresSatellite6945;
		public abstract bool requiresSatellite();
		internal static global::MonoJavaBridge.MethodId _requiresCell6946;
		public abstract bool requiresCell();
		internal static global::MonoJavaBridge.MethodId _hasMonetaryCost6947;
		public abstract bool hasMonetaryCost();
		internal static global::MonoJavaBridge.MethodId _supportsAltitude6948;
		public abstract bool supportsAltitude();
		internal static global::MonoJavaBridge.MethodId _supportsSpeed6949;
		public abstract bool supportsSpeed();
		internal static global::MonoJavaBridge.MethodId _supportsBearing6950;
		public abstract bool supportsBearing();
		internal static global::MonoJavaBridge.MethodId _meetsCriteria6951;
		public virtual bool meetsCriteria(android.location.Criteria arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider._meetsCriteria6951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider.staticClass, global::android.location.LocationProvider._meetsCriteria6951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int OUT_OF_SERVICE
		{
			get
			{
				return 0;
			}
		}
		public static int TEMPORARILY_UNAVAILABLE
		{
			get
			{
				return 1;
			}
		}
		public static int AVAILABLE
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.LocationProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/LocationProvider"));
			global::android.location.LocationProvider._getName6941 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "getName", "()Ljava/lang/String;");
			global::android.location.LocationProvider._getAccuracy6942 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "getAccuracy", "()I");
			global::android.location.LocationProvider._getPowerRequirement6943 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "getPowerRequirement", "()I");
			global::android.location.LocationProvider._requiresNetwork6944 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "requiresNetwork", "()Z");
			global::android.location.LocationProvider._requiresSatellite6945 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "requiresSatellite", "()Z");
			global::android.location.LocationProvider._requiresCell6946 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "requiresCell", "()Z");
			global::android.location.LocationProvider._hasMonetaryCost6947 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "hasMonetaryCost", "()Z");
			global::android.location.LocationProvider._supportsAltitude6948 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "supportsAltitude", "()Z");
			global::android.location.LocationProvider._supportsSpeed6949 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "supportsSpeed", "()Z");
			global::android.location.LocationProvider._supportsBearing6950 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "supportsBearing", "()Z");
			global::android.location.LocationProvider._meetsCriteria6951 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "meetsCriteria", "(Landroid/location/Criteria;)Z");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.location.LocationProvider))]
	public sealed partial class LocationProvider_ : android.location.LocationProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LocationProvider_()
		{
			InitJNI();
		}
		internal LocationProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAccuracy6955;
		public override int getAccuracy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.LocationProvider_._getAccuracy6955);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._getAccuracy6955);
		}
		internal static global::MonoJavaBridge.MethodId _getPowerRequirement6956;
		public override int getPowerRequirement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.LocationProvider_._getPowerRequirement6956);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._getPowerRequirement6956);
		}
		internal static global::MonoJavaBridge.MethodId _requiresNetwork6957;
		public override bool requiresNetwork() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._requiresNetwork6957);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._requiresNetwork6957);
		}
		internal static global::MonoJavaBridge.MethodId _requiresSatellite6958;
		public override bool requiresSatellite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._requiresSatellite6958);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._requiresSatellite6958);
		}
		internal static global::MonoJavaBridge.MethodId _requiresCell6959;
		public override bool requiresCell() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._requiresCell6959);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._requiresCell6959);
		}
		internal static global::MonoJavaBridge.MethodId _hasMonetaryCost6960;
		public override bool hasMonetaryCost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._hasMonetaryCost6960);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._hasMonetaryCost6960);
		}
		internal static global::MonoJavaBridge.MethodId _supportsAltitude6961;
		public override bool supportsAltitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._supportsAltitude6961);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._supportsAltitude6961);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSpeed6962;
		public override bool supportsSpeed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._supportsSpeed6962);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._supportsSpeed6962);
		}
		internal static global::MonoJavaBridge.MethodId _supportsBearing6963;
		public override bool supportsBearing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._supportsBearing6963);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._supportsBearing6963);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.LocationProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/LocationProvider"));
			global::android.location.LocationProvider_._getAccuracy6955 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "getAccuracy", "()I");
			global::android.location.LocationProvider_._getPowerRequirement6956 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "getPowerRequirement", "()I");
			global::android.location.LocationProvider_._requiresNetwork6957 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "requiresNetwork", "()Z");
			global::android.location.LocationProvider_._requiresSatellite6958 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "requiresSatellite", "()Z");
			global::android.location.LocationProvider_._requiresCell6959 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "requiresCell", "()Z");
			global::android.location.LocationProvider_._hasMonetaryCost6960 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "hasMonetaryCost", "()Z");
			global::android.location.LocationProvider_._supportsAltitude6961 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "supportsAltitude", "()Z");
			global::android.location.LocationProvider_._supportsSpeed6962 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "supportsSpeed", "()Z");
			global::android.location.LocationProvider_._supportsBearing6963 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "supportsBearing", "()Z");
		}
	}
}
