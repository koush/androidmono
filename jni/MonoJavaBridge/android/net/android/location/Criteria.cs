namespace android.location 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Criteria : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Criteria() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.location.Criteria), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.location.Criteria(@__env); 
			} 
		} 
		protected Criteria(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4240; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				@__env.CallVoidMethod(this, global::android.location.Criteria._writeToParcel4240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._writeToParcel4240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4241; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				return @__env.CallIntMethod(this, global::android.location.Criteria._describeContents4241); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._describeContents4241); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAccuracy4242; 
		public virtual void setAccuracy(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				@__env.CallVoidMethod(this, global::android.location.Criteria._setAccuracy4242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._setAccuracy4242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAccuracy4243; 
		public virtual int getAccuracy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				return @__env.CallIntMethod(this, global::android.location.Criteria._getAccuracy4243); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._getAccuracy4243); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPowerRequirement4244; 
		public virtual void setPowerRequirement(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				@__env.CallVoidMethod(this, global::android.location.Criteria._setPowerRequirement4244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._setPowerRequirement4244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPowerRequirement4245; 
		public virtual int getPowerRequirement() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				return @__env.CallIntMethod(this, global::android.location.Criteria._getPowerRequirement4245); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._getPowerRequirement4245); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCostAllowed4246; 
		public virtual void setCostAllowed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				@__env.CallVoidMethod(this, global::android.location.Criteria._setCostAllowed4246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._setCostAllowed4246, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isCostAllowed4247; 
		public virtual bool isCostAllowed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				return @__env.CallBooleanMethod(this, global::android.location.Criteria._isCostAllowed4247); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._isCostAllowed4247); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAltitudeRequired4248; 
		public virtual void setAltitudeRequired(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				@__env.CallVoidMethod(this, global::android.location.Criteria._setAltitudeRequired4248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._setAltitudeRequired4248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAltitudeRequired4249; 
		public virtual bool isAltitudeRequired() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				return @__env.CallBooleanMethod(this, global::android.location.Criteria._isAltitudeRequired4249); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._isAltitudeRequired4249); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSpeedRequired4250; 
		public virtual void setSpeedRequired(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				@__env.CallVoidMethod(this, global::android.location.Criteria._setSpeedRequired4250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._setSpeedRequired4250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSpeedRequired4251; 
		public virtual bool isSpeedRequired() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				return @__env.CallBooleanMethod(this, global::android.location.Criteria._isSpeedRequired4251); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._isSpeedRequired4251); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBearingRequired4252; 
		public virtual void setBearingRequired(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				@__env.CallVoidMethod(this, global::android.location.Criteria._setBearingRequired4252, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._setBearingRequired4252, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBearingRequired4253; 
		public virtual bool isBearingRequired() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				return @__env.CallBooleanMethod(this, global::android.location.Criteria._isBearingRequired4253); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._isBearingRequired4253); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Criteria4254; 
		public Criteria()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.location.Criteria.staticClass, global::android.location.Criteria._Criteria4254, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Criteria4255; 
		public Criteria(android.location.Criteria arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.location.Criteria.staticClass, global::android.location.Criteria._Criteria4255, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int NO_REQUIREMENT
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int POWER_LOW
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int POWER_MEDIUM
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int POWER_HIGH
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int ACCURACY_FINE
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int ACCURACY_COARSE
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR4256; 
		public static global::android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(global::android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.location.Criteria.staticClass = @__class; 
			global::android.location.Criteria._writeToParcel4240 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.location.Criteria._describeContents4241 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "describeContents", "()I"); 
			global::android.location.Criteria._setAccuracy4242 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setAccuracy", "(I)V"); 
			global::android.location.Criteria._getAccuracy4243 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "getAccuracy", "()I"); 
			global::android.location.Criteria._setPowerRequirement4244 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setPowerRequirement", "(I)V"); 
			global::android.location.Criteria._getPowerRequirement4245 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "getPowerRequirement", "()I"); 
			global::android.location.Criteria._setCostAllowed4246 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setCostAllowed", "(Z)V"); 
			global::android.location.Criteria._isCostAllowed4247 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "isCostAllowed", "()Z"); 
			global::android.location.Criteria._setAltitudeRequired4248 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setAltitudeRequired", "(Z)V"); 
			global::android.location.Criteria._isAltitudeRequired4249 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "isAltitudeRequired", "()Z"); 
			global::android.location.Criteria._setSpeedRequired4250 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setSpeedRequired", "(Z)V"); 
			global::android.location.Criteria._isSpeedRequired4251 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "isSpeedRequired", "()Z"); 
			global::android.location.Criteria._setBearingRequired4252 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setBearingRequired", "(Z)V"); 
			global::android.location.Criteria._isBearingRequired4253 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "isBearingRequired", "()Z"); 
			global::android.location.Criteria._Criteria4254 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "<init>", "()V"); 
			global::android.location.Criteria._Criteria4255 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "<init>", "(Landroid/location/Criteria;)V"); 
		} 
	} 
} 
