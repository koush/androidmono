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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.LocationProvider._getName6968)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.LocationProvider.staticClass, global::android.location.LocationProvider._getName6968)) as java.lang.String;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider._meetsCriteria6978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider.staticClass, global::android.location.LocationProvider._meetsCriteria6978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.location.LocationProvider._getName6968 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "getName", "()Ljava/lang/String;");
			global::android.location.LocationProvider._getAccuracy6969 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "getAccuracy", "()I");
			global::android.location.LocationProvider._getPowerRequirement6970 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "getPowerRequirement", "()I");
			global::android.location.LocationProvider._requiresNetwork6971 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "requiresNetwork", "()Z");
			global::android.location.LocationProvider._requiresSatellite6972 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "requiresSatellite", "()Z");
			global::android.location.LocationProvider._requiresCell6973 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "requiresCell", "()Z");
			global::android.location.LocationProvider._hasMonetaryCost6974 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "hasMonetaryCost", "()Z");
			global::android.location.LocationProvider._supportsAltitude6975 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "supportsAltitude", "()Z");
			global::android.location.LocationProvider._supportsSpeed6976 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "supportsSpeed", "()Z");
			global::android.location.LocationProvider._supportsBearing6977 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "supportsBearing", "()Z");
			global::android.location.LocationProvider._meetsCriteria6978 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "meetsCriteria", "(Landroid/location/Criteria;)Z");
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.LocationProvider_._getAccuracy6982);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._getAccuracy6982);
		}
		internal static global::MonoJavaBridge.MethodId _getPowerRequirement6983;
		public override int getPowerRequirement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.LocationProvider_._getPowerRequirement6983);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._getPowerRequirement6983);
		}
		internal static global::MonoJavaBridge.MethodId _requiresNetwork6984;
		public override bool requiresNetwork()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._requiresNetwork6984);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._requiresNetwork6984);
		}
		internal static global::MonoJavaBridge.MethodId _requiresSatellite6985;
		public override bool requiresSatellite()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._requiresSatellite6985);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._requiresSatellite6985);
		}
		internal static global::MonoJavaBridge.MethodId _requiresCell6986;
		public override bool requiresCell()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._requiresCell6986);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._requiresCell6986);
		}
		internal static global::MonoJavaBridge.MethodId _hasMonetaryCost6987;
		public override bool hasMonetaryCost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._hasMonetaryCost6987);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._hasMonetaryCost6987);
		}
		internal static global::MonoJavaBridge.MethodId _supportsAltitude6988;
		public override bool supportsAltitude()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._supportsAltitude6988);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._supportsAltitude6988);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSpeed6989;
		public override bool supportsSpeed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._supportsSpeed6989);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._supportsSpeed6989);
		}
		internal static global::MonoJavaBridge.MethodId _supportsBearing6990;
		public override bool supportsBearing()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._supportsBearing6990);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._supportsBearing6990);
		}
		static LocationProvider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.LocationProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/LocationProvider"));
			global::android.location.LocationProvider_._getAccuracy6982 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "getAccuracy", "()I");
			global::android.location.LocationProvider_._getPowerRequirement6983 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "getPowerRequirement", "()I");
			global::android.location.LocationProvider_._requiresNetwork6984 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "requiresNetwork", "()Z");
			global::android.location.LocationProvider_._requiresSatellite6985 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "requiresSatellite", "()Z");
			global::android.location.LocationProvider_._requiresCell6986 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "requiresCell", "()Z");
			global::android.location.LocationProvider_._hasMonetaryCost6987 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "hasMonetaryCost", "()Z");
			global::android.location.LocationProvider_._supportsAltitude6988 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "supportsAltitude", "()Z");
			global::android.location.LocationProvider_._supportsSpeed6989 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "supportsSpeed", "()Z");
			global::android.location.LocationProvider_._supportsBearing6990 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "supportsBearing", "()Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
