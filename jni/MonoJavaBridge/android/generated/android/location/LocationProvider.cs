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
		internal static global::MonoJavaBridge.MethodId _getName4800;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.LocationProvider._getName4800)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.LocationProvider.staticClass, global::android.location.LocationProvider._getName4800)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAccuracy4801;
		public abstract int getAccuracy();
		internal static global::MonoJavaBridge.MethodId _getPowerRequirement4802;
		public abstract int getPowerRequirement();
		internal static global::MonoJavaBridge.MethodId _requiresNetwork4803;
		public abstract bool requiresNetwork();
		internal static global::MonoJavaBridge.MethodId _requiresSatellite4804;
		public abstract bool requiresSatellite();
		internal static global::MonoJavaBridge.MethodId _requiresCell4805;
		public abstract bool requiresCell();
		internal static global::MonoJavaBridge.MethodId _hasMonetaryCost4806;
		public abstract bool hasMonetaryCost();
		internal static global::MonoJavaBridge.MethodId _supportsAltitude4807;
		public abstract bool supportsAltitude();
		internal static global::MonoJavaBridge.MethodId _supportsSpeed4808;
		public abstract bool supportsSpeed();
		internal static global::MonoJavaBridge.MethodId _supportsBearing4809;
		public abstract bool supportsBearing();
		internal static global::MonoJavaBridge.MethodId _meetsCriteria4810;
		public virtual bool meetsCriteria(android.location.Criteria arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider._meetsCriteria4810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider.staticClass, global::android.location.LocationProvider._meetsCriteria4810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.location.LocationProvider._getName4800 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "getName", "()Ljava/lang/String;");
			global::android.location.LocationProvider._getAccuracy4801 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "getAccuracy", "()I");
			global::android.location.LocationProvider._getPowerRequirement4802 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "getPowerRequirement", "()I");
			global::android.location.LocationProvider._requiresNetwork4803 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "requiresNetwork", "()Z");
			global::android.location.LocationProvider._requiresSatellite4804 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "requiresSatellite", "()Z");
			global::android.location.LocationProvider._requiresCell4805 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "requiresCell", "()Z");
			global::android.location.LocationProvider._hasMonetaryCost4806 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "hasMonetaryCost", "()Z");
			global::android.location.LocationProvider._supportsAltitude4807 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "supportsAltitude", "()Z");
			global::android.location.LocationProvider._supportsSpeed4808 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "supportsSpeed", "()Z");
			global::android.location.LocationProvider._supportsBearing4809 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "supportsBearing", "()Z");
			global::android.location.LocationProvider._meetsCriteria4810 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider.staticClass, "meetsCriteria", "(Landroid/location/Criteria;)Z");
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
		internal static global::MonoJavaBridge.MethodId _getAccuracy4811;
		public override int getAccuracy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.LocationProvider_._getAccuracy4811);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._getAccuracy4811);
		}
		internal static global::MonoJavaBridge.MethodId _getPowerRequirement4812;
		public override int getPowerRequirement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.LocationProvider_._getPowerRequirement4812);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._getPowerRequirement4812);
		}
		internal static global::MonoJavaBridge.MethodId _requiresNetwork4813;
		public override bool requiresNetwork() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._requiresNetwork4813);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._requiresNetwork4813);
		}
		internal static global::MonoJavaBridge.MethodId _requiresSatellite4814;
		public override bool requiresSatellite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._requiresSatellite4814);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._requiresSatellite4814);
		}
		internal static global::MonoJavaBridge.MethodId _requiresCell4815;
		public override bool requiresCell() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._requiresCell4815);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._requiresCell4815);
		}
		internal static global::MonoJavaBridge.MethodId _hasMonetaryCost4816;
		public override bool hasMonetaryCost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._hasMonetaryCost4816);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._hasMonetaryCost4816);
		}
		internal static global::MonoJavaBridge.MethodId _supportsAltitude4817;
		public override bool supportsAltitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._supportsAltitude4817);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._supportsAltitude4817);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSpeed4818;
		public override bool supportsSpeed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._supportsSpeed4818);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._supportsSpeed4818);
		}
		internal static global::MonoJavaBridge.MethodId _supportsBearing4819;
		public override bool supportsBearing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_._supportsBearing4819);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.LocationProvider_.staticClass, global::android.location.LocationProvider_._supportsBearing4819);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.LocationProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/LocationProvider"));
			global::android.location.LocationProvider_._getAccuracy4811 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "getAccuracy", "()I");
			global::android.location.LocationProvider_._getPowerRequirement4812 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "getPowerRequirement", "()I");
			global::android.location.LocationProvider_._requiresNetwork4813 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "requiresNetwork", "()Z");
			global::android.location.LocationProvider_._requiresSatellite4814 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "requiresSatellite", "()Z");
			global::android.location.LocationProvider_._requiresCell4815 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "requiresCell", "()Z");
			global::android.location.LocationProvider_._hasMonetaryCost4816 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "hasMonetaryCost", "()Z");
			global::android.location.LocationProvider_._supportsAltitude4817 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "supportsAltitude", "()Z");
			global::android.location.LocationProvider_._supportsSpeed4818 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "supportsSpeed", "()Z");
			global::android.location.LocationProvider_._supportsBearing4819 = @__env.GetMethodIDNoThrow(global::android.location.LocationProvider_.staticClass, "supportsBearing", "()Z");
		}
	}
}
