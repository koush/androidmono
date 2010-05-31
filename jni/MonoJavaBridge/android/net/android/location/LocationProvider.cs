namespace android.location 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class LocationProvider : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static LocationProvider() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.location.LocationProvider), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected LocationProvider(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName4346; 
		public virtual global::java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.LocationProvider._getName4346)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.LocationProvider.staticClass, global::android.location.LocationProvider._getName4346)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAccuracy4347; 
		public abstract int getAccuracy(); 
		internal static global::net.sf.jni4net.jni.MethodId _getPowerRequirement4348; 
		public abstract int getPowerRequirement(); 
		internal static global::net.sf.jni4net.jni.MethodId _requiresNetwork4349; 
		public abstract bool requiresNetwork(); 
		internal static global::net.sf.jni4net.jni.MethodId _requiresSatellite4350; 
		public abstract bool requiresSatellite(); 
		internal static global::net.sf.jni4net.jni.MethodId _requiresCell4351; 
		public abstract bool requiresCell(); 
		internal static global::net.sf.jni4net.jni.MethodId _hasMonetaryCost4352; 
		public abstract bool hasMonetaryCost(); 
		internal static global::net.sf.jni4net.jni.MethodId _supportsAltitude4353; 
		public abstract bool supportsAltitude(); 
		internal static global::net.sf.jni4net.jni.MethodId _supportsSpeed4354; 
		public abstract bool supportsSpeed(); 
		internal static global::net.sf.jni4net.jni.MethodId _supportsBearing4355; 
		public abstract bool supportsBearing(); 
		internal static global::net.sf.jni4net.jni.MethodId _meetsCriteria4356; 
		public virtual bool meetsCriteria(android.location.Criteria arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.location.LocationProvider._meetsCriteria4356, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.LocationProvider.staticClass, global::android.location.LocationProvider._meetsCriteria4356, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.location.LocationProvider.staticClass = @__class; 
			global::android.location.LocationProvider._getName4346 = @__env.GetMethodID(global::android.location.LocationProvider.staticClass, "getName", "()Ljava/lang/String;"); 
			global::android.location.LocationProvider._getAccuracy4347 = @__env.GetMethodID(global::android.location.LocationProvider.staticClass, "getAccuracy", "()I"); 
			global::android.location.LocationProvider._getPowerRequirement4348 = @__env.GetMethodID(global::android.location.LocationProvider.staticClass, "getPowerRequirement", "()I"); 
			global::android.location.LocationProvider._requiresNetwork4349 = @__env.GetMethodID(global::android.location.LocationProvider.staticClass, "requiresNetwork", "()Z"); 
			global::android.location.LocationProvider._requiresSatellite4350 = @__env.GetMethodID(global::android.location.LocationProvider.staticClass, "requiresSatellite", "()Z"); 
			global::android.location.LocationProvider._requiresCell4351 = @__env.GetMethodID(global::android.location.LocationProvider.staticClass, "requiresCell", "()Z"); 
			global::android.location.LocationProvider._hasMonetaryCost4352 = @__env.GetMethodID(global::android.location.LocationProvider.staticClass, "hasMonetaryCost", "()Z"); 
			global::android.location.LocationProvider._supportsAltitude4353 = @__env.GetMethodID(global::android.location.LocationProvider.staticClass, "supportsAltitude", "()Z"); 
			global::android.location.LocationProvider._supportsSpeed4354 = @__env.GetMethodID(global::android.location.LocationProvider.staticClass, "supportsSpeed", "()Z"); 
			global::android.location.LocationProvider._supportsBearing4355 = @__env.GetMethodID(global::android.location.LocationProvider.staticClass, "supportsBearing", "()Z"); 
			global::android.location.LocationProvider._meetsCriteria4356 = @__env.GetMethodID(global::android.location.LocationProvider.staticClass, "meetsCriteria", "(Landroid/location/Criteria;)Z"); 
		} 
	} 
} 
