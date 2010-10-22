namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Location : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Location()
		{
			InitJNI();
		}
		protected Location(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString6859;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Location._toString6859)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._toString6859)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set6860;
		public virtual void set(android.location.Location arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._set6860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._set6860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset6861;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._reset6861);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._reset6861);
		}
		internal static global::MonoJavaBridge.MethodId _setTime6862;
		public virtual void setTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setTime6862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setTime6862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTime6863;
		public virtual long getTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.location.Location._getTime6863);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getTime6863);
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
		internal static global::MonoJavaBridge.MethodId _getProvider6864;
		public virtual global::java.lang.String getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Location._getProvider6864)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getProvider6864)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _convert6865;
		public static double convert(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(android.location.Location.staticClass, global::android.location.Location._convert6865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convert6866;
		public static global::java.lang.String convert(double arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.location.Location.staticClass, global::android.location.Location._convert6866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump6867;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._dump6867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._dump6867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel6868;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._writeToParcel6868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._writeToParcel6868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents6869;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.Location._describeContents6869);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._describeContents6869);
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
		internal static global::MonoJavaBridge.MethodId _getExtras6870;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Location._getExtras6870)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getExtras6870)) as android.os.Bundle;
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
		internal static global::MonoJavaBridge.MethodId _getLatitude6871;
		public virtual double getLatitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.location.Location._getLatitude6871);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getLatitude6871);
		}
		internal static global::MonoJavaBridge.MethodId _setLatitude6872;
		public virtual void setLatitude(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setLatitude6872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setLatitude6872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLongitude6873;
		public virtual double getLongitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.location.Location._getLongitude6873);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getLongitude6873);
		}
		internal static global::MonoJavaBridge.MethodId _setLongitude6874;
		public virtual void setLongitude(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setLongitude6874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setLongitude6874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExtras6875;
		public virtual void setExtras(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setExtras6875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setExtras6875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAccuracy6876;
		public virtual void setAccuracy(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setAccuracy6876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setAccuracy6876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAccuracy6877;
		public virtual float getAccuracy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.Location._getAccuracy6877);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getAccuracy6877);
		}
		internal static global::MonoJavaBridge.MethodId _distanceBetween6878;
		public static void distanceBetween(double arg0, double arg1, double arg2, double arg3, float[] arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.location.Location.staticClass, global::android.location.Location._distanceBetween6878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _distanceTo6879;
		public virtual float distanceTo(android.location.Location arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.Location._distanceTo6879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._distanceTo6879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bearingTo6880;
		public virtual float bearingTo(android.location.Location arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.Location._bearingTo6880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._bearingTo6880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProvider6881;
		public virtual void setProvider(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setProvider6881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setProvider6881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasAltitude6882;
		public virtual bool hasAltitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Location._hasAltitude6882);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._hasAltitude6882);
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
		internal static global::MonoJavaBridge.MethodId _getAltitude6883;
		public virtual double getAltitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.location.Location._getAltitude6883);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getAltitude6883);
		}
		internal static global::MonoJavaBridge.MethodId _setAltitude6884;
		public virtual void setAltitude(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setAltitude6884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setAltitude6884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAltitude6885;
		public virtual void removeAltitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._removeAltitude6885);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._removeAltitude6885);
		}
		internal static global::MonoJavaBridge.MethodId _hasSpeed6886;
		public virtual bool hasSpeed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Location._hasSpeed6886);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._hasSpeed6886);
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
		internal static global::MonoJavaBridge.MethodId _getSpeed6887;
		public virtual float getSpeed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.Location._getSpeed6887);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getSpeed6887);
		}
		internal static global::MonoJavaBridge.MethodId _setSpeed6888;
		public virtual void setSpeed(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setSpeed6888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setSpeed6888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeSpeed6889;
		public virtual void removeSpeed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._removeSpeed6889);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._removeSpeed6889);
		}
		internal static global::MonoJavaBridge.MethodId _hasBearing6890;
		public virtual bool hasBearing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Location._hasBearing6890);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._hasBearing6890);
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
		internal static global::MonoJavaBridge.MethodId _getBearing6891;
		public virtual float getBearing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.Location._getBearing6891);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getBearing6891);
		}
		internal static global::MonoJavaBridge.MethodId _setBearing6892;
		public virtual void setBearing(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setBearing6892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setBearing6892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeBearing6893;
		public virtual void removeBearing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._removeBearing6893);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._removeBearing6893);
		}
		internal static global::MonoJavaBridge.MethodId _hasAccuracy6894;
		public virtual bool hasAccuracy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Location._hasAccuracy6894);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._hasAccuracy6894);
		}
		internal static global::MonoJavaBridge.MethodId _removeAccuracy6895;
		public virtual void removeAccuracy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._removeAccuracy6895);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._removeAccuracy6895);
		}
		internal static global::MonoJavaBridge.MethodId _Location6896;
		public Location(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Location.staticClass, global::android.location.Location._Location6896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Location6897;
		public Location(android.location.Location arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Location.staticClass, global::android.location.Location._Location6897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR6901;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.location.Location.staticClass, _CREATOR6901)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.Location.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/Location"));
			global::android.location.Location._toString6859 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "toString", "()Ljava/lang/String;");
			global::android.location.Location._set6860 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "set", "(Landroid/location/Location;)V");
			global::android.location.Location._reset6861 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "reset", "()V");
			global::android.location.Location._setTime6862 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setTime", "(J)V");
			global::android.location.Location._getTime6863 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getTime", "()J");
			global::android.location.Location._getProvider6864 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getProvider", "()Ljava/lang/String;");
			global::android.location.Location._convert6865 = @__env.GetStaticMethodIDNoThrow(global::android.location.Location.staticClass, "convert", "(Ljava/lang/String;)D");
			global::android.location.Location._convert6866 = @__env.GetStaticMethodIDNoThrow(global::android.location.Location.staticClass, "convert", "(DI)Ljava/lang/String;");
			global::android.location.Location._dump6867 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.location.Location._writeToParcel6868 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.location.Location._describeContents6869 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "describeContents", "()I");
			global::android.location.Location._getExtras6870 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.location.Location._getLatitude6871 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getLatitude", "()D");
			global::android.location.Location._setLatitude6872 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setLatitude", "(D)V");
			global::android.location.Location._getLongitude6873 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getLongitude", "()D");
			global::android.location.Location._setLongitude6874 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setLongitude", "(D)V");
			global::android.location.Location._setExtras6875 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setExtras", "(Landroid/os/Bundle;)V");
			global::android.location.Location._setAccuracy6876 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setAccuracy", "(F)V");
			global::android.location.Location._getAccuracy6877 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getAccuracy", "()F");
			global::android.location.Location._distanceBetween6878 = @__env.GetStaticMethodIDNoThrow(global::android.location.Location.staticClass, "distanceBetween", "(DDDD[F)V");
			global::android.location.Location._distanceTo6879 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "distanceTo", "(Landroid/location/Location;)F");
			global::android.location.Location._bearingTo6880 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "bearingTo", "(Landroid/location/Location;)F");
			global::android.location.Location._setProvider6881 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setProvider", "(Ljava/lang/String;)V");
			global::android.location.Location._hasAltitude6882 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "hasAltitude", "()Z");
			global::android.location.Location._getAltitude6883 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getAltitude", "()D");
			global::android.location.Location._setAltitude6884 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setAltitude", "(D)V");
			global::android.location.Location._removeAltitude6885 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "removeAltitude", "()V");
			global::android.location.Location._hasSpeed6886 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "hasSpeed", "()Z");
			global::android.location.Location._getSpeed6887 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getSpeed", "()F");
			global::android.location.Location._setSpeed6888 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setSpeed", "(F)V");
			global::android.location.Location._removeSpeed6889 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "removeSpeed", "()V");
			global::android.location.Location._hasBearing6890 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "hasBearing", "()Z");
			global::android.location.Location._getBearing6891 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getBearing", "()F");
			global::android.location.Location._setBearing6892 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setBearing", "(F)V");
			global::android.location.Location._removeBearing6893 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "removeBearing", "()V");
			global::android.location.Location._hasAccuracy6894 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "hasAccuracy", "()Z");
			global::android.location.Location._removeAccuracy6895 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "removeAccuracy", "()V");
			global::android.location.Location._Location6896 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.location.Location._Location6897 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "<init>", "(Landroid/location/Location;)V");
			global::android.location.Location._CREATOR6901 = @__env.GetStaticFieldIDNoThrow(global::android.location.Location.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
