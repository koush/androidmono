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
		internal static global::MonoJavaBridge.MethodId _toString6886;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Location._toString6886)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._toString6886)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set6887;
		public virtual void set(android.location.Location arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._set6887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._set6887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset6888;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._reset6888);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._reset6888);
		}
		internal static global::MonoJavaBridge.MethodId _setTime6889;
		public virtual void setTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setTime6889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setTime6889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTime6890;
		public virtual long getTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.location.Location._getTime6890);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getTime6890);
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
		internal static global::MonoJavaBridge.MethodId _getProvider6891;
		public virtual global::java.lang.String getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Location._getProvider6891)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getProvider6891)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _convert6892;
		public static double convert(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(android.location.Location.staticClass, global::android.location.Location._convert6892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convert6893;
		public static global::java.lang.String convert(double arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.location.Location.staticClass, global::android.location.Location._convert6893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump6894;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._dump6894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._dump6894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel6895;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._writeToParcel6895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._writeToParcel6895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents6896;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.Location._describeContents6896);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._describeContents6896);
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
		internal static global::MonoJavaBridge.MethodId _getExtras6897;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Location._getExtras6897)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getExtras6897)) as android.os.Bundle;
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
		internal static global::MonoJavaBridge.MethodId _getLatitude6898;
		public virtual double getLatitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.location.Location._getLatitude6898);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getLatitude6898);
		}
		internal static global::MonoJavaBridge.MethodId _setLatitude6899;
		public virtual void setLatitude(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setLatitude6899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setLatitude6899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLongitude6900;
		public virtual double getLongitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.location.Location._getLongitude6900);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getLongitude6900);
		}
		internal static global::MonoJavaBridge.MethodId _setLongitude6901;
		public virtual void setLongitude(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setLongitude6901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setLongitude6901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExtras6902;
		public virtual void setExtras(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setExtras6902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setExtras6902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAccuracy6903;
		public virtual void setAccuracy(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setAccuracy6903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setAccuracy6903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAccuracy6904;
		public virtual float getAccuracy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.Location._getAccuracy6904);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getAccuracy6904);
		}
		internal static global::MonoJavaBridge.MethodId _distanceBetween6905;
		public static void distanceBetween(double arg0, double arg1, double arg2, double arg3, float[] arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.location.Location.staticClass, global::android.location.Location._distanceBetween6905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _distanceTo6906;
		public virtual float distanceTo(android.location.Location arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.Location._distanceTo6906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._distanceTo6906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bearingTo6907;
		public virtual float bearingTo(android.location.Location arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.Location._bearingTo6907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._bearingTo6907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProvider6908;
		public virtual void setProvider(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setProvider6908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setProvider6908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasAltitude6909;
		public virtual bool hasAltitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Location._hasAltitude6909);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._hasAltitude6909);
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
		internal static global::MonoJavaBridge.MethodId _getAltitude6910;
		public virtual double getAltitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.location.Location._getAltitude6910);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getAltitude6910);
		}
		internal static global::MonoJavaBridge.MethodId _setAltitude6911;
		public virtual void setAltitude(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setAltitude6911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setAltitude6911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAltitude6912;
		public virtual void removeAltitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._removeAltitude6912);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._removeAltitude6912);
		}
		internal static global::MonoJavaBridge.MethodId _hasSpeed6913;
		public virtual bool hasSpeed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Location._hasSpeed6913);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._hasSpeed6913);
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
		internal static global::MonoJavaBridge.MethodId _getSpeed6914;
		public virtual float getSpeed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.Location._getSpeed6914);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getSpeed6914);
		}
		internal static global::MonoJavaBridge.MethodId _setSpeed6915;
		public virtual void setSpeed(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setSpeed6915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setSpeed6915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeSpeed6916;
		public virtual void removeSpeed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._removeSpeed6916);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._removeSpeed6916);
		}
		internal static global::MonoJavaBridge.MethodId _hasBearing6917;
		public virtual bool hasBearing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Location._hasBearing6917);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._hasBearing6917);
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
		internal static global::MonoJavaBridge.MethodId _getBearing6918;
		public virtual float getBearing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.Location._getBearing6918);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getBearing6918);
		}
		internal static global::MonoJavaBridge.MethodId _setBearing6919;
		public virtual void setBearing(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setBearing6919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setBearing6919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeBearing6920;
		public virtual void removeBearing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._removeBearing6920);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._removeBearing6920);
		}
		internal static global::MonoJavaBridge.MethodId _hasAccuracy6921;
		public virtual bool hasAccuracy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Location._hasAccuracy6921);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._hasAccuracy6921);
		}
		internal static global::MonoJavaBridge.MethodId _removeAccuracy6922;
		public virtual void removeAccuracy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._removeAccuracy6922);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._removeAccuracy6922);
		}
		internal static global::MonoJavaBridge.MethodId _Location6923;
		public Location(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Location.staticClass, global::android.location.Location._Location6923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Location6924;
		public Location(android.location.Location arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Location.staticClass, global::android.location.Location._Location6924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR6928;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.location.Location.staticClass, _CREATOR6928)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.Location.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/Location"));
			global::android.location.Location._toString6886 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "toString", "()Ljava/lang/String;");
			global::android.location.Location._set6887 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "set", "(Landroid/location/Location;)V");
			global::android.location.Location._reset6888 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "reset", "()V");
			global::android.location.Location._setTime6889 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setTime", "(J)V");
			global::android.location.Location._getTime6890 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getTime", "()J");
			global::android.location.Location._getProvider6891 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getProvider", "()Ljava/lang/String;");
			global::android.location.Location._convert6892 = @__env.GetStaticMethodIDNoThrow(global::android.location.Location.staticClass, "convert", "(Ljava/lang/String;)D");
			global::android.location.Location._convert6893 = @__env.GetStaticMethodIDNoThrow(global::android.location.Location.staticClass, "convert", "(DI)Ljava/lang/String;");
			global::android.location.Location._dump6894 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.location.Location._writeToParcel6895 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.location.Location._describeContents6896 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "describeContents", "()I");
			global::android.location.Location._getExtras6897 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.location.Location._getLatitude6898 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getLatitude", "()D");
			global::android.location.Location._setLatitude6899 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setLatitude", "(D)V");
			global::android.location.Location._getLongitude6900 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getLongitude", "()D");
			global::android.location.Location._setLongitude6901 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setLongitude", "(D)V");
			global::android.location.Location._setExtras6902 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setExtras", "(Landroid/os/Bundle;)V");
			global::android.location.Location._setAccuracy6903 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setAccuracy", "(F)V");
			global::android.location.Location._getAccuracy6904 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getAccuracy", "()F");
			global::android.location.Location._distanceBetween6905 = @__env.GetStaticMethodIDNoThrow(global::android.location.Location.staticClass, "distanceBetween", "(DDDD[F)V");
			global::android.location.Location._distanceTo6906 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "distanceTo", "(Landroid/location/Location;)F");
			global::android.location.Location._bearingTo6907 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "bearingTo", "(Landroid/location/Location;)F");
			global::android.location.Location._setProvider6908 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setProvider", "(Ljava/lang/String;)V");
			global::android.location.Location._hasAltitude6909 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "hasAltitude", "()Z");
			global::android.location.Location._getAltitude6910 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getAltitude", "()D");
			global::android.location.Location._setAltitude6911 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setAltitude", "(D)V");
			global::android.location.Location._removeAltitude6912 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "removeAltitude", "()V");
			global::android.location.Location._hasSpeed6913 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "hasSpeed", "()Z");
			global::android.location.Location._getSpeed6914 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getSpeed", "()F");
			global::android.location.Location._setSpeed6915 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setSpeed", "(F)V");
			global::android.location.Location._removeSpeed6916 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "removeSpeed", "()V");
			global::android.location.Location._hasBearing6917 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "hasBearing", "()Z");
			global::android.location.Location._getBearing6918 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getBearing", "()F");
			global::android.location.Location._setBearing6919 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setBearing", "(F)V");
			global::android.location.Location._removeBearing6920 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "removeBearing", "()V");
			global::android.location.Location._hasAccuracy6921 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "hasAccuracy", "()Z");
			global::android.location.Location._removeAccuracy6922 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "removeAccuracy", "()V");
			global::android.location.Location._Location6923 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.location.Location._Location6924 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "<init>", "(Landroid/location/Location;)V");
			global::android.location.Location._CREATOR6928 = @__env.GetStaticFieldIDNoThrow(global::android.location.Location.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
