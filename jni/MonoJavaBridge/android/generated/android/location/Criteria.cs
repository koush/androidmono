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
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4472;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Criteria._writeToParcel4472, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._writeToParcel4472, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4473;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.location.Criteria._describeContents4473);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._describeContents4473);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAccuracy4474;
		public virtual void setAccuracy(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Criteria._setAccuracy4474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._setAccuracy4474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAccuracy4475;
		public virtual int getAccuracy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.location.Criteria._getAccuracy4475);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._getAccuracy4475);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPowerRequirement4476;
		public virtual void setPowerRequirement(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Criteria._setPowerRequirement4476, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._setPowerRequirement4476, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPowerRequirement4477;
		public virtual int getPowerRequirement() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.location.Criteria._getPowerRequirement4477);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._getPowerRequirement4477);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCostAllowed4478;
		public virtual void setCostAllowed(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Criteria._setCostAllowed4478, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._setCostAllowed4478, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isCostAllowed4479;
		public virtual bool isCostAllowed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.Criteria._isCostAllowed4479);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._isCostAllowed4479);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAltitudeRequired4480;
		public virtual void setAltitudeRequired(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Criteria._setAltitudeRequired4480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._setAltitudeRequired4480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAltitudeRequired4481;
		public virtual bool isAltitudeRequired() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.Criteria._isAltitudeRequired4481);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._isAltitudeRequired4481);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSpeedRequired4482;
		public virtual void setSpeedRequired(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Criteria._setSpeedRequired4482, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._setSpeedRequired4482, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSpeedRequired4483;
		public virtual bool isSpeedRequired() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.Criteria._isSpeedRequired4483);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._isSpeedRequired4483);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBearingRequired4484;
		public virtual void setBearingRequired(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Criteria._setBearingRequired4484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._setBearingRequired4484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isBearingRequired4485;
		public virtual bool isBearingRequired() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.Criteria._isBearingRequired4485);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Criteria.staticClass, global::android.location.Criteria._isBearingRequired4485);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Criteria4486;
		public Criteria()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.location.Criteria.staticClass, global::android.location.Criteria._Criteria4486, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Criteria4487;
		public Criteria(android.location.Criteria arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.location.Criteria.staticClass, global::android.location.Criteria._Criteria4487, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR4488;
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
			global::android.location.Criteria._writeToParcel4472 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.location.Criteria._describeContents4473 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "describeContents", "()I");
			global::android.location.Criteria._setAccuracy4474 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setAccuracy", "(I)V");
			global::android.location.Criteria._getAccuracy4475 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "getAccuracy", "()I");
			global::android.location.Criteria._setPowerRequirement4476 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setPowerRequirement", "(I)V");
			global::android.location.Criteria._getPowerRequirement4477 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "getPowerRequirement", "()I");
			global::android.location.Criteria._setCostAllowed4478 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setCostAllowed", "(Z)V");
			global::android.location.Criteria._isCostAllowed4479 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "isCostAllowed", "()Z");
			global::android.location.Criteria._setAltitudeRequired4480 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setAltitudeRequired", "(Z)V");
			global::android.location.Criteria._isAltitudeRequired4481 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "isAltitudeRequired", "()Z");
			global::android.location.Criteria._setSpeedRequired4482 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setSpeedRequired", "(Z)V");
			global::android.location.Criteria._isSpeedRequired4483 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "isSpeedRequired", "()Z");
			global::android.location.Criteria._setBearingRequired4484 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "setBearingRequired", "(Z)V");
			global::android.location.Criteria._isBearingRequired4485 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "isBearingRequired", "()Z");
			global::android.location.Criteria._Criteria4486 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "<init>", "()V");
			global::android.location.Criteria._Criteria4487 = @__env.GetMethodID(global::android.location.Criteria.staticClass, "<init>", "(Landroid/location/Criteria;)V");
		}
	}
}
