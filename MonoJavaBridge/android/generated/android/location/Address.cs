namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Address : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Address(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString6795;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "toString", "()Ljava/lang/String;", ref global::android.location.Address._toString6795) as java.lang.String;
		}
		public new global::java.lang.String Locality
		{
			get
			{
				return getLocality();
			}
			set
			{
				setLocality(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocality6796;
		public virtual global::java.lang.String getLocality()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getLocality", "()Ljava/lang/String;", ref global::android.location.Address._getLocality6796) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel6797;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.location.Address._writeToParcel6797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents6798;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.Address.staticClass, "describeContents", "()I", ref global::android.location.Address._describeContents6798);
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
		internal static global::MonoJavaBridge.MethodId _getExtras6799;
		public virtual global::android.os.Bundle getExtras()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.location.Address.staticClass, "getExtras", "()Landroid/os/Bundle;", ref global::android.location.Address._getExtras6799) as android.os.Bundle;
		}
		public new global::java.util.Locale Locale
		{
			get
			{
				return getLocale();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocale6800;
		public virtual global::java.util.Locale getLocale()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Locale>(this, global::android.location.Address.staticClass, "getLocale", "()Ljava/util/Locale;", ref global::android.location.Address._getLocale6800) as java.util.Locale;
		}
		public new int MaxAddressLineIndex
		{
			get
			{
				return getMaxAddressLineIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAddressLineIndex6801;
		public virtual int getMaxAddressLineIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.Address.staticClass, "getMaxAddressLineIndex", "()I", ref global::android.location.Address._getMaxAddressLineIndex6801);
		}
		internal static global::MonoJavaBridge.MethodId _getAddressLine6802;
		public virtual global::java.lang.String getAddressLine(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getAddressLine", "(I)Ljava/lang/String;", ref global::android.location.Address._getAddressLine6802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setAddressLine6803;
		public virtual void setAddressLine(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setAddressLine", "(ILjava/lang/String;)V", ref global::android.location.Address._setAddressLine6803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String FeatureName
		{
			get
			{
				return getFeatureName();
			}
			set
			{
				setFeatureName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFeatureName6804;
		public virtual global::java.lang.String getFeatureName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getFeatureName", "()Ljava/lang/String;", ref global::android.location.Address._getFeatureName6804) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureName6805;
		public virtual void setFeatureName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setFeatureName", "(Ljava/lang/String;)V", ref global::android.location.Address._setFeatureName6805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String AdminArea
		{
			get
			{
				return getAdminArea();
			}
			set
			{
				setAdminArea(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAdminArea6806;
		public virtual global::java.lang.String getAdminArea()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getAdminArea", "()Ljava/lang/String;", ref global::android.location.Address._getAdminArea6806) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setAdminArea6807;
		public virtual void setAdminArea(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setAdminArea", "(Ljava/lang/String;)V", ref global::android.location.Address._setAdminArea6807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SubAdminArea
		{
			get
			{
				return getSubAdminArea();
			}
			set
			{
				setSubAdminArea(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubAdminArea6808;
		public virtual global::java.lang.String getSubAdminArea()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getSubAdminArea", "()Ljava/lang/String;", ref global::android.location.Address._getSubAdminArea6808) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSubAdminArea6809;
		public virtual void setSubAdminArea(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setSubAdminArea", "(Ljava/lang/String;)V", ref global::android.location.Address._setSubAdminArea6809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLocality6810;
		public virtual void setLocality(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setLocality", "(Ljava/lang/String;)V", ref global::android.location.Address._setLocality6810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SubLocality
		{
			get
			{
				return getSubLocality();
			}
			set
			{
				setSubLocality(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubLocality6811;
		public virtual global::java.lang.String getSubLocality()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getSubLocality", "()Ljava/lang/String;", ref global::android.location.Address._getSubLocality6811) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSubLocality6812;
		public virtual void setSubLocality(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setSubLocality", "(Ljava/lang/String;)V", ref global::android.location.Address._setSubLocality6812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Thoroughfare
		{
			get
			{
				return getThoroughfare();
			}
			set
			{
				setThoroughfare(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThoroughfare6813;
		public virtual global::java.lang.String getThoroughfare()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getThoroughfare", "()Ljava/lang/String;", ref global::android.location.Address._getThoroughfare6813) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setThoroughfare6814;
		public virtual void setThoroughfare(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setThoroughfare", "(Ljava/lang/String;)V", ref global::android.location.Address._setThoroughfare6814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SubThoroughfare
		{
			get
			{
				return getSubThoroughfare();
			}
			set
			{
				setSubThoroughfare(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubThoroughfare6815;
		public virtual global::java.lang.String getSubThoroughfare()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getSubThoroughfare", "()Ljava/lang/String;", ref global::android.location.Address._getSubThoroughfare6815) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSubThoroughfare6816;
		public virtual void setSubThoroughfare(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setSubThoroughfare", "(Ljava/lang/String;)V", ref global::android.location.Address._setSubThoroughfare6816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Premises
		{
			get
			{
				return getPremises();
			}
			set
			{
				setPremises(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPremises6817;
		public virtual global::java.lang.String getPremises()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getPremises", "()Ljava/lang/String;", ref global::android.location.Address._getPremises6817) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPremises6818;
		public virtual void setPremises(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setPremises", "(Ljava/lang/String;)V", ref global::android.location.Address._setPremises6818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String PostalCode
		{
			get
			{
				return getPostalCode();
			}
			set
			{
				setPostalCode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPostalCode6819;
		public virtual global::java.lang.String getPostalCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getPostalCode", "()Ljava/lang/String;", ref global::android.location.Address._getPostalCode6819) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPostalCode6820;
		public virtual void setPostalCode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setPostalCode", "(Ljava/lang/String;)V", ref global::android.location.Address._setPostalCode6820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String CountryCode
		{
			get
			{
				return getCountryCode();
			}
			set
			{
				setCountryCode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCountryCode6821;
		public virtual global::java.lang.String getCountryCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getCountryCode", "()Ljava/lang/String;", ref global::android.location.Address._getCountryCode6821) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setCountryCode6822;
		public virtual void setCountryCode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setCountryCode", "(Ljava/lang/String;)V", ref global::android.location.Address._setCountryCode6822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String CountryName
		{
			get
			{
				return getCountryName();
			}
			set
			{
				setCountryName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCountryName6823;
		public virtual global::java.lang.String getCountryName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getCountryName", "()Ljava/lang/String;", ref global::android.location.Address._getCountryName6823) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setCountryName6824;
		public virtual void setCountryName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setCountryName", "(Ljava/lang/String;)V", ref global::android.location.Address._setCountryName6824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasLatitude6825;
		public virtual bool hasLatitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Address.staticClass, "hasLatitude", "()Z", ref global::android.location.Address._hasLatitude6825);
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
		internal static global::MonoJavaBridge.MethodId _getLatitude6826;
		public virtual double getLatitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.location.Address.staticClass, "getLatitude", "()D", ref global::android.location.Address._getLatitude6826);
		}
		internal static global::MonoJavaBridge.MethodId _setLatitude6827;
		public virtual void setLatitude(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setLatitude", "(D)V", ref global::android.location.Address._setLatitude6827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearLatitude6828;
		public virtual void clearLatitude()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "clearLatitude", "()V", ref global::android.location.Address._clearLatitude6828);
		}
		internal static global::MonoJavaBridge.MethodId _hasLongitude6829;
		public virtual bool hasLongitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Address.staticClass, "hasLongitude", "()Z", ref global::android.location.Address._hasLongitude6829);
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
		internal static global::MonoJavaBridge.MethodId _getLongitude6830;
		public virtual double getLongitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.location.Address.staticClass, "getLongitude", "()D", ref global::android.location.Address._getLongitude6830);
		}
		internal static global::MonoJavaBridge.MethodId _setLongitude6831;
		public virtual void setLongitude(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setLongitude", "(D)V", ref global::android.location.Address._setLongitude6831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearLongitude6832;
		public virtual void clearLongitude()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "clearLongitude", "()V", ref global::android.location.Address._clearLongitude6832);
		}
		public new global::java.lang.String Phone
		{
			get
			{
				return getPhone();
			}
			set
			{
				setPhone(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPhone6833;
		public virtual global::java.lang.String getPhone()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getPhone", "()Ljava/lang/String;", ref global::android.location.Address._getPhone6833) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPhone6834;
		public virtual void setPhone(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setPhone", "(Ljava/lang/String;)V", ref global::android.location.Address._setPhone6834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Url
		{
			get
			{
				return getUrl();
			}
			set
			{
				setUrl(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrl6835;
		public virtual global::java.lang.String getUrl()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getUrl", "()Ljava/lang/String;", ref global::android.location.Address._getUrl6835) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setUrl6836;
		public virtual void setUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setUrl", "(Ljava/lang/String;)V", ref global::android.location.Address._setUrl6836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExtras6837;
		public virtual void setExtras(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setExtras", "(Landroid/os/Bundle;)V", ref global::android.location.Address._setExtras6837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Address6838;
		public Address(java.util.Locale arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.Address._Address6838.native == global::System.IntPtr.Zero)
				global::android.location.Address._Address6838 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Address.staticClass, global::android.location.Address._Address6838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR6839;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.location.Address.staticClass, _CREATOR6839)) as android.os.Parcelable_Creator;
			}
		}
		static Address()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.Address.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/Address"));
			global::android.location.Address._CREATOR6839 = @__env.GetStaticFieldIDNoThrow(global::android.location.Address.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
