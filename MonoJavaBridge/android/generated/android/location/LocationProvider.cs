namespace android.location
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.location.LocationProvider_))]
	public abstract partial class LocationProvider : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LocationProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getName6968;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.LocationProvider.staticClass, "getName", "()Ljava/lang/String;", ref global::android.location.LocationProvider._getName6968) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAccuracy6969;
		public abstract int getAccuracy();
		internal static global::MonoJavaBridge.MethodId _getPowerRequirement6970;
		public abstract int getPowerRequirement();
		internal static global::MonoJavaBridge.MethodId _requiresNetwork6971;
		public abstract bool requiresNetwork();
		internal static global::MonoJavaBridge.MethodId _requiresSatellite6972;
		public abstract bool requiresSatellite();
		internal static global::MonoJavaBridge.MethodId _requiresCell6973;
		public abstract bool requiresCell();
		internal static global::MonoJavaBridge.MethodId _hasMonetaryCost6974;
		public abstract bool hasMonetaryCost();
		internal static global::MonoJavaBridge.MethodId _supportsAltitude6975;
		public abstract bool supportsAltitude();
		internal static global::MonoJavaBridge.MethodId _supportsSpeed6976;
		public abstract bool supportsSpeed();
		internal static global::MonoJavaBridge.MethodId _supportsBearing6977;
		public abstract bool supportsBearing();
		internal static global::MonoJavaBridge.MethodId _meetsCriteria6978;
		public virtual bool meetsCriteria(android.location.Criteria arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider.staticClass, "meetsCriteria", "(Landroid/location/Criteria;)Z", ref global::android.location.LocationProvider._meetsCriteria6978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		static LocationProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.LocationProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/LocationProvider"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.location.LocationProvider))]
	internal sealed partial class LocationProvider_ : android.location.LocationProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LocationProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAccuracy6982;
		public override int getAccuracy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.LocationProvider_.staticClass, "getAccuracy", "()I", ref global::android.location.LocationProvider_._getAccuracy6982);
		}
		internal static global::MonoJavaBridge.MethodId _getPowerRequirement6983;
		public override int getPowerRequirement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.LocationProvider_.staticClass, "getPowerRequirement", "()I", ref global::android.location.LocationProvider_._getPowerRequirement6983);
		}
		internal static global::MonoJavaBridge.MethodId _requiresNetwork6984;
		public override bool requiresNetwork()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider_.staticClass, "requiresNetwork", "()Z", ref global::android.location.LocationProvider_._requiresNetwork6984);
		}
		internal static global::MonoJavaBridge.MethodId _requiresSatellite6985;
		public override bool requiresSatellite()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider_.staticClass, "requiresSatellite", "()Z", ref global::android.location.LocationProvider_._requiresSatellite6985);
		}
		internal static global::MonoJavaBridge.MethodId _requiresCell6986;
		public override bool requiresCell()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider_.staticClass, "requiresCell", "()Z", ref global::android.location.LocationProvider_._requiresCell6986);
		}
		internal static global::MonoJavaBridge.MethodId _hasMonetaryCost6987;
		public override bool hasMonetaryCost()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider_.staticClass, "hasMonetaryCost", "()Z", ref global::android.location.LocationProvider_._hasMonetaryCost6987);
		}
		internal static global::MonoJavaBridge.MethodId _supportsAltitude6988;
		public override bool supportsAltitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider_.staticClass, "supportsAltitude", "()Z", ref global::android.location.LocationProvider_._supportsAltitude6988);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSpeed6989;
		public override bool supportsSpeed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider_.staticClass, "supportsSpeed", "()Z", ref global::android.location.LocationProvider_._supportsSpeed6989);
		}
		internal static global::MonoJavaBridge.MethodId _supportsBearing6990;
		public override bool supportsBearing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider_.staticClass, "supportsBearing", "()Z", ref global::android.location.LocationProvider_._supportsBearing6990);
		}
		static LocationProvider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.LocationProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/LocationProvider"));
		}
		internal static void InitJNI()
		{
		}
	}
}
