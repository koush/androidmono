namespace android.location 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Criteria : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Criteria() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.location.Criteria), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4017; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				@__env.CallVoidMethod(this, _writeToParcel4017, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Criteria.staticClass, _writeToParcel4017, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4018; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				return @__env.CallIntMethod(this, _describeContents4018); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.location.Criteria.staticClass, _describeContents4018); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAccuracy4019; 
		public virtual void setAccuracy(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				@__env.CallVoidMethod(this, _setAccuracy4019, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Criteria.staticClass, _setAccuracy4019, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAccuracy4020; 
		public virtual int getAccuracy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				return @__env.CallIntMethod(this, _getAccuracy4020); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.location.Criteria.staticClass, _getAccuracy4020); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPowerRequirement4021; 
		public virtual void setPowerRequirement(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				@__env.CallVoidMethod(this, _setPowerRequirement4021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Criteria.staticClass, _setPowerRequirement4021, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPowerRequirement4022; 
		public virtual int getPowerRequirement() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				return @__env.CallIntMethod(this, _getPowerRequirement4022); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.location.Criteria.staticClass, _getPowerRequirement4022); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCostAllowed4023; 
		public virtual void setCostAllowed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				@__env.CallVoidMethod(this, _setCostAllowed4023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Criteria.staticClass, _setCostAllowed4023, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isCostAllowed4024; 
		public virtual bool isCostAllowed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				return @__env.CallBooleanMethod(this, _isCostAllowed4024); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.Criteria.staticClass, _isCostAllowed4024); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAltitudeRequired4025; 
		public virtual void setAltitudeRequired(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				@__env.CallVoidMethod(this, _setAltitudeRequired4025, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Criteria.staticClass, _setAltitudeRequired4025, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAltitudeRequired4026; 
		public virtual bool isAltitudeRequired() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				return @__env.CallBooleanMethod(this, _isAltitudeRequired4026); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.Criteria.staticClass, _isAltitudeRequired4026); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSpeedRequired4027; 
		public virtual void setSpeedRequired(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				@__env.CallVoidMethod(this, _setSpeedRequired4027, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Criteria.staticClass, _setSpeedRequired4027, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSpeedRequired4028; 
		public virtual bool isSpeedRequired() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				return @__env.CallBooleanMethod(this, _isSpeedRequired4028); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.Criteria.staticClass, _isSpeedRequired4028); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBearingRequired4029; 
		public virtual void setBearingRequired(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				@__env.CallVoidMethod(this, _setBearingRequired4029, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Criteria.staticClass, _setBearingRequired4029, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBearingRequired4030; 
		public virtual bool isBearingRequired() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Criteria)) 
				return @__env.CallBooleanMethod(this, _isBearingRequired4030); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.Criteria.staticClass, _isBearingRequired4030); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Criteria4031; 
		public Criteria()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.location.Criteria.staticClass, _Criteria4031, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Criteria4032; 
		public Criteria(android.location.Criteria arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.location.Criteria.staticClass, _Criteria4032, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR4033; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.location.Criteria.staticClass = @__class; 
			global::android.location.Criteria._writeToParcel4017 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.location.Criteria._describeContents4018 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "describeContents", "()I"); 
			global::android.location.Criteria._setAccuracy4019 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setAccuracy", "(I)V"); 
			global::android.location.Criteria._getAccuracy4020 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "getAccuracy", "()I"); 
			global::android.location.Criteria._setPowerRequirement4021 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setPowerRequirement", "(I)V"); 
			global::android.location.Criteria._getPowerRequirement4022 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "getPowerRequirement", "()I"); 
			global::android.location.Criteria._setCostAllowed4023 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setCostAllowed", "(Z)V"); 
			global::android.location.Criteria._isCostAllowed4024 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "isCostAllowed", "()Z"); 
			global::android.location.Criteria._setAltitudeRequired4025 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setAltitudeRequired", "(Z)V"); 
			global::android.location.Criteria._isAltitudeRequired4026 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "isAltitudeRequired", "()Z"); 
			global::android.location.Criteria._setSpeedRequired4027 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setSpeedRequired", "(Z)V"); 
			global::android.location.Criteria._isSpeedRequired4028 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "isSpeedRequired", "()Z"); 
			global::android.location.Criteria._setBearingRequired4029 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setBearingRequired", "(Z)V"); 
			global::android.location.Criteria._isBearingRequired4030 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "isBearingRequired", "()Z"); 
			global::android.location.Criteria._Criteria4031 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "<init>", "()V"); 
			global::android.location.Criteria._Criteria4032 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "<init>", "(Landroid/location/Criteria;)V"); 
		} 
	} 
} 
