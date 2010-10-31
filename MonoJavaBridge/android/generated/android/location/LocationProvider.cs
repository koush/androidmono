namespace android.location
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.location.LocationProvider_))]
	public abstract partial class LocationProvider : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LocationProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.LocationProvider.staticClass, "getName", "()Ljava/lang/String;", ref global::android.location.LocationProvider._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract int getAccuracy();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract int getPowerRequirement();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract bool requiresNetwork();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract bool requiresSatellite();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract bool requiresCell();
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract bool hasMonetaryCost();
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract bool supportsAltitude();
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract bool supportsSpeed();
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract bool supportsBearing();
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool meetsCriteria(android.location.Criteria arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider.staticClass, "meetsCriteria", "(Landroid/location/Criteria;)Z", ref global::android.location.LocationProvider._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.location.LocationProvider))]
	internal sealed partial class LocationProvider_ : android.location.LocationProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LocationProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int getAccuracy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.LocationProvider_.staticClass, "getAccuracy", "()I", ref global::android.location.LocationProvider_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int getPowerRequirement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.LocationProvider_.staticClass, "getPowerRequirement", "()I", ref global::android.location.LocationProvider_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool requiresNetwork()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider_.staticClass, "requiresNetwork", "()Z", ref global::android.location.LocationProvider_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool requiresSatellite()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider_.staticClass, "requiresSatellite", "()Z", ref global::android.location.LocationProvider_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool requiresCell()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider_.staticClass, "requiresCell", "()Z", ref global::android.location.LocationProvider_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool hasMonetaryCost()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider_.staticClass, "hasMonetaryCost", "()Z", ref global::android.location.LocationProvider_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool supportsAltitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider_.staticClass, "supportsAltitude", "()Z", ref global::android.location.LocationProvider_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool supportsSpeed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider_.staticClass, "supportsSpeed", "()Z", ref global::android.location.LocationProvider_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool supportsBearing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.LocationProvider_.staticClass, "supportsBearing", "()Z", ref global::android.location.LocationProvider_._m8);
		}
		static LocationProvider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.LocationProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/LocationProvider"));
		}
	}
}
