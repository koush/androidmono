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
		internal static global::MonoJavaBridge.MethodId _writeToParcel6815;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Criteria._writeToParcel6815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._writeToParcel6815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents6816;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.Criteria._describeContents6816);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._describeContents6816);
		}
		internal static global::MonoJavaBridge.MethodId _setAccuracy6817;
		public virtual void setAccuracy(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Criteria._setAccuracy6817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._setAccuracy6817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Accuracy
		{
			get
			{
				return getAccuracy();
			}
			set
			{
				setAccuracy(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAccuracy6818;
		public virtual int getAccuracy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.Criteria._getAccuracy6818);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._getAccuracy6818);
		}
		internal static global::MonoJavaBridge.MethodId _setPowerRequirement6819;
		public virtual void setPowerRequirement(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Criteria._setPowerRequirement6819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._setPowerRequirement6819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int PowerRequirement
		{
			get
			{
				return getPowerRequirement();
			}
			set
			{
				setPowerRequirement(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPowerRequirement6820;
		public virtual int getPowerRequirement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.Criteria._getPowerRequirement6820);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._getPowerRequirement6820);
		}
		internal static global::MonoJavaBridge.MethodId _setCostAllowed6821;
		public virtual void setCostAllowed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Criteria._setCostAllowed6821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._setCostAllowed6821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCostAllowed6822;
		public virtual bool isCostAllowed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Criteria._isCostAllowed6822);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._isCostAllowed6822);
		}
		internal static global::MonoJavaBridge.MethodId _setAltitudeRequired6823;
		public virtual void setAltitudeRequired(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Criteria._setAltitudeRequired6823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._setAltitudeRequired6823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isAltitudeRequired6824;
		public virtual bool isAltitudeRequired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Criteria._isAltitudeRequired6824);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._isAltitudeRequired6824);
		}
		internal static global::MonoJavaBridge.MethodId _setSpeedRequired6825;
		public virtual void setSpeedRequired(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Criteria._setSpeedRequired6825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._setSpeedRequired6825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpeedRequired6826;
		public virtual bool isSpeedRequired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Criteria._isSpeedRequired6826);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._isSpeedRequired6826);
		}
		internal static global::MonoJavaBridge.MethodId _setBearingRequired6827;
		public virtual void setBearingRequired(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Criteria._setBearingRequired6827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._setBearingRequired6827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isBearingRequired6828;
		public virtual bool isBearingRequired() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Criteria._isBearingRequired6828);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Criteria.staticClass, global::android.location.Criteria._isBearingRequired6828);
		}
		internal static global::MonoJavaBridge.MethodId _Criteria6829;
		public Criteria()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Criteria.staticClass, global::android.location.Criteria._Criteria6829);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Criteria6830;
		public Criteria(android.location.Criteria arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Criteria.staticClass, global::android.location.Criteria._Criteria6830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR6837;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.location.Criteria.staticClass, _CREATOR6837)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.Criteria.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/Criteria"));
			global::android.location.Criteria._writeToParcel6815 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.location.Criteria._describeContents6816 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "describeContents", "()I");
			global::android.location.Criteria._setAccuracy6817 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "setAccuracy", "(I)V");
			global::android.location.Criteria._getAccuracy6818 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "getAccuracy", "()I");
			global::android.location.Criteria._setPowerRequirement6819 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "setPowerRequirement", "(I)V");
			global::android.location.Criteria._getPowerRequirement6820 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "getPowerRequirement", "()I");
			global::android.location.Criteria._setCostAllowed6821 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "setCostAllowed", "(Z)V");
			global::android.location.Criteria._isCostAllowed6822 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "isCostAllowed", "()Z");
			global::android.location.Criteria._setAltitudeRequired6823 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "setAltitudeRequired", "(Z)V");
			global::android.location.Criteria._isAltitudeRequired6824 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "isAltitudeRequired", "()Z");
			global::android.location.Criteria._setSpeedRequired6825 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "setSpeedRequired", "(Z)V");
			global::android.location.Criteria._isSpeedRequired6826 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "isSpeedRequired", "()Z");
			global::android.location.Criteria._setBearingRequired6827 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "setBearingRequired", "(Z)V");
			global::android.location.Criteria._isBearingRequired6828 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "isBearingRequired", "()Z");
			global::android.location.Criteria._Criteria6829 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "<init>", "()V");
			global::android.location.Criteria._Criteria6830 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "<init>", "(Landroid/location/Criteria;)V");
			global::android.location.Criteria._CREATOR6837 = @__env.GetStaticFieldIDNoThrow(global::android.location.Criteria.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
