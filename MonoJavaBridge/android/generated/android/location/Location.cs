namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Location : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Location(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Location.staticClass, "toString", "()Ljava/lang/String;", ref global::android.location.Location._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void set(android.location.Location arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "set", "(Landroid/location/Location;)V", ref global::android.location.Location._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "reset", "()V", ref global::android.location.Location._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setTime(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "setTime", "(J)V", ref global::android.location.Location._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long Time
		{
			get
			{
				return getTime();
			}
			set
			{
				setTime(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual long getTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.location.Location.staticClass, "getTime", "()J", ref global::android.location.Location._m4);
		}
		public new global::java.lang.String Provider
		{
			get
			{
				return getProvider();
			}
			set
			{
				setProvider(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Location.staticClass, "getProvider", "()Ljava/lang/String;", ref global::android.location.Location._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static double convert(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.Location._m6.native == global::System.IntPtr.Zero)
				global::android.location.Location._m6 = @__env.GetStaticMethodIDNoThrow(global::android.location.Location.staticClass, "convert", "(Ljava/lang/String;)D");
			return @__env.CallStaticDoubleMethod(android.location.Location.staticClass, global::android.location.Location._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.lang.String convert(double arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.Location._m7.native == global::System.IntPtr.Zero)
				global::android.location.Location._m7 = @__env.GetStaticMethodIDNoThrow(global::android.location.Location.staticClass, "convert", "(DI)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.location.Location.staticClass, global::android.location.Location._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.location.Location._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.location.Location._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.Location.staticClass, "describeContents", "()I", ref global::android.location.Location._m10);
		}
		public new global::android.os.Bundle Extras
		{
			get
			{
				return getExtras();
			}
			set
			{
				setExtras(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::android.os.Bundle getExtras()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.location.Location.staticClass, "getExtras", "()Landroid/os/Bundle;", ref global::android.location.Location._m11) as android.os.Bundle;
		}
		public new double Latitude
		{
			get
			{
				return getLatitude();
			}
			set
			{
				setLatitude(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual double getLatitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.location.Location.staticClass, "getLatitude", "()D", ref global::android.location.Location._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setLatitude(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "setLatitude", "(D)V", ref global::android.location.Location._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new double Longitude
		{
			get
			{
				return getLongitude();
			}
			set
			{
				setLongitude(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual double getLongitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.location.Location.staticClass, "getLongitude", "()D", ref global::android.location.Location._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setLongitude(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "setLongitude", "(D)V", ref global::android.location.Location._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setExtras(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "setExtras", "(Landroid/os/Bundle;)V", ref global::android.location.Location._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setAccuracy(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "setAccuracy", "(F)V", ref global::android.location.Location._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float Accuracy
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
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual float getAccuracy()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.location.Location.staticClass, "getAccuracy", "()F", ref global::android.location.Location._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static void distanceBetween(double arg0, double arg1, double arg2, double arg3, float[] arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.Location._m19.native == global::System.IntPtr.Zero)
				global::android.location.Location._m19 = @__env.GetStaticMethodIDNoThrow(global::android.location.Location.staticClass, "distanceBetween", "(DDDD[F)V");
			@__env.CallStaticVoidMethod(android.location.Location.staticClass, global::android.location.Location._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual float distanceTo(android.location.Location arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.location.Location.staticClass, "distanceTo", "(Landroid/location/Location;)F", ref global::android.location.Location._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual float bearingTo(android.location.Location arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.location.Location.staticClass, "bearingTo", "(Landroid/location/Location;)F", ref global::android.location.Location._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setProvider(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "setProvider", "(Ljava/lang/String;)V", ref global::android.location.Location._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool hasAltitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Location.staticClass, "hasAltitude", "()Z", ref global::android.location.Location._m23);
		}
		public new double Altitude
		{
			get
			{
				return getAltitude();
			}
			set
			{
				setAltitude(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual double getAltitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.location.Location.staticClass, "getAltitude", "()D", ref global::android.location.Location._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setAltitude(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "setAltitude", "(D)V", ref global::android.location.Location._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void removeAltitude()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "removeAltitude", "()V", ref global::android.location.Location._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool hasSpeed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Location.staticClass, "hasSpeed", "()Z", ref global::android.location.Location._m27);
		}
		public new float Speed
		{
			get
			{
				return getSpeed();
			}
			set
			{
				setSpeed(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual float getSpeed()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.location.Location.staticClass, "getSpeed", "()F", ref global::android.location.Location._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void setSpeed(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "setSpeed", "(F)V", ref global::android.location.Location._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void removeSpeed()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "removeSpeed", "()V", ref global::android.location.Location._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual bool hasBearing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Location.staticClass, "hasBearing", "()Z", ref global::android.location.Location._m31);
		}
		public new float Bearing
		{
			get
			{
				return getBearing();
			}
			set
			{
				setBearing(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual float getBearing()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.location.Location.staticClass, "getBearing", "()F", ref global::android.location.Location._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void setBearing(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "setBearing", "(F)V", ref global::android.location.Location._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void removeBearing()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "removeBearing", "()V", ref global::android.location.Location._m34);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual bool hasAccuracy()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Location.staticClass, "hasAccuracy", "()Z", ref global::android.location.Location._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void removeAccuracy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Location.staticClass, "removeAccuracy", "()V", ref global::android.location.Location._m36);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public Location(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.Location._m37.native == global::System.IntPtr.Zero)
				global::android.location.Location._m37 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Location.staticClass, global::android.location.Location._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public Location(android.location.Location arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.Location._m38.native == global::System.IntPtr.Zero)
				global::android.location.Location._m38 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "<init>", "(Landroid/location/Location;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Location.staticClass, global::android.location.Location._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int FORMAT_DEGREES
		{
			get
			{
				return 0;
			}
		}
		public static int FORMAT_MINUTES
		{
			get
			{
				return 1;
			}
		}
		public static int FORMAT_SECONDS
		{
			get
			{
				return 2;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2612;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.location.Location.staticClass, _CREATOR2612)) as android.os.Parcelable_Creator;
			}
		}
		static Location()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.Location.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/Location"));
			global::android.location.Location._CREATOR2612 = @__env.GetStaticFieldIDNoThrow(global::android.location.Location.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
