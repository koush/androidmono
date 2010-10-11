namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Criteria : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Criteria()
		{
			InitJNI();
		}
		protected Criteria(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4694;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Criteria._writeToParcel4694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._writeToParcel4694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4695;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.Criteria._describeContents4695);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._describeContents4695);
		}
		internal static global::MonoJavaBridge.MethodId _setAccuracy4696;
		public virtual void setAccuracy(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Criteria._setAccuracy4696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._setAccuracy4696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAccuracy4697;
		public virtual int getAccuracy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.Criteria._getAccuracy4697);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._getAccuracy4697);
		}
		internal static global::MonoJavaBridge.MethodId _setPowerRequirement4698;
		public virtual void setPowerRequirement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Criteria._setPowerRequirement4698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._setPowerRequirement4698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPowerRequirement4699;
		public virtual int getPowerRequirement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.Criteria._getPowerRequirement4699);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._getPowerRequirement4699);
		}
		internal static global::MonoJavaBridge.MethodId _setCostAllowed4700;
		public virtual void setCostAllowed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Criteria._setCostAllowed4700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._setCostAllowed4700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCostAllowed4701;
		public virtual bool isCostAllowed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Criteria._isCostAllowed4701);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._isCostAllowed4701);
		}
		internal static global::MonoJavaBridge.MethodId _setAltitudeRequired4702;
		public virtual void setAltitudeRequired(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Criteria._setAltitudeRequired4702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._setAltitudeRequired4702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAltitudeRequired4703;
		public virtual bool isAltitudeRequired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Criteria._isAltitudeRequired4703);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._isAltitudeRequired4703);
		}
		internal static global::MonoJavaBridge.MethodId _setSpeedRequired4704;
		public virtual void setSpeedRequired(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Criteria._setSpeedRequired4704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._setSpeedRequired4704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpeedRequired4705;
		public virtual bool isSpeedRequired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Criteria._isSpeedRequired4705);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._isSpeedRequired4705);
		}
		internal static global::MonoJavaBridge.MethodId _setBearingRequired4706;
		public virtual void setBearingRequired(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Criteria._setBearingRequired4706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._setBearingRequired4706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isBearingRequired4707;
		public virtual bool isBearingRequired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Criteria._isBearingRequired4707);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._isBearingRequired4707);
		}
		internal static global::MonoJavaBridge.MethodId _Criteria4708;
		public Criteria()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Criteria.staticClass, global::android.location.Criteria._Criteria4708);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Criteria4709;
		public Criteria(android.location.Criteria arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Criteria.staticClass, global::android.location.Criteria._Criteria4709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
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
		internal static global::MonoJavaBridge.FieldId _CREATOR4710;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.Criteria.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/Criteria"));
			global::android.location.Criteria._writeToParcel4694 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.location.Criteria._describeContents4695 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "describeContents", "()I");
			global::android.location.Criteria._setAccuracy4696 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "setAccuracy", "(I)V");
			global::android.location.Criteria._getAccuracy4697 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "getAccuracy", "()I");
			global::android.location.Criteria._setPowerRequirement4698 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "setPowerRequirement", "(I)V");
			global::android.location.Criteria._getPowerRequirement4699 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "getPowerRequirement", "()I");
			global::android.location.Criteria._setCostAllowed4700 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "setCostAllowed", "(Z)V");
			global::android.location.Criteria._isCostAllowed4701 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "isCostAllowed", "()Z");
			global::android.location.Criteria._setAltitudeRequired4702 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "setAltitudeRequired", "(Z)V");
			global::android.location.Criteria._isAltitudeRequired4703 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "isAltitudeRequired", "()Z");
			global::android.location.Criteria._setSpeedRequired4704 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "setSpeedRequired", "(Z)V");
			global::android.location.Criteria._isSpeedRequired4705 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "isSpeedRequired", "()Z");
			global::android.location.Criteria._setBearingRequired4706 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "setBearingRequired", "(Z)V");
			global::android.location.Criteria._isBearingRequired4707 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "isBearingRequired", "()Z");
			global::android.location.Criteria._Criteria4708 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "<init>", "()V");
			global::android.location.Criteria._Criteria4709 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "<init>", "(Landroid/location/Criteria;)V");
		}
	}
}
