namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Criteria : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Criteria(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Criteria.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.location.Criteria._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.Criteria.staticClass, "describeContents", "()I", ref global::android.location.Criteria._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setAccuracy(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Criteria.staticClass, "setAccuracy", "(I)V", ref global::android.location.Criteria._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getAccuracy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.Criteria.staticClass, "getAccuracy", "()I", ref global::android.location.Criteria._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setPowerRequirement(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Criteria.staticClass, "setPowerRequirement", "(I)V", ref global::android.location.Criteria._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getPowerRequirement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.Criteria.staticClass, "getPowerRequirement", "()I", ref global::android.location.Criteria._m5);
		}
		public new bool CostAllowed
		{
			set
			{
				setCostAllowed(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setCostAllowed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Criteria.staticClass, "setCostAllowed", "(Z)V", ref global::android.location.Criteria._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isCostAllowed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Criteria.staticClass, "isCostAllowed", "()Z", ref global::android.location.Criteria._m7);
		}
		public new bool AltitudeRequired
		{
			set
			{
				setAltitudeRequired(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setAltitudeRequired(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Criteria.staticClass, "setAltitudeRequired", "(Z)V", ref global::android.location.Criteria._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isAltitudeRequired()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Criteria.staticClass, "isAltitudeRequired", "()Z", ref global::android.location.Criteria._m9);
		}
		public new bool SpeedRequired
		{
			set
			{
				setSpeedRequired(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setSpeedRequired(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Criteria.staticClass, "setSpeedRequired", "(Z)V", ref global::android.location.Criteria._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool isSpeedRequired()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Criteria.staticClass, "isSpeedRequired", "()Z", ref global::android.location.Criteria._m11);
		}
		public new bool BearingRequired
		{
			set
			{
				setBearingRequired(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setBearingRequired(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Criteria.staticClass, "setBearingRequired", "(Z)V", ref global::android.location.Criteria._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool isBearingRequired()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Criteria.staticClass, "isBearingRequired", "()Z", ref global::android.location.Criteria._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public Criteria() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.Criteria._m14.native == global::System.IntPtr.Zero)
				global::android.location.Criteria._m14 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Criteria.staticClass, global::android.location.Criteria._m14);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public Criteria(android.location.Criteria arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.Criteria._m15.native == global::System.IntPtr.Zero)
				global::android.location.Criteria._m15 = @__env.GetMethodIDNoThrow(global::android.location.Criteria.staticClass, "<init>", "(Landroid/location/Criteria;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Criteria.staticClass, global::android.location.Criteria._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR2604;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.location.Criteria.staticClass, _CREATOR2604)) as android.os.Parcelable_Creator;
			}
		}
		static Criteria()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.Criteria.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/Criteria"));
			global::android.location.Criteria._CREATOR2604 = @__env.GetStaticFieldIDNoThrow(global::android.location.Criteria.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
