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
		internal static global::MonoJavaBridge.MethodId _toString4728;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Location._toString4728)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._toString4728)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set4729;
		public virtual void set(android.location.Location arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._set4729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._set4729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset4730;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._reset4730);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._reset4730);
		}
		internal static global::MonoJavaBridge.MethodId _setTime4731;
		public virtual void setTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setTime4731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setTime4731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTime4732;
		public virtual long getTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.location.Location._getTime4732);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getTime4732);
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
		internal static global::MonoJavaBridge.MethodId _getProvider4733;
		public virtual global::java.lang.String getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Location._getProvider4733)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getProvider4733)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _convert4734;
		public static double convert(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(android.location.Location.staticClass, global::android.location.Location._convert4734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convert4735;
		public static global::java.lang.String convert(double arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.location.Location.staticClass, global::android.location.Location._convert4735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dump4736;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._dump4736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._dump4736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4737;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._writeToParcel4737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._writeToParcel4737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4738;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.Location._describeContents4738);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._describeContents4738);
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
		internal static global::MonoJavaBridge.MethodId _getExtras4739;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.location.Location._getExtras4739)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getExtras4739)) as android.os.Bundle;
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
		internal static global::MonoJavaBridge.MethodId _getLatitude4740;
		public virtual double getLatitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.location.Location._getLatitude4740);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getLatitude4740);
		}
		internal static global::MonoJavaBridge.MethodId _setLatitude4741;
		public virtual void setLatitude(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setLatitude4741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setLatitude4741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLongitude4742;
		public virtual double getLongitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.location.Location._getLongitude4742);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getLongitude4742);
		}
		internal static global::MonoJavaBridge.MethodId _setLongitude4743;
		public virtual void setLongitude(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setLongitude4743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setLongitude4743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExtras4744;
		public virtual void setExtras(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setExtras4744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setExtras4744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAccuracy4745;
		public virtual void setAccuracy(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setAccuracy4745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setAccuracy4745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAccuracy4746;
		public virtual float getAccuracy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.Location._getAccuracy4746);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getAccuracy4746);
		}
		internal static global::MonoJavaBridge.MethodId _distanceBetween4747;
		public static void distanceBetween(double arg0, double arg1, double arg2, double arg3, float[] arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.location.Location.staticClass, global::android.location.Location._distanceBetween4747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _distanceTo4748;
		public virtual float distanceTo(android.location.Location arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.Location._distanceTo4748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._distanceTo4748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bearingTo4749;
		public virtual float bearingTo(android.location.Location arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.Location._bearingTo4749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._bearingTo4749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProvider4750;
		public virtual void setProvider(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setProvider4750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setProvider4750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasAltitude4751;
		public virtual bool hasAltitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Location._hasAltitude4751);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._hasAltitude4751);
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
		internal static global::MonoJavaBridge.MethodId _getAltitude4752;
		public virtual double getAltitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.location.Location._getAltitude4752);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getAltitude4752);
		}
		internal static global::MonoJavaBridge.MethodId _setAltitude4753;
		public virtual void setAltitude(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setAltitude4753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setAltitude4753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAltitude4754;
		public virtual void removeAltitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._removeAltitude4754);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._removeAltitude4754);
		}
		internal static global::MonoJavaBridge.MethodId _hasSpeed4755;
		public virtual bool hasSpeed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Location._hasSpeed4755);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._hasSpeed4755);
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
		internal static global::MonoJavaBridge.MethodId _getSpeed4756;
		public virtual float getSpeed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.Location._getSpeed4756);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getSpeed4756);
		}
		internal static global::MonoJavaBridge.MethodId _setSpeed4757;
		public virtual void setSpeed(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setSpeed4757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setSpeed4757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeSpeed4758;
		public virtual void removeSpeed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._removeSpeed4758);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._removeSpeed4758);
		}
		internal static global::MonoJavaBridge.MethodId _hasBearing4759;
		public virtual bool hasBearing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Location._hasBearing4759);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._hasBearing4759);
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
		internal static global::MonoJavaBridge.MethodId _getBearing4760;
		public virtual float getBearing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.location.Location._getBearing4760);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._getBearing4760);
		}
		internal static global::MonoJavaBridge.MethodId _setBearing4761;
		public virtual void setBearing(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._setBearing4761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._setBearing4761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeBearing4762;
		public virtual void removeBearing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._removeBearing4762);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._removeBearing4762);
		}
		internal static global::MonoJavaBridge.MethodId _hasAccuracy4763;
		public virtual bool hasAccuracy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.location.Location._hasAccuracy4763);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._hasAccuracy4763);
		}
		internal static global::MonoJavaBridge.MethodId _removeAccuracy4764;
		public virtual void removeAccuracy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.location.Location._removeAccuracy4764);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.Location.staticClass, global::android.location.Location._removeAccuracy4764);
		}
		internal static global::MonoJavaBridge.MethodId _Location4765;
		public Location(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Location.staticClass, global::android.location.Location._Location4765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Location4766;
		public Location(android.location.Location arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Location.staticClass, global::android.location.Location._Location4766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR4767;
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
			global::android.location.Location.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/Location"));
			global::android.location.Location._toString4728 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "toString", "()Ljava/lang/String;");
			global::android.location.Location._set4729 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "set", "(Landroid/location/Location;)V");
			global::android.location.Location._reset4730 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "reset", "()V");
			global::android.location.Location._setTime4731 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setTime", "(J)V");
			global::android.location.Location._getTime4732 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getTime", "()J");
			global::android.location.Location._getProvider4733 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getProvider", "()Ljava/lang/String;");
			global::android.location.Location._convert4734 = @__env.GetStaticMethodIDNoThrow(global::android.location.Location.staticClass, "convert", "(Ljava/lang/String;)D");
			global::android.location.Location._convert4735 = @__env.GetStaticMethodIDNoThrow(global::android.location.Location.staticClass, "convert", "(DI)Ljava/lang/String;");
			global::android.location.Location._dump4736 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.location.Location._writeToParcel4737 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.location.Location._describeContents4738 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "describeContents", "()I");
			global::android.location.Location._getExtras4739 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.location.Location._getLatitude4740 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getLatitude", "()D");
			global::android.location.Location._setLatitude4741 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setLatitude", "(D)V");
			global::android.location.Location._getLongitude4742 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getLongitude", "()D");
			global::android.location.Location._setLongitude4743 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setLongitude", "(D)V");
			global::android.location.Location._setExtras4744 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setExtras", "(Landroid/os/Bundle;)V");
			global::android.location.Location._setAccuracy4745 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setAccuracy", "(F)V");
			global::android.location.Location._getAccuracy4746 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getAccuracy", "()F");
			global::android.location.Location._distanceBetween4747 = @__env.GetStaticMethodIDNoThrow(global::android.location.Location.staticClass, "distanceBetween", "(DDDD[F)V");
			global::android.location.Location._distanceTo4748 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "distanceTo", "(Landroid/location/Location;)F");
			global::android.location.Location._bearingTo4749 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "bearingTo", "(Landroid/location/Location;)F");
			global::android.location.Location._setProvider4750 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setProvider", "(Ljava/lang/String;)V");
			global::android.location.Location._hasAltitude4751 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "hasAltitude", "()Z");
			global::android.location.Location._getAltitude4752 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getAltitude", "()D");
			global::android.location.Location._setAltitude4753 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setAltitude", "(D)V");
			global::android.location.Location._removeAltitude4754 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "removeAltitude", "()V");
			global::android.location.Location._hasSpeed4755 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "hasSpeed", "()Z");
			global::android.location.Location._getSpeed4756 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getSpeed", "()F");
			global::android.location.Location._setSpeed4757 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setSpeed", "(F)V");
			global::android.location.Location._removeSpeed4758 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "removeSpeed", "()V");
			global::android.location.Location._hasBearing4759 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "hasBearing", "()Z");
			global::android.location.Location._getBearing4760 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "getBearing", "()F");
			global::android.location.Location._setBearing4761 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "setBearing", "(F)V");
			global::android.location.Location._removeBearing4762 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "removeBearing", "()V");
			global::android.location.Location._hasAccuracy4763 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "hasAccuracy", "()Z");
			global::android.location.Location._removeAccuracy4764 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "removeAccuracy", "()V");
			global::android.location.Location._Location4765 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.location.Location._Location4766 = @__env.GetMethodIDNoThrow(global::android.location.Location.staticClass, "<init>", "(Landroid/location/Location;)V");
		}
	}
}
